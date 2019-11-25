namespace PersonalDataXmlStorageApp
{
    partial class Form
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
            this.uxLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.uxPersons = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartmentNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.townDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPersonalData = new System.Windows.Forms.BindingSource(this.components);
            this.uxSave = new System.Windows.Forms.Button();
            this.uxClose = new System.Windows.Forms.Button();
            this.uxErrors = new System.Windows.Forms.ErrorProvider(this.components);
            this.uxLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPersonalData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxErrors)).BeginInit();
            this.SuspendLayout();
            // 
            // uxLayout
            // 
            this.uxLayout.Controls.Add(this.uxPersons);
            this.uxLayout.Controls.Add(this.uxSave);
            this.uxLayout.Controls.Add(this.uxClose);
            this.uxLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxLayout.Location = new System.Drawing.Point(0, 0);
            this.uxLayout.Name = "uxLayout";
            this.uxLayout.Size = new System.Drawing.Size(1046, 444);
            this.uxLayout.TabIndex = 0;
            // 
            // uxPersons
            // 
            this.uxPersons.AutoGenerateColumns = false;
            this.uxPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxPersons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.streetNameDataGridViewTextBoxColumn,
            this.houseNumberDataGridViewTextBoxColumn,
            this.apartmentNumberDataGridViewTextBoxColumn,
            this.postalCodeDataGridViewTextBoxColumn,
            this.townDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn});
            this.uxPersons.DataSource = this.bsPersonalData;
            this.uxPersons.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.uxPersons.Location = new System.Drawing.Point(3, 3);
            this.uxPersons.Name = "uxPersons";
            this.uxPersons.Size = new System.Drawing.Size(1043, 396);
            this.uxPersons.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // streetNameDataGridViewTextBoxColumn
            // 
            this.streetNameDataGridViewTextBoxColumn.DataPropertyName = "StreetName";
            this.streetNameDataGridViewTextBoxColumn.HeaderText = "Street Name";
            this.streetNameDataGridViewTextBoxColumn.Name = "streetNameDataGridViewTextBoxColumn";
            // 
            // houseNumberDataGridViewTextBoxColumn
            // 
            this.houseNumberDataGridViewTextBoxColumn.DataPropertyName = "HouseNumber";
            this.houseNumberDataGridViewTextBoxColumn.HeaderText = "House Number";
            this.houseNumberDataGridViewTextBoxColumn.Name = "houseNumberDataGridViewTextBoxColumn";
            // 
            // apartmentNumberDataGridViewTextBoxColumn
            // 
            this.apartmentNumberDataGridViewTextBoxColumn.DataPropertyName = "ApartmentNumber";
            this.apartmentNumberDataGridViewTextBoxColumn.HeaderText = "Apartment Number";
            this.apartmentNumberDataGridViewTextBoxColumn.Name = "apartmentNumberDataGridViewTextBoxColumn";
            // 
            // postalCodeDataGridViewTextBoxColumn
            // 
            this.postalCodeDataGridViewTextBoxColumn.DataPropertyName = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.HeaderText = "Postal Code";
            this.postalCodeDataGridViewTextBoxColumn.Name = "postalCodeDataGridViewTextBoxColumn";
            // 
            // townDataGridViewTextBoxColumn
            // 
            this.townDataGridViewTextBoxColumn.DataPropertyName = "Town";
            this.townDataGridViewTextBoxColumn.HeaderText = "Town";
            this.townDataGridViewTextBoxColumn.Name = "townDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "Birth Date";
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsPersonalData
            // 
            this.bsPersonalData.DataSource = typeof(PersonalDataXmlStorageApp.Models.Person);
            // 
            // uxSave
            // 
            this.uxSave.Enabled = false;
            this.uxSave.Location = new System.Drawing.Point(3, 405);
            this.uxSave.Name = "uxSave";
            this.uxSave.Size = new System.Drawing.Size(516, 32);
            this.uxSave.TabIndex = 1;
            this.uxSave.Text = "Save";
            this.uxSave.UseVisualStyleBackColor = true;
            this.uxSave.Click += new System.EventHandler(this.uxSave_Click);
            // 
            // uxClose
            // 
            this.uxClose.Enabled = false;
            this.uxClose.Location = new System.Drawing.Point(525, 405);
            this.uxClose.Name = "uxClose";
            this.uxClose.Size = new System.Drawing.Size(516, 32);
            this.uxClose.TabIndex = 2;
            this.uxClose.Text = "Cancel";
            this.uxClose.UseVisualStyleBackColor = true;
            this.uxClose.Click += new System.EventHandler(this.uxClose_Click);
            // 
            // uxErrors
            // 
            this.uxErrors.ContainerControl = this;
            this.uxErrors.DataSource = this.bsPersonalData;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 444);
            this.Controls.Add(this.uxLayout);
            this.Name = "Form";
            this.Text = "PersonalDataXmlStorage";
            this.uxLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uxPersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPersonalData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxErrors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bsPersonalData;
        private System.Windows.Forms.FlowLayoutPanel uxLayout;
        private System.Windows.Forms.DataGridView uxPersons;
        private System.Windows.Forms.Button uxSave;
        private System.Windows.Forms.Button uxClose;
        private System.Windows.Forms.ErrorProvider uxErrors;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn townDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
    }
}

