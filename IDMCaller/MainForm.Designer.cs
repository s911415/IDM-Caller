namespace IDMCaller
{
    partial class MainForm
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
            this._urlLabel = new System.Windows.Forms.Label();
            this._urlTextBox = new System.Windows.Forms.TextBox();
            this._localPathLabel = new System.Windows.Forms.Label();
            this._localPathTextBox = new System.Windows.Forms.TextBox();
            this._localFileNameLabel = new System.Windows.Forms.Label();
            this._localFileNameTextBox = new System.Windows.Forms.TextBox();
            this._userAgentLabel = new System.Windows.Forms.Label();
            this._userAgentTextBox = new System.Windows.Forms.TextBox();
            this._callIDMBtn = new System.Windows.Forms.Button();
            this._refererTextBox = new System.Windows.Forms.TextBox();
            this._refererLabel = new System.Windows.Forms.Label();
            this._cookiesTextBox = new System.Windows.Forms.TextBox();
            this._cookiesLabel = new System.Windows.Forms.Label();
            this._postDataTextBox = new System.Windows.Forms.TextBox();
            this._postDataLabel = new System.Windows.Forms.Label();
            this._browseFileBtn = new System.Windows.Forms.Button();
            this._saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // _urlLabel
            // 
            this._urlLabel.AutoSize = true;
            this._urlLabel.Location = new System.Drawing.Point(12, 9);
            this._urlLabel.Name = "_urlLabel";
            this._urlLabel.Size = new System.Drawing.Size(31, 12);
            this._urlLabel.TabIndex = 0;
            this._urlLabel.Text = "URL:";
            // 
            // _urlTextBox
            // 
            this._urlTextBox.Location = new System.Drawing.Point(12, 24);
            this._urlTextBox.Name = "_urlTextBox";
            this._urlTextBox.Size = new System.Drawing.Size(620, 22);
            this._urlTextBox.TabIndex = 1;
            // 
            // _localPathLabel
            // 
            this._localPathLabel.AutoSize = true;
            this._localPathLabel.Location = new System.Drawing.Point(12, 169);
            this._localPathLabel.Name = "_localPathLabel";
            this._localPathLabel.Size = new System.Drawing.Size(187, 12);
            this._localPathLabel.TabIndex = 2;
            this._localPathLabel.Text = "Where to save a file on your computer:";
            // 
            // _localPathTextBox
            // 
            this._localPathTextBox.Location = new System.Drawing.Point(12, 184);
            this._localPathTextBox.Name = "_localPathTextBox";
            this._localPathTextBox.Size = new System.Drawing.Size(380, 22);
            this._localPathTextBox.TabIndex = 6;
            this._localPathTextBox.Text = "D:\\";
            // 
            // _localFileNameLabel
            // 
            this._localFileNameLabel.AutoSize = true;
            this._localFileNameLabel.Location = new System.Drawing.Point(398, 168);
            this._localFileNameLabel.Name = "_localFileNameLabel";
            this._localFileNameLabel.Size = new System.Drawing.Size(111, 12);
            this._localFileNameLabel.TabIndex = 4;
            this._localFileNameLabel.Text = "File name to save with:";
            // 
            // _localFileNameTextBox
            // 
            this._localFileNameTextBox.Location = new System.Drawing.Point(398, 183);
            this._localFileNameTextBox.Name = "_localFileNameTextBox";
            this._localFileNameTextBox.Size = new System.Drawing.Size(196, 22);
            this._localFileNameTextBox.TabIndex = 7;
            // 
            // _userAgentLabel
            // 
            this._userAgentLabel.AutoSize = true;
            this._userAgentLabel.Location = new System.Drawing.Point(12, 209);
            this._userAgentLabel.Name = "_userAgentLabel";
            this._userAgentLabel.Size = new System.Drawing.Size(61, 12);
            this._userAgentLabel.TabIndex = 6;
            this._userAgentLabel.Text = "User-Agent:";
            // 
            // _userAgentTextBox
            // 
            this._userAgentTextBox.Location = new System.Drawing.Point(12, 224);
            this._userAgentTextBox.Name = "_userAgentTextBox";
            this._userAgentTextBox.Size = new System.Drawing.Size(620, 22);
            this._userAgentTextBox.TabIndex = 8;
            // 
            // _callIDMBtn
            // 
            this._callIDMBtn.AutoSize = true;
            this._callIDMBtn.Location = new System.Drawing.Point(550, 252);
            this._callIDMBtn.Name = "_callIDMBtn";
            this._callIDMBtn.Size = new System.Drawing.Size(82, 31);
            this._callIDMBtn.TabIndex = 9;
            this._callIDMBtn.Text = "&Call IDM";
            this._callIDMBtn.UseVisualStyleBackColor = true;
            this._callIDMBtn.Click += new System.EventHandler(this.OnCallIDMBtnClick);
            // 
            // _refererTextBox
            // 
            this._refererTextBox.Location = new System.Drawing.Point(12, 64);
            this._refererTextBox.Name = "_refererTextBox";
            this._refererTextBox.Size = new System.Drawing.Size(620, 22);
            this._refererTextBox.TabIndex = 2;
            // 
            // _refererLabel
            // 
            this._refererLabel.AutoSize = true;
            this._refererLabel.Location = new System.Drawing.Point(12, 49);
            this._refererLabel.Name = "_refererLabel";
            this._refererLabel.Size = new System.Drawing.Size(43, 12);
            this._refererLabel.TabIndex = 9;
            this._refererLabel.Text = "Referer:";
            // 
            // _cookiesTextBox
            // 
            this._cookiesTextBox.Location = new System.Drawing.Point(12, 104);
            this._cookiesTextBox.Name = "_cookiesTextBox";
            this._cookiesTextBox.Size = new System.Drawing.Size(620, 22);
            this._cookiesTextBox.TabIndex = 3;
            // 
            // _cookiesLabel
            // 
            this._cookiesLabel.AutoSize = true;
            this._cookiesLabel.Location = new System.Drawing.Point(12, 89);
            this._cookiesLabel.Name = "_cookiesLabel";
            this._cookiesLabel.Size = new System.Drawing.Size(46, 12);
            this._cookiesLabel.TabIndex = 11;
            this._cookiesLabel.Text = "Cookies:";
            // 
            // _postDataTextBox
            // 
            this._postDataTextBox.Location = new System.Drawing.Point(12, 144);
            this._postDataTextBox.Name = "_postDataTextBox";
            this._postDataTextBox.Size = new System.Drawing.Size(620, 22);
            this._postDataTextBox.TabIndex = 4;
            // 
            // _postDataLabel
            // 
            this._postDataLabel.AutoSize = true;
            this._postDataLabel.Location = new System.Drawing.Point(12, 129);
            this._postDataLabel.Name = "_postDataLabel";
            this._postDataLabel.Size = new System.Drawing.Size(51, 12);
            this._postDataLabel.TabIndex = 13;
            this._postDataLabel.Text = "Post Data:";
            // 
            // _browseFileBtn
            // 
            this._browseFileBtn.Location = new System.Drawing.Point(600, 183);
            this._browseFileBtn.Name = "_browseFileBtn";
            this._browseFileBtn.Size = new System.Drawing.Size(32, 23);
            this._browseFileBtn.TabIndex = 5;
            this._browseFileBtn.Text = "...";
            this._browseFileBtn.UseVisualStyleBackColor = true;
            this._browseFileBtn.Click += new System.EventHandler(this.OnBrowseFileBtnClick);
            // 
            // _saveFileDialog
            // 
            this._saveFileDialog.OverwritePrompt = false;
            this._saveFileDialog.RestoreDirectory = true;
            this._saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OnSaveFileDialogFileOk);
            // 
            // Form1
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(644, 294);
            this.Controls.Add(this._browseFileBtn);
            this.Controls.Add(this._postDataTextBox);
            this.Controls.Add(this._postDataLabel);
            this.Controls.Add(this._cookiesTextBox);
            this.Controls.Add(this._cookiesLabel);
            this.Controls.Add(this._refererTextBox);
            this.Controls.Add(this._refererLabel);
            this.Controls.Add(this._callIDMBtn);
            this.Controls.Add(this._userAgentTextBox);
            this.Controls.Add(this._userAgentLabel);
            this.Controls.Add(this._localFileNameTextBox);
            this.Controls.Add(this._localFileNameLabel);
            this.Controls.Add(this._localPathTextBox);
            this.Controls.Add(this._localPathLabel);
            this.Controls.Add(this._urlTextBox);
            this.Controls.Add(this._urlLabel);
            this.Name = "Form1";
            this.Text = "IDM Caller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _urlLabel;
        private System.Windows.Forms.TextBox _urlTextBox;
        private System.Windows.Forms.Label _localPathLabel;
        private System.Windows.Forms.TextBox _localPathTextBox;
        private System.Windows.Forms.Label _localFileNameLabel;
        private System.Windows.Forms.TextBox _localFileNameTextBox;
        private System.Windows.Forms.Label _userAgentLabel;
        private System.Windows.Forms.TextBox _userAgentTextBox;
        private System.Windows.Forms.Button _callIDMBtn;
        private System.Windows.Forms.TextBox _refererTextBox;
        private System.Windows.Forms.Label _refererLabel;
        private System.Windows.Forms.TextBox _cookiesTextBox;
        private System.Windows.Forms.Label _cookiesLabel;
        private System.Windows.Forms.TextBox _postDataTextBox;
        private System.Windows.Forms.Label _postDataLabel;
        private System.Windows.Forms.Button _browseFileBtn;
        private System.Windows.Forms.SaveFileDialog _saveFileDialog;
    }
}

