﻿using AppListaSupermercado.Model;
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

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaProdutos());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}