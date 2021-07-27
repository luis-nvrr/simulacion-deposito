
namespace Numeros_aleatorios.Colas
{
    partial class PantallaPrincipal
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grdResultados = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTiempoPromedioFinInforme = new System.Windows.Forms.Label();
            this.txtMediaAtencion1 = new System.Windows.Forms.TextBox();
            this.txtMediaLlegadas1 = new System.Windows.Forms.TextBox();
            this.lblTiempoPromedioLlegadas = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMediaAtencion2 = new System.Windows.Forms.TextBox();
            this.txtMediaLlegadas2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.txtCantidadSimulaciones = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCantidadLineas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdResultados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 71);
            this.panel1.TabIndex = 16;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(12, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(470, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Ejercicio 213: Mecánicos y Depósito";
            // 
            // grdResultados
            // 
            this.grdResultados.AllowUserToAddRows = false;
            this.grdResultados.AllowUserToDeleteRows = false;
            this.grdResultados.AllowUserToResizeColumns = false;
            this.grdResultados.AllowUserToResizeRows = false;
            this.grdResultados.BackgroundColor = System.Drawing.Color.White;
            this.grdResultados.ColumnHeadersHeight = 50;
            this.grdResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdResultados.Location = new System.Drawing.Point(133, 156);
            this.grdResultados.Name = "grdResultados";
            this.grdResultados.ReadOnly = true;
            this.grdResultados.RowHeadersVisible = false;
            this.grdResultados.RowTemplate.Height = 25;
            this.grdResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdResultados.Size = new System.Drawing.Size(602, 296);
            this.grdResultados.TabIndex = 7;
            this.grdResultados.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.grdRangoResultados_ColumnAdded);
            this.grdResultados.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grdRangoResultados_DataBindingComplete);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTiempoPromedioFinInforme);
            this.groupBox1.Controls.Add(this.txtMediaAtencion1);
            this.groupBox1.Controls.Add(this.txtMediaLlegadas1);
            this.groupBox1.Controls.Add(this.lblTiempoPromedioLlegadas);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 119);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simulacion SIN ayudante";
            // 
            // lblTiempoPromedioFinInforme
            // 
            this.lblTiempoPromedioFinInforme.AutoSize = true;
            this.lblTiempoPromedioFinInforme.Location = new System.Drawing.Point(67, 73);
            this.lblTiempoPromedioFinInforme.Name = "lblTiempoPromedioFinInforme";
            this.lblTiempoPromedioFinInforme.Size = new System.Drawing.Size(230, 21);
            this.lblTiempoPromedioFinInforme.TabIndex = 28;
            this.lblTiempoPromedioFinInforme.Text = "Media fin de atención (exp neg):";
            // 
            // txtMediaAtencion1
            // 
            this.txtMediaAtencion1.Location = new System.Drawing.Point(319, 65);
            this.txtMediaAtencion1.Name = "txtMediaAtencion1";
            this.txtMediaAtencion1.Size = new System.Drawing.Size(110, 29);
            this.txtMediaAtencion1.TabIndex = 26;
            // 
            // txtMediaLlegadas1
            // 
            this.txtMediaLlegadas1.Location = new System.Drawing.Point(319, 30);
            this.txtMediaLlegadas1.Name = "txtMediaLlegadas1";
            this.txtMediaLlegadas1.Size = new System.Drawing.Size(110, 29);
            this.txtMediaLlegadas1.TabIndex = 25;
            // 
            // lblTiempoPromedioLlegadas
            // 
            this.lblTiempoPromedioLlegadas.AutoSize = true;
            this.lblTiempoPromedioLlegadas.Location = new System.Drawing.Point(72, 38);
            this.lblTiempoPromedioLlegadas.Name = "lblTiempoPromedioLlegadas";
            this.lblTiempoPromedioLlegadas.Size = new System.Drawing.Size(225, 21);
            this.lblTiempoPromedioLlegadas.TabIndex = 24;
            this.lblTiempoPromedioLlegadas.Text = "Media entre llegadas (exp neg):";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtMediaAtencion2);
            this.groupBox4.Controls.Add(this.txtMediaLlegadas2);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(556, 87);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(552, 119);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Simulación CON ayudante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "Media fin de atención (exp neg):";
            // 
            // txtMediaAtencion2
            // 
            this.txtMediaAtencion2.Location = new System.Drawing.Point(319, 65);
            this.txtMediaAtencion2.Name = "txtMediaAtencion2";
            this.txtMediaAtencion2.Size = new System.Drawing.Size(110, 29);
            this.txtMediaAtencion2.TabIndex = 26;
            // 
            // txtMediaLlegadas2
            // 
            this.txtMediaLlegadas2.Location = new System.Drawing.Point(319, 30);
            this.txtMediaLlegadas2.Name = "txtMediaLlegadas2";
            this.txtMediaLlegadas2.Size = new System.Drawing.Size(110, 29);
            this.txtMediaLlegadas2.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "Media entre llegadas (exp neg):";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblTexto);
            this.groupBox5.Controls.Add(this.txtCantidadSimulaciones);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtCantidadLineas);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.txtHasta);
            this.groupBox5.Controls.Add(this.txtDesde);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.grdResultados);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.Location = new System.Drawing.Point(12, 212);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1096, 495);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Resultados";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(756, 156);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(0, 21);
            this.lblTexto.TabIndex = 47;
            // 
            // txtCantidadSimulaciones
            // 
            this.txtCantidadSimulaciones.Location = new System.Drawing.Point(314, 27);
            this.txtCantidadSimulaciones.Name = "txtCantidadSimulaciones";
            this.txtCantidadSimulaciones.Size = new System.Drawing.Size(110, 29);
            this.txtCantidadSimulaciones.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 21);
            this.label7.TabIndex = 46;
            this.label7.Text = "Cantidad de Simulaciones: ";
            // 
            // txtCantidadLineas
            // 
            this.txtCantidadLineas.Location = new System.Drawing.Point(314, 65);
            this.txtCantidadLineas.Name = "txtCantidadLineas";
            this.txtCantidadLineas.Size = new System.Drawing.Size(110, 29);
            this.txtCantidadLineas.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(148, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 21);
            this.label8.TabIndex = 44;
            this.label8.Text = "Cantidad de Lineas:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(441, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 21);
            this.label9.TabIndex = 42;
            this.label9.Text = "Hasta: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(238, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 21);
            this.label10.TabIndex = 39;
            this.label10.Text = "Desde: ";
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(503, 101);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(116, 29);
            this.txtHasta.TabIndex = 38;
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(314, 101);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(110, 29);
            this.txtDesde.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(120)))), ((int)(((byte)(44)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(640, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 38);
            this.button1.TabIndex = 24;
            this.button1.Text = "Simular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1144, 749);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.panel1);
            this.Name = "PantallaPrincipal";
            this.Text = "Pantalla Principal - Simulacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PantallaResultados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdResultados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView grdResultados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTiempoPromedioFinInforme;
        private System.Windows.Forms.TextBox txtMediaAtencion1;
        private System.Windows.Forms.TextBox txtMediaLlegadas1;
        private System.Windows.Forms.Label lblTiempoPromedioLlegadas;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMediaAtencion2;
        private System.Windows.Forms.TextBox txtMediaLlegadas2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtCantidadSimulaciones;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCantidadLineas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTexto;
    }
}