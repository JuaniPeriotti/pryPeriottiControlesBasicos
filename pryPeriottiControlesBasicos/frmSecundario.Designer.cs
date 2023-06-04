namespace pryPeriottiControlesBasicos
{
    partial class frmSecundario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.optRojo = new System.Windows.Forms.RadioButton();
            this.optAzul = new System.Windows.Forms.RadioButton();
            this.cmdAsignar = new System.Windows.Forms.Button();
            this.lblCopiado = new System.Windows.Forms.Label();
            this.mrcAderezos = new System.Windows.Forms.GroupBox();
            this.chkKetchup = new System.Windows.Forms.CheckBox();
            this.chkChimichurri = new System.Windows.Forms.CheckBox();
            this.chkMayonesa = new System.Windows.Forms.CheckBox();
            this.cmdSeleccionar = new System.Windows.Forms.Button();
            this.mrcAderezos.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(137, 21);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(171, 20);
            this.txtTexto.TabIndex = 0;
            this.txtTexto.TextChanged += new System.EventHandler(this.txtTexto_TextChanged);
            // 
            // optRojo
            // 
            this.optRojo.AutoSize = true;
            this.optRojo.CheckAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.optRojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optRojo.Location = new System.Drawing.Point(137, 67);
            this.optRojo.Name = "optRojo";
            this.optRojo.Size = new System.Drawing.Size(54, 20);
            this.optRojo.TabIndex = 1;
            this.optRojo.TabStop = true;
            this.optRojo.Text = "Rojo";
            this.optRojo.UseVisualStyleBackColor = true;
            this.optRojo.CheckedChanged += new System.EventHandler(this.optRojo_CheckedChanged);
            // 
            // optAzul
            // 
            this.optAzul.AutoSize = true;
            this.optAzul.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.optAzul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optAzul.Location = new System.Drawing.Point(258, 67);
            this.optAzul.Name = "optAzul";
            this.optAzul.Size = new System.Drawing.Size(50, 20);
            this.optAzul.TabIndex = 2;
            this.optAzul.TabStop = true;
            this.optAzul.Text = "Azul";
            this.optAzul.UseVisualStyleBackColor = true;
            // 
            // cmdAsignar
            // 
            this.cmdAsignar.Location = new System.Drawing.Point(183, 134);
            this.cmdAsignar.Name = "cmdAsignar";
            this.cmdAsignar.Size = new System.Drawing.Size(75, 23);
            this.cmdAsignar.TabIndex = 3;
            this.cmdAsignar.Text = "Asignar";
            this.cmdAsignar.UseVisualStyleBackColor = true;
            this.cmdAsignar.Click += new System.EventHandler(this.cmdAsignar_Click);
            // 
            // lblCopiado
            // 
            this.lblCopiado.AutoSize = true;
            this.lblCopiado.Location = new System.Drawing.Point(108, 108);
            this.lblCopiado.Name = "lblCopiado";
            this.lblCopiado.Size = new System.Drawing.Size(229, 13);
            this.lblCopiado.TabIndex = 4;
            this.lblCopiado.Text = "_____________________________________";
            this.lblCopiado.Click += new System.EventHandler(this.lblCopiado_Click);
            // 
            // mrcAderezos
            // 
            this.mrcAderezos.Controls.Add(this.chkKetchup);
            this.mrcAderezos.Controls.Add(this.chkChimichurri);
            this.mrcAderezos.Controls.Add(this.chkMayonesa);
            this.mrcAderezos.Location = new System.Drawing.Point(24, 163);
            this.mrcAderezos.Name = "mrcAderezos";
            this.mrcAderezos.Size = new System.Drawing.Size(381, 103);
            this.mrcAderezos.TabIndex = 5;
            this.mrcAderezos.TabStop = false;
            this.mrcAderezos.Text = "Aderezos";
            // 
            // chkKetchup
            // 
            this.chkKetchup.AutoSize = true;
            this.chkKetchup.Location = new System.Drawing.Point(309, 49);
            this.chkKetchup.Name = "chkKetchup";
            this.chkKetchup.Size = new System.Drawing.Size(66, 17);
            this.chkKetchup.TabIndex = 2;
            this.chkKetchup.Text = "Ketchup";
            this.chkKetchup.UseVisualStyleBackColor = true;
            // 
            // chkChimichurri
            // 
            this.chkChimichurri.AutoSize = true;
            this.chkChimichurri.Location = new System.Drawing.Point(159, 49);
            this.chkChimichurri.Name = "chkChimichurri";
            this.chkChimichurri.Size = new System.Drawing.Size(77, 17);
            this.chkChimichurri.TabIndex = 1;
            this.chkChimichurri.Text = "Chimichurri";
            this.chkChimichurri.UseVisualStyleBackColor = true;
            // 
            // chkMayonesa
            // 
            this.chkMayonesa.AutoSize = true;
            this.chkMayonesa.Location = new System.Drawing.Point(6, 49);
            this.chkMayonesa.Name = "chkMayonesa";
            this.chkMayonesa.Size = new System.Drawing.Size(75, 17);
            this.chkMayonesa.TabIndex = 0;
            this.chkMayonesa.Text = "Mayonesa";
            this.chkMayonesa.UseVisualStyleBackColor = true;
            // 
            // cmdSeleccionar
            // 
            this.cmdSeleccionar.Location = new System.Drawing.Point(183, 286);
            this.cmdSeleccionar.Name = "cmdSeleccionar";
            this.cmdSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.cmdSeleccionar.TabIndex = 8;
            this.cmdSeleccionar.Text = "Seleccionar";
            this.cmdSeleccionar.UseVisualStyleBackColor = true;
            this.cmdSeleccionar.Click += new System.EventHandler(this.cmdSeleccionar_Click);
            // 
            // frmSecundario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 331);
            this.Controls.Add(this.cmdSeleccionar);
            this.Controls.Add(this.mrcAderezos);
            this.Controls.Add(this.lblCopiado);
            this.Controls.Add(this.cmdAsignar);
            this.Controls.Add(this.optAzul);
            this.Controls.Add(this.optRojo);
            this.Controls.Add(this.txtTexto);
            this.Name = "frmSecundario";
            this.Text = "frmSecundario";
            this.mrcAderezos.ResumeLayout(false);
            this.mrcAderezos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.RadioButton optRojo;
        private System.Windows.Forms.RadioButton optAzul;
        private System.Windows.Forms.Button cmdAsignar;
        private System.Windows.Forms.Label lblCopiado;
        private System.Windows.Forms.GroupBox mrcAderezos;
        private System.Windows.Forms.CheckBox chkKetchup;
        private System.Windows.Forms.CheckBox chkChimichurri;
        private System.Windows.Forms.CheckBox chkMayonesa;
        private System.Windows.Forms.Button cmdSeleccionar;
    }
}