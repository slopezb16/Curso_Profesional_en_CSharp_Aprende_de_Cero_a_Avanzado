using ClosedXML.Excel;
using System;
using System.Data;
using System.IO;

namespace Ejercicio1ASP
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable("BookExcel");

                dt.Columns.Add("Nombre");
                dt.Columns.Add("Apellido");
                dt.Columns.Add("Telefono");
                dt.Columns.Add("Edad");

                DataRow dr = dt.NewRow();
                dr["Nombre"] = "Jonathan";
                dr["Apellido"] = "Robayo";
                dr["Telefono"] = "123456";
                dr["Edad"] = "30";

                dt.Rows.Add(dr);

                using (XLWorkbook book = new XLWorkbook())
                {
                    var hoja = book.Worksheets.Add(dt);
                    hoja.ColumnsUsed().AdjustToContents();
                    Response.Clear();
                    Response.Buffer = true;
                    Response.Charset = "";
                    Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                    Response.AddHeader("content-disposition", "attachment;filename=Book.xlsx");

                    using (MemoryStream memoria = new MemoryStream())
                    {
                        book.SaveAs(memoria);
                        Response.BinaryWrite(memoria.ToArray());
                        Response.Flush();
                        Response.End();
                    }

                }

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}