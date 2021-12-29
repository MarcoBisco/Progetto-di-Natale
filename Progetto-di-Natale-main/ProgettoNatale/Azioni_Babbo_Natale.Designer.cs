namespace ProgettoNatale
{
    partial class Azioni_elfo
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
            this.View_Gifts = new System.Windows.Forms.Button();
            this.View_Kids = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // View_Gifts
            // 
            this.View_Gifts.BackColor = System.Drawing.Color.Chocolate;
            this.View_Gifts.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_Gifts.ForeColor = System.Drawing.Color.White;
            this.View_Gifts.Location = new System.Drawing.Point(27, 265);
            this.View_Gifts.Margin = new System.Windows.Forms.Padding(2);
            this.View_Gifts.Name = "View_Gifts";
            this.View_Gifts.Size = new System.Drawing.Size(195, 93);
            this.View_Gifts.TabIndex = 5;
            this.View_Gifts.Text = "REGALI";
            this.View_Gifts.UseVisualStyleBackColor = false;
            // 
            // View_Kids
            // 
            this.View_Kids.BackColor = System.Drawing.Color.Chocolate;
            this.View_Kids.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.View_Kids.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_Kids.ForeColor = System.Drawing.Color.White;
            this.View_Kids.Location = new System.Drawing.Point(27, 142);
            this.View_Kids.Margin = new System.Windows.Forms.Padding(2);
            this.View_Kids.Name = "View_Kids";
            this.View_Kids.Size = new System.Drawing.Size(195, 93);
            this.View_Kids.TabIndex = 4;
            this.View_Kids.Text = "BAMBINI";
            this.View_Kids.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Chocolate;
            this.button2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(293, 142);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 93);
            this.button2.TabIndex = 6;
            this.button2.Text = "IMPOSTAZIONI PROFILO";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(19, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 47);
            this.label1.TabIndex = 7;
            this.label1.Text = "Menù";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(61, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(469, 85);
            this.label2.TabIndex = 8;
            this.label2.Text = "Christmas System";
            // 
            // Azioni_elfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProgettoNatale.Properties.Resources.Sfondo_Azioni_modificato_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(563, 378);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.View_Gifts);
            this.Controls.Add(this.View_Kids);
            this.Name = "Azioni_elfo";
            this.Text = "Azioni";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button View_Gifts;
        private System.Windows.Forms.Button View_Kids;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}