using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai17_TinhLaiSuat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double sotien = Convert.ToDouble(txtTien.Text);
            double laisuat = Convert.ToDouble(txtLaisuat.Text.Replace("%", ""))/100;
            int nam = Convert.ToInt32(txtNam.Text);
            double tienlai = 0;

            lstKq.Items.Clear();

            for (int i = 0; i <= nam; i++)
            {
                tienlai = sotien * laisuat / 100;
                lstKq.Items.Add("Năm " + i + ": Vốn = " + string.Format("{0:N2}",sotien) + " VND "+ " - Tiền lãi: " + string.Format("{0:N2}", tienlai) + " VND");
                sotien += tienlai;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTien.Text = "1000";
            txtLaisuat.Text = "1%";
            txtNam.Text = "10";
        }
    }
}
