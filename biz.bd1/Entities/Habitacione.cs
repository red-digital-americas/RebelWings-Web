﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.bd1.Entities
{
    public partial class Habitacione
    {
        public string Serie { get; set; }
        public int Tipohabitacion { get; set; }
        public int? Numero { get; set; }
        public int? Pax { get; set; }

        public virtual Series SerieNavigation { get; set; }
        public virtual Articulo1 TipohabitacionNavigation { get; set; }
    }
}