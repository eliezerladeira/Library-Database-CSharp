using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryDatabase
{
    public partial class TemplateForm : Form
    {
        public String operation;

        public TemplateForm()
        {
            InitializeComponent();
        }

        public void changeButtons(int op)
        {
            // op = operations that will be done with the buttons
            // 1  = prepare the buttons to insert and locate
            // 2  = prepare to insert / change a record
            // 3  = prepare the screen to delete or change

            btnInclude.Enabled = false;
            btnChange.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = false;
            btnClose.Enabled = false;
            btnPrint.Enabled = false;

            if (op == 1)
            {
                btnInclude.Enabled = true;
            }
            if (op == 2)
            {
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
            }
            if (op == 3)
            {
                btnChange.Enabled = true;
                btnDelete.Enabled = true;
                btnCancel.Enabled = true;
            }
        }

        private void TemplateForm_Load(object sender, EventArgs e)
        {
            this.changeButtons(1);
        }

        private void TemplateForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}