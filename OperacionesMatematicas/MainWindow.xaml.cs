using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OperacionesMatematicas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Datos_Default();
        }

        private void Datos_Default()
        {
            Operando1_textBox.Text = "0";
            Operando2_textBox.Text = "0";
            Suma_radioButton.IsChecked = true;
        }       

        private void Operaciones_Actualizacion(object sender, RoutedEventArgs e)
        {
            if (Suma_radioButton.IsChecked == true)
                Resultado_textBox.Text = (double.Parse(Operando1_textBox.Text) + double.Parse(Operando2_textBox.Text)).ToString();
            else if (Resta_radioButton.IsChecked == true)
                Resultado_textBox.Text = (double.Parse(Operando1_textBox.Text) - double.Parse(Operando2_textBox.Text)).ToString();
            else if (Multiplicacion_radioButton.IsChecked == true)
                Resultado_textBox.Text = (double.Parse(Operando1_textBox.Text) * double.Parse(Operando2_textBox.Text)).ToString();
            else if (Division_radioButton.IsChecked == true && double.Parse(Operando2_textBox.Text) != 0)
                Resultado_textBox.Text = (double.Parse(Operando1_textBox.Text) / double.Parse(Operando2_textBox.Text)).ToString();
            else if (Division_radioButton.IsChecked == true && double.Parse(Operando2_textBox.Text) == 0)
                Resultado_textBox.Text = "Error";
        }

        private void LimpiarButton_Click(object sender, RoutedEventArgs e)
        {
            Datos_Default();
        }
    }
}
