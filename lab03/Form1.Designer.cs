namespace lab03
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboMovie = new System.Windows.Forms.ComboBox();
            this.lblCast = new System.Windows.Forms.Label();
            this.btnCast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboMovie
            // 
            this.cboMovie.FormattingEnabled = true;
            this.cboMovie.Items.AddRange(new object[] {
            "The Godfather",
            "Terminator",
            "Back to the Future",
            "Matrix"});
            this.cboMovie.Location = new System.Drawing.Point(37, 87);
            this.cboMovie.Name = "cboMovie";
            this.cboMovie.Size = new System.Drawing.Size(340, 20);
            this.cboMovie.TabIndex = 0;
            this.cboMovie.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblCast
            // 
            this.lblCast.AutoSize = true;
            this.lblCast.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblCast.Location = new System.Drawing.Point(33, 47);
            this.lblCast.Name = "lblCast";
            this.lblCast.Size = new System.Drawing.Size(254, 21);
            this.lblCast.TabIndex = 1;
            this.lblCast.Text = "My Choice of Best Movie Series";
            this.lblCast.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCast
            // 
            this.btnCast.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnCast.Location = new System.Drawing.Point(49, 371);
            this.btnCast.Name = "btnCast";
            this.btnCast.Size = new System.Drawing.Size(238, 28);
            this.btnCast.TabIndex = 2;
            this.btnCast.Text = "Cast your vote";
            this.btnCast.UseVisualStyleBackColor = true;
            this.btnCast.Click += new System.EventHandler(this.btnCast_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCast);
            this.Controls.Add(this.lblCast);
            this.Controls.Add(this.cboMovie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMovie;
        private System.Windows.Forms.Label lblCast;
        private System.Windows.Forms.Button btnCast;
    }
}

