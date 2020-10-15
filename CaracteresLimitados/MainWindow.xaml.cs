
using System.Windows;


namespace CaracteresLimitados
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void limitadoTextBox_TextChanged(object sender, RoutedEventArgs e)
        {
            contadorLetrasTextBlock.Text = limitadoTextBox.Text.Length + "/140";

            if(limitadoTextBox.Text.Length == 140)
            {
                limitadoTextBox.IsReadOnly=true;
            }
        }
    }
}
