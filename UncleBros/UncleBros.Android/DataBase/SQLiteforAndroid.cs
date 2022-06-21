using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UncleBros.DataBase;
using UncleBros.Droid.DataBase;
using Xamarin.Forms;

// 공유코드에 생성한 인터페이스(ISQLite)를 상속하여 구현한 클래스를 DependencyService에 등록해야 Xamarin.Forms가 런타임에 구현된 플랫폼(클래스)을 찾을 수 있다.
[assembly: Dependency(typeof(SQLiteforAndroid))]
namespace UncleBros.Droid.DataBase
{
    public class SQLiteforAndroid : ISQLite
    {
        public SQLiteAsyncConnection GetConnection(string strDBName)
        {
            var dbFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(dbFolder, strDBName);
            return new SQLiteAsyncConnection(path);
        }
    }
}