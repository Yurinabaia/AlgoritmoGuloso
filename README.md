<h2>Algoritmo Guloso </h2>

~~~c#
/Ordenando por ordem decrescente
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
            
~~~
<p> Programa finalizado </p>

