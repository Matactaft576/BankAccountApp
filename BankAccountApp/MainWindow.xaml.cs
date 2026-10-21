using BankAccountApp.Classes;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BankAccountApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Account account;

        public MainWindow()
        {
            InitializeComponent();

            account = new Account("Jan Novák", 1000);

            ShowAccount();
        }

        private void ShowAccount()
        {
            txtOwner.Text = account.Owner;
            txtBalance.Text = $"Zůstatek: {account.Balance} Kč";
        }

        private void btnDeposit_Click(object sender, RoutedEventArgs e)
        {
            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                txtStatus.Text = "Zadejte platnou částku.";
                return;
            }

            bool result = account.Deposit(amount);

            if (result)
            {
                txtStatus.Text = "Vklad byl proveden.";
                txtAmount.Clear();

                ShowAccount();
            }
            else
            {
                txtStatus.Text = "Částka musí být větší než 0.";
            }
        }
    }
}