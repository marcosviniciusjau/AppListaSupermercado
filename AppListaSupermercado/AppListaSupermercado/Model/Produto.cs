
using SQLite;

namespace AppListaSupermercado.Model
{
    public class Produto
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string NomeProduto { get; set; }
        public double Quantidade { get; set; }
        public double PrecoPago { get; set; }
    }
}
