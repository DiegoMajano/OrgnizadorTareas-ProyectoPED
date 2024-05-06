﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorT.ClasesSistema
{
    internal class Recordatorio : CNodos
    {
        public string titulo;
        public DateTime arecordar;
        public string cuerpo;

        public Recordatorio(string titulo, DateTime arecordar)
        {
            this.titulo = titulo;
            this.arecordar = arecordar;
            setID(3, titulo);
        }
    }
}
