''' <summary>
''' Public Class Event
''' </summary>
Public Class [Event]
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The unique id for the event</returns>
    Public Property id As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The name of the event</returns>
    Public Property name As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The ISO-2 code for the event.  A list of ISO-2 codes is available via http://en.wikipedia.org/wiki/ISO_3166-1_alpha-2</returns>
    Public Property countryCode As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>This is timezone in which the event is taking place.</returns>
    Public Property timezone As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>venue</returns>
    Public Property venue As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The scheduled start date and time of the event. This is Europe/London (GMT) by default</returns>
    Public Property openDate As Date

End Class
