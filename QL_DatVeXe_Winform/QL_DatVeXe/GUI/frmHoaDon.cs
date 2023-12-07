using BLL_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmHoaDon : Form
    {
        HoaDon_BLL_DAL hoaDon = new HoaDon_BLL_DAL();
        public frmHoaDon()
        {
            InitializeComponent();
        }

        void loadDataHoaDon()
        {
            dtgvDSHoaDon.DataSource = hoaDon.getDataHoaDon();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            loadDataHoaDon();
        }
    }
}
