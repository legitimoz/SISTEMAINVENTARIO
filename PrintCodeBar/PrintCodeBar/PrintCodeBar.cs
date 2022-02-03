using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PrintCodeBar
{
   public class PrintCodeBar
    {
        public PrintCodeBar() { }

       public void Imprimir(string printerName, string codeBar)
       {
           if (printerName == null)
           {
               throw new ArgumentNullException("printerName");
           }
           RawPrinterHelper.SendStringToPrinter(printerName, codeBar);
       }

        //public void Imprimir(string printerName, string codeBar, DataTable dtInfo)
        //{
        //    if (printerName == null)
        //    {
        //        throw new ArgumentNullException("printerName");
        //    }
        //    RawPrinterHelper.SendStringToPrinter(printerName, stringcode(codeBar, dtInfo));
        //}

        string stringcode(string code, DataTable dtInfo)
        {
            foreach (DataRow dr in dtInfo.Rows)
            {
                foreach (DataColumn dc in dtInfo.Columns)
                {
                    while (code.ToUpper().IndexOf("[" + dc.ColumnName.ToUpper() + "]") > 0)
                    {
                        int index = code.ToUpper().IndexOf("[" + dc.ColumnName.ToUpper() + "]");
                        string codeReplace = code.Substring(index, ("[" + dc.ColumnName.ToUpper() + "]").Length);
                        code = code.Replace(codeReplace, dr[dc.ColumnName].ToString());
                    }
                }
                break;
            }
            return code;
        }
    }
}