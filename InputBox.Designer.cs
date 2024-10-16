namespace BulmeSharp
{
    partial class InputBox
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
            this.BtnOkay = new System.Windows.Forms.Button();
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.LblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnOkay
            // 
            this.BtnOkay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOkay.Location = new System.Drawing.Point(556, 313);
            this.BtnOkay.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.BtnOkay.Name = "BtnOkay";
            this.BtnOkay.Size = new System.Drawing.Size(291, 88);
            this.BtnOkay.TabIndex = 0;
            this.BtnOkay.Text = "OK";
            this.BtnOkay.UseVisualStyleBackColor = true;
            this.BtnOkay.Click += new System.EventHandler(this.BtnOkay_Click);
            // 
            // TxtInput
            // 
            this.TxtInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInput.Location = new System.Drawing.Point(38, 196);
            this.TxtInput.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.TxtInput.Multiline = true;
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(809, 99);
            this.TxtInput.TabIndex = 2;
            // 
            // LblMessage
            // 
            this.LblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMessage.Location = new System.Drawing.Point(38, 26);
            this.LblMessage.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(809, 162);
            this.LblMessage.TabIndex = 3;
            this.LblMessage.Text = "label1";
            // 
            // InputBox
            // 
            this.AcceptButton = this.BtnOkay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 419);
            this.ControlBox = false;
            this.Controls.Add(this.LblMessage);
            this.Controls.Add(this.TxtInput);
            this.Controls.Add(this.BtnOkay);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "InputBox";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputBox";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.InputBox_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOkay;
        private System.Windows.Forms.TextBox TxtInput;
        private System.Windows.Forms.Label LblMessage;
    }
}