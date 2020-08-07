namespace ImageSorter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.FindTextbox = new System.Windows.Forms.TextBox();
            this.StoreTextbox = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.StoreButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FindTextbox
            // 
            this.FindTextbox.Location = new System.Drawing.Point(25, 33);
            this.FindTextbox.Name = "FindTextbox";
            this.FindTextbox.Size = new System.Drawing.Size(493, 27);
            this.FindTextbox.TabIndex = 0;
            // 
            // StoreTextbox
            // 
            this.StoreTextbox.Location = new System.Drawing.Point(25, 86);
            this.StoreTextbox.Name = "StoreTextbox";
            this.StoreTextbox.Size = new System.Drawing.Size(493, 27);
            this.StoreTextbox.TabIndex = 1;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(544, 31);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(135, 29);
            this.FindButton.TabIndex = 2;
            this.FindButton.Text = "Select Directory";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // StoreButton
            // 
            this.StoreButton.Location = new System.Drawing.Point(544, 86);
            this.StoreButton.Name = "StoreButton";
            this.StoreButton.Size = new System.Drawing.Size(135, 29);
            this.StoreButton.TabIndex = 3;
            this.StoreButton.Text = "Select Directory";
            this.StoreButton.UseVisualStyleBackColor = true;
            this.StoreButton.Click += new System.EventHandler(this.StoreButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Where to find files";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Where to store sorted files";
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(697, 31);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(106, 82);
            this.SortButton.TabIndex = 6;
            this.SortButton.Text = "Sort ";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 135);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StoreButton);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.StoreTextbox);
            this.Controls.Add(this.FindTextbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sorter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox FindTextbox;
        private System.Windows.Forms.TextBox StoreTextbox;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Button StoreButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SortButton;
    }
}

