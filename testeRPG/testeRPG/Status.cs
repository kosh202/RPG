using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeRPG
{
    class Status
    {
        public float forca;
        public float defesa;
        public float agilidade;
        public int sorte;
        private float vida;
        public float mana;
        public float flechas;

        public Status(float forca, float defesa, float agilidade, int sorte, float vida, float mana, float flechas)
        {
            this.forca = forca;
            this.defesa = defesa;
            this.agilidade = agilidade;
            this.sorte = sorte;
            this.setVida(vida );
            this.mana = mana;
            this.flechas = flechas;

        }

        public float getVida()
        {
            return this.vida;
        }

        public void setVida(float hp)
        {

            this.vida = hp;
            
        }
    }
}
