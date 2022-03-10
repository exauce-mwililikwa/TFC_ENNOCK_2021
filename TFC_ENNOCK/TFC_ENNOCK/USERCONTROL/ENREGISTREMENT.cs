using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace TFC_ENNOCK.USERCONTROL
{
    public partial class ENREGISTREMENT : UserControl
    {
        MYCONNECTION M = new MYCONNECTION();
        public ENREGISTREMENT()
        {
            InitializeComponent();
            M.chargementCombo(PROMOTION, "SELECT PROMOTION.DESIGNATION FROM AUDITOIRE INNER JOIN PROMOTION ON PROMOTION.ID=AUDITOIRE.PROMOTION INNER JOIN OPTIONS ON OPTIONS.ID=AUDITOIRE.OPTIONS GROUP BY PROMOTION.DESIGNATION");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void ENREGISTREMENT_Load(object sender, EventArgs e)
        {
            M.chargementTableau(dataGridView1, "SELECT INSCRIPTION.MATRICULE,NOM,POSTNOM,PRENOM,SEXE,CONCAT(PROMOTION.DESIGNATION,'/',OPTIONS.ABREVIATION) AS AUDITOIRE FROM INSCRIPTION INNER JOIN ETUDIANT ON ETUDIANT.ID=INSCRIPTION.ETUDIANT INNER JOIN AUDITOIRE ON AUDITOIRE.ID=INSCRIPTION.AUDITOIRE INNER JOIN PROMOTION on PROMOTION.ID=AUDITOIRE.PROMOTION inner join OPTIONS on OPTIONS.ID=AUDITOIRE.OPTIONS ORDER BY INSCRIPTION.ID DESC");
        }

        private void PROMOTION_SelectedIndexChanged(object sender, EventArgs e)
        {
            M.chargementCombo(OPTIONS, "SELECT OPTIONS.ABREVIATION FROM AUDITOIRE INNER JOIN PROMOTION ON PROMOTION.ID=AUDITOIRE.PROMOTION INNER JOIN OPTIONS ON OPTIONS.ID=AUDITOIRE.OPTIONS WHERE PROMOTION.DESIGNATION='"+PROMOTION.SelectedItem+"'");
            M.chargementTableau(dataGridView1, "SELECT INSCRIPTION.MATRICULE,NOM,POSTNOM,PRENOM,SEXE,CONCAT('',OPTIONS.ABREVIATION) AS OPTIONS FROM INSCRIPTION INNER JOIN ETUDIANT ON ETUDIANT.ID=INSCRIPTION.ETUDIANT INNER JOIN AUDITOIRE ON AUDITOIRE.ID=INSCRIPTION.AUDITOIRE INNER JOIN PROMOTION on PROMOTION.ID=AUDITOIRE.PROMOTION inner join OPTIONS on OPTIONS.ID=AUDITOIRE.OPTIONS WHERE PROMOTION.DESIGNATION='"+PROMOTION.SelectedItem+"' ORDER BY INSCRIPTION.ID DESC");
       
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            M.CHOISIR_IMAGE(pictureBox1);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string sexe;
            if (Male.Checked == true)
            {
                sexe = "M";
            }
            else
            {
                sexe = "F"; 
            }
            if (NOM.Text == "")
            {
                errorProvider1.SetError(NOM, "Ce champs ne doit pas etre vide");
            }
            else if (POSTNOM.Text == "")
            {
                errorProvider1.SetError(POSTNOM, "Ce champs ne doit pas etre vide");
            }
            else if (prenom.Text == "")
            {
                errorProvider1.SetError(prenom, "Ce champs ne doit pas etre vide");
            }
            else if (PROMOTION.SelectedIndex==-1)
            {
                errorProvider1.SetError(PROMOTION, "Selection un element");
            }
            else if (OPTIONS.SelectedIndex == -1)
            {
                errorProvider1.SetError(OPTIONS, "Selection un element");
            }
            else
            {
 M.EXEC_UNIVERSEL_picture("AJOUTEETUDIANT", "'"+NOM.Text+"','"+POSTNOM.Text+"','"+prenom.Text+"','"+sexe+"','"+LIEU.Text+"','"+DATE.Value.ToString()+"',@image,'"+PROMOTION.SelectedItem+"','"+OPTIONS.SelectedItem+"'", "Enregistrer");
            M.chargementTableau(dataGridView1, "SELECT INSCRIPTION.MATRICULE,NOM,POSTNOM,PRENOM,SEXE FROM INSCRIPTION INNER JOIN ETUDIANT ON ETUDIANT.ID=INSCRIPTION.ETUDIANT INNER JOIN AUDITOIRE ON AUDITOIRE.ID=INSCRIPTION.AUDITOIRE INNER JOIN PROMOTION on PROMOTION.ID=AUDITOIRE.PROMOTION inner join OPTIONS on OPTIONS.ID=AUDITOIRE.OPTIONS WHERE PROMOTION.DESIGNATION='" + PROMOTION.SelectedItem + "' AND OPTIONS.ABREVIATION='" + OPTIONS.SelectedItem + "' ORDER BY INSCRIPTION.ID DESC");
          
            }
           
        }

        private void OPTIONS_SelectedIndexChanged(object sender, EventArgs e)
        {
            M.chargementTableau(dataGridView1, "SELECT INSCRIPTION.MATRICULE,NOM,POSTNOM,PRENOM,SEXE FROM INSCRIPTION INNER JOIN ETUDIANT ON ETUDIANT.ID=INSCRIPTION.ETUDIANT INNER JOIN AUDITOIRE ON AUDITOIRE.ID=INSCRIPTION.AUDITOIRE INNER JOIN PROMOTION on PROMOTION.ID=AUDITOIRE.PROMOTION inner join OPTIONS on OPTIONS.ID=AUDITOIRE.OPTIONS WHERE PROMOTION.DESIGNATION='" + PROMOTION.SelectedItem + "' AND OPTIONS.ABREVIATION='"+OPTIONS.SelectedItem+"' ORDER BY INSCRIPTION.ID DESC");
            guna2Button2.Enabled = true;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            RAPPORT.LISTE_ETUDIANT rpt = new RAPPORT.LISTE_ETUDIANT();
            rpt.DataSource = M.get_Report_Z("*","LISTE_ETUDIANT"," where DESIGNATION='"+PROMOTION.SelectedItem+"' and ABREVIATION='"+OPTIONS.SelectedItem+"'");
            using (ReportPrintTool printTool = new ReportPrintTool(rpt))
            {
                printTool.ShowPreviewDialog();
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            RAPPORT.CARTE rpt = new RAPPORT.CARTE();
            rpt.DataSource = M.get_Report_Z("*", "LISTE_ETUDIANT", " where MATRICULE='"+dataGridView1.CurrentRow.Cells[0].Value.ToString()+"'");
            using (ReportPrintTool printTool = new ReportPrintTool(rpt))
            {
                printTool.ShowPreviewDialog();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            guna2Button3.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            M.chargementTableau(dataGridView1, "SELECT INSCRIPTION.MATRICULE,NOM,POSTNOM,PRENOM,SEXE,CONCAT(PROMOTION.DESIGNATION,'/',OPTIONS.ABREVIATION) AS AUDITOIRE FROM INSCRIPTION INNER JOIN ETUDIANT ON ETUDIANT.ID=INSCRIPTION.ETUDIANT INNER JOIN AUDITOIRE ON AUDITOIRE.ID=INSCRIPTION.AUDITOIRE INNER JOIN PROMOTION on PROMOTION.ID=AUDITOIRE.PROMOTION inner join OPTIONS on OPTIONS.ID=AUDITOIRE.OPTIONS where concat(NOM,' ',POSTNOM,' ',PRENOM) LIKE '"+textBox1.Text+"' ORDER BY INSCRIPTION.ID DESC");
     
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
