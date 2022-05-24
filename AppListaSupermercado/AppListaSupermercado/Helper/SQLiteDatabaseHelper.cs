using System;
using System.Collections.Generic;
using System.Text;

using SQLite;
using AppListaSupermercado.Model;
using System.Threading.Tasks;
namespace AppListaSupermercado.Helper
{
    public class SQLiteDatabaseHelper
    {
        readonly SQLiteAsyncConnection _connection;

        public SQLiteDatabaseHelper(string path)
        {
            _connection = new SQLiteAsyncConnection(path);
            _connection.CreateTableAsync<Produto>().Wait();
        }
        public Task<int> save(Produto p)
        {
            return _connection.InsertAsync(p);
        }

        public void getAllRows()
        {
            return _connection.Table<Produto>().ToListAsync();
        }

        public Task<int> delete(int id)
        {
            return _connection.Table<Produto>().DeleteAsync(i => i.Id == id);
        }

        public Task<List<Produto>> Update (Produto p)
        {
            string sql = "UPDATE produto SET " +
                                    "NomeProduto=?, Quantidade=?, PrecoEstimado=?, PrecoPago=? " +
                                    "WHERE Id=?";

            return _connection.QueryAsync<Produto>(sql,
                p.NomeProduto, p.Quantidade, p.PrecoEstimado, p.PrecoPago, p.Id);
        }

        public Task<List<Produto> Search(string q)
        {
            string sql = "SELECT * FROM produto WHERE Descricao LIKE '%" + q + "%'";

            return _connection.QueryAsync<Produto>(sql);
        }
    }
}
