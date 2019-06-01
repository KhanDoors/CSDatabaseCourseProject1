namespace CSDatabaseCourseProject1
{
    partial class frmDataEntry
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
            this.grpDataTimer = new System.Windows.Forms.GroupBox();
            this.grpTimer = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpDataTimer.SuspendLayout();
            this.grpTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDataTimer
            // 
            this.grpDataTimer.Controls.Add(this.btnClear);
            this.grpDataTimer.Controls.Add(this.btnAccept);
            this.grpDataTimer.Controls.Add(this.txtZip);
            this.grpDataTimer.Controls.Add(this.txtState);
            this.grpDataTimer.Controls.Add(this.txtCity);
            this.grpDataTimer.Controls.Add(this.txtAddress);
            this.grpDataTimer.Controls.Add(this.txtName);
            this.grpDataTimer.Controls.Add(this.label5);
            this.grpDataTimer.Controls.Add(this.label4);
            this.grpDataTimer.Controls.Add(this.label3);
            this.grpDataTimer.Controls.Add(this.label2);
            this.grpDataTimer.Controls.Add(this.label1);
            this.grpDataTimer.Location = new System.Drawing.Point(84, 52);
            this.grpDataTimer.Name = "grpDataTimer";
            this.grpDataTimer.Size = new System.Drawing.Size(247, 358);
            this.grpDataTimer.TabIndex = 0;
            this.grpDataTimer.TabStop = false;
            this.grpDataTimer.Text = "Data Entry";
            // 
            // grpTimer
            // 
            this.grpTimer.Controls.Add(this.btnExit);
            this.grpTimer.Controls.Add(this.btnPause);
            this.grpTimer.Controls.Add(this.btnStart);
            this.grpTimer.Controls.Add(this.textBox1);
            this.grpTimer.Location = new System.Drawing.Point(365, 52);
            this.grpTimer.Name = "grpTimer";
            this.grpTimer.Size = new System.Drawing.Size(202, 358);
            this.grpTimer.TabIndex = 1;
            this.grpTimer.TabStop = false;
            this.grpTimer.Text = "Timer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Zip";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(59, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 20);
            this.txtName.TabIndex = 5;
            this.txtName.Text = "Name";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(58, 65);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(151, 20);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.Text = "Address";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(59, 93);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(151, 20);
            this.txtCity.TabIndex = 7;
            this.txtCity.Text = "City";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(58, 124);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(151, 20);
            this.txtState.TabIndex = 8;
            this.txtState.Text = "State";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(59, 156);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(151, 20);
            this.txtZip.TabIndex = 9;
            this.txtZip.Text = "Zip";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(31, 279);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 10;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(135, 279);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(67, 100);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(67, 149);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(67, 194);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.grpTimer);
            this.Controls.Add(this.grpDataTimer);
            this.Name = "frmDataEntry";
            this.Text = "Data Entry Form";
            this.grpDataTimer.ResumeLayout(false);
            this.grpDataTimer.PerformLayout();
            this.grpTimer.ResumeLayout(false);
            this.grpTimer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDataTimer;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpTimer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox textBox1;
    }
}

