using Infrastructure;
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

namespace LocalizationPoC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnSave(object sender, RoutedEventArgs e)
        {
             //var x = Translation.GetTranslatedText("Save");
            //MessageBox.Show(String.Format(Properties.Resources.ButtonClick,Properties.Resources.Save));
            MessageBox.Show(String.Format(Properties.Resources.ButtonClick, Translation.GetTranslatedText("Save")));
        }
        private void OnSubmit(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(String.Format(Properties.Resources.ButtonClick, Translation.GetTranslatedText("Submit")));
        }
        private void OnClear(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(String.Format(Properties.Resources.ButtonClick, Translation.GetTranslatedText("Clear")));
        }
    }
}
