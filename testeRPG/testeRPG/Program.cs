using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Arco arco = new Arco();
            Console.WriteLine("Digite o nome do mago: ");
            string nome = Console.ReadLine();

            Arqueiro arqueiro = new Arqueiro(nome, 20);
            arqueiro.MostraStatus();
            arqueiro.Equipar(arco);
            arqueiro.MostraStatus();

            Elmo elmo = new Elmo();

            ChapeuDeMago chapeuDeMago = new ChapeuDeMago();
            arco.MostrarStatArma();
            arqueiro.Equipar(chapeuDeMago);
            arqueiro.MostraStatus();
            arqueiro.Equipar(elmo);
            arqueiro.MostraStatus();
            arqueiro.MostraStatus();
            Goblin goblin = new Goblin("goblin", 1);
            goblin.MostraStatus();
            //goblin.recebeDano(arqueiro.ataque());
            arqueiro.AtirarFlecha(goblin);
            arqueiro.AtirarFlecha(goblin);

            goblin.MostraStatus();
            arqueiro.Desequipar(chapeuDeMago);
            arqueiro.MostraStatus();


            /* Mago mago= new Mago(nome, 20);
            mago.MostraStatus();

            Goblin goblin = new Goblin("Goblin", 2);
            goblin.MostraStatus();

            EspadaLonga espadaLonga = new EspadaLonga();
            mago.BolaDeMana(goblin);

            mago.MostraStatus();
            goblin.MostraStatus();
 
            Mago mago = new Mago(nome, 20);
            mago.MostraStatus();

            Goblin goblin = new Goblin("Goblin", 1);
            goblin.MostraStatus();

            mago.recebeDano(goblin.ataque());
            mago.MostraStatus();

            mago.cura(mago);

            mago.MostraStatus();
            mago.cura(mago);

            mago.MostraStatus();

*/
/*
           Guerreiro guerreiro = new Guerreiro(nome, 20);

            guerreiro.MostraStatus();

            

            EspadaLonga espadaLonga = new EspadaLonga();
            Espada espada = new Espada();
            EscudoLeve escudoLeve = new EscudoLeve();
            EscudoPesado escudoPesado = new EscudoPesado();

            guerreiro.Equipar(espada);

            guerreiro.MostraStatus();

            guerreiro.Equipar(escudoLeve);
            guerreiro.MostraStatus();
            
            guerreiro.Desequipar(espada);
            guerreiro.MostraStatus();

            guerreiro.Desequipar(espada);
            guerreiro.MostraStatus();
            */
        }
    }
}
