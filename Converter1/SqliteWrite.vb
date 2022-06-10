Imports System.Data.SQLite.Linq
Imports System.Linq

Partial Module Module1
    Public Sub SqliteWrite()
        Console.WriteLine()
        Dim CMD2 As New Data.SQLite.SQLiteCommand(CN2)
        Try
            Console.WriteLine("CalibData writing")
            For I As Integer = 0 To CalibDataList.Count - 1
                CMD2.CommandText = My.Settings.CalibInsert &
                $"('{CalibDataList(I).Name}'," &
                $"'{CalibDataList(I).Source}'," &
                $"'{CalibDataList(I).SampleTargets}'," &
                $"'{CalibDataList(I).SampleValues}'," &
                $"'{CalibDataList(I).Coeffs}'," &
                $"'{CalibDataList(I).ZeroSample}'," &
                $"'{CalibDataList(I).NewZeroSample}'," &
                $"'{CalibDataList(I).InfinitySample}'," &
                $"'{CalibDataList(I).NewInfinitySample}'," &
                $"'{CalibDataList(I).Description}'," &
                $"'{CalibDataList(I).MaxNormPrcnt}'," &
                $"'{CalibDataList(I).MinNormPrcnt}'," &
                $"'{CalibDataList(I).SampleTime}'," &
                $"'{CalibDataList(I).LastRezero}');"
                Dim Ret1 As Integer = CMD2.ExecuteNonQuery
                If (I Mod 10) = 0 Then Console.Write(".")
            Next
            Console.WriteLine("done.")
            '
            Console.WriteLine("CardData writing")
            For I As Integer = 0 To CardDataList.Count - 1
                CMD2.CommandText = My.Settings.CardInsert &
                $"('{CardDataList(I).Name}'," &
                $"'{CardDataList(I).Address}'," &
                $"'{CardDataList(I).CardModel}'," &
                $"'{CardDataList(I).CardSetup}'," &
                $"'{CardDataList(I).MasterCard}');"
                If (I Mod 10) = 0 Then Console.Write(".")
                Dim Ret1 As Integer = CMD2.ExecuteNonQuery
            Next
            Console.WriteLine("done.")
            '
            Console.WriteLine("ControlData writing.")
            For I As Integer = 0 To ControlDataList.Count - 1
                CMD2.CommandText = My.Settings.ControlInsert &
                $"('{ControlDataList(I).RecipeName}'," &
                $"'{ControlDataList(I).CtrlName}'," &
                $"'{ControlDataList(I).CtrlSignal}'," &
                $"'{ControlDataList(I).CtrlNumber}'," &
                $"'{ControlDataList(I).CtrlLogic}'," &
                $"'{ControlDataList(I).Description}'," &
                $"'{ControlDataList(I).CtrlType}'," &
                $"'{ControlDataList(I).DigOutput}'," &
                $"'{ControlDataList(I).GaugeOutput}');"
                If (I Mod 10) = 0 Then Console.Write(".")
                Dim Ret1 As Integer = CMD2.ExecuteNonQuery
            Next
            Console.WriteLine("done.")
            '
            Console.WriteLine("CoreData writing")
            For I As Integer = 0 To CoreDataList.Count - 1
                CMD2.CommandText = My.Settings.CoreInsert &
                $"('{CoreDataList(I).Name}'," &
                $"'{CoreDataList(I).DataType}'," &
                $"'{CoreDataList(I).Initialize}'," &
                $"'{CoreDataList(I).Save}');"
                If (I Mod 10) = 0 Then Console.Write(".")
                Dim Ret1 As Integer = CMD2.ExecuteNonQuery
            Next
            Console.WriteLine("done.")
            '
            Console.WriteLine("GaugeData writing.")
            For I As Integer = 0 To GaugeDataList.Count - 1
                CMD2.CommandText = My.Settings.GaugeInsert &
                $"('{GaugeDataList(I).ID}'," &
                $"'{GaugeDataList(I).GaugeName}'," &
                $"'{GaugeDataList(I).Description}'," &
                $"'{GaugeDataList(I).GaugeType}'," &
                $"'{GaugeDataList(I).IsotopeType}'," &
                $"'{GaugeDataList(I).GaugeOn}'," &
                $"'{GaugeDataList(I).ProfileGauge}'," &
                $"'{GaugeDataList(I).StripWidth}'," &
                $"'{GaugeDataList(I).NomLineSpeed}'," &
                $"'{GaugeDataList(I).ScanSpeed}'," &
                $"'{GaugeDataList(I).ScanMode}'," &
                $"'{GaugeDataList(I).Calibration}'," &
                $"'{GaugeDataList(I).SPC}'," &
                $"'{GaugeDataList(I).RecipeName}'," &
                $"'{GaugeDataList(I).RecipeID}'," &
                $"'{GaugeDataList(I).Multiplier}'," &
                $"'{GaugeDataList(I).Compensation}'," &
                $"'{GaugeDataList(I).Filter}'," &
                $"'{GaugeDataList(I).UpdateRate}'," &
                $"'{GaugeDataList(I).StatLength}'," &
                $"'{GaugeDataList(I).SetPoint}'," &
                $"'{GaugeDataList(I).SigFormat}'," &
                $"'{GaugeDataList(I).WarningEnable}'," &
                $"'{GaugeDataList(I).WarningLow}'," &
                $"'{GaugeDataList(I).WarningHigh}'," &
                $"'{GaugeDataList(I).AlarmEnable}'," &
                $"'{GaugeDataList(I).AlarmLow}'," &
                $"'{GaugeDataList(I).AlarmHigh}'," &
                $"'{GaugeDataList(I).ActiveFilter}'," &
                $"'{GaugeDataList(I).Recording}'," &
                $"'{GaugeDataList(I).ExceptReport}'," &
                $"'{GaugeDataList(I).Reporting}'," &
                $"'{GaugeDataList(I).PrintGraph}'," &
                $"'{GaugeDataList(I).DistModeDivider}'," &
                $"'{GaugeDataList(I).RecordingRate}'," &
                $"'{GaugeDataList(I).Seperation}'," &
                $"'{GaugeDataList(I).StripLength}'," &
                $"'{GaugeDataList(I).AOLow}'," &
                $"'{GaugeDataList(I).AOHigh}'," &
                $"'{GaugeDataList(I).AOLow1}'," &
                $"'{GaugeDataList(I).AOHigh1}'," &
                $"'{GaugeDataList(I).AOLow2}'," &
                $"'{GaugeDataList(I).AOHigh2}'," &
                $"'{GaugeDataList(I).AOLow3}'," &
                $"'{GaugeDataList(I).AOHigh3}'," &
                $"'{GaugeDataList(I).Input1}'," &
                $"'{GaugeDataList(I).Input2}'," &
                $"'{GaugeDataList(I).Input3}'," &
                $"'{GaugeDataList(I).Input4}'," &
                $"'{GaugeDataList(I).Input5}'," &
                $"'{GaugeDataList(I).Input6}'," &
                $"'{GaugeDataList(I).Input7}'," &
                $"'{GaugeDataList(I).Input8}'," &
                $"'{GaugeDataList(I).Input9}'," &
                $"'{GaugeDataList(I).Output1}'," &
                $"'{GaugeDataList(I).Output2}'," &
                $"'{GaugeDataList(I).Output3}'," &
                $"'{GaugeDataList(I).Output4}'," &
                $"'{GaugeDataList(I).Output5}'," &
                $"'{GaugeDataList(I).Output6}'," &
                $"'{GaugeDataList(I).Output7}'," &
                $"'{GaugeDataList(I).Output8}'," &
                $"'{GaugeDataList(I).Output9}'," &
                $"'{GaugeDataList(I).CDPulsePerUnit}'," &
                $"'{GaugeDataList(I).LeftMargin}'," &
                $"'{GaugeDataList(I).LeftTrim}'," &
                $"'{GaugeDataList(I).RightTrim}'," &
                $"'{GaugeDataList(I).RightMargin}'," &
                $"'{GaugeDataList(I).FixedPosition}'," &
                $"'{GaugeDataList(I).NumOfSteps}'," &
                $"'{GaugeDataList(I).TravSpeed}'," &
                $"'{GaugeDataList(I).RetSpeed}'," &
                $"'{GaugeDataList(I).MotorNumber}'," &
                $"'{GaugeDataList(I).CDOffset}'," &
                $"'{GaugeDataList(I).K_Prop}'," &
                $"'{GaugeDataList(I).K_Integr}'," &
                $"'{GaugeDataList(I).K_Deriv}'," &
                $"'{GaugeDataList(I).FFMaxLineSpeed}'," &
                $"'{GaugeDataList(I).FFMinLineSpeed}'," &
                $"'{GaugeDataList(I).MAFilterN}'," &
                $"'{GaugeDataList(I).LimitPlus}'," &
                $"'{GaugeDataList(I).LimitMinus}'," &
                $"'{GaugeDataList(I).ZoningEnable}'," &
                $"'{GaugeDataList(I).ZoneABeg}'," &
                $"'{GaugeDataList(I).ZoneAEnd}'," &
                $"'{GaugeDataList(I).ZoneBBeg}'," &
                $"'{GaugeDataList(I).ZoneBEnd}'," &
                $"'{GaugeDataList(I).Zone1Beg}'," &
                $"'{GaugeDataList(I).Zone1End}'," &
                $"'{GaugeDataList(I).Zone2Beg}'," &
                $"'{GaugeDataList(I).Zone2End}'," &
                $"'{GaugeDataList(I).Zone3Beg}'," &
                $"'{GaugeDataList(I).Zone3End}'," &
                $"'{GaugeDataList(I).Zone4Beg}'," &
                $"'{GaugeDataList(I).Zone4End}'," &
                $"'{GaugeDataList(I).Zone5Beg}'," &
                $"'{GaugeDataList(I).Zone5End}'," &
                $"'{GaugeDataList(I).Zone6Beg}'," &
                $"'{GaugeDataList(I).Zone6End}'," &
                $"'{GaugeDataList(I).Zone7Beg}'," &
                $"'{GaugeDataList(I).Zone7End}'," &
                $"'{GaugeDataList(I).Zone8Beg}'," &
                $"'{GaugeDataList(I).Zone8End}'," &
                $"'{GaugeDataList(I).Zone9Beg}'," &
                $"'{GaugeDataList(I).Zone9End}'," &
                $"'{GaugeDataList(I).Zone10Beg}'," &
                $"'{GaugeDataList(I).Zone10End}'," &
                $"'{GaugeDataList(I).Zone11Beg}'," &
                $"'{GaugeDataList(I).Zone11End}'," &
                $"'{GaugeDataList(I).Zone12Beg}'," &
                $"'{GaugeDataList(I).Zone12End}'," &
                $"'{GaugeDataList(I).DIO1}'," &
                $"'{GaugeDataList(I).DIO2}'," &
                $"'{GaugeDataList(I).DIO3}'," &
                $"'{GaugeDataList(I).DIO4}'," &
                $"'{GaugeDataList(I).DIO5}'," &
                $"'{GaugeDataList(I).DIO6}'," &
                $"'{GaugeDataList(I).DIO7}'," &
                $"'{GaugeDataList(I).DIO8}'," &
                $"'{GaugeDataList(I).DIO9}'," &
                $"'{GaugeDataList(I).DIO10}'," &
                $"'{GaugeDataList(I).DIO11}'," &
                $"'{GaugeDataList(I).DIO12}'," &
                $"'{GaugeDataList(I).RecordIfWarnLow}'," &
                $"'{GaugeDataList(I).CountsCorrOn}');"
                If (I Mod 10) = 0 Then Console.Write(".")
                Dim Ret1 As Integer = CMD2.ExecuteNonQuery
            Next
            Console.WriteLine("done.")
            '
            Console.WriteLine("done.")
            For I As Integer = 0 To RecipeDataList.Count - 1
                CMD2.CommandText = My.Settings.RecipeInsert &
                $"('{RecipeDataList(I).ID}'," &
                $"'{RecipeDataList(I).Name}'," &
                $"'{RecipeDataList(I).GaugeName}'," &
                $"'{RecipeDataList(I).RecipeName}'," &
                $"'{RecipeDataList(I).Description}');"
                If (I Mod 10) = 0 Then Console.Write(".")
                Dim Ret1 As Integer = CMD2.ExecuteNonQuery
            Next
            Console.WriteLine("done.")
            '
            Console.WriteLine("SignalData writing.")
            For I As Integer = 0 To SignalDataList.Count - 1
                CMD2.CommandText = My.Settings.SignalInsert &
                $"('{SignalDataList(I).SignalDelay}'," &
                $"'{SignalDataList(I).RecipeName}'," &
                $"'{SignalDataList(I).SignalName}'," &
                $"'{SignalDataList(I).SignalNumber}'," &
                $"'{SignalDataList(I).SignalLogic}'," &
                $"'{SignalDataList(I).InputType0}','{SignalDataList(I).InputName0}','{SignalDataList(I).InputLogic0}'," &
                $"'{SignalDataList(I).InputType1}','{SignalDataList(I).InputName1}','{SignalDataList(I).InputLogic1}'," &
                $"'{SignalDataList(I).InputType2}','{SignalDataList(I).InputName2}','{SignalDataList(I).InputLogic2}'," &
                $"'{SignalDataList(I).InputType3}','{SignalDataList(I).InputName3}','{SignalDataList(I).InputLogic3}'," &
                $"'{SignalDataList(I).InputType4}','{SignalDataList(I).InputName4}','{SignalDataList(I).InputLogic4}'," &
                $"'{SignalDataList(I).InputType5}','{SignalDataList(I).InputName5}','{SignalDataList(I).InputLogic5}'," &
                $"'{SignalDataList(I).InputType6}','{SignalDataList(I).InputName6}','{SignalDataList(I).InputLogic6}'," &
                $"'{SignalDataList(I).InputType7}','{SignalDataList(I).InputName7}','{SignalDataList(I).InputLogic7}');"
                If (I Mod 10) = 0 Then Console.Write(".")
                Dim Ret1 As Integer = CMD2.ExecuteNonQuery
            Next
            Console.WriteLine("done.")
            '
            Console.WriteLine("SpcData writing.")
            For I As Integer = 0 To SpcDataList.Count - 1
                CMD2.CommandText = My.Settings.SpcInsert &
                $"('{SpcDataList(I).Name}'," &
                $"'{SpcDataList(I).RecipeName}'," &
                $"'{SpcDataList(I).Source}'," &
                $"'{SpcDataList(I).Interval}'," &
                $"'{SpcDataList(I).StatSample}'," &
                $"'{SpcDataList(I).CpkHigh}'," &
                $"'{SpcDataList(I).CpkLow}'," &
                $"'{SpcDataList(I).XbarEnable}'," &
                $"'{SpcDataList(I).XbarMean}'," &
                $"'{SpcDataList(I).XbarUCL}'," &
                $"'{SpcDataList(I).XbarLCL}'," &
                $"'{SpcDataList(I).RbarEnable}'," &
                $"'{SpcDataList(I).RbarMean}'," &
                $"'{SpcDataList(I).RbarUCL}'," &
                $"'{SpcDataList(I).RbarLCL}'," &
                $"'{SpcDataList(I).ProdSpecEnable}'," &
                $"'{SpcDataList(I).ProdSpecUSL}'," &
                $"'{SpcDataList(I).ProdSpecLSL}'," &
                $"'{SpcDataList(I).ActiveFilterComp}');"
                If (I Mod 10) = 0 Then Console.Write(".")
                Dim Ret1 As Integer = CMD2.ExecuteNonQuery
            Next
            Console.WriteLine("done.")
            '
            Console.WriteLine("ViewData writing.")
            For I As Integer = 0 To ViewDataList.Count - 1
                CMD2.CommandText = My.Settings.ViewInsert &
                $"('{ViewDataList(I).RecipeName}'," &
                $"'{ViewDataList(I).GraphCaption}'," &
                $"'{ViewDataList(I).Style}'," &
                $"'{ViewDataList(I).WinNo}'," &
                $"'{ViewDataList(I).GaugeName}'," &
                $"'{ViewDataList(I).SetPoint}'," &
                $"'{ViewDataList(I).BackColor}'," &
                $"'{ViewDataList(I).BorderColor}'," &
                $"'{ViewDataList(I).Left}'," &
                $"'{ViewDataList(I).Top}'," &
                $"'{ViewDataList(I).Width}'," &
                $"'{ViewDataList(I).Height}'," &
                $"'{ViewDataList(I).GphRng}'," &
                $"'{ViewDataList(I).GphRngInc}'," &
                $"'{ViewDataList(I).SetPtInc}'," &
                $"'{ViewDataList(I).DataPnts}'," &
                $"'{ViewDataList(I).DataColorOn}'," &
                $"'{ViewDataList(I).DataType}'," &
                $"'{ViewDataList(I).DataColor}'," &
                $"'{ViewDataList(I).AlarmColor}'," &
                $"'{ViewDataList(I).WarningColor}'," &
                $"'{ViewDataList(I).NormalColor}'," &
                $"'{ViewDataList(I).LineWidth}'," &
                $"'{ViewDataList(I).FontSize}'," &
                $"'{ViewDataList(I).ShowAlarmLine}'," &
                $"'{ViewDataList(I).ShowWarnLine}'," &
                $"'{ViewDataList(I).Xunits}'," &
                $"'{ViewDataList(I).Yunits}'," &
                $"'{ViewDataList(I).ProfileStyle}'," &
                $"'{ViewDataList(I).LastNAveraged}'," &
                $"'{ViewDataList(I).Profile}');"
                If (I Mod 10) = 0 Then Console.Write(".")
                Dim Ret1 As Integer = CMD2.ExecuteNonQuery
            Next
            Console.WriteLine("done.")
            '
            Console.WriteLine("Priv writing.")
            For I As Integer = 0 To PrivList.Count - 1
                CMD2.CommandText = My.Settings.PrivInsert &
                $"('{PrivList(I).LastName}'," &
                $"'{PrivList(I).FirstName}'," &
                $"'{PrivList(I).UserName}'," &
                $"'{PrivList(I).PassWord}'," &
                $"'{PrivList(I).ChangeModes}'," &
                $"'{PrivList(I).RcpEdit}'," &
                $"'{PrivList(I).ggEdit}'," &
                $"'{PrivList(I).gphChange}'," &
                $"'{PrivList(I).ExitApp}'," &
                $"'{PrivList(I).StartApp}'," &
                $"'{PrivList(I).Calib}'," &
                $"'{PrivList(I).PCTimeMod}'," &
                $"'{PrivList(I).Prnt}'," &
                $"'{PrivList(I).PicPath}'," &
                $"'{PrivList(I).Picture}'," &
                $"'{PrivList(I).MeasModeChange}'," &
                $"'{PrivList(I).IOCardEdit}'," &
                $"'{PrivList(I).ShellToDos}'," &
                $"'{PrivList(I).EditUsers}'," &
                $"'{PrivList(I).AdvGGEdit}'," &
                $"'{PrivList(I).CalEdit}'," &
                $"'{PrivList(I).AdvRcpEdit}'," &
                $"'{PrivList(I).SmartGauge}'," &
                $"'{PrivList(I).StorePassword}');"
                If (I Mod 10) = 0 Then Console.Write(".")
                Dim Ret1 As Integer = CMD2.ExecuteNonQuery
            Next
            Console.WriteLine("done.")
        Catch ex As Exception
            Console.WriteLine(ex.Message & vbCrLf & CMD2.CommandText)
            Console.ReadLine()
        End Try

        Console.WriteLine("All done.")
        Console.ReadLine()
    End Sub
End Module
