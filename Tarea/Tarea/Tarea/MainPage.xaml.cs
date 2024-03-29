﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

        }



        async void Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Entry_user.Text) || string.IsNullOrEmpty(Entry_password.Text))
            {
                await DisplayAlert("Error ", "Faltan Datos", "Ok");


            }
            else
            {
                await DisplayAlert("Bienvenido", $"Hola! {Entry_user.Text}", "Ok");
            }


        }

     }
}
