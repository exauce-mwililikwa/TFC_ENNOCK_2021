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
    partial class AUDITOIRE : Form
    {
        MYCONNECTION M = new MYCONNECTION();
        public AUDITOIRE()
        {
            InitializeComponent();
            M.chargementCombo(PROMOTION, "SELECT DESIGNATION FROM PROMOTION GROUP BY DESIGNATION");
            M.chargementCombo(OPTION, "SELECT ABREVIATION FROM OPTIONS GROUP BY ABREVIATION");
            M.chargementTableau(dataGridView1, "SELECT AUDITOIRE.ID,PROMOTION.DESIGNATION AS PROMOTION,OPTIONS.ABREVIATION AS OPTIONS FROM AUDITOIRE INNER JOIN PROMOTION ON PROMOTION.ID=AUDITOIRE.PROMOTION INNER JOIN OPTIONS ON OPTIONS.ID=AUDITOIRE.OPTIONS");
       
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (PROMOTION.SelectedIndex == -1)
            {
                errorProvider1.SetError(PROMOTION, "selectionner une promotion");
            }
         else   if (OPTION.SelectedIndex == -1)
            {
                errorProvider1.SetError(OPTION, "selectionner une promotion");
            }
            else
            {
      M.EXEC_UNIVERSEL("AJOUTEAUDITOIRE", "'" + PROMOTION.SelectedItem + "','" + OPTION.SelectedItem + "'", "Enregistrer");
            M.chargementTableau(dataGridView1, "SELECT AUDITOIRE.ID,PROMOTION.DESIGNATION AS PROMOTION,OPTIONS.ABREVIATION AS OPTIONS FROM AUDITOIRE INNER JOIN PROMOTION ON PROMOTION.ID=AUDITOIRE.PROMOTION INNER JOIN OPTIONS ON OPTIONS.ID=AUDITOIRE.OPTIONS");
      
            }
        }
    }
}
