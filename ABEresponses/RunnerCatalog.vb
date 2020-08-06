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
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERCATALOG_SORTPRIORITY", .DataType = GetType(System.Int64), .DefaultValue = sortPriority})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERCATALOG_RUNNERNAME", .DataType = GetType(System.String), .DefaultValue = runnerName})

        dt.Merge(metadata.gettable, True, MissingSchemaAction.Add)

        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERCATALOG_TIMESTAMP", .DataType = GetType(System.String), .DefaultValue = Date.Now.ToString("dd/MM/yyyy hh:mm:ss.fff tt")})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERCATALOG_NOW", .DataType = GetType(DateTime), .DefaultValue = Date.Now})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERCATALOG_NOWTICKS", .DataType = GetType(System.Int64), .DefaultValue = Date.Now.Ticks})


        'Dim dr As DataRow
        'dr = dt.NewRow
        'dt.Rows.Add(dr)

        Return dt

    End Function


    Public Function getnode() As System.Windows.Forms.TreeNode
        Dim newnode = New System.Windows.Forms.TreeNode With {.Text = "RunnerCatalog: " & "RunnerCatalog", .Name = "RunnerCatalog", .Tag = "RunnerCatalog"}
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "Zeitstempel: " & DateAndTime.Now, .Tag = DateAndTime.Now, .Name = "RUNNERCATALOG_ZEITSTEMPEL"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "sortPriority: " & sortPriority, .Tag = sortPriority, .Name = "RUNNERCATALOG_SORTPRIORITY"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "selectionId: " & selectionId, .Tag = selectionId, .Name = "RUNNERCATALOG_SELECTIONID"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "runnerName: " & runnerName, .Tag = runnerName, .Name = "RUNNERCATALOG_RUNNERNAME"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "handicap: " & handicap, .Tag = handicap, .Name = "RUNNERCATALOG_HANDICAP"})
        newnode.Nodes.Add(metadata.getnode)

        Return newnode
    End Function


End Class
