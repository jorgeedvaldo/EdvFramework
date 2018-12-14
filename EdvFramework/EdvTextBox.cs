using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdvFramework
{
    public class EdvTextBox : TextBox
    {
        //Construtor
        public EdvTextBox()
        {
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(18, 147);
            this.Name = "EdvTextBox";
            this.Size = new System.Drawing.Size(129, 25);
            this.TabIndex = 5;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EdvTextBox_KeyPress);
            this.TextChanged += new EventHandler(this.EdvTextBox_TextChanged);
        }

        bool _onlynumber = false;
        public bool OnlyNumber
        {
            get { return _onlynumber; }
            set { _onlynumber = value; this.Clear(); }
        }
        private void EdvTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_onlynumber)
            {
                bool __temvirgula = false;
                for (int i = 0; i < this.Text.Length; i++)
                {
                    if (this.Text[i] == ',')
                    {
                        __temvirgula = true;
                        break;
                    }
                }

                if (__temvirgula)
                {
                    if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == ','))
                    {
                        e.Handled = true;
                    }
                }
            }
        }
        private void EdvTextBox_TextChanged(object sender, EventArgs e)
        {
            if ((_onlynumber == true))
            {
                if ((this.Text.Length == 1 && this.Text[0] == ','))
                {
                    this.Text = "0,";
                }

                if (this.Text.Length > 0)
                {
                    try
                    {
                        Convert.ToDouble(this.Text);
                    }
                    catch
                    {
                        this.Text = "0";
                    }
                }
            }
        }

    }
}
