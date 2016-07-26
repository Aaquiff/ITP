﻿namespace RawMaterialManagement.Invoice_Management
{
    partial class InvoiceDetail
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
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label supplier_idLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label invoice_idLabel;
            System.Windows.Forms.Label payment_statusLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceDetail));
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSupplier = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.supplier_idTextBox = new System.Windows.Forms.TextBox();
            this.tabPageOrder = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.invoice_tabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRawMaterial = new RawMaterialManagement.DataSetRawMaterial();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.invoice_idTextBox = new System.Windows.Forms.TextBox();
            this.invoice_tabTableAdapter = new RawMaterialManagement.DataSetRawMaterialTableAdapters.invoice_tabTableAdapter();
            this.tableAdapterManager = new RawMaterialManagement.DataSetRawMaterialTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            supplier_idLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            invoice_idLabel = new System.Windows.Forms.Label();
            payment_statusLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageSupplier.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoice_tabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRawMaterial)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(411, 49);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(99, 16);
            label6.TabIndex = 34;
            label6.Text = "Contact Person";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(206, 49);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(59, 16);
            label7.TabIndex = 32;
            label7.Text = "Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(4, 49);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(47, 16);
            label8.TabIndex = 30;
            label8.Text = "Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(411, 3);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(42, 16);
            label2.TabIndex = 28;
            label2.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(206, 3);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(45, 16);
            label5.TabIndex = 26;
            label5.Text = "Name";
            // 
            // supplier_idLabel
            // 
            supplier_idLabel.AutoSize = true;
            supplier_idLabel.Location = new System.Drawing.Point(4, 3);
            supplier_idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            supplier_idLabel.Name = "supplier_idLabel";
            supplier_idLabel.Size = new System.Drawing.Size(72, 16);
            supplier_idLabel.TabIndex = 24;
            supplier_idLabel.Text = "Supplier Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 86);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(37, 16);
            label4.TabIndex = 34;
            label4.Text = "Date";
            // 
            // invoice_idLabel
            // 
            invoice_idLabel.AutoSize = true;
            invoice_idLabel.Location = new System.Drawing.Point(7, 30);
            invoice_idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            invoice_idLabel.Name = "invoice_idLabel";
            invoice_idLabel.Size = new System.Drawing.Size(65, 16);
            invoice_idLabel.TabIndex = 28;
            invoice_idLabel.Text = "Invoice Id";
            // 
            // payment_statusLabel
            // 
            payment_statusLabel.AutoSize = true;
            payment_statusLabel.Location = new System.Drawing.Point(277, 86);
            payment_statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            payment_statusLabel.Name = "payment_statusLabel";
            payment_statusLabel.Size = new System.Drawing.Size(45, 16);
            payment_statusLabel.TabIndex = 31;
            payment_statusLabel.Text = "Status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1249, 72);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(62, 68);
            this.toolStripMenuItem3.Text = "New";
            this.toolStripMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(62, 68);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(62, 68);
            this.toolStripMenuItem1.Text = "Delete";
            this.toolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(70, 68);
            this.toolStripMenuItem2.Text = "Populate";
            this.toolStripMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem4.Image")));
            this.toolStripMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(62, 68);
            this.toolStripMenuItem4.Text = "Search";
            this.toolStripMenuItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 425);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(940, 425);
            this.panel2.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tabControl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 194);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(940, 231);
            this.panel4.TabIndex = 27;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSupplier);
            this.tabControl1.Controls.Add(this.tabPageOrder);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(940, 231);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPageSupplier
            // 
            this.tabPageSupplier.Controls.Add(label6);
            this.tabPageSupplier.Controls.Add(this.textBox5);
            this.tabPageSupplier.Controls.Add(label7);
            this.tabPageSupplier.Controls.Add(this.textBox6);
            this.tabPageSupplier.Controls.Add(label8);
            this.tabPageSupplier.Controls.Add(this.textBox7);
            this.tabPageSupplier.Controls.Add(label2);
            this.tabPageSupplier.Controls.Add(this.textBox2);
            this.tabPageSupplier.Controls.Add(label5);
            this.tabPageSupplier.Controls.Add(this.textBox4);
            this.tabPageSupplier.Controls.Add(supplier_idLabel);
            this.tabPageSupplier.Controls.Add(this.supplier_idTextBox);
            this.tabPageSupplier.Location = new System.Drawing.Point(4, 25);
            this.tabPageSupplier.Name = "tabPageSupplier";
            this.tabPageSupplier.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSupplier.Size = new System.Drawing.Size(932, 202);
            this.tabPageSupplier.TabIndex = 0;
            this.tabPageSupplier.Text = "Supplier Details";
            this.tabPageSupplier.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(414, 69);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(197, 22);
            this.textBox5.TabIndex = 35;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(209, 69);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(197, 22);
            this.textBox6.TabIndex = 33;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(10, 69);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(191, 22);
            this.textBox7.TabIndex = 31;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(414, 23);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(197, 22);
            this.textBox2.TabIndex = 29;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(209, 23);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(197, 22);
            this.textBox4.TabIndex = 27;
            // 
            // supplier_idTextBox
            // 
            this.supplier_idTextBox.Location = new System.Drawing.Point(10, 23);
            this.supplier_idTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.supplier_idTextBox.Name = "supplier_idTextBox";
            this.supplier_idTextBox.ReadOnly = true;
            this.supplier_idTextBox.Size = new System.Drawing.Size(191, 22);
            this.supplier_idTextBox.TabIndex = 25;
            // 
            // tabPageOrder
            // 
            this.tabPageOrder.Location = new System.Drawing.Point(4, 25);
            this.tabPageOrder.Name = "tabPageOrder";
            this.tabPageOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrder.Size = new System.Drawing.Size(1241, 386);
            this.tabPageOrder.TabIndex = 1;
            this.tabPageOrder.Text = "Order Detail";
            this.tabPageOrder.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(940, 194);
            this.panel3.TabIndex = 26;
            // 
            // invoice_tabBindingSource
            // 
            this.invoice_tabBindingSource.DataMember = "invoice_tab";
            this.invoice_tabBindingSource.DataSource = this.dataSetRawMaterial;
            // 
            // dataSetRawMaterial
            // 
            this.dataSetRawMaterial.DataSetName = "DataSetRawMaterial";
            this.dataSetRawMaterial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoice_tabBindingSource, "date", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 106);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(262, 22);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // invoice_idTextBox
            // 
            this.invoice_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoice_tabBindingSource, "invoice_id", true));
            this.invoice_idTextBox.Location = new System.Drawing.Point(10, 50);
            this.invoice_idTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.invoice_idTextBox.Name = "invoice_idTextBox";
            this.invoice_idTextBox.Size = new System.Drawing.Size(191, 22);
            this.invoice_idTextBox.TabIndex = 29;
            // 
            // invoice_tabTableAdapter
            // 
            this.invoice_tabTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.invoice_item_tabTableAdapter = null;
            this.tableAdapterManager.invoice_tabTableAdapter = this.invoice_tabTableAdapter;
            this.tableAdapterManager.item_tabTableAdapter = null;
            this.tableAdapterManager.supplier_tabTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RawMaterialManagement.DataSetRawMaterialTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(label10);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(invoice_idLabel);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(payment_statusLabel);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.invoice_idTextBox);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 170);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(label9);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.Controls.Add(this.totalTextBox);
            this.groupBox2.Controls.Add(totalLabel);
            this.groupBox2.Location = new System.Drawing.Point(690, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 170);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(404, 30);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(61, 16);
            label1.TabIndex = 40;
            label1.Text = "Currency";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoice_tabBindingSource, "payment_status", true));
            this.textBox1.Location = new System.Drawing.Point(407, 50);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 22);
            this.textBox1.TabIndex = 41;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoice_tabBindingSource, "total", true));
            this.totalTextBox.Location = new System.Drawing.Point(7, 40);
            this.totalTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(164, 22);
            this.totalTextBox.TabIndex = 34;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(4, 20);
            totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(67, 16);
            totalLabel.TabIndex = 33;
            totalLabel.Text = "Net Value";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoice_tabBindingSource, "total", true));
            this.textBox3.Location = new System.Drawing.Point(7, 86);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 22);
            this.textBox3.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(4, 66);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(69, 16);
            label3.TabIndex = 35;
            label3.Text = "Tax Value";
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoice_tabBindingSource, "total", true));
            this.textBox8.Location = new System.Drawing.Point(7, 132);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(164, 22);
            this.textBox8.TabIndex = 38;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(4, 112);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(82, 16);
            label9.TabIndex = 37;
            label9.Text = "Gross Value";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(206, 30);
            label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(93, 16);
            label10.TabIndex = 42;
            label10.Text = "Order Number";
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoice_tabBindingSource, "invoice_id", true));
            this.textBox9.Location = new System.Drawing.Point(209, 50);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(191, 22);
            this.textBox9.TabIndex = 43;
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoice_tabBindingSource, "invoice_id", true));
            this.textBox10.Location = new System.Drawing.Point(280, 106);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(120, 22);
            this.textBox10.TabIndex = 44;
            // 
            // InvoiceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(940, 425);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InvoiceDetail";
            this.Text = "Invoice Detail";
            this.Load += new System.EventHandler(this.InvoiceDetail_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageSupplier.ResumeLayout(false);
            this.tabPageSupplier.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.invoice_tabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRawMaterial)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DataSetRawMaterial dataSetRawMaterial;
        private System.Windows.Forms.BindingSource invoice_tabBindingSource;
        private DataSetRawMaterialTableAdapters.invoice_tabTableAdapter invoice_tabTableAdapter;
        private DataSetRawMaterialTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSupplier;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox supplier_idTextBox;
        private System.Windows.Forms.TabPage tabPageOrder;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox invoice_idTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox1;
    }
}