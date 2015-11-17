namespace Ch10_2ProcessLunchOrders
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
            this.btnFinalizeOrder = new System.Windows.Forms.Button();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.chkHamburger = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAddOnHam3 = new System.Windows.Forms.CheckBox();
            this.chkAddOnHam2 = new System.Windows.Forms.CheckBox();
            this.chkAddOnHam1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkAddOnPiz3 = new System.Windows.Forms.CheckBox();
            this.chkAddOnPiz2 = new System.Windows.Forms.CheckBox();
            this.chkAddOnPiz1 = new System.Windows.Forms.CheckBox();
            this.chkPizza = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkAddOnSal3 = new System.Windows.Forms.CheckBox();
            this.chkAddOnSal2 = new System.Windows.Forms.CheckBox();
            this.chkAddOnSal1 = new System.Windows.Forms.CheckBox();
            this.chkSalad = new System.Windows.Forms.CheckBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lstOrderForm = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRunningTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTaxAmount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFinalizeOrder
            // 
            this.btnFinalizeOrder.Location = new System.Drawing.Point(352, 376);
            this.btnFinalizeOrder.Name = "btnFinalizeOrder";
            this.btnFinalizeOrder.Size = new System.Drawing.Size(88, 32);
            this.btnFinalizeOrder.TabIndex = 4;
            this.btnFinalizeOrder.Text = "&Finalize Order";
            this.btnFinalizeOrder.UseVisualStyleBackColor = true;
            this.btnFinalizeOrder.Click += new System.EventHandler(this.btnFinalizeOrder_Click);
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Location = new System.Drawing.Point(32, 376);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(112, 48);
            this.btnAddToOrder.TabIndex = 3;
            this.btnAddToOrder.Text = "&Add to Order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // chkHamburger
            // 
            this.chkHamburger.AutoSize = true;
            this.chkHamburger.Location = new System.Drawing.Point(16, 24);
            this.chkHamburger.Name = "chkHamburger";
            this.chkHamburger.Size = new System.Drawing.Size(111, 17);
            this.chkHamburger.TabIndex = 0;
            this.chkHamburger.Text = "Hamburger: $6.50";
            this.chkHamburger.UseVisualStyleBackColor = true;
            this.chkHamburger.CheckedChanged += new System.EventHandler(this.chkHamburger_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAddOnHam3);
            this.groupBox1.Controls.Add(this.chkAddOnHam2);
            this.groupBox1.Controls.Add(this.chkAddOnHam1);
            this.groupBox1.Controls.Add(this.chkHamburger);
            this.groupBox1.Location = new System.Drawing.Point(32, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // chkAddOnHam3
            // 
            this.chkAddOnHam3.AutoSize = true;
            this.chkAddOnHam3.Enabled = false;
            this.chkAddOnHam3.Location = new System.Drawing.Point(32, 96);
            this.chkAddOnHam3.Name = "chkAddOnHam3";
            this.chkAddOnHam3.Size = new System.Drawing.Size(111, 17);
            this.chkAddOnHam3.TabIndex = 3;
            this.chkAddOnHam3.Text = "French fries: $ .75";
            this.chkAddOnHam3.UseVisualStyleBackColor = true;
            this.chkAddOnHam3.CheckedChanged += new System.EventHandler(this.chkAddOnHam3_CheckedChanged);
            // 
            // chkAddOnHam2
            // 
            this.chkAddOnHam2.AutoSize = true;
            this.chkAddOnHam2.Enabled = false;
            this.chkAddOnHam2.Location = new System.Drawing.Point(32, 72);
            this.chkAddOnHam2.Name = "chkAddOnHam2";
            this.chkAddOnHam2.Size = new System.Drawing.Size(174, 17);
            this.chkAddOnHam2.TabIndex = 2;
            this.chkAddOnHam2.Text = "Mayonnaise and mustard: $ .75";
            this.chkAddOnHam2.UseVisualStyleBackColor = true;
            this.chkAddOnHam2.CheckedChanged += new System.EventHandler(this.chkAddOnHam2_CheckedChanged);
            // 
            // chkAddOnHam1
            // 
            this.chkAddOnHam1.AutoSize = true;
            this.chkAddOnHam1.Enabled = false;
            this.chkAddOnHam1.Location = new System.Drawing.Point(32, 48);
            this.chkAddOnHam1.Name = "chkAddOnHam1";
            this.chkAddOnHam1.Size = new System.Drawing.Size(194, 17);
            this.chkAddOnHam1.TabIndex = 1;
            this.chkAddOnHam1.Text = "Lettuce, Tomato, and Onions: $ .75";
            this.chkAddOnHam1.UseVisualStyleBackColor = true;
            this.chkAddOnHam1.CheckedChanged += new System.EventHandler(this.chkAddOnHam1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkAddOnPiz3);
            this.groupBox2.Controls.Add(this.chkAddOnPiz2);
            this.groupBox2.Controls.Add(this.chkAddOnPiz1);
            this.groupBox2.Controls.Add(this.chkPizza);
            this.groupBox2.Location = new System.Drawing.Point(32, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 120);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // chkAddOnPiz3
            // 
            this.chkAddOnPiz3.AutoSize = true;
            this.chkAddOnPiz3.Enabled = false;
            this.chkAddOnPiz3.Location = new System.Drawing.Point(32, 96);
            this.chkAddOnPiz3.Name = "chkAddOnPiz3";
            this.chkAddOnPiz3.Size = new System.Drawing.Size(85, 17);
            this.chkAddOnPiz3.TabIndex = 3;
            this.chkAddOnPiz3.Text = "Olives: $ .50";
            this.chkAddOnPiz3.UseVisualStyleBackColor = true;
            this.chkAddOnPiz3.CheckedChanged += new System.EventHandler(this.chkAddOnPiz3_CheckedChanged);
            // 
            // chkAddOnPiz2
            // 
            this.chkAddOnPiz2.AutoSize = true;
            this.chkAddOnPiz2.Enabled = false;
            this.chkAddOnPiz2.Location = new System.Drawing.Point(32, 72);
            this.chkAddOnPiz2.Name = "chkAddOnPiz2";
            this.chkAddOnPiz2.Size = new System.Drawing.Size(98, 17);
            this.chkAddOnPiz2.TabIndex = 2;
            this.chkAddOnPiz2.Text = "Sausage: $ .50";
            this.chkAddOnPiz2.UseVisualStyleBackColor = true;
            this.chkAddOnPiz2.CheckedChanged += new System.EventHandler(this.chkAddOnPiz2_CheckedChanged);
            // 
            // chkAddOnPiz1
            // 
            this.chkAddOnPiz1.AutoSize = true;
            this.chkAddOnPiz1.Enabled = false;
            this.chkAddOnPiz1.Location = new System.Drawing.Point(32, 48);
            this.chkAddOnPiz1.Name = "chkAddOnPiz1";
            this.chkAddOnPiz1.Size = new System.Drawing.Size(104, 17);
            this.chkAddOnPiz1.TabIndex = 1;
            this.chkAddOnPiz1.Text = "Pepperoni: $ .50";
            this.chkAddOnPiz1.UseVisualStyleBackColor = true;
            this.chkAddOnPiz1.CheckedChanged += new System.EventHandler(this.chkAddOnPiz1_CheckedChanged);
            // 
            // chkPizza
            // 
            this.chkPizza.AutoSize = true;
            this.chkPizza.Location = new System.Drawing.Point(16, 24);
            this.chkPizza.Name = "chkPizza";
            this.chkPizza.Size = new System.Drawing.Size(84, 17);
            this.chkPizza.TabIndex = 0;
            this.chkPizza.Text = "Pizza: $8.50";
            this.chkPizza.UseVisualStyleBackColor = true;
            this.chkPizza.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkAddOnSal3);
            this.groupBox3.Controls.Add(this.chkAddOnSal2);
            this.groupBox3.Controls.Add(this.chkAddOnSal1);
            this.groupBox3.Controls.Add(this.chkSalad);
            this.groupBox3.Location = new System.Drawing.Point(32, 256);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 112);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // chkAddOnSal3
            // 
            this.chkAddOnSal3.AutoSize = true;
            this.chkAddOnSal3.Enabled = false;
            this.chkAddOnSal3.Location = new System.Drawing.Point(32, 88);
            this.chkAddOnSal3.Name = "chkAddOnSal3";
            this.chkAddOnSal3.Size = new System.Drawing.Size(114, 17);
            this.chkAddOnSal3.TabIndex = 3;
            this.chkAddOnSal3.Text = "Bread sticks: $ .25";
            this.chkAddOnSal3.UseVisualStyleBackColor = true;
            this.chkAddOnSal3.CheckedChanged += new System.EventHandler(this.chkAddOnSal3_CheckedChanged);
            // 
            // chkAddOnSal2
            // 
            this.chkAddOnSal2.AutoSize = true;
            this.chkAddOnSal2.Enabled = false;
            this.chkAddOnSal2.Location = new System.Drawing.Point(32, 64);
            this.chkAddOnSal2.Name = "chkAddOnSal2";
            this.chkAddOnSal2.Size = new System.Drawing.Size(107, 17);
            this.chkAddOnSal2.TabIndex = 2;
            this.chkAddOnSal2.Text = "Bacon Bits: $ .25";
            this.chkAddOnSal2.UseVisualStyleBackColor = true;
            this.chkAddOnSal2.CheckedChanged += new System.EventHandler(this.chkAddOnSal2_CheckedChanged);
            // 
            // chkAddOnSal1
            // 
            this.chkAddOnSal1.AutoSize = true;
            this.chkAddOnSal1.Enabled = false;
            this.chkAddOnSal1.Location = new System.Drawing.Point(32, 40);
            this.chkAddOnSal1.Name = "chkAddOnSal1";
            this.chkAddOnSal1.Size = new System.Drawing.Size(98, 17);
            this.chkAddOnSal1.TabIndex = 1;
            this.chkAddOnSal1.Text = "Croutons: $ .25";
            this.chkAddOnSal1.UseVisualStyleBackColor = true;
            this.chkAddOnSal1.CheckedChanged += new System.EventHandler(this.chkAddOnSal1_CheckedChanged);
            // 
            // chkSalad
            // 
            this.chkSalad.AutoSize = true;
            this.chkSalad.Location = new System.Drawing.Point(16, 16);
            this.chkSalad.Name = "chkSalad";
            this.chkSalad.Size = new System.Drawing.Size(86, 17);
            this.chkSalad.TabIndex = 0;
            this.chkSalad.Text = "Salad: $5.75";
            this.chkSalad.UseVisualStyleBackColor = true;
            this.chkSalad.CheckedChanged += new System.EventHandler(this.chkSalad_CheckedChanged);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(152, 392);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(124, 13);
            this.lblSubTotal.TabIndex = 7;
            this.lblSubTotal.Text = "Selected items Subtotal: ";
            // 
            // lstOrderForm
            // 
            this.lstOrderForm.FormattingEnabled = true;
            this.lstOrderForm.HorizontalScrollbar = true;
            this.lstOrderForm.Location = new System.Drawing.Point(352, 48);
            this.lstOrderForm.Name = "lstOrderForm";
            this.lstOrderForm.Size = new System.Drawing.Size(280, 277);
            this.lstOrderForm.TabIndex = 8;
            this.lstOrderForm.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Order List";
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.Location = new System.Drawing.Point(448, 376);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(88, 32);
            this.btnClearOrder.TabIndex = 5;
            this.btnClearOrder.Text = "&Clear Order";
            this.btnClearOrder.UseVisualStyleBackColor = true;
            this.btnClearOrder.Click += new System.EventHandler(this.btnClearOrder_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(544, 376);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 32);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "E&xit Form";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRunningTotal
            // 
            this.lblRunningTotal.AutoSize = true;
            this.lblRunningTotal.Location = new System.Drawing.Point(184, 408);
            this.lblRunningTotal.Name = "lblRunningTotal";
            this.lblRunningTotal.Size = new System.Drawing.Size(0, 13);
            this.lblRunningTotal.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tax: ";
            // 
            // lblTaxAmount
            // 
            this.lblTaxAmount.AutoSize = true;
            this.lblTaxAmount.Location = new System.Drawing.Point(384, 336);
            this.lblTaxAmount.Name = "lblTaxAmount";
            this.lblTaxAmount.Size = new System.Drawing.Size(0, 13);
            this.lblTaxAmount.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Grand Total:";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Location = new System.Drawing.Point(552, 336);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(0, 13);
            this.lblGrandTotal.TabIndex = 16;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnFinalizeOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(663, 447);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTaxAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRunningTotal);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClearOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstOrderForm);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.btnFinalizeOrder);
            this.Name = "Form1";
            this.Text = "Lunch Order Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinalizeOrder;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.CheckBox chkHamburger;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkAddOnHam3;
        private System.Windows.Forms.CheckBox chkAddOnHam2;
        private System.Windows.Forms.CheckBox chkAddOnHam1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkAddOnPiz3;
        private System.Windows.Forms.CheckBox chkAddOnPiz2;
        private System.Windows.Forms.CheckBox chkAddOnPiz1;
        private System.Windows.Forms.CheckBox chkPizza;
        private System.Windows.Forms.CheckBox chkAddOnSal3;
        private System.Windows.Forms.CheckBox chkAddOnSal2;
        private System.Windows.Forms.CheckBox chkAddOnSal1;
        private System.Windows.Forms.CheckBox chkSalad;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.ListBox lstOrderForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClearOrder;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRunningTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTaxAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGrandTotal;
    }
}

