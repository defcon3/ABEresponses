''' <summary>
''' Public Class RunnerMetadataDescription
''' </summary>
Public Class RunnerMetadataDescription
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The unit of weight used.</returns>
    Public Property WEIGHT_UNITS As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>Adjusted ratings are race-specific ratings which reflect weights allocated in the race and, in some circumstances, the age of the horse. Collectively they represent the chance each runner has on form. https://www.timeform.com/Racing/Articles/How_the_ratings_for_a_race_are_calculated Please note: this data is only returned for those with a Premium Timeform subscription</returns>
    Public Property ADJUSTED_RATING As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The year the horse’s mother's birth</returns>
    Public Property DAM_YEAR_BORN As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The number of days since the horse last ran</returns>
    Public Property DAYS_SINCE_LAST_RUN As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns></returns>
    Public Property WEARING As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The year in which the horse's grandfather was born on its mothers side</returns>
    Public Property DAMSIRE_YEAR_BORN As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The country were the horse's father was bred</returns>
    Public Property SIRE_BRED As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The name of the horse's trainer</returns>
    Public Property TRAINER_NAME As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The stall number the horse is starting from</returns>
    Public Property STALL_DRAW As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The sex of the horse</returns>
    Public Property SEX_TYPE As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The owner of the horse</returns>
    Public Property OWNER_NAME As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The name of the horse's father</returns>
    Public Property SIRE_NAME As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The forecast price numerator</returns>
    Public Property FORECASTPRICE_NUMERATOR As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The forecast price denominator</returns>
    Public Property FORECASTPRICE_DENOMINATOR As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The reduction in the weight that the horse carries for a particular jockey were applicable.</returns>
    Public Property JOCKEY_CLAIM As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The weight of the horse</returns>
    Public Property WEIGHT_VALUE As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The name of the horse's mother</returns>
    Public Property DAM_NAME As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The age of the horse</returns>
    Public Property AGE As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The colour of the horse</returns>
    Public Property COLOUR_TYPE As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The country were the horse's grandfather was born</returns>
    Public Property DAMSIRE_BRED As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The name of the horse's grandfather</returns>
    Public Property DAMSIRE_NAME As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The year the horse's father was born</returns>
    Public Property SIRE_YEAR_BORN As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The horses official rating</returns>
    Public Property OFFICIAL_RATING As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The horses recent form</returns>
    Public Property FORM As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The country in which the horse was born</returns>
    Public Property BRED As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The runnerId for the horse</returns>
    Public Property runnerId As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The name of the jockey. Please note: This field will contain 'Reserve' in the event that the horse has been entered into the market as a reserve runner. Any reserve runners will be withdrawn from the market once it has been confirmed that they will not run.</returns>
    Public Property JOCKEY_NAME As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The country where the horse's mother was born</returns>
    Public Property DAM_BRED As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The textual description of the jockey silk</returns>
    Public Property COLOURS_DESCRIPTION As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>A relative URL to an image file corresponding to the jockey silk. You must add the value of this field to the base URL: https://content-cache.cdnbf.net/feeds_images/Horses/SilkColours/</returns>
    Public Property COLOURS_FILENAME As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The number on the saddle-cloth</returns>
    Public Property CLOTH_NUMBER As System.String
    ''' <summary>
    ''' Field optional
    ''' </summary>
    ''' <returns>The number on the saddle-cloth. For US Racing were the runner is paired, this field will display the cloth number of the paired runner e.g. "1A"</returns>
    Public Property CLOTH_NUMBER_ALPHA As System.String

End Class
