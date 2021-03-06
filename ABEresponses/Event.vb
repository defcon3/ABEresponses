﻿''' <summary>
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
    Public Property openDate As DateTime


    Function gettable() As System.Data.DataTable
        Dim dt As New System.Data.DataTable("Event")



        dt.Columns.Add(New DataColumn With {.ColumnName = "EVENT_ID", .DataType = GetType(System.String), .DefaultValue = id})
        dt.Columns.Add(New DataColumn With {.ColumnName = "EVENT_NAME", .DataType = GetType(System.String), .DefaultValue = name})
        dt.Columns.Add(New DataColumn With {.ColumnName = "EVENT_COUNTRYCODE", .DataType = GetType(System.String), .DefaultValue = countryCode})
        dt.Columns.Add(New DataColumn With {.ColumnName = "EVENT_TIMEZONE", .DataType = GetType(System.String), .DefaultValue = timezone})
        dt.Columns.Add(New DataColumn With {.ColumnName = "EVENT_VENUE", .DataType = GetType(System.String), .DefaultValue = venue})
        dt.Columns.Add(New DataColumn With {.ColumnName = "EVENT_OPENDATE", .DataType = GetType(System.DateTime), .DefaultValue = openDate})

        dt.Columns.Add(New DataColumn With {.ColumnName = "EVENT_TIMESTAMP", .DataType = GetType(System.String), .DefaultValue = Date.Now.ToString("dd/MM/yyyy hh:mm:ss.fff tt")})
        dt.Columns.Add(New DataColumn With {.ColumnName = "EVENT_NOW", .DataType = GetType(DateTime), .DefaultValue = DateTime.Now})
        dt.Columns.Add(New DataColumn With {.ColumnName = "EVENT_NOWTICKS", .DataType = GetType(System.Int64), .DefaultValue = Date.Now.Ticks})



        Return dt

    End Function

    Public Function getnode() As System.Windows.Forms.TreeNode
        Dim newnode = New System.Windows.Forms.TreeNode With {.Text = "Event: " & "Event", .Name = "Event", .Tag = "Event"}
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "Zeitstempel: " & DateAndTime.Now, .Tag = DateAndTime.Now, .Name = "EVENT_ZEITSTEMPEL"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "id: " & id, .Tag = id, .Name = "EVENT_ID"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "countryCode: " & countryCode, .Tag = countryCode, .Name = "EVENT_COUNTRYCODE"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "timezone: " & timezone, .Tag = timezone, .Name = "EVENT_TIMEZONE"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "name: " & name, .Tag = name, .Name = "EVENT_NAME"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "venue: " & venue, .Tag = venue, .Name = "EVENT_VENUE"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "openDate: " & openDate, .Tag = openDate, .Name = "EVENT_OPENDATE"})

        Return newnode
    End Function




End Class
