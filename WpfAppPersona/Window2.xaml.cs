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
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        // Botón utilizado para para cerrar la ventana de consulta de personas.
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        // Botón utilizado para imprimir en un textBlock todas las personas añadidas anteriormente.
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < ListaPersona.personas.Count; i++)
            {
                txt1.Inlines.Add( ListaPersona.personas[i].ToString());
            }
        }

        // Botón utilizado para buscar una persona introduciendo su DNI, si no encuentra la persona nos dará un mensaje de error.
        private void btn3_Click(object sender, RoutedEventArgs e)
        {
        
            for (int i = 0; i < ListaPersona.personas.Count; i++)
            {

                if (txt2.Text.Equals(ListaPersona.personas[i].dni))
                {
                    txt1.Inlines.Add(ListaPersona.personas[i].ToString());
                }
                else {
                    MessageBox.Show("El DNI introducido no existe.");
                }
            }
        }

        // Botón utilizado para imprimir en un textBlock la persona que mas pese. 
        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            
            Double peso = Double.MaxValue;
            Persona persona = new Persona();

            for (int i = 0; i < ListaPersona.personas.Count; i++)
            {

                if (peso > ListaPersona.personas[i].peso)
                {
                    peso = ListaPersona.personas[i].peso;
                    persona = ListaPersona.personas[i];
                }
            }

            txt1.Text = persona.ToString();
        }

        // Botón utilizado para imprimir en un textBlock la persona más baja.
        private void btn5_Click(object sender, RoutedEventArgs e)
        {
         
            Double altura = Double.MinValue;
            Persona persona = new Persona();

            for (int i = 0; i < ListaPersona.personas.Count; i++)
            {

                if (altura < ListaPersona.personas[i].altura)
                {
                    altura = ListaPersona.personas[i].peso;
                    persona = ListaPersona.personas[i];
                }
            }

            txt1.Text = persona.ToString();
        }
    }
}
