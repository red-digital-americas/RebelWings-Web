﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace biz.bd1.Entities
{
    public partial class CmrcEnlacesidioma
    {
        public int Idenlace { get; set; }
        public int Ididioma { get; set; }
        public string Titulo { get; set; }

        public virtual CmrcEnlace IdenlaceNavigation { get; set; }
    }
}