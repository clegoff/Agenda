namespace Agenda
{
    partial class RendezvousDisplay
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.vacationCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Intitulé :";
            //
            // textBoxTitle
            //
            this.textBoxTitle.Location = new System.Drawing.Point(267, 40);
            this.textBoxTitle.Multiline = true;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(149, 27);
            this.textBoxTitle.TabIndex = 1;
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date de début : ";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date de fin : ";
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Commentaire : ";
            //
            // textBoxComment
            //
            this.textBoxComment.Location = new System.Drawing.Point(267, 234);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(336, 74);
            this.textBoxComment.TabIndex = 7;
            //
            // startDateTimePicker
            //
            this.startDateTimePicker.Location = new System.Drawing.Point(267, 99);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(243, 22);
            this.startDateTimePicker.TabIndex = 8;
            //
            // endDateTimePicker
            //
            this.endDateTimePicker.Location = new System.Drawing.Point(267, 165);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(243, 22);
            this.endDateTimePicker.TabIndex = 9;
            //
            // buttonSubmit
            //
            this.buttonSubmit.Location = new System.Drawing.Point(584, 440);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(158, 41);
            this.buttonSubmit.TabIndex = 10;
            this.buttonSubmit.Text = "Valider";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            //
            // buttonDelete
            //
            this.buttonDelete.Location = new System.Drawing.Point(136, 440);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(158, 41);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Supprimer";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            //
            // vacationCheckBox
            //
            this.vacationCheckBox.AutoSize = true;
            this.vacationCheckBox.Location = new System.Drawing.Point(267, 355);
            this.vacationCheckBox.Name = "vacationCheckBox";
            this.vacationCheckBox.Size = new System.Drawing.Size(92, 21);
            this.vacationCheckBox.TabIndex = 13;
            this.vacationCheckBox.Text = "Vacances";
            this.vacationCheckBox.UseVisualStyleBackColor = true;
            //
            // RendezvousDisplay
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.vacationCheckBox);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label1);
            this.Name = "RendezvousDisplay";
            this.Text = "Rendez-vous";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.CheckBox vacationCheckBox;
    }
}