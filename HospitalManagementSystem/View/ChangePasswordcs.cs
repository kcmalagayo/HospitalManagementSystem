﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem.View
{
    public partial class ChangePasswordcs : Form
    {
        public ChangePasswordcs()
        {
            InitializeComponent();
            confirmNewPasswordTextBox.PasswordChar = '*';
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            confirmNewPasswordTextBox.PasswordChar = showPasswordCheckBox.Checked ? '\0' : '*';
        }
    }
}
