﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.bd2.Entities
{
    public partial class Hcuposrestriccione
    {
        public int Idhotel { get; set; }
        public int Idcupo { get; set; }
        public DateTime Fechainicio { get; set; }
        public DateTime Fechafin { get; set; }
        public int Tiporestriccion { get; set; }
        public int Estado { get; set; }
        public int? Diasestancia { get; set; }
        public bool? Pendientesubida { get; set; }

        public virtual Hcupo IdcupoNavigation { get; set; }
        public virtual Hotele IdhotelNavigation { get; set; }
    }
}