namespace OOGSM
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
            this.btnDeelnemers = new System.Windows.Forms.Button();
            this.btnEinde = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAntwoorden = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAantal = new System.Windows.Forms.TextBox();
            this.lblVraag1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txtVraag1 = new System.Windows.Forms.TextBox();
            this.lblVraag2 = new System.Windows.Forms.Label();
            this.txtVraag2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblResultaat1 = new System.Windows.Forms.Label();
            this.lblResultaat2 = new System.Windows.Forms.Label();
            this.lblGsmgebruik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeelnemers
            // 
            this.btnDeelnemers.Location = new System.Drawing.Point(338, 43);
            this.btnDeelnemers.Name = "btnDeelnemers";
            this.btnDeelnemers.Size = new System.Drawing.Size(75, 23);
            this.btnDeelnemers.TabIndex = 0;
            this.btnDeelnemers.Text = "OK";
            this.btnDeelnemers.UseVisualStyleBackColor = true;
            this.btnDeelnemers.Click += new System.EventHandler(this.btnDeelnemers_Click);
            // 
            // btnEinde
            // 
            this.btnEinde.Location = new System.Drawing.Point(338, 267);
            this.btnEinde.Name = "btnEinde";
            this.btnEinde.Size = new System.Drawing.Size(75, 23);
            this.btnEinde.TabIndex = 1;
            this.btnEinde.Text = "Einde";
            this.btnEinde.UseVisualStyleBackColor = true;
            this.btnEinde.Click += new System.EventHandler(this.btnEinde_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(257, 267);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAntwoorden
            // 
            this.btnAntwoorden.Enabled = false;
            this.btnAntwoorden.Location = new System.Drawing.Point(338, 141);
            this.btnAntwoorden.Name = "btnAntwoorden";
            this.btnAntwoorden.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoorden.TabIndex = 3;
            this.btnAntwoorden.Text = "OK";
            this.btnAntwoorden.UseVisualStyleBackColor = true;
            this.btnAntwoorden.Click += new System.EventHandler(this.btnAntwoorden_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enquête: gsm gebruik in klaslokalen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Aantal personen die zullen deelnemen aan de enquête";
            // 
            // txtAantal
            // 
            this.txtAantal.Location = new System.Drawing.Point(282, 45);
            this.txtAantal.MaxLength = 5;
            this.txtAantal.Name = "txtAantal";
            this.txtAantal.Size = new System.Drawing.Size(50, 20);
            this.txtAantal.TabIndex = 6;
            // 
            // lblVraag1
            // 
            this.lblVraag1.AutoSize = true;
            this.lblVraag1.Location = new System.Drawing.Point(12, 92);
            this.lblVraag1.Name = "lblVraag1";
            this.lblVraag1.Size = new System.Drawing.Size(170, 13);
            this.lblVraag1.TabIndex = 7;
            this.lblVraag1.Text = "1. Hebt u een gsm of smartphone?";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(422, 302);
            this.shapeContainer1.TabIndex = 8;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 15;
            this.lineShape1.X2 = 410;
            this.lineShape1.Y1 = 75;
            this.lineShape1.Y2 = 75;
            // 
            // txtVraag1
            // 
            this.txtVraag1.Enabled = false;
            this.txtVraag1.Location = new System.Drawing.Point(282, 89);
            this.txtVraag1.MaxLength = 1;
            this.txtVraag1.Name = "txtVraag1";
            this.txtVraag1.Size = new System.Drawing.Size(50, 20);
            this.txtVraag1.TabIndex = 9;
            // 
            // lblVraag2
            // 
            this.lblVraag2.AutoSize = true;
            this.lblVraag2.Location = new System.Drawing.Point(13, 118);
            this.lblVraag2.Name = "lblVraag2";
            this.lblVraag2.Size = new System.Drawing.Size(243, 13);
            this.lblVraag2.TabIndex = 10;
            this.lblVraag2.Text = "2. Is het gsm-gebruik toegelaten in de leslokalen? ";
            // 
            // txtVraag2
            // 
            this.txtVraag2.Enabled = false;
            this.txtVraag2.Location = new System.Drawing.Point(282, 115);
            this.txtVraag2.MaxLength = 1;
            this.txtVraag2.Name = "txtVraag2";
            this.txtVraag2.Size = new System.Drawing.Size(50, 20);
            this.txtVraag2.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Antwoord met J/j (ja), N/n (nee) of O/o (onverschillig)";
            // 
            // lblResultaat1
            // 
            this.lblResultaat1.AutoSize = true;
            this.lblResultaat1.Location = new System.Drawing.Point(16, 173);
            this.lblResultaat1.Name = "lblResultaat1";
            this.lblResultaat1.Size = new System.Drawing.Size(0, 13);
            this.lblResultaat1.TabIndex = 13;
            // 
            // lblResultaat2
            // 
            this.lblResultaat2.AutoSize = true;
            this.lblResultaat2.Location = new System.Drawing.Point(134, 173);
            this.lblResultaat2.Name = "lblResultaat2";
            this.lblResultaat2.Size = new System.Drawing.Size(0, 13);
            this.lblResultaat2.TabIndex = 14;
            // 
            // lblGsmgebruik
            // 
            this.lblGsmgebruik.AutoSize = true;
            this.lblGsmgebruik.Location = new System.Drawing.Point(16, 244);
            this.lblGsmgebruik.Name = "lblGsmgebruik";
            this.lblGsmgebruik.Size = new System.Drawing.Size(0, 13);
            this.lblGsmgebruik.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 302);
            this.Controls.Add(this.lblGsmgebruik);
            this.Controls.Add(this.lblResultaat2);
            this.Controls.Add(this.lblResultaat1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVraag2);
            this.Controls.Add(this.lblVraag2);
            this.Controls.Add(this.txtVraag1);
            this.Controls.Add(this.lblVraag1);
            this.Controls.Add(this.txtAantal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAntwoorden);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEinde);
            this.Controls.Add(this.btnDeelnemers);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form1";
            this.Text = "GSM gebruik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeelnemers;
        private System.Windows.Forms.Button btnEinde;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAntwoorden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAantal;
        private System.Windows.Forms.Label lblVraag1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox txtVraag1;
        private System.Windows.Forms.Label lblVraag2;
        private System.Windows.Forms.TextBox txtVraag2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblResultaat1;
        private System.Windows.Forms.Label lblResultaat2;
        private System.Windows.Forms.Label lblGsmgebruik;
    }
}

