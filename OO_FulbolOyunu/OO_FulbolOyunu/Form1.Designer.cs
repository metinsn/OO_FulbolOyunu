namespace OO_FulbolOyunu
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
            this.lblAdı = new System.Windows.Forms.Label();
            this.txtboxAdı = new System.Windows.Forms.TextBox();
            this.txtboxTakim = new System.Windows.Forms.TextBox();
            this.lblTakım = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumNo = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.LstBoxOyuncular = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumNo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdı
            // 
            this.lblAdı.AutoEllipsis = true;
            this.lblAdı.AutoSize = true;
            this.lblAdı.Location = new System.Drawing.Point(12, 7);
            this.lblAdı.Name = "lblAdı";
            this.lblAdı.Size = new System.Drawing.Size(28, 13);
            this.lblAdı.TabIndex = 4;
            this.lblAdı.Text = "Adı :";
            this.lblAdı.UseWaitCursor = true;
            // 
            // txtboxAdı
            // 
            this.txtboxAdı.Location = new System.Drawing.Point(65, 4);
            this.txtboxAdı.Name = "txtboxAdı";
            this.txtboxAdı.Size = new System.Drawing.Size(120, 20);
            this.txtboxAdı.TabIndex = 0;
            // 
            // txtboxTakim
            // 
            this.txtboxTakim.Location = new System.Drawing.Point(65, 54);
            this.txtboxTakim.Name = "txtboxTakim";
            this.txtboxTakim.Size = new System.Drawing.Size(120, 20);
            this.txtboxTakim.TabIndex = 2;
            // 
            // lblTakım
            // 
            this.lblTakım.AutoEllipsis = true;
            this.lblTakım.AutoSize = true;
            this.lblTakım.Location = new System.Drawing.Point(12, 61);
            this.lblTakım.Name = "lblTakım";
            this.lblTakım.Size = new System.Drawing.Size(42, 13);
            this.lblTakım.TabIndex = 6;
            this.lblTakım.Text = "Takım :";
            this.lblTakım.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "No:";
            this.label1.UseWaitCursor = true;
            // 
            // NumNo
            // 
            this.NumNo.Location = new System.Drawing.Point(65, 28);
            this.NumNo.Name = "NumNo";
            this.NumNo.Size = new System.Drawing.Size(120, 20);
            this.NumNo.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LstBoxOyuncular
            // 
            this.LstBoxOyuncular.FormattingEnabled = true;
            this.LstBoxOyuncular.Location = new System.Drawing.Point(200, 4);
            this.LstBoxOyuncular.Name = "LstBoxOyuncular";
            this.LstBoxOyuncular.Size = new System.Drawing.Size(247, 108);
            this.LstBoxOyuncular.TabIndex = 7;
            this.LstBoxOyuncular.SelectedIndexChanged += new System.EventHandler(this.LstBoxOyuncular_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 157);
            this.Controls.Add(this.LstBoxOyuncular);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NumNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxTakim);
            this.Controls.Add(this.lblTakım);
            this.Controls.Add(this.txtboxAdı);
            this.Controls.Add(this.lblAdı);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdı;
        private System.Windows.Forms.TextBox txtboxAdı;
        private System.Windows.Forms.TextBox txtboxTakim;
        private System.Windows.Forms.Label lblTakım;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox LstBoxOyuncular;
    }
}

