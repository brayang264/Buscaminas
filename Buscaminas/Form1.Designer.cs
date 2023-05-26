namespace Buscaminas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTablero = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fotoModo = new System.Windows.Forms.PictureBox();
            this.botonProporcion = new Buscaminas.BSGButtons();
            this.boxProporcion = new Buscaminas.BSGTextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoModo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTablero
            // 
            this.panelTablero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.panelTablero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTablero.Location = new System.Drawing.Point(200, 0);
            this.panelTablero.Name = "panelTablero";
            this.panelTablero.Size = new System.Drawing.Size(726, 511);
            this.panelTablero.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(93)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.fotoModo);
            this.panel2.Controls.Add(this.botonProporcion);
            this.panel2.Controls.Add(this.boxProporcion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 511);
            this.panel2.TabIndex = 1;
            // 
            // fotoModo
            // 
            this.fotoModo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fotoModo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fotoModo.Image = global::Buscaminas.Properties.Resources.mina;
            this.fotoModo.Location = new System.Drawing.Point(0, 309);
            this.fotoModo.Name = "fotoModo";
            this.fotoModo.Size = new System.Drawing.Size(200, 202);
            this.fotoModo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoModo.TabIndex = 2;
            this.fotoModo.TabStop = false;
            this.fotoModo.Visible = false;
            this.fotoModo.Click += new System.EventHandler(this.clickFoto);
            // 
            // botonProporcion
            // 
            this.botonProporcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.botonProporcion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.botonProporcion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botonProporcion.BorderRadius = 40;
            this.botonProporcion.BorderSize = 0;
            this.botonProporcion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonProporcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonProporcion.FlatAppearance.BorderSize = 0;
            this.botonProporcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonProporcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonProporcion.ForeColor = System.Drawing.Color.White;
            this.botonProporcion.Location = new System.Drawing.Point(0, 31);
            this.botonProporcion.Name = "botonProporcion";
            this.botonProporcion.Size = new System.Drawing.Size(200, 40);
            this.botonProporcion.TabIndex = 1;
            this.botonProporcion.Text = "Iniciar";
            this.botonProporcion.TextColor = System.Drawing.Color.White;
            this.botonProporcion.UseVisualStyleBackColor = false;
            this.botonProporcion.Click += new System.EventHandler(this.botonProporcion_Click);
            // 
            // boxProporcion
            // 
            this.boxProporcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(93)))), ((int)(((byte)(70)))));
            this.boxProporcion.BorderColor = System.Drawing.Color.White;
            this.boxProporcion.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.boxProporcion.BorderSize = 2;
            this.boxProporcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.boxProporcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxProporcion.ForeColor = System.Drawing.Color.White;
            this.boxProporcion.Location = new System.Drawing.Point(0, 0);
            this.boxProporcion.Margin = new System.Windows.Forms.Padding(4);
            this.boxProporcion.Multiline = false;
            this.boxProporcion.Name = "boxProporcion";
            this.boxProporcion.Padding = new System.Windows.Forms.Padding(7);
            this.boxProporcion.PasswordChar = false;
            this.boxProporcion.Size = new System.Drawing.Size(200, 31);
            this.boxProporcion.TabIndex = 0;
            this.boxProporcion.Texts = "";
            this.boxProporcion.UnderlinedStyle = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(72)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(926, 511);
            this.Controls.Add(this.panelTablero);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fotoModo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTablero;
        private System.Windows.Forms.Panel panel2;
        private BSGTextBox boxProporcion;
        private BSGButtons botonProporcion;
        private System.Windows.Forms.PictureBox fotoModo;
    }
}

