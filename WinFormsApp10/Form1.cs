using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp10
{
    public partial class Form1 : Form
    {
        static List<Panel> panellist = new List<Panel>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel() 
            { 
                Size = new Size(468, 40),
                Location = new Point(40, 10),
                BackColor = Color.Black
            };




         Controls.Add(panel);
        }
    }
}
