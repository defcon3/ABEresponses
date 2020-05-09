''' <summary>
''' MarketCatalogue - Objekt, erbt die Properties aus clsResponseRoot
''' </summary>
Public Class MarketCatalogue
    Inherits clsResponseRoot
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>The unique identifier for the market. MarketId's are prefixed with '1.'</returns>
    Public Property marketId As System.String
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>The name of the market</returns>
    Public Property marketName As System.String
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
    Public Property description As MarketDescription
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The total amount of money matched on the market</returns>
    Public Property totalMatched As System.Double
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The runners (selections) contained in the market</returns>
    Public Property runners As List(Of RunnerCatalog)
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The Event Type the market is contained within</returns>
    Public Property eventType As EventType
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The competition the market is contained within. Usually only applies to Football competitions</returns>
    Public Property competition As Competition
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The event the market is contained within</returns>
    Public Property [event] As [Event]
End Class
