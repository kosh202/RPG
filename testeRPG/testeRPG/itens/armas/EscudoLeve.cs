using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeRPG
{
    class EscudoLeve:Armas
    {
        public EscudoLeve()
        {
            tipo = 3;
            defesa = 2;
            agilidade = -1;
            nome = "Escudo Leve";
            UmaMao = true;

        }
    }
}
