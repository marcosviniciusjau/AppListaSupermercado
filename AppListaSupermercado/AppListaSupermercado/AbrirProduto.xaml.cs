using AppListaSupermercado.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppListaSupermercado
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AbrirProduto : ContentPage
    {
        public AbrirProduto()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Produto p = new Produto
            {
                Id = Convert.ToInt16(lbl_id.Text),
                NomeProduto = txt_descricao.Text,
                Quantidade = txt_quantidade.Text,
                PrecoEstimado = txt_preco_estimado.Text,
                PrecoPago = txt_preco_pago.Text,
            };

            await App.Database.Update(p);

            await DisplayAlert("Sucesso", "Atualizado no SQLite", "OK");

            await Navigation.PushAsync(new ListaProdutos());
        }
    }
}