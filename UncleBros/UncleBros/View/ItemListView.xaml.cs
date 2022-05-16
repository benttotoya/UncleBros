using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using UncleBros.Model;

namespace UncleBros.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemListView : ContentView
    {
        List<UserInfo> users = new List<UserInfo>();

        public ItemListView()
        {
            InitializeComponent();
            InitData();
            InitProperty();
            InitMemberText();
        }

        private void InitMemberText()
        {
            pID.Text = users[0].ID;
            pName.Text = users[0].Name;
            pAge.Text = users[0].Age;
            pSex.Text = users[0].Sex;
            pAddr.Text = users[0].Address;
        }

        private void InitProperty()
        {
            pID.BackgroundColor = Color.Gray;
            pName.BackgroundColor = Color.Ivory;
            pAge.BackgroundColor = Color.Ivory;
            pSex.BackgroundColor = Color.Ivory;
            pAddr.BackgroundColor = Color.Ivory;
        }

        private void InitData()
        {
            users.Add(new UserInfo("01", "박동흠", "43", "남", "제주특별자치도 제주시 화삼로 107 부영아파트 605동 101호"));
            users.Add(new UserInfo("02", "김우미", "42", "여", "제주특별자치도 제주시 화삼로 107 부영아파트 605동 101호"));
            users.Add(new UserInfo("03", "박윤아", "11", "여", "제주특별자치도 제주시 화삼로 107 부영아파트 605동 101호"));
            users.Add(new UserInfo("04", "박재덕", "69", "남", "서울특별시 강서구 방화2동 615-23"));
            users.Add(new UserInfo("05", "설경이", "66", "여", "서울특별시 강서구 방화2동 615-23"));
        }


        public string ID
        {
            get { return pID.Text; }
            set { pID.Text = value; }
        }

        public string Name
        {
            get { return pName.Text; }
            set { pName.Text = value; }
        }

        public string Age
        {
            get { return pAge.Text; }
            set { pAge.Text = value; }
        }

        public string Sex
        {
            get { return pSex.Text; }
            set { pSex.Text = value; }
        }

        public string Addr
        {
            get { return pAddr.Text; }
            set { pAddr.Text = value; }
        }
    }
}