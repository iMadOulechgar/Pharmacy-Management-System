using BusinessLayer;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using Pharmacy_Management_System.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.Reports
{
    public static class clsReportInfo
    {

        public static void CreateReport(string ReportName , string DrugName)
        {
            using (PdfWriter Write = new PdfWriter(ReportName))
            {
                using (PdfDocument PdfDoc = new PdfDocument(Write))
                {
                    using (Document Doc = new Document(PdfDoc))
                    {
                        Doc.Add(new Paragraph("                 Report Status Of Batches              "));
                        clsBusinessBatches Butches = clsBusinessBatches.FindByDrugID(clsBusinessDrugs.FindByDrugName(DrugName).DrugId);
                        Doc.Add(new Paragraph("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - -"));
                        Doc.Add(new Paragraph("  BatchId                 : " + Butches.ButchesID));
                        Doc.Add(new Paragraph("  DrugName                : " + Butches.CompDrugs.DrugName));
                        Doc.Add(new Paragraph("  Purchase Price Per Unit : " + Butches.PerchasePrice));
                        Doc.Add(new Paragraph("  Selling Price Per Unit  : " + Butches.SellingPrice));
                        Doc.Add(new Paragraph("  ExpirationDate          : " + Butches.ExpirationDate));
                        Doc.Add(new Paragraph("  The Old Quantity        : " + Butches.OldQuantity));
                        Doc.Add(new Paragraph("  User Fill DrugInfo      : " + clsBusinessUsers.FindUserById(Butches.CreatedByUserID).Username));
                        Doc.Add(new Paragraph("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - -"));

                        Doc.Add(new Paragraph("**********" + " This Report Created By " + clsCurrentUserLogin.CurrentUser.Username + " **********"));

                        Doc.Add(new Paragraph("                           Quantity At " + DateTime.Now.ToString() + " : " + Butches.Quantity));

                        Doc.Add(new Paragraph("\n\n                                         This Report Is Created At " + DateTime.Now.ToString()));
                        MessageBox.Show("The Report Has Been Created Successfly :=)", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

    }
}
