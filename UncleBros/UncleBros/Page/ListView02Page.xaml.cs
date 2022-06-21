using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UncleBros.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UncleBros.Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListView02Page : ContentPage
    {
        /*
        int studentId = 0;
        string[] arrName = new string[] {"Kim", "Lee", "Park", "Choi", "Kang", "Ko", "Bu"};
        string[] arrMajor = new string[] {"Korean", "Japanese", "Chinese", "English", "Computer", "Science" };
        char[] arrGender = new char[] {'M', 'W' };
        string[] arrGrade = new string[] {"A+", "A", "B+", "B", "C+", "C", "D+", "D", "F"};
        int[] arrAge = new int[] { 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30};
        */


        public ListView02Page()
        {
            InitializeComponent();

            /*
            ObservableCollection<Student> students = new ObservableCollection<Student>();

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                Random random = new Random();
                students.Add(new Student(
                    ++studentId,
                    arrName[new Random().Next(0, arrName.Length - 1)],
                    arrMajor[new Random().Next(0, arrMajor.Length - 1)],
                    arrGender[new Random().Next(0, arrGender.Length - 1)],
                    arrGrade[new Random().Next(0, arrGrade.Length - 1)],
                    arrAge[new Random().Next(0, arrAge.Length - 1)]
                    ));
                
                return true;
            });

            listView01.ItemsSource = students;
            */
        }

        private void listView01_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

        private void listView01_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}