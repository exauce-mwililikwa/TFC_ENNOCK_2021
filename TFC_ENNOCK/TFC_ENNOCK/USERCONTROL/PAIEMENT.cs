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
    public partial class PAIEMENT : UserControl
    {
        MYCONNECTION M = new MYCONNECTION();
        public PAIEMENT()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void PAIEMENT_Load(object sender, EventArgs e)
        {
            M.chargementLabel(T_D, "SELECT SUM(PAIEMENT.MONTANT) FROM PAIEMENT WHERE CONVERT(DATE,DATETIME)=CONVERT(DATE,GETDATE())");
            M.chargementCombo(PROMOTION, "SELECT DESIGNATION FROM VOIR_AUDITOIRE");
            M.chargementTableau(dataGridView1, "SELECT INSCRIPTION.MATRICULE,NOM,POSTNOM,PRENOM,SEXE,CONCAT(PROMOTION.DESIGNATION,'/',OPTIONS.ABREVIATION) AS AUDITOIRE FROM INSCRIPTION INNER JOIN ETUDIANT ON ETUDIANT.ID=INSCRIPTION.ETUDIANT INNER JOIN AUDITOIRE ON AUDITOIRE.ID=INSCRIPTION.AUDITOIRE INNER JOIN PROMOTION on PROMOTION.ID=AUDITOIRE.PROMOTION inner join OPTIONS on OPTIONS.ID=AUDITOIRE.OPTIONS ORDER BY INSCRIPTION.ID DESC");
            label4.Visible = false;
            M.chargementTableau(dataGridView2, "SELECT SUBSTRING( CONVERT(VARCHAR(10),CONVERT(TIME,PAIEMENT.DATETIME)),1,8) AS HEURE,FORMAT(PAIEMENT.ID,'0000') AS RECU,INSCRIPTION.MATRICULE,NOM,POSTNOM,PRENOM,SEXE,MONTANT FROM PAIEMENT INNER JOIN INSCRIPTION ON INSCRIPTION.ID=PAIEMENT.INSCRIPTION INNER JOIN ETUDIANT ON ETUDIANT.ID=INSCRIPTION.ETUDIANT");
        }

        private void PROMOTION_SelectedIndexChanged(object sender, EventArgs e)
        {
            M.chargementCombo(OPTIONS, "SELECT ABREVIATION FROM VOIR_AUDITOIRE WHERE VOIR_AUDITOIRE.DESIGNATION='"+PROMOTION.SelectedItem+"'");
        }

        private void OPTIONS_SelectedIndexChanged(object sender, EventArgs e)
        {
            M.chargementLabel(TOTAL_TOTAL, "SELECT sum(MONTANT) FROM MOTIF INNER JOIN VOIR_AUDITOIRE ON VOIR_AUDITOIRE.ID=MOTIF.AUDITOIRE WHERE  VOIR_AUDITOIRE.DESIGNATION='" + PROMOTION.SelectedItem + "' AND VOIR_AUDITOIRE.ABREVIATION='" + OPTIONS.SelectedItem + "'");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            NOM.Text = "" + dataGridView1.CurrentRow.Cells[1].Value.ToString();
            POSTNOM.Text = "" + dataGridView1.CurrentRow.Cells[2].Value.ToString();
            PRENOM.Text = "" + dataGridView1.CurrentRow.Cells[3].Value.ToString();
            M.chargementLabel(TOTAL_TOTAL, "SELECT ISNULL(sum(MONTANT),0) FROM MOTIF INNER JOIN VOIR_AUDITOIRE ON VOIR_AUDITOIRE.ID=MOTIF.AUDITOIRE WHERE  CONCAT(VOIR_AUDITOIRE.DESIGNATION,'/',VOIR_AUDITOIRE.ABREVIATION)='" + dataGridView1.CurrentRow.Cells[5].Value.ToString() + "'");
       
            M.chargementLabel(DEJA, "SELECT ISNULL(SUM(MONTANT),0) FROM PAIEMENT  INNER JOIN INSCRIPTION ON INSCRIPTION.ID=PAIEMENT.INSCRIPTION WHERE MATRICULE='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'");
            M.GET_PHOTO("SELECT CARTE.IMAGE FROM CARTE INNER JOIN INSCRIPTION ON INSCRIPTION.ID=CARTE.INSCRIPTION WHERE INSCRIPTION.MATRICULE='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", guna2CirclePictureBox1, 0);
           RESTE.Text = "" + (int.Parse(TOTAL_TOTAL.Text) - int.Parse(DEJA.Text));
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (guna2TextBox1.Text == "")
            {
                errorProvider1.SetError(guna2TextBox1, "champs vide");
            }
            else
            {
                label4.Visible = false;
                if (int.Parse(RESTE.Text) < int.Parse(guna2TextBox1.Text))
                {
                    label4.Visible = true;
                }
                else
                {
                    M.EXEC_UNIVERSEL("AJOUTEPAIEMENT", "'" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'," + int.Parse(guna2TextBox1.Text) + "", "Enregistrer");
                    M.chargementTableau(dataGridView2, "SELECT SUBSTRING( CONVERT(VARCHAR(10),CONVERT(TIME,PAIEMENT.DATETIME)),1,8) AS HEURE,FORMAT(PAIEMENT.ID,'0000') AS RECU,INSCRIPTION.MATRICULE,NOM,POSTNOM,PRENOM,SEXE,MONTANT FROM PAIEMENT INNER JOIN INSCRIPTION ON INSCRIPTION.ID=PAIEMENT.INSCRIPTION INNER JOIN ETUDIANT ON ETUDIANT.ID=INSCRIPTION.ETUDIANT");

                    M.chargementLabel(TOTAL_TOTAL, "SELECT sum(MONTANT) FROM MOTIF INNER JOIN VOIR_AUDITOIRE ON VOIR_AUDITOIRE.ID=MOTIF.AUDITOIRE WHERE  CONCAT(VOIR_AUDITOIRE.DESIGNATION,'/',VOIR_AUDITOIRE.ABREVIATION)='" + dataGridView1.CurrentRow.Cells[5].Value.ToString() + "'");

                    M.chargementLabel(DEJA, "SELECT SUM(MONTANT) FROM PAIEMENT  INNER JOIN INSCRIPTION ON INSCRIPTION.ID=PAIEMENT.INSCRIPTION WHERE MATRICULE='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'");
                    RESTE.Text = "" + (int.Parse(TOTAL_TOTAL.Text) - int.Parse(DEJA.Text));
                    M.chargementLabel(T_D, "SELECT SUM(PAIEMENT.MONTANT) FROM PAIEMENT WHERE CONVERT(DATE,DATETIME)=CONVERT(DATE,GETDATE())");
                    RAPPORT.RECU rpt = new RAPPORT.RECU();
                    rpt.DataSource = M.get_Report_Z("*", "RECU", " WHERE ID=(SELECT MAX(ID) FROM RECU)");
                    using (ReportPrintTool printTool = new ReportPrintTool(rpt))
                    {
                        printTool.ShowPreviewDialog();
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            M.chargementTableau(dataGridView1, "SELECT INSCRIPTION.MATRICULE,NOM,POSTNOM,PRENOM,SEXE,CONCAT(PROMOTION.DESIGNATION,'/',OPTIONS.ABREVIATION) AS AUDITOIRE FROM INSCRIPTION INNER JOIN ETUDIANT ON ETUDIANT.ID=INSCRIPTION.ETUDIANT INNER JOIN AUDITOIRE ON AUDITOIRE.ID=INSCRIPTION.AUDITOIRE INNER JOIN PROMOTION on PROMOTION.ID=AUDITOIRE.PROMOTION inner join OPTIONS on OPTIONS.ID=AUDITOIRE.OPTIONS where concat(nom,' ',postnom,' ',prenom) like '%" + textBox1.Text+ "%' ORDER BY INSCRIPTION.ID DESC");
          
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            RAPPORT.RAPPORT_PAIEMENT rpt = new RAPPORT.RAPPORT_PAIEMENT();
            rpt.DataSource = M.get_Report_Z("*", "RECU", " WHERE FORMAT(DATETIME,'dd/MM/yyyy')='"+dateEdit1.Text+"'");
            using (ReportPrintTool printTool = new ReportPrintTool(rpt))
            {
                printTool.ShowPreviewDialog();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RAPPORT.RECU rpt = new RAPPORT.RECU();
            rpt.DataSource = M.get_Report_Z("*", "RECU", " WHERE RECU='"+dataGridView2.CurrentRow.Cells[1].Value.ToString()+"'");
            using (ReportPrintTool printTool = new ReportPrintTool(rpt))
            {
                printTool.ShowPreviewDialog();
            }
        }
    }
}
