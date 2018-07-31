using Infrastructure;
using System;
using System.Threading.Tasks;
using System.Windows;

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

        private async void OnSave(object sender, RoutedEventArgs e)
        {
            //Demo of resource localization working for background tasks as well
            var getTranslatedText = await Task.Run(() =>
                  //MessageBox.Show(String.Format(Properties.Resources.ButtonClick,Properties.Resources.Save));
                  String.Format(Properties.Resources.ButtonClick, Translation.GetTranslatedText("Save"))
            );
            MessageBox.Show(getTranslatedText);
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
