using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeRPG
{
    class Guerreiro:Heroi
    {
        public Guerreiro(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
            this.level = 1;
            Status stat = new Status(55, 40, 10, 20, 175, 0, 0); //test
            this.vidaMax = 175;
            this.setStatus(stat);
        }
        
    }
}
