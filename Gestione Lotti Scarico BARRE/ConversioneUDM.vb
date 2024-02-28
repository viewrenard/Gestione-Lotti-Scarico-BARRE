Module ConversioneUDM

    Friend peso As Decimal

    Class RitornoValori
        Private RapportoUDMrichiesto As Decimal
        Private UDM As String
        Private tabella As DataTable
        Public Property TrasloRapportoUDM As String
            Get
                Return RapportoUDMrichiesto
            End Get
            Set(ByVal value As String)
                UDM = value
                Dim riga As DataRow
                For Each riga In tabella.Rows
                    If riga("UDM").ToString.ToUpper.Replace(".", "") = UDM.ToUpper.Replace(".", "") Then RapportoUDMrichiesto = CDec(riga("Rapportounita"))
                Next
            End Set
        End Property

        Public Function ConvertoValoriQuantita(UDMPresente As String, UDMRichiesto As String, Valore As Decimal) As Decimal
            Dim pmpp As Integer = 0
            Dim RapportoUDMPresente As Decimal
            TrasloRapportoUDM = UDMPresente
            RapportoUDMPresente = TrasloRapportoUDM
            Dim RapportoUDMRichiesto As Decimal
            TrasloRapportoUDM = UDMRichiesto
            RapportoUDMRichiesto = TrasloRapportoUDM
            ConvertoValoriQuantita = Valore * RapportoUDMPresente / RapportoUDMRichiesto
        End Function

        Public Function ConvertoValoriImporto(UDMPresente As String, UDMRichiesto As String, Valore As Decimal) As Decimal
            Dim pmpp As Integer = 0
            Dim RapportoUDMPresente As Decimal
            TrasloRapportoUDM = UDMPresente
            RapportoUDMPresente = TrasloRapportoUDM
            Dim RapportoUDMRichiesto As Decimal
            TrasloRapportoUDM = UDMRichiesto
            RapportoUDMRichiesto = TrasloRapportoUDM
            ConvertoValoriImporto = Valore * RapportoUDMRichiesto / RapportoUDMPresente
        End Function
        Public WriteOnly Property CaricoDati As Integer
            Set(value As Integer)
                tabella = CaricoDatiArticolo(value)
            End Set
        End Property
        Public ReadOnly Property TabellaUDM As DataTable
            Get
                Return tabella
            End Get
        End Property
    End Class










    Public Function CaricoDatiArticolo(articolo As Integer) As DataTable
        'La funzione ha lo scopo di caricare una tabella (DATATABLE) con gli elementi dei tre tipi possibili di UDM e del loro rapporto con il peso 
        'Creo la tabella "CaricoDatiArticolo" ===============================================================================================================
        CaricoDatiArticolo = New DataTable
        CaricoDatiArticolo.Columns.Add("UDM", GetType(String))
        CaricoDatiArticolo.Columns.Add("RapportoUnita", GetType(Decimal))
        CaricoDatiArticolo.Columns.Add("Peso", GetType(Decimal))
        CaricoDatiArticolo.Columns.Add("UdmRitorno", GetType(Decimal))
        'Definisco un SqlCommand ===========================================================================================================================
        Dim SqlConnVermar As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection()
        Dim SqlComConvertiValoriUDM As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand
        SqlComConvertiValoriUDM.Connection = SqlConnVermar
        SqlConnVermar.ConnectionString = "Data Source=DATASERVER\SQLPROCEDURA;Initial Catalog=vermarnew;Persist Security In" & _
          "fo=True;User ID=fox;Password=31iris46"
        SqlConnVermar.FireInfoMessageEventOnUserErrors = False
        'Questo è il controllo se l'EAN è conforme ========================================================================================================
        SqlComConvertiValoriUDM.CommandText = "SELECT UDM, RapportoUnita1 AS RU_UDM, Confezioni, RapportoUnita2 AS RU_Confezione, Cartoni, RapportoUnita3 AS RU_Cartone FROM dbo.ListGenDettagli WHERE Progressivo = '" & articolo.ToString & "'"
        'Apro la connessione e carico gli elementi voluti =================================================================================================
        If SqlComConvertiValoriUDM.Connection.State = ConnectionState.Closed Then SqlComConvertiValoriUDM.Connection.Open()
        Dim leggo As SqlClient.SqlDataReader = SqlComConvertiValoriUDM.ExecuteReader
        If leggo.HasRows = False Then
            CaricoDatiArticolo.Clear() 'Se non ottengo nessul elemento la tabella deve essere vuota =======================================================
        Else
            leggo.Read()
            CaricoDatiArticolo.Rows.Add(leggo("UDM").ToString, CDec(leggo("RU_UDM").ToString))
            If leggo("Confezioni").ToString <> "" Then CaricoDatiArticolo.Rows.Add(leggo("Confezioni").ToString, CDec(leggo("RU_Confezione").ToString))
            If leggo("Cartoni").ToString <> "" Then CaricoDatiArticolo.Rows.Add(leggo("Cartoni").ToString, CDec(leggo("RU_Cartone").ToString))
        End If
        leggo.Close()
        Dim cerco() As DataRow
        cerco = CaricoDatiArticolo.Select("UDM = 'KG.' or UDM = 'LT.'")
        If cerco.Length = 0 Then
            CaricoDatiArticolo.Rows.Add("KG/LT", "1")

        End If
        peso = 2
        'Esco dalla Funzione =============================================================================================================================
    End Function


    Public Function ConvertiValoriUDM(Articolo As Integer, UDM_da_Convertire As String, Valore_da_Convertire As Decimal, UDM_Richiesto As String) As String
        'Per prima cosa Vado a vedere se l'articolo richiesto esiste e carico gli UDM e i Rapporto con l'unità ===========================================
        Dim Tabella As DataTable = CaricoDatiArticolo(Articolo)
       
        'Calcolo il Peso in Kg per la Quantità da convertire sulla base dell'UDM legato ad essa===========================================================
        Dim riga As DataRow
        Dim Peso_in_kg As Decimal = 0
        For Each riga In Tabella.Rows
            If riga("Udm").ToString.ToUpper.Replace(".", "") = UDM_da_Convertire.ToUpper.Replace(".", "") Then
                Peso_in_kg = CDec(riga("rapportounita") * Valore_da_Convertire)
            End If
        Next
        'Adesso converto la quantità in Peso per ciascuna UDM prevista dall'Articolo e lo carico nella tabella ===========================================
        Dim Valore_da_Convertire_Convertita As String = ""
        For Each riga In Tabella.Rows
            If riga("UDM").ToString <> "" Then riga("Peso") = CDec(Peso_in_kg / CDec(riga("RapportoUnita")))
            'Approfitto del loop per restituire il valore convertito per l'UDM indicata (se esiste ovviamente) ===========================================
            If riga("UDM").ToString.ToUpper.Replace(".", "") = UDM_Richiesto.ToUpper.Replace(".", "") Then Valore_da_Convertire_Convertita = CDec(riga("Peso"))
        Next
        ConvertiValoriUDM = Valore_da_Convertire_Convertita 'Ho preferito usare String anzichè Decimal per maggiore flessibilità =========================
    End Function
    Public Function ConvertiValoriUDMDataTable(Tabella As DataTable, UDM_da_Convertire As String, Valore_da_Convertire As Decimal, UDM_Richiesto As String) As String

        'Calcolo il Peso in Kg per la Quantità da convertire sulla base dell'UDM legato ad essa===========================================================
        Dim riga As DataRow
        Dim Peso_in_kg As Decimal = 0
        For Each riga In Tabella.Rows
            If riga("Udm").ToString.ToUpper.Replace(".", "") = UDM_da_Convertire.ToUpper.Replace(".", "") Then
                Peso_in_kg = CDec(riga("rapportounita") * Valore_da_Convertire)
            End If
        Next
        'Adesso converto la quantità in Peso per ciascuna UDM prevista dall'Articolo e lo carico nella tabella ===========================================
        Dim Valore_da_Convertire_Convertita As String = ""
        For Each riga In Tabella.Rows
            If riga("UDM").ToString <> "" Then riga("Peso") = CDec(Peso_in_kg / CDec(riga("RapportoUnita")))
            'Approfitto del loop per restituire il valore convertito per l'UDM indicata (se esiste ovviamente) ===========================================
            If riga("UDM").ToString.ToUpper.Replace(".", "") = UDM_Richiesto.ToUpper.Replace(".", "") Then Valore_da_Convertire_Convertita = CDec(riga("Peso"))
        Next
        ConvertiValoriUDMDataTable = Valore_da_Convertire_Convertita 'Ho preferito usare String anzichè Decimal per maggiore flessibilità =================
    End Function


End Module
