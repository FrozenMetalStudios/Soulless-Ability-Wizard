namespace Souless_Ability_Creator
{
    partial class ARK_AbilityWizard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ARK_AbilityWizard));
            this.ability_tree = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ability_dev_information = new System.Windows.Forms.GroupBox();
            this.sprite_button = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.sprite_textbox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.combo_dark_textbox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.combo_checkbox = new System.Windows.Forms.CheckBox();
            this.combo_light_textbox = new System.Windows.Forms.TextBox();
            this.anim_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.hitbox_height_textbox = new System.Windows.Forms.TextBox();
            this.hitbox_length_textbox = new System.Windows.Forms.TextBox();
            this.animation_key_combobox = new System.Windows.Forms.ComboBox();
            this.description_richTextbox = new System.Windows.Forms.RichTextBox();
            this.animation_file_textbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.base_groupbox = new System.Windows.Forms.GroupBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.skill_type_combox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.slot_label = new System.Windows.Forms.Label();
            this.equip_slot_combobox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cast_combobox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.effect_animation_button = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.effect_animation_textbox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.effect_damage_textbox = new System.Windows.Forms.TextBox();
            this.effect_rate_label = new System.Windows.Forms.Label();
            this.effect_rate_textbox = new System.Windows.Forms.TextBox();
            this.effect_label = new System.Windows.Forms.Label();
            this.effect_duration_textbox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.effecttype_combobox = new System.Windows.Forms.ComboBox();
            this.ability_satistics = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.energycost_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.corruptioncost_textbox = new System.Windows.Forms.TextBox();
            this.damage_textbox = new System.Windows.Forms.TextBox();
            this.cooldown_textbox = new System.Windows.Forms.TextBox();
            this.modifier_textbox = new System.Windows.Forms.TextBox();
            this.reset_btn = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.treenode_right_click = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.view_textbox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.ability_dev_information.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.base_groupbox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ability_satistics.SuspendLayout();
            this.treenode_right_click.SuspendLayout();
            this.SuspendLayout();
            // 
            // ability_tree
            // 
            this.ability_tree.Location = new System.Drawing.Point(12, 38);
            this.ability_tree.Name = "ability_tree";
            this.ability_tree.Size = new System.Drawing.Size(241, 353);
            this.ability_tree.TabIndex = 0;
            this.ability_tree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ability_tree_NodeMouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(898, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.newToolStripMenuItem.Text = "New file";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.insertToolStripMenuItem,
            this.editToolStripMenuItem1,
            this.removeToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.insertToolStripMenuItem.Text = "Insert";
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // ability_dev_information
            // 
            this.ability_dev_information.Controls.Add(this.sprite_button);
            this.ability_dev_information.Controls.Add(this.label18);
            this.ability_dev_information.Controls.Add(this.sprite_textbox);
            this.ability_dev_information.Controls.Add(this.label19);
            this.ability_dev_information.Controls.Add(this.combo_dark_textbox);
            this.ability_dev_information.Controls.Add(this.label16);
            this.ability_dev_information.Controls.Add(this.combo_checkbox);
            this.ability_dev_information.Controls.Add(this.combo_light_textbox);
            this.ability_dev_information.Controls.Add(this.anim_btn);
            this.ability_dev_information.Controls.Add(this.groupBox1);
            this.ability_dev_information.Controls.Add(this.animation_key_combobox);
            this.ability_dev_information.Controls.Add(this.description_richTextbox);
            this.ability_dev_information.Controls.Add(this.animation_file_textbox);
            this.ability_dev_information.Controls.Add(this.label9);
            this.ability_dev_information.Controls.Add(this.label10);
            this.ability_dev_information.Controls.Add(this.label11);
            this.ability_dev_information.Location = new System.Drawing.Point(259, 170);
            this.ability_dev_information.Name = "ability_dev_information";
            this.ability_dev_information.Size = new System.Drawing.Size(437, 221);
            this.ability_dev_information.TabIndex = 21;
            this.ability_dev_information.TabStop = false;
            this.ability_dev_information.Text = "Information";
            // 
            // sprite_button
            // 
            this.sprite_button.Location = new System.Drawing.Point(272, 47);
            this.sprite_button.Name = "sprite_button";
            this.sprite_button.Size = new System.Drawing.Size(30, 20);
            this.sprite_button.TabIndex = 34;
            this.sprite_button.Text = "...";
            this.sprite_button.UseVisualStyleBackColor = true;
            this.sprite_button.Click += new System.EventHandler(this.sprite_button_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(39, 54);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 33;
            this.label18.Text = "Sprite:";
            // 
            // sprite_textbox
            // 
            this.sprite_textbox.Location = new System.Drawing.Point(101, 47);
            this.sprite_textbox.Name = "sprite_textbox";
            this.sprite_textbox.ReadOnly = true;
            this.sprite_textbox.Size = new System.Drawing.Size(165, 20);
            this.sprite_textbox.TabIndex = 32;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 129);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 13);
            this.label19.TabIndex = 31;
            this.label19.Text = "Dark Combo Skill:";
            // 
            // combo_dark_textbox
            // 
            this.combo_dark_textbox.Location = new System.Drawing.Point(101, 126);
            this.combo_dark_textbox.Name = "combo_dark_textbox";
            this.combo_dark_textbox.Size = new System.Drawing.Size(151, 20);
            this.combo_dark_textbox.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 103);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Light Combo Skill";
            // 
            // combo_checkbox
            // 
            this.combo_checkbox.AutoSize = true;
            this.combo_checkbox.Location = new System.Drawing.Point(258, 103);
            this.combo_checkbox.Name = "combo_checkbox";
            this.combo_checkbox.Size = new System.Drawing.Size(88, 17);
            this.combo_checkbox.TabIndex = 28;
            this.combo_checkbox.Text = "Combo-able?";
            this.combo_checkbox.UseVisualStyleBackColor = true;
            this.combo_checkbox.CheckedChanged += new System.EventHandler(this.combo_checkbox_CheckedChanged);
            // 
            // combo_light_textbox
            // 
            this.combo_light_textbox.Location = new System.Drawing.Point(101, 100);
            this.combo_light_textbox.Name = "combo_light_textbox";
            this.combo_light_textbox.Size = new System.Drawing.Size(151, 20);
            this.combo_light_textbox.TabIndex = 26;
            // 
            // anim_btn
            // 
            this.anim_btn.Location = new System.Drawing.Point(272, 21);
            this.anim_btn.Name = "anim_btn";
            this.anim_btn.Size = new System.Drawing.Size(30, 20);
            this.anim_btn.TabIndex = 23;
            this.anim_btn.Text = "...";
            this.anim_btn.UseVisualStyleBackColor = true;
            this.anim_btn.Click += new System.EventHandler(this.anim_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.hitbox_height_textbox);
            this.groupBox1.Controls.Add(this.hitbox_length_textbox);
            this.groupBox1.Location = new System.Drawing.Point(315, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(107, 75);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hit Box";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Height:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Length:";
            // 
            // hitbox_height_textbox
            // 
            this.hitbox_height_textbox.Location = new System.Drawing.Point(62, 44);
            this.hitbox_height_textbox.Name = "hitbox_height_textbox";
            this.hitbox_height_textbox.Size = new System.Drawing.Size(41, 20);
            this.hitbox_height_textbox.TabIndex = 12;
            // 
            // hitbox_length_textbox
            // 
            this.hitbox_length_textbox.Location = new System.Drawing.Point(62, 18);
            this.hitbox_length_textbox.Name = "hitbox_length_textbox";
            this.hitbox_length_textbox.Size = new System.Drawing.Size(41, 20);
            this.hitbox_length_textbox.TabIndex = 11;
            // 
            // animation_key_combobox
            // 
            this.animation_key_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.animation_key_combobox.FormattingEnabled = true;
            this.animation_key_combobox.Items.AddRange(new object[] {
            "",
            "BasicAttack1",
            "BasicAttack2",
            "Ability1",
            "Ability2",
            "Ability3",
            "Ultimate"});
            this.animation_key_combobox.Location = new System.Drawing.Point(101, 73);
            this.animation_key_combobox.Name = "animation_key_combobox";
            this.animation_key_combobox.Size = new System.Drawing.Size(121, 21);
            this.animation_key_combobox.TabIndex = 21;
            // 
            // description_richTextbox
            // 
            this.description_richTextbox.Location = new System.Drawing.Point(101, 152);
            this.description_richTextbox.Name = "description_richTextbox";
            this.description_richTextbox.Size = new System.Drawing.Size(321, 63);
            this.description_richTextbox.TabIndex = 9;
            this.description_richTextbox.Text = "";
            // 
            // animation_file_textbox
            // 
            this.animation_file_textbox.Location = new System.Drawing.Point(101, 21);
            this.animation_file_textbox.Name = "animation_file_textbox";
            this.animation_file_textbox.ReadOnly = true;
            this.animation_file_textbox.Size = new System.Drawing.Size(165, 20);
            this.animation_file_textbox.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Animation key:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Animation:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Description:";
            // 
            // base_groupbox
            // 
            this.base_groupbox.Controls.Add(this.name_textbox);
            this.base_groupbox.Controls.Add(this.skill_type_combox);
            this.base_groupbox.Controls.Add(this.label1);
            this.base_groupbox.Controls.Add(this.slot_label);
            this.base_groupbox.Controls.Add(this.equip_slot_combobox);
            this.base_groupbox.Controls.Add(this.label8);
            this.base_groupbox.Controls.Add(this.label7);
            this.base_groupbox.Controls.Add(this.cast_combobox);
            this.base_groupbox.Location = new System.Drawing.Point(259, 38);
            this.base_groupbox.Name = "base_groupbox";
            this.base_groupbox.Size = new System.Drawing.Size(222, 126);
            this.base_groupbox.TabIndex = 22;
            this.base_groupbox.TabStop = false;
            this.base_groupbox.Text = "Base";
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(95, 15);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(121, 20);
            this.name_textbox.TabIndex = 32;
            // 
            // skill_type_combox
            // 
            this.skill_type_combox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skill_type_combox.FormattingEnabled = true;
            this.skill_type_combox.Items.AddRange(new object[] {
            "",
            "Melee",
            "Ranged",
            "Buff",
            "Mobility",
            "Transform"});
            this.skill_type_combox.Location = new System.Drawing.Point(95, 66);
            this.skill_type_combox.Name = "skill_type_combox";
            this.skill_type_combox.Size = new System.Drawing.Size(121, 21);
            this.skill_type_combox.TabIndex = 28;
            this.skill_type_combox.SelectedIndexChanged += new System.EventHandler(this.skill_type_combox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Name:";
            // 
            // slot_label
            // 
            this.slot_label.AutoSize = true;
            this.slot_label.Location = new System.Drawing.Point(5, 41);
            this.slot_label.Name = "slot_label";
            this.slot_label.Size = new System.Drawing.Size(84, 13);
            this.slot_label.TabIndex = 26;
            this.slot_label.Text = "Equippable Slot:";
            // 
            // equip_slot_combobox
            // 
            this.equip_slot_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equip_slot_combobox.FormattingEnabled = true;
            this.equip_slot_combobox.Items.AddRange(new object[] {
            "",
            "AttackSlot1",
            "AttackSlot2",
            "SpellSlot1",
            "SpellSlot2",
            "SpellSlot3",
            "Ultimate"});
            this.equip_slot_combobox.Location = new System.Drawing.Point(95, 39);
            this.equip_slot_combobox.Name = "equip_slot_combobox";
            this.equip_slot_combobox.Size = new System.Drawing.Size(121, 21);
            this.equip_slot_combobox.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Skill Cast:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Skill Type:";
            // 
            // cast_combobox
            // 
            this.cast_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cast_combobox.FormattingEnabled = true;
            this.cast_combobox.Items.AddRange(new object[] {
            "",
            "Dark",
            "Light"});
            this.cast_combobox.Location = new System.Drawing.Point(95, 93);
            this.cast_combobox.Name = "cast_combobox";
            this.cast_combobox.Size = new System.Drawing.Size(121, 21);
            this.cast_combobox.TabIndex = 29;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.effect_animation_button);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.effect_animation_textbox);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.effect_damage_textbox);
            this.groupBox2.Controls.Add(this.effect_rate_label);
            this.groupBox2.Controls.Add(this.effect_rate_textbox);
            this.groupBox2.Controls.Add(this.effect_label);
            this.groupBox2.Controls.Add(this.effect_duration_textbox);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.effecttype_combobox);
            this.groupBox2.Location = new System.Drawing.Point(487, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 126);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Effects";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // effect_animation_button
            // 
            this.effect_animation_button.Location = new System.Drawing.Point(202, 65);
            this.effect_animation_button.Name = "effect_animation_button";
            this.effect_animation_button.Size = new System.Drawing.Size(30, 23);
            this.effect_animation_button.TabIndex = 34;
            this.effect_animation_button.Text = "...";
            this.effect_animation_button.UseVisualStyleBackColor = true;
            this.effect_animation_button.Click += new System.EventHandler(this.effect_animation_button_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(247, 81);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "Damage: ";
            // 
            // effect_animation_textbox
            // 
            this.effect_animation_textbox.Location = new System.Drawing.Point(75, 67);
            this.effect_animation_textbox.Name = "effect_animation_textbox";
            this.effect_animation_textbox.ReadOnly = true;
            this.effect_animation_textbox.Size = new System.Drawing.Size(121, 20);
            this.effect_animation_textbox.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Animation:";
            // 
            // effect_damage_textbox
            // 
            this.effect_damage_textbox.Location = new System.Drawing.Point(306, 78);
            this.effect_damage_textbox.Name = "effect_damage_textbox";
            this.effect_damage_textbox.Size = new System.Drawing.Size(41, 20);
            this.effect_damage_textbox.TabIndex = 15;
            // 
            // effect_rate_label
            // 
            this.effect_rate_label.AutoSize = true;
            this.effect_rate_label.Location = new System.Drawing.Point(267, 55);
            this.effect_rate_label.Name = "effect_rate_label";
            this.effect_rate_label.Size = new System.Drawing.Size(33, 13);
            this.effect_rate_label.TabIndex = 28;
            this.effect_rate_label.Text = "Rate:";
            // 
            // effect_rate_textbox
            // 
            this.effect_rate_textbox.Location = new System.Drawing.Point(306, 52);
            this.effect_rate_textbox.Name = "effect_rate_textbox";
            this.effect_rate_textbox.Size = new System.Drawing.Size(41, 20);
            this.effect_rate_textbox.TabIndex = 29;
            // 
            // effect_label
            // 
            this.effect_label.AutoSize = true;
            this.effect_label.Location = new System.Drawing.Point(250, 33);
            this.effect_label.Name = "effect_label";
            this.effect_label.Size = new System.Drawing.Size(50, 13);
            this.effect_label.TabIndex = 14;
            this.effect_label.Text = "Duration:";
            // 
            // effect_duration_textbox
            // 
            this.effect_duration_textbox.Location = new System.Drawing.Point(306, 26);
            this.effect_duration_textbox.Name = "effect_duration_textbox";
            this.effect_duration_textbox.Size = new System.Drawing.Size(41, 20);
            this.effect_duration_textbox.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Effect Type:";
            // 
            // effecttype_combobox
            // 
            this.effecttype_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.effecttype_combobox.FormattingEnabled = true;
            this.effecttype_combobox.Location = new System.Drawing.Point(75, 28);
            this.effecttype_combobox.Name = "effecttype_combobox";
            this.effecttype_combobox.Size = new System.Drawing.Size(121, 21);
            this.effecttype_combobox.TabIndex = 22;
            // 
            // ability_satistics
            // 
            this.ability_satistics.Controls.Add(this.label2);
            this.ability_satistics.Controls.Add(this.label3);
            this.ability_satistics.Controls.Add(this.label4);
            this.ability_satistics.Controls.Add(this.label5);
            this.ability_satistics.Controls.Add(this.energycost_textbox);
            this.ability_satistics.Controls.Add(this.label6);
            this.ability_satistics.Controls.Add(this.corruptioncost_textbox);
            this.ability_satistics.Controls.Add(this.damage_textbox);
            this.ability_satistics.Controls.Add(this.cooldown_textbox);
            this.ability_satistics.Controls.Add(this.modifier_textbox);
            this.ability_satistics.Location = new System.Drawing.Point(702, 170);
            this.ability_satistics.Name = "ability_satistics";
            this.ability_satistics.Size = new System.Drawing.Size(183, 161);
            this.ability_satistics.TabIndex = 26;
            this.ability_satistics.TabStop = false;
            this.ability_satistics.Text = "Satistics";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Damage: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modifier: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cooldown: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Energy cost:";
            // 
            // energycost_textbox
            // 
            this.energycost_textbox.Location = new System.Drawing.Point(91, 91);
            this.energycost_textbox.Name = "energycost_textbox";
            this.energycost_textbox.Size = new System.Drawing.Size(41, 20);
            this.energycost_textbox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Corruption cost: ";
            // 
            // corruptioncost_textbox
            // 
            this.corruptioncost_textbox.Location = new System.Drawing.Point(91, 117);
            this.corruptioncost_textbox.Name = "corruptioncost_textbox";
            this.corruptioncost_textbox.Size = new System.Drawing.Size(41, 20);
            this.corruptioncost_textbox.TabIndex = 12;
            // 
            // damage_textbox
            // 
            this.damage_textbox.Location = new System.Drawing.Point(91, 15);
            this.damage_textbox.Name = "damage_textbox";
            this.damage_textbox.Size = new System.Drawing.Size(41, 20);
            this.damage_textbox.TabIndex = 9;
            // 
            // cooldown_textbox
            // 
            this.cooldown_textbox.Location = new System.Drawing.Point(91, 65);
            this.cooldown_textbox.Name = "cooldown_textbox";
            this.cooldown_textbox.Size = new System.Drawing.Size(41, 20);
            this.cooldown_textbox.TabIndex = 11;
            // 
            // modifier_textbox
            // 
            this.modifier_textbox.Location = new System.Drawing.Point(91, 41);
            this.modifier_textbox.Name = "modifier_textbox";
            this.modifier_textbox.Size = new System.Drawing.Size(41, 20);
            this.modifier_textbox.TabIndex = 10;
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(757, 366);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(75, 23);
            this.reset_btn.TabIndex = 28;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(757, 337);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(75, 23);
            this.update_button.TabIndex = 27;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_tree_button_Click);
            // 
            // treenode_right_click
            // 
            this.treenode_right_click.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.editToolStripMenuItem2,
            this.removeToolStripMenuItem1});
            this.treenode_right_click.Name = "treenode_right_click";
            this.treenode_right_click.Size = new System.Drawing.Size(118, 70);
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem2
            // 
            this.editToolStripMenuItem2.Name = "editToolStripMenuItem2";
            this.editToolStripMenuItem2.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem2.Text = "Edit";
            this.editToolStripMenuItem2.Click += new System.EventHandler(this.editToolStripMenuItem2_Click);
            // 
            // removeToolStripMenuItem1
            // 
            this.removeToolStripMenuItem1.Name = "removeToolStripMenuItem1";
            this.removeToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem1.Text = "Remove";
            this.removeToolStripMenuItem1.Click += new System.EventHandler(this.removeToolStripMenuItem1_Click);
            // 
            // view_textbox
            // 
            this.view_textbox.Location = new System.Drawing.Point(12, 397);
            this.view_textbox.Name = "view_textbox";
            this.view_textbox.ReadOnly = true;
            this.view_textbox.Size = new System.Drawing.Size(241, 20);
            this.view_textbox.TabIndex = 35;
            // 
            // ARK_AbilityWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 424);
            this.Controls.Add(this.view_textbox);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.ability_satistics);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.base_groupbox);
            this.Controls.Add(this.ability_dev_information);
            this.Controls.Add(this.ability_tree);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ARK_AbilityWizard";
            this.Text = "Ability Database Creation Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ARK_AbilityWizard_FormClosing);
            this.Load += new System.EventHandler(this.ability_wizard_viewer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ability_dev_information.ResumeLayout(false);
            this.ability_dev_information.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.base_groupbox.ResumeLayout(false);
            this.base_groupbox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ability_satistics.ResumeLayout(false);
            this.ability_satistics.PerformLayout();
            this.treenode_right_click.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView ability_tree;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox ability_dev_information;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox combo_dark_textbox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox combo_checkbox;
        private System.Windows.Forms.TextBox combo_light_textbox;
        private System.Windows.Forms.Button anim_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox hitbox_height_textbox;
        private System.Windows.Forms.TextBox hitbox_length_textbox;
        private System.Windows.Forms.ComboBox animation_key_combobox;
        private System.Windows.Forms.RichTextBox description_richTextbox;
        private System.Windows.Forms.TextBox animation_file_textbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox base_groupbox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.ComboBox skill_type_combox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label slot_label;
        private System.Windows.Forms.ComboBox equip_slot_combobox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cast_combobox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button effect_animation_button;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox effect_animation_textbox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox effect_damage_textbox;
        private System.Windows.Forms.Label effect_rate_label;
        private System.Windows.Forms.TextBox effect_rate_textbox;
        private System.Windows.Forms.Label effect_label;
        private System.Windows.Forms.TextBox effect_duration_textbox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox effecttype_combobox;
        private System.Windows.Forms.GroupBox ability_satistics;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox energycost_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox corruptioncost_textbox;
        private System.Windows.Forms.TextBox damage_textbox;
        private System.Windows.Forms.TextBox cooldown_textbox;
        private System.Windows.Forms.TextBox modifier_textbox;
        private System.Windows.Forms.Button sprite_button;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox sprite_textbox;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.ContextMenuStrip treenode_right_click;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem1;
        private System.Windows.Forms.TextBox view_textbox;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;

    }
}