using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeRPG
{
    class EspadaLonga : Armas
    {
        public EspadaLonga()
        {
            Status status = new Status(5, 0, 2, 0, 0, 0, 0);
            forca = 5;
            agilidade = 2;
            nome = "Espada Longa";
            DuasMaos = true;
            tipo = 1;
            UmaMao = false;
            
        }

    /*
     public class ESpadaLonga
        {
            public Status status = new Status(5, 0, 2, 0, 0, 0, 0);
            public string nome = "Espada Longa";
            public bool MaoUnica = true;
        }*/
}
}
