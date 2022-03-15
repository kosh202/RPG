using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeRPG
{
    class Aranha : Monstro
    {
        public Aranha(string nome, int level)
        {
            this.nome = nome;
            this.level = level;
            this.level = 1;
            Status stat = new Status(20,5,35,10,40,0,0); //test
            this.setStatusM(stat);
        }
    }
}
