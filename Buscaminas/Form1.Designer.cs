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
            this.label1 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.modo = new System.Windows.Forms.Label();
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
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel2.Controls.Add(this.modo);
            this.panel2.Controls.Add(this.timeLabel);
            this.panel2.Controls.Add(this.label1);
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
            this.botonProporcion.FlatAppearance.BorderSize = 0;
            this.botonProporcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonProporcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonProporcion.ForeColor = System.Drawing.Color.White;
            this.botonProporcion.Location = new System.Drawing.Point(0, 88);
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
            this.boxProporcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.boxProporcion.BorderColor = System.Drawing.Color.White;
            this.boxProporcion.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.boxProporcion.BorderSize = 2;
            this.boxProporcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxProporcion.ForeColor = System.Drawing.Color.White;
            this.boxProporcion.Location = new System.Drawing.Point(0, 50);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese el número\r\nde filas:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(48, 244);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(74, 24);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "label2";
            this.timeLabel.Visible = false;
            // 
            // modo
            // 
            this.modo.AutoSize = true;
            this.modo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.modo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modo.ForeColor = System.Drawing.Color.White;
            this.modo.Location = new System.Drawing.Point(0, 288);
            this.modo.Name = "modo";
            this.modo.Size = new System.Drawing.Size(175, 21);
            this.modo.TabIndex = 5;
            this.modo.Text = "buscar casillas vácias";
            this.modo.Visible = false;
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
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoModo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTablero;
        private System.Windows.Forms.Panel panel2;
        private BSGTextBox boxProporcion;
        private BSGButtons botonProporcion;
        private System.Windows.Forms.PictureBox fotoModo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label modo;
    }
}

