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

namespace semana2
{
    /// <summary>
    /// Lógica de interacción para RegistrarConductores.xaml
    /// </summary>
    public partial class RegistrarConductores : Window
    {
        public RegistrarConductores()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            
            string nombreConductor = txtNombreConductor.Text;
            string licencia = txtLicencia.Text;
            string transporte = txtTransporte.Text;

            
            MessageBox.Show("Conductor registrado correctamente.");

            
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombreConductor.Clear();
            txtLicencia.Clear();
            txtTransporte.Clear();
        }
    }
}
