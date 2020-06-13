''' <summary>
''' Public Class Match
''' </summary>
Public Class Match
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>Only present if no rollup</returns>
    Public Property betId As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>Only present if no rollup</returns>
    Public Property matchId As System.String = "---"
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>Indicates if the bet is a Back or a LAY</returns>
    Public Property side As clsEnumerations.Side = clsEnumerations.Side.INITIALISE
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>Either actual match price or avg match price depending on rollup. This value is not meaningful for activity on LINE markets and is not guaranteed to be returned or maintained for these markets. </returns>
    Public Property price As System.Double = -1
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>Size matched at in this fragment, or at this price or avg price depending on rollup</returns>
    Public Property size As System.Double = -1
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>Only present if no rollup</returns>
    Public Property matchDate As System.DateTime


    Public Function getnode() As System.Windows.Forms.TreeNode

        Dim newnode = New System.Windows.Forms.TreeNode With {.Text = "betId: " & betId, .Name = betId, .Tag = betId}
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "matchId: " & matchId, .Tag = matchId})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "side: " & side, .Tag = side})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "price: " & price, .Tag = price})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "size: " & size, .Tag = size})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "matchDate: " & matchDate, .Tag = matchDate})
        Return newnode
    End Function

End Class
