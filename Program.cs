using System;
using System.Collections.Generic;
using System.Linq;

namespace ttese
{
    class Item
    {
        public int peso { get; set; }
        public int valor { get; set; }
        public Item(int peso, int valor) {
            this.peso = peso;
            this.valor = valor;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> itens = new List<Item>();
            itens.Add(new Item(11,4));
            itens.Add(new Item(2,2));
            itens.Add(new Item(1,1));
            itens.Add(new Item(4,10));
            itens.Add(new Item(1,2));
            int mochila = 15;
            AlgoritmoGuloso(itens, mochila);
        }

        static void AlgoritmoGuloso(List<Item> itens, int mochila) 
        {

            List<Item> SortedList = itens.OrderByDescending(o=>o.valor/o.peso).ToList();
            //Ordenando por ordem decrescente
            //Os valors o.valor/o.peso significar que valor é ponderado com valor final

            int pesoTotal = 0, valorTotal = 0;

            foreach (Item i in SortedList)//List ordenado  decrescente 
            {
                if(i.peso <= mochila) {
                    pesoTotal+= i.peso;//somando valores dos pesos
                    valorTotal += i.valor;//somanto valor total
                    mochila -= i.peso;//diminuindo o tamanho que a mochila aguetan
                    //De imicio a mochila aguenta 15 kg

                    System.Console.WriteLine("Peso toal " + i.peso + " - valor " + i.valor);
                }

            }
 
            System.Console.WriteLine("Peso total: " + pesoTotal + " valor total: "+ valorTotal);
        }
    }
}
