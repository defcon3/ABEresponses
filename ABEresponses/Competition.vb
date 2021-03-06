﻿''' <summary>
''' Public Class Competition
''' </summary>
Public Class Competition
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>id</returns>
    Public Property id As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>name</returns>
    Public Property name As System.String = "---"


    Function gettable() As System.Data.DataTable
        Dim dt As New System.Data.DataTable("Competition")



        dt.Columns.Add(New DataColumn With {.ColumnName = "COMPETITION_ID", .DataType = GetType(System.String), .DefaultValue = id})
        dt.Columns.Add(New DataColumn With {.ColumnName = "COMPETITION_NAME", .DataType = GetType(System.String), .DefaultValue = name})

        dt.Columns.Add(New DataColumn With {.ColumnName = "COMPETITION_TIMESTAMP", .DataType = GetType(System.String), .DefaultValue = Date.Now.ToString("dd/MM/yyyy hh:mm:ss.fff tt")})
        dt.Columns.Add(New DataColumn With {.ColumnName = "COMPETITION_NOW", .DataType = GetType(DateTime), .DefaultValue = Date.Now})
        dt.Columns.Add(New DataColumn With {.ColumnName = "COMPETITION_NOWTICKS", .DataType = GetType(System.Int64), .DefaultValue = Date.Now.Ticks})



        Return dt

    End Function


    Public Function getnode() As System.Windows.Forms.TreeNode
        Dim newnode = New System.Windows.Forms.TreeNode With {.Text = "Competition: " & "Competition", .Name = "Competition", .Tag = "Competition"}
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "Zeitstempel: " & DateAndTime.Now, .Tag = DateAndTime.Now, .Name = "COMPETITION_ZEITSTEMPEL"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "id: " & id, .Tag = id, .Name = "COMPETITION_ID"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "name: " & name, .Tag = name, .Name = "COMPETITION_NAME"})

        Return newnode
    End Function


End Class
