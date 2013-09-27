﻿namespace complex_brood
{
    partial class MainWindow
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
            if(disposing && (components != null))
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
            this.labelCenterX = new System.Windows.Forms.Label();
            this.labelCenterY = new System.Windows.Forms.Label();
            this.labelScale = new System.Windows.Forms.Label();
            this.labelMaxIterations = new System.Windows.Forms.Label();
            this.labelViewWidth = new System.Windows.Forms.Label();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.mandelDisplay = new complex_brood.MandelDisplay();
            this.spinnerScale = new System.Windows.Forms.NumericUpDown();
            this.spinnerMaxIterations = new System.Windows.Forms.NumericUpDown();
            this.spinnerDiameter = new System.Windows.Forms.NumericUpDown();
            this.spinnerCenterX = new System.Windows.Forms.NumericUpDown();
            this.spinnerCenterY = new System.Windows.Forms.NumericUpDown();
            this.btnGo = new System.Windows.Forms.Button();
            this.tableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerMaxIterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerDiameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerCenterX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerCenterY)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCenterX
            // 
            this.labelCenterX.AutoSize = true;
            this.labelCenterX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCenterX.Location = new System.Drawing.Point(3, 0);
            this.labelCenterX.Name = "labelCenterX";
            this.labelCenterX.Size = new System.Drawing.Size(69, 32);
            this.labelCenterX.TabIndex = 1;
            this.labelCenterX.Text = "Midden X:";
            this.labelCenterX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCenterY
            // 
            this.labelCenterY.AutoSize = true;
            this.labelCenterY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCenterY.Location = new System.Drawing.Point(3, 32);
            this.labelCenterY.Name = "labelCenterY";
            this.labelCenterY.Size = new System.Drawing.Size(69, 32);
            this.labelCenterY.TabIndex = 2;
            this.labelCenterY.Text = "Midden Y:";
            this.labelCenterY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelScale
            // 
            this.labelScale.AutoSize = true;
            this.labelScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelScale.Location = new System.Drawing.Point(186, 0);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(139, 32);
            this.labelScale.TabIndex = 3;
            this.labelScale.Text = "Pixelbreedte:";
            this.labelScale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMaxIterations
            // 
            this.labelMaxIterations.AutoSize = true;
            this.labelMaxIterations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaxIterations.Location = new System.Drawing.Point(186, 32);
            this.labelMaxIterations.Name = "labelMaxIterations";
            this.labelMaxIterations.Size = new System.Drawing.Size(139, 32);
            this.labelMaxIterations.TabIndex = 4;
            this.labelMaxIterations.Text = "Maximaal aantal iteraties:";
            this.labelMaxIterations.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelViewWidth
            // 
            this.labelViewWidth.AutoSize = true;
            this.labelViewWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelViewWidth.Location = new System.Drawing.Point(439, 0);
            this.labelViewWidth.Name = "labelViewWidth";
            this.labelViewWidth.Size = new System.Drawing.Size(114, 32);
            this.labelViewWidth.TabIndex = 5;
            this.labelViewWidth.Text = "Weergave breedte:";
            this.labelViewWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 6;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayout.Controls.Add(this.labelCenterY, 0, 1);
            this.tableLayout.Controls.Add(this.mandelDisplay, 0, 2);
            this.tableLayout.Controls.Add(this.labelCenterX, 0, 0);
            this.tableLayout.Controls.Add(this.labelScale, 2, 0);
            this.tableLayout.Controls.Add(this.labelMaxIterations, 2, 1);
            this.tableLayout.Controls.Add(this.labelViewWidth, 4, 0);
            this.tableLayout.Controls.Add(this.spinnerScale, 3, 0);
            this.tableLayout.Controls.Add(this.spinnerMaxIterations, 3, 1);
            this.tableLayout.Controls.Add(this.spinnerDiameter, 5, 0);
            this.tableLayout.Controls.Add(this.spinnerCenterX, 1, 0);
            this.tableLayout.Controls.Add(this.spinnerCenterY, 1, 1);
            this.tableLayout.Controls.Add(this.btnGo, 5, 1);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 3;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.Size = new System.Drawing.Size(670, 400);
            this.tableLayout.TabIndex = 0;
            // 
            // mandelDisplay
            // 
            this.tableLayout.SetColumnSpan(this.mandelDisplay, 6);
            this.mandelDisplay.Cursor = System.Windows.Forms.Cursors.Cross;
            this.mandelDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mandelDisplay.Location = new System.Drawing.Point(3, 67);
            this.mandelDisplay.Name = "mandelDisplay";
            this.mandelDisplay.Size = new System.Drawing.Size(664, 330);
            this.mandelDisplay.TabIndex = 0;
            this.mandelDisplay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mandelDisplay_MouseDown);
            this.mandelDisplay.MouseLeave += new System.EventHandler(this.mandelDisplay_MouseLeave);
            this.mandelDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mandelDisplay_MouseMove);
            this.mandelDisplay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mandelDisplay_MouseUp);
            // 
            // spinnerScale
            // 
            this.spinnerScale.DecimalPlaces = 9;
            this.spinnerScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spinnerScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.spinnerScale.Location = new System.Drawing.Point(331, 6);
            this.spinnerScale.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.spinnerScale.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinnerScale.Name = "spinnerScale";
            this.spinnerScale.Size = new System.Drawing.Size(102, 20);
            this.spinnerScale.TabIndex = 6;
            this.spinnerScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.spinnerScale.ValueChanged += new System.EventHandler(this.spinnerScale_ValueChanged);
            // 
            // spinnerMaxIterations
            // 
            this.spinnerMaxIterations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spinnerMaxIterations.Location = new System.Drawing.Point(331, 38);
            this.spinnerMaxIterations.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.spinnerMaxIterations.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.spinnerMaxIterations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinnerMaxIterations.Name = "spinnerMaxIterations";
            this.spinnerMaxIterations.Size = new System.Drawing.Size(102, 20);
            this.spinnerMaxIterations.TabIndex = 7;
            this.spinnerMaxIterations.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // spinnerDiameter
            // 
            this.spinnerDiameter.DecimalPlaces = 9;
            this.spinnerDiameter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spinnerDiameter.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.spinnerDiameter.Location = new System.Drawing.Point(559, 6);
            this.spinnerDiameter.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.spinnerDiameter.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.spinnerDiameter.Name = "spinnerDiameter";
            this.spinnerDiameter.Size = new System.Drawing.Size(108, 20);
            this.spinnerDiameter.TabIndex = 8;
            this.spinnerDiameter.ValueChanged += new System.EventHandler(this.spinnerDiameter_ValueChanged);
            // 
            // spinnerCenterX
            // 
            this.spinnerCenterX.DecimalPlaces = 9;
            this.spinnerCenterX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spinnerCenterX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.spinnerCenterX.Location = new System.Drawing.Point(78, 6);
            this.spinnerCenterX.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.spinnerCenterX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.spinnerCenterX.Name = "spinnerCenterX";
            this.spinnerCenterX.Size = new System.Drawing.Size(102, 20);
            this.spinnerCenterX.TabIndex = 9;
            // 
            // spinnerCenterY
            // 
            this.spinnerCenterY.DecimalPlaces = 9;
            this.spinnerCenterY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spinnerCenterY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.spinnerCenterY.Location = new System.Drawing.Point(78, 38);
            this.spinnerCenterY.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.spinnerCenterY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.spinnerCenterY.Name = "spinnerCenterY";
            this.spinnerCenterY.Size = new System.Drawing.Size(102, 20);
            this.spinnerCenterY.TabIndex = 10;
            // 
            // btnGo
            // 
            this.btnGo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGo.Location = new System.Drawing.Point(559, 35);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(108, 26);
            this.btnGo.TabIndex = 11;
            this.btnGo.Text = "Geef weer";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 400);
            this.Controls.Add(this.tableLayout);
            this.MinimumSize = new System.Drawing.Size(686, 300);
            this.Name = "MainWindow";
            this.Text = "Complex brood";
            this.ResizeEnd += new System.EventHandler(this.MainWindow_ResizeEnd);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerMaxIterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerDiameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerCenterX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerCenterY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private MandelDisplay mandelDisplay;
        private System.Windows.Forms.NumericUpDown spinnerScale;
        private System.Windows.Forms.NumericUpDown spinnerMaxIterations;
        private System.Windows.Forms.NumericUpDown spinnerDiameter;
        private System.Windows.Forms.NumericUpDown spinnerCenterX;
        private System.Windows.Forms.NumericUpDown spinnerCenterY;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label labelCenterX;
        private System.Windows.Forms.Label labelCenterY;
        private System.Windows.Forms.Label labelScale;
        private System.Windows.Forms.Label labelMaxIterations;
        private System.Windows.Forms.Label labelViewWidth;

    }
}