﻿namespace HomemadeCalculator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.oneKey = new System.Windows.Forms.Button();
            this.twoKey = new System.Windows.Forms.Button();
            this.threeKey = new System.Windows.Forms.Button();
            this.fourKey = new System.Windows.Forms.Button();
            this.fiveKey = new System.Windows.Forms.Button();
            this.sixKey = new System.Windows.Forms.Button();
            this.sevenKey = new System.Windows.Forms.Button();
            this.eightKey = new System.Windows.Forms.Button();
            this.nineKey = new System.Windows.Forms.Button();
            this.zeroKey = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.evalKey = new System.Windows.Forms.Button();
            this.squareKey = new System.Windows.Forms.Button();
            this.clearKey = new System.Windows.Forms.Button();
            this.sqrtKey = new System.Windows.Forms.Button();
            this.divKey = new System.Windows.Forms.Button();
            this.multiKey = new System.Windows.Forms.Button();
            this.minusKey = new System.Windows.Forms.Button();
            this.plusKey = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.03799F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.96201F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(744, 555);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox1, 2);
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(738, 152);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // oneKey
            // 
            this.oneKey.AutoSize = true;
            this.oneKey.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.oneKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oneKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneKey.Location = new System.Drawing.Point(3, 3);
            this.oneKey.Name = "oneKey";
            this.oneKey.Size = new System.Drawing.Size(101, 91);
            this.oneKey.TabIndex = 0;
            this.oneKey.Text = "1";
            this.oneKey.UseVisualStyleBackColor = true;
            this.oneKey.Click += new System.EventHandler(this.oneKey_Click);
            // 
            // twoKey
            // 
            this.twoKey.AutoSize = true;
            this.twoKey.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.twoKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.twoKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoKey.Location = new System.Drawing.Point(110, 3);
            this.twoKey.Name = "twoKey";
            this.twoKey.Size = new System.Drawing.Size(101, 91);
            this.twoKey.TabIndex = 1;
            this.twoKey.Text = "2";
            this.twoKey.UseVisualStyleBackColor = true;
            this.twoKey.Click += new System.EventHandler(this.twoKey_Click);
            // 
            // threeKey
            // 
            this.threeKey.AutoSize = true;
            this.threeKey.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.threeKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.threeKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeKey.Location = new System.Drawing.Point(217, 3);
            this.threeKey.Name = "threeKey";
            this.threeKey.Size = new System.Drawing.Size(102, 91);
            this.threeKey.TabIndex = 2;
            this.threeKey.Text = "3";
            this.threeKey.UseVisualStyleBackColor = true;
            this.threeKey.Click += new System.EventHandler(this.threeKey_Click);
            // 
            // fourKey
            // 
            this.fourKey.AutoSize = true;
            this.fourKey.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fourKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fourKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourKey.Location = new System.Drawing.Point(3, 100);
            this.fourKey.Name = "fourKey";
            this.fourKey.Size = new System.Drawing.Size(101, 91);
            this.fourKey.TabIndex = 3;
            this.fourKey.Text = "4";
            this.fourKey.UseVisualStyleBackColor = true;
            this.fourKey.Click += new System.EventHandler(this.fourKey_Click);
            // 
            // fiveKey
            // 
            this.fiveKey.AutoSize = true;
            this.fiveKey.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fiveKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fiveKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveKey.Location = new System.Drawing.Point(110, 100);
            this.fiveKey.Name = "fiveKey";
            this.fiveKey.Size = new System.Drawing.Size(101, 91);
            this.fiveKey.TabIndex = 4;
            this.fiveKey.Text = "5";
            this.fiveKey.UseVisualStyleBackColor = true;
            this.fiveKey.Click += new System.EventHandler(this.fiveKey_Click);
            // 
            // sixKey
            // 
            this.sixKey.AutoSize = true;
            this.sixKey.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sixKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sixKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixKey.Location = new System.Drawing.Point(217, 100);
            this.sixKey.Name = "sixKey";
            this.sixKey.Size = new System.Drawing.Size(102, 91);
            this.sixKey.TabIndex = 5;
            this.sixKey.Text = "6";
            this.sixKey.UseVisualStyleBackColor = true;
            this.sixKey.Click += new System.EventHandler(this.sixKey_Click);
            // 
            // sevenKey
            // 
            this.sevenKey.AutoSize = true;
            this.sevenKey.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sevenKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sevenKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenKey.Location = new System.Drawing.Point(3, 197);
            this.sevenKey.Name = "sevenKey";
            this.sevenKey.Size = new System.Drawing.Size(101, 91);
            this.sevenKey.TabIndex = 6;
            this.sevenKey.Text = "7";
            this.sevenKey.UseVisualStyleBackColor = true;
            this.sevenKey.Click += new System.EventHandler(this.sevenKey_Click);
            // 
            // eightKey
            // 
            this.eightKey.AutoSize = true;
            this.eightKey.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eightKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eightKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightKey.Location = new System.Drawing.Point(110, 197);
            this.eightKey.Name = "eightKey";
            this.eightKey.Size = new System.Drawing.Size(101, 91);
            this.eightKey.TabIndex = 7;
            this.eightKey.Text = "8";
            this.eightKey.UseVisualStyleBackColor = true;
            this.eightKey.Click += new System.EventHandler(this.eightKey_Click);
            // 
            // nineKey
            // 
            this.nineKey.AutoSize = true;
            this.nineKey.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nineKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nineKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nineKey.Location = new System.Drawing.Point(217, 197);
            this.nineKey.Name = "nineKey";
            this.nineKey.Size = new System.Drawing.Size(102, 91);
            this.nineKey.TabIndex = 8;
            this.nineKey.Text = "9";
            this.nineKey.UseVisualStyleBackColor = true;
            this.nineKey.Click += new System.EventHandler(this.nineKey_Click);
            // 
            // zeroKey
            // 
            this.zeroKey.AutoSize = true;
            this.zeroKey.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.SetColumnSpan(this.zeroKey, 3);
            this.zeroKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zeroKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroKey.Location = new System.Drawing.Point(3, 294);
            this.zeroKey.Name = "zeroKey";
            this.zeroKey.Size = new System.Drawing.Size(316, 94);
            this.zeroKey.TabIndex = 9;
            this.zeroKey.Text = "0";
            this.zeroKey.UseVisualStyleBackColor = true;
            this.zeroKey.Click += new System.EventHandler(this.zeroKey_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.nineKey, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.eightKey, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.sevenKey, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.sixKey, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.fiveKey, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.twoKey, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.threeKey, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.fourKey, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.zeroKey, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.oneKey, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(419, 161);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(322, 391);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.evalKey, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.squareKey, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.clearKey, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.sqrtKey, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.divKey, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.multiKey, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.minusKey, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.plusKey, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 161);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(410, 391);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // evalKey
            // 
            this.evalKey.AutoSize = true;
            this.evalKey.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.evalKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.evalKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evalKey.Location = new System.Drawing.Point(3, 294);
            this.evalKey.Name = "evalKey";
            this.evalKey.Size = new System.Drawing.Size(199, 94);
            this.evalKey.TabIndex = 6;
            this.evalKey.Text = "=";
            this.evalKey.UseVisualStyleBackColor = true;
            // 
            // squareKey
            // 
            this.squareKey.AutoSize = true;
            this.squareKey.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.squareKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.squareKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squareKey.Location = new System.Drawing.Point(208, 197);
            this.squareKey.Name = "squareKey";
            this.squareKey.Size = new System.Drawing.Size(199, 91);
            this.squareKey.TabIndex = 4;
            this.squareKey.Text = "Square";
            this.squareKey.UseVisualStyleBackColor = true;
            // 
            // clearKey
            // 
            this.clearKey.AutoSize = true;
            this.clearKey.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clearKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearKey.Location = new System.Drawing.Point(208, 294);
            this.clearKey.Name = "clearKey";
            this.clearKey.Size = new System.Drawing.Size(199, 94);
            this.clearKey.TabIndex = 7;
            this.clearKey.Text = "Clear";
            this.clearKey.UseVisualStyleBackColor = true;
            // 
            // sqrtKey
            // 
            this.sqrtKey.AutoSize = true;
            this.sqrtKey.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sqrtKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqrtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqrtKey.Location = new System.Drawing.Point(3, 197);
            this.sqrtKey.Name = "sqrtKey";
            this.sqrtKey.Size = new System.Drawing.Size(199, 91);
            this.sqrtKey.TabIndex = 5;
            this.sqrtKey.Text = "Square Root";
            this.sqrtKey.UseVisualStyleBackColor = true;
            // 
            // divKey
            // 
            this.divKey.AutoSize = true;
            this.divKey.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.divKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divKey.Location = new System.Drawing.Point(208, 100);
            this.divKey.Name = "divKey";
            this.divKey.Size = new System.Drawing.Size(199, 91);
            this.divKey.TabIndex = 3;
            this.divKey.Text = "/";
            this.divKey.UseVisualStyleBackColor = true;
            // 
            // multiKey
            // 
            this.multiKey.AutoSize = true;
            this.multiKey.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.multiKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiKey.Location = new System.Drawing.Point(3, 100);
            this.multiKey.Name = "multiKey";
            this.multiKey.Size = new System.Drawing.Size(199, 91);
            this.multiKey.TabIndex = 2;
            this.multiKey.Text = "x";
            this.multiKey.UseVisualStyleBackColor = true;
            // 
            // minusKey
            // 
            this.minusKey.AutoSize = true;
            this.minusKey.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.minusKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minusKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusKey.Location = new System.Drawing.Point(208, 3);
            this.minusKey.Name = "minusKey";
            this.minusKey.Size = new System.Drawing.Size(199, 91);
            this.minusKey.TabIndex = 1;
            this.minusKey.Text = "-";
            this.minusKey.UseVisualStyleBackColor = true;
            // 
            // plusKey
            // 
            this.plusKey.AutoSize = true;
            this.plusKey.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.plusKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plusKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusKey.Location = new System.Drawing.Point(3, 3);
            this.plusKey.Name = "plusKey";
            this.plusKey.Size = new System.Drawing.Size(199, 91);
            this.plusKey.TabIndex = 0;
            this.plusKey.Text = "+";
            this.plusKey.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(744, 555);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "CalcuLater";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button oneKey;
        private System.Windows.Forms.Button twoKey;
        private System.Windows.Forms.Button threeKey;
        private System.Windows.Forms.Button fourKey;
        private System.Windows.Forms.Button fiveKey;
        private System.Windows.Forms.Button sixKey;
        private System.Windows.Forms.Button sevenKey;
        private System.Windows.Forms.Button eightKey;
        private System.Windows.Forms.Button nineKey;
        private System.Windows.Forms.Button zeroKey;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button evalKey;
        private System.Windows.Forms.Button squareKey;
        private System.Windows.Forms.Button clearKey;
        private System.Windows.Forms.Button sqrtKey;
        private System.Windows.Forms.Button divKey;
        private System.Windows.Forms.Button multiKey;
        private System.Windows.Forms.Button minusKey;
        private System.Windows.Forms.Button plusKey;
    }
}

