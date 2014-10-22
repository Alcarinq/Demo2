using EasyArchive.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyArchive
{
    public partial class MainForm : Form
    {
        ActivityLogger _activityLogger;

        public MainForm()
        {
            InitializeComponent();

            _activityLogger = new ActivityLogger(new LabelDisplay(lblStatus));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool CheckLoginIsUnique()
        {
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _activityLogger.Show("Button Add Clicked !");
            if (string.IsNullOrEmpty(tbLogin.Text))
            {
                MessageBox.Show("Login Text Area is empty !");
                /*
                 * 
                 * add user to rep
                 * 
                 * 
                 * 
                 */
            }
 			else if (CheckLoginIsUnique())
            {
                MessageBox.Show("Podany login NIE jest unikalny");
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _activityLogger.Show("Button Cancel Clicked !");
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
