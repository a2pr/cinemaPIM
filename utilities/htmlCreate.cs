using CinemaPIM.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace CinemaPIM.utilities
{
    class htmlCreate
    {
        public string createInvoiceHTML(List<Ingressos> ingressos)
        {
            string html = @"<html>
                            <body>
                                <h1>Tua fatura de venda</h1>
                                <h3>Informação de ingressos:</h3>";
            html += getIngressoInfo(ingressos[0]);
            html += getIngressosID(ingressos);
            html+= @"<p>Obrigado pela preferencia!</p>
                            </ body >
                        </ html >";
            string name = Convert.ToString(ingressos.Count()) + "-" + Session.getCarrinho().IdCliente;
            createHTML(html, name);
            return name;
        }

        public string getReportByFilmes(List<string>[] filmes)
        {
            string html = @"<html>
                            <body>
                                <h1>Relatorio vendas pelo Filmes</h1>
                            <table>
                                <tr>
                                    <th>Titulo Filmes </th>
                                    <th>Total vendas</th>
                                </tr>";
            html += getFilmesTable(filmes);

            string name = "filmes-"+ DateTime.Now.ToString("yyyy'-'MM'-'dd'-'HH'-'mm");
            createHTML(html, name);
            return name;
        }

        public string getReportByCinema(List<string>[] Cinemas)
        {
            string html = @"<html>
                            <body>
                                <h1>Relatorio vendas pelos Cinemas</h1>
                            <table>
                                <tr>
                                    <th>Nome de Cinema </th>
                                    <th>Total vendas</th>
                                </tr>";
            html += getCinemasTable(Cinemas);
            string name ="cinemas-"+DateTime.Now.ToString("yyyy'-'MM'-'dd'-'HH'-'mm");
            createHTML(html, name);
            return name;
        } 
        public string getReportByCard(List<string>[] Cards)
        {
            string html = @"<html>
                            <body>
                                <h1>Relatorio vendas pelo cartao</h1>
                               <h3>Valor obtido pelo cartao: " + Cards[0][0]+@" R$</h3>
                            </body>
                        </html>";

            string name ="cards-"+DateTime.Now.ToString("yyyy'-'MM'-'dd'-'HH'-'mm");
            createHTML(html, name);
            return name;
        }  
        public string getReportByPimCoin(List<string>[] PIMCoin)
        {
            string html = @"<html>
                            <body>
                                <h1>Relatorio vendas pelo PimCoin</h1>
                               <h3>Valor obtido pelo PimCoin: " + PIMCoin[0][0]+@" R$</h3>
                            </body>
                        </html>";

            string name ="cards-"+DateTime.Now.ToString("yyyy'-'MM'-'dd'-'HH'-'mm");
            createHTML(html, name);
            return name;
        }
        public string getReportALL(List<string>[] data)
        {
            string html = @"<html>
                            <body>
                                <h1>Relatorio vendas ate o dia de hoje</h1>
                                <table>
                                    <tr>
                                        <th>Pagamento id: </th>
                                        <th>Id Cliente</th> 
                                        <th>Cinema</th> 
                                        <th>Filme</th> 
                                        <th>Valor</th>  
                                        <th>Use Card</th>
                                        <th>Use PIMCoin</th>
                                    </tr>";
            html += getAllTable(data);
            string name ="All-"+DateTime.Now.ToString("yyyy'-'MM'-'dd'-'HH'-'mm");
            createHTML(html, name);
            return name;
        }

        private string getAllTable(List<string>[] data)
        {
            string html = "";
            for (var i = 0; i < data[0].Count; i++)
            {
                html += "<tr><td>" + data[0][i] + "</td>";
                html += "<td>" + data[1][i] + "</td>";
                html += "<td>" + data[2][i] + "</td>";
                html += "<td>" + data[3][i] + "</td>";
                html += "<td>" + data[4][i] + "</td>";
                html += "<td>" + data[5][i] + "</td>";
                html += "<td>" + data[6][i] + "</td></tr>";

            }
            html += "</table></body></html>";
            return html;
        }

        private string getCinemasTable(List<string>[] cinemas)
        {
            string html = "";
            for (var i = 0; i < cinemas[0].Count; i++)
            {
                html += "<tr><td>" + cinemas[0][i] + "</td>";
                html += "<td>" + cinemas[1][i] + " R$ </td></tr>";

            }
            html += "</table></body></html>";
            return html;
        }
        private string getFilmesTable(List<string>[] filmes)
        {
            string html = "";
            for (var i=0; i< filmes[0].Count; i++ )
            {
                html+= "<tr><td>" + filmes[0][i] + "</td>";
                html += "<td>"+ filmes[1][i] + " R$ </td></tr>";

            }
            html += "</table></body></html>";
            return html;
        }

        private string getIngressoInfo(Ingressos newIngressos)
        {
            var html = "<p>  Cinema: " + newIngressos.Cinema +"<p/>";
            html += "<p> Filme: " + newIngressos.Filme + "<p/>";
            html += "<p> Horario: " + newIngressos.Horario + "<p/>";
            return html;
        }

        private string getIngressosID(List<Ingressos> ingressos)
        {
            var html= "<ul> ";
            float valorTotal= 0;
            ingressos.ForEach(x =>
            {
                html += "<li> # de ingresso: "+ x.Id +"</li>";
                valorTotal += x.Valor;

            });
            html += "</ul> <p>"+ Convert.ToString(valorTotal) + "</p>";

            return html;
        }

        private void createHTML(string html, string fileName)
        {
            var htmlDoc = new HtmlAgilityPack.HtmlDocument();
            htmlDoc.LoadHtml(html);
            
            htmlDoc.Save(fileName + ".html", Encoding.UTF8);
        }
        
    }
}
