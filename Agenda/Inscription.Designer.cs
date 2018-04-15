namespace Agenda
{
    partial class Inscription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inscription));
            this.password_new = new System.Windows.Forms.TextBox();
            this.inscriptionLabel = new System.Windows.Forms.Label();
            this.button_inscrire = new System.Windows.Forms.Button();
            this.label_password = new System.Windows.Forms.Label();
            this.label_motclef = new System.Windows.Forms.Label();
            this.mail_new = new System.Windows.Forms.TextBox();
            this.label_mail = new System.Windows.Forms.Label();
            this.telPro_new = new System.Windows.Forms.TextBox();
            this.label_Pro = new System.Windows.Forms.Label();
            this.comboBox_question = new System.Windows.Forms.ComboBox();
            this.reponseCle = new System.Windows.Forms.TextBox();
            this.label_Service = new System.Windows.Forms.Label();
            this.serviceText = new System.Windows.Forms.TextBox();
            this.name_new = new System.Windows.Forms.TextBox();
            this.firstName_new = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_firstname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // password_new
            // 
            this.password_new.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.password_new.Location = new System.Drawing.Point(211, 110);
            this.password_new.Multiline = true;
            this.password_new.Name = "password_new";
            this.password_new.Size = new System.Drawing.Size(344, 24);
            this.password_new.TabIndex = 2;
            // 
            // inscriptionLabel
            // 
            this.inscriptionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.inscriptionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.inscriptionLabel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inscriptionLabel.ForeColor = System.Drawing.Color.Ivory;
            this.inscriptionLabel.Location = new System.Drawing.Point(0, 0);
            this.inscriptionLabel.Name = "inscriptionLabel";
            this.inscriptionLabel.Size = new System.Drawing.Size(567, 41);
            this.inscriptionLabel.TabIndex = 2;
            this.inscriptionLabel.Text = "S\'inscrire";
            this.inscriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_inscrire
            // 
            this.button_inscrire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_inscrire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_inscrire.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_inscrire.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_inscrire.Location = new System.Drawing.Point(141, 469);
            this.button_inscrire.Name = "button_inscrire";
            this.button_inscrire.Size = new System.Drawing.Size(213, 58);
            this.button_inscrire.TabIndex = 9;
            this.button_inscrire.Text = "Valider";
            this.button_inscrire.UseVisualStyleBackColor = false;
            this.button_inscrire.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(38, 116);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(147, 18);
            this.label_password.TabIndex = 5;
            this.label_password.Text = "*Mot de passe : ";
            // 
            // label_motclef
            // 
            this.label_motclef.AutoSize = true;
            this.label_motclef.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_motclef.Location = new System.Drawing.Point(8, 343);
            this.label_motclef.Name = "label_motclef";
            this.label_motclef.Size = new System.Drawing.Size(177, 18);
            this.label_motclef.TabIndex = 7;
            this.label_motclef.Text = "*Question secrète : ";
            // 
            // mail_new
            // 
            this.mail_new.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail_new.ForeColor = System.Drawing.Color.Silver;
            this.mail_new.Location = new System.Drawing.Point(211, 66);
            this.mail_new.Multiline = true;
            this.mail_new.Name = "mail_new";
            this.mail_new.Size = new System.Drawing.Size(344, 24);
            this.mail_new.TabIndex = 1;
            this.mail_new.Text = "name@exemple.com";
            this.mail_new.Enter += new System.EventHandler(this.mail_new_Enter);
            this.mail_new.Leave += new System.EventHandler(this.mail_new_Leave);
            // 
            // label_mail
            // 
            this.label_mail.AutoSize = true;
            this.label_mail.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mail.Location = new System.Drawing.Point(42, 66);
            this.label_mail.Name = "label_mail";
            this.label_mail.Size = new System.Drawing.Size(143, 18);
            this.label_mail.TabIndex = 9;
            this.label_mail.Text = "*Adresse mail : ";
            // 
            // telPro_new
            // 
            this.telPro_new.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.telPro_new.Location = new System.Drawing.Point(211, 248);
            this.telPro_new.Multiline = true;
            this.telPro_new.Name = "telPro_new";
            this.telPro_new.Size = new System.Drawing.Size(344, 24);
            this.telPro_new.TabIndex = 5;
            this.telPro_new.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telPro_new_KeyPress);
            // 
            // label_Pro
            // 
            this.label_Pro.AutoSize = true;
            this.label_Pro.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Pro.Location = new System.Drawing.Point(31, 248);
            this.label_Pro.Name = "label_Pro";
            this.label_Pro.Size = new System.Drawing.Size(154, 18);
            this.label_Pro.TabIndex = 13;
            this.label_Pro.Text = "*Téléphone Pro : ";
            // 
            // comboBox_question
            // 
            this.comboBox_question.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_question.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_question.FormattingEnabled = true;
            this.comboBox_question.Location = new System.Drawing.Point(211, 340);
            this.comboBox_question.Name = "comboBox_question";
            this.comboBox_question.Size = new System.Drawing.Size(344, 21);
            this.comboBox_question.TabIndex = 7;
            // 
            // reponseCle
            // 
            this.reponseCle.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.reponseCle.Location = new System.Drawing.Point(211, 383);
            this.reponseCle.Multiline = true;
            this.reponseCle.Name = "reponseCle";
            this.reponseCle.Size = new System.Drawing.Size(344, 24);
            this.reponseCle.TabIndex = 8;
            // 
            // label_Service
            // 
            this.label_Service.AutoSize = true;
            this.label_Service.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Service.Location = new System.Drawing.Point(100, 294);
            this.label_Service.Name = "label_Service";
            this.label_Service.Size = new System.Drawing.Size(85, 18);
            this.label_Service.TabIndex = 16;
            this.label_Service.Text = "Service : ";
            // 
            // serviceText
            // 
            this.serviceText.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.serviceText.Location = new System.Drawing.Point(211, 294);
            this.serviceText.Multiline = true;
            this.serviceText.Name = "serviceText";
            this.serviceText.Size = new System.Drawing.Size(344, 24);
            this.serviceText.TabIndex = 6;
            // 
            // name_new
            // 
            this.name_new.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.name_new.Location = new System.Drawing.Point(211, 156);
            this.name_new.Multiline = true;
            this.name_new.Name = "name_new";
            this.name_new.Size = new System.Drawing.Size(344, 24);
            this.name_new.TabIndex = 3;
            // 
            // firstName_new
            // 
            this.firstName_new.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.firstName_new.Location = new System.Drawing.Point(211, 199);
            this.firstName_new.Multiline = true;
            this.firstName_new.Name = "firstName_new";
            this.firstName_new.Size = new System.Drawing.Size(344, 24);
            this.firstName_new.TabIndex = 4;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(111, 162);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(74, 18);
            this.label_name.TabIndex = 20;
            this.label_name.Text = "*Nom : ";
            // 
            // label_firstname
            // 
            this.label_firstname.AutoSize = true;
            this.label_firstname.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_firstname.Location = new System.Drawing.Point(87, 205);
            this.label_firstname.Name = "label_firstname";
            this.label_firstname.Size = new System.Drawing.Size(98, 18);
            this.label_firstname.TabIndex = 21;
            this.label_firstname.Text = "*Prénom : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "* Champs obligatoires";
            // 
            // Inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 539);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_firstname);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.firstName_new);
            this.Controls.Add(this.name_new);
            this.Controls.Add(this.serviceText);
            this.Controls.Add(this.label_Service);
            this.Controls.Add(this.reponseCle);
            this.Controls.Add(this.comboBox_question);
            this.Controls.Add(this.label_Pro);
            this.Controls.Add(this.telPro_new);
            this.Controls.Add(this.label_mail);
            this.Controls.Add(this.mail_new);
            this.Controls.Add(this.label_motclef);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.button_inscrire);
            this.Controls.Add(this.inscriptionLabel);
            this.Controls.Add(this.password_new);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inscription";
            this.Text = "Inscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label inscriptionLabel;
        private System.Windows.Forms.Label label_mail;
        private System.Windows.Forms.TextBox mail_new;  
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox password_new;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox name_new;
        private System.Windows.Forms.Label label_firstname;
        private System.Windows.Forms.TextBox firstName_new;
        private System.Windows.Forms.Label label_Pro;
        private System.Windows.Forms.TextBox telPro_new;
        private System.Windows.Forms.Label label_Service;
        private System.Windows.Forms.TextBox serviceText; 
        private System.Windows.Forms.Label label_motclef;
        private System.Windows.Forms.ComboBox comboBox_question;
        private System.Windows.Forms.TextBox reponseCle;
        private System.Windows.Forms.Button button_inscrire;
        private System.Windows.Forms.Label label1;
    }
}