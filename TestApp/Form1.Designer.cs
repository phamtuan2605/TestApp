namespace TestApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFindNumber = new System.Windows.Forms.Button();
            this.lblResultNumber = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowContent = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnShowName = new System.Windows.Forms.Button();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFindNumber);
            this.groupBox1.Controls.Add(this.lblResultNumber);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 67);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm số thứ 42 có tổng các chữ số bằng 42";
            // 
            // btnFindNumber
            // 
            this.btnFindNumber.Location = new System.Drawing.Point(225, 19);
            this.btnFindNumber.Name = "btnFindNumber";
            this.btnFindNumber.Size = new System.Drawing.Size(104, 23);
            this.btnFindNumber.TabIndex = 12;
            this.btnFindNumber.Text = "Find Number";
            this.btnFindNumber.UseVisualStyleBackColor = true;
            this.btnFindNumber.Click += new System.EventHandler(this.btnFindNumber_Click);
            // 
            // lblResultNumber
            // 
            this.lblResultNumber.AutoSize = true;
            this.lblResultNumber.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultNumber.Location = new System.Drawing.Point(359, 18);
            this.lblResultNumber.Name = "lblResultNumber";
            this.lblResultNumber.Size = new System.Drawing.Size(143, 24);
            this.lblResultNumber.TabIndex = 11;
            this.lblResultNumber.Text = "Result Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnShowContent);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.btnShowName);
            this.groupBox2.Controls.Add(this.rtbResult);
            this.groupBox2.Controls.Add(this.richTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 447);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm bài thơ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name:";
            // 
            // btnShowContent
            // 
            this.btnShowContent.Location = new System.Drawing.Point(593, 58);
            this.btnShowContent.Name = "btnShowContent";
            this.btnShowContent.Size = new System.Drawing.Size(100, 23);
            this.btnShowContent.TabIndex = 13;
            this.btnShowContent.Text = "Display content";
            this.btnShowContent.UseVisualStyleBackColor = true;
            this.btnShowContent.Click += new System.EventHandler(this.btnShowContent_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(399, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(188, 20);
            this.txtName.TabIndex = 12;
            // 
            // btnShowName
            // 
            this.btnShowName.Location = new System.Drawing.Point(358, 26);
            this.btnShowName.Name = "btnShowName";
            this.btnShowName.Size = new System.Drawing.Size(335, 23);
            this.btnShowName.TabIndex = 11;
            this.btnShowName.Text = "Displays the names of all the poems";
            this.btnShowName.UseVisualStyleBackColor = true;
            this.btnShowName.Click += new System.EventHandler(this.btnShowName_Click);
            // 
            // rtbResult
            // 
            this.rtbResult.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.rtbResult.Location = new System.Drawing.Point(358, 87);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(335, 354);
            this.rtbResult.TabIndex = 10;
            this.rtbResult.Text = "";
            // 
            // richTextBox
            // 
            this.richTextBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.richTextBox.Location = new System.Drawing.Point(6, 26);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(323, 415);
            this.richTextBox.TabIndex = 9;
            this.richTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 557);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFindNumber;
        private System.Windows.Forms.Label lblResultNumber;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowContent;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnShowName;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.RichTextBox richTextBox;


    }
}

