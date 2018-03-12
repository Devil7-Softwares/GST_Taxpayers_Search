Imports System.Net
Imports HtmlAgilityPack
Public Module GST_Taxpayer
    Public Function SearchTaxpayer(ByVal GSTIN As String) As SearchResult
        Dim GSTIN_ As String = ""
        Dim TaxPayerName_ As String = ""
        Dim StateJurisdiction_ As String = ""
        Dim CentreJurisdiction_ As String = ""
        Dim Date_of_Registration_ As Date = Nothing
        Dim Constitution_of_Business_ As String = ""
        Dim TaxpayerType_ As String = ""
        Dim GSTN_status As String = ""
        Dim Cancelled_ As Boolean = False
        Dim CancellationDate_ As Date = Nothing

        Dim HTML As String = New WebClient().DownloadString(String.Format("https://www.mastersindia.co/gst-number-search-and-gstin-verification/?keyword={0}", GSTIN))
        Dim HTML_DOM As New HtmlAgilityPack.HtmlDocument
        HTML_DOM.LoadHtml(HTML)

        If HTML_DOM.ParsedText.Contains("The GSTIN passed in the request is invalid.") Then
            Return New SearchResult(Result.NotFound, Nothing)
        End If

        Dim Index As Integer = 0
        For Each i As HtmlAgilityPack.HtmlNode In HTML_DOM.DocumentNode.ChildNodes.Descendants("tr")
            If i.InnerText.Contains(GSTIN) Then
                For Each c As HtmlAgilityPack.HtmlNode In i.ChildNodes
                    If c.Name = "td" Then
                        Select Case Index
                            Case 0
                                GSTIN_ = c.InnerText
                            Case 1
                                TaxPayerName_ = c.InnerText
                            Case 2
                                StateJurisdiction_ = c.InnerText
                            Case 3
                                CentreJurisdiction_ = c.InnerText
                            Case 4
                                Date_of_Registration_ = Date.Parse(c.InnerText)
                            Case 5
                                Constitution_of_Business_ = c.InnerText
                            Case 6
                                TaxpayerType_ = c.InnerText
                            Case 7
                                GSTN_status = c.InnerText
                            Case 8
                                If c.InnerText.Trim = "" Then
                                    Cancelled_ = False
                                    CancellationDate_ = Nothing
                                End If
                        End Select
                        Index += 1
                    End If
                Next
            End If
        Next
        Return New SearchResult(Result.Found, New TaxPayer(GSTIN_, TaxPayerName_, StateJurisdiction_, CentreJurisdiction_, Date_of_Registration_, Constitution_of_Business_, TaxpayerType_, GSTN_status, Cancelled_, CancellationDate_))
    End Function
End Module
Public Class SearchResult
    Dim Result_ As Result = Result.NotFound
    Sub New(ByVal Result As Result, ByVal TaxPayer As TaxPayer)
        Me.TaxPayer_ = TaxPayer
        Me.Result_ = Result
    End Sub
    ReadOnly Property Result As Result
        Get
            Return Result_
        End Get
    End Property
    Dim TaxPayer_ As TaxPayer = Nothing
    ReadOnly Property TaxPayer As TaxPayer
        Get
            Return TaxPayer_
        End Get
    End Property
End Class
Public Enum Result As Integer
    Found = 0
    NotFound = -1
End Enum
Public Class TaxPayer
    Dim GSTIN_ As String
    Dim TaxPayerName_ As String
    Dim StateJurisdiction_ As String
    Dim CentreJurisdiction_ As String
    Dim Date_of_Registration_ As Date
    Dim Constitution_of_Business_ As String
    Dim TaxpayerType_ As String
    Dim GSTN_status As String
    Dim Cancelled_ As Boolean = False
    Dim CancellationDate_ As Date
    Sub New(ByVal GSTIN_ As String, ByVal TaxPayerName_ As String, ByVal StateJurisdiction_ As String, ByVal CentreJurisdiction_ As String, ByVal Date_of_Registration_ As Date, ByVal Constitution_of_Business_ As String, ByVal TaxpayerType_ As String, ByVal GSTN_status As String, Optional ByVal Cancelled_ As Boolean = False, Optional ByVal CancellationDate_ As Date = Nothing)
        Me.GSTIN_ = GSTIN_
        Me.TaxPayerName_ = TaxPayerName_
        Me.StateJurisdiction_ = StateJurisdiction_
        Me.CentreJurisdiction_ = CentreJurisdiction_
        Me.Date_of_Registration_ = Date_of_Registration_
        Me.Constitution_of_Business_ = Constitution_of_Business_
        Me.TaxpayerType_ = TaxpayerType_
        Me.GSTN_status = GSTN_status
        Me.Cancelled_ = Cancelled_
        Me.CancellationDate_ = CancellationDate_
    End Sub
    ReadOnly Property GSTIN As String
        Get
            Return GSTIN_
        End Get
    End Property
    ReadOnly Property TaxPayerName As String
        Get
            Return TaxPayerName_
        End Get
    End Property
    ReadOnly Property StateJurisdiction As String
        Get
            Return StateJurisdiction_
        End Get
    End Property
    ReadOnly Property CentreJurisdiction As String
        Get
            Return CentreJurisdiction_
        End Get
    End Property
    ReadOnly Property DateOfRegistration As Date
        Get
            Return Date_of_Registration_
        End Get
    End Property
    ReadOnly Property ConstitutionOfBusiness As String
        Get
            Return Constitution_of_Business_
        End Get
    End Property
    ReadOnly Property TaxpayerType As String
        Get
            Return TaxpayerType_
        End Get
    End Property
    ReadOnly Property Status As String
        Get
            Return GSTN_status
        End Get
    End Property
    ReadOnly Property Cancelled As Boolean
        Get
            Return Cancelled_
        End Get
    End Property
    ReadOnly Property CancellationDate As String
        Get
            Return CancellationDate_
        End Get
    End Property
End Class