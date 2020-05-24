namespace InformaticGirlfriendQuestion
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Button SI;
        private System.Windows.Forms.Button NO;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Question = new System.Windows.Forms.Label();
            this.SI = new System.Windows.Forms.Button();
            this.NO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Font = new System.Drawing.Font("Lucida Handwriting", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question.Location = new System.Drawing.Point(228, 112);
            this.Question.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(581, 55);
            this.Question.TabIndex = 0;
            this.Question.Text = "¿Quieres ser mi novia?";
            this.Question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SI
            // 
            this.SI.BackColor = System.Drawing.Color.Red;
            this.SI.FlatAppearance.BorderSize = 0;
            this.SI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SI.Font = new System.Drawing.Font("Calibri Light", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SI.ForeColor = System.Drawing.Color.White;
            this.SI.Location = new System.Drawing.Point(342, 295);
            this.SI.Margin = new System.Windows.Forms.Padding(4);
            this.SI.Name = "SI";
            this.SI.Size = new System.Drawing.Size(107, 74);
            this.SI.TabIndex = 1;
            this.SI.TabStop = false;
            this.SI.Text = "SI";
            this.SI.UseVisualStyleBackColor = false;
            this.SI.Click += new System.EventHandler(this.SI_Click);
            // 
            // NO
            // 
            this.NO.BackColor = System.Drawing.Color.Red;
            this.NO.FlatAppearance.BorderSize = 0;
            this.NO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NO.Font = new System.Drawing.Font("Calibri Light", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NO.ForeColor = System.Drawing.Color.White;
            this.NO.Location = new System.Drawing.Point(597, 295);
            this.NO.Margin = new System.Windows.Forms.Padding(4);
            this.NO.Name = "NO";
            this.NO.Size = new System.Drawing.Size(107, 74);
            this.NO.TabIndex = 1;
            this.NO.TabStop = false;
            this.NO.Text = "NO";
            this.NO.UseVisualStyleBackColor = false;
            this.NO.MouseEnter += new System.EventHandler(this.NO_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1000, 534);
            this.Controls.Add(this.NO);
            this.Controls.Add(this.SI);
            this.Controls.Add(this.Question);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "🙈";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

