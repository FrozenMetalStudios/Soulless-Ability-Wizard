using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;



namespace Souless_Ability_Creator
{
    public partial class AbilityWizard : Form
    {
        public string jsonfile;
        private AbilityObject ability;
        private string spritePath;
        public AbilityWizard()
        {
            InitializeComponent();
            ability = new AbilityObject();
            spritePath = "";
            combo_light_textbox.Enabled = false;
            combo_dark_textbox.Enabled = false;
            effect_damage.Enabled = false;
            effect_rate_textbox.Enabled = false;
        }

        public string ConvertToJson(AbilityObject ability)
        {
            ability.id= Utilities.DetermineAbilityID(ability);
            string json = JsonConvert.SerializeObject(ability, Formatting.Indented);
            return json;
        }



        #region Form Functionality Functions
        private void combo_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (combo_checkbox.CheckState == CheckState.Unchecked || combo_checkbox.CheckState == CheckState.Indeterminate)
            {
                combo_light_textbox.Enabled = false;
                combo_dark_textbox.Enabled = false;
            }
            else
            {
                combo_light_textbox.Enabled = true;
                combo_dark_textbox.Enabled = true;
            }

        }

        private void textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 48) 
            {
                e.Handled = true;
            }
        }
        private void textbox_KeyPress_decimal(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void sprite_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDiaglog = new OpenFileDialog();

            //Set filter options and filter index
            openFileDiaglog.Filter = "All Files (*.*)|*.*";
            openFileDiaglog.FilterIndex = 1;

            openFileDiaglog.Multiselect = true;

            //call the showdialog method to show the dialog box
            DialogResult userClickOk = openFileDiaglog.ShowDialog();

            if (userClickOk == DialogResult.OK)
            {
                string img = openFileDiaglog.FileName;
                string temp = openFileDiaglog.FileName.Replace("\\", "/");
                string name = Path.GetFileNameWithoutExtension(temp);
                temp = temp.Replace(Path.GetFileName(temp), name);
                string s = temp.Substring(temp.LastIndexOf("Sprites"));
                spritePath = s;
                sprite_pictureBox.Image = new Bitmap(img);
            }
        }
        private void anim_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDiaglog = new OpenFileDialog();

            //Set filter options and filter index
            openFileDiaglog.Filter = "Animation Clips (.anim)|*.anim|All Files (*.*)|*.*";
            openFileDiaglog.FilterIndex = 1;

            openFileDiaglog.Multiselect = true;

            //call the showdialog method to show the dialog box
            DialogResult userClickOk = openFileDiaglog.ShowDialog();

            if (userClickOk == DialogResult.OK)
            {
                string temp = openFileDiaglog.FileName.Replace("\\", "/");
                string name = Path.GetFileNameWithoutExtension(temp);
                temp = temp.Replace(Path.GetFileName(temp), name);
                string s = temp.Substring(temp.LastIndexOf("Animations"));
                animation_file_textbox.Text = s;
               // animation_file_textbox.Text = Path.GetDirectoryName(openFileDiaglog.FileName).Replace("\\", "/");
              
            }
        }
        private void effect_anim_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDiaglog = new OpenFileDialog();

            //Set filter options and filter index
            openFileDiaglog.Filter = "Animation Clips (.anim)|*.anim|All Files (*.*)|*.*";
            openFileDiaglog.FilterIndex = 1;

            openFileDiaglog.Multiselect = true;

            //call the showdialog method to show the dialog box
            DialogResult userClickOk = openFileDiaglog.ShowDialog();

            if (userClickOk == DialogResult.OK)
            {
                string temp = openFileDiaglog.FileName.Replace("\\", "/");
                string name = Path.GetFileNameWithoutExtension(temp);
                temp = temp.Replace(Path.GetFileName(temp), name);
                string s = temp.Substring(temp.LastIndexOf("Animations"));
                effect_animation_textbox.Text = s;
                //effect_animation_textbox.Text = Path.GetDirectoryName(openFileDiaglog.FileName).Replace("\\", "/");

            }
        }
        private void generate_btn_Click(object sender, EventArgs e)
        {
            if (Utilities.CheckAllFields(this))
            {
                //General Information
                ability.name = name_textbox.Text;
                ability.slot = equip_slot_combobox.SelectedItem.ToString();
                ability.type = skill_type_combox.SelectedItem.ToString();
                ability.cast = cast_combobox.SelectedItem.ToString();
            
                //Statisitics
                ability.statistics.damage = Int32.Parse(damage_textbox.Text);
                ability.statistics.modifier = Int32.Parse(modifier_textbox.Text);
                ability.statistics.cooldown = Int32.Parse(cooldown_textbox.Text);
                ability.statistics.energy = Int32.Parse(energycost_textbox.Text);
                ability.statistics.corruption = Int32.Parse(corruptioncost_textbox.Text);

                if(combo_checkbox.CheckState == CheckState.Checked && combo_light_textbox != null)
                {
                    ability.statistics.comboLight = combo_light_textbox.Text;
                    ability.statistics.comboDark = combo_dark_textbox.Text;
                }
                else
                {
                    ability.statistics.comboLight = null;
                    ability.statistics.comboDark = null;
                }

                //Information
                ability.information.animationKey = animation_key_combobox.SelectedItem.ToString();
                ability.information.animationPath = animation_file_textbox.Text;
                ability.information.description = description_richTextbox.Text;
                ability.information.spritePath = spritePath;

                ability.information.hitbox.length = Int32.Parse(hitbox_length_textbox.Text);
                ability.information.hitbox.height = Int32.Parse(hitbox_height_textbox.Text);

                //Effect
                ability.effect.effectKey = effecttype_combobox.SelectedItem.ToString();
                ability.effect.duration = float.Parse(effect_duration_textbox.Text);
                ability.effect.animationPath = effect_animation_textbox.Text;

                if(String.Equals(ability.effect.effectKey, "DamageOverTime", StringComparison.OrdinalIgnoreCase))
                {
                    ability.effect.damage = Int32.Parse(effect_damage.Text);
                    ability.effect.rate = float.Parse(effect_rate_textbox.Text);
                }
                else if (String.Equals(ability.effect.effectKey, "Slow", StringComparison.OrdinalIgnoreCase) ||
                    String.Equals(ability.effect.effectKey, "DamageAmp", StringComparison.OrdinalIgnoreCase))
                {
                    ability.effect.damage = 0;
                    ability.effect.rate = float.Parse(effect_rate_textbox.Text);
                }
                else
                {
                    ability.effect.damage = 0;
                    ability.effect.rate = 0;
                }
                string json = ConvertToJson(ability);
                JsonOutputWindow viewer = new JsonOutputWindow();
                viewer.Show();
                viewer.updateRichTextBox(json);
            }
            else
            {
                MessageBox.Show("Not all fields are filled in! Please fill in the fields and Try again!", "Fields Missing!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(this);
        }
        #endregion

        private void effecttype_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.Equals(effecttype_combobox.SelectedItem.ToString(), "DamageOverTime", StringComparison.OrdinalIgnoreCase))
            {
                effect_rate_textbox.Enabled = true;
                effect_damage.Enabled = true;
            }
            else if(String.Equals(effecttype_combobox.SelectedItem.ToString(), "DamageAmp", StringComparison.OrdinalIgnoreCase) ||
                String.Equals(effecttype_combobox.SelectedItem.ToString(), "Slow", StringComparison.OrdinalIgnoreCase) ||
                String.Equals(effecttype_combobox.SelectedItem.ToString(), "Debuff", StringComparison.OrdinalIgnoreCase))
            {
                effect_rate_textbox.Enabled = true;
                effect_damage.Enabled = false;
            }
            else
            {
                effect_rate_textbox.Enabled = false;
                effect_damage.Enabled = false;
            }
        }
    }

   
}
