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
    public partial class DASHBOARD : UserControl
    {
        MYCONNECTION M = new MYCONNECTION();
        public DASHBOARD()
        {
            InitializeComponent();
            M.chargementLabel(ETUDINT, "select count(*) from inscription");
            M.chargementLabel(AUDITOIRE, "SELECT COUNT(*) FROM AUDITOIRE");
            M.chartchargement("SELECT PROMOTION.DESIGNATION,COUNT(INSCRIPTION.ID) FROM PROMOTION INNER JOIN AUDITOIRE ON AUDITOIRE.PROMOTION=PROMOTION.ID INNER JOIN INSCRIPTION ON INSCRIPTION.AUDITOIRE=AUDITOIRE.ID GROUP BY PROMOTION.DESIGNATION", PROMOTION);
            M.chartchargement("SELECT OPTIONS.ABREVIATION,COUNT(INSCRIPTION.ID) FROM options INNER JOIN AUDITOIRE ON AUDITOIRE.OPTIONS=OPTIONS.ID INNER JOIN INSCRIPTION ON INSCRIPTION.AUDITOIRE=AUDITOIRE.ID GROUP BY OPTIONS.ABREVIATION", OPTION);

            M.chartchargement("SELECT CONCAT(PROMOTION.DESIGNATION,' ',OPTIONS.ABREVIATION),COUNT(INSCRIPTION.ID) FROM options INNER JOIN AUDITOIRE ON AUDITOIRE.OPTIONS=OPTIONS.ID INNER JOIN INSCRIPTION ON INSCRIPTION.AUDITOIRE=AUDITOIRE.ID INNER JOIN PROMOTION ON PROMOTION.ID=AUDITOIRE.PROMOTION GROUP BY CONCAT(PROMOTION.DESIGNATION,' ',OPTIONS.ABREVIATION)", AUDITOIRES);
       
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void DASHBOARD_Load(object sender, EventArgs e)
        {

        }
    }
}
