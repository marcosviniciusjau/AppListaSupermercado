using AppListaSupermercado.Model;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppListaSupermercado.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditarProduto : ContentPage
    {
        public EditarProduto()
        {
            InitializeComponent();
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            try
            {
                Produto produto_anexado = BindingContext as Produto;


                Produto p = new Produto
                {
                    Id = produto_anexado.Id,
                    NomeProduto = txt_descricao.Text,
                    Quantidade = Convert.ToDouble(txt_quantidade.Text),
                    PrecoPago = Convert.ToDouble(txt_preco_pago.Text),
                };

               
                await App.Database.Update(p);

                await DisplayAlert("Sucesso!", "Produto Editado", "OK");

                await Navigation.PushAsync(new ListaProdutos());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}