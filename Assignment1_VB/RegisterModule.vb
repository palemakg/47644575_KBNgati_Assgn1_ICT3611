Imports System.IO

Public Class frmRegisterModule

    #Region "Global Variables"

        Private Const FileName As String = "C:\Modules.txt"
        Dim ReadOnly _clsValidation As New clsValidation

    #End Region

    #Region "Menu Buttons"

        Private Sub mnuRegisterStudent_Click( sender As Object,  e As EventArgs) Handles mnuRegisterStudent.Click
                Me.Hide()
                Me.Show()
        End Sub

        Private Sub mnuRegisterModule_Click( sender As Object,  e As EventArgs) Handles mnuRegisterModule.Click
                me.Hide()
                me.Show()
        End Sub

        Private Sub mnuModuleActivation_Click( sender As Object,  e As EventArgs) Handles mnuModuleActivation.Click
                me.Hide()
                frmModuleActivation.Show()
        End Sub

        Private Sub mnuEnrollStudentInModule_Click( sender As Object,  e As EventArgs) Handles mnuEnrollStudentInModule.Click
                me.Hide()
                frmEnrollStudentInModule.Show()
        End Sub

        Private Sub mnuExit_Click( sender As Object,  e As EventArgs) Handles mnuExit.Click
                Application.Exit()
        End Sub

    #End Region
   
    #Region "UI Buttons AND FormLoad"

        Private Sub frmRegisterModule_Load( sender As Object,  e As EventArgs) Handles MyBase.Load
            cboActivationSemester.Text = "Please Select"
        End Sub

        Private Sub btnSave_Click( sender As Object,  e As EventArgs) Handles btnSave.Click

                Try
                    'Validation
                    If String.IsNullOrEmpty(txtModuleCode.Text)
                        MessageBox.Show("Please enter the Module Code", "Module Code", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtModuleCode.Focus()

                    Else If String.IsNullOrEmpty(txtModuleTitle.Text)
                        MessageBox.Show("Please enter the Module Title", "Module Title", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtModuleTitle.Focus()

                    Else If String.IsNullOrEmpty(cboActivationSemester.Text) Or cboActivationSemester.Text = "Please Select"
                        MessageBox.Show("Please Select the Activation Semester", "Activation Semester", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        cboActivationSemester.Focus()

                    Else If _clsValidation.FieldExist(txtModuleCode.Text.Trim(), FileName)
                        MessageBox.Show("Module Code: " + txtModuleCode.Text + " Already Exist in the system", "Module Code", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    Else If Not _clsValidation.ValidModuleCode(txtModuleCode.Text)
                         MessageBox.Show("Please Enter a Valid Module Code e.g FAC1507 (XXX9999)", "Invalid Module Code", MessageBoxButtons.OK, MessageBoxIcon.Error)
                         txtModuleCode.Text = ""
                         txtModuleCode.Focus()

                    Else 
                        If System.IO.File.Exists(FileName) = True Then

                            Dim w As StreamWriter
                            w = File.AppendText(FileName)
                    
                            'Write into the Text Files
                            w.WriteLine()
                            w.Write(txtModuleCode.Text.Trim().ToString())
                            w.WriteLine()
                            w.Write(txtModuleTitle.Text.Trim())
                            w.WriteLine()
                            w.Write(cboActivationSemester.Text.Trim())
                    
                            w.Close()

                            'RESET ALL TEXT BOXES
                            txtModuleCode.Text = ""
                            txtModuleTitle.Text = ""
                            cboActivationSemester.Text = "Please Select"

                            'Show Success Message
                            MessageBox.Show("Module Registered Successfull", "Module Registration", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        End If

                    End If

                Catch ex As Exception
                    MessageBox.Show(CType("Error: {0}", IWin32Window), ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error )
                End Try

        End Sub
    
        Private Sub btnClear_Click( sender As Object,  e As EventArgs) Handles btnClear.Click

                txtModuleCode.Text = ""
                txtModuleTitle.Text = ""
                cboActivationSemester.Text = "Please Select"

        End Sub

        Private Sub btnExit_Click( sender As Object,  e As EventArgs) Handles btnExit.Click
                Application.Exit()
        End Sub

    #End Region


End Class