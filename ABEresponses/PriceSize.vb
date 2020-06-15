''' <summary>
''' Public Class PriceSize
''' </summary>
Public Class PriceSize
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>The price available</returns>
    Public Property price As System.Double = -1
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>The stake available</returns>
    Public Property size As System.Double = -1
    Public Property exchangePriceTimeStamp As String = Date.Now.ToString("dd/MM/yyyy hh:mm:ss.fff tt")
    Public Property nau = Date.Now
    Public Function getnode() As System.Windows.Forms.TreeNode

        Dim newnode = New System.Windows.Forms.TreeNode With {.Text = "PriceSize", .Name = "PriceSize", .Tag = "PriceSize"}
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "price: " & price, .Tag = price})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "size: " & size, .Tag = size})
        newnode.Nodes.Add(exchangePriceTimeStamp)
        newnode.Nodes.Add(Date.Now.Ticks - nau.ticks)
        Return newnode

    End Function




End Class
