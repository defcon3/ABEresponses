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

    ''' <summary>
    ''' gibt die Angaben als Baumknoten für Treeviewobjekt zurück
    ''' </summary>
    ''' <returns>Baumknoten mit Überschrift PriceSize und den Angaben price und size darunter</returns>
    Public Function getnode() As System.Windows.Forms.TreeNode

        Dim newnode = New System.Windows.Forms.TreeNode With {.Text = "PriceSize", .Name = "PriceSize", .Tag = "PriceSize"}
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "price: " & price, .Tag = price, .Name = "PRICESIZE_PRICE"})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "size: " & size, .Tag = size, .Name = "PRICESIZE_SIZE"})

        Return newnode

    End Function




End Class
