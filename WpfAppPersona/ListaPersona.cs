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
