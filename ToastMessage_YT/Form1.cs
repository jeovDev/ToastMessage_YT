using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToastMessage_YT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void showToast(string type, string message) {
            ToastForm toast = new ToastForm(type,message);
            toast.Show();
        }
        private void btnSuccess_Click(object sender, EventArgs e)
        {
            showToast("SUCCESS", "This is a Success Toast");
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            showToast("INFO", "This is a Info Toast");
        }

        private void btnWarning_Click(object sender, EventArgs e)
        {
            showToast("WARNING", "This is a Warning Toast");
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            showToast("ERROR", "This is a Error Toast");
        }
    }
}
