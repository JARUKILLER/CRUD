using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ProgramaContactos : Form
    {
        private Capadenegocios _capadenegocios;
        public ProgramaContactos()
        {
            InitializeComponent();
            _capadenegocios = new Capadenegocios();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenañadircontactosDialog();
        }
        private void OpenañadircontactosDialog() 
        {
            Añadircontactos añadircontactos = new Añadircontactos();
            añadircontactos.ShowDialog(this);
        }

        private void ProgramaContactos_load(object sender, EventArgs e) 
        {
            ContactosPopulares();
        }
        public void ContactosPopulares(string textBuscador = null) 
        {
            List<Contacto> contactos = _capadenegocios.GetContactos(textBuscador);
            gridContactos.DataSource = contactos;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)gridContactos.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cell.Value.ToString() == "Editar")
            {
                Añadircontactos añadircontactos = new Añadircontactos();
                añadircontactos.CargarContacto(new Contacto
                {
                    id = int.Parse((gridContactos.Rows[e.RowIndex].Cells[0]).Value.ToString()),
                    PrimerNombre = gridContactos.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    SegundoNombre = gridContactos.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    Apellidos = gridContactos.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    Telefono = gridContactos.Rows[e.RowIndex].Cells[4].Value.ToString(),
                    Correo = gridContactos.Rows[e.RowIndex].Cells[5].Value.ToString(),
                });
                añadircontactos.ShowDialog(this);
            }
            else if (cell.Value.ToString() == " Eliminar")
            {
                EliminarContacto(int.Parse((gridContactos.Rows[e.RowIndex].Cells[0]).Value.ToString()));
                ContactosPopulares();
            }
        }

        private void EliminarContacto(int id) 
        {
            _capadenegocios.EliminarContacto(id);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ContactosPopulares(textBuscador.Text);
          
        }
    } 
}
