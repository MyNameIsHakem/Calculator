
namespace First_Windows_Forms_App
{
    partial class Box
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
            this.PromptUserToWrite = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_result = new System.Windows.Forms.Button();
            this.btn_comma = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_plusOrmines = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_mines = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_rest = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ResultDisplayer = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PromptUserToWrite
            // 
            this.PromptUserToWrite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PromptUserToWrite.BackColor = System.Drawing.Color.White;
            this.PromptUserToWrite.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PromptUserToWrite.Location = new System.Drawing.Point(78, 18);
            this.PromptUserToWrite.Name = "PromptUserToWrite";
            this.PromptUserToWrite.Size = new System.Drawing.Size(285, 22);
            this.PromptUserToWrite.TabIndex = 3;
            this.PromptUserToWrite.Text = "Please Write here your single Operated calculation  : ";
            this.PromptUserToWrite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(95, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "The result is gonna be displayed here :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btn_C, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_result, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_comma, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_0, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_plusOrmines, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_plus, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_mines, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_multiply, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_9, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_divide, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_rest, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Back, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(33, 132);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(370, 264);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // btn_C
            // 
            this.btn_C.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_C.Location = new System.Drawing.Point(95, 3);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(86, 46);
            this.btn_C.TabIndex = 21;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = true;
            this.btn_C.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_result
            // 
            this.btn_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_result.Location = new System.Drawing.Point(279, 211);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(88, 50);
            this.btn_result.TabIndex = 19;
            this.btn_result.Text = "=";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btn_comma
            // 
            this.btn_comma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_comma.Location = new System.Drawing.Point(187, 211);
            this.btn_comma.Name = "btn_comma";
            this.btn_comma.Size = new System.Drawing.Size(86, 50);
            this.btn_comma.TabIndex = 18;
            this.btn_comma.Text = ",";
            this.btn_comma.UseVisualStyleBackColor = true;
            this.btn_comma.Click += new System.EventHandler(this.btn_comma_Click);
            // 
            // btn_0
            // 
            this.btn_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_0.Location = new System.Drawing.Point(95, 211);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(86, 50);
            this.btn_0.TabIndex = 17;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_plusOrmines
            // 
            this.btn_plusOrmines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_plusOrmines.Location = new System.Drawing.Point(3, 211);
            this.btn_plusOrmines.Name = "btn_plusOrmines";
            this.btn_plusOrmines.Size = new System.Drawing.Size(86, 50);
            this.btn_plusOrmines.TabIndex = 16;
            this.btn_plusOrmines.Text = "BackWard";
            this.btn_plusOrmines.UseVisualStyleBackColor = true;
            this.btn_plusOrmines.Click += new System.EventHandler(this.BackWard);
            // 
            // btn_plus
            // 
            this.btn_plus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_plus.Location = new System.Drawing.Point(279, 159);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(88, 46);
            this.btn_plus.TabIndex = 15;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btn_3
            // 
            this.btn_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_3.Location = new System.Drawing.Point(187, 159);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(86, 46);
            this.btn_3.TabIndex = 14;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_2
            // 
            this.btn_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_2.Location = new System.Drawing.Point(95, 159);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(86, 46);
            this.btn_2.TabIndex = 13;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_1
            // 
            this.btn_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_1.Location = new System.Drawing.Point(3, 159);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(86, 46);
            this.btn_1.TabIndex = 12;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_mines
            // 
            this.btn_mines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_mines.Location = new System.Drawing.Point(279, 107);
            this.btn_mines.Name = "btn_mines";
            this.btn_mines.Size = new System.Drawing.Size(88, 46);
            this.btn_mines.TabIndex = 11;
            this.btn_mines.Text = "-";
            this.btn_mines.UseVisualStyleBackColor = true;
            this.btn_mines.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btn_6
            // 
            this.btn_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_6.Location = new System.Drawing.Point(187, 107);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(86, 46);
            this.btn_6.TabIndex = 10;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_5
            // 
            this.btn_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_5.Location = new System.Drawing.Point(95, 107);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(86, 46);
            this.btn_5.TabIndex = 9;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_4
            // 
            this.btn_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_4.Location = new System.Drawing.Point(3, 107);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(86, 46);
            this.btn_4.TabIndex = 8;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_multiply
            // 
            this.btn_multiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_multiply.Location = new System.Drawing.Point(279, 55);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(88, 46);
            this.btn_multiply.TabIndex = 7;
            this.btn_multiply.Text = "*";
            this.btn_multiply.UseVisualStyleBackColor = true;
            this.btn_multiply.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btn_9
            // 
            this.btn_9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_9.Location = new System.Drawing.Point(187, 55);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(86, 46);
            this.btn_9.TabIndex = 6;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_7
            // 
            this.btn_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_7.Location = new System.Drawing.Point(3, 55);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(86, 46);
            this.btn_7.TabIndex = 4;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_divide.Location = new System.Drawing.Point(279, 3);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(88, 46);
            this.btn_divide.TabIndex = 3;
            this.btn_divide.Text = "/";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btn_rest
            // 
            this.btn_rest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_rest.Location = new System.Drawing.Point(187, 3);
            this.btn_rest.Name = "btn_rest";
            this.btn_rest.Size = new System.Drawing.Size(86, 46);
            this.btn_rest.TabIndex = 2;
            this.btn_rest.Text = "( )";
            this.btn_rest.UseVisualStyleBackColor = true;
            this.btn_rest.Click += new System.EventHandler(this.ParentTheSize);
            // 
            // btn_Back
            // 
            this.btn_Back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Back.Location = new System.Drawing.Point(3, 3);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(86, 46);
            this.btn_Back.TabIndex = 20;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(95, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 46);
            this.button1.TabIndex = 22;
            this.button1.Text = "8";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ResultDisplayer
            // 
            this.ResultDisplayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultDisplayer.Location = new System.Drawing.Point(36, 101);
            this.ResultDisplayer.Name = "ResultDisplayer";
            this.ResultDisplayer.Size = new System.Drawing.Size(364, 23);
            this.ResultDisplayer.TabIndex = 6;
            this.ResultDisplayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(26, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(391, 23);
            this.textBox1.TabIndex = 7;
            // 
            // Box
            // 
            this.AcceptButton = this.btn_result;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(429, 415);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ResultDisplayer);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PromptUserToWrite);
            this.MinimumSize = new System.Drawing.Size(445, 454);
            this.Name = "Box";
            this.Text = "My First App";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PromptUserToWrite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.Button btn_comma;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_plusOrmines;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_mines;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_rest;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label ResultDisplayer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

