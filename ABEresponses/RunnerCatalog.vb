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


        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERCATALOG_SELECTIONID", .DataType = GetType(System.Int64), .DefaultValue = selectionId})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERCATALOG_SORTPRIORITY", .DataType = GetType(System.Int32), .DefaultValue = sortPriority})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERCATALOG_RUNNERNAME", .DataType = GetType(System.String), .DefaultValue = runnerName})

        dt.Merge(metadata.gettable, True, MissingSchemaAction.Add)

        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERCATALOG_TIMESTAMP", .DataType = GetType(System.String), .DefaultValue = Date.Now.ToString("dd/MM/yyyy hh:mm:ss.fff tt")})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERCATALOG_NOW", .DataType = GetType(DateTime), .DefaultValue = Date.Now})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERCATALOG_NOWTICKS", .DataType = GetType(System.Int64), .DefaultValue = Date.Now.Ticks})

        Return dt

    End Function


End Class
