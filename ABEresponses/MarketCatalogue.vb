﻿Imports System.Net.Mime
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
        'dt.Columns.Add(New DataColumn With {.ColumnName = "MARKETCATALOGUE_ID", .DataType = GetType(Long)})

        Dim i = 0

        For Each tab As RunnerCatalog In runners
            'dt.Columns("MARKETCATALOGUE_ID").DefaultValue = i
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

        dt.Columns.Add(New DataColumn With {.ColumnName = "MARKETCATALOGUE_TIMESTAMP", .DataType = GetType(System.String), .DefaultValue = Date.Now.ToString("dd/MM/yyyy hh:mm:ss.fff tt")})
        dt.Columns.Add(New DataColumn With {.ColumnName = "MARKETCATALOGUE_NOW", .DataType = GetType(DateTime), .DefaultValue = Date.Now})
        dt.Columns.Add(New DataColumn With {.ColumnName = "MARKETCATALOGUE_NOWTICKS", .DataType = GetType(System.Int64), .DefaultValue = Date.Now.Ticks})

        dt.Columns.Add(New DataColumn With {.ColumnName = "HASHTAG", .DataType = GetType(System.String)})


        For Each rw As DataRow In dt.Rows
            If eventType.name = "Soccer" Then

                'rw("HASHTAG") = "#" & Left([event].name, 3) & Right([event].name, 3)

                rw("HASHTAG") = "#" & getAbbriviationFromName(([event].name).Split(New String() {" v "}, 0)(0)) & getAbbriviationFromName(([event].name).Split(New String() {" v "}, 1)(1))

            Else

                rw("HASHTAG") = "kein Fußball"

            End If

        Next

        Return dt

    End Function

    Public Function getnode() As System.Windows.Forms.TreeNode
        Dim newnode = New System.Windows.Forms.TreeNode With {.Text = "marketId: " & marketId, .Name = marketId, .Tag = marketId}
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "Zeitstempel: " & DateAndTime.Now, .Tag = DateAndTime.Now, .Name = "MARKETCATALOGUE_ZEITSTEMPEL"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "marketName: " & marketName, .Tag = marketName, .Name = "MARKETCATALOGUE_MARKETNAME"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "marketStartTime: " & marketStartTime, .Tag = marketStartTime, .Name = "MARKETCATALOGUE_MARKETSTARTTIME"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "totalMatched: " & totalMatched, .Tag = totalMatched, .Name = "MARKETCATALOGUE_TOTALMATCHED"})
        newnode.Nodes.Add(description.getnode)
        newnode.Nodes.Add(eventType.getnode)
        newnode.Nodes.Add(competition.getnode)
        newnode.Nodes.Add([event].getnode)

        For Each asdf As RunnerCatalog In runners

            newnode.Nodes.Add(asdf.getnode)

        Next



        Return newnode
    End Function

    Private Function getAbbriviationFromName(ByVal str As String) As String

        Select Case str
            Case Is = "Arminia Bielefeld"
                Return "DSC"
            Case Is = "1. FC Kaiserslautern"
                Return "FCK"
            Case Is = "Hannover 96"
                Return "H96"
            Case Is = "1. FC Nürnberg"
                Return "FCN"
            Case Is = "Bayer Leverkusen"
                Return "B04"
            Case Is = "Leverkusen"
                Return "B04"
            Case Is = "Borussia Mönchengladbach"
                Return "BMG"
            Case Is = "Mgladbach"
                Return "BMG"
            Case Is = "Werder Bremen"
                Return "BRE"
            Case Is = "Hertha BSC Berlin"
                Return "BSC"
            Case Is = "Hertha Berlin"
                Return "BSC"
            Case Is = "Borussia Dortmund"
                Return "BVB"
            Case Is = "Dortmund"
                Return "BVB"
            Case Is = "FC Augsburg"
                Return "FCA"
            Case Is = "Augsburg"
                Return "FCA"
            Case Is = "FC Bayern München"
                Return "FCB"
            Case Is = "Bayern Munich"
                Return "FCB"
            Case Is = "1. FC Kaiserslautern"
                Return "FCK"
            Case Is = "1. FC Nürnberg"
                Return "FCN"
            Case Is = "Hannover 96"
                Return "H96"
            Case Is = "1899 Hoffenheim"
                Return "HOF"
            Case Is = "Hoffenheim"
                Return "HOF"
            Case Is = "Hamburger SV"
                Return "HSV"
            Case Is = "1. FC Köln"
                Return "KOE"
            Case Is = "FC Koln"
                Return "KOE"
            Case Is = "Mainz 05"
                Return "M05"
            Case Is = "Mainz"
                Return "M05"
            Case Is = "FC Schalke 04"
                Return "S04"
            Case Is = "Schalke 04"
                Return "S04"
            Case Is = "SC Freiburg"
                Return "SCF"
            Case Is = "Freiburg"
                Return "SCF"
            Case Is = "VfB Stuttgart"
                Return "VFB"
            Case Is = "Stuttgart"
                Return "VFB"
            Case Is = "VfL Wolfsburg"
                Return "WOB"
            Case Is = "Wolfsburg"
                Return "WOB"
            Case Is = "Werder Bremen"
                Return "SVW"
            Case Is = "RB Leipzig"
                Return "RBL"
            Case Is = "Eintracht Frankfurt"
                Return "SGE"
            Case Is = "Union Berlin"
                Return "FCU"
            Case Is = "1899 Hoffenheim"
                Return "TSG"
            Case Is = "Arminia Bielefeld"
                Return "DSC"
            Case Else
                Return "###"
        End Select

    End Function


End Class
