using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppPersona
{
    public class Persona
    {

        //variables

        public String dni;
        public String nombre;
        public String apellidos;
        public String sexo;
        public String fechaNacimiento;
        public Double peso;
        public Double altura;


        //constructores
        public Persona(string dni, string nombre, string apellidos, string sexo, string fechaNacimiento, double peso, double altura)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Sexo = sexo;
            this.FechaNacimiento = fechaNacimiento;
            this.Peso = peso;
            this.Altura = altura;
        }

        public Persona()
        {

        }
        //accesores

        public string Dni
        {
            get => dni;
            set => dni = value;
        }
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public string Apellidos
        {
            get => apellidos;
            set => apellidos = value;
        }
        public string Sexo
        {
            get => sexo;
            set => sexo = value;
        }
        public string FechaNacimiento
        {
            get => fechaNacimiento;
            set => fechaNacimiento = value;
        }
        public double Peso
        {
            get => peso;
            set => peso = value;
        }
        public double Altura
        {
            get => altura;
            set => altura = value;
        }

        public int CompareTo(object obj)
        {
            if (obj is Persona)
            {
                return (obj as Persona).Altura.CompareTo(this.Altura);

            }
            throw new ArgumentException("El objeto no es una Persona");
        }

        public override string ToString()
        {
            return
                "DNI =" + dni + "\n" +
                "Nombre =" + nombre + "\n" +
                "Apellidos =" + apellidos + "\n" +
                "Sexo =" + sexo + "\n" +
                "Fecha de Nacimiento =" + fechaNacimiento + "\n" +
                "Peso =" + peso + "\n" +
                "Altura =" + altura + "\n";
        }
    }
}

