Imports System
Imports System.Xml

Public Class Form1
    Dim xmlDoc As New XmlDocument()
    Dim xmlNodeList As XmlNodeList
    Dim xmlNode As XmlNode

    Dim sicil As String
    Dim ad As String
    Dim gorev As String
    Dim ucret As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            xmlDoc.Load("isciler.xml")
            xmlNodeList = xmlDoc.GetElementsByTagName("isci")

            For Each xmlNode In xmlNodeList
                sicil = xmlNode.Attributes("sicil").Value
                ad = xmlNode("ad").FirstChild.Value
                gorev = xmlNode("gorev").FirstChild.Value
                ucret = xmlNode("ucret").FirstChild.Value

                ListBox1.Items.Add("İşçi Sicil: " & sicil)
                ListBox1.Items.Add("Ad: " & ad)
                ListBox1.Items.Add("Görev: " & gorev)
                ListBox1.Items.Add("Ücret: " & ucret)
                ListBox1.Items.Add("-")
            Next
        Catch ex As Exception
            MsgBox("Veri Okurken Hata: " & ex.Message)
        End Try
    End Sub
End Class
