using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Agenda
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStrip1 = new ToolStrip();
            this.toolStripDropDownButton1 = new ToolStripDropDownButton();
            this.testToolStripMenuItem = new ToolStripMenuItem();
            this.test2ToolStripMenuItem = new ToolStripMenuItem();
            this.tabControl1 = new TabControl();
            this.tabCalendar = new TabPage();
            this.flowLayout_Calendar = new FlowLayoutPanel();
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.label4 = new Label();
            this.label5 = new Label();
            this.label6 = new Label();
            this.label7 = new Label();
            this.labelMonth = new Label();
            this.labelYear = new Label();
            this.prevMonth = new Button();
            this.folMonth = new Button();
            this.prevYear = new Button();
            this.folYear = new Button();

            this.buttonSaveRdv = new Button();
            this.datagridviewRDV = new DataGridView();
            this.TextBoxComentaries = new TextBox();
            this.TextBoxContributor = new TextBox();
            this.dateTimePickerDate = new DateTimePicker();
            this.dgvColumnDate = new DataGridViewTextBoxColumn();
            this.dgvColumnContributor = new DataGridViewTextBoxColumn();
            this.dgvColumnCommentaries = new DataGridViewTextBoxColumn();

            this.labelNewPassword = new Label();
            this.textboxNewPassword = new TextBox();
            this.labelConfNewPassword = new Label();
            this.textboxConfNewPassword = new TextBox();
            this.labelPhone = new Label();
            this.textboxPhone = new TextBox();
            this.labelService = new Label();
            this.textboxService = new TextBox();
            this.labelPicture= new Label();
            this.textboxPicture = new TextBox();
            this.buttonPicture = new Button();
            this.pictureboxPicture = new PictureBox();
            this.buttonSave = new Button();
            this.groupboxProfil = new GroupBox();
            this.buttonImporter = new Button();
            this.buttonExporter = new Button();
            this.groupboxContacts = new GroupBox();
            this.openFilePicture = new OpenFileDialog();
            this.buttonContact = new Button();
            
            this.tabRendezvous = new TabPage();
            this.tabSettings = new TabPage();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCalendar.SuspendLayout();
            this.flowLayout_Calendar.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new Size(20, 20);
            this.toolStrip1.Items.AddRange(new ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new Size(1093, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] {
            this.testToolStripMenuItem,
            this.test2ToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new Size(34, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new Size(116, 26);
            this.testToolStripMenuItem.Text = "test";
            // 
            // test2ToolStripMenuItem
            // 
            this.test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
            this.test2ToolStripMenuItem.Size = new Size(116, 26);
            this.test2ToolStripMenuItem.Text = "test2";
            // 
            // tabControl
            // 
            this.tabControl1.Controls.Add(this.tabCalendar);
            this.tabControl1.Controls.Add(this.tabRendezvous);
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Location = new Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new Size(1093, 800);
            this.tabControl1.TabIndex = 2;
            // 
            // tabCalendar
            // 
            this.tabCalendar.Controls.Add(this.labelMonth);
            this.tabCalendar.Controls.Add(this.labelYear);
            this.tabCalendar.Controls.Add(this.prevMonth);
            this.tabCalendar.Controls.Add(this.folMonth);
            this.tabCalendar.Controls.Add(this.prevYear);
            this.tabCalendar.Controls.Add(this.folYear);
            this.tabCalendar.Controls.Add(this.flowLayout_Calendar);
            this.tabCalendar.Location = new Point(4, 25);
            this.tabCalendar.Name = "tabCalendar";
            this.tabCalendar.Padding = new Padding(3);
            this.tabCalendar.Size = new Size(1085, 800);
            this.tabCalendar.TabIndex = 0;
            this.tabCalendar.Text = "Calendrier";
            this.tabCalendar.UseVisualStyleBackColor = true;
            //
            //flowLayout_Calendar
            //
            this.flowLayout_Calendar.Location = new Point(36, 74);
            this.flowLayout_Calendar.Name = "flowLayout_Calendar";
            this.flowLayout_Calendar.Size = new Size(1002, 800);
            this.flowLayout_Calendar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new Size(136, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "lun.";
            this.label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new Point(145, 0);
            this.label2.Name = "label2";
            this.label2.Size = new Size(135, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "mar.";
            this.label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new Point(286, 0);
            this.label3.Name = "label3";
            this.label3.Size = new Size(135, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "mer.";
            this.label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new Point(427, 0);
            this.label4.Name = "label4";
            this.label4.Size = new Size(135, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "jeu.";
            this.label4.TextAlign = ContentAlignment.MiddleCenter;
            this.label4.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.Location = new Point(568, 0);
            this.label5.Name = "label5";
            this.label5.Size = new Size(135, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "ven.";
            this.label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new Point(709, 0);
            this.label6.Name = "label6";
            this.label6.Size = new Size(135, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "sam.";
            this.label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new Point(850, 0);
            this.label7.Name = "label7";
            this.label7.Size = new Size(135, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "dim.";
            this.label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelMonth
            // 
            this.labelMonth.Location = new Point(600, 15);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new Size(135, 16);
            this.labelMonth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelYear
            // 
            this.labelYear.Location = new Point(600, 45);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new Size(135, 26);
            this.labelYear.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // prevMonth
            // 
            this.prevMonth.Location = new Point(550, 15);
            this.prevMonth.Name = "prevMonth";
            this.prevMonth.Size = new Size(40, 25);
            this.prevMonth.Text = "<-";
            this.prevMonth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // folMonth
            // 
            this.folMonth.Location = new Point(750, 15);
            this.folMonth.Name = "folMonth";
            this.folMonth.Size = new Size(40, 25);
            this.folMonth.Text = "->";
            this.folMonth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // prevYear
            // 
            this.prevYear.Location = new Point(550, 45);
            this.prevYear.Name = "prevMonth";
            this.prevYear.Size = new Size(40, 25);
            this.prevYear.Text = "<-";
            this.prevYear.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // folYear
            // 
            this.folYear.Location = new Point(750, 45);
            this.folYear.Name = "folMonth";
            this.folYear.Size = new Size(40, 25);
            this.folYear.Text = "->";
            this.folYear.TextAlign = ContentAlignment.MiddleCenter;

            ///////////////////////////////////////////

            this.monthCalendar = DateTime.Now.Month;
            this.yearCalendar = DateTime.Now.Year;

            this.createCalendar(monthCalendar, yearCalendar, 136, 100);

            // 
            // tabRendezvous
            // 
            this.tabRendezvous.Location = new Point(4, 25);
            this.tabRendezvous.Name = "tabRendezvous";
            this.tabRendezvous.Padding = new Padding(3);
            this.tabRendezvous.Size = new Size(1800, 900);
            this.tabRendezvous.TabIndex = 1;
            this.tabRendezvous.Text = "Rendez-Vous";
            this.tabRendezvous.UseVisualStyleBackColor = true;
            //
            // datagridviewRDV
            //
            this.datagridviewRDV.Location = new Point(8, 30);
            this.datagridviewRDV.Size = new Size(1000, 600);
            this.datagridviewRDV.AllowUserToAddRows = false;
            this.datagridviewRDV.AllowUserToDeleteRows = false;
            this.datagridviewRDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewRDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            { this.dgvColumnDate, this.dgvColumnContributor, this.dgvColumnCommentaries });
            this.datagridviewRDV.Name = "listerdv";
            //
            // datagridviewColumns
            // date
            this.dgvColumnDate.Frozen = true;
            this.dgvColumnDate.HeaderText = "Date RVD";
            this.dgvColumnDate.Name = "date";
            // contributor
            this.dgvColumnContributor.HeaderText = "Participant";
            this.dgvColumnContributor.Name = "participant";
            // commentaries
            this.dgvColumnCommentaries.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvColumnCommentaries.HeaderText = "Commentaires";
            this.dgvColumnCommentaries.Name = "libelle";
            this.tabRendezvous.Controls.Add(this.datagridviewRDV);


            // 
            // tabSettings
            // 
            this.tabSettings.Location = new Point(4, 25);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new Padding(3);
            this.tabSettings.Size = new Size(1085, 559);
            this.tabSettings.TabIndex = 2;
            this.tabSettings.Text = "Paramètres";
            this.tabSettings.UseVisualStyleBackColor = true;
            //
            // labelNewPassword
            //
            this.labelNewPassword.Location = new Point(93, 40);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new Size(216, 25);
            this.labelNewPassword.Font = new Font("Verdana", 9.0F);
            this.labelNewPassword.Text = "Nouveau mot de passe : ";
            //
            // textboxNewPassword
            //
            this.textboxNewPassword.Location = new Point(380, 40);
            this.textboxNewPassword.Name = "labelNewPassword";
            this.textboxNewPassword.Size = new Size(250, 25);
            this.textboxNewPassword.Font = new Font("Verdana", 9.0F);
            this.textboxNewPassword.TabIndex = 1;
            //
            // labelConfNewPassword
            //
            this.labelConfNewPassword.Location = new Point(8, 75);
            this.labelConfNewPassword.Name = "labelNewPassword";
            this.labelConfNewPassword.Size = new Size(305, 25);
            this.labelConfNewPassword.Font = new Font("Verdana", 9.0F);
            this.labelConfNewPassword.Text = "Confirmer nouveau mot de passe : ";
            //
            // textboxConfNewPassword
            //
            this.textboxConfNewPassword.Location = new Point(380, 75);
            this.textboxConfNewPassword.Name = "textboxConfNewPassword";
            this.textboxConfNewPassword.Size = new Size(250, 25);
            this.textboxConfNewPassword.Font = new Font("Verdana", 9.0F);
            this.textboxConfNewPassword.TabIndex = 2;
            //
            // labelPhone
            //
            this.labelPhone.Location = new Point(88, 110);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new Size(255, 25);
            this.labelPhone.Font = new Font("Verdana", 9.0F);
            this.labelPhone.Text = "Nouveau téléphone pro : ";
            //
            // textboxPhone
            //
            this.textboxPhone.Location = new Point(380, 110);
            this.textboxPhone.Name = "textboxPhone";
            this.textboxPhone.Size = new Size(250, 25);
            this.textboxPhone.Font = new Font("Verdana", 9.0F);
            this.textboxPhone.TabIndex = 3;
            //
            // labelService
            //
            this.labelService.Location = new Point(226, 145);
            this.labelService.Name = "labelPhone";
            this.labelService.Size = new Size(125, 25);
            this.labelService.Font = new Font("Verdana", 9.0F);
            this.labelService.Text = "Service : ";
            //
            // textboxService
            //
            this.textboxService.Location = new Point(380, 145);
            this.textboxService.Name = "textboxService";
            this.textboxService.Size = new Size(250, 25);
            this.textboxService.Font = new Font("Verdana", 9.0F);
            this.textboxService.TabIndex = 4;
            //
            // labelPicture
            //
            this.labelPicture.Location = new Point(163, 180);
            this.labelPicture.Name = "labelPicture";
            this.labelPicture.Size = new Size(150, 25);
            this.labelPicture.Font = new Font("Verdana", 9.0F);
            this.labelPicture.Text = "Photo de profil : ";
            //
            // textboxPicture
            //
            this.textboxPicture.Location = new Point(380, 180);
            this.textboxPicture.Name = "textboxPicture";
            this.textboxPicture.Size = new Size(250, 25);
            this.textboxPicture.Font = new Font("Verdana", 9.0F);
            this.textboxPicture.TabIndex = 5;
            //
            // buttonPicture
            //
            this.buttonPicture.Location = new Point(650, 180);
            this.buttonPicture.Name = "buttonPicture";
            this.buttonPicture.Size = new Size(100, 29);
            this.buttonPicture.Font = new Font("Verdana", 8.0F);
            this.buttonPicture.Text = "Parcourir...";
            this.buttonPicture.BackColor = Color.LightGray;
            this.buttonPicture.TabIndex = 6;
            //
            // pictureboxPicture
            //
            this.pictureboxPicture.Location = new Point(380, 220);
            this.pictureboxPicture.Name = "pictureboxPicture";
            this.pictureboxPicture.Size = new Size(350, 350);
            this.pictureboxPicture.BackgroundImageLayout = ImageLayout.Zoom;
            //
            // buttonSave
            //
            this.buttonSave.Location = new Point(307, 640);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(200, 50);
            this.buttonSave.Font = new Font("Verdana",11.0F, FontStyle.Bold);
            this.buttonSave.Text = "Sauvegarder";
            this.buttonSave.BackColor = Color.Red;
            this.buttonSave.ForeColor = Color.White;
            this.buttonSave.TabIndex = 7;
            //
            // groupboxProfil
            //
            this.groupboxProfil.Location = new Point(12, 12);
            this.groupboxProfil.Name = "groupboxProfil";
            this.groupboxProfil.Size = new Size(815, 700);
            this.groupboxProfil.Font = new Font("Verdana", 11.0F, FontStyle.Bold);
            this.groupboxProfil.Text = "Profil";
            //
            // buttonImporter
            //
            this.buttonImporter.Location = new Point(61, 35);
            this.buttonImporter.Name = "buttonImporter";
            this.buttonImporter.Size = new Size(122, 37);
            this.buttonImporter.Font = new Font("Verdana", 9.0F);
            this.buttonImporter.Text = "Importer";
            this.buttonImporter.BackColor = Color.LightGray;
            //
            // buttonExporter
            //
            this.buttonExporter.Location = new Point(61,93);
            this.buttonExporter.Name = "buttonExporter";
            this.buttonExporter.Size = new Size(122, 37);
            this.buttonExporter.Font = new Font("Verdana", 9.0F);
            this.buttonExporter.Text = "Exporter";
            this.buttonExporter.BackColor = Color.LightGray;
            //
            // buttonContact
            //
            this.buttonContact.Location = new Point(61,151);
            this.buttonContact.Name = "buttonAjoutContact";
            this.buttonContact.Size = new Size(122, 37);
            this.buttonContact.Font = new Font("Verdana", 9.0F);
            this.buttonContact.Text = "Contacts";
            this.buttonContact.BackColor = Color.LightGray;
            //
            // groupboxContacts
            //
            this.groupboxContacts.Location = new Point(833, 12);
            this.groupboxContacts.Name = "groupboxContacts";
            this.groupboxContacts.Size = new Size(244, 200);
            this.groupboxContacts.Font = new Font("Verdana", 11.0F, FontStyle.Bold);
            this.groupboxContacts.Text = "Contacts";
            
            this.groupboxProfil.Controls.Add(this.labelNewPassword);
            this.groupboxProfil.Controls.Add(this.textboxNewPassword);
            this.groupboxProfil.Controls.Add(this.labelConfNewPassword);
            this.groupboxProfil.Controls.Add(this.textboxConfNewPassword);
            this.groupboxProfil.Controls.Add(this.labelPhone);
            this.groupboxProfil.Controls.Add(this.textboxPhone);
            this.groupboxProfil.Controls.Add(this.labelService);
            this.groupboxProfil.Controls.Add(this.textboxService);
            this.groupboxProfil.Controls.Add(this.labelPicture);
            this.groupboxProfil.Controls.Add(this.textboxPicture);
            this.groupboxProfil.Controls.Add(this.buttonPicture);
            this.groupboxProfil.Controls.Add(this.buttonSave);
            this.groupboxProfil.Controls.Add(this.pictureboxPicture);
            this.tabSettings.Controls.Add(this.groupboxProfil);
            this.groupboxContacts.Controls.Add(this.buttonImporter);
            this.groupboxContacts.Controls.Add(this.buttonExporter);
            this.groupboxContacts.Controls.Add(this.buttonContact);
            this.tabSettings.Controls.Add(this.groupboxContacts);

            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 800);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Agenda";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabCalendar.ResumeLayout(false);
            this.flowLayout_Calendar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public void createCalendar(int currentMonth, int currentYear, int width, int height)
        {

            // flowLayout_Calendar
            //
            this.flowLayout_Calendar.Controls.Add(this.label1);
            this.flowLayout_Calendar.Controls.Add(this.label2);
            this.flowLayout_Calendar.Controls.Add(this.label3);
            this.flowLayout_Calendar.Controls.Add(this.label4);
            this.flowLayout_Calendar.Controls.Add(this.label5);
            this.flowLayout_Calendar.Controls.Add(this.label6);
            this.flowLayout_Calendar.Controls.Add(this.label7);

            int monthFinal = currentMonth;
            int yearFinal = currentYear;

            switch (currentMonth)
            {
                case 1:
                    this.labelMonth.Text = "Janvier";
                    break;
                case 2:
                    this.labelMonth.Text = "Février";
                    break;
                case 3:
                    this.labelMonth.Text = "Mars";
                    break;
                case 4:
                    this.labelMonth.Text = "Avril";
                    break;
                case 5:
                    this.labelMonth.Text = "Mai";
                    break;
                case 6:
                    this.labelMonth.Text = "Juin";
                    break;
                case 7:
                    this.labelMonth.Text = "Juillet";
                    break;
                case 8:
                    this.labelMonth.Text = "Août";
                    break;
                case 9:
                    this.labelMonth.Text = "Septembre";
                    break;
                case 10:
                    this.labelMonth.Text = "Octobre";
                    break;
                case 11:
                    this.labelMonth.Text = "Novembre";
                    break;
                default:
                    this.labelMonth.Text = "Décembre";
                    break;
            }
            this.labelYear.Text = "" + currentYear;

            DateTime day = new DateTime(currentYear, currentMonth, 1);
            if (currentMonth == 12)
            {
                monthFinal = 1;
                yearFinal++;
            }
            else
            {
                monthFinal++;
            }
            DateTime firstDayofNextMonth = new DateTime(yearFinal, monthFinal, 1);

            int i = 1;
            int currentPosition = 1;
            while (!day.Equals(firstDayofNextMonth))
            {
                GroupBoxDays newGroupBox = new GroupBoxDays();

                if (day.Day == 1)
                {
                    DayOfWeek theDayofTheWeek = day.DayOfWeek;
                    DayOfWeek dayOfCurrentPosition;
                    switch (currentPosition)
                    {
                        case 1:
                            dayOfCurrentPosition = DayOfWeek.Monday;
                            break;
                        case 2:
                            dayOfCurrentPosition = DayOfWeek.Tuesday;
                            break;
                        case 3:
                            dayOfCurrentPosition = DayOfWeek.Wednesday;
                            break;
                        case 4:
                            dayOfCurrentPosition = DayOfWeek.Thursday;
                            break;
                        case 5:
                            dayOfCurrentPosition = DayOfWeek.Friday;
                            break;
                        case 6:
                            dayOfCurrentPosition = DayOfWeek.Saturday;
                            break;
                        default:
                            dayOfCurrentPosition = DayOfWeek.Sunday;
                            break;
                    }
                    if (!theDayofTheWeek.Equals(dayOfCurrentPosition))
                    {
                        currentPosition++;
                    }
                    else
                    {
                        newGroupBox.Name = "groupBox" + i;
                        newGroupBox.TabIndex = 7 + i;
                        newGroupBox.TabStop = false;
                        newGroupBox.Text = " " + i + " ";


                        if (TheAccount.TheCalendar.testIfDayIsTaken(day))
                        {
                            if (TheAccount.TheCalendar.getARendezvous(new DateTime(currentYear, currentMonth, i)).IsVacation)
                            {
                                newGroupBox.getColors(Color.LightGreen, Color.Black);
                            }
                            else
                            {
                                newGroupBox.getColors(Color.Red, Color.White);
                            }
                            newGroupBox.Click += GBRendezVous_Click;
                        }
                        else if (day.DayOfWeek.Equals(DayOfWeek.Saturday) || day.DayOfWeek.Equals(DayOfWeek.Sunday))
                        {
                            newGroupBox.getColors(Color.LightGray, Color.Black);
                            newGroupBox.Click += GBFreeDay_Click;
                        }
                        else
                        {
                            newGroupBox.getColors(Color.Aqua, Color.Black);
                            newGroupBox.Click += GBFreeDay_Click;
                        }

                        day = day.AddDays(1);
                        i++;
                    }
                }
                else
                {
                    newGroupBox.Name = "groupBox" + i;
                    newGroupBox.TabIndex = 7 + i;
                    newGroupBox.TabStop = false;
                    newGroupBox.Text = " " + i + " ";


                    if (TheAccount.TheCalendar.testIfDayIsTaken(day))
                    {
                        if (TheAccount.TheCalendar.getARendezvous(new DateTime(currentYear, currentMonth, i)).IsVacation)
                        {
                            newGroupBox.getColors(Color.LightGreen, Color.Black);
                        }
                        else
                        {
                            newGroupBox.getColors(Color.Red, Color.White);
                        }
                        newGroupBox.Click += GBRendezVous_Click;
                    }
                    else if (day.DayOfWeek.Equals(DayOfWeek.Saturday) || day.DayOfWeek.Equals(DayOfWeek.Sunday))
                    {
                        newGroupBox.getColors(Color.LightGray, Color.Black);
                        newGroupBox.Click += GBFreeDay_Click;
                    }
                    else
                    {
                        newGroupBox.getColors(Color.Aqua, Color.Black);
                        newGroupBox.Click += GBFreeDay_Click;
                    }

                    day = day.AddDays(1);
                    i++;
                }

                newGroupBox.Location = new System.Drawing.Point();
                this.groupBoxes.Add(newGroupBox);
            }

            foreach (System.Windows.Forms.GroupBox G in this.groupBoxes)
            {
                G.Size = new System.Drawing.Size(width, height);
                this.flowLayout_Calendar.Controls.Add(G);
            }
        }

        public void clearCalendar()
        {
            this.groupBoxes.Clear();
            this.flowLayout_Calendar.Controls.Clear();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem testToolStripMenuItem;
        private ToolStripMenuItem test2ToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabCalendar;
        private TabPage tabRendezvous;
        private TabPage tabSettings;
        private FlowLayoutPanel flowLayout_Calendar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label labelMonth;
        private Label labelYear;
        private Button prevMonth;
        private Button folMonth;
        private Button prevYear;
        private Button folYear;
        private int monthCalendar;
        private int yearCalendar;

        private Button buttonSaveRdv;
        private DataGridView datagridviewRDV;
        private TextBox TextBoxComentaries;
        private TextBox TextBoxContributor;
        private DateTimePicker dateTimePickerDate;
        private DataGridViewTextBoxColumn dgvColumnDate;
        private DataGridViewTextBoxColumn dgvColumnContributor;
        private DataGridViewTextBoxColumn dgvColumnCommentaries;

        private Label labelNewPassword;
        private TextBox textboxNewPassword;
        private Label labelConfNewPassword;
        private TextBox textboxConfNewPassword;
        private Label labelPhone;
        private TextBox textboxPhone;
        private Label labelService;
        private TextBox textboxService;
        private Label labelPicture;
        private TextBox textboxPicture;
        private Button buttonPicture;
        private PictureBox pictureboxPicture;
        private Button buttonSave;
        private GroupBox groupboxProfil;
        private Button buttonImporter;
        private Button buttonExporter;
        private Button buttonContact;
        private GroupBox groupboxContacts;
        private OpenFileDialog openFilePicture;
       
        private List<GroupBox> groupBoxes = new List<GroupBox>();
    }
}

           
    