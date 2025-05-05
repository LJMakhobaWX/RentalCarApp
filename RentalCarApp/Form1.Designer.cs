namespace RentalCarApp
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblCName = new System.Windows.Forms.Label();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.lblCarRented = new System.Windows.Forms.Label();
            this.dtpDateRented = new System.Windows.Forms.DateTimePicker();
            this.lblTypeOfCar = new System.Windows.Forms.Label();
            this.cmbTypeOfCar = new System.Windows.Forms.ComboBox();
            this.lblDateReturned = new System.Windows.Forms.Label();
            this.dtpDateReturned = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblStrip = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(172, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(444, 93);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Rental Car System";
            // 
            // lblCName
            // 
            this.lblCName.AutoSize = true;
            this.lblCName.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCName.Location = new System.Drawing.Point(29, 122);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(133, 32);
            this.lblCName.TabIndex = 1;
            this.lblCName.Text = "Customer Name";
            // 
            // txtCName
            // 
            this.txtCName.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCName.Location = new System.Drawing.Point(35, 157);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(246, 31);
            this.txtCName.TabIndex = 2;
            // 
            // lblCarRented
            // 
            this.lblCarRented.AutoSize = true;
            this.lblCarRented.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarRented.Location = new System.Drawing.Point(29, 213);
            this.lblCarRented.Name = "lblCarRented";
            this.lblCarRented.Size = new System.Drawing.Size(105, 32);
            this.lblCarRented.TabIndex = 3;
            this.lblCarRented.Text = "Date Rented";
            // 
            // dtpDateRented
            // 
            this.dtpDateRented.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateRented.Location = new System.Drawing.Point(32, 248);
            this.dtpDateRented.Name = "dtpDateRented";
            this.dtpDateRented.Size = new System.Drawing.Size(249, 31);
            this.dtpDateRented.TabIndex = 4;
            // 
            // lblTypeOfCar
            // 
            this.lblTypeOfCar.AutoSize = true;
            this.lblTypeOfCar.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeOfCar.Location = new System.Drawing.Point(29, 311);
            this.lblTypeOfCar.Name = "lblTypeOfCar";
            this.lblTypeOfCar.Size = new System.Drawing.Size(101, 32);
            this.lblTypeOfCar.TabIndex = 5;
            this.lblTypeOfCar.Text = "Type of Car";
            // 
            // cmbTypeOfCar
            // 
            this.cmbTypeOfCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeOfCar.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTypeOfCar.FormattingEnabled = true;
            this.cmbTypeOfCar.Location = new System.Drawing.Point(32, 357);
            this.cmbTypeOfCar.Name = "cmbTypeOfCar";
            this.cmbTypeOfCar.Size = new System.Drawing.Size(249, 31);
            this.cmbTypeOfCar.TabIndex = 6;
            // 
            // lblDateReturned
            // 
            this.lblDateReturned.AutoSize = true;
            this.lblDateReturned.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReturned.Location = new System.Drawing.Point(517, 213);
            this.lblDateReturned.Name = "lblDateReturned";
            this.lblDateReturned.Size = new System.Drawing.Size(121, 32);
            this.lblDateReturned.TabIndex = 7;
            this.lblDateReturned.Text = "Date Returned";
            // 
            // dtpDateReturned
            // 
            this.dtpDateReturned.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateReturned.Location = new System.Drawing.Point(523, 248);
            this.dtpDateReturned.Name = "dtpDateReturned";
            this.dtpDateReturned.Size = new System.Drawing.Size(249, 31);
            this.dtpDateReturned.TabIndex = 8;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(523, 292);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(249, 96);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblStrip
            // 
            this.lblStrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblStrip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrip.Location = new System.Drawing.Point(32, 202);
            this.lblStrip.Name = "lblStrip";
            this.lblStrip.Size = new System.Drawing.Size(740, 3);
            this.lblStrip.TabIndex = 10;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(517, 122);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(48, 32);
            this.lblCost.TabIndex = 11;
            this.lblCost.Text = "Cost";
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(523, 157);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(246, 31);
            this.txtCost.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblStrip);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dtpDateReturned);
            this.Controls.Add(this.lblDateReturned);
            this.Controls.Add(this.cmbTypeOfCar);
            this.Controls.Add(this.lblTypeOfCar);
            this.Controls.Add(this.dtpDateRented);
            this.Controls.Add(this.lblCarRented);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.lblCName);
            this.Controls.Add(this.lblHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Rental Car System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.Label lblCarRented;
        private System.Windows.Forms.DateTimePicker dtpDateRented;
        private System.Windows.Forms.Label lblTypeOfCar;
        private System.Windows.Forms.ComboBox cmbTypeOfCar;
        private System.Windows.Forms.Label lblDateReturned;
        private System.Windows.Forms.DateTimePicker dtpDateReturned;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblStrip;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtCost;
    }
}

