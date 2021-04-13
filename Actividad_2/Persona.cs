using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2
{
    class Persona
    {
        private int id;
        private string nombre;
        private string direccion;
        private int fono;

        public Persona()
        {

        }
        public Persona(int id, string nombre, string direccion, int fono)
        {
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
            this.fono = fono;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Fono { get => fono; set => fono = value; }

    }
}
