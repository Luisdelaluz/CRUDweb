﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDweb.Models.ViewModels
{
    public class ListTablaViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
    }
}