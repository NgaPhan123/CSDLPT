namespace QLDSV
{
    partial class frmPhieuDiem
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
            System.Windows.Forms.Label mASVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuDiem));
            System.Windows.Forms.Label mAKHLabel;
            this.btnPreview = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dS = new QLDSV.DS();
            this.cmbMaSV = new System.Windows.Forms.ComboBox();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crptView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SINHVIENTableAdapter = new QLDSV.DSTableAdapters.SINHVIENTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.sINHVIENBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sINHVIENBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KHOATableAdapter = new QLDSV.DSTableAdapters.KHOATableAdapter();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            mASVLabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingNavigator)).BeginInit();
            this.sINHVIENBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(379, 74);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(88, 17);
            mASVLabel.TabIndex = 6;
            mASVLabel.Text = "Mã Sinh Viên";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(219, 109);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 3;
            this.btnPreview.Text = "Màn Hình";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(355, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Máy In";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(485, 109);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "PHIẾU ĐIỂM";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(mAKHLabel);
            this.panel1.Controls.Add(this.cmbKhoa);
            this.panel1.Controls.Add(mASVLabel);
            this.panel1.Controls.Add(this.cmbMaSV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnPreview);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 152);
            this.panel1.TabIndex = 0;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbMaSV
            // 
            this.cmbMaSV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sINHVIENBindingSource, "MASV", true));
            this.cmbMaSV.DataSource = this.sINHVIENBindingSource;
            this.cmbMaSV.DisplayMember = "MASV";
            this.cmbMaSV.FormattingEnabled = true;
            this.cmbMaSV.Location = new System.Drawing.Point(485, 66);
            this.cmbMaSV.Name = "cmbMaSV";
            this.cmbMaSV.Size = new System.Drawing.Size(121, 25);
            this.cmbMaSV.TabIndex = 7;
            this.cmbMaSV.ValueMember = "TEN";
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.dS;
            // 
            // crptView
            // 
            this.crptView.ActiveViewIndex = -1;
            this.crptView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crptView.Cursor = System.Windows.Forms.Cursors.Default;
            this.crptView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crptView.Location = new System.Drawing.Point(0, 152);
            this.crptView.Name = "crptView";
            this.crptView.Size = new System.Drawing.Size(1091, 400);
            this.crptView.TabIndex = 1;
            // 
            // SINHVIENTableAdapter
            // 
            this.SINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEM1TableAdapter = null;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOP1TableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.SINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sINHVIENBindingNavigator
            // 
            this.sINHVIENBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sINHVIENBindingNavigator.BindingSource = this.sINHVIENBindingSource;
            this.sINHVIENBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sINHVIENBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sINHVIENBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.sINHVIENBindingNavigatorSaveItem});
            this.sINHVIENBindingNavigator.Location = new System.Drawing.Point(0, 152);
            this.sINHVIENBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sINHVIENBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sINHVIENBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sINHVIENBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sINHVIENBindingNavigator.Name = "sINHVIENBindingNavigator";
            this.sINHVIENBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sINHVIENBindingNavigator.Size = new System.Drawing.Size(1091, 25);
            this.sINHVIENBindingNavigator.TabIndex = 2;
            this.sINHVIENBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // sINHVIENBindingNavigatorSaveItem
            // 
            this.sINHVIENBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sINHVIENBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sINHVIENBindingNavigatorSaveItem.Image")));
            this.sINHVIENBindingNavigatorSaveItem.Name = "sINHVIENBindingNavigatorSaveItem";
            this.sINHVIENBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.sINHVIENBindingNavigatorSaveItem.Text = "Save Data";
            this.sINHVIENBindingNavigatorSaveItem.Click += new System.EventHandler(this.sINHVIENBindingNavigatorSaveItem_Click);
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "KHOA";
            this.kHOABindingSource.DataSource = this.dS;
            // 
            // KHOATableAdapter
            // 
            this.KHOATableAdapter.ClearBeforeFill = true;
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(138, 74);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(67, 17);
            mAKHLabel.TabIndex = 7;
            mAKHLabel.Text = "Mã Khoa:";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DataSource = this.kHOABindingSource;
            this.cmbKhoa.DisplayMember = "MAKH";
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(211, 71);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(121, 25);
            this.cmbKhoa.TabIndex = 8;
            this.cmbKhoa.ValueMember = "TENKH";
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // frmPhieuDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 552);
            this.Controls.Add(this.sINHVIENBindingNavigator);
            this.Controls.Add(this.crptView);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhieuDiem";
            this.Text = "frmPhieuDiem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhieuDiem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingNavigator)).EndInit();
            this.sINHVIENBindingNavigator.ResumeLayout(false);
            this.sINHVIENBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crptView;
        private DS dS;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private DSTableAdapters.SINHVIENTableAdapter SINHVIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sINHVIENBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton sINHVIENBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox cmbMaSV;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private DSTableAdapters.KHOATableAdapter KHOATableAdapter;
        private System.Windows.Forms.ComboBox cmbKhoa;
    }
}