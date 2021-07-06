using System;

namespace estruturas{
    public class Pilha    {
        Posicao x1;
        public void empilha(object item){
            x1 = new Posicao(x1, item);
        }
        public object desempilha(){
            if (x1==null){
                throw new InvalidOperationException("Pilha está vazia");          
            }
            object result = x1.item;
            x1= x1.prox;
            return result;
        }

        class Posicao{
            public Posicao prox;
            public object item;
            public Posicao(Posicao prox, object item){
                this.prox= prox;
                this.item= item;
            }
        }
    }
}
