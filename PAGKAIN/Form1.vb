
Public Class Form1
    Dim classic As Single
    Dim cheese As Single
    Dim spicy As Single
    Dim bbq As Single
    Dim salt As Single
    Dim pack1 As Single
    Dim pack2 As Single

    Dim qty1 As Short
    Dim total As Single
    Dim ammt As Single
    Dim chg As Single

    Dim qtClassic As Single
    Dim qtCheese As Single
    Dim qtSpicy As Single
    Dim qtbbq As Single
    Dim qtsalt As Single

    Dim qtP1 As Single
    Dim qtP2 As Single

    Dim total1 As Single
    Dim total2 As Single
    Dim total3 As Single
    Dim total4 As Single
    Dim total5 As Single
    Dim total6 As Single
    Dim total7 As Single

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' adding flavor
        classic = 149
        cheese = 149
        spicy = 149
        bbq = 149
        salt = 149

        qty1 = qty1 + 1
        Label11.Text = qty1

        If RadioButton1.Checked Then
            qtClassic = qtClassic + 1
            Label19.Text = qtClassic
            total1 = qtClassic * classic
        ElseIf RadioButton2.Checked Then
            qtCheese = qtCheese + 1
            Label20.Text = qtCheese
            total2 = qtCheese * cheese
        ElseIf RadioButton3.Checked Then
            qtSpicy = qtSpicy + 1
            Label21.Text = qtSpicy
            total3 = qtSpicy * spicy
        ElseIf RadioButton4.Checked Then
            qtbbq = qtbbq + 1
            Label22.Text = qtbbq
            total4 = qtbbq * bbq
        ElseIf RadioButton5.Checked Then
            qtsalt = qtsalt + 1
            Label23.Text = qtsalt
            total5 = qtsalt * salt
        End If

        Label14.Text = total1 + total2 + total3 + total4 + total5 + total6 + total7

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' minus flavor

        classic = 149
        cheese = 149
        spicy = 149
        bbq = 149
        salt = 149

        If RadioButton1.Checked And qtClassic > 0 Then
            qtClassic = qtClassic - 1
            Label19.Text = qtClassic
            total1 = qtClassic * classic
            If qty1 > 0 Then
                qty1 = qty1 - 1
                Label11.Text = qty1
            End If
        ElseIf RadioButton2.Checked And qtCheese > 0 Then
            qtCheese = qtCheese - 1
            Label20.Text = qtCheese
            total2 = qtCheese * cheese
            If qty1 > 0 Then
                qty1 = qty1 - 1
                Label11.Text = qty1
            End If
        ElseIf RadioButton3.Checked And qtSpicy > 0 Then
            qtSpicy = qtSpicy - 1
            Label21.Text = qtSpicy
            total3 = qtSpicy * spicy
            If qty1 > 0 Then
                qty1 = qty1 - 1
                Label11.Text = qty1
            End If
        ElseIf RadioButton4.Checked And qtbbq > 0 Then
            qtbbq = qtbbq - 1
            Label22.Text = qtbbq
            total4 = qtbbq * bbq
            If qty1 > 0 Then
                qty1 = qty1 - 1
                Label11.Text = qty1
            End If
        ElseIf RadioButton5.Checked And qtsalt > 0 Then
            qtsalt = qtsalt - 1
            Label23.Text = qtsalt
            total5 = qtsalt * salt
            If qty1 > 0 Then
                qty1 = qty1 - 1
                Label11.Text = qty1
            End If
        End If

        Label14.Text = total1 + total2 + total3 + total4 + total5 + total6 + total7

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' adding pack
        pack1 = 2788
        pack2 = 5488

        If RadioButton6.Checked Then
            qtP1 = qtP1 + 1
            Label24.Text = qtP1
            total6 = qtP1 * pack1
            If qty1 <= 0 Then
                qty1 = qty1 + 1
                Label11.Text = qty1
            End If
        ElseIf RadioButton7.Checked Then
            qtP2 = qtP2 + 1
            Label25.Text = qtP2
            total7 = qtP2 * pack2
            If qty1 <= 0 Then
                qty1 = qty1 + 1
                Label11.Text = qty1
            End If
        End If

        Label14.Text = total1 + total2 + total3 + total4 + total5 + total6 + total7

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' minus pack
        pack1 = 2788
        pack2 = 5488

        If RadioButton6.Checked And qtP1 > 0 Then
            qtP1 = qtP1 - 1
            Label24.Text = qtP1
            total6 = qtP1 * pack1
            If qty1 > 0 Then
                qty1 = qty1 - 1
                Label11.Text = qty1
            End If
        ElseIf RadioButton7.Checked And qtP2 > 0 Then
            qtP2 = qtP2 - 1
            Label25.Text = qtP2
            total7 = qtP2 * pack2
            If qty1 > 0 Then
                qty1 = qty1 - 1
                Label11.Text = qty1
            End If
        End If

        Label14.Text = total1 + total2 + total3 + total4 + total5 + total6 + total7
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If TextBox3.Text = "" Then
            MsgBox("PLEASE INPUT AMMOUNT")
        End If
        ammt = TextBox3.Text
        chg = Label16.Text
        total = Label14.Text

        Label16.Text = ammt - total


        If total = 0 Then
            MsgBox("WALA KA BANG PERA? BAKIT DI KA BUMILI, TAMAD TO")
        ElseIf ammt > total Then
            MsgBox("DAMING PERA AH, SIPAG MO NAMAN")
        ElseIf ammt < total Then
            MsgBox("BAWAL UTANG DITO, MAG TRABAHO KA")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Reset all labels to 0
        Label19.Text = 0
        Label20.Text = 0
        Label21.Text = 0
        Label22.Text = 0
        Label23.Text = 0
        Label24.Text = 0
        Label25.Text = 0
        Label11.Text = 0
        Label14.Text = 0
        Label16.Text = 0

        ' Clear the TextBox
        TextBox3.Text = ""

        ' Uncheck all RadioButtons
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False
        RadioButton7.Checked = False

        ' Reset all totals and quantities to 0
        total1 = 0
        total2 = 0
        total3 = 0
        total4 = 0
        total5 = 0
        total6 = 0
        total7 = 0
        total = 0
        ammt = 0
        chg = 0
        qty1 = 0
        qtClassic = 0
        qtCheese = 0
        qtSpicy = 0
        qtbbq = 0
        qtsalt = 0
        qtP1 = 0
        qtP2 = 0

    End Sub
End Class
