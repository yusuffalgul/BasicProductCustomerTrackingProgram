namespace ProductTrackingProgram
{
    partial class Graphics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.backButtonGr = new System.Windows.Forms.Button();
            this.categoryChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.productChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.brandChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.productStockDataSet1 = new ProductTrackingProgram.ProductStockDataSet();
            this.productPriceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.categoryChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productStockDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPriceChart)).BeginInit();
            this.SuspendLayout();
            // 
            // backButtonGr
            // 
            this.backButtonGr.Location = new System.Drawing.Point(1350, 12);
            this.backButtonGr.Name = "backButtonGr";
            this.backButtonGr.Size = new System.Drawing.Size(87, 31);
            this.backButtonGr.TabIndex = 1;
            this.backButtonGr.Text = "Back";
            this.backButtonGr.UseVisualStyleBackColor = true;
            this.backButtonGr.Click += new System.EventHandler(this.backButtonGr_Click);
            // 
            // categoryChart
            // 
            chartArea1.Name = "ChartArea1";
            this.categoryChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.categoryChart.Legends.Add(legend1);
            this.categoryChart.Location = new System.Drawing.Point(678, 34);
            this.categoryChart.Name = "categoryChart";
            this.categoryChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Categories";
            this.categoryChart.Series.Add(series1);
            this.categoryChart.Size = new System.Drawing.Size(485, 284);
            this.categoryChart.TabIndex = 2;
            this.categoryChart.Text = "chart1";
            // 
            // productChart
            // 
            chartArea2.Name = "ChartArea1";
            this.productChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.productChart.Legends.Add(legend2);
            this.productChart.Location = new System.Drawing.Point(36, 34);
            this.productChart.Name = "productChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Products";
            this.productChart.Series.Add(series2);
            this.productChart.Size = new System.Drawing.Size(485, 284);
            this.productChart.TabIndex = 3;
            this.productChart.Text = "chart1";
            this.productChart.Click += new System.EventHandler(this.productChart_Click);
            // 
            // brandChart
            // 
            chartArea3.Name = "ChartArea1";
            this.brandChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.brandChart.Legends.Add(legend3);
            this.brandChart.Location = new System.Drawing.Point(36, 389);
            this.brandChart.Name = "brandChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Brands";
            this.brandChart.Series.Add(series3);
            this.brandChart.Size = new System.Drawing.Size(485, 300);
            this.brandChart.TabIndex = 4;
            this.brandChart.Text = "chart1";
            // 
            // productStockDataSet1
            // 
            this.productStockDataSet1.DataSetName = "ProductStockDataSet";
            this.productStockDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productPriceChart
            // 
            chartArea4.Name = "ChartArea1";
            this.productPriceChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.productPriceChart.Legends.Add(legend4);
            this.productPriceChart.Location = new System.Drawing.Point(678, 389);
            this.productPriceChart.Name = "productPriceChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Product-Price";
            this.productPriceChart.Series.Add(series4);
            this.productPriceChart.Size = new System.Drawing.Size(485, 300);
            this.productPriceChart.TabIndex = 5;
            this.productPriceChart.Text = "chart1";
            // 
            // Graphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1449, 723);
            this.Controls.Add(this.productPriceChart);
            this.Controls.Add(this.brandChart);
            this.Controls.Add(this.productChart);
            this.Controls.Add(this.categoryChart);
            this.Controls.Add(this.backButtonGr);
            this.Name = "Graphics";
            this.Text = "Graphics";
            this.Load += new System.EventHandler(this.Graphics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productStockDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPriceChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button backButtonGr;
        private System.Windows.Forms.DataVisualization.Charting.Chart categoryChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart productChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart brandChart;
        private ProductStockDataSet productStockDataSet1;
        private System.Windows.Forms.DataVisualization.Charting.Chart productPriceChart;
    }
}