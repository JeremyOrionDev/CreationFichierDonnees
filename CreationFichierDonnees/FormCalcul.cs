using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace CreationFichierDonnees
{
    public partial class FormCalcul : Form
    {
        Int64 nbDepart, nbFin, Qte;
        string nom = "";
        Timer T = new Timer();
        public FormCalcul()
        {
            InitializeComponent();
        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {
            if (ctrlBox())
            {
                nbDepart = Convert.ToInt64(tBxDepart.Text);
                Qte = Convert.ToInt64(tBxQte.Text);
                nbFin = nbDepart + Qte - 1;
                tBxFin.Text = nbFin.ToString();
            }
            
        }

        private bool ctrlBox()
        {
            string mText = "Merci de remplir le(s) champ(s) ci-dessous:" + "\n";
            foreach (TextBox item in this.Controls.OfType<TextBox>())
            {
                if (item.Text == string.Empty)
                {
                    if (item.Name == "tBxNom")
                    {
                        mText += "Le nom est vide" + "\n";
                    }
                    else if (item.Name == "tBxDepart")
                    {
                        mText += "La valeur de départ est vide" + "\n";
                    }
                    else if (item.Name == "tBxQte")
                    {
                        mText += "La quantité est vide" + "\n";
                    }
                }

            }
            if (mText != "Merci de remplir le(s) champ(s) ci-dessous:" + "\n")
            {
                MessageBox.Show(mText, "Champs vide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }

        /// <summary>
        /// Test a directory for create file access permissions
        /// </summary>
        /// <param name="DirectoryPath">Full path to directory </param>
        /// <param name="AccessRight">File System right tested</param>
        /// <returns>State [bool]</returns>
        public static bool DirectoryHasPermission(string DirectoryPath, FileSystemRights AccessRight)
        {
            if (string.IsNullOrEmpty(DirectoryPath)) return false;

            try
            {
                AuthorizationRuleCollection rules = Directory.GetAccessControl(DirectoryPath).GetAccessRules(true, true, typeof(System.Security.Principal.SecurityIdentifier));
                WindowsIdentity identity = WindowsIdentity.GetCurrent();

                foreach (FileSystemAccessRule rule in rules)
                {
                    if (identity.Groups.Contains(rule.IdentityReference))
                    {
                        if ((AccessRight & rule.FileSystemRights) == AccessRight)
                        {
                            if (rule.AccessControlType == AccessControlType.Allow)
                                return true;
                        }
                    }
                }
            }
            catch { }
            return false;
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {

            if (ctrlBox())
            {


                FolderBrowserDialog folder = new FolderBrowserDialog
                {
                    RootFolder = Environment.SpecialFolder.MyComputer
                };
                while (folder.ShowDialog() == DialogResult.OK||folder.ShowDialog()==DialogResult.Retry)
                {
                    if (DirectoryHasPermission(folder.SelectedPath,FileSystemRights.CreateFiles))
                    {         
                        nom = folder.SelectedPath + "\\" + tBxNom.Text + ".csv";
                        StreamWriter writer = new StreamWriter(nom, true);
                        for (Int64 i = nbDepart; i < nbFin + 1; i++)
                        {
                            writer.Write(i);
                            writer.WriteLine();
                        }
                        writer.Close();
                        MessageBox.Show("Fichier crée: " + "\n" + nom);
                        if (MessageBox.Show("Voulez-vous créer un nouveau fichier de données?", "Avez-vous terminé?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            nbDepart = nbFin = Qte = 0;
                            tBxDepart.Clear();
                            tBxFin.Clear();
                            tBxNom.Clear();
                            tBxQte.Clear();
                            return;
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vous n'avez pas le droit d'écrire dans ce dossier."+"\n"+"Veuillez en sélectionner un autre","Erreur accès dossier",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
                        
                    }
                }
            }
        }


    }
}
