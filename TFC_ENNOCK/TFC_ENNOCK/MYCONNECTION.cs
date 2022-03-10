using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace TFC_ENNOCK
{
    class MYCONNECTION
    {
        public static string imgLon = "";
        public static string cons = @"Data Source=EXAUCE\SA;Initial Catalog=TFC_ENNOCK;User ID=sa;Password=aliconnorecho";
        public static SqlConnection con = new SqlConnection("" + cons);
        public static SqlCommand cmd = new SqlCommand("", con);

        SqlDataReader dr;
        public static SqlDataAdapter dt = null;
        public static DataSet ds = new DataSet();
        public void APPEL_PANEL(UserControl s, Panel pan)
        {

            s.Dock = DockStyle.Fill;
            pan.Controls.Clear();
            pan.Controls.Add(s);
            pan.Show();

        }
        public DataSet get_Report_Z(string colonnes, string nomTable, string refh)
        {
            DataSet dst;
            try
            {
                //   innitialiseConnect();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd = new SqlCommand("SELECT  " + colonnes + " FROM " + nomTable + "" + refh, con);
                //  cmd.Parameters.AddWithValue("@valchamp", valchamp);
                dt = new SqlDataAdapter(cmd);
                dst = new DataSet();
                dt.Fill(dst, nomTable);
                Console.WriteLine("SELECT  " + colonnes + " FROM " + nomTable + "" + refh);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose(); con.Close();
            }
            return dst;
        }
        public void CHOISIR_IMAGE(PictureBox picture)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|GIF Files(*.gif)|*.gif|All Files(*.*)|*.*";
            dlg.Title = "Selectionner une image";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgLon = dlg.FileName.ToString();
                picture.ImageLocation = imgLon;
            }
        }
        public void chartchargement(string rqt, Chart a)
        {


            try
            {
                //  a.Series["Series1"].Points.re
                con.Open();
                cmd.CommandText = "" + rqt;

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    a.Series["Series1"].Points.AddXY("" + dr[0].ToString(), int.Parse(dr[1].ToString()));
                }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void chargementCombo(Guna.UI2.WinForms.Suite.ComboBox cmb, string rqt)
        {
            cmb.Items.Clear();

            try
            {
                con.Open();
                cmd.CommandText = rqt;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmb.Items.Add(dr[0].ToString());
                }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void chargementTableau(DataGridView dg, string rqt)
        {
            con.Open();
            try
            {

                cmd = con.CreateCommand();
                SqlDataAdapter da = new SqlDataAdapter(rqt, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "ETUDIANT");
                dg.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            con.Close();

        }


        public void EXEC_UNIVERSEL(String proc, string parametre, string message)
        {
            con.Open();
            try
            {

                cmd.CommandText = "EXEC " + proc + " " + parametre;
                cmd.ExecuteNonQuery();
                MessageBox.Show("" + message, "Reussite", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }

        public void EXEC_UNIVERSEL_picture(String proc, string parametre, string message)
        {
            con.Open();
            try
            {
                byte[] img = null;

                cmd.Parameters.Clear();
                FileStream fs = new FileStream(imgLon, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                cmd.CommandText = "EXEC " + proc + " " + parametre;
                cmd.Parameters.Add(new SqlParameter("@IMAGE", img));
                cmd.ExecuteNonQuery();
                MessageBox.Show("" + message, "Reussite", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }

        public void JETON(String IDNATIONAL, Guna2DataGridView s, string agent)
        {

            con.Open();
            try
            {
                Console.WriteLine("EXEC JETONNER '" + IDNATIONAL + "','" + agent + "'");

                cmd.CommandText = "EXEC JETONNER '" + IDNATIONAL + "','" + agent + "'";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[0].ToString() == "1")
                    {
                        MessageBox.Show("la carte presente est fausse!", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else if (dr[0].ToString() == "2")
                    {
                        MessageBox.Show("la carte presente n'est pas celui du NORD-KIVU,elle ne peut pas etre enregistrer", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (dr[0].ToString() == "3")
                    {

                        MessageBox.Show("Interdit de traverser las barriere", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        /*con.Close();
                        s.DataSource = M.TABLEAU("SELECT TCITOYEN.IDENTIFICATIONNATIONAL,TINTERDIT.DATEDEBUT,TINTERDIT.MOTIF FROM TINTERDIT INNER JOIN TCITOYEN ON TCITOYEN.ID=TINTERDIT.CITOYEN WHERE TCITOYEN.IDENTIFICATIONNATIONAL='"+IDNATIONAL+"' AND ISNULL(TINTERDIT.DATEFIN,'00:00:00')='00:00:00'");
                        con.Open();
                        */


                    }
                    else if (dr[0].ToString() == "4")
                    {
                        MessageBox.Show("La personne n'est jamais retree le " + dr[1].ToString() + "", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (dr[0].ToString() == "5")
                    {
                        MessageBox.Show("Horaire depasse ou pas encore atteint[" + dr[1].ToString() + " a " + dr[2].ToString() + "]", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (dr[0].ToString() == "6")
                    {
                        MessageBox.Show("le nombre limite de " + dr[1].ToString() + " est deja atteint, attend l'entree des autres", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (dr[0].ToString() == "7")
                    {

                        MessageBox.Show("Enregistrer", "reussi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //   SCREEN.SORTIE.a = 1;
                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }

        public void JETON_SORTIE(String NUMEROJETON, Guna2DataGridView s)
        {
            Console.WriteLine("EXEC SCAN_JETON_SORTIE '" + NUMEROJETON + "'");
            con.Open();
            try
            {

                cmd.CommandText = "EXEC SCAN_JETON_SORTIE '" + NUMEROJETON + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (dr[0].ToString() == "8")
                    {
                        MessageBox.Show("la jeton n'est pas authentique", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else if (dr[0].ToString() == "2")
                    {
                        MessageBox.Show("le jeton n'est pas valide", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (dr[0].ToString() == "3")
                    {
                        MessageBox.Show("Interdit de traverser la barriere", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //  s.DataSource = M.TABLEAU("SELECT NOM,POSTNOM,TJETON.NUMERO,TJETON.HEURESORTIE FROM TJETON INNER JOIN TCITOYEN ON TCITOYEN.ID=TJETON.CITOYEN WHERE ISNULL(HEURESORTIE,'00:00:00')<>'00:00:00'");

                    }
                    else if (dr[0].ToString() == "4")
                    {
                        MessageBox.Show("La personne n'est jamais retree le " + dr[1].ToString() + "", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (dr[0].ToString() == "5")
                    {
                        MessageBox.Show("Horaire depasse [" + dr[1].ToString() + " a " + dr[2].ToString() + "]", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (dr[0].ToString() == "6")
                    {
                        MessageBox.Show("le nombre limite de " + dr[1].ToString() + " est deja atteint, attend l'entree des autres", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (dr[0].ToString() == "7")
                    {
                        MessageBox.Show("Enregistrer", "reussi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (dr[0].ToString() == "DEUX")
                    {
                        MessageBox.Show("Ce jeton a deja ete scanne le " + dr[2].ToString() + " a " + dr[1].ToString() + "", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }
        public void JETON_ENTRE(String NUMEROJETON, Guna2DataGridView s)
        {
            Console.WriteLine("EXEC SCAN_JETON_ENTREE '" + NUMEROJETON + "'");
            con.Open();
            try
            {

                cmd.CommandText = "EXEC SCAN_JETON_ENTREE '" + NUMEROJETON + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    if (dr[0].ToString() == "2")
                    {
                        MessageBox.Show("le jeton n'est pas enregistrer pour la date d'ajourd'hui", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (dr[0].ToString() == "3")
                    {
                        MessageBox.Show("Interdit de traverser la barriere", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //  s.DataSource = M.TABLEAU("SELECT NOM,POSTNOM,TJETON.NUMERO,TJETON.HEURESORTIE FROM TJETON INNER JOIN TCITOYEN ON TCITOYEN.ID=TJETON.CITOYEN WHERE ISNULL(HEURESORTIE,'00:00:00')<>'00:00:00'");

                    }

                    else if (dr[0].ToString() == "5")
                    {
                        MessageBox.Show("Horaire depasse [" + dr[1].ToString() + " a " + dr[2].ToString() + "]", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (dr[0].ToString() == "6")
                    {
                        MessageBox.Show("le nombre limite de " + dr[1].ToString() + " est deja atteint, attend l'entree des autres", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (dr[0].ToString() == "7")
                    {

                        //  MYCONNECTION M = new MYCONNECTION();

                        //    s.DataSource = M.TABLEAU("SELECT NOM,POSTNOM,TJETON.NUMERO,TJETON.HEURESORTIE FROM TJETON INNER JOIN TCITOYEN ON TCITOYEN.ID=TJETON.CITOYEN WHERE ISNULL(HEURESORTIE,'00:00:00')<>'00:00:00'");

                        MessageBox.Show("Enregistrer", "reussi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // cmd.Clone();
                    }
                    else if (dr[0].ToString() == "DEUX")
                    {
                        MessageBox.Show("Ce jeton n'a pas etait scanne a la sortie", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else if (dr[0].ToString() == "TROIS")
                    {
                        MessageBox.Show("Ce jeton a deja etait scanne a l'entree a " + dr[1].ToString() + "", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }


        public void GET_PHOTO(string RQT, PictureBox picemp, int row)
        {
            con.Open();
            try
            {

                cmd.CommandText = RQT + "";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    byte[] img = (byte[])(dr[row]);
                    if (img == null)
                        picemp.Image = null;
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        picemp.Image = System.Drawing.Image.FromStream(ms);
                    }

                }

                //  Console.WriteLine("select PHOTO from " + table + " where " + colonne_ref + "='" + reference + "'");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("" + ex);
            }
            con.Close();
        }

        public void chargementLabel(Label prenom,String id)
        {
            con.Open();

            try
            {

                cmd.CommandText = ""+id;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    prenom.Text = dr[0].ToString();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        public void LOGIN(String USERNAME, string password, Form s)
        {


            try
            {
                con.Open();
                cmd.CommandText = "exec LOGER 'simple','" + USERNAME + "','" + password + "','LOGER'";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[0].ToString() == "USERNAME INCORRECT")
                    {
                        MessageBox.Show("L'identifiant est invalide", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (dr[0].ToString() == "MOT DE PASSE INCORRECT")
                    {
                        MessageBox.Show("Le mot de passe est incorrect", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (dr[0].ToString() == "COMPTE DESACTIVER")
                    {
                        MessageBox.Show("Votre compte est desactivé, veuillez contacter l'administrateur", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        s.Hide();

                        //  new SCREEN.DASHBOARD("" + dr[0].ToString(), "" + dr[1].ToString(), "" + dr[2].ToString(), "" + dr[3].ToString()).Show();
                        //   con.Close();
                    }
                }
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void UNIVERSALLabel(string RQT, Label prenom, int row)
        {
            con.Open();

            try
            {

                cmd.CommandText = "" + RQT;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    prenom.Text = dr[row].ToString();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
}
