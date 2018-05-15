using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Col2Line
{
    public partial class frm_Mul2Sin : Form
    {
        Col2Line changeLine;
        BasicLog logtofile;

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
            logtofile = new BasicLog();
            logtofile.Info($"Logging starts.");
            logtofile.Trace($" Object is {changeLine.ToString()}");
            logtofile.Trace($" Objetc is {logtofile.ToString()}");
            btn_copytext.Enabled = false;
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            if (txt_lines.Lines.Length > 0)
            {
                changeLine.multiLines = txt_lines.Lines;
                changeLine.ConvertLinesToSingle();
                txt_single_line.Text = changeLine.singleLine;
                btn_copytext.Enabled = true;
            }
        }

        private void btn_copytext_Click(object sender, EventArgs e)
        {
            if (txt_single_line.Text != string.Empty || txt_single_line.Text != null)
            {
                Clipboard.SetText(txt_single_line.Text);
            }               
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_lines.Text = string.Empty;
            txt_single_line.Text = string.Empty;
            btn_copytext.Enabled = false;

        }

        private void linkLbl_log_view_Click(object sender, EventArgs e)
        {
            Process viewtextprog = new Process();

            try
            {
                if (File.Exists(Assembly.GetExecutingAssembly().GetName().Name + ".log"))
                {
                    viewtextprog.StartInfo.FileName = "notepad";
                    viewtextprog.StartInfo.Arguments = Assembly.GetExecutingAssembly().GetName().Name + ".log";
                    viewtextprog.Start();
                }
                viewtextprog.Dispose();
            }
            catch(Exception excp)
            {

            }
        }
    }
}
