Imports System.Globalization
Imports System.Windows.Forms
''' <summary>
''' Public Class ExchangePrices
''' </summary>
Public Class ExchangePrices
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>availableToBack</returns>
    Public Property availableToBack As List(Of PriceSize) = New List(Of PriceSize)
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>availableToLay</returns>
    Public Property availableToLay As List(Of PriceSize) = New List(Of PriceSize)
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>tradedVolume</returns>
    Public Property tradedVolume As List(Of PriceSize) = New List(Of PriceSize)
    ''' <summary>
    ''' Zeitstempel als String
    ''' </summary>
    ''' <returns></returns>
    Public Property exchangePricesTimeStamp As String = Date.Now.ToString("dd/MM/yyyy hh:mm:ss.fff tt")
    ''' <summary>
    ''' Zeitstempel as Datum
    ''' </summary>
    ''' <returns>Date.Now</returns>
    Public Property exchangePricesNow As DateTime = Date.Now
    ''' <summary>
    ''' Zeitangabe in Ticks
    ''' </summary>
    ''' <returns></returns>
    Public Property exchangePricesNowTicks As Long = Date.Now.Ticks


    ''' <summary>
    ''' Gibt das Objekt als Treeviewknoten zurück. Knoten heißt ExchangePrices und hat alle Angaben darunter
    ''' </summary>
    ''' <returns>Treeviewknoten "ExchangePrices"</returns>
    Public Function getnode() As System.Windows.Forms.TreeNode

        Dim newnode = New System.Windows.Forms.TreeNode With {.Text = "ExchangePrices", .Name = "ExchangePrices", .Tag = "ExchangePrices"}

        Dim atbnode = New System.Windows.Forms.TreeNode With {.Text = "availableToBack", .Name = "availableToBack", .Tag = "availableToBack"}
        Dim atlnode = New System.Windows.Forms.TreeNode With {.Text = "availableToLay", .Name = "availableToLay", .Tag = "availableToLay"}
        Dim tvnode = New System.Windows.Forms.TreeNode With {.Text = "tradedVolume", .Name = "tradedVolume", .Tag = "tradedVolume"}


        For Each atb As PriceSize In availableToBack
            atbnode.Nodes.Add(atb.getnode)
        Next

        For Each atl As PriceSize In availableToLay
            atlnode.Nodes.Add(atl.getnode)
        Next
        For Each tv As PriceSize In tradedVolume
            tvnode.Nodes.Add(tv.getnode)
        Next
        newnode.Nodes.Add(atbnode)
        newnode.Nodes.Add(atlnode)
        newnode.Nodes.Add(tvnode)

        Return newnode

    End Function

    Function gettable() As System.Data.DataTable
        Dim dt As New System.Data.DataTable("exchangePrices")
        dt.Columns.Add("EXCHANGEPRICES_ID", GetType(System.Int64))
        dt.Columns.Add("EXCHANGEPRICES_TYP", GetType(System.String))
        dt.Columns.Add("EXCHANGEPRICES_PRICE", GetType(System.Decimal))
        dt.Columns.Add("EXCHANGEPRICES_SIZE", GetType(System.Decimal))



        Dim i = 0

        For Each atb As PriceSize In availableToBack

            dt.Rows.Add(i, "availableToBack", atb.price, atb.size)
            i += 1
        Next

        i = 0

        For Each atb As PriceSize In availableToLay

            dt.Rows.Add(i, "availableToLay", atb.price, atb.size)
            i += 1
        Next

        i = 0

        For Each atb As PriceSize In tradedVolume

            dt.Rows.Add(i, "tradedVolume", atb.price, atb.size)
            i += 1
        Next


        dt.Columns.Add(New DataColumn With {.ColumnName = "EXCHANGEPRICES_TIMESTAMP", .DataType = GetType(System.String), .DefaultValue = Date.Now.ToString("dd/MM/yyyy hh:mm:ss.fff tt")})
        dt.Columns.Add(New DataColumn With {.ColumnName = "EXCHANGEPRICES_NOW", .DataType = GetType(DateTime), .DefaultValue = Date.Now})
        dt.Columns.Add(New DataColumn With {.ColumnName = "EXCHANGEPRICES_NOWTICKS", .DataType = GetType(System.Int64), .DefaultValue = Date.Now.Ticks})


        Return dt

    End Function

End Class
