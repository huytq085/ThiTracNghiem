namespace ThiTracNghiem.Forms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnSetup = new DevExpress.XtraBars.BarButtonItem();
            this.btnThi = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddPacket = new DevExpress.XtraBars.BarButtonItem();
            this.btnStudent = new DevExpress.XtraBars.BarButtonItem();
            this.btnTeacher = new DevExpress.XtraBars.BarButtonItem();
            this.btnDept = new DevExpress.XtraBars.BarButtonItem();
            this.btnSubject = new DevExpress.XtraBars.BarButtonItem();
            this.btnClass = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuestions = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.txtFooterId = new DevExpress.XtraBars.BarHeaderItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.txtFooterFullName = new DevExpress.XtraBars.BarHeaderItem();
            this.txtFooterClass = new DevExpress.XtraBars.BarHeaderItem();
            this.btnInfo = new DevExpress.XtraBars.BarButtonItem();
            this.txtFooterTenLop = new DevExpress.XtraBars.BarHeaderItem();
            this.Home = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbFunction = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbControl = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbAccount = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbFooter = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Images = this.imageList1;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnAdd,
            this.btnEdit,
            this.btnDelete,
            this.btnSetup,
            this.btnThi,
            this.btnAddPacket,
            this.btnStudent,
            this.btnTeacher,
            this.btnDept,
            this.btnSubject,
            this.btnClass,
            this.btnQuestions,
            this.btnLogout,
            this.txtFooterId,
            this.barStaticItem1,
            this.txtFooterFullName,
            this.txtFooterClass,
            this.btnInfo,
            this.txtFooterTenLop});
            this.ribbon.LargeImages = this.imageList1;
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 23;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.Home});
            this.ribbon.Size = new System.Drawing.Size(1008, 146);
            this.ribbon.StatusBar = this.rbFooter;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            this.imageList1.Images.SetKeyName(1, "delete.png");
            this.imageList1.Images.SetKeyName(2, "edit.png");
            this.imageList1.Images.SetKeyName(3, "search-circle-blue-32.png");
            this.imageList1.Images.SetKeyName(4, "prepare.png");
            this.imageList1.Images.SetKeyName(5, "start.png");
            this.imageList1.Images.SetKeyName(6, "logout.png");
            this.imageList1.Images.SetKeyName(7, "icon_class.png");
            this.imageList1.Images.SetKeyName(8, "icon_dept.png");
            this.imageList1.Images.SetKeyName(9, "icon_subject.png");
            this.imageList1.Images.SetKeyName(10, "icon_teacher.png");
            this.imageList1.Images.SetKeyName(11, "icon_class.png");
            this.imageList1.Images.SetKeyName(12, "icon_teacher.png");
            this.imageList1.Images.SetKeyName(13, "Apps-Dialog-Logout-icon-48.png");
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Thêm mới";
            this.btnAdd.Id = 4;
            this.btnAdd.ImageOptions.LargeImageIndex = 0;
            this.btnAdd.Name = "btnAdd";
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Sửa";
            this.btnEdit.Id = 5;
            this.btnEdit.ImageOptions.LargeImageIndex = 2;
            this.btnEdit.Name = "btnEdit";
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Xóa";
            this.btnDelete.Id = 6;
            this.btnDelete.ImageOptions.LargeImageIndex = 1;
            this.btnDelete.Name = "btnDelete";
            // 
            // btnSetup
            // 
            this.btnSetup.Caption = "Chuẩn bị thi";
            this.btnSetup.Id = 7;
            this.btnSetup.ImageOptions.LargeImageIndex = 4;
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSetup_ItemClick);
            // 
            // btnThi
            // 
            this.btnThi.Caption = "Thi";
            this.btnThi.Id = 8;
            this.btnThi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.ImageOptions.Image")));
            this.btnThi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnStart.ImageOptions.LargeImage")));
            this.btnThi.ImageOptions.LargeImageIndex = 5;
            this.btnThi.Name = "btnThi";
            this.btnThi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStart_ItemClick);
            // 
            // btnAddPacket
            // 
            this.btnAddPacket.Caption = "Thêm bộ đề";
            this.btnAddPacket.Id = 9;
            this.btnAddPacket.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPacket.ImageOptions.Image")));
            this.btnAddPacket.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAddPacket.ImageOptions.LargeImage")));
            this.btnAddPacket.ImageOptions.LargeImageIndex = 0;
            this.btnAddPacket.Name = "btnAddPacket";
            this.btnAddPacket.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddPacket_ItemClick);
            // 
            // btnStudent
            // 
            this.btnStudent.Caption = "Sinh Viên";
            this.btnStudent.Id = 10;
            this.btnStudent.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStudent.ImageOptions.Image")));
            this.btnStudent.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnStudent.ImageOptions.LargeImage")));
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStudent_ItemClick);
            // 
            // btnTeacher
            // 
            this.btnTeacher.Caption = "Giáo Viên";
            this.btnTeacher.Id = 11;
            this.btnTeacher.ImageOptions.LargeImageIndex = 12;
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTeacher_ItemClick);
            // 
            // btnDept
            // 
            this.btnDept.Caption = "Khoa";
            this.btnDept.Id = 12;
            this.btnDept.ImageOptions.LargeImageIndex = 8;
            this.btnDept.Name = "btnDept";
            this.btnDept.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDept_ItemClick);
            // 
            // btnSubject
            // 
            this.btnSubject.Caption = "Môn học";
            this.btnSubject.Id = 13;
            this.btnSubject.ImageOptions.LargeImageIndex = 9;
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSubject_ItemClick);
            // 
            // btnClass
            // 
            this.btnClass.Caption = "Lớp";
            this.btnClass.Id = 14;
            this.btnClass.ImageOptions.LargeImageIndex = 11;
            this.btnClass.Name = "btnClass";
            this.btnClass.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClass_ItemClick);
            // 
            // btnQuestions
            // 
            this.btnQuestions.Caption = "Đề thi";
            this.btnQuestions.Id = 15;
            this.btnQuestions.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQuestions.ImageOptions.Image")));
            this.btnQuestions.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQuestions.ImageOptions.LargeImage")));
            this.btnQuestions.Name = "btnQuestions";
            this.btnQuestions.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQuestions_ItemClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Đăng Xuất";
            this.btnLogout.Id = 16;
            this.btnLogout.ImageOptions.LargeImageIndex = 13;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // txtFooterId
            // 
            this.txtFooterId.Caption = "Id";
            this.txtFooterId.Id = 17;
            this.txtFooterId.Name = "txtFooterId";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 18;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // txtFooterFullName
            // 
            this.txtFooterFullName.Caption = "Full Name";
            this.txtFooterFullName.Id = 19;
            this.txtFooterFullName.Name = "txtFooterFullName";
            // 
            // txtFooterClass
            // 
            this.txtFooterClass.Caption = "Class";
            this.txtFooterClass.Id = 20;
            this.txtFooterClass.Name = "txtFooterClass";
            // 
            // btnInfo
            // 
            this.btnInfo.AllowAllUp = true;
            this.btnInfo.Caption = "Thông tin";
            this.btnInfo.Id = 21;
            this.btnInfo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.ImageOptions.Image")));
            this.btnInfo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnInfo.ImageOptions.LargeImage")));
            this.btnInfo.Name = "btnInfo";
            // 
            // txtFooterTenLop
            // 
            this.txtFooterTenLop.Caption = "Tên Lớp";
            this.txtFooterTenLop.Id = 22;
            this.txtFooterTenLop.Name = "txtFooterTenLop";
            // 
            // Home
            // 
            this.Home.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbFunction,
            this.rbControl,
            this.rbAccount});
            this.Home.Name = "Home";
            this.Home.Text = "Trang chủ";
            // 
            // rbFunction
            // 
            this.rbFunction.ItemLinks.Add(this.btnSetup, true);
            this.rbFunction.ItemLinks.Add(this.btnAddPacket, true);
            this.rbFunction.ItemLinks.Add(this.btnThi, true);
            this.rbFunction.Name = "rbFunction";
            this.rbFunction.Text = "Chức năng";
            // 
            // rbControl
            // 
            this.rbControl.AllowTextClipping = false;
            this.rbControl.ItemLinks.Add(this.btnQuestions, true);
            this.rbControl.ItemLinks.Add(this.btnSubject, true);
            this.rbControl.ItemLinks.Add(this.btnStudent, true);
            this.rbControl.ItemLinks.Add(this.btnClass, true);
            this.rbControl.ItemLinks.Add(this.btnTeacher, true);
            this.rbControl.ItemLinks.Add(this.btnDept, true);
            this.rbControl.Name = "rbControl";
            this.rbControl.Text = "Quản lý";
            // 
            // rbAccount
            // 
            this.rbAccount.ItemLinks.Add(this.btnInfo, true);
            this.rbAccount.ItemLinks.Add(this.btnLogout, true);
            this.rbAccount.Name = "rbAccount";
            this.rbAccount.Text = "Tài khoản";
            // 
            // rbFooter
            // 
            this.rbFooter.ItemLinks.Add(this.txtFooterId);
            this.rbFooter.ItemLinks.Add(this.txtFooterFullName);
            this.rbFooter.ItemLinks.Add(this.txtFooterClass);
            this.rbFooter.ItemLinks.Add(this.txtFooterTenLop);
            this.rbFooter.Location = new System.Drawing.Point(0, 428);
            this.rbFooter.Name = "rbFooter";
            this.rbFooter.Ribbon = this.ribbon;
            this.rbFooter.Size = new System.Drawing.Size(1008, 21);
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "ribbonPage3";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 449);
            this.Controls.Add(this.rbFooter);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.rbFooter;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage Home;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbFunction;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar rbFooter;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnSetup;
        private DevExpress.XtraBars.BarButtonItem btnThi;
        private DevExpress.XtraBars.BarButtonItem btnAddPacket;
        private DevExpress.XtraBars.BarButtonItem btnStudent;
        private DevExpress.XtraBars.BarButtonItem btnTeacher;
        private DevExpress.XtraBars.BarButtonItem btnDept;
        private DevExpress.XtraBars.BarButtonItem btnSubject;
        private DevExpress.XtraBars.BarButtonItem btnClass;
        private DevExpress.XtraBars.BarButtonItem btnQuestions;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbControl;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbAccount;
        private DevExpress.XtraBars.BarHeaderItem txtFooterId;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarHeaderItem txtFooterFullName;
        private DevExpress.XtraBars.BarHeaderItem txtFooterClass;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem btnInfo;
        private DevExpress.XtraBars.BarHeaderItem txtFooterTenLop;
    }
}