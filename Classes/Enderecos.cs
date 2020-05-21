using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPIM.Classes
{
    class Enderecos
    {
		private string rua;
		private string cidade;
		private string estado;
		private string CPE;


		public void SetRua(string rua)
		{
			this.rua = rua;

		}
		public void SetCidade(string cidade)
		{
			this.cidade = cidade;

		}
		public void SetEstado(string estado)
		{
			this.estado = estado;

		}
		public void SetCPE(string cpe)
		{
			this.CPE = cpe;

		}

		//public int GetRua()
		//{
		//	return this.rua;
		//}

		//public int GetCidade()
		//{
		//	return this.cidade;
		//}
		//public int GetEstado()
		//{
		//	return this.estado;
		//}
		//public int GetCPE()
		//{
		//	return this.CPE;
		//}
	}
}
