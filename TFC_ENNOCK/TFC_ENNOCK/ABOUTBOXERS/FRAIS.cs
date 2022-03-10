using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFC_ENNOCK.ABOUTBOXERS
{
    partial class FRAIS : Form
    {
        MYCONNECTION M = new MYCONNECTION();
        public FRAIS()
        {
            InitializeComponent();
            M.chargementCombo(PROMOTION, "SELECT PROMOTION.DESIGNATION FROM AUDITOIRE INNER JOIN PROMOTION ON PROMOTION.ID=AUDITOIRE.PROMOTION INNER JOIN OPTIONS ON OPTIONS.ID=AUDITOIRE.OPTIONS group by PROMOTION.DESIGNATION");
      
        }

        

        private void FRAIS_Load(object sender, EventArgs e)
        {
            M.chargementTableau(dataGridView1, "SELECT VOIR_AUDITOIRE.DESIGNATION AS PROMOTION,VOIR_AUDITOIRE.ABREVIATION AS OPTIONS,MOTIF.DESIGNATION AS FRAIS ,MONTANT FROM MOTIF INNER JOIN VOIR_AUDITOIRE ON VOIR_AUDITOIRE.ID=MOTIF.AUDITOIRE");
        }

        private void PROMOTION_SelectedIndexChanged(object sender, EventArgs e)
        {
            M.chargementCombo(OPTIONS, "SELECT OPTIONS.ABREVIATION FROM AUDITOIRE INNER JOIN PROMOTION ON PROMOTION.ID=AUDITOIRE.PROMOTION INNER JOIN OPTIONS ON OPTIONS.ID=AUDITOIRE.OPTIONS WHERE PROMOTION.DESIGNATION='" + PROMOTION.SelectedItem + "'");
            M.chargementTableau(dataGridView1, "SELECT VOIR_AUDITOIRE.ABREVIATION AS OPTIONS,MOTIF.DESIGNATION AS FRAIS ,MONTANT FROM MOTIF INNER JOIN VOIR_AUDITOIRE ON VOIR_AUDITOIRE.ID=MOTIF.AUDITOIRE WHERE  VOIR_AUDITOIRE.DESIGNATION='"+PROMOTION.SelectedItem+"'");
     
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (PROMOTION.SelectedIndex == -1)
            {
                errorProvider1.SetError(PROMOTION, "completer ce champs");
            }
            else if (OPTIONS.SelectedIndex == -1)
            {
                errorProvider1.SetError(OPTIONS, "completer ce champs");
            }
            else if (DESIGNATION.Text=="")
            {
                errorProvider1.SetError(DESIGNATION, "completer ce champs");
            }
            else if (MONTANT.Text == "")
            {
                errorProvider1.SetError(DESIGNATION, "completer ce champs");
            }
            else
            {
  M.EXEC_UNIVERSEL("AJOUTERMOTIF", "'"+PROMOTION.SelectedItem+"','"+OPTIONS.SelectedItem+"','"+DESIGNATION.Text+"',"+int.Parse(MONTANT.Text)+"", "Enregistrer");
            M.chargementCombo(PROMOTION, "SELECT PROMOTION.DESIGNATION FROM AUDITOIRE INNER JOIN PROMOTION ON PROMOTION.ID=AUDITOIRE.PROMOTION INNER JOIN OPTIONS ON OPTIONS.ID=AUDITOIRE.OPTIONS");
            M.chargementTableau(dataGridView1, "SELECT VOIR_AUDITOIRE.DESIGNATION AS PROMOTION,VOIR_AUDITOIRE.ABREVIATION AS OPTIONS,MOTIF.DESIGNATION AS FRAIS ,MONTANT FROM MOTIF INNER JOIN VOIR_AUDITOIRE ON VOIR_AUDITOIRE.ID=MOTIF.AUDITOIRE");
       
            }
          
        }

        private void OPTIONS_SelectedIndexChanged(object sender, EventArgs e)
        {
            M.chargementTableau(dataGridView1, "SELECT MOTIF.DESIGNATION AS FRAIS ,MONTANT FROM MOTIF INNER JOIN VOIR_AUDITOIRE ON VOIR_AUDITOIRE.ID=MOTIF.AUDITOIRE WHERE  VOIR_AUDITOIRE.DESIGNATION='" + PROMOTION.SelectedItem + "' AND VOIR_AUDITOIRE.ABREVIATION='"+OPTIONS.SelectedItem+"'");
     
        }
    }
}
