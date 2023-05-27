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
            this.labelMinas = new System.Windows.Forms.Label();
            this.modo = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fotoModo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cantMinas = new Buscaminas.ButtonSwitch();
            this.botonReiniciar = new Buscaminas.BSGButtons();
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
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cantMinas);
            this.panel2.Controls.Add(this.labelMinas);
            this.panel2.Controls.Add(this.botonReiniciar);
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
            // labelMinas
            // 
            this.labelMinas.AutoSize = true;
            this.labelMinas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelMinas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinas.ForeColor = System.Drawing.Color.White;
            this.labelMinas.Location = new System.Drawing.Point(0, 267);
            this.labelMinas.Name = "labelMinas";
            this.labelMinas.Size = new System.Drawing.Size(140, 21);
            this.labelMinas.TabIndex = 7;
            this.labelMinas.Text = "Minas restrantes:";
            this.labelMinas.Visible = false;
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
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(66, 179);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(74, 24);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "label2";
            this.timeLabel.Visible = false;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 42);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mostrar Minas\r\nRestantes";
            this.label2.Visible = false;
            // 
            // cantMinas
            // 
            this.cantMinas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cantMinas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cantMinas.Location = new System.Drawing.Point(0, 230);
            this.cantMinas.MinimumSize = new System.Drawing.Size(42, 22);
            this.cantMinas.Name = "cantMinas";
            this.cantMinas.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cantMinas.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cantMinas.OnBackColor = System.Drawing.Color.Lime;
            this.cantMinas.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cantMinas.Size = new System.Drawing.Size(200, 37);
            this.cantMinas.TabIndex = 8;
            this.cantMinas.Text = "buttonSwitch1";
            this.cantMinas.UseVisualStyleBackColor = true;
            this.cantMinas.Visible = false;
            this.cantMinas.CheckedChanged += new System.EventHandler(this.MostrarMinas);
            // 
            // botonReiniciar
            // 
            this.botonReiniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.botonReiniciar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.botonReiniciar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botonReiniciar.BorderRadius = 40;
            this.botonReiniciar.BorderSize = 0;
            this.botonReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonReiniciar.FlatAppearance.BorderSize = 0;
            this.botonReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonReiniciar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonReiniciar.ForeColor = System.Drawing.Color.White;
            this.botonReiniciar.Location = new System.Drawing.Point(0, 136);
            this.botonReiniciar.Name = "botonReiniciar";
            this.botonReiniciar.Size = new System.Drawing.Size(200, 40);
            this.botonReiniciar.TabIndex = 6;
            this.botonReiniciar.Text = "Reiniciar Juego!";
            this.botonReiniciar.TextColor = System.Drawing.Color.White;
            this.botonReiniciar.UseVisualStyleBackColor = false;
            this.botonReiniciar.Visible = false;
            this.botonReiniciar.Click += new System.EventHandler(this.botonReiniciar_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
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
        private BSGButtons botonReiniciar;
        private System.Windows.Forms.Label labelMinas;
        private System.Windows.Forms.Label label2;
        private ButtonSwitch cantMinas;
    }
}

