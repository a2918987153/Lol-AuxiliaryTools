using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Litle_Util
{
    public partial class Form4 : Form
    {
        Form1 form;
        public Form4(Form1 form)
        {
            this.form = form;
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Location = new Point(this.form.Location.X, this.form.Location.Y + 30);
            this.Size = new Size(Litle_Util.Properties.Settings.Default.IconSize * 9, Litle_Util.Properties.Settings.Default.IconSize * 8);
            this.TopMost = Litle_Util.Properties.Settings.Default.TopMost;
            this.Opacity = Litle_Util.Properties.Settings.Default.Opacity;
        }
    }
}
