﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class MaterialException : Exception
    {
        public MaterialException(string mensaje, Exception inner)
            :base(mensaje, inner)
        {

        }
        public MaterialException(string mensaje)
            :this(mensaje,null)
        {

        }

    }
}