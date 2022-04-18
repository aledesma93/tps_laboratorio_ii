namespace MiCalculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbOperador = new System.Windows.Forms.ComboBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnBinario = new System.Windows.Forms.Button();
            this.btnOperar = new System.Windows.Forms.Button();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.lstOperaciones = new System.Windows.Forms.ListBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbOperador
            // 
            this.cmbOperador.FormattingEnabled = true;
            this.cmbOperador.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.cmbOperador.Location = new System.Drawing.Point(260, 93);
            this.cmbOperador.Name = "cmbOperador";
            this.cmbOperador.Size = new System.Drawing.Size(151, 23);
            this.cmbOperador.TabIndex = 2;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.IndianRed;
            this.btnCerrar.Location = new System.Drawing.Point(442, 193);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(151, 64);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnLimpiar.Location = new System.Drawing.Point(260, 193);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(151, 64);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDecimal.Location = new System.Drawing.Point(327, 321);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(266, 64);
            this.btnDecimal.TabIndex = 8;
            this.btnDecimal.Text = "Convertir a Decimal";
            this.btnDecimal.UseVisualStyleBackColor = false;
            this.btnDecimal.Click += new System.EventHandler(this.btnConvertirADecimal_Click);
            // 
            // btnBinario
            // 
            this.btnBinario.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBinario.Location = new System.Drawing.Point(62, 321);
            this.btnBinario.Name = "btnBinario";
            this.btnBinario.Size = new System.Drawing.Size(259, 64);
            this.btnBinario.TabIndex = 7;
            this.btnBinario.Text = "Convertir a Binario";
            this.btnBinario.UseVisualStyleBackColor = false;
            this.btnBinario.Click += new System.EventHandler(this.btnConvertirABinario_Click);
            // 
            // btnOperar
            // 
            this.btnOperar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnOperar.Location = new System.Drawing.Point(62, 193);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(151, 64);
            this.btnOperar.TabIndex = 4;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = false;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(442, 93);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.PlaceholderText = "Numero 2";
            this.txtNumero2.Size = new System.Drawing.Size(151, 23);
            this.txtNumero2.TabIndex = 3;
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(62, 93);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.PlaceholderText = "Numero 1";
            this.txtNumero1.Size = new System.Drawing.Size(151, 23);
            this.txtNumero1.TabIndex = 1;
            // 
            // lstOperaciones
            // 
            this.lstOperaciones.FormattingEnabled = true;
            this.lstOperaciones.ItemHeight = 15;
            this.lstOperaciones.Location = new System.Drawing.Point(635, 52);
            this.lstOperaciones.Name = "lstOperaciones";
            this.lstOperaciones.Size = new System.Drawing.Size(145, 334);
            this.lstOperaciones.TabIndex = 9;
            // 
            // lblResultado
            // 
            this.lblResultado.Location = new System.Drawing.Point(62, 20);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(531, 51);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = "0";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblResultado.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MiCalculadora.Properties.Resources.istockphoto_1027289688_170667a;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lstOperaciones);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.btnBinario);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.cmbOperador);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Ledesma";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCalculadora_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOperador;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnBinario;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.ListBox lstOperaciones;
        private System.Windows.Forms.Label lblResultado;
    }
}
