using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPIM.Classes
{
    class Enderecos
    {
		private int id;
		private string rua;
		private string cidade;
		private string estado;
		private string CPE;

		public Enderecos(string rua, string cidade, string estado, string cPE)
		{
			this.rua = rua;
			this.cidade = cidade;
			this.estado = estado;
			this.CPE = cPE;
		}

		public string Rua { get => rua; set => rua = value; }
		public string Cidade { get => cidade; set => cidade = value; }
		public string Estado { get => estado; set => estado = value; }
		public string CPE1 { get => CPE; set => CPE = value; }
		public int Id { get => id; set => id = value; }
	}
}
