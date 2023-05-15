namespace Telemess
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlBar = new System.Windows.Forms.Panel();
            this.lblCl = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.rtxRx = new System.Windows.Forms.RichTextBox();
            this.pnlInp = new System.Windows.Forms.Panel();
            this.txtSndr = new YANF.Control.YANTxt();
            this.lblAdd = new System.Windows.Forms.Label();
            this.pnlBar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlInp.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBar
            // 
            this.pnlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.pnlBar.Controls.Add(this.lblAdd);
            this.pnlBar.Controls.Add(this.lblCl);
            this.pnlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBar.Location = new System.Drawing.Point(0, 0);
            this.pnlBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(400, 24);
            this.pnlBar.TabIndex = 0;
            // 
            // lblCl
            // 
            this.lblCl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblCl.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCl.Location = new System.Drawing.Point(364, 0);
            this.lblCl.Margin = new System.Windows.Forms.Padding(0);
            this.lblCl.Name = "lblCl";
            this.lblCl.Size = new System.Drawing.Size(36, 24);
            this.lblCl.TabIndex = 0;
            this.lblCl.Text = "✕";
            this.lblCl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCl.Click += new System.EventHandler(this.LblCl_Click);
            this.lblCl.MouseEnter += new System.EventHandler(this.LblCl_MouseEnter);
            this.lblCl.MouseLeave += new System.EventHandler(this.LblCl_MouseLeave);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Controls.Add(this.rtxRx);
            this.pnlMain.Controls.Add(this.pnlInp);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 24);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(400, 476);
            this.pnlMain.TabIndex = 1;
            // 
            // rtxRx
            // 
            this.rtxRx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.rtxRx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxRx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxRx.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.rtxRx.ForeColor = System.Drawing.Color.White;
            this.rtxRx.Location = new System.Drawing.Point(0, 0);
            this.rtxRx.Margin = new System.Windows.Forms.Padding(0);
            this.rtxRx.Name = "rtxRx";
            this.rtxRx.ReadOnly = true;
            this.rtxRx.Size = new System.Drawing.Size(400, 442);
            this.rtxRx.TabIndex = 0;
            this.rtxRx.TabStop = false;
            this.rtxRx.Text = "";
            // 
            // pnlInp
            // 
            this.pnlInp.Controls.Add(this.txtSndr);
            this.pnlInp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInp.Location = new System.Drawing.Point(0, 442);
            this.pnlInp.Margin = new System.Windows.Forms.Padding(0);
            this.pnlInp.Name = "pnlInp";
            this.pnlInp.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.pnlInp.Size = new System.Drawing.Size(400, 34);
            this.pnlInp.TabIndex = 0;
            // 
            // txtSndr
            // 
            this.txtSndr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.txtSndr.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSndr.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSndr.BorderRadius = 0;
            this.txtSndr.BorderSize = 1;
            this.txtSndr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSndr.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSndr.ForeColor = System.Drawing.Color.Cyan;
            this.txtSndr.Location = new System.Drawing.Point(1, 0);
            this.txtSndr.Margin = new System.Windows.Forms.Padding(0);
            this.txtSndr.MaxLength = 32767;
            this.txtSndr.Multiline = false;
            this.txtSndr.Name = "txtSndr";
            this.txtSndr.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSndr.PasswordChar = false;
            this.txtSndr.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSndr.PlaceholderText = "nhập nội dung tin nhắn vào đây...";
            this.txtSndr.Size = new System.Drawing.Size(398, 33);
            this.txtSndr.String = null;
            this.txtSndr.TabIndex = 1;
            this.txtSndr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSndr.UnderlinedStyle = true;
            this.txtSndr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSndr_KeyDown);
            this.txtSndr.Leave += new System.EventHandler(this.TxtSndr_Leave);
            // 
            // lblAdd
            // 
            this.lblAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblAdd.ForeColor = System.Drawing.Color.DarkGray;
            this.lblAdd.Location = new System.Drawing.Point(0, 0);
            this.lblAdd.Margin = new System.Windows.Forms.Padding(0);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(36, 24);
            this.lblAdd.TabIndex = 0;
            this.lblAdd.Text = "✙";
            this.lblAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAdd.Click += new System.EventHandler(this.LblAdd_Click);
            this.lblAdd.MouseEnter += new System.EventHandler(this.LblAdd_MouseEnter);
            this.lblAdd.MouseLeave += new System.EventHandler(this.LblAdd_MouseLeave);
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telemess";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.pnlBar.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlInp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.Panel pnlMain;
        private YANF.Control.YANTxt txtSndr;
        private System.Windows.Forms.RichTextBox rtxRx;
        private System.Windows.Forms.Panel pnlInp;
        private System.Windows.Forms.Label lblCl;
        private System.Windows.Forms.Label lblAdd;
    }
}

