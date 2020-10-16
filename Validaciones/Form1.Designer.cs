namespace Validaciones
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
            this.components = new System.ComponentModel.Container();
            this.btnValidar = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.Label();
            this.correo = new System.Windows.Forms.Label();
            this.NombreIn = new System.Windows.Forms.TextBox();
            this.CodigoIn = new System.Windows.Forms.TextBox();
            this.CorreoIn = new System.Windows.Forms.TextBox();
            this.errorM = new System.Windows.Forms.ErrorProvider(this.components);
            this.salida = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorM)).BeginInit();
            this.SuspendLayout();
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(151, 226);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 23);
            this.btnValidar.TabIndex = 0;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.button1_Click);
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(55, 49);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(44, 13);
            this.nombre.TabIndex = 1;
            this.nombre.Text = "Nombre";
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.Location = new System.Drawing.Point(55, 101);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(40, 13);
            this.codigo.TabIndex = 2;
            this.codigo.Text = "Codigo";
            // 
            // correo
            // 
            this.correo.AutoSize = true;
            this.correo.Location = new System.Drawing.Point(55, 154);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(38, 13);
            this.correo.TabIndex = 3;
            this.correo.Text = "Correo";
            // 
            // NombreIn
            // 
            this.NombreIn.Location = new System.Drawing.Point(110, 45);
            this.NombreIn.Name = "NombreIn";
            this.NombreIn.Size = new System.Drawing.Size(206, 20);
            this.NombreIn.TabIndex = 4;
            // 
            // CodigoIn
            // 
            this.CodigoIn.Location = new System.Drawing.Point(110, 98);
            this.CodigoIn.Name = "CodigoIn";
            this.CodigoIn.Size = new System.Drawing.Size(206, 20);
            this.CodigoIn.TabIndex = 5;
            // 
            // CorreoIn
            // 
            this.CorreoIn.Location = new System.Drawing.Point(110, 150);
            this.CorreoIn.Name = "CorreoIn";
            this.CorreoIn.Size = new System.Drawing.Size(206, 20);
            this.CorreoIn.TabIndex = 6;
            // 
            // errorM
            // 
            this.errorM.ContainerControl = this;
            // 
            // salida
            // 
            this.salida.AutoSize = true;
            this.salida.Location = new System.Drawing.Point(170, 281);
            this.salida.Name = "salida";
            this.salida.Size = new System.Drawing.Size(35, 13);
            this.salida.TabIndex = 7;
            this.salida.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 359);
            this.Controls.Add(this.salida);
            this.Controls.Add(this.CorreoIn);
            this.Controls.Add(this.CodigoIn);
            this.Controls.Add(this.NombreIn);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.btnValidar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label codigo;
        private System.Windows.Forms.Label correo;
        private System.Windows.Forms.TextBox NombreIn;
        private System.Windows.Forms.TextBox CodigoIn;
        private System.Windows.Forms.TextBox CorreoIn;
        private System.Windows.Forms.ErrorProvider errorM;
        private System.Windows.Forms.Label salida;
    }
}

