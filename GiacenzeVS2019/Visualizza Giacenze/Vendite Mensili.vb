
Public Class Vendite_Mensili
    Friend idprodotto As Integer
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        DsVenditeMensili1.Clear()
        AdapterVenditeMensili.SelectCommand.Parameters("@DataInizio").Value = TxtDallaData.Value
        AdapterVenditeMensili.SelectCommand.Parameters("@Datafine").Value = TxtAllaData.Value
        AdapterVenditeMensili.SelectCommand.Parameters("@varditta").Value = 0
        AdapterVenditeMensili.SelectCommand.Parameters("@idprodotto").Value = idprodotto
        AdapterVenditeMensili.Fill(DsVenditeMensili1)
        Dim riga As DataRow
        For Each riga In DsVenditeMensili1.SpecifichePrevOrdFatt
            riga("MeseLettere") = Format(CDate("01/" & riga("meseNumero").ToString & "/" & riga("Anno").ToString), "MMMM")
        Next
    End Sub

    Private Sub Vendite_Mensili_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        C1TrueDBGrid1.Columns("vendite").NumberFormat = "#,##0.00"

        TxtAllaData.Value = Today
        TxtDallaData.Value = Today.AddYears(-1)
    End Sub

    Private Sub C1TrueDBGrid1_DoubleClick(sender As Object, e As System.EventArgs) Handles C1TrueDBGrid1.DoubleClick
        DsDettagliInventario1.Clear()
        GridDettagliInventario.Visible = False
        GridDettagliInventario.Caption = "Dettaglio della merce Venduta e fatturata Nel mese di " & C1TrueDBGrid1(C1TrueDBGrid1.Row, "Mese").ToString & " - " & C1TrueDBGrid1(C1TrueDBGrid1.Row, "Anno").ToString
        If ComVenditeFatturateTutti.Connection.State = ConnectionState.Closed Then ComVenditeFatturateTutti.Connection.Open()
        ComVenditeFatturateTutti.Parameters("@Varditta").Value = 0
        ComVenditeFatturateTutti.Parameters("@idprodotto").Value = idprodotto
        ComVenditeFatturateTutti.Parameters("@Mese").Value = C1TrueDBGrid1(C1TrueDBGrid1.Row, "MeseNumero")
        ComVenditeFatturateTutti.Parameters("@Anno").Value = C1TrueDBGrid1(C1TrueDBGrid1.Row, "Anno")
        Dim leggo As SqlClient.SqlDataReader = ComVenditeFatturateTutti.ExecuteReader
        Dim riga As DataRow = DsDettagliInventario1.Tables(0).NewRow
        While leggo.Read
            riga = DsDettagliInventario1.Tables(0).NewRow
            riga("quantita") = leggo("quantita")
            riga("DataOrdine") = leggo("DataOrdine")
            riga("UDM") = leggo("UDM")
            riga("NumFattura") = leggo("NumFattura")
            riga("Descrizione") = leggo("Descrizione")
            riga("CliFor") = leggo("CliFor")

            DsDettagliInventario1.Tables(0).Rows.Add(riga)
        End While

        leggo.Close()
        If DsDettagliInventario1.Tables(0).Rows.Count > 0 Then
            GridDettagliInventario.Splits(0).DisplayColumns("Data Cons.").Visible = False
            GridDettagliInventario.Splits(0).DisplayColumns("Ordine N.").Visible = False
            GridDettagliInventario.Splits(0).DisplayColumns("Data Fatt.").Visible = True
            GridDettagliInventario.Splits(0).DisplayColumns("Data Ordine").Visible = False

            GridDettagliInventario.Visible = True
        End If
    End Sub

    Private Sub C1TrueDBGrid1_FetchRowStyle(sender As Object, e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1TrueDBGrid1.FetchRowStyle
        If C1TrueDBGrid1(e.Row, "Anno").ToString = C1TrueDBGrid1(C1TrueDBGrid1.Row, "Anno").ToString And C1TrueDBGrid1(e.Row, "Mese").ToString = C1TrueDBGrid1(C1TrueDBGrid1.Row, "Mese").ToString Then
            e.CellStyle.BackColor = Color.YellowGreen
        End If
    End Sub
    Private Sub c1truedbgrid1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles C1TrueDBGrid1.MouseDown
        GridDettagliInventario.Visible = False
        If e.Button = Windows.Forms.MouseButtons.Right AndAlso C1TrueDBGrid1.PointAt(e.X, e.Y) = C1.Win.C1TrueDBGrid.PointAtEnum.AtDataArea Then

            C1TrueDBGrid1.Row = C1TrueDBGrid1.RowContaining(e.Y)

        End If
      
    End Sub
    Private Function GetUniqueTempFileName(ext As String) As String
        Dim TEMP_DIR As String = System.Environment.GetEnvironmentVariable("tmp")

        Return (TEMP_DIR & ext)
    End Function
    Private Sub C1TrueDBGrid1_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles C1TrueDBGrid1.MouseUp
        C1TrueDBGrid1.Refresh()
        If C1TrueDBGrid1.PointAt(e.X, e.Y) = C1.Win.C1TrueDBGrid.PointAtEnum.AtCaption And e.Button = System.Windows.Forms.MouseButtons.Right Then
            Dim captio As String = C1TrueDBGrid1.Caption
            C1TrueDBGrid1.Caption = "Vendite Mensili del prodotto: " & idprodotto.ToString
            Dim nomefile As String = GetUniqueTempFileName("\VenditeMensili " & idprodotto & ".xls")
            If System.IO.File.Exists(nomefile) Then

                System.IO.File.Delete(nomefile)
            End If

            C1TrueDBGrid1.ExportToExcel(nomefile)
            System.Diagnostics.Process.Start(nomefile)
            C1TrueDBGrid1.Caption = captio
        End If
    End Sub
End Class