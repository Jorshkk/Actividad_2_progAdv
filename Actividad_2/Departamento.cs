using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2
{
    class Departamento
    {
        private int id;
        private string nombre;

        public Departamento()
        {

        }

        public Departamento(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public void MostrarDepartamento()
        {
            Console.WriteLine("ID Departamento: "+id+
                "\nNombre DPTO: "+nombre);
        }
    }
}
