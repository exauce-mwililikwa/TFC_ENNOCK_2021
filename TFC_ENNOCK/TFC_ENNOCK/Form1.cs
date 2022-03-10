using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFC_ENNOCK
{
    public partial class Form1 : Form
    {
        MYCONNECTION M = new MYCONNECTION();
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            M.APPEL_PANEL(new USERCONTROL.ENREGISTREMENT(), panel1);
        }

        private void promotionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ABOUTBOXERS.PROMOTION().ShowDialog();
        }

        private void optionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ABOUTBOXERS.OPTION().ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            M.APPEL_PANEL(new USERCONTROL.PAIEMENT(), panel1);
        }

        private void auditoireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ABOUTBOXERS.AUDITOIRE().ShowDialog();
        }

        private void fraisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ABOUTBOXERS.FRAIS().ShowDialog();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            M.APPEL_PANEL(new USERCONTROL.RECOUVREMENT(), panel1);
        }

        private void recouvrementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ABOUTBOXERS.RECOUVREMENT_PARAMETRE().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            M.APPEL_PANEL(new USERCONTROL.DASHBOARD(), panel1);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            M.APPEL_PANEL(new USERCONTROL.DASHBOARD(), panel1);
        }
    }
}
