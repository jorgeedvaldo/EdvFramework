using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdvFramework{

    public class EdvForm : Form
    {
        public EdvForm() {
            IniciarComponentes();
        }

        #region Componentes do form
        private System.Windows.Forms.Panel _bordaCima { get; set; }
        private System.Windows.Forms.Button btmin { get; set; }
        private System.Windows.Forms.Button btmax { get; set; }
        private System.Windows.Forms.Button btclose { get; set; }
        private System.Windows.Forms.Label _txtHeader { get; set; }
        private System.Windows.Forms.Panel _bordaEsquerda { get; set; }
        private System.Windows.Forms.Panel _bordaDireita { get; set; }
        private System.Windows.Forms.Panel _bordaBaixo { get; set; }
        #endregion

        #region Eventos do form

        #region Mover Formulário    
        Point newpoint = new Point();
        int mouseX, mouseY;
        private void Objecto_MouseDown(object sender, MouseEventArgs e)
        {
            if (MoveForm)
            {
                mouseX = Control.MousePosition.X - this.Location.X;
                mouseY = Control.MousePosition.Y - this.Location.Y;
            }

        }

        private void Objecto_MouseMove(object sender, MouseEventArgs e)
        {
            if (MoveForm)
            {
                if (e.Button == MouseButtons.Left)
                {
                    newpoint = Control.MousePosition;
                    newpoint.X -= mouseX;
                    newpoint.Y -= mouseY;
                    this.Location = newpoint;
                }
            }
        }
        #endregion

        #region Minimizar, Maximinizar e Fechar Formulário
        private void minForm(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void maxForm(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
            if (this.WindowState == FormWindowState.Maximized)
            {
                btmax.Text = "2";
            }
            else 
            {
                btmax.Text = "1";
            }
        }
        private void closeForm(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Outros Eventos
        private void _EdvForm_Load(object sender, EventArgs e)
        {
            this.Padding = new System.Windows.Forms.Padding(1, 35, 1, 1);
            if (this.WindowState == FormWindowState.Maximized)
            {
                btmax.Text = "2";
            }

            _bordaCima.Width = this.Width;
            _bordaCima.Location = new Point(0, 0);

            _bordaBaixo.Location = new Point(0, this.Height - 1);
            _bordaBaixo.Width = this.Width;

            _bordaDireita.Location = new Point(this.Width - 1, 0);
            _bordaDireita.Height = this.Height;

            _bordaEsquerda.Location = new Point(0, 0);
            _bordaEsquerda.Height = this.Height;

            _MudarBorda(this.FormBorderStyle);
        }

        private void _EdvForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                btmax.Text = "2";
            }
            else
            {
                btmax.Text = "1";
            }

            _MudarBorda(this.FormBorderStyle);
        }

        private void _EdvForm_PaddingChanged(object sender, EventArgs e)
        {
            if (this.FormBorderStyle == EdvFormBorderStyle.Default)
            {
                if (this.Padding.Bottom < 1 || this.Padding.Left < 1 || this.Padding.Right < 1 || this.Padding.Top < 35)
                {
                    this.Padding = new System.Windows.Forms.Padding(1, 35, 1, 1);
                }
            }

        }
        #endregion

        #endregion

        #region Propriedades
        //Propriedade 'ThemeColor'
        public System.Drawing.Color ThemeColor
        {
            get { return _bordaCima.BackColor; }
            set { 
                _bordaCima.BackColor = value; 
                _bordaBaixo.BackColor = value; 
                _bordaDireita.BackColor = value;
                _bordaEsquerda.BackColor = value; 
            }
        }

        //Propriedade 'MoveForm'
        bool _moveform = true;
        public bool MoveForm
        {
            get { return _moveform; }
            set { this._moveform = value; }
        }

        //Propriedade 'Text'
        string _text = "EdvForm";
        public override string Text
        {
            get { return _text; }
            set{ 
                this._text = value; 
                this._txtHeader.Text = value;
            }
        }

        //Propriedade 'MaximizeBox'
        bool _maxbox = true;
        public new bool MaximizeBox
        {
            get { return _maxbox; }
            set { 
                _maxbox = value; 
                this.btmax.Visible = value; 
            }
        }

        //Propriedade 'MinimizeBox'
        bool _minbox = true;
        public new bool MinimizeBox
        {
            get { return this._minbox; }
            set { 
                this._minbox = value; 
                this.btmin.Visible = value; 
            }
        }

        //Propriedade 'CloseBox'
        bool _closebox = true;
        public bool CloseBox
        {
            get { return this._closebox; }
            set { this._closebox = value; this.btclose.Visible = value; }
        }

        //Propriedade 'FormBorderStyle'
        EdvFormBorderStyle _bdStyle = EdvFormBorderStyle.Default;
        public new EdvFormBorderStyle FormBorderStyle
        {
            get { return _bdStyle; }
            set { 
                _bdStyle = value; 
                _MudarBorda(value); 
            }
        }
        void _removerBordas() {
            try
            {
                this.Controls.Remove(this._bordaCima);
                this.Controls.Remove(this._bordaBaixo);
                this.Controls.Remove(this._bordaDireita);
                this.Controls.Remove(this._bordaEsquerda);
            }
            catch { }
        }
        void _MudarBorda(EdvFormBorderStyle fm)
        {

            switch (fm)
            {
                case EdvFormBorderStyle.None:
                    this._removerBordas();
                    this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
                    break;
                case EdvFormBorderStyle.Second:
                    this.Padding = new System.Windows.Forms.Padding(0, 35, 0, 10);
                    this._bordaCima.Width = this.Width;
                    this._bordaCima.Location = new Point(0, 0);

                    this._bordaBaixo.Location = new Point(0, this.Height - 10);
                    this._bordaBaixo.Width = this.Width;
                    this._bordaBaixo.Height = 10;
                    this._removerBordas();
                    this.Controls.Add(this._bordaCima);
                    this.Controls.Add(this._bordaBaixo);
                    
                break;
                default:
                    
                    this.Padding = new System.Windows.Forms.Padding(1, 35, 1, 1);
                    this._bordaCima.Width = this.Width;
                    this._bordaCima.Location = new Point(0, 0);

                    this._bordaBaixo.Location = new Point(0, this.Height - 1);
                    this._bordaBaixo.Width = this.Width;

                    this._bordaDireita.Location = new Point(this.Width - 1, 0);
                    this._bordaDireita.Height = this.Height;

                    this._bordaEsquerda.Location = new Point(0, 0);
                    this._bordaEsquerda.Height = this.Height;

                    this._removerBordas();
                    this.Controls.Add(this._bordaCima);
                    this.Controls.Add(this._bordaBaixo);
                    this.Controls.Add(this._bordaDireita);
                    this.Controls.Add(this._bordaEsquerda);
                    
                    break;
            }

            //OBS.: Este método é chamado no evento Load do formulário para actualizar a borda depois de troca-la
        }
        #endregion

        #region Região principal, gera o designer e outras funções do formulário
        private void IniciarComponentes()
        {
            #region Instanciando os componentes do Formulário
            this._bordaCima = new System.Windows.Forms.Panel();
            this._txtHeader = new System.Windows.Forms.Label();
            this.btmin = new System.Windows.Forms.Button();
            this.btmax = new System.Windows.Forms.Button();
            this.btclose = new System.Windows.Forms.Button();
            this._bordaEsquerda = new System.Windows.Forms.Panel();
            this._bordaDireita = new System.Windows.Forms.Panel();
            this._bordaBaixo = new System.Windows.Forms.Panel();
            #endregion
            this._bordaCima.SuspendLayout();
            this.SuspendLayout();
            
            #region Borda de cima e os seus componentes
            // 
            // _bordaCima
            // 
            this._bordaCima.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._bordaCima.BackColor = System.Drawing.Color.DeepSkyBlue;
            this._bordaCima.Controls.Add(this._txtHeader);
            this._bordaCima.Controls.Add(this.btmin);
            this._bordaCima.Controls.Add(this.btmax);
            this._bordaCima.Controls.Add(this.btclose);
            this._bordaCima.ForeColor = System.Drawing.Color.White;
            this._bordaCima.Location = new System.Drawing.Point(1, 0);
            this._bordaCima.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this._bordaCima.Name = "_bordaCima";
            this._bordaCima.Size = new System.Drawing.Size(584, 35);
            this._bordaCima.TabIndex = 0;
            this._bordaCima.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Objecto_MouseDown);
            this._bordaCima.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Objecto_MouseMove);
            this._bordaCima.ResumeLayout(false);
            this._bordaCima.PerformLayout();
            // 
            // _txtHeader
            // 
            this._txtHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtHeader.AutoSize = true;
            this._txtHeader.BackColor = System.Drawing.Color.Transparent;
            this._txtHeader.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtHeader.Location = new System.Drawing.Point(2, 5);
            this._txtHeader.Name = "_txtHeader";
            this._txtHeader.Size = new System.Drawing.Size(219, 23);
            this._txtHeader.TabIndex = 7;
            this._txtHeader.Text = "EdvForm by Edivaldo Jorge";
            this._txtHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._txtHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Objecto_MouseDown);
            this._txtHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Objecto_MouseMove);
            // 
            // btmin
            // 
            this.btmin.BackColor = System.Drawing.Color.Transparent;
            this.btmin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btmin.FlatAppearance.BorderSize = 0;
            this.btmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmin.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btmin.ForeColor = System.Drawing.Color.White;
            this.btmin.Location = new System.Drawing.Point(500, 0);
            this.btmin.Name = "btmin";
            this.btmin.Size = new System.Drawing.Size(28, 35);
            this.btmin.TabIndex = 6;
            this.btmin.Text = "0";
            this.btmin.UseVisualStyleBackColor = false;
            this.btmin.Click += new System.EventHandler(this.minForm);
            // 
            // btmax
            // 
            this.btmax.BackColor = System.Drawing.Color.Transparent;
            this.btmax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btmax.FlatAppearance.BorderSize = 0;
            this.btmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmax.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btmax.ForeColor = System.Drawing.Color.White;
            this.btmax.Location = new System.Drawing.Point(528, 0);
            this.btmax.Name = "btmax";
            this.btmax.Size = new System.Drawing.Size(28, 35);
            this.btmax.TabIndex = 5;
            this.btmax.Text = "1";
            this.btmax.UseVisualStyleBackColor = false;
            this.btmax.Click += new System.EventHandler(this.maxForm);
            // 
            // btclose
            // 
            this.btclose.BackColor = System.Drawing.Color.Transparent;
            this.btclose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btclose.FlatAppearance.BorderSize = 0;
            this.btclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btclose.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btclose.ForeColor = System.Drawing.Color.White;
            this.btclose.Location = new System.Drawing.Point(556, 0);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(28, 35);
            this.btclose.TabIndex = 4;
            this.btclose.Text = "r";
            this.btclose.UseVisualStyleBackColor = false;
            this.btclose.Click += new System.EventHandler(this.closeForm);
            #endregion

            #region Borda Esquerda
            // 
            // _bordaEsquerda
            // 
            this._bordaEsquerda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this._bordaEsquerda.BackColor = System.Drawing.Color.DeepSkyBlue;
            this._bordaEsquerda.Location = new System.Drawing.Point(0, 0);
            this._bordaEsquerda.Name = "_bordaEsquerda";
            this._bordaEsquerda.Size = new System.Drawing.Size(1, 359);
            this._bordaEsquerda.TabIndex = 1;
            #endregion

            #region Borda Direita
            // 
            // _bordaDireita
            // 
            this._bordaDireita.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._bordaDireita.BackColor = System.Drawing.Color.DeepSkyBlue;
            this._bordaDireita.Location = new System.Drawing.Point(585, 0);
            this._bordaDireita.Name = "_bordaDireita";
            this._bordaDireita.Size = new System.Drawing.Size(1, 359);
            this._bordaDireita.TabIndex = 2;
            #endregion

            #region Borda de Baixo
            // 
            // _bordaBaixo
            // 
            this._bordaBaixo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._bordaBaixo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this._bordaBaixo.Location = new System.Drawing.Point(1, 358);
            this._bordaBaixo.Name = "_bordaBaixo";
            this._bordaBaixo.Size = new System.Drawing.Size(584, 1);
            this._bordaBaixo.TabIndex = 3;
            #endregion

            #region Mudando as propriedades do proprio formulário
            // 
            // EdvFormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(586, 359);
            this.Controls.Add(this._bordaCima);
            this.Controls.Add(this._bordaBaixo);
            this.Controls.Add(this._bordaDireita);
            this.Controls.Add(this._bordaEsquerda);
            this.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizedBounds = Screen.PrimaryScreen.WorkingArea;
            this.Name = "EdvFormTest";
            this.Padding = new System.Windows.Forms.Padding(1, 35, 1, 1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this._EdvForm_Load);
            this.SizeChanged += new System.EventHandler(this._EdvForm_SizeChanged);
            this.PaddingChanged += new System.EventHandler(this._EdvForm_PaddingChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Objecto_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Objecto_MouseMove);
            this.ResumeLayout(false);
            #endregion


        }
        #endregion

        #region Por favor não apague
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
        #endregion
    }
}
