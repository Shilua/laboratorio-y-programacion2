﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorreoLibrary
{
    class TrackingIdRepetidoException : Exception
    {
        public TrackingIdRepetidoException(string mensaje, Exception inner)
            :base(mensaje, inner)
        {

        }
        public TrackingIdRepetidoException(string mensaje)
            :this(mensaje,null)
        {

        }
    }
}