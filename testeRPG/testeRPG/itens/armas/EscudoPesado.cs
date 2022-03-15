using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeRPG
{
    class EscudoPesado : Armas
    {
        public EscudoPesado()
        {
            nome = "Escudo pesado";
            forca = -1;
            defesa = 6;
            agilidade = -2;
            UmaMao = true;
        }
    }
}
