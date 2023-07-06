
namespace autostart
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAppPath = new System.Windows.Forms.TextBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRegistryName = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter application path :";
            // 
            // textBoxAppPath
            // 
            this.textBoxAppPath.Location = new System.Drawing.Point(433, 178);
            this.textBoxAppPath.Name = "textBoxAppPath";
            this.textBoxAppPath.Size = new System.Drawing.Size(1162, 46);
            this.textBoxAppPath.TabIndex = 1;
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(76, 337);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(430, 101);
            this.buttonRun.TabIndex = 2;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter registry name    :";
            // 
            // textBoxRegistryName
            // 
            this.textBoxRegistryName.Location = new System.Drawing.Point(433, 244);
            this.textBoxRegistryName.Name = "textBoxRegistryName";
            this.textBoxRegistryName.Size = new System.Drawing.Size(1162, 46);
            this.textBoxRegistryName.TabIndex = 6;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(563, 337);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(100, 39);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "label3";
            this.statusLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1638, 854);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.textBoxRegistryName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.textBoxAppPath);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(9);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAppPath;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRegistryName;
        private System.Windows.Forms.Label statusLabel;
    }
}

