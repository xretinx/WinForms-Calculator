
using System.Globalization;

namespace Kalkulator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_7 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_multiply = new System.Windows.Forms.Button();
            this.button_divide = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_equal = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_comma = new System.Windows.Forms.Button();
            this.button_C = new System.Windows.Forms.Button();
            this.textBox_equation = new System.Windows.Forms.TextBox();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.button_del = new System.Windows.Forms.Button();
            this.textBox_history = new System.Windows.Forms.TextBox();
            this.button_signChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_7
            // 
            this.button_7.Location = new System.Drawing.Point(4, 111);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(97, 56);
            this.button_7.TabIndex = 0;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.button_Number_Click);
            // 
            // button_8
            // 
            this.button_8.Location = new System.Drawing.Point(107, 111);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(98, 56);
            this.button_8.TabIndex = 1;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.button_Number_Click);
            // 
            // button_9
            // 
            this.button_9.Location = new System.Drawing.Point(212, 111);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(98, 56);
            this.button_9.TabIndex = 2;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.button_Number_Click);
            // 
            // button_4
            // 
            this.button_4.Location = new System.Drawing.Point(4, 173);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(98, 56);
            this.button_4.TabIndex = 3;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.button_Number_Click);
            // 
            // button_5
            // 
            this.button_5.Location = new System.Drawing.Point(107, 173);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(98, 56);
            this.button_5.TabIndex = 4;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.button_Number_Click);
            // 
            // button_6
            // 
            this.button_6.Location = new System.Drawing.Point(212, 173);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(98, 56);
            this.button_6.TabIndex = 5;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.button_Number_Click);
            // 
            // button_1
            // 
            this.button_1.Location = new System.Drawing.Point(4, 236);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(98, 56);
            this.button_1.TabIndex = 6;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_Number_Click);
            // 
            // button_2
            // 
            this.button_2.Location = new System.Drawing.Point(107, 236);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(98, 56);
            this.button_2.TabIndex = 7;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button_Number_Click);
            // 
            // button_3
            // 
            this.button_3.Location = new System.Drawing.Point(212, 236);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(98, 56);
            this.button_3.TabIndex = 8;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.button_Number_Click);
            // 
            // button_0
            // 
            this.button_0.Location = new System.Drawing.Point(107, 297);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(98, 56);
            this.button_0.TabIndex = 9;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.button_Number_Click);
            // 
            // button_multiply
            // 
            this.button_multiply.Location = new System.Drawing.Point(316, 173);
            this.button_multiply.Name = "button_multiply";
            this.button_multiply.Size = new System.Drawing.Size(98, 56);
            this.button_multiply.TabIndex = 10;
            this.button_multiply.Text = "×";
            this.button_multiply.UseVisualStyleBackColor = true;
            this.button_multiply.Click += new System.EventHandler(this.button_multiply_Click);
            // 
            // button_divide
            // 
            this.button_divide.Location = new System.Drawing.Point(316, 111);
            this.button_divide.Name = "button_divide";
            this.button_divide.Size = new System.Drawing.Size(98, 56);
            this.button_divide.TabIndex = 11;
            this.button_divide.Text = "÷";
            this.button_divide.UseVisualStyleBackColor = true;
            this.button_divide.Click += new System.EventHandler(this.button_divide_Click);
            // 
            // button_minus
            // 
            this.button_minus.Location = new System.Drawing.Point(316, 236);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(98, 56);
            this.button_minus.TabIndex = 12;
            this.button_minus.Text = "−";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_equal
            // 
            this.button_equal.Location = new System.Drawing.Point(419, 236);
            this.button_equal.Name = "button_equal";
            this.button_equal.Size = new System.Drawing.Size(66, 118);
            this.button_equal.TabIndex = 13;
            this.button_equal.Text = "=";
            this.button_equal.UseVisualStyleBackColor = true;
            this.button_equal.Click += new System.EventHandler(this.button_equal_Click);
            // 
            // button_plus
            // 
            this.button_plus.Location = new System.Drawing.Point(316, 297);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(98, 56);
            this.button_plus.TabIndex = 14;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_comma
            // 
            this.button_comma.Location = new System.Drawing.Point(212, 297);
            this.button_comma.Name = "button_comma";
            this.button_comma.Size = new System.Drawing.Size(98, 56);
            this.button_comma.TabIndex = 15;
            this.button_comma.Text = ((System.Globalization.NumberFormatInfo)(resources.GetObject("resource1"))).NumberDecimalSeparator;
            this.button_comma.UseVisualStyleBackColor = true;
            this.button_comma.Click += new System.EventHandler(this.button_comma_Click);
            // 
            // button_C
            // 
            this.button_C.Location = new System.Drawing.Point(419, 112);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(66, 55);
            this.button_C.TabIndex = 16;
            this.button_C.Text = "C";
            this.button_C.UseVisualStyleBackColor = true;
            this.button_C.Click += new System.EventHandler(this.button_C_Click);
            // 
            // textBox_equation
            // 
            this.textBox_equation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_equation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_equation.Location = new System.Drawing.Point(14, 41);
            this.textBox_equation.Name = "textBox_equation";
            this.textBox_equation.Size = new System.Drawing.Size(472, 28);
            this.textBox_equation.TabIndex = 17;
            this.textBox_equation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_equation.TextChanged += new System.EventHandler(this.textBox_equation_TextChanged);
            // 
            // textBox_result
            // 
            this.textBox_result.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_result.Location = new System.Drawing.Point(157, 82);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(329, 19);
            this.textBox_result.TabIndex = 0;
            this.textBox_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_result.TextChanged += new System.EventHandler(this.textBox_result_TextChanged);
            // 
            // button_del
            // 
            this.button_del.Location = new System.Drawing.Point(421, 174);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(65, 55);
            this.button_del.TabIndex = 18;
            this.button_del.Text = "⌫";
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // textBox_history
            // 
            this.textBox_history.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_history.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_history.Location = new System.Drawing.Point(14, 12);
            this.textBox_history.Name = "textBox_history";
            this.textBox_history.Size = new System.Drawing.Size(471, 19);
            this.textBox_history.TabIndex = 19;
            this.textBox_history.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_history.TextChanged += new System.EventHandler(this.textBox_history_TextChanged);
            // 
            // button_signChange
            // 
            this.button_signChange.Location = new System.Drawing.Point(4, 298);
            this.button_signChange.Name = "button_signChange";
            this.button_signChange.Size = new System.Drawing.Size(98, 55);
            this.button_signChange.TabIndex = 20;
            this.button_signChange.Text = "-/+";
            this.button_signChange.UseVisualStyleBackColor = true;
            this.button_signChange.Click += new System.EventHandler(this.button_signChange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(488, 358);
            this.Controls.Add(this.button_signChange);
            this.Controls.Add(this.textBox_history);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.textBox_equation);
            this.Controls.Add(this.button_C);
            this.Controls.Add(this.button_comma);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.button_equal);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_divide);
            this.Controls.Add(this.button_multiply);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_multiply;
        private System.Windows.Forms.Button button_divide;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_equal;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_comma;
        private System.Windows.Forms.Button button_C;
        private System.Windows.Forms.TextBox textBox_equation;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.TextBox textBox_history;
        private System.Windows.Forms.Button button_signChange;
    }
}

