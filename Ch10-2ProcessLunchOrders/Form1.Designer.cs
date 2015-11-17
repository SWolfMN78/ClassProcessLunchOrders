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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkAddOnHam1 = new System.Windows.Forms.CheckBox();
            this.chkAddOnHam2 = new System.Windows.Forms.CheckBox();
            this.chkAddOnHam3 = new System.Windows.Forms.CheckBox();
            this.chkAddOnPiz3 = new System.Windows.Forms.CheckBox();
            this.chkAddOnPiz2 = new System.Windows.Forms.CheckBox();
            this.chkAddOnPiz1 = new System.Windows.Forms.CheckBox();
            this.chkPizza = new System.Windows.Forms.CheckBox();
            this.chkAddOnSal3 = new System.Windows.Forms.CheckBox();
            this.chkAddOnSal2 = new System.Windows.Forms.CheckBox();
            this.chkAddOnSal1 = new System.Windows.Forms.CheckBox();
            this.chkSalad = new System.Windows.Forms.CheckBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lstOrderForm = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
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
            this.btnFinalizeOrder.TabIndex = 0;
            this.btnFinalizeOrder.Text = "Finalize Order";
            this.btnFinalizeOrder.UseVisualStyleBackColor = true;
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Location = new System.Drawing.Point(32, 376);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(112, 48);
            this.btnAddToOrder.TabIndex = 1;
            this.btnAddToOrder.Text = "Add to Order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            // 
            // chkHamburger
            // 
            this.chkHamburger.AutoSize = true;
            this.chkHamburger.Location = new System.Drawing.Point(16, 24);
            this.chkHamburger.Name = "chkHamburger";
            this.chkHamburger.Size = new System.Drawing.Size(111, 17);
            this.chkHamburger.TabIndex = 2;
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
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
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
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
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
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // chkAddOnHam1
            // 
            this.chkAddOnHam1.AutoSize = true;
            this.chkAddOnHam1.Enabled = false;
            this.chkAddOnHam1.Location = new System.Drawing.Point(32, 48);
            this.chkAddOnHam1.Name = "chkAddOnHam1";
            this.chkAddOnHam1.Size = new System.Drawing.Size(194, 17);
            this.chkAddOnHam1.TabIndex = 3;
            this.chkAddOnHam1.Text = "Lettuce, Tomato, and Onions: $ .75";
            this.chkAddOnHam1.UseVisualStyleBackColor = true;
            // 
            // chkAddOnHam2
            // 
            this.chkAddOnHam2.AutoSize = true;
            this.chkAddOnHam2.Enabled = false;
            this.chkAddOnHam2.Location = new System.Drawing.Point(32, 72);
            this.chkAddOnHam2.Name = "chkAddOnHam2";
            this.chkAddOnHam2.Size = new System.Drawing.Size(174, 17);
            this.chkAddOnHam2.TabIndex = 4;
            this.chkAddOnHam2.Text = "Mayonnaise and mustard: $ .75";
            this.chkAddOnHam2.UseVisualStyleBackColor = true;
            // 
            // chkAddOnHam3
            // 
            this.chkAddOnHam3.AutoSize = true;
            this.chkAddOnHam3.Enabled = false;
            this.chkAddOnHam3.Location = new System.Drawing.Point(32, 96);
            this.chkAddOnHam3.Name = "chkAddOnHam3";
            this.chkAddOnHam3.Size = new System.Drawing.Size(111, 17);
            this.chkAddOnHam3.TabIndex = 5;
            this.chkAddOnHam3.Text = "French fries: $ .75";
            this.chkAddOnHam3.UseVisualStyleBackColor = true;
            // 
            // chkAddOnPiz3
            // 
            this.chkAddOnPiz3.AutoSize = true;
            this.chkAddOnPiz3.Enabled = false;
            this.chkAddOnPiz3.Location = new System.Drawing.Point(32, 96);
            this.chkAddOnPiz3.Name = "chkAddOnPiz3";
            this.chkAddOnPiz3.Size = new System.Drawing.Size(85, 17);
            this.chkAddOnPiz3.TabIndex = 9;
            this.chkAddOnPiz3.Text = "Olives: $ .50";
            this.chkAddOnPiz3.UseVisualStyleBackColor = true;
            // 
            // chkAddOnPiz2
            // 
            this.chkAddOnPiz2.AutoSize = true;
            this.chkAddOnPiz2.Enabled = false;
            this.chkAddOnPiz2.Location = new System.Drawing.Point(32, 72);
            this.chkAddOnPiz2.Name = "chkAddOnPiz2";
            this.chkAddOnPiz2.Size = new System.Drawing.Size(98, 17);
            this.chkAddOnPiz2.TabIndex = 8;
            this.chkAddOnPiz2.Text = "Sausage: $ .50";
            this.chkAddOnPiz2.UseVisualStyleBackColor = true;
            // 
            // chkAddOnPiz1
            // 
            this.chkAddOnPiz1.AutoSize = true;
            this.chkAddOnPiz1.Enabled = false;
            this.chkAddOnPiz1.Location = new System.Drawing.Point(32, 48);
            this.chkAddOnPiz1.Name = "chkAddOnPiz1";
            this.chkAddOnPiz1.Size = new System.Drawing.Size(104, 17);
            this.chkAddOnPiz1.TabIndex = 7;
            this.chkAddOnPiz1.Text = "Pepperoni: $ .50";
            this.chkAddOnPiz1.UseVisualStyleBackColor = true;
            // 
            // chkPizza
            // 
            this.chkPizza.AutoSize = true;
            this.chkPizza.Location = new System.Drawing.Point(16, 24);
            this.chkPizza.Name = "chkPizza";
            this.chkPizza.Size = new System.Drawing.Size(84, 17);
            this.chkPizza.TabIndex = 6;
            this.chkPizza.Text = "Pizza: $8.50";
            this.chkPizza.UseVisualStyleBackColor = true;
            this.chkPizza.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // chkAddOnSal3
            // 
            this.chkAddOnSal3.AutoSize = true;
            this.chkAddOnSal3.Enabled = false;
            this.chkAddOnSal3.Location = new System.Drawing.Point(32, 88);
            this.chkAddOnSal3.Name = "chkAddOnSal3";
            this.chkAddOnSal3.Size = new System.Drawing.Size(114, 17);
            this.chkAddOnSal3.TabIndex = 13;
            this.chkAddOnSal3.Text = "Bread sticks: $ .25";
            this.chkAddOnSal3.UseVisualStyleBackColor = true;
            // 
            // chkAddOnSal2
            // 
            this.chkAddOnSal2.AutoSize = true;
            this.chkAddOnSal2.Enabled = false;
            this.chkAddOnSal2.Location = new System.Drawing.Point(32, 64);
            this.chkAddOnSal2.Name = "chkAddOnSal2";
            this.chkAddOnSal2.Size = new System.Drawing.Size(107, 17);
            this.chkAddOnSal2.TabIndex = 12;
            this.chkAddOnSal2.Text = "Bacon Bits: $ .25";
            this.chkAddOnSal2.UseVisualStyleBackColor = true;
            // 
            // chkAddOnSal1
            // 
            this.chkAddOnSal1.AutoSize = true;
            this.chkAddOnSal1.Enabled = false;
            this.chkAddOnSal1.Location = new System.Drawing.Point(32, 40);
            this.chkAddOnSal1.Name = "chkAddOnSal1";
            this.chkAddOnSal1.Size = new System.Drawing.Size(98, 17);
            this.chkAddOnSal1.TabIndex = 11;
            this.chkAddOnSal1.Text = "Croutons: $ .25";
            this.chkAddOnSal1.UseVisualStyleBackColor = true;
            // 
            // chkSalad
            // 
            this.chkSalad.AutoSize = true;
            this.chkSalad.Location = new System.Drawing.Point(16, 16);
            this.chkSalad.Name = "chkSalad";
            this.chkSalad.Size = new System.Drawing.Size(86, 17);
            this.chkSalad.TabIndex = 10;
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
            this.lstOrderForm.Location = new System.Drawing.Point(352, 48);
            this.lstOrderForm.Name = "lstOrderForm";
            this.lstOrderForm.Size = new System.Drawing.Size(280, 316);
            this.lstOrderForm.TabIndex = 8;
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
            this.btnClearOrder.TabIndex = 10;
            this.btnClearOrder.Text = "Clear Order";
            this.btnClearOrder.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(544, 376);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 32);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Exit Form";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 447);
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
    }
}

