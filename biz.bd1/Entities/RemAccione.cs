﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.bd1.Entities
{
    public partial class RemAccione
    {
        public int Idfront { get; set; }
        public int Accion { get; set; }
        public int Identidad { get; set; }

        public virtual RemFront IdfrontNavigation { get; set; }
    }
}