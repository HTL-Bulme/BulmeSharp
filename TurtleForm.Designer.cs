namespace BulmeSharp
{
    partial class TurtleForm
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
            this.btnRedraw = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRedraw
            // 
            this.btnRedraw.Location = new System.Drawing.Point(12, 12);
            this.btnRedraw.Name = "btnRedraw";
            this.btnRedraw.Size = new System.Drawing.Size(316, 63);
            this.btnRedraw.TabIndex = 1;
            this.btnRedraw.Text = "Redraw Slow";
            this.btnRedraw.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(329, 63);
            this.button1.TabIndex = 2;
            this.button1.Text = "Redraw Fast";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TurtleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2020, 1648);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRedraw);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "TurtleForm";
            this.Text = "Bulme Turtle";
            this.Shown += new System.EventHandler(this.TurtleForm_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TurtleForm_Paint);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRedraw;
        private System.Windows.Forms.Button button1;
    }
}