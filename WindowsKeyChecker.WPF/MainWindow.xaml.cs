using System;
using System.Windows;
using WindowsKeyChecker.WPF.Utils;

namespace WindowsKeyChecker.WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCheckActivation_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text = CommandExecutor.RunCommand("/dli");
        }

        private void BtnDetailedInfo_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text = CommandExecutor.RunCommand("/dlv");
        }

        private void BtnExpiration_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text = CommandExecutor.RunCommand("/xpr");
        }
    }
}
