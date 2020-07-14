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
    Public Property marketTime As Date
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>The market suspend time</returns>
    Public Property suspendTime As Date
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>settled time</returns>
    Public Property settleTime As Date
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
        dt.Merge(priceLadderDescription.gettable)

        dt.Columns.Add("MARKETDESCRIPTION_RACETYPE", GetType(System.String))
        dt.Columns.Add("RUNNERCATALOG_SORT_PRIORITY", GetType(Short))
        dt.Columns.Add("RUNNERCATALOG_RUNNERNAME", GetType(String))



        Return dt

    End Function


End Class
