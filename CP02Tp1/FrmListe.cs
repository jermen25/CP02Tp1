using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP02Tp1
{
    public partial class FrmListe : Form
    {
        public FrmListe()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtSaisie.Text == "" ) // Si aucun item sélectionné
            {
                // Message d'avertissement – attention instruction sur une seule ligne
                MessageBox.Show("Vous devez remplir le champs", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                // Ajouter le contenu de la textbox à la liste
                lstListe.Items.Add(txtSaisie.Text);
                // Effacer le contenu de la textbox
                txtSaisie.Text = "";
                // txtSaisie.Clear() --> aurait la même fonction
            }
            // Remettre le focus (le curseur) sur la textbox
            txtSaisie.Focus();
        }

       
            private void btnSupprimer_Click(object sender, EventArgs e)
            {
            if (lstListe.SelectedIndex == -1) // Si aucun item sélectionné
            {
                // Message d'avertissement – attention instruction sur une seule ligne
                MessageBox.Show("Vous devez sélectionner un élément dans la liste", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                // Suppression possible et effectuée
                lstListe.Items.RemoveAt(lstListe.SelectedIndex);
            }
        }

        
    }
}
