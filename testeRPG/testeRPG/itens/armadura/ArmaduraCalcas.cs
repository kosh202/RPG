using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeRPG
{
    class ArmaduraCalcas : Armas
    {
        public ArmaduraCalcas()
        {
            nome = "Armadura de pernas";
            defesa = 1;
            agilidade = -1;
            tipoequip = 1;
            pernas = true;
        }
    }
}
