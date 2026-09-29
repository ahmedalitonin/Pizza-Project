namespace Pizza_Project_Cource_14
{
    partial class PizzaCander
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
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarg = new System.Windows.Forms.RadioButton();
            this.rbMedum = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bnResetForm = new System.Windows.Forms.Button();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.laSize = new System.Windows.Forms.Label();
            this.gbToppingsCheck = new System.Windows.Forms.GroupBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnian = new System.Windows.Forms.CheckBox();
            this.chkTomatos = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkExtraChesse = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbOrderSummary = new System.Windows.Forms.GroupBox();
            this.TxToppings = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbToppingsCheck.SuspendLayout();
            this.gbOrderSummary.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.SystemColors.Control;
            this.gbSize.Controls.Add(this.rbLarg);
            this.gbSize.Controls.Add(this.rbMedum);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.Location = new System.Drawing.Point(12, 111);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(152, 170);
            this.gbSize.TabIndex = 13;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbLarg
            // 
            this.rbLarg.AutoSize = true;
            this.rbLarg.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLarg.Location = new System.Drawing.Point(22, 119);
            this.rbLarg.Name = "rbLarg";
            this.rbLarg.Size = new System.Drawing.Size(65, 26);
            this.rbLarg.TabIndex = 7;
            this.rbLarg.Tag = "40";
            this.rbLarg.Text = "Larg";
            this.rbLarg.UseVisualStyleBackColor = true;
            this.rbLarg.CheckedChanged += new System.EventHandler(this.rbLarg_CheckedChanged);
            // 
            // rbMedum
            // 
            this.rbMedum.AutoSize = true;
            this.rbMedum.Checked = true;
            this.rbMedum.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedum.Location = new System.Drawing.Point(22, 78);
            this.rbMedum.Name = "rbMedum";
            this.rbMedum.Size = new System.Drawing.Size(89, 26);
            this.rbMedum.TabIndex = 6;
            this.rbMedum.TabStop = true;
            this.rbMedum.Tag = "30";
            this.rbMedum.Text = "Medum";
            this.rbMedum.UseVisualStyleBackColor = true;
            this.rbMedum.CheckedChanged += new System.EventHandler(this.rbMedum_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSmall.Location = new System.Drawing.Point(22, 33);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(71, 26);
            this.rbSmall.TabIndex = 5;
            this.rbSmall.Tag = "20";
            this.rbSmall.Text = "small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAKE YOUR PIZZA";
            // 
            // bnResetForm
            // 
            this.bnResetForm.BackColor = System.Drawing.Color.Yellow;
            this.bnResetForm.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bnResetForm.Location = new System.Drawing.Point(382, 435);
            this.bnResetForm.Name = "bnResetForm";
            this.bnResetForm.Size = new System.Drawing.Size(144, 40);
            this.bnResetForm.TabIndex = 14;
            this.bnResetForm.Text = "Reset Form";
            this.bnResetForm.UseVisualStyleBackColor = false;
            this.bnResetForm.Click += new System.EventHandler(this.bnResetForm_Click);
            // 
            // gbCrustType
            // 
            this.gbCrustType.BackColor = System.Drawing.SystemColors.Control;
            this.gbCrustType.Controls.Add(this.rbThick);
            this.gbCrustType.Controls.Add(this.rbThin);
            this.gbCrustType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrustType.Location = new System.Drawing.Point(12, 287);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(152, 132);
            this.gbCrustType.TabIndex = 12;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            // 
            // rbThick
            // 
            this.rbThick.AutoSize = true;
            this.rbThick.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThick.Location = new System.Drawing.Point(20, 100);
            this.rbThick.Name = "rbThick";
            this.rbThick.Size = new System.Drawing.Size(73, 26);
            this.rbThick.TabIndex = 9;
            this.rbThick.Tag = "10";
            this.rbThick.Text = "Thick";
            this.rbThick.UseVisualStyleBackColor = true;
            this.rbThick.CheckedChanged += new System.EventHandler(this.rbThick_CheckedChanged);
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Checked = true;
            this.rbThin.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThin.Location = new System.Drawing.Point(21, 45);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(66, 26);
            this.rbThin.TabIndex = 8;
            this.rbThin.TabStop = true;
            this.rbThin.Tag = "0";
            this.rbThin.Text = "Thin";
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.BackColor = System.Drawing.Color.Lime;
            this.btnOrderPizza.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnOrderPizza.Location = new System.Drawing.Point(217, 435);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(144, 40);
            this.btnOrderPizza.TabIndex = 11;
            this.btnOrderPizza.Text = "Oreder Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = false;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // laSize
            // 
            this.laSize.AutoSize = true;
            this.laSize.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laSize.Location = new System.Drawing.Point(758, 130);
            this.laSize.Name = "laSize";
            this.laSize.Size = new System.Drawing.Size(0, 21);
            this.laSize.TabIndex = 22;
            // 
            // gbToppingsCheck
            // 
            this.gbToppingsCheck.BackColor = System.Drawing.SystemColors.Control;
            this.gbToppingsCheck.Controls.Add(this.chkGreenPeppers);
            this.gbToppingsCheck.Controls.Add(this.chkOlives);
            this.gbToppingsCheck.Controls.Add(this.chkOnian);
            this.gbToppingsCheck.Controls.Add(this.chkTomatos);
            this.gbToppingsCheck.Controls.Add(this.chkMushrooms);
            this.gbToppingsCheck.Controls.Add(this.chkExtraChesse);
            this.gbToppingsCheck.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppingsCheck.Location = new System.Drawing.Point(194, 111);
            this.gbToppingsCheck.Name = "gbToppingsCheck";
            this.gbToppingsCheck.Size = new System.Drawing.Size(332, 181);
            this.gbToppingsCheck.TabIndex = 25;
            this.gbToppingsCheck.TabStop = false;
            this.gbToppingsCheck.Text = "Toppings";
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGreenPeppers.Location = new System.Drawing.Point(188, 123);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(146, 26);
            this.chkGreenPeppers.TabIndex = 26;
            this.chkGreenPeppers.Tag = "5";
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOlives.Location = new System.Drawing.Point(188, 80);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(79, 26);
            this.chkOlives.TabIndex = 25;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnian
            // 
            this.chkOnian.AutoSize = true;
            this.chkOnian.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnian.Location = new System.Drawing.Point(188, 37);
            this.chkOnian.Name = "chkOnian";
            this.chkOnian.Size = new System.Drawing.Size(75, 26);
            this.chkOnian.TabIndex = 24;
            this.chkOnian.Tag = "5";
            this.chkOnian.Text = "onian";
            this.chkOnian.UseVisualStyleBackColor = true;
            this.chkOnian.CheckedChanged += new System.EventHandler(this.chkOnian_CheckedChanged);
            // 
            // chkTomatos
            // 
            this.chkTomatos.AutoSize = true;
            this.chkTomatos.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTomatos.Location = new System.Drawing.Point(23, 123);
            this.chkTomatos.Name = "chkTomatos";
            this.chkTomatos.Size = new System.Drawing.Size(110, 26);
            this.chkTomatos.TabIndex = 23;
            this.chkTomatos.Tag = "5";
            this.chkTomatos.Text = "Tomatose";
            this.chkTomatos.UseVisualStyleBackColor = true;
            this.chkTomatos.CheckedChanged += new System.EventHandler(this.chkTomatos_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMushrooms.Location = new System.Drawing.Point(23, 83);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(123, 26);
            this.chkMushrooms.TabIndex = 22;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkExtraChesse
            // 
            this.chkExtraChesse.AutoSize = true;
            this.chkExtraChesse.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExtraChesse.Location = new System.Drawing.Point(23, 35);
            this.chkExtraChesse.Name = "chkExtraChesse";
            this.chkExtraChesse.Size = new System.Drawing.Size(133, 26);
            this.chkExtraChesse.TabIndex = 21;
            this.chkExtraChesse.Tag = "5";
            this.chkExtraChesse.Text = "Extra Chesse";
            this.chkExtraChesse.UseVisualStyleBackColor = true;
            this.chkExtraChesse.CheckedChanged += new System.EventHandler(this.chkExtraChesse_CheckedChanged);
            // 
            // gbOrderSummary
            // 
            this.gbOrderSummary.BackColor = System.Drawing.SystemColors.Control;
            this.gbOrderSummary.Controls.Add(this.TxToppings);
            this.gbOrderSummary.Controls.Add(this.lblTotalPrice);
            this.gbOrderSummary.Controls.Add(this.label6);
            this.gbOrderSummary.Controls.Add(this.lblWhereToEat);
            this.gbOrderSummary.Controls.Add(this.lblCrustType);
            this.gbOrderSummary.Controls.Add(this.label5);
            this.gbOrderSummary.Controls.Add(this.label4);
            this.gbOrderSummary.Controls.Add(this.lblSize);
            this.gbOrderSummary.Controls.Add(this.label3);
            this.gbOrderSummary.Controls.Add(this.label2);
            this.gbOrderSummary.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.gbOrderSummary.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbOrderSummary.Location = new System.Drawing.Point(548, 111);
            this.gbOrderSummary.Name = "gbOrderSummary";
            this.gbOrderSummary.Size = new System.Drawing.Size(295, 372);
            this.gbOrderSummary.TabIndex = 31;
            this.gbOrderSummary.TabStop = false;
            this.gbOrderSummary.Text = "Order Summary";
            // 
            // TxToppings
            // 
            this.TxToppings.BackColor = System.Drawing.SystemColors.Control;
            this.TxToppings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxToppings.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxToppings.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxToppings.Location = new System.Drawing.Point(27, 92);
            this.TxToppings.Multiline = true;
            this.TxToppings.Name = "TxToppings";
            this.TxToppings.ReadOnly = true;
            this.TxToppings.Size = new System.Drawing.Size(262, 62);
            this.TxToppings.TabIndex = 41;
            this.TxToppings.TextChanged += new System.EventHandler(this.TxToppings_TextChanged);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(77, 294);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(76, 52);
            this.lblTotalPrice.TabIndex = 40;
            this.lblTotalPrice.Text = "$0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(6, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 23);
            this.label6.TabIndex = 39;
            this.label6.Text = "Total Price:";
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.BackColor = System.Drawing.SystemColors.Control;
            this.lblWhereToEat.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereToEat.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblWhereToEat.Location = new System.Drawing.Point(97, 227);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(65, 22);
            this.lblWhereToEat.TabIndex = 38;
            this.lblWhereToEat.Text = "Eat In";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.BackColor = System.Drawing.SystemColors.Control;
            this.lblCrustType.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustType.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblCrustType.Location = new System.Drawing.Point(136, 157);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(103, 22);
            this.lblCrustType.TabIndex = 37;
            this.lblCrustType.Text = "Thin Crust";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(23, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 23);
            this.label5.TabIndex = 36;
            this.label5.Text = "Where To Eat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(23, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Crust Type:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.BackColor = System.Drawing.SystemColors.Control;
            this.lblSize.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblSize.Location = new System.Drawing.Point(81, 33);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(77, 22);
            this.lblSize.TabIndex = 34;
            this.lblSize.Text = "Medum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "Toppings:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(24, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "Size:";
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.BackColor = System.Drawing.SystemColors.Control;
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWhereToEat.Location = new System.Drawing.Point(217, 300);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(248, 92);
            this.gbWhereToEat.TabIndex = 34;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTakeOut.Location = new System.Drawing.Point(118, 36);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(104, 26);
            this.rbTakeOut.TabIndex = 35;
            this.rbTakeOut.Tag = "30";
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Checked = true;
            this.rbEatIn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEatIn.Location = new System.Drawing.Point(13, 36);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(79, 26);
            this.rbEatIn.TabIndex = 34;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Tag = "20";
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Image = global::Pizza_Project_Cource_14.Properties.Resources.pizza2;
            this.label7.Location = new System.Drawing.Point(745, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 35;
            // 
            // PizzaCander
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Pizza_Project_Cource_14.Properties.Resources.Pizza1;
            this.ClientSize = new System.Drawing.Size(869, 527);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbOrderSummary);
            this.Controls.Add(this.gbToppingsCheck);
            this.Controls.Add(this.laSize);
            this.Controls.Add(this.bnResetForm);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.label1);
            this.Name = "PizzaCander";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Pizza Cander";
            this.Load += new System.EventHandler(this.PizzaCander_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbToppingsCheck.ResumeLayout(false);
            this.gbToppingsCheck.PerformLayout();
            this.gbOrderSummary.ResumeLayout(false);
            this.gbOrderSummary.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnResetForm;
        private System.Windows.Forms.RadioButton rbLarg;
        private System.Windows.Forms.RadioButton rbMedum;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Label laSize;
        private System.Windows.Forms.GroupBox gbToppingsCheck;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnian;
        private System.Windows.Forms.CheckBox chkTomatos;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkExtraChesse;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbOrderSummary;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.TextBox TxToppings;
        private System.Windows.Forms.Label label7;
    }
}

