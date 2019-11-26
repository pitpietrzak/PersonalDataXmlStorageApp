using DevExpress.XtraEditors.Controls;
using PersonalDataXmlStorageApp.Models;
using PersonalDataXmlStorageApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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

            DisableButtons();
        }

        private void uxSave_Click(object sender, EventArgs e)
        {
            var data = (List<Person>)bsPersonalData.DataSource;
            var correctData = data.Where(x => !x.HasErrors && x.IsDirty).ToList();
            if (!correctData.Any())
                return;

            FileService.SaveDataToFile(correctData);
            DisableButtons();
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void uxPersonsView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            try
            {
                var currentRow = (Person)e.Row;
                if (currentRow.HasErrors)
                {
                    throw new Exception("Row contains empty required fields !");
                }
            }
            catch (Exception ex)
            {
                e.ErrorText = ex.Message;
                e.Valid = false;
            }
        }

        private void uxPersonsView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {             
            var message = $@"{e.ErrorText}. Czy chcesz poprawić wartość?";
            e.ExceptionMode = MessageBox.Show(message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK ? ExceptionMode.NoAction : ExceptionMode.Ignore;
            if (e.ExceptionMode == ExceptionMode.Ignore)
            {
                uxPersonsView.CancelUpdateCurrentRow();
                var data = (List<Person>)bsPersonalData.DataSource;
                if (!data.Any())
                {
                    DisableButtons();
                }
            }
        }

        private void uxPersonsView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            EnableButtons();
        }

        private void DisableButtons()
        {
            uxSave.Enabled = false;
            uxCancel.Enabled = false;
        }

        private void EnableButtons()
        {
            uxSave.Enabled = true;
            uxCancel.Enabled = true;
        }
    }
}
