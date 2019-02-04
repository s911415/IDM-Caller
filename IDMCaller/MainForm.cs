using IDManLib;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace IDMCaller
{
    public partial class MainForm : Form
    {
        private const string LastParamsKey = "LastParams";

        public MainForm()
        {
            InitializeComponent();

            foreach (TextBox textBox in new[] {
                _urlTextBox, _refererTextBox, _cookiesTextBox,
                _postDataTextBox, _localPathTextBox, _localFileNameTextBox,
                _userAgentTextBox})
            {
                textBox.GotFocus += OnTextBoxGotFocus;
            }

            var model = GetModelFromSettings();
            SetByModel(model);
        }

        private IDMParams SaveSettingToStorageAndGet()
        {
            var model = GetModelFromTextBox();
            var xmlSerializer = new XmlSerializer(typeof(IDMParams));
            var sb = new StringBuilder();
            var sw = new StringWriter(sb);
            xmlSerializer.Serialize(sw, model);
            Properties.Settings.Default[LastParamsKey] = sb.ToString();
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Upgrade();

            return model;
        }

        private IDMParams GetModelFromTextBox()
        {
            return new IDMParams
            {
                Url = _urlTextBox.Text,
                Referer = _refererTextBox.Text,
                Cookies = _cookiesTextBox.Text,
                Data = _postDataTextBox.Text,
                LocalPath = _localPathTextBox.Text,
                LocalFileName = _localFileNameTextBox.Text,
                UserAgent = _userAgentTextBox.Text,
            };
        }

        private IDMParams GetModelFromSettings()
        {
            try
            {
                var str = Properties.Settings.Default.LastParams;
                var xmlSerializer = new XmlSerializer(typeof(IDMParams));
                var sr = new StringReader(str ?? "");
                var obj = (IDMParams)xmlSerializer.Deserialize(sr);

                return obj;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        private void SetByModel(IDMParams idmParams)
        {
            if (idmParams == null) return;
            _urlTextBox.Text = idmParams.Url;
            _refererTextBox.Text = idmParams.Referer;
            _cookiesTextBox.Text = idmParams.Cookies;
            _postDataTextBox.Text = idmParams.Data;
            _localPathTextBox.Text = idmParams.LocalPath;
            _localFileNameTextBox.Text = idmParams.LocalFileName;
            _userAgentTextBox.Text = idmParams.UserAgent;
        }

        private void OnTextBoxGotFocus(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            textBox.SelectAll();
        }

        private void OnCallIDMBtnClick(object sender, EventArgs e)
        {
            var model = SaveSettingToStorageAndGet();
            IDMUtils.DownloadFile(model);
        }

        private void OnSaveFileDialogFileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var fileInfo = new FileInfo(_saveFileDialog.FileName);
            _localPathTextBox.Text = fileInfo.DirectoryName;
            _localFileNameTextBox.Text = fileInfo.Name;
        }

        private void OnBrowseFileBtnClick(object sender, EventArgs e)
        {
            _saveFileDialog.ShowDialog();
        }
    }
}
