using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionalCalculos.Entities {
    internal class Product {

        public string Nome { get; set;}
        public double Price { get; set;}



        public Product(string nome, double price) {
            Nome = nome;
            Price = price;
        }


        public override string ToString() {
            string valorFormatado = string.Format(CultureInfo.GetCultureInfo("pt-br"), "{0:C}", Price);
            return $"{Nome} R${valorFormatado}";
        }

    }
}
