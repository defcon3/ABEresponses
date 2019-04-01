''' <summary>
''' Public Class MarketLineRangeInfo
''' </summary>
Public Class MarketLineRangeInfo
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>maxPrice - Maximum value for the outcome, in market units for this market (eg 100 runs)</returns>
    Public Property maxUnitValue As System.Double
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>minPrice - Minimum value for the outcome, in market units for this market (eg 0 runs)</returns>
    Public Property minUnitValue As System.Double
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>interval - The odds ladder on this market will be between the range of minUnitValue and maxUnitValue, in increments of the inverval value.e.g. If minUnitValue=10 runs, maxUnitValue=20 runs, interval=0.5 runs, then valid odds include 10, 10.5, 11, 11.5 up to 20 runs.</returns>
    Public Property interval As System.Double
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>The unit - The type of unit the lines are incremented in by the interval (e.g: runs, goals or seconds.</returns>
    Public Property marketUnit As System.String
End Class
