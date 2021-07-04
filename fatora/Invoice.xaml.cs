using fatora.Data;
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

namespace fatora
{
    /// <summary>
    /// Interaction logic for InvoiceWindow.xaml
    /// </summary>
    public partial class InvoiceWindow : Window
    {
        public InvoiceWindow()
        {
            
            InitializeComponent();
            InitializeStaticData();

        }

        private void InitializeStaticData()
        {
            Invoice invoice = new Invoice();
            CustomerNameLbl.Content = invoice.CustomerName;
            BranshNameLbl.Content = invoice.BranchName;
            DateLbl.Content = invoice.Date.ToString();
            
           
        }

        private void PrintBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
