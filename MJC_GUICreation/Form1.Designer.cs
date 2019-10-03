namespace MJC_GUICreation
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
            this.components = new System.ComponentModel.Container();
            this.ruleBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rulesLabel = new System.Windows.Forms.Label();
            this.timerBar = new System.Windows.Forms.ProgressBar();
            this.gameButton = new System.Windows.Forms.Button();
            this.timerBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.redWire = new System.Windows.Forms.Button();
            this.blackWire = new System.Windows.Forms.Button();
            this.blueWire = new System.Windows.Forms.Button();
            this.whiteWire = new System.Windows.Forms.Button();
            this.yellowWire = new System.Windows.Forms.Button();
            this.wireBox = new System.Windows.Forms.GroupBox();
            this.progressTimer = new System.Windows.Forms.Timer(this.components);
            this.ruleBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ruleBox
            // 
            this.ruleBox.Controls.Add(this.label5);
            this.ruleBox.Controls.Add(this.label4);
            this.ruleBox.Controls.Add(this.label3);
            this.ruleBox.Controls.Add(this.label2);
            this.ruleBox.Controls.Add(this.rulesLabel);
            this.ruleBox.Location = new System.Drawing.Point(12, 12);
            this.ruleBox.Name = "ruleBox";
            this.ruleBox.Size = new System.Drawing.Size(850, 272);
            this.ruleBox.TabIndex = 0;
            this.ruleBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(358, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "-Otherwise, cut the last wire.";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(843, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "-Otherwise, if there is more than one blue wire, cut the last blue wire. ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(644, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "-Otherwise, if the last wire is white, cut the last wire. ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(565, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "-If there are no red wires, cut the second wire.";
            // 
            // rulesLabel
            // 
            this.rulesLabel.AutoSize = true;
            this.rulesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rulesLabel.Location = new System.Drawing.Point(375, 27);
            this.rulesLabel.Name = "rulesLabel";
            this.rulesLabel.Size = new System.Drawing.Size(124, 42);
            this.rulesLabel.TabIndex = 0;
            this.rulesLabel.Text = "Rules:";
            // 
            // timerBar
            // 
            this.timerBar.Location = new System.Drawing.Point(12, 1105);
            this.timerBar.Name = "timerBar";
            this.timerBar.Size = new System.Drawing.Size(1178, 56);
            this.timerBar.TabIndex = 1;
            // 
            // gameButton
            // 
            this.gameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameButton.Location = new System.Drawing.Point(1205, 1105);
            this.gameButton.Name = "gameButton";
            this.gameButton.Size = new System.Drawing.Size(215, 56);
            this.gameButton.TabIndex = 2;
            this.gameButton.Text = "Start Game";
            this.gameButton.UseVisualStyleBackColor = true;
            // 
            // timerBox
            // 
            this.timerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerBox.Location = new System.Drawing.Point(12, 1050);
            this.timerBox.Name = "timerBox";
            this.timerBox.Size = new System.Drawing.Size(139, 38);
            this.timerBox.TabIndex = 3;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(6, 1016);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(145, 31);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "Time Left:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(6, 909);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(107, 31);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.Text = "Status:";
            // 
            // resultBox
            // 
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.Location = new System.Drawing.Point(12, 943);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(365, 38);
            this.resultBox.TabIndex = 6;
            // 
            // redWire
            // 
            this.redWire.BackColor = System.Drawing.Color.Crimson;
            this.redWire.Enabled = false;
            this.redWire.Location = new System.Drawing.Point(42, 451);
            this.redWire.Name = "redWire";
            this.redWire.Size = new System.Drawing.Size(620, 40);
            this.redWire.TabIndex = 7;
            this.redWire.UseVisualStyleBackColor = false;
            // 
            // blackWire
            // 
            this.blackWire.BackColor = System.Drawing.Color.Black;
            this.blackWire.Enabled = false;
            this.blackWire.Location = new System.Drawing.Point(42, 501);
            this.blackWire.Name = "blackWire";
            this.blackWire.Size = new System.Drawing.Size(620, 40);
            this.blackWire.TabIndex = 8;
            this.blackWire.UseVisualStyleBackColor = false;
            // 
            // blueWire
            // 
            this.blueWire.BackColor = System.Drawing.Color.MediumBlue;
            this.blueWire.Enabled = false;
            this.blueWire.Location = new System.Drawing.Point(42, 551);
            this.blueWire.Name = "blueWire";
            this.blueWire.Size = new System.Drawing.Size(620, 40);
            this.blueWire.TabIndex = 9;
            this.blueWire.UseVisualStyleBackColor = false;
            // 
            // whiteWire
            // 
            this.whiteWire.BackColor = System.Drawing.Color.White;
            this.whiteWire.Enabled = false;
            this.whiteWire.Location = new System.Drawing.Point(42, 601);
            this.whiteWire.Name = "whiteWire";
            this.whiteWire.Size = new System.Drawing.Size(620, 40);
            this.whiteWire.TabIndex = 10;
            this.whiteWire.UseVisualStyleBackColor = false;
            // 
            // yellowWire
            // 
            this.yellowWire.BackColor = System.Drawing.Color.Yellow;
            this.yellowWire.Enabled = false;
            this.yellowWire.Location = new System.Drawing.Point(42, 651);
            this.yellowWire.Name = "yellowWire";
            this.yellowWire.Size = new System.Drawing.Size(620, 40);
            this.yellowWire.TabIndex = 11;
            this.yellowWire.UseVisualStyleBackColor = false;
            // 
            // wireBox
            // 
            this.wireBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.wireBox.Location = new System.Drawing.Point(25, 431);
            this.wireBox.Name = "wireBox";
            this.wireBox.Size = new System.Drawing.Size(652, 277);
            this.wireBox.TabIndex = 12;
            this.wireBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 1173);
            this.Controls.Add(this.yellowWire);
            this.Controls.Add(this.whiteWire);
            this.Controls.Add(this.blueWire);
            this.Controls.Add(this.blackWire);
            this.Controls.Add(this.redWire);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.timerBox);
            this.Controls.Add(this.gameButton);
            this.Controls.Add(this.timerBar);
            this.Controls.Add(this.ruleBox);
            this.Controls.Add(this.wireBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ruleBox.ResumeLayout(false);
            this.ruleBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ruleBox;
        private System.Windows.Forms.Label rulesLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar timerBar;
        private System.Windows.Forms.Button gameButton;
        private System.Windows.Forms.TextBox timerBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button redWire;
        private System.Windows.Forms.Button blackWire;
        private System.Windows.Forms.Button blueWire;
        private System.Windows.Forms.Button whiteWire;
        private System.Windows.Forms.Button yellowWire;
        private System.Windows.Forms.GroupBox wireBox;
        private System.Windows.Forms.Timer progressTimer;
    }
}

