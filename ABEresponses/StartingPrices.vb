''' <summary>
''' Public Class StartingPrices
''' </summary>
Public Class StartingPrices
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>What the starting price would be if the market was reconciled now taking into account the SP bets as well as unmatched exchange bets on the same selection in the exchange. This data is cached and update every 60 seconds. Please note: Type Double may contain numbers, INF, -INF, and NaN.</returns>
    Public Property nearPrice As System.Double = -1
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>What the starting price would be if the market was reconciled now taking into account only the currently place SP bets. The Far Price is not as complicated but not as accurate and only accounts for money on the exchange at SP. This data is cached and updated every 60 seconds. Please note: Type Double may contain numbers, INF, -INF, and NaN.</returns>
    Public Property farPrice As System.Double = -1
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The total amount of back bets matched at the actual Betfair Starting Price. Pre-reconciliation, this field is zero for all prices except 1.01 (for Market on Close bets) and at the limit price for any Limit on Close bets.</returns>
    Public Property backStakeTaken As List(Of PriceSize) = New List(Of PriceSize)
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The lay amount matched at the actual Betfair Starting Price. Pre-reconciliation, this field is zero for all prices except 1.01 (for Market on Close bets) and at the limit price for any Limit on Close bets.</returns>
    Public Property layLiabilityTaken As List(Of PriceSize) = New List(Of PriceSize)
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The final BSP price for this runner. Only available for a BSP market that has been reconciled.</returns>
    Public Property actualSP As System.Double = -1

    Public Function getnode() As System.Windows.Forms.TreeNode

        Dim newnode = New System.Windows.Forms.TreeNode With {.Text = "StartingPrices", .Name = "StartingPrices", .Tag = "StartingPrices"}
        Dim bstnode = New System.Windows.Forms.TreeNode With {.Text = "backStakeTaken", .Name = "backStakeTaken", .Tag = "backStakeTaken"}
        Dim lltnode = New System.Windows.Forms.TreeNode With {.Text = "layLiabilityTaken", .Name = "layLiabilityTaken", .Tag = "layLiabilityTaken"}
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "nearPrice: " & nearPrice, .Tag = nearPrice})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "farPrice: " & farPrice, .Tag = farPrice})

        For Each bst As PriceSize In backStakeTaken
            bstnode.Nodes.Add(bst.getnode)
        Next
        For Each llt As PriceSize In layLiabilityTaken
            lltnode.Nodes.Add(llt.getnode)
        Next

        newnode.Nodes.Add(bstnode)
        newnode.Nodes.Add(lltnode)

        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "actualSP: " & actualSP, .Tag = actualSP})

        Return newnode

    End Function

End Class
