﻿namespace Opeq_CallCenter
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.problemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MATTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.emailRadioBtn = new System.Windows.Forms.RadioButton();
            this.phoneRadioBtn = new System.Windows.Forms.RadioButton();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.inPersonRadioBtn = new System.Windows.Forms.RadioButton();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.opeq_CallCenterDataSet1 = new Opeq_CallCenter.Opeq_CallCenterDataSet();
            this.computerProblemComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.screenProblemComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.laptopProblemComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.phoneOrTabletProblemComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.addRadioBtn = new System.Windows.Forms.RadioButton();
            this.modifyRadioBtn = new System.Windows.Forms.RadioButton();
            this.viewRadioBtn = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.aptNumTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.opeq_CallCenterDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(482, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(483, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // problemDescriptionTextBox
            // 
            this.problemDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemDescriptionTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.problemDescriptionTextBox.Location = new System.Drawing.Point(489, 209);
            this.problemDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.problemDescriptionTextBox.Multiline = true;
            this.problemDescriptionTextBox.Name = "problemDescriptionTextBox";
            this.problemDescriptionTextBox.Size = new System.Drawing.Size(516, 55);
            this.problemDescriptionTextBox.TabIndex = 2;
            this.problemDescriptionTextBox.Text = "Entrer problème";
            this.problemDescriptionTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.problemDescriptionTextBox_MouseClick);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.nameTextBox.Location = new System.Drawing.Point(488, 78);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(516, 55);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.Text = "Entrer nom du cliente";
            this.nameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nameTextBox_MouseClick);
            // 
            // emailTextbox
            // 
            this.emailTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.emailTextbox.Location = new System.Drawing.Point(674, 421);
            this.emailTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextbox.Multiline = true;
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(332, 33);
            this.emailTextbox.TabIndex = 9;
            this.emailTextbox.Text = "Courriel";
            this.emailTextbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.emailTextbox_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(483, 360);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Comment Contacter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(484, 295);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date";
            // 
            // MATTextBox
            // 
            this.MATTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MATTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.MATTextBox.Location = new System.Drawing.Point(484, 1270);
            this.MATTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MATTextBox.Multiline = true;
            this.MATTextBox.Name = "MATTextBox";
            this.MATTextBox.Size = new System.Drawing.Size(440, 55);
            this.MATTextBox.TabIndex = 12;
            this.MATTextBox.Text = "MAT";
            this.MATTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MATTextBox_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(473, 752);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Type de Probléme";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(623, 295);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(383, 28);
            this.dateTimePicker.TabIndex = 13;
            // 
            // emailRadioBtn
            // 
            this.emailRadioBtn.AutoSize = true;
            this.emailRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailRadioBtn.Location = new System.Drawing.Point(490, 421);
            this.emailRadioBtn.Name = "emailRadioBtn";
            this.emailRadioBtn.Size = new System.Drawing.Size(101, 29);
            this.emailRadioBtn.TabIndex = 14;
            this.emailRadioBtn.Text = "Courriel";
            this.emailRadioBtn.UseVisualStyleBackColor = true;
            // 
            // phoneRadioBtn
            // 
            this.phoneRadioBtn.AutoSize = true;
            this.phoneRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneRadioBtn.Location = new System.Drawing.Point(490, 489);
            this.phoneRadioBtn.Name = "phoneRadioBtn";
            this.phoneRadioBtn.Size = new System.Drawing.Size(127, 29);
            this.phoneRadioBtn.TabIndex = 16;
            this.phoneRadioBtn.Text = "Téléphone";
            this.phoneRadioBtn.UseVisualStyleBackColor = true;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.phoneTextBox.Location = new System.Drawing.Point(674, 489);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTextBox.Multiline = true;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(332, 33);
            this.phoneTextBox.TabIndex = 15;
            this.phoneTextBox.Text = "Téléphone";
            this.phoneTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.phoneTextBox_MouseClick);
            // 
            // inPersonRadioBtn
            // 
            this.inPersonRadioBtn.AutoSize = true;
            this.inPersonRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inPersonRadioBtn.Location = new System.Drawing.Point(490, 555);
            this.inPersonRadioBtn.Name = "inPersonRadioBtn";
            this.inPersonRadioBtn.Size = new System.Drawing.Size(146, 29);
            this.inPersonRadioBtn.TabIndex = 18;
            this.inPersonRadioBtn.Text = "En Personne";
            this.inPersonRadioBtn.UseVisualStyleBackColor = true;
            // 
            // streetTextBox
            // 
            this.streetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.streetTextBox.Location = new System.Drawing.Point(674, 555);
            this.streetTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.streetTextBox.Multiline = true;
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(332, 33);
            this.streetTextBox.TabIndex = 17;
            this.streetTextBox.Text = "Adresse";
            this.streetTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addressTextBox_MouseClick);
            // 
            // opeq_CallCenterDataSet1
            // 
            this.opeq_CallCenterDataSet1.DataSetName = "Opeq_CallCenterDataSet";
            this.opeq_CallCenterDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // computerProblemComboBox
            // 
            this.computerProblemComboBox.FormattingEnabled = true;
            this.computerProblemComboBox.Location = new System.Drawing.Point(488, 849);
            this.computerProblemComboBox.Name = "computerProblemComboBox";
            this.computerProblemComboBox.Size = new System.Drawing.Size(357, 30);
            this.computerProblemComboBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(481, 808);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Ordinateur";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(490, 900);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Écran";
            // 
            // screenProblemComboBox
            // 
            this.screenProblemComboBox.FormattingEnabled = true;
            this.screenProblemComboBox.Location = new System.Drawing.Point(488, 942);
            this.screenProblemComboBox.Name = "screenProblemComboBox";
            this.screenProblemComboBox.Size = new System.Drawing.Size(357, 30);
            this.screenProblemComboBox.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(490, 1006);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "Portable";
            // 
            // laptopProblemComboBox
            // 
            this.laptopProblemComboBox.FormattingEnabled = true;
            this.laptopProblemComboBox.Location = new System.Drawing.Point(486, 1047);
            this.laptopProblemComboBox.Name = "laptopProblemComboBox";
            this.laptopProblemComboBox.Size = new System.Drawing.Size(357, 30);
            this.laptopProblemComboBox.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(488, 1105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = "Cellulaire/Tablette";
            // 
            // phoneOrTabletProblemComboBox
            // 
            this.phoneOrTabletProblemComboBox.FormattingEnabled = true;
            this.phoneOrTabletProblemComboBox.Location = new System.Drawing.Point(486, 1147);
            this.phoneOrTabletProblemComboBox.Name = "phoneOrTabletProblemComboBox";
            this.phoneOrTabletProblemComboBox.Size = new System.Drawing.Size(357, 30);
            this.phoneOrTabletProblemComboBox.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(480, 1217);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 29);
            this.label10.TabIndex = 27;
            this.label10.Text = "MAT";
            // 
            // addRadioBtn
            // 
            this.addRadioBtn.AutoSize = true;
            this.addRadioBtn.Checked = true;
            this.addRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRadioBtn.Location = new System.Drawing.Point(50, 54);
            this.addRadioBtn.Name = "addRadioBtn";
            this.addRadioBtn.Size = new System.Drawing.Size(128, 35);
            this.addRadioBtn.TabIndex = 28;
            this.addRadioBtn.TabStop = true;
            this.addRadioBtn.Text = "Ajouter";
            this.addRadioBtn.UseVisualStyleBackColor = true;
            // 
            // modifyRadioBtn
            // 
            this.modifyRadioBtn.AutoSize = true;
            this.modifyRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyRadioBtn.Location = new System.Drawing.Point(50, 149);
            this.modifyRadioBtn.Name = "modifyRadioBtn";
            this.modifyRadioBtn.Size = new System.Drawing.Size(139, 35);
            this.modifyRadioBtn.TabIndex = 29;
            this.modifyRadioBtn.Text = "Modifier";
            this.modifyRadioBtn.UseVisualStyleBackColor = true;
            this.modifyRadioBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.modifyRadioBtn_MouseClick);
            // 
            // viewRadioBtn
            // 
            this.viewRadioBtn.AutoSize = true;
            this.viewRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewRadioBtn.Location = new System.Drawing.Point(50, 243);
            this.viewRadioBtn.Name = "viewRadioBtn";
            this.viewRadioBtn.Size = new System.Drawing.Size(87, 35);
            this.viewRadioBtn.TabIndex = 30;
            this.viewRadioBtn.Text = "Voir";
            this.viewRadioBtn.UseVisualStyleBackColor = true;
            this.viewRadioBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.viewRadioBtn_MouseClick);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(286, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 1434);
            this.label11.TabIndex = 31;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Red;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.cancelBtn.Location = new System.Drawing.Point(711, 1357);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(153, 61);
            this.cancelBtn.TabIndex = 33;
            this.cancelBtn.Text = "Annuler";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Green;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addBtn.Location = new System.Drawing.Point(521, 1357);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(153, 61);
            this.addBtn.TabIndex = 34;
            this.addBtn.Text = "Adjouter";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // aptNumTextBox
            // 
            this.aptNumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aptNumTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.aptNumTextBox.Location = new System.Drawing.Point(674, 596);
            this.aptNumTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.aptNumTextBox.Multiline = true;
            this.aptNumTextBox.Name = "aptNumTextBox";
            this.aptNumTextBox.Size = new System.Drawing.Size(332, 33);
            this.aptNumTextBox.TabIndex = 35;
            this.aptNumTextBox.Text = "Appartement, suite, ect.";
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postalCodeTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.postalCodeTextBox.Location = new System.Drawing.Point(673, 678);
            this.postalCodeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.postalCodeTextBox.Multiline = true;
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(332, 33);
            this.postalCodeTextBox.TabIndex = 36;
            this.postalCodeTextBox.Text = "Code Postal";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cityTextBox.Location = new System.Drawing.Point(674, 637);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cityTextBox.Multiline = true;
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(332, 33);
            this.cityTextBox.TabIndex = 37;
            this.cityTextBox.Text = "Ville";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1215, 750);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.postalCodeTextBox);
            this.Controls.Add(this.aptNumTextBox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.viewRadioBtn);
            this.Controls.Add(this.modifyRadioBtn);
            this.Controls.Add(this.addRadioBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.phoneOrTabletProblemComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.laptopProblemComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.screenProblemComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.computerProblemComboBox);
            this.Controls.Add(this.inPersonRadioBtn);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(this.phoneRadioBtn);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.emailRadioBtn);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.MATTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.problemDescriptionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.opeq_CallCenterDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox problemDescriptionTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MATTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.RadioButton emailRadioBtn;
        private System.Windows.Forms.RadioButton phoneRadioBtn;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.RadioButton inPersonRadioBtn;
        private System.Windows.Forms.TextBox streetTextBox;
        private Opeq_CallCenterDataSet opeq_CallCenterDataSet1;
        private System.Windows.Forms.ComboBox computerProblemComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox screenProblemComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox laptopProblemComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox phoneOrTabletProblemComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton addRadioBtn;
        private System.Windows.Forms.RadioButton modifyRadioBtn;
        private System.Windows.Forms.RadioButton viewRadioBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox aptNumTextBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
    }
}