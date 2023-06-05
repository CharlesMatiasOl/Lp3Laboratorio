namespace pryMatiasAgricultura
{
    partial class Agricultura
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
            this.TCAgricultura = new System.Windows.Forms.TabControl();
            this.TPRegistro = new System.Windows.Forms.TabPage();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtToneladasA = new System.Windows.Forms.TextBox();
            this.CBCultivoA = new System.Windows.Forms.ComboBox();
            this.CBLocalidadA = new System.Windows.Forms.ComboBox();
            this.lblToneladasA = new System.Windows.Forms.Label();
            this.lblCultivoA = new System.Windows.Forms.Label();
            this.lblLocalidadA = new System.Windows.Forms.Label();
            this.TPConsultas = new System.Windows.Forms.TabPage();
            this.TCAgricultura.SuspendLayout();
            this.TPRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // TCAgricultura
            // 
            this.TCAgricultura.Controls.Add(this.TPRegistro);
            this.TCAgricultura.Controls.Add(this.TPConsultas);
            this.TCAgricultura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCAgricultura.ItemSize = new System.Drawing.Size(200, 25);
            this.TCAgricultura.Location = new System.Drawing.Point(0, 0);
            this.TCAgricultura.Name = "TCAgricultura";
            this.TCAgricultura.SelectedIndex = 0;
            this.TCAgricultura.Size = new System.Drawing.Size(667, 410);
            this.TCAgricultura.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TCAgricultura.TabIndex = 1;
            // 
            // TPRegistro
            // 
            this.TPRegistro.Controls.Add(this.btnAgregar);
            this.TPRegistro.Controls.Add(this.txtToneladasA);
            this.TPRegistro.Controls.Add(this.CBCultivoA);
            this.TPRegistro.Controls.Add(this.CBLocalidadA);
            this.TPRegistro.Controls.Add(this.lblToneladasA);
            this.TPRegistro.Controls.Add(this.lblCultivoA);
            this.TPRegistro.Controls.Add(this.lblLocalidadA);
            this.TPRegistro.Location = new System.Drawing.Point(4, 29);
            this.TPRegistro.Name = "TPRegistro";
            this.TPRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.TPRegistro.Size = new System.Drawing.Size(659, 377);
            this.TPRegistro.TabIndex = 0;
            this.TPRegistro.Text = "Registro";
            this.TPRegistro.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(492, 50);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtToneladasA
            // 
            this.txtToneladasA.Location = new System.Drawing.Point(343, 52);
            this.txtToneladasA.Name = "txtToneladasA";
            this.txtToneladasA.Size = new System.Drawing.Size(121, 20);
            this.txtToneladasA.TabIndex = 6;
            // 
            // CBCultivoA
            // 
            this.CBCultivoA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCultivoA.FormattingEnabled = true;
            this.CBCultivoA.Location = new System.Drawing.Point(192, 52);
            this.CBCultivoA.Name = "CBCultivoA";
            this.CBCultivoA.Size = new System.Drawing.Size(121, 21);
            this.CBCultivoA.TabIndex = 5;
            // 
            // CBLocalidadA
            // 
            this.CBLocalidadA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBLocalidadA.FormattingEnabled = true;
            this.CBLocalidadA.Location = new System.Drawing.Point(40, 52);
            this.CBLocalidadA.Name = "CBLocalidadA";
            this.CBLocalidadA.Size = new System.Drawing.Size(121, 21);
            this.CBLocalidadA.TabIndex = 4;
            // 
            // lblToneladasA
            // 
            this.lblToneladasA.AutoSize = true;
            this.lblToneladasA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToneladasA.Location = new System.Drawing.Point(338, 33);
            this.lblToneladasA.Name = "lblToneladasA";
            this.lblToneladasA.Size = new System.Drawing.Size(76, 16);
            this.lblToneladasA.TabIndex = 2;
            this.lblToneladasA.Text = "Toneladas:";
            // 
            // lblCultivoA
            // 
            this.lblCultivoA.AutoSize = true;
            this.lblCultivoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCultivoA.Location = new System.Drawing.Point(189, 36);
            this.lblCultivoA.Name = "lblCultivoA";
            this.lblCultivoA.Size = new System.Drawing.Size(50, 16);
            this.lblCultivoA.TabIndex = 1;
            this.lblCultivoA.Text = "Cultivo:";
            // 
            // lblLocalidadA
            // 
            this.lblLocalidadA.AutoSize = true;
            this.lblLocalidadA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidadA.Location = new System.Drawing.Point(37, 36);
            this.lblLocalidadA.Name = "lblLocalidadA";
            this.lblLocalidadA.Size = new System.Drawing.Size(70, 16);
            this.lblLocalidadA.TabIndex = 0;
            this.lblLocalidadA.Text = "Localidad:";
            // 
            // TPConsultas
            // 
            this.TPConsultas.Location = new System.Drawing.Point(4, 29);
            this.TPConsultas.Name = "TPConsultas";
            this.TPConsultas.Padding = new System.Windows.Forms.Padding(3);
            this.TPConsultas.Size = new System.Drawing.Size(659, 377);
            this.TPConsultas.TabIndex = 1;
            this.TPConsultas.Text = "Consultas";
            this.TPConsultas.UseVisualStyleBackColor = true;
            // 
            // Agricultura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 410);
            this.Controls.Add(this.TCAgricultura);
            this.Name = "Agricultura";
            this.Text = "Agricultura";
            this.TCAgricultura.ResumeLayout(false);
            this.TPRegistro.ResumeLayout(false);
            this.TPRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TCAgricultura;
        private System.Windows.Forms.TabPage TPRegistro;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtToneladasA;
        private System.Windows.Forms.ComboBox CBCultivoA;
        private System.Windows.Forms.ComboBox CBLocalidadA;
        private System.Windows.Forms.Label lblToneladasA;
        private System.Windows.Forms.Label lblCultivoA;
        private System.Windows.Forms.Label lblLocalidadA;
        private System.Windows.Forms.TabPage TPConsultas;
    }
}

