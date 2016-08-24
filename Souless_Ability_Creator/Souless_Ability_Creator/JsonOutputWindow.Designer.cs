namespace Souless_Ability_Creator
{
    partial class JsonOutputWindow
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
            this.json_textbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // json_textbox
            // 
            this.json_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.json_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.json_textbox.Location = new System.Drawing.Point(13, 13);
            this.json_textbox.Name = "json_textbox";
            this.json_textbox.ReadOnly = true;
            this.json_textbox.Size = new System.Drawing.Size(541, 379);
            this.json_textbox.TabIndex = 0;
            this.json_textbox.Text = "";
            // 
            // JsonOutputWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 404);
            this.Controls.Add(this.json_textbox);
            this.Name = "JsonOutputWindow";
            this.Text = "JSON Output";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox json_textbox;
    }
}