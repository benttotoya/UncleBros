using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UncleBros.DataBase;
using UncleBros.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UncleBros.Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SQLiteforTodoPage : ContentPage
    {
        SQLiteAsyncConnection conn;
        ObservableCollection<Todo> todos;

        public SQLiteforTodoPage()
        {
            InitializeComponent();
            conn = DependencyService.Get<ISQLite>().GetConnection("MySQLite.db");
        }

        public ObservableCollection<Todo> Todos
        {
            get
            {
                return todos;
            }
            set
            {
                todos = value;
            }
        }

        protected override async void OnAppearing()
        {
            // DB에서 가져와 ObservableCollection에 추가
            await conn.CreateTableAsync<Todo>();

            List<Todo> tds = await conn.Table<Todo>().ToListAsync();
            Todos = new ObservableCollection<Todo>(tds);
            todoListView.ItemsSource = Todos;

            base.OnAppearing();
        }

        private async void OnTodoInsertButton_Clicked(object sender, EventArgs e)
        {
            var id = (sender as Button).Id;

            if (entryTodo.Text == null)
            {
                return;
            }

            if (id == btnSave.Id && entryTodo.Text.Length > 1)
            {
                Todo todo = new Todo
                {
                    RecordTime = DateTime.Now,
                    Title = entryTodo.Text.ToString(),
                };

                // DB에 추가
                int result = await conn.InsertAsync(todo);

                if (result == 1)
                {
                    await DisplayAlert("Insert", "Data Inserted.", "Confirm");
                }

                // 화면 갱신
                OnAppearing();

                // 입력값 초기화
                entryTodo.Text = String.Empty;
            }
        }

        private async void OnTodoModifyButton_Clicked(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            Todo todo = (Todo)btn.BindingContext;
            todo.RecordTime = DateTime.Now;

            // DB에 업데이트
            int result = await conn.UpdateAsync(todo);
            if (result == 1)
            {
                // Alert
                await DisplayAlert("Modify", "Data Changed.", "Confirm");

                // 화면 갱신
                OnAppearing();
            }
        }

        private async void OnTodoDeleteButton_Clicked(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Todo todo = (Todo)btn.BindingContext;

            Task<bool> resultYN = DisplayAlert("Delete", "Delete?", "Yes", "No");

            if (await resultYN)
            {
                int result = await conn.DeleteAsync(todo);

                if (result == 1)
                {
                    // Alert
                    await DisplayAlert("Delete", "Data Deleted.", "Confirm");

                    // 화면 갱신
                    OnAppearing();
                }
            }
        }
    }
}