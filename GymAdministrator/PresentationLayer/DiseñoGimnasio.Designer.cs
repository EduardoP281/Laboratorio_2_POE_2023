namespace PresentationLayer
{
    partial class DiseñoGimnasio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiseñoGimnasio));
            gymAdminTab = new TabControl();
            membersTab = new TabPage();
            membersBox = new GroupBox();
            emailTextBox = new TextBox();
            numberPhoneTextBox = new TextBox();
            textBox3 = new TextBox();
            nameTextBox = new TextBox();
            duiTextBox = new TextBox();
            emailLabel = new Label();
            numberPhoneLabel = new Label();
            lastNameLabel = new Label();
            nameLabel = new Label();
            duiLabel = new Label();
            deleteButton = new Button();
            editButton = new Button();
            deleteButtom = new Button();
            membershipTab = new TabPage();
            membershipManagerGroupBox = new GroupBox();
            membershipStateButton = new Button();
            membershipStateComboBox = new ComboBox();
            duiMemberTextBox = new TextBox();
            membershipStateLabel = new Label();
            duiMemberLabel = new Label();
            registerMembershipGroupBox = new GroupBox();
            addMemberButton = new Button();
            priceMembershipComboBox = new ComboBox();
            typeMembershipComboBox = new ComboBox();
            priceMembershipLabel = new Label();
            typeMembershipLabel = new Label();
            sesionTab = new TabPage();
            instructorGroupBox = new GroupBox();
            addInstructorButton = new Button();
            instructorPaymentTextBox = new TextBox();
            instructorEmailTextBox = new TextBox();
            instructorPhoneNumberTextBox = new TextBox();
            instructorLastNameTextBox = new TextBox();
            instructorNameTextBox = new TextBox();
            instructorStateComboBox = new ComboBox();
            instructorStateLabel = new Label();
            instructorPaymentLabel = new Label();
            instructorEmailLabel = new Label();
            instructorPhoneNumberLabel = new Label();
            instructorLastNameLabel = new Label();
            instructorNameLabel = new Label();
            classGroupBox = new GroupBox();
            addTypeExcerciseButton = new Button();
            roomComboBox = new ComboBox();
            typeExcerciseComboBox = new ComboBox();
            roomLabel = new Label();
            excerciseTypeLabel = new Label();
            asistenceTab = new TabPage();
            assistenceGroupBox = new GroupBox();
            addAssistenceButton = new Button();
            assistenceStateCheckedListBox = new CheckedListBox();
            assistenceDateTimePicker = new DateTimePicker();
            assistenceStateLabel = new Label();
            assistenceDateLabel = new Label();
            gymAdminTab.SuspendLayout();
            membersTab.SuspendLayout();
            membersBox.SuspendLayout();
            membershipTab.SuspendLayout();
            membershipManagerGroupBox.SuspendLayout();
            registerMembershipGroupBox.SuspendLayout();
            sesionTab.SuspendLayout();
            instructorGroupBox.SuspendLayout();
            classGroupBox.SuspendLayout();
            asistenceTab.SuspendLayout();
            assistenceGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // gymAdminTab
            // 
            gymAdminTab.Controls.Add(membersTab);
            gymAdminTab.Controls.Add(membershipTab);
            gymAdminTab.Controls.Add(sesionTab);
            gymAdminTab.Controls.Add(asistenceTab);
            gymAdminTab.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gymAdminTab.Location = new Point(81, 25);
            gymAdminTab.Name = "gymAdminTab";
            gymAdminTab.SelectedIndex = 0;
            gymAdminTab.Size = new Size(576, 547);
            gymAdminTab.TabIndex = 0;
            // 
            // membersTab
            // 
            membersTab.Controls.Add(membersBox);
            membersTab.Location = new Point(4, 28);
            membersTab.Name = "membersTab";
            membersTab.Padding = new Padding(3);
            membersTab.Size = new Size(568, 515);
            membersTab.TabIndex = 0;
            membersTab.Text = "Miembros";
            membersTab.UseVisualStyleBackColor = true;
            // 
            // membersBox
            // 
            membersBox.BackColor = SystemColors.ControlLightLight;
            membersBox.Controls.Add(emailTextBox);
            membersBox.Controls.Add(numberPhoneTextBox);
            membersBox.Controls.Add(textBox3);
            membersBox.Controls.Add(nameTextBox);
            membersBox.Controls.Add(duiTextBox);
            membersBox.Controls.Add(emailLabel);
            membersBox.Controls.Add(numberPhoneLabel);
            membersBox.Controls.Add(lastNameLabel);
            membersBox.Controls.Add(nameLabel);
            membersBox.Controls.Add(duiLabel);
            membersBox.Controls.Add(deleteButton);
            membersBox.Controls.Add(editButton);
            membersBox.Controls.Add(deleteButtom);
            membersBox.Location = new Point(22, 17);
            membersBox.Name = "membersBox";
            membersBox.Size = new Size(517, 452);
            membersBox.TabIndex = 0;
            membersBox.TabStop = false;
            membersBox.Text = "REGISTRO DE MIEMBROS";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(160, 317);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(185, 26);
            emailTextBox.TabIndex = 12;
            // 
            // numberPhoneTextBox
            // 
            numberPhoneTextBox.Location = new Point(160, 250);
            numberPhoneTextBox.Name = "numberPhoneTextBox";
            numberPhoneTextBox.Size = new Size(185, 26);
            numberPhoneTextBox.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(160, 183);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(185, 26);
            textBox3.TabIndex = 10;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(160, 119);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(185, 26);
            nameTextBox.TabIndex = 9;
            // 
            // duiTextBox
            // 
            duiTextBox.Location = new Point(160, 56);
            duiTextBox.Name = "duiTextBox";
            duiTextBox.Size = new Size(185, 26);
            duiTextBox.TabIndex = 8;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(160, 295);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(56, 19);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "Correo";
            // 
            // numberPhoneLabel
            // 
            numberPhoneLabel.AutoSize = true;
            numberPhoneLabel.Location = new Point(160, 228);
            numberPhoneLabel.Name = "numberPhoneLabel";
            numberPhoneLabel.Size = new Size(67, 19);
            numberPhoneLabel.TabIndex = 6;
            numberPhoneLabel.Text = "Telefono";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(160, 161);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(66, 19);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Apellido";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(160, 97);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(65, 19);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Nombre";
            // 
            // duiLabel
            // 
            duiLabel.AutoSize = true;
            duiLabel.Location = new Point(160, 34);
            duiLabel.Name = "duiLabel";
            duiLabel.Size = new Size(33, 19);
            duiLabel.TabIndex = 3;
            duiLabel.Text = "DUI";
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(335, 388);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(87, 31);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Eliminar";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            editButton.Location = new Point(217, 388);
            editButton.Name = "editButton";
            editButton.Size = new Size(87, 31);
            editButton.TabIndex = 1;
            editButton.Text = "Editar";
            editButton.UseVisualStyleBackColor = true;
            // 
            // deleteButtom
            // 
            deleteButtom.Location = new Point(94, 388);
            deleteButtom.Name = "deleteButtom";
            deleteButtom.Size = new Size(82, 31);
            deleteButtom.TabIndex = 0;
            deleteButtom.Text = "Eliminar";
            deleteButtom.UseVisualStyleBackColor = true;
            // 
            // membershipTab
            // 
            membershipTab.Controls.Add(membershipManagerGroupBox);
            membershipTab.Controls.Add(registerMembershipGroupBox);
            membershipTab.Location = new Point(4, 28);
            membershipTab.Name = "membershipTab";
            membershipTab.Padding = new Padding(3);
            membershipTab.Size = new Size(568, 515);
            membershipTab.TabIndex = 1;
            membershipTab.Text = "Membresias";
            membershipTab.UseVisualStyleBackColor = true;
            // 
            // membershipManagerGroupBox
            // 
            membershipManagerGroupBox.Controls.Add(membershipStateButton);
            membershipManagerGroupBox.Controls.Add(membershipStateComboBox);
            membershipManagerGroupBox.Controls.Add(duiMemberTextBox);
            membershipManagerGroupBox.Controls.Add(membershipStateLabel);
            membershipManagerGroupBox.Controls.Add(duiMemberLabel);
            membershipManagerGroupBox.Location = new Point(308, 26);
            membershipManagerGroupBox.Name = "membershipManagerGroupBox";
            membershipManagerGroupBox.Size = new Size(231, 431);
            membershipManagerGroupBox.TabIndex = 1;
            membershipManagerGroupBox.TabStop = false;
            membershipManagerGroupBox.Text = "GESTION DE MEMBRESIAS";
            // 
            // membershipStateButton
            // 
            membershipStateButton.Location = new Point(68, 329);
            membershipStateButton.Name = "membershipStateButton";
            membershipStateButton.Size = new Size(92, 31);
            membershipStateButton.TabIndex = 4;
            membershipStateButton.Text = "Editar";
            membershipStateButton.UseVisualStyleBackColor = true;
            // 
            // membershipStateComboBox
            // 
            membershipStateComboBox.FormattingEnabled = true;
            membershipStateComboBox.Location = new Point(36, 257);
            membershipStateComboBox.Name = "membershipStateComboBox";
            membershipStateComboBox.Size = new Size(167, 27);
            membershipStateComboBox.TabIndex = 3;
            // 
            // duiMemberTextBox
            // 
            duiMemberTextBox.Location = new Point(36, 119);
            duiMemberTextBox.Name = "duiMemberTextBox";
            duiMemberTextBox.Size = new Size(167, 26);
            duiMemberTextBox.TabIndex = 2;
            // 
            // membershipStateLabel
            // 
            membershipStateLabel.AutoSize = true;
            membershipStateLabel.Location = new Point(36, 192);
            membershipStateLabel.Name = "membershipStateLabel";
            membershipStateLabel.Size = new Size(153, 19);
            membershipStateLabel.TabIndex = 1;
            membershipStateLabel.Text = "Estado de membresia";
            // 
            // duiMemberLabel
            // 
            duiMemberLabel.AutoSize = true;
            duiMemberLabel.Location = new Point(36, 64);
            duiMemberLabel.Name = "duiMemberLabel";
            duiMemberLabel.Size = new Size(33, 19);
            duiMemberLabel.TabIndex = 0;
            duiMemberLabel.Text = "DUI";
            // 
            // registerMembershipGroupBox
            // 
            registerMembershipGroupBox.Controls.Add(addMemberButton);
            registerMembershipGroupBox.Controls.Add(priceMembershipComboBox);
            registerMembershipGroupBox.Controls.Add(typeMembershipComboBox);
            registerMembershipGroupBox.Controls.Add(priceMembershipLabel);
            registerMembershipGroupBox.Controls.Add(typeMembershipLabel);
            registerMembershipGroupBox.Location = new Point(40, 29);
            registerMembershipGroupBox.Name = "registerMembershipGroupBox";
            registerMembershipGroupBox.Size = new Size(222, 428);
            registerMembershipGroupBox.TabIndex = 0;
            registerMembershipGroupBox.TabStop = false;
            registerMembershipGroupBox.Text = "REGISTRO DE MEMBRESIAS";
            // 
            // addMemberButton
            // 
            addMemberButton.Location = new Point(73, 326);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(90, 31);
            addMemberButton.TabIndex = 4;
            addMemberButton.Text = "Agregar";
            addMemberButton.UseVisualStyleBackColor = true;
            // 
            // priceMembershipComboBox
            // 
            priceMembershipComboBox.FormattingEnabled = true;
            priceMembershipComboBox.Location = new Point(24, 254);
            priceMembershipComboBox.Name = "priceMembershipComboBox";
            priceMembershipComboBox.Size = new Size(171, 27);
            priceMembershipComboBox.TabIndex = 3;
            // 
            // typeMembershipComboBox
            // 
            typeMembershipComboBox.FormattingEnabled = true;
            typeMembershipComboBox.Location = new Point(24, 115);
            typeMembershipComboBox.Name = "typeMembershipComboBox";
            typeMembershipComboBox.Size = new Size(171, 27);
            typeMembershipComboBox.TabIndex = 2;
            // 
            // priceMembershipLabel
            // 
            priceMembershipLabel.AutoSize = true;
            priceMembershipLabel.Location = new Point(24, 189);
            priceMembershipLabel.Name = "priceMembershipLabel";
            priceMembershipLabel.Size = new Size(152, 19);
            priceMembershipLabel.TabIndex = 1;
            priceMembershipLabel.Text = "Precio de membresia";
            // 
            // typeMembershipLabel
            // 
            typeMembershipLabel.AutoSize = true;
            typeMembershipLabel.Location = new Point(24, 61);
            typeMembershipLabel.Name = "typeMembershipLabel";
            typeMembershipLabel.Size = new Size(139, 19);
            typeMembershipLabel.TabIndex = 0;
            typeMembershipLabel.Text = "Tipo de membresia";
            // 
            // sesionTab
            // 
            sesionTab.Controls.Add(instructorGroupBox);
            sesionTab.Controls.Add(classGroupBox);
            sesionTab.Location = new Point(4, 28);
            sesionTab.Name = "sesionTab";
            sesionTab.Padding = new Padding(3);
            sesionTab.Size = new Size(568, 515);
            sesionTab.TabIndex = 2;
            sesionTab.Text = "Sesión";
            sesionTab.UseVisualStyleBackColor = true;
            // 
            // instructorGroupBox
            // 
            instructorGroupBox.Controls.Add(addInstructorButton);
            instructorGroupBox.Controls.Add(instructorPaymentTextBox);
            instructorGroupBox.Controls.Add(instructorEmailTextBox);
            instructorGroupBox.Controls.Add(instructorPhoneNumberTextBox);
            instructorGroupBox.Controls.Add(instructorLastNameTextBox);
            instructorGroupBox.Controls.Add(instructorNameTextBox);
            instructorGroupBox.Controls.Add(instructorStateComboBox);
            instructorGroupBox.Controls.Add(instructorStateLabel);
            instructorGroupBox.Controls.Add(instructorPaymentLabel);
            instructorGroupBox.Controls.Add(instructorEmailLabel);
            instructorGroupBox.Controls.Add(instructorPhoneNumberLabel);
            instructorGroupBox.Controls.Add(instructorLastNameLabel);
            instructorGroupBox.Controls.Add(instructorNameLabel);
            instructorGroupBox.Location = new Point(268, 37);
            instructorGroupBox.Name = "instructorGroupBox";
            instructorGroupBox.Size = new Size(253, 446);
            instructorGroupBox.TabIndex = 1;
            instructorGroupBox.TabStop = false;
            instructorGroupBox.Text = "INSTRUCTOR";
            // 
            // addInstructorButton
            // 
            addInstructorButton.Location = new Point(84, 396);
            addInstructorButton.Name = "addInstructorButton";
            addInstructorButton.Size = new Size(81, 32);
            addInstructorButton.TabIndex = 12;
            addInstructorButton.Text = "Agregar";
            addInstructorButton.UseVisualStyleBackColor = true;
            // 
            // instructorPaymentTextBox
            // 
            instructorPaymentTextBox.Location = new Point(33, 297);
            instructorPaymentTextBox.Name = "instructorPaymentTextBox";
            instructorPaymentTextBox.Size = new Size(185, 26);
            instructorPaymentTextBox.TabIndex = 11;
            // 
            // instructorEmailTextBox
            // 
            instructorEmailTextBox.Location = new Point(33, 243);
            instructorEmailTextBox.Name = "instructorEmailTextBox";
            instructorEmailTextBox.Size = new Size(185, 26);
            instructorEmailTextBox.TabIndex = 10;
            // 
            // instructorPhoneNumberTextBox
            // 
            instructorPhoneNumberTextBox.Location = new Point(33, 187);
            instructorPhoneNumberTextBox.Name = "instructorPhoneNumberTextBox";
            instructorPhoneNumberTextBox.Size = new Size(185, 26);
            instructorPhoneNumberTextBox.TabIndex = 9;
            // 
            // instructorLastNameTextBox
            // 
            instructorLastNameTextBox.Location = new Point(33, 125);
            instructorLastNameTextBox.Name = "instructorLastNameTextBox";
            instructorLastNameTextBox.Size = new Size(185, 26);
            instructorLastNameTextBox.TabIndex = 8;
            // 
            // instructorNameTextBox
            // 
            instructorNameTextBox.Location = new Point(33, 66);
            instructorNameTextBox.Name = "instructorNameTextBox";
            instructorNameTextBox.Size = new Size(185, 26);
            instructorNameTextBox.TabIndex = 7;
            // 
            // instructorStateComboBox
            // 
            instructorStateComboBox.FormattingEnabled = true;
            instructorStateComboBox.Location = new Point(33, 353);
            instructorStateComboBox.Name = "instructorStateComboBox";
            instructorStateComboBox.Size = new Size(185, 27);
            instructorStateComboBox.TabIndex = 6;
            // 
            // instructorStateLabel
            // 
            instructorStateLabel.AutoSize = true;
            instructorStateLabel.Location = new Point(33, 331);
            instructorStateLabel.Name = "instructorStateLabel";
            instructorStateLabel.Size = new Size(53, 19);
            instructorStateLabel.TabIndex = 5;
            instructorStateLabel.Text = "Estado";
            // 
            // instructorPaymentLabel
            // 
            instructorPaymentLabel.AutoSize = true;
            instructorPaymentLabel.Location = new Point(33, 275);
            instructorPaymentLabel.Name = "instructorPaymentLabel";
            instructorPaymentLabel.Size = new Size(55, 19);
            instructorPaymentLabel.TabIndex = 4;
            instructorPaymentLabel.Text = "Sueldo";
            // 
            // instructorEmailLabel
            // 
            instructorEmailLabel.AutoSize = true;
            instructorEmailLabel.Location = new Point(33, 221);
            instructorEmailLabel.Name = "instructorEmailLabel";
            instructorEmailLabel.Size = new Size(56, 19);
            instructorEmailLabel.TabIndex = 3;
            instructorEmailLabel.Text = "Correo";
            // 
            // instructorPhoneNumberLabel
            // 
            instructorPhoneNumberLabel.AutoSize = true;
            instructorPhoneNumberLabel.Location = new Point(33, 165);
            instructorPhoneNumberLabel.Name = "instructorPhoneNumberLabel";
            instructorPhoneNumberLabel.Size = new Size(67, 19);
            instructorPhoneNumberLabel.TabIndex = 2;
            instructorPhoneNumberLabel.Text = "Teléfono";
            // 
            // instructorLastNameLabel
            // 
            instructorLastNameLabel.AutoSize = true;
            instructorLastNameLabel.Location = new Point(33, 103);
            instructorLastNameLabel.Name = "instructorLastNameLabel";
            instructorLastNameLabel.Size = new Size(66, 19);
            instructorLastNameLabel.TabIndex = 1;
            instructorLastNameLabel.Text = "Apellido";
            // 
            // instructorNameLabel
            // 
            instructorNameLabel.AutoSize = true;
            instructorNameLabel.Location = new Point(33, 44);
            instructorNameLabel.Name = "instructorNameLabel";
            instructorNameLabel.Size = new Size(65, 19);
            instructorNameLabel.TabIndex = 0;
            instructorNameLabel.Text = "Nombre";
            // 
            // classGroupBox
            // 
            classGroupBox.Controls.Add(addTypeExcerciseButton);
            classGroupBox.Controls.Add(roomComboBox);
            classGroupBox.Controls.Add(typeExcerciseComboBox);
            classGroupBox.Controls.Add(roomLabel);
            classGroupBox.Controls.Add(excerciseTypeLabel);
            classGroupBox.Location = new Point(30, 53);
            classGroupBox.Name = "classGroupBox";
            classGroupBox.Size = new Size(197, 346);
            classGroupBox.TabIndex = 0;
            classGroupBox.TabStop = false;
            classGroupBox.Text = "CLASE";
            // 
            // addTypeExcerciseButton
            // 
            addTypeExcerciseButton.Location = new Point(60, 252);
            addTypeExcerciseButton.Name = "addTypeExcerciseButton";
            addTypeExcerciseButton.Size = new Size(76, 33);
            addTypeExcerciseButton.TabIndex = 4;
            addTypeExcerciseButton.Text = "Agregar";
            addTypeExcerciseButton.UseVisualStyleBackColor = true;
            // 
            // roomComboBox
            // 
            roomComboBox.FormattingEnabled = true;
            roomComboBox.Location = new Point(15, 197);
            roomComboBox.Name = "roomComboBox";
            roomComboBox.Size = new Size(158, 27);
            roomComboBox.TabIndex = 3;
            // 
            // typeExcerciseComboBox
            // 
            typeExcerciseComboBox.FormattingEnabled = true;
            typeExcerciseComboBox.Location = new Point(15, 100);
            typeExcerciseComboBox.Name = "typeExcerciseComboBox";
            typeExcerciseComboBox.Size = new Size(158, 27);
            typeExcerciseComboBox.TabIndex = 2;
            // 
            // roomLabel
            // 
            roomLabel.AutoSize = true;
            roomLabel.Location = new Point(15, 149);
            roomLabel.Name = "roomLabel";
            roomLabel.Size = new Size(43, 19);
            roomLabel.TabIndex = 1;
            roomLabel.Text = "Salas";
            // 
            // excerciseTypeLabel
            // 
            excerciseTypeLabel.AutoSize = true;
            excerciseTypeLabel.Location = new Point(15, 49);
            excerciseTypeLabel.Name = "excerciseTypeLabel";
            excerciseTypeLabel.Size = new Size(121, 19);
            excerciseTypeLabel.TabIndex = 0;
            excerciseTypeLabel.Text = "Tipo de ejercicio";
            // 
            // asistenceTab
            // 
            asistenceTab.Controls.Add(assistenceGroupBox);
            asistenceTab.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            asistenceTab.Location = new Point(4, 28);
            asistenceTab.Name = "asistenceTab";
            asistenceTab.Padding = new Padding(3);
            asistenceTab.Size = new Size(568, 515);
            asistenceTab.TabIndex = 3;
            asistenceTab.Text = "Asistencia";
            asistenceTab.UseVisualStyleBackColor = true;
            // 
            // assistenceGroupBox
            // 
            assistenceGroupBox.Controls.Add(addAssistenceButton);
            assistenceGroupBox.Controls.Add(assistenceStateCheckedListBox);
            assistenceGroupBox.Controls.Add(assistenceDateTimePicker);
            assistenceGroupBox.Controls.Add(assistenceStateLabel);
            assistenceGroupBox.Controls.Add(assistenceDateLabel);
            assistenceGroupBox.Location = new Point(98, 37);
            assistenceGroupBox.Name = "assistenceGroupBox";
            assistenceGroupBox.Size = new Size(366, 421);
            assistenceGroupBox.TabIndex = 0;
            assistenceGroupBox.TabStop = false;
            assistenceGroupBox.Text = "Asistencia";
            // 
            // addAssistenceButton
            // 
            addAssistenceButton.Location = new Point(133, 344);
            addAssistenceButton.Name = "addAssistenceButton";
            addAssistenceButton.Size = new Size(88, 31);
            addAssistenceButton.TabIndex = 4;
            addAssistenceButton.Text = "Agregar";
            addAssistenceButton.UseVisualStyleBackColor = true;
            // 
            // assistenceStateCheckedListBox
            // 
            assistenceStateCheckedListBox.FormattingEnabled = true;
            assistenceStateCheckedListBox.Items.AddRange(new object[] { "Asistiendo", "Ausente", "Reservado", "En lista de espera", "Cancelado", "No presentado" });
            assistenceStateCheckedListBox.Location = new Point(94, 185);
            assistenceStateCheckedListBox.Name = "assistenceStateCheckedListBox";
            assistenceStateCheckedListBox.Size = new Size(168, 130);
            assistenceStateCheckedListBox.TabIndex = 3;
            // 
            // assistenceDateTimePicker
            // 
            assistenceDateTimePicker.Location = new Point(59, 88);
            assistenceDateTimePicker.Name = "assistenceDateTimePicker";
            assistenceDateTimePicker.Size = new Size(239, 26);
            assistenceDateTimePicker.TabIndex = 2;
            // 
            // assistenceStateLabel
            // 
            assistenceStateLabel.AutoSize = true;
            assistenceStateLabel.Location = new Point(81, 142);
            assistenceStateLabel.Name = "assistenceStateLabel";
            assistenceStateLabel.Size = new Size(192, 18);
            assistenceStateLabel.TabIndex = 1;
            assistenceStateLabel.Text = "Estado de la asistencia";
            // 
            // assistenceDateLabel
            // 
            assistenceDateLabel.AutoSize = true;
            assistenceDateLabel.Location = new Point(94, 47);
            assistenceDateLabel.Name = "assistenceDateLabel";
            assistenceDateLabel.Size = new Size(168, 18);
            assistenceDateLabel.TabIndex = 0;
            assistenceDateLabel.Text = "Fecha de asistencia";
            // 
            // DiseñoGimnasio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 644);
            Controls.Add(gymAdminTab);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DiseñoGimnasio";
            Text = "DiseñoGimnasio";
            gymAdminTab.ResumeLayout(false);
            membersTab.ResumeLayout(false);
            membersBox.ResumeLayout(false);
            membersBox.PerformLayout();
            membershipTab.ResumeLayout(false);
            membershipManagerGroupBox.ResumeLayout(false);
            membershipManagerGroupBox.PerformLayout();
            registerMembershipGroupBox.ResumeLayout(false);
            registerMembershipGroupBox.PerformLayout();
            sesionTab.ResumeLayout(false);
            instructorGroupBox.ResumeLayout(false);
            instructorGroupBox.PerformLayout();
            classGroupBox.ResumeLayout(false);
            classGroupBox.PerformLayout();
            asistenceTab.ResumeLayout(false);
            assistenceGroupBox.ResumeLayout(false);
            assistenceGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl gymAdminTab;
        private TabPage membersTab;
        private TabPage membershipTab;
        private TabPage sesionTab;
        private TabPage asistenceTab;
        private GroupBox membersBox;
        private Button deleteButton;
        private Button editButton;
        private Button deleteButtom;
        private TextBox emailTextBox;
        private TextBox numberPhoneTextBox;
        private TextBox textBox3;
        private TextBox nameTextBox;
        private TextBox duiTextBox;
        private Label emailLabel;
        private Label numberPhoneLabel;
        private Label lastNameLabel;
        private Label nameLabel;
        private Label duiLabel;
        private GroupBox membershipManagerGroupBox;
        private GroupBox registerMembershipGroupBox;
        private ComboBox membershipStateComboBox;
        private TextBox duiMemberTextBox;
        private Label membershipStateLabel;
        private Label duiMemberLabel;
        private ComboBox priceMembershipComboBox;
        private ComboBox typeMembershipComboBox;
        private Label priceMembershipLabel;
        private Label typeMembershipLabel;
        private Button membershipStateButton;
        private Button addMemberButton;
        private GroupBox instructorGroupBox;
        private GroupBox classGroupBox;
        private Label excerciseTypeLabel;
        private TextBox instructorPaymentTextBox;
        private TextBox instructorEmailTextBox;
        private TextBox instructorPhoneNumberTextBox;
        private TextBox instructorLastNameTextBox;
        private TextBox instructorNameTextBox;
        private ComboBox instructorStateComboBox;
        private Label instructorStateLabel;
        private Label instructorPaymentLabel;
        private Label instructorEmailLabel;
        private Label instructorPhoneNumberLabel;
        private Label instructorLastNameLabel;
        private Label instructorNameLabel;
        private ComboBox roomComboBox;
        private ComboBox typeExcerciseComboBox;
        private Label roomLabel;
        private Button addInstructorButton;
        private Button addTypeExcerciseButton;
        private GroupBox assistenceGroupBox;
        private CheckedListBox assistenceStateCheckedListBox;
        private DateTimePicker assistenceDateTimePicker;
        private Label assistenceStateLabel;
        private Label assistenceDateLabel;
        private Button addAssistenceButton;
    }
}