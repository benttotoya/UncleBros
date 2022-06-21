using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace UncleBros.DataBase
{
    public interface ISQLite
    {
        SQLiteAsyncConnection GetConnection(string strDBName);
    }
}
