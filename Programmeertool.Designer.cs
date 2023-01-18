namespace Project_programmeertool
{
    partial class frmLoopgenerator
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
            this.components = new System.ComponentModel.Container();
            this.gbxForWhile = new System.Windows.Forms.GroupBox();
            this.rdbWhile = new System.Windows.Forms.RadioButton();
            this.rdbFor = new System.Windows.Forms.RadioButton();
            this.gbxStart = new System.Windows.Forms.GroupBox();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.gbxEnd = new System.Windows.Forms.GroupBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.rdbSmallerEqual = new System.Windows.Forms.RadioButton();
            this.rdbGreaterEqual = new System.Windows.Forms.RadioButton();
            this.rdbSmaller = new System.Windows.Forms.RadioButton();
            this.rdbGreater = new System.Windows.Forms.RadioButton();
            this.gbxIncrement = new System.Windows.Forms.GroupBox();
            this.txtIncrement = new System.Windows.Forms.TextBox();
            this.lblIncrement = new System.Windows.Forms.Label();
            this.rdbMin = new System.Windows.Forms.RadioButton();
            this.rdbPlus = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.gbxForWhile.SuspendLayout();
            this.gbxStart.SuspendLayout();
            this.gbxEnd.SuspendLayout();
            this.gbxIncrement.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxForWhile
            // 
            this.gbxForWhile.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gbxForWhile.Controls.Add(this.rdbWhile);
            this.gbxForWhile.Controls.Add(this.rdbFor);
            this.gbxForWhile.Location = new System.Drawing.Point(12, 12);
            this.gbxForWhile.Name = "gbxForWhile";
            this.gbxForWhile.Size = new System.Drawing.Size(133, 100);
            this.gbxForWhile.TabIndex = 0;
            this.gbxForWhile.TabStop = false;
            this.gbxForWhile.Text = "1. For loop or while loop";
            // 
            // rdbWhile
            // 
            this.rdbWhile.AutoSize = true;
            this.rdbWhile.Location = new System.Drawing.Point(64, 41);
            this.rdbWhile.Name = "rdbWhile";
            this.rdbWhile.Size = new System.Drawing.Size(52, 17);
            this.rdbWhile.TabIndex = 1;
            this.rdbWhile.TabStop = true;
            this.rdbWhile.Text = "While";
            this.rdbWhile.UseVisualStyleBackColor = true;
            // 
            // rdbFor
            // 
            this.rdbFor.AutoSize = true;
            this.rdbFor.Location = new System.Drawing.Point(18, 41);
            this.rdbFor.Name = "rdbFor";
            this.rdbFor.Size = new System.Drawing.Size(40, 17);
            this.rdbFor.TabIndex = 0;
            this.rdbFor.TabStop = true;
            this.rdbFor.Text = "For";
            this.rdbFor.UseVisualStyleBackColor = true;
            // 
            // gbxStart
            // 
            this.gbxStart.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gbxStart.Controls.Add(this.txtStart);
            this.gbxStart.Controls.Add(this.lblStart);
            this.gbxStart.Location = new System.Drawing.Point(167, 13);
            this.gbxStart.Name = "gbxStart";
            this.gbxStart.Size = new System.Drawing.Size(148, 100);
            this.gbxStart.TabIndex = 1;
            this.gbxStart.TabStop = false;
            this.gbxStart.Text = "2. Choose a starting value";
            // 
            // txtStart
            // 
            this.txtStart.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtStart.Location = new System.Drawing.Point(80, 40);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(62, 20);
            this.txtStart.TabIndex = 1;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(6, 43);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(75, 13);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "Starting value:";
            // 
            // gbxEnd
            // 
            this.gbxEnd.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gbxEnd.Controls.Add(this.txtEnd);
            this.gbxEnd.Controls.Add(this.lblEnd);
            this.gbxEnd.Controls.Add(this.rdbSmallerEqual);
            this.gbxEnd.Controls.Add(this.rdbGreaterEqual);
            this.gbxEnd.Controls.Add(this.rdbSmaller);
            this.gbxEnd.Controls.Add(this.rdbGreater);
            this.gbxEnd.Location = new System.Drawing.Point(338, 13);
            this.gbxEnd.Name = "gbxEnd";
            this.gbxEnd.Size = new System.Drawing.Size(154, 100);
            this.gbxEnd.TabIndex = 2;
            this.gbxEnd.TabStop = false;
            this.gbxEnd.Text = "3. Choose an end value";
            // 
            // txtEnd
            // 
            this.txtEnd.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtEnd.Location = new System.Drawing.Point(70, 66);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(62, 20);
            this.txtEnd.TabIndex = 6;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(6, 69);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(58, 13);
            this.lblEnd.TabIndex = 5;
            this.lblEnd.Text = "End value:";
            // 
            // rdbSmallerEqual
            // 
            this.rdbSmallerEqual.AutoSize = true;
            this.rdbSmallerEqual.Location = new System.Drawing.Point(102, 43);
            this.rdbSmallerEqual.Name = "rdbSmallerEqual";
            this.rdbSmallerEqual.Size = new System.Drawing.Size(37, 17);
            this.rdbSmallerEqual.TabIndex = 4;
            this.rdbSmallerEqual.TabStop = true;
            this.rdbSmallerEqual.Text = "<=";
            this.rdbSmallerEqual.UseVisualStyleBackColor = true;
            // 
            // rdbGreaterEqual
            // 
            this.rdbGreaterEqual.AutoSize = true;
            this.rdbGreaterEqual.Location = new System.Drawing.Point(102, 19);
            this.rdbGreaterEqual.Name = "rdbGreaterEqual";
            this.rdbGreaterEqual.Size = new System.Drawing.Size(37, 17);
            this.rdbGreaterEqual.TabIndex = 3;
            this.rdbGreaterEqual.TabStop = true;
            this.rdbGreaterEqual.Text = ">=";
            this.rdbGreaterEqual.UseVisualStyleBackColor = true;
            // 
            // rdbSmaller
            // 
            this.rdbSmaller.AutoSize = true;
            this.rdbSmaller.Location = new System.Drawing.Point(6, 41);
            this.rdbSmaller.Name = "rdbSmaller";
            this.rdbSmaller.Size = new System.Drawing.Size(31, 17);
            this.rdbSmaller.TabIndex = 1;
            this.rdbSmaller.TabStop = true;
            this.rdbSmaller.Text = "<";
            this.rdbSmaller.UseVisualStyleBackColor = true;
            // 
            // rdbGreater
            // 
            this.rdbGreater.AutoSize = true;
            this.rdbGreater.Location = new System.Drawing.Point(6, 19);
            this.rdbGreater.Name = "rdbGreater";
            this.rdbGreater.Size = new System.Drawing.Size(31, 17);
            this.rdbGreater.TabIndex = 0;
            this.rdbGreater.TabStop = true;
            this.rdbGreater.Text = ">";
            this.rdbGreater.UseVisualStyleBackColor = true;
            // 
            // gbxIncrement
            // 
            this.gbxIncrement.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gbxIncrement.Controls.Add(this.txtIncrement);
            this.gbxIncrement.Controls.Add(this.lblIncrement);
            this.gbxIncrement.Controls.Add(this.rdbMin);
            this.gbxIncrement.Controls.Add(this.rdbPlus);
            this.gbxIncrement.Location = new System.Drawing.Point(509, 13);
            this.gbxIncrement.Name = "gbxIncrement";
            this.gbxIncrement.Size = new System.Drawing.Size(155, 100);
            this.gbxIncrement.TabIndex = 3;
            this.gbxIncrement.TabStop = false;
            this.gbxIncrement.Text = "4. Change increment";
            // 
            // txtIncrement
            // 
            this.txtIncrement.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtIncrement.Location = new System.Drawing.Point(77, 62);
            this.txtIncrement.Name = "txtIncrement";
            this.txtIncrement.Size = new System.Drawing.Size(63, 20);
            this.txtIncrement.TabIndex = 3;
            // 
            // lblIncrement
            // 
            this.lblIncrement.AutoSize = true;
            this.lblIncrement.Location = new System.Drawing.Point(6, 66);
            this.lblIncrement.Name = "lblIncrement";
            this.lblIncrement.Size = new System.Drawing.Size(65, 13);
            this.lblIncrement.TabIndex = 2;
            this.lblIncrement.Text = "Stapgrootte:";
            // 
            // rdbMin
            // 
            this.rdbMin.AutoSize = true;
            this.rdbMin.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.rdbMin.Location = new System.Drawing.Point(81, 28);
            this.rdbMin.Name = "rdbMin";
            this.rdbMin.Size = new System.Drawing.Size(28, 17);
            this.rdbMin.TabIndex = 1;
            this.rdbMin.TabStop = true;
            this.rdbMin.Text = "-";
            this.rdbMin.UseVisualStyleBackColor = false;
            // 
            // rdbPlus
            // 
            this.rdbPlus.AutoSize = true;
            this.rdbPlus.Location = new System.Drawing.Point(21, 28);
            this.rdbPlus.Name = "rdbPlus";
            this.rdbPlus.Size = new System.Drawing.Size(31, 17);
            this.rdbPlus.TabIndex = 0;
            this.rdbPlus.TabStop = true;
            this.rdbPlus.Text = "+";
            this.rdbPlus.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtOutput.Location = new System.Drawing.Point(12, 128);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(776, 310);
            this.txtOutput.TabIndex = 5;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnGenerate.Location = new System.Drawing.Point(693, 14);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(95, 100);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate loop";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnAdvies_Click);
            // 
            // frmLoopgenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.gbxIncrement);
            this.Controls.Add(this.gbxEnd);
            this.Controls.Add(this.gbxStart);
            this.Controls.Add(this.gbxForWhile);
            this.Name = "frmLoopgenerator";
            this.Text = "For/while loop generator";
            this.gbxForWhile.ResumeLayout(false);
            this.gbxForWhile.PerformLayout();
            this.gbxStart.ResumeLayout(false);
            this.gbxStart.PerformLayout();
            this.gbxEnd.ResumeLayout(false);
            this.gbxEnd.PerformLayout();
            this.gbxIncrement.ResumeLayout(false);
            this.gbxIncrement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxForWhile;
        private System.Windows.Forms.RadioButton rdbWhile;
        private System.Windows.Forms.RadioButton rdbFor;
        private System.Windows.Forms.GroupBox gbxStart;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.GroupBox gbxEnd;
        private System.Windows.Forms.RadioButton rdbSmallerEqual;
        private System.Windows.Forms.RadioButton rdbGreaterEqual;
        private System.Windows.Forms.RadioButton rdbSmaller;
        private System.Windows.Forms.RadioButton rdbGreater;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.GroupBox gbxIncrement;
        private System.Windows.Forms.Label lblIncrement;
        private System.Windows.Forms.RadioButton rdbMin;
        private System.Windows.Forms.RadioButton rdbPlus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtIncrement;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnGenerate;
    }
}

