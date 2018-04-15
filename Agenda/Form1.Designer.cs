namespace Agenda
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label Password_label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Connexion_Button = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Login_label = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.LinkLabel();
            this.PasswordLost = new System.Windows.Forms.LinkLabel();
            Password_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Password_label
            // 
            Password_label.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Password_label.Location = new System.Drawing.Point(284, 70);
            Password_label.Name = "Password_label";
            Password_label.Size = new System.Drawing.Size(249, 23);
            Password_label.TabIndex = 5;
            Password_label.Text = "Mot de passe";
            Password_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Connexion_Button
            // 
            this.Connexion_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Connexion_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Connexion_Button.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.Connexion_Button.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connexion_Button.ForeColor = System.Drawing.Color.Ivory;
            this.Connexion_Button.Location = new System.Drawing.Point(342, 147);
            this.Connexion_Button.Name = "Connexion_Button";
            this.Connexion_Button.Size = new System.Drawing.Size(134, 42);
            this.Connexion_Button.TabIndex = 3;
            this.Connexion_Button.Text = "Connexion";
            this.Connexion_Button.UseVisualStyleBackColor = false;
            this.Connexion_Button.Click += new System.EventHandler(this.Connexion_Button_Click);
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.Silver;
            this.Login.Location = new System.Drawing.Point(280, 35);
            this.Login.Multiline = true;
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(253, 25);
            this.Login.TabIndex = 1;
            this.Login.Text = "name@exemple.com";
            this.Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Login.Enter += new System.EventHandler(this.Login_Enter);
            this.Login.Leave += new System.EventHandler(this.Login_Leave);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.Password.Location = new System.Drawing.Point(280, 96);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(253, 25);
            this.Password.TabIndex = 2;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_KeyDown);
            // 
            // Login_label
            // 
            this.Login_label.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.Login_label.Location = new System.Drawing.Point(280, 9);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(253, 23);
            this.Login_label.TabIndex = 4;
            this.Login_label.Text = "E-Mail";
            this.Login_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // register
            // 
            this.register.AutoSize = true;
            this.register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.LinkColor = System.Drawing.Color.Red;
            this.register.Location = new System.Drawing.Point(297, 211);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(60, 13);
            this.register.TabIndex = 6;
            this.register.TabStop = true;
            this.register.Text = "S\'inscrire";
            this.register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // PasswordLost
            // 
            this.PasswordLost.AutoSize = true;
            this.PasswordLost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PasswordLost.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLost.LinkColor = System.Drawing.Color.Red;
            this.PasswordLost.Location = new System.Drawing.Point(403, 211);
            this.PasswordLost.Name = "PasswordLost";
            this.PasswordLost.Size = new System.Drawing.Size(130, 13);
            this.PasswordLost.TabIndex = 7;
            this.PasswordLost.TabStop = true;
            this.PasswordLost.Text = "Mot de passe oublié ?";
            this.PasswordLost.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PasswordLost_LinkClicked);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(549, 245);
            this.Controls.Add(this.PasswordLost);
            this.Controls.Add(this.register);
            this.Controls.Add(Password_label);
            this.Controls.Add(this.Login_label);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Connexion_Button);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Connexion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Connexion_Button;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label Login_label;
        private System.Windows.Forms.LinkLabel register;
        private System.Windows.Forms.LinkLabel PasswordLost;
    }
}

