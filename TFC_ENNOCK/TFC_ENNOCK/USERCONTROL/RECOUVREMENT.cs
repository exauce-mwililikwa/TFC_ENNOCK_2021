using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFC_ENNOCK.USERCONTROL
{
    public partial class RECOUVREMENT : UserControl
    {
        MYCONNECTION M = new MYCONNECTION();
        public RECOUVREMENT()
        {
            InitializeComponent();
        }

     

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            M.chargementLabel(BUTOIRE, "SELECT * FROM PARAMETRE");

            if (textBox1.Text.Length == 8)
            {
                M.chargementLabel(TOTAL, "SELECT ISNULL(SUM(MOTIF.MONTANT),0) FROM MOTIF INNER JOIN AUDITOIRE ON AUDITOIRE.ID=MOTIF.AUDITOIRE INNER JOIN INSCRIPTION ON INSCRIPTION.AUDITOIRE=AUDITOIRE.ID WHERE INSCRIPTION.MATRICULE='" + textBox1.Text + "'");
                M.chargementLabel(DEJA, "SELECT ISNULL(SUM(MONTANT),0) FROM PAIEMENT  INNER JOIN INSCRIPTION ON INSCRIPTION.ID=PAIEMENT.INSCRIPTION WHERE MATRICULE='" + textBox1.Text + "'");
                M.chargementLabel(NOM, "SELECT NOM FROM ETUDIANT INNER JOIN INSCRIPTION ON INSCRIPTION.ETUDIANT=ETUDIANT.ID WHERE INSCRIPTION.MATRICULE='" + textBox1.Text + "'");
                M.chargementLabel(POSTNOM, "SELECT POSTNOM FROM ETUDIANT INNER JOIN INSCRIPTION ON INSCRIPTION.ETUDIANT=ETUDIANT.ID WHERE INSCRIPTION.MATRICULE='" + textBox1.Text + "'");
                M.chargementLabel(PRENOM, "SELECT PRENOM FROM ETUDIANT INNER JOIN INSCRIPTION ON INSCRIPTION.ETUDIANT=ETUDIANT.ID WHERE INSCRIPTION.MATRICULE='" + textBox1.Text + "'");
              
                M.GET_PHOTO("SELECT CARTE.IMAGE FROM CARTE INNER JOIN INSCRIPTION ON INSCRIPTION.ID=CARTE.INSCRIPTION WHERE INSCRIPTION.MATRICULE='" + textBox1.Text + "'", guna2CirclePictureBox1, 0);
                RESTE.Text = "" + (int.Parse(TOTAL.Text) - int.Parse(DEJA.Text));

                if (int.Parse(DEJA.Text) >= (int.Parse(TOTAL.Text) * int.Parse(BUTOIRE.Text)) / 100)
                {
                    ok.Visible = true;
                    cancel.Visible = false;
                }
                else
                {
                    cancel.Visible = true;
                   ok.Visible = false;
                }


                MATRICULE.Text = textBox1.Text;
                textBox1.Text = "";
            }
            else
            {

            }
       
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void RECOUVREMENT_Load(object sender, EventArgs e)
        {
            M.chargementLabel(BUTOIRE, "SELECT * FROM PARAMETRE");
        }
    }
}
