namespace CP220_ASYNC_P2_UI
{
    partial class Form1
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
            this.btnStart = new System.Windows.Forms.Button();
            this.P1_OUTPUT = new System.Windows.Forms.ListBox();
            this.P2_OUTPUT = new System.Windows.Forms.ListBox();
            this.SimStatus = new System.Windows.Forms.Label();
            this.txtSimStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(536, 165);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(263, 147);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Simulation";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // P1_OUTPUT
            // 
            this.P1_OUTPUT.FormattingEnabled = true;
            this.P1_OUTPUT.Location = new System.Drawing.Point(12, 12);
            this.P1_OUTPUT.Name = "P1_OUTPUT";
            this.P1_OUTPUT.Size = new System.Drawing.Size(518, 147);
            this.P1_OUTPUT.TabIndex = 1;
            // 
            // P2_OUTPUT
            // 
            this.P2_OUTPUT.FormattingEnabled = true;
            this.P2_OUTPUT.Location = new System.Drawing.Point(12, 165);
            this.P2_OUTPUT.Name = "P2_OUTPUT";
            this.P2_OUTPUT.Size = new System.Drawing.Size(518, 147);
            this.P2_OUTPUT.TabIndex = 2;
            // 
            // SimStatus
            // 
            this.SimStatus.AutoSize = true;
            this.SimStatus.Location = new System.Drawing.Point(618, 44);
            this.SimStatus.Name = "SimStatus";
            this.SimStatus.Size = new System.Drawing.Size(88, 13);
            this.SimStatus.TabIndex = 3;
            this.SimStatus.Text = "Simulation Status";
            // 
            // txtSimStatus
            // 
            this.txtSimStatus.Location = new System.Drawing.Point(572, 83);
            this.txtSimStatus.Name = "txtSimStatus";
            this.txtSimStatus.ReadOnly = true;
            this.txtSimStatus.Size = new System.Drawing.Size(185, 20);
            this.txtSimStatus.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 324);
            this.Controls.Add(this.txtSimStatus);
            this.Controls.Add(this.SimStatus);
            this.Controls.Add(this.P2_OUTPUT);
            this.Controls.Add(this.P1_OUTPUT);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Peasent Simulator 2017";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox P1_OUTPUT;
        private System.Windows.Forms.ListBox P2_OUTPUT;
        private System.Windows.Forms.Label SimStatus;
        private System.Windows.Forms.TextBox txtSimStatus;
    }
}

