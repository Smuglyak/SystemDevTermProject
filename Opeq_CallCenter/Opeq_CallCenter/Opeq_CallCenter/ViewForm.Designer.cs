﻿namespace Opeq_CallCenter
{
    partial class ViewForm
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
            this.components = new System.ComponentModel.Container();
            this.searchbar = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.viewBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resultBox = new System.Windows.Forms.RichTextBox();
            this.filter = new System.Windows.Forms.GroupBox();
            this.unresolvedRadioBtn = new System.Windows.Forms.RadioButton();
            this.ongoingRadioBtn = new System.Windows.Forms.RadioButton();
            this.resolveRadioBtn = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.navigation = new System.Windows.Forms.GroupBox();
            this.adminRadioBtn = new System.Windows.Forms.RadioButton();
            this.viewRadioBtn = new System.Windows.Forms.RadioButton();
            this.modifyRadioBtn = new System.Windows.Forms.RadioButton();
            this.addRadioBtn = new System.Windows.Forms.RadioButton();
            this.empNameTextView = new System.Windows.Forms.Label();
            this.filter.SuspendLayout();
            this.navigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchbar
            // 
            this.searchbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbar.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.searchbar.Location = new System.Drawing.Point(631, 30);
            this.searchbar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchbar.Multiline = true;
            this.searchbar.Name = "searchbar";
            this.searchbar.Size = new System.Drawing.Size(445, 42);
            this.searchbar.TabIndex = 0;
            this.searchbar.Text = "Enter nom du cliente, MAT, ou nom du commande";
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(490, 30);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(124, 42);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rechercher";
            // 
            // viewBtn
            // 
            this.viewBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.viewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtn.Location = new System.Drawing.Point(595, 712);
            this.viewBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(146, 54);
            this.viewBtn.TabIndex = 3;
            this.viewBtn.Text = "Voir";
            this.viewBtn.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(352, 160);
            this.resultBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(724, 525);
            this.resultBox.TabIndex = 6;
            this.resultBox.Text = "";
            // 
            // filter
            // 
            this.filter.Controls.Add(this.unresolvedRadioBtn);
            this.filter.Controls.Add(this.ongoingRadioBtn);
            this.filter.Controls.Add(this.resolveRadioBtn);
            this.filter.Location = new System.Drawing.Point(369, 86);
            this.filter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filter.Name = "filter";
            this.filter.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filter.Size = new System.Drawing.Size(706, 60);
            this.filter.TabIndex = 7;
            this.filter.TabStop = false;
            // 
            // unresolvedRadioBtn
            // 
            this.unresolvedRadioBtn.AutoSize = true;
            this.unresolvedRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unresolvedRadioBtn.Location = new System.Drawing.Point(456, 26);
            this.unresolvedRadioBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.unresolvedRadioBtn.Name = "unresolvedRadioBtn";
            this.unresolvedRadioBtn.Size = new System.Drawing.Size(144, 29);
            this.unresolvedRadioBtn.TabIndex = 2;
            this.unresolvedRadioBtn.TabStop = true;
            this.unresolvedRadioBtn.Text = "Non Résolu";
            this.unresolvedRadioBtn.UseVisualStyleBackColor = true;
            // 
            // ongoingRadioBtn
            // 
            this.ongoingRadioBtn.AutoSize = true;
            this.ongoingRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ongoingRadioBtn.Location = new System.Drawing.Point(252, 26);
            this.ongoingRadioBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ongoingRadioBtn.Name = "ongoingRadioBtn";
            this.ongoingRadioBtn.Size = new System.Drawing.Size(123, 29);
            this.ongoingRadioBtn.TabIndex = 1;
            this.ongoingRadioBtn.TabStop = true;
            this.ongoingRadioBtn.Text = "En Cours";
            this.ongoingRadioBtn.UseVisualStyleBackColor = true;
            // 
            // resolveRadioBtn
            // 
            this.resolveRadioBtn.AutoSize = true;
            this.resolveRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resolveRadioBtn.Location = new System.Drawing.Point(52, 26);
            this.resolveRadioBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resolveRadioBtn.Name = "resolveRadioBtn";
            this.resolveRadioBtn.Size = new System.Drawing.Size(99, 29);
            this.resolveRadioBtn.TabIndex = 0;
            this.resolveRadioBtn.TabStop = true;
            this.resolveRadioBtn.Text = "Résolu";
            this.resolveRadioBtn.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(271, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 773);
            this.label11.TabIndex = 32;
            // 
            // navigation
            // 
            this.navigation.Controls.Add(this.adminRadioBtn);
            this.navigation.Controls.Add(this.viewRadioBtn);
            this.navigation.Controls.Add(this.modifyRadioBtn);
            this.navigation.Controls.Add(this.addRadioBtn);
            this.navigation.Location = new System.Drawing.Point(41, 69);
            this.navigation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navigation.Name = "navigation";
            this.navigation.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navigation.Size = new System.Drawing.Size(205, 344);
            this.navigation.TabIndex = 33;
            this.navigation.TabStop = false;
            // 
            // adminRadioBtn
            // 
            this.adminRadioBtn.AutoSize = true;
            this.adminRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminRadioBtn.Location = new System.Drawing.Point(5, 255);
            this.adminRadioBtn.Name = "adminRadioBtn";
            this.adminRadioBtn.Size = new System.Drawing.Size(191, 35);
            this.adminRadioBtn.TabIndex = 104;
            this.adminRadioBtn.Text = "Admin Page";
            this.adminRadioBtn.UseVisualStyleBackColor = true;
            this.adminRadioBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.adminRadioBtn_MouseClick);
            // 
            // viewRadioBtn
            // 
            this.viewRadioBtn.AutoSize = true;
            this.viewRadioBtn.Checked = true;
            this.viewRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewRadioBtn.Location = new System.Drawing.Point(26, 186);
            this.viewRadioBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewRadioBtn.Name = "viewRadioBtn";
            this.viewRadioBtn.Size = new System.Drawing.Size(87, 35);
            this.viewRadioBtn.TabIndex = 33;
            this.viewRadioBtn.TabStop = true;
            this.viewRadioBtn.Text = "Voir";
            this.viewRadioBtn.UseVisualStyleBackColor = true;
            this.viewRadioBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.viewRadioBtn_MouseClick);
            // 
            // modifyRadioBtn
            // 
            this.modifyRadioBtn.AutoSize = true;
            this.modifyRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyRadioBtn.Location = new System.Drawing.Point(26, 111);
            this.modifyRadioBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modifyRadioBtn.Name = "modifyRadioBtn";
            this.modifyRadioBtn.Size = new System.Drawing.Size(139, 35);
            this.modifyRadioBtn.TabIndex = 32;
            this.modifyRadioBtn.Text = "Modifier";
            this.modifyRadioBtn.UseVisualStyleBackColor = true;
            this.modifyRadioBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.modifyRadioBtn_MouseClick);
            // 
            // addRadioBtn
            // 
            this.addRadioBtn.AutoSize = true;
            this.addRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRadioBtn.Location = new System.Drawing.Point(26, 35);
            this.addRadioBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addRadioBtn.Name = "addRadioBtn";
            this.addRadioBtn.Size = new System.Drawing.Size(128, 35);
            this.addRadioBtn.TabIndex = 31;
            this.addRadioBtn.Text = "Ajouter";
            this.addRadioBtn.UseVisualStyleBackColor = true;
            this.addRadioBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addButton_MouseClick);
            // 
            // empNameTextView
            // 
            this.empNameTextView.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empNameTextView.Location = new System.Drawing.Point(13, 9);
            this.empNameTextView.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.empNameTextView.Name = "empNameTextView";
            this.empNameTextView.Size = new System.Drawing.Size(251, 58);
            this.empNameTextView.TabIndex = 103;
            this.empNameTextView.Text = "Nom";
            this.empNameTextView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1215, 750);
            this.Controls.Add(this.empNameTextView);
            this.Controls.Add(this.navigation);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchbar);
            this.Name = "ViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewForm";
            this.Load += new System.EventHandler(this.ViewForm_Load);
            this.filter.ResumeLayout(false);
            this.filter.PerformLayout();
            this.navigation.ResumeLayout(false);
            this.navigation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchbar;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox resultBox;
        private System.Windows.Forms.GroupBox filter;
        private System.Windows.Forms.RadioButton unresolvedRadioBtn;
        private System.Windows.Forms.RadioButton ongoingRadioBtn;
        private System.Windows.Forms.RadioButton resolveRadioBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox navigation;
        private System.Windows.Forms.RadioButton viewRadioBtn;
        private System.Windows.Forms.RadioButton modifyRadioBtn;
        private System.Windows.Forms.RadioButton addRadioBtn;
        private System.Windows.Forms.Label empNameTextView;
        private System.Windows.Forms.RadioButton adminRadioBtn;
    }
}