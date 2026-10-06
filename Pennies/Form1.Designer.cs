namespace Pennies
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtDays = new TextBox();
            btnCal = new Button();
            btnClr = new Button();
            lstResult = new ListBox();
            label2 = new Label();
            lblTotal = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 70);
            label1.Name = "label1";
            label1.Size = new Size(160, 20);
            label1.TabIndex = 0;
            label1.Text = "Number of days works:";
            // 
            // txtDays
            // 
            txtDays.Location = new Point(214, 70);
            txtDays.Name = "txtDays";
            txtDays.Size = new Size(125, 27);
            txtDays.TabIndex = 1;
            // 
            // btnCal
            // 
            btnCal.Location = new Point(358, 70);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(94, 29);
            btnCal.TabIndex = 2;
            btnCal.Text = "Calculate";
            btnCal.UseVisualStyleBackColor = true;
            btnCal.Click += btnCal_Click;
            // 
            // btnClr
            // 
            btnClr.Location = new Point(470, 70);
            btnClr.Name = "btnClr";
            btnClr.Size = new Size(94, 29);
            btnClr.TabIndex = 3;
            btnClr.Text = "Clear";
            btnClr.UseVisualStyleBackColor = true;
            btnClr.Click += btnClr_Click;
            // 
            // lstResult
            // 
            lstResult.FormattingEnabled = true;
            lstResult.Location = new Point(58, 137);
            lstResult.Name = "lstResult";
            lstResult.Size = new Size(384, 144);
            lstResult.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(243, 298);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 5;
            label2.Text = "Total Pay:";
            // 
            // lblTotal
            // 
            lblTotal.BorderStyle = BorderStyle.FixedSingle;
            lblTotal.Location = new Point(331, 298);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(159, 20);
            lblTotal.TabIndex = 6;
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 338);
            Controls.Add(lblTotal);
            Controls.Add(label2);
            Controls.Add(lstResult);
            Controls.Add(btnClr);
            Controls.Add(btnCal);
            Controls.Add(txtDays);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Salary";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDays;
        private Button btnCal;
        private Button btnClr;
        private ListBox lstResult;
        private Label label2;
        private Label lblTotal;
    }
}
