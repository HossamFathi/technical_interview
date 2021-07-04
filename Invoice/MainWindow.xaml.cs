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
using Invoice.Data;

namespace Invoice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private invoice invoice;
        public MainWindow()
        {
            InitializeComponent();
            InitializeStaticData();
        }
        private void InitializeStaticData()
        {
            invoice = new invoice(); //  get data 
            // initial data 
       
            BranshNameLbl.Content = invoice.BranchName;
            DateLbl.Content = invoice.Date.ToString();
            foreach (var item in invoice.Items)
            {
                InvoiceItemGrid.Items.Add(item);

            }
            


        }
        private void PrintBtn_Click(object sender, RoutedEventArgs e)
        {
            invoice.CustomerName = CustomerNameTxt.Text;
            Recite recite = new Recite(invoice);
            recite.Show();
        }
    }
}
