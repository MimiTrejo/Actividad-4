namespace Actividad_4
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEstatura = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtB_Nombre = new System.Windows.Forms.TextBox();
            this.txtB_Apellido = new System.Windows.Forms.TextBox();
            this.txtB_Telefono = new System.Windows.Forms.TextBox();
            this.txtB_Estatura = new System.Windows.Forms.TextBox();
            this.txtB_Edad = new System.Windows.Forms.TextBox();
            this.gBGenero = new System.Windows.Forms.GroupBox();
            this.rBFemenino = new System.Windows.Forms.RadioButton();
            this.rBMasculino = new System.Windows.Forms.RadioButton();
            this.gBGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(64, 57);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(64, 101);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(60, 16);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(64, 141);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 16);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblEstatura
            // 
            this.lblEstatura.AutoSize = true;
            this.lblEstatura.Location = new System.Drawing.Point(64, 183);
            this.lblEstatura.Name = "lblEstatura";
            this.lblEstatura.Size = new System.Drawing.Size(59, 16);
            this.lblEstatura.TabIndex = 3;
            this.lblEstatura.Text = "Estatura:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(64, 223);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(43, 16);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "Edad:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(67, 393);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(193, 393);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtB_Nombre
            // 
            this.txtB_Nombre.Location = new System.Drawing.Point(129, 54);
            this.txtB_Nombre.Name = "txtB_Nombre";
            this.txtB_Nombre.Size = new System.Drawing.Size(100, 22);
            this.txtB_Nombre.TabIndex = 7;
            // 
            // txtB_Apellido
            // 
            this.txtB_Apellido.Location = new System.Drawing.Point(129, 98);
            this.txtB_Apellido.Name = "txtB_Apellido";
            this.txtB_Apellido.Size = new System.Drawing.Size(100, 22);
            this.txtB_Apellido.TabIndex = 8;
            // 
            // txtB_Telefono
            // 
            this.txtB_Telefono.Location = new System.Drawing.Point(129, 138);
            this.txtB_Telefono.Name = "txtB_Telefono";
            this.txtB_Telefono.Size = new System.Drawing.Size(100, 22);
            this.txtB_Telefono.TabIndex = 9;
            // 
            // txtB_Estatura
            // 
            this.txtB_Estatura.Location = new System.Drawing.Point(129, 183);
            this.txtB_Estatura.Name = "txtB_Estatura";
            this.txtB_Estatura.Size = new System.Drawing.Size(100, 22);
            this.txtB_Estatura.TabIndex = 10;
            // 
            // txtB_Edad
            // 
            this.txtB_Edad.Location = new System.Drawing.Point(129, 223);
            this.txtB_Edad.Name = "txtB_Edad";
            this.txtB_Edad.Size = new System.Drawing.Size(100, 22);
            this.txtB_Edad.TabIndex = 11;
            // 
            // gBGenero
            // 
            this.gBGenero.Controls.Add(this.rBFemenino);
            this.gBGenero.Controls.Add(this.rBMasculino);
            this.gBGenero.Location = new System.Drawing.Point(33, 265);
            this.gBGenero.Name = "gBGenero";
            this.gBGenero.Size = new System.Drawing.Size(283, 108);
            this.gBGenero.TabIndex = 12;
            this.gBGenero.TabStop = false;
            this.gBGenero.Text = "Genero";
            // 
            // rBFemenino
            // 
            this.rBFemenino.AutoSize = true;
            this.rBFemenino.Location = new System.Drawing.Point(160, 52);
            this.rBFemenino.Name = "rBFemenino";
            this.rBFemenino.Size = new System.Drawing.Size(88, 20);
            this.rBFemenino.TabIndex = 1;
            this.rBFemenino.TabStop = true;
            this.rBFemenino.Text = "Femenino";
            this.rBFemenino.UseVisualStyleBackColor = true;
            // 
            // rBMasculino
            // 
            this.rBMasculino.AutoSize = true;
            this.rBMasculino.Location = new System.Drawing.Point(17, 52);
            this.rBMasculino.Name = "rBMasculino";
            this.rBMasculino.Size = new System.Drawing.Size(89, 20);
            this.rBMasculino.TabIndex = 0;
            this.rBMasculino.TabStop = true;
            this.rBMasculino.Text = "Masculino";
            this.rBMasculino.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 450);
            this.Controls.Add(this.gBGenero);
            this.Controls.Add(this.txtB_Edad);
            this.Controls.Add(this.txtB_Estatura);
            this.Controls.Add(this.txtB_Telefono);
            this.Controls.Add(this.txtB_Apellido);
            this.Controls.Add(this.txtB_Nombre);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblEstatura);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gBGenero.ResumeLayout(false);
            this.gBGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEstatura;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtB_Nombre;
        private System.Windows.Forms.TextBox txtB_Apellido;
        private System.Windows.Forms.TextBox txtB_Telefono;
        private System.Windows.Forms.TextBox txtB_Estatura;
        private System.Windows.Forms.TextBox txtB_Edad;
        private System.Windows.Forms.GroupBox gBGenero;
        private System.Windows.Forms.RadioButton rBFemenino;
        private System.Windows.Forms.RadioButton rBMasculino;
    }
}

