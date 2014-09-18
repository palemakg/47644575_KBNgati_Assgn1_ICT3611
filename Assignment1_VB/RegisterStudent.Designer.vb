<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegisterStudent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegisterStudent))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtInitial = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.cboTitle = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RegisterStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRegisterStudent = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRegisterModule = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModuleActivation = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEnrollStudentInModule = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.dtPicker = New System.Windows.Forms.DateTimePicker()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(228, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Register Student"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(101, 294)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Title:"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(101, 354)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Initial:"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.Location = New System.Drawing.Point(101, 474)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Address:"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.Location = New System.Drawing.Point(101, 414)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Surname:"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.Location = New System.Drawing.Point(101, 537)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Date Of Birth:"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label7.Location = New System.Drawing.Point(101, 593)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Gender:"
        '
        'txtInitial
        '
        Me.txtInitial.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtInitial.Location = New System.Drawing.Point(281, 351)
        Me.txtInitial.Name = "txtInitial"
        Me.txtInitial.Size = New System.Drawing.Size(249, 23)
        Me.txtInitial.TabIndex = 8
        '
        'txtSurname
        '
        Me.txtSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtSurname.Location = New System.Drawing.Point(281, 411)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(249, 23)
        Me.txtSurname.TabIndex = 9
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtAddress.Location = New System.Drawing.Point(281, 471)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(249, 23)
        Me.txtAddress.TabIndex = 10
        '
        'cboTitle
        '
        Me.cboTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cboTitle.FormattingEnabled = true
        Me.cboTitle.Items.AddRange(New Object() {"Please Select", "Mr.", "Mrs.", "Miss", "Dr.", "Prof"})
        Me.cboTitle.Location = New System.Drawing.Point(281, 294)
        Me.cboTitle.Name = "cboTitle"
        Me.cboTitle.Size = New System.Drawing.Size(151, 24)
        Me.cboTitle.TabIndex = 12
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnSave.Location = New System.Drawing.Point(151, 692)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(106, 31)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = false
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnClear.Location = New System.Drawing.Point(292, 692)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(106, 31)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = false
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnExit.Location = New System.Drawing.Point(431, 692)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(106, 31)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = false
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = true
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.Red
        Me.lblMessage.Location = New System.Drawing.Point(325, 628)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(0, 15)
        Me.lblMessage.TabIndex = 17
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Brown
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegisterStudentToolStripMenuItem, Me.mnuExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(688, 24)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RegisterStudentToolStripMenuItem
        '
        Me.RegisterStudentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRegisterStudent, Me.mnuRegisterModule, Me.mnuModuleActivation, Me.mnuEnrollStudentInModule})
        Me.RegisterStudentToolStripMenuItem.Name = "RegisterStudentToolStripMenuItem"
        Me.RegisterStudentToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.RegisterStudentToolStripMenuItem.Text = "&File"
        '
        'mnuRegisterStudent
        '
        Me.mnuRegisterStudent.Name = "mnuRegisterStudent"
        Me.mnuRegisterStudent.Size = New System.Drawing.Size(205, 22)
        Me.mnuRegisterStudent.Text = "Register Student"
        '
        'mnuRegisterModule
        '
        Me.mnuRegisterModule.Name = "mnuRegisterModule"
        Me.mnuRegisterModule.Size = New System.Drawing.Size(205, 22)
        Me.mnuRegisterModule.Text = "Register Module"
        '
        'mnuModuleActivation
        '
        Me.mnuModuleActivation.Name = "mnuModuleActivation"
        Me.mnuModuleActivation.Size = New System.Drawing.Size(205, 22)
        Me.mnuModuleActivation.Text = "Module Activation"
        '
        'mnuEnrollStudentInModule
        '
        Me.mnuEnrollStudentInModule.Name = "mnuEnrollStudentInModule"
        Me.mnuEnrollStudentInModule.Size = New System.Drawing.Size(205, 22)
        Me.mnuEnrollStudentInModule.Text = "Enroll Student In Module"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(37, 20)
        Me.mnuExit.Text = "E&xit"
        '
        'dtPicker
        '
        Me.dtPicker.Location = New System.Drawing.Point(281, 533)
        Me.dtPicker.Name = "dtPicker"
        Me.dtPicker.Size = New System.Drawing.Size(249, 20)
        Me.dtPicker.TabIndex = 19
        '
        'cboGender
        '
        Me.cboGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cboGender.FormattingEnabled = true
        Me.cboGender.Items.AddRange(New Object() {"Please Select", "Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(281, 590)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(151, 24)
        Me.cboGender.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"),System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(101, 94)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(487, 140)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = false
        '
        'frmRegisterStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(688, 767)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dtPicker)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cboGender)
        Me.Controls.Add(Me.cboTitle)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtInitial)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmRegisterStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register Student"
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtInitial As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents cboTitle As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents RegisterStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRegisterStudent As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRegisterModule As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuModuleActivation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEnrollStudentInModule As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dtPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboGender As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
