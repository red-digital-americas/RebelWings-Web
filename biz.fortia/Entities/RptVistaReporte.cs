﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.fortia.Entities
{
    public partial class RptVistaReporte
    {
        public int IdVista { get; set; }
        public string IdReporte { get; set; }
        public string NomVista { get; set; }
        public string TipoVista { get; set; }
        public byte[] Vista { get; set; }

        public virtual RptReporte IdReporteNavigation { get; set; }
    }
}