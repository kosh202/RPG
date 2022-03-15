using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeRPG
{
    class PeitoralGuerreiro : Armas
    {
        public PeitoralGuerreiro()
        {
            nome = "Peitoral";
            defesa = 2;
            agilidade = -2;
            tronco = true;
            tipoequip = 1;
        }
    }
}
