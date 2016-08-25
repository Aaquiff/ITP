﻿namespace FinishedGoodManagement
{
    partial class DashBoard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Inventory = new System.Windows.Forms.Button();
            this.workorder = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Inventory
            // 
            this.Inventory.Location = new System.Drawing.Point(46, 9);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(130, 48);
            this.Inventory.TabIndex = 0;
            this.Inventory.Text = "New Items";
            this.Inventory.UseVisualStyleBackColor = true;
            this.Inventory.Click += new System.EventHandler(this.Inventory_Click);
            // 
            // workorder
            // 
            this.workorder.Location = new System.Drawing.Point(411, 9);
            this.workorder.Name = "workorder";
            this.workorder.Size = new System.Drawing.Size(130, 48);
            this.workorder.TabIndex = 0;
            this.workorder.Text = "WorkOrder";
            this.workorder.UseVisualStyleBackColor = true;
            this.workorder.Click += new System.EventHandler(this.workorder_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(224, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 48);
            this.button3.TabIndex = 0;
            this.button3.Text = "Ordered Items";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // chart2
            // 
            chartArea3.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart2.Legends.Add(legend3);
            this.chart2.Location = new System.Drawing.Point(422, 77);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(299, 234);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea4.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart3.Legends.Add(legend4);
            this.chart3.Location = new System.Drawing.Point(95, 77);
            this.chart3.Name = "chart3";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart3.Series.Add(series4);
            this.chart3.Size = new System.Drawing.Size(304, 238);
            this.chart3.TabIndex = 1;
            this.chart3.Text = "chart2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Inventory);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.workorder);
            this.panel1.Controls.Add(this.chart3);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.chart2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 405);
            this.panel1.TabIndex = 3;
            // 
            // DashBoard
            // 
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(755, 405);
            this.Controls.Add(this.panel1);
            this.Name = "DashBoard";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart SalesCake;
        private System.Windows.Forms.DataVisualization.Charting.Chart SalesBiscuit;
        private System.Windows.Forms.DataVisualization.Charting.Chart SaleChocolate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button Inventory;
        private System.Windows.Forms.Button workorder;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;

    }
}