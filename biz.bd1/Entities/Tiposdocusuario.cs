﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.bd1.Entities
{
    public partial class Tiposdocusuario
    {
        public int Codusuario { get; set; }
        public string Documento { get; set; }
        public int Numlinea { get; set; }
        public int Tipodoc { get; set; }

        public virtual Tiposdoc TipodocNavigation { get; set; }
    }
}