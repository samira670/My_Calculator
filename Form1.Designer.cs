namespace Calculator
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnbackspace = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.btnminis = new System.Windows.Forms.Button();
            this.btnmulty = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btndivide = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btndot = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnequal = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnOn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnbackspace);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btnplus);
            this.panel1.Controls.Add(this.btnminis);
            this.panel1.Controls.Add(this.btnmulty);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btndivide);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btndot);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btnequal);
            this.panel1.Controls.Add(this.btn0);
            this.panel1.Location = new System.Drawing.Point(35, 132);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 314);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(140, 26);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 45);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnbackspace
            // 
            this.btnbackspace.Location = new System.Drawing.Point(16, 26);
            this.btnbackspace.Name = "btnbackspace";
            this.btnbackspace.Size = new System.Drawing.Size(118, 45);
            this.btnbackspace.TabIndex = 16;
            this.btnbackspace.Text = "<------";
            this.btnbackspace.UseVisualStyleBackColor = true;
           
            this.btnbackspace.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnbackspace_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(16, 90);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(56, 45);
            this.btn9.TabIndex = 15;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btnplus
            // 
            this.btnplus.Location = new System.Drawing.Point(78, 90);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(56, 45);
            this.btnplus.TabIndex = 14;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Operator);
            // 
            // btnminis
            // 
            this.btnminis.Location = new System.Drawing.Point(140, 90);
            this.btnminis.Name = "btnminis";
            this.btnminis.Size = new System.Drawing.Size(56, 45);
            this.btnminis.TabIndex = 13;
            this.btnminis.Text = "-";
            this.btnminis.UseVisualStyleBackColor = true;
            this.btnminis.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Operator);
            // 
            // btnmulty
            // 
            this.btnmulty.Location = new System.Drawing.Point(202, 90);
            this.btnmulty.Name = "btnmulty";
            this.btnmulty.Size = new System.Drawing.Size(56, 45);
            this.btnmulty.TabIndex = 12;
            this.btnmulty.Text = "*";
            this.btnmulty.UseVisualStyleBackColor = true;
            this.btnmulty.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Operator);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(78, 141);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(56, 45);
            this.btn7.TabIndex = 11;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btndivide
            // 
            this.btndivide.Location = new System.Drawing.Point(202, 141);
            this.btndivide.Name = "btndivide";
            this.btndivide.Size = new System.Drawing.Size(56, 45);
            this.btndivide.TabIndex = 10;
            this.btndivide.Text = "/";
            this.btndivide.UseVisualStyleBackColor = true;
            this.btndivide.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Operator);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(140, 141);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(56, 45);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(16, 192);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(56, 45);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(78, 192);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(56, 45);
            this.btn4.TabIndex = 7;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(140, 192);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(56, 45);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btndot
            // 
            this.btndot.Location = new System.Drawing.Point(202, 192);
            this.btndot.Name = "btndot";
            this.btndot.Size = new System.Drawing.Size(56, 45);
            this.btndot.TabIndex = 5;
            this.btndot.Text = ".";
            this.btndot.UseVisualStyleBackColor = true;
            this.btndot.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(16, 141);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(56, 45);
            this.btn6.TabIndex = 4;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(78, 243);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(56, 47);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(140, 245);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(56, 45);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btnequal
            // 
            this.btnequal.Location = new System.Drawing.Point(202, 245);
            this.btnequal.Name = "btnequal";
            this.btnequal.Size = new System.Drawing.Size(56, 45);
            this.btnequal.TabIndex = 1;
            this.btnequal.Text = "=";
            this.btnequal.UseVisualStyleBackColor = true;
            this.btnequal.Click += new System.EventHandler(this.Equal);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(16, 245);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(56, 45);
            this.btn0.TabIndex = 0;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(35, 30);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(279, 27);
            this.txtDisplay.TabIndex = 1;
            this.txtDisplay.TextChanged += new System.EventHandler(this.txtDisplay_TextChanged);
            // 
            // btnOn
            // 
            this.btnOn.Location = new System.Drawing.Point(35, 80);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(118, 45);
            this.btnOn.TabIndex = 17;
            this.btnOn.Text = "ON";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 486);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Operator);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btnminis;
        private System.Windows.Forms.Button btnmulty;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btndivide;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btndot;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnequal;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnbackspace;
        private System.Windows.Forms.Button btnOn;
    }
}

