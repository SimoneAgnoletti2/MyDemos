using SQLite;
using Xamarin.Forms;
using LocalDataAccess.UWP;
using Windows.Storage;
using System.IO;
using Demos;

[assembly: Dependency(typeof(DatabaseConnection_UWP))]
namespace LocalDataAccess.UWP
{
    public class DatabaseConnection_UWPAsync : IDatabaseConnectionAsync
    {
        public SQLiteAsyncConnection DbConnection()
        {
            var dbName = "MYDB.db3";
            var path = Path.Combine(ApplicationData.
              Current.LocalFolder.Path, dbName);
            return new SQLiteAsyncConnection(path);
        }
    }
}