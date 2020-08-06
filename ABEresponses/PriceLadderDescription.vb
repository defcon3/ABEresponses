''' <summary>
''' Description of the price ladder type and any related data.
''' </summary>
Public Class PriceLadderDescription
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The type of price ladder.</returns>
    Public Property type As clsEnumerations.PriceLadderType = clsEnumerations.PriceLadderType.INITIALISE


    Public Function gettable() As System.Data.DataTable

        Dim dt As New DataTable("PRICELADDERDESCRIPTION")


        '[Enum].GetName(GetType(Applications), CALLING_APP ))
        dt.Columns.Add(New DataColumn With {.ColumnName = "PRICELADDERDESCRIPTION_TYPE", .DataType = GetType(System.String), .DefaultValue = [Enum].GetName(GetType(clsEnumerations.PriceLadderType), type)})

        'Dim str As String
        'str = [Enum].GetName(GetType(clsEnumerations.PriceLadderType), type)

        Return dt

    End Function


    Public Function getnode() As System.Windows.Forms.TreeNode
        Dim newnode = New System.Windows.Forms.TreeNode With {.Text = "PriceLadderDescription: ", .Name = "PriceLadderDescription", .Tag = "PriceLadderDescription"}
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "Zeitstempel: " & DateAndTime.Now, .Tag = DateAndTime.Now, .Name = "PRICELADDERDESCRIPTION_ZEITSTEMPEL"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "type: " & [Enum].GetName(GetType(clsEnumerations.PriceLadderType), type), .Tag = [Enum].GetName(GetType(clsEnumerations.PriceLadderType), type), .Name = "PRICELADDERDESCRIPTION_TYPE"})


        Return newnode
    End Function



End Class
