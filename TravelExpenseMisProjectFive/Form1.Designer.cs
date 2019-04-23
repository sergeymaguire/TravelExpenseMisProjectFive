namespace TravelExpenseMisProjectFive
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
            this.checkBoxBuick = new System.Windows.Forms.CheckBox();
            this.groupBoxAuto = new System.Windows.Forms.GroupBox();
            this.checkBoxChevy = new System.Windows.Forms.CheckBox();
            this.groupBoxRoute = new System.Windows.Forms.GroupBox();
            this.checkBoxCity = new System.Windows.Forms.CheckBox();
            this.checkBoxFreeway = new System.Windows.Forms.CheckBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.lblMpg = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lblTotalMiles = new System.Windows.Forms.Label();
            this.textBoxGasPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.groupBoxAuto.SuspendLayout();
            this.groupBoxRoute.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxBuick
            // 
            this.checkBoxBuick.AutoSize = true;
            this.checkBoxBuick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBuick.Location = new System.Drawing.Point(6, 29);
            this.checkBoxBuick.Name = "checkBoxBuick";
            this.checkBoxBuick.Size = new System.Drawing.Size(89, 17);
            this.checkBoxBuick.TabIndex = 0;
            this.checkBoxBuick.Text = "Buick Electra";
            this.checkBoxBuick.UseVisualStyleBackColor = true;
            // 
            // groupBoxAuto
            // 
            this.groupBoxAuto.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBoxAuto.Controls.Add(this.checkBoxChevy);
            this.groupBoxAuto.Controls.Add(this.checkBoxBuick);
            this.groupBoxAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAuto.Location = new System.Drawing.Point(31, 26);
            this.groupBoxAuto.Name = "groupBoxAuto";
            this.groupBoxAuto.Size = new System.Drawing.Size(183, 123);
            this.groupBoxAuto.TabIndex = 1;
            this.groupBoxAuto.TabStop = false;
            this.groupBoxAuto.Text = "AUTO";
            // 
            // checkBoxChevy
            // 
            this.checkBoxChevy.AutoSize = true;
            this.checkBoxChevy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxChevy.Location = new System.Drawing.Point(6, 63);
            this.checkBoxChevy.Name = "checkBoxChevy";
            this.checkBoxChevy.Size = new System.Drawing.Size(93, 17);
            this.checkBoxChevy.TabIndex = 1;
            this.checkBoxChevy.Text = "Chevy Lumina";
            this.checkBoxChevy.UseVisualStyleBackColor = true;
            // 
            // groupBoxRoute
            // 
            this.groupBoxRoute.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBoxRoute.Controls.Add(this.checkBoxCity);
            this.groupBoxRoute.Controls.Add(this.checkBoxFreeway);
            this.groupBoxRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRoute.Location = new System.Drawing.Point(31, 176);
            this.groupBoxRoute.Name = "groupBoxRoute";
            this.groupBoxRoute.Size = new System.Drawing.Size(183, 123);
            this.groupBoxRoute.TabIndex = 2;
            this.groupBoxRoute.TabStop = false;
            this.groupBoxRoute.Text = "ROUTE";
            // 
            // checkBoxCity
            // 
            this.checkBoxCity.AutoSize = true;
            this.checkBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCity.Location = new System.Drawing.Point(6, 63);
            this.checkBoxCity.Name = "checkBoxCity";
            this.checkBoxCity.Size = new System.Drawing.Size(43, 17);
            this.checkBoxCity.TabIndex = 1;
            this.checkBoxCity.Text = "City";
            this.checkBoxCity.UseVisualStyleBackColor = true;
            // 
            // checkBoxFreeway
            // 
            this.checkBoxFreeway.AutoSize = true;
            this.checkBoxFreeway.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFreeway.Location = new System.Drawing.Point(6, 29);
            this.checkBoxFreeway.Name = "checkBoxFreeway";
            this.checkBoxFreeway.Size = new System.Drawing.Size(66, 17);
            this.checkBoxFreeway.TabIndex = 0;
            this.checkBoxFreeway.Text = "Freeway";
            this.checkBoxFreeway.UseVisualStyleBackColor = true;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(31, 305);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Calc";
            this.btnCalc.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(139, 305);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(296, 89);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(44, 13);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "Mileage";
            // 
            // lblMpg
            // 
            this.lblMpg.AutoSize = true;
            this.lblMpg.Location = new System.Drawing.Point(372, 89);
            this.lblMpg.Name = "lblMpg";
            this.lblMpg.Size = new System.Drawing.Size(52, 13);
            this.lblMpg.TabIndex = 6;
            this.lblMpg.Text = "mpg label";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(296, 136);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(65, 13);
            this.label.TabIndex = 7;
            this.label.Text = "lblTotalMiles";
            // 
            // lblTotalMiles
            // 
            this.lblTotalMiles.AutoSize = true;
            this.lblTotalMiles.Location = new System.Drawing.Point(372, 136);
            this.lblTotalMiles.Name = "lblTotalMiles";
            this.lblTotalMiles.Size = new System.Drawing.Size(65, 13);
            this.lblTotalMiles.TabIndex = 8;
            this.lblTotalMiles.Text = "lblTotalMiles";
            // 
            // textBoxGasPrice
            // 
            this.textBoxGasPrice.Location = new System.Drawing.Point(375, 192);
            this.textBoxGasPrice.Name = "textBoxGasPrice";
            this.textBoxGasPrice.Size = new System.Drawing.Size(61, 20);
            this.textBoxGasPrice.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Gas Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total Cost";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(380, 239);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(55, 13);
            this.lblTotalCost.TabIndex = 12;
            this.lblTotalCost.Text = "Total Cost";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 341);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxGasPrice);
            this.Controls.Add(this.lblTotalMiles);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lblMpg);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.groupBoxRoute);
            this.Controls.Add(this.groupBoxAuto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxAuto.ResumeLayout(false);
            this.groupBoxAuto.PerformLayout();
            this.groupBoxRoute.ResumeLayout(false);
            this.groupBoxRoute.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxBuick;
        private System.Windows.Forms.GroupBox groupBoxAuto;
        private System.Windows.Forms.CheckBox checkBoxChevy;
        private System.Windows.Forms.GroupBox groupBoxRoute;
        private System.Windows.Forms.CheckBox checkBoxCity;
        private System.Windows.Forms.CheckBox checkBoxFreeway;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblMpg;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblTotalMiles;
        private System.Windows.Forms.TextBox textBoxGasPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalCost;
    }
}

