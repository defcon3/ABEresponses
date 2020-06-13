Imports System.Windows.Forms
''' <summary>
''' Klasse MarketBook
''' </summary>
Public Class MarketBook
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>The unique identifier for the market. MarketId's are prefixed with '1.'</returns>
    Public Property marketId As System.String = "---"
    ''' <summary>
    ''' Field required
    ''' </summary>
    ''' <returns>True if the data returned by listMarketBook will be delayed. The data may be delayed because you are not logged in with a funded account or you are using an Application Key that does not allow up to date data.</returns>
    Public Property isMarketDataDelayed As System.Boolean = System.Boolean.FalseString
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The status of the market, for example OPEN, SUSPENDED, CLOSED (settled), etc.</returns>
    Public Property status As clsEnumerations.MarketStatus = clsEnumerations.MarketStatus.INITIALISE
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The number of seconds an order is held until it is submitted into the market. Orders are usually delayed when the market is in-play</returns>
    Public Property betDelay As System.Int32 = 0
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>True if the market starting price has been reconciled</returns>
    Public Property bspReconciled As System.Boolean = System.Boolean.FalseString
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>If false, runners may be added to the market</returns>
    Public Property complete As System.Boolean = System.Boolean.FalseString
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>True if the market is currently in play</returns>
    Public Property inplay As System.Boolean = System.Boolean.FalseString
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The number of selections that could be settled as winners</returns>
    Public Property numberOfWinners As System.Int32 = 0
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The number of runners in the market</returns>
    Public Property numberOfRunners As System.Int32 = 0
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The number of runners that are currently active. An active runner is a selection available for betting</returns>
    Public Property numberOfActiveRunners As System.Int32 = 0
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The most recent time an order was executed</returns>
    Public Property lastMatchTime As System.DateTime = New DateTime(1900, 1, 1)
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The total amount matched</returns>
    Public Property totalMatched As System.Double = -1
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The total amount of orders that remain unmatched</returns>
    Public Property totalAvailable As System.Double = -1
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>True if cross matching is enabled for this market.</returns>
    Public Property crossMatching As System.Boolean = System.Boolean.FalseString
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>True if runners in the market can be voided. Please note - this doesn't include horse racing markets under which bets are voided on non-runners with any applicable reduction factor applied/</returns>
    Public Property runnersVoidable As System.Boolean = System.Boolean.FalseString
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The version of the market. The version increments whenever the market status changes, for example, turning in-play, or suspended when a goal is scored.</returns>
    Public Property version As System.Int64 = 0
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>Information about the runners (selections) in the market.</returns>
    Public Property runners As List(Of Runner) = New List(Of Runner)
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>Description of a markets key line for valid market types</returns>
    Public Property keyLineDescription As KeyLineDescription = New KeyLineDescription

    Public Function getnode() As System.Windows.Forms.TreeNode
        Dim newnode = New TreeNode With {.Text = "marketId: " & marketId, .Name = marketId, .Tag = marketId}
        newnode.Nodes.Add(New TreeNode With {.Text = "Zeitstempel: " & DateAndTime.Now, .Tag = DateAndTime.Now})
        newnode.Nodes.Add(New TreeNode With {.Text = "isMarketDataDelayed: " & isMarketDataDelayed, .Tag = isMarketDataDelayed})
        newnode.Nodes.Add(New TreeNode With {.Text = "status: " & status, .Tag = status})
        newnode.Nodes.Add(New TreeNode With {.Text = "betDelay: " & betDelay, .Tag = betDelay})
        newnode.Nodes.Add(New TreeNode With {.Text = "totalMatched: " & totalMatched, .Tag = totalMatched})
        newnode.Nodes.Add(New TreeNode With {.Text = "bspReconciled: " & bspReconciled, .Tag = bspReconciled})
        newnode.Nodes.Add(New TreeNode With {.Text = "complete: " & complete, .Tag = complete})
        newnode.Nodes.Add(New TreeNode With {.Text = "inplay: " & inplay, .Tag = inplay})
        newnode.Nodes.Add(New TreeNode With {.Text = "numberOfWinners: " & numberOfWinners, .Tag = numberOfWinners})
        newnode.Nodes.Add(New TreeNode With {.Text = "numberOfRunners: " & numberOfRunners, .Tag = numberOfRunners})
        newnode.Nodes.Add(New TreeNode With {.Text = "numberOfActiveRunners: " & numberOfActiveRunners, .Tag = numberOfActiveRunners})
        newnode.Nodes.Add(New TreeNode With {.Text = "lastMatchTime: " & lastMatchTime, .Tag = lastMatchTime})
        newnode.Nodes.Add(New TreeNode With {.Text = "totalAvailable: " & totalAvailable, .Tag = totalAvailable})
        newnode.Nodes.Add(New TreeNode With {.Text = "crossMatching: " & crossMatching, .Tag = crossMatching})
        newnode.Nodes.Add(New TreeNode With {.Text = "runnersVoidable: " & runnersVoidable, .Tag = runnersVoidable})
        newnode.Nodes.Add(New TreeNode With {.Text = "Version: " & version, .Tag = version})

        For Each ru As Runner In runners
            newnode.Nodes.Add(ru.getnode)
        Next


        Return newnode
    End Function

End Class
