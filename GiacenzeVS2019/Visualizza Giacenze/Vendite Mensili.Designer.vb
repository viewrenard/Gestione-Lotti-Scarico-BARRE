<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vendite_Mensili
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vendite_Mensili))
        Me.TxtDallaData = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtAllaData = New System.Windows.Forms.DateTimePicker()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.AdapterVenditeMensili = New System.Data.SqlClient.SqlDataAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.C1TrueDBGrid1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.DsVenditeMensili1 = New Visualizza_Giacenze_Barre.DsVenditeMensili()
        Me.GridDettagliInventario = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.DsDettagliInventario1 = New Visualizza_Giacenze_Barre.DsDettagliInventario()
        Me.ComVenditeFatturateTutti = New System.Data.SqlClient.SqlCommand()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsVenditeMensili1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDettagliInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsDettagliInventario1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtDallaData
        '
        Me.TxtDallaData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TxtDallaData.Location = New System.Drawing.Point(75, 3)
        Me.TxtDallaData.Name = "TxtDallaData"
        Me.TxtDallaData.Size = New System.Drawing.Size(97, 20)
        Me.TxtDallaData.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Dalla Data"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Alla Data"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'TxtAllaData
        '
        Me.TxtAllaData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TxtAllaData.Location = New System.Drawing.Point(256, 2)
        Me.TxtAllaData.Name = "TxtAllaData"
        Me.TxtAllaData.Size = New System.Drawing.Size(97, 20)
        Me.TxtAllaData.TabIndex = 3
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@IdProdotto", System.Data.SqlDbType.Int, 4, "progressivo"), New System.Data.SqlClient.SqlParameter("@datainizio", System.Data.SqlDbType.SmallDateTime, 4, "Data"), New System.Data.SqlClient.SqlParameter("@datafine", System.Data.SqlDbType.SmallDateTime, 4, "Data"), New System.Data.SqlClient.SqlParameter("@Varditta", System.Data.SqlDbType.NVarChar, 1, "Societa")})
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=DATASERVER\SQLPROCEDURA;Initial Catalog=vermarnew;User ID=fox;Passwor" & _
    "d=31iris46"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'AdapterVenditeMensili
        '
        Me.AdapterVenditeMensili.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterVenditeMensili.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SpecifichePrevOrdFatt", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Anno", "Anno"), New System.Data.Common.DataColumnMapping("Mese", "Mese"), New System.Data.Common.DataColumnMapping("Vendite", "Vendite"), New System.Data.Common.DataColumnMapping("UDM", "UDM")})})
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(359, -1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Carica Prospetto Mensile"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'C1TrueDBGrid1
        '
        Me.C1TrueDBGrid1.AllowUpdate = False
        Me.C1TrueDBGrid1.AllowUpdateOnBlur = False
        Me.C1TrueDBGrid1.Caption = "Tasto Mouse Destro: Passa Excel"
        Me.C1TrueDBGrid1.DataMember = "SpecifichePrevOrdFatt"
        Me.C1TrueDBGrid1.DataSource = Me.DsVenditeMensili1
        Me.C1TrueDBGrid1.FetchRowStyles = True
        Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("C1TrueDBGrid1.Images"), System.Drawing.Image))
        Me.C1TrueDBGrid1.Location = New System.Drawing.Point(15, 49)
        Me.C1TrueDBGrid1.Name = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.ZoomFactor = 75.0R
        Me.C1TrueDBGrid1.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1TrueDBGrid1.PropBag = resources.GetString("C1TrueDBGrid1.PropBag")
        Me.C1TrueDBGrid1.Size = New System.Drawing.Size(358, 358)
        Me.C1TrueDBGrid1.TabIndex = 5
        Me.C1TrueDBGrid1.Text = "C1TrueDBGrid1"
        '
        'DsVenditeMensili1
        '
        Me.DsVenditeMensili1.DataSetName = "DsVenditeMensili"
        Me.DsVenditeMensili1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridDettagliInventario
        '
        Me.GridDettagliInventario.AllowUpdate = False
        Me.GridDettagliInventario.DataMember = "DettagliInventario"
        Me.GridDettagliInventario.DataSource = Me.DsDettagliInventario1
        Me.GridDettagliInventario.Images.Add(CType(resources.GetObject("GridDettagliInventario.Images"), System.Drawing.Image))
        Me.GridDettagliInventario.Location = New System.Drawing.Point(379, 49)
        Me.GridDettagliInventario.Name = "GridDettagliInventario"
        Me.GridDettagliInventario.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.GridDettagliInventario.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.GridDettagliInventario.PreviewInfo.ZoomFactor = 75.0R
        Me.GridDettagliInventario.PrintInfo.PageSettings = CType(resources.GetObject("GridDettagliInventario.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.GridDettagliInventario.PropBag = resources.GetString("GridDettagliInventario.PropBag")
        Me.GridDettagliInventario.Size = New System.Drawing.Size(488, 358)
        Me.GridDettagliInventario.TabIndex = 17
        Me.GridDettagliInventario.Text = "C1TrueDBGrid1"
        Me.GridDettagliInventario.Visible = False
        '
        'DsDettagliInventario1
        '
        Me.DsDettagliInventario1.DataSetName = "DsDettagliInventario"
        Me.DsDettagliInventario1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComVenditeFatturateTutti
        '
        Me.ComVenditeFatturateTutti.CommandText = resources.GetString("ComVenditeFatturateTutti.CommandText")
        Me.ComVenditeFatturateTutti.Connection = Me.SqlConnection1
        Me.ComVenditeFatturateTutti.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Varditta", System.Data.SqlDbType.NVarChar, 1, "Societa"), New System.Data.SqlClient.SqlParameter("@Idprodotto", System.Data.SqlDbType.Int, 4, "progressivo"), New System.Data.SqlClient.SqlParameter("@Mese", System.Data.SqlDbType.[Decimal]), New System.Data.SqlClient.SqlParameter("@Anno", System.Data.SqlDbType.[Decimal])})
        '
        'Vendite_Mensili
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 408)
        Me.Controls.Add(Me.GridDettagliInventario)
        Me.Controls.Add(Me.C1TrueDBGrid1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtAllaData)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtDallaData)
        Me.Name = "Vendite_Mensili"
        Me.Text = "Prospetto Vendite Mensili"
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsVenditeMensili1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDettagliInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsDettagliInventario1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtDallaData As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtAllaData As System.Windows.Forms.DateTimePicker
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents AdapterVenditeMensili As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsVenditeMensili1 As Visualizza_Giacenze_Barre.DsVenditeMensili
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents C1TrueDBGrid1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents GridDettagliInventario As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents DsDettagliInventario1 As Visualizza_Giacenze_Barre.DsDettagliInventario
    Friend WithEvents ComVenditeFatturateTutti As System.Data.SqlClient.SqlCommand
End Class
