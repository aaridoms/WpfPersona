using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppPersona
{
    public static class ListaPersona
    {   
        // Creamos un ArrayList en el que irá guardada la información de las personas.
        public static List<Persona> personas = new List<Persona>();


        public static void AnadirPersona(Persona persona)
        {
            personas.Add(persona);
        }

        public static void MostarPersona(Persona persona)
        {
            
        }
    }
}
