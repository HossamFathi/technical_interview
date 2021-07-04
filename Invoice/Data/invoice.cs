using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice.Data
{
    public  class invoice
    {
        public string CustomerName { get; set; }
        public string BranchName { get; set; }
        public List<InvoiceProduct> Items { get; set; }
        public DateTime Date { get; set; }

        public invoice()
        {
            // static value for  data 
            this.CustomerName = "Customer Name";
            this.BranchName = "Branch 1 ";
            Date = DateTime.Now;
             //   static Value for items 
            Items = new List<InvoiceProduct>();
            for (int item = 1; item < 10 ; item++)
            {
               var productInvoice =  new InvoiceProduct { 
                   product = new Product 
                   { ProductName = "Product"+item, Price = item },
                  Quantity = item 
               };

                Items.Add(productInvoice);
            }
           
           
        }
    }
}
