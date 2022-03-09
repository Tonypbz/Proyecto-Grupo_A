
namespace Proyecto_Programa_Grupo_A
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
            this.btnpedido = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.rdbmismodia = new System.Windows.Forms.RadioButton();
            this.rdbagencia = new System.Windows.Forms.RadioButton();
            this.rdbdomicilio = new System.Windows.Forms.RadioButton();
            this.chbusado = new System.Windows.Forms.CheckBox();
            this.chbnuevo = new System.Windows.Forms.CheckBox();
            this.cmbubicacion = new System.Windows.Forms.ComboBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnpedido
            // 
            this.btnpedido.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnpedido.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpedido.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnpedido.Location = new System.Drawing.Point(435, 366);
            this.btnpedido.Name = "btnpedido";
            this.btnpedido.Size = new System.Drawing.Size(251, 38);
            this.btnpedido.TabIndex = 31;
            this.btnpedido.Text = "REALIZAR PEDIDO";
            this.btnpedido.UseVisualStyleBackColor = true;
            this.btnpedido.Click += new System.EventHandler(this.btnpedido_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnborrar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnborrar.Location = new System.Drawing.Point(149, 366);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(251, 38);
            this.btnborrar.TabIndex = 30;
            this.btnborrar.Text = "BORRAR FORMULARIO";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // rdbmismodia
            // 
            this.rdbmismodia.AutoSize = true;
            this.rdbmismodia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdbmismodia.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rdbmismodia.Location = new System.Drawing.Point(435, 265);
            this.rdbmismodia.Name = "rdbmismodia";
            this.rdbmismodia.Size = new System.Drawing.Size(216, 25);
            this.rdbmismodia.TabIndex = 29;
            this.rdbmismodia.TabStop = true;
            this.rdbmismodia.Text = "Envio el mismo dia (15$)";
            this.rdbmismodia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbmismodia.UseVisualStyleBackColor = true;
            // 
            // rdbagencia
            // 
            this.rdbagencia.AutoSize = true;
            this.rdbagencia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdbagencia.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rdbagencia.Location = new System.Drawing.Point(554, 233);
            this.rdbagencia.Name = "rdbagencia";
            this.rdbagencia.Size = new System.Drawing.Size(175, 25);
            this.rdbagencia.TabIndex = 28;
            this.rdbagencia.TabStop = true;
            this.rdbagencia.Text = "Retirar en agencia";
            this.rdbagencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbagencia.UseVisualStyleBackColor = true;
            // 
            // rdbdomicilio
            // 
            this.rdbdomicilio.AutoSize = true;
            this.rdbdomicilio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdbdomicilio.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rdbdomicilio.Location = new System.Drawing.Point(355, 234);
            this.rdbdomicilio.Name = "rdbdomicilio";
            this.rdbdomicilio.Size = new System.Drawing.Size(193, 25);
            this.rdbdomicilio.TabIndex = 27;
            this.rdbdomicilio.TabStop = true;
            this.rdbdomicilio.Text = "Envio a domicilio (5$)";
            this.rdbdomicilio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbdomicilio.UseVisualStyleBackColor = true;
            // 
            // chbusado
            // 
            this.chbusado.AutoSize = true;
            this.chbusado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chbusado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbusado.ForeColor = System.Drawing.SystemColors.Desktop;
            this.chbusado.Location = new System.Drawing.Point(554, 308);
            this.chbusado.Name = "chbusado";
            this.chbusado.Size = new System.Drawing.Size(94, 25);
            this.chbusado.TabIndex = 26;
            this.chbusado.Text = "Usado";
            this.chbusado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbusado.UseVisualStyleBackColor = true;
            // 
            // chbnuevo
            // 
            this.chbnuevo.AutoSize = true;
            this.chbnuevo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chbnuevo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.chbnuevo.Location = new System.Drawing.Point(355, 308);
            this.chbnuevo.Name = "chbnuevo";
            this.chbnuevo.Size = new System.Drawing.Size(92, 25);
            this.chbnuevo.TabIndex = 25;
            this.chbnuevo.Text = "Nuevo";
            this.chbnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbnuevo.UseVisualStyleBackColor = true;
            // 
            // cmbubicacion
            // 
            this.cmbubicacion.FormattingEnabled = true;
            this.cmbubicacion.Items.AddRange(new object[] {
            "Riobamba",
            "Quito",
            "Cuenca",
            "Guayaquil",
            "Latacunga",
            "Puyo",
            "Tena",
            "Loja",
            "Esmeraldas",
            "Manabi"});
            this.cmbubicacion.Location = new System.Drawing.Point(355, 154);
            this.cmbubicacion.Name = "cmbubicacion";
            this.cmbubicacion.Size = new System.Drawing.Size(246, 28);
            this.cmbubicacion.TabIndex = 24;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(355, 195);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(246, 26);
            this.txtcantidad.TabIndex = 23;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(355, 107);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(246, 26);
            this.txtnombre.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 22);
            this.label6.TabIndex = 21;
            this.label6.Text = "ESTADO DEL PRODUCTO: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "TIPO DE ENVIO: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "CANTIDAD DE UNIDADES: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "UBICACION DE COMPRA: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "NOMBRE DEL PRODUCTO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 34);
            this.label1.TabIndex = 16;
            this.label1.Text = "PEDIDO DE AMAZON";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnpedido);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.rdbmismodia);
            this.Controls.Add(this.rdbagencia);
            this.Controls.Add(this.rdbdomicilio);
            this.Controls.Add(this.chbusado);
            this.Controls.Add(this.chbnuevo);
            this.Controls.Add(this.cmbubicacion);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnpedido;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.RadioButton rdbmismodia;
        private System.Windows.Forms.RadioButton rdbagencia;
        private System.Windows.Forms.RadioButton rdbdomicilio;
        private System.Windows.Forms.CheckBox chbusado;
        private System.Windows.Forms.CheckBox chbnuevo;
        private System.Windows.Forms.ComboBox cmbubicacion;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

