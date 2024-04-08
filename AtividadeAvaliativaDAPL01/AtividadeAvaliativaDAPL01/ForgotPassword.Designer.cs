namespace AtividadeAvaliativaDAPL01
{
    partial class ForgotPasswordPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordPage));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.CAPageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.BlueViolet;
            this.TitleLabel.Location = new System.Drawing.Point(227, 55);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(318, 37);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = ">> Esqueci a senha <<";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.BlueViolet;
            this.EmailLabel.Location = new System.Drawing.Point(194, 166);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(124, 20);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.Text = "Insira seu email:";
            // 
            // EmailBox
            // 
            this.EmailBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.EmailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBox.ForeColor = System.Drawing.Color.MediumPurple;
            this.EmailBox.Location = new System.Drawing.Point(324, 170);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(233, 16);
            this.EmailBox.TabIndex = 4;
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.BlueViolet;
            this.SendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.ForeColor = System.Drawing.Color.Transparent;
            this.SendButton.Location = new System.Drawing.Point(324, 233);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(134, 36);
            this.SendButton.TabIndex = 7;
            this.SendButton.Text = "Enviar Email";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // CAPageLabel
            // 
            this.CAPageLabel.AutoSize = true;
            this.CAPageLabel.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CAPageLabel.ForeColor = System.Drawing.Color.BlueViolet;
            this.CAPageLabel.Location = new System.Drawing.Point(321, 391);
            this.CAPageLabel.Name = "CAPageLabel";
            this.CAPageLabel.Size = new System.Drawing.Size(142, 20);
            this.CAPageLabel.TabIndex = 8;
            this.CAPageLabel.Text = "Recebi minha Senha";
            this.CAPageLabel.Click += new System.EventHandler(this.CAPageLabel_Click);
            // 
            // ForgotPasswordPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CAPageLabel);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.TitleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgotPasswordPage";
            this.Text = "Página de Recuperação de Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label CAPageLabel;
    }
}