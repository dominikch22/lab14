
namespace lab14
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
            this.nameA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ageA = new System.Windows.Forms.TextBox();
            this.nameB = new System.Windows.Forms.TextBox();
            this.ageB = new System.Windows.Forms.TextBox();
            this.nameC = new System.Windows.Forms.TextBox();
            this.ageC = new System.Windows.Forms.TextBox();
            this.showPersonButton = new System.Windows.Forms.Button();
            this.sortPersonButton = new System.Windows.Forms.Button();
            this.A = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.C = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.showIntButton = new System.Windows.Forms.Button();
            this.sortIntButton = new System.Windows.Forms.Button();
            this.personShow = new System.Windows.Forms.Label();
            this.personSorted = new System.Windows.Forms.Label();
            this.intShow = new System.Windows.Forms.Label();
            this.intSort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameA
            // 
            this.nameA.Location = new System.Drawing.Point(12, 40);
            this.nameA.Name = "nameA";
            this.nameA.Size = new System.Drawing.Size(100, 20);
            this.nameA.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trzy osoby (imię, wiek)";
            // 
            // ageA
            // 
            this.ageA.Location = new System.Drawing.Point(119, 39);
            this.ageA.Name = "ageA";
            this.ageA.Size = new System.Drawing.Size(100, 20);
            this.ageA.TabIndex = 2;
            // 
            // nameB
            // 
            this.nameB.Location = new System.Drawing.Point(12, 67);
            this.nameB.Name = "nameB";
            this.nameB.Size = new System.Drawing.Size(100, 20);
            this.nameB.TabIndex = 3;
            // 
            // ageB
            // 
            this.ageB.Location = new System.Drawing.Point(119, 66);
            this.ageB.Name = "ageB";
            this.ageB.Size = new System.Drawing.Size(100, 20);
            this.ageB.TabIndex = 4;
            // 
            // nameC
            // 
            this.nameC.Location = new System.Drawing.Point(12, 94);
            this.nameC.Name = "nameC";
            this.nameC.Size = new System.Drawing.Size(100, 20);
            this.nameC.TabIndex = 5;
            // 
            // ageC
            // 
            this.ageC.Location = new System.Drawing.Point(119, 93);
            this.ageC.Name = "ageC";
            this.ageC.Size = new System.Drawing.Size(100, 20);
            this.ageC.TabIndex = 6;
            // 
            // showPersonButton
            // 
            this.showPersonButton.Location = new System.Drawing.Point(15, 121);
            this.showPersonButton.Name = "showPersonButton";
            this.showPersonButton.Size = new System.Drawing.Size(75, 23);
            this.showPersonButton.TabIndex = 7;
            this.showPersonButton.Text = "Wyswietl";
            this.showPersonButton.UseVisualStyleBackColor = true;
            this.showPersonButton.Click += new System.EventHandler(this.showPersonButton_Click);
            // 
            // sortPersonButton
            // 
            this.sortPersonButton.Location = new System.Drawing.Point(15, 151);
            this.sortPersonButton.Name = "sortPersonButton";
            this.sortPersonButton.Size = new System.Drawing.Size(75, 23);
            this.sortPersonButton.TabIndex = 8;
            this.sortPersonButton.Text = "Sortuj";
            this.sortPersonButton.UseVisualStyleBackColor = true;
            this.sortPersonButton.Click += new System.EventHandler(this.sortPersonButton_Click);
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(600, 40);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(100, 20);
            this.A.TabIndex = 9;
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(600, 68);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(100, 20);
            this.B.TabIndex = 10;
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(600, 95);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(100, 20);
            this.C.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(597, 10);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Trzy liczby";
            // 
            // showIntButton
            // 
            this.showIntButton.Location = new System.Drawing.Point(600, 122);
            this.showIntButton.Name = "showIntButton";
            this.showIntButton.Size = new System.Drawing.Size(75, 23);
            this.showIntButton.TabIndex = 13;
            this.showIntButton.Text = "Wyswietl";
            this.showIntButton.UseVisualStyleBackColor = true;
            this.showIntButton.Click += new System.EventHandler(this.showIntButton_Click);
            // 
            // sortIntButton
            // 
            this.sortIntButton.Location = new System.Drawing.Point(600, 152);
            this.sortIntButton.Name = "sortIntButton";
            this.sortIntButton.Size = new System.Drawing.Size(75, 23);
            this.sortIntButton.TabIndex = 14;
            this.sortIntButton.Text = "Sortuj";
            this.sortIntButton.UseVisualStyleBackColor = true;
            this.sortIntButton.Click += new System.EventHandler(this.sortIntButton_Click);
            // 
            // personShow
            // 
            this.personShow.AutoSize = true;
            this.personShow.Location = new System.Drawing.Point(96, 126);
            this.personShow.Name = "personShow";
            this.personShow.Size = new System.Drawing.Size(35, 13);
            this.personShow.TabIndex = 15;
            this.personShow.Text = "label3";
            // 
            // personSorted
            // 
            this.personSorted.AutoSize = true;
            this.personSorted.Location = new System.Drawing.Point(96, 156);
            this.personSorted.Name = "personSorted";
            this.personSorted.Size = new System.Drawing.Size(35, 13);
            this.personSorted.TabIndex = 16;
            this.personSorted.Text = "label4";
            // 
            // intShow
            // 
            this.intShow.AutoSize = true;
            this.intShow.Location = new System.Drawing.Point(681, 127);
            this.intShow.Name = "intShow";
            this.intShow.Size = new System.Drawing.Size(35, 13);
            this.intShow.TabIndex = 18;
            this.intShow.Text = "label6";
            // 
            // intSort
            // 
            this.intSort.AutoSize = true;
            this.intSort.Location = new System.Drawing.Point(681, 157);
            this.intSort.Name = "intSort";
            this.intSort.Size = new System.Drawing.Size(35, 13);
            this.intSort.TabIndex = 19;
            this.intSort.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.intSort);
            this.Controls.Add(this.intShow);
            this.Controls.Add(this.personSorted);
            this.Controls.Add(this.personShow);
            this.Controls.Add(this.sortIntButton);
            this.Controls.Add(this.showIntButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.C);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Controls.Add(this.sortPersonButton);
            this.Controls.Add(this.showPersonButton);
            this.Controls.Add(this.ageC);
            this.Controls.Add(this.nameC);
            this.Controls.Add(this.ageB);
            this.Controls.Add(this.nameB);
            this.Controls.Add(this.ageA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameA);
            this.Name = "Form1";
            this.Text = "Trojka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ageA;
        private System.Windows.Forms.TextBox nameB;
        private System.Windows.Forms.TextBox ageB;
        private System.Windows.Forms.TextBox nameC;
        private System.Windows.Forms.TextBox ageC;
        private System.Windows.Forms.Button showPersonButton;
        private System.Windows.Forms.Button sortPersonButton;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.TextBox C;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button showIntButton;
        private System.Windows.Forms.Button sortIntButton;
        private System.Windows.Forms.Label personShow;
        private System.Windows.Forms.Label personSorted;
        private System.Windows.Forms.Label intShow;
        private System.Windows.Forms.Label intSort;
    }
}

