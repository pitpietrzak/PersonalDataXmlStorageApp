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
            this.bsPersonalData = new System.Windows.Forms.BindingSource(this.components);
            this.uxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.uxCancel = new DevExpress.XtraEditors.SimpleButton();
            this.uxSave = new DevExpress.XtraEditors.SimpleButton();
            this.uxPersons = new DevExpress.XtraGrid.GridControl();
            this.uxPersonsView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStreetName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHouseNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApartmentNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostalCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTown = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.uxBirthDateRepository = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colAge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.bsPersonalData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxPersonsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxBirthDateRepository)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxBirthDateRepository.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // bsPersonalData
            // 
            this.bsPersonalData.DataSource = typeof(PersonalDataXmlStorageApp.Models.Person);
            // 
            // uxErrorProvider
            // 
            this.uxErrorProvider.ContainerControl = this;
            this.uxErrorProvider.DataSource = this.bsPersonalData;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.uxCancel);
            this.dataLayoutControl1.Controls.Add(this.uxSave);
            this.dataLayoutControl1.Controls.Add(this.uxPersons);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1046, 223);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // uxCancel
            // 
            this.uxCancel.Enabled = false;
            this.uxCancel.Location = new System.Drawing.Point(525, 189);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(509, 22);
            this.uxCancel.StyleController = this.dataLayoutControl1;
            this.uxCancel.TabIndex = 5;
            this.uxCancel.Text = "Cancel";
            this.uxCancel.Click += new System.EventHandler(this.uxCancel_Click);
            // 
            // uxSave
            // 
            this.uxSave.Enabled = false;
            this.uxSave.Location = new System.Drawing.Point(12, 189);
            this.uxSave.Name = "uxSave";
            this.uxSave.Size = new System.Drawing.Size(509, 22);
            this.uxSave.StyleController = this.dataLayoutControl1;
            this.uxSave.TabIndex = 1;
            this.uxSave.Text = "Save";
            this.uxSave.Click += new System.EventHandler(this.uxSave_Click);
            // 
            // uxPersons
            // 
            this.uxPersons.DataSource = this.bsPersonalData;
            this.uxPersons.Location = new System.Drawing.Point(12, 12);
            this.uxPersons.MainView = this.uxPersonsView;
            this.uxPersons.Name = "uxPersons";
            this.uxPersons.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.uxBirthDateRepository});
            this.uxPersons.Size = new System.Drawing.Size(1022, 173);
            this.uxPersons.TabIndex = 4;
            this.uxPersons.UseEmbeddedNavigator = true;
            this.uxPersons.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.uxPersonsView});
            // 
            // uxPersonsView
            // 
            this.uxPersonsView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colLastName,
            this.colStreetName,
            this.colHouseNumber,
            this.colApartmentNumber,
            this.colPostalCode,
            this.colTown,
            this.colPhoneNumber,
            this.colBirthDate,
            this.colAge});
            this.uxPersonsView.GridControl = this.uxPersons;
            this.uxPersonsView.Name = "uxPersonsView";
            this.uxPersonsView.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
            this.uxPersonsView.OptionsFind.AllowFindPanel = false;
            this.uxPersonsView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.uxPersonsView.OptionsView.ShowGroupPanel = false;
            this.uxPersonsView.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.uxPersonsView_InvalidRowException);
            this.uxPersonsView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.uxPersonsView_ValidateRow);
            // 
            // colName
            // 
            this.colName.Caption = "First Name";
            this.colName.FieldName = "FirstName";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colLastName
            // 
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 1;
            // 
            // colStreetName
            // 
            this.colStreetName.FieldName = "StreetName";
            this.colStreetName.Name = "colStreetName";
            this.colStreetName.Visible = true;
            this.colStreetName.VisibleIndex = 2;
            // 
            // colHouseNumber
            // 
            this.colHouseNumber.FieldName = "HouseNumber";
            this.colHouseNumber.Name = "colHouseNumber";
            this.colHouseNumber.Visible = true;
            this.colHouseNumber.VisibleIndex = 3;
            // 
            // colApartmentNumber
            // 
            this.colApartmentNumber.FieldName = "ApartmentNumber";
            this.colApartmentNumber.Name = "colApartmentNumber";
            this.colApartmentNumber.Visible = true;
            this.colApartmentNumber.VisibleIndex = 4;
            // 
            // colPostalCode
            // 
            this.colPostalCode.FieldName = "PostalCode";
            this.colPostalCode.Name = "colPostalCode";
            this.colPostalCode.Visible = true;
            this.colPostalCode.VisibleIndex = 5;
            // 
            // colTown
            // 
            this.colTown.FieldName = "Town";
            this.colTown.Name = "colTown";
            this.colTown.Visible = true;
            this.colTown.VisibleIndex = 6;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.FieldName = "PhoneNumber";
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.Visible = true;
            this.colPhoneNumber.VisibleIndex = 7;
            // 
            // colBirthDate
            // 
            this.colBirthDate.Caption = "Date of Birth";
            this.colBirthDate.ColumnEdit = this.uxBirthDateRepository;
            this.colBirthDate.FieldName = "BirthDate";
            this.colBirthDate.Name = "colBirthDate";
            this.colBirthDate.Visible = true;
            this.colBirthDate.VisibleIndex = 8;
            // 
            // uxBirthDateRepository
            // 
            this.uxBirthDateRepository.AutoHeight = false;
            this.uxBirthDateRepository.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.uxBirthDateRepository.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.uxBirthDateRepository.MaxValue = new System.DateTime(2019, 11, 27, 16, 21, 28, 0);
            this.uxBirthDateRepository.Name = "uxBirthDateRepository";
            // 
            // colAge
            // 
            this.colAge.FieldName = "Age";
            this.colAge.Name = "colAge";
            this.colAge.OptionsColumn.ReadOnly = true;
            this.colAge.Visible = true;
            this.colAge.VisibleIndex = 9;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1046, 223);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.uxPersons;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1026, 177);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.uxSave;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 177);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(513, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.uxCancel;
            this.layoutControlItem3.Location = new System.Drawing.Point(513, 177);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(513, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 223);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "Form";
            this.Text = "PersonalDataXmlStorage";
            ((System.ComponentModel.ISupportInitialize)(this.bsPersonalData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uxPersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxPersonsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxBirthDateRepository.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxBirthDateRepository)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bsPersonalData;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider uxErrorProvider;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.SimpleButton uxCancel;
        private DevExpress.XtraEditors.SimpleButton uxSave;
        private DevExpress.XtraGrid.GridControl uxPersons;
        private DevExpress.XtraGrid.Views.Grid.GridView uxPersonsView;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colStreetName;
        private DevExpress.XtraGrid.Columns.GridColumn colHouseNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colApartmentNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colPostalCode;
        private DevExpress.XtraGrid.Columns.GridColumn colTown;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthDate;
        private DevExpress.XtraGrid.Columns.GridColumn colAge;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit uxBirthDateRepository;
    }
}

