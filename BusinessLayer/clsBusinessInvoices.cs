using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsBusinessInvoices
    {

        public int InvoiceID { get; set; }
        public int InvoiceNumber { get; set; }
        public int PharmacistID { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }


        private bool _AddInvoice()
        {
            int invoi = clsDataAccessinvoices.AddInvoice(this.InvoiceNumber, this.PharmacistID, this.TotalAmount, this.CreatedAt);
            if (invoi > 0)
            {
                this.InvoiceID = invoi;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Save()
        {
            if (_AddInvoice())
                return true;
            else
                return false;
        }

        public static int GetTotalSales()
        {
            return clsDataAccessinvoices.GetTotalSales();
        }

    }
}
