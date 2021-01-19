using System;
using System.Windows.Forms;
namespace DataTerminalProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartAppBtn = new System.Windows.Forms.Button();
            this.RestartBtn = new System.Windows.Forms.Button();
            this.ShutDownBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartAppBtn
            // 
            this.StartAppBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(74)))), ((int)(((byte)(81)))));
            this.StartAppBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartAppBtn.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartAppBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.StartAppBtn.Location = new System.Drawing.Point(160, 40);
            this.StartAppBtn.Name = "StartAppBtn";
            this.StartAppBtn.Size = new System.Drawing.Size(300, 80);
            this.StartAppBtn.TabIndex = 0;
            this.StartAppBtn.Text = "Start DataTerminal";
            this.StartAppBtn.UseVisualStyleBackColor = false;
            this.StartAppBtn.Click += new System.EventHandler(this.StartAppBtn_Click);
            // 
            // RestartBtn
            // 
            this.RestartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(74)))), ((int)(((byte)(81)))));
            this.RestartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestartBtn.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RestartBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.RestartBtn.Location = new System.Drawing.Point(160, 160);
            this.RestartBtn.Name = "RestartBtn";
            this.RestartBtn.Size = new System.Drawing.Size(300, 80);
            this.RestartBtn.TabIndex = 1;
            this.RestartBtn.Text = "Restart";
            this.RestartBtn.UseVisualStyleBackColor = false;
            this.RestartBtn.Click += new System.EventHandler(this.RestartBtn_Click);
            // 
            // ShutDownBtn
            // 
            this.ShutDownBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(74)))), ((int)(((byte)(81)))));
            this.ShutDownBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShutDownBtn.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShutDownBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.ShutDownBtn.Location = new System.Drawing.Point(160, 290);
            this.ShutDownBtn.Name = "ShutDownBtn";
            this.ShutDownBtn.Size = new System.Drawing.Size(300, 80);
            this.ShutDownBtn.TabIndex = 2;
            this.ShutDownBtn.Text = "ShutDown";
            this.ShutDownBtn.UseVisualStyleBackColor = false;
            this.ShutDownBtn.Click += new System.EventHandler(this.ShutDownBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(618, 424);
            this.Controls.Add(this.ShutDownBtn);
            this.Controls.Add(this.RestartBtn);
            this.Controls.Add(this.StartAppBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DTRunner";
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button StartAppBtn;
        private System.Windows.Forms.Button RestartBtn;
        private System.Windows.Forms.Button ShutDownBtn;


        //remove the entire system menu:
        private const int WS_SYSMENU = 0x80000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~WS_SYSMENU;
                return cp;
            }
        }
    }

}

