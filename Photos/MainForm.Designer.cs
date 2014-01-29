namespace Photos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.Label photoIDLabel;
            System.Windows.Forms.Label photoCategoryIDLabel;
            System.Windows.Forms.Label photoNameLabel;
            System.Windows.Forms.Label datePhotoTakenLabel;
            System.Windows.Forms.Label placePhotoTakenLabel;
            System.Windows.Forms.Label photoDescriptionLabel;
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myDatabaseDataSet = new Photos.MyDatabaseDataSet();
            this.photosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.photosTableAdapter = new Photos.MyDatabaseDataSetTableAdapters.PhotosTableAdapter();
            this.tableAdapterManager = new Photos.MyDatabaseDataSetTableAdapters.TableAdapterManager();
            this.photosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.photosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.photoIDLabel1 = new System.Windows.Forms.Label();
            this.photoCategoryIDComboBox = new System.Windows.Forms.ComboBox();
            this.photoNameTextBox = new System.Windows.Forms.TextBox();
            this.datePhotoTakenDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.placePhotoTakenTextBox = new System.Windows.Forms.TextBox();
            this.photoDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.photoCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.photoCategoriesTableAdapter = new Photos.MyDatabaseDataSetTableAdapters.PhotoCategoriesTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.photographPictureBox = new System.Windows.Forms.PictureBox();
            photoIDLabel = new System.Windows.Forms.Label();
            photoCategoryIDLabel = new System.Windows.Forms.Label();
            photoNameLabel = new System.Windows.Forms.Label();
            datePhotoTakenLabel = new System.Windows.Forms.Label();
            placePhotoTakenLabel = new System.Windows.Forms.Label();
            photoDescriptionLabel = new System.Windows.Forms.Label();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosBindingNavigator)).BeginInit();
            this.photosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoCategoriesBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photographPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(628, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // myDatabaseDataSet
            // 
            this.myDatabaseDataSet.DataSetName = "MyDatabaseDataSet";
            this.myDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // photosBindingSource
            // 
            this.photosBindingSource.DataMember = "Photos";
            this.photosBindingSource.DataSource = this.myDatabaseDataSet;
            // 
            // photosTableAdapter
            // 
            this.photosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PhotoCategoriesTableAdapter = this.photoCategoriesTableAdapter;
            this.tableAdapterManager.PhotosTableAdapter = this.photosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Photos.MyDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // photosBindingNavigator
            // 
            this.photosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.photosBindingNavigator.BindingSource = this.photosBindingSource;
            this.photosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.photosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.photosBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.photosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.photosBindingNavigatorSaveItem});
            this.photosBindingNavigator.Location = new System.Drawing.Point(0, 230);
            this.photosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.photosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.photosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.photosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.photosBindingNavigator.Name = "photosBindingNavigator";
            this.photosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.photosBindingNavigator.Size = new System.Drawing.Size(628, 25);
            this.photosBindingNavigator.TabIndex = 1;
            this.photosBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // photosBindingNavigatorSaveItem
            // 
            this.photosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.photosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("photosBindingNavigatorSaveItem.Image")));
            this.photosBindingNavigatorSaveItem.Name = "photosBindingNavigatorSaveItem";
            this.photosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.photosBindingNavigatorSaveItem.Text = "Save Data";
            this.photosBindingNavigatorSaveItem.Click += new System.EventHandler(this.photosBindingNavigatorSaveItem_Click);
            // 
            // photoIDLabel
            // 
            photoIDLabel.AutoSize = true;
            photoIDLabel.Location = new System.Drawing.Point(16, 36);
            photoIDLabel.Name = "photoIDLabel";
            photoIDLabel.Size = new System.Drawing.Size(52, 13);
            photoIDLabel.TabIndex = 2;
            photoIDLabel.Text = "Photo ID:";
            // 
            // photoIDLabel1
            // 
            this.photoIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photosBindingSource, "PhotoID", true));
            this.photoIDLabel1.Location = new System.Drawing.Point(116, 36);
            this.photoIDLabel1.Name = "photoIDLabel1";
            this.photoIDLabel1.Size = new System.Drawing.Size(100, 23);
            this.photoIDLabel1.TabIndex = 3;
            this.photoIDLabel1.Text = "label1";
            // 
            // photoCategoryIDLabel
            // 
            photoCategoryIDLabel.AutoSize = true;
            photoCategoryIDLabel.Location = new System.Drawing.Point(16, 59);
            photoCategoryIDLabel.Name = "photoCategoryIDLabel";
            photoCategoryIDLabel.Size = new System.Drawing.Size(97, 13);
            photoCategoryIDLabel.TabIndex = 4;
            photoCategoryIDLabel.Text = "Photo Category ID:";
            // 
            // photoCategoryIDComboBox
            // 
            this.photoCategoryIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.photosBindingSource, "PhotoCategoryID", true));
            this.photoCategoryIDComboBox.DataSource = this.photoCategoriesBindingSource;
            this.photoCategoryIDComboBox.DisplayMember = "PhotoCategoryName";
            this.photoCategoryIDComboBox.FormattingEnabled = true;
            this.photoCategoryIDComboBox.Location = new System.Drawing.Point(116, 56);
            this.photoCategoryIDComboBox.Name = "photoCategoryIDComboBox";
            this.photoCategoryIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.photoCategoryIDComboBox.TabIndex = 5;
            this.photoCategoryIDComboBox.ValueMember = "PhotoCategoryID";
            // 
            // photoNameLabel
            // 
            photoNameLabel.AutoSize = true;
            photoNameLabel.Location = new System.Drawing.Point(16, 85);
            photoNameLabel.Name = "photoNameLabel";
            photoNameLabel.Size = new System.Drawing.Size(69, 13);
            photoNameLabel.TabIndex = 6;
            photoNameLabel.Text = "Photo Name:";
            // 
            // photoNameTextBox
            // 
            this.photoNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photosBindingSource, "PhotoName", true));
            this.photoNameTextBox.Location = new System.Drawing.Point(116, 82);
            this.photoNameTextBox.Name = "photoNameTextBox";
            this.photoNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.photoNameTextBox.TabIndex = 7;
            // 
            // datePhotoTakenLabel
            // 
            datePhotoTakenLabel.AutoSize = true;
            datePhotoTakenLabel.Location = new System.Drawing.Point(16, 115);
            datePhotoTakenLabel.Name = "datePhotoTakenLabel";
            datePhotoTakenLabel.Size = new System.Drawing.Size(98, 13);
            datePhotoTakenLabel.TabIndex = 8;
            datePhotoTakenLabel.Text = "Date Photo Taken:";
            // 
            // datePhotoTakenDateTimePicker
            // 
            this.datePhotoTakenDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.photosBindingSource, "DatePhotoTaken", true));
            this.datePhotoTakenDateTimePicker.Location = new System.Drawing.Point(116, 111);
            this.datePhotoTakenDateTimePicker.Name = "datePhotoTakenDateTimePicker";
            this.datePhotoTakenDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datePhotoTakenDateTimePicker.TabIndex = 9;
            // 
            // placePhotoTakenLabel
            // 
            placePhotoTakenLabel.AutoSize = true;
            placePhotoTakenLabel.Location = new System.Drawing.Point(16, 143);
            placePhotoTakenLabel.Name = "placePhotoTakenLabel";
            placePhotoTakenLabel.Size = new System.Drawing.Size(102, 13);
            placePhotoTakenLabel.TabIndex = 10;
            placePhotoTakenLabel.Text = "Place Photo Taken:";
            // 
            // placePhotoTakenTextBox
            // 
            this.placePhotoTakenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photosBindingSource, "PlacePhotoTaken", true));
            this.placePhotoTakenTextBox.Location = new System.Drawing.Point(116, 140);
            this.placePhotoTakenTextBox.Name = "placePhotoTakenTextBox";
            this.placePhotoTakenTextBox.Size = new System.Drawing.Size(100, 20);
            this.placePhotoTakenTextBox.TabIndex = 11;
            // 
            // photoDescriptionLabel
            // 
            photoDescriptionLabel.AutoSize = true;
            photoDescriptionLabel.Location = new System.Drawing.Point(16, 176);
            photoDescriptionLabel.Name = "photoDescriptionLabel";
            photoDescriptionLabel.Size = new System.Drawing.Size(94, 13);
            photoDescriptionLabel.TabIndex = 12;
            photoDescriptionLabel.Text = "Photo Description:";
            // 
            // photoDescriptionTextBox
            // 
            this.photoDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photosBindingSource, "PhotoDescription", true));
            this.photoDescriptionTextBox.Location = new System.Drawing.Point(116, 173);
            this.photoDescriptionTextBox.Name = "photoDescriptionTextBox";
            this.photoDescriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.photoDescriptionTextBox.TabIndex = 13;
            // 
            // photoCategoriesBindingSource
            // 
            this.photoCategoriesBindingSource.DataMember = "PhotoCategories";
            this.photoCategoriesBindingSource.DataSource = this.myDatabaseDataSet;
            // 
            // photoCategoriesTableAdapter
            // 
            this.photoCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.photographPictureBox);
            this.panel1.Location = new System.Drawing.Point(322, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 192);
            this.panel1.TabIndex = 14;
            // 
            // photographPictureBox
            // 
            this.photographPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.photosBindingSource, "Photograph", true));
            this.photographPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.photographPictureBox.Location = new System.Drawing.Point(0, 0);
            this.photographPictureBox.Name = "photographPictureBox";
            this.photographPictureBox.Size = new System.Drawing.Size(291, 188);
            this.photographPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photographPictureBox.TabIndex = 1;
            this.photographPictureBox.TabStop = false;
            this.photographPictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.photographPictureBox_DragDrop);
            this.photographPictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.photographPictureBox_DragEnter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 255);
            this.Controls.Add(this.panel1);
            this.Controls.Add(photoDescriptionLabel);
            this.Controls.Add(this.photoDescriptionTextBox);
            this.Controls.Add(placePhotoTakenLabel);
            this.Controls.Add(this.placePhotoTakenTextBox);
            this.Controls.Add(datePhotoTakenLabel);
            this.Controls.Add(this.datePhotoTakenDateTimePicker);
            this.Controls.Add(photoNameLabel);
            this.Controls.Add(this.photoNameTextBox);
            this.Controls.Add(photoCategoryIDLabel);
            this.Controls.Add(this.photoCategoryIDComboBox);
            this.Controls.Add(photoIDLabel);
            this.Controls.Add(this.photoIDLabel1);
            this.Controls.Add(this.photosBindingNavigator);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosBindingNavigator)).EndInit();
            this.photosBindingNavigator.ResumeLayout(false);
            this.photosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoCategoriesBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.photographPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private MyDatabaseDataSet myDatabaseDataSet;
        private System.Windows.Forms.BindingSource photosBindingSource;
        private MyDatabaseDataSetTableAdapters.PhotosTableAdapter photosTableAdapter;
        private MyDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator photosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton photosBindingNavigatorSaveItem;
        private System.Windows.Forms.Label photoIDLabel1;
        private System.Windows.Forms.ComboBox photoCategoryIDComboBox;
        private System.Windows.Forms.TextBox photoNameTextBox;
        private System.Windows.Forms.DateTimePicker datePhotoTakenDateTimePicker;
        private System.Windows.Forms.TextBox placePhotoTakenTextBox;
        private System.Windows.Forms.TextBox photoDescriptionTextBox;
        private MyDatabaseDataSetTableAdapters.PhotoCategoriesTableAdapter photoCategoriesTableAdapter;
        private System.Windows.Forms.BindingSource photoCategoriesBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox photographPictureBox;
    }
}