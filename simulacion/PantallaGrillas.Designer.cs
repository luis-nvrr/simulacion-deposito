
namespace simulacion_mecanicos.simulacion
{
    partial class PantallaGrillas
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
            this.grdSinAyudante = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCostoSinAyudante = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCostoConAyudante = new System.Windows.Forms.TextBox();
            this.grdConAyudante = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdSinAyudante)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConAyudante)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSinAyudante
            // 
            this.grdSinAyudante.AllowUserToAddRows = false;
            this.grdSinAyudante.AllowUserToDeleteRows = false;
            this.grdSinAyudante.AllowUserToResizeColumns = false;
            this.grdSinAyudante.AllowUserToResizeRows = false;
            this.grdSinAyudante.BackgroundColor = System.Drawing.Color.White;
            this.grdSinAyudante.ColumnHeadersHeight = 50;
            this.grdSinAyudante.Location = new System.Drawing.Point(30, 90);
            this.grdSinAyudante.Name = "grdSinAyudante";
            this.grdSinAyudante.ReadOnly = true;
            this.grdSinAyudante.RowHeadersVisible = false;
            this.grdSinAyudante.RowTemplate.Height = 25;
            this.grdSinAyudante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSinAyudante.Size = new System.Drawing.Size(1304, 305);
            this.grdSinAyudante.TabIndex = 7;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.txtCostoSinAyudante);
            this.groupBox5.Controls.Add(this.grdSinAyudante);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1340, 420);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Simulacion SIN ayudante";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 21);
            this.label10.TabIndex = 39;
            this.label10.Text = "Costo Acumulado";
            // 
            // txtCostoSinAyudante
            // 
            this.txtCostoSinAyudante.Location = new System.Drawing.Point(169, 37);
            this.txtCostoSinAyudante.Name = "txtCostoSinAyudante";
            this.txtCostoSinAyudante.Size = new System.Drawing.Size(116, 29);
            this.txtCostoSinAyudante.TabIndex = 38;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCostoConAyudante);
            this.groupBox1.Controls.Add(this.grdConAyudante);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 438);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1340, 420);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simulacion CON ayudante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 21);
            this.label1.TabIndex = 39;
            this.label1.Text = "Costo Acumulado";
            // 
            // txtCostoConAyudante
            // 
            this.txtCostoConAyudante.Location = new System.Drawing.Point(169, 37);
            this.txtCostoConAyudante.Name = "txtCostoConAyudante";
            this.txtCostoConAyudante.Size = new System.Drawing.Size(116, 29);
            this.txtCostoConAyudante.TabIndex = 38;
            // 
            // grdConAyudante
            // 
            this.grdConAyudante.AllowUserToAddRows = false;
            this.grdConAyudante.AllowUserToDeleteRows = false;
            this.grdConAyudante.AllowUserToResizeColumns = false;
            this.grdConAyudante.AllowUserToResizeRows = false;
            this.grdConAyudante.BackgroundColor = System.Drawing.Color.White;
            this.grdConAyudante.ColumnHeadersHeight = 50;
            this.grdConAyudante.Location = new System.Drawing.Point(30, 90);
            this.grdConAyudante.Name = "grdConAyudante";
            this.grdConAyudante.ReadOnly = true;
            this.grdConAyudante.RowHeadersVisible = false;
            this.grdConAyudante.RowTemplate.Height = 25;
            this.grdConAyudante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdConAyudante.Size = new System.Drawing.Size(1304, 305);
            this.grdConAyudante.TabIndex = 7;
            // 
            // PantallaGrillas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1364, 749);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Name = "PantallaGrillas";
            this.Text = "PantallaGrillas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grdSinAyudante)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConAyudante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdSinAyudante;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCostoSinAyudante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCostoConAyudante;
        private System.Windows.Forms.DataGridView grdConAyudante;
    }
}