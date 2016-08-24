using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Souless_Ability_Creator
{
    public partial class ARK_AbilityWizard : Form
    {
        public string jsonfile;
        public string filePath;
        private bool edit = false;
        private bool selected = false;
        private bool remove = false;
        private bool saved = true;
        List<AbilityObject> abilityDB;
        private AbilityObject selectedAbility;

        enum eSkillTypes
        {
            undefined,       
            Melee,
            Ranged,
            Buff,
            Mobility,
            Transform
        }

        public static class EffectTypes
        {
            public static string undefined = "";
            public static string DamageOverTime = "DamageOverTime";
            public static string LifeSteal = "LifeSteal";
            public static string Movement = "Movement";
            public static string Stun = "Stun";
            public static string DamageBuff = "DamageBuff";
            public static string Dodge = "Dodge";
            public static string Teleport = "Teleport";
        }
        private string spritePath;

        public ARK_AbilityWizard()
        {
            InitializeComponent();
            abilityDB = new List<AbilityObject>();
            spritePath = "";
            selectedAbility = new AbilityObject();

            if (edit == false)
            {
                ControlsEnabled(this, false);
            }
        }

        private void ability_wizard_viewer_Load(object sender, EventArgs e)
        {

            abilityDB = JsonConvert.DeserializeObject<List<AbilityObject>>(jsonfile);
            PopulateTree();
            view_textbox.Text = Path.GetFileName(filePath);
        }

        private void ControlsEnabled(Control control, bool state)
        {
            Utilities.ChangeAllControls(control, state);
            hitbox_length_textbox.Enabled = state;
            hitbox_height_textbox.Enabled = state;
            if(combo_dark_textbox.Text != "" ||combo_light_textbox.Text != "" )
            {
                combo_checkbox.Checked = true;
                combo_dark_textbox.Enabled = true;
                combo_light_textbox.Enabled = true;
            }
            else
            {
                combo_checkbox.Checked = false;
                combo_dark_textbox.Enabled = false;
                combo_light_textbox.Enabled = false;
            }
            update_button.Enabled = state;
            reset_btn.Enabled = state;

        }
        private void PopulateTree()
        {
            ability_tree.Nodes.Clear();
            for (int i = 0; i < abilityDB.Count; i++)
            {
                TreeNode node;

                AbilityObject a = abilityDB[i];
                node = ability_tree.Nodes.Add(a.id);

                node = ability_tree.Nodes[i].Nodes.Add("Name");
                TreeNode topNode = node;
                node.Nodes.Add(a.name);
                node = ability_tree.Nodes[i].Nodes.Add("Slot"); 
                node.Nodes.Add(a.slot);
                node = ability_tree.Nodes[i].Nodes.Add("Type");
                node.Nodes.Add(a.type);
                node = ability_tree.Nodes[i].Nodes.Add("Cast");
                node.Nodes.Add(a.cast);

                //Statistics
                node = ability_tree.Nodes[i].Nodes.Add("Statistics");
                TreeNode node1 = node;
                node = node.Nodes.Add("Damage");
                node.Nodes.Add(a.statistics.damage.ToString());

                node = node1;
                node = node.Nodes.Add("Modifier");
                node.Nodes.Add(a.statistics.modifier.ToString());

                node = node1;
                node = node.Nodes.Add("Cooldown");
                node.Nodes.Add(a.statistics.cooldown.ToString());

                node = node1;
                node = node.Nodes.Add("Energy");
                node.Nodes.Add(a.statistics.energy.ToString());

                node = node1;
                node = node.Nodes.Add("Corruption");
                node.Nodes.Add(a.statistics.corruption.ToString());

                node = node1;
                node = node.Nodes.Add("Dark Comobo");
                node.Nodes.Add(a.statistics.comboDark);

                node = node1;
                node = node.Nodes.Add("Light Combo");
                node.Nodes.Add(a.statistics.comboLight);

                //Development Information
                node = ability_tree.Nodes[i].Nodes.Add("Development Information");
                node1 = node;
                node = node.Nodes.Add("Animation Key");
                node.Nodes.Add(a.information.animationKey);

                node = node1;
                node = node.Nodes.Add("Animation Path");
                node.Nodes.Add(a.information.animationPath);

                node = node1;
                node = node.Nodes.Add("Description");
                node.Nodes.Add(a.information.description);

                node = node1;
                node = node.Nodes.Add("SpritePath");
                node.Nodes.Add(a.information.spritePath);

                node = node1;
                node = node.Nodes.Add("Hitbox");
                TreeNode t2Node = node.Nodes.Add("Length");
                t2Node.Nodes.Add(a.information.hitbox.length.ToString());

                t2Node = node.Nodes.Add("Height");
                t2Node.Nodes.Add(a.information.hitbox.height.ToString());

                //Effect
                node = ability_tree.Nodes[i].Nodes.Add("Effect");
                node1 = node;
                node = node.Nodes.Add("Effect Key");
                node.Nodes.Add(a.effect.effectKey);

                node = node1;
                node = node.Nodes.Add("Animation Path");
                node.Nodes.Add(a.effect.animationPath);

                node = node1;
                node = node.Nodes.Add("Damage");
                node.Nodes.Add(a.effect.damage.ToString());

                node = node1;
                node = node.Nodes.Add("Duration" );
                node.Nodes.Add(a.effect.duration.ToString());

                node = node1;
                node = node.Nodes.Add("Rate");
                node.Nodes.Add(a.effect.rate.ToString());

            }
        }
        private void PopulateFields(AbilityObject a)
        {
            name_textbox.Text = a.name;
            equip_slot_combobox.Text = a.slot;
            skill_type_combox.Text = a.type;
            cast_combobox.Text = a.cast;

            damage_textbox.Text = a.statistics.damage.ToString();
            modifier_textbox.Text = a.statistics.modifier.ToString();
            cooldown_textbox.Text = a.statistics.cooldown.ToString();
            energycost_textbox.Text = a.statistics.energy.ToString();
            corruptioncost_textbox.Text = a.statistics.corruption.ToString();
            combo_dark_textbox.Text = a.statistics.comboDark;
            combo_light_textbox.Text = a.statistics.comboDark;

            animation_file_textbox.Text = a.information.animationPath;
            sprite_textbox.Text = a.information.spritePath;
            animation_key_combobox.Text = a.information.animationKey;
            hitbox_height_textbox.Text = a.information.hitbox.height.ToString();
            hitbox_length_textbox.Text = a.information.hitbox.length.ToString();


            description_richTextbox.Text = a.information.description;

            effecttype_combobox.Text = a.effect.effectKey;
            effect_animation_textbox.Text = a.effect.animationPath;

            effect_damage_textbox.Text = a.effect.damage.ToString();
            effect_duration_textbox.Text = a.effect.duration.ToString();
            effect_rate_textbox.Text = a.effect.rate.ToString();
        }

        private string CreateToolTip(AbilityObject a)
        {
            string s = "";
            s = "id:" + a.id + "\n" +
            "name:" + a.name + "\n" +
            "slot:" + a.slot + "\n" +
            "type:" + a.type + "\n" +
            "cast:" + a.cast + "\n" +
            "statistics: {\n" +  
            "\t damage:" + a.statistics.damage.ToString() + "\n" +
            "\t modifier:"+ a.statistics.modifier.ToString() + "\n" +
            "\t cooldown:" + a.statistics.cooldown.ToString()+ "\n" +
            "\t energy:"+ a.statistics.energy.ToString()+ "\n" +
            "\t corruption:"+ a.statistics.corruption + "\n" +
            "\t comboDark:" + a.statistics.comboDark+ "\n" +
            "\t comboLight:" + a.statistics.comboLight + "\n\t}\n" +

            "information{\n" +  
            "\t animationKey:" + a.information.animationKey + "\n" +
            "\t animationPath:" + a.information.animationPath + "\n" +
            "\t description:" + a.information.description + "\n" +
            "\t spritePath:" + a.information.spritePath + "\n" +
            "\t hitbox{\n" +   
            "\t\t length:" + a.information.hitbox.length.ToString() + "\n" +
            "\t\t height:" + a.information.hitbox.height.ToString() + "\n\t}\n}\n" +

            "effect{\n" +  
            "\t effectKey:" + a.effect.effectKey  + "\n" +
            "\t animationPath:" + a.effect.animationPath + "\n" +
            "\t damage:" + a.effect.damage.ToString() + "\n" +
            "\t duration:" + a.effect.duration.ToString() + "\n" +
            "\t rate:" + a.effect.rate.ToString() + "\n}";

            return s;

        }
        
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ability_tree.Nodes.Clear();
            abilityDB.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void sprite_button_Click(object sender, EventArgs e)
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
                sprite_textbox.Text = s;
                spritePath = s;
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
        private void effect_animation_button_Click(object sender, EventArgs e)
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
                // animation_file_textbox.Text = Path.GetDirectoryName(openFileDiaglog.FileName).Replace("\\", "/");

            }

        }

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

        private void ability_tree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            update_button.Text = "Update";
            ControlsEnabled(this, false);
            if (e.Button == MouseButtons.Right)
            {
                treenode_right_click.Show(Cursor.Position);
                ability_tree.SelectedNode = e.Node;
            }
            selectedAbility = Utilities.SearchDataBase(e.Node.Text, abilityDB);
            PopulateFields(selectedAbility);
            selected = true;
        }

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ControlsEnabled(this, true);
            this.Text += " ---------- Save Required";
            saved = false;
        }

        private AbilityObject GenerateAbility()
        {
            AbilityObject ability = new AbilityObject();
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

                if (combo_checkbox.CheckState == CheckState.Checked && combo_light_textbox != null)
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
                ability.information.spritePath = sprite_textbox.Text;

                ability.information.hitbox.length = Int32.Parse(hitbox_length_textbox.Text);
                ability.information.hitbox.height = Int32.Parse(hitbox_height_textbox.Text);

                //Effect
                ability.effect.effectKey = effecttype_combobox.SelectedItem.ToString();
                ability.effect.duration = float.Parse(effect_duration_textbox.Text);
                ability.effect.animationPath = effect_animation_textbox.Text;

                if (String.Equals(ability.effect.effectKey, "DamageOverTime", StringComparison.OrdinalIgnoreCase) ||
                    String.Equals(ability.effect.effectKey, "LifeSteal", StringComparison.OrdinalIgnoreCase))
                {
                    ability.effect.damage = Int32.Parse(effect_damage_textbox.Text);
                    ability.effect.rate = float.Parse(effect_rate_textbox.Text);
                }
                else if (String.Equals(ability.type, "Movement", StringComparison.OrdinalIgnoreCase) ||
                    String.Equals(ability.effect.effectKey, "DamageBuff", StringComparison.OrdinalIgnoreCase))
                {
                    ability.effect.damage = 0;
                    ability.effect.rate = float.Parse(effect_rate_textbox.Text);
                }
                else
                {
                    ability.effect.damage = 0;
                    ability.effect.rate = 0;
                }
                ability.id = Utilities.DetermineAbilityID(ability);
            }
            else
            {
                MessageBox.Show("Not all fields are filled in! Please fill in the fields and Try again!", "Fields Missing!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ability;
        }

        private void update_tree_button_Click(object sender, EventArgs e)
        {
            UpdateTree();
            update_button.Text = "Update";
        }
        private void UpdateTree()
        {
            if (selected && !remove)
            {
                AbilityObject eddited = GenerateAbility();
                Utilities.UpdateDatabase(selectedAbility, eddited, abilityDB);
            }
            else if (!remove)
            {
                AbilityObject ability = GenerateAbility();
                abilityDB.Add(ability);
            }

            PopulateTree();
            ControlsEnabled(this, false);
        }
        private void SaveAs()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "JSON files(.json)|*.json|All Files (*.*)|*.*";
            saveDialog.Title = "Save JSON file";
            saveDialog.ShowDialog();
            string file = saveDialog.FileName;
            if (file != "")
            {
                string output = JsonConvert.SerializeObject(abilityDB, Formatting.Indented);
                File.WriteAllText(file, output);
            }
            this.Text = "Ability Database Creation Tool";
            saved = true;
        }
        private void Save()
        {
            string output = JsonConvert.SerializeObject(abilityDB, Formatting.Indented);
            File.WriteAllText(filePath, output);
            this.Text = "Ability Database Creation Tool";
            saved = true;
        }

        private void Open()
        {
            if(saved)
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
                    filePath = openFileDiaglog.FileName;
                    jsonfile = System.IO.File.ReadAllText(filePath);
                }
                abilityDB = JsonConvert.DeserializeObject<List<AbilityObject>>(jsonfile);

                PopulateTree();
                view_textbox.Text = Path.GetFileName(filePath);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Save changes?", "Stupid Mistake Blocker", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    Save();
                    saved = true;
                    Open();
                }
                else saved = false;
            }
            
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == ( Keys.Control | Keys.Shift | Keys.S ))
            {
                SaveAs();
                return true;
            }
            if (keyData == (Keys.Control | Keys.A))
            {
                AddAbility();
                return true;
            }
            if (keyData == (Keys.Delete) || keyData == (Keys.Back))
            {
                Remove();
                return true;
            }
            if (keyData == (Keys.Control | Keys.E))
            {
                if(selected)
                {
                    ControlsEnabled(this, true);
                }

                return true;
            }
            if (keyData == (Keys.Control | Keys.S))
            {
                Save();
                return true;
            }
            if (keyData == (Keys.Control | Keys.O))
            {
                Open();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddAbility();
            ClearEffectTypesCombobox();
        }

        private void AddAbility()
        {
            update_button.Text = "Add";
            ControlsEnabled(this, true);
            selected = false;
            Utilities.ResetAllControls(this);
            hitbox_height_textbox.Text = null;
            hitbox_length_textbox.Text = null;
            saved = false;
            this.Text += " ---------- Save Required";
        }

        private void removeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void Remove()
        {
            DialogResult dr = MessageBox.Show("This is action is Permanent!\n Are you sure you want to delete this ability?", "WTF MANG", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                abilityDB.Remove(selectedAbility);
                remove = true;
                UpdateTree();
                remove = false;

                this.Text += " ---------- Save Required";
                saved = false;
            }
        }

        private void ARK_AbilityWizard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!saved)
            {
                DialogResult dr = MessageBox.Show("Please save your changes!\n Would you like to save your changes?", "Stupid Mistake Blocker", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dr == DialogResult.Yes)
                {
                    Save();
                    e.Cancel = false;
                }
                if(dr == DialogResult.No)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void skill_type_combox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(skill_type_combox.SelectedIndex)
            {
                case (int)eSkillTypes.Melee:
                    ClearEffectTypesCombobox();
                    effecttype_combobox.Items.Add(EffectTypes.DamageOverTime);
                    effecttype_combobox.Items.Add(EffectTypes.LifeSteal);

                    effect_duration_textbox.Enabled = true;
                    effect_rate_textbox.Enabled = true;
                    effect_damage_textbox.Enabled = true;
                    break;
                case (int)eSkillTypes.Ranged:
                    ClearEffectTypesCombobox();
                    effecttype_combobox.Items.Add(EffectTypes.DamageOverTime);
                    effecttype_combobox.Items.Add(EffectTypes.LifeSteal);

                    effect_duration_textbox.Enabled = true;
                    effect_rate_textbox.Enabled = true;
                    effect_damage_textbox.Enabled = true;
                    break;
                case (int)eSkillTypes.Buff:
                    ClearEffectTypesCombobox();
                    effecttype_combobox.Items.Add(EffectTypes.DamageBuff);
                    effecttype_combobox.Items.Add(EffectTypes.Movement);
                    effect_duration_textbox.Enabled = true;
                    effect_rate_textbox.Enabled = true;
                    effect_damage_textbox.Enabled = false;
                    break;
                case (int)eSkillTypes.Mobility:
                    ClearEffectTypesCombobox();
                    effecttype_combobox.Items.Add(EffectTypes.Dodge);
                    effecttype_combobox.Items.Add(EffectTypes.Teleport);
                    effecttype_combobox.Items.Add(EffectTypes.Stun);
                    effect_duration_textbox.Enabled = true;
                    effect_rate_textbox.Enabled = true;
                    effect_damage_textbox.Enabled = false;
                    break;
                case (int)eSkillTypes.Transform:
                    MessageBox.Show("Transform");
                    break;
            }
        }

        private void ClearEffectTypesCombobox()
        {
            effecttype_combobox.Items.Clear();
            effecttype_combobox.Items.Add(EffectTypes.undefined);
            effect_duration_textbox.Enabled = false;
            effect_rate_textbox.Enabled = false;
            effect_damage_textbox.Enabled = false;

        }
    }
}
