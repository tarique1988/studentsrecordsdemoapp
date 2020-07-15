namespace StudentRecordCSV
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loadStudentsButton = new System.Windows.Forms.Button();
            this.saveStudentButton = new System.Windows.Forms.Button();
            this.studentsListBox = new System.Windows.Forms.ListBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.classText = new System.Windows.Forms.TextBox();
            this.sectionText = new System.Windows.Forms.TextBox();
            this.contactText = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.classLabel = new System.Windows.Forms.Label();
            this.sectionLabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.saveStudentLabel = new System.Windows.Forms.Label();
            this.disclaimerLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exportStudentsButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.editStudentButton = new System.Windows.Forms.Button();
            this.addressDisplayText = new System.Windows.Forms.TextBox();
            this.contactDisplayText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.updateStudentButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.idDisplayText = new System.Windows.Forms.TextBox();
            this.sectionDisplayText = new System.Windows.Forms.TextBox();
            this.deleteStudentButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.classDisplayText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nameDisplayText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.studentDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.studentDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadStudentsButton
            // 
            this.loadStudentsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadStudentsButton.Location = new System.Drawing.Point(13, 24);
            this.loadStudentsButton.Name = "loadStudentsButton";
            this.loadStudentsButton.Size = new System.Drawing.Size(90, 23);
            this.loadStudentsButton.TabIndex = 0;
            this.loadStudentsButton.TabStop = false;
            this.loadStudentsButton.Text = "Load Students";
            this.loadStudentsButton.UseVisualStyleBackColor = true;
            this.loadStudentsButton.Click += new System.EventHandler(this.loadStudentsButton_Click);
            // 
            // saveStudentButton
            // 
            this.saveStudentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveStudentButton.Location = new System.Drawing.Point(159, 398);
            this.saveStudentButton.Name = "saveStudentButton";
            this.saveStudentButton.Size = new System.Drawing.Size(90, 23);
            this.saveStudentButton.TabIndex = 6;
            this.saveStudentButton.Text = "Save Student";
            this.saveStudentButton.UseVisualStyleBackColor = true;
            this.saveStudentButton.Click += new System.EventHandler(this.saveStudentButton_Click);
            // 
            // studentsListBox
            // 
            this.studentsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentsListBox.FormattingEnabled = true;
            this.studentsListBox.ItemHeight = 15;
            this.studentsListBox.Location = new System.Drawing.Point(13, 12);
            this.studentsListBox.Name = "studentsListBox";
            this.studentsListBox.Size = new System.Drawing.Size(218, 409);
            this.studentsListBox.TabIndex = 0;
            this.studentsListBox.TabStop = false;
            this.studentsListBox.UseTabStops = false;
            this.studentsListBox.SelectedIndexChanged += new System.EventHandler(this.studentsListBox_SelectedIndexChanged);
            this.studentsListBox.DoubleClick += new System.EventHandler(this.studentsListBox_DoubleClick);
            // 
            // nameText
            // 
            this.nameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameText.Location = new System.Drawing.Point(13, 154);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(236, 23);
            this.nameText.TabIndex = 1;
            // 
            // classText
            // 
            this.classText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.classText.Location = new System.Drawing.Point(13, 198);
            this.classText.Name = "classText";
            this.classText.Size = new System.Drawing.Size(236, 23);
            this.classText.TabIndex = 2;
            // 
            // sectionText
            // 
            this.sectionText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sectionText.Location = new System.Drawing.Point(13, 259);
            this.sectionText.Name = "sectionText";
            this.sectionText.Size = new System.Drawing.Size(236, 23);
            this.sectionText.TabIndex = 3;
            // 
            // contactText
            // 
            this.contactText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contactText.Location = new System.Drawing.Point(13, 313);
            this.contactText.Name = "contactText";
            this.contactText.Size = new System.Drawing.Size(236, 23);
            this.contactText.TabIndex = 4;
            // 
            // addressText
            // 
            this.addressText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addressText.Location = new System.Drawing.Point(13, 357);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(236, 23);
            this.addressText.TabIndex = 5;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 136);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(42, 15);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name:";
            // 
            // classLabel
            // 
            this.classLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(13, 180);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(37, 15);
            this.classLabel.TabIndex = 3;
            this.classLabel.Text = "Class:";
            // 
            // sectionLabel
            // 
            this.sectionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sectionLabel.AutoSize = true;
            this.sectionLabel.Location = new System.Drawing.Point(13, 241);
            this.sectionLabel.Name = "sectionLabel";
            this.sectionLabel.Size = new System.Drawing.Size(49, 15);
            this.sectionLabel.TabIndex = 3;
            this.sectionLabel.Text = "Section:";
            // 
            // contactLabel
            // 
            this.contactLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contactLabel.AutoSize = true;
            this.contactLabel.Location = new System.Drawing.Point(13, 295);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(52, 15);
            this.contactLabel.TabIndex = 3;
            this.contactLabel.Text = "Contact:";
            // 
            // addressLabel
            // 
            this.addressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(13, 339);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(52, 15);
            this.addressLabel.TabIndex = 3;
            this.addressLabel.Text = "Address:";
            // 
            // saveStudentLabel
            // 
            this.saveStudentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveStudentLabel.AutoSize = true;
            this.saveStudentLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveStudentLabel.Location = new System.Drawing.Point(13, 65);
            this.saveStudentLabel.Name = "saveStudentLabel";
            this.saveStudentLabel.Size = new System.Drawing.Size(231, 21);
            this.saveStudentLabel.TabIndex = 4;
            this.saveStudentLabel.Text = "Enter Details to save a Student";
            // 
            // disclaimerLabel
            // 
            this.disclaimerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.disclaimerLabel.Location = new System.Drawing.Point(12, 426);
            this.disclaimerLabel.Name = "disclaimerLabel";
            this.disclaimerLabel.Size = new System.Drawing.Size(307, 15);
            this.disclaimerLabel.TabIndex = 5;
            this.disclaimerLabel.Text = "*Double click on a student to delete it from the database.";
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(13, 398);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(90, 23);
            this.clearButton.TabIndex = 0;
            this.clearButton.TabStop = false;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exportStudentsButton
            // 
            this.exportStudentsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exportStudentsButton.Location = new System.Drawing.Point(138, 24);
            this.exportStudentsButton.Name = "exportStudentsButton";
            this.exportStudentsButton.Size = new System.Drawing.Size(111, 23);
            this.exportStudentsButton.TabIndex = 0;
            this.exportStudentsButton.TabStop = false;
            this.exportStudentsButton.Text = "Export Students";
            this.exportStudentsButton.UseVisualStyleBackColor = true;
            this.exportStudentsButton.Click += new System.EventHandler(this.exportStudentsButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.idText);
            this.panel1.Controls.Add(this.loadStudentsButton);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.classLabel);
            this.panel1.Controls.Add(this.nameText);
            this.panel1.Controls.Add(this.sectionLabel);
            this.panel1.Controls.Add(this.contactLabel);
            this.panel1.Controls.Add(this.classText);
            this.panel1.Controls.Add(this.addressLabel);
            this.panel1.Controls.Add(this.exportStudentsButton);
            this.panel1.Controls.Add(this.sectionText);
            this.panel1.Controls.Add(this.saveStudentLabel);
            this.panel1.Controls.Add(this.saveStudentButton);
            this.panel1.Controls.Add(this.contactText);
            this.panel1.Controls.Add(this.addressText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(537, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 450);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Next Id:";
            // 
            // idText
            // 
            this.idText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.idText.Enabled = false;
            this.idText.Location = new System.Drawing.Point(192, 103);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(57, 23);
            this.idText.TabIndex = 0;
            this.idText.TabStop = false;
            this.idText.Text = "0";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.idDisplayText);
            this.panel2.Controls.Add(this.contactDisplayText);
            this.panel2.Controls.Add(this.sectionDisplayText);
            this.panel2.Controls.Add(this.classDisplayText);
            this.panel2.Controls.Add(this.nameDisplayText);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.editStudentButton);
            this.panel2.Controls.Add(this.updateStudentButton);
            this.panel2.Controls.Add(this.deleteStudentButton);
            this.panel2.Controls.Add(this.addressDisplayText);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.studentDetailsGroupBox);
            this.panel2.Controls.Add(this.disclaimerLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 8;
            // 
            // editStudentButton
            // 
            this.editStudentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editStudentButton.Enabled = false;
            this.editStudentButton.Location = new System.Drawing.Point(361, 391);
            this.editStudentButton.Name = "editStudentButton";
            this.editStudentButton.Size = new System.Drawing.Size(57, 23);
            this.editStudentButton.TabIndex = 6;
            this.editStudentButton.Text = "Edit";
            this.editStudentButton.UseVisualStyleBackColor = true;
            this.editStudentButton.Click += new System.EventHandler(this.editStudentButton_Click);
            // 
            // addressDisplayText
            // 
            this.addressDisplayText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addressDisplayText.Enabled = false;
            this.addressDisplayText.Location = new System.Drawing.Point(269, 350);
            this.addressDisplayText.Name = "addressDisplayText";
            this.addressDisplayText.Size = new System.Drawing.Size(236, 23);
            this.addressDisplayText.TabIndex = 5;
            // 
            // contactDisplayText
            // 
            this.contactDisplayText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contactDisplayText.Enabled = false;
            this.contactDisplayText.Location = new System.Drawing.Point(269, 306);
            this.contactDisplayText.Name = "contactDisplayText";
            this.contactDisplayText.Size = new System.Drawing.Size(236, 23);
            this.contactDisplayText.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(295, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 21);
            this.label9.TabIndex = 4;
            this.label9.Text = "Current Student Details";
            // 
            // updateStudentButton
            // 
            this.updateStudentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateStudentButton.Enabled = false;
            this.updateStudentButton.Location = new System.Drawing.Point(448, 391);
            this.updateStudentButton.Name = "updateStudentButton";
            this.updateStudentButton.Size = new System.Drawing.Size(57, 23);
            this.updateStudentButton.TabIndex = 6;
            this.updateStudentButton.Text = "Update";
            this.updateStudentButton.UseVisualStyleBackColor = true;
            this.updateStudentButton.Click += new System.EventHandler(this.updateStudentButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Student Id:";
            // 
            // idDisplayText
            // 
            this.idDisplayText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.idDisplayText.Enabled = false;
            this.idDisplayText.Location = new System.Drawing.Point(448, 96);
            this.idDisplayText.Name = "idDisplayText";
            this.idDisplayText.Size = new System.Drawing.Size(57, 23);
            this.idDisplayText.TabIndex = 0;
            this.idDisplayText.TabStop = false;
            this.idDisplayText.Text = "0";
            // 
            // sectionDisplayText
            // 
            this.sectionDisplayText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sectionDisplayText.Enabled = false;
            this.sectionDisplayText.Location = new System.Drawing.Point(269, 252);
            this.sectionDisplayText.Name = "sectionDisplayText";
            this.sectionDisplayText.Size = new System.Drawing.Size(236, 23);
            this.sectionDisplayText.TabIndex = 3;
            // 
            // deleteStudentButton
            // 
            this.deleteStudentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteStudentButton.Enabled = false;
            this.deleteStudentButton.Location = new System.Drawing.Point(269, 391);
            this.deleteStudentButton.Name = "deleteStudentButton";
            this.deleteStudentButton.Size = new System.Drawing.Size(61, 23);
            this.deleteStudentButton.TabIndex = 0;
            this.deleteStudentButton.TabStop = false;
            this.deleteStudentButton.Text = "Delete";
            this.deleteStudentButton.UseVisualStyleBackColor = true;
            this.deleteStudentButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Address:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name:";
            // 
            // classDisplayText
            // 
            this.classDisplayText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.classDisplayText.Enabled = false;
            this.classDisplayText.Location = new System.Drawing.Point(269, 191);
            this.classDisplayText.Name = "classDisplayText";
            this.classDisplayText.Size = new System.Drawing.Size(236, 23);
            this.classDisplayText.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Class:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Contact:";
            // 
            // nameDisplayText
            // 
            this.nameDisplayText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameDisplayText.Enabled = false;
            this.nameDisplayText.Location = new System.Drawing.Point(269, 147);
            this.nameDisplayText.Name = "nameDisplayText";
            this.nameDisplayText.Size = new System.Drawing.Size(236, 23);
            this.nameDisplayText.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Section:";
            // 
            // studentDetailsGroupBox
            // 
            this.studentDetailsGroupBox.Controls.Add(this.label3);
            this.studentDetailsGroupBox.Location = new System.Drawing.Point(242, 12);
            this.studentDetailsGroupBox.Name = "studentDetailsGroupBox";
            this.studentDetailsGroupBox.Size = new System.Drawing.Size(289, 411);
            this.studentDetailsGroupBox.TabIndex = 9;
            this.studentDetailsGroupBox.TabStop = false;
            this.studentDetailsGroupBox.Text = "Details";
            // 
            // MainWindow
            // 
            this.AcceptButton = this.saveStudentButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.studentsListBox);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Record CSV Demo";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.studentDetailsGroupBox.ResumeLayout(false);
            this.studentDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadStudentsButton;
        private System.Windows.Forms.Button saveStudentButton;
        private System.Windows.Forms.ListBox studentsListBox;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox classText;
        private System.Windows.Forms.TextBox sectionText;
        private System.Windows.Forms.TextBox contactText;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.Label sectionLabel;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label saveStudentLabel;
        private System.Windows.Forms.Label disclaimerLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exportStudentsButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.Button editStudentButton;
        private System.Windows.Forms.TextBox addressDisplayText;
        private System.Windows.Forms.TextBox contactDisplayText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button updateStudentButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idDisplayText;
        private System.Windows.Forms.TextBox sectionDisplayText;
        private System.Windows.Forms.Button deleteStudentButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox classDisplayText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nameDisplayText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox studentDetailsGroupBox;
    }
}

