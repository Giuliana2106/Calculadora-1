
namespace Ejer.Calc
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
            this.cmdResultado = new System.Windows.Forms.Button();
            this.cbxOperaciones = new System.Windows.Forms.ComboBox();
            this.lblv1 = new System.Windows.Forms.Label();
            this.lblv2 = new System.Windows.Forms.Label();
            this.txtv1 = new System.Windows.Forms.TextBox();
            this.txtv2 = new System.Windows.Forms.TextBox();
            this.lblOperaciones = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdResultado
            // 
            this.cmdResultado.Location = new System.Drawing.Point(236, 341);
            this.cmdResultado.Name = "cmdResultado";
            this.cmdResultado.Size = new System.Drawing.Size(75, 23);
            this.cmdResultado.TabIndex = 0;
            this.cmdResultado.Text = "Resultado";
            this.cmdResultado.UseVisualStyleBackColor = true;
            this.cmdResultado.Click += new System.EventHandler(this.cmdResultado_Click);
            // 
            // cbxOperaciones
            // 
            this.cbxOperaciones.FormattingEnabled = true;
            this.cbxOperaciones.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicación",
            "División"});
            this.cbxOperaciones.Location = new System.Drawing.Point(224, 222);
            this.cbxOperaciones.Name = "cbxOperaciones";
            this.cbxOperaciones.Size = new System.Drawing.Size(121, 21);
            this.cbxOperaciones.TabIndex = 1;
            this.cbxOperaciones.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cbxOperaciones_MouseMove);
            // 
            // lblv1
            // 
            this.lblv1.AutoSize = true;
            this.lblv1.ForeColor = System.Drawing.Color.Navy;
            this.lblv1.Location = new System.Drawing.Point(152, 82);
            this.lblv1.Name = "lblv1";
            this.lblv1.Size = new System.Drawing.Size(40, 13);
            this.lblv1.TabIndex = 2;
            this.lblv1.Text = "Valor 1";
            this.lblv1.Click += new System.EventHandler(this.lblv1_Click);
            // 
            // lblv2
            // 
            this.lblv2.AutoSize = true;
            this.lblv2.ForeColor = System.Drawing.Color.Navy;
            this.lblv2.Location = new System.Drawing.Point(152, 151);
            this.lblv2.Name = "lblv2";
            this.lblv2.Size = new System.Drawing.Size(40, 13);
            this.lblv2.TabIndex = 3;
            this.lblv2.Text = "Valor 2";
            // 
            // txtv1
            // 
            this.txtv1.Location = new System.Drawing.Point(198, 79);
            this.txtv1.Name = "txtv1";
            this.txtv1.Size = new System.Drawing.Size(172, 20);
            this.txtv1.TabIndex = 4;
            // 
            // txtv2
            // 
            this.txtv2.Location = new System.Drawing.Point(198, 148);
            this.txtv2.Name = "txtv2";
            this.txtv2.Size = new System.Drawing.Size(168, 20);
            this.txtv2.TabIndex = 5;
            this.txtv2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtv2_MouseUp);
            // 
            // lblOperaciones
            // 
            this.lblOperaciones.AutoSize = true;
            this.lblOperaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblOperaciones.Location = new System.Drawing.Point(153, 225);
            this.lblOperaciones.Name = "lblOperaciones";
            this.lblOperaciones.Size = new System.Drawing.Size(56, 13);
            this.lblOperaciones.TabIndex = 6;
            this.lblOperaciones.Text = "Operación";
            this.lblOperaciones.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblOperaciones_MouseDown);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.BackColor = System.Drawing.Color.Turquoise;
            this.lblRes.Location = new System.Drawing.Point(267, 287);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(13, 13);
            this.lblRes.TabIndex = 7;
            this.lblRes.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 400);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.lblOperaciones);
            this.Controls.Add(this.txtv2);
            this.Controls.Add(this.txtv1);
            this.Controls.Add(this.lblv2);
            this.Controls.Add(this.lblv1);
            this.Controls.Add(this.cbxOperaciones);
            this.Controls.Add(this.cmdResultado);
            this.Name = "Form1";
            this.Text = "Operaciones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdResultado;
        private System.Windows.Forms.ComboBox cbxOperaciones;
        private System.Windows.Forms.Label lblv1;
        private System.Windows.Forms.Label lblv2;
        private System.Windows.Forms.TextBox txtv1;
        private System.Windows.Forms.TextBox txtv2;
        private System.Windows.Forms.Label lblOperaciones;
        private System.Windows.Forms.Label lblRes;
    }
}

