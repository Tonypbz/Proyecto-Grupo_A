
namespace Proyecto_Programa_Grupo_A
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
            this.btnmostrar = new System.Windows.Forms.Button();
            this.btnenviar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvlista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlista)).BeginInit();
            this.SuspendLayout();
            // 
            // btnmostrar
            // 
            this.btnmostrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnmostrar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnmostrar.Location = new System.Drawing.Point(463, 43);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(173, 38);
            this.btnmostrar.TabIndex = 22;
            this.btnmostrar.Text = "MOSTRAR";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // btnenviar
            // 
            this.btnenviar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnenviar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenviar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnenviar.Location = new System.Drawing.Point(415, 370);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(173, 38);
            this.btnenviar.TabIndex = 21;
            this.btnenviar.Text = "ENVIAR";
            this.btnenviar.UseVisualStyleBackColor = true;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btncancelar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btncancelar.Location = new System.Drawing.Point(180, 370);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(173, 38);
            this.btncancelar.TabIndex = 20;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 34);
            this.label1.TabIndex = 19;
            this.label1.Text = "DATOS DEL PEDIDO: ";
            // 
            // dgvlista
            // 
            this.dgvlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlista.Location = new System.Drawing.Point(12, 92);
            this.dgvlista.Name = "dgvlista";
            this.dgvlista.RowHeadersWidth = 62;
            this.dgvlista.RowTemplate.Height = 28;
            this.dgvlista.Size = new System.Drawing.Size(776, 225);
            this.dgvlista.TabIndex = 18;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvlista);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvlista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvlista;
    }
}