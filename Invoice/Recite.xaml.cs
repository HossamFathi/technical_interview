using Invoice.Data;
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
using System.Windows.Shapes;

namespace Invoice
{
    /// <summary>
    /// Interaction logic for Recite.xaml
    /// </summary>
    public partial class Recite : Window
    {
        public Recite(invoice invoice)
        {
            InitializeComponent();
            InitializeReciteData(invoice);

        }

        private void InitializeReciteData(invoice invoice)
        {
            this.CustomerNameLbl.Content = invoice.CustomerName;
            this.CompanyNameLbl.Content = "Technical Company";
            this.BranshNameLbl.Content = invoice.BranchName;
            this.DateLbl.Content = invoice.Date.ToString();
            foreach (var item in invoice.Items)
            {
                this.ItemList.Items.Add(item);
            }
            
        
        }
    }
}
