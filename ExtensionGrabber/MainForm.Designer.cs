namespace ExtensionGrabber {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butSource = new System.Windows.Forms.Button();
            this.butDest = new System.Windows.Forms.Button();
            this.txtExt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.butGo = new System.Windows.Forms.Button();
            this.chkAutoOW = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.BackColor = System.Drawing.SystemColors.Window;
            this.txtSource.Location = new System.Drawing.Point(16, 29);
            this.txtSource.Name = "txtSource";
            this.txtSource.ReadOnly = true;
            this.txtSource.Size = new System.Drawing.Size(277, 20);
            this.txtSource.TabIndex = 0;
            this.txtSource.TextChanged += new System.EventHandler(this.txtSource_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source Directory";
            // 
            // txtDest
            // 
            this.txtDest.BackColor = System.Drawing.SystemColors.Window;
            this.txtDest.Location = new System.Drawing.Point(16, 68);
            this.txtDest.Name = "txtDest";
            this.txtDest.ReadOnly = true;
            this.txtDest.Size = new System.Drawing.Size(277, 20);
            this.txtDest.TabIndex = 2;
            this.txtDest.TextChanged += new System.EventHandler(this.txtDest_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination Directory";
            // 
            // butSource
            // 
            this.butSource.Location = new System.Drawing.Point(299, 27);
            this.butSource.Name = "butSource";
            this.butSource.Size = new System.Drawing.Size(31, 23);
            this.butSource.TabIndex = 1;
            this.butSource.Text = "...";
            this.butSource.UseVisualStyleBackColor = true;
            this.butSource.Click += new System.EventHandler(this.butSource_Click);
            // 
            // butDest
            // 
            this.butDest.Location = new System.Drawing.Point(299, 66);
            this.butDest.Name = "butDest";
            this.butDest.Size = new System.Drawing.Size(31, 23);
            this.butDest.TabIndex = 3;
            this.butDest.Text = "...";
            this.butDest.UseVisualStyleBackColor = true;
            this.butDest.Click += new System.EventHandler(this.butDest_Click);
            // 
            // txtExt
            // 
            this.txtExt.Location = new System.Drawing.Point(16, 107);
            this.txtExt.Name = "txtExt";
            this.txtExt.Size = new System.Drawing.Size(50, 20);
            this.txtExt.TabIndex = 4;
            this.txtExt.Text = "JPG";
            this.txtExt.TextChanged += new System.EventHandler(this.txtExt_TextChanged);
            this.txtExt.Leave += new System.EventHandler(this.txtExt_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Extension";
            // 
            // butGo
            // 
            this.butGo.Enabled = false;
            this.butGo.Location = new System.Drawing.Point(255, 104);
            this.butGo.Name = "butGo";
            this.butGo.Size = new System.Drawing.Size(75, 23);
            this.butGo.TabIndex = 5;
            this.butGo.Text = "Go";
            this.butGo.UseVisualStyleBackColor = true;
            this.butGo.Click += new System.EventHandler(this.butGo_Click);
            // 
            // chkAutoOW
            // 
            this.chkAutoOW.AutoSize = true;
            this.chkAutoOW.Location = new System.Drawing.Point(108, 108);
            this.chkAutoOW.Name = "chkAutoOW";
            this.chkAutoOW.Size = new System.Drawing.Size(96, 17);
            this.chkAutoOW.TabIndex = 6;
            this.chkAutoOW.Text = "Auto Overwrite";
            this.chkAutoOW.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 140);
            this.Controls.Add(this.chkAutoOW);
            this.Controls.Add(this.butGo);
            this.Controls.Add(this.butDest);
            this.Controls.Add(this.butSource);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExt);
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.txtSource);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extension Grabber";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butSource;
        private System.Windows.Forms.Button butDest;
        private System.Windows.Forms.TextBox txtExt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butGo;
        private System.Windows.Forms.CheckBox chkAutoOW;
    }
}

