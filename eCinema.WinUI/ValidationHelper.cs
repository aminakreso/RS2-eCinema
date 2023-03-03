﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.WinUI
{
    public static class ValidationHelper
    {
        public static void  Validate(TextBox textBox, CancelEventArgs e, string name, ErrorProvider errorProvider, bool number = false)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text) || (number && !int.TryParse(textBox.Text, out int result)))
            {
                e.Cancel = true;
                textBox.Focus();
                if(number)
                    errorProvider.SetError(textBox, name + " must be a number!");

                else
                    errorProvider.SetError(textBox, name + " should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBox, "");
            }

        }

        public static void ValidateRichTextBox(RichTextBox textBox, CancelEventArgs e, string name, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
        
                errorProvider.SetError(textBox, name + " should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBox, "");
            }

        }
    }
}