using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio1_1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async  void btnresta_Clicked(object sender, EventArgs e)
        {
            var numberOne = Double.Parse(numerouno.Text);
            var numberTwo = Double.Parse(numerodos.Text);
            var result = numberOne - numberTwo;
            await Navigation.PushAsync(new Views.Resultados(result));
        }

        private async void btnsuma_Clicked(object sender, EventArgs e)
        {
            var numberOne = Double.Parse(numerouno.Text);
            var numberTwo = Double.Parse(numerodos.Text);
            var result = numberOne + numberTwo;
            await Navigation.PushAsync(new Views.Resultados(result));
        }

        private async void btnmultiplicacion_Clicked(object sender, EventArgs e)
        {
            var numberOne = Double.Parse(numerouno.Text);
            var numberTwo = Double.Parse(numerodos.Text);
            var result = numberOne * numberTwo;
            await Navigation.PushAsync(new Views.Resultados(result));
        }

        private async  void btndivicion_Clicked(object sender, EventArgs e)
        {
            var numberOne = Double.Parse(numerouno.Text);
            var numberTwo = Double.Parse(numerodos.Text);
            var result = numberOne / numberTwo;
            await Navigation.PushAsync(new Views.Resultados(result));
        }
    }
}
