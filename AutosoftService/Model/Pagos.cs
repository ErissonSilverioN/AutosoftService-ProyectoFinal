﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutosoftService.Model
{
    public class Pagos
    {
        [Key]

        public int PagoId { get; set; }
        public int ClienteId { get; set; }
        public decimal Monto { get; set; }
        public decimal Deuda { get; set; }
        public DateTime Fecha { get; set; }

        public Pagos()
        {
            PagoId = 0;
            ClienteId = 0;
            Monto = 0;
            Deuda = 0;
            Fecha = DateTime.Now;
        }
    }
}
