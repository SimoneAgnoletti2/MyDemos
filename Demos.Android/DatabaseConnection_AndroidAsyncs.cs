using SQLite;
using LocalDataAccess.Droid;
using System.IO;
using Demos;

[assembly: Xamarin.Forms.Dependency(typeof(DatabaseConnection_Android))]
namespace LocalDataAccess.Droid
{
    public class DatabaseConnection_AndroidAsync : IDatabaseConnectionAsync
    {
        public SQLiteAsyncConnection DbConnection()
        {
            var dbName = "MYDB.db3";
            var path = Path.Combine(System.Environment.
              GetFolderPath(System.Environment.
              SpecialFolder.Personal), dbName);
            return new SQLiteAsyncConnection(path);
        }


    }
}