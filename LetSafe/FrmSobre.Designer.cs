namespace LetSafe
{
    partial class FrmSobre
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
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.lblInfo3 = new System.Windows.Forms.Label();
            this.linkLbl1 = new System.Windows.Forms.LinkLabel();
            this.linkLbl2 = new System.Windows.Forms.LinkLabel();
            this.linkLbl3 = new System.Windows.Forms.LinkLabel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfo1
            // 
            this.lblInfo1.Location = new System.Drawing.Point(46, 204);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(192, 40);
            this.lblInfo1.TabIndex = 0;
            this.lblInfo1.Text = "Marco Antonio";
            this.lblInfo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo2
            // 
            this.lblInfo2.Location = new System.Drawing.Point(300, 204);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(192, 40);
            this.lblInfo2.TabIndex = 1;
            this.lblInfo2.Text = "Mariane";
            this.lblInfo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo3
            // 
            this.lblInfo3.Location = new System.Drawing.Point(562, 204);
            this.lblInfo3.Name = "lblInfo3";
            this.lblInfo3.Size = new System.Drawing.Size(192, 40);
            this.lblInfo3.TabIndex = 2;
            this.lblInfo3.Text = "Matheus Amaro";
            this.lblInfo3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLbl1
            // 
            this.linkLbl1.AutoSize = true;
            this.linkLbl1.Location = new System.Drawing.Point(106, 244);
            this.linkLbl1.Name = "linkLbl1";
            this.linkLbl1.Size = new System.Drawing.Size(68, 25);
            this.linkLbl1.TabIndex = 3;
            this.linkLbl1.TabStop = true;
            this.linkLbl1.Text = "GitHub";
            this.linkLbl1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbl1_LinkClicked);
            // 
            // linkLbl2
            // 
            this.linkLbl2.AutoSize = true;
            this.linkLbl2.Location = new System.Drawing.Point(360, 244);
            this.linkLbl2.Name = "linkLbl2";
            this.linkLbl2.Size = new System.Drawing.Size(68, 25);
            this.linkLbl2.TabIndex = 4;
            this.linkLbl2.TabStop = true;
            this.linkLbl2.Text = "GitHub";
            this.linkLbl2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbl2_LinkClicked);
            // 
            // linkLbl3
            // 
            this.linkLbl3.AutoSize = true;
            this.linkLbl3.Location = new System.Drawing.Point(626, 244);
            this.linkLbl3.Name = "linkLbl3";
            this.linkLbl3.Size = new System.Drawing.Size(68, 25);
            this.linkLbl3.TabIndex = 5;
            this.linkLbl3.TabStop = true;
            this.linkLbl3.Text = "GitHub";
            this.linkLbl3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbl3_LinkClicked);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(344, 377);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(112, 34);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FrmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.linkLbl3);
            this.Controls.Add(this.linkLbl2);
            this.Controls.Add(this.linkLbl1);
            this.Controls.Add(this.lblInfo3);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.lblInfo1);
            this.Name = "FrmSobre";
            this.Text = "Sobre nós";
            this.Load += new System.EventHandler(this.FrmSobre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblInfo1;
        private Label lblInfo2;
        private Label lblInfo3;
        private LinkLabel linkLbl1;
        private LinkLabel linkLbl2;
        private LinkLabel linkLbl3;
        private Button btnFechar;
    }
}