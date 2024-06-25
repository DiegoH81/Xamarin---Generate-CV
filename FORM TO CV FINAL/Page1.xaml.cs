using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FORM_TO_CV_FINAL
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1(string nombre, string apellido, string direccion, string correo, string telefono, DateTime fechaNacimiento, string genero, string idioma)
        {
            InitializeComponent();
            NombreLabel.Text = nombre;
            ApellidoLabel.Text = apellido;
            DireccionLabel.Text = direccion;
            CorreoLabel.Text = correo;
            TelefonoLabel.Text = telefono;
            FechaNacimientoLabel.Text = fechaNacimiento.ToShortDateString(); ;
            GeneroLabel.Text = genero;
            IdiomaLabel.Text = idioma;
        }
    }
}