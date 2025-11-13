namespace Lab_3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.output_textbox = new System.Windows.Forms.TextBox();
            this.seven_btn = new System.Windows.Forms.Button();
            this.eight_btn = new System.Windows.Forms.Button();
            this.nine_btn = new System.Windows.Forms.Button();
            this.six_btn = new System.Windows.Forms.Button();
            this.five_btn = new System.Windows.Forms.Button();
            this.four_btn = new System.Windows.Forms.Button();
            this.three_btn = new System.Windows.Forms.Button();
            this.two_btn = new System.Windows.Forms.Button();
            this.one_btn = new System.Windows.Forms.Button();
            this.equal_btn = new System.Windows.Forms.Button();
            this.zero_btn = new System.Windows.Forms.Button();
            this.comma_btn = new System.Windows.Forms.Button();
            this.plus_btn = new System.Windows.Forms.Button();
            this.minus_btn = new System.Windows.Forms.Button();
            this.multiply_btn = new System.Windows.Forms.Button();
            this.division_btn = new System.Windows.Forms.Button();
            this.pow_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.once_del_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // output_textbox
            // 
            this.output_textbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.output_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.output_textbox.Location = new System.Drawing.Point(13, 15);
            this.output_textbox.Margin = new System.Windows.Forms.Padding(0);
            this.output_textbox.Name = "output_textbox";
            this.output_textbox.Size = new System.Drawing.Size(290, 53);
            this.output_textbox.TabIndex = 0;
            this.output_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // seven_btn
            // 
            this.seven_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.seven_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seven_btn.Location = new System.Drawing.Point(13, 136);
            this.seven_btn.Name = "seven_btn";
            this.seven_btn.Size = new System.Drawing.Size(74, 47);
            this.seven_btn.TabIndex = 1;
            this.seven_btn.Text = "7";
            this.seven_btn.UseVisualStyleBackColor = false;
            this.seven_btn.Click += new System.EventHandler(this.btn_num_click);
            // 
            // eight_btn
            // 
            this.eight_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.eight_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eight_btn.Location = new System.Drawing.Point(93, 136);
            this.eight_btn.Name = "eight_btn";
            this.eight_btn.Size = new System.Drawing.Size(74, 47);
            this.eight_btn.TabIndex = 2;
            this.eight_btn.Text = "8";
            this.eight_btn.UseVisualStyleBackColor = false;
            this.eight_btn.Click += new System.EventHandler(this.btn_num_click);
            // 
            // nine_btn
            // 
            this.nine_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.nine_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nine_btn.Location = new System.Drawing.Point(173, 136);
            this.nine_btn.Name = "nine_btn";
            this.nine_btn.Size = new System.Drawing.Size(74, 47);
            this.nine_btn.TabIndex = 3;
            this.nine_btn.Text = "9";
            this.nine_btn.UseVisualStyleBackColor = false;
            this.nine_btn.Click += new System.EventHandler(this.btn_num_click);
            // 
            // six_btn
            // 
            this.six_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.six_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.six_btn.Location = new System.Drawing.Point(173, 189);
            this.six_btn.Name = "six_btn";
            this.six_btn.Size = new System.Drawing.Size(74, 47);
            this.six_btn.TabIndex = 6;
            this.six_btn.Text = "6";
            this.six_btn.UseVisualStyleBackColor = false;
            this.six_btn.Click += new System.EventHandler(this.btn_num_click);
            // 
            // five_btn
            // 
            this.five_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.five_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.five_btn.Location = new System.Drawing.Point(93, 189);
            this.five_btn.Name = "five_btn";
            this.five_btn.Size = new System.Drawing.Size(74, 47);
            this.five_btn.TabIndex = 5;
            this.five_btn.Text = "5";
            this.five_btn.UseVisualStyleBackColor = false;
            this.five_btn.Click += new System.EventHandler(this.btn_num_click);
            // 
            // four_btn
            // 
            this.four_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.four_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.four_btn.Location = new System.Drawing.Point(13, 189);
            this.four_btn.Name = "four_btn";
            this.four_btn.Size = new System.Drawing.Size(74, 47);
            this.four_btn.TabIndex = 4;
            this.four_btn.Text = "4";
            this.four_btn.UseVisualStyleBackColor = false;
            this.four_btn.Click += new System.EventHandler(this.btn_num_click);
            // 
            // three_btn
            // 
            this.three_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.three_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.three_btn.Location = new System.Drawing.Point(173, 242);
            this.three_btn.Name = "three_btn";
            this.three_btn.Size = new System.Drawing.Size(74, 47);
            this.three_btn.TabIndex = 9;
            this.three_btn.Text = "3";
            this.three_btn.UseVisualStyleBackColor = false;
            this.three_btn.Click += new System.EventHandler(this.btn_num_click);
            // 
            // two_btn
            // 
            this.two_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.two_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.two_btn.Location = new System.Drawing.Point(93, 242);
            this.two_btn.Name = "two_btn";
            this.two_btn.Size = new System.Drawing.Size(74, 47);
            this.two_btn.TabIndex = 8;
            this.two_btn.Text = "2";
            this.two_btn.UseVisualStyleBackColor = false;
            this.two_btn.Click += new System.EventHandler(this.btn_num_click);
            // 
            // one_btn
            // 
            this.one_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.one_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.one_btn.Location = new System.Drawing.Point(13, 242);
            this.one_btn.Name = "one_btn";
            this.one_btn.Size = new System.Drawing.Size(74, 47);
            this.one_btn.TabIndex = 7;
            this.one_btn.Text = "1";
            this.one_btn.UseVisualStyleBackColor = false;
            this.one_btn.Click += new System.EventHandler(this.btn_num_click);
            // 
            // equal_btn
            // 
            this.equal_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.equal_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equal_btn.Location = new System.Drawing.Point(173, 295);
            this.equal_btn.Name = "equal_btn";
            this.equal_btn.Size = new System.Drawing.Size(74, 47);
            this.equal_btn.TabIndex = 12;
            this.equal_btn.Text = "=";
            this.equal_btn.UseVisualStyleBackColor = false;
            this.equal_btn.Click += new System.EventHandler(this.btn_calculate);
            // 
            // zero_btn
            // 
            this.zero_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.zero_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zero_btn.Location = new System.Drawing.Point(93, 295);
            this.zero_btn.Name = "zero_btn";
            this.zero_btn.Size = new System.Drawing.Size(74, 47);
            this.zero_btn.TabIndex = 11;
            this.zero_btn.Text = "0";
            this.zero_btn.UseVisualStyleBackColor = false;
            this.zero_btn.Click += new System.EventHandler(this.btn_num_click);
            // 
            // comma_btn
            // 
            this.comma_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.comma_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comma_btn.Location = new System.Drawing.Point(13, 295);
            this.comma_btn.Name = "comma_btn";
            this.comma_btn.Size = new System.Drawing.Size(74, 47);
            this.comma_btn.TabIndex = 10;
            this.comma_btn.Text = ",";
            this.comma_btn.UseVisualStyleBackColor = false;
            this.comma_btn.Click += new System.EventHandler(this.btn_num_click);
            // 
            // plus_btn
            // 
            this.plus_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.plus_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus_btn.Location = new System.Drawing.Point(253, 295);
            this.plus_btn.Name = "plus_btn";
            this.plus_btn.Size = new System.Drawing.Size(50, 47);
            this.plus_btn.TabIndex = 16;
            this.plus_btn.Text = "+";
            this.plus_btn.UseVisualStyleBackColor = false;
            this.plus_btn.Click += new System.EventHandler(this.btn_action_click);
            // 
            // minus_btn
            // 
            this.minus_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.minus_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minus_btn.Location = new System.Drawing.Point(253, 242);
            this.minus_btn.Name = "minus_btn";
            this.minus_btn.Size = new System.Drawing.Size(50, 47);
            this.minus_btn.TabIndex = 15;
            this.minus_btn.Text = "-";
            this.minus_btn.UseVisualStyleBackColor = false;
            this.minus_btn.Click += new System.EventHandler(this.btn_action_click);
            // 
            // multiply_btn
            // 
            this.multiply_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.multiply_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiply_btn.Location = new System.Drawing.Point(253, 189);
            this.multiply_btn.Name = "multiply_btn";
            this.multiply_btn.Size = new System.Drawing.Size(50, 47);
            this.multiply_btn.TabIndex = 14;
            this.multiply_btn.Text = "x";
            this.multiply_btn.UseVisualStyleBackColor = false;
            this.multiply_btn.Click += new System.EventHandler(this.btn_action_click);
            // 
            // division_btn
            // 
            this.division_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.division_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.division_btn.Location = new System.Drawing.Point(253, 136);
            this.division_btn.Name = "division_btn";
            this.division_btn.Size = new System.Drawing.Size(50, 47);
            this.division_btn.TabIndex = 13;
            this.division_btn.Text = "/";
            this.division_btn.UseVisualStyleBackColor = false;
            this.division_btn.Click += new System.EventHandler(this.btn_action_click);
            // 
            // pow_btn
            // 
            this.pow_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.pow_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pow_btn.Location = new System.Drawing.Point(253, 83);
            this.pow_btn.Name = "pow_btn";
            this.pow_btn.Size = new System.Drawing.Size(50, 47);
            this.pow_btn.TabIndex = 17;
            this.pow_btn.Text = "^";
            this.pow_btn.UseVisualStyleBackColor = false;
            this.pow_btn.Click += new System.EventHandler(this.btn_action_click);
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.del_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.del_btn.Location = new System.Drawing.Point(13, 83);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(154, 47);
            this.del_btn.TabIndex = 18;
            this.del_btn.Text = "C";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.btn_delete);
            // 
            // once_del_btn
            // 
            this.once_del_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.once_del_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.once_del_btn.Location = new System.Drawing.Point(173, 83);
            this.once_del_btn.Name = "once_del_btn";
            this.once_del_btn.Size = new System.Drawing.Size(74, 47);
            this.once_del_btn.TabIndex = 19;
            this.once_del_btn.Text = "del";
            this.once_del_btn.UseVisualStyleBackColor = false;
            this.once_del_btn.Click += new System.EventHandler(this.btn_del_last);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(315, 355);
            this.Controls.Add(this.once_del_btn);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.pow_btn);
            this.Controls.Add(this.plus_btn);
            this.Controls.Add(this.minus_btn);
            this.Controls.Add(this.multiply_btn);
            this.Controls.Add(this.division_btn);
            this.Controls.Add(this.equal_btn);
            this.Controls.Add(this.zero_btn);
            this.Controls.Add(this.comma_btn);
            this.Controls.Add(this.three_btn);
            this.Controls.Add(this.two_btn);
            this.Controls.Add(this.one_btn);
            this.Controls.Add(this.six_btn);
            this.Controls.Add(this.five_btn);
            this.Controls.Add(this.four_btn);
            this.Controls.Add(this.nine_btn);
            this.Controls.Add(this.eight_btn);
            this.Controls.Add(this.seven_btn);
            this.Controls.Add(this.output_textbox);
            this.Name = "Form1";
            this.Text = "Bogdanov\'s Calcucator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox output_textbox;
        private System.Windows.Forms.Button seven_btn;
        private System.Windows.Forms.Button eight_btn;
        private System.Windows.Forms.Button nine_btn;
        private System.Windows.Forms.Button six_btn;
        private System.Windows.Forms.Button five_btn;
        private System.Windows.Forms.Button four_btn;
        private System.Windows.Forms.Button three_btn;
        private System.Windows.Forms.Button two_btn;
        private System.Windows.Forms.Button one_btn;
        private System.Windows.Forms.Button equal_btn;
        private System.Windows.Forms.Button zero_btn;
        private System.Windows.Forms.Button comma_btn;
        private System.Windows.Forms.Button plus_btn;
        private System.Windows.Forms.Button minus_btn;
        private System.Windows.Forms.Button multiply_btn;
        private System.Windows.Forms.Button division_btn;
        private System.Windows.Forms.Button pow_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button once_del_btn;
    }
}

