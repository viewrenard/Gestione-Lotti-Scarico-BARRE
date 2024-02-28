Public Class RicercaProdotti
    Friend datainventario As Date
    Friend Dirittipassword_Operatore As String
    Friend DettagliUDM As New RitornoValori
    Private Sub ricerca_i_Prodotti(ByVal chiave_ricerca As String)
        ' GridRicerca.Caption = "Elenco Prodotti Movimentati dalla data del " & datainventario.ToShortDateString
        If IsNumeric(chiave_ricerca) Then
            AdapterRicercaProdotti.SelectCommand = ComRicercaProdottiPerCodice
            AdapterRicercaProdotti.SelectCommand.Parameters("@Articolo").Value = CInt(chiave_ricerca)
            ' Me.AdapterRicercaProdotti.SelectCommand.Parameters("@Datainizio").Value = datainventario
        Else
            AdapterRicercaProdotti.SelectCommand = SqlSelectCommand1
            Dim ricerca As String = "%" & chiave_ricerca.Trim & "%"
            Dim parole() As String = ricerca.Split(CType(" ", Char))
            Dim ricerca1 As String = "%%"
            Dim ricerca2 As String = "%%"
            If parole.Length < 4 Then
                ricerca = "%" & parole(0) & "%"
                If parole.Length > 1 Then ricerca1 = "%" & parole(1) & "%"
                If parole.Length > 2 Then ricerca2 = "%" & parole(2) & "%"
            End If


            Me.AdapterRicercaProdotti.SelectCommand.Parameters("@ricerca").Value = ricerca
            Me.AdapterRicercaProdotti.SelectCommand.Parameters("@ricerca1").Value = ricerca1
            Me.AdapterRicercaProdotti.SelectCommand.Parameters("@ricerca2").Value = ricerca2
            ' Me.AdapterRicercaProdotti.SelectCommand.Parameters("@Datainizio").Value = datainventario
        End If
        DsRicercaProdotti1.Clear()

        AdapterRicercaProdotti.Fill(DsRicercaProdotti1)
        Dim riga As DataRow
        For Each riga In DsRicercaProdotti1.Tables(0).Rows
            If CDec(riga("Giacenza")) = 0 Then
                riga("Scadenze") = System.DBNull.Value
            End If
        Next
        GridRicerca.Refresh()
    End Sub
    Private Sub RicercaProdotti_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Dim aggiornaDati As New Project1.Aggiorna
        ' aggiornaDati.aggiorna()

        Dim data As Date = Today

        Dirittipassword_Operatore = ""

        Me.Text = System.Environment.UserName.ToLower
        If comPassword.Connection.State = ConnectionState.Closed Then comPassword.Connection.Open()
        Me.Text = System.Environment.UserName.ToString
        comPassword.Parameters("@utente").Value = System.Environment.UserName.ToLower
        '  comPassword.Parameters("@utente").Value = "cristina"
        Dim leggo As SqlClient.SqlDataReader = comPassword.ExecuteReader
        leggo.Read()
        If leggo.HasRows Then
            ' Incaricato_completo_operatore = leggo("NomeCompleto").ToString
            ' Password_Operatore = leggo("Password").ToString
            ' Email_Ooperatore = leggo("Email").ToString
            Dirittipassword_Operatore = leggo("FlagDiritti").ToString
            ' PasswordNet = leggo("PasswordNet").ToString

        End If
        leggo.Close()
        comPassword.Connection.Close()

        If ComDataUltimoInventarioGenerale.Connection.State = ConnectionState.Closed Then ComDataUltimoInventarioGenerale.Connection.Open()
        ComDataUltimoInventarioGenerale.Parameters("@Varditta").Value = 0
        If Not ComDataUltimoInventarioGenerale.ExecuteScalar Is Nothing Then
            datainventario = CDate(ComDataUltimoInventarioGenerale.ExecuteScalar)

        Else
            datainventario = CDate("01/01/" & Str(Today.Year))
        End If
        GridRicerca.ContextMenu = ContextMenu1
    End Sub

    Private Sub TxtRicerca_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TxtRicerca.KeyDown
        If e.KeyCode = Keys.Enter Then BtRicerca.PerformClick()
    End Sub

    Private Sub BtRicerca_Click(sender As System.Object, e As System.EventArgs) Handles BtRicerca.Click
        ricerca_i_Prodotti(TxtRicerca.Text)
    End Sub

    Private Sub GridRicerca_DoubleClick(sender As Object, e As System.EventArgs) Handles GridRicerca.DoubleClick
        If IsDBNull(GridRicerca.Columns("Id Prodotto").Value) Then Exit Sub

        DettagliUDM.CaricoDati = CInt(GridRicerca.Columns("Id Prodotto").Value)


    End Sub

    Private Sub GridRicerca_FetchRowStyle(sender As Object, e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles GridRicerca.FetchRowStyle
        Dim newfont As New Font(GridRicerca.Font, FontStyle.Strikeout)
        If GridRicerca(e.Row, "FlagUso").ToString = "*" Then
            e.CellStyle.Font = newfont
            e.CellStyle.BackColor = System.Drawing.Color.Coral

        End If
        If e.Row = GridRicerca.Row Then e.CellStyle.BackColor = System.Drawing.Color.YellowGreen

    End Sub

    Private Sub GridRicerca_MarginChanged(sender As Object, e As System.EventArgs) Handles GridRicerca.MarginChanged

    End Sub

    Private Sub GridRicerca_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles GridRicerca.MouseClick
        ' If e.Clicks = 1 Then PRezziAcquistoVendita1.Visible = False
    End Sub

    Private Sub GridRicerca_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles GridRicerca.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right AndAlso GridRicerca.PointAt(e.X, e.Y) = C1.Win.C1TrueDBGrid.PointAtEnum.AtDataArea Then

            GridRicerca.Row = GridRicerca.RowContaining(e.Y)

        End If
        If DsRicercaProdotti1.Tables(0).Rows.Count = 0 Then
            MenuItem1.Visible = False
        Else
            MenuItem1.Visible = True
        End If
    End Sub

    Private Sub MenuItem1_Click(sender As Object, e As System.EventArgs) Handles MenuItem1.Click
        If GridRicerca.Columns("progressivo").Text = "" Then Exit Sub
        Dim giacenza As New FormGiacenze
        giacenza.IdProdotto = CInt(GridRicerca.Columns("progressivo").Value)
        giacenza.ShowDialog()
        giacenza.Dispose()
    End Sub


    Private Sub MenuItem2_Click(sender As Object, e As System.EventArgs) Handles MenuItem2.Click
        If GridRicerca.Columns("progressivo").Text = "" Then Exit Sub
        Dim vendite As New Vendite_Mensili
        vendite.idprodotto = CInt(GridRicerca.Columns("progressivo").Value)
        vendite.ShowDialog()
        vendite.Dispose()
    End Sub

    Private Sub GridRicerca_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles GridRicerca.MouseMove

    End Sub

    Private Sub GridRicerca_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles GridRicerca.MouseUp
        If GridRicerca(GridRicerca.Row, "Annotazioni").ToString <> "" Then
            TxtNote.Text = GridRicerca(GridRicerca.Row, "Annotazioni").ToString
            TxtNote.Visible = True
        Else
            TxtNote.Text = ""
            TxtNote.Visible = False
        End If

        DataGridView1.Visible = False
        DataGridView2.Visible = False

    End Sub


    Private Function GetUniqueTempFileName(ext As String) As String
        Dim TEMP_DIR As String = System.Environment.GetEnvironmentVariable("tmp")

        Return (TEMP_DIR & ext)
    End Function

    Private Sub MenuItem3_Click(sender As Object, e As System.EventArgs) Handles MenuItem3.Click
        If GridRicerca.RowCount = 0 Then Exit Sub


        Dim nomefile As String = GetUniqueTempFileName("\Elenco Prodotti.xls")
        If System.IO.File.Exists(nomefile) Then

            System.IO.File.Delete(nomefile)
        End If

        GridRicerca.ExportToExcel(nomefile)
        System.Diagnostics.Process.Start(nomefile)

    End Sub






End Class