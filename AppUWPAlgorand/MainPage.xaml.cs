using Algorand;
using Algorand.V2;
using Algorand.Client;
using Algorand.V2.Model;
using Account = Algorand.Account;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Text;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AppUWPAlgorand
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.ViewModel = new AccountViewModel();
        }

        //VYFF3MXAXWGHNIAEUVINZZHEW2MH5HKTXEACXUTZ3HHADIBPT5ATJGR6K4
        //stock fit fresh spawn jump weapon chaos flower choice cycle rubber media repeat animal news rent become broom mushroom glance news high hunt absent click
        public AccountViewModel ViewModel;
        public class AccountViewModel
        {
            public AccountViewModel()
            {
                Account account = new Account();
                var address = account.Address.ToString();
                var key = account.ToMnemonic();
                this.AccountAddress = address;
                this.MnemonicKey = key;
            }
            public string AccountAddress;
            public string MnemonicKey;
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string ALGOD_API_ADDR = "https://testnet-algorand.api.purestake.io/ps2";
            string ALGOD_API_TOKEN = "B3SU4KcVKi94Jap2VXkK83xx38bsv95K5UZm2lab";
            AlgodApi algodApiInstance = new AlgodApi(ALGOD_API_ADDR, ALGOD_API_TOKEN);
            var accountInfo = algodApiInstance.AccountInformation("VYFF3MXAXWGHNIAEUVINZZHEW2MH5HKTXEACXUTZ3HHADIBPT5ATJGR6K4");
            var dialog = new MessageDialog(string.Format("Account Balance: " + accountInfo.Amount + " MicroAlgos"));
            await dialog.ShowAsync();
        }

        private async void Button_Click_Dan(object sender, RoutedEventArgs e)
        {            
            var dialog = new MessageDialog(string.Format("Hi Dan!"));
            await dialog.ShowAsync();
        }
    }
}
