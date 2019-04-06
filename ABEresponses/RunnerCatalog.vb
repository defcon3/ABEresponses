''' <summary>
''' Public Class RunnerCatalog
''' </summary>
Public Class RunnerCatalog
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>The sort priority of this runner</returns>
    Public Property sortPriority As System.Int32
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>The unique id for the selection.</returns>
    Public Property selectionId As System.Int64
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>The name of the runner</returns>
    Public Property runnerName As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>Metadata associated with the runner.  For a description of this data for Horse Racing</returns>
    Public Property metadata As System.String
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>The handicap</returns>
    Public Property handicap As System.Double
End Class
