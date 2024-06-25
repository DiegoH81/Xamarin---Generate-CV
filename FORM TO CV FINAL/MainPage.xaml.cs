using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FORM_TO_CV_FINAL
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void OnEnviarClicked(object sender, EventArgs e)
        {
            string nombre = NombreEntry.Text;
            string apellido = ApellidoEntry.Text;
            string direccion = DireccionEntry.Text;
            string correo = CorreoEntry.Text;
            string telefono = TelefonoEntry.Text;
            DateTime fechaNacimiento = FechaNacimientoPicker.Date;
            string genero = GeneroPicker.SelectedItem as string;
            string idioma = IdiomaPicker.SelectedItem as string;

            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(direccion) ||
                string.IsNullOrWhiteSpace(telefono) ||
                string.IsNullOrWhiteSpace(genero) ||
                string.IsNullOrWhiteSpace(idioma))
            {
                string mensaje = "Todos los campos son obligatorios!";
                DisplayAlert("AVISO", mensaje, "OK");
            }
            else
            {
                Navigation.PushModalAsync(new Page1(nombre, apellido, direccion, correo, telefono, fechaNacimiento, genero, idioma), true);
            }



            
        }
    }
}
