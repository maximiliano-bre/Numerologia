Public Class FrmUno

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If Len(Trim(TxtNombre.Text)) > 0 Then
            Dim total_Texto
            total_Texto = Len(TxtNombre.Text)
            Dim FirstWord As String = Mid(TxtNombre.Text, 1)
            Dim i As Integer
            Dim acumulador As Integer
            Dim dos As String
            Dim uno As Integer
            Dim total As Integer

            uno = 0
            For i = 0 To total_Texto - 1

                dos = FirstWord(i)

                uno = calcular(dos)

                acumulador = acumulador + uno

            Next
            MsgBox("El sub total es: " & acumulador, MsgBoxStyle.Information, "Pre resulatado del calculo")

            If acumulador > 10 Then
                Dim pr As String = Mid(acumulador.ToString, 1)
                Dim pr1 As String
                Dim j As Integer
                Dim largo As Integer
                Dim ero As Integer
                largo = Len(acumulador.ToString)

                For j = 0 To largo - 1
                    pr1 = pr(j)

                    ero = sumar(pr1)

                    total = total + ero
                Next
                MsgBox("El Numero del nombre es: " & total, MsgBoxStyle.Information, "resultado total del calculo")
            End If




        Else
            MsgBox("Ingrese el nombre a calcular")
        End If
    End Sub
    Function sumar(ByVal otro As String) As Integer
        Dim suma As Integer
        suma = suma + otro
        Return suma
    End Function
    Function calcular(ByVal nose As String) As Integer
        Dim ret As Integer
        If nose = "a" Then
            ret = ret + 1
            Return ret
        End If
        If nose = "j" Then
            ret = ret + 1
            Return ret
        End If
        If nose = "s" Then
            ret = ret + 1
            Return ret
        End If
        If nose = "b" Then
            ret = ret + 2
            Return ret
        End If
        If nose = "k" Then
            ret = ret + 2
            Return ret
        End If
        If nose = "t" Then
            ret = ret + 2
            Return ret
        End If
        If nose = "c" Then
            ret = ret + 3
            Return ret
        End If
        If nose = "l" Then
            ret = ret + 3
            Return ret
        End If
        If nose = "u" Then
            ret = ret + 3
            Return ret
        End If
        If nose = "d" Then
            ret = ret + 4
            Return ret
        End If
        If nose = "m" Then
            ret = ret + 4
            Return ret
        End If
        If nose = "v" Then
            ret = ret + 4
            Return ret
        End If
        If nose = "e" Then
            ret = ret + 5
            Return ret
        End If
        If nose = "n" Then
            ret = ret + 5
            Return ret
        End If
        If nose = "w" Then
            ret = ret + 5
            Return ret
        End If
        If nose = "f" Then
            ret = ret + 6
            Return ret
        End If
        If nose = "o" Then
            ret = ret + 6
            Return ret
        End If
        If nose = "x" Then
            ret = ret + 6
            Return ret
        End If
        If nose = "g" Then
            ret = ret + 7
            Return ret
        End If
        If nose = "p" Then
            ret = ret + 7
            Return ret
        End If
        If nose = "y" Then
            ret = ret + 7
            Return ret
        End If
        If nose = "h" Then
            ret = ret + 8
            Return ret
        End If
        If nose = "q" Then
            ret = ret + 8
            Return ret
        End If
        If nose = "z" Then
            ret = ret + 8
            Return ret
        End If
        If nose = "i" Then
            ret = ret + 9
            Return ret
        End If
        If nose = "r" Then
            ret = ret + 9
            Return ret
        End If
    End Function

    Private Sub TxtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TxtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNombre.TextChanged

    End Sub

    Private Sub BtnAceptar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BtnAceptar.KeyPress
   
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            Call BtnAceptar_Click(sender, e)
        End If
        

    End Sub
End Class