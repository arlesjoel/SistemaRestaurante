using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRestaurante
{
    public partial class FRM_Menu : Form
    {
        public FRM_Menu()
        {
            InitializeComponent();
        }

        private void GridMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FRM_Menu_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void CargarGrid()
        {
            GridMenu.DataSource = DAL_Productos.Lista();
            GridMenu.Columns[0].Visible = false;
            GridMenu.Columns[3].Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
