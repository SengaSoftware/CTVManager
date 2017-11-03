using System;

namespace TVCable_manager
{
    partial class edit
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
            this.saveButton = new System.Windows.Forms.Button();
            this.offerNameTextBox = new System.Windows.Forms.TextBox();
            this.offerNameLabel = new System.Windows.Forms.Label();
            this.offerDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.offerDescriptionLabel = new System.Windows.Forms.Label();
            this.offerCurrencyTextBox = new System.Windows.Forms.TextBox();
            this.offerCurrencyLabel = new System.Windows.Forms.Label();
            this.offerMonthlyLengthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.offerMonthlyLengthLabel = new System.Windows.Forms.Label();
            this.offerActivationPriceTextBox = new System.Windows.Forms.TextBox();
            this.offerActivationPriceLabel = new System.Windows.Forms.Label();
            this.offerMonthlyPriceTextBox = new System.Windows.Forms.TextBox();
            this.offerMonthlyPriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.offerMonthlyLengthNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(249, 457);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Zapisz";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // offerNameTextBox
            // 
            this.offerNameTextBox.Location = new System.Drawing.Point(13, 44);
            this.offerNameTextBox.MaxLength = 255;
            this.offerNameTextBox.Name = "offerNameTextBox";
            this.offerNameTextBox.Size = new System.Drawing.Size(556, 20);
            this.offerNameTextBox.TabIndex = 1;
            // 
            // offerNameLabel
            // 
            this.offerNameLabel.AutoSize = true;
            this.offerNameLabel.Location = new System.Drawing.Point(13, 25);
            this.offerNameLabel.Name = "offerNameLabel";
            this.offerNameLabel.Size = new System.Drawing.Size(78, 13);
            this.offerNameLabel.TabIndex = 2;
            this.offerNameLabel.Text = "Nazwa pakietu";
            this.offerNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // offerDescriptionTextBox
            // 
            this.offerDescriptionTextBox.Location = new System.Drawing.Point(13, 92);
            this.offerDescriptionTextBox.MaxLength = 255;
            this.offerDescriptionTextBox.Multiline = true;
            this.offerDescriptionTextBox.Name = "offerDescriptionTextBox";
            this.offerDescriptionTextBox.Size = new System.Drawing.Size(556, 107);
            this.offerDescriptionTextBox.TabIndex = 3;
            // 
            // offerDescriptionLabel
            // 
            this.offerDescriptionLabel.AutoSize = true;
            this.offerDescriptionLabel.Location = new System.Drawing.Point(13, 73);
            this.offerDescriptionLabel.Name = "offerDescriptionLabel";
            this.offerDescriptionLabel.Size = new System.Drawing.Size(57, 13);
            this.offerDescriptionLabel.TabIndex = 4;
            this.offerDescriptionLabel.Text = "Opis oferty";
            // 
            // offerCurrencyTextBox
            // 
            this.offerCurrencyTextBox.Location = new System.Drawing.Point(12, 232);
            this.offerCurrencyTextBox.MaxLength = 3;
            this.offerCurrencyTextBox.Name = "offerCurrencyTextBox";
            this.offerCurrencyTextBox.Size = new System.Drawing.Size(556, 20);
            this.offerCurrencyTextBox.TabIndex = 5;
            // 
            // offerCurrencyLabel
            // 
            this.offerCurrencyLabel.AutoSize = true;
            this.offerCurrencyLabel.Location = new System.Drawing.Point(13, 216);
            this.offerCurrencyLabel.Name = "offerCurrencyLabel";
            this.offerCurrencyLabel.Size = new System.Drawing.Size(41, 13);
            this.offerCurrencyLabel.TabIndex = 6;
            this.offerCurrencyLabel.Text = "Waluta";
            // 
            // offerMonthlyLengthNumericUpDown
            // 
            this.offerMonthlyLengthNumericUpDown.Location = new System.Drawing.Point(12, 290);
            this.offerMonthlyLengthNumericUpDown.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.offerMonthlyLengthNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.offerMonthlyLengthNumericUpDown.Name = "offerMonthlyLengthNumericUpDown";
            this.offerMonthlyLengthNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.offerMonthlyLengthNumericUpDown.TabIndex = 7;
            this.offerMonthlyLengthNumericUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // offerMonthlyLengthLabel
            // 
            this.offerMonthlyLengthLabel.AutoSize = true;
            this.offerMonthlyLengthLabel.Location = new System.Drawing.Point(13, 274);
            this.offerMonthlyLengthLabel.Name = "offerMonthlyLengthLabel";
            this.offerMonthlyLengthLabel.Size = new System.Drawing.Size(138, 13);
            this.offerMonthlyLengthLabel.TabIndex = 8;
            this.offerMonthlyLengthLabel.Text = "Okres umowy w miesiącach";
            this.offerMonthlyLengthLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // offerActivationPriceTextBox
            // 
            this.offerActivationPriceTextBox.Location = new System.Drawing.Point(13, 347);
            this.offerActivationPriceTextBox.MaxLength = 10;
            this.offerActivationPriceTextBox.Name = "offerActivationPriceTextBox";
            this.offerActivationPriceTextBox.Size = new System.Drawing.Size(552, 20);
            this.offerActivationPriceTextBox.TabIndex = 9;
            //this.offerActivationPriceTextBox.TextChanged += new System.EventHandler(this.offerActivationPriceTextBox_TextChanged);
            this.offerActivationPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(offerActivationPriceTextBox_KeyPress);
            // 
            // offerActivationPriceLabel
            // 
            this.offerActivationPriceLabel.AutoSize = true;
            this.offerActivationPriceLabel.Location = new System.Drawing.Point(16, 328);
            this.offerActivationPriceLabel.Name = "offerActivationPriceLabel";
            this.offerActivationPriceLabel.Size = new System.Drawing.Size(102, 13);
            this.offerActivationPriceLabel.TabIndex = 10;
            this.offerActivationPriceLabel.Text = "Opłata aktywacyjna";
            // 
            // offerMonthlyPriceTextBox
            // 
            this.offerMonthlyPriceTextBox.Location = new System.Drawing.Point(16, 403);
            this.offerMonthlyPriceTextBox.MaxLength = 10;
            this.offerMonthlyPriceTextBox.Name = "offerMonthlyPriceTextBox";
            this.offerMonthlyPriceTextBox.Size = new System.Drawing.Size(549, 20);
            this.offerMonthlyPriceTextBox.TabIndex = 11;
            this.offerMonthlyPriceTextBox.TextChanged += new System.EventHandler(this.offerMonthlyPriceTextBox_TextChanged);
            //this.offerMonthlyPriceTextBox.KeyPress += new System.EventHandler(this.offerMonthlyPriceTextBox_KeyPress);
            this.offerMonthlyPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(offerMonthlyPriceTextBox_KeyPress);
            // 
            // offerMonthlyPriceLabel
            // 
            this.offerMonthlyPriceLabel.AutoSize = true;
            this.offerMonthlyPriceLabel.Location = new System.Drawing.Point(19, 384);
            this.offerMonthlyPriceLabel.Name = "offerMonthlyPriceLabel";
            this.offerMonthlyPriceLabel.Size = new System.Drawing.Size(95, 13);
            this.offerMonthlyPriceLabel.TabIndex = 12;
            this.offerMonthlyPriceLabel.Text = "Opłata miesięczna";
            // 
            // edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 503);
            this.Controls.Add(this.offerMonthlyPriceLabel);
            this.Controls.Add(this.offerMonthlyPriceTextBox);
            this.Controls.Add(this.offerActivationPriceLabel);
            this.Controls.Add(this.offerActivationPriceTextBox);
            this.Controls.Add(this.offerMonthlyLengthLabel);
            this.Controls.Add(this.offerMonthlyLengthNumericUpDown);
            this.Controls.Add(this.offerCurrencyLabel);
            this.Controls.Add(this.offerCurrencyTextBox);
            this.Controls.Add(this.offerDescriptionLabel);
            this.Controls.Add(this.offerDescriptionTextBox);
            this.Controls.Add(this.offerNameLabel);
            this.Controls.Add(this.offerNameTextBox);
            this.Controls.Add(this.saveButton);
            this.Name = "edit";
            this.Text = "Edycja";
            this.Load += new System.EventHandler(this.edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.offerMonthlyLengthNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void offerActivationPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void offerMonthlyPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox offerNameTextBox;
        private System.Windows.Forms.Label offerNameLabel;
        private System.Windows.Forms.TextBox offerDescriptionTextBox;
        private System.Windows.Forms.Label offerDescriptionLabel;
        private System.Windows.Forms.TextBox offerCurrencyTextBox;
        private System.Windows.Forms.Label offerCurrencyLabel;
        private System.Windows.Forms.NumericUpDown offerMonthlyLengthNumericUpDown;
        private System.Windows.Forms.Label offerMonthlyLengthLabel;
        private System.Windows.Forms.TextBox offerActivationPriceTextBox;
        private System.Windows.Forms.Label offerActivationPriceLabel;
        private System.Windows.Forms.TextBox offerMonthlyPriceTextBox;
        private System.Windows.Forms.Label offerMonthlyPriceLabel;
    }
}