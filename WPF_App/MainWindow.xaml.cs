using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
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
using HtmlAgilityPack;

namespace WPF_App
{
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
            timer.Tick += new EventHandler(setValues);
            timer.Interval = new TimeSpan(0,0,1);
            timer.Start();
        }
        public void setValues(object sender, EventArgs e)
        {
            btcValue.Text = "$" + new Crypto().showBTC();
            ethValue.Text = "$" + new Crypto().showETH();
            xrpValue.Text = "$" + new Crypto().showXRP();
            bnbValue.Text = "$" + new Crypto().showBNB();
            solanaValue.Text = "$" + new Crypto().showSOL();
            dogeValue.Text = "$" + new Crypto().showDOGE();
        }
    }
    public class Crypto
    {
        public string showBTC()
        {
            return new HtmlWeb().Load("https://www.coindesk.com/price/bitcoin/").QuerySelector(".jvRAOp").InnerText;
        }
        public string showETH()
        {
            return new HtmlWeb().Load("https://www.coindesk.com/price/ethereum/").QuerySelector(".jvRAOp").InnerText;
        }
        public string showXRP()
        {
            return new HtmlWeb().Load("https://www.coindesk.com/price/xrp/").QuerySelector(".jvRAOp").InnerText;
        }
        public string showBNB()
        {
            return new HtmlWeb().Load("https://www.coindesk.com/price/binance-coin/").QuerySelector(".jvRAOp").InnerText;
        }
        public string showSOL()
        {
            return new HtmlWeb().Load("https://www.coindesk.com/price/solana/").QuerySelector(".jvRAOp").InnerText;
        }
        public string showDOGE()
        {
            return new HtmlWeb().Load("https://www.coindesk.com/price/dogecoin/").QuerySelector(".jvRAOp").InnerText;
        }
    }
}
