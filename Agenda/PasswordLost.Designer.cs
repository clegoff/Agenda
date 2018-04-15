namespace Agenda
{
    partial class PasswordLost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordLost));
            this.comboBoxQuestion = new System.Windows.Forms.ComboBox();
            this.mailTextbox = new System.Windows.Forms.TextBox();
            this.textBoxReponse = new System.Windows.Forms.TextBox();
            this.buttonRecup = new System.Windows.Forms.Button();
            this.label_recupmp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxQuestion
            // 
            this.comboBoxQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQuestion.FormattingEnabled = true;
            this.comboBoxQuestion.Location = new System.Drawing.Point(193, 130);
            this.comboBoxQuestion.Name = "comboBoxQuestion";
            this.comboBoxQuestion.Size = new System.Drawing.Size(251, 21);
            this.comboBoxQuestion.TabIndex = 0;
            // 
            // mailTextbox
            // 
            this.mailTextbox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailTextbox.ForeColor = System.Drawing.Color.Silver;
            this.mailTextbox.Location = new System.Drawing.Point(193, 68);
            this.mailTextbox.Multiline = true;
            this.mailTextbox.Name = "mailTextbox";
            this.mailTextbox.Size = new System.Drawing.Size(251, 22);
            this.mailTextbox.TabIndex = 1;
            this.mailTextbox.Text = "name@exemple.com";
            this.mailTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mailTextbox.Enter += new System.EventHandler(this.mailTextbox_Enter);
            this.mailTextbox.Leave += new System.EventHandler(this.mailTextbox_Leave);
            // 
            // textBoxReponse
            // 
            this.textBoxReponse.Location = new System.Drawing.Point(193, 167);
            this.textBoxReponse.Multiline = true;
            this.textBoxReponse.Name = "textBoxReponse";
            this.textBoxReponse.Size = new System.Drawing.Size(251, 23);
            this.textBoxReponse.TabIndex = 2;
            // 
            // buttonRecup
            // 
            this.buttonRecup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRecup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRecup.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.buttonRecup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRecup.Location = new System.Drawing.Point(129, 228);
            this.buttonRecup.Name = "buttonRecup";
            this.buttonRecup.Size = new System.Drawing.Size(164, 43);
            this.buttonRecup.TabIndex = 3;
            this.buttonRecup.Text = "Envoyer";
            this.buttonRecup.UseVisualStyleBackColor = false;
            this.buttonRecup.Click += new System.EventHandler(this.buttonRecup_Click);
            // 
            // label_recupmp
            // 
            this.label_recupmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_recupmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_recupmp.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_recupmp.ForeColor = System.Drawing.Color.Ivory;
            this.label_recupmp.Location = new System.Drawing.Point(0, 0);
            this.label_recupmp.Name = "label_recupmp";
            this.label_recupmp.Size = new System.Drawing.Size(456, 43);
            this.label_recupmp.TabIndex = 4;
            this.label_recupmp.Text = "Récupération du mot de passe";
            this.label_recupmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F);
            this.label1.Location = new System.Drawing.Point(60, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Adresse mail :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F);
            this.label2.Location = new System.Drawing.Point(20, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Question secrète : ";
            // 
            // PasswordLost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 283);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_recupmp);
            this.Controls.Add(this.buttonRecup);
            this.Controls.Add(this.textBoxReponse);
            this.Controls.Add(this.mailTextbox);
            this.Controls.Add(this.comboBoxQuestion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswordLost";
            this.Text = "Mot de passe oublié";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxQuestion;
        private System.Windows.Forms.TextBox mailTextbox;
        private System.Windows.Forms.TextBox textBoxReponse;
        private System.Windows.Forms.Button buttonRecup;
        private System.Windows.Forms.Label label_recupmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}