using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FactorialApp
{

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            double n = -1;
            double.TryParse(TextInput.Text, out n);
            if (n == 0)
                result.Text = $"Результат: {n}";

            if(n < 0)
            {
                result.Text = "Введите положительное число";
                return;
            }

            double fact = 1;

            for (int i = 1; i <= n; i++)
            {
                fact = fact * (double)i;
            }

            result.Text = $"результат: {fact}";
        }
    }
}
