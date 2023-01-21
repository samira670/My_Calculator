using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double x, y, z;
        string op;
        Boolean flag;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             txtDisplay_TextChanged(null, null);
            if (btnOn.Text =="ON")
                panel1.Enabled = false; 
         
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Equal(object sender, EventArgs e)
        {
            y = Convert.ToDouble(txtDisplay.Text);
                if (op == "+")
            {
                z= x +y;
            }
            if (op == "-")
            {
                z = x - y;
            }
            if (op == "/")
            {
                z = x / y;
            }
            if (op == "*")
            {
                z = x * y;
            }
            txtDisplay.Text = z.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
            btndot.Enabled = !txtDisplay.Text.Contains(".");
           btnbackspace.Enabled = Convert.ToBoolean(txtDisplay.Text.Length);
            btnClear.Enabled = Convert.ToBoolean(txtDisplay.Text.Length);



        }

        private void btnbackspace_Click(object sender, MouseEventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            txtDisplay.Text=txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            panel1.Enabled = !panel1.Enabled;
            if (btnOn.Text == "ON")
            {

                btnOn.Text = "OFF";
                this.KeyPreview = true;
            }



            else
            {
                btnOn.Text = "ON";
                txtDisplay.Text = "";
                this.KeyPreview = false;
            }

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            foreach (Control c in panel1.Controls)
                if (c.Text == e.KeyChar.ToString())
                {
                    c.Focus();
                    c.ForeColor = Color.Red;

                }
                else
                    c.ForeColor = Color.Black;
            Button temp = new Button();
            temp.Text = e.KeyChar.ToString();
            if (e.KeyChar >= '0' && e.KeyChar <= '9')

                Numbers(temp, null);

            else if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/')
                Operator(temp, null);
            else if (e.KeyChar == '=')
                Equal(null, null);
            else if (e.KeyChar == '.' && !txtDisplay.Text.Contains("."))
                Numbers(temp, null);
            else if (e.KeyChar == '\b')
                btnbackspace_Click(null, null);



        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Equal(null, null);
                btnequal.Focus();
              
            }
        }

      

        

        private void Numbers(object sender, MouseEventArgs e)

        { if (flag==true)
            {
                txtDisplay.Text = "";
                    }
            txtDisplay.Text += ((Control)sender).Text;

            flag = false;
            
        }

        private void Operator(object sender, MouseEventArgs e)
        {  
            if (op != null)
            {
                Equal(null, null);
            }
            x = Convert.ToDouble(txtDisplay.Text);
            op = ((Button)sender).Text;
            flag = true;

        }
    }
}
