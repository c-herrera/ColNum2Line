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
        ColintoLine changeLine;
        BasicLog logtofile;
        About aboutBox;

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
            changeLine = new ColintoLine();
            logtofile = new BasicLog();
            aboutBox = new About();
            logtofile.Info($"Logging starts.");
            logtofile.Trace($" Object is {changeLine.ToString()}");
            logtofile.Trace($" Objetc is {logtofile.ToString()}");
            btn_copytext.Enabled = false;
            logtofile.Info( $" There are not issues in this point, continue." );
            txt_Info.Text =  aboutBox.TheText;
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            if (txt_lines.Lines.Length > 0 || txt_lines.Text != string.Empty)
            {
                changeLine.multiLines = txt_lines.Lines;
                changeLine.ConvertLinesToSingle();
                txt_single_line.Text = changeLine.singleLine;
                btn_copytext.Enabled = true;

                logtofile.Info($"Lines to change  : {Environment.NewLine}{txt_lines.Text.ToString()}");
                logtofile.Info($"Lines pasted :  {txt_lines.Lines.Length}");
                logtofile.Info($"Lines processed :  {changeLine.totalLines}");
                logtofile.Trace( $"single line recovered : {Environment.NewLine} {changeLine.singleLine}" );

                // TODO: To check if this does not interrupt the flow logic

                // Clear the lines already changed 
                txt_lines.Clear();

            }
        }

        private void btn_copytext_Click(object sender, EventArgs e)
        {
            // Remove previous Copy elements
            if (Clipboard.ContainsText() == true)
            {
                Clipboard.Clear();
                logtofile.Trace( $"Clipboard is clear" );
            }
            else
            {
                Clipboard.SetText( string.Empty );
                logtofile.Trace( $"Clipoboard has been set to \'{string.Empty} \' " );
            }


            if (changeLine.isLineSingle == true)
            {
                if (txt_single_line.Text != string.Empty || txt_single_line.Text != null)
                {
                    try
                    {
                        Clipboard.SetText( txt_single_line.Text );
                        logtofile.Info( $"The text has been copied to the clipbooard with no issues" );
                    }
                    catch (Exception excp)
                    {
                        logtofile.Error( $"Exception ; An unexpected error from Clipboard: {Environment.NewLine} {excp.Message}" );
                        throw;
                    }
                }
            }
            else
            {
                if (txt_lines.Text != string.Empty || txt_lines.Lines.Length != 0)
                {
                    try
                    {
                        Clipboard.SetText( txt_lines.Text );
                        logtofile.Info( $"The text has been copied to the clipbooard with no issues" );
                    }
                    catch (Exception excp)
                    {
                        logtofile.Error( $"Exception ; An unexpected error from Clipboard: {Environment.NewLine} {excp.Message}" );
                        throw;
                    }
                }
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

            txt_lines.Text = string.Empty;
            txt_lines.Clear();
            txt_single_line.Text = string.Empty;
            btn_copytext.Enabled = false;

            logtofile.Trace( $"Event ; Pressed Clear text button : {btn_clear.Name.ToString()}" );

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
                logtofile.Error( $"An unexcepted error ocurred :{excp.Message}" );
                throw;
            }
        }

        private void txt_lines_TextChanged(object sender, EventArgs e)
        {
            if (txt_lines.Lines.Length ==  0 || txt_lines.Text == null || txt_lines.Text == string.Empty)
            {
                btn_convert.Enabled = false;                
            }
            else
            {
                btn_convert.Enabled = true;
            }
            //logtofile.Trace( $"Convert to single line button is disabled {btn_convert.ToString()} Status = {btn_convert.Enabled}" );
        }

        private void txt_single_line_TextChanged(object sender, EventArgs e)
        {
            if (txt_single_line.Text == string.Empty || txt_single_line.Text == null)
            {
                btn_convert_m.Enabled = false;                
            }
            else
            {
                btn_convert_m.Enabled = true;
            }
            //logtofile.Trace( $"Convert to single line button is disabled {btn_convert.ToString()} Status = {btn_convert.Enabled}" );
        }

        private void btn_convert_m_Click(object sender, EventArgs e)
        {
            if (txt_single_line.Text != string.Empty || txt_single_line.Text != null)
            {
                changeLine.singleLine = txt_single_line.Text;
                changeLine.ConvertSingleLinetoMultiple();
                txt_lines.Lines = changeLine.multiLines;
                btn_copytext.Enabled = true;

                logtofile.Trace( $"Line to change  : {Environment.NewLine}{txt_single_line.Text.ToString()}" );
                logtofile.Trace( $"Lines pasted :  {txt_lines.Lines.Length}" );
                logtofile.Trace( $"Lines processed :  {changeLine.totalLines}" );
                logtofile.Trace( $"Lines recovered : {Environment.NewLine} {txt_lines.Text}" );

                // TODO: Check this also

                // Clear the lines already changed 
                txt_single_line.Clear();
            }
        }
    }
}
