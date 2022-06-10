Imports System.ComponentModel.DataAnnotations
Public Class SpcData
    Public Property Name As String
    Public Property RecipeName As String
    Public Property Source As String
    Public Property Interval As Long
    Public Property StatSample As Long
    Public Property CpkHigh As Double
    Public Property CpkLow As Double
    Public Property XbarEnable As Boolean
    Public Property XbarMean As Double
    Public Property XbarUCL As Double
    Public Property XbarLCL As Double
    Public Property RbarEnable As Boolean
    Public Property RbarMean As Double
    Public Property RbarUCL As Double
    Public Property RbarLCL As Double
    Public Property ProdSpecEnable As Boolean
    Public Property ProdSpecUSL As Double
    Public Property ProdSpecLSL As Double
    Public Property ActiveFilterComp As Double

End Class
