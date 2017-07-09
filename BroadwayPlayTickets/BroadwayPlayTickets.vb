Public Class frmTheatreTickets
    Dim decTax As Decimal = 0.12D
    Dim blnOrchestra As Boolean = False
    Dim blnMezzanine As Boolean = False

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(5000)
    End Sub
    Private Sub cboSelectPlay_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cboSelectPlay.SelectedIndexChanged
        Dim intPlayChoice As Integer

        intPlayChoice = Me.cboSelectPlay.SelectedIndex
        txtEnterNumberOfTickets.Focus()
        lblEnterNumberOfTickets.Visible = True
        btnCalculateCost.Visible = True
        txtEnterNumberOfTickets.Visible = True
        radOrchestra.Visible = True
        radMezzanine.Visible = True
        radOrchestra.Checked = True

    End Sub
    Private Sub btnCalculateCost_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCalculateCost.Click
        Dim intGroupSize As Integer
        Dim blnNumberInPartyIsValid As Boolean = False
        Dim blnSeatIsSelected As Boolean = False
        Dim intPLayChoice As Integer
        Dim intSeatingArea As Integer
        Dim intSeat As Integer
        Dim decTotalCost As Decimal


        blnNumberInPartyIsValid = ValidateNumberInParty()

        If blnNumberInPartyIsValid Then
            intGroupSize = Convert.ToInt32(txtEnterNumberOfTickets.Text)
            intSeatingArea = cboSelectPlay.SelectedIndex

            Select Case intSeatingArea
                Case 0
                    decTotalCost = LionKingFindCost(intPLayChoice, intGroupSize, intSeat)

                Case 1
                    decTotalCost = WickedFindCost(intPLayChoice, intGroupSize, intSeat)

                Case 2
                    decTotalCost = PhantomFindCost(intPLayChoice, intGroupSize, intSeat)

            End Select
            txtEnterNumberOfTickets.Focus()
            lblSubTotalGenerate.Visible = True
            lblTaxGenerate.Visible = True
            lblTotalGenerate.Visible = True
            lblSubTotal.Visible = True
            lblTax.Visible = True
            lblFinalTotal.Visible = True
            lblSubTotalGenerate.Text = decTotalCost.ToString("C")
            lblTaxGenerate.Text = FormatCurrency(decTotalCost.ToString("C") * decTax)
            lblTotalGenerate.Text = FormatCurrency(decTotalCost.ToString("C") + (decTotalCost * decTax))
        End If
    End Sub
    Private Function ValidateNumberInParty() As Boolean
        Dim intPartyNumber As Integer
        Dim blnValidityCheck As Boolean = False

        Try
            intPartyNumber = Convert.ToInt32(txtEnterNumberOfTickets.Text)
            If intPartyNumber >= 1 Then
                blnValidityCheck = True
            Else
                MsgBox("Please enter number of tickets", , "Entry Error")
            End If
        Catch Exception As FormatException
            MsgBox("Please enter number 1 or greater", , "Entry Error")
        End Try

        Return blnValidityCheck
    End Function
   
    Private Function LionKingFindCost(ByVal intPlayChoice As Integer, ByVal intGroupSize As Integer, ByVal intSeat As Integer) As Decimal
        Dim decPlayCost As Decimal
        Dim decFinalCost As Decimal
        Dim decLionKingOrcCost As Decimal = 135D
        Dim decLionKingMezCost As Decimal = 92D

        Select Case intPlayChoice
            Case 0
                If radOrchestra.Checked = True Then
                    decPlayCost = decLionKingOrcCost
                Else
                    decPlayCost = decLionKingMezCost
                End If
        End Select
        decFinalCost = decPlayCost * intGroupSize
        Return decFinalCost
    End Function
    Private Function WickedFindCost(ByVal intPlayChoice As Integer, ByVal intGroupSize As Integer, ByVal intSeat As Integer) As Decimal
        Dim decPlayCost As Decimal
        Dim decFinalCost As Decimal
        Dim decWickedOrcCost As Decimal = 149D
        Dim decWickedMezCost As Decimal = 98D

        Select Case intPlayChoice
            Case 0
                If radOrchestra.Checked = True Then
                    decPlayCost = decWickedOrcCost
                Else
                    decPlayCost = decWickedMezCost
                End If
        End Select
        decFinalCost = decPlayCost * intGroupSize
        Return decFinalCost
    End Function
    Private Function PhantomFindCost(ByVal intPlayChoice As Integer, ByVal intGroupSize As Integer, ByVal intSeat As Integer) As Decimal
        Dim decPlayCost As Decimal
        Dim decFinalCost As Decimal
        Dim decPhantomOrcCost As Decimal = 128D
        Dim decPhantomMezCost As Decimal = 82D

        Select Case intPlayChoice
            Case 0
                If radOrchestra.Checked = True Then
                    decPlayCost = decPhantomOrcCost
                Else
                    decPlayCost = decPhantomMezCost
                End If
        End Select
        decFinalCost = decPlayCost * intGroupSize
        Return decFinalCost
    End Function
End Class
