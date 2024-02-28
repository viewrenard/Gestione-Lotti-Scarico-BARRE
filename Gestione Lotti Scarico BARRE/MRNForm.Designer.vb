<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MRNForm
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MRNForm))
		Me.BtAccetta = New System.Windows.Forms.Button()
		Me.BtCancella = New System.Windows.Forms.Button()
		Me.BtItem = New System.Windows.Forms.Button()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.AdapterMRN_DM = New System.Data.SqlClient.SqlDataAdapter()
		Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
		Me.SqlConnDMSQL = New System.Data.SqlClient.SqlConnection()
		Me.CommMRNuscitiDM = New System.Data.SqlClient.SqlCommand()
		Me.CommNoMRNUscitiDM = New System.Data.SqlClient.SqlCommand()
		Me.C1TrueDBGrid1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
		Me.DsMRNcaricoDM1 = New Gestione_Lotti_Scarico_BARRE.DsMRNcaricoDM()
		CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DsMRNcaricoDM1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'BtAccetta
		'
		Me.BtAccetta.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtAccetta.Location = New System.Drawing.Point(12, 227)
		Me.BtAccetta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.BtAccetta.Name = "BtAccetta"
		Me.BtAccetta.Size = New System.Drawing.Size(140, 69)
		Me.BtAccetta.TabIndex = 22
		Me.BtAccetta.Text = "Accetta"
		Me.BtAccetta.UseVisualStyleBackColor = True
		'
		'BtCancella
		'
		Me.BtCancella.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtCancella.Location = New System.Drawing.Point(444, 227)
		Me.BtCancella.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.BtCancella.Name = "BtCancella"
		Me.BtCancella.Size = New System.Drawing.Size(140, 69)
		Me.BtCancella.TabIndex = 21
		Me.BtCancella.Text = "Annulla"
		Me.BtCancella.UseVisualStyleBackColor = True
		'
		'BtItem
		'
		Me.BtItem.BackColor = System.Drawing.Color.LimeGreen
		Me.BtItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtItem.Location = New System.Drawing.Point(22, 61)
		Me.BtItem.Name = "BtItem"
		Me.BtItem.Size = New System.Drawing.Size(64, 44)
		Me.BtItem.TabIndex = 82
		Me.BtItem.UseVisualStyleBackColor = False
		'
		'Label17
		'
		Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label17.Location = New System.Drawing.Point(20, 2)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(78, 56)
		Me.Label17.TabIndex = 83
		Me.Label17.Text = "Scelta Item"
		Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'AdapterMRN_DM
		'
		Me.AdapterMRN_DM.SelectCommand = Me.SqlSelectCommand4
		Me.AdapterMRN_DM.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TB_ARTICOLI", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MRN", "MRN"), New System.Data.Common.DataColumnMapping("MASSANETTA_038", "MASSANETTA_038"), New System.Data.Common.DataColumnMapping("MASSALORDA_035", "MASSALORDA_035"), New System.Data.Common.DataColumnMapping("CodVermarDM", "CodVermarDM"), New System.Data.Common.DataColumnMapping("NumRiga", "NumRiga"), New System.Data.Common.DataColumnMapping("CodiceDM", "CodiceDM"), New System.Data.Common.DataColumnMapping("Colli", "Colli"), New System.Data.Common.DataColumnMapping("PROGRESSIVO", "PROGRESSIVO"), New System.Data.Common.DataColumnMapping("ALFA", "ALFA")})})
		'
		'SqlSelectCommand4
		'
		Me.SqlSelectCommand4.CommandText = resources.GetString("SqlSelectCommand4.CommandText")
		Me.SqlSelectCommand4.Connection = Me.SqlConnDMSQL
		Me.SqlSelectCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@IdVermar", System.Data.SqlDbType.VarChar, 1024)})
		'
		'SqlConnDMSQL
		'
		Me.SqlConnDMSQL.ConnectionString = "Data Source=DATASERVER\SQLPROCEDURA;Initial Catalog=DMSQL_VerMar;Persist Security" &
	" Info=True;User ID=sa;Password=31iris46"
		Me.SqlConnDMSQL.FireInfoMessageEventOnUserErrors = False
		'
		'CommMRNuscitiDM
		'
		Me.CommMRNuscitiDM.CommandText = resources.GetString("CommMRNuscitiDM.CommandText")
		Me.CommMRNuscitiDM.Connection = Me.SqlConnDMSQL
		Me.CommMRNuscitiDM.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@MRNCarico", System.Data.SqlDbType.[Char], 50, "DOCUMENTOPRECED_040_IDMRN"), New System.Data.SqlClient.SqlParameter("@NumItemCarico", System.Data.SqlDbType.[Char], 5, "DOCUMENTOPRECED_040_SINGOLORIFPREC")})
		'
		'CommNoMRNUscitiDM
		'
		Me.CommNoMRNUscitiDM.CommandText = resources.GetString("CommNoMRNUscitiDM.CommandText")
		Me.CommNoMRNUscitiDM.Connection = Me.SqlConnDMSQL
		Me.CommNoMRNUscitiDM.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.SmallDateTime, 4, "DOCUMENTOPRECED_040_DATAPREC"), New System.Data.SqlClient.SqlParameter("@NumItemCarico", System.Data.SqlDbType.[Char], 5, "DOCUMENTOPRECED_040_SINGOLORIFPREC"), New System.Data.SqlClient.SqlParameter("@NumDocCarico", System.Data.SqlDbType.[Char], 18, "DOCUMENTOPRECED_040_NUMREGISTRAZ"), New System.Data.SqlClient.SqlParameter("@CIN", System.Data.SqlDbType.[Char], 5, "DOCUMENTOPRECED_040_CIN")})
		'
		'C1TrueDBGrid1
		'
		Me.C1TrueDBGrid1.AllowSort = False
		Me.C1TrueDBGrid1.AllowUpdate = False
		Me.C1TrueDBGrid1.Caption = "Elenoc degli MRN con giacenze"
		Me.C1TrueDBGrid1.DataMember = "TB_ARTICOLI"
		Me.C1TrueDBGrid1.DataSource = Me.DsMRNcaricoDM1
		Me.C1TrueDBGrid1.FetchRowStyles = True
		Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("C1TrueDBGrid1.Images"), System.Drawing.Image))
		Me.C1TrueDBGrid1.Location = New System.Drawing.Point(126, 2)
		Me.C1TrueDBGrid1.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
		Me.C1TrueDBGrid1.Name = "C1TrueDBGrid1"
		Me.C1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
		Me.C1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
		Me.C1TrueDBGrid1.PreviewInfo.ZoomFactor = 75.0R
		Me.C1TrueDBGrid1.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
		Me.C1TrueDBGrid1.RowHeight = 42
		Me.C1TrueDBGrid1.Size = New System.Drawing.Size(458, 220)
		Me.C1TrueDBGrid1.TabIndex = 0
		Me.C1TrueDBGrid1.Text = "C1TrueDBGrid1"
		Me.C1TrueDBGrid1.PropBag = resources.GetString("C1TrueDBGrid1.PropBag")
		'
		'DsMRNcaricoDM1
		'
		Me.DsMRNcaricoDM1.DataSetName = "DsMRNcaricoDM"
		Me.DsMRNcaricoDM1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'MRNForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(596, 307)
		Me.Controls.Add(Me.Label17)
		Me.Controls.Add(Me.BtItem)
		Me.Controls.Add(Me.BtAccetta)
		Me.Controls.Add(Me.BtCancella)
		Me.Controls.Add(Me.C1TrueDBGrid1)
		Me.Name = "MRNForm"
		Me.Text = "MRNForm"
		CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DsMRNcaricoDM1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents C1TrueDBGrid1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
	Friend WithEvents DsMRNcaricoDM1 As DsMRNcaricoDM
	Friend WithEvents BtAccetta As Button
	Friend WithEvents BtCancella As Button
	Friend WithEvents BtItem As Button
	Friend WithEvents Label17 As Label
	Friend WithEvents AdapterMRN_DM As SqlClient.SqlDataAdapter
	Friend WithEvents SqlSelectCommand4 As SqlClient.SqlCommand
	Friend WithEvents SqlConnDMSQL As SqlClient.SqlConnection
	Friend WithEvents CommMRNuscitiDM As SqlClient.SqlCommand
	Friend WithEvents CommNoMRNUscitiDM As SqlClient.SqlCommand
End Class
