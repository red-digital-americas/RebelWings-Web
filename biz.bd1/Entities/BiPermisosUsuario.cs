﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.bd1.Entities
{
    public partial class BiPermisosUsuario
    {
        public int Idusuario { get; set; }
        public string Permisos { get; set; }
        public int? Idinformedefecto { get; set; }

        public virtual IeInforme IdinformedefectoNavigation { get; set; }
    }
}