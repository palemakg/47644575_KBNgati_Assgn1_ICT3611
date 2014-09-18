<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModuleActivation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModuleActivation))
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.RegisterStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRegisterStudent = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRegisterModule = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModuleActivation = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEnrollStudentInModule = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.txtModuleCode = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.cboSemester = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnSave.Location = New System.Drawing.Point(106, 575)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(106, 31)
        Me.btnSave.TabIndex = 44
        Me.btnSave.Text = "&Activate"
        Me.btnSave.UseVisualStyleBackColor = false
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = true
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.Red
        Me.lblMessage.Location = New System.Drawing.Point(303, 761)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(0, 15)
        Me.lblMessage.TabIndex = 47
        '
        'RegisterStudentToolStripMenuItem
        '
        Me.RegisterStudentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRegisterStudent, Me.mnuRegisterModule, Me.mnuModuleActivation, Me.mnuEnrollStudentInModule})
        Me.RegisterStudentToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold)
        Me.RegisterStudentToolStripMenuItem.Name = "RegisterStudentToolStripMenuItem"
        Me.RegisterStudentToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.RegisterStudentToolStripMenuItem.Text = "File"
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
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnExit.Location = New System.Drawing.Point(386, 575)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(106, 31)
        Me.btnExit.TabIndex = 46
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = false
        '
        'mnuExit
        '
        Me.mnuExit.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold)
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(40, 20)
        Me.mnuExit.Text = "Exit"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnClear.Location = New System.Drawing.Point(247, 575)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(106, 31)
        Me.btnClear.TabIndex = 45
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = false
        '
        'cboYear
        '
        Me.cboYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cboYear.FormattingEnabled = true
        Me.cboYear.Items.AddRange(New Object() {"Please Select", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cboYear.Location = New System.Drawing.Point(269, 482)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(198, 24)
        Me.cboYear.TabIndex = 43
        '
        'txtModuleCode
        '
        Me.txtModuleCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtModuleCode.Location = New System.Drawing.Point(269, 356)
        Me.txtModuleCode.Name = "txtModuleCode"
        Me.txtModuleCode.Size = New System.Drawing.Size(249, 23)
        Me.txtModuleCode.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label7.Location = New System.Drawing.Point(97, 485)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 17)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Year:"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.Location = New System.Drawing.Point(97, 419)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 17)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Semester:"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(97, 359)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 17)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Module Code:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Brown
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegisterStudentToolStripMenuItem, Me.mnuExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(622, 24)
        Me.MenuStrip1.TabIndex = 48
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'cboSemester
        '
        Me.cboSemester.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cboSemester.FormattingEnabled = true
        Me.cboSemester.Items.AddRange(New Object() {"Please Select", "First Semester", "Second Semester"})
        Me.cboSemester.Location = New System.Drawing.Point(269, 416)
        Me.cboSemester.Name = "cboSemester"
        Me.cboSemester.Size = New System.Drawing.Size(198, 24)
        Me.cboSemester.TabIndex = 49
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"),System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(68, 134)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(487, 140)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = false
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(189, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(245, 31)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Module Activation"
        '
        'frmModuleActivation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(622, 659)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboSemester)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.cboYear)
        Me.Controls.Add(Me.txtModuleCode)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmModuleActivation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Module Activation"
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents RegisterStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRegisterStudent As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRegisterModule As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuModuleActivation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEnrollStudentInModule As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents cboYear As System.Windows.Forms.ComboBox
    Friend WithEvents txtModuleCode As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents cboSemester As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
