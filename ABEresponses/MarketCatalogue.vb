''' <summary>
''' MarketCatalogue - Objekt, erbt die Properties aus clsResponseRoot
''' </summary>
Public Class MarketCatalogue
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>The unique identifier for the market. MarketId's are prefixed with '1.'</returns>
    Public Property marketId As System.String = "---"
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>The name of the market</returns>
    Public Property marketName As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' wew
    ''' </summary>
    ''' <returns>The time this market starts at, only returned when the MARKET_START_TIME enum is passed in the marketProjections</returns>
    Public Property marketStartTime As System.DateTime
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>Details about the market</returns>
    Public Property description As MarketDescription = New MarketDescription
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The total amount of money matched on the market</returns>
    Public Property totalMatched As System.Double = -1
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The runners (selections) contained in the market</returns>
    Public Property runners As List(Of RunnerCatalog) = New List(Of RunnerCatalog)
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The Event Type the market is contained within</returns>
    Public Property eventType As EventType = New EventType
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The competition the market is contained within. Usually only applies to Football competitions</returns>
    Public Property competition As Competition = New Competition
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The event the market is contained within</returns>
    Public Property [event] As [Event] = New [Event]



    Function gettable() As System.Data.DataTable
        Dim dt As New System.Data.DataTable("MarketCatalogue")
        dt.Columns.Add(New DataColumn With {.ColumnName = "MARKETCATALOGUE_ID", .DataType = GetType(System.Int16)})

        Dim i = 0

        For Each tab As RunnerCatalog In runners
            dt.Columns("MARKETCATALOGUE_ID").DefaultValue = i
            dt.Merge(tab.gettable, True, MissingSchemaAction.Add)
            i += 1
        Next


        dt.Columns.Add(New DataColumn With {.ColumnName = "MARKETCATALOGUE_MARKETID", .DataType = GetType(System.String), .DefaultValue = marketId})

        dt.Merge([event].gettable, True, MissingSchemaAction.Add)
        dt.Merge(competition.gettable, True, MissingSchemaAction.Add)
        dt.Merge(eventType.gettable, True, MissingSchemaAction.Add)
        dt.Columns.Add(New DataColumn With {.ColumnName = "MARKETCATALOGUE_TOTALMATCHED", .DataType = GetType(System.Double), .DefaultValue = totalMatched})
        dt.Merge(description.gettable, True, MissingSchemaAction.Add)
        dt.Columns.Add(New DataColumn With {.ColumnName = "MARKETCATALOGUE_MARKETNAME", .DataType = GetType(System.String), .DefaultValue = marketName})
        dt.Columns.Add(New DataColumn With {.ColumnName = "MARKETCATALOGUE_MARKETSTARTTIME", .DataType = GetType(System.DateTime), .DefaultValue = marketStartTime})




        Return dt

    End Function


End Class
