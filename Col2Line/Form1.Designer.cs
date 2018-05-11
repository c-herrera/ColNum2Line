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
            this.txt_lines = new System.Windows.Forms.TextBox();
            this.txt_single_line = new System.Windows.Forms.TextBox();
            this.btn_convert = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_copytext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.ImageIndex = 0;
            this.btn_exit.ImageList = this.imageList1;
            this.btn_exit.Location = new System.Drawing.Point(290, 183);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Quit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txt_lines
            // 
            this.txt_lines.Location = new System.Drawing.Point(12, 12);
            this.txt_lines.Multiline = true;
            this.txt_lines.Name = "txt_lines";
            this.txt_lines.Size = new System.Drawing.Size(170, 84);
            this.txt_lines.TabIndex = 1;
            // 
            // txt_single_line
            // 
            this.txt_single_line.Location = new System.Drawing.Point(12, 144);
            this.txt_single_line.Name = "txt_single_line";
            this.txt_single_line.Size = new System.Drawing.Size(170, 20);
            this.txt_single_line.TabIndex = 2;
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(199, 12);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(166, 23);
            this.btn_convert.TabIndex = 3;
            this.btn_convert.Text = "Change to Single line";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Apps-session-halt-icon.png");
            this.imageList1.Images.SetKeyName(1, "copy-icon.png");
            // 
            // btn_copytext
            // 
            this.btn_copytext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_copytext.ImageIndex = 1;
            this.btn_copytext.ImageList = this.imageList1;
            this.btn_copytext.Location = new System.Drawing.Point(199, 141);
            this.btn_copytext.Name = "btn_copytext";
            this.btn_copytext.Size = new System.Drawing.Size(162, 23);
            this.btn_copytext.TabIndex = 4;
            this.btn_copytext.Text = "Copy to Clipboard";
            this.btn_copytext.UseVisualStyleBackColor = true;
            this.btn_copytext.Click += new System.EventHandler(this.btn_copytext_Click);
            // 
            // frm_Mul2Sin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 219);
            this.Controls.Add(this.btn_copytext);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.txt_single_line);
            this.Controls.Add(this.txt_lines);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
    }
}

