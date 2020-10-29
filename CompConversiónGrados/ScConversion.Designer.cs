namespace CompConversiónGrados {
    partial class ScConversion {
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.tbDegrees = new System.Windows.Forms.TextBox();
            this.lDegrees = new System.Windows.Forms.Label();
            this.lTittle = new System.Windows.Forms.Label();
            this.butConversion = new System.Windows.Forms.Button();
            this.gbDegrees = new System.Windows.Forms.GroupBox();
            this.rbCtoF = new System.Windows.Forms.RadioButton();
            this.rbFtoC = new System.Windows.Forms.RadioButton();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.lResult = new System.Windows.Forms.Label();
            this.gbDegrees.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDegrees
            // 
            this.tbDegrees.Location = new System.Drawing.Point(75, 54);
            this.tbDegrees.Name = "tbDegrees";
            this.tbDegrees.Size = new System.Drawing.Size(144, 20);
            this.tbDegrees.TabIndex = 0;
            this.tbDegrees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lDegrees
            // 
            this.lDegrees.AutoSize = true;
            this.lDegrees.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDegrees.Location = new System.Drawing.Point(15, 57);
            this.lDegrees.Name = "lDegrees";
            this.lDegrees.Size = new System.Drawing.Size(54, 17);
            this.lDegrees.TabIndex = 1;
            this.lDegrees.Text = "Grados:";
            // 
            // lTittle
            // 
            this.lTittle.AutoSize = true;
            this.lTittle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTittle.Location = new System.Drawing.Point(12, 10);
            this.lTittle.Name = "lTittle";
            this.lTittle.Size = new System.Drawing.Size(175, 21);
            this.lTittle.TabIndex = 2;
            this.lTittle.Text = "Conversión de grados";
            // 
            // butConversion
            // 
            this.butConversion.Location = new System.Drawing.Point(98, 128);
            this.butConversion.Name = "butConversion";
            this.butConversion.Size = new System.Drawing.Size(121, 23);
            this.butConversion.TabIndex = 3;
            this.butConversion.Text = "Realizar conversión";
            this.butConversion.UseVisualStyleBackColor = true;
            this.butConversion.Click += new System.EventHandler(this.butConversion_Click);
            // 
            // gbDegrees
            // 
            this.gbDegrees.Controls.Add(this.rbFtoC);
            this.gbDegrees.Controls.Add(this.rbCtoF);
            this.gbDegrees.Location = new System.Drawing.Point(225, 47);
            this.gbDegrees.Name = "gbDegrees";
            this.gbDegrees.Size = new System.Drawing.Size(200, 64);
            this.gbDegrees.TabIndex = 4;
            this.gbDegrees.TabStop = false;
            this.gbDegrees.Text = "Opciones de conversión";
            // 
            // rbCtoF
            // 
            this.rbCtoF.AutoSize = true;
            this.rbCtoF.Location = new System.Drawing.Point(18, 20);
            this.rbCtoF.Name = "rbCtoF";
            this.rbCtoF.Size = new System.Drawing.Size(117, 17);
            this.rbCtoF.TabIndex = 0;
            this.rbCtoF.TabStop = true;
            this.rbCtoF.Text = "Celsius a fahrenheit";
            this.rbCtoF.UseVisualStyleBackColor = true;
            // 
            // rbFtoC
            // 
            this.rbFtoC.AutoSize = true;
            this.rbFtoC.Location = new System.Drawing.Point(18, 43);
            this.rbFtoC.Name = "rbFtoC";
            this.rbFtoC.Size = new System.Drawing.Size(119, 17);
            this.rbFtoC.TabIndex = 1;
            this.rbFtoC.TabStop = true;
            this.rbFtoC.Text = "Fahrenheit a celsius";
            this.rbFtoC.UseVisualStyleBackColor = true;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(98, 91);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(121, 20);
            this.tbResult.TabIndex = 5;
            this.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lResult.Location = new System.Drawing.Point(16, 94);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(76, 17);
            this.lResult.TabIndex = 7;
            this.lResult.Text = "Conversión:";
            // 
            // ScConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.gbDegrees);
            this.Controls.Add(this.butConversion);
            this.Controls.Add(this.lTittle);
            this.Controls.Add(this.lDegrees);
            this.Controls.Add(this.tbDegrees);
            this.Name = "ScConversion";
            this.Size = new System.Drawing.Size(450, 167);
            this.gbDegrees.ResumeLayout(false);
            this.gbDegrees.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDegrees;
        private System.Windows.Forms.Label lDegrees;
        private System.Windows.Forms.Label lTittle;
        private System.Windows.Forms.Button butConversion;
        private System.Windows.Forms.GroupBox gbDegrees;
        private System.Windows.Forms.RadioButton rbFtoC;
        private System.Windows.Forms.RadioButton rbCtoF;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label lResult;
    }
}
