using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace PJOBS
{
    public partial class frmJOB : Form
    {
        public frmJOB()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //ParameterFieldDefinitions crParameterFieldDefinitions;
            //ParameterFieldDefinition crParameterFieldDefinition;
            //ParameterValues crParameterValues = new ParameterValues();
            //ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

        }

        private void btnBAR_Click(object sender, EventArgs e)
        {
            //Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            //pictureBox1.Image = barcode.Draw(txtbBAR.Text, 50);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument pdoc = new PrintDocument();
            pdoc.PrintPage += doc_printpage;
            pd.Document = pdoc;
            if (pd.ShowDialog()==DialogResult.OK)
            {
                pdoc.Print();
            }
        }

        private void doc_printpage(object sender,PrintPageEventArgs e)
        {
        //    Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        //    pictureBox1.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
        //    e.Graphics.DrawImage(bm, 0, 0);
        //    bm.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
