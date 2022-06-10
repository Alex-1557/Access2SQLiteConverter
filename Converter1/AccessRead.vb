Partial Module Module1
    Sub AccessRead()
        'GoTo Priv

        CalibDataList = CN1.RawSqlQuery(Of CalibData)(My.Settings.CalibSQL, Function(X) New CalibData With {
                                        .Name = CheckDBNull(Of String)(X("Name")),
                                        .Source = CheckDBNull(Of String)(X("Source")),
                                        .SampleTargets = CheckDBNull(Of String)(X("SampleTargets")),
                                        .SampleValues = CheckDBNull(Of String)(X("SampleValues")),
                                        .Coeffs = CheckDBNull(Of String)(X("Coeffs")),
                                        .ZeroSample = CheckDBNull(Of String)(X("ZeroSample")),
                                        .NewZeroSample = CheckDBNull(Of String)(X("NewZeroSample")),
                                        .InfinitySample = CheckDBNull(Of String)(X("InfinitySample")),
                                        .NewInfinitySample = CheckDBNull(Of String)(X("NewInfinitySample")),
                                        .Description = CheckDBNull(Of String)(X("Description")),
                                        .MaxNormPrcnt = CheckDBNull(Of Double)(X("MaxNormPrcnt")),
                                        .MinNormPrcnt = CheckDBNull(Of Double)(X("MinNormPrcnt")),
                                        .SampleTime = CheckDBNull(Of Long)(X("SampleTime")),
                                        .LastRezero = CheckDBNull(Of Date)(X("LastRezero"))
            })
        Console.WriteLine()
        Console.WriteLine($"CalibData {CalibDataList?.Count} rows read")


CardData:
        CardDataList = CN1.RawSqlQuery(Of CardData)(My.Settings.CardSQL, Function(X) New CardData With {
                                        .Name = CheckDBNull(Of String)(X("Name")),
                                        .Address = CheckDBNull(Of String)(X("Address ")),
                                        .CardModel = CheckDBNull(Of Long)(X("CardModel")),
                                        .CardSetup = CheckDBNull(Of Long)(X("CardSetup")),
                                        .MasterCard = CheckDBNull(Of Long)(X("MasterCard"))
            })
        Console.WriteLine()
        Console.WriteLine($"CardData {CardDataList?.Count} rows read")

ControlData:
        ControlDataList = CN1.RawSqlQuery(Of ControlData)(My.Settings.ControlSQL, Function(X) New ControlData With {
                                        .RecipeName = CheckDBNull(Of String)(X("RecipeName")),
                                        .CtrlName = CheckDBNull(Of String)(X("CtrlName")),
                                        .CtrlSignal = CheckDBNull(Of Long)(X("CtrlSignal")),
                                        .CtrlNumber = CheckDBNull(Of Long)(X("CtrlNumber")),
                                        .CtrlLogic = CheckDBNull(Of Long)(X("CtrlLogic")),
                                        .Description = CheckDBNull(Of String)(X("Description")),
                                        .CtrlType = CheckDBNull(Of Long)(X("CtrlType")),
                                        .DigOutput = CheckDBNull(Of String)(X("DigOutput")),
                                        .GaugeOutput = CheckDBNull(Of String)(X("GaugeOutput"))
            })
        Console.WriteLine()
        Console.WriteLine($"ControlData {ControlDataList?.Count} rows read")
CoreData:
        CoreDataList = CN1.RawSqlQuery(Of CoreData)(My.Settings.CoreSQL, Function(X) New CoreData With {
                                        .Name = CheckDBNull(Of String)(X("Name")),
                                        .DataType = CheckDBNull(Of String)(X("DataType")),
                                        .Initialize = CheckDBNull(Of String)(X("Initialize")),
                                        .Save = CheckDBNull(Of Boolean)(X("Save"))
            })
        Console.WriteLine()
        Console.WriteLine($"CoreData {CoreDataList?.Count} rows read")
GaugeData:
        GaugeDataList = CN1.RawSqlQuery(Of GaugeData)(My.Settings.GaugeSQL, Function(X) New GaugeData With {
                                        .ID = CheckDBNull(Of String)(X("ID")),
                                        .GaugeName = CheckDBNull(Of String)(X("GaugeName")),
                                        .Description = CheckDBNull(Of String)(X("Description")),
                                        .GaugeType = CheckDBNull(Of Integer)(X("GaugeType")),
                                        .IsotopeType = CheckDBNull(Of Long)(X("IsotopeType")),
                                        .GaugeOn = CheckDBNull(Of Boolean)(X("GaugeOn")),
                                        .ProfileGauge = CheckDBNull(Of Boolean)(X("ProfileGauge")),
                                        .StripWidth = CheckDBNull(Of Double)(X("StripWidth")),
                                        .NomLineSpeed = CheckDBNull(Of Double)(X("NomLineSpeed")),
                                        .ScanSpeed = CheckDBNull(Of Double)(X("ScanSpeed")),
                                        .ScanMode = CheckDBNull(Of Long)(X("ScanMode")),
                                        .Calibration = CheckDBNull(Of String)(X("Calibration")),
                                        .SPC = CheckDBNull(Of String)(X("SPC")),
                                        .RecipeName = CheckDBNull(Of String)(X("RecipeName")),
                                        .RecipeID = CheckDBNull(Of Long)(X("Recipe ID")), 'Recipe ID
                                        .Multiplier = CheckDBNull(Of Double)(X("Multiplier")),
                                        .Compensation = CheckDBNull(Of Double)(X("Compensation")),
                                        .Filter = CheckDBNull(Of Double)(X("Filter")),
                                        .UpdateRate = CheckDBNull(Of Long)(X("UpdateRate")),
                                        .StatLength = CheckDBNull(Of Long)(X("StatLength")),
                                        .SetPoint = CheckDBNull(Of Double)(X("SetPoint")),
                                        .SigFormat = CheckDBNull(Of String)(X("SigFormat")),
                                        .WarningEnable = CheckDBNull(Of Boolean)(X("WarningEnable")),
                                        .WarningLow = CheckDBNull(Of Double)(X("WarningLow")),
                                        .WarningHigh = CheckDBNull(Of Double)(X("WarningHigh")),
                                        .AlarmEnable = CheckDBNull(Of Boolean)(X("AlarmEnable")),
                                        .AlarmLow = CheckDBNull(Of Double)(X("AlarmLow")),
                                        .AlarmHigh = CheckDBNull(Of Double)(X("AlarmHigh")),
                                        .ActiveFilter = CheckDBNull(Of Boolean)(X("ActiveFilter")),
                                        .Recording = CheckDBNull(Of Boolean)(X("Recording")),
                                        .ExceptReport = CheckDBNull(Of Boolean)(X("ExceptReport")),
                                        .Reporting = CheckDBNull(Of Boolean)(X("Reporting")),
                                        .PrintGraph = CheckDBNull(Of Boolean)(X("PrintGraph")),
                                        .DistModeDivider = CheckDBNull(Of Double)(X("DistModeDivider")),
                                        .RecordingRate = CheckDBNull(Of Long)(X("RecordingRate")),
                                        .Seperation = CheckDBNull(Of Double)(X("Seperation")),
                                        .StripLength = CheckDBNull(Of Double)(X("StripLength")),
                                        .AOLow = CheckDBNull(Of Double)(X("AOLow")),
                                        .AOHigh = CheckDBNull(Of Double)(X("AOHigh")),
                                        .AOLow1 = CheckDBNull(Of Double)(X("AOLow1")),
                                        .AOHigh1 = CheckDBNull(Of Double)(X("AOHigh1")),
                                        .AOLow2 = CheckDBNull(Of Double)(X("AOLow2")),
                                        .AOHigh2 = CheckDBNull(Of Double)(X("AOHigh2")),
                                        .AOLow3 = CheckDBNull(Of Long)(X("AOLow3")),
                                        .AOHigh3 = CheckDBNull(Of Long)(X("AOHigh3")),
                                        .Input1 = CheckDBNull(Of String)(X("Input1")),
                                        .Input2 = CheckDBNull(Of String)(X("Input2")),
                                        .Input3 = CheckDBNull(Of String)(X("Input3")),
                                        .Input4 = CheckDBNull(Of String)(X("Input4")),
                                        .Input5 = CheckDBNull(Of String)(X("Input5")),
                                        .Input6 = CheckDBNull(Of String)(X("Input6")),
                                        .Input7 = CheckDBNull(Of String)(X("Input7")),
                                        .Input8 = CheckDBNull(Of String)(X("Input8")),
                                        .Input9 = CheckDBNull(Of String)(X("Input9")),
                                        .Output1 = CheckDBNull(Of String)(X("Output1")),
                                        .Output2 = CheckDBNull(Of String)(X("Output2")),
                                        .Output3 = CheckDBNull(Of String)(X("Output3")),
                                        .Output4 = CheckDBNull(Of String)(X("Output4")),
                                        .Output5 = CheckDBNull(Of String)(X("Output5")),
                                        .Output6 = CheckDBNull(Of String)(X("Output6")),
                                        .Output7 = CheckDBNull(Of String)(X("Output7")),
                                        .Output8 = CheckDBNull(Of String)(X("Output8")),
                                        .Output9 = CheckDBNull(Of String)(X("Output9")),
                                        .CDPulsePerUnit = CheckDBNull(Of Double)(X("CDPulsePerUnit")),
                                        .LeftMargin = CheckDBNull(Of Double)(X("LeftMargin")),
                                        .LeftTrim = CheckDBNull(Of Double)(X("LeftTrim")),
                                        .RightTrim = CheckDBNull(Of Double)(X("RightTrim")),
                                        .RightMargin = CheckDBNull(Of Double)(X("RightMargin")),
                                        .FixedPosition = CheckDBNull(Of Double)(X("FixedPosition")),
                                        .NumOfSteps = CheckDBNull(Of Long)(X("NumOfSteps")),
                                        .TravSpeed = CheckDBNull(Of Double)(X("TravSpeed")),
                                        .RetSpeed = CheckDBNull(Of Double)(X("RetSpeed")),
                                        .MotorNumber = CheckDBNull(Of Long)(X("MotorNumber")),
                                        .CDOffset = CheckDBNull(Of Double)(X("CDOffset")),
                                        .K_Prop = CheckDBNull(Of Double)(X("K_Prop")),
                                        .K_Integr = CheckDBNull(Of Double)(X("K_Integr")),
                                        .K_Deriv = CheckDBNull(Of Double)(X("K_Deriv")),
                                        .FFMaxLineSpeed = CheckDBNull(Of Double)(X("FFMaxLineSpeed")),
                                        .FFMinLineSpeed = CheckDBNull(Of Double)(X("FFMinLineSpeed")),
                                        .MAFilterN = CheckDBNull(Of Integer)(X("MAFilterN")),
                                        .LimitPlus = CheckDBNull(Of Double)(X("LimitPlus")),
                                        .LimitMinus = CheckDBNull(Of Double)(X("LimitMinus")),
                                        .ZoningEnable = CheckDBNull(Of Boolean)(X("ZoningEnable")),
                                        .ZoneABeg = CheckDBNull(Of Double)(X("ZoneABeg")),
                                        .ZoneAEnd = CheckDBNull(Of Double)(X("ZoneAEnd")),
                                        .ZoneBBeg = CheckDBNull(Of Double)(X("ZoneBBeg")),
                                        .ZoneBEnd = CheckDBNull(Of Double)(X("ZoneBEnd")),
                                        .Zone1Beg = CheckDBNull(Of Double)(X("Zone1Beg")),
                                        .Zone1End = CheckDBNull(Of Double)(X("Zone1End")),
                                        .Zone2Beg = CheckDBNull(Of Double)(X("Zone2Beg")),
                                        .Zone2End = CheckDBNull(Of Double)(X("Zone2End")),
                                        .Zone3Beg = CheckDBNull(Of Double)(X("Zone3Beg")),
                                        .Zone3End = CheckDBNull(Of Double)(X("Zone3End")),
                                        .Zone4Beg = CheckDBNull(Of Double)(X("Zone4Beg")),
                                        .Zone4End = CheckDBNull(Of Double)(X("Zone4End")),
                                        .Zone5Beg = CheckDBNull(Of Double)(X("Zone5Beg")),
                                        .Zone5End = CheckDBNull(Of Double)(X("Zone5End")),
                                        .Zone6Beg = CheckDBNull(Of Double)(X("Zone6Beg")),
                                        .Zone6End = CheckDBNull(Of Double)(X("Zone6End")),
                                        .Zone7Beg = CheckDBNull(Of Double)(X("Zone7Beg")),
                                        .Zone7End = CheckDBNull(Of Double)(X("Zone7End")),
                                        .Zone8Beg = CheckDBNull(Of Double)(X("Zone8Beg")),
                                        .Zone8End = CheckDBNull(Of Double)(X("Zone8End")),
                                        .Zone9Beg = CheckDBNull(Of Double)(X("Zone9Beg")),
                                        .Zone9End = CheckDBNull(Of Double)(X("Zone9End")),
                                        .Zone10Beg = CheckDBNull(Of Double)(X("Zone10Beg")),
                                        .Zone10End = CheckDBNull(Of Double)(X("Zone10End")),
                                        .Zone11Beg = CheckDBNull(Of Double)(X("Zone11Beg")),
                                        .Zone11End = CheckDBNull(Of Double)(X("Zone11End")),
                                        .Zone12Beg = CheckDBNull(Of Double)(X("Zone12Beg")),
                                        .Zone12End = CheckDBNull(Of Double)(X("Zone12End")),
                                        .DIO1 = CheckDBNull(Of String)(X("DIO1")),
                                        .DIO2 = CheckDBNull(Of String)(X("DIO2")),
                                        .DIO3 = CheckDBNull(Of String)(X("DIO3")),
                                        .DIO4 = CheckDBNull(Of String)(X("DIO4")),
                                        .DIO5 = CheckDBNull(Of String)(X("DIO5")),
                                        .DIO6 = CheckDBNull(Of String)(X("DIO6")),
                                        .DIO7 = CheckDBNull(Of String)(X("DIO7")),
                                        .DIO8 = CheckDBNull(Of String)(X("DIO8")),
                                        .DIO9 = CheckDBNull(Of String)(X("DIO9")),
                                        .DIO10 = CheckDBNull(Of String)(X("DIO10")),
                                        .DIO11 = CheckDBNull(Of String)(X("DIO11")),
                                        .DIO12 = CheckDBNull(Of String)(X("DIO12")),
                                        .RecordIfWarnLow = CheckDBNull(Of Boolean)(X("RecordIfWarnLow")),
                                        .CountsCorrOn = CheckDBNull(Of Boolean)(X("CountsCorrOn"))
                        })
        Console.WriteLine()
        Console.WriteLine($"GaugeData {GaugeDataList?.Count} rows read")

RecipeData:
        RecipeDataList = CN1.RawSqlQuery(Of RecipeData)(My.Settings.RecipeSQL, Function(X) New RecipeData With {
                                        .ID = CheckDBNull(Of Integer)(X("ID")),
                                        .Name = CheckDBNull(Of String)(X("Name")),
                                        .GaugeName = CheckDBNull(Of String)(X("GaugeName")),
                                        .RecipeName = CheckDBNull(Of String)(X("RecipeName")),
                                        .Description = CheckDBNull(Of String)(X("Description"))
            })
        Console.WriteLine()
        Console.WriteLine($"RecipeData {RecipeDataList?.Count} rows read")

SignalData:
        SignalDataList = CN1.RawSqlQuery(Of SignalData)(My.Settings.SignalSQL, Function(X) New SignalData With {
                                        .SignalDelay = CheckDBNull(Of Long)(X("SignalDelay")),
                                        .RecipeName = CheckDBNull(Of String)(X("RecipeName")),
                                        .SignalName = CheckDBNull(Of String)(X("SignalName")),
                                        .SignalNumber = CheckDBNull(Of Long)(X("SignalNumber")),
                                        .SignalLogic = CheckDBNull(Of Long)(X("SignalLogic")),
                                        .InputType0 = CheckDBNull(Of Long)(X("InputType0")),
                                        .InputName0 = CheckDBNull(Of String)(X("InputName0")),
                                        .InputLogic0 = CheckDBNull(Of Long)(X("InputLogic0")),
                                        .InputType1 = CheckDBNull(Of Long)(X("InputType1")),
                                        .InputName1 = CheckDBNull(Of String)(X("InputName1")),
                                        .InputLogic1 = CheckDBNull(Of Long)(X("InputLogic1")),
                                        .InputType2 = CheckDBNull(Of Long)(X("InputType2")),
                                        .InputName2 = CheckDBNull(Of String)(X("InputName2")),
                                        .InputLogic2 = CheckDBNull(Of Long)(X("InputLogic2")),
                                        .InputType3 = CheckDBNull(Of Long)(X("InputType3")),
                                        .InputName3 = CheckDBNull(Of String)(X("InputName3")),
                                        .InputLogic3 = CheckDBNull(Of Long)(X("InputLogic3")),
                                        .InputType4 = CheckDBNull(Of Long)(X("InputType4")),
                                        .InputName4 = CheckDBNull(Of String)(X("InputName4")),
                                        .InputLogic4 = CheckDBNull(Of Long)(X("InputLogic4")),
                                        .InputType5 = CheckDBNull(Of Long)(X("InputType5")),
                                        .InputName5 = CheckDBNull(Of String)(X("InputName5")),
                                        .InputLogic5 = CheckDBNull(Of Long)(X("InputLogic5")),
                                        .InputType6 = CheckDBNull(Of Long)(X("InputType6")),
                                        .InputName6 = CheckDBNull(Of String)(X("InputName6")),
                                        .InputLogic6 = CheckDBNull(Of Long)(X("InputLogic6")),
                                        .InputType7 = CheckDBNull(Of Long)(X("InputType7")),
                                        .InputName7 = CheckDBNull(Of String)(X("InputName7")),
                                        .InputLogic7 = CheckDBNull(Of Long)(X("InputLogic7"))
            })
        Console.WriteLine()
        Console.WriteLine($"SignalData {SignalDataList?.Count} rows read")

SpcData:
        SpcDataList = CN1.RawSqlQuery(Of SpcData)(My.Settings.SpcSQL, Function(X) New SpcData With {
                                        .Name = CheckDBNull(Of String)(X("Name")),
                                        .RecipeName = CheckDBNull(Of String)(X("RecipeName")),
                                        .Source = CheckDBNull(Of String)(X("Source")),
                                        .Interval = CheckDBNull(Of Long)(X("Interval")),
                                        .StatSample = CheckDBNull(Of Long)(X("StatSample")),
                                        .CpkHigh = CheckDBNull(Of Double)(X("CpkHigh")),
                                        .CpkLow = CheckDBNull(Of Double)(X("CpkLow")),
                                        .XbarEnable = CheckDBNull(Of Boolean)(X("XbarEnable")),
                                        .XbarMean = CheckDBNull(Of Double)(X("XbarMean")),
                                        .XbarUCL = CheckDBNull(Of Double)(X("XbarUCL")),
                                        .XbarLCL = CheckDBNull(Of Double)(X("XbarLCL")),
                                        .RbarEnable = CheckDBNull(Of Boolean)(X("RbarEnable")),
                                        .RbarMean = CheckDBNull(Of Double)(X("RbarMean")),
                                        .RbarUCL = CheckDBNull(Of Double)(X("RbarUCL")),
                                        .RbarLCL = CheckDBNull(Of Double)(X("RbarLCL")),
                                        .ProdSpecEnable = CheckDBNull(Of Boolean)(X("ProdSpecEnable")),
                                        .ProdSpecUSL = CheckDBNull(Of Double)(X("ProdSpecUSL")),
                                        .ProdSpecLSL = CheckDBNull(Of Double)(X("ProdSpecLSL")),
                                        .ActiveFilterComp = CheckDBNull(Of Double)(X("ActiveFilterComp"))
             })
        Console.WriteLine()
        Console.WriteLine($"SpcData {SpcDataList?.Count} rows read")

ViewData:
        ViewDataList = CN1.RawSqlQuery(Of ViewData)(My.Settings.ViewSQL, Function(X) New ViewData With {
                                        .RecipeName = CheckDBNull(Of String)(X("RecipeName")),
                                        .GraphCaption = CheckDBNull(Of String)(X("GraphCaption")),
                                        .Style = CheckDBNull(Of Long)(X("Style")),
                                        .WinNo = CheckDBNull(Of Long)(X("WinNo")),
                                        .GaugeName = CheckDBNull(Of String)(X("GaugeName")),
                                        .SetPoint = CheckDBNull(Of Long)(X("SetPoint")),
                                        .BackColor = CheckDBNull(Of Long)(X("BackColor")),
                                        .BorderColor = CheckDBNull(Of Long)(X("BorderColor")),
                                        .Left = CheckDBNull(Of Long)(X("Left")),
                                        .Top = CheckDBNull(Of Long)(X("Top")),
                                        .Width = CheckDBNull(Of Long)(X("Width")),
                                        .Height = CheckDBNull(Of Long)(X("Height")),
                                        .GphRng = CheckDBNull(Of Double)(X("GphRng")),
                                        .GphRngInc = CheckDBNull(Of Double)(X("GphRngInc")),
                                        .SetPtInc = CheckDBNull(Of Double)(X("SetPtInc")),
                                        .DataPnts = CheckDBNull(Of Long)(X("DataPnts")),
                                        .DataColorOn = CheckDBNull(Of Boolean)(X("DataColorOn")),
                                        .DataType = CheckDBNull(Of Long)(X("DataType")),
                                        .DataColor = CheckDBNull(Of Long)(X("DataColor")),
                                        .AlarmColor = CheckDBNull(Of Long)(X("AlarmColor")),
                                        .WarningColor = CheckDBNull(Of Long)(X("WarningColor")),
                                        .NormalColor = CheckDBNull(Of Long)(X("NormalColor")),
                                        .LineWidth = CheckDBNull(Of Long)(X("LineWidth")),
                                        .FontSize = CheckDBNull(Of Long)(X("FontSize")),
                                        .ShowAlarmLine = CheckDBNull(Of Boolean)(X("ShowAlarmLine")),
                                        .ShowWarnLine = CheckDBNull(Of Boolean)(X("ShowWarnLine")),
                                        .Xunits = CheckDBNull(Of String)(X("Xunits")),
                                        .Yunits = CheckDBNull(Of String)(X("Yunits")),
                                        .ProfileStyle = CheckDBNull(Of Long)(X("ProfileStyle")),
                                        .LastNAveraged = CheckDBNull(Of Long)(X("LastNAveraged")),
                                        .Profile = CheckDBNull(Of Boolean)(X("Profile"))
            })
        Console.WriteLine()
        Console.WriteLine($"ViewData {ViewDataList?.Count} rows read")

Priv:
        PrivList = CN1.RawSqlQuery(Of Priv)(My.Settings.PrivSQL, Function(X) New Priv With {
                                        .LastName = CheckDBNull(Of String)(X("LastName")),
                                        .FirstName = CheckDBNull(Of String)(X("FirstName")),
                                        .UserName = CheckDBNull(Of String)(X("UserName")),
                                        .PassWord = CheckDBNull(Of String)(X("PassWord")),
                                        .ChangeModes = CheckDBNull(Of Integer)(X("ChangeModes")),
                                        .RcpEdit = CheckDBNull(Of Integer)(X("RcpEdit")),
                                        .ggEdit = CheckDBNull(Of Integer)(X("ggEdit")),
                                        .gphChange = CheckDBNull(Of Integer)(X("gphChange")),
                                        .ExitApp = CheckDBNull(Of Integer)(X("ExitApp")),
                                        .StartApp = CheckDBNull(Of Integer)(X("StartApp")),
                                        .Calib = CheckDBNull(Of Integer)(X("Calib")),
                                        .PCTimeMod = CheckDBNull(Of Integer)(X("PCTimeMod")),
                                        .Prnt = CheckDBNull(Of Integer)(X("Prnt")),
                                        .PicPath = CheckDBNull(Of String)(X("PicPath")),
                                        .Picture = CheckDBNull(Of Byte())(X("Picture")),
                                        .MeasModeChange = CheckDBNull(Of Integer)(X("MeasModeChange")),
                                        .IOCardEdit = CheckDBNull(Of Integer)(X("IOCardEdit")),
                                        .ShellToDos = CheckDBNull(Of Integer)(X("ShellToDos")),
                                        .EditUsers = CheckDBNull(Of Integer)(X("EditUsers")),
                                        .AdvGGEdit = CheckDBNull(Of Integer)(X("AdvGGEdit")),
                                        .CalEdit = CheckDBNull(Of Integer)(X("CalEdit")),
                                        .AdvRcpEdit = CheckDBNull(Of Integer)(X("AdvRcpEdit")),
                                        .SmartGauge = CheckDBNull(Of Integer)(X("SmartGauge")),
                                        .StorePassword = CheckDBNull(Of Integer)(X("StorePassword"))
             })
        Console.WriteLine()
        Console.WriteLine($"Priv {PrivList?.Count} rows read")

        Console.WriteLine("Readind done.")
    End Sub
End Module
