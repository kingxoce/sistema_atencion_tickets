using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace consumirsistemadetickets.reportes
{
    public partial class frmreporteticket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                wsreportes.reportesSoapClient rpt = new wsreportes.reportesSoapClient();
                DataSet reporteT = new DataSet();

                reporteT = rpt.buscartickets();
                Gdrpttickets.DataSource = reporteT;
                Gdrpttickets.DataBind();
            }
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dts_rpt_ticket dsreporte = new dts_rpt_ticket();
            DataTable tabla = dsreporte.Tables["dtticket"];

            foreach (GridViewRow fila in Gdrpttickets.Rows)
            {
                DataRow row = tabla.NewRow();
                row["idTicket"] = fila.Cells[0].Text ;
                row["nombre"] = fila.Cells[1].Text;
                row["carne"] = fila.Cells[2].Text;
                row["apellido"] = fila.Cells[3].Text;
                row["correo"] = fila.Cells[4].Text;
                row["motivo"] = fila.Cells[5].Text;
                row["estado_de_ticket"] = fila.Cells[6].Text;

                tabla.Rows.Add(row);
            }

            ReportDocument crystalreports = new ReportDocument();
            crystalreports = new ReportDocument();
            crystalreports.Load(Server.MapPath("~/rptticket.rpt"));
            crystalreports.SetDataSource(dsreporte);
            CrystalReportViewer1.ReportSource = crystalreports;
            ExportFormatType formato = ExportFormatType.NoFormat;
            formato = ExportFormatType.PortableDocFormat;
            crystalreports.ExportToHttpResponse(formato,Response,true,"rptticket");
            
          
        }
    }
}