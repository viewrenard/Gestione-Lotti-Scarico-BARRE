
Public Class MRNForm
    Public Codice As String
    Public MRNTrovato As String
    Private Sub MRNForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CaricoMRN_esistenti()
        'Dim rigg As New Resources.ResourceReader = My.Resources.ResourceManager

    End Sub
    Private Sub CaricoMRN_esistenti()
        DsMRNcaricoDM1.Clear()
        AdapterMRN_DM.SelectCommand.Parameters("@IdVermar").Value = "%" & Codice.ToString & "%"
        AdapterMRN_DM.Fill(DsMRNcaricoDM1)
        If DsMRNcaricoDM1.TB_ARTICOLI.Rows.Count = 0 Then Exit Sub
        Dim riga As DataRow
        If CommMRNuscitiDM.Connection.State = ConnectionState.Closed Then CommMRNuscitiDM.Connection.Open()
        Dim leggo As SqlClient.SqlDataReader
        'Ho visto che in alcuni IM7 l'MRN è inserito nel campro progressivo (destinato a quelli no MRN)
        For Each riga In DsMRNcaricoDM1.TB_ARTICOLI.Rows
            If IsDBNull(riga("Alfa")) And IsDBNull(riga("MRN")) And riga("Progressivo").ToString.Length > 15 Then
                riga("MRN") = riga("Progressivo")
                riga("Progressivo") = System.DBNull.Value

            End If
        Next




        For Each riga In DsMRNcaricoDM1.TB_ARTICOLI.Rows
            If riga("MRN").ToString <> "" Then
                CommMRNuscitiDM.Parameters("@MRNCarico").Value = riga("MRN")
                CommMRNuscitiDM.Parameters("@NumItemCarico").Value = riga("NumRiga")
                leggo = CommMRNuscitiDM.ExecuteReader
                leggo.Read()
                If leggo.HasRows Then
                    riga("NettoExport") = leggo("NettoExport")
                    riga("LordoExport") = leggo("LordoExport")
                    riga("ColliExport") = leggo("ColliExport")
                End If
                leggo.Close()
            Else
                CommNoMRNUscitiDM.Parameters("@NumItemCarico").Value = riga("NumRiga")
                CommNoMRNUscitiDM.Parameters("@NumDocCarico").Value = riga("Progressivo")
                CommNoMRNUscitiDM.Parameters("@CIN").Value = riga("Alfa")
                CommNoMRNUscitiDM.Parameters("@Data").Value = riga("DATA")
                leggo = CommNoMRNUscitiDM.ExecuteReader
                leggo.Read()
                If leggo.HasRows Then
                    riga("NettoExport") = leggo("NettoExport")
                    riga("LordoExport") = leggo("LordoExport")
                    riga("ColliExport") = leggo("ColliExport")
                End If
                leggo.Close()
            End If

        Next
        Dim i As Integer = 0
        For Each riga In DsMRNcaricoDM1.TB_ARTICOLI.Rows
            If riga.RowState <> DataRowState.Deleted Then
                If riga("Massanetta_038").ToString = riga("NettoExport").ToString Then riga.Delete()
                If riga.RowState <> DataRowState.Deleted Then
                    If riga("Massalorda_035").ToString = riga("LordoExport").ToString Then riga.Delete()
                End If
                If riga.RowState <> DataRowState.Deleted Then
                    If riga("Colli").ToString = riga("ColliExport").ToString Then riga.Delete()
                End If
                If riga.RowState <> DataRowState.Deleted Then
                    If IsNumeric(riga("Massanetta_038")) And IsNumeric(riga("NettoExport")) Then
                        riga("Massanetta_038") = CDec(riga("Massanetta_038")) - CDec(riga("NettoExport"))
                        riga("Massalorda_035") = CDec(riga("Massalorda_035")) - CDec(riga("LordoExport"))
                        riga("Colli") = CDec(riga("Colli")) - CDec(riga("ColliExport"))

                    End If
                End If
            End If



        Next

        DsMRNcaricoDM1.AcceptChanges()
        For Each riga In DsMRNcaricoDM1.TB_ARTICOLI.Rows
            i = i + 1
            If riga("MRN").ToString = "" Then riga("MRN") = riga("Progressivo").ToString & "/" & riga("Alfa").ToString
            riga("Item") = i
        Next
        If DsMRNcaricoDM1.TB_ARTICOLI.Rows.Count = 0 Then Exit Sub
        If DsMRNcaricoDM1.TB_ARTICOLI.Rows.Count = 1 Then
            MRNTrovato = DsMRNcaricoDM1.TB_ARTICOLI.Rows(0).Item("MRN")
            Me.Close()
        End If
        'tMRN.Text = DsMRNcaricoDM1.TB_ARTICOLI.Rows(0).Item("MRN").ToString
        'C1TrueDBGrid1.Columns("MRN").Text = BtMRN.Text
        ' Else
        'Dim MultiMTN As New MRNForm
        'MultiMTN.ds = DsMRNcaricoDM1.Copy
        'MultiMTN.ShowDialog()
        ' End If
    End Sub

    Private Sub BtItem_Click(sender As Object, e As EventArgs) Handles BtItem.Click
        Dim calcola As New Calc
        Calc.ShowDialog()
        If Not IsNumeric(Calc.Risultato) Then
            MRNTrovato = ""
        ElseIf CInt(Calc.Risultato) > DsMRNcaricoDM1.TB_ARTICOLI.Rows.Count + 1 Then
            MRNTrovato = ""
        Else
            MRNTrovato = DsMRNcaricoDM1.TB_ARTICOLI.Rows(CInt(Calc.Risultato) - 1).Item("MRN")
            BtItem.Text = (CInt(Calc.Risultato)).ToString
            C1TrueDBGrid1.Row = CInt(Calc.Risultato) - 1
            C1TrueDBGrid1.Refresh()
        End If
        Calc.Dispose()
    End Sub

    Private Sub BtCancella_Click(sender As Object, e As EventArgs) Handles BtCancella.Click
        MRNTrovato = ""
        Me.Close()
    End Sub

    Private Sub BtAccetta_Click(sender As Object, e As EventArgs) Handles BtAccetta.Click
        Me.Close()
    End Sub
End Class