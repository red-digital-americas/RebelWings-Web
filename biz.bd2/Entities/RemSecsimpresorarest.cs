﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.bd2.Entities
{
    public partial class RemSecsimpresorarest
    {
        public int Idfront { get; set; }
        public int Idgruposecuencias { get; set; }
        public int Codsecuencia { get; set; }
        public string Secuencia { get; set; }

        public virtual RemFront IdfrontNavigation { get; set; }
    }
}