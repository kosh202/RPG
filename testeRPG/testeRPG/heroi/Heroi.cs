using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeRPG
{
    class Heroi
    {
        public float ataqueMagic = 0;
        public string nome { get; set; }
        public int idade { get; set; }
        public int level { get; set; }
        Corpo corpo = new Corpo(false, false, false, false, false);
        public int vidaMax;
        public Status status;
        public int moedas = 0;

        public void Equipar(Armas armas)
         {
            this.status.agilidade += armas.agilidade;
            this.status.forca += armas.forca;
            this.status.defesa += armas.defesa;
            this.status.mana += armas.mana;
            this.ataqueMagic += armas.atackMagi;
            if (armas.DuasMaos)
            {
                if (this.corpo.getDireita() == true || this.corpo.getEsquerda() == true)
                {
                    this.status.agilidade -= armas.agilidade;
                    this.status.forca -= armas.forca;
                    this.status.defesa -= armas.defesa;
                    this.status.mana -= armas.mana;
                    this.ataqueMagic -= armas.atackMagi;
                    Console.WriteLine("Voce precisa desequipar a arma antes");
                    return;
                }
                this.corpo.setDireita(true);
                this.corpo.setEsquerda(true);
                return;
            }
            else if (armas.UmaMao)
            {
                Console.WriteLine("Deseja equipar me qual mão? \n1: direita \n 2: esquerda\n");
                int resp = Int32.Parse(Console.ReadLine());
                if (resp == 1)
                {
                    if (this.corpo.getDireita() == false)
                    {
                        this.status.agilidade += armas.agilidade;
                        this.status.forca += armas.forca;
                        this.status.defesa += armas.defesa;
                        this.status.mana += armas.mana;
                        this.ataqueMagic += armas.atackMagi;
                        Console.WriteLine("Arma equipada");
                        this.corpo.setDireita(true);
                        return;
                    }
                    else if (this.corpo.getDireita() == true)
                    {
                        this.status.agilidade -= armas.agilidade;
                        this.status.forca -= armas.forca;
                        this.status.defesa -= armas.defesa;
                        this.status.mana -= armas.mana;
                        this.ataqueMagic -= armas.atackMagi;
                        Console.WriteLine("Voce precisa desequipar a arma antes");
                        return;
                    }
                }
                else if (resp == 2)
                {
                    if (this.corpo.getEsquerda() == false)
                    {
                        this.status.agilidade += armas.agilidade;
                        this.status.forca += armas.forca;
                        this.status.defesa += armas.defesa;
                        this.status.mana += armas.mana;
                        this.ataqueMagic += armas.atackMagi;
                        Console.WriteLine("Arma equipada");
                        this.corpo.setEsquerda(true);
                        return;
                    }
                    else if (this.corpo.getEsquerda() == true)
                    {
                        this.status.agilidade -= armas.agilidade;
                        this.status.forca -= armas.forca;
                        this.status.defesa -= armas.defesa;
                        this.status.mana -= armas.mana;
                        this.ataqueMagic -= armas.atackMagi;
                        Console.WriteLine("Voce precisa desequipar a arma antes");
                        return;

                    }
                }
            }
            else if(armas.cabeca == true)
            {
                if (this.corpo.getCabeca() == true)
                {
                    this.status.agilidade -= armas.agilidade;
                    this.status.forca -= armas.forca;
                    this.status.defesa -= armas.defesa;
                    this.status.mana -= armas.mana;
                    this.ataqueMagic -= armas.atackMagi;
                    Console.WriteLine("Voce precisa desequipar a arma antes");
                    return;
                }
                this.corpo.setCabeca(true);
                return;
            }
            else if (armas.tronco == true)
            {
                if (this.corpo.getTronco() == true)
                {
                    this.status.agilidade -= armas.agilidade;
                    this.status.forca -= armas.forca;
                    this.status.defesa -= armas.defesa;
                    this.status.mana -= armas.mana;
                    this.ataqueMagic -= armas.atackMagi;
                    Console.WriteLine("Voce precisa desequipar a arma antes");
                    return;
                }
                this.corpo.setTronco(true);
                return;
            }
            else if (armas.pernas == true)
            {
                if (this.corpo.getPernas() == true)
                {
                    this.status.agilidade -= armas.agilidade;
                    this.status.forca -= armas.forca;
                    this.status.defesa -= armas.defesa;
                    this.status.mana -= armas.mana;
                    this.ataqueMagic -= armas.atackMagi;
                    Console.WriteLine("Voce precisa desequipar a arma antes");
                    return;
                }
                this.corpo.setPernas(true);
                return;
            }
            
        }
       
        public void Desequipar(Armas armas)
        {
            this.status.agilidade -= armas.agilidade;
            this.status.forca -= armas.forca;
            this.status.defesa -= armas.defesa;
            this.status.mana -= armas.mana;
            this.ataqueMagic -= armas.atackMagi;
            if (armas.DuasMaos)
            {
                if(this.corpo.getDireita() && this.corpo.getEsquerda())
                {
                    this.corpo.setDireita(false);
                    this.corpo.setEsquerda(false);
                    Console.WriteLine("Desequipado com sucesso");
                    return;
                }
                this.status.agilidade += armas.agilidade;
                this.status.forca += armas.forca;
                this.status.defesa += armas.defesa;
                this.status.mana += armas.mana;
                this.ataqueMagic += armas.atackMagi;
                Console.WriteLine("Você não possui nada para desequipar");
                return;

            }
            else if (armas.UmaMao)
            {
                Console.WriteLine("Mão direita: 1\nMão esquerda: 2");
                int resp = Int32.Parse(Console.ReadLine());
                if(resp == 1)
                {
                    if(this.corpo.getDireita() == false)
                    {
                        this.status.agilidade += armas.agilidade;
                        this.status.forca += armas.forca;
                        this.status.defesa += armas.defesa;
                        this.status.mana += armas.mana;
                        this.ataqueMagic += armas.atackMagi;
                        Console.WriteLine("Você não possui nada para desequipar");
                        return;
                    }
                    Console.WriteLine("Desequipado com sucesso");
                    this.corpo.setDireita(false);
                    return; ;
                }
                else if(resp == 2)
                {
                    if (this.corpo.getEsquerda() == false)
                    {
                        this.status.agilidade += armas.agilidade;
                        this.status.forca += armas.forca;
                        this.status.defesa += armas.defesa;
                        this.status.mana += armas.mana;
                        this.ataqueMagic += armas.atackMagi;
                        Console.WriteLine("Você não possui nada para desequipar");
                        return;
                    }
                    this.corpo.setEsquerda(false);
                    Console.WriteLine("Desequipado com sucesso");
                    return;
                }
            }
            else if(armas.cabeca)
            {
                if(this.corpo.getCabeca() == false)
                {
                    this.status.agilidade += armas.agilidade;
                    this.status.forca += armas.forca;
                    this.status.defesa += armas.defesa;
                    this.status.mana += armas.mana;
                    this.ataqueMagic += armas.atackMagi;
                    Console.WriteLine("Você não possui nada para desequipar");
                    return;
                }
                this.corpo.setCabeca(false);
                Console.WriteLine("Desequipado com sucesso");
                return;
            }
            else if (armas.tronco)
            {
                if (this.corpo.getCabeca() == false)
                {
                    this.status.agilidade += armas.agilidade;
                    this.status.forca += armas.forca;
                    this.status.defesa += armas.defesa;
                    this.status.mana += armas.mana;
                    this.ataqueMagic += armas.atackMagi;
                    Console.WriteLine("Você não possui nada para desequipar");
                    return;
                }
                this.corpo.setTronco(false);
                Console.WriteLine("Desequipado com sucesso");
                return;
            }
            else if (armas.pernas)
            {
                if (this.corpo.getPernas() == false)
                {
                    this.status.agilidade += armas.agilidade;
                    this.status.forca += armas.forca;
                    this.status.defesa += armas.defesa;
                    this.status.mana += armas.mana;
                    this.ataqueMagic += armas.atackMagi;
                    Console.WriteLine("Você não possui nada para desequipar");
                    return;
                }
                this.corpo.setPernas(false);
                Console.WriteLine("Desequipado com sucesso");
                return;
            }
            
            return;
        }
        


        public void MostraStatus()
        {
            Console.WriteLine($"\nLevel:{this.level}\nNome: {this.nome}\nVida:{this.status.getVida()}\nMana:{this.status.mana}\nForça{this.status.forca}\nDefesa:{this.status.defesa}\nAgilidade{this.status.agilidade}\nSorte:{this.status.sorte}\nFlechas:{this.status.flechas}\nAtaque magico: {this.ataqueMagic}\nMoedas: {this.moedas}\n");
        }
        public float ataque()
        {
            float dano = (this.status.forca + this.status.agilidade) * 1 + (new Random(DateTime.Now.Millisecond).Next(0, this.status.sorte));
            
            return dano;
        }
        public void setStatus(Status status)
        {
            this.status = status;
        }

        public float DEFESA()
        {

            float rand = 1 + (float)(new Random(DateTime.Now.Millisecond).Next(10, this.status.sorte)) / 100;
            return (this.status.defesa + this.status.agilidade) * rand;
        }
        public void recebeDano(float dano)
        {
            float recebe = this.DEFESA() - dano;
            Console.WriteLine("recebe: {0} dano", recebe);
            if (recebe + this.status.getVida() < 0)
            {
                Console.WriteLine($"{this.nome} morreu");
                this.status.setVida(0);
            }
            else if (recebe < 0)
            {
                this.status.setVida(this.status.getVida() + recebe);
            }


        }
    }
}
