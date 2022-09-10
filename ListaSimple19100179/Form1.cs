using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaSimple19100179
{
    public partial class Form1 : Form
    {
        ClaseListaSimpleDesordenada<DeportistaOlimpicoFamoso> miListaDeportista = new ClaseListaSimpleDesordenada<DeportistaOlimpicoFamoso>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog miArchivoFoto = new OpenFileDialog();
            miArchivoFoto.Title = "Seleccione la imagen que desea cargar";
            miArchivoFoto.Filter = "Archivos de imagen |*.png;*.jpg";
            miArchivoFoto.RestoreDirectory = false; 
            miArchivoFoto.InitialDirectory = Application.StartupPath + "\\Deportistas";
            MessageBox.Show(Application.StartupPath + "\\Deportistas");
            if (miArchivoFoto.ShowDialog() == DialogResult.OK)
            {
                picImagen.ImageLocation = miArchivoFoto.FileName;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                DeportistaOlimpicoFamoso miDeportista = new DeportistaOlimpicoFamoso();
                miDeportista.Clave = int.Parse(txtClave.Text);
                miDeportista.Nombre = txtNombre.Text;
                miDeportista.FechaNacimiento = dtpFechaNacimiento.Value;
                miDeportista.DineroGenerado = double.Parse(txtDinero.Text);
                miDeportista.Categoria = cboCategoria.Text;
                miDeportista.Activo = chkActivo.Checked;
                if (radOro.Checked)
                {
                    miDeportista.Presea = 'O';
                }
                if (radPlata.Checked)
                {
                    miDeportista.Presea = 'P';
                }
                else
                {
                    miDeportista.Presea = 'B';
                }
                miDeportista.Imagen = picImagen.ImageLocation;
                miListaDeportista.AgregarNodo(miDeportista);
                dtgDeportistasOlimpicos.Rows.Clear();
                foreach (DeportistaOlimpicoFamoso deportistaOlimpicoFamoso in miListaDeportista)
                {
                    var activo = deportistaOlimpicoFamoso.Activo ? "Sigue activo" : "No esta activo";
                    dtgDeportistasOlimpicos.Rows.Add(deportistaOlimpicoFamoso.Clave, deportistaOlimpicoFamoso.Nombre, deportistaOlimpicoFamoso.FechaNacimiento, deportistaOlimpicoFamoso.DineroGenerado, deportistaOlimpicoFamoso.Categoria, activo, deportistaOlimpicoFamoso.Presea, deportistaOlimpicoFamoso.Imagen);
                }
                foreach(Control x in grpDeportista.Controls)
                {
                    if(x is TextBox)
                    {
                        x.Text = "";
                    }
                }
                cboCategoria.Text = "";
                chkActivo.Checked = false;
                MessageBox.Show("Información agregada correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string[] imagenesRutas =
            {
                Application.StartupPath + "\\Deportistas" +"\\AdrianPaz.jpg",
                Application.StartupPath + "\\Deportistas" +"\\GloriaZarza.jpg",
                Application.StartupPath + "\\Deportistas" +"\\MariaDelPilar.jpg",
                Application.StartupPath + "\\Deportistas" +"\\MichaelPhelps.jpg",
                Application.StartupPath + "\\Deportistas" +"\\RafaelNadal.jpg",
                Application.StartupPath + "\\Deportistas" +"\\RogerFederer.jpg",
                Application.StartupPath + "\\Deportistas" +"\\UsainBolt.jpg"
            };
            Random rand = new Random();
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    DeportistaOlimpicoFamoso miDeportista = new DeportistaOlimpicoFamoso();
                    miDeportista.Clave = rand.Next();
                    miDeportista.Nombre = Guid.NewGuid().ToString().Substring(0, 16);
                    miDeportista.FechaNacimiento = Convert.ToDateTime($"{rand.Next(1, 13)}/{rand.Next(1, 28)}/{rand.Next(1500, 5000)}");
                    miDeportista.DineroGenerado = double.Parse((rand.NextDouble() * 30000).ToString("N2"));
                    miDeportista.Categoria = cboCategoria.Items[rand.Next(0, 19)].ToString();
                    if (rand.Next(0, 2) == 0)
                    {
                        miDeportista.Activo = false;
                    }
                    else
                    {
                        miDeportista.Activo = true;
                    }
                    int presea = rand.Next(0, 3);
                    if (presea == 0)
                    {
                        miDeportista.Presea = 'O';
                    }
                    else if (presea == 1)
                    {
                        miDeportista.Presea = 'P';
                    }
                    else
                    {
                        miDeportista.Presea = 'B';
                    }
                    miDeportista.Imagen = imagenesRutas[rand.Next(0,7)];
                    miListaDeportista.AgregarNodo(miDeportista);
                    dtgDeportistasOlimpicos.Rows.Clear();
                    foreach (DeportistaOlimpicoFamoso deportistaOlimpicoFamoso in miListaDeportista)
                    {
                        var activo = deportistaOlimpicoFamoso.Activo ? "Sigue activo" : "No esta activo";
                        dtgDeportistasOlimpicos.Rows.Add(deportistaOlimpicoFamoso.Clave, deportistaOlimpicoFamoso.Nombre, deportistaOlimpicoFamoso.FechaNacimiento, deportistaOlimpicoFamoso.DineroGenerado, deportistaOlimpicoFamoso.Categoria, activo, deportistaOlimpicoFamoso.Presea, deportistaOlimpicoFamoso.Imagen);
                    }
                }
                MessageBox.Show("Datos agregadados correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void dtgDeportistasOlimpicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgDeportistasOlimpicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgDeportistasOlimpicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDeportistasOlimpicos.MultiSelect = false;
            if (dtgDeportistasOlimpicos.CurrentRow == null)
            {
                MessageBox.Show("No hay datos en la fila para mostrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                txtClave.Text = dtgDeportistasOlimpicos.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dtgDeportistasOlimpicos.CurrentRow.Cells[1].Value.ToString();
                dtpFechaNacimiento.Value = DateTime.Parse(dtgDeportistasOlimpicos.CurrentRow.Cells[2].Value.ToString());
                txtDinero.Text = dtgDeportistasOlimpicos.CurrentRow.Cells[3].Value.ToString();
                cboCategoria.Text = dtgDeportistasOlimpicos.CurrentRow.Cells[4].Value.ToString();
                chkActivo.Checked = dtgDeportistasOlimpicos.CurrentRow.Cells[5].Value.ToString() == "Sigue activo" ? true : false;
                if (char.Parse(dtgDeportistasOlimpicos.CurrentRow.Cells[6].Value.ToString()) == 'O')
                {
                    radOro.Checked = true;
                }
                else if (char.Parse(dtgDeportistasOlimpicos.CurrentRow.Cells[6].Value.ToString()) == 'P')
                {
                    radPlata.Checked = true;
                }
                else
                {
                    radBronce.Checked = true;
                }
                picImagen.ImageLocation = dtgDeportistasOlimpicos.CurrentRow.Cells[7].Value.ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DeportistaOlimpicoFamoso deportista = new DeportistaOlimpicoFamoso();
            try
            {
                DialogResult decision = MessageBox.Show("Desea eliminar el dato seleccionado?", "Advertencia", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (decision == DialogResult.Yes)
                {
                    deportista.Clave = int.Parse(dtgDeportistasOlimpicos.CurrentRow.Cells[0].Value.ToString());
                    //deportista.Nombre = dtgDeportistasOlimpicos.CurrentRow.Cells[1].Value.ToString();
                    //deportista.FechaNacimiento = DateTime.Parse(dtgDeportistasOlimpicos.CurrentRow.Cells[2].Value.ToString());
                    //deportista.DineroGenerado = double.Parse(dtgDeportistasOlimpicos.CurrentRow.Cells[3].Value.ToString());
                    //deportista.Categoria = dtgDeportistasOlimpicos.CurrentRow.Cells[4].Value.ToString();
                    //deportista.Activo = dtgDeportistasOlimpicos.CurrentRow.Cells[5].Value.ToString() == "Sigue activo" ? true : false;
                    //if (char.Parse(dtgDeportistasOlimpicos.CurrentRow.Cells[6].Value.ToString()) == 'O')
                    //{
                    //    deportista.Presea = 'O';
                    //}
                    //else if (char.Parse(dtgDeportistasOlimpicos.CurrentRow.Cells[6].Value.ToString()) == 'P')
                    //{
                    //    deportista.Presea = 'P';
                    //}
                    //else
                    //{
                    //    deportista.Presea = 'B';
                    //}
                    dtgDeportistasOlimpicos.Rows.Clear();
                    deportista = miListaDeportista.EliminarNodo(deportista);
                    MessageBox.Show($"Se elimino el deportista con los datos: \nNombre: {deportista.Nombre}\nCon clave de: {deportista.Clave}");
                    foreach (DeportistaOlimpicoFamoso deportistaOlimpicoFamoso in miListaDeportista)
                    {
                        var activo = deportistaOlimpicoFamoso.Activo ? "Sigue activo" : "No esta activo";
                        dtgDeportistasOlimpicos.Rows.Add(deportistaOlimpicoFamoso.Clave, deportistaOlimpicoFamoso.Nombre, deportistaOlimpicoFamoso.FechaNacimiento, deportistaOlimpicoFamoso.DineroGenerado, deportistaOlimpicoFamoso.Categoria, activo, deportistaOlimpicoFamoso.Presea, deportistaOlimpicoFamoso.Imagen);
                    }
                    foreach (Control x in grpDeportista.Controls)
                    {
                        if (x is TextBox)
                        {
                            x.Text = "";
                        }
                    }
                    cboCategoria.Text = "";
                    chkActivo.Checked = false;
                }
                else
                {
                    MessageBox.Show("El dato seleccionado no se elimino.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult decision = MessageBox.Show("Desea vaciar la lista?", "Advertencia", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (decision == DialogResult.Yes)
                {
                    miListaDeportista.Vaciar();
                    dtgDeportistasOlimpicos.Rows.Clear();
                    foreach (DeportistaOlimpicoFamoso deportistaOlimpicoFamoso in miListaDeportista)
                    {
                        var activo = deportistaOlimpicoFamoso.Activo ? "Sigue activo" : "No esta activo";
                        dtgDeportistasOlimpicos.Rows.Add(deportistaOlimpicoFamoso.Clave, deportistaOlimpicoFamoso.Nombre, deportistaOlimpicoFamoso.FechaNacimiento, deportistaOlimpicoFamoso.DineroGenerado, deportistaOlimpicoFamoso.Categoria, activo, deportistaOlimpicoFamoso.Presea, deportistaOlimpicoFamoso.Imagen);
                    }
                    foreach (Control x in grpDeportista.Controls)
                    {
                        if (x is TextBox)
                        {
                            x.Text = "";
                        }
                    }
                    cboCategoria.Text = "";
                    chkActivo.Checked = false;
                }
                else
                {
                    MessageBox.Show("Se cancelo la operacion de vaciar.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
