using Infrastructure;
using System;
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
