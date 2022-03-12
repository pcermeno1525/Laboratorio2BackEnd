using RegistroDeAsistencia.Edu.Kinal.Lab2.Interfaces;

namespace RegistroDeAsistencia.Edu.Kinal.Lab2.Entities
{
    public class Alumno : Persona, IOperaciones
    {
        public string Carne { get; set; }
        public int NumeroCreditos { get; set; }

        public Alumno() : base()
        {

        }

        public Alumno(string uuid, string apellidos, string nombres, string email, string carne, int numeroCreditos)        
            : base(uuid, apellidos, nombres, email)
        {
            this.Carne = carne;
            this.NumeroCreditos = numeroCreditos;
        }

        public override void TomarAsistencia()
        {
            Console.WriteLine($"Asistencia alumno: {this.Apellidos} {this.Nombres} con carné: {this.Carne}");            
        }

        public void ListarMisDatos(string identificador)
        {
            Console.WriteLine($"Datos: UUID:{this.UUID}, Apellidos:{this.Apellidos}, Nombres:{this.Nombres}, Número de Créditos {this.NumeroCreditos}"); 
        }

        public bool EliminarAsignatura(string asignatura)
        {
            Console.WriteLine($"Se ha eliminado la asignatura {asignatura} Apellidos:{this.Apellidos} Nombres:{this.Nombres}, perdera la cantidad de créditos {this.NumeroCreditos}"); 
            return true;
        }
    }
}