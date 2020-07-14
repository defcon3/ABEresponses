''' <summary>
''' Public Class RunnerCatalog
''' </summary>
Public Class RunnerCatalog
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>The sort priority of this runner</returns>
    Public Property sortPriority As System.Int32 = 0
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>The unique id for the selection.</returns>
    Public Property selectionId As System.Int64 = 0
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>The name of the runner</returns>
    Public Property runnerName As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>Metadata associated with the runner.  For a description of this data for Horse Racing</returns>
    Public Property metadata As RunnerMetadataDescription = New RunnerMetadataDescription
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>The handicap</returns>
    Public Property handicap As System.Double = -1

    Function gettable() As System.Data.DataTable
        Dim dt As New System.Data.DataTable("RunnerCatalog")
        dt.Columns.Add("RUNNERCATALOG_SELECTION_ID", GetType(Long))
        dt.Columns.Add("RUNNERCATALOG_SORT_PRIORITY", GetType(Short))
        dt.Columns.Add("RUNNERCATALOG_RUNNERNAME", GetType(String))



        Return dt

    End Function


End Class
