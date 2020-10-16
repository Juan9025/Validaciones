using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validaciones
{
    public partial class Form1 : Form
    {
        ValidarCajas validar = new ValidarCajas();      

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //--------------------------------Codigo de validacion
            if (!validar.Vacio(NombreIn, errorM, "el nombre no puede ser vacio"))
                if(validar.TipoTexto(NombreIn,errorM, "Debe digitar texto"))
                if (!validar.Vacio(CodigoIn, errorM, "el codigo no puede ser vacio"))
                        if(validar.TipoNumero(CodigoIn, errorM, "debe digitar numeros"))
                            if(!validar.Vacio(CorreoIn,errorM, "el correo no puede ser vacio"))
                                if (validar.TipoCorreo(CorreoIn, errorM, "el correo no cumple con el formato"))
                                {
                                    salida.Text = "todos los valores estan llenos";
                                    LimpiarCajas();
                                }
            //................................Codigo de validacion
           

            //-------funcion para limpiar cajas de texto

        }
        private void LimpiarCajas()
        {
            NombreIn.Clear();
            CodigoIn.Clear();
            CorreoIn.Clear();

        }
    }
}
