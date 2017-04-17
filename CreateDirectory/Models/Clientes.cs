using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace CreateDirectory.Models
{
    public class Clientes
    {
        public int ID { get; set; }
        private int quantidadeImagem { get; set; }
        public int imagem
        {
            get
            {
                return quantidadeImagem = 1;
            }
            set
            {
                quantidadeImagem = 1;
            }
        }

        public List<string> NameImagens { get; set; }
    }
}