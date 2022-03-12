using RegistroDeAsistencia.Edu.Kinal.Lab2.Entities;
public class Sistema {
    public static void Main(string[] args) {
        List<Persona> ListaGeneral = new List<Persona>();

        Alumno alumno = new Alumno(Guid.NewGuid().ToString(), "Cermeño", "Pablo", "alumno@gmail.com","2022-0001", 5);
        Alumno alumno2 = new Alumno(Guid.NewGuid().ToString(), "Letran", "Francisco", "alumno2@gmail.com","2022-0002", 10);
        Profesor profesor = new Profesor(Guid.NewGuid().ToString(), "Estrada","José","profesor@gmail.com", "2168017100101","maestro computación");                       
        Profesor profesor2 = new Profesor(Guid.NewGuid().ToString(), "Gonzalez","Javier","profesor2@gmail.com", "4215462540101","maestro matemáticas");                       

        ListaGeneral.Add(alumno);
        ListaGeneral.Add(alumno2);
        ListaGeneral.Add(profesor);              
        ListaGeneral.Add(profesor2);              

        OperarRegistro(ListaGeneral);
        RegistarAsistencia(ListaGeneral);
        VerMisDatos(ListaGeneral);
        QuitarAsignatura(ListaGeneral);

    }    
    static void OperarRegistro(List<Persona> elemento)
    {
        Console.WriteLine($"Registro General:");
        foreach (Persona persona in elemento)
        {
            if(persona is Alumno)
            {
                Console.WriteLine($"Registro de alumno: {persona.Nombres} {persona.Apellidos} con carné: {((Alumno)persona).Carne}");                
            }
            else if(persona is Profesor)
            {
                Console.WriteLine($"Registro de Profesor: {persona.Nombres} {persona.Apellidos} con cargo: {((Profesor)persona).Cargo}");

            }
        }

    }
    static void RegistarAsistencia(List<Persona> elemento)
    {
        Console.WriteLine($"Registro de Asistencia:");
        foreach (Persona persona in elemento)
        {
            persona.TomarAsistencia();            
        }
    }

    static void VerMisDatos(List<Persona> elemento)
    {
        Console.WriteLine($"Datos de Persona: ");
        foreach (Persona persona in elemento)
        {
            if(persona is Alumno)
            {
                ((Alumno)persona).ListarMisDatos(((Alumno)persona).Carne);                
            }
            else if(persona is Profesor)
            {
                ((Profesor)persona).ListarMisDatos(((Profesor)persona).CUI);
            }
        }
    }

    static void QuitarAsignatura(List<Persona> elemento)
    {
        Console.WriteLine($"Eliminando Asignatura: ");
        foreach (Persona persona in elemento)
        {
            if(persona is Alumno)
            {
                ((Alumno)persona).EliminarAsignatura("Matemáticas");                
            }
            else if(persona is Profesor)
            {
                ((Profesor)persona).EliminarAsignatura("Computación");
            }
        }
    }
}