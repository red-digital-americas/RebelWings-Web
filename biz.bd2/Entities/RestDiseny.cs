﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.bd2.Entities
{
    public partial class RestDiseny
    {
        public RestDiseny()
        {
            RestTiquetsdisenies = new HashSet<RestTiquetsdiseny>();
        }

        public short Idgrupo { get; set; }
        public short Iddiseny { get; set; }
        public int? Idioma { get; set; }
        public string Ivaincluido { get; set; }
        public string Esmodelo { get; set; }
        public short? Tipodocumento { get; set; }
        public string Descripcion { get; set; }
        public byte[] Imagen { get; set; }
        public string Esdefecto { get; set; }
        public bool? Ocultarptotales { get; set; }
        public byte[] Version { get; set; }

        public virtual ICollection<RestTiquetsdiseny> RestTiquetsdisenies { get; set; }
    }
}