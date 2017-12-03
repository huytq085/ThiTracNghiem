namespace ThiTracNghiem.Forms
{
    partial class FrmSubject
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
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label tENMHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSubject));
            this.branchesBindingSource = new System.Windows.Forms.BindingSource();
            this.ds = new ThiTracNghiem.TRACNGHIEMDataSet();
            this.pnTable = new System.Windows.Forms.Panel();
            this.mONHOCGridControl = new DevExpress.XtraGrid.GridControl();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource();
            this.dsSV1 = new ThiTracNghiem.TRACNGHIEMDataSetSV1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.barAction = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection();
            this.pnEditor = new System.Windows.Forms.Panel();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenMH = new DevExpress.XtraEditors.TextEdit();
            this.txtMaMH = new DevExpress.XtraEditors.TextEdit();
            this.subjectTableAdapter = new ThiTracNghiem.TRACNGHIEMDataSetSV1TableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new ThiTracNghiem.TRACNGHIEMDataSetSV1TableAdapters.TableAdapterManager();
            this.branchesTableAdapter = new ThiTracNghiem.TRACNGHIEMDataSetTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager1 = new ThiTracNghiem.TRACNGHIEMDataSetTableAdapters.TableAdapterManager();
            mAMHLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.pnTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.pnEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMH.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(62, 27);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(62, 19);
            mAMHLabel.TabIndex = 0;
            mAMHLabel.Text = "MAMH:";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(62, 71);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(67, 19);
            tENMHLabel.TabIndex = 2;
            tENMHLabel.Text = "TENMH:";
            // 
            // branchesBindingSource
            // 
            this.branchesBindingSource.DataMember = "V_DS_PHANMANH";
            this.branchesBindingSource.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "TRACNGHIEMDataSet";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnTable
            // 
            this.pnTable.Controls.Add(this.mONHOCGridControl);
            this.pnTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTable.Location = new System.Drawing.Point(0, 42);
            this.pnTable.Name = "pnTable";
            this.pnTable.Size = new System.Drawing.Size(1238, 263);
            this.pnTable.TabIndex = 5;
            // 
            // mONHOCGridControl
            // 
            this.mONHOCGridControl.DataSource = this.subjectBindingSource;
            this.mONHOCGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.mONHOCGridControl.Location = new System.Drawing.Point(12, 20);
            this.mONHOCGridControl.MainView = this.gridView1;
            this.mONHOCGridControl.MenuManager = this.barManager1;
            this.mONHOCGridControl.Name = "mONHOCGridControl";
            this.mONHOCGridControl.Size = new System.Drawing.Size(1203, 220);
            this.mONHOCGridControl.TabIndex = 0;
            this.mONHOCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.mONHOCGridControl.Click += new System.EventHandler(this.mONHOCGridControl_Click);
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataMember = "MONHOC";
            this.subjectBindingSource.DataSource = this.dsSV1;
            // 
            // dsSV1
            // 
            this.dsSV1.DataSetName = "TRACNGHIEMDataSetSV1";
            this.dsSV1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH});
            this.gridView1.GridControl = this.mONHOCGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            // 
            // colTENMH
            // 
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barAction,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnSave,
            this.btnDelete,
            this.btnUndo,
            this.btnReload,
            this.btnPrint,
            this.btnExit});
            this.barManager1.MainMenu = this.barAction;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // barAction
            // 
            this.barAction.BarName = "Main menu";
            this.barAction.DockCol = 0;
            this.barAction.DockRow = 0;
            this.barAction.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barAction.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave, "", false, true, false, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPrint, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExit, "", false, true, false, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barAction.OptionsBar.MultiLine = true;
            this.barAction.OptionsBar.UseWholeRow = true;
            this.barAction.Text = "Main menu";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Thêm";
            this.btnAdd.Id = 0;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Hiệu chỉnh";
            this.btnEdit.Id = 1;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Ghi";
            this.btnSave.Enabled = false;
            this.btnSave.Id = 2;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Xóa";
            this.btnDelete.Id = 3;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Phục hồi";
            this.btnUndo.Id = 4;
            this.btnUndo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.Image")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Tải lại";
            this.btnReload.Id = 5;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnPrint
            // 
            this.btnPrint.Caption = "In danh sách";
            this.btnPrint.Id = 6;
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.Name = "btnPrint";
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Thoát";
            this.btnExit.Id = 7;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Name = "btnExit";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1238, 42);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 573);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1238, 18);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 42);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 531);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1238, 42);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 531);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "Undo-icon-48.png");
            // 
            // pnEditor
            // 
            this.pnEditor.Controls.Add(this.btnCancel);
            this.pnEditor.Controls.Add(this.btnSubmit);
            this.pnEditor.Controls.Add(tENMHLabel);
            this.pnEditor.Controls.Add(this.txtTenMH);
            this.pnEditor.Controls.Add(mAMHLabel);
            this.pnEditor.Controls.Add(this.txtMaMH);
            this.pnEditor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnEditor.Enabled = false;
            this.pnEditor.Location = new System.Drawing.Point(0, 305);
            this.pnEditor.Name = "pnEditor";
            this.pnEditor.Size = new System.Drawing.Size(1238, 182);
            this.pnEditor.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.btnCancel.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnCancel.Appearance.Options.UseBackColor = true;
            this.btnCancel.Appearance.Options.UseBorderColor = true;
            this.btnCancel.AppearancePressed.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCancel.AppearancePressed.BackColor2 = System.Drawing.SystemColors.ActiveBorder;
            this.btnCancel.AppearancePressed.Options.UseBackColor = true;
            this.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnCancel.Location = new System.Drawing.Point(313, 122);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 38);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Appearance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSubmit.Appearance.BackColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.btnSubmit.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Appearance.Options.UseBackColor = true;
            this.btnSubmit.Appearance.Options.UseFont = true;
            this.btnSubmit.Appearance.Options.UseForeColor = true;
            this.btnSubmit.AppearancePressed.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSubmit.AppearancePressed.BackColor2 = System.Drawing.SystemColors.ActiveBorder;
            this.btnSubmit.AppearancePressed.Options.UseBackColor = true;
            this.btnSubmit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSubmit.Location = new System.Drawing.Point(217, 122);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 38);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Lưu";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtTenMH
            // 
            this.txtTenMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.subjectBindingSource, "TENMH", true));
            this.txtTenMH.Location = new System.Drawing.Point(217, 70);
            this.txtTenMH.MenuManager = this.barManager1;
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(447, 20);
            this.txtTenMH.TabIndex = 3;
            // 
            // txtMaMH
            // 
            this.txtMaMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.subjectBindingSource, "MAMH", true));
            this.txtMaMH.Location = new System.Drawing.Point(217, 26);
            this.txtMaMH.MenuManager = this.barManager1;
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(447, 20);
            this.txtMaMH.TabIndex = 1;
            // 
            // subjectTableAdapter
            // 
            this.subjectTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.subjectTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ThiTracNghiem.TRACNGHIEMDataSetSV1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // branchesTableAdapter
            // 
            this.branchesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = ThiTracNghiem.TRACNGHIEMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmSubject
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 591);
            this.Controls.Add(this.pnEditor);
            this.Controls.Add(this.pnTable);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSubject";
            this.Text = "FrmSubject";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.pnTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.pnEditor.ResumeLayout(false);
            this.pnEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMH.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnTable;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar barAction;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private TRACNGHIEMDataSetSV1 dsSV1;
        private System.Windows.Forms.Panel pnEditor;
        private TRACNGHIEMDataSetSV1TableAdapters.MONHOCTableAdapter subjectTableAdapter;
        private TRACNGHIEMDataSetSV1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl mONHOCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtTenMH;
        private DevExpress.XtraEditors.TextEdit txtMaMH;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private TRACNGHIEMDataSet ds;
        private System.Windows.Forms.BindingSource branchesBindingSource;
        private TRACNGHIEMDataSetTableAdapters.V_DS_PHANMANHTableAdapter branchesTableAdapter;
        private TRACNGHIEMDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}