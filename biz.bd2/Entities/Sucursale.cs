﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.bd2.Entities
{
    public partial class Sucursale
    {
        public Sucursale()
        {
            Sucursalespermisos = new HashSet<Sucursalespermiso>();
        }

        public int Idsucursal { get; set; }
        public string Descripcion { get; set; }
        public string Usuario { get; set; }
        public string Pass { get; set; }

        public virtual ICollection<Sucursalespermiso> Sucursalespermisos { get; set; }
    }
}