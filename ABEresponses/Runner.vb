''' <summary>
''' The dynamic data about runners in a market
''' </summary>
Public Class Runner
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>The unique id of the runner (selection)</returns>
    Public Property selectionId As System.Int64 = 0
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>The handicap.  Enter the specific handicap value (returned by RUNNER in listMaketBook) if the market is an Asian handicap market.</returns>
    Public Property handicap As System.Double = -1
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>The status of the selection (i.e., ACTIVE, REMOVED, WINNER, PLACED, LOSER, HIDDEN) Runner status information is available for 90 days following market settlement.</returns>
    Public Property status As clsEnumerations.RunnerStatus = clsEnumerations.RunnerStatus.INITIALISE
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>The adjustment factor applied if the selection is removed</returns>
    Public Property adjustmentFactor As System.Double = -1
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The price of the most recent bet matched on this selection</returns>
    Public Property lastPriceTraded As System.Double = -1
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The total amount matched on this runner</returns>
    Public Property totalMatched As System.Double = -1
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>If date and time the runner was removed</returns>
    Public Property removalDate As System.DateTime = New Date(1900, 1, 1)
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The BSP related prices for this runner</returns>
    Public Property sp As StartingPrices = New StartingPrices
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The Exchange prices available for this runner</returns>
    Public Property ex As ExchangePrices = New ExchangePrices
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>List of orders in the market</returns>
    Public Property orders As List(Of [Order]) = New List(Of [Order])
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>List of matches (i.e, orders that have been fully or partially executed)</returns>
    Public Property matches As List(Of Match) = New List(Of Match)
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>List of matches for each strategy, ordered by matched data</returns>
    Public Property matchesByStrategy
    Public Function gettable() As System.Data.DataTable

        Dim dt As New DataTable

        Dim statusname As String = [Enum].GetName(GetType(clsEnumerations.RunnerStatus), status)

        Dim dc As New DataColumn
        dc.DefaultValue = statusname
        dc.DataType = GetType(String)
        dc.ColumnName = "viet"

        dt = ex.gettable.Copy
        dt.Columns.Add("SELECTIONID", GetType(String), selectionId)
        dt.Columns.Add("HANDICAP", GetType(Double), handicap.ToString)
        dt.Columns.Add(New DataColumn With {.ColumnName = "STATUS", .DataType = GetType(String), .DefaultValue = statusname})
        dt.Columns.Add(dc)

        Return dt

    End Function

    Public Function getnode() As System.Windows.Forms.TreeNode

        Dim newnode = New System.Windows.Forms.TreeNode With {.Text = "runner", .Name = "runner", .Tag = "runner"}
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "selectionId: " & selectionId, .Tag = selectionId})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "handicap: " & handicap, .Tag = handicap})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "status: " & status, .Tag = status})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "adjustmentFactor: " & adjustmentFactor, .Tag = adjustmentFactor})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "lastPriceTraded: " & lastPriceTraded, .Tag = lastPriceTraded})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "totalMatched: " & totalMatched, .Tag = totalMatched})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "removalDate: " & removalDate, .Tag = removalDate})
        newnode.Nodes.Add(sp.getnode)
        newnode.Nodes.Add(ex.getnode)
        For Each o As [Order] In orders
            newnode.Nodes.Add(o.getnode)
        Next
        For Each m As Match In matches
            newnode.Nodes.Add(m.getnode)
        Next

        Return newnode
    End Function
End Class
