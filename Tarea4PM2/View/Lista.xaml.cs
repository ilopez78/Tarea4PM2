﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea4PM2.Model;
using Tarea4PM2.Controller;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;

namespace Tarea4PM2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lista : ContentPage
    {
        Plugin.Media.Abstractions.MediaFile FileFoto = null;

        public Lista()
        {
            InitializeComponent();
            BindingContext = new ListViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            var listaImagenes = await App.BD.ListaImagen();
            ListView.ItemsSource = listaImagenes;

        }

        private async void ListaImagen_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var img = (Imagen)e.Item;
            var secondPage = new MostrarImagen();
            secondPage.BindingContext = img;
            await Navigation.PushAsync(secondPage);
        }

    }
}