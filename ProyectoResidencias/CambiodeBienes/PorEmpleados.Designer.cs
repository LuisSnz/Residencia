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
            this.Cancelar = new System.Windows.Forms.Button();
            this.Aceptar = new System.Windows.Forms.Button();
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
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.White;
            this.Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Location = new System.Drawing.Point(433, 387);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(131, 34);
            this.Cancelar.TabIndex = 7;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Aceptar
            // 
            this.Aceptar.BackColor = System.Drawing.Color.White;
            this.Aceptar.Enabled = false;
            this.Aceptar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptar.Location = new System.Drawing.Point(279, 387);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(133, 34);
            this.Aceptar.TabIndex = 6;
            this.Aceptar.Text = "Aceptar Cambio";
            this.Aceptar.UseVisualStyleBackColor = false;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.CBNombreNuevo);
            this.groupBox2.Controls.Add(this.GridNuevo);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(433, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 350);
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
            this.CBNombreNuevo.Size = new System.Drawing.Size(388, 25);
            this.CBNombreNuevo.TabIndex = 2;
            this.CBNombreNuevo.SelectedIndexChanged += new System.EventHandler(this.CBNombreNuevo_SelectedIndexChanged);
            // 
            // GridNuevo
            // 
            this.GridNuevo.AllowUserToAddRows = false;
            this.GridNuevo.AllowUserToDeleteRows = false;
            this.GridNuevo.AllowUserToOrderColumns = true;
            this.GridNuevo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridNuevo.Location = new System.Drawing.Point(6, 50);
            this.GridNuevo.Name = "GridNuevo";
            this.GridNuevo.ReadOnly = true;
            this.GridNuevo.Size = new System.Drawing.Size(388, 294);
            this.GridNuevo.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.CBNombreActual);
            this.groupBox1.Controls.Add(this.GridActual);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 350);
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
            this.CBNombreActual.Size = new System.Drawing.Size(388, 25);
            this.CBNombreActual.TabIndex = 1;
            this.CBNombreActual.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // GridActual
            // 
            this.GridActual.AllowUserToAddRows = false;
            this.GridActual.AllowUserToDeleteRows = false;
            this.GridActual.AllowUserToOrderColumns = true;
            this.GridActual.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GridActual.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GridActual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridActual.Location = new System.Drawing.Point(6, 50);
            this.GridActual.Name = "GridActual";
            this.GridActual.ReadOnly = true;
            this.GridActual.Size = new System.Drawing.Size(388, 294);
            this.GridActual.TabIndex = 0;
            // 
            // PorEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.CancelButton = this.Cancelar;
            this.ClientSize = new System.Drawing.Size(845, 433);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Aceptar);
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

        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CBNombreNuevo;
        private System.Windows.Forms.DataGridView GridNuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CBNombreActual;
        private System.Windows.Forms.DataGridView GridActual;
    }
}