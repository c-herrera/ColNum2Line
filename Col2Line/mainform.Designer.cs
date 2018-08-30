namespace Col2Line
{
    partial class frm_Mul2Sin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Mul2Sin));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPg_main_tab = new System.Windows.Forms.TabPage();
            this.btn_convert_m = new System.Windows.Forms.Button();
            this.linkLbl_log_view = new System.Windows.Forms.LinkLabel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lbl_info1 = new System.Windows.Forms.Label();
            this.btn_copytext = new System.Windows.Forms.Button();
            this.btn_convert = new System.Windows.Forms.Button();
            this.txt_single_line = new System.Windows.Forms.TextBox();
            this.txt_lines = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.tabPg_About = new System.Windows.Forms.TabPage();
            this.txt_Info = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPg_main_tab.SuspendLayout();
            this.tabPg_About.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Apps-session-halt-icon.png");
            this.imageList1.Images.SetKeyName(1, "copy-icon.png");
            this.imageList1.Images.SetKeyName(2, "Clipboard-Paste-icon.png");
            this.imageList1.Images.SetKeyName(3, "delete-icon.png");
            this.imageList1.Images.SetKeyName(4, "Document-Text-icon.png");
            this.imageList1.Images.SetKeyName(5, "page-white-get-icon.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 299);
            this.panel1.TabIndex = 9;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPg_main_tab);
            this.tabControl1.Controls.Add(this.tabPg_About);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(403, 299);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPg_main_tab
            // 
            this.tabPg_main_tab.Controls.Add(this.btn_convert_m);
            this.tabPg_main_tab.Controls.Add(this.linkLbl_log_view);
            this.tabPg_main_tab.Controls.Add(this.btn_clear);
            this.tabPg_main_tab.Controls.Add(this.lbl_info1);
            this.tabPg_main_tab.Controls.Add(this.btn_copytext);
            this.tabPg_main_tab.Controls.Add(this.btn_convert);
            this.tabPg_main_tab.Controls.Add(this.txt_single_line);
            this.tabPg_main_tab.Controls.Add(this.txt_lines);
            this.tabPg_main_tab.Controls.Add(this.btn_exit);
            this.tabPg_main_tab.ImageIndex = 4;
            this.tabPg_main_tab.Location = new System.Drawing.Point(4, 23);
            this.tabPg_main_tab.Name = "tabPg_main_tab";
            this.tabPg_main_tab.Padding = new System.Windows.Forms.Padding(3);
            this.tabPg_main_tab.Size = new System.Drawing.Size(395, 272);
            this.tabPg_main_tab.TabIndex = 0;
            this.tabPg_main_tab.Text = "Convert Lines";
            this.tabPg_main_tab.UseVisualStyleBackColor = true;
            // 
            // btn_convert_m
            // 
            this.btn_convert_m.Enabled = false;
            this.btn_convert_m.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_convert_m.ImageIndex = 5;
            this.btn_convert_m.ImageList = this.imageList1;
            this.btn_convert_m.Location = new System.Drawing.Point(194, 89);
            this.btn_convert_m.Name = "btn_convert_m";
            this.btn_convert_m.Size = new System.Drawing.Size(166, 23);
            this.btn_convert_m.TabIndex = 17;
            this.btn_convert_m.Text = "Change to Multiple Line";
            this.btn_convert_m.UseVisualStyleBackColor = true;
            this.btn_convert_m.Click += new System.EventHandler(this.btn_convert_m_Click);
            // 
            // linkLbl_log_view
            // 
            this.linkLbl_log_view.AutoSize = true;
            this.linkLbl_log_view.Location = new System.Drawing.Point(12, 223);
            this.linkLbl_log_view.Name = "linkLbl_log_view";
            this.linkLbl_log_view.Size = new System.Drawing.Size(53, 13);
            this.linkLbl_log_view.TabIndex = 16;
            this.linkLbl_log_view.TabStop = true;
            this.linkLbl_log_view.Text = "Opent log";
            this.linkLbl_log_view.Click += new System.EventHandler(this.linkLbl_log_view_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.ImageIndex = 3;
            this.btn_clear.ImageList = this.imageList1;
            this.btn_clear.Location = new System.Drawing.Point(7, 169);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(106, 23);
            this.btn_clear.TabIndex = 15;
            this.btn_clear.Text = "Clear Text!";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lbl_info1
            // 
            this.lbl_info1.AutoSize = true;
            this.lbl_info1.Location = new System.Drawing.Point(4, 16);
            this.lbl_info1.Name = "lbl_info1";
            this.lbl_info1.Size = new System.Drawing.Size(125, 13);
            this.lbl_info1.TabIndex = 14;
            this.lbl_info1.Text = "Paste Multiline text here :";
            // 
            // btn_copytext
            // 
            this.btn_copytext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_copytext.ImageIndex = 2;
            this.btn_copytext.ImageList = this.imageList1;
            this.btn_copytext.Location = new System.Drawing.Point(194, 169);
            this.btn_copytext.Name = "btn_copytext";
            this.btn_copytext.Size = new System.Drawing.Size(166, 23);
            this.btn_copytext.TabIndex = 13;
            this.btn_copytext.Text = "Copy to Clipboard";
            this.btn_copytext.UseVisualStyleBackColor = true;
            this.btn_copytext.Click += new System.EventHandler(this.btn_copytext_Click);
            // 
            // btn_convert
            // 
            this.btn_convert.Enabled = false;
            this.btn_convert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_convert.ImageIndex = 5;
            this.btn_convert.ImageList = this.imageList1;
            this.btn_convert.Location = new System.Drawing.Point(194, 130);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(166, 23);
            this.btn_convert.TabIndex = 12;
            this.btn_convert.Text = "Change to Single line";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // txt_single_line
            // 
            this.txt_single_line.Location = new System.Drawing.Point(194, 42);
            this.txt_single_line.Name = "txt_single_line";
            this.txt_single_line.Size = new System.Drawing.Size(170, 20);
            this.txt_single_line.TabIndex = 11;
            this.txt_single_line.TextChanged += new System.EventHandler(this.txt_single_line_TextChanged);
            // 
            // txt_lines
            // 
            this.txt_lines.Location = new System.Drawing.Point(7, 42);
            this.txt_lines.Multiline = true;
            this.txt_lines.Name = "txt_lines";
            this.txt_lines.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_lines.Size = new System.Drawing.Size(170, 84);
            this.txt_lines.TabIndex = 10;
            this.txt_lines.TextChanged += new System.EventHandler(this.txt_lines_TextChanged);
            // 
            // btn_exit
            // 
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.ImageIndex = 0;
            this.btn_exit.ImageList = this.imageList1;
            this.btn_exit.Location = new System.Drawing.Point(289, 213);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Quit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // tabPg_About
            // 
            this.tabPg_About.Controls.Add(this.txt_Info);
            this.tabPg_About.ImageIndex = 4;
            this.tabPg_About.Location = new System.Drawing.Point(4, 23);
            this.tabPg_About.Name = "tabPg_About";
            this.tabPg_About.Padding = new System.Windows.Forms.Padding(3);
            this.tabPg_About.Size = new System.Drawing.Size(395, 272);
            this.tabPg_About.TabIndex = 1;
            this.tabPg_About.Text = "About";
            this.tabPg_About.UseVisualStyleBackColor = true;
            // 
            // txt_Info
            // 
            this.txt_Info.Location = new System.Drawing.Point(26, 26);
            this.txt_Info.Multiline = true;
            this.txt_Info.Name = "txt_Info";
            this.txt_Info.ReadOnly = true;
            this.txt_Info.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_Info.Size = new System.Drawing.Size(283, 201);
            this.txt_Info.TabIndex = 0;
            // 
            // frm_Mul2Sin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 299);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Mul2Sin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultiLine 2 Line";
            this.Load += new System.EventHandler(this.frm_Mul2Sin_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPg_main_tab.ResumeLayout(false);
            this.tabPg_main_tab.PerformLayout();
            this.tabPg_About.ResumeLayout(false);
            this.tabPg_About.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPg_main_tab;
        private System.Windows.Forms.Button btn_convert_m;
        private System.Windows.Forms.LinkLabel linkLbl_log_view;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label lbl_info1;
        private System.Windows.Forms.Button btn_copytext;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.TextBox txt_single_line;
        private System.Windows.Forms.TextBox txt_lines;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TabPage tabPg_About;
        private System.Windows.Forms.TextBox txt_Info;
    }
}

