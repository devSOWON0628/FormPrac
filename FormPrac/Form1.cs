using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customForm cs = new customForm();
            cs.MdiParent = this;
            cs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customForm cs = new customForm();
           // cs.MdiParent = this;//모달창은 Mdi 불가능 Mdi는 모달만 가능하다
            cs.ShowDialog();
        }
    }
}
