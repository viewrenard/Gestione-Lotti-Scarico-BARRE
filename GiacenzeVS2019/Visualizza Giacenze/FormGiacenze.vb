Imports CrystalDecisions.CrystalReports.Engine




Public Class FormGiacenze
    Inherits System.Windows.Forms.Form
    Dim riga As DataRow
    Dim riga1 As String
    ' Dim ElementiAI As New DataTable

    Friend Const FNC As String = Chr(33)
    Dim AIDataTable As DataTable
    Friend UDM As String = ""
    Friend excel As String = ""
    Friend DataInventario As Date
    Friend DataInizialeLink As Date
    Friend varditta As Integer
    '  Friend IdProdotto As Integer
    Friend TotInizialiNoKg As Decimal = 0
    Friend TotAcquistiNoKg As Decimal = 0
    Friend totVenditeNoKg As Decimal = 0
    Friend TotInizialiKg As Decimal = 0
    Friend TotAcquistiKg As Decimal = 0
    Friend totVenditeKg As Decimal = 0
    Friend totNonFatturataNoKg As Decimal = 0
    Friend TotNonFatturataKg As Decimal = 0
    Friend TotNonArrivataNoKg As Decimal = 0
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlAdapterLotto As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsLotto1 As Visualizza_Giacenze_Barre.DSLotto
    Friend WithEvents TxtGiacenza As System.Windows.Forms.Button
    Friend WithEvents ComPrezziAcquisto As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsUDM1 As Visualizza_Giacenze_Barre.DsUDM
    Friend WithEvents DsScadenze1 As Visualizza_Giacenze_Barre.DsScadenze
    Friend WithEvents TxtScansione As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtEAN As Label
    Friend WithEvents TxtLotto As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtArticolo As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtDescrizione As Label
    Friend WithEvents TxtScadenza As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As SqlClient.SqlCommand
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtUDM As Label
    Friend WithEvents TxtQuantita As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtPesoNetto As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtPesoLordo As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtIdFornitore As Label
    Friend WithEvents TxtNomeFornitore As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TxTOrdNumVermar As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtNumOrdForn As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents TxtDataOrdForn As Label
    Friend totNonArrivataKg As Decimal = 0
#Region " Codice generato da Progettazione Windows Form "

    Public Sub New()
        MyBase.New()

        'Chiamata richiesta da Progettazione Windows Form.
        InitializeComponent()

        'Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent()

    End Sub

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form.
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents LabGiacenzeIniziali As System.Windows.Forms.Label
    Friend WithEvents TxtGiacenzeIniziali As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComDataUltimoInventarioGenerale As System.Data.SqlClient.SqlCommand
    Friend WithEvents ComUltimoInventarioProdotto As System.Data.SqlClient.SqlCommand
    Friend WithEvents ComAcquistiArrivati As System.Data.SqlClient.SqlCommand
    Friend WithEvents ComAcquistiDaArrivare As System.Data.SqlClient.SqlCommand
    Friend WithEvents ComVenditeFatturate As System.Data.SqlClient.SqlCommand
    Friend WithEvents ComVenditeDaFatturare As System.Data.SqlClient.SqlCommand
    Friend WithEvents TxtAcquisti As System.Windows.Forms.Button
    Friend WithEvents TxtVenduta As System.Windows.Forms.Button
    Friend WithEvents TxtOrdiniNonPervenuti As System.Windows.Forms.Button
    Friend WithEvents TxtImpegnati As System.Windows.Forms.Button
    Friend WithEvents ComAcquistiArrivatiTutti As System.Data.SqlClient.SqlCommand
    Friend WithEvents ComAcquistiDaArrivareTutti As System.Data.SqlClient.SqlCommand
    Friend WithEvents ComVenditeFatturateTutti As System.Data.SqlClient.SqlCommand
    Friend WithEvents ComVenditeDaFatturareTutti As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsDettagliInventario1 As DsDettagliInventario
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents ComUDMListino As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsUDMListino As System.Data.DataSet
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents TxtMessaggio As System.Windows.Forms.Label
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents CMBUDM As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGiacenze))
		Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
		Me.LabGiacenzeIniziali = New System.Windows.Forms.Label()
		Me.TxtGiacenzeIniziali = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.TxtAcquisti = New System.Windows.Forms.Button()
		Me.ComDataUltimoInventarioGenerale = New System.Data.SqlClient.SqlCommand()
		Me.ComUltimoInventarioProdotto = New System.Data.SqlClient.SqlCommand()
		Me.ComAcquistiArrivati = New System.Data.SqlClient.SqlCommand()
		Me.ComAcquistiDaArrivare = New System.Data.SqlClient.SqlCommand()
		Me.ComVenditeFatturate = New System.Data.SqlClient.SqlCommand()
		Me.ComVenditeDaFatturare = New System.Data.SqlClient.SqlCommand()
		Me.TxtVenduta = New System.Windows.Forms.Button()
		Me.TxtOrdiniNonPervenuti = New System.Windows.Forms.Button()
		Me.TxtImpegnati = New System.Windows.Forms.Button()
		Me.ComAcquistiArrivatiTutti = New System.Data.SqlClient.SqlCommand()
		Me.ComAcquistiDaArrivareTutti = New System.Data.SqlClient.SqlCommand()
		Me.ComVenditeFatturateTutti = New System.Data.SqlClient.SqlCommand()
		Me.ComVenditeDaFatturareTutti = New System.Data.SqlClient.SqlCommand()
		Me.DsDettagliInventario1 = New Visualizza_Giacenze_Barre.DsDettagliInventario()
		Me.DsUDMListino = New System.Data.DataSet()
		Me.DataTable1 = New System.Data.DataTable()
		Me.DataColumn1 = New System.Data.DataColumn()
		Me.DataColumn2 = New System.Data.DataColumn()
		Me.DataColumn3 = New System.Data.DataColumn()
		Me.DataColumn4 = New System.Data.DataColumn()
		Me.DataColumn5 = New System.Data.DataColumn()
		Me.DataColumn6 = New System.Data.DataColumn()
		Me.DataColumn7 = New System.Data.DataColumn()
		Me.DataColumn8 = New System.Data.DataColumn()
		Me.ComUDMListino = New System.Data.SqlClient.SqlCommand()
		Me.TxtMessaggio = New System.Windows.Forms.Label()
		Me.CMBUDM = New System.Windows.Forms.ComboBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
		Me.SqlAdapterLotto = New System.Data.SqlClient.SqlDataAdapter()
		Me.DsLotto1 = New Visualizza_Giacenze_Barre.DSLotto()
		Me.TxtGiacenza = New System.Windows.Forms.Button()
		Me.ComPrezziAcquisto = New System.Data.SqlClient.SqlCommand()
		Me.DsUDM1 = New Visualizza_Giacenze_Barre.DsUDM()
		Me.DsScadenze1 = New Visualizza_Giacenze_Barre.DsScadenze()
		Me.TxtScansione = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.TxtEAN = New System.Windows.Forms.Label()
		Me.TxtLotto = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.TxtArticolo = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.TxtDescrizione = New System.Windows.Forms.Label()
		Me.TxtScadenza = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
		Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.TxtUDM = New System.Windows.Forms.Label()
		Me.TxtQuantita = New System.Windows.Forms.Label()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.TxtPesoNetto = New System.Windows.Forms.Label()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.TxtPesoLordo = New System.Windows.Forms.Label()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.TxtIdFornitore = New System.Windows.Forms.Label()
		Me.TxtNomeFornitore = New System.Windows.Forms.Label()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.TxTOrdNumVermar = New System.Windows.Forms.Label()
		Me.Label18 = New System.Windows.Forms.Label()
		Me.TxtNumOrdForn = New System.Windows.Forms.Label()
		Me.Label19 = New System.Windows.Forms.Label()
		Me.TxtDataOrdForn = New System.Windows.Forms.Label()
		CType(Me.DsDettagliInventario1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DsUDMListino, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DsLotto1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DsUDM1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DsScadenze1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'SqlConnection1
		'
		Me.SqlConnection1.ConnectionString = "Data Source=DATASERVER\SQLPROCEDURA;Initial Catalog=vermarnew;User ID=fox;Passwor" &
	"d=31iris46"
		Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
		'
		'LabGiacenzeIniziali
		'
		Me.LabGiacenzeIniziali.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabGiacenzeIniziali.Location = New System.Drawing.Point(14, 227)
		Me.LabGiacenzeIniziali.Name = "LabGiacenzeIniziali"
		Me.LabGiacenzeIniziali.Size = New System.Drawing.Size(168, 23)
		Me.LabGiacenzeIniziali.TabIndex = 0
		Me.LabGiacenzeIniziali.Text = "Giacenze Iniziali al 31/12/2010"
		Me.LabGiacenzeIniziali.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TxtGiacenzeIniziali
		'
		Me.TxtGiacenzeIniziali.BackColor = System.Drawing.SystemColors.HighlightText
		Me.TxtGiacenzeIniziali.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtGiacenzeIniziali.Location = New System.Drawing.Point(182, 227)
		Me.TxtGiacenzeIniziali.Name = "TxtGiacenzeIniziali"
		Me.TxtGiacenzeIniziali.Size = New System.Drawing.Size(112, 23)
		Me.TxtGiacenzeIniziali.TabIndex = 1
		Me.TxtGiacenzeIniziali.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label1
		'
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(14, 259)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(267, 23)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "Merce Pervenuta ad Oggi"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label2
		'
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(13, 289)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(242, 23)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Merce Venduta ad Oggi"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label3
		'
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(14, 330)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(200, 23)
		Me.Label3.TabIndex = 6
		Me.Label3.Text = "Giacenza Contabile"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label4
		'
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(480, 221)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(177, 67)
		Me.Label4.TabIndex = 8
		Me.Label4.Text = "Merce Ordinata e non Pervenuta"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label5
		'
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(484, 318)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(173, 75)
		Me.Label5.TabIndex = 9
		Me.Label5.Text = "Merce Impegnata su Ordini"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TxtAcquisti
		'
		Me.TxtAcquisti.BackColor = System.Drawing.SystemColors.HighlightText
		Me.TxtAcquisti.Cursor = System.Windows.Forms.Cursors.Hand
		Me.TxtAcquisti.Enabled = False
		Me.TxtAcquisti.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.TxtAcquisti.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtAcquisti.Location = New System.Drawing.Point(272, 259)
		Me.TxtAcquisti.Name = "TxtAcquisti"
		Me.TxtAcquisti.Size = New System.Drawing.Size(112, 29)
		Me.TxtAcquisti.TabIndex = 12
		Me.TxtAcquisti.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.TxtAcquisti.UseVisualStyleBackColor = False
		'
		'ComDataUltimoInventarioGenerale
		'
		Me.ComDataUltimoInventarioGenerale.CommandText = "SELECT TOP 1 DataDocumento FROM ordineFornitore WHERE (NumDocumento = N'INVENTARI" &
	"O') AND (Societa = @Varditta) ORDER BY DataDocumento DESC"
		Me.ComDataUltimoInventarioGenerale.Connection = Me.SqlConnection1
		Me.ComDataUltimoInventarioGenerale.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Varditta", System.Data.SqlDbType.NVarChar, 1, "Societa")})
		'
		'ComUltimoInventarioProdotto
		'
		Me.ComUltimoInventarioProdotto.CommandText = resources.GetString("ComUltimoInventarioProdotto.CommandText")
		Me.ComUltimoInventarioProdotto.Connection = Me.SqlConnection1
		Me.ComUltimoInventarioProdotto.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Varditta", System.Data.SqlDbType.NVarChar, 1, "Societa"), New System.Data.SqlClient.SqlParameter("@IdProdotto", System.Data.SqlDbType.Int, 4, "IdArticolo"), New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.SmallDateTime, 4, "Data")})
		'
		'ComAcquistiArrivati
		'
		Me.ComAcquistiArrivati.CommandText = resources.GetString("ComAcquistiArrivati.CommandText")
		Me.ComAcquistiArrivati.Connection = Me.SqlConnection1
		Me.ComAcquistiArrivati.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Varditta", System.Data.SqlDbType.NVarChar, 1, "Societa"), New System.Data.SqlClient.SqlParameter("@IdProdotto", System.Data.SqlDbType.Int, 4, "IdArticolo"), New System.Data.SqlClient.SqlParameter("@Datainizio", System.Data.SqlDbType.DateTime, 8, "DATADOCUMENTO")})
		'
		'ComAcquistiDaArrivare
		'
		Me.ComAcquistiDaArrivare.CommandText = resources.GetString("ComAcquistiDaArrivare.CommandText")
		Me.ComAcquistiDaArrivare.Connection = Me.SqlConnection1
		Me.ComAcquistiDaArrivare.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Varditta", System.Data.SqlDbType.NVarChar, 1, "Societa"), New System.Data.SqlClient.SqlParameter("@IdProdotto", System.Data.SqlDbType.Int, 4, "IdArticolo"), New System.Data.SqlClient.SqlParameter("@Datainizio", System.Data.SqlDbType.SmallDateTime, 4, "Data")})
		'
		'ComVenditeFatturate
		'
		Me.ComVenditeFatturate.CommandText = resources.GetString("ComVenditeFatturate.CommandText")
		Me.ComVenditeFatturate.Connection = Me.SqlConnection1
		Me.ComVenditeFatturate.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Varditta", System.Data.SqlDbType.NVarChar, 1, "Societa"), New System.Data.SqlClient.SqlParameter("@datainizio", System.Data.SqlDbType.DateTime, 4, "Data"), New System.Data.SqlClient.SqlParameter("@Idprodotto", System.Data.SqlDbType.Int, 4, "progressivo")})
		'
		'ComVenditeDaFatturare
		'
		Me.ComVenditeDaFatturare.CommandText = resources.GetString("ComVenditeDaFatturare.CommandText")
		Me.ComVenditeDaFatturare.Connection = Me.SqlConnection1
		Me.ComVenditeDaFatturare.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@datainizio", System.Data.SqlDbType.DateTime, 4, "dataConsegna"), New System.Data.SqlClient.SqlParameter("@Varditta", System.Data.SqlDbType.NVarChar, 1, "Societa"), New System.Data.SqlClient.SqlParameter("@Idprodotto", System.Data.SqlDbType.Int, 4, "progressivo")})
		'
		'TxtVenduta
		'
		Me.TxtVenduta.BackColor = System.Drawing.SystemColors.HighlightText
		Me.TxtVenduta.Cursor = System.Windows.Forms.Cursors.Hand
		Me.TxtVenduta.Enabled = False
		Me.TxtVenduta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.TxtVenduta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtVenduta.Location = New System.Drawing.Point(272, 289)
		Me.TxtVenduta.Name = "TxtVenduta"
		Me.TxtVenduta.Size = New System.Drawing.Size(112, 29)
		Me.TxtVenduta.TabIndex = 13
		Me.TxtVenduta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.TxtVenduta.UseVisualStyleBackColor = False
		'
		'TxtOrdiniNonPervenuti
		'
		Me.TxtOrdiniNonPervenuti.BackColor = System.Drawing.SystemColors.HighlightText
		Me.TxtOrdiniNonPervenuti.Cursor = System.Windows.Forms.Cursors.Hand
		Me.TxtOrdiniNonPervenuti.Enabled = False
		Me.TxtOrdiniNonPervenuti.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.TxtOrdiniNonPervenuti.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtOrdiniNonPervenuti.Location = New System.Drawing.Point(512, 286)
		Me.TxtOrdiniNonPervenuti.Name = "TxtOrdiniNonPervenuti"
		Me.TxtOrdiniNonPervenuti.Size = New System.Drawing.Size(112, 29)
		Me.TxtOrdiniNonPervenuti.TabIndex = 14
		Me.TxtOrdiniNonPervenuti.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.TxtOrdiniNonPervenuti.UseVisualStyleBackColor = False
		'
		'TxtImpegnati
		'
		Me.TxtImpegnati.BackColor = System.Drawing.SystemColors.HighlightText
		Me.TxtImpegnati.Cursor = System.Windows.Forms.Cursors.Hand
		Me.TxtImpegnati.Enabled = False
		Me.TxtImpegnati.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.TxtImpegnati.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtImpegnati.Location = New System.Drawing.Point(512, 396)
		Me.TxtImpegnati.Name = "TxtImpegnati"
		Me.TxtImpegnati.Size = New System.Drawing.Size(112, 29)
		Me.TxtImpegnati.TabIndex = 15
		Me.TxtImpegnati.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.TxtImpegnati.UseVisualStyleBackColor = False
		'
		'ComAcquistiArrivatiTutti
		'
		Me.ComAcquistiArrivatiTutti.CommandText = resources.GetString("ComAcquistiArrivatiTutti.CommandText")
		Me.ComAcquistiArrivatiTutti.Connection = Me.SqlConnection1
		Me.ComAcquistiArrivatiTutti.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Varditta", System.Data.SqlDbType.NVarChar, 1, "Societa"), New System.Data.SqlClient.SqlParameter("@IdProdotto", System.Data.SqlDbType.Int, 4, "IdArticolo"), New System.Data.SqlClient.SqlParameter("@Datainizio", System.Data.SqlDbType.DateTime, 8, "DataConsegna")})
		'
		'ComAcquistiDaArrivareTutti
		'
		Me.ComAcquistiDaArrivareTutti.CommandText = resources.GetString("ComAcquistiDaArrivareTutti.CommandText")
		Me.ComAcquistiDaArrivareTutti.Connection = Me.SqlConnection1
		Me.ComAcquistiDaArrivareTutti.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Varditta", System.Data.SqlDbType.NVarChar, 1, "Societa"), New System.Data.SqlClient.SqlParameter("@IdProdotto", System.Data.SqlDbType.Int, 4, "IdArticolo"), New System.Data.SqlClient.SqlParameter("@Datainizio", System.Data.SqlDbType.SmallDateTime, 4, "DataConsegna")})
		'
		'ComVenditeFatturateTutti
		'
		Me.ComVenditeFatturateTutti.CommandText = resources.GetString("ComVenditeFatturateTutti.CommandText")
		Me.ComVenditeFatturateTutti.Connection = Me.SqlConnection1
		Me.ComVenditeFatturateTutti.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Varditta", System.Data.SqlDbType.NVarChar, 1, "Societa"), New System.Data.SqlClient.SqlParameter("@datainizio", System.Data.SqlDbType.SmallDateTime, 4, "DataOrdine"), New System.Data.SqlClient.SqlParameter("@Idprodotto", System.Data.SqlDbType.Int, 4, "progressivo")})
		'
		'ComVenditeDaFatturareTutti
		'
		Me.ComVenditeDaFatturareTutti.CommandText = resources.GetString("ComVenditeDaFatturareTutti.CommandText")
		Me.ComVenditeDaFatturareTutti.Connection = Me.SqlConnection1
		Me.ComVenditeDaFatturareTutti.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Idprodotto", System.Data.SqlDbType.Int, 4, "progressivo"), New System.Data.SqlClient.SqlParameter("@Varditta", System.Data.SqlDbType.NVarChar, 1, "Societa"), New System.Data.SqlClient.SqlParameter("@DataInizio", System.Data.SqlDbType.SmallDateTime, 4, "DataConsegna")})
		'
		'DsDettagliInventario1
		'
		Me.DsDettagliInventario1.DataSetName = "DsDettagliInventario"
		Me.DsDettagliInventario1.Locale = New System.Globalization.CultureInfo("en-US")
		Me.DsDettagliInventario1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'DsUDMListino
		'
		Me.DsUDMListino.DataSetName = "NewDataSet"
		Me.DsUDMListino.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
		'
		'DataTable1
		'
		Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8})
		Me.DataTable1.TableName = "Table1"
		'
		'DataColumn1
		'
		Me.DataColumn1.ColumnName = "UDM"
		'
		'DataColumn2
		'
		Me.DataColumn2.ColumnName = "Rapporto"
		'
		'DataColumn3
		'
		Me.DataColumn3.ColumnName = "Giacenze"
		Me.DataColumn3.DataType = GetType(Decimal)
		'
		'DataColumn4
		'
		Me.DataColumn4.ColumnName = "Carico"
		Me.DataColumn4.DataType = GetType(Decimal)
		'
		'DataColumn5
		'
		Me.DataColumn5.ColumnName = "Scarico"
		Me.DataColumn5.DataType = GetType(Decimal)
		'
		'DataColumn6
		'
		Me.DataColumn6.ColumnName = "NonFatturata"
		Me.DataColumn6.DataType = GetType(Decimal)
		'
		'DataColumn7
		'
		Me.DataColumn7.ColumnName = "NonArrivata"
		Me.DataColumn7.DataType = GetType(Decimal)
		'
		'DataColumn8
		'
		Me.DataColumn8.ColumnName = "FlagIncongruenza"
		Me.DataColumn8.DataType = GetType(Boolean)
		'
		'ComUDMListino
		'
		Me.ComUDMListino.CommandText = "SELECT        UDM, RapportoUnita1, Confezioni, RapportoUnita2, Cartoni, RapportoU" &
	"nita3, Descrizione" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            ListGenDettagli" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE        (Progressivo =" &
	" @IdProdotto)"
		Me.ComUDMListino.Connection = Me.SqlConnection1
		Me.ComUDMListino.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@IdProdotto", System.Data.SqlDbType.Int, 4, "Progressivo")})
		'
		'TxtMessaggio
		'
		Me.TxtMessaggio.BackColor = System.Drawing.SystemColors.HighlightText
		Me.TxtMessaggio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtMessaggio.Location = New System.Drawing.Point(14, 390)
		Me.TxtMessaggio.Name = "TxtMessaggio"
		Me.TxtMessaggio.Size = New System.Drawing.Size(492, 91)
		Me.TxtMessaggio.TabIndex = 17
		Me.TxtMessaggio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'CMBUDM
		'
		Me.CMBUDM.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CMBUDM.Location = New System.Drawing.Point(225, 355)
		Me.CMBUDM.Name = "CMBUDM"
		Me.CMBUDM.Size = New System.Drawing.Size(96, 32)
		Me.CMBUDM.TabIndex = 18
		'
		'Label6
		'
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(14, 359)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(216, 23)
		Me.Label6.TabIndex = 19
		Me.Label6.Text = "Visualizza Altre UDM Previste"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'SqlSelectCommand1
		'
		Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
		Me.SqlSelectCommand1.Connection = Me.SqlConnection1
		Me.SqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Prodotto", System.Data.SqlDbType.Int, 4, "IdProdotto"), New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.VarChar, 3, "DataScadenza")})
		'
		'SqlAdapterLotto
		'
		Me.SqlAdapterLotto.SelectCommand = Me.SqlSelectCommand1
		Me.SqlAdapterLotto.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TabellaLotti", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Giacenza", "Giacenza"), New System.Data.Common.DataColumnMapping("DataScadenza", "DataScadenza"), New System.Data.Common.DataColumnMapping("Lotto", "Lotto")})})
		'
		'DsLotto1
		'
		Me.DsLotto1.DataSetName = "DSLotto"
		Me.DsLotto1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'TxtGiacenza
		'
		Me.TxtGiacenza.BackColor = System.Drawing.SystemColors.HighlightText
		Me.TxtGiacenza.Cursor = System.Windows.Forms.Cursors.Hand
		Me.TxtGiacenza.Enabled = False
		Me.TxtGiacenza.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.TxtGiacenza.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtGiacenza.Location = New System.Drawing.Point(272, 324)
		Me.TxtGiacenza.Name = "TxtGiacenza"
		Me.TxtGiacenza.Size = New System.Drawing.Size(112, 29)
		Me.TxtGiacenza.TabIndex = 21
		Me.TxtGiacenza.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.TxtGiacenza.UseVisualStyleBackColor = False
		'
		'ComPrezziAcquisto
		'
		Me.ComPrezziAcquisto.CommandText = resources.GetString("ComPrezziAcquisto.CommandText")
		Me.ComPrezziAcquisto.Connection = Me.SqlConnection1
		Me.ComPrezziAcquisto.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Articolo", System.Data.SqlDbType.Int, 4, "IdArticolo"), New System.Data.SqlClient.SqlParameter("@datainizio", System.Data.SqlDbType.DateTime, 8, "DataDocumento"), New System.Data.SqlClient.SqlParameter("@datafine", System.Data.SqlDbType.DateTime, 8, "DataDocumento")})
		'
		'DsUDM1
		'
		Me.DsUDM1.DataSetName = "DsUDM"
		Me.DsUDM1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'DsScadenze1
		'
		Me.DsScadenze1.DataSetName = "DsScadenze"
		Me.DsScadenze1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'TxtScansione
		'
		Me.TxtScansione.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtScansione.Location = New System.Drawing.Point(117, -3)
		Me.TxtScansione.Name = "TxtScansione"
		Me.TxtScansione.Size = New System.Drawing.Size(569, 26)
		Me.TxtScansione.TabIndex = 0
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(3, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(108, 24)
		Me.Label7.TabIndex = 23
		Me.Label7.Text = "Scansione"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(3, 88)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(103, 24)
		Me.Label8.TabIndex = 24
		Me.Label8.Text = "Cod. EAN"
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TxtEAN
		'
		Me.TxtEAN.BackColor = System.Drawing.Color.PaleGreen
		Me.TxtEAN.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtEAN.Location = New System.Drawing.Point(113, 88)
		Me.TxtEAN.Name = "TxtEAN"
		Me.TxtEAN.Size = New System.Drawing.Size(164, 24)
		Me.TxtEAN.TabIndex = 25
		Me.TxtEAN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TxtLotto
		'
		Me.TxtLotto.BackColor = System.Drawing.Color.PaleGreen
		Me.TxtLotto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtLotto.Location = New System.Drawing.Point(438, 88)
		Me.TxtLotto.Name = "TxtLotto"
		Me.TxtLotto.Size = New System.Drawing.Size(248, 24)
		Me.TxtLotto.TabIndex = 27
		Me.TxtLotto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.Location = New System.Drawing.Point(387, 88)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(55, 24)
		Me.Label11.TabIndex = 26
		Me.Label11.Text = "Lotto"
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TxtArticolo
		'
		Me.TxtArticolo.BackColor = System.Drawing.Color.PaleGreen
		Me.TxtArticolo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtArticolo.Location = New System.Drawing.Point(116, 29)
		Me.TxtArticolo.Name = "TxtArticolo"
		Me.TxtArticolo.Size = New System.Drawing.Size(89, 24)
		Me.TxtArticolo.TabIndex = 29
		Me.TxtArticolo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.Location = New System.Drawing.Point(6, 29)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(88, 24)
		Me.Label10.TabIndex = 28
		Me.Label10.Text = "Prodotto"
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TxtDescrizione
		'
		Me.TxtDescrizione.BackColor = System.Drawing.Color.PaleGreen
		Me.TxtDescrizione.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtDescrizione.Location = New System.Drawing.Point(242, 29)
		Me.TxtDescrizione.Name = "TxtDescrizione"
		Me.TxtDescrizione.Size = New System.Drawing.Size(444, 44)
		Me.TxtDescrizione.TabIndex = 30
		'
		'TxtScadenza
		'
		Me.TxtScadenza.BackColor = System.Drawing.Color.PaleGreen
		Me.TxtScadenza.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtScadenza.Location = New System.Drawing.Point(525, 122)
		Me.TxtScadenza.Name = "TxtScadenza"
		Me.TxtScadenza.Size = New System.Drawing.Size(164, 24)
		Me.TxtScadenza.TabIndex = 32
		Me.TxtScadenza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.Location = New System.Drawing.Point(389, 122)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(102, 24)
		Me.Label12.TabIndex = 31
		Me.Label12.Text = "Scadenza"
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'SqlDataAdapter1
		'
		Me.SqlDataAdapter1.SelectCommand = Me.SqlCommand1
		Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TabellaAI-GS1", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("AI", "AI"), New System.Data.Common.DataColumnMapping("Descrizione", "Descrizione"), New System.Data.Common.DataColumnMapping("LunghezzaMax", "LunghezzaMax"), New System.Data.Common.DataColumnMapping("FNC1", "FNC1")})})
		'
		'SqlCommand1
		'
		Me.SqlCommand1.CommandText = "SELECT        [TabellaAI-GS1].*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            [TabellaAI-GS1]"
		Me.SqlCommand1.Connection = Me.SqlConnection1
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.Location = New System.Drawing.Point(6, 122)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(55, 24)
		Me.Label9.TabIndex = 33
		Me.Label9.Text = "UDM"
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TxtUDM
		'
		Me.TxtUDM.BackColor = System.Drawing.Color.PaleGreen
		Me.TxtUDM.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtUDM.Location = New System.Drawing.Point(67, 122)
		Me.TxtUDM.Name = "TxtUDM"
		Me.TxtUDM.Size = New System.Drawing.Size(47, 24)
		Me.TxtUDM.TabIndex = 34
		Me.TxtUDM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TxtQuantita
		'
		Me.TxtQuantita.BackColor = System.Drawing.Color.PaleGreen
		Me.TxtQuantita.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtQuantita.Location = New System.Drawing.Point(198, 122)
		Me.TxtQuantita.Name = "TxtQuantita"
		Me.TxtQuantita.Size = New System.Drawing.Size(96, 24)
		Me.TxtQuantita.TabIndex = 36
		Me.TxtQuantita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label14.Location = New System.Drawing.Point(120, 122)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(72, 24)
		Me.Label14.TabIndex = 35
		Me.Label14.Text = "Quant."
		Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TxtPesoNetto
		'
		Me.TxtPesoNetto.BackColor = System.Drawing.Color.PaleGreen
		Me.TxtPesoNetto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtPesoNetto.Location = New System.Drawing.Point(126, 160)
		Me.TxtPesoNetto.Name = "TxtPesoNetto"
		Me.TxtPesoNetto.Size = New System.Drawing.Size(129, 24)
		Me.TxtPesoNetto.TabIndex = 38
		Me.TxtPesoNetto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label15.Location = New System.Drawing.Point(8, 160)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(112, 24)
		Me.Label15.TabIndex = 37
		Me.Label15.Text = "Peso Netto"
		Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TxtPesoLordo
		'
		Me.TxtPesoLordo.BackColor = System.Drawing.Color.PaleGreen
		Me.TxtPesoLordo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtPesoLordo.Location = New System.Drawing.Point(525, 160)
		Me.TxtPesoLordo.Name = "TxtPesoLordo"
		Me.TxtPesoLordo.Size = New System.Drawing.Size(129, 24)
		Me.TxtPesoLordo.TabIndex = 40
		Me.TxtPesoLordo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label16.Location = New System.Drawing.Point(389, 160)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(117, 24)
		Me.Label16.TabIndex = 39
		Me.Label16.Text = "Peso Lordo"
		Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label13
		'
		Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label13.Location = New System.Drawing.Point(14, 495)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(97, 23)
		Me.Label13.TabIndex = 41
		Me.Label13.Text = "Fornitore"
		Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TxtIdFornitore
		'
		Me.TxtIdFornitore.BackColor = System.Drawing.Color.PaleGreen
		Me.TxtIdFornitore.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtIdFornitore.Location = New System.Drawing.Point(113, 495)
		Me.TxtIdFornitore.Name = "TxtIdFornitore"
		Me.TxtIdFornitore.Size = New System.Drawing.Size(79, 24)
		Me.TxtIdFornitore.TabIndex = 42
		Me.TxtIdFornitore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TxtNomeFornitore
		'
		Me.TxtNomeFornitore.BackColor = System.Drawing.Color.PaleGreen
		Me.TxtNomeFornitore.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtNomeFornitore.Location = New System.Drawing.Point(221, 494)
		Me.TxtNomeFornitore.Name = "TxtNomeFornitore"
		Me.TxtNomeFornitore.Size = New System.Drawing.Size(436, 24)
		Me.TxtNomeFornitore.TabIndex = 43
		Me.TxtNomeFornitore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label17
		'
		Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label17.Location = New System.Drawing.Point(2, 58)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(107, 23)
		Me.Label17.TabIndex = 44
		Me.Label17.Text = "Ord. Num."
		Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TxTOrdNumVermar
		'
		Me.TxTOrdNumVermar.BackColor = System.Drawing.Color.GreenYellow
		Me.TxTOrdNumVermar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxTOrdNumVermar.Location = New System.Drawing.Point(113, 58)
		Me.TxTOrdNumVermar.Name = "TxTOrdNumVermar"
		Me.TxTOrdNumVermar.Size = New System.Drawing.Size(100, 24)
		Me.TxTOrdNumVermar.TabIndex = 45
		Me.TxTOrdNumVermar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label18
		'
		Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label18.Location = New System.Drawing.Point(14, 529)
		Me.Label18.Name = "Label18"
		Me.Label18.Size = New System.Drawing.Size(103, 23)
		Me.Label18.TabIndex = 46
		Me.Label18.Text = "DDT/Fatt."
		Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TxtNumOrdForn
		'
		Me.TxtNumOrdForn.BackColor = System.Drawing.Color.PaleGreen
		Me.TxtNumOrdForn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtNumOrdForn.Location = New System.Drawing.Point(116, 529)
		Me.TxtNumOrdForn.Name = "TxtNumOrdForn"
		Me.TxtNumOrdForn.Size = New System.Drawing.Size(139, 24)
		Me.TxtNumOrdForn.TabIndex = 47
		Me.TxtNumOrdForn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label19
		'
		Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label19.Location = New System.Drawing.Point(268, 529)
		Me.Label19.Name = "Label19"
		Me.Label19.Size = New System.Drawing.Size(53, 23)
		Me.Label19.TabIndex = 48
		Me.Label19.Text = "Del"
		Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TxtDataOrdForn
		'
		Me.TxtDataOrdForn.BackColor = System.Drawing.Color.PaleGreen
		Me.TxtDataOrdForn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtDataOrdForn.Location = New System.Drawing.Point(312, 528)
		Me.TxtDataOrdForn.Name = "TxtDataOrdForn"
		Me.TxtDataOrdForn.Size = New System.Drawing.Size(139, 24)
		Me.TxtDataOrdForn.TabIndex = 49
		Me.TxtDataOrdForn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'FormGiacenze
		'
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.ClientSize = New System.Drawing.Size(704, 901)
		Me.Controls.Add(Me.TxtDataOrdForn)
		Me.Controls.Add(Me.Label19)
		Me.Controls.Add(Me.TxtNumOrdForn)
		Me.Controls.Add(Me.Label18)
		Me.Controls.Add(Me.TxTOrdNumVermar)
		Me.Controls.Add(Me.Label17)
		Me.Controls.Add(Me.TxtNomeFornitore)
		Me.Controls.Add(Me.TxtIdFornitore)
		Me.Controls.Add(Me.Label13)
		Me.Controls.Add(Me.TxtPesoLordo)
		Me.Controls.Add(Me.Label16)
		Me.Controls.Add(Me.TxtPesoNetto)
		Me.Controls.Add(Me.Label15)
		Me.Controls.Add(Me.TxtQuantita)
		Me.Controls.Add(Me.Label14)
		Me.Controls.Add(Me.TxtUDM)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.TxtScadenza)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.TxtDescrizione)
		Me.Controls.Add(Me.TxtArticolo)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.TxtLotto)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.TxtEAN)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.TxtScansione)
		Me.Controls.Add(Me.TxtGiacenza)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.CMBUDM)
		Me.Controls.Add(Me.TxtMessaggio)
		Me.Controls.Add(Me.TxtImpegnati)
		Me.Controls.Add(Me.TxtOrdiniNonPervenuti)
		Me.Controls.Add(Me.TxtVenduta)
		Me.Controls.Add(Me.TxtAcquisti)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.TxtGiacenzeIniziali)
		Me.Controls.Add(Me.LabGiacenzeIniziali)
		Me.Name = "FormGiacenze"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Giacenze"
		CType(Me.DsDettagliInventario1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DsUDMListino, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DsLotto1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DsUDM1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DsScadenze1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

#End Region
	Friend Sub Carico_Giacenze(Articolo As Integer)
        'Carico le unità di misura previste per il prodotto
        Dim leggo As SqlClient.SqlDataReader
        Dim Confronto As String = ""
        DsUDMListino.Clear()
        If ComUDMListino.Connection.State = ConnectionState.Closed Then ComUDMListino.Connection.Open()
        ComUDMListino.Parameters("@Idprodotto").Value = Articolo
        leggo = ComUDMListino.ExecuteReader
        leggo.Read()
        TxtDescrizione.Text = leggo("Descrizione").ToString
        'Carico il DS che mi servirà per i prezzi di acquisto, scadenze, lotti
        DsUDM1.Clear()
        Dim rigUDM As DataRow = DsUDM1.Tables(0).NewRow
        If leggo("UDM").ToString <> "" Then rigUDM("UDM") = leggo("UDM")
        If leggo("RapportoUnita1").ToString <> "" Then rigUDM("Rapporto") = leggo("RapportoUnita1")
        DsUDM1.Tables(0).Rows.Add(rigUDM)
        rigUDM = DsUDM1.Tables(0).NewRow
        If leggo("Confezioni").ToString <> "" Then rigUDM("UDM") = leggo("Confezioni")
        If leggo("RapportoUnita2").ToString <> "" Then rigUDM("Rapporto") = leggo("RapportoUnita2")
        DsUDM1.Tables(0).Rows.Add(rigUDM)
        rigUDM = DsUDM1.Tables(0).NewRow
        If leggo("Cartoni").ToString <> "" Then rigUDM("UDM") = leggo("Cartoni")
        If leggo("RapportoUnita3").ToString <> "" Then
            rigUDM("Rapporto") = leggo("RapportoUnita3")
            DsUDM1.Tables(0).Rows.Add(rigUDM)
        End If

        'Aggiungo sempre l'UDM KG.
        rigUDM = DsUDM1.Tables(0).NewRow
        rigUDM("UDM") = "KG."
        rigUDM("Rapporto") = 1
        DsUDM1.Tables(0).Rows.Add(rigUDM)

        Dim riga As DataRow = DsUDMListino.Tables(0).NewRow
        riga("FlagIncongruenza") = False
        riga("Udm") = leggo(0)
        riga("Rapporto") = leggo(1)
        riga("Giacenze") = 0
        riga("Carico") = 0
        riga("Scarico") = 0
        riga("NonFatturata") = 0
        riga("NonArrivata") = 0
        DsUDMListino.Tables(0).Rows.Add(riga)
        riga = DsUDMListino.Tables(0).NewRow
        riga("FlagIncongruenza") = False
        riga("Udm") = leggo(2)
        riga("Rapporto") = leggo(3)
        riga("Giacenze") = 0
        riga("Carico") = 0
        riga("Scarico") = 0
        riga("NonFatturata") = 0
        riga("NonArrivata") = 0
        If leggo(2).ToString <> leggo(0).ToString Then DsUDMListino.Tables(0).Rows.Add(riga)
        riga = DsUDMListino.Tables(0).NewRow
        riga("FlagIncongruenza") = False
        riga("Udm") = leggo(4)
        riga("Rapporto") = leggo(5)
        riga("Giacenze") = 0
        riga("Carico") = 0
        riga("Scarico") = 0
        riga("NonFatturata") = 0
        riga("NonArrivata") = 0
        If leggo(4).ToString <> leggo(0).ToString And leggo(4).ToString <> leggo(2).ToString And leggo(4).ToString <> "" Then DsUDMListino.Tables(0).Rows.Add(riga)
        leggo.Close()
        'cerco la data dell'ultimo inventario (Intestazione)
        If ComDataUltimoInventarioGenerale.Connection.State = ConnectionState.Closed Then ComDataUltimoInventarioGenerale.Connection.Open()
        ComDataUltimoInventarioGenerale.Parameters("@Varditta").Value = varditta
        If Not ComDataUltimoInventarioGenerale.ExecuteScalar Is Nothing Then DataInventario = CDate(ComDataUltimoInventarioGenerale.ExecuteScalar) Else DataInventario = CDate("01/01/" & Str(Today.Year))
        'Vedo se il prodotto è stato inventariato in una data successiva
        TxtGiacenzeIniziali.Text = "0"

        ComUltimoInventarioProdotto.Parameters("@Varditta").Value = varditta
        ComUltimoInventarioProdotto.Parameters("@idprodotto").Value = Articolo
        ComUltimoInventarioProdotto.Parameters("@Data").Value = DataInventario
        leggo = ComUltimoInventarioProdotto.ExecuteReader
        While leggo.Read()

            DataInventario = CDate(CDate(leggo("datainventario")).ToShortDateString & " 23:00:00")
            Confronto = ""
            For Each riga In DsUDMListino.Tables(0).Rows
                Confronto = Confronto + riga("UDM").ToString.Trim
                If riga("UDM").ToString = leggo("UDM").ToString Then
                    If IsNumeric(leggo("quantitaconsegnata")) Then riga("Giacenze") = leggo("Quantitaconsegnata") Else If IsNumeric(leggo("quantitaordinata")) Then riga("Giacenze") = leggo("Quantitaordinata")
                End If

            Next
            If Confronto.IndexOf(leggo("UDM").ToString) = -1 Then
                riga("FlagIncongruenza") = True
            End If
        End While
        leggo.Close()
        'aggiungo un giorno alla data dell'inventario
        DataInventario = DataInventario.AddDays(1)
        TxtAcquisti.Text = "0"

        'calcolo gli acquisti da quella data
        ComAcquistiArrivati.Parameters("@Varditta").Value = varditta
        ComAcquistiArrivati.Parameters("@idprodotto").Value = Articolo
        ComAcquistiArrivati.Parameters("@DataInizio").Value = DataInventario.ToShortDateString

        If DateDiff(DateInterval.Day, Today.Date, DataInventario) > 90 Then DataInizialeLink = DataInventario.AddDays(-90) Else DataInizialeLink = DataInventario



        leggo = ComAcquistiArrivati.ExecuteReader
        While leggo.Read
            Confronto = ""
            For Each riga In DsUDMListino.Tables(0).Rows
                Confronto = Confronto + riga("UDM").ToString.Trim
                If riga("UDM").ToString = leggo("UDM").ToString Then
                    If IsNumeric(leggo("Acquisti")) Then riga("Carico") = CDec(riga("Carico")) + CDec(leggo("Acquisti"))
                End If
            Next
            If Confronto.IndexOf(leggo("UDM").ToString) = -1 Then
                riga("FlagIncongruenza") = True
                If IsNumeric(leggo("Acquisti")) Then riga("Carico") = CDec(riga("Carico")) + CDec(leggo("Acquisti"))
            End If
        End While
        leggo.Close()
        'Calcolo gli ordini fatti ma non pervenuta la merce
        TxtOrdiniNonPervenuti.Text = "0"
        ComAcquistiDaArrivare.Parameters("@Varditta").Value = varditta
        ComAcquistiDaArrivare.Parameters("@idprodotto").Value = Articolo
        'If DataInizialeLink.ToShortDateString = "01/01/1900" Then ComAcquistiDaArrivare.Parameters("@DataInizio").Value = DataInventario Else ComAcquistiDaArrivare.Parameters("@DataInizio").Value = DataInizialeLink
        ComAcquistiDaArrivare.Parameters("@DataInizio").Value = DataInizialeLink
        leggo = ComAcquistiDaArrivare.ExecuteReader
        Dim totale As Decimal = 0
        While leggo.Read()
            For Each riga In DsUDMListino.Tables(0).Rows
                If riga("UDM").ToString = leggo("UDM").ToString Then
                    If IsNumeric(leggo("Acquisti")) Then riga("NonArrivata") = CDec(riga("NonArrivata")) + CDec(leggo("Acquisti"))


                End If

            Next



            If IsNumeric(leggo("Acquisti")) Then totale = totale + CDec(leggo("Acquisti"))
        End While
        TxtOrdiniNonPervenuti.Text = totale.ToString
        leggo.Close()

        TxtVenduta.Text = "0"
        'calcolo le vendite da quella data
        ComVenditeFatturate.Parameters("@Varditta").Value = varditta
        ComVenditeFatturate.Parameters("@idprodotto").Value = Articolo
        ComVenditeFatturate.Parameters("@DataInizio").Value = DataInventario.ToShortDateString
        'If Not ComVenditeFatturate.ExecuteScalar Is Nothing And Not IsDBNull(ComVenditeFatturate.ExecuteScalar) Then TxtVenduta.Text = ComVenditeFatturate.ExecuteScalar
        leggo = ComVenditeFatturate.ExecuteReader
        Confronto = ""
        While leggo.Read

            For Each riga In DsUDMListino.Tables(0).Rows
                Confronto = Confronto + riga("UDM").ToString.Trim
                If riga("UDM").ToString = leggo("UDM").ToString Then
                    If IsNumeric(leggo("Vendite")) Then riga("Scarico") = leggo("Vendite")

                End If

            Next
            If Confronto.IndexOf(leggo("UDM").ToString) = -1 Then
                riga("FlagIncongruenza") = True
                If IsNumeric(leggo("Vendite")) Then riga("Scarico") = leggo("Vendite")
            End If
        End While
        leggo.Close()

        'Calcolo gli ordini fatti ma non Fatturati
        TxtImpegnati.Text = "0"
        ComVenditeDaFatturare.Parameters("@Varditta").Value = varditta
        ComVenditeDaFatturare.Parameters("@idprodotto").Value = Articolo
        'If DataInizialeLink.ToShortDateString = "01/01/1900" Then ComVenditeDaFatturare.Parameters("@DataInizio").Value = DataInventario Else ComVenditeDaFatturare.Parameters("@DataInizio").Value = DataInizialeLink
        ComVenditeDaFatturare.Parameters("@DataInizio").Value = DataInizialeLink
        leggo = ComVenditeDaFatturare.ExecuteReader
        totale = 0
        While leggo.Read()

            For Each riga In DsUDMListino.Tables(0).Rows
                If riga("UDM").ToString = leggo("UDM").ToString Then
                    If IsNumeric(leggo("Vendite")) Then riga("NonFatturata") = CDec(riga("NonFatturata")) + CDec(leggo("Vendite"))

                End If

            Next

        End While
        TxtImpegnati.Text = totale.ToString
        leggo.Close()
        'Pulisco il dataset se i valori sono a zero
        Dim i As Integer = 0
        For i = DsUDMListino.Tables(0).Rows.Count - 1 To 0 Step -1
            riga = DsUDMListino.Tables(0).Rows(i)
            If riga.RowState <> DataRowState.Deleted Then
                If CDec(riga("giacenze")) + CDec(riga("Carico")) + CDec(riga("Scarico")) + CDec(riga("NonFatturata")) + CDec(riga("NonArrivata")) = 0 Then riga.Delete()

            End If
        Next

        DsUDMListino.AcceptChanges()

        CMBUDM.Items.Clear()
        TotInizialiNoKg = 0
        TotAcquistiNoKg = 0
        totVenditeNoKg = 0
        TotInizialiKg = 0
        TotAcquistiKg = 0
        totVenditeKg = 0
        totNonFatturataNoKg = 0
        TotNonFatturataKg = 0
        TotNonArrivataNoKg = 0
        totNonArrivataKg = 0
        For Each riga In DsUDMListino.Tables(0).Rows
            'If riga("UDM").ToString <> "" And riga("Rapporto").ToString = "" Then
            If CBool(riga("FlagIncongruenza")) = True Then
                TxtGiacenzeIniziali.Text = "Dati Incongruenti"
                TxtGiacenzeIniziali.BackColor = System.Drawing.Color.Red

                TxtAcquisti.Text = "Dati Incongruenti"
                TxtAcquisti.BackColor = System.Drawing.Color.Red

                TxtVenduta.Text = "Dati Incongruenti"
                TxtVenduta.BackColor = System.Drawing.Color.Red

                TxtGiacenza.Text = "Dati Incongruenti"
                TxtGiacenza.BackColor = System.Drawing.Color.Red

                CMBUDM.Enabled = False

                TxtOrdiniNonPervenuti.Text = "Dati Incongruenti"
                TxtOrdiniNonPervenuti.BackColor = System.Drawing.Color.Red

                TxtImpegnati.Text = "Dati Incongruenti"
                TxtImpegnati.BackColor = System.Drawing.Color.Red

                TxtMessaggio.Text = "Mancano dati Necessari per il calcolo: UDM Inserita: " & riga("UDM").ToString & " Rapporto Peso Inserito: " & riga("Rapporto").ToString
                Exit Sub


            End If



            If riga("UDM").ToString.ToLower.Replace(".", "") <> "kg" Then CMBUDM.Items.Add(riga("UDM"))
            If IsNumeric(riga("giacenze")) Then
                TotInizialiNoKg = TotInizialiNoKg + CDec(riga("giacenze"))
                TotInizialiKg = TotInizialiKg + CDec(riga("giacenze")) * CDec(riga("Rapporto"))
            End If

            If IsNumeric(riga("Carico")) Then
                TotAcquistiNoKg = TotAcquistiNoKg + CDec(riga("Carico"))
                TotAcquistiKg = TotAcquistiKg + CDec(riga("Carico")) * CDec(riga("Rapporto"))
            End If

            If IsNumeric(riga("Scarico")) Then
                totVenditeNoKg = totVenditeNoKg + CDec(riga("Scarico"))
                totVenditeKg = totVenditeKg + CDec(riga("Scarico")) * CDec(riga("Rapporto"))
            End If
            If IsNumeric(riga("NonFatturata")) Then
                totNonFatturataNoKg = totNonFatturataNoKg + CDec(riga("NonFatturata"))
                TotNonFatturataKg = TotNonFatturataKg + CDec(riga("NonFatturata")) * CDec(riga("Rapporto"))
            End If
            If IsNumeric(riga("NonArrivata")) Then
                TotNonArrivataNoKg = TotNonArrivataNoKg + CDec(riga("NonArrivata"))
                totNonArrivataKg = totNonArrivataKg + CDec(riga("NonArrivata")) * CDec(riga("Rapporto"))
            End If
        Next
        CMBUDM.Items.Add("KG.")
        CMBUDM.Items.Add("<Quantità>")


        If DsUDMListino.Tables(0).Rows.Count = 1 Then
            CMBUDM.Enabled = False
            TxtGiacenzeIniziali.Text = Format(CDec(DsUDMListino.Tables(0).Rows(0).Item("Giacenze")), "#,##0.00")
            TxtAcquisti.Text = Format(CDec(DsUDMListino.Tables(0).Rows(0).Item("Carico")), "#,##0.00")
            TxtVenduta.Text = Format(CDec(DsUDMListino.Tables(0).Rows(0).Item("Scarico")), "#,##0.00")
            TxtImpegnati.Text = Format(CDec(DsUDMListino.Tables(0).Rows(0).Item("NonFatturata")), "#,##0.00")
            TxtOrdiniNonPervenuti.Text = Format(CDec(DsUDMListino.Tables(0).Rows(0).Item("NonArrivata")), "#,##0.00")

            TxtMessaggio.Text = "Unica Unità di misura Utilizzata: " & DsUDMListino.Tables(0).Rows(0).Item("UDM").ToString
            UDM = DsUDMListino.Tables(0).Rows(0).Item("UDM").ToString
            Calcolo_Prezzi_Acquisto(Articolo, CDec(Format(CDec(TxtGiacenzeIniziali.Text) + CDec(TxtAcquisti.Text) - CDec(TxtVenduta.Text), "#,##0.00")), UDM)

            TxtMessaggio.BackColor = System.Drawing.Color.LightGreen
        ElseIf DsUDMListino.Tables(0).Rows.Count = 0 Then
            CMBUDM.Enabled = False
            UDM = ""
            TxtMessaggio.Text = "Nessun Movimento per il prodotto indicato "
            TxtMessaggio.BackColor = System.Drawing.Color.Yellow
        ElseIf DsUDMListino.Tables(0).Rows.Count > 1 Then
            CMBUDM.Enabled = True
            UDM = "KG."
            TxtGiacenzeIniziali.Text = Format(TotInizialiKg, "#,##0.00")
            TxtAcquisti.Text = Format(TotAcquistiKg, "#,##0.00")
            TxtVenduta.Text = Format(totVenditeKg, "#,##0.00")
            TxtImpegnati.Text = Format(TotNonFatturataKg, "#,##0.00")
            TxtOrdiniNonPervenuti.Text = Format(totNonArrivataKg, "#,##0.00")
            TxtMessaggio.Text = "Sono state utilizzate più UDM disomogenee: I dati indicati sono stati rapportati al Kg. <<==>> Attenzione: potrebbero essere errati"
            Calcolo_Prezzi_Acquisto(Articolo, CDec(Format(CDec(TxtGiacenzeIniziali.Text) + CDec(TxtAcquisti.Text) - CDec(TxtVenduta.Text), "#,##0.00")), UDM)
            TxtMessaggio.BackColor = System.Drawing.Color.Tomato
        End If


        LabGiacenzeIniziali.Text = "Giacenze Iniziali al: " & DataInventario.ToShortDateString
        TxtGiacenza.Text = Format(CDec(TxtGiacenzeIniziali.Text) + CDec(TxtAcquisti.Text) - CDec(TxtVenduta.Text), "#,##0.00")
        If CDec(TxtGiacenza.Text) >= 0 Then TxtGiacenza.BackColor = System.Drawing.Color.GreenYellow Else TxtGiacenza.BackColor = System.Drawing.Color.Red

    End Sub
    Private Sub FormGiacenze_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Height = 1220
        AIDataTable = New DataTable
        SqlDataAdapter1.Fill(AIDataTable)       'Carico subito tutta la tabella dei codici AI
        AIDataTable.Columns.Add("ValoreAI", GetType(String))    'Aggiungo una colonna destinata a contenere il valore dell'AI

    End Sub




    Private Sub TxtVenduta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtVenduta.Click
        DsDettagliInventario1.Clear()
        excel = "Scarico"
        If ComVenditeFatturateTutti.Connection.State = ConnectionState.Closed Then ComVenditeFatturateTutti.Connection.Open()
        ComVenditeFatturateTutti.Parameters("@Varditta").Value = varditta
        '    ComVenditeFatturateTutti.Parameters("@idprodotto").Value = IdProdotto
        ComVenditeFatturateTutti.Parameters("@DataInizio").Value = DataInventario
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


    End Sub



    Private Sub CMBUDM_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMBUDM.SelectedIndexChanged
        If CMBUDM.SelectedItem.ToString.ToLower.Replace(".", "") = "kg" Then
            TxtGiacenzeIniziali.Text = Format(TotInizialiKg, "#,##0.00")
            TxtAcquisti.Text = Format(TotAcquistiKg, "#,##0.00")
            TxtVenduta.Text = Format(totVenditeKg, "#,##0.00")
            TxtImpegnati.Text = Format(TotNonFatturataKg, "#,##0.00")
            TxtOrdiniNonPervenuti.Text = Format(totNonArrivataKg, "#,##0.00")
            TxtMessaggio.Text = "Sono state utilizzate più UDM disomogenee: I dati indicati sono stati rapportati al Kg. <<==>> Attenzione: potrebbero essere errati"
            TxtMessaggio.BackColor = System.Drawing.Color.Tomato
            TxtGiacenza.Text = Format(CDec(TxtGiacenzeIniziali.Text) + CDec(TxtAcquisti.Text) - CDec(TxtVenduta.Text), "#,##0.00")
            Calcolo_Prezzi_Acquisto(CInt(TxtArticolo.Text), CDec(Format(CDec(TxtGiacenzeIniziali.Text) + CDec(TxtAcquisti.Text) - CDec(TxtVenduta.Text), "#,##0.00")), CMBUDM.SelectedItem.ToString)
            If CDec(TxtGiacenza.Text) >= 0 Then TxtGiacenza.BackColor = System.Drawing.Color.GreenYellow Else TxtGiacenza.BackColor = System.Drawing.Color.Red

            TxtScansione.SelectAll()
            TxtScansione.Focus()
            Exit Sub

        End If
        If CMBUDM.SelectedItem.ToString = "<Quantità>" Then
            TxtGiacenzeIniziali.Text = Format(TotInizialiNoKg, "#,##0.00")
            TxtAcquisti.Text = Format(TotAcquistiNoKg, "#,##0.00")
            TxtVenduta.Text = Format(totVenditeNoKg, "#,##0.00")
            TxtImpegnati.Text = Format(totNonFatturataNoKg, "#,##0.00")
            TxtOrdiniNonPervenuti.Text = Format(TotNonArrivataNoKg, "#,##0.00")
            TxtMessaggio.Text = "Sono state utilizzate più UDM disomogenee: I dati indicati  potrebbero essere errati"
            TxtMessaggio.BackColor = System.Drawing.Color.Tomato
            TxtGiacenza.Text = Format(CDec(TxtGiacenzeIniziali.Text) + CDec(TxtAcquisti.Text) - CDec(TxtVenduta.Text), "#,##0.00")

            If CDec(TxtGiacenza.Text) >= 0 Then TxtGiacenza.BackColor = System.Drawing.Color.GreenYellow Else TxtGiacenza.BackColor = System.Drawing.Color.Red
            TxtScansione.SelectAll()
            TxtScansione.Focus()
            Exit Sub

        End If

        Dim riga As DataRow
        For Each riga In DsUDMListino.Tables(0).Rows
            If riga("udm").ToString = CMBUDM.SelectedItem.ToString Then
                TxtGiacenzeIniziali.Text = Format(TotInizialiKg / CDec(riga("rapporto")), "#,##0.00")
                TxtAcquisti.Text = Format(TotAcquistiKg / CDec(riga("rapporto")), "#,##0.00")
                TxtVenduta.Text = Format(totVenditeKg / CDec(riga("rapporto")), "#,##0.00")
                TxtImpegnati.Text = Format(TotNonFatturataKg / CDec(riga("rapporto")), "#,##0.00")
                TxtOrdiniNonPervenuti.Text = Format(totNonArrivataKg / CDec(riga("rapporto")), "#,##0.00")
                TxtMessaggio.Text = "I Dati visualizzati si riferiscono alle quantità traslate in Kg e riportate all'UDM: " & riga("UDM").ToString & " Se il rapporto all'Unità non è corretto i dati saranno sbagliati"
                TxtMessaggio.BackColor = System.Drawing.Color.Tomato
                TxtGiacenza.Text = Format(CDec(TxtGiacenzeIniziali.Text) + CDec(TxtAcquisti.Text) - CDec(TxtVenduta.Text), "#,##0.00")
                Calcolo_Prezzi_Acquisto(CInt(TxtArticolo.Text), CDec(Format(CDec(TxtGiacenzeIniziali.Text) + CDec(TxtAcquisti.Text) - CDec(TxtVenduta.Text), "#,##0.00")), CMBUDM.SelectedItem.ToString)
                If CDec(TxtGiacenza.Text) >= 0 Then TxtGiacenza.BackColor = System.Drawing.Color.GreenYellow Else TxtGiacenza.BackColor = System.Drawing.Color.Red
            End If
        Next
        TxtScansione.SelectAll()
        TxtScansione.Focus()


    End Sub





    Private Function GetUniqueTempFileName(ext As String) As String
        Dim TEMP_DIR As String = System.Environment.GetEnvironmentVariable("tmp")

        Return (TEMP_DIR & ext)
    End Function



    Private Sub Calcolo_Prezzi_Acquisto(IdProdotto As Integer, Giacenza As Decimal, UDMRiferimento As String)

        'Cerco dalla data ultima indicata e andando indietro tutti gli acquisti del prodotto sino a raggiungere la quantita delle giacenze.
        'Dal momento che non so con che UDM ho acquistato devo, per ogni voce trovata rapportarla a Kg e poi riportarla all'UDM delle giacenze
        'Per prima cosa porto a KG le giacenze Finali


        If Giacenza = 0 Then Exit Sub
        Dim giacenzeFinaliKG As Decimal = 0
        Dim rapportoGiacenzaIniziale As Decimal = 0
        Dim rigaTMP As DataRow
        For Each rigaTMP In DsUDM1.Tables(0).Rows
            If UDMRiferimento = rigaTMP("UDM").ToString Then
                rapportoGiacenzaIniziale = CDec(rigaTMP("Rapporto"))
                giacenzeFinaliKG = Giacenza * CDec(rigaTMP("Rapporto"))
            End If
        Next

        If rapportoGiacenzaIniziale = 0 Then Exit Sub

        If ComPrezziAcquisto.Connection.State = ConnectionState.Closed Then ComPrezziAcquisto.Connection.Open()
        Dim rapportoItem As Decimal = 0
        Dim prezzomedio As Decimal = 0
        Dim PrezzoTMP As Decimal = 0
        Dim quantitaTotale As Decimal = 0
        Dim quantitaTMP As Decimal
        Dim leggo As SqlClient.SqlDataReader
        'For Each Riga In DsInventario1.Tables(0).Rows
        Dim riga As DataRow
        If IsNumeric(Giacenza) Then

            prezzomedio = 0
            quantitaTotale = giacenzeFinaliKG
            If quantitaTotale = 0 Then quantitaTotale = 1
            quantitaTMP = quantitaTotale
            ComPrezziAcquisto.Parameters("@Datafine").Value = Today
            ComPrezziAcquisto.Parameters("@Datainizio").Value = DataInventario.AddYears(-1) ' CDate("31/12/" & Today.AddYears(-1).Year.ToString)
            ComPrezziAcquisto.Parameters("@Articolo").Value = IdProdotto
            leggo = ComPrezziAcquisto.ExecuteReader
            While quantitaTotale > 0
                DsScadenze1.Clear()
                While leggo.Read()
                    ' Ora Porto la quantità a KG
                    For Each rigaTMP In DsUDM1.Tables(0).Rows
                        If leggo("UDM").ToString = rigaTMP("UDM").ToString Then
                            rapportoItem = CDec(rigaTMP("Rapporto"))
                            quantitaTMP = CDec(leggo("Quantitaconsegnata")) * rapportoItem 'rapportoGiacenzaIniziale
                            PrezzoTMP = CDec(leggo("PrezzoFattura")) / rapportoItem 'rapportoGiacenzaIniziale



                        End If

                    Next
                    riga = DsScadenze1.TableScadenze.NewRow
                    riga("UDM") = UDMRiferimento
                    If IsDate(leggo("scadenza")) Then riga("Scadenza") = leggo("Scadenza")
                    riga("Lotto") = leggo("Lotto")
                    riga("DataAcquisto") = leggo("DataDocumento")
                    riga("IdOrdine") = leggo("IdOrdine")
                    If IsNumeric(riga("Quantita")) Then riga("Quantita") = CDec(riga("Quantita")) + Math.Min(CDec(quantitaTMP / rapportoGiacenzaIniziale), quantitaTotale / rapportoGiacenzaIniziale) Else riga("Quantita") = Math.Min(CDec(quantitaTMP / rapportoGiacenzaIniziale), quantitaTotale / rapportoGiacenzaIniziale)
                    riga("Prezzo") = PrezzoTMP * rapportoGiacenzaIniziale
                    DsScadenze1.TableScadenze.Rows.Add(riga)

                    prezzomedio = prezzomedio + Math.Min(quantitaTMP * PrezzoTMP, PrezzoTMP * quantitaTotale)
                    quantitaTotale = quantitaTotale - quantitaTMP
                    '  If leggo("Scadenza").ToString <> "" Then Riga("Scadenze") = Riga("Scadenze").ToString & "<" & leggo("Scadenza").ToString & "> " Else Riga("Scadenze") = Riga("Scadenze").ToString & " <Non Ins.> "
                    If quantitaTotale <= 0 Then Exit While

                End While
                Exit While
            End While
            leggo.Close()

            If prezzomedio / giacenzeFinaliKG <> 0 Then prezzomedio = prezzomedio / giacenzeFinaliKG
            ' Riga("PrezzoAcquisto") = Format(prezzomedio * rapportoGiacenzaIniziale, "#0.00")
        End If
        '
        '  Next
    End Sub

    Private Sub TxtScansione_Leave(sender As Object, e As EventArgs) Handles TxtScansione.Leave
        If TxtScansione.Text = "" Then
            TxtScansione.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub TxtScansione_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtScansione.KeyDown
        If e.KeyData = Keys.Enter Then
            interpretoCodici(TxtScansione.Text)
        End If
    End Sub

    Private Sub interpretoCodici(CodiceBarre As String)

        ' Dim CodiceBarre As String = TxtScansione.Text
        Dim RigaAi() As DataRow = Nothing
        'Per prima cosa vedo 
        If CodiceBarre.Length < 8 Then
            TxtScansione.SelectAll()
            TxtScansione.Focus()
            Exit Sub
        End If
        Select Case CodiceBarre.Substring(0, 1).ToUpper

            Case "$" ' è un codice barre GS1 (potrebe essere anche un altro tipo ma non darà risultati)
                CodiceBarre = CodiceBarre.Substring(1) ' Tolgo l'identificativo
                Select Case CodiceBarre.Substring(0, 2)
                    Case "00" 'Questo indica che il primo AI è dello SSCC ed è lungo 18
                        RigaAi = AIDataTable.Select("AI = '" & CodiceBarre.Substring(0, 2) & "'")
                        RigaAi(0).Item("ValoreAI") = CodiceBarre.Substring(0, CInt(RigaAi(0).Item("LunghezzaMax")))
                        CodiceBarre = CodiceBarre.Substring(CInt(RigaAi(0).Item("LunghezzaMax")) + 2)

                    Case "01", "02" 'Questo indica che il primo AI è EAN14 ed è lungo 14
                        RigaAi = AIDataTable.Select("AI = '" & CodiceBarre.Substring(0, 2) & "'")
                        If RigaAi.Length <> 0 Then
                            '' riga = ElementiAI.NewRow
                            ''riga.Item("AI") = CodiceBarre.Substring(0, 2)
                            TxtEAN.Text = CodiceBarre.Substring(2, CInt(RigaAi(0).Item("LunghezzaMax")))
                            'questo valore è lungo 14 deve essere trasformato in EAN13 ===========================
                            '' riga.Item("Descrizione") = RigaAi(0).Item("Descrizione").ToString
                            CodiceBarre = CodiceBarre.Substring(CInt(RigaAi(0).Item("LunghezzaMax")) + 2)
                            ''   ElementiAI.Rows.Add(riga)
                        End If
                End Select
        End Select
        'A questo punto arrivo con un codice barre senza codice EAN e con tutte le altre informazioni che debo tirar fuori
        While CodiceBarre.Trim.Length > 0
            RigaAi = AIDataTable.Select("AI = '" & CodiceBarre.Substring(0, 2) & "'")
            Select Case CodiceBarre.Substring(0, 2).Trim
                Case "10" 'E' il lotto 
                    ''  riga = ElementiAI.NewRow
                    ''  riga.Item("AI") = CodiceBarre.Substring(0, 2)
                    Dim lunghezza As Integer = CodiceBarre.IndexOf(FNC)
                    If lunghezza = -1 Then
                        TxtLotto.Text = CodiceBarre.Substring(2) ' Non è stato indicato l'FNC perchè è l'ultimo
                        CodiceBarre = ""
                    Else
                        TxtLotto.Text = CodiceBarre.Substring(2, lunghezza - 2)
                        CodiceBarre = CodiceBarre.Substring(CodiceBarre.IndexOf(FNC) + 1)
                    End If
                        ''  riga.Item("Descrizione") = RigaAi(0).Item("Descrizione").ToString
                      ''  ElementiAI.Rows.Add(riga)

                Case "11", "12", "13", "15", "17" 'Rispettivamente sono le date di produzione, Scadenza Fattura, Data Imballagg$010800177014168110L.F189!172507082401980!90SC.!916
                    'io, Consumare entro, scadenza
                    If RigaAi.Length <> 0 Then
                        ''  riga = ElementiAI.NewRow
                        ''  riga.Item("AI") = CodiceBarre.Substring(0, 2)
                        CodiceBarre = CodiceBarre.Substring(2) ' tolgo l'AI in modo da lavorare meglio sulla data
                        Dim scadenza As String = CodiceBarre.Substring(0, CInt(RigaAi(0).Item("LunghezzaMax")))
                        TxtScadenza.Text = scadenza.Substring(4, 2) & "/" & scadenza.Substring(2, 2) & "/" & scadenza.Substring(0, 2)
                        ''  riga.Item("Descrizione") = RigaAi(0).Item("Descrizione").ToString
                        CodiceBarre = CodiceBarre.Substring(CInt(RigaAi(0).Item("LunghezzaMax"))) ' cancello i dati dell'AI appena ottenuto
                        '' ElementiAI.Rows.Add(riga)
                    End If
                Case "31" 'E' il Peso Netto 
                    RigaAi = AIDataTable.Select("AI like '" & CodiceBarre.Substring(0, 4) & "'") 'Devo ripetere la ricerca perchè l'AI è lungo 4 Prendo tutti i decimali previsti per il peso (da 0 a 6)
                    Dim NumDecimali As Integer = CInt(RigaAi(0).Item("AI").ToString.Substring(3, 1))
                    Dim lunghezza As Integer = CInt(RigaAi(0).Item("LunghezzaMax"))
                    CodiceBarre = CodiceBarre.Substring(4) ' tolgo l'AI del peso
                    Dim pippo As String = CodiceBarre.Substring(0, lunghezza - NumDecimali)
                    If NumDecimali <> 0 Then TxtPesoNetto.Text = CodiceBarre.Substring(0, CInt(RigaAi(0).Item("LunghezzaMax")) - NumDecimali) & "." & CodiceBarre.Substring(CInt(RigaAi(0).Item("LunghezzaMax")) - NumDecimali, NumDecimali) Else TxtPesoNetto.Text = CodiceBarre.Substring(0, CInt(RigaAi(0).Item("LunghezzaMax")))
                    CodiceBarre = CodiceBarre.Substring(CInt(RigaAi(0).Item("LunghezzaMax"))) ' cancello i dati dell'AI appena ottenuto

                Case "33" 'E' il peso lordo

                    RigaAi = AIDataTable.Select("AI like '" & CodiceBarre.Substring(0, 4) & "'") 'Devo ripetere la ricerca perchè l'AI è lungo 4 Prendo tutti i decimali previsti per il peso (da 0 a 6)
                    Dim NumDecimali As Integer = CInt(RigaAi(0).Item("AI").ToString.Substring(3, 1))

                    CodiceBarre = CodiceBarre.Substring(4) ' tolgo l'AI del peso

                    If NumDecimali <> 0 Then TxtPesoLordo.Text = CodiceBarre.Substring(0, CInt(RigaAi(0).Item("LunghezzaMax")) - NumDecimali) & "." & CodiceBarre.Substring(CInt(RigaAi(0).Item("LunghezzaMax")) - NumDecimali, NumDecimali) Else riga.Item("ValoreAI") = CodiceBarre.Substring(0, CInt(RigaAi(0).Item("LunghezzaMax")))
                    CodiceBarre = CodiceBarre.Substring(CInt(RigaAi(0).Item("LunghezzaMax"))) ' cancello i dati dell'AI appena ottenuto


                Case "30", "37" 'Numero dei Colli Variabile o fissi
                    '' riga = ElementiAI.NewRow
                    '' riga.Item("AI") = CodiceBarre.Substring(0, 2)
                    Dim lunghezza As Integer = CodiceBarre.IndexOf(FNC)
                    ''  riga.Item("ValoreAI") = CodiceBarre.Substring(2, lunghezza - 2)
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
                    RigaAi = AIDataTable.Select("AI = '" & CodiceBarre.Substring(0, 3) & "'") 'Devo ripetere la ricerca perchè l'AI è lungo 3
                    ''  riga = ElementiAI.NewRow
                    '' riga.Item("AI") = CodiceBarre.Substring(0, 3)
                    CodiceBarre = CodiceBarre.Substring(3) ' tolgo l'AI
                    Dim lunghezza As Integer = CodiceBarre.IndexOf(FNC)
                    TxtArticolo.Text = CodiceBarre.Substring(0, lunghezza)
                    ''  riga.Item("Descrizione") = RigaAi(0).Item("Descrizione").ToString
                    CodiceBarre = CodiceBarre.Substring(CodiceBarre.IndexOf(FNC) + 1)
                      ''  ElementiAI.Rows.Add(riga)

                Case "42" 'Paese di Origine 422(ISO Numerico) e paese di lavorazione 423
                    RigaAi = AIDataTable.Select("AI = '" & CodiceBarre.Substring(0, 3) & "'")
                    CodiceBarre = CodiceBarre.Substring(3) ' tolgo l'AI
                    RigaAi(0).Item("ValoreAI") = CodiceBarre.Substring(0, CInt(RigaAi(0).Item("LunghezzaMax")))
                    CodiceBarre = CodiceBarre.Substring(CInt(RigaAi(0).Item("LunghezzaMax"))) ' cancello i dati dell'AI appena ottenuto
                     ''   Txtdopo.AppendText(Chr(13) & RigaAi(0).Item("Descrizione").ToString & " - " & RigaAi(0).Item("ValoreAI").ToString & vbCrLf)

                Case "90" ' Valori concordati NOI LO UTILIZIAMO PER L'UDM

                    Dim lunghezza As Integer = CodiceBarre.IndexOf(FNC)
                    If lunghezza = -1 Then
                        TxtUDM.Text = CodiceBarre.Substring(2) ' Non è stato indicato l'FNC perchè è l'ultimo
                        CodiceBarre = ""
                    Else
                        TxtUDM.Text = CodiceBarre.Substring(2, lunghezza - 2)
                        CodiceBarre = CodiceBarre.Substring(CodiceBarre.IndexOf(FNC) + 1)
                    End If
                        'riga.Item("Descrizione") = RigaAi(0).Item("Descrizione").ToString
                        '' ElementiAI.Rows.Add(riga)

                Case "91" ' Valori concordati NOI LO UTILIZZIAMO PER LA QUANTITA    

                    Dim lunghezza As Integer = CodiceBarre.IndexOf(FNC)
                    If lunghezza = -1 Then
                        TxtQuantita.Text = CodiceBarre.Substring(2) ' Non è stato indicato l'FNC perchè è l'ultimo
                        CodiceBarre = ""
                    Else
                        TxtQuantita.Text = CodiceBarre.Substring(2, lunghezza - 2)
                        CodiceBarre = CodiceBarre.Substring(CodiceBarre.IndexOf(FNC) + 1)
                    End If
                        'riga.Item("Descrizione") = RigaAi(0).Item("Descrizione").ToString

                Case "92" ' Valori concordati PER NOI è IL CODICE FORNITORE
                    ''  riga = ElementiAI.NewRow
                    ''  riga.Item("AI") = CodiceBarre.Substring(0, 2)
                    Dim lunghezza As Integer = CodiceBarre.IndexOf(FNC)
                    Dim codFornitore As String = ""
                    If lunghezza = -1 Then
                        'riga.Item("ValoreAI") = CodiceBarre.Substring(2) ' Non è stato indicato l'FNC perchè è l'ultimo
                        CodiceBarre = ""
                    Else
                        codFornitore = CodiceBarre.Substring(2, lunghezza - 2)
                        CodiceBarre = CodiceBarre.Substring(CodiceBarre.IndexOf(FNC) + 1)
                        Dim carico As New SqlClient.SqlCommand
                        carico.Connection = SqlConnection1
                        carico.CommandText = "SELECT ArchivioFornitori.Descrizione_1 AS NomeFornitore FROM ArchivioFornitori where IDFornitore = '" & codFornitore & "'"
                        If carico.Connection.State = ConnectionState.Closed Then carico.Connection.Open()
                        TxtIdFornitore.Text = codFornitore
                        TxtNomeFornitore.Text = carico.ExecuteScalar.ToString

                    End If
                    'riga.Item("Descrizione") = RigaAi(0).Item("Descrizione").ToString
                    '' ElementiAI.Rows.Add(riga)
                Case "93" ' Valori concordati PER NOI è IL nostro numero di ordine

                    Dim lunghezza As Integer = CodiceBarre.IndexOf(FNC)

                    If lunghezza = -1 Then
                        'riga.Item("ValoreAI") = CodiceBarre.Substring(2) ' Non è stato indicato l'FNC perchè è l'ultimo
                        CodiceBarre = ""
                    Else
                        TxTOrdNumVermar.Text = CodiceBarre.Substring(2, lunghezza - 2)
                        CodiceBarre = CodiceBarre.Substring(CodiceBarre.IndexOf(FNC) + 1)




                    End If
                    'riga.Item("Descrizione") = RigaAi(0).Item("Descrizione").ToString
                    '' ElementiAI.Rows.Add(riga)
                Case "94" ' Valori concordati PER NOI è IL CODICE FORNITORE
                    ''  riga = ElementiAI.NewRow
                    ''  riga.Item("AI") = CodiceBarre.Substring(0, 2)
                    Dim lunghezza As Integer = CodiceBarre.IndexOf(FNC)
                    Dim NumOrdine As String = ""
					If lunghezza = -1 Then
						NumOrdine = CodiceBarre.Substring(2)
						CodiceBarre = ""
					Else
						NumOrdine = CodiceBarre.Substring(2, lunghezza - 2)
						CodiceBarre = CodiceBarre.Substring(CodiceBarre.IndexOf(FNC) + 1)


					End If
					Dim carico As New SqlClient.SqlCommand
					carico.Connection = SqlConnection1
					carico.CommandText = "SELECT TB_DOCUMENTI_ORDINI_FORNITORI.DataDocumento AS DataDocumento FROM TB_DOCUMENTI_ORDINI_FORNITORI where NUMDocumento = '" & NumOrdine & "'"
					If carico.Connection.State = ConnectionState.Closed Then carico.Connection.Open()
					TxtNumOrdForn.Text = NumOrdine
					TxtDataOrdForn.Text = CDate(carico.ExecuteScalar).ToShortDateString
					'riga.Item("Descrizione") = RigaAi(0).Item("Descrizione").ToString
					'' ElementiAI.Rows.Add(riga)

				Case "95", "96", "97", "98", "99" ' Valori concordati 
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
        Carico_Giacenze(CInt(TxtArticolo.Text))
        'inserisco i risultati nel textbox
        ''  Txtdopo.Text = ""
        '' For Each riga In ElementiAI.Rows
        ''  Txtdopo.AppendText(Chr(13) & riga("AI").ToString & " - " & riga("Descrizione").ToString & " - " & riga("ValoreAI").ToString & vbCrLf)
        '' Next

        TxtScansione.SelectAll()
    End Sub

End Class
