﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.bd2.Entities
{
    public partial class Hmensajesvendedore
    {
        public int Id { get; set; }
        public int? Vendedororigen { get; set; }
        public int? Vendedordestino { get; set; }
        public string Textomensaje { get; set; }
        public DateTime? Fechacreacion { get; set; }
        public DateTime? Fechaleido { get; set; }
    }
}