﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.fortia.Entities
{
    public partial class RhTipoObjetivo
    {
        public int ClaEmpresa { get; set; }
        public int ClaUbicacion { get; set; }
        public int ClaDepto { get; set; }
        public int FolAuto { get; set; }
        public int ClaTipoObj { get; set; }
        public string Descripcion { get; set; }
        public string TipoEvaluacion { get; set; }
        public byte? Proporcional { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaUltCambio { get; set; }
        public double Ponderacion { get; set; }
    }
}