
namespace ВодителиВАР3
{
    partial class Form3
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
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label address_lifeLabel;
            System.Windows.Forms.Label companyLabel;
            System.Windows.Forms.Label decriptionLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label jobnameLabel;
            System.Windows.Forms.Label middlenameLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label patronymicLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label photoLabel;
            System.Windows.Forms.Label ссерия_и_номер_паспортаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.driversBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.driversBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.driversBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.address_lifeTextBox = new System.Windows.Forms.TextBox();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.decriptionTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.jobnameTextBox = new System.Windows.Forms.TextBox();
            this.middlenameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.photoTextBox = new System.Windows.Forms.TextBox();
            this.ссерия_и_номер_паспортаTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            addressLabel = new System.Windows.Forms.Label();
            address_lifeLabel = new System.Windows.Forms.Label();
            companyLabel = new System.Windows.Forms.Label();
            decriptionLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            jobnameLabel = new System.Windows.Forms.Label();
            middlenameLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            patronymicLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            ссерия_и_номер_паспортаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingNavigator)).BeginInit();
            this.driversBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            addressLabel.Location = new System.Drawing.Point(144, 196);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(135, 17);
            addressLabel.TabIndex = 1;
            addressLabel.Text = "Адрес регистрации";
            addressLabel.Click += new System.EventHandler(this.addressLabel_Click);
            // 
            // address_lifeLabel
            // 
            address_lifeLabel.AutoSize = true;
            address_lifeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            address_lifeLabel.Location = new System.Drawing.Point(147, 233);
            address_lifeLabel.Name = "address_lifeLabel";
            address_lifeLabel.Size = new System.Drawing.Size(132, 17);
            address_lifeLabel.TabIndex = 3;
            address_lifeLabel.Text = "Адрес проживания";
            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            companyLabel.Location = new System.Drawing.Point(176, 260);
            companyLabel.Name = "companyLabel";
            companyLabel.Size = new System.Drawing.Size(102, 17);
            companyLabel.TabIndex = 5;
            companyLabel.Text = "Место работы";
            // 
            // decriptionLabel
            // 
            decriptionLabel.AutoSize = true;
            decriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            decriptionLabel.Location = new System.Drawing.Point(197, 413);
            decriptionLabel.Name = "decriptionLabel";
            decriptionLabel.Size = new System.Drawing.Size(82, 17);
            decriptionLabel.TabIndex = 7;
            decriptionLabel.Text = "Замечания";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            emailLabel.Location = new System.Drawing.Point(226, 352);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(45, 17);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "email:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            iDLabel.Location = new System.Drawing.Point(165, 38);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(114, 17);
            iDLabel.TabIndex = 11;
            iDLabel.Text = "Идентификатор";
            // 
            // jobnameLabel
            // 
            jobnameLabel.AutoSize = true;
            jobnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            jobnameLabel.Location = new System.Drawing.Point(193, 292);
            jobnameLabel.Name = "jobnameLabel";
            jobnameLabel.Size = new System.Drawing.Size(85, 17);
            jobnameLabel.TabIndex = 13;
            jobnameLabel.Text = "Должность:";
            // 
            // middlenameLabel
            // 
            middlenameLabel.AutoSize = true;
            middlenameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            middlenameLabel.Location = new System.Drawing.Point(199, 70);
            middlenameLabel.Name = "middlenameLabel";
            middlenameLabel.Size = new System.Drawing.Size(70, 17);
            middlenameLabel.TabIndex = 15;
            middlenameLabel.Text = "Фамилия";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            nameLabel.Location = new System.Drawing.Point(236, 102);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(35, 17);
            nameLabel.TabIndex = 17;
            nameLabel.Text = "Имя";
            // 
            // patronymicLabel
            // 
            patronymicLabel.AutoSize = true;
            patronymicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            patronymicLabel.Location = new System.Drawing.Point(207, 131);
            patronymicLabel.Name = "patronymicLabel";
            patronymicLabel.Size = new System.Drawing.Size(71, 17);
            patronymicLabel.TabIndex = 19;
            patronymicLabel.Text = "Отчество";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            phoneLabel.Location = new System.Drawing.Point(207, 323);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(68, 17);
            phoneLabel.TabIndex = 21;
            phoneLabel.Text = "Телефон";
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            photoLabel.Location = new System.Drawing.Point(186, 381);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(92, 17);
            photoLabel.TabIndex = 23;
            photoLabel.Text = "Фотография";
            // 
            // ссерия_и_номер_паспортаLabel
            // 
            ссерия_и_номер_паспортаLabel.AutoSize = true;
            ссерия_и_номер_паспортаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            ссерия_и_номер_паспортаLabel.Location = new System.Drawing.Point(96, 162);
            ссерия_и_номер_паспортаLabel.Name = "ссерия_и_номер_паспортаLabel";
            ссерия_и_номер_паспортаLabel.Size = new System.Drawing.Size(183, 17);
            ссерия_и_номер_паспортаLabel.TabIndex = 27;
            ссерия_и_номер_паспортаLabel.Text = "Ссерия и номер паспорта:";
            // 
            // driversBindingNavigator
            // 
            this.driversBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.driversBindingNavigator.BindingSource = this.driversBindingSource;
            this.driversBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.driversBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.driversBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.driversBindingNavigatorSaveItem});
            this.driversBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.driversBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.driversBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.driversBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.driversBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.driversBindingNavigator.Name = "driversBindingNavigator";
            this.driversBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.driversBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.driversBindingNavigator.TabIndex = 0;
            this.driversBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // driversBindingSource
            // 
            this.driversBindingSource.DataSource = typeof(ВодителиВАР3.Drivers);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
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
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // driversBindingNavigatorSaveItem
            // 
            this.driversBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.driversBindingNavigatorSaveItem.Enabled = false;
            this.driversBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("driversBindingNavigatorSaveItem.Image")));
            this.driversBindingNavigatorSaveItem.Name = "driversBindingNavigatorSaveItem";
            this.driversBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.driversBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "address", true));
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addressTextBox.Location = new System.Drawing.Point(285, 193);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(218, 23);
            this.addressTextBox.TabIndex = 2;
            // 
            // address_lifeTextBox
            // 
            this.address_lifeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "address_life", true));
            this.address_lifeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.address_lifeTextBox.Location = new System.Drawing.Point(285, 227);
            this.address_lifeTextBox.Name = "address_lifeTextBox";
            this.address_lifeTextBox.Size = new System.Drawing.Size(218, 23);
            this.address_lifeTextBox.TabIndex = 4;
            // 
            // companyTextBox
            // 
            this.companyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "company", true));
            this.companyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.companyTextBox.Location = new System.Drawing.Point(285, 257);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(218, 23);
            this.companyTextBox.TabIndex = 6;
            // 
            // decriptionTextBox
            // 
            this.decriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "decription", true));
            this.decriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.decriptionTextBox.Location = new System.Drawing.Point(285, 407);
            this.decriptionTextBox.Name = "decriptionTextBox";
            this.decriptionTextBox.Size = new System.Drawing.Size(218, 23);
            this.decriptionTextBox.TabIndex = 8;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.emailTextBox.Location = new System.Drawing.Point(285, 349);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(218, 23);
            this.emailTextBox.TabIndex = 10;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "ID", true));
            this.iDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.iDTextBox.Location = new System.Drawing.Point(285, 38);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(218, 23);
            this.iDTextBox.TabIndex = 12;
            // 
            // jobnameTextBox
            // 
            this.jobnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "jobname", true));
            this.jobnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.jobnameTextBox.Location = new System.Drawing.Point(285, 289);
            this.jobnameTextBox.Name = "jobnameTextBox";
            this.jobnameTextBox.Size = new System.Drawing.Size(218, 23);
            this.jobnameTextBox.TabIndex = 14;
            // 
            // middlenameTextBox
            // 
            this.middlenameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "middlename", true));
            this.middlenameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.middlenameTextBox.Location = new System.Drawing.Point(285, 67);
            this.middlenameTextBox.Name = "middlenameTextBox";
            this.middlenameTextBox.Size = new System.Drawing.Size(218, 23);
            this.middlenameTextBox.TabIndex = 16;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameTextBox.Location = new System.Drawing.Point(285, 99);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(218, 23);
            this.nameTextBox.TabIndex = 18;
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "patronymic", true));
            this.patronymicTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.patronymicTextBox.Location = new System.Drawing.Point(285, 128);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(218, 23);
            this.patronymicTextBox.TabIndex = 20;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "phone", true));
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.phoneTextBox.Location = new System.Drawing.Point(285, 321);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(218, 23);
            this.phoneTextBox.TabIndex = 22;
            // 
            // photoTextBox
            // 
            this.photoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "photo", true));
            this.photoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.photoTextBox.Location = new System.Drawing.Point(285, 378);
            this.photoTextBox.Name = "photoTextBox";
            this.photoTextBox.Size = new System.Drawing.Size(218, 23);
            this.photoTextBox.TabIndex = 24;
            // 
            // ссерия_и_номер_паспортаTextBox
            // 
            this.ссерия_и_номер_паспортаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "Ссерия_и_номер_паспорта", true));
            this.ссерия_и_номер_паспортаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ссерия_и_номер_паспортаTextBox.Location = new System.Drawing.Point(285, 159);
            this.ссерия_и_номер_паспортаTextBox.Name = "ссерия_и_номер_паспортаTextBox";
            this.ссерия_и_номер_паспортаTextBox.Size = new System.Drawing.Size(218, 23);
            this.ссерия_и_номер_паспортаTextBox.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.button1.Location = new System.Drawing.Point(561, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 51);
            this.button1.TabIndex = 29;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button2.Location = new System.Drawing.Point(683, 413);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 39);
            this.button2.TabIndex = 30;
            this.button2.Text = "Выйти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(address_lifeLabel);
            this.Controls.Add(this.address_lifeTextBox);
            this.Controls.Add(companyLabel);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(decriptionLabel);
            this.Controls.Add(this.decriptionTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(jobnameLabel);
            this.Controls.Add(this.jobnameTextBox);
            this.Controls.Add(middlenameLabel);
            this.Controls.Add(this.middlenameTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(patronymicLabel);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(photoLabel);
            this.Controls.Add(this.photoTextBox);
            this.Controls.Add(ссерия_и_номер_паспортаLabel);
            this.Controls.Add(this.ссерия_и_номер_паспортаTextBox);
            this.Controls.Add(this.driversBindingNavigator);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form3";
            this.Text = "Добавление/изменение данных";
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingNavigator)).EndInit();
            this.driversBindingNavigator.ResumeLayout(false);
            this.driversBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource driversBindingSource;
        private System.Windows.Forms.BindingNavigator driversBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton driversBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox address_lifeTextBox;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.TextBox decriptionTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox jobnameTextBox;
        private System.Windows.Forms.TextBox middlenameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox photoTextBox;
        private System.Windows.Forms.TextBox ссерия_и_номер_паспортаTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}