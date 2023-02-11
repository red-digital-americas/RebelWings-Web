﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace biz.bd1.Entities
{
    public partial class TPedidosEntrega
    {
        public TPedidosEntrega()
        {
            TFotosPedidosEntregas = new HashSet<TFotosPedidosEntrega>();
        }

        public int Id { get; set; }
        public int IdProveedor { get; set; }
        public DateTime? FechaProgPedido { get; set; }
        public DateTime? FechaPedidoReal { get; set; }
        public DateTime? FechaProgEntrega { get; set; }
        public DateTime? FechaEntregaReal { get; set; }
        public string ComentariosPedido { get; set; }
        public string ComentariosEntrega { get; set; }
        public int EstatusEntrega { get; set; }
        public int EstatusPedido { get; set; }
        public int IdSucursal { get; set; }

        public virtual TEstatusPedidosEntrega EstatusEntregaNavigation { get; set; }
        public virtual TEstatusPedidosEntrega EstatusPedidoNavigation { get; set; }
        public virtual ICollection<TFotosPedidosEntrega> TFotosPedidosEntregas { get; set; }
    }
}