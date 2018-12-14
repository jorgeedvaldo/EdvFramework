using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdvFramework
{
    public class EdvButton : Button
    {
        //Construtor
        public EdvButton()
        {
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Location = new System.Drawing.Point(100, 254);
            this.Name = "EdvButton";
            this.Size = new System.Drawing.Size(91, 50);
            this.TabIndex = 4;
            this.Text = "EdvButton";
            this.UseVisualStyleBackColor = false;
        }
    }
}
