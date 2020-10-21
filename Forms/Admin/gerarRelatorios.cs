using CinemaPIM.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaPIM.utilities;
using System.Windows.Forms;

namespace CinemaPIM.Forms.Admin
{
    public partial class gerarRelatorios : Form
    {
        private DatabaseAdmin adminDB;
        private pdfCreate pdfBuilder;
        public gerarRelatorios()
        {
            InitializeComponent();
            adminDB = new DatabaseAdmin();
        }

        private void gerarRelatorios_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string>[] data = adminDB.getFilmesPDf();
            pdfBuilder = new pdfCreate();
            pdfBuilder.createReportFilmes(data);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string>[] data = adminDB.getCinemasPDf();
            pdfBuilder = new pdfCreate();
            pdfBuilder.createReportCinemas(data);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string>[] data = adminDB.getCardsPDf();
            pdfBuilder = new pdfCreate();
            pdfBuilder.createReportCards(data);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<string>[] data = adminDB.getPIMCoinPDf();
            pdfBuilder = new pdfCreate();
            pdfBuilder.createReportPIMCoin(data);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string>[] data = adminDB.getAllPDf();
            pdfBuilder = new pdfCreate();
            pdfBuilder.createReportALL(data);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
