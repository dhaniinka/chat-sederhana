namespace ChatSederhana
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            Startbutton = new Button();
            ServerPorttextBox = new TextBox();
            SeverIPtextBox = new TextBox();
            label3 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            Connectbutton = new Button();
            ClientPorttextBox = new TextBox();
            ClientIPtextBox = new TextBox();
            label4 = new Label();
            label2 = new Label();
            ChatScreentextBox = new TextBox();
            MessagetextBox = new TextBox();
            Sendbutton = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Startbutton);
            groupBox1.Controls.Add(ServerPorttextBox);
            groupBox1.Controls.Add(SeverIPtextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(24, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(796, 120);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Server";
            // 
            // Startbutton
            // 
            Startbutton.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Startbutton.Location = new Point(652, 52);
            Startbutton.Name = "Startbutton";
            Startbutton.Size = new Size(112, 36);
            Startbutton.TabIndex = 5;
            Startbutton.Text = "START";
            Startbutton.UseVisualStyleBackColor = true;
            Startbutton.Click += Startbutton_Click;
            // 
            // ServerPorttextBox
            // 
            ServerPorttextBox.Location = new Point(404, 52);
            ServerPorttextBox.Name = "ServerPorttextBox";
            ServerPorttextBox.Size = new Size(219, 31);
            ServerPorttextBox.TabIndex = 4;
            // 
            // SeverIPtextBox
            // 
            SeverIPtextBox.Location = new Point(78, 52);
            SeverIPtextBox.Name = "SeverIPtextBox";
            SeverIPtextBox.Size = new Size(219, 31);
            SeverIPtextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(343, 52);
            label3.Name = "label3";
            label3.Size = new Size(55, 25);
            label3.TabIndex = 2;
            label3.Text = "PORT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 52);
            label1.Name = "label1";
            label1.Size = new Size(27, 25);
            label1.TabIndex = 0;
            label1.Text = "IP";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Connectbutton);
            groupBox2.Controls.Add(ClientPorttextBox);
            groupBox2.Controls.Add(ClientIPtextBox);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(24, 149);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(796, 120);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Client";
            // 
            // Connectbutton
            // 
            Connectbutton.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Connectbutton.Location = new Point(652, 58);
            Connectbutton.Name = "Connectbutton";
            Connectbutton.Size = new Size(112, 36);
            Connectbutton.TabIndex = 6;
            Connectbutton.Text = "CONNECT";
            Connectbutton.UseVisualStyleBackColor = true;
            Connectbutton.Click += Connectbutton_Click;
            // 
            // ClientPorttextBox
            // 
            ClientPorttextBox.Location = new Point(404, 61);
            ClientPorttextBox.Name = "ClientPorttextBox";
            ClientPorttextBox.Size = new Size(219, 31);
            ClientPorttextBox.TabIndex = 5;
            // 
            // ClientIPtextBox
            // 
            ClientIPtextBox.Location = new Point(78, 61);
            ClientIPtextBox.Name = "ClientIPtextBox";
            ClientIPtextBox.Size = new Size(219, 31);
            ClientIPtextBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(343, 64);
            label4.Name = "label4";
            label4.Size = new Size(55, 25);
            label4.TabIndex = 3;
            label4.Text = "PORT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 61);
            label2.Name = "label2";
            label2.Size = new Size(27, 25);
            label2.TabIndex = 2;
            label2.Text = "IP";
            // 
            // ChatScreentextBox
            // 
            ChatScreentextBox.Location = new Point(24, 293);
            ChatScreentextBox.Multiline = true;
            ChatScreentextBox.Name = "ChatScreentextBox";
            ChatScreentextBox.Size = new Size(796, 190);
            ChatScreentextBox.TabIndex = 2;
            // 
            // MessagetextBox
            // 
            MessagetextBox.Location = new Point(24, 505);
            MessagetextBox.Multiline = true;
            MessagetextBox.Name = "MessagetextBox";
            MessagetextBox.Size = new Size(623, 71);
            MessagetextBox.TabIndex = 3;
            // 
            // Sendbutton
            // 
            Sendbutton.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Sendbutton.Location = new Point(677, 505);
            Sendbutton.Name = "Sendbutton";
            Sendbutton.Size = new Size(112, 71);
            Sendbutton.TabIndex = 7;
            Sendbutton.Text = "SEND";
            Sendbutton.UseVisualStyleBackColor = true;
            Sendbutton.Click += Sendbutton_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // backgroundWorker2
            // 
            backgroundWorker2.DoWork += backgroundWorker2_DoWork;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 612);
            Controls.Add(Sendbutton);
            Controls.Add(MessagetextBox);
            Controls.Add(ChatScreentextBox);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button Startbutton;
        private TextBox ServerPorttextBox;
        private TextBox SeverIPtextBox;
        private Label label3;
        private Label label1;
        private Button Connectbutton;
        private TextBox ClientPorttextBox;
        private TextBox ClientIPtextBox;
        private Label label4;
        private Label label2;
        private TextBox ChatScreentextBox;
        private TextBox MessagetextBox;
        private Button Sendbutton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}
