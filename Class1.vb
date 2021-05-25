Imports Microsoft.VisualBasic
Imports System.Math
Imports System

Friend Module Class1
    Public Class Class1
        Public Shared Sub Main()

            'Declaring variables
            Dim X, Y, Z, N, result As Double
            Dim operation() As Char
            Dim P As Integer
            Dim M As String

            'Color coding
            Console.ForegroundColor = ConsoleColor.White 'character color
            Console.BackgroundColor = ConsoleColor.DarkBlue 'background color
            Console.Clear()

            'Conclusion in the main loop
            While P <> 5
                Try

                    'Instructions for the calculator menu
                    Console.WriteLine("")
                    Console.WriteLine(" ------------------------ MENU ------------------------")
                    Console.WriteLine("")
                    Console.WriteLine("")
                    Console.WriteLine(" 1 - Calculating the square root of a number:       [√]")
                    Console.WriteLine(" 2 - Calculating the cube root of a number:        [3√]")
                    Console.WriteLine(" 3 - Operations for calculation:     [+, -, *, ^, /, %]")
                    Console.WriteLine(" 4 - Instructions for the user what not to do:      [?]")
                    Console.WriteLine(" 5 - Exit")
                    Console.WriteLine(" ======================================================")
                    Console.ForegroundColor = ConsoleColor.Magenta
                    Console.WriteLine(" Entered another number, you will return to the menu")
                    Console.WriteLine(" Ignore <CLS> on screen cleaning, return to the menu")
                    Console.ForegroundColor = ConsoleColor.White
                    Console.WriteLine(" ======================================================")
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine(" NaN - it means Not-a-Number under math. exceptions")
                    Console.WriteLine(" Calculation of the result is more 1E+308 - ∞[Infinity]")
                    Console.ForegroundColor = ConsoleColor.White
                    Console.WriteLine(" ------------------------------------------------------")

                    'Get the variable «P», needed to control the calculator menu
                    Do
                        Try
                            Console.WriteLine("")
                            Console.Write(" Enter the number of your choice: ")
                            P = Console.ReadLine()
                            If P <> 0 Then
                                Exit Do
                            ElseIf P = 0 Then
                                Console.WriteLine("")
                                Console.ForegroundColor = ConsoleColor.Yellow
                                Console.WriteLine(" Incorrect entry, try entering the number of your choice again.")
                                Console.ForegroundColor = ConsoleColor.White
                                Continue Do
                            End If
                        Catch ex As Exception
                            Console.WriteLine("")
                            Console.ForegroundColor = ConsoleColor.Yellow
                            Console.WriteLine(" Incorrect entry, try entering the number of your choice again.")
                            Console.ForegroundColor = ConsoleColor.White
                            Continue Do
                        End Try
                    Loop While True

                    'Instructions for the user what not to do
                    If P = 4 Then
                        Console.WriteLine("")
                        Console.WriteLine(" ============================================================================")
                        Console.ForegroundColor = ConsoleColor.Cyan
                        Console.WriteLine(" Instructions for the user what not to do:")
                        Console.WriteLine("")
                        Console.WriteLine(" In the «3 - Operations for calculation» mode, it is prohibited to enter a ->")
                        Console.WriteLine(" -> zero before and after the operation sign. Accordingly,all calculations ->")
                        Console.WriteLine(" -> with zero will be invalid. The prohibition is due to the ability to    ->")
                        Console.WriteLine(" -> change the keyboard layout to Cyrillic,and in Visual Basic this layout ->")
                        Console.WriteLine(" -> is zero, which makes it possible to enter incorrect data. We bring our ->")
                        Console.WriteLine(" -> regrets. In modes with square and cube root calculations,entering zero ->")
                        Console.WriteLine(" -> is also prohibited for the same reasons. That's all, end of instructions.")
                        Console.ForegroundColor = ConsoleColor.White
                        Console.WriteLine(" ============================================================================")
                        Console.Write(" Press <CLS> to clear the screen - ")
                        M = Console.ReadLine()
                        If M = "CLS" Then
                            Console.Clear()
                        ElseIf M <> "CLS" Then
                            Console.Clear()
                        End If
                    End If

                    'Last instruction before exiting the program
                    If P = 5 Then
                        Console.WriteLine("")
                        Console.ForegroundColor = ConsoleColor.Cyan
                        Console.WriteLine(" Program ended. Exit.")
                        Console.ForegroundColor = ConsoleColor.White
                        Console.WriteLine(" ------------------------------------------------------")
                    End If

                    'Instructions in case if wrong number of your choice
                    If P > 5 Then
                        Console.WriteLine("")
                        Console.ForegroundColor = ConsoleColor.Yellow
                        Console.WriteLine(" Wrong way, try entering the number again after looking at the instructions.")
                        Console.WriteLine(" Look in the menu above this message which of the numbers you need to enter.")
                        Console.ForegroundColor = ConsoleColor.White
                        Console.WriteLine(" ---------------------------------------------------------------------------")
                        Console.Write(" Press <CLS> to clear the screen - ")
                        M = Console.ReadLine()
                        If M = "CLS" Then
                            Console.Clear()
                        ElseIf M <> "CLS" Then
                            Console.Clear()
                        End If
                    ElseIf P < 0 Then
                        Console.WriteLine("")
                        Console.ForegroundColor = ConsoleColor.Yellow
                        Console.WriteLine(" Wrong way, try entering the number again after looking at the instructions.")
                        Console.WriteLine(" Look in the menu above this message which of the numbers you need to enter.")
                        Console.ForegroundColor = ConsoleColor.White
                        Console.WriteLine(" ---------------------------------------------------------------------------")
                        Console.Write(" Press <CLS> to clear the screen - ")
                        M = Console.ReadLine()
                        If M = "CLS" Then
                            Console.Clear()
                        ElseIf M <> "CLS" Then
                            Console.Clear()
                        End If
                    End If

                    'Entering data and then calculating the square root of a number
                    If P = 1 Then
                        Do
                            Try
                                Console.WriteLine("")
                                Console.Write(" Enter a number to calculate its square root: ")
                                Z = Console.ReadLine()
                                If Z <> 0 Then
                                    N = Math.Sqrt(Z)
                                    If N <> N Then
                                        Console.WriteLine("")
                                        Console.ForegroundColor = ConsoleColor.Red
                                        Console.WriteLine(" The square root of " & Z & " is " & N & " ->")
                                        Console.WriteLine(" Square root of a negative number converts your result to ->")
                                        Console.WriteLine(" -> NaN - it means Not-a-Number under mathematical exception")
                                        Console.WriteLine(" Calculating square root of a negative number is not allowed")
                                        Console.ForegroundColor = ConsoleColor.White
                                        Console.WriteLine(" -----------------------------------------------------------")
                                        Console.Write(" Press <CLS> to clear the screen - ")
                                        M = Console.ReadLine()
                                        If M = "CLS" Then
                                            Console.Clear()
                                        ElseIf M <> "CLS" Then
                                            Console.Clear()
                                        End If
                                    ElseIf N = N Then
                                        Console.WriteLine("")
                                        Console.WriteLine(" The square root of " & Z & " is " & N)
                                        Console.WriteLine(" ------------------------------------------------------")
                                        Console.Write(" Press <CLS> to clear the screen - ")
                                        M = Console.ReadLine()
                                        If M = "CLS" Then
                                            Console.Clear()
                                        ElseIf M <> "CLS" Then
                                            Console.Clear()
                                        End If
                                    End If
                                    Exit Do
                                    ElseIf Z = 0 Then
                                    Console.WriteLine("")
                                    Console.ForegroundColor = ConsoleColor.Yellow
                                    Console.WriteLine(" Wrong entry, try entering the number for square root again.")
                                    Console.ForegroundColor = ConsoleColor.White
                                    Continue Do
                                End If
                            Catch ex As Exception
                                Console.WriteLine("")
                                Console.ForegroundColor = ConsoleColor.Yellow
                                Console.WriteLine(" Wrong entry, try entering the number for square root again.")
                                Console.ForegroundColor = ConsoleColor.White
                                Continue Do
                            End Try
                        Loop While True
                    End If

                    'Entering data and then calculating the cube root of a number
                    If P = 2 Then
                        Do
                            Try
                                Console.WriteLine("")
                                Console.Write(" Enter a number to calculate its cube root: ")
                                Z = Console.ReadLine()
                                If Z <> 0 Then
                                    N = Math.Cbrt(Z)
                                    Console.WriteLine("")
                                    Console.WriteLine(" The cube root of " & Z & " is " & N)
                                    Console.WriteLine(" ------------------------------------------------------")
                                    Console.Write(" Press <CLS> to clear the screen - ")
                                    M = Console.ReadLine()
                                    If M = "CLS" Then
                                        Console.Clear()
                                    ElseIf M <> "CLS" Then
                                        Console.Clear()
                                    End If
                                    Exit Do
                                ElseIf Z = 0 Then
                                    Console.WriteLine("")
                                    Console.ForegroundColor = ConsoleColor.Yellow
                                    Console.WriteLine(" Wrong entry, try entering the number for cube root again.")
                                    Console.ForegroundColor = ConsoleColor.White
                                    Continue Do
                                End If
                            Catch ex As Exception
                                Console.WriteLine("")
                                Console.ForegroundColor = ConsoleColor.Yellow
                                Console.WriteLine(" Wrong entry, try entering the number for cube root again.")
                                Console.ForegroundColor = ConsoleColor.White
                                Continue Do
                            End Try
                        Loop While True
                    End If

                    'Getting values ​​for variables and then arithmetic calculations
                    If P = 3 Then
                        Do
                            Try
                                Console.WriteLine("")
                                Console.Write(" Enter first number: ")
                                X = Console.ReadLine()
                                If X <> 0 Then
                                    Exit Do
                                ElseIf X = 0 Then
                                    Console.WriteLine("")
                                    Console.ForegroundColor = ConsoleColor.Yellow
                                    Console.WriteLine(" Incorrect entry, please try entering your first number again.")
                                    Console.ForegroundColor = ConsoleColor.White
                                    Continue Do
                                End If
                            Catch ex As Exception
                                Console.WriteLine("")
                                Console.ForegroundColor = ConsoleColor.Yellow
                                Console.WriteLine(" Incorrect entry, please try entering your first number again.")
                                Console.ForegroundColor = ConsoleColor.White
                                Continue Do
                            End Try
                        Loop While True

                        Do
                            Console.WriteLine("")
                            Console.Write(" Enter operation: ")
                            operation = Console.ReadLine()
                            If operation = ("+") And operation = ("*") And operation = ("-") And operation = ("/") And operation = ("^") And operation = ("%") Then
                                Exit Do
                            ElseIf operation <> ("+") And operation <> ("*") And operation <> ("-") And operation <> ("/") And operation <> ("^") And operation <> ("%") Then
                                Console.WriteLine("")
                                Console.ForegroundColor = ConsoleColor.Yellow
                                Console.WriteLine(" Operation not recognized, enter operation again.") 'Instructions for the situation when the operation is not recognized
                                Console.ForegroundColor = ConsoleColor.White
                                Continue Do
                            End If
                        Loop While operation <> ("+") And operation <> ("*") And operation <> ("-") And operation <> ("/") And operation <> ("^") And operation <> ("%")

                        Do
                            Try
                                Console.WriteLine("")
                                Console.Write(" Enter second number: ")
                                Y = Console.ReadLine()
                                If Y <> 0 Then
                                    Exit Do
                                ElseIf Y = 0 Then
                                    Console.WriteLine("")
                                    Console.ForegroundColor = ConsoleColor.Yellow
                                    Console.WriteLine(" Incorrect entry, please try entering your second number again.")
                                    Console.ForegroundColor = ConsoleColor.White
                                    Continue Do
                                End If
                            Catch ex As Exception
                                Console.WriteLine("")
                                Console.ForegroundColor = ConsoleColor.Yellow
                                Console.WriteLine(" Incorrect entry, please try entering your second number again.")
                                Console.ForegroundColor = ConsoleColor.White
                                Continue Do
                            End Try
                        Loop While True

                        If operation = ("+") Then
                            result = X + Y
                            Console.WriteLine("")
                            Console.Write(" Your calculated result = ")
                            Console.WriteLine(result)
                            Console.WriteLine(" ------------------------------------------------------")
                            Console.Write(" Press <CLS> to clear the screen - ")
                            M = Console.ReadLine()
                            If M = "CLS" Then
                                Console.Clear()
                            ElseIf M <> "CLS" Then
                                Console.Clear()
                            End If
                        ElseIf operation = ("-") Then
                            result = X - Y
                            Console.WriteLine("")
                            Console.Write(" Your calculated result = ")
                            Console.WriteLine(result)
                            Console.WriteLine(" ------------------------------------------------------")
                            Console.Write(" Press <CLS> to clear the screen - ")
                            M = Console.ReadLine()
                            If M = "CLS" Then
                                Console.Clear()
                            ElseIf M <> "CLS" Then
                                Console.Clear()
                            End If
                        ElseIf operation = ("*") Then
                            result = X * Y
                            If result <= 1.7976931348623157E+308 Then
                                Console.WriteLine("")
                                Console.Write(" Your calculated result = ")
                                Console.WriteLine(result)
                                Console.WriteLine(" ------------------------------------------------------")
                                Console.Write(" Press <CLS> to clear the screen - ")
                                M = Console.ReadLine()
                                If M = "CLS" Then
                                    Console.Clear()
                                ElseIf M <> "CLS" Then
                                    Console.Clear()
                                End If
                            ElseIf result > 1.7976931348623157E+308 Then
                                Console.WriteLine("")
                                Console.ForegroundColor = ConsoleColor.Red
                                Console.Write(" Your calculated result = ")
                                Console.WriteLine(result & "(Infinity),Inf. symbol(∞) ->")
                                Console.WriteLine(" when the result of your calculations is too LARGE!! ->")
                                Console.WriteLine(" Your result is too HUGE, this number is much higher ->")
                                Console.WriteLine(" -> than the last number known to science, which in  ->")
                                Console.WriteLine(" -> science is called novemquadragintillion (1E+150)!!!")
                                Console.ForegroundColor = ConsoleColor.White
                                Console.WriteLine("")
                                Console.ForegroundColor = ConsoleColor.Cyan
                                Console.WriteLine(" Sorry,Visual Basic calculator is not ready for this!!!")
                                Console.ForegroundColor = ConsoleColor.White
                                Console.WriteLine(" ------------------------------------------------------")
                                Console.Write(" Press <CLS> to clear the screen - ")
                                M = Console.ReadLine()
                                If M = "CLS" Then
                                    Console.Clear()
                                ElseIf M <> "CLS" Then
                                    Console.Clear()
                                End If
                            End If
                        ElseIf operation = ("/") Then
                            If Y <> 0 Then
                                result = X / Y
                                Console.WriteLine("")
                                Console.Write(" Your calculated result = ")
                                Console.WriteLine(result)
                                Console.WriteLine(" ------------------------------------------------------")
                                Console.Write(" Press <CLS> to clear the screen - ")
                                M = Console.ReadLine()
                                If M = "CLS" Then
                                    Console.Clear()
                                ElseIf M <> "CLS" Then
                                    Console.Clear()
                                End If
                            Else
                                Console.WriteLine("")
                                Console.ForegroundColor = ConsoleColor.Red
                                Console.WriteLine(" Division by zero is impossible! Please don't try to divide by zero.")
                                Console.ForegroundColor = ConsoleColor.White
                                Console.WriteLine(" -------------------------------------------------------------------")
                                Console.Write(" Press <CLS> to clear the screen - ")
                                M = Console.ReadLine()
                                If M = "CLS" Then
                                    Console.Clear()
                                ElseIf M <> "CLS" Then
                                    Console.Clear()
                                End If
                            End If
                        ElseIf operation = ("^") Then
                            result = X ^ Y
                            If (result = result) And (result <= 1.7976931348623157E+308) Then
                                Console.WriteLine("")
                                Console.Write(" Your calculated result = ")
                                Console.WriteLine(result)
                                Console.WriteLine(" ------------------------------------------------------")
                                Console.Write(" Press <CLS> to clear the screen - ")
                                M = Console.ReadLine()
                                If M = "CLS" Then
                                    Console.Clear()
                                ElseIf M <> "CLS" Then
                                    Console.Clear()
                                End If
                            ElseIf result <> result Then
                                Console.WriteLine("")
                                Console.ForegroundColor = ConsoleColor.Red
                                Console.Write(" Your calculated result is ")
                                Console.WriteLine(result & ",it means Not-a-Number ->")
                                Console.WriteLine(" The operation (example: -X^(Y = 0,5)) of extracting ->")
                                Console.WriteLine(" -> a square root from a negative number is FORBIDDEN!!")
                                Console.ForegroundColor = ConsoleColor.White
                                Console.WriteLine(" ------------------------------------------------------")
                                Console.Write(" Press <CLS> to clear the screen - ")
                                M = Console.ReadLine()
                                If M = "CLS" Then
                                    Console.Clear()
                                ElseIf M <> "CLS" Then
                                    Console.Clear()
                                End If
                            ElseIf result > 1.7976931348623157E+308 Then
                                Console.WriteLine("")
                                Console.ForegroundColor = ConsoleColor.Red
                                Console.Write(" Your calculated result = ")
                                Console.WriteLine(result & "(Infinity),Inf. symbol(∞) ->")
                                Console.WriteLine(" when the result of your calculations is too LARGE!! ->")
                                Console.WriteLine(" Your result is too HUGE, this number is much higher ->")
                                Console.WriteLine(" -> than the last number known to science, which in  ->")
                                Console.WriteLine(" -> science is called novemquadragintillion (1E+150)!!!")
                                Console.ForegroundColor = ConsoleColor.White
                                Console.WriteLine("")
                                Console.ForegroundColor = ConsoleColor.Cyan
                                Console.WriteLine(" Sorry,Visual Basic calculator is not ready for this!!!")
                                Console.ForegroundColor = ConsoleColor.White
                                Console.WriteLine(" ------------------------------------------------------")
                                Console.Write(" Press <CLS> to clear the screen - ")
                                M = Console.ReadLine()
                                If M = "CLS" Then
                                    Console.Clear()
                                ElseIf M <> "CLS" Then
                                    Console.Clear()
                                End If
                            End If
                        ElseIf operation = ("%") Then
                            If Y <> 0 Then
                                result = X Mod Y
                                Console.WriteLine("")
                                Console.Write(" Your calculated result = ")
                                Console.WriteLine(result)
                                Console.WriteLine(" ------------------------------------------------------")
                                Console.Write(" Press <CLS> to clear the screen - ")
                                M = Console.ReadLine()
                                If M = "CLS" Then
                                    Console.Clear()
                                ElseIf M <> "CLS" Then
                                    Console.Clear()
                                End If
                            Else
                                Console.WriteLine("")
                                Console.ForegroundColor = ConsoleColor.Red
                                Console.WriteLine(" Division by zero is impossible! Please don't try to divide by zero!")
                                Console.ForegroundColor = ConsoleColor.White
                                Console.WriteLine(" -------------------------------------------------------------------")
                                Console.Write(" Press <CLS> to clear the screen - ")
                                M = Console.ReadLine()
                                If M = "CLS" Then
                                    Console.Clear()
                                ElseIf M <> "CLS" Then
                                    Console.Clear()
                                End If
                            End If
                        End If
                    End If
                Catch ex As OverflowException
                    Console.WriteLine("")
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine(" The operation (example:-X ^ (Y = 0,5)) of extracting")
                    Console.WriteLine(" a square root from a negative number is FORBIDDEN!!!")
                    Console.ForegroundColor = ConsoleColor.White
                    Console.WriteLine(" ----------------------------------------------------")
                    M = Console.ReadLine()
                    If M = "CLS" Then
                        Console.Clear()
                    ElseIf M <> "CLS" Then
                        Console.Clear()
                    End If
                    Continue While
                End Try
            End While

        End Sub
    End Class
End Module