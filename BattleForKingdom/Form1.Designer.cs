
namespace BattleForKingdom
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
            this.MENU = new System.Windows.Forms.Label();
            this.menü = new System.Windows.Forms.Panel();
            this.btn_lore = new System.Windows.Forms.PictureBox();
            this.btn_back = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menü.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_lore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_start)).BeginInit();
            this.SuspendLayout();
            // 
            // MENU
            // 
            this.MENU.AutoSize = true;
            this.MENU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MENU.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MENU.ForeColor = System.Drawing.Color.DarkOrange;
            this.MENU.Location = new System.Drawing.Point(64, 0);
            this.MENU.Name = "MENU";
            this.MENU.Size = new System.Drawing.Size(115, 44);
            this.MENU.TabIndex = 0;
            this.MENU.Text = "MENU";
            this.MENU.Click += new System.EventHandler(this.label1_Click);
            // 
            // menü
            // 
            this.menü.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menü.Controls.Add(this.btn_lore);
            this.menü.Controls.Add(this.btn_back);
            this.menü.Controls.Add(this.btn_start);
            this.menü.Controls.Add(this.MENU);
            this.menü.Location = new System.Drawing.Point(60, 96);
            this.menü.Name = "menü";
            this.menü.Size = new System.Drawing.Size(253, 285);
            this.menü.TabIndex = 1;
            // 
            // btn_lore
            // 
            this.btn_lore.BackColor = System.Drawing.Color.Transparent;
            this.btn_lore.Image = global::BattleForKingdom.Properties.Resources.LORE2;
            this.btn_lore.Location = new System.Drawing.Point(84, 200);
            this.btn_lore.Name = "btn_lore";
            this.btn_lore.Size = new System.Drawing.Size(86, 53);
            this.btn_lore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_lore.TabIndex = 2;
            this.btn_lore.TabStop = false;
            this.btn_lore.Click += new System.EventHandler(this.btn_lore_Click);
            // 
            // btn_back
            // 
            this.btn_back.Image = global::BattleForKingdom.Properties.Resources.BACKK;
            this.btn_back.Location = new System.Drawing.Point(64, 135);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(120, 35);
            this.btn_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_back.TabIndex = 2;
            this.btn_back.TabStop = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            this.btn_back.MouseLeave += new System.EventHandler(this.btn_back_MouseLeave);
            this.btn_back.MouseHover += new System.EventHandler(this.btn_back_MouseHover);
            // 
            // btn_start
            // 
            this.btn_start.Image = global::BattleForKingdom.Properties.Resources.STARTT;
            this.btn_start.Location = new System.Drawing.Point(64, 73);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(118, 34);
            this.btn_start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_start.TabIndex = 1;
            this.btn_start.TabStop = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            this.btn_start.MouseLeave += new System.EventHandler(this.btn_start_MouseLeave);
            this.btn_start.MouseHover += new System.EventHandler(this.btn_start_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "BATTLE FOR KİNGDOM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(394, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menü);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menü.ResumeLayout(false);
            this.menü.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_lore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_start)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MENU;
        private System.Windows.Forms.Panel menü;
        private System.Windows.Forms.PictureBox btn_back;
        private System.Windows.Forms.PictureBox btn_start;
        private System.Windows.Forms.PictureBox btn_lore;
        private System.Windows.Forms.Label label1;
    }
}

