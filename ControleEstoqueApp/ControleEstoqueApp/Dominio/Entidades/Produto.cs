﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoqueApp.Dominio.Entidades
{
       public class Produto
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public int Quantidade { get; set; }
            public decimal Preco { get; set; }
        }
}
