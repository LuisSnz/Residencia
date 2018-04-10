namespace ProyectoResidencias.Catalogos.Empleados
{
    partial class Modificar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Motivo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBloqueado = new System.Windows.Forms.CheckBox();
            this.checkSinPliegos = new System.Windows.Forms.CheckBox();
            this.checkBaja = new System.Windows.Forms.CheckBox();
            this.checkJefe = new System.Windows.Forms.CheckBox();
            this.checkPliegos = new System.Windows.Forms.CheckBox();
            this.comboJefe = new System.Windows.Forms.ComboBox();
            this.NumLicencia = new System.Windows.Forms.TextBox();
            this.comboDepto = new System.Windows.Forms.ComboBox();
            this.NombreM = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.Motivo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.checkBloqueado);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(15, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 92);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bloqueo";
            // 
            // Motivo
            // 
            this.Motivo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Motivo.Location = new System.Drawing.Point(67, 52);
            this.Motivo.Name = "Motivo";
            this.Motivo.Size = new System.Drawing.Size(436, 25);
            this.Motivo.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Motivo";
            // 
            // checkBloqueado
            // 
            this.checkBloqueado.AutoSize = true;
            this.checkBloqueado.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBloqueado.Location = new System.Drawing.Point(8, 24);
            this.checkBloqueado.Name = "checkBloqueado";
            this.checkBloqueado.Size = new System.Drawing.Size(151, 21);
            this.checkBloqueado.TabIndex = 25;
            this.checkBloqueado.Text = "Empleado Bloqueado";
            this.checkBloqueado.UseVisualStyleBackColor = true;
            // 
            // checkSinPliegos
            // 
            this.checkSinPliegos.AutoSize = true;
            this.checkSinPliegos.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSinPliegos.Location = new System.Drawing.Point(10, 100);
            this.checkSinPliegos.Name = "checkSinPliegos";
            this.checkSinPliegos.Size = new System.Drawing.Size(130, 21);
            this.checkSinPliegos.TabIndex = 44;
            this.checkSinPliegos.Text = "Sin Validar Pliego";
            this.checkSinPliegos.UseVisualStyleBackColor = true;
            // 
            // checkBaja
            // 
            this.checkBaja.AutoSize = true;
            this.checkBaja.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBaja.Location = new System.Drawing.Point(10, 71);
            this.checkBaja.Name = "checkBaja";
            this.checkBaja.Size = new System.Drawing.Size(54, 21);
            this.checkBaja.TabIndex = 43;
            this.checkBaja.Text = "Baja";
            this.checkBaja.UseVisualStyleBackColor = true;
            // 
            // checkJefe
            // 
            this.checkJefe.AutoSize = true;
            this.checkJefe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkJefe.Location = new System.Drawing.Point(10, 42);
            this.checkJefe.Name = "checkJefe";
            this.checkJefe.Size = new System.Drawing.Size(71, 21);
            this.checkJefe.TabIndex = 42;
            this.checkJefe.Text = "Es Jefe";
            this.checkJefe.UseVisualStyleBackColor = true;
            // 
            // checkPliegos
            // 
            this.checkPliegos.AutoSize = true;
            this.checkPliegos.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPliegos.Location = new System.Drawing.Point(10, 13);
            this.checkPliegos.Name = "checkPliegos";
            this.checkPliegos.Size = new System.Drawing.Size(140, 21);
            this.checkPliegos.TabIndex = 41;
            this.checkPliegos.Text = "Activo para pliegos";
            this.checkPliegos.UseVisualStyleBackColor = true;
            // 
            // comboJefe
            // 
            this.comboJefe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboJefe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboJefe.FormattingEnabled = true;
            this.comboJefe.Location = new System.Drawing.Point(146, 155);
            this.comboJefe.Name = "comboJefe";
            this.comboJefe.Size = new System.Drawing.Size(380, 25);
            this.comboJefe.TabIndex = 40;
            // 
            // NumLicencia
            // 
            this.NumLicencia.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumLicencia.Location = new System.Drawing.Point(146, 97);
            this.NumLicencia.Name = "NumLicencia";
            this.NumLicencia.Size = new System.Drawing.Size(380, 25);
            this.NumLicencia.TabIndex = 38;
            // 
            // comboDepto
            // 
            this.comboDepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDepto.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDepto.FormattingEnabled = true;
            this.comboDepto.Location = new System.Drawing.Point(146, 68);
            this.comboDepto.Name = "comboDepto";
            this.comboDepto.Size = new System.Drawing.Size(380, 25);
            this.comboDepto.TabIndex = 37;
            // 
            // NombreM
            // 
            this.NombreM.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreM.Location = new System.Drawing.Point(146, 39);
            this.NombreM.Name = "NombreM";
            this.NombreM.Size = new System.Drawing.Size(380, 25);
            this.NombreM.TabIndex = 36;
            // 
            // Nombre
            // 
            this.Nombre.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(146, 10);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(380, 25);
            this.Nombre.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Jefe Dpto.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Fecha Vencimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Num. Licencia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Departamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Nombre a mostrar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nombre";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(614, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 35);
            this.button2.TabIndex = 28;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(614, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 35);
            this.button1.TabIndex = 27;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.checkSinPliegos);
            this.panel1.Controls.Add(this.checkBaja);
            this.panel1.Controls.Add(this.checkJefe);
            this.panel1.Controls.Add(this.checkPliegos);
            this.panel1.Location = new System.Drawing.Point(569, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 137);
            this.panel1.TabIndex = 46;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Fecha);
            this.panel2.Controls.Add(this.comboJefe);
            this.panel2.Controls.Add(this.NumLicencia);
            this.panel2.Controls.Add(this.comboDepto);
            this.panel2.Controls.Add(this.NombreM);
            this.panel2.Controls.Add(this.Nombre);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(15, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 191);
            this.panel2.TabIndex = 47;
            // 
            // Fecha
            // 
            this.Fecha.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fecha.Location = new System.Drawing.Point(146, 126);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(380, 25);
            this.Fecha.TabIndex = 41;
            // 
            // Modificar
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(751, 318);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Modificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar";
            this.Load += new System.EventHandler(this.Modificar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Motivo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBloqueado;
        private System.Windows.Forms.CheckBox checkSinPliegos;
        private System.Windows.Forms.CheckBox checkBaja;
        private System.Windows.Forms.CheckBox checkJefe;
        private System.Windows.Forms.CheckBox checkPliegos;
        private System.Windows.Forms.ComboBox comboJefe;
        private System.Windows.Forms.TextBox NumLicencia;
        private System.Windows.Forms.ComboBox comboDepto;
        private System.Windows.Forms.TextBox NombreM;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker Fecha;
    }
}