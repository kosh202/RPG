using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeRPG
{
    class Monstro
    {
        public string nome { get; set; }
        public int level;
        public Status Status;

        public void MostraStatus()
        {
            Console.WriteLine($"\n============\nLevel:{this.level}\nNome: {this.nome}\nVida:{this.Status.getVida()}\nMana:{this.Status.mana}\nForça{this.Status.forca}\nDefesa:{this.Status.defesa}\nAgilidade{this.Status.agilidade}\nSorte:{this.Status.sorte}\n================\n");
        }

        public Status getStatusM()
        {
            return this.Status;
        }
        public void setStatusM(Status status)
        {
            this.Status = status;
        }
        public float DEFESA()
        {

            float rand = 1 + (float)(new Random(DateTime.Now.Millisecond).Next(10, this.Status.sorte)) / 100;
            return (this.Status.defesa + this.Status.agilidade) * rand;
        }
        public float ataque()
        {
            float dano = (this.Status.forca + this.Status.agilidade) * 1 + (new Random(DateTime.Now.Millisecond).Next(0, this.Status.sorte));
            
            return dano;
        }
        public void recebeDano(float dano)
        {
            float recebe = this.DEFESA() - dano;
            Console.WriteLine("recebe: {0} dano", recebe);
            if (recebe + this.Status.getVida() < 0)
            {
                Console.WriteLine($"{this.nome} morreu");
                this.Status.setVida(0);
            }
            else if (recebe < 0)
            {
                this.Status.setVida( this.Status.getVida() + recebe);
            }
        }
    }
}
