
Imports System.Net
Imports C1.Win.C1TrueDBGrid

Public Class GestioneLottiBarre
	Friend IdDettaglioOrdine As Integer
	Friend DettagliUDM As New RitornoValori
	Friend Const FNC As String = Chr(33)
	Friend AIDatatable As New DataTable
	Friend NumOrdine As Integer
	Friend NumArticolo As Integer
	Friend RapportoUdmPeso As Decimal
	Friend RapportoColliQuantita As Decimal
	Friend RapportoPackingAnagrafica As Decimal
	Friend TaraUnitadiMisura As Decimal
	Friend TaraCRT As Decimal
	Friend PesoNetto As Decimal = 0
	Friend Pesolordo As Decimal = 0
	Friend PesoNettoRiga As Decimal = 0
	Friend PesoLordoRiga As Decimal = 0
	Friend DataInventario As Date
	Friend UDMLottoGS1Fornitore As String
	Friend Incaricato_completo_Operatore As String
	Friend Password_Operatore As String
	Friend Email_Ooperatore As String
	Friend DirittiPAssword_operatore As Integer
	Friend FlagT1 As Boolean
	Friend Email_Responsabile_Ordine As String
	Friend Responsabile_Ordine As String
	Friend PlistOrdine As String
	Friend Non_e_QRCODE As Boolean
	Friend NumPallet As Integer
	Friend Function Cerco_Elemento(Matrice() As String, Ricerca As String) As Boolean
		Dim i As Integer = 0
		For i = 0 To Matrice.Length - 1
			If Matrice(i).Contains(Ricerca) Then
				Cerco_Elemento = True
				Exit For
			Else
				Cerco_Elemento = False
			End If
		Next

	End Function
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		If SqlComPassword.Connection.State = ConnectionState.Closed Then SqlComPassword.Connection.Open()

		SqlComPassword.Parameters("@utente").Value = System.Environment.UserName.ToLower
		Dim leggo As SqlClient.SqlDataReader = SqlComPassword.ExecuteReader
		leggo.Read()
		If leggo.HasRows Then
			Incaricato_completo_Operatore = leggo("NomeCompleto").ToString
			Password_Operatore = leggo("Password").ToString
			Email_Ooperatore = leggo("Email").ToString
			DirittiPAssword_operatore = CInt(leggo("FlagDiritti"))
		Else
			MsgBox("Non si ha alcun diritto di entrare nella procedura")
			Me.Close()
		End If
		leggo.Close()
		SqlComPassword.Connection.Close()


		If Environment.UserName.ToLower = "volponenew" Then
			If MsgBox("Vuoi lavorare in ambiente TEST? SI/NO", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
				If MsgBox("Stai per lavorare in ambiente Reale, i dati saranno memorizzati sul DB che viene utilizzato: vuoi continuare SI/NO", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

			Else

				SqlConnection1 = SqlConnection1TEST
				SqlConnection2 = SqlConnection2TEST
				AdapterLottoEsistente.SelectCommand.Connection.ConnectionString = SqlConnection2TEST.ConnectionString
				AdapterLottoEsistente.UpdateCommand.Connection.ConnectionString = SqlConnection2TEST.ConnectionString
				AdapterLottoEsistente.DeleteCommand.Connection.ConnectionString = SqlConnection2TEST.ConnectionString
				AdapterOrdineDettagli.SelectCommand.Connection.ConnectionString = SqlConnection2TEST.ConnectionString
				SqlComUpdateRigheOrdine.Connection = SqlConnection1TEST

			End If
		End If
		'Me.Height = 1220
		'AIDataTable = New DataTable
		AdapterGs1AI.Fill(AIDatatable)    'Carico subito tutta la tabella dei codici AI
		AIDatatable.Columns.Add("ValoreAI", GetType(String))    'Aggiungo una colonna destinata a contenere il valore dell'AI
		If ComDataUltimoInventarioGenerale.Connection.State = ConnectionState.Closed Then ComDataUltimoInventarioGenerale.Connection.Open()
		ComDataUltimoInventarioGenerale.Parameters("@Varditta").Value = 0
		If Not ComDataUltimoInventarioGenerale.ExecuteScalar Is Nothing Then
			DataInventario = CDate(ComDataUltimoInventarioGenerale.ExecuteScalar)

		Else
			DataInventario = CDate("01/01/" & Str(Today.Year))
		End If
	End Sub


	Private Sub TxtScansione_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtScansione.KeyDown
		TxtAvviso.Visible = False
		' Dim calcolatore As New Calc
		'  calcolatore.ShowDialog()


		If e.KeyData = Keys.Enter Then
			interpretoCodici(TxtScansione.Text)
		End If
	End Sub
	Private Sub Salvo_Riga_Ordine()
		Calcolo_Totali()
		If NumOrdine = 0 Or IdDettaglioOrdine = 0 Then Exit Sub
		Dim righe() As DataRow = DataView1.Table.Select("Idpratica = " & IdDettaglioOrdine)
		If righe(0).RowState = DataRowState.Unchanged Then Exit Sub

		If SqlComUpdateRigheOrdine.Connection.State = ConnectionState.Closed Then SqlComUpdateRigheOrdine.Connection.Open()
		SqlComUpdateRigheOrdine.Parameters("@IdDettaglioOrdine").Value = IdDettaglioOrdine
		'Queste righe sono per inserire il packing della riga calcolato se il packing risulta vuoto tolte per indica =========================
		'If PlistOrdine = "" And IsNumeric(BtQuantita.Text.Replace("0", "")) And IsNumeric(BTColli.Text.Replace("0", "")) And TxtUdm.Text.ToLower = "kg." Then PlistOrdine = "1x" & CDec(CDec(BtQuantita.Text.Trim) / CDec(BTColli.Text))
		'=====================================================================================================================================

		If PlistOrdine = "" Then SqlComUpdateRigheOrdine.Parameters("@Packing").Value = System.DBNull.Value Else SqlComUpdateRigheOrdine.Parameters("@Packing").Value = PlistOrdine
		If BtQuantita.Text.Replace("0", "") = "" Then SqlComUpdateRigheOrdine.Parameters("@QuantitaMagazzino").Value = System.DBNull.Value Else SqlComUpdateRigheOrdine.Parameters("@QuantitaMagazzino").Value = BtQuantita.Text.Replace(".", ",")
		If BtQuantita.Text.Replace("0", "") = "" Then SqlComUpdateRigheOrdine.Parameters("@QuantitaMagazzinoNum").Value = System.DBNull.Value Else SqlComUpdateRigheOrdine.Parameters("@QuantitaMagazzinoNum").Value = CDec(BtQuantita.Text.Replace(".", ","))
		If BTColli.Text.Replace("0", "") = "" Then SqlComUpdateRigheOrdine.Parameters("@ColliMagazzino").Value = System.DBNull.Value Else SqlComUpdateRigheOrdine.Parameters("@ColliMagazzino").Value = BTColli.Text
		SqlComUpdateRigheOrdine.Parameters("@Pallet").Value = BtPallet.Text
		If PesoNetto <> 0 Then SqlComUpdateRigheOrdine.Parameters("@PesoNetto").Value = PesoNetto Else SqlComUpdateRigheOrdine.Parameters("@PesoNetto").Value = System.DBNull.Value
		If Pesolordo <> 0 Then SqlComUpdateRigheOrdine.Parameters("@PesoLordo").Value = Pesolordo Else SqlComUpdateRigheOrdine.Parameters("@PesoLordo").Value = System.DBNull.Value
		If My.Computer.Network.IsAvailable Then
			SqlComUpdateRigheOrdine.ExecuteScalar()
		Else
			MsgBox("ATTENZIONE: MANCA LA CONNESSIONE DI RETE L'ORDINE VERRA' RIAVVIATO e i dati dell'ultimo articolo inserito saranno persi")
			Dim ORDINENUM As String = "$" & NumOrdine.ToString
			AzzeroTutto()
			TxtScansione.Text = ORDINENUM
			interpretoCodici(TxtScansione.Text)
			Exit Sub
		End If

		righe = DsOrdineDettagli1.Tables(0).Select("IdPratica = " & IdDettaglioOrdine.ToString)
		If righe.Length > 0 Then
			righe(0).Item("QuantMagazzino") = BtQuantita.Text
			C1TrueDBGrid2.Refresh()
		End If
		IdDettaglioOrdine = 0
		BtPacking.Text = ""
		BtQuantita.Text = ""
		BTColli.Text = ""
		PesoLordoRiga = 0
		PesoNettoRiga = 0
		PesoNetto = 0
		Pesolordo = 0



	End Sub
	Private Sub Salvo_Lotti_del_Prodotto()
		If DsLotti1.TabellaLotti.Rows.Count <> 0 Then
			C1TrueDBGrid1.UpdateData()
			If My.Computer.Network.IsAvailable Then
				Dim inseriti As DataSet = DsLotti1.GetChanges(DataRowState.Added)
				Dim Aggiornati As DataSet = DsLotti1.GetChanges(DataRowState.Modified)
				Dim cancellati As DataSet = DsLotti1.GetChanges(DataRowState.Deleted)

				If Not IsNothing(inseriti) Then AdapterLottoEsistente.Update(inseriti)
				If Not IsNothing(cancellati) Then AdapterLottoEsistente.Update(cancellati)
				If Not IsNothing(Aggiornati) Then AdapterLottoEsistente.Update(Aggiornati)
			Else
				MsgBox("ATTENZIONE: MANCA LA CONNESSIONE DI RETE L'ORDINE VERRA' RIAVVIATO e i dati dell'ultimo articolo inserito saranno persi")
				Dim ORDINENUM As String = "$" & NumOrdine.ToString
				AzzeroTutto()
				TxtScansione.Text = ORDINENUM
				interpretoCodici(TxtScansione.Text)
				Exit Sub
			End If

			TxtLotto.Text = ""
			TxTUDMLotto.Text = ""
			TxtQuantitaLotto.Text = ""
			TxtColli.Text = ""
			TxtScadenza.Text = ""
			BtProduzione.Text = ""
			DsLotti1.Clear()
			GroupBox2.Visible = False
			DsRicercaLotti1.Clear()
			If BtVediLotti.Text = "Chiudi Lotti" Then
				BtVediLotti.Text = "Vedi Lotti"
				BtVediLotti.BackColor = Color.Aqua
			End If

		End If
	End Sub

	Private Sub cancello_riga_Lotto()
		If NumOrdine = 0 Then Exit Sub

		If C1TrueDBGrid1.FetchRowStyles = True Then
			If C1TrueDBGrid1.RowCount <> 0 Then
				If (MsgBox("Stai per cancellare la riga selezionata: Continua?", MsgBoxStyle.YesNo)) = MsgBoxResult.No Then Exit Sub
				C1TrueDBGrid1.AllowDelete = True
				C1TrueDBGrid1.Delete()
				C1TrueDBGrid1.AllowDelete = False
				C1TrueDBGrid1.UpdateData()
				C1TrueDBGrid1.FetchRowStyles = False
			End If
		ElseIf C1TrueDBGrid1.RowCount = 0 Then


		End If

		BTColli.Text = ""
		BtQuantita.Text = ""
		Calcolo_Totali()
	End Sub

	Private Sub CaricoProdotto(idProdotto As String)

		If NumOrdine = 0 Then
			TxtScansione.Text = ""
			TxtScansione.SelectAll()
			TxtScansione.Focus()
			Exit Sub
		End If
		DsRicercaLotti1.Clear()
		GroupBox2.Visible = False
		'Per prima cosa vedo se vi sono dati nella riga
		Salvo_Riga_Ordine()
		'SE ci sono dati nel Datasetlotti li devo salvare
		Salvo_Lotti_del_Prodotto()


		Dim IdRigaOrdine As Integer
		Dim tavola As DataTable = DataView1.ToTable
		Dim righe() As DataRow = tavola.Select("progressivo = " & idProdotto)
		If righe.Length = 0 Then
			TxtScansione.SelectAll()
			TxtScansione.Focus()
			Exit Sub
		ElseIf righe(0).Item("IdFatt").ToString <> "" Then
			TxtAvviso.Text = "Il prodotto è già stato fatturato e non può essere meodificat"
			TxtAvviso.Visible = True
			Exit Sub

		Else
			If righe.Length = 1 Then
				IdRigaOrdine = CInt(righe(0).Item("idpratica"))

			Else
				Dim nota As String = ""
				TxtAvviso.Text = "Vi sono più ricorrenze del prodotto: " & idProdotto.ToString & " >>> Scegliere la riga fra la numero: "
				Dim riga1 As DataRow
				For Each riga1 In righe
					If nota = "" Then nota = riga1("IdRiga").ToString Else nota = nota & " - " & riga1("IdRiga").ToString

					TxtAvviso.Visible = True
				Next
				TxtAvviso.Text = TxtAvviso.Text & nota
				Dim calcolatore As New Calc
				calcolatore.OperatorDivideBtn.Visible = False
				calcolatore.OperatorMultiplyBtn.Visible = False
				calcolatore.OperatorSubtractBtn.Visible = False
				calcolatore.OperatorPlusBtn.Visible = False
				calcolatore.DecimalBtn.Visible = False
				calcolatore.DecimalBtn.Visible = False
				calcolatore.EqualBtn.Visible = False
				calcolatore.OperatorX.Visible = False
				calcolatore.TxtLabelAvviso.Text = "Scegliere soltanto le righe: " & nota.Trim
				calcolatore.TxtLabelAvviso.Visible = True
				calcolatore.ShowDialog()
				If calcolatore.Risultato = "" Then Exit Sub
				Dim spezzo() As String = nota.Split("-")
				Dim i As Integer
				For i = 0 To spezzo.Length - 1
					spezzo(i) = spezzo(i).Trim
				Next
				If spezzo.Contains(calcolatore.Risultato) Then

					righe = DataView1.Table.Select("Idriga = " & calcolatore.Risultato)
					IdRigaOrdine = CInt(righe(0).Item("Idpratica"))
				Else Exit Sub
				End If
				calcolatore.Dispose()
			End If
		End If
		DettagliUDM.CaricoDati = CInt(idProdotto)
		IdDettaglioOrdine = 0
		RapportoColliQuantita = 0
		TaraCRT = 1 ' Per deasfault pongo la tara del cartone = 1 Kg
		TaraUnitadiMisura = 0
		Dim commando As New SqlClient.SqlCommand
		commando.Connection = SqlConnection1
		commando.CommandText = "SELECT ListGenDettagli.Descrizione,ListGenDettagli.UDM as UDML,ListGenDettagli.RapportoUnita1 as RappUDML,ListGenDettagli.Confezioni as CONF, ListGenDettagli.RapportoUnita2 as RapportoCONFL, ListGenDettagli.Cartoni as CRT, ListGenDettagli.RapportoUnita3 as RapportoCRTL, SpecifichePrevOrdFatt.ColliMagazzino, SpecifichePrevOrdFatt.IdPratica, SpecifichePrevOrdFatt.QuantMagazzino, SpecifichePrevOrdFatt.IdRiga, SpecifichePrevOrdFatt.NumOrdQuant, SpecifichePrevOrdFatt.UDM, SpecifichePrevOrdFatt.Packing AS Plistordine,SpecifichePrevOrdFatt.colli, SpecifichePrevOrdFatt.PesoNetto as PesoNettoRiga, SpecifichePrevOrdFatt.PesoLordo AS PesoLordoRiga, listgendettagli.Packing, SpecifichePrevOrdFatt.Pallet, ListGenDettagli.Tara1, ListGenDettagli.FlagT1, ListGenDettagli.Tara2, ListGenDettagli.tara3, CAST(SpecifichePrevOrdFatt.NumContainer AS nvarchar(2)) + ' -  ' + containers.Descrizione AS Camion FROM SpecifichePrevOrdFatt INNER JOIN ListGenDettagli ON SpecifichePrevOrdFatt.progressivo = ListGenDettagli.Progressivo INNER JOIN ContainersOrdine ON SpecifichePrevOrdFatt.IdOrd = ContainersOrdine.IDOrdine AND SpecifichePrevOrdFatt.NumContainer = ContainersOrdine.NumContainer INNER JOIN containers ON ContainersOrdine.IDTipoContainer = containers.ID  Where (SpecifichePrevOrdFatt.Idpratica = " & IdRigaOrdine & ")"

		If commando.Connection.State = ConnectionState.Closed Then commando.Connection.Open()
		Dim leggo As SqlClient.SqlDataReader = commando.ExecuteReader
		leggo.Read()
		If leggo.HasRows Then
			Dim RapportoCartone As Decimal = 0

			TxtIdArticolo.Text = CInt(idProdotto)
			NumArticolo = CInt(idProdotto)
			IdDettaglioOrdine = CInt(leggo("IdPratica"))
			TxtDesArticolo.Text = leggo("Descrizione").ToString
			TxtUdm.Text = leggo("UDM").ToString
			TxtQuantOrdine.Text = leggo("NumOrdQuant").ToString
			BTColli.Text = leggo("Colli").ToString
			'spezzo = leggo("Packing").ToString.Replace("X", "x").Split("x")
			'If spezzo.Length <> 0 Then
			If IsNumeric(leggo("PesoNettoRiga")) Then PesoNettoRiga = CDec(leggo("PesoNettoRiga"))
			If IsNumeric(leggo("PesoLordoRiga")) Then PesoLordoRiga = CDec(leggo("PesoLordoRiga"))
			If leggo("Flagt1").ToString = "*" Then
				FlagT1 = True
				GroupBox1.Visible = True
			Else
				FlagT1 = False
				GroupBox1.Visible = False
			End If
			If leggo("Plistordine").ToString <> "" Then PlistOrdine = leggo("Plistordine").ToString Else PlistOrdine = ""
			If IsNumeric(leggo("Tara3")) Then TaraCRT = CDec(leggo("Tara3")) Else TaraCRT = 1 'Memorizzo la tara del cartone e se non è stata inserita la metto = a 1 kg
			'End If
			If IsNumeric(leggo("RapportocrtL")) Then RapportoCartone = CDec(leggo("RapportocrtL")) Else RapportoCartone = 0
			'If RapportoCartone <> 0 Then
			Select Case TxtUdm.Text
				Case leggo("UDML").ToString
					If IsNumeric(leggo("RappUDML")) Then
						RapportoColliQuantita = CDec(RapportoCartone / CDec(leggo("RappUDML")))
						RapportoUdmPeso = CDec(leggo("RappUDML"))
						If IsNumeric(leggo("Tara1")) Then TaraUnitadiMisura = CDec(leggo("Tara1"))
					End If

				Case leggo("Conf").ToString
					If IsNumeric(leggo("RapportoCONFL")) Then
						RapportoColliQuantita = CDec(RapportoCartone / CDec(leggo("RapportoCONFL")))
						RapportoUdmPeso = CDec(leggo("RapportoCONFL"))
						If IsNumeric(leggo("Tara2")) Then TaraUnitadiMisura = CDec(leggo("Tara2"))
					End If
				Case leggo("Crt").ToString
					If IsNumeric(leggo("RapportoCRTL")) Then
						RapportoColliQuantita = CDec(RapportoCartone / CDec(leggo("RapportoCRTL")))
						RapportoUdmPeso = CDec(leggo("RapportoCRTL"))
						'La tara del cartone la ho già presa
					End If

			End Select
			'End If
			If RapportoColliQuantita <> 0 Then BtPacking.Text = RapportoColliQuantita.ToString

			'  BtPacking.Text = leggo("Packing").ToString
			TxtItem.Text = leggo("Idriga").ToString
			TxtCamion.Text = leggo("Camion").ToString
			BtQuantita.Text = leggo("QuantMagazzino").ToString
			BtPallet.Text = leggo("Pallet").ToString










			If IsNumeric(leggo("ColliMagazzino")) Then 'Tre righe colli/quantità automatico
				If CDec(leggo("Collimagazzino")) <> 0 Then
					BTColli.Text = leggo("ColliMagazzino").ToString
					Dim rapportoTMP As Decimal = 0
					If IsNumeric(BTColli.Text) And IsNumeric(BtQuantita.Text) Then rapportoTMP = CDec(BtQuantita.Text) / CDec(BTColli.Text)
					If RapportoColliQuantita <> 0 And rapportoTMP <> 0 And rapportoTMP <> RapportoColliQuantita Then
						TxtAvviso.Text = "Il Rapporto COLLO/UDM non è conforme a quello previsto "
						TxtAvviso.Visible = True
					End If
				End If
			End If
		End If
		leggo.Close()
		If BtPacking.Text = "" Then
			If CommRapportoStorico.Connection.State = ConnectionState.Closed Then CommRapportoStorico.Connection.Open()
			CommRapportoStorico.Parameters("@DataInizio").Value = Today.AddYears(-2)
			CommRapportoStorico.Parameters("@UDM").Value = TxtUdm.Text
			CommRapportoStorico.Parameters("@Articolo").Value = NumArticolo
			Dim packingTMP As String = ""
			If Not IsNothing(CommRapportoStorico.ExecuteScalar()) Then packingTMP = CommRapportoStorico.ExecuteScalar.ToString
			If TxtUdm.Text = "KG." Then BtPacking.Text = packingTMP Else BtPacking.Text = CInt(packingTMP).ToString

		End If
		If BtPallet.Text = "" And NumPallet <> 0 Then
			BtPallet.Text = NumPallet.ToString
			Aggiorno_pallet(BtPallet.Text)
		End If
		TxtScansione.SelectAll()
		TxtScansione.Focus()


		DsLotti1.Clear()
		AdapterLottoEsistente.SelectCommand.Parameters("@idordine").Value = NumOrdine
		AdapterLottoEsistente.SelectCommand.Parameters("@Idprodotto").Value = NumArticolo
		AdapterLottoEsistente.SelectCommand.Parameters("@IdDettaglioOrdine").Value = IdDettaglioOrdine
		AdapterLottoEsistente.Fill(DsLotti1)

		C1TrueDBGrid1.Refresh()
		Dim evvv As New Object
		Dim eeee = New System.Windows.Forms.MouseEventArgs(Windows.Forms.MouseButtons.None, 0, 0, 0, 0)

		C1TrueDBGrid1_MouseUp(evvv, eeee)

		Dim riga As DataRow
		For Each riga In DsLotti1.TabellaLotti.Rows
			riga("Q_Udm_Ord") = CDec(DettagliUDM.ConvertoValoriQuantita(riga("UDM").ToString, TxtUdm.Text, CDec(riga("Quantita"))))
		Next
		Calcolo_Totali()
	End Sub
	Private Sub interpretoCodici(CodiceBarre As String)
		Non_e_QRCODE = True


		If CodiceBarre.First <> "$" Then Exit Sub
		If CodiceBarre = "" Then
			TxtScansione.SelectAll()
			TxtScansione.Focus()
			Exit Sub
		End If
		If Not My.Computer.Network.IsAvailable Then
			MsgBox("Manca la Connessione della Rete")
			TxtScansione.SelectAll()
			TxtScansione.Focus()
			Exit Sub
		End If
		Me.Text = TxtScansione.Text
		TxtScansione.Text = ""
		If CodiceBarre.ToUpper = "$SALVA" Then
			Salvo_Riga_Ordine()
			Salvo_Lotti_del_Prodotto()
			AzzeroTutto()
			TxtScansione.SelectAll()
			TxtScansione.Focus()

			Exit Sub
		End If
		If CodiceBarre.ToUpper = "$CANCELLA" Then
			cancello_riga_Lotto()
			TxtScansione.SelectAll()
			TxtScansione.Focus()

			Exit Sub
		End If
		' Vedo se il qrcode e' quello della Vermar o del fornitore

		If CodiceBarre.Length > 14 Then
			Dim spezzoQRcode() As String = CodiceBarre.Split("!")
			If spezzoQRcode(0) = CodiceBarre Then 'Non ho trivato FNC ma non so ancora se il codice èGS1 fornitoree o quealcos'altro
				UDMLottoGS1Fornitore = ""
				If CodiceBarre.LastIndexOf("10") <> -1 Then  ' non so se il lotto è alla fine (se fosse nel mezzo afrebbe spezzato il codice
					Dim lotto As String = CodiceBarre.Substring(CodiceBarre.LastIndexOf("10") + 2)
					'Adesso devo andare a vedere se quello che ho trovato è un lotto oppure no
					If SqlComRicercaLotto.Connection.State = ConnectionState.Closed Then SqlComRicercaLotto.Connection.Open()
					SqlComRicercaLotto.Parameters("@Lotto").Value = lotto
					SqlComRicercaLotto.Parameters("@DataInventario").Value = DataInventario
					Dim leggo As SqlClient.SqlDataReader = SqlComRicercaLotto.ExecuteReader
					leggo.Read()
					If leggo.HasRows = False Then
						leggo.Close()
						TxtAvviso.Text = "Il lotto " & lotto & " Non è stato trovato. I Dati del GS1 non possono essere acquisiti"
						TxtAvviso.Visible = True
						Exit Sub 'il lotto non era alla fine dunque non esiste nel codice scannerizzato
					End If
					If leggo("Idprodotto") <> NumArticolo Then
						leggo.Close()
						Exit Sub
					Else
						UDMLottoGS1Fornitore = leggo("UDM").ToString
						leggo.Close()
					End If
					'provo ad aggiungere i dati nel gs1 del fornitore che mancavano per renderlo = a quello della vermar (a parte la quantità)
					CodiceBarre = CodiceBarre & FNC & "240" & NumArticolo.ToString & FNC
					If UDMLottoGS1Fornitore <> "" Then CodiceBarre = CodiceBarre & "90" & UDMLottoGS1Fornitore & FNC
					CodiceBarre = CodiceBarre & "91" & "0"
				End If
			Else
				If Cerco_Elemento(spezzoQRcode, "90") = False And Cerco_Elemento(spezzoQRcode, "91") = False Then 'Senon ci sono questi AI è senz'altro un QR del Forntoe
					'Cerco il Lotto e vado a vewdere se esiste
					Non_e_QRCODE = False ' è un QRCODE VERMAR
					Dim StringaTMP As String = ""
					For Each StringaTMP In spezzoQRcode
						If StringaTMP.LastIndexOf("10") <> -1 Then  ' HO TROVATO L'ai DEL LOTTO
							Dim lotto As String = StringaTMP.Substring(StringaTMP.LastIndexOf("10") + 2)
							'Adesso devo andare a vedere se quello che ho trovato è un lotto oppure no
							If SqlComRicercaLotto.Connection.State = ConnectionState.Closed Then SqlComRicercaLotto.Connection.Open()
							SqlComRicercaLotto.Parameters("@Lotto").Value = lotto
							SqlComRicercaLotto.Parameters("@DataInventario").Value = DataInventario
							Dim leggo As SqlClient.SqlDataReader = SqlComRicercaLotto.ExecuteReader
							leggo.Read()
							If leggo.HasRows = False Then
								leggo.Close()
								Exit Sub 'il lotto non era alla fine dunque non esiste nel codice scannerizzato
							End If
							If leggo("Idprodotto") <> NumArticolo Then
								leggo.Close()
								Exit Sub
							Else
								UDMLottoGS1Fornitore = leggo("UDM").ToString
								leggo.Close()
							End If
							'provo ad aggiungere i dati nel gs1 del fornitore che mancavano per renderlo = a quello della vermar (a parte la quantità)
							CodiceBarre = CodiceBarre & FNC & "240" & NumArticolo.ToString & FNC
							If UDMLottoGS1Fornitore <> "" Then CodiceBarre = CodiceBarre & "90" & UDMLottoGS1Fornitore & FNC
							CodiceBarre = CodiceBarre & "91" & "0"
						End If
					Next
				End If

			End If

		End If

		Dim RigaAi() As DataRow = Nothing
		'Per prima cosa vedo 
		' If NumOrdine = 0 Then Exit Sub
		Select Case CodiceBarre.Substring(0, 1).ToUpper

			Case "$" ' è un codice barre GS1 (potrebe essere anche un altro tipo ma non darà risultati)
				CodiceBarre = CodiceBarre.Substring(1) ' Tolgo l'identificativo
				Select Case CodiceBarre.Substring(0, 2)
					Case "00" 'Questo indica che il primo AI è dello SSCC ed è lungo 18
						RigaAi = AIDatatable.Select("AI = '" & CodiceBarre.Substring(0, 2) & "'")
						RigaAi(0).Item("ValoreAI") = CodiceBarre.Substring(0, CInt(RigaAi(0).Item("LunghezzaMax")))
						CodiceBarre = CodiceBarre.Substring(CInt(RigaAi(0).Item("LunghezzaMax")) + 2)

					Case "01", "02" 'Questo indica che il primo AI è EAN14 ed è lungo 14
						RigaAi = AIDatatable.Select("AI = '" & CodiceBarre.Substring(0, 2) & "'")
						If RigaAi.Length <> 0 Then
							'' riga = ElementiAI.NewRow
							''riga.Item("AI") = CodiceBarre.Substring(0, 2)
							RigaAi(0).Item("ValoreAI") = CodiceBarre.Substring(2, CInt(RigaAi(0).Item("LunghezzaMax")))
							'questo valore è lungo 14 deve essere trasformato in EAN13 ===========================
							'' riga.Item("Descrizione") = RigaAi(0).Item("Descrizione").ToString
							CodiceBarre = CodiceBarre.Substring(CInt(RigaAi(0).Item("LunghezzaMax")) + 2)
							''   ElementiAI.Rows.Add(riga)
						End If
					Case Else
						If Not IsNumeric(CodiceBarre) Then ' questo significa che non è un numero ma se si arriva qui non è nbeppure un dato che inizia con AI corretto
							If CodiceBarre.IndexOf(FNC) = -1 Then Exit Sub
						End If
						Dim commando As New SqlClient.SqlCommand
						commando.Connection = SqlConnection1
						Select Case Len(CodiceBarre)
							Case > 5
								If IsNumeric(CodiceBarre) Then
									' e' un numero di ordine

									If NumOrdine = 0 Then
										NumPallet = 0
										commando.CommandText = "SELECT ArchivioFornitori.Descrizione_1, OrdineCliente.dataConsegna, OrdineCliente.luogoConsegna, OrdineCliente.Riferimento, OrdineCliente.Responsabile, TabellaPassword.Email FROM OrdineCliente INNER JOIN ArchivioFornitori ON OrdineCliente.IdCliente = ArchivioFornitori.IDFornitore INNER JOIN TabellaPassword ON OrdineCliente.Responsabile = TabellaPassword.NomeCompleto WHERE (OrdineCliente.IdOrdine =" & CodiceBarre & ")"


										If commando.Connection.State = ConnectionState.Closed Then commando.Connection.Open()
										Dim leggo As SqlClient.SqlDataReader = commando.ExecuteReader
										leggo.Read()

										If leggo.HasRows Then
											TxtOrdineNum.Text = CodiceBarre
											NumOrdine = CInt(CodiceBarre)
											TxtRiferimento.Text = leggo("riferimento").ToString
											TxtCliente.Text = leggo("Descrizione_1").ToString
											TxtDataConsegna.Text = CDate(leggo("DataConsegna")).ToShortDateString
											TxtLuogoConsegna.Text = leggo("Luogoconsegna").ToString
											Responsabile_Ordine = leggo("Responsabile").ToString
											Email_Responsabile_Ordine = leggo("Email")
											BTsalva.Enabled = True
											BTsalva.BackColor = Color.LimeGreen
											AdapterContainerOrdini.SelectCommand.Parameters("@IdORDINE").Value = NumOrdine
											AdapterContainerOrdini.Fill(DsContainerOrdine1)
											AdapterOrdineDettagli.SelectCommand.Parameters("@Ordine").Value = NumOrdine
											DsOrdineDettagli1.Clear()
											AdapterOrdineDettagli.Fill(DsOrdineDettagli1)
											C1TrueDBGrid2.FetchRowStyles = True
											C1TrueDBGrid2.Refresh()
										End If
										leggo.Close()
									End If
									TxtScansione.SelectAll()
									TxtScansione.Focus()

									Exit Sub
								End If


							Case <= 5
								Non_e_QRCODE = True 'Non è un QRCODE
								CaricoProdotto(CodiceBarre)
								TxtScansione.SelectAll()
								TxtScansione.Focus()

								Exit Sub

						End Select



				End Select

		End Select

		'A questo punto arrivo con un codice barre senza codice EAN e con tutte le altre informazioni che devo tirar fuori
		' If NumArticolo = 0 Then Exit Sub
		While CodiceBarre.Trim.Length > 0
			RigaAi = AIDatatable.Select("AI = '" & CodiceBarre.Substring(0, 2) & "'")
			Select Case CodiceBarre.Substring(0, 2).Trim
				Case "10" 'E' il lotto 
					''  riga = ElementiAI.NewRow
					RigaAi(0).Item("AI") = CodiceBarre.Substring(0, 2)
					Dim lunghezza As Integer = CodiceBarre.IndexOf(FNC)
					If lunghezza = -1 Then
						RigaAi(0).Item("ValoreAI") = CodiceBarre.Substring(2).Replace("'", "-") ' Non è stato indicato l'FNC perchè è l'ultimo
						CodiceBarre = ""
					Else
						RigaAi(0).Item("ValoreAI") = CodiceBarre.Substring(2, lunghezza - 2).Replace("'", "-")
						CodiceBarre = CodiceBarre.Substring(CodiceBarre.IndexOf(FNC) + 1)
					End If
						''  riga.Item("Descrizione") = RigaAi(0).Item("Descrizione").ToString
					  ''  ElementiAI.Rows.Add(riga)

				Case "11", "12", "13", "15", "17" 'Rispettivamente sono le date di produzione, Scadenza Fattura, Data Imballaggio, Consumare entro, scadenza
					If RigaAi.Length <> 0 Then
						''  riga = ElementiAI.NewRow
						''  riga.Item("AI") = CodiceBarre.Substring(0, 2)
						CodiceBarre = CodiceBarre.Substring(2) ' tolgo l'AI in modo da lavorare meglio sulla data
						Dim scadenza As String = CodiceBarre.Substring(0, CInt(RigaAi(0).Item("LunghezzaMax")))
						RigaAi(0).Item("ValoreAI") = scadenza.Substring(4, 2) & "/" & scadenza.Substring(2, 2) & "/" & scadenza.Substring(0, 2)
						''  riga.Item("Descrizione") = RigaAi(0).Item("Descrizione").ToString
						CodiceBarre = CodiceBarre.Substring(CInt(RigaAi(0).Item("LunghezzaMax"))) ' cancello i dati dell'AI appena ottenuto
						'' ElementiAI.Rows.Add(riga)
					End If
				Case "31" 'E' il Peso Netto 
					RigaAi = AIDatatable.Select("AI like '" & CodiceBarre.Substring(0, 4) & "'") 'Devo ripetere la ricerca perchè l'AI è lungo 4 Prendo tutti i decimali previsti per il peso (da 0 a 6)
					Dim NumDecimali As Integer = CInt(RigaAi(0).Item("AI").ToString.Substring(3, 1))
					Dim lunghezza As Integer = CInt(RigaAi(0).Item("LunghezzaMax"))
					CodiceBarre = CodiceBarre.Substring(4) ' tolgo l'AI del peso
					Dim pippo As String = CodiceBarre.Substring(0, lunghezza - NumDecimali)
					If NumDecimali <> 0 Then RigaAi(0).Item("ValoreAI") = CodiceBarre.Substring(0, CInt(RigaAi(0).Item("LunghezzaMax")) - NumDecimali) & "." & CodiceBarre.Substring(CInt(RigaAi(0).Item("LunghezzaMax")) - NumDecimali, NumDecimali) Else RigaAi(0).Item("ValoreAI") = CodiceBarre.Substring(0, CInt(RigaAi(0).Item("LunghezzaMax")))
					CodiceBarre = CodiceBarre.Substring(CInt(RigaAi(0).Item("LunghezzaMax"))) ' cancello i dati dell'AI appena ottenuto

				Case "33" 'E' il peso lordo

					RigaAi = AIDatatable.Select("AI like '" & CodiceBarre.Substring(0, 4) & "'") 'Devo ripetere la ricerca perchè l'AI è lungo 4 Prendo tutti i decimali previsti per il peso (da 0 a 6)
					Dim NumDecimali As Integer = CInt(RigaAi(0).Item("AI").ToString.Substring(3, 1))

					CodiceBarre = CodiceBarre.Substring(4) ' tolgo l'AI del peso

					'  If NumDecimali <> 0 Then TxtPesoLordo.Text = CodiceBarre.Substring(0, CInt(RigaAi(0).Item("LunghezzaMax")) - NumDecimali) & "." & CodiceBarre.Substring(CInt(RigaAi(0).Item("LunghezzaMax")) - NumDecimali, NumDecimali) Else riga.Item("ValoreAI") = CodiceBarre.Substring(0, CInt(RigaAi(0).Item("LunghezzaMax")))
					CodiceBarre = CodiceBarre.Substring(CInt(RigaAi(0).Item("LunghezzaMax"))) ' cancello i dati dell'AI appena ottenuto


				Case "30", "37" 'Numero dei Colli Variabile o fissi
					'' riga = ElementiAI.NewRow
					'' riga.Item("AI") = CodiceBarre.Substring(0, 2)
					Dim lunghezza As Integer = CodiceBarre.IndexOf(FNC)
					RigaAi(0).Item("ValoreAI") = CodiceBarre.Substring(2, lunghezza - 2)
					''  riga.Item("Descrizione") = RigaAi(0).Item("Descrizione").ToString
					CodiceBarre = CodiceBarre.Substring(CodiceBarre.IndexOf(FNC) + 1)
					  ''  ElementiAI.Rows.Add(riga)

				Case "40" 'Numero Ordine Acquisto Cliente (400) e numero di spedizione (401)
					'' RigaAi = AIDataTable.Select("AI = '" & CodiceBarre.Substring(0, 3) & "'") 'Devo ripetere la ricerca perchè l'AI è lungo 3
					'' riga = ElementiAI.NewRow
					'' riga.Item("AI") = CodiceBarre.Substring(0, 3)
					Dim lunghezza As Integer = CodiceBarre.IndexOf(FNC)
					''   riga.Item("ValoreAI") = CodiceBarre.Substring(3, lunghezza - 3)
					''   riga.Item("Descrizione") = RigaAi(0).Item("Descrizione").ToString
					CodiceBarre = CodiceBarre.Substring(CodiceBarre.IndexOf(FNC) + 1)
					  ''  ElementiAI.Rows.Add(riga)

				Case "24" 'Indicazioni Aggiuntive (240) e CodiceBarre Prodotto del Cliente (241)
					RigaAi = AIDatatable.Select("AI = '" & CodiceBarre.Substring(0, 3) & "'") 'Devo ripetere la ricerca perchè l'AI è lungo 3
					''  riga = ElementiAI.NewRow
					'' riga.Item("AI") = CodiceBarre.Substring(0, 3)
					CodiceBarre = CodiceBarre.Substring(3) ' tolgo l'AI
					Dim lunghezza As Integer = CodiceBarre.IndexOf(FNC)
					Dim righe() As DataRow = DataView1.Table.Select("progressivo = " & CodiceBarre.Substring(0, lunghezza))
					If righe.Length <> 0 Then
						RigaAi(0).Item("ValoreAI") = CodiceBarre.Substring(0, lunghezza)
						If TxtIdArticolo.Text = "" Then
							CaricoProdotto(RigaAi(0).Item("ValoreAI"))
						ElseIf TxtIdArticolo.Text <> RigaAi(0).Item("ValoreAI").ToString Then ' ho scelto un nuovo prodotto
							'devo salvare il prodotto precedente
							Salvo_Riga_Ordine()
							Salvo_Lotti_del_Prodotto()
							CaricoProdotto(RigaAi(0).Item("ValoreAI"))
							TxtIdArticolo.Text = RigaAi(0).Item("ValoreAI").ToString
							'CodiceBarre = ""
							TxtScansione.SelectAll()
							TxtScansione.Focus()

						End If
					Else
						TxtAvviso.Text = "Il prodotto: " & CodiceBarre.Substring(0, lunghezza) & "Non risulta nell'ordine (o nella lista dei prodotti a fianco)"
						For Each riga In AIDatatable.Rows
							riga("ValoreAi") = System.DBNull.Value
						Next
						Exit Sub
					End If
					''  riga.Item("Descrizione") = RigaAi(0).Item("Descrizione").ToString
					CodiceBarre = CodiceBarre.Substring(CodiceBarre.IndexOf(FNC) + 1)
					  ''  ElementiAI.Rows.Add(riga)

				Case "42" 'Paese di Origine 422(ISO Numerico) e paese di lavorazione 423
					RigaAi = AIDatatable.Select("AI = '" & CodiceBarre.Substring(0, 3) & "'")
					CodiceBarre = CodiceBarre.Substring(3) ' tolgo l'AI
					RigaAi(0).Item("ValoreAI") = CodiceBarre.Substring(0, CInt(RigaAi(0).Item("LunghezzaMax")))
					CodiceBarre = CodiceBarre.Substring(CInt(RigaAi(0).Item("LunghezzaMax"))) ' cancello i dati dell'AI appena ottenuto
					 ''   Txtdopo.AppendText(Chr(13) & RigaAi(0).Item("Descrizione").ToString & " - " & RigaAi(0).Item("ValoreAI").ToString & vbCrLf)

				Case "90" ' Valori concordati NOI LO UTILIZIAMO PER L'UDM

					Dim lunghezza As Integer = CodiceBarre.IndexOf(FNC)
					If lunghezza = -1 Then
						RigaAi(0).Item("ValoreAI") = CodiceBarre.Substring(2) ' Non è stato indicato l'FNC perchè è l'ultimo
						CodiceBarre = ""
					Else
						RigaAi(0).Item("ValoreAI") = CodiceBarre.Substring(2, lunghezza - 2)
						CodiceBarre = CodiceBarre.Substring(CodiceBarre.IndexOf(FNC) + 1)
					End If
						'riga.Item("Descrizione") = RigaAi(0).Item("Descrizione").ToString
						'' ElementiAI.Rows.Add(riga)

				Case "91" ' Valori concordati NOI LO UTILIZZIAMO PER LA QUANTITA    

					Dim lunghezza As Integer = CodiceBarre.IndexOf(FNC)
					If lunghezza = -1 Then
						RigaAi(0).Item("ValoreAI") = CodiceBarre.Substring(2) ' Non è stato indicato l'FNC perchè è l'ultimo
						CodiceBarre = ""
					Else
						RigaAi(0).Item("ValoreAI") = CodiceBarre.Substring(2, lunghezza - 2)
						CodiceBarre = CodiceBarre.Substring(CodiceBarre.IndexOf(FNC) + 1)
					End If
						'riga.Item("Descrizione") = RigaAi(0).Item("Descrizione").ToString

				Case "92", "93", "94", "95", "96", "97", "98", "99" ' Valori concordati 
					''  riga = ElementiAI.NewRow
					''  riga.Item("AI") = CodiceBarre.Substring(0, 2)
					Dim lunghezza As Integer = CodiceBarre.IndexOf(FNC)
					If lunghezza = -1 Then
						'riga.Item("ValoreAI") = CodiceBarre.Substring(2) ' Non è stato indicato l'FNC perchè è l'ultimo
						CodiceBarre = ""
					Else
						' riga.Item("ValoreAI") = CodiceBarre.Substring(2, lunghezza - 2)
						CodiceBarre = CodiceBarre.Substring(CodiceBarre.IndexOf(FNC) + 1)
					End If
					'riga.Item("Descrizione") = RigaAi(0).Item("Descrizione").ToString
					'' ElementiAI.Rows.Add(riga)
				Case Else
					Exit While
			End Select

		End While
		'Prendo il Rapport quantità Lotti della scannerizzazione
		If RapportoColliQuantita = 0 Then
			Dim Quantita As Decimal = 0
			Dim collo As Decimal = 1
			If IsNumeric(TxtColli.Text) Then collo = CDec(TxtColli.Text)
			If IsNumeric(TxtQuantOrdine.Text) Then Quantita = CDec(TxtQuantOrdine.Text)
			RapportoColliQuantita = Quantita / collo
		End If
		'Carico_Giacenze(CInt(TxtArticolo.Text))
		'inserisco i risultati nel textbox
		''  Txtdopo.Text = ""
		'' For Each riga In ElementiAI.Rows
		''  Txtdopo.AppendText(Chr(13) & riga("AI").ToString & " - " & riga("Descrizione").ToString & " - " & riga("ValoreAI").ToString & vbCrLf)
		'' Next
		'A questo punto nella tabella aIDatatable ho tutti gli elementi del QR e posso iniziare a inserirli
		Ho_Acquisito_il_QR(AIDatatable)
		TxtScansione.SelectAll()
		TxtScansione.Focus()

	End Sub

	Private Sub BTColli_Click(sender As Object, e As EventArgs) Handles BTColli.Click
		TxtAvviso.Visible = False
		If NumArticolo = 0 Then Exit Sub
		'If C1TrueDBGrid1(C1TrueDBGrid1.Row, "Lotto").ToString = "" Then
		'TxtAvviso.Text = "ATTENZIONE: Per inserire/modificare I Colli occorre aver scansionato almento un lotto"
		'TxtAvviso.Visible = True
		'TxtScansione.Focus()
		'Exit Sub

		'  End If
		If DsLotti1.TabellaLotti.Rows.Count > 1 Then
			If C1TrueDBGrid1(C1TrueDBGrid1.Row, "Quantita").ToString.Replace("-", "") <> BtQuantita.Text Then
				TxtAvviso.Text = "Occorre Selezionare uno dei Lotti"
				TxtAvviso.Visible = True
				Exit Sub
			End If
		End If
		If Not IsNumeric(BtPacking.Text) Then
			TxtAvviso.Text = "ATTENZIONE: Per inserire/modificare I Colli occorre che vi sia inserito un rapporto COLLO/UDM"
			TxtAvviso.Visible = True
			TxtScansione.Focus()
			Exit Sub
		End If


		Dim calcolatore As New Calc


		calcolatore.ShowDialog()
		If calcolatore.Risultato <> "" Then
			BTColli.Text = calcolatore.Risultato
			'Controllo che l'udm dei lotti sia = all'udm dell'ordine+
			'Ora controllo che la quantità diviso il packuing sua un numero intero
			If IsNumeric(BtQuantita.Text) Then
				If CInt(CDec(BtQuantita.Text) / CDec(BtPacking.Text)) = CDec(CDec(BtQuantita.Text) / CDec(BtPacking.Text)) Then
					BtQuantita.Text = DettagliUDM.ConvertoValoriQuantita(TxtUdm.Text, C1TrueDBGrid1.Columns("UDM").Text, CDec((BTColli.Text)) * CDec(BtPacking.Text))
					BtQuantita.Text = BtQuantita.Text.Replace(".", ",")
				End If
			End If
			If DsLotti1.TabellaLotti.Rows.Count <> 0 Then

				'BtQuantita.Text = CDec(BTColli.Text) * RapportoColliQuantita
				If C1TrueDBGrid1.RowCount <> 0 Then
					C1TrueDBGrid1.Columns("Colli").Text = CDec(BTColli.Text) * -1
					C1TrueDBGrid1.Columns("Quantita").Text = CDec(BtQuantita.Text) * -1
					C1TrueDBGrid1.Columns("Q Udm Ord").Value = DettagliUDM.ConvertoValoriQuantita(C1TrueDBGrid1(C1TrueDBGrid1.Row, "UDM").ToString, TxtUdm.Text, C1TrueDBGrid1.Columns("Quantita").Value)

				End If
			End If
		End If
		calcolatore.Dispose()
		Calcolo_Totali()
		'CalcoloPesi()
		TxtScansione.SelectAll()
		TxtScansione.Focus()
	End Sub

	Private Sub Ho_Acquisito_il_QR(datiQR As DataTable)
		'Azzoro tutti i campi del lotto
		If NumArticolo = 0 Then
			Exit Sub
		End If
		Dim quantitaOrdineResidua As Decimal = 0
		' If IsNumeric(TxtQuantOrdine.Text) Then quantitaOrdineResidua = CDec(TxtQuantOrdine.Text)
		Dim totalequantitalotti As Decimal = 0
		Dim riga As DataRow
		For Each riga In DsLotti1.TabellaLotti
			If riga.RowState <> DataRowState.Deleted Then
				If IsNumeric(riga("Q_Udm_Ord")) Then totalequantitalotti = totalequantitalotti + Math.Abs(CDec(riga("Q_Udm_Ord")))
			End If
		Next
		' quantitaOrdineResidua = quantitaOrdineResidua - totalequantitalotti
		TxtLotto.Text = ""
		TxTUDMLotto.Text = ""
		TxtQuantitaLotto.Text = ""
		TxtScadenza.Text = ""
		TxtColli.Text = ""
		BTColli.Text = ""
		BtQuantita.Text = ""
		' BtPacking.Text = ""
		Dim rigaai() As DataRow

		rigaai = datiQR.Select("AI = '" & 240.ToString & "'") 'Ho il codice del prodotto Vermar
		If rigaai.Length = 0 Then Exit Sub
		If Not IsNumeric(rigaai(0).Item("ValoreAi")) Then rigaai(0).Item("Valoreai") = NumArticolo
		rigaai = datiQR.Select("AI = '" & 90.ToString & "'")
		If rigaai(0).Item("ValoreAi").ToString = "" Then
			If UDMLottoGS1Fornitore <> "" Then rigaai(0).Item("Valoreai") = UDMLottoGS1Fornitore Else rigaai(0).Item("Valoreai") = TxtUdm.Text
		End If
		rigaai = datiQR.Select("AI = '" & 91.ToString & "'")
		If Not IsNumeric(rigaai(0).Item("valoreaI")) Then rigaai(0).Item("Valoreai") = 0
		'Dim articololotto As Decimal = CDec(rigaai(0).Item("ValoreAI"))
		' If articololotto <> NumArticolo Then Exit Sub 'L'articolo del QR non è l'articolo cercato
		rigaai = datiQR.Select("AI = '" & 10.ToString & "'") 'Ho il lotto
		If rigaai.Length = 0 Then Exit Sub
		Dim lotto As String = rigaai(0).Item("ValoreAI").ToString
		If TxtLotto.Text = "" Then
			If TxtLotto.Text <> "" Then

			End If
			For Each riga In datiQR.Rows
				If riga("ValoreAI").ToString <> "" Then
					Select Case riga("AI").ToString
						Case "10" ' è il lotto
							TxtLotto.Text = riga("ValoreAi").ToString
						Case "90" ' è l'UDM
							TxTUDMLotto.Text = riga("valoreAI").ToString
						Case "91" ' è la quantità
							' DettagliUDM.ConvertoValoriQuantita(TxTUDMLotto.Text, TxtUdm.Text, CDec(riga("ValoreAI")))
							'  If DettagliUDM.ConvertoValoriQuantita(TxTUDMLotto.Text, TxtUdm.Text, CDec(riga("ValoreAI"))) > quantitaOrdineResidua Then riga("ValoreAI") = quantitaOrdineResidua
							'riga("ValoreAI") = quantitaOrdineResidua
							quantitaOrdineResidua = quantitaOrdineResidua - CDec(DettagliUDM.ConvertoValoriQuantita(TxTUDMLotto.Text, TxtUdm.Text, CDec(riga("ValoreAI"))))
							'  If CDec(riga("ValoreAI")) > quantitaOrdine Then riga("ValoreAI") = quantitaOrdine
							If totalequantitalotti > CDec(TxtQuantOrdine.Text) Then
								TxtAvviso.Text = "La quantità scannerizzata è maggiore della quantità ordinata"
							End If
							TxtQuantitaLotto.Text = riga("valoreAI").ToString
						Case "15" ' è Data Consumo preferibile 
							TxtScadenza.Text = riga("valoreAI").ToString
						Case "17" ' è la scadenza
							TxtScadenza.Text = riga("valoreAI").ToString
						Case "30", "37" ' sono i colli
							TxtColli.Text = riga("valoreAI").ToString
					End Select
				End If
			Next
			If TxtColli.Text = "" Then TxtColli.Text = 1
			If CDec(TxtQuantitaLotto.Text) = 0 Then TxtColli.Text = 0
		End If

		' Exit Sub
		' If TxtLotto.Text <> "" Then 'Vuol dire che non ho già scannerizzato in precedenza un QR
		'vedo se il lotto che ho acquisito è già inseirto
		'Per prima cosa lo inserisco nel grid
		rigaai = DsLotti1.TabellaLotti.Select("Lotto = '" & TxtLotto.Text & "'")
		If rigaai.Length = 0 Then 'Il lotto non è ancora stato inserito
			riga = DsLotti1.TabellaLotti.NewRow
			riga("Lotto") = TxtLotto.Text
			riga("LottoFornitore") = TxtLotto.Text
			riga("UDM") = TxTUDMLotto.Text
			riga("Quantita") = (CDec(TxtQuantitaLotto.Text) * -1)
			riga("IddettagliOrdineCli") = IdDettaglioOrdine
			If IsDate(TxtScadenza.Text) Then riga("DataScadenza") = CDate(TxtScadenza.Text)
			If IsDate(TxtScadenza.Text) Then riga("Scadenza") = CDate(TxtScadenza.Text)
			riga("Colli") = CInt(TxtColli.Text) * -1
			riga("Data") = Today.ToShortDateString
			riga("Idprodotto") = NumArticolo
			riga("IdOrdine") = NumOrdine
			riga("FlagCaricoScarico") = "S"
			riga("FlagMoltiplica") = -1
			riga("Societa") = 0
			If BtMRN.Text <> "" Then riga("IM7") = BtMRN.Text Else riga("IM7") = System.DBNull.Value
			riga("Operatore") = Environment.UserName.ToLower '& Today.ToShortDateString
			If TxtUdm.Text <> "" Then riga("Q_Udm_Ord") = DettagliUDM.ConvertoValoriQuantita(riga("UDM").ToString, TxtUdm.Text, riga("Quantita"))
			DsLotti1.TabellaLotti.Rows.Add(riga)
			C1TrueDBGrid1.Row = DsLotti1.TabellaLotti.Rows.Count - 1
			C1TrueDBGrid1.Refresh()
		Else

			rigaai(0).Item("Quantita") = CDec(rigaai(0).Item("Quantita")) + (CDec(TxtQuantitaLotto.Text) * -1)
			If IsNumeric(rigaai(0).Item("Colli")) Then rigaai(0).Item("Colli") = CDec(rigaai(0).Item("Colli")) + (CDec(TxtColli.Text) * -1) Else rigaai(0).Item("Colli") = CDec(TxtColli.Text) * -1
			If TxtUdm.Text <> "" Then rigaai(0).Item("Q_Udm_Ord") = DettagliUDM.ConvertoValoriQuantita(rigaai(0).Item("UDM").ToString, TxtUdm.Text, CDec(rigaai(0).Item("Quantita")))
		End If
		Calcolo_Totali()
	End Sub
	Private Sub Calcolo_Totali()
		C1TrueDBGrid1.UpdateData()
		Dim totale As Decimal = 0
		Dim totcolli As Decimal = 0
		If DsLotti1.TabellaLotti.Rows.Count <> 0 Then 'kkk

			For Each riga In DsLotti1.TabellaLotti
				If riga.RowState <> DataRowState.Deleted Then
					If IsNumeric(riga("Q_Udm_Ord")) Then totale = totale + Math.Round(Math.Abs(CDec(riga("Q_Udm_Ord"))), 4)
					If IsNumeric(riga("colli")) Then totcolli = totcolli + Math.Round(Math.Abs(CDec(riga("colli"))))
				End If
			Next

			If totale <> 0 Then BtQuantita.Text = totale.ToString
			If totcolli <> 0 Then BTColli.Text = Math.Abs(totcolli).ToString
			If CDec(TxtQuantOrdine.Text) < totale Then
				TxtAvviso.Text = "Il Totale della quantità inserita è maggiore della quantità ordinata"
				TxtAvviso.Visible = True
			End If
		End If


		Dim righe() As DataRow = DsOrdineDettagli1.Tables(0).Select("IdPratica = " & IdDettaglioOrdine.ToString)
		If righe.Length > 0 Then
			If IsNumeric(BtQuantita.Text) Then righe(0).Item("QuantMagazzino") = BtQuantita.Text
			righe(0).Item("Colli") = BTColli.Text
			C1TrueDBGrid2.Refresh()
			Dim i As Integer = 0
			For i = 0 To C1TrueDBGrid2.RowCount
				C1TrueDBGrid2.Row = i
				If CInt(C1TrueDBGrid2(i, "IdPratica").ToString) = IdDettaglioOrdine Then
					C1TrueDBGrid2.FetchRowStyles = True
					C1TrueDBGrid2.MarqueeStyle = MarqueeEnum.HighlightRow
					Exit For
				End If
			Next
			'C1TrueDBGrid2.Row = CInt(righe(0).Item("IdRiga"))
			If IsNumeric(righe(0).Item("IdFatt")) Then
				TxtAvviso.Text = "ATTENZIONE: Prodotto già fatturato !!!!!!!!!!!!!!!!"
				TxtAvviso.Visible = True
			End If
		End If
		CalcoloPesi()
	End Sub

	Private Sub CalcoloPesi()

		If IsNumeric(BtQuantita.Text) Then PesoNetto = Math.Round(CDec(BtQuantita.Text) * RapportoUdmPeso, 4) Else PesoNetto = 0
		'if BTColli.Text = "" Then BTColli.Text = "0"
		'If BtQuantita.Text = "" Then BtQuantita.Text = "0"
		If TaraUnitadiMisura <> 0 Then
			If PesoNetto <> 0 Then Pesolordo = Math.Round(PesoNetto + (CDec(BtQuantita.Text) * TaraUnitadiMisura), 4)
		Else
			If PesoNetto <> 0 And BTColli.Text <> "" Then Pesolordo = Math.Round(PesoNetto + (CDec(BTColli.Text) * TaraCRT), 4)
		End If
		Me.Text = "PesoNetto = " & PesoNetto.ToString & " Peso Lordo = " & Pesolordo.ToString
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs)
		NumOrdine = 0

	End Sub

	Private Sub BtPacking_Click(sender As Object, e As EventArgs) Handles BtPacking.Click
		TxtAvviso.Visible = False
		If NumArticolo = 0 Then Exit Sub
		'If C1TrueDBGrid1(C1TrueDBGrid1.Row, "Lotto").ToString = "" Then
		'TxtAvviso.Text = "ATTENZIONE: Per inserire/modificare Il Packing occorre aver scansionato almento un lotto"
		'TxtAvviso.Visible = True
		'TxtScansione.Focus()
		'Exit Sub
		' End If
		'Dim packing As String = InputBox("Inserire il Packing del prodotto", "Inserire il formato NNxNNxNN")
		'If packing = "" Or packing.StartsWith("$") Then
		'Else
		'BtPacking.Text = packing
		'End If
		Dim calcolatore As New Calc
		calcolatore.EqualBtn.Visible = False
		calcolatore.OperatorPlusBtn.Visible = False
		calcolatore.OperatorSubtractBtn.Visible = False
		calcolatore.OperatorDivideBtn.Visible = False
		calcolatore.DecimalBtn.Visible = True
		calcolatore.OperatorMultiplyBtn.Visible = False
		calcolatore.OperatorX.Visible = False

		calcolatore.ShowDialog()
		If calcolatore.Risultato <> "" Then BtPacking.Text = calcolatore.Risultato
		If IsNumeric(BtPacking.Text) Then RapportoColliQuantita = CDec(BtPacking.Text)

		calcolatore.Dispose()
		TxtScansione.SelectAll()
		TxtScansione.Focus()
	End Sub

	Private Sub C1TrueDBGrid1_MouseUp(sender As Object, e As MouseEventArgs) Handles C1TrueDBGrid1.MouseUp
		BtMRN.Text = C1TrueDBGrid1(C1TrueDBGrid1.Row, "IM7").ToString
		If C1TrueDBGrid1.PointAt(e.X, e.Y) = C1.Win.C1TrueDBGrid.PointAtEnum.AtDataArea Then
			If IsNumeric(C1TrueDBGrid1(C1TrueDBGrid1.Row, "quantita").ToString) Then BtQuantita.Text = Math.Abs(CDec(C1TrueDBGrid1(C1TrueDBGrid1.Row, "quantita").ToString))
			BTColli.Text = C1TrueDBGrid1(C1TrueDBGrid1.Row, "Colli").ToString
		End If
		If C1TrueDBGrid1(C1TrueDBGrid1.Row, "UDM").ToString.ToLower = "kg." And IsNumeric(C1TrueDBGrid1(C1TrueDBGrid1.Row, "Colli").ToString) And IsNumeric(C1TrueDBGrid1(C1TrueDBGrid1.Row, "Quantita").ToString) Then
			If CDec(C1TrueDBGrid1(C1TrueDBGrid1.Row, "Quantita").ToString) / CDec(C1TrueDBGrid1(C1TrueDBGrid1.Row, "Quantita").ToString) = CInt(CDec(C1TrueDBGrid1(C1TrueDBGrid1.Row, "Quantita").ToString) / CDec(C1TrueDBGrid1(C1TrueDBGrid1.Row, "Quantita").ToString)) Then
				BtPacking.Text = Math.Abs(CInt(CDec(C1TrueDBGrid1(C1TrueDBGrid1.Row, "Quantita").ToString) / CDec(C1TrueDBGrid1(C1TrueDBGrid1.Row, "colli").ToString)))
				RapportoColliQuantita = CInt(BtPacking.Text)
			End If
		End If
		C1TrueDBGrid1.FetchRowStyles = True
		TxtScansione.SelectAll()
		TxtScansione.Focus()
	End Sub

	Private Sub BtProduzione_Click(sender As Object, e As EventArgs) Handles BtProduzione.Click
		If NumArticolo = 0 Then Exit Sub
		Dim Produzione As String = InputBox("Inserire il Paese di Produzione/Origine")
		If Produzione = "" Or Produzione.StartsWith("$") Then
		Else
			BtProduzione.Text = Produzione
		End If

		TxtScansione.SelectAll()
		TxtScansione.Focus()
	End Sub

	Private Sub BtQuantita_Click(sender As Object, e As EventArgs) Handles BtQuantita.Click
		TxtAvviso.Visible = False
		If NumArticolo = 0 Then Exit Sub
		'  If C1TrueDBGrid1(C1TrueDBGrid1.Row, "Lotto").ToString = "" Then
		' TxtAvviso.Text = "ATTENZIONE: Per inserire/modificare la Quantità occorre aver scansionato almento un lotto"
		' TxtAvviso.Visible = True
		' TxtScansione.Focus()
		'  Exit Sub
		'  End If
		If DsLotti1.TabellaLotti.Rows.Count > 1 Then
			If C1TrueDBGrid1(C1TrueDBGrid1.Row, "Quantita").ToString.Replace("-", "") <> BtQuantita.Text Then
				TxtAvviso.Text = "Occorre Selezionare uno dei Lotti"
				TxtAvviso.Visible = True
				Exit Sub
			End If
		End If
			If Not IsNumeric(BtPacking.Text) Then
			TxtAvviso.Text = "ATTENZIONE: Per inserire/modificare la quantità occorre che vi sia inserito un rapporto COLLO/UDM"
			TxtAvviso.Visible = True
			TxtScansione.Focus()
			Exit Sub
		End If
		RapportoColliQuantita = CDec(BtPacking.Text)
		Dim calcolatore As New Calc

		calcolatore.ShowDialog()
		If calcolatore.Risultato <> "" Then
			BtQuantita.Text = calcolatore.Risultato



			If C1TrueDBGrid1.RowCount <> 0 Then
				C1TrueDBGrid1.Columns("Colli").Value = (CInt(CDec(BtQuantita.Text) / RapportoColliQuantita)) * -1
				BTColli.Text = CInt(CDec(BtQuantita.Text) / RapportoColliQuantita).ToString
				If CDec(BtQuantita.Text) / CDec(BtPacking.Text) = CInt(CDec(BtQuantita.Text) / CDec(BtPacking.Text)) Then
					TxtAvviso.Visible = False

				Else
					TxtAvviso.Text = "La quantità inserita non è divisibile per avere un numero di lotti intero"
					TxtAvviso.Visible = True
				End If
				' C1TrueDBGrid1.Columns("Quantita").Value = CDec(BtQuantita.Text) * -1
				C1TrueDBGrid1.Columns("Quantita").Value = DettagliUDM.ConvertoValoriQuantita(TxtUdm.Text, C1TrueDBGrid1(C1TrueDBGrid1.Row, "UDM").ToString, CDec(BtQuantita.Text)) * -1
				If C1TrueDBGrid1(C1TrueDBGrid1.Row, "UDM").ToString <> TxtUdm.Text Then
					C1TrueDBGrid1.Columns("Q Udm Ord").Value = DettagliUDM.ConvertoValoriQuantita(C1TrueDBGrid1(C1TrueDBGrid1.Row, "UDM").ToString, TxtUdm.Text, C1TrueDBGrid1.Columns("Quantita").Value)
				Else
					C1TrueDBGrid1.Columns("Q Udm Ord").Value = C1TrueDBGrid1(C1TrueDBGrid1.Row, "Quantita").ToString
				End If
				'  
				Calcolo_Totali()
			Else
				'If IsNumeric(BTColli.Text) Then
				If CDec(BtQuantita.Text) / CDec(BtPacking.Text) = CInt(CDec(BtQuantita.Text) / CDec(BtPacking.Text)) Then BTColli.Text = CInt(CDec(BtQuantita.Text) / RapportoColliQuantita).ToString

				Calcolo_Totali()
				CalcoloPesi()
			End If

		End If
		calcolatore.Dispose()

		'  Calcolo_Totali()
		TxtScansione.SelectAll()
		TxtScansione.Focus()
	End Sub


	Private Sub BtPallet_Click(sender As Object, e As EventArgs) Handles BtPallet.Click
		If NumArticolo = 0 Then Exit Sub
		' If C1TrueDBGrid1(C1TrueDBGrid1.Row, "Lotto").ToString = "" Then
		' TxtAvviso.Text = "ATTENZIONE: Per inserire/modificare Il Pallet di destinazione occorre aver scansionato almento un lotto"
		'TxtAvviso.Visible = True
		'TxtScansione.Focus()
		'Exit Sub
		'  End If
		Dim calcolatore As New Calc
		calcolatore.EqualBtn.Visible = False
		calcolatore.OperatorPlusBtn.Visible = False
		calcolatore.OperatorSubtractBtn.Visible = False
		calcolatore.OperatorDivideBtn.Visible = False
		calcolatore.DecimalBtn.Visible = False
		calcolatore.OperatorMultiplyBtn.Visible = False
		calcolatore.OperatorX.Visible = True
		calcolatore.DisplayLbl.Text = ""

		calcolatore.ShowDialog()
		If calcolatore.Risultato <> "" Then
			BtPallet.Text = calcolatore.Risultato
			Aggiorno_pallet(BtPallet.Text)


		End If
		calcolatore.Dispose()


		TxtScansione.SelectAll()
		TxtScansione.Focus()
	End Sub
	Private Sub Aggiorno_pallet(Pallet As String)
		If IsNumeric(Pallet) Then NumPallet = CInt(Pallet)
		Dim righe() As DataRow = DsOrdineDettagli1.Tables(0).Select("IdPratica = " & IdDettaglioOrdine.ToString)
		If righe.Length > 0 Then
			righe(0).Item("Pallet") = BtPallet.Text
			C1TrueDBGrid2.Refresh()
			C1TrueDBGrid2.Row = CInt(righe(0).Item("IdRiga"))
			C1TrueDBGrid2.FetchRowStyles = True
			C1TrueDBGrid2.MarqueeStyle = MarqueeEnum.HighlightRow
		End If
	End Sub
	Private Sub Btcontainer_Click_1(sender As Object, e As EventArgs) Handles BtContainer.Click
		If NumOrdine = 0 Then Exit Sub

		Dim calcolatore As New Calc


		calcolatore.ShowDialog()
		If calcolatore.Risultato <> "" Then

			Dim Controllo() As DataRow = DsContainerOrdine1.Tables(0).Select("NumContainer = '" & calcolatore.Risultato & "'")
			If Controllo.Count = 0 Then
				BtContainer.Text = ""
				TxtScansione.SelectAll()
				TxtScansione.Focus()
				Exit Sub
			End If
			BtContainer.Text = calcolatore.Risultato
			If BtContainer.Text = "" Then
			Else
				DataView1.RowFilter = "Container = " & BtContainer.Text
				C1TrueDBGrid2.Caption = "Tutti gli item Cel Camion/Container " & BtContainer.Text
			End If
		Else
			DataView1.RowFilter = ""
			BtContainer.Text = ""
			C1TrueDBGrid2.Caption = "Tutti gli item dell'ordine"
		End If
		calcolatore.Dispose()
		TxtScansione.SelectAll()
		TxtScansione.Focus()
	End Sub

	Private Sub BtDry_Click(sender As Object, e As EventArgs) Handles BtDry.Click
		If DsOrdineDettagli1.Tables(0).Rows.Count = 0 Then Exit Sub


		Dim calcolatore As New Calc


		calcolatore.ShowDialog()
		If calcolatore.Risultato <> "" Then
			If calcolatore.Risultato <> "0" And calcolatore.Risultato <> "1" And calcolatore.Risultato <> "2" Then
				calcolatore.Dispose()
				Exit Sub
			End If

			BtDry.Text = calcolatore.Risultato
			Select Case BtDry.Text
				Case "0"
					If BtContainer.Text = "" Then
						DataView1.RowFilter = ""
					Else
						DataView1.RowFilter = "Container = " & BtContainer.Text
					End If
				Case "1"
					If BtContainer.Text = "" Then
						DataView1.RowFilter = "TipoContenitore <> 3 AND Tipocontenitore <> 1"
					Else
						DataView1.RowFilter = "Container = " & BtContainer.Text & "AND TipoContenitore <> 3 AND Tipocontenitore <> 1"
					End If
				Case "2"
					If BtContainer.Text = "" Then
						DataView1.RowFilter = "TipoContenitore = 3 or Tipocontenitore = 1"
					Else
						DataView1.RowFilter = "Container = " & BtContainer.Text & " AND (TipoContenitore = 3 or Tipocontenitore = 1)"
					End If
			End Select
		End If


		TxtScansione.SelectAll()
		TxtScansione.Focus()




	End Sub

	Private Sub BTsalva_Click(sender As Object, e As EventArgs) Handles BTsalva.Click
		Salvo_Riga_Ordine()
		Salvo_Lotti_del_Prodotto()
		mando_email(DataView1.Table)
		AzzeroTutto()
		TxtScansione.SelectAll()
		TxtScansione.Focus()


	End Sub
	Private Sub AzzeroTutto()
		TxtOrdineNum.Text = ""
		TxtRiferimento.Text = ""
		TxtCliente.Text = ""
		TxtDataConsegna.Text = ""
		TxtLuogoConsegna.Text = ""
		TxtIdArticolo.Text = ""
		TxtDesArticolo.Text = ""
		TxtItem.Text = ""
		TxtCamion.Text = ""
		TxtUdm.Text = ""
		TxtQuantOrdine.Text = ""
		DsContainerOrdine1.Clear()
		DsLotti1.Clear()
		DsOrdineDettagli1.Clear()
		BTColli.Text = ""
		BtContainer.Text = ""
		BtDry.Text = ""
		BtPacking.Text = ""
		BtProduzione.Text = ""
		BtPallet.Text = ""
		BtQuantita.Text = ""
		PesoLordoRiga = 0
		PesoNettoRiga = 0
		Pesolordo = 0
		PesoNetto = 0
		NumArticolo = 0
		NumOrdine = 0
		For Each riga In AIDatatable.Rows
			riga("ValoreAi") = System.DBNull.Value
		Next
		If BtVediLotti.Text = "Chiudi Lotti" Then
			BtVediLotti.Text = "Vedi Lotti"
			BtVediLotti.BackColor = Color.Aqua
		End If
		GroupBox1.Visible = False
		BTsalva.Enabled = False
		BTsalva.BackColor = Color.LightCoral
	End Sub

	Private Sub BtSessione_Click(sender As Object, e As EventArgs) Handles BtSessione.Click
		Salvo_Riga_Ordine()
		Salvo_Lotti_del_Prodotto()

		DsLotti1.Clear()
		BTColli.Text = ""
		BtPacking.Text = ""
		BtProduzione.Text = ""
		BtPallet.Text = ""
		BtQuantita.Text = ""
		TxtIdArticolo.Text = ""
		TxtDesArticolo.Text = ""
		TxtItem.Text = ""
		TxtCamion.Text = ""
		TxtUdm.Text = ""
		TxtQuantOrdine.Text = ""
		NumArticolo = 0
		PesoNetto = 0
		Pesolordo = 0
		DsRicercaLotti1.Clear()
		GroupBox2.Visible = False
		GroupBox1.Visible = False
		Dim riga As DataRow
		For Each riga In AIDatatable.Rows
			riga("ValoreAi") = System.DBNull.Value
		Next
		If BtVediLotti.Text = "Chiudi Lotti" Then
			BtVediLotti.Text = "Vedi Lotti"
			BtVediLotti.BackColor = Color.Aqua
		End If
		TxtScansione.SelectAll()
		TxtScansione.Focus()
	End Sub

	Private Sub BtMRN_Click(sender As Object, e As EventArgs) Handles BtMRN.Click
		If NumArticolo = 0 Or DsLotti1.TabellaLotti.Rows.Count = 0 Then Exit Sub
		Dim MultiMTN As New MRNForm
		MultiMTN.Codice = NumArticolo.ToString
		MultiMTN.ShowDialog()
		BtMRN.Text = MultiMTN.MRNTrovato
		MultiMTN.Dispose()
		If DsLotti1.TabellaLotti.Rows.Count = 0 Then
			C1TrueDBGrid1.Columns("MRN").Text = BtMRN.Text
		Else
			Dim riga As DataRow
			For Each riga In DsLotti1.TabellaLotti.Rows
				If riga("IM7").ToString <> "" Then
					TxtAvviso.Text = "NON E' POSSIBILE INSERIRE DUE MRN SU UN SINGOLO PRODOTTO: Terminare il lavoro e avvisate la fatturazione di duplicare l'ìarticolo"
					TxtAvviso.Visible = True
					BtMRN.Text = ""
					Exit For
				Else
					C1TrueDBGrid1.Columns("MRN").Text = BtMRN.Text
				End If
			Next




		End If



			TxtScansione.SelectAll()
		TxtScansione.Focus()


	End Sub

	Private Sub BtCancMRN_Click(sender As Object, e As EventArgs) Handles BtCancMRN.Click
		If NumArticolo = 0 Or DsLotti1.TabellaLotti.Rows.Count = 0 Then Exit Sub
		BtMRN.Text = ""
		C1TrueDBGrid1.Columns("MRN").Text = BtMRN.Text
	End Sub
	Private Sub Chiudo_tutti_PDF()
		Dim myProcesses() As Process
		Dim myProcess As Process

		' Restituisce un'array con tutti i processi
		Dim Chiudo As Integer
		Dim prr As Process() = Process.GetProcessesByName("Acrobat")
		If prr.Length = 0 Then
			prr = Process.GetProcessesByName("AcroRd32")
		End If
		For Each myProcess In prr


			If myProcess.HasExited = False Then myProcess.Kill()


		Next
		Exit Sub
		myProcesses = Process.GetProcesses
		'chiude ogni processo

	End Sub
	Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
		If DsOrdineDettagli1.ListGenDettagli.Rows.Count = 0 Then Exit Sub
		Chiudo_tutti_PDF()
		Dim nomefile As String = System.Environment.UserName.ToLower
		nomefile = GetUniqueTempFileName(nomefile & ".PDF")
		If System.IO.File.Exists(nomefile) Then

			Try
				Dim mioprog As New System.IO.FileStream(nomefile, IO.FileMode.Open)
				mioprog.Close()
			Catch ex As Exception

				Chiudo_tutti_PDF()
			End Try

		End If

		If System.IO.File.Exists(nomefile) Then

			System.IO.File.Delete(nomefile)
		End If

		Dim tempo As String = C1TrueDBGrid2.Caption
		C1TrueDBGrid2.Caption = "Ordine n.: " & TxtOrdineNum.Text & " - " & TxtRiferimento.Text
		C1TrueDBGrid2.ExportToPDF(nomefile)

		System.Diagnostics.Process.Start(nomefile, CStr(AppWinStyle.MaximizedFocus))
		C1TrueDBGrid2.Caption = tempo
		TxtScansione.SelectAll()
		TxtScansione.Focus()
	End Sub
	Private Function GetUniqueTempFileName(ext As String) As String
		Dim TEMP_DIR As String = System.Environment.GetEnvironmentVariable("tmp")

		Return (TEMP_DIR & "\" & ext)
	End Function
	Private Sub mando_email(Tabella As DataTable)
		'Prima di tutto vedo se l'operatore vuole mandare l'email
		If MsgBox("Vuoi mandare una email che l'inserimento è stato completato a: " & Email_Responsabile_Ordine & " (S/N)", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
		'Inizio la creazione del foglio excel per le discrepanze
		'------------------------------------------------------------------------------------------------------------

		If Tabella.Rows.Count <> 0 Then
			C1XLBook1.Clear()

			Dim s1 As New C1.C1Excel.XLStyle(C1XLBook1)
			Dim s2 As New C1.C1Excel.XLStyle(C1XLBook1)
			Dim s3 As New C1.C1Excel.XLStyle(C1XLBook1)
			s1.Font = New Font("Courier New", 12, FontStyle.Bold)
			s2.Format = "#,##0.000"

			s3.Format = "dd/mm/yyyy"
			Dim sheet As C1.C1Excel.XLSheet = C1XLBook1.Sheets(0)
			sheet(0, 0).Value = "Elenco delle discrepanze nell'inserimento delle quantità da magazzino"
			sheet(1, 0).Value = "Ordine: " & TxtOrdineNum.Text & " - " & TxtRiferimento.Text
			sheet(2, 0).Value = "Item"
			sheet(2, 1).Value = "Descrizione"
			sheet(2, 2).Value = "UDM"
			sheet(2, 3).Value = "Quant.Ordine"
			sheet(2, 4).Value = "Quant.Mag."
			sheet(2, 5).Value = "Colli"

			sheet.Columns(1).Width = 8000
			sheet.Columns(2).Width = 500
			sheet.Columns(5).Width = 500
			Dim quantordine As Decimal = 0
			Dim quantmagazzino As Decimal = 0
			Dim i As Integer = 3
			Dim rigaord As DataRow
			Dim conteggio As Decimal = 0
			For Each rigaord In Tabella.Rows
				If IsNumeric(rigaord("Quantmagazzino")) Then quantmagazzino = CDec(rigaord("Quantmagazzino")) Else quantmagazzino = 0
				If IsNumeric(rigaord("NumOrdQuant")) Then quantordine = CDec(rigaord("NumOrdQuant")) Else quantordine = 0
				If Math.Abs(quantordine - quantmagazzino) > quantordine * 0.05 Then
					i = i + 1
					sheet(i, 0).Value = rigaord("IdRiga")
					sheet(i, 1).Value = rigaord("Descrizione")
					sheet(i, 2).Value = rigaord("UDM")
					If IsNumeric(rigaord("QuantMagazzino", DataRowVersion.Current)) Then sheet(i, 4).Value = (CDec(rigaord("QuantMagazzino", DataRowVersion.Current)))
					If IsNumeric(rigaord("QuantMagazzino", DataRowVersion.Current)) Then conteggio = (CDec(rigaord("QuantMagazzino", DataRowVersion.Current)))

					sheet(i, 3).Value = CDec(rigaord("NumOrdQuant"))
					sheet(i, 5).Value = rigaord("Colli")
				End If
			Next



			Dim Messaggio As String = "<Body>Questo messaggio è generato automaticamente, non rispondere </b><BR><BR>Le Quantità, Colli e pesi della merce relativa all'ordine: " & TxtOrdineNum.Text & " -<b> " & TxtRiferimento.Text & "Destinata a: <b> " & TxtCliente.Text & "<BR>Data consegna del " & TxtDataConsegna.Text & "<b>Luogo Consegna: " & TxtLuogoConsegna.Text & "<BR><BR>SONO STATI INSERITI"
			Dim msgEmail As New System.Net.Mail.MailMessage()
			If conteggio <> 0 Then
				Messaggio = Messaggio & "<BR><BR>" & Incaricato_completo_Operatore & "Vi sono Incongruenze nell'inserimento delle quantità Magazzino ordine: <BR><BR>VEDI FOGLIO ALLEGATO"
				Dim tempdir As String = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\") + 1)
				C1XLBook1.Save(tempdir + "Discrepanze.xls")
				Dim allegato As New System.Net.Mail.Attachment(tempdir + "Discrepanze.xls")
				msgEmail.Attachments.Add(allegato)
			End If

			msgEmail.Body = Messaggio

			msgEmail.From = New System.Net.Mail.MailAddress("logistica@vermar.it", Incaricato_completo_Operatore)
			msgEmail.To.Add(New System.Net.Mail.MailAddress(Email_Responsabile_Ordine))
			msgEmail.To.Add(New System.Net.Mail.MailAddress("Cristiano@vermar.it"))

			msgEmail.IsBodyHtml = True


			'Dim mSmtpClient As New System.Net.Mail.SmtpClient("smtps.aruba.it", 465)
			Dim mSmtpClient As New System.Net.Mail.SmtpClient("smtp.vermar.it", 25)
				' ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
				ServicePointManager.ServerCertificateValidationCallback = Function(sender, certificate, chain, sslPolicyErrors) False
				' mSmtpClient.EnableSsl = True
				mSmtpClient.EnableSsl = False
				mSmtpClient.Credentials = New System.Net.NetworkCredential("Logistica@vermar.it", "5z6P52KkHS&Z")

				Try
					mSmtpClient.Send(msgEmail)
				Catch ex As System.Net.Mail.SmtpException
					MsgBox("L'invio dei documenti per EMAIL non è avvenuto a causa di un errore nella Posta Elettronica: " & Chr(13) & Chr(13) & ex.Message, MsgBoxStyle.Exclamation, "ERRORE NELL'INVIO DELLA POSTA ELETTRONICA")
				End Try

			End If


		If TxtRiferimento.Text = "" Then
			TxtScansione.SelectAll()
			TxtScansione.Focus()
			Exit Sub
		End If


		TxtScansione.SelectAll()
		TxtScansione.Focus()
	End Sub


	Private Sub C1TrueDBGrid2_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles C1TrueDBGrid2.FetchRowStyle
		Dim newfont As New Font(C1TrueDBGrid2.Font, FontStyle.Strikeout)
		If IsNumeric(C1TrueDBGrid2(e.Row, "IdFatt").ToString) Then
			e.CellStyle.Font = newfont
			'e.CellStyle.BackColor = System.Drawing.Color.Coral
		End If

	End Sub

	Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

	End Sub

	Private Sub BtVediLotti_Click(sender As Object, e As EventArgs) Handles BtVediLotti.Click
		If NumArticolo = 0 Then Exit Sub
		If BtVediLotti.Text = "Vedi Lotti" Then
			DsRicercaLotti1.Clear()
			AdapterRicercaLotti.SelectCommand.Parameters("@DataInizio").Value = DataInventario
			AdapterRicercaLotti.SelectCommand.Parameters("@IdArticolo").Value = NumArticolo
			AdapterRicercaLotti.Fill(DsRicercaLotti1)
			Dim riga As DataRow
			For Each riga In DsRicercaLotti1.TabellaLotti.Rows

				riga("Giacenza") = Format(CDec(riga("Giacenza").ToString), "##0.0000")
			Next
			If DsRicercaLotti1.TabellaLotti.Rows.Count <> 0 Then
				GroupBox2.Visible = True
				BtVediLotti.Text = "Chiudi Lotti"
				BtVediLotti.BackColor = Color.Gold
				Dim i As Integer = 0
				For Each riga In DsRicercaLotti1.TabellaLotti.Rows
					i = i + 1
					riga("N") = i
				Next
				BTSceltaLotto.PerformClick()
				Exit Sub
			Else
				GroupBox2.Visible = False
				TxtAvviso.Text = "Per il Prodotto non vi sono lotti o lotti con giacenza diversa da ZERO"
				TxtAvviso.Visible = True
			End If
		Else
			GroupBox2.Visible = False
			BtVediLotti.Text = "Vedi Lotti"
			BtVediLotti.BackColor = Color.Aqua
			TxtAvviso.Text = ""
			TxtAvviso.Visible = False

		End If
	End Sub

	Private Sub C1TrueDBGrid2_RowColChange(sender As Object, e As RowColChangeEventArgs) Handles C1TrueDBGrid2.RowColChange
		C1TrueDBGrid2.FetchRowStyles = False
		C1TrueDBGrid2.MarqueeStyle = MarqueeEnum.NoMarquee
	End Sub

	Private Sub BTSceltaLotto_Click(sender As Object, e As EventArgs) Handles BTSceltaLotto.Click
		If NumOrdine = 0 Then Exit Sub
		Dim stringa As String = ""
		Dim calcolatore As New Calc
		calcolatore.TxtLabelAvviso.Text = "Scegliere soltanto uno dei lotti elencati"
		calcolatore.TxtLabelAvviso.Visible = True
		Dim lottoscelto As Integer

		calcolatore.ShowDialog()
		If calcolatore.Risultato = "" Then Exit Sub

		Dim Controllo() As DataRow = DsRicercaLotti1.Tables(0).Select("N = '" & calcolatore.Risultato & "'")
		If Controllo.Count = 0 Then

			C1TrueDBGrid4.FetchRowStyles = False
			C1TrueDBGrid4.MarqueeStyle = MarqueeEnum.NoMarquee
			C1TrueDBGrid4.Refresh()
			TxtScansione.SelectAll()
			TxtScansione.Focus()

			Exit Sub
		Else
			lottoscelto = CInt(calcolatore.Risultato)
			calcolatore.Dispose()

			'BtQuantita.Text = Controllo(0).Item("Giacenza").ToString
			If Not IsNumeric(BtPacking.Text) Then
				TxtAvviso.Text = "Per inserire un lotto occorre che la il rapporto Collo/UDM sia inserito"
				TxtAvviso.Visible = True
				C1TrueDBGrid4.FetchRowStyles = False
				C1TrueDBGrid4.MarqueeStyle = MarqueeEnum.NoMarquee
				C1TrueDBGrid4.Refresh()
				TxtScansione.SelectAll()
				TxtScansione.Focus()
				Exit Sub
			End If
			'BTColli.Text = (CDec(BtQuantita.Text) / CInt(BtPacking.Text)).ToString
			C1TrueDBGrid4.Row = lottoscelto - 1
			C1TrueDBGrid4.FetchRowStyles = True
			C1TrueDBGrid4.MarqueeStyle = MarqueeEnum.HighlightRow
			C1TrueDBGrid4.Refresh()
			calcolatore = New Calc
			calcolatore.TxtLabelAvviso.Text = "Scegliere la quantità Desiderata da inserire"
			calcolatore.TxtLabelAvviso.Visible = True
			calcolatore.DisplayLbl.Text = Controllo(0).Item("Giacenza").ToString

			calcolatore.ShowDialog()
			If calcolatore.Risultato = "" Then
				Exit Sub

			ElseIf CDec(calcolatore.Risultato) > CDec(Controllo(0).Item("Giacenza")) Then
				TxtAvviso.Text = "La quantità non può essere maggiore di quella disponibile"
				TxtAvviso.Visible = True
				Exit Sub
			End If
			BtQuantita.Text = calcolatore.Risultato
			BTColli.Text = (CDec(BtQuantita.Text) / CInt(BtPacking.Text)).ToString
			TxtLotto.Text = Controllo(0).Item("Lotto").ToString
			stringa = "$10" & TxtLotto.Text.Trim & "!"
				TxTUDMLotto.Text = Controllo(0).Item("UDM").ToString
				Dim righe() As DataRow
				Dim QuantitaInserita As Decimal = 0
				Dim riga As DataRow
				For Each riga In DsLotti1.TabellaLotti.Rows
					If riga.RowState <> DataRowState.Deleted Then
						If TxtLotto.Text = riga("Lotto").ToString Then QuantitaInserita = QuantitaInserita + CDec(riga("Quantita"))
					End If
				Next

				'If DsLotti1.TabellaLotti.Rows.Count = 0 Then
				If (CDec(BtQuantita.Text) - QuantitaInserita) >= (CDec(Controllo(0).Item("Giacenza").ToString)) Then TxtQuantitaLotto.Text = Controllo(0).Item("Giacenza").ToString Else TxtQuantitaLotto.Text = (CDec(BtQuantita.Text) - QuantitaInserita).ToString
				'End If
				TxtScadenza.Text = Controllo(0).Item("Scadenza").ToString
				Dim decimali As Integer = 0
				Dim spezzo() As String = TxtQuantitaLotto.Text.Trim.Split(",")
				If spezzo.Length = 1 Then
					decimali = 0
				Else
					decimali = spezzo(1).Length

				End If
				'Dim colli As Integer
				stringa = stringa & "31" & Format(decimali, "00") & Format(CInt(TxtQuantitaLotto.Text.Replace(",", "")), "000000") ' ho messo la quantità
			stringa = stringa & "240" & TxtIdArticolo.Text & "!" & "90" & TxTUDMLotto.Text & "!" & "91" & Format(CDec(BtQuantita.Text), "###.###") & "!"

			If IsDate(TxtScadenza.Text) Then
				Dim scadenza As String = TxtScadenza.Text.Replace("/", "")
				scadenza = scadenza.Substring(6, 2) & scadenza.Substring(2, 2) & scadenza.Substring(0, 2)
				stringa = stringa & "17" & scadenza
			End If

			TxtColli.Text = BTColli.Text
				interpretoCodici(stringa)
				Calcolo_Totali()
			End If
    End Sub


	'Devo inserire l'MRN nel dataset dei lotti e prevedere che vi possano essere + mrn --- giacenza MRN?
End Class
