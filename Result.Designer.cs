namespace MBTI
{
    partial class Result
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
            label1 = new System.Windows.Forms.Label();
            MBTIResult = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            btnExit = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("맑은 고딕", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(383, 54);
            label1.TabIndex = 0;
            label1.Text = "당신의 MBTI 유형은";
            // 
            // MBTIResult
            // 
            MBTIResult.AutoSize = true;
            MBTIResult.Font = new System.Drawing.Font("맑은 고딕", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            MBTIResult.Location = new System.Drawing.Point(12, 63);
            MBTIResult.Name = "MBTIResult";
            MBTIResult.Size = new System.Drawing.Size(39, 54);
            MBTIResult.TabIndex = 0;
            MBTIResult.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("맑은 고딕", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(12, 117);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(152, 54);
            label3.TabIndex = 0;
            label3.Text = "입니다.";
            // 
            // btnExit
            // 
            btnExit.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnExit.Location = new System.Drawing.Point(682, 372);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(83, 66);
            btnExit.TabIndex = 1;
            btnExit.Text = "종료";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Result
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(label3);
            Controls.Add(MBTIResult);
            Controls.Add(label1);
            Name = "Result";
            Text = "Result";
            TopMost = true;
            Load += Result_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MBTIResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
    }
}