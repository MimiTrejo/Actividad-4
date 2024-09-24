using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO; // Libreria para escritura y lectura de archivos

namespace Actividad_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtB_Nombre.Clear();
            txtB_Apellido.Clear();
            txtB_Telefono.Clear();
            txtB_Estatura.Clear();
            txtB_Edad.Clear();
            rBFemenino.Checked = false;
            rBMasculino.Checked = false;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            //obitiene los datos del texto box
            string nombres = txtB_Nombre.Text;
            string apellido = txtB_Apellido.Text;
            string telefono = txtB_Telefono.Text;
            string estatura = txtB_Estatura.Text;
            string edad = txtB_Edad.Text;

            //selecciond e genero
            string genero = "";
            if (rBMasculino.Checked)
            {
                genero = "masculino";
            }
            else if (rBFemenino.Checked)
            {
                genero = "Femenino";
            }
            //creacion de la cadena de datos
            string datos = $"Nombres: {nombres}\r\nApellidos: {apellido}\r\nTelefono: {telefono}\r\nEstatura: {estatura}\r\nEdad: {edad}";

            //guaardar en el txtx
            string savefile = "C:/Users/trejo/OneDrive/Escritorio/programacion/Actividad 4/datos.txt";
            //verificar si el arhcivo existe
            bool Chekfile = File.Exists(savefile);

            using (StreamWriter writer = new StreamWriter(savefile, true))
            {
                if (Chekfile)
                {
                    writer.WriteLine("*-**-*-");
                }
                writer.WriteLine(datos);
                //TEXT BOX DESPUES DEL GUARDADO
                MessageBox.Show("INFORMACION GUARDADA: \n\n" + datos, "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //TITULO, CADENA, TITULO DE LA VENTANA, BOTON DE OK AUTOGENERADO, ICONO DE LA VENATANA            
            }
        }
    }
}
