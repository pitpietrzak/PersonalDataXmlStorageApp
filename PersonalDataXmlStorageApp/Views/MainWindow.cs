using PersonalDataXmlStorageApp.Models;
using PersonalDataXmlStorageApp.Services;
using System;
using System.Collections.Generic;

namespace PersonalDataXmlStorageApp
{
    public partial class Form : System.Windows.Forms.Form
    {
        private FileService _fileService;
        private FileService FileService => _fileService ?? (_fileService = new FileService());

        public Form()
        {
            InitializeComponent();
            RefreshData();
        }

        private void RefreshData()
        {
            bsPersonalData.DataSource = FileService.GetDataFromFile();
            bsPersonalData.ResetBindings(false);
        }

        private void uxSave_Click(object sender, EventArgs e)
        {
            var data = (List<Person>)bsPersonalData.DataSource;
            FileService.SaveDataToFile(data);
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
