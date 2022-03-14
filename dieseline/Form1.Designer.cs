namespace dieseline
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
            this.dsTextBox1 = new dieseline.DS_Components.DS_TextBoxs.DSTextBox();
            this.SuspendLayout();
            // 
            // dsTextBox1
            // 
            this.dsTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.dsTextBox1.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.dsTextBox1.BorderSize = 2;
            this.dsTextBox1.Location = new System.Drawing.Point(456, 102);
            this.dsTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.dsTextBox1.Name = "dsTextBox1";
            this.dsTextBox1.Size = new System.Drawing.Size(200, 16);
            this.dsTextBox1.TabIndex = 0;
            this.dsTextBox1.UnderlineStyle = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dsTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DS_Components.DS_TextBoxs.DSTextBox dsTextBox1;
    }
}