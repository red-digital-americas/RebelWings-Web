﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.fortia.Entities
{
    public partial class RhRecorrido
    {
        public int ClaLugarAccid { get; set; }
        public int ClaEmpresa { get; set; }
        public DateTime Fecha { get; set; }
        public string Observaciones { get; set; }
        public string Responsable { get; set; }
        public DateTime? FechaCumplimiento { get; set; }
        public DateTime? FechaUltCambio { get; set; }
        public int FolAuto { get; set; }
        public string Repercusion { get; set; }
        public string Normatividad { get; set; }
        public string Solucion { get; set; }
        public string NivelPrioridad { get; set; }
        public double? PctAvance { get; set; }
        public string JustificaNoAvance { get; set; }
        public int? MesesIncumplimiento { get; set; }
        public string Recomendaciones { get; set; }
        public int? FolPlan { get; set; }
        public int? ExtraOrdinario { get; set; }
        public int? FolActividad { get; set; }
    }
}