﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.bd2.Entities
{
    public partial class TefsParam
    {
        public int Idtef { get; set; }
        public int Idparam { get; set; }
        public int Tipo { get; set; }
        public string Nombre { get; set; }
        public int Aplicacion { get; set; }

        public virtual Tef IdtefNavigation { get; set; }
    }
}