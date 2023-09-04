
namespace CounterApplication
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
            this.components = new System.ComponentModel.Container();
            this.counterText_lbl = new System.Windows.Forms.Label();
            this.delay_txtbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.count_txtbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.count_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // counterText_lbl
            // 
            this.counterText_lbl.AutoSize = true;
            this.counterText_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterText_lbl.Location = new System.Drawing.Point(41, 75);
            this.counterText_lbl.Name = "counterText_lbl";
            this.counterText_lbl.Size = new System.Drawing.Size(69, 73);
            this.counterText_lbl.TabIndex = 0;
            this.counterText_lbl.Text = "0";
            // 
            // delay_txtbx
            // 
            this.delay_txtbx.Location = new System.Drawing.Point(259, 61);
            this.delay_txtbx.Name = "delay_txtbx";
            this.delay_txtbx.Size = new System.Drawing.Size(110, 20);
            this.delay_txtbx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time Delay";
            // 
            // count_txtbx
            // 
            this.count_txtbx.Location = new System.Drawing.Point(259, 87);
            this.count_txtbx.Name = "count_txtbx";
            this.count_txtbx.Size = new System.Drawing.Size(110, 20);
            this.count_txtbx.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Count Limit";
            // 
            // count_btn
            // 
            this.count_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count_btn.Location = new System.Drawing.Point(281, 123);
            this.count_btn.Name = "count_btn";
            this.count_btn.Size = new System.Drawing.Size(88, 34);
            this.count_btn.TabIndex = 5;
            this.count_btn.Text = "Count";
            this.count_btn.UseVisualStyleBackColor = true;
            this.count_btn.Click += new System.EventHandler(this.count_btn_ClickAsync);
            // 
            // reset_btn
            // 
            this.reset_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.Location = new System.Drawing.Point(168, 123);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(88, 34);
            this.reset_btn.TabIndex = 6;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 225);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.count_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.count_txtbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delay_txtbx);
            this.Controls.Add(this.counterText_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Counter Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label counterText_lbl;
        private System.Windows.Forms.TextBox delay_txtbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox count_txtbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button count_btn;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Timer timer;
    }
}

