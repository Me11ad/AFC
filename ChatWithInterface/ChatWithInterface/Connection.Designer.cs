namespace ChatWithInterface
{
    partial class Connection
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
            txtIp = new TextBox();
            label1 = new Label();
            btnConnect = new Button();
            SuspendLayout();
            // 
            // txtIp
            // 
            txtIp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtIp.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtIp.BorderStyle = BorderStyle.FixedSingle;
            txtIp.Cursor = Cursors.IBeam;
            txtIp.Location = new Point(112, 67);
            txtIp.MaximumSize = new Size(320, 20);
            txtIp.Name = "txtIp";
            txtIp.Size = new Size(320, 20);
            txtIp.TabIndex = 0;
            txtIp.TextChanged += txtIp_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(60, 67);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Адрес :";
            // 
            // btnConnect
            // 
            btnConnect.BackgroundImageLayout = ImageLayout.Center;
            btnConnect.Location = new Point(173, 132);
            btnConnect.MaximumSize = new Size(180, 30);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(180, 30);
            btnConnect.TabIndex = 2;
            btnConnect.Text = "Подключиться";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // Connection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 217);
            Controls.Add(btnConnect);
            Controls.Add(label1);
            Controls.Add(txtIp);
            MaximumSize = new Size(512, 256);
            MinimumSize = new Size(512, 256);
            Name = "Connection";
            Text = "ConnectionToChat";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIp;
        private Label label1;
        private Button btnConnect;
    }
}
