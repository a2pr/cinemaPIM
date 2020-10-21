using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaPIM.Classes;
using Google.Protobuf.Reflection;
using IronPdf;

namespace CinemaPIM.utilities
{
    class pdfCreate
    {
        private IronPdf.HtmlToPdf Renderer= new IronPdf.HtmlToPdf();
        private htmlCreate htmlBuilder = new htmlCreate();
        public void createInvoice(List<Ingressos> newIngressos, order newOrder)
        {
            string fileName = htmlBuilder.createInvoiceHTML(newIngressos, newOrder);
           
            var PDF = Renderer.RenderHTMLFileAsPdf(fileName+".html");
            PDF.SaveAs(fileName+".pdf");
            System.Diagnostics.Process.Start(fileName+".pdf");
        }


        public void createReportFilmes(List<string>[] data)
        {
            string fileName = htmlBuilder.getReportByFilmes(data);

            var PDF = Renderer.RenderHTMLFileAsPdf(fileName + ".html");
            PDF.SaveAs(fileName + ".pdf");
            System.Diagnostics.Process.Start(fileName + ".pdf");
        }

        public void createReportCinemas(List<string>[] data)
        {
            string fileName = htmlBuilder.getReportByCinema(data);

            var PDF = Renderer.RenderHTMLFileAsPdf(fileName + ".html");
            PDF.SaveAs(fileName + ".pdf");
            System.Diagnostics.Process.Start(fileName + ".pdf");
        }
        public void createReportCards(List<string>[] data)
        {
            string fileName = htmlBuilder.getReportByCard(data);

            var PDF = Renderer.RenderHTMLFileAsPdf(fileName + ".html");
            PDF.SaveAs(fileName + ".pdf");
            System.Diagnostics.Process.Start(fileName + ".pdf");
        }
        public void createReportPIMCoin(List<string>[] data)
        {
            string fileName = htmlBuilder.getReportByPimCoin(data);

            var PDF = Renderer.RenderHTMLFileAsPdf(fileName + ".html");
            PDF.SaveAs(fileName + ".pdf");
            System.Diagnostics.Process.Start(fileName + ".pdf");
        }
        public void createReportALL(List<string>[] data)
        {
            string fileName = htmlBuilder.getReportALL(data);

            var PDF = Renderer.RenderHTMLFileAsPdf(fileName + ".html");
            PDF.SaveAs(fileName + ".pdf");
            System.Diagnostics.Process.Start(fileName + ".pdf");
        }
    }
}
