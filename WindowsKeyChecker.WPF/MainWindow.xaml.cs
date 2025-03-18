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

        private async void BtnCheckActivation_Click(object sender, RoutedEventArgs e)
        {
            await ExecuteCommandAsync("/dli");
        }

        private async void BtnDetailedInfo_Click(object sender, RoutedEventArgs e)
        {
            await ExecuteCommandAsync("/dlv");
        }

        private async void BtnExpiration_Click(object sender, RoutedEventArgs e)
        {
            await ExecuteCommandAsync("/xpr");
        }

        private async Task ExecuteCommandAsync(string command)
        {
            SetUIState(true, "Procesando...");

            await Task.Delay(100); 

            string result = await Task.Run(() => CommandExecutor.RunCommand(command));

            txtOutput.Text = result;

            SetUIState(false, "");
        }

        private void SetUIState(bool isProcessing, string statusMessage)
        {
            txtStatus.Text = statusMessage;
            txtStatus.Visibility = string.IsNullOrEmpty(statusMessage) ? Visibility.Collapsed : Visibility.Visible;

            BtnCheckActivation.IsEnabled = !isProcessing;
            BtnDetailedInfo.IsEnabled = !isProcessing;
            BtnExpiration.IsEnabled = !isProcessing;
        }

        private void UpdateResult(string result)
        {
            txtOutput.Text = result;
            AdjustWindowSize();
        }

        private void txtOutput_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            txtOutput.Height = Double.NaN;
            this.SizeToContent = SizeToContent.Height;
        }

        private void AdjustWindowSize()
        {
            this.Height = Double.NaN;
            this.SizeToContent = SizeToContent.Height;
        }
    }
}
