using URProject.Forms;

namespace URProject {
    partial class FormMain {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.button1 = new System.Windows.Forms.Button();
            this.panelManualMove = new System.Windows.Forms.Panel();
            this.buttonMarcos = new System.Windows.Forms.Button();
            this.boton_dioni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(599, 318);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 18);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelManualMove
            // 
            this.panelManualMove.Location = new System.Drawing.Point(11, 10);
            this.panelManualMove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelManualMove.Name = "panelManualMove";
            this.panelManualMove.Size = new System.Drawing.Size(259, 168);
            this.panelManualMove.TabIndex = 1;
            // 
            // buttonMarcos
            // 
            this.buttonMarcos.Location = new System.Drawing.Point(561, 22);
            this.buttonMarcos.Name = "buttonMarcos";
            this.buttonMarcos.Size = new System.Drawing.Size(113, 51);
            this.buttonMarcos.TabIndex = 2;
            this.buttonMarcos.Text = "Botón debug Marcos";
            this.buttonMarcos.UseVisualStyleBackColor = true;
            this.buttonMarcos.Click += new System.EventHandler(this.buttonDebugMarcos);
            // 
            // boton_dioni
            // 
            this.boton_dioni.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_dioni.Location = new System.Drawing.Point(561, 126);
            this.boton_dioni.Name = "boton_dioni";
            this.boton_dioni.Size = new System.Drawing.Size(113, 52);
            this.boton_dioni.TabIndex = 3;
            this.boton_dioni.Text = "Botón de Dioni";
            this.boton_dioni.UseVisualStyleBackColor = true;
            this.boton_dioni.Click += new System.EventHandler(this.boton_dioni_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.boton_dioni);
            this.Controls.Add(this.buttonMarcos);
            this.Controls.Add(this.panelManualMove);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelManualMove;
        private System.Windows.Forms.Button buttonMarcos;
        private System.Windows.Forms.Button boton_dioni;
    }
}

