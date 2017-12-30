namespace AoM.ESO
{
    partial class RatingForm
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
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblLoser = new System.Windows.Forms.Label();
            this.tbWinner = new System.Windows.Forms.TextBox();
            this.tbLoser = new System.Windows.Forms.TextBox();
            this.tbWinnerNew = new System.Windows.Forms.TextBox();
            this.tbLoserNew = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Location = new System.Drawing.Point(12, 9);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(41, 13);
            this.lblWinner.TabIndex = 0;
            this.lblWinner.Text = "Winner";
            // 
            // lblLoser
            // 
            this.lblLoser.AutoSize = true;
            this.lblLoser.Location = new System.Drawing.Point(12, 35);
            this.lblLoser.Name = "lblLoser";
            this.lblLoser.Size = new System.Drawing.Size(33, 13);
            this.lblLoser.TabIndex = 1;
            this.lblLoser.Text = "Loser";
            // 
            // tbWinner
            // 
            this.tbWinner.Location = new System.Drawing.Point(59, 6);
            this.tbWinner.Name = "tbWinner";
            this.tbWinner.Size = new System.Drawing.Size(92, 20);
            this.tbWinner.TabIndex = 2;
            this.tbWinner.Text = "1600";
            this.tbWinner.Validating += new System.ComponentModel.CancelEventHandler(this.tbRate_Validating);
            // 
            // tbLoser
            // 
            this.tbLoser.Location = new System.Drawing.Point(59, 32);
            this.tbLoser.Name = "tbLoser";
            this.tbLoser.Size = new System.Drawing.Size(92, 20);
            this.tbLoser.TabIndex = 3;
            this.tbLoser.Text = "1600";
            this.tbLoser.Validating += new System.ComponentModel.CancelEventHandler(this.tbRate_Validating);
            // 
            // tbWinnerNew
            // 
            this.tbWinnerNew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWinnerNew.Location = new System.Drawing.Point(157, 6);
            this.tbWinnerNew.Name = "tbWinnerNew";
            this.tbWinnerNew.ReadOnly = true;
            this.tbWinnerNew.Size = new System.Drawing.Size(95, 20);
            this.tbWinnerNew.TabIndex = 4;
            // 
            // tbLoserNew
            // 
            this.tbLoserNew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLoserNew.Location = new System.Drawing.Point(157, 32);
            this.tbLoserNew.Name = "tbLoserNew";
            this.tbLoserNew.ReadOnly = true;
            this.tbLoserNew.Size = new System.Drawing.Size(95, 20);
            this.tbLoserNew.TabIndex = 5;
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(12, 58);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(240, 23);
            this.btnGo.TabIndex = 6;
            this.btnGo.Text = "Calculate";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // RatingForm
            // 
            this.AcceptButton = this.btnGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 93);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.tbLoserNew);
            this.Controls.Add(this.tbWinnerNew);
            this.Controls.Add(this.tbLoser);
            this.Controls.Add(this.tbWinner);
            this.Controls.Add(this.lblLoser);
            this.Controls.Add(this.lblWinner);
            this.MaximizeBox = false;
            this.Name = "RatingForm";
            this.Text = "Rating Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label lblLoser;
        private System.Windows.Forms.TextBox tbWinner;
        private System.Windows.Forms.TextBox tbLoser;
        private System.Windows.Forms.TextBox tbWinnerNew;
        private System.Windows.Forms.TextBox tbLoserNew;
        private System.Windows.Forms.Button btnGo;
    }
}