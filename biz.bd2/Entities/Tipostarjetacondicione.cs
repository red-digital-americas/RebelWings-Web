﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.bd2.Entities
{
    public partial class Tipostarjetacondicione
    {
        public int Idtipotarjeta { get; set; }
        public int Idfront { get; set; }
        public int Dia { get; set; }
        public int? Numconsum { get; set; }
        public int? Idtarifaconsum { get; set; }
        public double? Dtoconsum { get; set; }
        public int? Idtarifaresto { get; set; }
        public double? Dtoresto { get; set; }

        public virtual Tipostarjetum IdtipotarjetaNavigation { get; set; }
    }
}