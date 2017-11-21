using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfAppPersona
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        // Botón utilizado para insertar en el Arraylist la persona añadida.
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string dni;
            string nombre;
            string apellidos;
            string sexo = "";
            string fechaNacimiento;
            double peso;
            double altura;

            dni = txtdni.Text;
            
            nombre = txtnombre.Text;
            apellidos = txtapellidos.Text;

            if (rad1.IsChecked == true)
            {
                sexo = "Hombre";
            }
            else if (rad2.IsChecked == true)
            {
                sexo = "Mujer";
            }

            fechaNacimiento = date1.Text;
            peso = Convert.ToDouble(txtpeso.Text);
            altura = Convert.ToDouble(txtaltura.Text);

            if (ListaPersona.personas.Count <= 0)
            {
                Persona p = new Persona(dni, nombre, apellidos, sexo, fechaNacimiento, peso, altura);
                ListaPersona.AnadirPersona(p);
                MessageBox.Show("La persona se ha creado correctamente.");
                this.Close();
            }
            else
            {
                Boolean valido = true;

                for (int i = 0; i < ListaPersona.personas.Count; i++)
                {

                    if (dni.Equals(ListaPersona.personas[i].dni))
                    {

                        valido = false;
                        break;
                    }
                }

                if(valido)
                {
                    Persona p = new Persona(dni, nombre, apellidos, sexo, fechaNacimiento, peso, altura);
                    ListaPersona.AnadirPersona(p);
                    MessageBox.Show("La persona se ha creado correctamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El dni esta en uso.");
                    this.Close();
                }   
            }
        }
    }
}