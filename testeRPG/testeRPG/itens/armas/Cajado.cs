using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeRPG
{
    class Cajado: Armas
    {
        public Cajado()
        {
            forca = 1;
            mana = 15;
            atackMagi = 3;

            nome = "Cajado";
            
            tipo = 4;
            UmaMao = true;
        }
    }
}
