using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente : Persona
    {
        #region Fields
        private int turno;
        private static int ultimoTurnoDado;
        #endregion

        #region Properties
        public int Turno
        {
            get
            {
                return this.turno;
            }
        }
        #endregion

        #region Methods
        static Paciente()
        {
            ultimoTurnoDado = 0;
        }
        public Paciente(string apellido, string nombre)
             : base(apellido, nombre)
        {
        }
        public Paciente(string apellido, string nombre, int turno)
            :this(apellido,nombre)
        {
            this.turno = turno;
            ultimoTurnoDado++;
        }
        public override string ToString()
        {
            return string.Format("Turno Nº{0} {1},{2}", this.turno, this.apellido, this.nombre);
        }

        #endregion


    }
}
