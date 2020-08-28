''' <summary>
''' Public Class EventType
''' </summary>
Public Class EventType
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>id</returns>
    Public ReadOnly Property id As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>name</returns>
    Public Property name As System.String = "---"


    Function gettable() As System.Data.DataTable
        Dim dt As New System.Data.DataTable("EventType")



        dt.Columns.Add(New DataColumn With {.ColumnName = "EVENTTYPE_ID", .DataType = GetType(System.String), .DefaultValue = id})
        dt.Columns.Add(New DataColumn With {.ColumnName = "EVENTTYPE_NAME", .DataType = GetType(System.String), .DefaultValue = name})

        dt.Columns.Add(New DataColumn With {.ColumnName = "EVENTTYPE_TIMESTAMP", .DataType = GetType(System.String), .DefaultValue = Date.Now.ToString("dd/MM/yyyy hh:mm:ss.fff tt")})
        dt.Columns.Add(New DataColumn With {.ColumnName = "EVENTTYPE_NOW", .DataType = GetType(DateTime), .DefaultValue = DateTime.Now})
        dt.Columns.Add(New DataColumn With {.ColumnName = "EVENTTYPE_NOWTICKS", .DataType = GetType(System.Int64), .DefaultValue = Date.Now.Ticks})



        Return dt

    End Function

    Public Function getnode() As System.Windows.Forms.TreeNode
        Dim newnode = New System.Windows.Forms.TreeNode With {.Text = "EventType: " & "EventType", .Name = "EventType", .Tag = "EventType"}
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "Zeitstempel: " & DateAndTime.Now, .Tag = DateAndTime.Now, .Name = "EVENTTYPE_ZEITSTEMPEL"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "id: " & id, .Tag = id, .Name = "EVENTTYPE_ID"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "name: " & name, .Tag = name, .Name = "EVENTTYPE_NAME"})

        Return newnode
    End Function

End Class
