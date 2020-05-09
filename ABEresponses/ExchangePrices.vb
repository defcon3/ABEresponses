''' <summary>
''' Public Class ExchangePrices
''' </summary>
Public Class ExchangePrices
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>availableToBack</returns>
    Public Property availableToBack As List(Of PriceSize) = New List(Of PriceSize)
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>availableToLay</returns>
    Public Property availableToLay As List(Of PriceSize) = New List(Of PriceSize)
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>tradedVolume</returns>
    Public Property tradedVolume As List(Of PriceSize) = New List(Of PriceSize)
End Class
