using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payphone
{
    public partial class ATC : Form
    {
        public ATC()
        {
            InitializeComponent();
        }
        public event EventHandler<string> CallEvent;
        private void LineIsBusy(object sender, EventArgs e)
        {
            if (CallEvent != null) CallEvent(this, "Busy");
        }
        private void LineIsFree(object sender, EventArgs e)
        {
            if (CallEvent != null) CallEvent(this, "FreeLine");
        }

     
    }
}
