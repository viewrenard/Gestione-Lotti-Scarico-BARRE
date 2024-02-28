Imports C1.Win.C1TrueDBGrid

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestioneLottiBarre
	Inherits System.Windows.Forms.Form

	'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Richiesto da Progettazione Windows Form
	Private components As System.ComponentModel.IContainer

	'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
	'Può essere modificata in Progettazione Windows Form.  
	'Non modificarla mediante l'editor del codice.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestioneLottiBarre))
		Me.Label7 = New System.Windows.Forms.Label()
		Me.TxtScansione = New System.Windows.Forms.TextBox()
		Me.AdapterGs1AI = New System.Data.SqlClient.SqlDataAdapter()
		Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
		Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
		Me.TxtRiferimento = New System.Windows.Forms.Label()
		Me.TxtOrdineNum = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.TxtCliente = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TxtDataConsegna = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.TxtLuogoConsegna = New System.Windows.Forms.Label()
		Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
		Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
		Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
		Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
		Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
		Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
		Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
		Me.TxtIdArticolo = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TxtDesArticolo = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TxtUdm = New System.Windows.Forms.Label()
		Me.TxtQuantOrdine = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.BTColli = New System.Windows.Forms.Button()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.TxtCamion = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.TxtItem = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.BtPacking = New System.Windows.Forms.Button()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.BtQuantita = New System.Windows.Forms.Button()
		Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
		Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection()
		Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
		Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
		Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
		Me.AdapterLottoEsistente = New System.Data.SqlClient.SqlDataAdapter()
		Me.TxtLotto = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.TxTUDMLotto = New System.Windows.Forms.Label()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.TxtQuantitaLotto = New System.Windows.Forms.Label()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.TxtScadenza = New System.Windows.Forms.Label()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.BtProduzione = New System.Windows.Forms.Button()
		Me.TxtColli = New System.Windows.Forms.Label()
		Me.Label18 = New System.Windows.Forms.Label()
		Me.SqlComUpdateRigheOrdine = New System.Data.SqlClient.SqlCommand()
		Me.SqlConnection1TEST = New System.Data.SqlClient.SqlConnection()
		Me.SqlConnection2TEST = New System.Data.SqlClient.SqlConnection()
		Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
		Me.SqlConnection3 = New System.Data.SqlClient.SqlConnection()
		Me.AdapterOrdineDettagli = New System.Data.SqlClient.SqlDataAdapter()
		Me.TxtAvviso = New System.Windows.Forms.Label()
		Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand()
		Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand()
		Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand()
		Me.Label19 = New System.Windows.Forms.Label()
		Me.BtPallet = New System.Windows.Forms.Button()
		Me.BtContainer = New System.Windows.Forms.Button()
		Me.DsContainerOrdine1 = New Gestione_Lotti_Scarico_BARRE.DsContainerOrdine()
		Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
		Me.AdapterContainerOrdini = New System.Data.SqlClient.SqlDataAdapter()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.Label20 = New System.Windows.Forms.Label()
		Me.BtDry = New System.Windows.Forms.Button()
		Me.DsLotti1 = New Gestione_Lotti_Scarico_BARRE.DsLotti()
		Me.BTsalva = New System.Windows.Forms.Button()
		Me.BtSessione = New System.Windows.Forms.Button()
		Me.ComDataUltimoInventarioGenerale = New System.Data.SqlClient.SqlCommand()
		Me.SqlComRicercaLotto = New System.Data.SqlClient.SqlCommand()
		Me.T1Descrizione = New System.Windows.Forms.Label()
		Me.BtMRN = New System.Windows.Forms.Button()
		Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
		Me.SqlConnDMSQL = New System.Data.SqlClient.SqlConnection()
		Me.AdapterMRN_DM = New System.Data.SqlClient.SqlDataAdapter()
		Me.CommMRNuscitiDM = New System.Data.SqlClient.SqlCommand()
		Me.BtCancMRN = New System.Windows.Forms.Button()
		Me.Label21 = New System.Windows.Forms.Label()
		Me.C1TrueDBGrid3 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
		Me.C1TrueDBGrid2 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
		Me.DataView1 = New System.Data.DataView()
		Me.DsOrdineDettagli1 = New Gestione_Lotti_Scarico_BARRE.DsOrdineDettagli()
		Me.C1TrueDBGrid1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.DsMRNcaricoDM1 = New Gestione_Lotti_Scarico_BARRE.DsMRNcaricoDM()
		Me.CommNoMRNUscitiDM = New System.Data.SqlClient.SqlCommand()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.C1XLBook1 = New C1.C1Excel.C1XLBook()
		Me.SqlComPassword = New System.Data.SqlClient.SqlCommand()
		Me.BtSceltaRiga = New System.Windows.Forms.Button()
		Me.AdapterRicercaLotti = New System.Data.SqlClient.SqlDataAdapter()
		Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.BTSceltaLotto = New System.Windows.Forms.Button()
		Me.C1TrueDBGrid4 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
		Me.DsRicercaLotti1 = New Gestione_Lotti_Scarico_BARRE.DsRicercaLotti()
		Me.BtVediLotti = New System.Windows.Forms.Button()
		Me.CommRapportoStorico = New System.Data.SqlClient.SqlCommand()
		CType(Me.DsContainerOrdine1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DsLotti1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.C1TrueDBGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.C1TrueDBGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DsOrdineDettagli1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		CType(Me.DsMRNcaricoDM1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox2.SuspendLayout()
		CType(Me.C1TrueDBGrid4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DsRicercaLotti1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(2, 9)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(108, 24)
		Me.Label7.TabIndex = 24
		Me.Label7.Text = "Scansione"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TxtScansione
		'
		Me.TxtScansione.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TxtScansione.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtScansione.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.TxtScansione.Location = New System.Drawing.Point(116, 9)
		Me.TxtScansione.Name = "TxtScansione"
		Me.TxtScansione.Size = New System.Drawing.Size(569, 26)
		Me.TxtScansione.TabIndex = 25
		'
		'AdapterGs1AI
		'
		Me.AdapterGs1AI.SelectCommand = Me.SqlCommand1
		Me.AdapterGs1AI.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TabellaAI-GS1", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("AI", "AI"), New System.Data.Common.DataColumnMapping("Descrizione", "Descrizione"), New System.Data.Common.DataColumnMapping("LunghezzaMax", "LunghezzaMax"), New System.Data.Common.DataColumnMapping("FNC1", "FNC1")})})
		'
		'SqlCommand1
		'
		Me.SqlCommand1.CommandText = "SELECT        ID, AI, Descrizione, LunghezzaMax, FNC1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            [TabellaAI" &
	"-GS1]"
		Me.SqlCommand1.Connection = Me.SqlConnection1
		'
		'SqlConnection1
		'
		Me.SqlConnection1.ConnectionString = "Data Source=DATASERVER\SQLPROCEDURA;Initial Catalog=vermarnew;Persist Security In" &
	"fo=True;User ID=sa;Password=31iris46"
		Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
		'
		'TxtRiferimento
		'
		Me.TxtRiferimento.BackColor = System.Drawing.Color.PaleGreen
		Me.TxtRiferimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtRiferimento.Location = New System.Drawing.Point(241, 38)
		Me.TxtRiferimento.Name = "TxtRiferimento"
		Me.TxtRiferimento.Size = New System.Drawing.Size(444, 44)
		Me.TxtRiferimento.TabIndex = 33
		'
		'TxtOrdineNum
		'
		Me.TxtOrdineNum.BackColor = System.Drawing.Color.PaleGreen
		Me.TxtOrdineNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtOrdineNum.Location = New System.Drawing.Point(112, 49)
		Me.TxtOrdineNum.Name = "TxtOrdineNum"
		Me.TxtOrdineNum.Size = New System.Drawing.Size(89, 24)
		Me.TxtOrdineNum.TabIndex = 32
		Me.TxtOrdineNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.Location = New System.Drawing.Point(2, 49)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(98, 24)
		Me.Label10.TabIndex = 31
		Me.Label10.Text = "Ordine n."
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TxtCliente
		'
		Me.TxtCliente.BackColor = System.Drawing.Color.PaleGreen
		Me.TxtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtCliente.Location = New System.Drawing.Point(112, 93)
		Me.TxtCliente.Name = "TxtCliente"
		Me.TxtCliente.Size = New System.Drawing.Size(573, 24)
		Me.TxtCliente.TabIndex = 35
		Me.TxtCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(2, 93)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(75, 24)
		Me.Label2.TabIndex = 34
		Me.Label2.Text = "Cliente"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TxtDataConsegna
		'
		Me.TxtDataConsegna.BackColor = System.Drawing.Color.PaleGreen
		Me.TxtDataConsegna.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtDataConsegna.Location = New System.Drawing.Point(150, 126)
		Me.TxtDataConsegna.Name = "TxtDataConsegna"
		Me.TxtDataConsegna.Size = New System.Drawing.Size(114, 24)
		Me.TxtDataConsegna.TabIndex = 37
		Me.TxtDataConsegna.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.Location = New System.Drawing.Point(2, 126)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(152, 24)
		Me.Label12.TabIndex = 36
		Me.Label12.Text = "Data Consegna"
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TxtLuogoConsegna
		'
		Me.TxtLuogoConsegna.BackColor = System.Drawing.Color.PaleGreen
		Me.TxtLuogoConsegna.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtLuogoConsegna.Location = New System.Drawing.Point(276, 126)
		Me.TxtLuogoConsegna.Name = "TxtLuogoConsegna"
		Me.TxtLuogoConsegna.Size = New System.Drawing.Size(409, 24)
		Me.TxtLuogoConsegna.TabIndex = 38
		Me.TxtLuogoConsegna.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'ShapeContainer1
		'
		Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
		Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
		Me.ShapeContainer1.Name = "ShapeContainer1"
		Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape6, Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
		Me.ShapeContainer1.Size = New System.Drawing.Size(1344, 817)
		Me.ShapeContainer1.TabIndex = 39
		Me.ShapeContainer1.TabStop = False
		'
		'LineShape6
		'
		Me.LineShape6.BorderWidth = 2
		Me.LineShape6.Name = "LineShape6"
		Me.LineShape6.X1 = 388
		Me.LineShape6.X2 = 769
		Me.LineShape6.Y1 = 209
		Me.LineShape6.Y2 = 209
		'
		'LineShape5
		'
		Me.LineShape5.BorderWidth = 2
		Me.LineShape5.Name = "LineShape5"
		Me.LineShape5.X1 = 387
		Me.LineShape5.X2 = 387
		Me.LineShape5.Y1 = 270
		Me.LineShape5.Y2 = 209
		'
		'LineShape4
		'
		Me.LineShape4.BorderWidth = 3
		Me.LineShape4.Name = "LineShape4"
		Me.LineShape4.X1 = 7
		Me.LineShape4.X2 = 772
		Me.LineShape4.Y1 = 420
		Me.LineShape4.Y2 = 422
		'
		'LineShape3
		'
		Me.LineShape3.BorderWidth = 3
		Me.LineShape3.Name = "LineShape3"
		Me.LineShape3.X1 = 6
		Me.LineShape3.X2 = 771
		Me.LineShape3.Y1 = 351
		Me.LineShape3.Y2 = 359
		'
		'LineShape2
		'
		Me.LineShape2.BorderWidth = 2
		Me.LineShape2.Name = "LineShape2"
		Me.LineShape2.X1 = 4
		Me.LineShape2.X2 = 769
		Me.LineShape2.Y1 = 270
		Me.LineShape2.Y2 = 270
		'
		'LineShape1
		'
		Me.LineShape1.BorderWidth = 2
		Me.LineShape1.Name = "LineShape1"
		Me.LineShape1.X1 = 8
		Me.LineShape1.X2 = 773
		Me.LineShape1.Y1 = 167
		Me.LineShape1.Y2 = 163
		'
		'TxtIdArticolo
		'
		Me.TxtIdArticolo.BackColor = System.Drawing.Color.Moccasin
		Me.TxtIdArticolo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtIdArticolo.Location = New System.Drawing.Point(81, 174)
		Me.TxtIdArticolo.Name = "TxtIdArticolo"
		Me.TxtIdArticolo.Size = New System.Drawing.Size(73, 24)
		Me.TxtIdArticolo.TabIndex = 41
		Me.TxtIdArticolo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(2, 174)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(81, 24)
		Me.Label3.TabIndex = 40
		Me.Label3.Text = "Articolo"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TxtDesArticolo
		'
		Me.TxtDesArticolo.BackColor = System.Drawing.Color.Moccasin
		Me.TxtDesArticolo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtDesArticolo.Location = New System.Drawing.Point(160, 174)
		Me.TxtDesArticolo.Name = "TxtDesArticolo"
		Me.TxtDesArticolo.Size = New System.Drawing.Size(482, 24)
		Me.TxtDesArticolo.TabIndex = 42
		Me.TxtDesArticolo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(218, 207)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(142, 24)
		Me.Label1.TabIndex = 43
		Me.Label1.Text = "Quant. Ordine"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TxtUdm
		'
		Me.TxtUdm.BackColor = System.Drawing.Color.Moccasin
		Me.TxtUdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtUdm.Location = New System.Drawing.Point(217, 230)
		Me.TxtUdm.Name = "TxtUdm"
		Me.TxtUdm.Size = New System.Drawing.Size(53, 24)
		Me.TxtUdm.TabIndex = 44
		Me.TxtUdm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TxtQuantOrdine
		'
		Me.TxtQuantOrdine.BackColor = System.Drawing.Color.Moccasin
		Me.TxtQuantOrdine.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtQuantOrdine.Location = New System.Drawing.Point(276, 230)
		Me.TxtQuantOrdine.Name = "TxtQuantOrdine"
		Me.TxtQuantOrdine.Size = New System.Drawing.Size(84, 24)
		Me.TxtQuantOrdine.TabIndex = 45
		Me.TxtQuantOrdine.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(70, 281)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(51, 24)
		Me.Label5.TabIndex = 46
		Me.Label5.Text = "Colli"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'BTColli
		'
		Me.BTColli.BackColor = System.Drawing.Color.LimeGreen
		Me.BTColli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BTColli.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BTColli.Location = New System.Drawing.Point(60, 312)
		Me.BTColli.Name = "BTColli"
		Me.BTColli.Size = New System.Drawing.Size(70, 31)
		Me.BTColli.TabIndex = 47
		Me.BTColli.UseVisualStyleBackColor = False
		'
		'Label6
		'
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(151, 272)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(98, 45)
		Me.Label6.TabIndex = 48
		Me.Label6.Text = "Rapp. Collo/UDM"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TxtCamion
		'
		Me.TxtCamion.BackColor = System.Drawing.Color.Moccasin
		Me.TxtCamion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtCamion.Location = New System.Drawing.Point(5, 231)
		Me.TxtCamion.Name = "TxtCamion"
		Me.TxtCamion.Size = New System.Drawing.Size(151, 24)
		Me.TxtCamion.TabIndex = 51
		Me.TxtCamion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(29, 207)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(81, 24)
		Me.Label8.TabIndex = 50
		Me.Label8.Text = "Camion"
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TxtItem
		'
		Me.TxtItem.BackColor = System.Drawing.Color.Moccasin
		Me.TxtItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtItem.Location = New System.Drawing.Point(716, 174)
		Me.TxtItem.Name = "TxtItem"
		Me.TxtItem.Size = New System.Drawing.Size(57, 24)
		Me.TxtItem.TabIndex = 53
		Me.TxtItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.Location = New System.Drawing.Point(665, 173)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(49, 24)
		Me.Label9.TabIndex = 52
		Me.Label9.Text = "Item"
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'BtPacking
		'
		Me.BtPacking.BackColor = System.Drawing.Color.LimeGreen
		Me.BtPacking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BtPacking.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtPacking.Location = New System.Drawing.Point(154, 312)
		Me.BtPacking.Name = "BtPacking"
		Me.BtPacking.Size = New System.Drawing.Size(81, 31)
		Me.BtPacking.TabIndex = 54
		Me.BtPacking.UseVisualStyleBackColor = False
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(273, 285)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(87, 24)
		Me.Label4.TabIndex = 55
		Me.Label4.Text = "Quantità"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'BtQuantita
		'
		Me.BtQuantita.BackColor = System.Drawing.Color.LimeGreen
		Me.BtQuantita.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BtQuantita.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtQuantita.Location = New System.Drawing.Point(261, 312)
		Me.BtQuantita.Name = "BtQuantita"
		Me.BtQuantita.Size = New System.Drawing.Size(106, 31)
		Me.BtQuantita.TabIndex = 56
		Me.BtQuantita.UseVisualStyleBackColor = False
		'
		'SqlSelectCommand1
		'
		Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
		Me.SqlSelectCommand1.Connection = Me.SqlConnection2
		Me.SqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@IdOrdine", System.Data.SqlDbType.Int, 4, "IdOrdine"), New System.Data.SqlClient.SqlParameter("@IdProdotto", System.Data.SqlDbType.Int, 4, "IdProdotto"), New System.Data.SqlClient.SqlParameter("@IdDettaglioOrdine", System.Data.SqlDbType.Int, 4, "IdDettagliOrdineCli")})
		'
		'SqlConnection2
		'
		Me.SqlConnection2.ConnectionString = "Data Source=DATASERVER\SQLPROCEDURA;Initial Catalog=Vermarnew;User ID=sa;Password" &
	"=31iris46"
		Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
		'
		'SqlInsertCommand1
		'
		Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
		Me.SqlInsertCommand1.Connection = Me.SqlConnection2
		Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Lotto", System.Data.SqlDbType.NVarChar, 0, "Lotto"), New System.Data.SqlClient.SqlParameter("@UDM", System.Data.SqlDbType.NVarChar, 0, "UDM"), New System.Data.SqlClient.SqlParameter("@Quantita", System.Data.SqlDbType.Float, 0, "Quantita"), New System.Data.SqlClient.SqlParameter("@Scadenza", System.Data.SqlDbType.NVarChar, 0, "Scadenza"), New System.Data.SqlClient.SqlParameter("@IdDettagliOrdineCli", System.Data.SqlDbType.Int, 0, "IdDettagliOrdineCli"), New System.Data.SqlClient.SqlParameter("@DataScadenza", System.Data.SqlDbType.[Date], 0, "DataScadenza"), New System.Data.SqlClient.SqlParameter("@Colli", System.Data.SqlDbType.Int, 0, "Colli"), New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.SmallDateTime, 0, "Data"), New System.Data.SqlClient.SqlParameter("@IdProdotto", System.Data.SqlDbType.Int, 0, "IdProdotto"), New System.Data.SqlClient.SqlParameter("@IdOrdine", System.Data.SqlDbType.Int, 0, "IdOrdine"), New System.Data.SqlClient.SqlParameter("@FlagCaricoScarico", System.Data.SqlDbType.[Char], 0, "FlagCaricoScarico"), New System.Data.SqlClient.SqlParameter("@FlagMoltiplica", System.Data.SqlDbType.SmallInt, 0, "FlagMoltiplica"), New System.Data.SqlClient.SqlParameter("@LottoFornitore", System.Data.SqlDbType.NVarChar, 0, "LottoFornitore"), New System.Data.SqlClient.SqlParameter("@CodiceEAN", System.Data.SqlDbType.NVarChar, 0, "CodiceEAN"), New System.Data.SqlClient.SqlParameter("@IM7", System.Data.SqlDbType.NVarChar, 0, "IM7"), New System.Data.SqlClient.SqlParameter("@Societa", System.Data.SqlDbType.Int, 0, "Societa"), New System.Data.SqlClient.SqlParameter("@Operatore", System.Data.SqlDbType.NVarChar, 0, "Operatore")})
		'
		'SqlUpdateCommand1
		'
		Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
		Me.SqlUpdateCommand1.Connection = Me.SqlConnection2
		Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Lotto", System.Data.SqlDbType.NVarChar, 30, "Lotto"), New System.Data.SqlClient.SqlParameter("@UDM", System.Data.SqlDbType.NVarChar, 5, "UDM"), New System.Data.SqlClient.SqlParameter("@Quantita", System.Data.SqlDbType.Float, 8, "Quantita"), New System.Data.SqlClient.SqlParameter("@Scadenza", System.Data.SqlDbType.NVarChar, 20, "Scadenza"), New System.Data.SqlClient.SqlParameter("@IdDettagliOrdineCli", System.Data.SqlDbType.Int, 4, "IdDettagliOrdineCli"), New System.Data.SqlClient.SqlParameter("@DataScadenza", System.Data.SqlDbType.[Date], 3, "DataScadenza"), New System.Data.SqlClient.SqlParameter("@Colli", System.Data.SqlDbType.Int, 4, "Colli"), New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.SmallDateTime, 4, "Data"), New System.Data.SqlClient.SqlParameter("@IdProdotto", System.Data.SqlDbType.Int, 4, "IdProdotto"), New System.Data.SqlClient.SqlParameter("@IdOrdine", System.Data.SqlDbType.Int, 4, "IdOrdine"), New System.Data.SqlClient.SqlParameter("@FlagCaricoScarico", System.Data.SqlDbType.[Char], 1, "FlagCaricoScarico"), New System.Data.SqlClient.SqlParameter("@FlagMoltiplica", System.Data.SqlDbType.SmallInt, 2, "FlagMoltiplica"), New System.Data.SqlClient.SqlParameter("@LottoFornitore", System.Data.SqlDbType.NVarChar, 30, "LottoFornitore"), New System.Data.SqlClient.SqlParameter("@CodiceEAN", System.Data.SqlDbType.NVarChar, 30, "CodiceEAN"), New System.Data.SqlClient.SqlParameter("@IM7", System.Data.SqlDbType.NVarChar, 20, "IM7"), New System.Data.SqlClient.SqlParameter("@Societa", System.Data.SqlDbType.Int, 4, "Societa"), New System.Data.SqlClient.SqlParameter("@Operatore", System.Data.SqlDbType.NVarChar, 40, "Operatore"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing)})
		'
		'SqlDeleteCommand1
		'
		Me.SqlDeleteCommand1.CommandText = "DELETE FROM TabellaLotti" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE        (Id = @Original_Id)"
		Me.SqlDeleteCommand1.Connection = Me.SqlConnection2
		Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing)})
		'
		'AdapterLottoEsistente
		'
		Me.AdapterLottoEsistente.DeleteCommand = Me.SqlDeleteCommand1
		Me.AdapterLottoEsistente.InsertCommand = Me.SqlInsertCommand1
		Me.AdapterLottoEsistente.SelectCommand = Me.SqlSelectCommand1
		Me.AdapterLottoEsistente.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TabellaLotti", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Lotto", "Lotto"), New System.Data.Common.DataColumnMapping("UDM", "UDM"), New System.Data.Common.DataColumnMapping("Quantita", "Quantita"), New System.Data.Common.DataColumnMapping("Scadenza", "Scadenza"), New System.Data.Common.DataColumnMapping("IdDettagliOrdineCli", "IdDettagliOrdineCli"), New System.Data.Common.DataColumnMapping("DataScadenza", "DataScadenza"), New System.Data.Common.DataColumnMapping("Colli", "Colli"), New System.Data.Common.DataColumnMapping("Data", "Data"), New System.Data.Common.DataColumnMapping("IdProdotto", "IdProdotto"), New System.Data.Common.DataColumnMapping("IdOrdine", "IdOrdine"), New System.Data.Common.DataColumnMapping("FlagCaricoScarico", "FlagCaricoScarico"), New System.Data.Common.DataColumnMapping("FlagMoltiplica", "FlagMoltiplica"), New System.Data.Common.DataColumnMapping("LottoFornitore", "LottoFornitore"), New System.Data.Common.DataColumnMapping("CodiceEAN", "CodiceEAN"), New System.Data.Common.DataColumnMapping("IM7", "IM7"), New System.Data.Common.DataColumnMapping("Societa", "Societa"), New System.Data.Common.DataColumnMapping("Operatore", "Operatore")})})
		Me.AdapterLottoEsistente.UpdateCommand = Me.SqlUpdateCommand1
		'
		'TxtLotto
		'
		Me.TxtLotto.BackColor = System.Drawing.Color.Moccasin
		Me.TxtLotto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtLotto.Location = New System.Drawing.Point(5, 390)
		Me.TxtLotto.Name = "TxtLotto"
		Me.TxtLotto.Size = New System.Drawing.Size(183, 24)
		Me.TxtLotto.TabIndex = 60
		Me.TxtLotto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label13.Location = New System.Drawing.Point(58, 359)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(55, 24)
		Me.Label13.TabIndex = 59
		Me.Label13.Text = "Lotto"
		Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.Location = New System.Drawing.Point(190, 361)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(55, 24)
		Me.Label11.TabIndex = 61
		Me.Label11.Text = "UDM"
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TxTUDMLotto
		'
		Me.TxTUDMLotto.BackColor = System.Drawing.Color.Moccasin
		Me.TxTUDMLotto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxTUDMLotto.Location = New System.Drawing.Point(194, 390)
		Me.TxTUDMLotto.Name = "TxTUDMLotto"
		Me.TxTUDMLotto.Size = New System.Drawing.Size(57, 24)
		Me.TxTUDMLotto.TabIndex = 62
		Me.TxTUDMLotto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label14.Location = New System.Drawing.Point(257, 359)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(87, 24)
		Me.Label14.TabIndex = 63
		Me.Label14.Text = "Quantità"
		Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TxtQuantitaLotto
		'
		Me.TxtQuantitaLotto.BackColor = System.Drawing.Color.Moccasin
		Me.TxtQuantitaLotto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtQuantitaLotto.Location = New System.Drawing.Point(257, 390)
		Me.TxtQuantitaLotto.Name = "TxtQuantitaLotto"
		Me.TxtQuantitaLotto.Size = New System.Drawing.Size(84, 24)
		Me.TxtQuantitaLotto.TabIndex = 64
		Me.TxtQuantitaLotto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label15.Location = New System.Drawing.Point(407, 358)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(102, 24)
		Me.Label15.TabIndex = 65
		Me.Label15.Text = "Scadenza"
		Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TxtScadenza
		'
		Me.TxtScadenza.BackColor = System.Drawing.Color.Moccasin
		Me.TxtScadenza.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtScadenza.Location = New System.Drawing.Point(407, 388)
		Me.TxtScadenza.Name = "TxtScadenza"
		Me.TxtScadenza.Size = New System.Drawing.Size(114, 24)
		Me.TxtScadenza.TabIndex = 66
		Me.TxtScadenza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label16.Location = New System.Drawing.Point(541, 359)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(117, 24)
		Me.Label16.TabIndex = 67
		Me.Label16.Text = "Produzione"
		Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'BtProduzione
		'
		Me.BtProduzione.BackColor = System.Drawing.Color.LimeGreen
		Me.BtProduzione.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtProduzione.Location = New System.Drawing.Point(531, 382)
		Me.BtProduzione.Name = "BtProduzione"
		Me.BtProduzione.Size = New System.Drawing.Size(144, 31)
		Me.BtProduzione.TabIndex = 68
		Me.BtProduzione.UseVisualStyleBackColor = False
		'
		'TxtColli
		'
		Me.TxtColli.BackColor = System.Drawing.Color.Moccasin
		Me.TxtColli.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtColli.Location = New System.Drawing.Point(354, 388)
		Me.TxtColli.Name = "TxtColli"
		Me.TxtColli.Size = New System.Drawing.Size(44, 24)
		Me.TxtColli.TabIndex = 70
		Me.TxtColli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label18
		'
		Me.Label18.AutoSize = True
		Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label18.Location = New System.Drawing.Point(350, 359)
		Me.Label18.Name = "Label18"
		Me.Label18.Size = New System.Drawing.Size(51, 24)
		Me.Label18.TabIndex = 69
		Me.Label18.Text = "Colli"
		Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'SqlComUpdateRigheOrdine
		'
		Me.SqlComUpdateRigheOrdine.CommandText = resources.GetString("SqlComUpdateRigheOrdine.CommandText")
		Me.SqlComUpdateRigheOrdine.Connection = Me.SqlConnection1
		Me.SqlComUpdateRigheOrdine.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Packing", System.Data.SqlDbType.NVarChar, 30, "Packing"), New System.Data.SqlClient.SqlParameter("@QuantitaMagazzino", System.Data.SqlDbType.NVarChar, 15, "QuantMagazzino"), New System.Data.SqlClient.SqlParameter("@ColliMagazzino", System.Data.SqlDbType.NVarChar, 15, "ColliMagazzino"), New System.Data.SqlClient.SqlParameter("@Pallet", System.Data.SqlDbType.NVarChar, 10, "Pallet"), New System.Data.SqlClient.SqlParameter("@PesoNetto", System.Data.SqlDbType.NVarChar, 15, "PesoNetto"), New System.Data.SqlClient.SqlParameter("@PesoLordo", System.Data.SqlDbType.NVarChar, 15, "PesoLordo"), New System.Data.SqlClient.SqlParameter("@QuantitaMagazzinoNum", System.Data.SqlDbType.Float, 8, "QuantMagazzinoNum"), New System.Data.SqlClient.SqlParameter("@IdDettaglioOrdine", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IDPratica", System.Data.DataRowVersion.Original, Nothing)})
		'
		'SqlConnection1TEST
		'
		Me.SqlConnection1TEST.ConnectionString = "Data Source=DATASERVER\SQLPROCEDURA;Initial Catalog=versaptest;Persist Security I" &
	"nfo=True;User ID=sa;Password=31iris46"
		Me.SqlConnection1TEST.FireInfoMessageEventOnUserErrors = False
		'
		'SqlConnection2TEST
		'
		Me.SqlConnection2TEST.ConnectionString = "Data Source=DATASERVER\SQLPROCEDURA;Initial Catalog=VerSapTest;User ID=sa;Passwor" &
	"d=31iris46"
		Me.SqlConnection2TEST.FireInfoMessageEventOnUserErrors = False
		'
		'SqlSelectCommand2
		'
		Me.SqlSelectCommand2.CommandText = resources.GetString("SqlSelectCommand2.CommandText")
		Me.SqlSelectCommand2.Connection = Me.SqlConnection3
		Me.SqlSelectCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Ordine", System.Data.SqlDbType.Int, 4, "IdOrd")})
		'
		'SqlConnection3
		'
		Me.SqlConnection3.ConnectionString = "Data Source=DATASERVER\SQLPROCEDURA;Initial Catalog=vermarnew;User ID=fox;Passwor" &
	"d=31iris46"
		Me.SqlConnection3.FireInfoMessageEventOnUserErrors = False
		'
		'AdapterOrdineDettagli
		'
		Me.AdapterOrdineDettagli.SelectCommand = Me.SqlSelectCommand2
		Me.AdapterOrdineDettagli.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ListGenDettagli", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IDPratica", "IDPratica"), New System.Data.Common.DataColumnMapping("IDRiga", "IDRiga"), New System.Data.Common.DataColumnMapping("progressivo", "progressivo"), New System.Data.Common.DataColumnMapping("Descrizione", "Descrizione"), New System.Data.Common.DataColumnMapping("UDM", "UDM"), New System.Data.Common.DataColumnMapping("NumOrdQuant", "NumOrdQuant"), New System.Data.Common.DataColumnMapping("QuantMagazzino", "QuantMagazzino"), New System.Data.Common.DataColumnMapping("Pallet", "Pallet")})})
		'
		'TxtAvviso
		'
		Me.TxtAvviso.BackColor = System.Drawing.Color.Coral
		Me.TxtAvviso.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtAvviso.Location = New System.Drawing.Point(12, 425)
		Me.TxtAvviso.Name = "TxtAvviso"
		Me.TxtAvviso.Size = New System.Drawing.Size(758, 40)
		Me.TxtAvviso.TabIndex = 72
		Me.TxtAvviso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.TxtAvviso.Visible = False
		'
		'SqlCommand2
		'
		Me.SqlCommand2.Connection = Me.SqlConnection1
		'
		'SqlCommand3
		'
		Me.SqlCommand3.CommandText = resources.GetString("SqlCommand3.CommandText")
		Me.SqlCommand3.Connection = Me.SqlConnection1
		Me.SqlCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodiceBarre", System.Data.SqlDbType.Int, 4, "IdOrdine")})
		'
		'SqlCommand4
		'
		Me.SqlCommand4.CommandText = resources.GetString("SqlCommand4.CommandText")
		Me.SqlCommand4.Connection = Me.SqlConnection1
		Me.SqlCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodiceBarre", System.Data.SqlDbType.Int, 4, "IdOrdine")})
		'
		'Label19
		'
		Me.Label19.AutoSize = True
		Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label19.Location = New System.Drawing.Point(616, 285)
		Me.Label19.Name = "Label19"
		Me.Label19.Size = New System.Drawing.Size(85, 24)
		Me.Label19.TabIndex = 74
		Me.Label19.Text = "Pallet n."
		Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'BtPallet
		'
		Me.BtPallet.BackColor = System.Drawing.Color.LimeGreen
		Me.BtPallet.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtPallet.Location = New System.Drawing.Point(545, 312)
		Me.BtPallet.Name = "BtPallet"
		Me.BtPallet.Size = New System.Drawing.Size(224, 31)
		Me.BtPallet.TabIndex = 75
		Me.BtPallet.UseVisualStyleBackColor = False
		'
		'BtContainer
		'
		Me.BtContainer.BackColor = System.Drawing.Color.LimeGreen
		Me.BtContainer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtContainer.Location = New System.Drawing.Point(741, 38)
		Me.BtContainer.Name = "BtContainer"
		Me.BtContainer.Size = New System.Drawing.Size(70, 31)
		Me.BtContainer.TabIndex = 76
		Me.BtContainer.UseVisualStyleBackColor = False
		'
		'DsContainerOrdine1
		'
		Me.DsContainerOrdine1.DataSetName = "DsContainerOrdine"
		Me.DsContainerOrdine1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'SqlSelectCommand3
		'
		Me.SqlSelectCommand3.CommandText = resources.GetString("SqlSelectCommand3.CommandText")
		Me.SqlSelectCommand3.Connection = Me.SqlConnection3
		Me.SqlSelectCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@IdOrdine", System.Data.SqlDbType.Int, 4, "IDOrdine")})
		'
		'AdapterContainerOrdini
		'
		Me.AdapterContainerOrdini.SelectCommand = Me.SqlSelectCommand3
		Me.AdapterContainerOrdini.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ContainersOrdine", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NumContainer", "NumContainer"), New System.Data.Common.DataColumnMapping("Descrizione", "Descrizione")})})
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label17.Location = New System.Drawing.Point(694, 7)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(163, 24)
		Me.Label17.TabIndex = 78
		Me.Label17.Text = "Scelta Container"
		Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label20
		'
		Me.Label20.AutoSize = True
		Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label20.Location = New System.Drawing.Point(694, 83)
		Me.Label20.Name = "Label20"
		Me.Label20.Size = New System.Drawing.Size(186, 18)
		Me.Label20.TabIndex = 79
		Me.Label20.Text = "All = 0; Dry =1; Rfer = 2"
		Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'BtDry
		'
		Me.BtDry.BackColor = System.Drawing.Color.LimeGreen
		Me.BtDry.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtDry.Location = New System.Drawing.Point(741, 106)
		Me.BtDry.Name = "BtDry"
		Me.BtDry.Size = New System.Drawing.Size(70, 31)
		Me.BtDry.TabIndex = 80
		Me.BtDry.UseVisualStyleBackColor = False
		'
		'DsLotti1
		'
		Me.DsLotti1.DataSetName = "DsLotti"
		Me.DsLotti1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'BTsalva
		'
		Me.BTsalva.BackColor = System.Drawing.Color.LightCoral
		Me.BTsalva.Enabled = False
		Me.BTsalva.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BTsalva.Location = New System.Drawing.Point(1196, 9)
		Me.BTsalva.Name = "BTsalva"
		Me.BTsalva.Size = New System.Drawing.Size(96, 44)
		Me.BTsalva.TabIndex = 81
		Me.BTsalva.Text = "Fine Lavoro"
		Me.BTsalva.UseVisualStyleBackColor = False
		'
		'BtSessione
		'
		Me.BtSessione.BackColor = System.Drawing.Color.LimeGreen
		Me.BtSessione.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtSessione.Location = New System.Drawing.Point(1196, 99)
		Me.BtSessione.Name = "BtSessione"
		Me.BtSessione.Size = New System.Drawing.Size(96, 44)
		Me.BtSessione.TabIndex = 82
		Me.BtSessione.Text = "Salva Sessione"
		Me.BtSessione.UseVisualStyleBackColor = False
		'
		'ComDataUltimoInventarioGenerale
		'
		Me.ComDataUltimoInventarioGenerale.CommandText = "SELECT        TOP (1) DataDocumento" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            ordineFornitore" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE      " &
	"  (NumDocumento = N'INVENTARIO') AND (Societa = @Varditta)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ORDER BY DataDocumen" &
	"to DESC"
		Me.ComDataUltimoInventarioGenerale.Connection = Me.SqlConnection1
		Me.ComDataUltimoInventarioGenerale.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Varditta", System.Data.SqlDbType.NVarChar, 1, "Societa")})
		'
		'SqlComRicercaLotto
		'
		Me.SqlComRicercaLotto.CommandText = resources.GetString("SqlComRicercaLotto.CommandText")
		Me.SqlComRicercaLotto.Connection = Me.SqlConnection1
		Me.SqlComRicercaLotto.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Lotto", System.Data.SqlDbType.NVarChar, 30, "Lotto"), New System.Data.SqlClient.SqlParameter("@DataInventario", System.Data.SqlDbType.SmallDateTime, 4, "Data")})
		'
		'T1Descrizione
		'
		Me.T1Descrizione.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.T1Descrizione.AutoSize = True
		Me.T1Descrizione.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.T1Descrizione.Location = New System.Drawing.Point(52, 1)
		Me.T1Descrizione.Margin = New System.Windows.Forms.Padding(0)
		Me.T1Descrizione.Name = "T1Descrizione"
		Me.T1Descrizione.Size = New System.Drawing.Size(164, 24)
		Me.T1Descrizione.TabIndex = 83
		Me.T1Descrizione.Text = "Merce T1 - MRN"
		Me.T1Descrizione.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'BtMRN
		'
		Me.BtMRN.BackColor = System.Drawing.Color.LimeGreen
		Me.BtMRN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtMRN.Location = New System.Drawing.Point(0, 26)
		Me.BtMRN.Margin = New System.Windows.Forms.Padding(0)
		Me.BtMRN.Name = "BtMRN"
		Me.BtMRN.Size = New System.Drawing.Size(270, 31)
		Me.BtMRN.TabIndex = 84
		Me.BtMRN.UseVisualStyleBackColor = False
		'
		'SqlSelectCommand4
		'
		Me.SqlSelectCommand4.CommandText = resources.GetString("SqlSelectCommand4.CommandText")
		Me.SqlSelectCommand4.Connection = Me.SqlConnDMSQL
		Me.SqlSelectCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@IdVermar", System.Data.SqlDbType.VarChar, 1024, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, "%4093%")})
		'
		'SqlConnDMSQL
		'
		Me.SqlConnDMSQL.ConnectionString = "Data Source=DATASERVER\SQLPROCEDURA;Initial Catalog=DMSQL_VerMar;Persist Security" &
	" Info=True;User ID=sa;Password=31iris46"
		Me.SqlConnDMSQL.FireInfoMessageEventOnUserErrors = False
		'
		'AdapterMRN_DM
		'
		Me.AdapterMRN_DM.SelectCommand = Me.SqlSelectCommand4
		Me.AdapterMRN_DM.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TB_ARTICOLI", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MRN", "MRN"), New System.Data.Common.DataColumnMapping("MASSANETTA_038", "MASSANETTA_038"), New System.Data.Common.DataColumnMapping("MASSALORDA_035", "MASSALORDA_035"), New System.Data.Common.DataColumnMapping("CodVermarDM", "CodVermarDM"), New System.Data.Common.DataColumnMapping("NumRiga", "NumRiga"), New System.Data.Common.DataColumnMapping("CodiceDM", "CodiceDM"), New System.Data.Common.DataColumnMapping("Colli", "Colli"), New System.Data.Common.DataColumnMapping("PROGRESSIVO", "PROGRESSIVO"), New System.Data.Common.DataColumnMapping("ALFA", "ALFA")})})
		'
		'CommMRNuscitiDM
		'
		Me.CommMRNuscitiDM.CommandText = resources.GetString("CommMRNuscitiDM.CommandText")
		Me.CommMRNuscitiDM.Connection = Me.SqlConnDMSQL
		Me.CommMRNuscitiDM.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@MRNCarico", System.Data.SqlDbType.[Char], 50, "DOCUMENTOPRECED_040_IDMRN"), New System.Data.SqlClient.SqlParameter("@NumItemCarico", System.Data.SqlDbType.[Char], 5, "DOCUMENTOPRECED_040_SINGOLORIFPREC")})
		'
		'BtCancMRN
		'
		Me.BtCancMRN.BackColor = System.Drawing.Color.Red
		Me.BtCancMRN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtCancMRN.Location = New System.Drawing.Point(309, 27)
		Me.BtCancMRN.Name = "BtCancMRN"
		Me.BtCancMRN.Size = New System.Drawing.Size(53, 31)
		Me.BtCancMRN.TabIndex = 86
		Me.BtCancMRN.Text = "MRN"
		Me.BtCancMRN.UseVisualStyleBackColor = False
		'
		'Label21
		'
		Me.Label21.AutoSize = True
		Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label21.Location = New System.Drawing.Point(312, 8)
		Me.Label21.Name = "Label21"
		Me.Label21.Size = New System.Drawing.Size(47, 16)
		Me.Label21.TabIndex = 85
		Me.Label21.Text = "Canc."
		Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'C1TrueDBGrid3
		'
		Me.C1TrueDBGrid3.DataMember = "ContainersOrdine"
		Me.C1TrueDBGrid3.DataSource = Me.DsContainerOrdine1
		Me.C1TrueDBGrid3.Enabled = False
		Me.C1TrueDBGrid3.Images.Add(CType(resources.GetObject("C1TrueDBGrid3.Images"), System.Drawing.Image))
		Me.C1TrueDBGrid3.Location = New System.Drawing.Point(890, 7)
		Me.C1TrueDBGrid3.Name = "C1TrueDBGrid3"
		Me.C1TrueDBGrid3.PreviewInfo.Location = New System.Drawing.Point(0, 0)
		Me.C1TrueDBGrid3.PreviewInfo.Size = New System.Drawing.Size(0, 0)
		Me.C1TrueDBGrid3.PreviewInfo.ZoomFactor = 75.0R
		Me.C1TrueDBGrid3.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid3.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
		Me.C1TrueDBGrid3.Size = New System.Drawing.Size(240, 150)
		Me.C1TrueDBGrid3.TabIndex = 77
		Me.C1TrueDBGrid3.Text = "GridOrdine"
		Me.C1TrueDBGrid3.PropBag = resources.GetString("C1TrueDBGrid3.PropBag")
		'
		'C1TrueDBGrid2
		'
		Me.C1TrueDBGrid2.AllowColSelect = False
		Me.C1TrueDBGrid2.AllowFilter = False
		Me.C1TrueDBGrid2.AllowRowSelect = False
		Me.C1TrueDBGrid2.AllowSort = False
		Me.C1TrueDBGrid2.AllowUpdate = False
		Me.C1TrueDBGrid2.Caption = "Prodotti dell'ordine previsti "
		Me.C1TrueDBGrid2.CaptionHeight = 17
		Me.C1TrueDBGrid2.DataSource = Me.DataView1
		Me.C1TrueDBGrid2.Images.Add(CType(resources.GetObject("C1TrueDBGrid2.Images"), System.Drawing.Image))
		Me.C1TrueDBGrid2.Location = New System.Drawing.Point(775, 163)
		Me.C1TrueDBGrid2.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.NoMarquee
		Me.C1TrueDBGrid2.Name = "C1TrueDBGrid2"
		Me.C1TrueDBGrid2.PreviewInfo.Location = New System.Drawing.Point(0, 0)
		Me.C1TrueDBGrid2.PreviewInfo.Size = New System.Drawing.Size(0, 0)
		Me.C1TrueDBGrid2.PreviewInfo.ZoomFactor = 75.0R
		Me.C1TrueDBGrid2.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid2.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
		Me.C1TrueDBGrid2.RecordSelectors = False
		Me.C1TrueDBGrid2.RowHeight = 42
		Me.C1TrueDBGrid2.Size = New System.Drawing.Size(569, 575)
		Me.C1TrueDBGrid2.TabIndex = 71
		Me.C1TrueDBGrid2.Text = "C1TrueDBGrid2"
		Me.C1TrueDBGrid2.PropBag = resources.GetString("C1TrueDBGrid2.PropBag")
		'
		'DataView1
		'
		Me.DataView1.Table = Me.DsOrdineDettagli1.ListGenDettagli
		'
		'DsOrdineDettagli1
		'
		Me.DsOrdineDettagli1.DataSetName = "DsOrdineDettagli"
		Me.DsOrdineDettagli1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'C1TrueDBGrid1
		'
		Me.C1TrueDBGrid1.AllowUpdate = False
		Me.C1TrueDBGrid1.Caption = "Lotti Inseriti"
		Me.C1TrueDBGrid1.CaptionHeight = 17
		Me.C1TrueDBGrid1.DataMember = "TabellaLotti"
		Me.C1TrueDBGrid1.DataSource = Me.DsLotti1
		Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("C1TrueDBGrid1.Images"), System.Drawing.Image))
		Me.C1TrueDBGrid1.Location = New System.Drawing.Point(8, 468)
		Me.C1TrueDBGrid1.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
		Me.C1TrueDBGrid1.Name = "C1TrueDBGrid1"
		Me.C1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
		Me.C1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
		Me.C1TrueDBGrid1.PreviewInfo.ZoomFactor = 75.0R
		Me.C1TrueDBGrid1.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
		Me.C1TrueDBGrid1.RowHeight = 65
		Me.C1TrueDBGrid1.Size = New System.Drawing.Size(761, 349)
		Me.C1TrueDBGrid1.TabIndex = 58
		Me.C1TrueDBGrid1.Text = "C1TrueDBGrid1"
		Me.C1TrueDBGrid1.PropBag = resources.GetString("C1TrueDBGrid1.PropBag")
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.T1Descrizione)
		Me.GroupBox1.Controls.Add(Me.BtCancMRN)
		Me.GroupBox1.Controls.Add(Me.BtMRN)
		Me.GroupBox1.Controls.Add(Me.Label21)
		Me.GroupBox1.Location = New System.Drawing.Point(390, 210)
		Me.GroupBox1.Margin = New System.Windows.Forms.Padding(0)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(383, 60)
		Me.GroupBox1.TabIndex = 87
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Visible = False
		'
		'DsMRNcaricoDM1
		'
		Me.DsMRNcaricoDM1.DataSetName = "DsMRNcaricoDM"
		Me.DsMRNcaricoDM1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'CommNoMRNUscitiDM
		'
		Me.CommNoMRNUscitiDM.CommandText = resources.GetString("CommNoMRNUscitiDM.CommandText")
		Me.CommNoMRNUscitiDM.Connection = Me.SqlConnDMSQL
		Me.CommNoMRNUscitiDM.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumItemCarico", System.Data.SqlDbType.[Char], 5, "DOCUMENTOPRECED_040_SINGOLORIFPREC"), New System.Data.SqlClient.SqlParameter("@NumDocCarico", System.Data.SqlDbType.[Char], 18, "DOCUMENTOPRECED_040_NUMREGISTRAZ"), New System.Data.SqlClient.SqlParameter("@CIN", System.Data.SqlDbType.[Char], 5, "DOCUMENTOPRECED_040_CIN")})
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.LimeGreen
		Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.Location = New System.Drawing.Point(1214, 759)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(96, 44)
		Me.Button1.TabIndex = 88
		Me.Button1.Text = "Esporta in PDF"
		Me.Button1.UseVisualStyleBackColor = False
		'
		'SqlComPassword
		'
		Me.SqlComPassword.CommandText = "SELECT        Password, FlagDiritti, NomeCompleto, Email" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            Tabella" &
	"Password" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE        (LOWER(Utente) LIKE @utente)"
		Me.SqlComPassword.Connection = Me.SqlConnection1
		Me.SqlComPassword.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@utente", System.Data.SqlDbType.VarChar, 1024)})
		'
		'BtSceltaRiga
		'
		Me.BtSceltaRiga.BackColor = System.Drawing.Color.LimeGreen
		Me.BtSceltaRiga.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtSceltaRiga.Location = New System.Drawing.Point(784, 759)
		Me.BtSceltaRiga.Name = "BtSceltaRiga"
		Me.BtSceltaRiga.Size = New System.Drawing.Size(96, 44)
		Me.BtSceltaRiga.TabIndex = 89
		Me.BtSceltaRiga.Text = "Scelta Riga"
		Me.BtSceltaRiga.UseVisualStyleBackColor = False
		'
		'AdapterRicercaLotti
		'
		Me.AdapterRicercaLotti.SelectCommand = Me.SqlSelectCommand5
		Me.AdapterRicercaLotti.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TabellaLotti", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Giacenza", "Giacenza"), New System.Data.Common.DataColumnMapping("Lotto", "Lotto"), New System.Data.Common.DataColumnMapping("Scadenza", "Scadenza")})})
		'
		'SqlSelectCommand5
		'
		Me.SqlSelectCommand5.CommandText = resources.GetString("SqlSelectCommand5.CommandText")
		Me.SqlSelectCommand5.Connection = Me.SqlConnection3
		Me.SqlSelectCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@DataInizio", System.Data.SqlDbType.SmallDateTime, 4, "Data"), New System.Data.SqlClient.SqlParameter("@IdArticolo", System.Data.SqlDbType.BigInt, 8, "IdArticolo")})
		'
		'GroupBox2
		'
		Me.GroupBox2.BackColor = System.Drawing.Color.AntiqueWhite
		Me.GroupBox2.Controls.Add(Me.BTSceltaLotto)
		Me.GroupBox2.Controls.Add(Me.C1TrueDBGrid4)
		Me.GroupBox2.Location = New System.Drawing.Point(773, 312)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(377, 199)
		Me.GroupBox2.TabIndex = 99
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Visible = False
		'
		'BTSceltaLotto
		'
		Me.BTSceltaLotto.BackColor = System.Drawing.Color.LimeGreen
		Me.BTSceltaLotto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BTSceltaLotto.Location = New System.Drawing.Point(11, 19)
		Me.BTSceltaLotto.Name = "BTSceltaLotto"
		Me.BTSceltaLotto.Size = New System.Drawing.Size(27, 150)
		Me.BTSceltaLotto.TabIndex = 101
		Me.BTSceltaLotto.Text = "SCELTA"
		Me.BTSceltaLotto.UseVisualStyleBackColor = False
		'
		'C1TrueDBGrid4
		'
		Me.C1TrueDBGrid4.AllowRowSelect = False
		Me.C1TrueDBGrid4.AllowSort = False
		Me.C1TrueDBGrid4.AllowUpdate = False
		Me.C1TrueDBGrid4.BackColor = System.Drawing.Color.Aquamarine
		Me.C1TrueDBGrid4.DataMember = "TabellaLotti"
		Me.C1TrueDBGrid4.DataSource = Me.DsRicercaLotti1
		Me.C1TrueDBGrid4.FetchRowStyles = True
		Me.C1TrueDBGrid4.Images.Add(CType(resources.GetObject("C1TrueDBGrid4.Images"), System.Drawing.Image))
		Me.C1TrueDBGrid4.Location = New System.Drawing.Point(45, 5)
		Me.C1TrueDBGrid4.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.NoMarquee
		Me.C1TrueDBGrid4.Name = "C1TrueDBGrid4"
		Me.C1TrueDBGrid4.PreviewInfo.Location = New System.Drawing.Point(0, 0)
		Me.C1TrueDBGrid4.PreviewInfo.Size = New System.Drawing.Size(0, 0)
		Me.C1TrueDBGrid4.PreviewInfo.ZoomFactor = 75.0R
		Me.C1TrueDBGrid4.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid4.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
		Me.C1TrueDBGrid4.RecordSelectors = False
		Me.C1TrueDBGrid4.RowHeight = 25
		Me.C1TrueDBGrid4.Size = New System.Drawing.Size(332, 194)
		Me.C1TrueDBGrid4.TabIndex = 0
		Me.C1TrueDBGrid4.Text = "C1TrueDBGrid4"
		Me.C1TrueDBGrid4.PropBag = resources.GetString("C1TrueDBGrid4.PropBag")
		'
		'DsRicercaLotti1
		'
		Me.DsRicercaLotti1.DataSetName = "DsRicercaLotti"
		Me.DsRicercaLotti1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'BtVediLotti
		'
		Me.BtVediLotti.BackColor = System.Drawing.Color.Aqua
		Me.BtVediLotti.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtVediLotti.Location = New System.Drawing.Point(697, 361)
		Me.BtVediLotti.Name = "BtVediLotti"
		Me.BtVediLotti.Size = New System.Drawing.Size(70, 61)
		Me.BtVediLotti.TabIndex = 100
		Me.BtVediLotti.Text = "Vedi Lotti"
		Me.BtVediLotti.UseVisualStyleBackColor = False
		'
		'CommRapportoStorico
		'
		Me.CommRapportoStorico.CommandText = resources.GetString("CommRapportoStorico.CommandText")
		Me.CommRapportoStorico.Connection = Me.SqlConnection1
		Me.CommRapportoStorico.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@DataInizio", System.Data.SqlDbType.SmallDateTime, 4, "Data"), New System.Data.SqlClient.SqlParameter("@Articolo", System.Data.SqlDbType.Int, 4, "progressivo"), New System.Data.SqlClient.SqlParameter("@UDM", System.Data.SqlDbType.NVarChar, 10, "UDM")})
		'
		'GestioneLottiBarre
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoScroll = True
		Me.ClientSize = New System.Drawing.Size(1341, 817)
		Me.Controls.Add(Me.BtVediLotti)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.BtSceltaRiga)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.BtSessione)
		Me.Controls.Add(Me.BTsalva)
		Me.Controls.Add(Me.BtDry)
		Me.Controls.Add(Me.Label20)
		Me.Controls.Add(Me.Label17)
		Me.Controls.Add(Me.C1TrueDBGrid3)
		Me.Controls.Add(Me.BtContainer)
		Me.Controls.Add(Me.BtPallet)
		Me.Controls.Add(Me.Label19)
		Me.Controls.Add(Me.TxtAvviso)
		Me.Controls.Add(Me.C1TrueDBGrid2)
		Me.Controls.Add(Me.TxtColli)
		Me.Controls.Add(Me.Label18)
		Me.Controls.Add(Me.BtProduzione)
		Me.Controls.Add(Me.Label16)
		Me.Controls.Add(Me.TxtScadenza)
		Me.Controls.Add(Me.Label15)
		Me.Controls.Add(Me.TxtQuantitaLotto)
		Me.Controls.Add(Me.Label14)
		Me.Controls.Add(Me.TxTUDMLotto)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.TxtLotto)
		Me.Controls.Add(Me.Label13)
		Me.Controls.Add(Me.C1TrueDBGrid1)
		Me.Controls.Add(Me.BtQuantita)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.BtPacking)
		Me.Controls.Add(Me.TxtItem)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.TxtCamion)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.BTColli)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.TxtQuantOrdine)
		Me.Controls.Add(Me.TxtUdm)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.TxtDesArticolo)
		Me.Controls.Add(Me.TxtIdArticolo)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.TxtLuogoConsegna)
		Me.Controls.Add(Me.TxtDataConsegna)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.TxtCliente)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.TxtRiferimento)
		Me.Controls.Add(Me.TxtOrdineNum)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.TxtScansione)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.ShapeContainer1)
		Me.Name = "GestioneLottiBarre"
		Me.Text = "Form1"
		CType(Me.DsContainerOrdine1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DsLotti1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.C1TrueDBGrid3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.C1TrueDBGrid2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DsOrdineDettagli1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		CType(Me.DsMRNcaricoDM1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox2.ResumeLayout(False)
		CType(Me.C1TrueDBGrid4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DsRicercaLotti1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub



	Private Sub C1TrueDBGrid2_OwnerDrawCell(sender As Object, e As OwnerDrawCellEventArgs) Handles C1TrueDBGrid2.OwnerDrawCell
		Dim Qmag As Decimal = 0
		Dim Qord As Decimal = 0
		Select Case e.Column.Name
			Case "ID"
				If Not IsNumeric(C1TrueDBGrid2.Columns("Quantità Inserita").CellValue(e.Row)) Then e.Style.BackColor() = System.Drawing.Color.LightGray

			Case "Quantità Inserita"
				If IsNumeric(e.Text) Then Qmag = CDec(e.Text)
				If IsNumeric(C1TrueDBGrid2.Columns("Quantità Ordinata").CellValue(e.Row)) Then Qord = CDec(C1TrueDBGrid2.Columns("Quantità Ordinata").CellValue(e.Row))
				If Qmag <> Qord And Qmag > 0 Then
					e.Style.BackColor() = System.Drawing.Color.Salmon
				ElseIf Qmag = Qord Then
					e.Style.BackColor() = System.Drawing.Color.YellowGreen
				End If
			Case "T1"
				If C1TrueDBGrid2(e.Row, "T1").ToString = "*" Then e.Style.BackColor() = System.Drawing.Color.RoyalBlue
			Case "DAA"
				If C1TrueDBGrid2(e.Row, "DAA").ToString = "S" Then e.Style.BackColor() = System.Drawing.Color.Gold
		End Select
	End Sub

	Private Sub C1TrueDBGrid2_MouseUp(sender As Object, e As MouseEventArgs) Handles C1TrueDBGrid2.MouseUp
		C1TrueDBGrid2.FetchRowStyles = True
		TxtScansione.Focus()
	End Sub

	Friend WithEvents Label7 As Label
	Friend WithEvents TxtScansione As TextBox
	Friend WithEvents AdapterGs1AI As SqlClient.SqlDataAdapter
	Friend WithEvents SqlCommand1 As SqlClient.SqlCommand
	Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
	Friend WithEvents TxtRiferimento As Label
	Friend WithEvents TxtOrdineNum As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents TxtCliente As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents TxtDataConsegna As Label
	Friend WithEvents Label12 As Label
	Friend WithEvents TxtLuogoConsegna As Label
	Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
	Friend WithEvents LineShape1 As PowerPacks.LineShape
	Friend WithEvents TxtIdArticolo As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents TxtDesArticolo As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents TxtUdm As Label
	Friend WithEvents TxtQuantOrdine As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents BTColli As Button
	Friend WithEvents Label6 As Label
	Friend WithEvents TxtCamion As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents TxtItem As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents LineShape2 As PowerPacks.LineShape
	Friend WithEvents BtPacking As Button
	Friend WithEvents Label4 As Label
	Friend WithEvents BtQuantita As Button
	Friend WithEvents LineShape3 As PowerPacks.LineShape
	Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
	Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
	Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
	Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
	Friend WithEvents AdapterLottoEsistente As SqlClient.SqlDataAdapter
	Friend WithEvents SqlConnection2 As SqlClient.SqlConnection
	Friend WithEvents C1TrueDBGrid1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
	Friend WithEvents DsLotti1 As DsLotti
	Friend WithEvents TxtLotto As Label
	Friend WithEvents Label13 As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents TxTUDMLotto As Label
	Friend WithEvents Label14 As Label
	Friend WithEvents TxtQuantitaLotto As Label
	Friend WithEvents Label15 As Label
	Friend WithEvents TxtScadenza As Label
	Friend WithEvents Label16 As Label
	Friend WithEvents BtProduzione As Button
	Friend WithEvents TxtColli As Label
	Friend WithEvents Label18 As Label
	Friend WithEvents SqlComUpdateRigheOrdine As SqlClient.SqlCommand
	Friend WithEvents SqlConnection1TEST As SqlClient.SqlConnection
	Friend WithEvents SqlConnection2TEST As SqlClient.SqlConnection
	Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
	Friend WithEvents SqlConnection3 As SqlClient.SqlConnection
	Friend WithEvents AdapterOrdineDettagli As SqlClient.SqlDataAdapter
	Friend WithEvents DsOrdineDettagli1 As DsOrdineDettagli
	Friend WithEvents C1TrueDBGrid2 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
	Friend WithEvents TxtAvviso As Label
	Friend WithEvents LineShape4 As PowerPacks.LineShape
	Friend WithEvents SqlCommand2 As SqlClient.SqlCommand
	Friend WithEvents SqlCommand3 As SqlClient.SqlCommand
	Friend WithEvents SqlCommand4 As SqlClient.SqlCommand
	Friend WithEvents Label19 As Label
	Friend WithEvents BtPallet As Button
	Friend WithEvents BtContainer As Button
	Friend WithEvents C1TrueDBGrid3 As C1TrueDBGrid
	Friend WithEvents DsContainerOrdine1 As DsContainerOrdine
	Friend WithEvents SqlSelectCommand3 As SqlClient.SqlCommand
	Friend WithEvents AdapterContainerOrdini As SqlClient.SqlDataAdapter
	Friend WithEvents Label17 As Label
	Friend WithEvents DataView1 As DataView
	Friend WithEvents Label20 As Label
	Friend WithEvents BtDry As Button
	Friend WithEvents BTsalva As Button
	Friend WithEvents BtSessione As Button
	Friend WithEvents ComDataUltimoInventarioGenerale As SqlClient.SqlCommand
	Friend WithEvents SqlComRicercaLotto As SqlClient.SqlCommand
	Friend WithEvents T1Descrizione As Label
	Friend WithEvents BtMRN As Button
	Friend WithEvents LineShape6 As PowerPacks.LineShape
	Friend WithEvents LineShape5 As PowerPacks.LineShape
	Friend WithEvents SqlSelectCommand4 As SqlClient.SqlCommand
	Friend WithEvents SqlConnDMSQL As SqlClient.SqlConnection
	Friend WithEvents AdapterMRN_DM As SqlClient.SqlDataAdapter
	Friend WithEvents DsMRNcaricoDM1 As DsMRNcaricoDM
	Friend WithEvents CommMRNuscitiDM As SqlClient.SqlCommand
	Friend WithEvents BtCancMRN As Button
	Friend WithEvents Label21 As Label
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents CommNoMRNUscitiDM As SqlClient.SqlCommand
	Friend WithEvents Button1 As Button
	Friend WithEvents C1XLBook1 As C1.C1Excel.C1XLBook
	Friend WithEvents SqlComPassword As SqlClient.SqlCommand
	Friend WithEvents BtSceltaRiga As Button
	Friend WithEvents AdapterRicercaLotti As SqlClient.SqlDataAdapter
	Friend WithEvents SqlSelectCommand5 As SqlClient.SqlCommand
	Friend WithEvents DsRicercaLotti1 As DsRicercaLotti
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents C1TrueDBGrid4 As C1TrueDBGrid
	Friend WithEvents BtVediLotti As Button
	Friend WithEvents BTSceltaLotto As Button
	Friend WithEvents CommRapportoStorico As SqlClient.SqlCommand
End Class
