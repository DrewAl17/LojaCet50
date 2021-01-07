using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LojaCet50.Dados.Entidades
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        [Display(Name = "Preço")]
        [DisplayFormat(DataFormatString="{0:C2}",ApplyFormatInEditMode = false)]
        public Decimal Preco { get; set; }
       
        [Display(Name ="image")]
        public string UrlDaImagem { get; set; }

        [Display(Name = "Ultima Compra")]
        public DateTime UltimaCompra { get; set; }

        [Display(Name = "Ultima Venda")]
        public DateTime UltimaVenda { get; set; }

        [Display(Name = "Disponivel")]
        public bool Disponivel { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Stock { get; set; }


    }
}
