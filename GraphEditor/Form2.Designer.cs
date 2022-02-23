namespace GraphEditor
{
    partial class Form2
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
            this.RedBarr = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GreenBarr = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.BlueBarr = new System.Windows.Forms.HScrollBar();
            this.Color_Pic = new System.Windows.Forms.PictureBox();
            this.Ok_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.OtherColors = new System.Windows.Forms.Button();
            this.numericUpDownRed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGreen = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBlue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Color_Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // RedBarr
            // 
            this.RedBarr.LargeChange = 1;
            this.RedBarr.Location = new System.Drawing.Point(71, 9);
            this.RedBarr.Maximum = 255;
            this.RedBarr.Name = "RedBarr";
            this.RedBarr.Size = new System.Drawing.Size(192, 21);
            this.RedBarr.TabIndex = 0;
            this.RedBarr.ValueChanged += new System.EventHandler(this.RedBarr_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Green";
            // 
            // GreenBarr
            // 
            this.GreenBarr.LargeChange = 1;
            this.GreenBarr.Location = new System.Drawing.Point(71, 47);
            this.GreenBarr.Maximum = 255;
            this.GreenBarr.Name = "GreenBarr";
            this.GreenBarr.Size = new System.Drawing.Size(192, 21);
            this.GreenBarr.TabIndex = 2;
            this.GreenBarr.ValueChanged += new System.EventHandler(this.GreenBarr_ValueChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Blue";
            // 
            // BlueBarr
            // 
            this.BlueBarr.LargeChange = 1;
            this.BlueBarr.Location = new System.Drawing.Point(71, 91);
            this.BlueBarr.Maximum = 255;
            this.BlueBarr.Name = "BlueBarr";
            this.BlueBarr.Size = new System.Drawing.Size(192, 21);
            this.BlueBarr.TabIndex = 4;
            this.BlueBarr.ValueChanged += new System.EventHandler(this.BlueBarr_ValueChanged);
            // 
            // Color_Pic
            // 
            this.Color_Pic.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Color_Pic.Location = new System.Drawing.Point(335, 13);
            this.Color_Pic.Name = "Color_Pic";
            this.Color_Pic.Size = new System.Drawing.Size(100, 99);
            this.Color_Pic.TabIndex = 6;
            this.Color_Pic.TabStop = false;
            // 
            // Ok_btn
            // 
            this.Ok_btn.Location = new System.Drawing.Point(13, 151);
            this.Ok_btn.Name = "Ok_btn";
            this.Ok_btn.Size = new System.Drawing.Size(75, 23);
            this.Ok_btn.TabIndex = 7;
            this.Ok_btn.Text = "Ok";
            this.Ok_btn.UseVisualStyleBackColor = true;
            this.Ok_btn.Click += new System.EventHandler(this.Ok_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(94, 151);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.Cancel_btn.TabIndex = 8;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // OtherColors
            // 
            this.OtherColors.Location = new System.Drawing.Point(360, 151);
            this.OtherColors.Name = "OtherColors";
            this.OtherColors.Size = new System.Drawing.Size(75, 23);
            this.OtherColors.TabIndex = 9;
            this.OtherColors.Text = "Other Color";
            this.OtherColors.UseVisualStyleBackColor = true;
            this.OtherColors.Click += new System.EventHandler(this.OtherColors_Click);
            // 
            // numericUpDownRed
            // 
            this.numericUpDownRed.Location = new System.Drawing.Point(277, 9);
            this.numericUpDownRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownRed.Name = "numericUpDownRed";
            this.numericUpDownRed.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownRed.TabIndex = 10;
            this.numericUpDownRed.ValueChanged += new System.EventHandler(this.numericUpDownRed_ValueChanged);
            // 
            // numericUpDownGreen
            // 
            this.numericUpDownGreen.Location = new System.Drawing.Point(277, 47);
            this.numericUpDownGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownGreen.Name = "numericUpDownGreen";
            this.numericUpDownGreen.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownGreen.TabIndex = 11;
            this.numericUpDownGreen.ValueChanged += new System.EventHandler(this.numericUpDownGreen_ValueChanged);
            // 
            // numericUpDownBlue
            // 
            this.numericUpDownBlue.Location = new System.Drawing.Point(277, 91);
            this.numericUpDownBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBlue.Name = "numericUpDownBlue";
            this.numericUpDownBlue.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownBlue.TabIndex = 12;
            this.numericUpDownBlue.ValueChanged += new System.EventHandler(this.numericUpDownBlue_ValueChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 199);
            this.Controls.Add(this.numericUpDownBlue);
            this.Controls.Add(this.numericUpDownGreen);
            this.Controls.Add(this.numericUpDownRed);
            this.Controls.Add(this.OtherColors);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Ok_btn);
            this.Controls.Add(this.Color_Pic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BlueBarr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GreenBarr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RedBarr);
            this.Name = "Form2";
            this.Text = "ColorPicker";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Color_Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.HScrollBar RedBarr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HScrollBar GreenBarr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HScrollBar BlueBarr;
        private System.Windows.Forms.PictureBox Color_Pic;
        private System.Windows.Forms.Button Ok_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Button OtherColors;
        private System.Windows.Forms.NumericUpDown numericUpDownRed;
        private System.Windows.Forms.NumericUpDown numericUpDownGreen;
        private System.Windows.Forms.NumericUpDown numericUpDownBlue;
    }
}