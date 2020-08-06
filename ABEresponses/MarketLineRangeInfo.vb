''' <summary>
''' Public Class MarketLineRangeInfo
''' </summary>
Public Class MarketLineRangeInfo
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>maxPrice - Maximum value for the outcome, in market units for this market (eg 100 runs)</returns>
    Public Property maxUnitValue As System.Double = -1
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>minPrice - Minimum value for the outcome, in market units for this market (eg 0 runs)</returns>
    Public Property minUnitValue As System.Double = -1
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>interval - The odds ladder on this market will be between the range of minUnitValue and maxUnitValue, in increments of the inverval value.e.g. If minUnitValue=10 runs, maxUnitValue=20 runs, interval=0.5 runs, then valid odds include 10, 10.5, 11, 11.5 up to 20 runs.</returns>
    Public Property interval As System.Double = -1
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>The unit - The type of unit the lines are incremented in by the interval (e.g: runs, goals or seconds.</returns>
    Public Property marketUnit As System.String = "---"


    Function gettable() As System.Data.DataTable
        Dim dt As New System.Data.DataTable("MarketLineRangeInfo")



        dt.Columns.Add(New DataColumn With {.ColumnName = "MARKETLINERANGEINFO_MARKETUNIT", .DataType = GetType(System.String), .DefaultValue = marketUnit})
        dt.Columns.Add(New DataColumn With {.ColumnName = "MARKETLINERANGEINFO_INTERVAL", .DataType = GetType(System.Double), .DefaultValue = interval})
        dt.Columns.Add(New DataColumn With {.ColumnName = "MARKETLINERANGEINFO_MINUNITVALUE", .DataType = GetType(System.Double), .DefaultValue = minUnitValue})
        dt.Columns.Add(New DataColumn With {.ColumnName = "MARKETLINERANGEINFO_MAXUNITVALUE", .DataType = GetType(System.Double), .DefaultValue = maxUnitValue})

        dt.Columns.Add(New DataColumn With {.ColumnName = "MARKETLINERANGEINFO_TIMESTAMP", .DataType = GetType(System.String), .DefaultValue = Date.Now.ToString("dd/MM/yyyy hh:mm:ss.fff tt")})
        dt.Columns.Add(New DataColumn With {.ColumnName = "MARKETLINERANGEINFO_NOW", .DataType = GetType(DateTime), .DefaultValue = Date.Now})
        dt.Columns.Add(New DataColumn With {.ColumnName = "MARKETLINERANGEINFO_NOWTICKS", .DataType = GetType(System.Int64), .DefaultValue = Date.Now.Ticks})



        Return dt

    End Function

    Public Function getnode() As System.Windows.Forms.TreeNode
        Dim newnode = New System.Windows.Forms.TreeNode With {.Text = "MarketLineRangeInfo: ", .Name = "MarketLineRangeInfo", .Tag = "MarketLineRangeInfo"}
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "Zeitstempel: " & DateAndTime.Now, .Tag = DateAndTime.Now, .Name = "MARKETLINERANGEINFO_ZEITSTEMPEL"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "marketUnit: " & marketUnit, .Tag = marketUnit, .Name = "MARKETLINERANGEINFO_MARKETUNIT"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "interval: " & interval, .Tag = interval, .Name = "MARKETLINERANGEINFO_INTERVAL"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "minUnitValue: " & minUnitValue, .Tag = minUnitValue, .Name = "MARKETLINERANGEINFO_MINUNITVALUE"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "maxUnitValue: " & maxUnitValue, .Tag = maxUnitValue, .Name = "MARKETLINERANGEINFO_MAXUNITVALUE"})

        Return newnode
    End Function


End Class
