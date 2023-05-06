using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos
{
    public class Tabuada
    {
        public void TabuadaAdicao(int x)
        {
            for(int contador = 0; contador <= 10; contador++){
                Console.WriteLine($"{x} + {contador} = {x + contador}");
            }
        }

        public void TabuadaSubtracao(int x)
        {
            for(int contador = 0; contador <= 10; contador++){
                Console.WriteLine($"{x} - {contador} = {x - contador}");
            }
        }
        public void TabuadaMultiplicacao(int x)
        {   
            int contador = 0;
            do{
                Console.WriteLine($"{x} * {contador} = {x * contador}");
                contador++;
            }while(contador <= 10);
            
        }

        public void TabuadaDivisao(int x)
        {
            int contador = 1;
            while(contador <= 10){
                Console.WriteLine($"{x} / {contador} = {x / contador}");
                contador++;
            }
        }
    }
}