﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.bd2.Entities
{
    public partial class Pedcomprafirma
    {
        public string Serie { get; set; }
        public int Numero { get; set; }
        public string N { get; set; }
        public string Versionfirma { get; set; }
        public string Firma { get; set; }
        public string Claveprivada { get; set; }
        public string Claveacceso { get; set; }
        public string Atdoccodeid { get; set; }
        public int? Estado1 { get; set; }
        public int? Estado2 { get; set; }
        public string Error { get; set; }

        public virtual Pedcompracab Pedcompracab { get; set; }
    }
}