namespace TVCable_manager
{
    partial class mainForm
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
            this.reloadButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offerActivationPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offerCurrencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offerDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offerMonthlyLengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offerMonthlyPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tvOfferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvOfferBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reloadButton
            // 
            this.reloadButton.Location = new System.Drawing.Point(12, 12);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(75, 23);
            this.reloadButton.TabIndex = 0;
            this.reloadButton.Text = "Reload";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.offerActivationPriceDataGridViewTextBoxColumn,
            this.offerCurrencyDataGridViewTextBoxColumn,
            this.offerDescriptionDataGridViewTextBoxColumn,
            this.offerMonthlyLengthDataGridViewTextBoxColumn,
            this.offerMonthlyPriceDataGridViewTextBoxColumn,
            this.offerNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tvOfferBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(754, 513);
            this.dataGridView1.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // offerActivationPriceDataGridViewTextBoxColumn
            // 
            this.offerActivationPriceDataGridViewTextBoxColumn.DataPropertyName = "offerActivationPrice";
            this.offerActivationPriceDataGridViewTextBoxColumn.HeaderText = "Opłata aktywacyjna";
            this.offerActivationPriceDataGridViewTextBoxColumn.Name = "offerActivationPriceDataGridViewTextBoxColumn";
            this.offerActivationPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // offerCurrencyDataGridViewTextBoxColumn
            // 
            this.offerCurrencyDataGridViewTextBoxColumn.DataPropertyName = "offerCurrency";
            this.offerCurrencyDataGridViewTextBoxColumn.HeaderText = "Waluta";
            this.offerCurrencyDataGridViewTextBoxColumn.Name = "offerCurrencyDataGridViewTextBoxColumn";
            this.offerCurrencyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // offerDescriptionDataGridViewTextBoxColumn
            // 
            this.offerDescriptionDataGridViewTextBoxColumn.DataPropertyName = "offerDescription";
            this.offerDescriptionDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.offerDescriptionDataGridViewTextBoxColumn.Name = "offerDescriptionDataGridViewTextBoxColumn";
            this.offerDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // offerMonthlyLengthDataGridViewTextBoxColumn
            // 
            this.offerMonthlyLengthDataGridViewTextBoxColumn.DataPropertyName = "offerMonthlyLength";
            this.offerMonthlyLengthDataGridViewTextBoxColumn.HeaderText = "Okres umowy";
            this.offerMonthlyLengthDataGridViewTextBoxColumn.Name = "offerMonthlyLengthDataGridViewTextBoxColumn";
            this.offerMonthlyLengthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // offerMonthlyPriceDataGridViewTextBoxColumn
            // 
            this.offerMonthlyPriceDataGridViewTextBoxColumn.DataPropertyName = "offerMonthlyPrice";
            this.offerMonthlyPriceDataGridViewTextBoxColumn.HeaderText = "Opłata miesięczna";
            this.offerMonthlyPriceDataGridViewTextBoxColumn.Name = "offerMonthlyPriceDataGridViewTextBoxColumn";
            this.offerMonthlyPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // offerNameDataGridViewTextBoxColumn
            // 
            this.offerNameDataGridViewTextBoxColumn.DataPropertyName = "offerName";
            this.offerNameDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.offerNameDataGridViewTextBoxColumn.Name = "offerNameDataGridViewTextBoxColumn";
            this.offerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tvOfferBindingSource
            // 
            this.tvOfferBindingSource.DataSource = typeof(TVCable_manager.ServiceReference.tvOffer);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(491, 12);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Edytuj";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(691, 12);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 4;
            this.newButton.Text = "Dodaj";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(590, 12);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Usuń";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 566);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.reloadButton);
            this.Name = "mainForm";
            this.Text = "Oferta";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvOfferBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offerActivationPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offerCurrencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offerDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offerMonthlyLengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offerMonthlyPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tvOfferBindingSource;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

