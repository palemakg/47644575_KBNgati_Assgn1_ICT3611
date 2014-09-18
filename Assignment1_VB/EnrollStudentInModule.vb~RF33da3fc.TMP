Imports System.IO

Public Class frmEnrollStudentInModule

    #Region "Variable Declaration"

        'Global Variable Declaration
        Dim ReadOnly _clsValidation As New clsValidation

        Private Const enrollStudentPath As String = "C:\StudentEnrollment.txt"
        Private Const studentFilePath As String = "C:\Student.txt"
        Private Const activeModulePath As String = "C:\ModulesActivated.txt"
    
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
                Me.Show()
        End Sub

Private Sub mnuExit_Click( sender As Object,  e As EventArgs) Handles mnuExit.Click
        Application.Exit()
End Sub

    #End Region

    #Region "Helper"

        Public Function EnrollStudent()

            Dim w As StreamWriter
            w = File.AppendText(enrollStudentPath)
                    
            'Write into the Text Files
            w.WriteLine()
            w.Write(cboModuleCode.Text.Trim().ToString())
            w.WriteLine()
            w.Write(txtStudentNumber.Text.Trim())
            
            w.Close()

            'RESET ALL TEXT BOXES
            cboModuleCode.Text = "Please Select"
            txtStudentNumber.Text = ""

            'Show Success Message
            MessageBox.Show("Module Activated Successfully", "Module Activation", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Function

        Public Function PopulateComboBox()
             Dim  objModuleReader As New System.IO.StreamReader(activeModulePath)
             cboModuleCode.Items.Add("Please Select")

             Do While objModuleReader.Peek() <> -1

                  Dim currentRecord = objModuleReader.ReadLine()
                    If currentRecord.Length = 7
                        If IsNumeric(currentRecord.Substring(3, 4))
                            cboModuleCode.Items.Add(currentRecord)
                        End If
                    End If

             Loop
             objModuleReader.Close()
        End Function

    #End Region
    
    #Region "UI Buttons AND FormLoad"

        Private Sub frmEnrollStudentInModule_Load( sender As Object,  e As EventArgs) Handles MyBase.Load

                Try
                   
                    If System.IO.File.Exists(activeModulePath) = True Then
                        PopulateComboBox()
                    Else 
                        Dim createFile = File.Create(activeModulePath)
                        createFile.Close()

                        PopulateComboBox()
            
                    End If

                cboModuleCode.Text = "Please Select"
            
                Catch ex As Exception
                    MessageBox.Show(String.Format("Error: {0}", ex.Message), "Exception Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End Sub
    
        Private Sub btnSave_Click( sender As Object,  e As EventArgs) Handles btnSave.Click

                Try
                    'Validation
                    If String.IsNullOrEmpty(txtStudentNumber.Text.Trim())
                        MessageBox.Show("Please enter the Student Number", "Student Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtStudentNumber.Focus()

                    Else If String.IsNullOrEmpty(cboModuleCode.Text) OR cboModuleCode.Text = "Please Select"
                        MessageBox.Show("Please Select the Module Code", "Module Code", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    Else If Not _clsValidation.ValidStudentNumber(txtStudentNumber.Text.Trim())
                        MessageBox.Show("The Student Number: " + txtStudentNumber.Text.Trim() + ", is not a Valid Student Number", "Invalid Student Number", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    Else If Not _clsValidation.FieldExist(txtStudentNumber.Text.Trim(), studentFilePath)
                        MessageBox.Show("The Student Number: " + txtStudentNumber.Text.Trim() + ", does not exist in the system", "Student Number", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    Else If Not _clsValidation.ValidModuleRegistrationTime(cboModuleCode.Text)
                        MessageBox.Show("Invalid Registration Period, A Module cannot be registered within its Activation Period", "Invalid Module Enrollment Period", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    Else If _clsValidation.StudentAlreadyEnrolled(cboModuleCode.Text.Trim(), txtStudentNumber.Text.Trim(), enrollStudentPath)
                        MessageBox.Show("Student Number " + txtStudentNumber.Text.Trim() + " has already been enrolled for Module " + cboModuleCode.Text.Trim(), _
                                        "Student Already Enrolled", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    Else 

                        'Check if File Exist and Enroll Student
                         If System.IO.File.Exists(enrollStudentPath) = True Then
                            EnrollStudent()

                        Else 
                            'Create File
                             Dim createFile = File.Create(enrollStudentPath)
                             createFile.Close()     
                        
                            'Enroll Student
                             EnrollStudent()

                        End If

                    End If

                Catch ex As Exception
                    MessageBox.Show(String.Format("Error: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

        End Sub

        Private Sub btnClear_Click( sender As Object,  e As EventArgs) Handles btnClear.Click
                cboModuleCode.Text = "Please Select"
                txtStudentNumber.Text = ""
        End Sub

        Private Sub btnExit_Click( sender As Object,  e As EventArgs) Handles btnExit.Click
                Application.Exit()
        End Sub

    #End Region

End Class