﻿namespace Consultorio
{
    partial class ListadoFormasDePago
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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.btnAgregar = new Telerik.WinControls.UI.RadButton();
            this.btnVolver = new Telerik.WinControls.UI.RadButton();
            this.formaDePagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEditar = new Telerik.WinControls.UI.RadButton();
            this.btnEliminar = new Telerik.WinControls.UI.RadButton();
            this.btnBuscar = new Telerik.WinControls.UI.RadButton();
            this.lblBuscar = new Telerik.WinControls.UI.RadLabel();
            this.txtBoxBuscar = new Telerik.WinControls.UI.RadTextBox();
            this.dgvBancos = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formaDePagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBancos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBancos.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.Location = new System.Drawing.Point(431, 119);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(157, 25);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnVolver.Location = new System.Drawing.Point(450, 296);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(110, 24);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // formaDePagoBindingSource
            // 
            this.formaDePagoBindingSource.DataSource = typeof(Consultorio.Modelo.FormaDePago);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditar.Location = new System.Drawing.Point(431, 150);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(157, 25);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Location = new System.Drawing.Point(431, 181);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(157, 25);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Location = new System.Drawing.Point(431, 64);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(157, 24);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBuscar.Location = new System.Drawing.Point(435, 12);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(140, 19);
            this.lblBuscar.TabIndex = 14;
            this.lblBuscar.Text = "Nombre Forma de Pago:";
            // 
            // txtBoxBuscar
            // 
            this.txtBoxBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxBuscar.Location = new System.Drawing.Point(431, 37);
            this.txtBoxBuscar.Name = "txtBoxBuscar";
            this.txtBoxBuscar.Size = new System.Drawing.Size(157, 21);
            this.txtBoxBuscar.TabIndex = 13;
            // 
            // dgvBancos
            // 
            this.dgvBancos.EnableKineticScrolling = true;
            this.dgvBancos.Location = new System.Drawing.Point(8, 12);
            // 
            // 
            // 
            this.dgvBancos.MasterTemplate.AllowAddNewRow = false;
            this.dgvBancos.MasterTemplate.AllowColumnChooser = false;
            this.dgvBancos.MasterTemplate.AllowColumnReorder = false;
            this.dgvBancos.MasterTemplate.AllowColumnResize = false;
            this.dgvBancos.MasterTemplate.AllowDeleteRow = false;
            this.dgvBancos.MasterTemplate.AllowDragToGroup = false;
            this.dgvBancos.MasterTemplate.AllowEditRow = false;
            this.dgvBancos.MasterTemplate.AllowRowReorder = true;
            this.dgvBancos.MasterTemplate.AllowRowResize = false;
            this.dgvBancos.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "Nombre";
            gridViewTextBoxColumn1.HeaderText = "Nombre";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Nombre";
            gridViewTextBoxColumn1.Width = 388;
            this.dgvBancos.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1});
            this.dgvBancos.MasterTemplate.DataSource = this.formaDePagoBindingSource;
            this.dgvBancos.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysHide;
            this.dgvBancos.MasterTemplate.SearchRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.dgvBancos.MasterTemplate.VerticalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysHide;
            this.dgvBancos.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgvBancos.Name = "dgvBancos";
            this.dgvBancos.ReadOnly = true;
            this.dgvBancos.ShowGroupPanel = false;
            this.dgvBancos.ShowGroupPanelScrollbars = false;
            this.dgvBancos.Size = new System.Drawing.Size(409, 308);
            this.dgvBancos.TabIndex = 22;
            this.dgvBancos.Text = "radGridView1";
            // 
            // ListadoFormasDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(598, 332);
            this.Controls.Add(this.dgvBancos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBoxBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ListadoFormasDePago";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Formas de Pago";
            this.Load += new System.EventHandler(this.Forma_Pago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formaDePagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBancos.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBancos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private Telerik.WinControls.UI.RadButton btnAgregar;
        private Telerik.WinControls.UI.RadButton btnVolver;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Telerik.WinControls.UI.RadButton btnEditar;
        private Telerik.WinControls.UI.RadButton btnEliminar;
        private Telerik.WinControls.UI.RadButton btnBuscar;
        private Telerik.WinControls.UI.RadLabel lblBuscar;
        private Telerik.WinControls.UI.RadTextBox txtBoxBuscar;
        private System.Windows.Forms.BindingSource formaDePagoBindingSource;
        private Telerik.WinControls.UI.RadGridView dgvBancos;
    }
}