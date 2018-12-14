namespace Teste
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.edvButton1 = new EdvFramework.EdvButton();
            this.edvTextBox1 = new EdvFramework.EdvTextBox();
            this.edvButton2 = new EdvFramework.EdvButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.edvProgressBar1 = new EdvFramework.EdvProgressBar();
            this.SuspendLayout();
            // 
            // edvButton1
            // 
            this.edvButton1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.edvButton1.FlatAppearance.BorderSize = 0;
            this.edvButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edvButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edvButton1.ForeColor = System.Drawing.Color.White;
            this.edvButton1.Location = new System.Drawing.Point(20, 114);
            this.edvButton1.Name = "edvButton1";
            this.edvButton1.Size = new System.Drawing.Size(91, 50);
            this.edvButton1.TabIndex = 4;
            this.edvButton1.Text = "edvButton1";
            this.edvButton1.UseVisualStyleBackColor = false;
            // 
            // edvTextBox1
            // 
            this.edvTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edvTextBox1.Location = new System.Drawing.Point(75, 60);
            this.edvTextBox1.Name = "edvTextBox1";
            this.edvTextBox1.OnlyNumber = true;
            this.edvTextBox1.Size = new System.Drawing.Size(129, 25);
            this.edvTextBox1.TabIndex = 5;
            // 
            // edvButton2
            // 
            this.edvButton2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.edvButton2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.edvButton2.FlatAppearance.BorderSize = 0;
            this.edvButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edvButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edvButton2.ForeColor = System.Drawing.Color.White;
            this.edvButton2.Location = new System.Drawing.Point(160, 114);
            this.edvButton2.Name = "edvButton2";
            this.edvButton2.Size = new System.Drawing.Size(91, 50);
            this.edvButton2.TabIndex = 4;
            this.edvButton2.Text = "edvButton2";
            this.edvButton2.UseVisualStyleBackColor = false;
            this.edvButton2.Click += new System.EventHandler(this.edvButton2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(302, 195);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(251, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // edvProgressBar1
            // 
            this.edvProgressBar1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.edvProgressBar1.Location = new System.Drawing.Point(31, 195);
            this.edvProgressBar1.Name = "edvProgressBar1";
            this.edvProgressBar1.Size = new System.Drawing.Size(251, 23);
            this.edvProgressBar1.TabIndex = 7;
            this.edvProgressBar1.ThemeColor = System.Drawing.Color.DeepSkyBlue;
            this.edvProgressBar1.Value = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 375);
            this.Controls.Add(this.edvProgressBar1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.edvButton2);
            this.Controls.Add(this.edvTextBox1);
            this.Controls.Add(this.edvButton1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EdvFramework.EdvButton edvButton1;
        private EdvFramework.EdvTextBox edvTextBox1;
        private EdvFramework.EdvButton edvButton2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private EdvFramework.EdvProgressBar edvProgressBar1;
    }
}