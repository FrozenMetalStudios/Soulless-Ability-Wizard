using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using System.Windows.Forms;

namespace Souless_Ability_Creator
{
    public partial class Landing : Form
    {
        public Landing()
        {
            InitializeComponent();
        }
        private void new_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AbilityWizard abilityWizard = new AbilityWizard();
            abilityWizard.FormClosed += (s, args) => this.Close();
            abilityWizard.Show();
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDiaglog = new OpenFileDialog();

            //Set filter options and filter index
            openFileDiaglog.Filter = "JSON files(.json)|*.json|All Files (*.*)|*.*";
            openFileDiaglog.FilterIndex = 1;

            openFileDiaglog.Multiselect = true;

            //call the showdialog method to show the dialog box
            DialogResult userClickOk = openFileDiaglog.ShowDialog();

            if (userClickOk == DialogResult.OK)
            {
                this.Hide();
                ARK_AbilityWizard abilityWizardViewer = new ARK_AbilityWizard();
                string filePath = openFileDiaglog.FileName;
                abilityWizardViewer.filePath = filePath;
                abilityWizardViewer.jsonfile = System.IO.File.ReadAllText(filePath);
                abilityWizardViewer.FormClosed += (s, args) => this.Close();
                abilityWizardViewer.Show();
            }

        }
    }
}
