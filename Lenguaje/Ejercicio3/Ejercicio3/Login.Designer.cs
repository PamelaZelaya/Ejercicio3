namespace Ejercicio3
{
    partial class Login
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
            this.Entrar_Button = new System.Windows.Forms.Button();
            this.Cancelar_button = new System.Windows.Forms.Button();
            this.Usuario_textBox = new System.Windows.Forms.TextBox();
            this.Clave_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Entrar_Button
            // 
            this.Entrar_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entrar_Button.Location = new System.Drawing.Point(29, 161);
            this.Entrar_Button.Name = "Entrar_Button";
            this.Entrar_Button.Size = new System.Drawing.Size(108, 36);
            this.Entrar_Button.TabIndex = 0;
            this.Entrar_Button.Text = "Entrar";
            this.Entrar_Button.UseVisualStyleBackColor = true;
            this.Entrar_Button.Click += new System.EventHandler(this.Entrar_Button_Click);
            // 
            // Cancelar_button
            // 
            this.Cancelar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar_button.Location = new System.Drawing.Point(163, 161);
            this.Cancelar_button.Name = "Cancelar_button";
            this.Cancelar_button.Size = new System.Drawing.Size(108, 36);
            this.Cancelar_button.TabIndex = 1;
            this.Cancelar_button.Text = "Cancelar";
            this.Cancelar_button.UseVisualStyleBackColor = true;
            this.Cancelar_button.Click += new System.EventHandler(this.Cancelar_button_Click);
            // 
            // Usuario_textBox
            // 
            this.Usuario_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario_textBox.Location = new System.Drawing.Point(87, 26);
            this.Usuario_textBox.Name = "Usuario_textBox";
            this.Usuario_textBox.Size = new System.Drawing.Size(141, 21);
            this.Usuario_textBox.TabIndex = 2;
            // 
            // Clave_textBox
            // 
            this.Clave_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clave_textBox.Location = new System.Drawing.Point(87, 69);
            this.Clave_textBox.Name = "Clave_textBox";
            this.Clave_textBox.Size = new System.Drawing.Size(140, 21);
            this.Clave_textBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Clave";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 244);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Clave_textBox);
            this.Controls.Add(this.Usuario_textBox);
            this.Controls.Add(this.Cancelar_button);
            this.Controls.Add(this.Entrar_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Entrar_Button;
        private System.Windows.Forms.Button Cancelar_button;
        private System.Windows.Forms.TextBox Usuario_textBox;
        private System.Windows.Forms.TextBox Clave_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

