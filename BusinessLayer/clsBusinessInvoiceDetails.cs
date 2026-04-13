using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessLayer
{
    public class clsBusinessInvoiceDetails
    {
        public DataTable TableDetails = new DataTable();
        public int PharmacistID {  get; set; }
        public int invoiceNumber { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }

        private bool AddInvoiceDetails()
        {
            if (clsDataAccessInvoicesDetails.ADDInvoices(this.TableDetails, this.invoiceNumber, this.PharmacistID, this.Price, this.CreatedAt))
                return true;
            else
                return false;
        }

        public bool Save()
        {
            if (AddInvoiceDetails())
                return true;
            else
                return false;
        }





    }
}
