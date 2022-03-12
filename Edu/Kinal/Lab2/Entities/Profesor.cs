using RegistroDeAsistencia.Edu.Kinal.Lab2.Interfaces;

namespace RegistroDeAsistencia.Edu.Kinal.Lab2.Entities
{
    public class Profesor : Persona, IOperaciones
    {
        public string CUI { get; set; }
        public string Cargo { get; set; }

        public Profesor()
        {

        }

        public Profesor(string uuid, string apellidos, string nombres, string email, string cui, string cargo)
            : base(uuid, apellidos, nombres, email)
        {
            this.CUI = cui;
            this.Cargo = cargo;
        }

        public override void TomarAsistencia()
        {
            Console.WriteLine($"Asistencia Profesor: {this.Apellidos} {this.Nombres} con cargo: {this.Cargo}");
        }

        public void ListarMisDatos(string identificador)
        {
            Console.WriteLine($"Datos: UUID:{this.UUID}, Apellidos:{this.Apellidos}, Nombres:{this.Nombres}, Cargo {this.Cargo}"); 
        }

        public bool EliminarAsignatura(string asignatura)
        {
            Console.WriteLine($"Se ha eliminado la asignatura {asignatura} del profesor Apellidos:{this.Apellidos} Nombres:{this.Nombres}"); 
            return true;
        }
    }
}