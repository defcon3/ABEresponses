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
End Class
