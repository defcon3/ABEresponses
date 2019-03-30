''' <summary>
''' Klasse MarketBook
''' </summary>
Public Class MarketBook
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>The unique identifier for the market. MarketId's are prefixed with '1.'</returns>
    Public Property marketId As System.String 'The unique identifier for the market. MarketId's are prefixed with '1.'


    <Required(ErrorMessage:="Date is required")>
    Public Property ReleaseDate() As Date


    Property neuland As String
    Property dorit As String
End Class
