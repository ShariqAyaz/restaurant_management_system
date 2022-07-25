using System;

using System.IO;
using iTextSharp.text;

using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;
using System.Drawing;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;

namespace ESIT_ERP.Reports.MM
{
    public partial class Stock_Level : System.Web.UI.Page
    {

        protected string cs = @"data source=ANWARBALOCH-PC\SQLEXPRESS;initial catalog=ESITERP;integrated security=True";
        //public GRN_ITEMS[] GI = null;
        transactions.transactions GET_GI = new transactions.transactions();
        public bool loaditm = false;
        rdgrant.rdgrant apps = new rdgrant.rdgrant();
        public int cur_actionid;
        static int appid = 1020;
        //
        Document doc = new Document(PageSize.A4, 7f, 5f, 5f, 0f);
        //iTextSharp.text.Font mainFont = FontFactory.GetFont("Segoe UI", 22, new iTextSharp.text.bas(System.Drawing.ColorTranslator.FromHtml("#999")));

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userlogin"] == null)
                Response.Redirect("/login.aspx");
            cur_actionid = apps.getActionId(Convert.ToInt32(Session["userlogin"]), appid);

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {

            Response.Redirect("/");
        }

        protected void print_Click(object sender, EventArgs e)
        {
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=print.pdf");
            string sourceFile = Server.MapPath("/print.pdf");
            //PdfReader reader = new PdfReader(sourceFile);
            //iTextSharp.text.Rectangle size = reader.GetPageSizeWithRotation(1);
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);
            pdfPannel.RenderControl(hw);
            
            StringReader sr = new StringReader(sw.ToString());
            Document pdfDoc = new Document();
            HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
            
            //PdfStamper pdfStamper = new PdfStamper(reader);
            PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
            //pdfStamper.setFormFlattening(true);
            pdfDoc.Open();
            htmlparser.Parse(sr);
            // flatten the PDF (so the values are visible when PDF is downloaded on iOS / OS X)
            
            pdfDoc.Close();
            Response.Write(pdfDoc);
            Response.End();
        }
    }
}