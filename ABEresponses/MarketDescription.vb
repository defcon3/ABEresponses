''' <summary>
''' Public Class MarketDescription
''' </summary>
Public Class MarketDescription
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>If 'true' the market supports 'Keep' bets if the market is to be turned in-play</returns>
    Public Property persistenceEnabled As System.Boolean = System.Boolean.FalseString
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>If 'true' the market supports Betfair SP betting</returns>
    Public Property bspMarket As System.Boolean = System.Boolean.FalseString
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>The market start time</returns>
    Public Property marketTime As DateTime
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>The market suspend time</returns>
    Public Property suspendTime As DateTime
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>settled time</returns>
    Public Property settleTime As DateTime
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>Enumeration MarketBettingType</returns>
    Public Property bettingType As clsEnumerations.MarketBettingType = clsEnumerations.MarketBettingType.INITIALISE
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>If 'true' the market is set to turn in-play</returns>
    Public Property turnInPlayEnabled As System.Boolean = System.Boolean.FalseString
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>Market base type</returns>
    Public Property marketType As System.String = "---"
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>The market regulator</returns>
    Public Property regulator As System.String = "---"
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>The commission rate applicable to the market</returns>
    Public Property marketBaseRate As System.Double = -1
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>Indicates whether or not the user's discount rate is taken into account on this market. If ‘false’ all users will be charged the same commission rate, regardless of discount rate.</returns>
    Public Property discountAllowed As System.Boolean = System.Boolean.FalseString
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The wallet to which the market belongs.</returns>
    Public Property wallet As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The market rules.</returns>
    Public Property rules As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>rulesHasDate</returns>
    Public Property rulesHasDate As System.Boolean = System.Boolean.FalseString
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The divisor is returned for the marketType EACH_WAY only and refers to the fraction of the win odds at which the place portion of an each way bet is settled</returns>
    Public Property eachWayDivisor As System.Double = -1
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>Any additional information regarding the market</returns>
    Public Property clarifications As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>Line range info for line markets</returns>
    Public Property lineRangeInfo As MarketLineRangeInfo = New MarketLineRangeInfo
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>An external identifier of a race type</returns>
    Public Property raceType As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>Details about the price ladder in use for this market.</returns>
    Public Property priceLadderDescription As PriceLadderDescription = New PriceLadderDescription



    Function gettable() As System.Data.DataTable
        Dim dt As New System.Data.DataTable("MarketDescription")
        dt.Merge(priceLadderDescription.gettable, True, MissingSchemaAction.Add)
        dt.Merge(lineRangeInfo.gettable, True, MissingSchemaAction.Add)

        dt.Columns.Add(New DataColumn With {.ColumnName = "MARKETDESCRIPTION_RACETYPE", .DataType = GetType(System.String), .DefaultValue = raceType})
        dt.Columns.Add(New DataColumn With {.ColumnName = "MARKETDESCRIPTION_CLARIFICATIONS", .DataType = GetType(System.String), .DefaultValue = clarifications})
        dt.Columns.Add(New DataColumn With {.ColumnName = "MARKETDESCRIPTION_EACHWAYDIVISOR", .DataType = GetType(System.Double), .DefaultValue = eachWayDivisor})
        dt.Columns.Add(New DataColumn With {.ColumnName = "MARKETDESCRIPTION_RULESHASDATE", .DataType = GetType(System.String), .DefaultValue = rulesHasDate.ToString})
        dt.Columns.Add(New DataColumn With {.ColumnName = "MARKETDESCRIPTION_RULES", .DataType = GetType(System.String), .DefaultValue = rules})
        dt.Columns.Add(New DataColumn With {.ColumnName = "MARKETDESCRIPTION_WALLET", .DataType = GetType(System.String), .DefaultValue = wallet})
        dt.Columns.Add(New DataColumn With {.ColumnName = "MARKETDESCRIPTION_DISCOUNTALLOWED", .DataType = GetType(System.String), .DefaultValue = discountAllowed.ToString})
        dt.Columns.Add(New DataColumn With {.ColumnName = "MARKETDESCRIPTION_MARKETBASERATE", .DataType = GetType(System.Double), .DefaultValue = marketBaseRate})
        dt.Columns.Add(New DataColumn With {.ColumnName = "MARKETDESCRIPTION_REGULATOR", .DataType = GetType(System.String), .DefaultValue = regulator})
        dt.Columns.Add(New DataColumn With {.ColumnName = "MARKETDESCRIPTION_MARKETTYPE", .DataType = GetType(System.String), .DefaultValue = marketType})
        dt.Columns.Add(New DataColumn With {.ColumnName = "MARKETDESCRIPTION_TURNINPLAYENABLED", .DataType = GetType(System.String), .DefaultValue = turnInPlayEnabled.ToString})
        dt.Columns.Add(New DataColumn With {.ColumnName = "MARKETDESCRIPTION_BETTINGTYPE", .DataType = GetType(System.String), .DefaultValue = bettingType.ToString})
        dt.Columns.Add(New DataColumn With {.ColumnName = "MARKETDESCRIPTION_MARKETTIME", .DataType = GetType(System.DateTime), .DefaultValue = marketTime})
        dt.Columns.Add(New DataColumn With {.ColumnName = "MARKETDESCRIPTION_SUSPENDTIME", .DataType = GetType(System.DateTime), .DefaultValue = suspendTime})
        dt.Columns.Add(New DataColumn With {.ColumnName = "MARKETDESCRIPTION_SETTLETIME", .DataType = GetType(System.DateTime), .DefaultValue = New DateTime(1910, 10, 10, 10, 10, 10)})
        dt.Columns.Add(New DataColumn With {.ColumnName = "MARKETDESCRIPTION_PERSISTENCEENABLED", .DataType = GetType(System.String), .DefaultValue = persistenceEnabled.ToString})
        dt.Columns.Add(New DataColumn With {.ColumnName = "MARKETDESCRIPTION_BSPMARKET", .DataType = GetType(System.String), .DefaultValue = bspMarket.ToString})

        dt.Columns.Add(New DataColumn With {.ColumnName = "MARKETDESCRIPTION_TIMESTAMP", .DataType = GetType(System.String), .DefaultValue = Date.Now.ToString("dd/MM/yyyy hh:mm:ss.fff tt")})
        dt.Columns.Add(New DataColumn With {.ColumnName = "MARKETDESCRIPTION_NOW", .DataType = GetType(DateTime), .DefaultValue = Date.Now})
        dt.Columns.Add(New DataColumn With {.ColumnName = "MARKETDESCRIPTION_NOWTICKS", .DataType = GetType(System.Int64), .DefaultValue = Date.Now.Ticks})


        Return dt

    End Function


    Public Function getnode() As System.Windows.Forms.TreeNode
        Dim newnode = New System.Windows.Forms.TreeNode With {.Text = "MarketDescription: ", .Name = "MarketDescription", .Tag = "MarketDescription"}
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "Zeitstempel: " & DateAndTime.Now, .Tag = DateAndTime.Now, .Name = "MARKETDESCRIPTION_ZEITSTEMPEL"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "persistenceEnabled: " & persistenceEnabled.ToString, .Tag = persistenceEnabled.ToString, .Name = "MARKETDESCRIPTION_PERSISTANCEENABLED"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "bspMarket: " & bspMarket.ToString, .Tag = bspMarket.ToString, .Name = "MARKETDESCRIPTION_BSPMARKET"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "marketTime: " & marketTime, .Tag = marketTime, .Name = "MARKETDESCRIPTION_MARKETTIME"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "suspendTime: " & suspendTime, .Tag = suspendTime, .Name = "MARKETDESCRIPTION_SUSPENDTIME"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "settleTime: " & settleTime, .Tag = settleTime, .Name = "MARKETDESCRIPTION_SETTLETIME"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "bettingType: " & bettingType.ToString, .Tag = bettingType.ToString, .Name = "MARKETDESCRIPTION_BETTINGTYPE"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "turnInPlayEnabled: " & turnInPlayEnabled.ToString, .Tag = turnInPlayEnabled.ToString, .Name = "MARKETDESCRIPTION_TURNINPLAYENABLED"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "marketType: " & marketType.ToString, .Tag = marketType.ToString, .Name = "MARKETDESCRIPTION_MARKETTYPE"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "regulator: " & regulator, .Tag = regulator, .Name = "MARKETDESCRIPTION_REGULATOR"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "marketBaseRate: " & marketBaseRate, .Tag = marketBaseRate, .Name = "MARKETDESCRIPTION_MARKETBASERATE"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "discountAllowed: " & discountAllowed.ToString, .Tag = discountAllowed.ToString, .Name = "MARKETDESCRIPTION_DISCOUNTALLOWED"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "wallet: " & wallet.ToString, .Tag = wallet.ToString, .Name = "MARKETDESCRIPTION_WALLET"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "rules: " & rules.ToString, .Tag = rules.ToString, .Name = "MARKETDESCRIPTION_RULES"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "rulesHasDate: " & rulesHasDate.ToString, .Tag = rulesHasDate.ToString, .Name = "MARKETDESCRIPTION_RULESHASDATE"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "eachWayDivisor: " & eachWayDivisor.ToString, .Tag = eachWayDivisor.ToString, .Name = "MARKETDESCRIPTION_EACHWAYDIVISOR"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "clarifications: " & clarifications.ToString, .Tag = clarifications.ToString, .Name = "MARKETDESCRIPTION_CLARIFICATIONS"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "raceType: " & raceType.ToString, .Tag = raceType.ToString, .Name = "MARKETDESCRIPTION_RACETYPE"})
        newnode.Nodes.Add(lineRangeInfo.getnode)
        newnode.Nodes.Add(priceLadderDescription.getnode)


        Return newnode
    End Function




End Class
