Imports System.IO

Public Class frmRegisterStudent
    
    #Region "Global Variables"

        ' Declare Global Variables
        Private Const FileName As String = "C:\Student.txt"
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

    #Region "Helper"

        Public Function SaveStudentRecord(ByVal studentNum As String)

                Dim w As StreamWriter
                w = File.AppendText(FileName)
                    
                'Write into the Text Files
                w.WriteLine()
                w.Write(studentNum.trim())
                w.WriteLine()
                w.Write(cboTitle.Text.Trim().ToString())
                w.WriteLine()
                w.Write(txtInitial.Text.Trim())
                w.WriteLine()
                w.Write(txtSurname.Text.Trim())
                w.WriteLine()
                w.Write(txtAddress.Text.Trim())
                w.WriteLine()
                w.Write(dtPicker.Text.Trim())
                w.WriteLine()
                w.Write(cboGender.Text.Trim())
                    
                w.Close()

                'Reset All Controlls
                txtInitial.Text = ""
                txtAddress.Text = ""
                txtSurname.Text = ""
                cboGender.Text = "Please Select"
                cboTitle.Text  = "Please Select"
                dtPicker.Text = Date.Now

                'Show Success Message
                MessageBox.Show("Student Record Saved Successfully", "Student Save", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Function

    #End Region

    #Region "UI Buttons"

        Private Sub frmRegisterStudent_Load( sender As Object,  e As EventArgs) Handles MyBase.Load

                cboGender.Text = "Please Select"
                cboTitle.Text = "Please Select"
                dtPicker.Text = Date.Now

        End Sub

        Private Sub btnSave_Click( sender As Object,  e As EventArgs) Handles btnSave.Click
        
               Try

                'Validations
                if cboGender.Text = "Please Select"
                    MessageBox.Show("Please enter the Gender", "Gender", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    cboGender.Focus()

                Else if cboTitle.Text = "Please Select"
                    MessageBox.Show("Please Select the Title", "Title", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    cboTitle.Focus()

                Else if String.IsNullOrEmpty(txtInitial.Text)
                    MessageBox.Show("Please enter the Initial", "Initial", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtInitial.Focus()

                Else if String.IsNullOrEmpty(txtSurname.Text)
                    MessageBox.Show("Please enter the surname", "Surname", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtSurname.Focus()

                Else  if String.IsNullOrEmpty(txtAddress.Text)
                    MessageBox.Show("Please enter the Address", "Address", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtAddress.Focus()

                Else If String.IsNullOrEmpty(dtPicker.Text)
                    MessageBox.Show("Please enter the Date Of Birth", "Date Of Birth", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    dtPicker.Focus()

                Else 
                    'Save Records into the Student File
                        If System.IO.File.Exists(FileName) = True Then
                            Dim studentNumber As String = _clsValidation.GenerateStudentNumber()
                            SaveStudentRecord(studentNumber)

                        Else 
                            'MessageBox.Show("Student.txt File does not Exit", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Dim createdFile = File.Create(FileName)
                            createdFile.Close()

                            SaveStudentRecord("1400011")

                        End If

                End If

               Catch ex As Exception
                    MessageBox.Show(String.Format("Error: {0}", ex.Message.ToString()), "An exception has occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error)
               End Try

        End Sub

    #End Region

End Class