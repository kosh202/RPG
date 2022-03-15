using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeRPG
{
    class Arqueiro: Heroi
    {
        public Arqueiro(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
            this.level = 1;
            Status stat = new Status(35, 20, 25, 20, 170, 0, 30); //test
            this.vidaMax = 170;
            this.setStatus(stat);
        }

        public void AtirarFlecha(Monstro monstro)
        {
            if(this.status.flechas > 0)
            {
                this.status.flechas -= 1;
                monstro.recebeDano(this.ataque() + 2);
                
                
                if (monstro.Status.getVida() < 0)
                {
                    Console.WriteLine("O monstro morreu");
                    monstro.Status.setVida(0);
                    
                    return;
                }
                return;
            }
            else
            {
                Console.WriteLine("Não possui flecahas suficientes");
            }
        }
        /*
         //fica muito desbalanceado
        public void Atirar3Flechas(Monstro monstro)
        {
            monstro.recebeDano((this.ataque() + 2)*3);
            this.status.flechas -= 3;
        }*/
    }
}
