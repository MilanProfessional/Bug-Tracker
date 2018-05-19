﻿namespace Bug_Tracker.Views
{
    partial class Bugs
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
            this.panelBugs = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAssigned = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelBugs.SuspendLayout();
            this.panelAssigned.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBugs
            // 
            this.panelBugs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelBugs.Controls.Add(this.label1);
            this.panelBugs.ForeColor = System.Drawing.SystemColors.Window;
            this.panelBugs.Location = new System.Drawing.Point(2, 1);
            this.panelBugs.Name = "panelBugs";
            this.panelBugs.Size = new System.Drawing.Size(561, 567);
            this.panelBugs.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(177, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bugs List";
            // 
            // panelAssigned
            // 
            this.panelAssigned.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAssigned.Controls.Add(this.label2);
            this.panelAssigned.ForeColor = System.Drawing.SystemColors.Window;
            this.panelAssigned.Location = new System.Drawing.Point(569, 1);
            this.panelAssigned.Name = "panelAssigned";
            this.panelAssigned.Size = new System.Drawing.Size(508, 567);
            this.panelAssigned.TabIndex = 1;
            this.panelAssigned.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAssigned_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(188, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Work.";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1082, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1082, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Bugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1169, 616);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panelAssigned);
            this.Controls.Add(this.panelBugs);
            this.Name = "Bugs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bugs";
            this.Load += new System.EventHandler(this.Bugs_Load);
            this.panelBugs.ResumeLayout(false);
            this.panelBugs.PerformLayout();
            this.panelAssigned.ResumeLayout(false);
            this.panelAssigned.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBugs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelAssigned;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}