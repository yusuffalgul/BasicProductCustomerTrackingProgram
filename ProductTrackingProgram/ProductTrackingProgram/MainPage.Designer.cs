namespace ProductTrackingProgram
{
    partial class MainPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.productOpButton = new System.Windows.Forms.Button();
            this.customerOpButton = new System.Windows.Forms.Button();
            this.graphicsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(308, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(636, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "STOCK TRACKİNG PROGRAM";
            // 
            // productOpButton
            // 
            this.productOpButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productOpButton.Location = new System.Drawing.Point(317, 203);
            this.productOpButton.Name = "productOpButton";
            this.productOpButton.Size = new System.Drawing.Size(226, 120);
            this.productOpButton.TabIndex = 1;
            this.productOpButton.Text = "Product Operations";
            this.productOpButton.UseVisualStyleBackColor = false;
            this.productOpButton.Click += new System.EventHandler(this.productOpButton_Click);
            // 
            // customerOpButton
            // 
            this.customerOpButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customerOpButton.Location = new System.Drawing.Point(699, 203);
            this.customerOpButton.Name = "customerOpButton";
            this.customerOpButton.Size = new System.Drawing.Size(226, 120);
            this.customerOpButton.TabIndex = 3;
            this.customerOpButton.Text = "Customer Operations";
            this.customerOpButton.UseVisualStyleBackColor = false;
            this.customerOpButton.Click += new System.EventHandler(this.customerOpButton_Click);
            // 
            // graphicsButton
            // 
            this.graphicsButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.graphicsButton.Location = new System.Drawing.Point(515, 388);
            this.graphicsButton.Name = "graphicsButton";
            this.graphicsButton.Size = new System.Drawing.Size(226, 129);
            this.graphicsButton.TabIndex = 4;
            this.graphicsButton.Text = "Graphics";
            this.graphicsButton.UseVisualStyleBackColor = false;
            this.graphicsButton.Click += new System.EventHandler(this.graphicsButton_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1209, 601);
            this.Controls.Add(this.graphicsButton);
            this.Controls.Add(this.customerOpButton);
            this.Controls.Add(this.productOpButton);
            this.Controls.Add(this.label1);
            this.Name = "MainPage";
            this.Text = "Main Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button productOpButton;
        private System.Windows.Forms.Button customerOpButton;
        private System.Windows.Forms.Button graphicsButton;
    }
}

