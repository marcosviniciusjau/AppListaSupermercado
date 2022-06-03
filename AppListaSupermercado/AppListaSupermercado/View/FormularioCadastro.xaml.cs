using AppListaSupermercado.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppListaSupermercado.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FormularioCadastro : ContentPage
    {
        public FormularioCadastro()
        {
            InitializeComponent();
           
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Produto p = new Produto
            {
                NomeProduto = txt_descricao.Text,
                Quantidade = Convert.ToDouble(txt_quantidade.Text),

                PrecoEstimado = Convert.ToDouble(txt_preco_estimado.Text),
                PrecoPago = Convert.ToDouble(txt_preco_pago.Text),
            };

            await App.Database.Update(p);

            await DisplayAlert("Sucesso", "Atualizado no SQLite", "OK");

            await Navigation.PushAsync(new ListaProdutos());
        }
    }
}