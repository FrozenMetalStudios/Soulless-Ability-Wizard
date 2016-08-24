using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnityEngine;
using Newtonsoft.Json;

namespace Souless_Ability_Creator
{
    
    [Serializable]
    public class Statistics
    {
        public int damage;
        public int modifier;
        public int cooldown;
        public int energy;
        public int corruption;
        public string comboDark;
        public string comboLight;

        public Statistics()
        {

        }
    }

    [Serializable]
    public class HitBox
    {
        public int length;
        public int height;

        public HitBox()
        {

        }
    }

    [Serializable]
    public class Effect
    {
        public string effectKey;
        public string animationPath;
        public int damage;
        public float duration;
        public float rate;

        public Effect()
        {

        }
    }
    [Serializable]
    public class Information
    {
        public string animationKey;
        public string animationPath;
        public string description;
        public string spritePath;
        public HitBox hitbox;
        public Information()
        {
            hitbox = new HitBox();
        }
    }
    [Serializable]
    public class AbilityObject
    {
        public string id;
        public string name;
        public string slot;
        public string type;
        public string cast;

        public Statistics statistics;
        public Information information;
        public Effect effect;

        public AbilityObject()
        {
            statistics = new Statistics();
            information = new Information();
            effect = new Effect();
        }
    }

    public class Utilities
    {
        public static void ResetAllControls(Control form)
        {
            foreach (Control parent in form.Controls)
            {
                //Resetfield(parent);
                foreach (Control control in parent.Controls)
                {
                    Resetfield(control);
                }
            }
        }

        public static void ChangeAllControls(Control form, bool state)
        {
            foreach (Control parent in form.Controls)
            {
                ChangeControls(parent, state);
                foreach (Control control in parent.Controls)
                {
                    ChangeControls(control, state);
                }
            }
        }
        private static void Resetfield(Control control)
        {
            if (control is TextBox)
            {
                TextBox textBox = (TextBox)control;
                textBox.Text = null;
            }
            if (control is RichTextBox)
            {
                RichTextBox richtextBox = (RichTextBox)control;
                richtextBox.Text = null;
            }

            if (control is ComboBox)
            {
                ComboBox comboBox = (ComboBox)control;
                if (comboBox.Items.Count > 0)
                    comboBox.SelectedIndex = 0;
            }

            if (control is CheckBox)
            {
                CheckBox checkBox = (CheckBox)control;
                checkBox.Checked = false;
            }

            if (control is ListBox)
            {
                ListBox listBox = (ListBox)control;
                listBox.ClearSelected();
            }
            if (control is PictureBox)
            {
                PictureBox pictureBox = (PictureBox)control;
                pictureBox.Image = null;
            }
        }

        private static void ChangeControls(Control control, bool state)
        {
            if (control is TextBox)
            {
                TextBox textBox = (TextBox)control;
                textBox.Enabled = state;
            }
            if (control is RichTextBox)
            {
                RichTextBox richtextBox = (RichTextBox)control;
                richtextBox.Enabled = state;
            }

            if (control is ComboBox)
            {
                ComboBox comboBox = (ComboBox)control;
                comboBox.Enabled = state;
            }

            if (control is CheckBox)
            {
                CheckBox checkBox = (CheckBox)control;
                checkBox.Enabled = state;
            }

            if (control is ListBox)
            {
                ListBox listBox = (ListBox)control;
                listBox.Enabled = state;
            }
            if (control is PictureBox)
            {
                PictureBox pictureBox = (PictureBox)control;
                pictureBox.Enabled = state;
            }
        }
        public static bool CheckAllFields(Control form)
        {
            bool fields = true;
            foreach (Control parent in form.Controls)
            {
                if (CheckFields(parent))
                {
                    fields = false;
                }
                foreach (Control control in parent.Controls)
                {
                    if (CheckFields(control))
                    {
                        fields = false;
                    }
                }
            }
            return fields;
        }

        private static bool CheckFields(Control control)
        {
            if (control is TextBox && control.Enabled)
            {
                TextBox textBox = (TextBox)control;
                return (textBox.Text == null || textBox.Text == "");
            }
            if (control is RichTextBox && control.Enabled)
            {
                RichTextBox richtextBox = (RichTextBox)control;
                return (richtextBox.Text == null || richtextBox.Text == "");
            }

            if (control is ComboBox && control.Enabled)
            {
                ComboBox comboBox = (ComboBox)control;
                return (comboBox.SelectedText == null);

            }
            if (control is PictureBox && control.Enabled)
            {
                PictureBox pictureBox = (PictureBox)control;
                return (pictureBox.Image == null);
            }
            else return false;
        }

        public static string DetermineAbilityID(AbilityObject ability)
        {
            string slotflag = GetSlotFlag(ability.slot);
            string typeflag = GetTypeFlag(ability.type);
            string castflag = GetCastFlag(ability.cast);
            string effectflag = GetEffectFlag(ability.effect.effectKey);

            string dmg = ability.statistics.damage.ToString("X3");
            string cd = ability.statistics.cooldown.ToString("X3");

            int comboflag;

            if (ability.statistics.comboDark == null || ability.statistics.comboDark == "" || ability.statistics.comboLight == null || ability.statistics.comboLight == "")
            {
                comboflag = 0;
            }
            else {
                comboflag = 1;
            }

            string id = slotflag + "-" + typeflag + "-" + castflag + "-" + effectflag + "-" + dmg + "-" + cd + "-" + comboflag.ToString();
            return id;

        }
        private static string GetSlotFlag(string slot)
        {
            if (String.Equals(slot, "AttackSlot1", StringComparison.OrdinalIgnoreCase)) return "A1";
            if (String.Equals(slot, "AttackSlot2", StringComparison.OrdinalIgnoreCase)) return "A2";
            if (String.Equals(slot, "SpellSlot1", StringComparison.OrdinalIgnoreCase)) return "S1";
            if (String.Equals(slot, "SpellSlot2", StringComparison.OrdinalIgnoreCase)) return "S2";
            if (String.Equals(slot, "SpellSlot3", StringComparison.OrdinalIgnoreCase)) return "S3";
            if (String.Equals(slot, "Ultimate", StringComparison.OrdinalIgnoreCase)) return "UL";
            else return null;
        }

        private static string GetTypeFlag(string flag)
        {
            if (String.Equals(flag, "Melee", StringComparison.OrdinalIgnoreCase)) return "ML";
            if (String.Equals(flag, "Ranged", StringComparison.OrdinalIgnoreCase)) return "RG";
            if (String.Equals(flag, "Buff", StringComparison.OrdinalIgnoreCase)) return "BF";
            if (String.Equals(flag, "Mobility", StringComparison.OrdinalIgnoreCase)) return "MB";
            if (String.Equals(flag, "Transform", StringComparison.OrdinalIgnoreCase)) return "TF";
            else return null; 
        }
        public static string GetEffectFlag(string type)
        {
            if (String.Equals(type, "Teleport", StringComparison.OrdinalIgnoreCase)) return "TP";
            if (String.Equals(type, "Dodge", StringComparison.OrdinalIgnoreCase)) return "DG";
            if (String.Equals(type, "Stun", StringComparison.OrdinalIgnoreCase)) return "SN";
            if (String.Equals(type, "Movement", StringComparison.OrdinalIgnoreCase)) return "MV";
            if (String.Equals(type, "DamageOverTime", StringComparison.OrdinalIgnoreCase)) return "DT";
            if (String.Equals(type, "DamageBuff", StringComparison.OrdinalIgnoreCase)) return "DB";
            if (String.Equals(type, "LifeSteal", StringComparison.OrdinalIgnoreCase)) return "LS";
            else return null ;
        }

        public static string GetCastFlag(string type)
        {
            if (String.Equals(type, "light", StringComparison.OrdinalIgnoreCase)) return "LT";
            if (String.Equals(type, "dark", StringComparison.OrdinalIgnoreCase)) return "DK";
            else return null;
        }

        public static AbilityObject SearchDataBase(string id, List<AbilityObject> db)
        {
            AbilityObject output = new AbilityObject();
            foreach(AbilityObject a in db)
            {
                if (String.Equals(a.id, id, StringComparison.OrdinalIgnoreCase)) output = a;
            }
            return output;
        }

        public static void UpdateDatabase(AbilityObject oldAbility, AbilityObject edittedAbility, List<AbilityObject> db)
        {
            for (int i = 0; i < db.Count; i++ )
            {
                if (String.Equals(oldAbility.id, db[i].id, StringComparison.OrdinalIgnoreCase))
                {
                    db[i] = edittedAbility;
                }
            }
        }

        public static string ConvertToJson(AbilityObject ability)
        {
            string json = JsonConvert.SerializeObject(ability, Formatting.Indented);
            return json;
        }
    }

}
