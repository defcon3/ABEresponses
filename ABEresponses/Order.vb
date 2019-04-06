''' <summary>
''' Public Class Order
''' </summary>
Public Class Order
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns></returns>
    Public Property betId As System.String
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>BSP Order type.</returns>
    Public Property orderType As clsEnumerations.OrderType
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>Either EXECUTABLE (an unmatched amount remains) or EXECUTION_COMPLETE (no unmatched amount remains).</returns>
    Public Property status As clsEnumerations.OrderStatus
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>What to do with the order at turn-in-play</returns>
    Public Property persistenceType As clsEnumerations.PersistenceType
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>Indicates if the bet is a Back or a LAY. For LINE markets customers either Buy a line (LAY bet, winning if outcome Is greater than the taken line (price)) Or Sell a line (BACK bet, winning if outcome Is less than the taken line (price)) </returns>
    Public Property side As clsEnumerations.Side
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>The price of the bet. Please note: LINE markets operate at even-money odds of 2.0. However, price for these markets refers to the line positions available as defined by the markets min-max range and interval steps </returns>
    Public Property price As System.Double
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>The size of the bet.</returns>
    Public Property size As System.Double
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>Not to be confused with size. This is the liability of a given BSP bet.</returns>
    Public Property bspLiability As System.Double
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>The date, to the second, the bet was placed.</returns>
    Public Property placedDate As System.DateTime
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The average price matched at. Voided match fragments are removed from this average calculation. For MARKET_ON_CLOSE BSP bets this reports the matched SP price following the SP reconciliation process. This value is not meaningful for activity on LINE markets and is not guaranteed to be returned or maintained for these markets.</returns>
    Public Property avgPriceMatched As System.Double
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The current amount of this bet that was matched.</returns>
    Public Property sizeMatched As System.Double
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The current amount of this bet that is unmatched.</returns>
    Public Property sizeRemaining As System.Double
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The current amount of this bet that was lapsed.</returns>
    Public Property sizeLapsed As System.Double
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The current amount of this bet that was cancelled.</returns>
    Public Property sizeCancelled As System.Double
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The current amount of this bet that was voided.</returns>
    Public Property sizeVoided As System.Double
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The customer order reference sent for this bet</returns>
    Public Property customerOrderRef As System.String 'CustomerOrderRef
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The customer strategy reference sent for this bet</returns>
    Public Property customerStrategyRef As System.String 'CustomerStrategyRef
End Class
