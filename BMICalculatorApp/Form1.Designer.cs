namespace BMICalculatorApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblWeightPlaceholder;
        private System.Windows.Forms.Label lblHeightPlaceholder;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblWeightPlaceholder = new System.Windows.Forms.Label();
            this.lblHeightPlaceholder = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // txtWeight
            this.txtWeight.Location = new System.Drawing.Point(30, 30);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(150, 23);
            this.txtWeight.TabIndex = 0;
            this.txtWeight.Enter += new System.EventHandler(this.txtWeight_Enter);
            this.txtWeight.Leave += new System.EventHandler(this.txtWeight_Leave);

            // lblWeightPlaceholder
            this.lblWeightPlaceholder.AutoSize = true;
            this.lblWeightPlaceholder.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblWeightPlaceholder.BackColor = System.Drawing.Color.White;
            this.lblWeightPlaceholder.Location = new System.Drawing.Point(35, 33);
            this.lblWeightPlaceholder.Name = "lblWeightPlaceholder";
            this.lblWeightPlaceholder.Size = new System.Drawing.Size(100, 15);
            this.lblWeightPlaceholder.TabIndex = 4;
            this.lblWeightPlaceholder.Text = "Enter Weight (kg)";
            this.lblWeightPlaceholder.Click += (s, e) => txtWeight.Focus();

            // txtHeight
            this.txtHeight.Location = new System.Drawing.Point(30, 70);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(150, 23);
            this.txtHeight.TabIndex = 1;
            this.txtHeight.Enter += new System.EventHandler(this.txtHeight_Enter);
            this.txtHeight.Leave += new System.EventHandler(this.txtHeight_Leave);

            // lblHeightPlaceholder
            this.lblHeightPlaceholder.AutoSize = true;
            this.lblHeightPlaceholder.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblHeightPlaceholder.BackColor = System.Drawing.Color.White;
            this.lblHeightPlaceholder.Location = new System.Drawing.Point(35, 73);
            this.lblHeightPlaceholder.Name = "lblHeightPlaceholder";
            this.lblHeightPlaceholder.Size = new System.Drawing.Size(100, 15);
            this.lblHeightPlaceholder.TabIndex = 5;
            this.lblHeightPlaceholder.Text = "Enter Height (m)";
            this.lblHeightPlaceholder.Click += (s, e) => txtHeight.Focus();

            // btnCalculate
            this.btnCalculate.Location = new System.Drawing.Point(30, 110);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(150, 30);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate BMI";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // lblResult
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(30, 160);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 15);
            this.lblResult.TabIndex = 3;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.lblHeightPlaceholder);
            this.Controls.Add(this.lblWeightPlaceholder);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblResult);
            this.Name = "Form1";
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}