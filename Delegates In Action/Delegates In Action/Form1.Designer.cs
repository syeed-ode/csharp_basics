using System;

namespace Delegates_In_Action
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
            this.ingredientButton = new System.Windows.Forms.Button();
            this.suzannesDelegateButton = new System.Windows.Forms.Button();
            this.amysDelegateButton = new System.Windows.Forms.Button();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ingredientButton
            // 
            this.ingredientButton.Location = new System.Drawing.Point(12, 30);
            this.ingredientButton.Name = "ingredientButton";
            this.ingredientButton.Size = new System.Drawing.Size(429, 111);
            this.ingredientButton.TabIndex = 0;
            this.ingredientButton.Text = "Get the ingredients";
            this.ingredientButton.UseVisualStyleBackColor = true;
            this.ingredientButton.Click += new System.EventHandler(this.IngredientButton_Click);
            // 
            // suzannesDelegateButton
            // 
            this.suzannesDelegateButton.Location = new System.Drawing.Point(12, 147);
            this.suzannesDelegateButton.Name = "suzannesDelegateButton";
            this.suzannesDelegateButton.Size = new System.Drawing.Size(685, 111);
            this.suzannesDelegateButton.TabIndex = 1;
            this.suzannesDelegateButton.Text = "Get Suzanne\'s delegate";
            this.suzannesDelegateButton.UseVisualStyleBackColor = true;
            this.suzannesDelegateButton.Click += new System.EventHandler(this.SuzannesButton_Click);
            // 
            // amysDelegateButton
            // 
            this.amysDelegateButton.Location = new System.Drawing.Point(12, 264);
            this.amysDelegateButton.Name = "amysDelegateButton";
            this.amysDelegateButton.Size = new System.Drawing.Size(685, 130);
            this.amysDelegateButton.TabIndex = 2;
            this.amysDelegateButton.Text = "Get Amy\'s delegate";
            this.amysDelegateButton.UseVisualStyleBackColor = true;
            this.amysDelegateButton.Click += new System.EventHandler(this.AmysButton_Click);
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.Location = new System.Drawing.Point(532, 63);
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(49, 20);
            this.amountNumericUpDown.TabIndex = 3;
            this.amountNumericUpDown.ValueChanged += new System.EventHandler(this.AmountNumericUpDown_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.amountNumericUpDown);
            this.Controls.Add(this.amysDelegateButton);
            this.Controls.Add(this.suzannesDelegateButton);
            this.Controls.Add(this.ingredientButton);
            this.Name = "Form1";
            this.Text = "Secret Ingredients";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ingredientButton;
        private System.Windows.Forms.Button suzannesDelegateButton;
        private System.Windows.Forms.Button amysDelegateButton;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
    }
}

