namespace Teste
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
            this.edvButton1 = new EdvFramework.EdvButton();
            this.edvTextBox1 = new EdvFramework.EdvTextBox();
            this.edvTextBox2 = new EdvFramework.EdvTextBox();
            this.edvProgressBar1 = new EdvFramework.EdvProgressBar();
            this.edvTextBox3 = new EdvFramework.EdvTextBox();
            this.edvButton2 = new EdvFramework.EdvButton();
            this.SuspendLayout();
            // 
            // edvButton1
            // 
            this.edvButton1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.edvButton1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.edvButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edvButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edvButton1.ForeColor = System.Drawing.Color.Black;
            this.edvButton1.Location = new System.Drawing.Point(100, 245);
            this.edvButton1.Name = "edvButton1";
            this.edvButton1.Size = new System.Drawing.Size(108, 50);
            this.edvButton1.TabIndex = 4;
            this.edvButton1.Text = "edvButton1";
            this.edvButton1.UseVisualStyleBackColor = false;
            // 
            // edvTextBox1
            // 
            this.edvTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edvTextBox1.Location = new System.Drawing.Point(21, 84);
            this.edvTextBox1.Name = "edvTextBox1";
            this.edvTextBox1.OnlyNumber = false;
            this.edvTextBox1.Size = new System.Drawing.Size(129, 25);
            this.edvTextBox1.TabIndex = 5;
            // 
            // edvTextBox2
            // 
            this.edvTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edvTextBox2.Location = new System.Drawing.Point(239, 84);
            this.edvTextBox2.Name = "edvTextBox2";
            this.edvTextBox2.OnlyNumber = true;
            this.edvTextBox2.Size = new System.Drawing.Size(129, 25);
            this.edvTextBox2.TabIndex = 5;
            this.edvTextBox2.Text = "0";
            this.edvTextBox2.TextChanged += new System.EventHandler(this.edvTextBox2_TextChanged);
            // 
            // edvProgressBar1
            // 
            this.edvProgressBar1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.edvProgressBar1.Location = new System.Drawing.Point(174, 137);
            this.edvProgressBar1.Name = "edvProgressBar1";
            this.edvProgressBar1.Size = new System.Drawing.Size(153, 47);
            this.edvProgressBar1.TabIndex = 7;
            this.edvProgressBar1.ThemeColor = System.Drawing.Color.DeepSkyBlue;
            this.edvProgressBar1.Value = 0;
            // 
            // edvTextBox3
            // 
            this.edvTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edvTextBox3.Location = new System.Drawing.Point(21, 190);
            this.edvTextBox3.Name = "edvTextBox3";
            this.edvTextBox3.OnlyNumber = false;
            this.edvTextBox3.Size = new System.Drawing.Size(129, 25);
            this.edvTextBox3.TabIndex = 5;
            // 
            // edvButton2
            // 
            this.edvButton2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.edvButton2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.edvButton2.FlatAppearance.BorderSize = 0;
            this.edvButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edvButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edvButton2.ForeColor = System.Drawing.Color.White;
            this.edvButton2.Location = new System.Drawing.Point(268, 221);
            this.edvButton2.Name = "edvButton2";
            this.edvButton2.Size = new System.Drawing.Size(91, 50);
            this.edvButton2.TabIndex = 4;
            this.edvButton2.Text = "edvButton2";
            this.edvButton2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 326);
            this.Controls.Add(this.edvButton2);
            this.Controls.Add(this.edvTextBox3);
            this.Controls.Add(this.edvProgressBar1);
            this.Controls.Add(this.edvTextBox2);
            this.Controls.Add(this.edvTextBox1);
            this.Controls.Add(this.edvButton1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EdvFramework.EdvButton edvButton1;
        private EdvFramework.EdvTextBox edvTextBox1;
        private EdvFramework.EdvTextBox edvTextBox2;
        private EdvFramework.EdvProgressBar edvProgressBar1;
        private EdvFramework.EdvTextBox edvTextBox3;
        private EdvFramework.EdvButton edvButton2;



    }
}

