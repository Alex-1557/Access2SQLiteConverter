Imports System.ComponentModel.DataAnnotations

Public Class CalibData
    <Key>
    Public Property Name As String
    Public Property Source As String
    Public Property SampleTargets As String
    Public Property SampleValues As String
    Public Property Coeffs As String
    Public Property ZeroSample As String
    Public Property NewZeroSample As String
    Public Property InfinitySample As String
    Public Property NewInfinitySample As String
    Public Property Description As String
    Public Property MaxNormPrcnt As Double
    Public Property MinNormPrcnt As Double
    Public Property SampleTime As Long
    Public Property LastRezero As Date

End Class
'Public Overloads Overrides Function ToString() As String
'    Return String.Join("#", New String() {
'                Name,
'                Source,
'                SampleTargets,
'                SampleValues,
'                Coeffs,
'                ZeroSample,
'                NewZeroSample,
'                InfinitySample,
'                NewInfinitySample,
'                Description,
'                MaxNormPrcnt,
'                MinNormPrcnt,
'                SampleTime,
'                LastRezero
'                })
'End Function