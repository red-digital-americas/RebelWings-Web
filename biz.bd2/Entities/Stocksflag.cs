﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.bd2.Entities
{
    public partial class Stocksflag
    {
        public int Codarticulo { get; set; }
        public string Talla { get; set; }
        public string Color { get; set; }
        public string Codalmacen { get; set; }
        public string Flags { get; set; }
        public byte[] Version { get; set; }

        public virtual Articuloslin Articuloslin { get; set; }
    }
}