using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Col2Line
{
    public partial class frm_Mul2Sin : Form
    {
        Col2Line changeLine;

        public frm_Mul2Sin()
        {
            InitializeComponent();
        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_Mul2Sin_Load(object sender, EventArgs e)
        {
            changeLine = new Col2Line();
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            changeLine.multiLines = txt_lines.Lines;
            changeLine.ConvertLinesToSingle();
            txt_single_line.Text = changeLine.singleLine;
        }

        private void btn_copytext_Click(object sender, EventArgs e)
        {
            if (txt_single_line.Text != string.Empty || txt_single_line.Text != null)
                Clipboard.SetText( txt_single_line.Text );
        }
    }
}
