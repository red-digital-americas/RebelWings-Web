﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.fortia.Entities
{
    public partial class RhDetMatrizJerarquia
    {
        public int ClaMatriz { get; set; }
        public int FolAuto { get; set; }
        public int ClaTrab { get; set; }
        public int ClaEmpresa { get; set; }
        public int ClaPuesto { get; set; }
        public int ClaArea { get; set; }
        public int ClaDepto { get; set; }
        public string Tipo { get; set; }
        public int NivelPre1 { get; set; }
        public int ClaEmpresa1 { get; set; }
        public int NivelPre2 { get; set; }
        public int ClaEmpresa2 { get; set; }
        public int NivelPre3 { get; set; }
        public int ClaEmpresa3 { get; set; }
        public DateTime FechaRegistro { get; set; }

        public virtual RhMatrizJerarquia ClaMatrizNavigation { get; set; }
    }
}