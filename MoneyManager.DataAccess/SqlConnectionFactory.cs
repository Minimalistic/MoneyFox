﻿using System.IO;
using Windows.Storage;
using SQLite.Net;
using SQLite.Net.Interop;

namespace MoneyManager.DataAccess
{
    internal class SqlConnectionFactory
    {
        private static readonly string _dbPath = Path.Combine(
            Path.Combine(ApplicationData.Current.LocalFolder.Path, "moneyfox.sqlite"));


        public static SQLiteConnection GetSqlConnection()
        {
            return GetSqlConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT());
        }

        public static SQLiteConnection GetSqlConnection(ISQLitePlatform sqlitePlatform)
        {
            return new SQLiteConnection(sqlitePlatform, _dbPath);
        }
    }
}