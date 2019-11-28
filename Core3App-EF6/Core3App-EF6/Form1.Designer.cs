namespace Core3App_EF6
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EF6buttonAdd = new System.Windows.Forms.Button();
            this.EF6buttonGetBlogsCount = new System.Windows.Forms.Button();
            this.EF6QueryButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.EF6buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))),
                ((int) (((byte) (153)))), ((int) (((byte) (153)))));
            this.EF6buttonAdd.Location = new System.Drawing.Point(50, 98);
            this.EF6buttonAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EF6buttonAdd.Name = "EF6buttonAdd";
            this.EF6buttonAdd.Size = new System.Drawing.Size(195, 35);
            this.EF6buttonAdd.TabIndex = 0;
            this.EF6buttonAdd.Text = "EF6 - Add new Blog";
            this.EF6buttonAdd.UseVisualStyleBackColor = false;
            this.EF6buttonAdd.Click += new System.EventHandler(this.EF6buttonAdd_Click);
            this.EF6buttonGetBlogsCount.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))),
                ((int) (((byte) (153)))), ((int) (((byte) (153)))));
            this.EF6buttonGetBlogsCount.Location = new System.Drawing.Point(50, 156);
            this.EF6buttonGetBlogsCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EF6buttonGetBlogsCount.Name = "EF6buttonGetBlogsCount";
            this.EF6buttonGetBlogsCount.Size = new System.Drawing.Size(195, 35);
            this.EF6buttonGetBlogsCount.TabIndex = 1;
            this.EF6buttonGetBlogsCount.Text = "EF6 - Get Blogs Count";
            this.EF6buttonGetBlogsCount.UseVisualStyleBackColor = false;
            this.EF6buttonGetBlogsCount.Click += new System.EventHandler(this.EF6buttonGetBlogsCount_Click);
            this.EF6QueryButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))),
                ((int) (((byte) (153)))), ((int) (((byte) (153)))));
            this.EF6QueryButton.Location = new System.Drawing.Point(50, 213);
            this.EF6QueryButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EF6QueryButton.Name = "EF6QueryButton";
            this.EF6QueryButton.Size = new System.Drawing.Size(195, 35);
            this.EF6QueryButton.TabIndex = 2;
            this.EF6QueryButton.Text = "EF6 - Query";
            this.EF6QueryButton.UseVisualStyleBackColor = false;
            this.EF6QueryButton.Click += new System.EventHandler(this.EF6QueryButton_Click);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(67, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "EF 6.4 + Core3";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (204)))),
                ((int) (((byte) (204)))));
            this.ClientSize = new System.Drawing.Size(299, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EF6QueryButton);
            this.Controls.Add(this.EF6buttonGetBlogsCount);
            this.Controls.Add(this.EF6buttonAdd);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button EF6buttonAdd;
        private System.Windows.Forms.Button EF6buttonGetBlogsCount;
        private System.Windows.Forms.Button EF6QueryButton;
        private System.Windows.Forms.Label label1;
    }
}