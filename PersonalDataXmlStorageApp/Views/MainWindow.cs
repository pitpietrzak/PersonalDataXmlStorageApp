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

        public List<Person> ListToDelete;

        public Form()
        {
            ListToDelete = new List<Person>();
            InitializeComponent();
            RefreshData();
        }

        private void RefreshData()
        {
            try
            {
                ListToDelete = new List<Person>();
                bsPersonalData.DataSource = FileService.GetDataFromFile();
                bsPersonalData.ResetBindings(false);

                DisableButtons();
            }
            catch(Exception e)
            {
                var messageBox = MessageBox.Show($@"{e.Message} Would you create new file?", @"Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (messageBox == DialogResult.Yes)
                {
                    FileService.CreateNewFile();
                    RefreshData();
                }
                else
                {
                    Environment.Exit(1);
                }
            }
            
        }

        private void uxSave_Click(object sender, EventArgs e)
        {
            try
            {
                var data = (List<Person>)bsPersonalData.DataSource;
                var dataToSave = data.Where(x => (!x.HasErrors && (x.IsNew || x.IsDirty)) || ListToDelete.Any()).ToList();
                DisableButtons();
                if (!dataToSave.Any())
                {
                    return;
                }

                FileService.SaveDataToFile(dataToSave, ListToDelete);               
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"{ex.Message}", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    throw new Exception(@"Row contains empty required fields !");
                }

                if (currentRow.Id == 0)
                {
                    currentRow.IsNew = true;
                }

                EnableButtons();
            }
            catch (Exception ex)
            {
                e.ErrorText = ex.Message;
                e.Valid = false;
            }
        }

        private void uxPersonsView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {             
            var message = $@"{e.ErrorText} Would you like correct row?";
            e.ExceptionMode = MessageBox.Show(message, @"Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK ? ExceptionMode.NoAction : ExceptionMode.Ignore;
            if (e.ExceptionMode != ExceptionMode.Ignore) return;
            uxPersonsView.CancelUpdateCurrentRow();
            var data = (List<Person>)bsPersonalData.DataSource;
            if (!data.Any(x => !x.HasErrors && x.IsDirty) && !ListToDelete.Any())
            {
                DisableButtons();
            }
        }

        private void uxPersonsView_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            var person = (Person) e.Row;
            if (person.Id != 0)
            {
                person.MarkDeleted();
                ListToDelete.Add(person);
            }
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
