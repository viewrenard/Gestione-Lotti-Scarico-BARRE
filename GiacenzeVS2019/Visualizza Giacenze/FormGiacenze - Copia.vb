Imports CrystalDecisions.CrystalReports.Engine




Public Class FormGiacenze
    Inherits System.Windows.Forms.Form
    Friend UDM As String = ""
    Friend excel As String = ""
    Friend DataInventario As Date
    Friend DataInizialeLink As Date = Today.Date.AddYears(-1)
    Friend varditta As Integer
    Friend IdProdotto As Integer
    Friend TotInizialiNoKg As Decimal = 0
    Friend TotAcquistiNoKg As Decimal = 0
    Friend totVenditeNoKg As Decimal = 0
    Friend TotInizialiKg As Decimal = 0
    Friend TotAcquistiKg As Decimal = 0
    Friend totVenditeKg As Decimal = 0
    Friend totNonFatturataNoKg As Decimal = 0
    Friend TotNonFatturataKg As Decimal = 0
    Friend TotNonArrivataNoKg As Decimal = 0
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
    Friend WithEvents TxtGiacenza As System.Windows.Forms.Label
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
    Friend WithEvents GridDettagliInventario As C1.Win.C1TrueDBGrid.C1TrueDBGrid
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
        Me.TxtGiacenza = New System.Windows.Forms.Label()
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
        Me.DsDettagliInventario1 = New Visualizza_Giacenze.DsDettagliInventario()
        Me.GridDettagliInventario = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
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
        CType(Me.DsDettagliInventario1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDettagliInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsUDMListino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=DATASERVER\SQLPROCEDURA;Initial Catalog=vermarnew;User ID=fox;Password=31iris46"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'LabGiacenzeIniziali
        '
        Me.LabGiacenzeIniziali.Location = New System.Drawing.Point(8, 8)
        Me.LabGiacenzeIniziali.Name = "LabGiacenzeIniziali"
        Me.LabGiacenzeIniziali.Size = New System.Drawing.Size(168, 23)
        Me.LabGiacenzeIniziali.TabIndex = 0
        Me.LabGiacenzeIniziali.Text = "Giacenze Iniziali al 31/12/2010"
        Me.LabGiacenzeIniziali.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtGiacenzeIniziali
        '
        Me.TxtGiacenzeIniziali.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtGiacenzeIniziali.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGiacenzeIniziali.Location = New System.Drawing.Point(176, 8)
        Me.TxtGiacenzeIniziali.Name = "TxtGiacenzeIniziali"
        Me.TxtGiacenzeIniziali.Size = New System.Drawing.Size(112, 23)
        Me.TxtGiacenzeIniziali.TabIndex = 1
        Me.TxtGiacenzeIniziali.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Merce Pervenuta ad Oggi"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Merce Venduta ad Oggi"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Giacenza Contabile"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtGiacenza
        '
        Me.TxtGiacenza.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtGiacenza.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGiacenza.Location = New System.Drawing.Point(176, 88)
        Me.TxtGiacenza.Name = "TxtGiacenza"
        Me.TxtGiacenza.Size = New System.Drawing.Size(112, 23)
        Me.TxtGiacenza.TabIndex = 7
        Me.TxtGiacenza.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Merce Ordinata e non Pervenuta"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Merce Impegnata su Ordini"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtAcquisti
        '
        Me.TxtAcquisti.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtAcquisti.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtAcquisti.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TxtAcquisti.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAcquisti.Location = New System.Drawing.Point(176, 40)
        Me.TxtAcquisti.Name = "TxtAcquisti"
        Me.TxtAcquisti.Size = New System.Drawing.Size(112, 23)
        Me.TxtAcquisti.TabIndex = 12
        Me.TxtAcquisti.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TxtAcquisti.UseVisualStyleBackColor = False
        '
        'ComDataUltimoInventarioGenerale
        '
        Me.ComDataUltimoInventarioGenerale.CommandText = "SELECT TOP 1 DataDocumento FROM ordineFornitore WHERE (NumDocumento = N'INVENTARI" & _
    "O') AND (Societa = @Varditta) ORDER BY DataDocumento DESC"
        Me.ComDataUltimoInventarioGenerale.Connection = Me.SqlConnection1
        Me.ComDataUltimoInventarioGenerale.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Varditta", System.Data.SqlDbType.NVarChar, 1, "Societa")})
        '
        'ComUltimoInventarioProdotto
        '
        Me.ComUltimoInventarioProdotto.CommandText = resources.GetString("ComUltimoInventarioProdotto.CommandText")
        Me.ComUltimoInventarioProdotto.Connection = Me.SqlConnection1
        Me.ComUltimoInventarioProdotto.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Varditta", System.Data.SqlDbType.NVarChar, 1, "Societa"), New System.Data.SqlClient.SqlParameter("@IdProdotto", System.Data.SqlDbType.Int, 4, "IdArticolo"), New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 4, "Data")})
        '
        'ComAcquistiArrivati
        '
        Me.ComAcquistiArrivati.CommandText = resources.GetString("ComAcquistiArrivati.CommandText")
        Me.ComAcquistiArrivati.Connection = Me.SqlConnection1
        Me.ComAcquistiArrivati.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Varditta", System.Data.SqlDbType.NVarChar, 1, "Societa"), New System.Data.SqlClient.SqlParameter("@IdProdotto", System.Data.SqlDbType.Int, 4, "IdArticolo"), New System.Data.SqlClient.SqlParameter("@Datainizio", System.Data.SqlDbType.DateTime, 8, "DataDocumento")})
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
        Me.TxtVenduta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TxtVenduta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVenduta.Location = New System.Drawing.Point(176, 64)
        Me.TxtVenduta.Name = "TxtVenduta"
        Me.TxtVenduta.Size = New System.Drawing.Size(112, 23)
        Me.TxtVenduta.TabIndex = 13
        Me.TxtVenduta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TxtVenduta.UseVisualStyleBackColor = False
        '
        'TxtOrdiniNonPervenuti
        '
        Me.TxtOrdiniNonPervenuti.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtOrdiniNonPervenuti.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtOrdiniNonPervenuti.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TxtOrdiniNonPervenuti.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOrdiniNonPervenuti.Location = New System.Drawing.Point(176, 240)
        Me.TxtOrdiniNonPervenuti.Name = "TxtOrdiniNonPervenuti"
        Me.TxtOrdiniNonPervenuti.Size = New System.Drawing.Size(112, 23)
        Me.TxtOrdiniNonPervenuti.TabIndex = 14
        Me.TxtOrdiniNonPervenuti.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TxtOrdiniNonPervenuti.UseVisualStyleBackColor = False
        '
        'TxtImpegnati
        '
        Me.TxtImpegnati.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtImpegnati.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtImpegnati.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TxtImpegnati.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImpegnati.Location = New System.Drawing.Point(176, 272)
        Me.TxtImpegnati.Name = "TxtImpegnati"
        Me.TxtImpegnati.Size = New System.Drawing.Size(112, 23)
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
        'GridDettagliInventario
        '
        Me.GridDettagliInventario.AllowSort = False
        Me.GridDettagliInventario.AllowUpdate = False
        Me.GridDettagliInventario.DataSource = Me.DsDettagliInventario1.DettagliInventario
        Me.GridDettagliInventario.Images.Add(CType(resources.GetObject("GridDettagliInventario.Images"), System.Drawing.Image))
        Me.GridDettagliInventario.Location = New System.Drawing.Point(296, 8)
        Me.GridDettagliInventario.Name = "GridDettagliInventario"
        Me.GridDettagliInventario.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.GridDettagliInventario.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.GridDettagliInventario.PreviewInfo.ZoomFactor = 75.0R
        Me.GridDettagliInventario.PrintInfo.PageSettings = CType(resources.GetObject("GridDettagliInventario.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.GridDettagliInventario.PropBag = resources.GetString("GridDettagliInventario.PropBag")
        Me.GridDettagliInventario.Size = New System.Drawing.Size(488, 288)
        Me.GridDettagliInventario.TabIndex = 16
        Me.GridDettagliInventario.Text = "C1TrueDBGrid1"
        Me.GridDettagliInventario.Visible = False
        '
        'DsUDMListino
        '
        Me.DsUDMListino.DataSetName = "NewDataSet"
        Me.DsUDMListino.Locale = New System.Globalization.CultureInfo("it-IT")
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
        Me.ComUDMListino.CommandText = "SELECT UDM, RapportoUnita1, Confezioni, RapportoUnita2, Cartoni, RapportoUnita3 F" & _
    "ROM ListGenDettagli WHERE (Progressivo = @IdProdotto)"
        Me.ComUDMListino.Connection = Me.SqlConnection1
        Me.ComUDMListino.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@IdProdotto", System.Data.SqlDbType.Int, 4, "Progressivo")})
        '
        'TxtMessaggio
        '
        Me.TxtMessaggio.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtMessaggio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMessaggio.Location = New System.Drawing.Point(8, 152)
        Me.TxtMessaggio.Name = "TxtMessaggio"
        Me.TxtMessaggio.Size = New System.Drawing.Size(280, 80)
        Me.TxtMessaggio.TabIndex = 17
        Me.TxtMessaggio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CMBUDM
        '
        Me.CMBUDM.Location = New System.Drawing.Point(192, 120)
        Me.CMBUDM.Name = "CMBUDM"
        Me.CMBUDM.Size = New System.Drawing.Size(96, 21)
        Me.CMBUDM.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 23)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Visualizza Altre UDM Previste"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormGiacenze
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(792, 302)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CMBUDM)
        Me.Controls.Add(Me.TxtMessaggio)
        Me.Controls.Add(Me.GridDettagliInventario)
        Me.Controls.Add(Me.TxtImpegnati)
        Me.Controls.Add(Me.TxtOrdiniNonPervenuti)
        Me.Controls.Add(Me.TxtVenduta)
        Me.Controls.Add(Me.TxtAcquisti)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtGiacenza)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtGiacenzeIniziali)
        Me.Controls.Add(Me.LabGiacenzeIniziali)
        Me.Name = "FormGiacenze"
        Me.Text = "Giacenze"
        CType(Me.DsDettagliInventario1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDettagliInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsUDMListino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Friend Sub Carico_Giacenze()
        'Carico le unità di misura previste per il prodotto
        Dim leggo As SqlClient.SqlDataReader
        Dim Confronto As String = ""
        DsUDMListino.Clear()
        If ComUDMListino.Connection.State = ConnectionState.Closed Then ComUDMListino.Connection.Open()
        ComUDMListino.Parameters("@Idprodotto").Value = IdProdotto
        leggo = ComUDMListino.ExecuteReader
        leggo.Read()
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
        If leggo(4).ToString <> leggo(0).ToString And leggo(4).ToString <> leggo(2).ToString Then DsUDMListino.Tables(0).Rows.Add(riga)
        leggo.Close()
        'cerco la data dell'ultimo inventario (Intestazione)
        If ComDataUltimoInventarioGenerale.Connection.State = ConnectionState.Closed Then ComDataUltimoInventarioGenerale.Connection.Open()
        ComDataUltimoInventarioGenerale.Parameters("@Varditta").Value = varditta
        If Not ComDataUltimoInventarioGenerale.ExecuteScalar Is Nothing Then DataInventario = CDate(ComDataUltimoInventarioGenerale.ExecuteScalar) Else DataInventario = CDate("01/01/" & Str(Today.Year))
        'Vedo se il prodotto è stato inventariato in una data successiva
        TxtGiacenzeIniziali.Text = "0"

        ComUltimoInventarioProdotto.Parameters("@Varditta").Value = varditta
        ComUltimoInventarioProdotto.Parameters("@idprodotto").Value = IdProdotto
        ComUltimoInventarioProdotto.Parameters("@Data").Value = DataInventario
        leggo = ComUltimoInventarioProdotto.ExecuteReader
        leggo.Read()
        If leggo.HasRows Then
            DataInventario = CDate(leggo("datainventario"))
            Confronto = ""
            For Each riga In DsUDMListino.Tables(0).Rows
                Confronto = Confronto + riga("UDM").ToString.Trim
                If riga("UDM").ToString = leggo("UDM").ToString Then
                    If IsNumeric(leggo("quantitaconsegnata")) Then riga("Giacenze") = leggo("Quantitaconsegnata")
                End If

            Next
            If Confronto.IndexOf(leggo("UDM").ToString) = -1 Then
                riga("FlagIncongruenza") = True
            End If
        End If
        leggo.Close()
        'aggiungo un giorno alla data dell'inventario
        DataInventario = DataInventario.AddDays(1)
        TxtAcquisti.Text = "0"

        'calcolo gli acquisti da quella data
        ComAcquistiArrivati.Parameters("@Varditta").Value = varditta
        ComAcquistiArrivati.Parameters("@idprodotto").Value = IdProdotto
        ComAcquistiArrivati.Parameters("@DataInizio").Value = DataInventario


        leggo = ComAcquistiArrivati.ExecuteReader
        While leggo.Read
            Confronto = ""
            For Each riga In DsUDMListino.Tables(0).Rows
                Confronto = Confronto + riga("UDM").ToString.Trim
                If riga("UDM").ToString = leggo("UDM").ToString Then
                    If IsNumeric(leggo("Acquisti")) Then riga("Carico") = leggo("Acquisti")
                End If
            Next
            If Confronto.IndexOf(leggo("UDM").ToString) = -1 Then
                riga("FlagIncongruenza") = True
                If IsNumeric(leggo("Acquisti")) Then riga("Carico") = leggo("Acquisti")
            End If
        End While
        leggo.Close()
        'Calcolo gli ordini fatti ma non pervenuta la merce
        TxtOrdiniNonPervenuti.Text = "0"
        ComAcquistiDaArrivare.Parameters("@Varditta").Value = varditta
        ComAcquistiDaArrivare.Parameters("@idprodotto").Value = IdProdotto
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
        ComVenditeFatturate.Parameters("@idprodotto").Value = IdProdotto
        ComVenditeFatturate.Parameters("@DataInizio").Value = DataInventario
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
        ComVenditeDaFatturare.Parameters("@idprodotto").Value = IdProdotto
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
            TxtMessaggio.BackColor = System.Drawing.Color.Tomato
        End If


        LabGiacenzeIniziali.Text = "Giacenze Iniziali al: " & DataInventario.ToShortDateString
        TxtGiacenza.Text = Format(CDec(TxtGiacenzeIniziali.Text) + CDec(TxtAcquisti.Text) - CDec(TxtVenduta.Text), "#,##0.00")
        If CDec(TxtGiacenza.Text) >= 0 Then TxtGiacenza.BackColor = System.Drawing.Color.GreenYellow Else TxtGiacenza.BackColor = System.Drawing.Color.Red

    End Sub
    Private Sub FormGiacenze_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Carico_Giacenze()

    End Sub

    Private Sub TxtAcquisti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAcquisti.Click
        DsDettagliInventario1.Clear()
        excel = "Carico"
        GridDettagliInventario.Visible = False
        GridDettagliInventario.Caption = "Dettaglio della merce Acquistata e Arrivata dalla Data del " & DataInventario.ToShortDateString & " Bt Destro = Excel"
        If ComAcquistiArrivatiTutti.Connection.State = ConnectionState.Closed Then ComAcquistiArrivatiTutti.Connection.Open()
        ComAcquistiArrivatiTutti.Parameters("@Varditta").Value = varditta
        ComAcquistiArrivatiTutti.Parameters("@idprodotto").Value = IdProdotto
        ComAcquistiArrivatiTutti.Parameters("@DataInizio").Value = DataInventario
        Dim leggo As SqlClient.SqlDataReader = ComAcquistiArrivatiTutti.ExecuteReader
        Dim riga As DataRow = DsDettagliInventario1.Tables(0).NewRow
        While leggo.Read
            riga = DsDettagliInventario1.Tables(0).NewRow
            riga("quantita") = leggo("quantita")
            riga("UDM") = leggo("UDM")
            riga("NumOrdine") = leggo("NumOrdine")
            riga("DataOrdine") = leggo("DataOrdine")
            riga("DataConsegna") = leggo("DataConsegna")
            riga("Descrizione") = leggo("Descrizione")
            riga("CliFor") = leggo("CliFor")
            DsDettagliInventario1.Tables(0).Rows.Add(riga)
        End While

        leggo.Close()
        If DsDettagliInventario1.Tables(0).Rows.Count > 0 Then
            GridDettagliInventario.Splits(0).DisplayColumns("Num. Fatt.").Visible = False
            GridDettagliInventario.Splits(0).DisplayColumns("Data Fatt.").Visible = False
            GridDettagliInventario.Splits(0).DisplayColumns("Ordine N.").Visible = True
            GridDettagliInventario.Splits(0).DisplayColumns("Data Ordine").Visible = True
            GridDettagliInventario.Visible = True
        End If





    End Sub

    Private Sub TxtOrdiniNonPervenuti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtOrdiniNonPervenuti.Click
        DsDettagliInventario1.Clear()
        excel = ""
        GridDettagliInventario.Visible = False
        GridDettagliInventario.Caption = "Dettaglio della merce Ordinata e non Ancora Arrivata dalla Data del "
        ' If DataInizialeLink.ToShortDateString = "01/01/1900" Then GridDettagliInventario.Caption = GridDettagliInventario.Caption & DataInventario.ToShortDateString Else GridDettagliInventario.Caption = GridDettagliInventario.Caption & DataInizialeLink.ToShortDateString
        GridDettagliInventario.Caption = GridDettagliInventario.Caption & DataInizialeLink.ToShortDateString
        If ComAcquistiDaArrivareTutti.Connection.State = ConnectionState.Closed Then ComAcquistiDaArrivareTutti.Connection.Open()
        ComAcquistiDaArrivareTutti.Parameters("@Varditta").Value = varditta
        ComAcquistiDaArrivareTutti.Parameters("@idprodotto").Value = IdProdotto
        ' If DataInizialeLink.ToShortDateString = "01/01/1900" Then ComAcquistiDaArrivareTutti.Parameters("@DataInizio").Value = DataInventario Else ComAcquistiDaArrivareTutti.Parameters("@DataInizio").Value = DataInizialeLink
        ComAcquistiDaArrivareTutti.Parameters("@DataInizio").Value = DataInizialeLink
        Dim leggo As SqlClient.SqlDataReader = ComAcquistiDaArrivareTutti.ExecuteReader
        Dim riga As DataRow = DsDettagliInventario1.Tables(0).NewRow
        While leggo.Read
            riga = DsDettagliInventario1.Tables(0).NewRow
            riga("UDM") = leggo("UDM")
            riga("NumOrdine") = leggo("NumOrdine")

            riga("DataConsegna") = leggo("DataConsegna")
            riga("Descrizione") = leggo("Descrizione")
            riga("CliFor") = leggo("CliFor")
            riga("DataOrdine") = leggo("DataOrdine")
            riga("quantita") = leggo("quantita")

            DsDettagliInventario1.Tables(0).Rows.Add(riga)
        End While

        leggo.Close()
        If DsDettagliInventario1.Tables(0).Rows.Count > 0 Then
            GridDettagliInventario.Splits(0).DisplayColumns("Num. Fatt.").Visible = False
            GridDettagliInventario.Splits(0).DisplayColumns("Data Fatt.").Visible = False
            GridDettagliInventario.Splits(0).DisplayColumns("Ordine N.").Visible = True
            GridDettagliInventario.Splits(0).DisplayColumns("Data Ordine").Visible = True
            GridDettagliInventario.Visible = True
        End If

    End Sub

    Private Sub TxtVenduta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtVenduta.Click
        DsDettagliInventario1.Clear()
        excel = "Scarico"
        GridDettagliInventario.Visible = False
        GridDettagliInventario.Caption = "Dettaglio della merce Venduta e fatturata dalla Data del " & DataInventario.ToShortDateString & "BT Destro = Excel"
        If ComVenditeFatturateTutti.Connection.State = ConnectionState.Closed Then ComVenditeFatturateTutti.Connection.Open()
        ComVenditeFatturateTutti.Parameters("@Varditta").Value = varditta
        ComVenditeFatturateTutti.Parameters("@idprodotto").Value = IdProdotto
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
        If DsDettagliInventario1.Tables(0).Rows.Count > 0 Then
            GridDettagliInventario.Splits(0).DisplayColumns("Data Cons.").Visible = False
            GridDettagliInventario.Splits(0).DisplayColumns("Ordine N.").Visible = False
            GridDettagliInventario.Splits(0).DisplayColumns("Data Fatt.").Visible = True
            GridDettagliInventario.Splits(0).DisplayColumns("Data Ordine").Visible = False

            GridDettagliInventario.Visible = True
        End If

    End Sub

    Private Sub TxtImpegnati_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtImpegnati.Click
        DsDettagliInventario1.Clear()
        excel = ""
        GridDettagliInventario.Visible = False
        GridDettagliInventario.Caption = "Dettaglio della merce Venduta ma non ancora Fatturata dalla Data del "
        ' If DataInizialeLink.ToShortDateString = "01/01/1900" Then GridDettagliInventario.Caption = GridDettagliInventario.Caption & DataInventario.ToShortDateString Else GridDettagliInventario.Caption = GridDettagliInventario.Caption & DataInizialeLink.ToShortDateString
        GridDettagliInventario.Caption = GridDettagliInventario.Caption & DataInizialeLink.ToShortDateString
        If ComVenditeDaFatturareTutti.Connection.State = ConnectionState.Closed Then ComVenditeDaFatturareTutti.Connection.Open()
        ComVenditeDaFatturareTutti.Parameters("@Varditta").Value = varditta
        ComVenditeDaFatturareTutti.Parameters("@idprodotto").Value = IdProdotto
        ' If DataInizialeLink.ToShortDateString = "01/01/1900" Then ComVenditeDaFatturareTutti.Parameters("@DataInizio").Value = DataInventario Else ComVenditeDaFatturareTutti.Parameters("@DataInizio").Value = DataInizialeLink
        ComVenditeDaFatturareTutti.Parameters("@DataInizio").Value = DataInizialeLink
        Dim leggo As SqlClient.SqlDataReader = ComVenditeDaFatturareTutti.ExecuteReader
        Dim riga As DataRow = DsDettagliInventario1.Tables(0).NewRow
        While leggo.Read
            riga = DsDettagliInventario1.Tables(0).NewRow
            riga("quantita") = leggo("quantita")
            riga("UDM") = leggo("UDM")
            riga("CliFor") = leggo("CliFor")
            riga("DataOrdine") = leggo("DataOrdine")
            riga("DataConsegna") = leggo("DataConsegna")
            riga("Descrizione") = leggo("Descrizione")
            riga("NumOrdine") = leggo("NumOrdine")
            riga("FlagImpegnato") = leggo("FlagImpegnato")

            DsDettagliInventario1.Tables(0).Rows.Add(riga)
        End While

        leggo.Close()
        If DsDettagliInventario1.Tables(0).Rows.Count > 0 Then

            GridDettagliInventario.Splits(0).DisplayColumns("Data Cons.").Visible = True
            GridDettagliInventario.Splits(0).DisplayColumns("Ordine N.").Visible = True
            GridDettagliInventario.Splits(0).DisplayColumns("Data Fatt.").Visible = False
            GridDettagliInventario.Splits(0).DisplayColumns("Num. Fatt.").Visible = False

            GridDettagliInventario.Visible = True
            GridDettagliInventario.FetchRowStyles = True
            GridDettagliInventario.Refresh()
        End If
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
            If CDec(TxtGiacenza.Text) >= 0 Then TxtGiacenza.BackColor = System.Drawing.Color.GreenYellow Else TxtGiacenza.BackColor = System.Drawing.Color.Red
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
                If CDec(TxtGiacenza.Text) >= 0 Then TxtGiacenza.BackColor = System.Drawing.Color.GreenYellow Else TxtGiacenza.BackColor = System.Drawing.Color.Red
            End If
        Next



    End Sub

    Private Sub GridDettagliInventario_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles GridDettagliInventario.FetchRowStyle
        If GridDettagliInventario(e.Row, "FlagImpegnato").ToString = "*" Then
            Dim newfont As New Font(GridDettagliInventario.Font, FontStyle.Strikeout)
            e.CellStyle.Font = newfont
        End If

    End Sub
    Private Sub Gridxgiacenzedettagli_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles GridDettagliInventario.MouseUp
        If DsDettagliInventario1.Tables(0).Rows.Count = 0 Then Exit Sub
        If excel = "" Then Exit Sub
        If GridDettagliInventario.PointAt(e.X, e.Y) = C1.Win.C1TrueDBGrid.PointAtEnum.AtCaption And e.Button = System.Windows.Forms.MouseButtons.Right Then
            Dim nomefile As String = GetUniqueTempFileName("\Carico " & IdProdotto & excel & ".xls")
            If System.IO.File.Exists(nomefile) Then

                System.IO.File.Delete(nomefile)
            End If

            GridDettagliInventario.ExportToExcel(nomefile)
            System.Diagnostics.Process.Start(nomefile)
        End If
    End Sub


    Private Function GetUniqueTempFileName(ext As String) As String
        Dim TEMP_DIR As String = System.Environment.GetEnvironmentVariable("tmp")

        Return (TEMP_DIR & ext)
    End Function


End Class
