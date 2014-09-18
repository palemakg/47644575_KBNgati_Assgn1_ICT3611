Imports System.IO

Public Class clsValidation

    #Region "Global Variables"

        Private Const StudFilePath As String = "C:\Student.txt"
        Private Const ActiveModules As String = "C:\ModulesActivated.txt"
        

    #End Region

    #Region "Functions"

        public Function GenerateStudentNumber() As String 

            Try
                Dim  objStudentReader As New System.IO.StreamReader(StudFilePath)
                
                Dim year As String = Date.Now.Year
                Const appendValue As String = "00"
                Dim numberOfStudents As String = String.Empty
                Dim checkDigital As String = String.Empty

                Dim lastStudentNumber As String = String.Empty
                Dim readLine As String = String.Empty
            
                'Check if file Exist and Generate Student Number
                If System.IO.File.Exists( StudFilePath ) = True Then

                Do While objStudentReader.Peek() <> -1
                    
                    readLine = objStudentReader.ReadLine().ToString()

                    If  IsNumeric(readLine)
                        lastStudentNumber = readLine
                    End If
                Loop

               objStudentReader.Close()

                numberOfStudents = lastStudentNumber.Substring(4, 2)
                checkDigital = GetCheckValue(numberOfStudents).ToString()

                Else
                'Create File and Generate Student Number
                    Dim createFile = File.Create(StudFilePath)
                    createFile.Close()

                    Do While objStudentReader.Peek() <> -1
                    
                    readLine = objStudentReader.ReadLine().ToString()

                    If  IsNumeric(readLine)
                        lastStudentNumber = readLine
                    End If
                Loop

               objStudentReader.Close()

                numberOfStudents = lastStudentNumber.Substring(4, 2)
                checkDigital = GetCheckValue(numberOfStudents).ToString()


                End If

                If CInt(numberOfStudents) < 9
                    numberOfStudents = "0" + (numberOfStudents + 1).ToString()
                End If

                return year.Substring(2, 2) + appendValue + numberOfStudents + checkDigital

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Save Student")
            End Try


        End Function
    
        public Function GetCheckValue(ByVal studentNumber As String) As String

            Dim calcStudNum As Integer = 0
            Dim studentTotalValue As Integer = 0

            For Each value As String In studentNumber
                calcStudNum +=  CInt(value)
            Next

            studentTotalValue  = calcStudNum / 10 * 10

            If studentTotalValue = 0
                Return studentTotalValue.ToString()
            Else 
                Return 10 - studentTotalValue
            End If

        End Function
    
        public Function SumStudentNumber(ByVal studNumber As String) As Integer

            Dim studentTotalValue As Integer = 0

            For Each value As String In studNumber
                studentTotalValue +=  CInt(value)
            Next

            Return studentTotalValue

          End Function

        public Function ReadThroughFile(ByVal fieldname As String, ByVal path As String)

                    Dim oReader As New System.IO.StreamReader(path)
                
                    Do While oReader.Peek() <> -1
                    
                    Dim currentValue = oReader.ReadLine()

                    If fieldname = currentValue
                        oReader.Close()
                        Return True
                    End If
                    
                    Loop

                   oReader.Close()
                    Return  False    

        End Function

        public Function DoesModuleAndStudNumMatch(ByVal ModuleCode As String, ByVal studentNumber As String, ByVal path As String)

            Dim oReader As New System.IO.StreamReader(path)
                
            Do While oReader.Peek() <> -1
                    
            Dim currentValue = oReader.ReadLine()

            If ModuleCode = currentValue
                If studentNumber = oReader.ReadLine()
                    oReader.Close()
                    Return True
                End If
            End If
                    
            Loop

            oReader.Close()
            Return  False    

        End Function
    
        public Function FieldExist(ByVal moduleCode As String, ByVal filePath As String) As Boolean
        
            Try
                'Check If Record Exist
                If System.IO.File.Exists( filePath ) = True Then
                    
                    'Read through File and Check if FieldValue Already Exist
                    Return ReadThroughFile(moduleCode, filePath)

                Else
                'If file does not exist, Create File and Read through File, Check if FieldValue Already Exist
                    Dim createFile = File.Create(filePath)
                    createFile.Close()

                    Return ReadThroughFile(moduleCode, filePath)

                End If

            Catch ex As Exception
                MessageBox.Show(String.Format("Error: {0}", ex.Message), "Execption", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Function
    
        Public Function StudentAlreadyEnrolled(ByVal moduleCode As String, ByVal studentNumber As String, ByVal filePath As String) As Boolean
            
             Try
                'Check If Record Exist
                If System.IO.File.Exists( filePath ) = True Then
                    
                    'Read through File and Check if FieldValue Already Exist
                    Return DoesModuleAndStudNumMatch(moduleCode, studentNumber, filePath)

                Else
                'If file does not exist, Create File and Read through File, Check if FieldValue Already Exist
                    Dim createFile = File.Create(filePath)
                    createFile.Close()

                    Return DoesModuleAndStudNumMatch(moduleCode, studentNumber, filePath)

                End If

            Catch ex As Exception
                MessageBox.Show(String.Format("Error: {0}", ex.Message), "Execption", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


        End Function

        public Function ValidStudentNumber(ByVal studentNum As String) As Boolean

            If SumStudentNumber(studentNum) Mod 10 > 0
                Return True
            Else 
                Return False
            End If

        End Function

        Public Function ValidModuleRegistrationTime(ByVal moduleCode as String) As Boolean

        Try
            If System.IO.File.Exists(ActiveModules) = True Then

                Dim objActiveModuleReader As New System.IO.StreamReader(activeModules)
                
                Do While objActiveModuleReader.Peek() <> -1
                    
                Dim currentRecord = objActiveModuleReader.ReadLine()
                
                If currentRecord.Length = 7 AND currentRecord.Trim() = moduleCode.trim() 
                    If IsNumeric(currentRecord.Substring(3, 4))
                        
                        Dim semester as String = objActiveModuleReader.ReadLine()

                        Dim currentDate As Date = Date.Now

                        Dim year as String = objActiveModuleReader.ReadLine()
                        Dim fisrtSemesterStart as Date = DateTime.ParseExact("01/01/" + year, "dd/MM/yyyy", Globalization.CultureInfo.InvariantCulture)
                        Dim secondSemesterStart as Date = DateTime.ParseExact("01/07/" + year, "dd/MM/yyyy", Globalization.CultureInfo.InvariantCulture)
                        
                        If semester = "First Semester" AND currentDate < fisrtSemesterStart
                                Return true
                        Else If semester = "Second Semester" AND currentDate < secondSemesterStart 
                                Return true
                        Else 
                                Return false
                        End If

                    End If
                End If
                    
                Loop

               objActiveModuleReader.Close()
                Return  False

            Else
                MessageBox.Show(String.Format("File does not exist"), "Execption", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message), "Execption", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function

        Public Function ValidModuleCode(ByVal moduleCode As String) As Boolean

            If moduleCode.Length = 7 AND moduleCode.Trim() = moduleCode.trim() 
                If IsNumeric(moduleCode.Substring(3, 4))
                    Return True 
                End If
            End If

            Return False

            End Function


    #End Region

End Class
