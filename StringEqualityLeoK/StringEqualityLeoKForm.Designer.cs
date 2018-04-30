namespace StringEqualityLeoK
{
    partial class frmStringEqualityLeoK
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
            this.lblRequest = new System.Windows.Forms.Label();
            this.txtStringOne = new System.Windows.Forms.TextBox();
            this.txtStringTwo = new System.Windows.Forms.TextBox();
            this.lblStringOne = new System.Windows.Forms.Label();
            this.lblStringTwo = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblCase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRequest
            // 
            this.lblRequest.AutoSize = true;
            this.lblRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequest.Location = new System.Drawing.Point(9, 9);
            this.lblRequest.Name = "lblRequest";
            this.lblRequest.Size = new System.Drawing.Size(258, 13);
            this.lblRequest.TabIndex = 0;
            this.lblRequest.Text = "Enter two strings in the following text boxes:";
            // 
            // txtStringOne
            // 
            this.txtStringOne.Location = new System.Drawing.Point(16, 95);
            this.txtStringOne.Name = "txtStringOne";
            this.txtStringOne.Size = new System.Drawing.Size(100, 20);
            this.txtStringOne.TabIndex = 1;
            // 
            // txtStringTwo
            // 
            this.txtStringTwo.Location = new System.Drawing.Point(16, 168);
            this.txtStringTwo.Name = "txtStringTwo";
            this.txtStringTwo.Size = new System.Drawing.Size(100, 20);
            this.txtStringTwo.TabIndex = 2;
            // 
            // lblStringOne
            // 
            this.lblStringOne.AutoSize = true;
            this.lblStringOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStringOne.Location = new System.Drawing.Point(16, 79);
            this.lblStringOne.Name = "lblStringOne";
            this.lblStringOne.Size = new System.Drawing.Size(71, 13);
            this.lblStringOne.TabIndex = 3;
            this.lblStringOne.Text = "String One:";
            // 
            // lblStringTwo
            // 
            this.lblStringTwo.AutoSize = true;
            this.lblStringTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStringTwo.Location = new System.Drawing.Point(16, 152);
            this.lblStringTwo.Name = "lblStringTwo";
            this.lblStringTwo.Size = new System.Drawing.Size(72, 13);
            this.lblStringTwo.TabIndex = 4;
            this.lblStringTwo.Text = "String Two:";
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(164, 120);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(82, 35);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(12, 220);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 16);
            this.lblAnswer.TabIndex = 6;
            // 
            // lblCase
            // 
            this.lblCase.AutoSize = true;
            this.lblCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCase.Location = new System.Drawing.Point(16, 44);
            this.lblCase.Name = "lblCase";
            this.lblCase.Size = new System.Drawing.Size(126, 13);
            this.lblCase.TabIndex = 7;
            this.lblCase.Text = "(case doesn\'t matter)";
            // 
            // frmStringEqualityLeoK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblCase);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblStringTwo);
            this.Controls.Add(this.lblStringOne);
            this.Controls.Add(this.txtStringTwo);
            this.Controls.Add(this.txtStringOne);
            this.Controls.Add(this.lblRequest);
            this.Name = "frmStringEqualityLeoK";
            this.Text = "String Equality by Leo Kay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRequest;
        private System.Windows.Forms.TextBox txtStringOne;
        private System.Windows.Forms.TextBox txtStringTwo;
        private System.Windows.Forms.Label lblStringOne;
        private System.Windows.Forms.Label lblStringTwo;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblCase;
    }
}

