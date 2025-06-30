namespace TicketEase___Movie_Ticket_Management_System.View.Ticket
{
    partial class Purchase
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMovies = new System.Windows.Forms.ComboBox();
            this.txtGenre = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.Label();
            this.txtShowDate = new System.Windows.Forms.Label();
            this.txtShowTime = new System.Windows.Forms.Label();
            this.txtPriceLabel = new System.Windows.Forms.Label();
            this.txtAvailableTickets = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.gbUserInformation = new System.Windows.Forms.GroupBox();
            this.txtCustomerName = new System.Windows.Forms.Label();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.gbUserInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 54);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lora SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Purchase Ticket";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lora SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lists available movies";
            // 
            // cmbMovies
            // 
            this.cmbMovies.Font = new System.Drawing.Font("Lora SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.cmbMovies.FormattingEnabled = true;
            this.cmbMovies.ItemHeight = 30;
            this.cmbMovies.Location = new System.Drawing.Point(17, 114);
            this.cmbMovies.Name = "cmbMovies";
            this.cmbMovies.Size = new System.Drawing.Size(707, 38);
            this.cmbMovies.TabIndex = 3;
            this.cmbMovies.SelectedIndexChanged += new System.EventHandler(this.cmbMovies_SelectedIndexChanged);
            // 
            // txtGenre
            // 
            this.txtGenre.AutoSize = true;
            this.txtGenre.Font = new System.Drawing.Font("Lora SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenre.Location = new System.Drawing.Point(12, 162);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(241, 30);
            this.txtGenre.TabIndex = 4;
            this.txtGenre.Text = "Genre: Historical Drama";
            // 
            // txtDuration
            // 
            this.txtDuration.AutoSize = true;
            this.txtDuration.Font = new System.Drawing.Font("Lora SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.Location = new System.Drawing.Point(496, 162);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(228, 30);
            this.txtDuration.TabIndex = 5;
            this.txtDuration.Text = "Duration: 200 Minutes";
            // 
            // txtShowDate
            // 
            this.txtShowDate.AutoSize = true;
            this.txtShowDate.Font = new System.Drawing.Font("Lora SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowDate.Location = new System.Drawing.Point(12, 218);
            this.txtShowDate.Name = "txtShowDate";
            this.txtShowDate.Size = new System.Drawing.Size(235, 30);
            this.txtShowDate.TabIndex = 6;
            this.txtShowDate.Text = "Show Date: 2025-07-05";
            this.txtShowDate.Click += new System.EventHandler(this.txtShowTime_Click);
            // 
            // txtShowTime
            // 
            this.txtShowTime.AutoSize = true;
            this.txtShowTime.Font = new System.Drawing.Font("Lora SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowTime.Location = new System.Drawing.Point(496, 218);
            this.txtShowTime.Name = "txtShowTime";
            this.txtShowTime.Size = new System.Drawing.Size(206, 30);
            this.txtShowTime.TabIndex = 7;
            this.txtShowTime.Text = "Show Time: 18:30:00";
            // 
            // txtPriceLabel
            // 
            this.txtPriceLabel.AutoSize = true;
            this.txtPriceLabel.Font = new System.Drawing.Font("Lora SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceLabel.Location = new System.Drawing.Point(12, 273);
            this.txtPriceLabel.Name = "txtPriceLabel";
            this.txtPriceLabel.Size = new System.Drawing.Size(132, 30);
            this.txtPriceLabel.TabIndex = 8;
            this.txtPriceLabel.Text = "Ticket Price:";
            // 
            // txtAvailableTickets
            // 
            this.txtAvailableTickets.AutoSize = true;
            this.txtAvailableTickets.Font = new System.Drawing.Font("Lora SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvailableTickets.Location = new System.Drawing.Point(496, 273);
            this.txtAvailableTickets.Name = "txtAvailableTickets";
            this.txtAvailableTickets.Size = new System.Drawing.Size(219, 30);
            this.txtAvailableTickets.TabIndex = 9;
            this.txtAvailableTickets.Text = "Available Tickets: 200";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lora SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ticket Quantity";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Lora SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.numericUpDown1.Location = new System.Drawing.Point(20, 415);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(157, 33);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lora SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total Amount";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Lora SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.txtTotalAmount.Location = new System.Drawing.Point(20, 510);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(157, 33);
            this.txtTotalAmount.TabIndex = 13;
            // 
            // gbUserInformation
            // 
            this.gbUserInformation.Controls.Add(this.txtCustomerName);
            this.gbUserInformation.Font = new System.Drawing.Font("Lora SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.gbUserInformation.Location = new System.Drawing.Point(411, 370);
            this.gbUserInformation.Name = "gbUserInformation";
            this.gbUserInformation.Size = new System.Drawing.Size(313, 100);
            this.gbUserInformation.TabIndex = 14;
            this.gbUserInformation.TabStop = false;
            this.gbUserInformation.Text = "User Information";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.AutoSize = true;
            this.txtCustomerName.Font = new System.Drawing.Font("Lora SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(6, 45);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(145, 25);
            this.txtCustomerName.TabIndex = 15;
            this.txtCustomerName.Text = "Name: Customer";
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.DarkRed;
            this.btnPurchase.Font = new System.Drawing.Font("Lora SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.ForeColor = System.Drawing.Color.White;
            this.btnPurchase.Location = new System.Drawing.Point(490, 521);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(234, 60);
            this.btnPurchase.TabIndex = 15;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.AutoSize = true;
            this.txtPrice.Font = new System.Drawing.Font("Lora SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(150, 273);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(50, 30);
            this.txtPrice.TabIndex = 16;
            this.txtPrice.Text = "500";
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 612);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.gbUserInformation);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAvailableTickets);
            this.Controls.Add(this.txtPriceLabel);
            this.Controls.Add(this.txtShowTime);
            this.Controls.Add(this.txtShowDate);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.cmbMovies);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Purchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.Purchase_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.gbUserInformation.ResumeLayout(false);
            this.gbUserInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMovies;
        private System.Windows.Forms.Label txtGenre;
        private System.Windows.Forms.Label txtDuration;
        private System.Windows.Forms.Label txtShowDate;
        private System.Windows.Forms.Label txtShowTime;
        private System.Windows.Forms.Label txtPriceLabel;
        private System.Windows.Forms.Label txtAvailableTickets;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.GroupBox gbUserInformation;
        private System.Windows.Forms.Label txtCustomerName;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Label txtPrice;
    }
}