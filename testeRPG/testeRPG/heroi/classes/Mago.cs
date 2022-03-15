using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeRPG
{
    class Mago:Heroi
    {

        

        public Mago(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
            this.level = 1;
            Status stat = new Status(40,20,15,20,160,45,0); //test
            this.vidaMax = 160;
            this.setStatus(stat);
            ataqueMagic = 35;
        }

        public void BolaDeMana(Monstro monstro)
        {
            
            Console.WriteLine($"O Monstro sofreu {this.ataqueMagic} de dano");
            if (this.status.mana > 5)
            {
                this.status.mana -= 5;
                monstro.Status.setVida(monstro.Status.getVida() - this.ataqueMagic);//tirar a vida do monstro
                if (monstro.Status.getVida() < 0)//verificar se o monstro esta morto
                {
                    monstro.Status.setVida(0);
                    Console.WriteLine("O Monstro morreu");
                    return;
                }
                
                return;
            }
            else
            {
                Console.WriteLine("Mana insuficiente");
            }
        }

        public void cura(Heroi heroi)
        {
            
            if(this.status.mana > 10)
            {
                this.status.mana -= 10;
                heroi.status.setVida(heroi.status.getVida()/10 + heroi.status.getVida());
                if(heroi.status.getVida() > vidaMax)
                {
                    heroi.status.setVida(vidaMax);
                    return;
                }
                return;
            }
            else
            {
                Console.WriteLine("Mana insuficiente");
            }
        }
    }
}
