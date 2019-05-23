using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables
{
    public partial class Form1 : Form{
        #region variables
        string[] nameArrayy = { "", "", "", "", "" };
        int contArray = 0;
        #endregion

        #region init & load

        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            errorLabel.Text = "";
        }

        //#region add button click
        private void ADD_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";

            if (nameTextBox.Text != null && nameTextBox.Text.Trim() != ""){
                int size = nameArrayy.Length;
                if(contArray < size) {
                    nameArrayy[contArray] = nameTextBox.Text;
                    //label1[contArray] = textBox1.Text;
                    contArray++;
                } else {
                    errorLabel.Text = "Numeber exceded!";
                }

            } else{
                errorLabel.Text = "Name can not be null";
            }
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }

        private void Label1_Click_1(object sender, EventArgs e) {

        }
        //#endregion
    }
}
#endregion