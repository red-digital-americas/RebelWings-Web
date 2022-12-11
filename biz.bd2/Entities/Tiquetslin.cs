﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.bd2.Entities
{
    public partial class Tiquetslin
    {
        public Tiquetslin()
        {
            Tiquetsconsumos = new HashSet<Tiquetsconsumo>();
            Tiquetsmodifs = new HashSet<Tiquetsmodif>();
        }

        public short Fo { get; set; }
        public string Serie { get; set; }
        public int Numero { get; set; }
        public string N { get; set; }
        public int Numlinea { get; set; }
        public int? Codarticulo { get; set; }
        public string Descripcion { get; set; }
        public double? Coste { get; set; }
        public double? Unidades { get; set; }
        public double? Precio { get; set; }
        public double? Precioiva { get; set; }
        public double? Preciodefecto { get; set; }
        public double? Codvendedor { get; set; }
        public int? Codformato { get; set; }
        public int? Codmacro { get; set; }
        public string Tipo { get; set; }
        public short? Tipoiva { get; set; }
        public double? Dto { get; set; }
        public string Referencia { get; set; }

        public virtual Ticketscab Ticketscab { get; set; }
        public virtual Tiquetscab Tiquetscab { get; set; }
        public virtual ICollection<Tiquetsconsumo> Tiquetsconsumos { get; set; }
        public virtual ICollection<Tiquetsmodif> Tiquetsmodifs { get; set; }
    }
}