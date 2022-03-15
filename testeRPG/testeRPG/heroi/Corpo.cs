using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeRPG
{
    class Corpo
    {
        private bool cabeca;
        private bool direita;//mao direita 
        private bool esquerda;//mao esquerda
        private bool tronco;
        private bool pernas;
        

        public Corpo(bool cabeca, bool direita, bool esquerda, bool tronco, bool pernas)
        {
            //se for true é q tem algo equipado

            setCabeca(cabeca);
            setCabeca(direita);
            setCabeca(esquerda);
            setCabeca(tronco);
            setCabeca(pernas);
            
        }

        public bool getCabeca()
        {
            return this.cabeca;
        }

        public void setCabeca(bool cabeca)
        {
            this.cabeca = cabeca;
        }

        public bool getDireita()
        {
            return this.direita;
        }

        public void setDireita(bool direita)
        {
            this.direita = direita;
        }
        public bool getEsquerda()
        {
            return this.esquerda;
        }

        public void setEsquerda(bool esquerda)
        {
            this.esquerda = esquerda;
        }
        public bool getTronco()
        {
            return this.tronco;
        }

        public void setTronco(bool tronco)
        {
            this.tronco = tronco;
        }
        public bool getPernas()
        {
            return this.pernas;
        }

        public void setPernas(bool pernas)
        {
            this.pernas = pernas;
        }

        

    }
}
