﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.bd2.Entities
{
    public partial class Pedcompracamposlibre
    {
        public string Numserie { get; set; }
        public int Numpedido { get; set; }
        public string N { get; set; }
        public string Generado { get; set; }
        public string Documento { get; set; }
        public string Numero { get; set; }
        public string Sucursal { get; set; }

        public virtual Pedcompracab NNavigation { get; set; }
    }
}