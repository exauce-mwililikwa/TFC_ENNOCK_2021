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
    partial class OPTION : Form
    {
        MYCONNECTION M = new MYCONNECTION();
        public OPTION()
        {
            InitializeComponent();
            M.chargementTableau(dataGridView1, "SELECT * FROM OPTIONS group by id,DESIGNATION,ABREVIATION");
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (guna2TextBox1.Text == "")
            {
                errorProvider1.SetError(guna2TextBox1, "complete ce champs");
            }
            else if (guna2TextBox2.Text == "")
            {
                errorProvider1.SetError(guna2TextBox2, "complete ce champs");
            }
            else
            {
         M.EXEC_UNIVERSEL("AJOUTEOPTION", "'"+guna2TextBox1.Text+"','"+guna2TextBox2.Text+"'", "Enregistrer");
            M.chargementTableau(dataGridView1, "SELECT * FROM OPTIONS group by id,DESIGNATION,ABREVIATION");
            }
   
        }
    }
}
