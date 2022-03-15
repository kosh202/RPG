using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeRPG
{
    class Arco : Armas
    {
        public Arco()
        {
            forca = 1;
            

            nome = "Arco";
            DuasMaos = true;
            tipo = 2;
            UmaMao = false;
        }
    }
}
