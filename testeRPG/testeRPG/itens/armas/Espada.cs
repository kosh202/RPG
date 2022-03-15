using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeRPG
{
    class Espada: Armas
    {
        public Espada()
        {
            forca = 2;
            
            nome = "Espada";
            DuasMaos = false;
            tipo = 1;
            UmaMao = true;
        }
    }
}
