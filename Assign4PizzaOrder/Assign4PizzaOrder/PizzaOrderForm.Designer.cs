namespace Assign4PizzaOrder
{
    partial class frmPizzaOrder
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
            this.lblPizzaSize = new System.Windows.Forms.Label();
            this.nupPizzaSize = new System.Windows.Forms.NumericUpDown();
            this.lblMedium = new System.Windows.Forms.Label();
            this.lblLarge = new System.Windows.Forms.Label();
            this.lblExtraLarge = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.nupToppings = new System.Windows.Forms.NumericUpDown();
            this.lblChooseToppings = new System.Windows.Forms.Label();
            this.lblSides = new System.Windows.Forms.Label();
            this.nupSides = new System.Windows.Forms.NumericUpDown();
            this.lblNoSide = new System.Windows.Forms.Label();
            this.lblPoutine = new System.Windows.Forms.Label();
            this.lblWings = new System.Windows.Forms.Label();
            this.lblFries = new System.Windows.Forms.Label();
            this.lblHowManyPizzas = new System.Windows.Forms.Label();
            this.nupAmountOfPizzas = new System.Windows.Forms.NumericUpDown();
            this.lbl = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblSubtotalAns = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTaxAns = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalAns = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupPizzaSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupToppings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSides)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAmountOfPizzas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPizzaSize
            // 
            this.lblPizzaSize.AutoSize = true;
            this.lblPizzaSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaSize.Location = new System.Drawing.Point(27, 33);
            this.lblPizzaSize.Name = "lblPizzaSize";
            this.lblPizzaSize.Size = new System.Drawing.Size(225, 20);
            this.lblPizzaSize.TabIndex = 0;
            this.lblPizzaSize.Text = "Select the pizza size you want:\r\n";
            // 
            // nupPizzaSize
            // 
            this.nupPizzaSize.Location = new System.Drawing.Point(258, 36);
            this.nupPizzaSize.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nupPizzaSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupPizzaSize.Name = "nupPizzaSize";
            this.nupPizzaSize.Size = new System.Drawing.Size(67, 20);
            this.nupPizzaSize.TabIndex = 1;
            this.nupPizzaSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblMedium
            // 
            this.lblMedium.AutoSize = true;
            this.lblMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedium.Location = new System.Drawing.Point(68, 74);
            this.lblMedium.Name = "lblMedium";
            this.lblMedium.Size = new System.Drawing.Size(133, 20);
            this.lblMedium.TabIndex = 2;
            this.lblMedium.Text = "Medium Pizza = 1";
            // 
            // lblLarge
            // 
            this.lblLarge.AutoSize = true;
            this.lblLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLarge.Location = new System.Drawing.Point(68, 113);
            this.lblLarge.Name = "lblLarge";
            this.lblLarge.Size = new System.Drawing.Size(118, 20);
            this.lblLarge.TabIndex = 3;
            this.lblLarge.Text = "Large Pizza = 2";
            // 
            // lblExtraLarge
            // 
            this.lblExtraLarge.AutoSize = true;
            this.lblExtraLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraLarge.Location = new System.Drawing.Point(68, 151);
            this.lblExtraLarge.Name = "lblExtraLarge";
            this.lblExtraLarge.Size = new System.Drawing.Size(159, 20);
            this.lblExtraLarge.TabIndex = 4;
            this.lblExtraLarge.Text = "Extra Large Pizza = 3";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(28, 198);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(245, 20);
            this.lblToppings.TabIndex = 5;
            this.lblToppings.Text = "How Many Toppings do you want:\r\n";
            // 
            // nupToppings
            // 
            this.nupToppings.Location = new System.Drawing.Point(279, 198);
            this.nupToppings.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nupToppings.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupToppings.Name = "nupToppings";
            this.nupToppings.Size = new System.Drawing.Size(67, 20);
            this.nupToppings.TabIndex = 6;
            this.nupToppings.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblChooseToppings
            // 
            this.lblChooseToppings.AutoSize = true;
            this.lblChooseToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseToppings.Location = new System.Drawing.Point(352, 198);
            this.lblChooseToppings.Name = "lblChooseToppings";
            this.lblChooseToppings.Size = new System.Drawing.Size(196, 20);
            this.lblChooseToppings.TabIndex = 7;
            this.lblChooseToppings.Text = "(Choose between 1 and 5)";
            // 
            // lblSides
            // 
            this.lblSides.AutoSize = true;
            this.lblSides.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSides.Location = new System.Drawing.Point(28, 261);
            this.lblSides.Name = "lblSides";
            this.lblSides.Size = new System.Drawing.Size(173, 20);
            this.lblSides.TabIndex = 8;
            this.lblSides.Text = "What side do you want:";
            // 
            // nupSides
            // 
            this.nupSides.Location = new System.Drawing.Point(207, 261);
            this.nupSides.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nupSides.Name = "nupSides";
            this.nupSides.Size = new System.Drawing.Size(67, 20);
            this.nupSides.TabIndex = 9;
            // 
            // lblNoSide
            // 
            this.lblNoSide.AutoSize = true;
            this.lblNoSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoSide.Location = new System.Drawing.Point(68, 306);
            this.lblNoSide.Name = "lblNoSide";
            this.lblNoSide.Size = new System.Drawing.Size(88, 20);
            this.lblNoSide.TabIndex = 10;
            this.lblNoSide.Text = "No side = 0";
            // 
            // lblPoutine
            // 
            this.lblPoutine.AutoSize = true;
            this.lblPoutine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoutine.Location = new System.Drawing.Point(68, 346);
            this.lblPoutine.Name = "lblPoutine";
            this.lblPoutine.Size = new System.Drawing.Size(89, 20);
            this.lblPoutine.TabIndex = 11;
            this.lblPoutine.Text = "Poutine = 1";
            // 
            // lblWings
            // 
            this.lblWings.AutoSize = true;
            this.lblWings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWings.Location = new System.Drawing.Point(68, 388);
            this.lblWings.Name = "lblWings";
            this.lblWings.Size = new System.Drawing.Size(79, 20);
            this.lblWings.TabIndex = 12;
            this.lblWings.Text = "Wings = 2";
            // 
            // lblFries
            // 
            this.lblFries.AutoSize = true;
            this.lblFries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFries.Location = new System.Drawing.Point(68, 430);
            this.lblFries.Name = "lblFries";
            this.lblFries.Size = new System.Drawing.Size(70, 20);
            this.lblFries.TabIndex = 13;
            this.lblFries.Text = "Fries = 3";
            this.lblFries.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHowManyPizzas
            // 
            this.lblHowManyPizzas.AutoSize = true;
            this.lblHowManyPizzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHowManyPizzas.Location = new System.Drawing.Point(28, 473);
            this.lblHowManyPizzas.Name = "lblHowManyPizzas";
            this.lblHowManyPizzas.Size = new System.Drawing.Size(225, 20);
            this.lblHowManyPizzas.TabIndex = 14;
            this.lblHowManyPizzas.Text = "How many pizzas do you want:";
            // 
            // nupAmountOfPizzas
            // 
            this.nupAmountOfPizzas.Location = new System.Drawing.Point(259, 473);
            this.nupAmountOfPizzas.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nupAmountOfPizzas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupAmountOfPizzas.Name = "nupAmountOfPizzas";
            this.nupAmountOfPizzas.Size = new System.Drawing.Size(67, 20);
            this.nupAmountOfPizzas.TabIndex = 15;
            this.nupAmountOfPizzas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(332, 473);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(196, 20);
            this.lbl.TabIndex = 16;
            this.lbl.Text = "(Choose between 1 and 3)";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(28, 512);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(73, 20);
            this.lblSubtotal.TabIndex = 17;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblSubtotalAns
            // 
            this.lblSubtotalAns.AutoSize = true;
            this.lblSubtotalAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalAns.Location = new System.Drawing.Point(107, 512);
            this.lblSubtotalAns.Name = "lblSubtotalAns";
            this.lblSubtotalAns.Size = new System.Drawing.Size(36, 20);
            this.lblSubtotalAns.TabIndex = 18;
            this.lblSubtotalAns.Text = "???";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(28, 552);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(38, 20);
            this.lblTax.TabIndex = 19;
            this.lblTax.Text = "Tax:";
            // 
            // lblTaxAns
            // 
            this.lblTaxAns.AutoSize = true;
            this.lblTaxAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxAns.Location = new System.Drawing.Point(72, 552);
            this.lblTaxAns.Name = "lblTaxAns";
            this.lblTaxAns.Size = new System.Drawing.Size(36, 20);
            this.lblTaxAns.TabIndex = 20;
            this.lblTaxAns.Text = "???";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(28, 591);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 20);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Total:";
            // 
            // lblTotalAns
            // 
            this.lblTotalAns.AutoSize = true;
            this.lblTotalAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAns.Location = new System.Drawing.Point(82, 591);
            this.lblTotalAns.Name = "lblTotalAns";
            this.lblTotalAns.Size = new System.Drawing.Size(36, 20);
            this.lblTotalAns.TabIndex = 22;
            this.lblTotalAns.Text = "???";
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(640, 95);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(171, 355);
            this.btnOrder.TabIndex = 23;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 667);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblTotalAns);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTaxAns);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubtotalAns);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.nupAmountOfPizzas);
            this.Controls.Add(this.lblHowManyPizzas);
            this.Controls.Add(this.lblFries);
            this.Controls.Add(this.lblWings);
            this.Controls.Add(this.lblPoutine);
            this.Controls.Add(this.lblNoSide);
            this.Controls.Add(this.nupSides);
            this.Controls.Add(this.lblSides);
            this.Controls.Add(this.lblChooseToppings);
            this.Controls.Add(this.nupToppings);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.lblExtraLarge);
            this.Controls.Add(this.lblLarge);
            this.Controls.Add(this.lblMedium);
            this.Controls.Add(this.nupPizzaSize);
            this.Controls.Add(this.lblPizzaSize);
            this.Name = "frmPizzaOrder";
            this.Text = "Pizza Order by Kaelan K";
            ((System.ComponentModel.ISupportInitialize)(this.nupPizzaSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupToppings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSides)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAmountOfPizzas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPizzaSize;
        private System.Windows.Forms.NumericUpDown nupPizzaSize;
        private System.Windows.Forms.Label lblMedium;
        private System.Windows.Forms.Label lblLarge;
        private System.Windows.Forms.Label lblExtraLarge;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.NumericUpDown nupToppings;
        private System.Windows.Forms.Label lblChooseToppings;
        private System.Windows.Forms.Label lblSides;
        private System.Windows.Forms.NumericUpDown nupSides;
        private System.Windows.Forms.Label lblNoSide;
        private System.Windows.Forms.Label lblPoutine;
        private System.Windows.Forms.Label lblWings;
        private System.Windows.Forms.Label lblFries;
        private System.Windows.Forms.Label lblHowManyPizzas;
        private System.Windows.Forms.NumericUpDown nupAmountOfPizzas;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblSubtotalAns;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTaxAns;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalAns;
        private System.Windows.Forms.Button btnOrder;
    }
}

