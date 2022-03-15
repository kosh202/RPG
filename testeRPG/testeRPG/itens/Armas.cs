using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeRPG
{
    class Armas
    {
        public string nome;
        public bool DuasMaos = false;
        public bool UmaMao = false;
        public int tipo; // 1: arma de corte/ 2: longo alcance/ 3: escudos / 4 magicos
        public int tipoequip = 0; // 1: guerreiro/ 2: arqueiro/ 3: Mago 

        public bool cabeca = false;
        public bool tronco = false;
        public bool pernas = false;
        public bool pes = false;

        public float forca = 0;
        public float agilidade = 0;
        public float defesa = 0;
        public float mana = 0;
        public float atackMagi = 0;

        public void MostrarStatArma()
        {
            Console.WriteLine($"nome: {this.nome}\nforça: {this.forca}\nagilidade: {this.agilidade}\ndefesa:{this.defesa}\nmana:{this.mana}\nataque magico: {this.atackMagi}\n");
        }

    }
    
}
