using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeRPG
{
    class Goblin: Monstro
    {
        public Goblin(string nome,int level)
        {
            this.level = level;
            this.nome = nome;

            Status stat = new Status(35, 15, 20, 10, 50, 0, 0);
            this.Status = stat;
        }
        
    }
}
