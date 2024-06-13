namespace ProjetoLed
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialArduino = new System.IO.Ports.SerialPort(this.components);
            this.arduino = new BqBusNet.BqBusSerial(this.components);
            this.buttonOff = new System.Windows.Forms.Button();
            this.buttonOn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serialArduino
            // 
            this.serialArduino.PortName = "COM3";
            // 
            // arduino
            // 
            this.arduino.Serial = this.serialArduino;
            this.arduino.Size = 1;
            // 
            // buttonOff
            // 
            this.buttonOff.Location = new System.Drawing.Point(186, 74);
            this.buttonOff.Name = "buttonOff";
            this.buttonOff.Size = new System.Drawing.Size(97, 32);
            this.buttonOff.TabIndex = 0;
            this.buttonOff.Text = "Desligar";
            this.buttonOff.UseVisualStyleBackColor = true;
            this.buttonOff.Click += new System.EventHandler(this.buttonOff_Click);
            // 
            // buttonOn
            // 
            this.buttonOn.Location = new System.Drawing.Point(33, 74);
            this.buttonOn.Name = "buttonOn";
            this.buttonOn.Size = new System.Drawing.Size(97, 32);
            this.buttonOn.TabIndex = 1;
            this.buttonOn.Text = "Ligar";
            this.buttonOn.UseVisualStyleBackColor = true;
            this.buttonOn.Click += new System.EventHandler(this.buttonOn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 176);
            this.Controls.Add(this.buttonOn);
            this.Controls.Add(this.buttonOff);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialArduino;
        private BqBusNet.BqBusSerial arduino;
        private System.Windows.Forms.Button buttonOff;
        private System.Windows.Forms.Button buttonOn;
    }
}

