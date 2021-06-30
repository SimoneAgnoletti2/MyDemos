using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demos.Model
{
    public class DBData
    {
        public bool CreateTableProgramma()
        {
            try
            {
                SQLiteConnection Database = DependencyService.Get<IDatabaseConnection>().DbConnection();

                Database.CreateTable(typeof(Programma));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool TableExist(String tableName)
        {
            try
            {
                SQLiteConnection Database = DependencyService.Get<IDatabaseConnection>().DbConnection();
                var tableInfo = Database.GetTableInfo(tableName);
                if (tableInfo.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Programma> ExctractProgramma()
        {
            try
            {
                SQLiteConnection Database = DependencyService.Get<IDatabaseConnection>().DbConnection();
                List<Programma> v = Database.Query<Programma>("SELECT * FROM Programma ORDER BY Percorso");
                return v;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Programma ExctractProgrammaWithID(int id)
        {
            try
            {
                SQLiteConnection Database = DependencyService.Get<IDatabaseConnection>().DbConnection();
                List<Programma> v = Database.Query<Programma>("SELECT * FROM Programma WHERE ID =" + id);
                return v[0];
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Programma ExctractProgrammaWithName(string percorso)
        {
            try
            {
                SQLiteConnection Database = DependencyService.Get<IDatabaseConnection>().DbConnection();
                List<Programma> v = Database.Query<Programma>("SELECT * FROM Programma WHERE Percorso ='" + percorso + "'");
                return v[0];
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Programma> ExctractProgrammaWithOrder(string ordinamento)
        {
            try
            {
                SQLiteConnection Database = DependencyService.Get<IDatabaseConnection>().DbConnection();
                List<Programma> v = Database.Query<Programma>("SELECT * FROM Programma ORDER BY " + ordinamento);
                return v;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Programma> ExctractProgrammaWithSearch(string cerca)
        {
            try
            {
                SQLiteConnection Database = DependencyService.Get<IDatabaseConnection>().DbConnection();
                List<Programma> v = Database.Query<Programma>("SELECT * FROM Programma WHERE Percorso LIKE '%" + cerca + "%' ORDER BY Percorso");
                return v;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public void DropTable()
        {
            try
            {
                SQLiteConnection Database = DependencyService.Get<IDatabaseConnection>().DbConnection();
                List<Programma> v = Database.Query<Programma>("DROP TABLE Programma");

            }
            catch (Exception ex)
            {
            }
        }



        public bool InsProgramma(Programma p)
        {
            try
            {
                SQLiteConnection Database = DependencyService.Get<IDatabaseConnection>().DbConnection();
                int numero = Database.Insert(p);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }





        //MODALITà ASINCRONA

        public async Task<bool> CreateTableProgrammaAsync()
        {
            try
            {
                SQLiteAsyncConnection Database = DependencyService.Get<IDatabaseConnectionAsync>().DbConnection();

                await Database.CreateTableAsync(typeof(Programma));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> TableExistAsync(String tableName)
        {
            try
            {
                SQLiteAsyncConnection Database = DependencyService.Get<IDatabaseConnectionAsync>().DbConnection();
                var tableInfo = await Database.GetTableInfoAsync(tableName);
                if (tableInfo.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<List<Programma>> ExctractProgrammaAsync()
        {
            try
            {
                SQLiteAsyncConnection Database = DependencyService.Get<IDatabaseConnectionAsync>().DbConnection();
                List<Programma> v = await Database.QueryAsync<Programma>("SELECT * FROM Programma ORDER BY Percorso");
                return v;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<Programma> ExctractProgrammaWithIDAsync(int id)
        {
            try
            {
                SQLiteAsyncConnection Database = DependencyService.Get<IDatabaseConnectionAsync>().DbConnection();
                List<Programma> v = await Database.QueryAsync<Programma>("SELECT * FROM Programma WHERE ID=" + id);
                return v[0];
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<Programma> ExctractProgrammaWithNameAsync(string percorso)
        {
            try
            {
                SQLiteAsyncConnection Database = DependencyService.Get<IDatabaseConnectionAsync>().DbConnection();
                List<Programma> v = await Database.QueryAsync<Programma>("SELECT * FROM Programma WHERE Percorso=" + percorso);
                return v[0];
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<List<Programma>> ExctractProgrammaWithOrderAsync(string ordinamento)
        {
            try
            {
                SQLiteAsyncConnection Database = DependencyService.Get<IDatabaseConnectionAsync>().DbConnection();
                List<Programma> v = await Database.QueryAsync<Programma>("SELECT * FROM Programma ORDER BY " + ordinamento);
                return v;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<List<Programma>> ExctractProgrammaWithSearchAsync(string search)
        {
            try
            {
                SQLiteAsyncConnection Database = DependencyService.Get<IDatabaseConnectionAsync>().DbConnection();
                List<Programma> v = await Database.QueryAsync<Programma>("SELECT * FROM Programma WHERE Percorso = '" + search + "' ORDER BY Percorso ");
                return v;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async void DropTableAsync()
        {
            try
            {
                SQLiteAsyncConnection Database = DependencyService.Get<IDatabaseConnectionAsync>().DbConnection();
                List<Programma> v = await Database.QueryAsync<Programma>("DROP TABLE Programma");

            }
            catch (Exception ex)
            {
            }
        }

        public async Task<bool> InsProgrammaAsync(Programma p)
        {
            try
            {
                SQLiteAsyncConnection Database = DependencyService.Get<IDatabaseConnectionAsync>().DbConnection();
                int numero = await Database.InsertAsync(p);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
