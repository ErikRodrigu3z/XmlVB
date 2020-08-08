Imports System.Xml

Module Module1

    Sub Main()

        Dim sXml As String = "<Cancelacion xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" RfcEmisor=""MAU071220MR3"" Fecha=""2018-11-09T00:23:25"" xmlns=""http://cancelacfd.sat.gob.mx""><Folios><UUID>5ada40fa-8d2f-4f61-bc80-2c3311af0642 </UUID><UUIDEstatus>202 </UUIDEstatus><UUIDdescripcion>202 - UUID Previamente Cancelado. </UUIDdescripcion><UUIDfecha>2018-11-09T00:00:00 </UUIDfecha></Folios><Signature>no:signature</Signature></Cancelacion>"
        Dim varAttId As String = ""
        Dim uuid As String = ""
        Dim status As String = ""
        Dim descripcion As String = ""

        Dim xmlDoc As XmlDocument
        Dim xmlNodelist As XmlNodeList
        Dim xmlNode As XmlNode
        'Create the XML Document
        xmlDoc = New XmlDocument()
        sXml = sXml.Replace("xmlns:xsd=""http://www.w3.org/2001/XMLSchema""", "")
        sXml = sXml.Replace("xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance""", "")
        sXml = sXml.Replace("xmlns=""http://cancelacfd.sat.gob.mx""", "")

        'Load the Xml file
        xmlDoc.LoadXml(sXml)
        'Get the list of name nodes
        xmlNodelist = xmlDoc.SelectNodes("Cancelacion/Folios") 'UUIDEstatus
        'Loop through the nodes
        For Each xmlNode In xmlNodelist
            'varAttId = xmlNode.Attributes.GetNamedItem("ID").Value
            uuid = xmlNode.ChildNodes.Item(0).InnerText
            status = xmlNode.ChildNodes.Item(1).InnerText
            descripcion = xmlNode.ChildNodes.Item(2).InnerText
        Next


    End Sub

End Module
