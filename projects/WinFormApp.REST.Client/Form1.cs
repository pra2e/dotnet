using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp.REST.Client {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        // Custom debug output function
        private void debugOutput(string strDebugText) {
            try {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtRestResource.Text = txtRestResource.Text + strDebugText + Environment.NewLine;
                txtRestResource.SelectionStart = txtRestResource.TextLength;
                txtRestResource.ScrollToCaret();
            }
            catch (Exception ex) {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }


        // UI Event Handlers
        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            debugOutput("Hi");
        }

    }
}
