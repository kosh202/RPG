using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeRPG
{
    class Dragao : Monstro
    {
        public Dragao(string nome, int level)
        {
            this.nome = nome;
            
            this.level = level;
            Status stat = new Status(50,10,25,10,80, 0, 0); //test
            this.setStatusM(stat);
        }
    }
}
