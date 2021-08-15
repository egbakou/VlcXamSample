﻿using Xamarin.Forms;

namespace VlcXamSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnAppearing(object sender, System.EventArgs e)
        {
            base.OnAppearing();
            ((MainViewModel)BindingContext).OnAppearing();
        }

        void OnDisappearing(object sender, System.EventArgs e)
        {
            base.OnDisappearing();
            ((MainViewModel)BindingContext).OnDisappearing();
        }

    }
}
