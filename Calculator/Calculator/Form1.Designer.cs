namespace Calculator
{
    partial class window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(window));
            this.toptext = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // toptext
            // 
            this.toptext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.toptext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toptext.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toptext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(127)))), ((int)(((byte)(139)))));
            this.toptext.Location = new System.Drawing.Point(0, 15);
            this.toptext.Name = "toptext";
            this.toptext.ReadOnly = true;
            this.toptext.ShortcutsEnabled = false;
            this.toptext.Size = new System.Drawing.Size(334, 30);
            this.toptext.TabIndex = 1;
            this.toptext.TabStop = false;
            this.toptext.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clear.Location = new System.Drawing.Point(0, 126);
            this.clear.Margin = new System.Windows.Forms.Padding(0);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(85, 85);
            this.clear.TabIndex = 2;
            this.clear.TabStop = false;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.allclear_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(219)))), ((int)(((byte)(221)))));
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.delete.Location = new System.Drawing.Point(84, 126);
            this.delete.Margin = new System.Windows.Forms.Padding(0);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(85, 85);
            this.delete.TabIndex = 3;
            this.delete.TabStop = false;
            this.delete.Text = "DEL";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // percent
            // 
            this.percent.BackColor = System.Drawing.Color.LightGray;
            this.percent.FlatAppearance.BorderSize = 0;
            this.percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.percent.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.percent.Location = new System.Drawing.Point(168, 126);
            this.percent.Margin = new System.Windows.Forms.Padding(0);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(85, 85);
            this.percent.TabIndex = 4;
            this.percent.TabStop = false;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = false;
            this.percent.Click += new System.EventHandler(this.percent_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(78)))), ((int)(((byte)(220)))));
            this.divide.FlatAppearance.BorderSize = 0;
            this.divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divide.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.ForeColor = System.Drawing.SystemColors.ControlText;
            this.divide.Location = new System.Drawing.Point(253, 126);
            this.divide.Margin = new System.Windows.Forms.Padding(0);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(85, 85);
            this.divide.TabIndex = 5;
            this.divide.TabStop = false;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(78)))), ((int)(((byte)(220)))));
            this.multiply.FlatAppearance.BorderSize = 0;
            this.multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiply.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.ForeColor = System.Drawing.SystemColors.ControlText;
            this.multiply.Location = new System.Drawing.Point(253, 211);
            this.multiply.Margin = new System.Windows.Forms.Padding(0);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(85, 85);
            this.multiply.TabIndex = 9;
            this.multiply.TabStop = false;
            this.multiply.Text = "×";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // num9
            // 
            this.num9.BackColor = System.Drawing.Color.LightGray;
            this.num9.FlatAppearance.BorderSize = 0;
            this.num9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num9.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num9.Location = new System.Drawing.Point(168, 211);
            this.num9.Margin = new System.Windows.Forms.Padding(0);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(85, 85);
            this.num9.TabIndex = 8;
            this.num9.TabStop = false;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = false;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // num8
            // 
            this.num8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(219)))), ((int)(((byte)(221)))));
            this.num8.FlatAppearance.BorderSize = 0;
            this.num8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num8.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num8.Location = new System.Drawing.Point(84, 211);
            this.num8.Margin = new System.Windows.Forms.Padding(0);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(85, 85);
            this.num8.TabIndex = 7;
            this.num8.TabStop = false;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = false;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num7
            // 
            this.num7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.num7.FlatAppearance.BorderSize = 0;
            this.num7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num7.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num7.Location = new System.Drawing.Point(0, 211);
            this.num7.Margin = new System.Windows.Forms.Padding(0);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(85, 85);
            this.num7.TabIndex = 6;
            this.num7.TabStop = false;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = false;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(78)))), ((int)(((byte)(220)))));
            this.minus.FlatAppearance.BorderSize = 0;
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.minus.Location = new System.Drawing.Point(253, 296);
            this.minus.Margin = new System.Windows.Forms.Padding(0);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(85, 85);
            this.minus.TabIndex = 13;
            this.minus.TabStop = false;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.Color.LightGray;
            this.num6.FlatAppearance.BorderSize = 0;
            this.num6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num6.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num6.Location = new System.Drawing.Point(168, 296);
            this.num6.Margin = new System.Windows.Forms.Padding(0);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(85, 85);
            this.num6.TabIndex = 12;
            this.num6.TabStop = false;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = false;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(219)))), ((int)(((byte)(221)))));
            this.num5.FlatAppearance.BorderSize = 0;
            this.num5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num5.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num5.Location = new System.Drawing.Point(84, 296);
            this.num5.Margin = new System.Windows.Forms.Padding(0);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(85, 85);
            this.num5.TabIndex = 11;
            this.num5.TabStop = false;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = false;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.num4.FlatAppearance.BorderSize = 0;
            this.num4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num4.Location = new System.Drawing.Point(0, 296);
            this.num4.Margin = new System.Windows.Forms.Padding(0);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(85, 85);
            this.num4.TabIndex = 10;
            this.num4.TabStop = false;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = false;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // point
            // 
            this.point.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(219)))), ((int)(((byte)(221)))));
            this.point.FlatAppearance.BorderSize = 0;
            this.point.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.point.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point.ForeColor = System.Drawing.SystemColors.ControlText;
            this.point.Location = new System.Drawing.Point(84, 466);
            this.point.Margin = new System.Windows.Forms.Padding(0);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(85, 85);
            this.point.TabIndex = 15;
            this.point.TabStop = false;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = false;
            this.point.Click += new System.EventHandler(this.point_Click);
            // 
            // num0
            // 
            this.num0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.num0.FlatAppearance.BorderSize = 0;
            this.num0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num0.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num0.Location = new System.Drawing.Point(0, 466);
            this.num0.Margin = new System.Windows.Forms.Padding(0);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(85, 85);
            this.num0.TabIndex = 14;
            this.num0.TabStop = false;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = false;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(47)))), ((int)(((byte)(135)))));
            this.equals.FlatAppearance.BorderSize = 0;
            this.equals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equals.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals.ForeColor = System.Drawing.Color.White;
            this.equals.Location = new System.Drawing.Point(169, 466);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(169, 85);
            this.equals.TabIndex = 16;
            this.equals.TabStop = false;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(78)))), ((int)(((byte)(220)))));
            this.plus.FlatAppearance.BorderSize = 0;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.plus.Location = new System.Drawing.Point(253, 381);
            this.plus.Margin = new System.Windows.Forms.Padding(0);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(85, 85);
            this.plus.TabIndex = 20;
            this.plus.TabStop = false;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.Color.LightGray;
            this.num1.Cursor = System.Windows.Forms.Cursors.Default;
            this.num1.FlatAppearance.BorderSize = 0;
            this.num1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num1.Location = new System.Drawing.Point(168, 381);
            this.num1.Margin = new System.Windows.Forms.Padding(0);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(85, 85);
            this.num1.TabIndex = 19;
            this.num1.TabStop = false;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = false;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(219)))), ((int)(((byte)(221)))));
            this.num2.FlatAppearance.BorderSize = 0;
            this.num2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num2.Location = new System.Drawing.Point(84, 381);
            this.num2.Margin = new System.Windows.Forms.Padding(0);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(85, 85);
            this.num2.TabIndex = 18;
            this.num2.TabStop = false;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = false;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.num3.FlatAppearance.BorderSize = 0;
            this.num3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num3.Location = new System.Drawing.Point(0, 381);
            this.num3.Margin = new System.Windows.Forms.Padding(0);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(85, 85);
            this.num3.TabIndex = 17;
            this.num3.TabStop = false;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = false;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.display.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.ForeColor = System.Drawing.Color.White;
            this.display.Location = new System.Drawing.Point(0, 53);
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.display.Size = new System.Drawing.Size(340, 59);
            this.display.TabIndex = 0;
            this.display.Text = "0";
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.display.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
            this.display.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keypressed);
            this.display.Leave += new System.EventHandler(this.nofocus);
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(338, 551);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.point);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.toptext);
            this.Controls.Add(this.display);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(354, 590);
            this.Name = "window";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.win_load);
            this.Resize += new System.EventHandler(this.resized);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox toptext;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button percent;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.TextBox display;

    }
}

