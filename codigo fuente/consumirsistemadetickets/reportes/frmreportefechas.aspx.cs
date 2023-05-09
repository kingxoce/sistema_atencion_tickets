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
    public partial class frmreportefechas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dts_rpt_escrit dsreporte = new dts_rpt_escrit();
            DataTable tabla = dsreporte.Tables["dtescrit"];

            foreach (GridViewRow fila in gdrptescr.Rows)
            {
                DataRow row = tabla.NewRow();
                row["idTicket"] = fila.Cells[0].Text;
                row["idEscritorio"] = fila.Cells[1].Text;
                row["idEmpleado"] = fila.Cells[2].Text;
                row["motivo"] = fila.Cells[3].Text;
                row["fecha_t"] = fila.Cells[4].Text;
                row["estado_de_ticket"] = fila.Cells[5].Text;

                tabla.Rows.Add(row);
            }

            ReportDocument crystalreports = new ReportDocument();
            crystalreports = new ReportDocument();
            crystalreports.Load(Server.MapPath("~/rptescrit.rpt"));
            crystalreports.SetDataSource(dsreporte);
            CrystalReportViewer1.ReportSource = crystalreports;
            ExportFormatType formato = ExportFormatType.NoFormat;
            formato = ExportFormatType.PortableDocFormat;
            crystalreports.ExportToHttpResponse(formato, Response, true, "rptescrit");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            wsreportes.reportesSoapClient rpt = new wsreportes.reportesSoapClient();
            DataSet reporteT = new DataSet();

            reporteT = rpt.buscarescritorio(Convert.ToInt32(fecha1.Text), Convert.ToInt32(fecha2.Text));
            gdrptescr.DataSource = reporteT;
            gdrptescr.DataBind();
        }
    }
}