using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            toolStripVersion.Text = "Version " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
    }
}
