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
        newnode.Nodes.Add("availableToBack")
        Dim tn As System.Windows.Forms.TreeNode

        For Each atb As PriceSize In availableToBack
            tn = atb.getnode
            tn.Text = "availableToBack"
            newnode.Nodes.Add(tn)
        Next
        For Each atb As PriceSize In availableToLay
            tn = atb.getnode
            tn.Text = "availableToLay"
            newnode.Nodes.Add(tn)
        Next
        For Each atb As PriceSize In tradedVolume
            tn = atb.getnode
            tn.Text = "tradedVolume"
            newnode.Nodes.Add(tn)
        Next
        Return newnode

    End Function
End Class
