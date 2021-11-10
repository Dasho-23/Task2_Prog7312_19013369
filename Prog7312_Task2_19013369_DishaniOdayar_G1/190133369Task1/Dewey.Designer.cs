
namespace _190133369Task1
{
    partial class Dewey
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
            this.btnReplBook = new System.Windows.Forms.Button();
            this.btnFinCallNums = new System.Windows.Forms.Button();
            this.btnIdentAreas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEx = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReplBook
            // 
            this.btnReplBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplBook.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReplBook.Location = new System.Drawing.Point(35, 250);
            this.btnReplBook.Name = "btnReplBook";
            this.btnReplBook.Size = new System.Drawing.Size(227, 41);
            this.btnReplBook.TabIndex = 0;
            this.btnReplBook.Text = "Replacing books";
            this.btnReplBook.UseVisualStyleBackColor = true;
            this.btnReplBook.Click += new System.EventHandler(this.btnReplBook_Click);
            // 
            // btnFinCallNums
            // 
            this.btnFinCallNums.Enabled = false;
            this.btnFinCallNums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinCallNums.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFinCallNums.Location = new System.Drawing.Point(625, 248);
            this.btnFinCallNums.Name = "btnFinCallNums";
            this.btnFinCallNums.Size = new System.Drawing.Size(227, 43);
            this.btnFinCallNums.TabIndex = 1;
            this.btnFinCallNums.Text = "Finding call numbers";
            this.btnFinCallNums.UseVisualStyleBackColor = true;
            // 
            // btnIdentAreas
            // 
            this.btnIdentAreas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdentAreas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIdentAreas.Location = new System.Drawing.Point(330, 250);
            this.btnIdentAreas.Name = "btnIdentAreas";
            this.btnIdentAreas.Size = new System.Drawing.Size(230, 41);
            this.btnIdentAreas.TabIndex = 2;
            this.btnIdentAreas.Text = "Identifying Areas";
            this.btnIdentAreas.UseVisualStyleBackColor = true;
            this.btnIdentAreas.Click += new System.EventHandler(this.btnIdentAreas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(280, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose a skill to learn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(76, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(644, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Welcome to the Dewey Decimal System";
            // 
            // btnEx
            // 
            this.btnEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEx.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEx.Location = new System.Drawing.Point(841, 12);
            this.btnEx.Name = "btnEx";
            this.btnEx.Size = new System.Drawing.Size(45, 32);
            this.btnEx.TabIndex = 5;
            this.btnEx.Text = "Exit";
            this.btnEx.UseVisualStyleBackColor = true;
            this.btnEx.Click += new System.EventHandler(this.btnEx_Click);
            // 
            // Dewey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(898, 341);
            this.Controls.Add(this.btnEx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIdentAreas);
            this.Controls.Add(this.btnFinCallNums);
            this.Controls.Add(this.btnReplBook);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dewey";
            this.Text = "Dewey Decimal System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReplBook;
        private System.Windows.Forms.Button btnFinCallNums;
        private System.Windows.Forms.Button btnIdentAreas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEx;
    }
}

