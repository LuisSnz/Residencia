﻿namespace ProyectoResidencias.CBienes.CambiodeBienes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PorEmpleados));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.PasarIzquierda = new System.Windows.Forms.ToolStripButton();
            this.TodoIzquierda = new System.Windows.Forms.ToolStripButton();
            this.PasarDerecha = new System.Windows.Forms.ToolStripButton();
            this.TodoDerecha = new System.Windows.Forms.ToolStripButton();
            this.Cancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CBDerecho = new System.Windows.Forms.ComboBox();
            this.GridDerecho = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBIzquierdo = new System.Windows.Forms.ComboBox();
            this.GridIzquierdo = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDerecho)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridIzquierdo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Enabled = false;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PasarIzquierda,
            this.TodoIzquierda,
            this.PasarDerecha,
            this.TodoDerecha});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(428, 12);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(76, 245);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // PasarIzquierda
            // 
            this.PasarIzquierda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PasarIzquierda.Image = global::ProyectoResidencias.Properties.Resources.pasar;
            this.PasarIzquierda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PasarIzquierda.Name = "PasarIzquierda";
            this.PasarIzquierda.Size = new System.Drawing.Size(75, 54);
            this.PasarIzquierda.Text = "toolStripButton1";
            this.PasarIzquierda.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.PasarIzquierda.ToolTipText = "Transferir Bien Seleccionado";
            this.PasarIzquierda.Click += new System.EventHandler(this.PasarIzquierda_Click);
            // 
            // TodoIzquierda
            // 
            this.TodoIzquierda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TodoIzquierda.Image = global::ProyectoResidencias.Properties.Resources.pasartodo;
            this.TodoIzquierda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TodoIzquierda.Name = "TodoIzquierda";
            this.TodoIzquierda.Size = new System.Drawing.Size(75, 54);
            this.TodoIzquierda.Text = "Transferir todos los bienes";
            this.TodoIzquierda.Click += new System.EventHandler(this.TodoIzquierda_Click);
            // 
            // PasarDerecha
            // 
            this.PasarDerecha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PasarDerecha.Image = global::ProyectoResidencias.Properties.Resources.pasar2;
            this.PasarDerecha.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PasarDerecha.Name = "PasarDerecha";
            this.PasarDerecha.Size = new System.Drawing.Size(75, 54);
            this.PasarDerecha.Text = "toolStripButton3";
            this.PasarDerecha.ToolTipText = "Transferir Bien Seleccionado";
            this.PasarDerecha.Click += new System.EventHandler(this.PasarDerecha_Click);
            // 
            // TodoDerecha
            // 
            this.TodoDerecha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TodoDerecha.Image = global::ProyectoResidencias.Properties.Resources.pasartodo2;
            this.TodoDerecha.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TodoDerecha.Name = "TodoDerecha";
            this.TodoDerecha.Size = new System.Drawing.Size(75, 54);
            this.TodoDerecha.Text = "toolStripButton4";
            this.TodoDerecha.ToolTipText = "Transferir todos los bienes";
            this.TodoDerecha.Click += new System.EventHandler(this.TodoDerecha_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.White;
            this.Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Location = new System.Drawing.Point(420, 278);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(89, 57);
            this.Cancelar.TabIndex = 7;
            this.Cancelar.Text = "Cerrar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkOrange;
            this.groupBox2.Controls.Add(this.CBDerecho);
            this.groupBox2.Controls.Add(this.GridDerecho);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(515, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 350);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resguardo del Empleado Nuevo";
            // 
            // CBDerecho
            // 
            this.CBDerecho.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CBDerecho.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBDerecho.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBDerecho.FormattingEnabled = true;
            this.CBDerecho.Location = new System.Drawing.Point(6, 19);
            this.CBDerecho.Name = "CBDerecho";
            this.CBDerecho.Size = new System.Drawing.Size(388, 25);
            this.CBDerecho.TabIndex = 2;
            this.CBDerecho.SelectedIndexChanged += new System.EventHandler(this.CBNombreNuevo_SelectedIndexChanged);
            // 
            // GridDerecho
            // 
            this.GridDerecho.AllowUserToAddRows = false;
            this.GridDerecho.AllowUserToDeleteRows = false;
            this.GridDerecho.AllowUserToOrderColumns = true;
            this.GridDerecho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GridDerecho.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GridDerecho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDerecho.Location = new System.Drawing.Point(6, 50);
            this.GridDerecho.Name = "GridDerecho";
            this.GridDerecho.ReadOnly = true;
            this.GridDerecho.Size = new System.Drawing.Size(388, 294);
            this.GridDerecho.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lime;
            this.groupBox1.Controls.Add(this.CBIzquierdo);
            this.groupBox1.Controls.Add(this.GridIzquierdo);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 350);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resguardo del Empleado Actual";
            // 
            // CBIzquierdo
            // 
            this.CBIzquierdo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CBIzquierdo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBIzquierdo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBIzquierdo.FormattingEnabled = true;
            this.CBIzquierdo.Location = new System.Drawing.Point(6, 19);
            this.CBIzquierdo.Name = "CBIzquierdo";
            this.CBIzquierdo.Size = new System.Drawing.Size(388, 25);
            this.CBIzquierdo.TabIndex = 1;
            this.CBIzquierdo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // GridIzquierdo
            // 
            this.GridIzquierdo.AllowUserToAddRows = false;
            this.GridIzquierdo.AllowUserToDeleteRows = false;
            this.GridIzquierdo.AllowUserToOrderColumns = true;
            this.GridIzquierdo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GridIzquierdo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GridIzquierdo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridIzquierdo.Location = new System.Drawing.Point(6, 50);
            this.GridIzquierdo.Name = "GridIzquierdo";
            this.GridIzquierdo.ReadOnly = true;
            this.GridIzquierdo.Size = new System.Drawing.Size(388, 294);
            this.GridIzquierdo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.Cancelar);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 374);
            this.panel1.TabIndex = 9;
            // 
            // PorEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.CancelButton = this.Cancelar;
            this.ClientSize = new System.Drawing.Size(953, 400);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PorEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio de Bienes por Empleados";
            this.Load += new System.EventHandler(this.PorEmpleados_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridDerecho)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridIzquierdo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton PasarIzquierda;
        private System.Windows.Forms.ToolStripButton TodoIzquierda;
        private System.Windows.Forms.ToolStripButton PasarDerecha;
        private System.Windows.Forms.ToolStripButton TodoDerecha;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CBDerecho;
        private System.Windows.Forms.DataGridView GridDerecho;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CBIzquierdo;
        private System.Windows.Forms.DataGridView GridIzquierdo;
        private System.Windows.Forms.Panel panel1;
    }
}