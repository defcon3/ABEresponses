''' <summary>
''' Public Class Match
''' </summary>
Public Class Match
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>Only present if no rollup</returns>
    Public Property betId As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>Only present if no rollup</returns>
    Public Property matchId As System.String
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>Indicates if the bet is a Back or a LAY</returns>
    Public Property side As clsEnumerations.Side
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>Either actual match price or avg match price depending on rollup. This value is not meaningful for activity on LINE markets and is not guaranteed to be returned or maintained for these markets. </returns>
    Public Property price As System.Double
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>Size matched at in this fragment, or at this price or avg price depending on rollup</returns>
    Public Property size As System.Double
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>Only present if no rollup</returns>
    Public Property matchDate As System.DateTime

End Class
