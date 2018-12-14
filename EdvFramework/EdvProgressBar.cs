using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdvFramework
{
    public class EdvProgressBar : Panel
    {
        //Construtor
        public EdvProgressBar()
        {
            this._panel2 = new System.Windows.Forms.Panel();
            //edvProgressBar
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this._panel2);
            this.Location = new System.Drawing.Point(267, 228);
            this.Name = "edvProgressbar";
            this.Size = new System.Drawing.Size(100, 23);
            this.TabIndex = 7;

            // 
            // panel2
            // 
            this._panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this._panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this._panel2.Location = new System.Drawing.Point(0, 0);
            this._panel2.Name = "panel2";
            this._panel2.Size = new System.Drawing.Size(0, 23);
            this._panel2.TabIndex = 8;
        }

        //Propriedade Value
        int _value = 0;
        public int Value
        {
            get { return this._value; }
            set { this._value = value; _EncherProgressBar(value); }
        }

        //Propriedade 'ThemeColor'
        public System.Drawing.Color ThemeColor
        {
            get { return this._panel2.BackColor; }
            set { this._panel2.BackColor = value; }
        }

        void _EncherProgressBar(int valor)
        {
            if (valor > 100 || valor < 0)
            {
                this._value = 0;
                valor = 0;
            }
            this._panel2.Width = Convert.ToInt32((this.Width * valor) / 100);
        }

        //Objectos usados no edvProgressBar
        Panel _panel2;
    }
}
