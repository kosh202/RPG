using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeRPG
{
    class SlotItem
    {
		private Armas maoDir = new Armas();
		private Armas maoEsq = new Armas();
		

		public void setMaoDir(Armas armas)
		{
			this.maoDir = armas;
		}

		public void setMaoEsq(Armas armas)
		{
			this.maoEsq = armas;
		}

		

		public Armas getMaoDir()
		{
			return this.maoDir;
		}

		public Armas getMaoEsq()
		{
			return this.maoEsq;
		}

		public string mostrarDireita()
		{
			return maoDir.nome;
		}

		public string mostrarEsquerda()
		{
			return maoEsq.nome;
		}
    }
}
