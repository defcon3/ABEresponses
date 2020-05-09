''' <summary>
''' Public Class clsEnumerations
''' </summary>
Public Class clsEnumerations

    ''' <summary>
    ''' Enumeration MarketStatus
    ''' </summary>
    Public Enum MarketStatus
        ''' <summary>
        ''' The market has been created but isn't yet available.
        ''' </summary>
        INACTIVE 'The market has been created but isn't yet available.
        ''' <summary>
        ''' The market Is open For betting.
        ''' </summary>
        OPEN 'The market Is open For betting.
        ''' <summary>
        ''' The market Is suspended And Not available For betting.
        ''' </summary>
        SUSPENDED 'The market Is suspended And Not available For betting.
        ''' <summary>
        ''' The market has been settled And Is no longer available For betting.
        ''' </summary>
        CLOSED 'The market has been settled And Is no longer available For betting.
        ''' <summary>
        ''' No Entry found.
        ''' </summary>
        INITIALISE

    End Enum

    ''' <summary>
    ''' Enumeration RunnerStatus
    ''' </summary>
    Public Enum RunnerStatus
        ''' <summary>
        ''' RunnerStatus ACTIVE
        ''' </summary>
        ACTIVE 'ACTIVE
        ''' <summary>
        ''' RunnerStatus WINNER
        ''' </summary>
        WINNER 'WINNER
        ''' <summary>
        ''' RunnerStatus LOSER
        ''' </summary>
        LOSER 'LOSER
        ''' <summary>
        ''' The runner was placed, applies to EACH_WAY marketTypes only.
        ''' </summary>
        PLACED 'The runner was placed, applies To EACH_WAY marketTypes only. 
        ''' <summary>
        ''' REMOVED_VACANT applies To Greyhounds. Greyhound markets always Return a fixed number Of runners (traps). If a dog has been removed, the trap Is shown As vacant.
        ''' </summary>
        REMOVED_VACANT 'REMOVED_VACANT applies To Greyhounds. Greyhound markets always Return a fixed number Of runners (traps). If a dog has been removed, the trap Is shown As vacant.
        ''' <summary>
        ''' RunnerStatus REMOVED
        ''' </summary>
        REMOVED 'REMOVED
        ''' <summary>
        ''' The selection Is hidden from the market.  This occurs In Horse Racing markets were runners Is hidden When it Is doesn't hold an official entry following an entry stage. This could be because the horse was never entered or because they have been scratched from a race at a declaration stage. All matched customer bet prices are set to 1.0 even if there are later supplementary stages. Should it appear likely that a specific runner may actually be supplemented into the race this runner will be reinstated with all matched customer bets set back to the original prices.
        ''' </summary>
        HIDDEN 'The selection Is hidden from the market.  This occurs In Horse Racing markets were runners Is hidden When it Is doesn't hold an official entry following an entry stage. This could be because the horse was never entered or because they have been scratched from a race at a declaration stage. All matched customer bet prices are set to 1.0 even if there are later supplementary stages. Should it appear likely that a specific runner may actually be supplemented into the race this runner will be reinstated with all matched customer bets set back to the original prices.
        ''' <summary>
        ''' No Entry found.
        ''' </summary>
        INITIALISE

    End Enum

    ''' <summary>
    ''' Enumeration Side
    ''' </summary>
    Public Enum Side
        ''' <summary>
        ''' Back-Side
        ''' </summary>
        BACK 'BACK
        ''' <summary>
        ''' Lay-Side
        ''' </summary>
        LAY 'LAY
        ''' <summary>
        ''' No Entry found.
        ''' </summary>
        INITIALISE

    End Enum

    ''' <summary>
    ''' Public Enum OrderType
    ''' </summary>
    Public Enum OrderType
        ''' <summary>
        ''' A normal exchange limit order for immediate execution
        ''' </summary>
        LIMIT 'LIMIT
        ''' <summary>
        ''' Limit order for the auction (SP)
        ''' </summary>
        LIMIT_ON_CLOSE 'LIMIT_ON_CLOSE
        ''' <summary>
        ''' Market order for the auction (SP)
        ''' </summary>
        MARKET_ON_CLOSE 'MARKET_ON_CLOSE
        ''' <summary>
        ''' No Entry found.
        ''' </summary>
        INITIALISE

    End Enum

    ''' <summary>
    ''' Public Enum OrderStatus
    ''' </summary>
    Public Enum OrderStatus
        ''' <summary>
        ''' An asynchronous order is yet to be processed. Once the bet has been processed by the exchange (including waiting for any in-play delay), the result will be reported And available on the Exchange Stream API And API NG. Not a valid search criteria on MarketFilter
        ''' </summary>
        PENDING 'PENDING
        ''' <summary>
        ''' An order that does not have any remaining unmatched portion.
        ''' </summary>
        EXECUTION_COMPLETE 'EXECUTION_COMPLETE
        ''' <summary>
        ''' An order that has a remaining unmatched portion.
        ''' </summary>
        EXECUTABLE 'EXECUTABLE
        ''' <summary>
        ''' The order is no longer available for execution due to its time in force constraint. In the case of FILL_OR_KILL orders, this means the order has been killed because it could Not be filled to your specifications. Not a valid search criteria on MarketFilter
        ''' </summary>
        EXPIRED 'EXPIRED
        ''' <summary>
        ''' No Entry found.
        ''' </summary>
        INITIALISE

    End Enum

    ''' <summary>
    ''' Public Enum PersistenceType
    ''' </summary>
    Public Enum PersistenceType
        ''' <summary>
        ''' Lapse the order when the market is turned in-play
        ''' </summary>
        LAPSE 'LAPSE
        ''' <summary>
        ''' Persist the order to in-play. The bet will be place automatically into the in-play market at the start of the event.
        ''' </summary>
        PERSIST 'PERSIST
        ''' <summary>
        ''' Put the order into the auction (SP) at turn-in-play
        ''' </summary>
        MARKET_ON_CLOSE 'MARKET_ON_CLOSE
        ''' <summary>
        ''' No Entry found.
        ''' </summary>
        INITIALISE

    End Enum

    ''' <summary>
    ''' Public Enum MarketBettingType
    ''' </summary>
    Public Enum MarketBettingType
        ''' <summary>
        ''' Odds Market - Any market that doesn't fit any any of the below categories.
        ''' </summary>
        ODDS
        ''' <summary>
        ''' Line Market - LINE markets operate at even-money odds of 2.0. However, price for these markets refers to the line positions available as defined by the markets min-max range and interval steps. Customers either Buy a line (LAY bet, winning if outcome is greater than the taken line (price)) or Sell a line (BACK bet, winning if outcome is less than the taken line (price)). If settled outcome equals the taken line, stake is returned. 
        ''' </summary>
        LINE
        ''' <summary>
        ''' Range Market - Now Deprecated
        ''' </summary>
        RANGE
        ''' <summary>
        ''' Asian Handicap Market - A traditional Asian handicap market. Can be identified by marketType ASIAN_HANDICAP
        ''' </summary>
        ASIAN_HANDICAP_DOUBLE_LINE
        ''' <summary>
        ''' Asian Single Line Market - A market in which there can be 0 or multiple winners. e,.g marketType TOTAL_GOALS
        ''' </summary>
        ASIAN_HANDICAP_SINGLE_LINE
        ''' <summary>
        ''' Sportsbook Odds Market. This type is deprecated and will be removed in future releases, when Sportsbook markets will be represented as ODDS market but with a different product type.
        ''' </summary>
        FIXED_ODDS
        ''' <summary>
        ''' No Entry found.
        ''' </summary>
        INITIALISE

    End Enum

    ''' <summary>
    ''' Public Enum PriceLadderDescription
    ''' </summary>
    Public Enum PriceLadderType
        ''' <summary>
        ''' Price ladder increments traditionally used for Odds Markets.
        ''' </summary>
        CLASSIC
        ''' <summary>
        ''' Price ladder with the finest available increment, traditionally used for         Asian Handicap markets. 
        ''' </summary>
        FINEST
        ''' <summary>
        ''' Price ladder used for LINE markets. Refer to MarketLineRangeInfo for more details.
        ''' </summary>
        LINE_RANGE
        ''' <summary>
        ''' No Entry found.
        ''' </summary>
        INITIALISE

    End Enum


End Class
