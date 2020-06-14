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
End Class
