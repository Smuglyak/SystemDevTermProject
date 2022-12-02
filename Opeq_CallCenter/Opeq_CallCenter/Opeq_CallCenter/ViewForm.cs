﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opeq_CallCenter
{
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
        }

        public ViewForm(string empName)
        {
            InitializeComponent();
            empNameTextView.Text = empName;

            if(empName == "Simon.P")
            {
                adminRadioBtn.Show();
            }
            else
            {
                adminRadioBtn.Hide();
            }
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {

        }

        private void addButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            String empName = empNameTextView.Text;
            AddForm addFormInstance = new AddForm(empName);
            addFormInstance.ShowDialog();
            this.Close();
        }

        private void modifyRadioBtn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            String empName = empNameTextView.Text;
            ModifyForm modifyFormInstance = new ModifyForm(empName);
            modifyFormInstance.ShowDialog();
            this.Close();
        }

        private void viewRadioBtn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            String empName = empNameTextView.Text;
            ViewForm viewFormInstance = new ViewForm(empName);
            viewFormInstance.ShowDialog();
            this.Close();
        }

        private void adminRadioBtn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            AdminPage adminFormInstance = new AdminPage();
            adminFormInstance.ShowDialog();
            this.Close();
        }
    }
}
