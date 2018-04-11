namespace ProyectoResidencias.CBienes.CambiodeBienes
{
    partial class PorEmpleados
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CBNombreNuevo = new System.Windows.Forms.ComboBox();
            this.GridNuevo = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBNombreActual = new System.Windows.Forms.ComboBox();
            this.GridActual = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridNuevo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridActual)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(335, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(188, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Aceptar Cambio";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.CBNombreNuevo);
            this.groupBox2.Controls.Add(this.GridNuevo);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(329, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 258);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resguardo del Empleado Nuevo";
            // 
            // CBNombreNuevo
            // 
            this.CBNombreNuevo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CBNombreNuevo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBNombreNuevo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBNombreNuevo.FormattingEnabled = true;
            this.CBNombreNuevo.Location = new System.Drawing.Point(6, 19);
            this.CBNombreNuevo.Name = "CBNombreNuevo";
            this.CBNombreNuevo.Size = new System.Drawing.Size(288, 25);
            this.CBNombreNuevo.TabIndex = 2;
            // 
            // GridNuevo
            // 
            this.GridNuevo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridNuevo.Location = new System.Drawing.Point(6, 46);
            this.GridNuevo.Name = "GridNuevo";
            this.GridNuevo.Size = new System.Drawing.Size(288, 203);
            this.GridNuevo.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.CBNombreActual);
            this.groupBox1.Controls.Add(this.GridActual);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 258);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resguardo del Empleado Actual";
            // 
            // CBNombreActual
            // 
            this.CBNombreActual.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CBNombreActual.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBNombreActual.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBNombreActual.FormattingEnabled = true;
            this.CBNombreActual.Location = new System.Drawing.Point(6, 19);
            this.CBNombreActual.Name = "CBNombreActual";
            this.CBNombreActual.Size = new System.Drawing.Size(288, 25);
            this.CBNombreActual.TabIndex = 1;
            this.CBNombreActual.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // GridActual
            // 
            this.GridActual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridActual.Location = new System.Drawing.Point(6, 46);
            this.GridActual.Name = "GridActual";
            this.GridActual.Size = new System.Drawing.Size(288, 203);
            this.GridActual.TabIndex = 0;
            // 
            // PorEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(641, 334);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PorEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio de Bienes por Empleados";
            this.Load += new System.EventHandler(this.PorEmpleados_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridNuevo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridActual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CBNombreNuevo;
        private System.Windows.Forms.DataGridView GridNuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CBNombreActual;
        private System.Windows.Forms.DataGridView GridActual;
    }
}