''' <summary>
''' Public Class RunnerMetadataDescription
''' </summary>
Public Class RunnerMetadataDescription
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The unit of weight used.</returns>
    Public Property WEIGHT_UNITS As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>Adjusted ratings are race-specific ratings which reflect weights allocated in the race and, in some circumstances, the age of the horse. Collectively they represent the chance each runner has on form. https://www.timeform.com/Racing/Articles/How_the_ratings_for_a_race_are_calculated Please note: this data is only returned for those with a Premium Timeform subscription</returns>
    Public Property ADJUSTED_RATING As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The year the horse’s mother's birth</returns>
    Public Property DAM_YEAR_BORN As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The number of days since the horse last ran</returns>
    Public Property DAYS_SINCE_LAST_RUN As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns></returns>
    Public Property WEARING As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The year in which the horse's grandfather was born on its mothers side</returns>
    Public Property DAMSIRE_YEAR_BORN As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The country were the horse's father was bred</returns>
    Public Property SIRE_BRED As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The name of the horse's trainer</returns>
    Public Property TRAINER_NAME As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The stall number the horse is starting from</returns>
    Public Property STALL_DRAW As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The sex of the horse</returns>
    Public Property SEX_TYPE As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The owner of the horse</returns>
    Public Property OWNER_NAME As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The name of the horse's father</returns>
    Public Property SIRE_NAME As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The forecast price numerator</returns>
    Public Property FORECASTPRICE_NUMERATOR As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The forecast price denominator</returns>
    Public Property FORECASTPRICE_DENOMINATOR As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The reduction in the weight that the horse carries for a particular jockey were applicable.</returns>
    Public Property JOCKEY_CLAIM As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The weight of the horse</returns>
    Public Property WEIGHT_VALUE As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The name of the horse's mother</returns>
    Public Property DAM_NAME As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The age of the horse</returns>
    Public Property AGE As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The colour of the horse</returns>
    Public Property COLOUR_TYPE As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The country were the horse's grandfather was born</returns>
    Public Property DAMSIRE_BRED As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The name of the horse's grandfather</returns>
    Public Property DAMSIRE_NAME As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The year the horse's father was born</returns>
    Public Property SIRE_YEAR_BORN As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The horses official rating</returns>
    Public Property OFFICIAL_RATING As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The horses recent form</returns>
    Public Property FORM As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The country in which the horse was born</returns>
    Public Property BRED As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The runnerId for the horse</returns>
    Public Property runnerId As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The name of the jockey. Please note: This field will contain 'Reserve' in the event that the horse has been entered into the market as a reserve runner. Any reserve runners will be withdrawn from the market once it has been confirmed that they will not run.</returns>
    Public Property JOCKEY_NAME As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The country where the horse's mother was born</returns>
    Public Property DAM_BRED As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The textual description of the jockey silk</returns>
    Public Property COLOURS_DESCRIPTION As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>A relative URL to an image file corresponding to the jockey silk. You must add the value of this field to the base URL: https://content-cache.cdnbf.net/feeds_images/Horses/SilkColours/</returns>
    Public Property COLOURS_FILENAME As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The number on the saddle-cloth</returns>
    Public Property CLOTH_NUMBER As System.String = "---"
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The number on the saddle-cloth. For US Racing were the runner is paired, this field will display the cloth number of the paired runner e.g. "1A"</returns>
    Public Property CLOTH_NUMBER_ALPHA As System.String = "---"

    Function gettable() As System.Data.DataTable
        Dim dt As New System.Data.DataTable("RunnerMetadataDescription")

        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERMETADATADESCRIPTION_WEIGHT_UNITS", .DataType = GetType(System.String), .DefaultValue = WEIGHT_UNITS})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERMETADATADESCRIPTION_ADJUSTED_RATING", .DataType = GetType(System.String), .DefaultValue = ADJUSTED_RATING})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERMETADATADESCRIPTION_DAM_YEAR_BORN", .DataType = GetType(System.String), .DefaultValue = DAM_YEAR_BORN})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERMETADATADESCRIPTION_DAYS_SINCE_LAST_RUN", .DataType = GetType(System.String), .DefaultValue = DAYS_SINCE_LAST_RUN})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERMETADATADESCRIPTION_WEARING", .DataType = GetType(System.String), .DefaultValue = WEARING})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERMETADATADESCRIPTION_DAMSIRE_YEAR_BORN", .DataType = GetType(System.String), .DefaultValue = DAMSIRE_YEAR_BORN})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERMETADATADESCRIPTION_SIRE_BRED", .DataType = GetType(System.String), .DefaultValue = SIRE_BRED})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERMETADATADESCRIPTION_TRAINER_NAME", .DataType = GetType(System.String), .DefaultValue = TRAINER_NAME})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERMETADATADESCRIPTION_STALL_DRAW", .DataType = GetType(System.String), .DefaultValue = STALL_DRAW})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERMETADATADESCRIPTION_SEX_TYPE", .DataType = GetType(System.String), .DefaultValue = SEX_TYPE})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERMETADATADESCRIPTION_OWNER_NAME", .DataType = GetType(System.String), .DefaultValue = OWNER_NAME})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERMETADATADESCRIPTION_SIRE_NAME", .DataType = GetType(System.String), .DefaultValue = SIRE_NAME})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERMETADATADESCRIPTION_FORECASTPRICE_NUMERATOR", .DataType = GetType(System.String), .DefaultValue = FORECASTPRICE_NUMERATOR})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERMETADATADESCRIPTION_FORECASTPRICE_DENOMINATOR", .DataType = GetType(System.String), .DefaultValue = FORECASTPRICE_DENOMINATOR})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERMETADATADESCRIPTION_JOCKEY_CLAIM", .DataType = GetType(System.String), .DefaultValue = JOCKEY_CLAIM})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERMETADATADESCRIPTION_WEIGHT_VALUE", .DataType = GetType(System.String), .DefaultValue = WEIGHT_VALUE})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERMETADATADESCRIPTION_DAM_NAME", .DataType = GetType(System.String), .DefaultValue = DAM_NAME})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERMETADATADESCRIPTION_AGE", .DataType = GetType(System.String), .DefaultValue = AGE})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERMETADATADESCRIPTION_COLOUR_TYPE", .DataType = GetType(System.String), .DefaultValue = COLOUR_TYPE})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERMETADATADESCRIPTION_DAMSIRE_BRED", .DataType = GetType(System.String), .DefaultValue = DAMSIRE_BRED})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERMETADATADESCRIPTION_DAMSIRE_NAME", .DataType = GetType(System.String), .DefaultValue = DAMSIRE_NAME})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERMETADATADESCRIPTION_SIRE_YEAR_BORN", .DataType = GetType(System.String), .DefaultValue = SIRE_YEAR_BORN})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERMETADATADESCRIPTION_OFFICIAL_RATING", .DataType = GetType(System.String), .DefaultValue = OFFICIAL_RATING})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERMETADATADESCRIPTION_FORM", .DataType = GetType(System.String), .DefaultValue = FORM})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERMETADATADESCRIPTION_BRED", .DataType = GetType(System.String), .DefaultValue = BRED})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERMETADATADESCRIPTION_RUNNERID", .DataType = GetType(System.String), .DefaultValue = runnerId})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERMETADATADESCRIPTION_JOCKEY_NAME", .DataType = GetType(System.String), .DefaultValue = JOCKEY_NAME})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERMETADATADESCRIPTION_DAM_BRED", .DataType = GetType(System.String), .DefaultValue = DAM_BRED})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERMETADATADESCRIPTION_COLOURS_DESCRIPTION", .DataType = GetType(System.String), .DefaultValue = COLOURS_DESCRIPTION})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERMETADATADESCRIPTION_COLOURS_FILENAME", .DataType = GetType(System.String), .DefaultValue = COLOURS_FILENAME})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERMETADATADESCRIPTION_CLOTH_NUMBER", .DataType = GetType(System.String), .DefaultValue = CLOTH_NUMBER})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERMETADATADESCRIPTION_CLOTH_NUMBER_ALPHA", .DataType = GetType(System.String), .DefaultValue = CLOTH_NUMBER_ALPHA})


        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERMETADATADESCRIPTION_TIMESTAMP", .DataType = GetType(System.String), .DefaultValue = Date.Now.ToString("dd/MM/yyyy hh:mm:ss.fff tt")})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERMETADATADESCRIPTION_NOW", .DataType = GetType(DateTime), .DefaultValue = Date.Now})
        dt.Columns.Add(New DataColumn With {.ColumnName = "RUNNERMETADATADESCRIPTION_NOWTICKS", .DataType = GetType(System.Int64), .DefaultValue = Date.Now.Ticks})


        dt.Rows.Add(dt.NewRow)

        'Dim dr As DataRow = dt.NewRow
        'dt.Rows.Add(dr)

        Return dt


    End Function


    Public Function getnode() As System.Windows.Forms.TreeNode
        Dim newnode = New System.Windows.Forms.TreeNode With {.Text = "RunnerMetadataDescription: " & "RunnerMetadataDescription", .Name = "RunnerMetadataDescription", .Tag = "RunnerMetadataDescription"}
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "Zeitstempel: " & DateAndTime.Now, .Tag = DateAndTime.Now})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "WEIGHT_UNITS: " & WEIGHT_UNITS, .Tag = WEIGHT_UNITS})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "ADJUSTED_RATING: " & ADJUSTED_RATING, .Tag = ADJUSTED_RATING})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "DAM_YEAR_BORN: " & DAM_YEAR_BORN, .Tag = DAM_YEAR_BORN})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "DAYS_SINCE_LAST_RUN: " & DAYS_SINCE_LAST_RUN, .Tag = DAYS_SINCE_LAST_RUN})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "WEARING: " & WEARING, .Tag = WEARING})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "DAMSIRE_YEAR_BORN: " & DAMSIRE_YEAR_BORN, .Tag = DAMSIRE_YEAR_BORN})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "SIRE_BRED: " & SIRE_BRED, .Tag = SIRE_BRED})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "TRAINER_NAME: " & TRAINER_NAME, .Tag = TRAINER_NAME})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "STALL_DRAW: " & STALL_DRAW, .Tag = STALL_DRAW})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "SEX_TYPE: " & SEX_TYPE, .Tag = SEX_TYPE})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "OWNER_NAME: " & OWNER_NAME, .Tag = OWNER_NAME})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "SIRE_NAME: " & SIRE_NAME, .Tag = SIRE_NAME})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "FORECASTPRICE_NUMERATOR: " & FORECASTPRICE_NUMERATOR, .Tag = FORECASTPRICE_NUMERATOR})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "FORECASTPRICE_DENOMINATOR: " & FORECASTPRICE_DENOMINATOR, .Tag = FORECASTPRICE_DENOMINATOR})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "JOCKEY_CLAIM: " & JOCKEY_CLAIM, .Tag = JOCKEY_CLAIM})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "WEIGHT_VALUE: " & WEIGHT_VALUE, .Tag = WEIGHT_VALUE})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "DAM_NAME: " & DAM_NAME, .Tag = DAM_NAME})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "AGE: " & AGE, .Tag = AGE})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "COLOUR_TYPE: " & COLOUR_TYPE, .Tag = COLOUR_TYPE})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "DAMSIRE_BRED: " & DAMSIRE_BRED, .Tag = DAMSIRE_BRED})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "DAMSIRE_NAME: " & DAMSIRE_NAME, .Tag = DAMSIRE_NAME})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "SIRE_YEAR_BORN: " & SIRE_YEAR_BORN, .Tag = SIRE_YEAR_BORN})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "OFFICIAL_RATING: " & OFFICIAL_RATING, .Tag = OFFICIAL_RATING})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "FORM: " & FORM, .Tag = FORM})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "BRED: " & BRED, .Tag = BRED})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "runnerId: " & runnerId, .Tag = runnerId})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "JOCKEY_NAME: " & JOCKEY_NAME, .Tag = JOCKEY_NAME})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "DAM_BRED: " & DAM_BRED, .Tag = DAM_BRED})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "COLOURS_DESCRIPTION: " & COLOURS_DESCRIPTION, .Tag = COLOURS_DESCRIPTION})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "COLOURS_FILENAME: " & COLOURS_FILENAME, .Tag = COLOURS_FILENAME})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "CLOTH_NUMBER: " & CLOTH_NUMBER, .Tag = CLOTH_NUMBER})
        newnode.Nodes.Add(New System.Windows.Forms.TreeNode With {.Text = "CLOTH_NUMBER_ALPHA: " & CLOTH_NUMBER_ALPHA, .Tag = CLOTH_NUMBER_ALPHA})

        Return newnode
    End Function


End Class
