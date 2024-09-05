using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuncionalCalculos.Entities;

namespace FuncionalCalculos {
     internal class Program {
          static void Main(string[] args) {

               Console.WriteLine("Programado pro JulianoMartins");

               List<Product> produto = new List<Product>();

               produto.Add(new Product("Playstation 5", 3800));
               produto.Add(new Product("Xbox Serie X", 4000));
               produto.Add(new Product("Televisor LG", 2300));
               produto.Add(new Product("Home Theater LG", 1600));


               double total = 0;
               Console.WriteLine("\nLista de compras.");
               foreach (Product x in produto) {
                    total += x.Price;
                    Console.WriteLine(x.ToString());
               }

               string valorFormatado = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", total);

               Console.WriteLine($"\nTotal da compra:\nR$ {valorFormatado}");

               produto.RemoveAll(p => p.Price >= 2000);

               Console.WriteLine("\nProdutos com valores abaixo de R$ 2.000,00");
               foreach(Product p in produto) {
                    Console.WriteLine(p.ToString());
               }

          }
     }
}
