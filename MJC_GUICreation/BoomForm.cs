using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MJC_GUICreation
{
    public partial class BoomForm : Form
    {
        public BoomForm(string title)
        {
            InitializeComponent();
            this.Text = $"You cut the {title} wire. Whoops.";
        }
    }
}
