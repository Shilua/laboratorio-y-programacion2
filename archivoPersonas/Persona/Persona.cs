﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    public class Persona
    {
        protected int id;
        protected string nombre;
        protected string apellido;

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Persona(int id, string nombre, string apellido)
            :this(nombre,apellido)
        {
            this.id = id;
        }

        
    }
}
