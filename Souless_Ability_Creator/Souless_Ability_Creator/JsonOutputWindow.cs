using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Souless_Ability_Creator
{
    public partial class JsonOutputWindow : Form
    {
        public JsonOutputWindow()
        {
            InitializeComponent();
        }

        public void updateRichTextBox(string text)
        {
            json_textbox.Text = text;
        }
    }
}
