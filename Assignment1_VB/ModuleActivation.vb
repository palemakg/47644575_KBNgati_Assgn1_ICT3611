Imports System.IO

Public Class frmModuleActivation


    #Region "Global Variables"

        Private Const ModuleActivationFilePath As String = "C:\ModulesActivated.txt"
        Private Const ModuleFilePath As String = "C:\Modules.txt"
        Dim ReadOnly _clsValidation As New clsValidation

    #End Region

    #Region "Menu Buttons"

        Private Sub mnuRegisterStudent_Click( sender As Object,  e As EventArgs) Handles mnuRegisterStudent.Click
                Me.Hide()
                Me.Show()
        End Sub

        Private Sub mnuRegisterModule_Click( sender As Object,  e As EventArgs) Handles mnuRegisterModule.Click
                me.Hide()
                frmRegisterModule.Show()
        End Sub

        Private Sub mnuModuleActivation_Click( sender As Object,  e As EventArgs) Handles mnuModuleActivation.Click
                me.Hide()
                me.Show()
        End Sub

        Private Sub mnuEnrollStudentInModule_Click( sender As Object,  e As EventArgs) Handles mnuEnrollStudentInModule.Click
                me.Hide()
                frmEnrollStudentInModule.Show()
        End Sub

Private Sub mnuExit_Click( sender As Object,  e As EventArgs) Handles mnuExit.Click
        Application.Exit()
End Sub

    #End Region

    #Region "Helper"

        Public Function ActivateModule()

            Dim w As StreamWriter
            w = File.AppendText(ModuleActivationFilePath)
                    
            'Write into the Text Files
            w.WriteLine()
            w.Write(txtModuleCode.Text.Trim().ToString())
            w.WriteLine()
            w.Write(cboSemester.Text.Trim())
            w.WriteLine()
            w.Write(cboYear.Text.Trim())
                    
            w.Close()

            'RESET ALL TEXT BOXES
            txtModuleCode.Text = ""
            cboSemester.Text = "Please Select"
            cboYear.Text = "Please Select"

            'Show Success Message
            MessageBox.Show("Module Activated Successfully", "Module Activation", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Function

    #End Region

    #Region "UI Buttons AND FormLoad"
        Private Sub frmModuleActivation_Load( sender As Object,  e As EventArgs) Handles MyBase.Load
            cboSemester.Text = "Please Select"
            cboYear.Text = "Please Select"
        End Sub

        Private Sub btnSave_Click( sender As Object,  e As EventArgs) Handles btnSave.Click

            Try
                'Validations
                 If String.IsNullOrEmpty(txtModuleCode.Text)
                    MessageBox.Show("Please enter the Module Code", "Module Code", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtModuleCode.Focus()

                 Else If String.IsNullOrEmpty(cboSemester.Text) Or cboSemester.Text = "Please Select"
                    MessageBox.Show("Please Select the Semester", "Semester", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    cboSemester.Focus()

                Else If String.IsNullOrEmpty(cboYear.Text) Or cboYear.Text = "Please Select"
                    MessageBox.Show("Please Select the Year", "Year", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    cboYear.Focus()

                Else If Not _clsValidation.FieldExist(txtModuleCode.Text.Trim(), ModuleFilePath)
                    MessageBox.Show("Module Code does not Exist", "Module Code", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    cboYear.Focus()

                Else 
                    'Check if file Exist and Save in Modules Activation Text File
                     If System.IO.File.Exists(ModuleActivationFilePath) = True Then
                        ActivateModule()
                     Else

                    'Create Modules Activations File if does not exist
                        Dim createFile = File.Create(ModuleActivationFilePath)
                        createFile.Close()

                        ActivateModule()
                     End If

                 End If

            Catch ex As Exception
                 MessageBox.Show(CType(String.Format("Error: {0}", ex.Message), String), "Module Activation", MessageBoxButtons.OK)
            End Try

    End Sub

        Private Sub btnClear_Click( sender As Object,  e As EventArgs) Handles btnClear.Click

        txtModuleCode.Text = ""
        cboSemester.Text = "Please Select"
        cboYear.Text = "Please Select"

End Sub

        Private Sub btnExit_Click( sender As Object,  e As EventArgs) Handles btnExit.Click
                Application.Exit()
        End Sub

    #End Region

End Class