using AppListaSupermercado.Model;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppListaSupermercado.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NovoProduto : ContentPage
    {
        public NovoProduto()
        {
            InitializeComponent();
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            try
            {
                Produto p = new Produto
                {
                    NomeProduto= txt_descricao.Text,
                    Quantidade = Convert.ToDouble(txt_quantidade.Text),
                    PrecoPago = Convert.ToDouble(txt_preco_pago.Text),
                };


                await App.Database.Insert(p);


                
                await DisplayAlert("Sucesso!", "Produto Cadastrado", "OK");


                await Navigation.PushAsync(new ListaProdutos());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}