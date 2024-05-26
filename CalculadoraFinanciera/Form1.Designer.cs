
namespace CalculadoraFinanciera
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
            this.textcap = new System.Windows.Forms.TextBox();
            this.texttasa = new System.Windows.Forms.TextBox();
            this.textper = new System.Windows.Forms.TextBox();
            this.textmon = new System.Windows.Forms.TextBox();
            this.combotipo = new System.Windows.Forms.ComboBox();
            this.labcap = new System.Windows.Forms.Label();
            this.labtasa = new System.Windows.Forms.Label();
            this.labmonto = new System.Windows.Forms.Label();
            this.labper = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butcalcu = new System.Windows.Forms.Button();
            this.textcalcu = new System.Windows.Forms.TextBox();
            this.quesbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textpor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textdec = new System.Windows.Forms.TextBox();
            this.butcon = new System.Windows.Forms.Button();
            this.buttonbor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textcap
            // 
            this.textcap.Location = new System.Drawing.Point(145, 59);
            this.textcap.Name = "textcap";
            this.textcap.Size = new System.Drawing.Size(135, 20);
            this.textcap.TabIndex = 0;
            this.textcap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textcap_KeyPress);
            // 
            // texttasa
            // 
            this.texttasa.Location = new System.Drawing.Point(145, 101);
            this.texttasa.Name = "texttasa";
            this.texttasa.Size = new System.Drawing.Size(135, 20);
            this.texttasa.TabIndex = 1;
            this.texttasa.Click += new System.EventHandler(this.texttasa_Click);
            this.texttasa.EnabledChanged += new System.EventHandler(this.texttasa_EnabledChanged);
            this.texttasa.TextChanged += new System.EventHandler(this.texttasa_TextChanged);
            this.texttasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texttasa_KeyPress);
            // 
            // textper
            // 
            this.textper.Location = new System.Drawing.Point(145, 147);
            this.textper.Name = "textper";
            this.textper.Size = new System.Drawing.Size(135, 20);
            this.textper.TabIndex = 2;
            this.textper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textper_KeyPress);
            // 
            // textmon
            // 
            this.textmon.Location = new System.Drawing.Point(145, 199);
            this.textmon.Name = "textmon";
            this.textmon.Size = new System.Drawing.Size(135, 20);
            this.textmon.TabIndex = 3;
            this.textmon.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textmon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textmon_KeyPress);
            // 
            // combotipo
            // 
            this.combotipo.FormattingEnabled = true;
            this.combotipo.Location = new System.Drawing.Point(147, 17);
            this.combotipo.Name = "combotipo";
            this.combotipo.Size = new System.Drawing.Size(121, 21);
            this.combotipo.TabIndex = 4;
            this.combotipo.SelectedIndexChanged += new System.EventHandler(this.combotipo_SelectedIndexChanged);
            // 
            // labcap
            // 
            this.labcap.AutoSize = true;
            this.labcap.Location = new System.Drawing.Point(17, 62);
            this.labcap.Name = "labcap";
            this.labcap.Size = new System.Drawing.Size(42, 13);
            this.labcap.TabIndex = 5;
            this.labcap.Text = "Capital:";
            this.labcap.Click += new System.EventHandler(this.label1_Click);
            // 
            // labtasa
            // 
            this.labtasa.AutoSize = true;
            this.labtasa.Location = new System.Drawing.Point(17, 104);
            this.labtasa.Name = "labtasa";
            this.labtasa.Size = new System.Drawing.Size(84, 13);
            this.labtasa.TabIndex = 6;
            this.labtasa.Text = "Tasa de Interés:";
            // 
            // labmonto
            // 
            this.labmonto.AutoSize = true;
            this.labmonto.Location = new System.Drawing.Point(17, 202);
            this.labmonto.Name = "labmonto";
            this.labmonto.Size = new System.Drawing.Size(40, 13);
            this.labmonto.TabIndex = 7;
            this.labmonto.Text = "Monto:";
            // 
            // labper
            // 
            this.labper.AutoSize = true;
            this.labper.Location = new System.Drawing.Point(17, 150);
            this.labper.Name = "labper";
            this.labper.Size = new System.Drawing.Size(76, 13);
            this.labper.TabIndex = 8;
            this.labper.Text = "# de Periodos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "¿Que deseas encontrar?";
            // 
            // butcalcu
            // 
            this.butcalcu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butcalcu.Location = new System.Drawing.Point(20, 264);
            this.butcalcu.Name = "butcalcu";
            this.butcalcu.Size = new System.Drawing.Size(190, 26);
            this.butcalcu.TabIndex = 11;
            this.butcalcu.Text = "Calcular";
            this.butcalcu.UseVisualStyleBackColor = false;
            this.butcalcu.Click += new System.EventHandler(this.butcalcu_Click);
            // 
            // textcalcu
            // 
            this.textcalcu.Enabled = false;
            this.textcalcu.Location = new System.Drawing.Point(20, 321);
            this.textcalcu.Name = "textcalcu";
            this.textcalcu.Size = new System.Drawing.Size(471, 20);
            this.textcalcu.TabIndex = 12;
            // 
            // quesbutton
            // 
            this.quesbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.quesbutton.BackgroundImage = global::CalculadoraFinanciera.Properties.Resources.question;
            this.quesbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quesbutton.FlatAppearance.BorderSize = 0;
            this.quesbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quesbutton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.quesbutton.Location = new System.Drawing.Point(730, 12);
            this.quesbutton.Name = "quesbutton";
            this.quesbutton.Size = new System.Drawing.Size(58, 52);
            this.quesbutton.TabIndex = 13;
            this.quesbutton.UseVisualStyleBackColor = false;
            this.quesbutton.Click += new System.EventHandler(this.quesbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(383, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Convertidor de porcentaje a decimal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ingresa la tasa de interes en porcentaje";
            // 
            // textpor
            // 
            this.textpor.Location = new System.Drawing.Point(441, 67);
            this.textpor.Name = "textpor";
            this.textpor.Size = new System.Drawing.Size(135, 20);
            this.textpor.TabIndex = 16;
            this.textpor.TextChanged += new System.EventHandler(this.textpor_TextChanged);
            this.textpor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textpor_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tasa de interés en decimales";
            // 
            // textdec
            // 
            this.textdec.Enabled = false;
            this.textdec.Location = new System.Drawing.Point(441, 163);
            this.textdec.Name = "textdec";
            this.textdec.Size = new System.Drawing.Size(135, 20);
            this.textdec.TabIndex = 18;
            // 
            // butcon
            // 
            this.butcon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butcon.Location = new System.Drawing.Point(463, 97);
            this.butcon.Name = "butcon";
            this.butcon.Size = new System.Drawing.Size(86, 26);
            this.butcon.TabIndex = 19;
            this.butcon.Text = "Convertir";
            this.butcon.UseVisualStyleBackColor = false;
            this.butcon.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonbor
            // 
            this.buttonbor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonbor.Location = new System.Drawing.Point(582, 163);
            this.buttonbor.Name = "buttonbor";
            this.buttonbor.Size = new System.Drawing.Size(72, 20);
            this.buttonbor.TabIndex = 20;
            this.buttonbor.Text = "Borrar";
            this.buttonbor.UseVisualStyleBackColor = false;
            this.buttonbor.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonbor);
            this.Controls.Add(this.butcon);
            this.Controls.Add(this.textdec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textpor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quesbutton);
            this.Controls.Add(this.textcalcu);
            this.Controls.Add(this.butcalcu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labper);
            this.Controls.Add(this.labmonto);
            this.Controls.Add(this.labtasa);
            this.Controls.Add(this.labcap);
            this.Controls.Add(this.combotipo);
            this.Controls.Add(this.textmon);
            this.Controls.Add(this.textper);
            this.Controls.Add(this.texttasa);
            this.Controls.Add(this.textcap);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculadora de Interés Compuesto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textcap;
        private System.Windows.Forms.TextBox texttasa;
        private System.Windows.Forms.TextBox textper;
        private System.Windows.Forms.TextBox textmon;
        private System.Windows.Forms.ComboBox combotipo;
        private System.Windows.Forms.Label labcap;
        private System.Windows.Forms.Label labtasa;
        private System.Windows.Forms.Label labmonto;
        private System.Windows.Forms.Label labper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butcalcu;
        private System.Windows.Forms.TextBox textcalcu;
        private System.Windows.Forms.Button quesbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textpor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textdec;
        private System.Windows.Forms.Button butcon;
        private System.Windows.Forms.Button buttonbor;
    }
}

