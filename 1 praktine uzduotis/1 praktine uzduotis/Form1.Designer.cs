namespace _1_praktine_uzduotis
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
            this.failuListBox = new System.Windows.Forms.ListBox();
            this.aplankoBtn = new System.Windows.Forms.Button();
            this.pranesimasLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // failuListBox
            // 
            this.failuListBox.FormattingEnabled = true;
            this.failuListBox.Location = new System.Drawing.Point(12, 51);
            this.failuListBox.Name = "failuListBox";
            this.failuListBox.Size = new System.Drawing.Size(585, 199);
            this.failuListBox.TabIndex = 0;
            // 
            // aplankoBtn
            // 
            this.aplankoBtn.Location = new System.Drawing.Point(12, 12);
            this.aplankoBtn.Name = "aplankoBtn";
            this.aplankoBtn.Size = new System.Drawing.Size(192, 32);
            this.aplankoBtn.TabIndex = 1;
            this.aplankoBtn.Text = "Pasirinkti aplanką";
            this.aplankoBtn.UseVisualStyleBackColor = true;
            this.aplankoBtn.Click += new System.EventHandler(this.aplankoBtn_Click);
            // 
            // pranesimasLabel
            // 
            this.pranesimasLabel.AutoSize = true;
            this.pranesimasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.pranesimasLabel.Location = new System.Drawing.Point(237, 12);
            this.pranesimasLabel.Name = "pranesimasLabel";
            this.pranesimasLabel.Size = new System.Drawing.Size(0, 24);
            this.pranesimasLabel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 261);
            this.Controls.Add(this.pranesimasLabel);
            this.Controls.Add(this.aplankoBtn);
            this.Controls.Add(this.failuListBox);
            this.Name = "Form1";
            this.Text = "Pasikartojančių failų ieškyklė";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox failuListBox;
        private System.Windows.Forms.Button aplankoBtn;
        private System.Windows.Forms.Label pranesimasLabel;
    }
}

