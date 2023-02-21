using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio1_1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resultados : ContentPage
    {
        public Resultados(Double resutl)
        {
            InitializeComponent();
            resultado.Text = " Resultado " + resutl.ToString();
        }
    }
}