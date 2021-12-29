
namespace ProgettoNatale
{
    partial class Azioni_Babbo_Natale
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
            this.View_Kids = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.View_Gifts = new System.Windows.Forms.Button();
            this.See_Map = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // View_Kids
            // 
            this.View_Kids.BackColor = System.Drawing.Color.Chocolate;
            this.View_Kids.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_Kids.ForeColor = System.Drawing.Color.White;
            this.View_Kids.Location = new System.Drawing.Point(32, 137);
            this.View_Kids.Margin = new System.Windows.Forms.Padding(2);
            this.View_Kids.Name = "View_Kids";
            this.View_Kids.Size = new System.Drawing.Size(195, 93);
            this.View_Kids.TabIndex = 0;
            this.View_Kids.Text = "BAMBINI";
            this.View_Kids.UseVisualStyleBackColor = false;
            this.View_Kids.Click += new System.EventHandler(this.View_Kids_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(24, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menù";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.Chocolate;
            this.Search.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(371, 137);
            this.Search.Margin = new System.Windows.Forms.Padding(2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(195, 93);
            this.Search.TabIndex = 2;
            this.Search.Text = "RICERCA";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // View_Gifts
            // 
            this.View_Gifts.BackColor = System.Drawing.Color.Chocolate;
            this.View_Gifts.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_Gifts.ForeColor = System.Drawing.Color.White;
            this.View_Gifts.Location = new System.Drawing.Point(32, 261);
            this.View_Gifts.Margin = new System.Windows.Forms.Padding(2);
            this.View_Gifts.Name = "View_Gifts";
            this.View_Gifts.Size = new System.Drawing.Size(195, 93);
            this.View_Gifts.TabIndex = 3;
            this.View_Gifts.Text = "REGALI";
            this.View_Gifts.UseVisualStyleBackColor = false;
            this.View_Gifts.Click += new System.EventHandler(this.View_Gifts_Click);
            // 
            // See_Map
            // 
            this.See_Map.BackColor = System.Drawing.Color.Chocolate;
            this.See_Map.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.See_Map.ForeColor = System.Drawing.Color.White;
            this.See_Map.Location = new System.Drawing.Point(371, 261);
            this.See_Map.Margin = new System.Windows.Forms.Padding(2);
            this.See_Map.Name = "See_Map";
            this.See_Map.Size = new System.Drawing.Size(195, 93);
            this.See_Map.TabIndex = 4;
            this.See_Map.Text = "MAPPA";
            this.See_Map.UseVisualStyleBackColor = false;
            this.See_Map.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(66, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(469, 85);
            this.label2.TabIndex = 9;
            this.label2.Text = "Christmas System";
            // 
            // Azioni_Babbo_Natale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProgettoNatale.Properties.Resources.Sfondo_Azioni_modificato_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(603, 375);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.See_Map);
            this.Controls.Add(this.View_Gifts);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.View_Kids);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(619, 414);
            this.MinimumSize = new System.Drawing.Size(619, 414);
            this.Name = "Azioni_Babbo_Natale";
            this.Text = "Azioni";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button View_Kids;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button View_Gifts;
        private System.Windows.Forms.Button See_Map;
        private System.Windows.Forms.Label label2;
    }
}