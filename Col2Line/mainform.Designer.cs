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
            this.btn_exit = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txt_lines = new System.Windows.Forms.TextBox();
            this.txt_single_line = new System.Windows.Forms.TextBox();
            this.btn_convert = new System.Windows.Forms.Button();
            this.btn_copytext = new System.Windows.Forms.Button();
            this.lbl_info1 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.linkLbl_log_view = new System.Windows.Forms.LinkLabel();
            this.btn_convert_m = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.ImageIndex = 0;
            this.btn_exit.ImageList = this.imageList1;
            this.btn_exit.Location = new System.Drawing.Point(294, 196);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Quit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
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
            // txt_lines
            // 
            this.txt_lines.Location = new System.Drawing.Point(12, 25);
            this.txt_lines.Multiline = true;
            this.txt_lines.Name = "txt_lines";
            this.txt_lines.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_lines.Size = new System.Drawing.Size(170, 84);
            this.txt_lines.TabIndex = 1;
            this.txt_lines.TextChanged += new System.EventHandler(this.txt_lines_TextChanged);
            // 
            // txt_single_line
            // 
            this.txt_single_line.Location = new System.Drawing.Point(199, 25);
            this.txt_single_line.Name = "txt_single_line";
            this.txt_single_line.Size = new System.Drawing.Size(170, 20);
            this.txt_single_line.TabIndex = 2;
            this.txt_single_line.TextChanged += new System.EventHandler(this.txt_single_line_TextChanged);
            // 
            // btn_convert
            // 
            this.btn_convert.Enabled = false;
            this.btn_convert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_convert.ImageIndex = 5;
            this.btn_convert.ImageList = this.imageList1;
            this.btn_convert.Location = new System.Drawing.Point(199, 113);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(166, 23);
            this.btn_convert.TabIndex = 3;
            this.btn_convert.Text = "Change to Single line";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // btn_copytext
            // 
            this.btn_copytext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_copytext.ImageIndex = 2;
            this.btn_copytext.ImageList = this.imageList1;
            this.btn_copytext.Location = new System.Drawing.Point(199, 152);
            this.btn_copytext.Name = "btn_copytext";
            this.btn_copytext.Size = new System.Drawing.Size(166, 23);
            this.btn_copytext.TabIndex = 4;
            this.btn_copytext.Text = "Copy to Clipboard";
            this.btn_copytext.UseVisualStyleBackColor = true;
            this.btn_copytext.Click += new System.EventHandler(this.btn_copytext_Click);
            // 
            // lbl_info1
            // 
            this.lbl_info1.AutoSize = true;
            this.lbl_info1.Location = new System.Drawing.Point(12, 9);
            this.lbl_info1.Name = "lbl_info1";
            this.lbl_info1.Size = new System.Drawing.Size(125, 13);
            this.lbl_info1.TabIndex = 5;
            this.lbl_info1.Text = "Paste Multiline text here :";
            // 
            // btn_clear
            // 
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.ImageIndex = 3;
            this.btn_clear.ImageList = this.imageList1;
            this.btn_clear.Location = new System.Drawing.Point(12, 152);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(106, 23);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Clear Text!";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // linkLbl_log_view
            // 
            this.linkLbl_log_view.AutoSize = true;
            this.linkLbl_log_view.Location = new System.Drawing.Point(17, 206);
            this.linkLbl_log_view.Name = "linkLbl_log_view";
            this.linkLbl_log_view.Size = new System.Drawing.Size(53, 13);
            this.linkLbl_log_view.TabIndex = 7;
            this.linkLbl_log_view.TabStop = true;
            this.linkLbl_log_view.Text = "Opent log";
            this.linkLbl_log_view.Click += new System.EventHandler(this.linkLbl_log_view_Click);
            // 
            // btn_convert_m
            // 
            this.btn_convert_m.Enabled = false;
            this.btn_convert_m.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_convert_m.ImageIndex = 5;
            this.btn_convert_m.ImageList = this.imageList1;
            this.btn_convert_m.Location = new System.Drawing.Point(199, 72);
            this.btn_convert_m.Name = "btn_convert_m";
            this.btn_convert_m.Size = new System.Drawing.Size(166, 23);
            this.btn_convert_m.TabIndex = 8;
            this.btn_convert_m.Text = "Change to Multiple Line";
            this.btn_convert_m.UseVisualStyleBackColor = true;
            this.btn_convert_m.Click += new System.EventHandler(this.btn_convert_m_Click);
            // 
            // frm_Mul2Sin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 235);
            this.Controls.Add(this.btn_convert_m);
            this.Controls.Add(this.linkLbl_log_view);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lbl_info1);
            this.Controls.Add(this.btn_copytext);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.txt_single_line);
            this.Controls.Add(this.txt_lines);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Mul2Sin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultiLine 2 Line";
            this.Load += new System.EventHandler(this.frm_Mul2Sin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox txt_lines;
        private System.Windows.Forms.TextBox txt_single_line;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_copytext;
        private System.Windows.Forms.Label lbl_info1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.LinkLabel linkLbl_log_view;
        private System.Windows.Forms.Button btn_convert_m;
    }
}

