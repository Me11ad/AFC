namespace ChatWithInterface
{
    partial class ActiveChat
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
            txtSend = new TextBox();
            btnSend = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // txtSend
            // 
            txtSend.Anchor = AnchorStyles.Bottom;
            txtSend.BorderStyle = BorderStyle.FixedSingle;
            txtSend.Location = new Point(55, 398);
            txtSend.MinimumSize = new Size(352, 22);
            txtSend.Multiline = true;
            txtSend.Name = "txtSend";
            txtSend.ScrollBars = ScrollBars.Horizontal;
            txtSend.Size = new Size(352, 22);
            txtSend.TabIndex = 1;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Bottom;
            btnSend.BackColor = SystemColors.ButtonHighlight;
            btnSend.BackgroundImageLayout = ImageLayout.Center;
            btnSend.Location = new Point(413, 388);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(118, 38);
            btnSend.TabIndex = 2;
            btnSend.Text = "Отправить";
            btnSend.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.Cursor = Cursors.WaitCursor;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(42, 39);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(489, 287);
            listBox1.TabIndex = 3;
            // 
            // ActiveChat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(579, 451);
            Controls.Add(listBox1);
            Controls.Add(btnSend);
            Controls.Add(txtSend);
            Name = "ActiveChat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ActiveChat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSend;
        private Button btnSend;
        private ListBox listBox1;
    }
}