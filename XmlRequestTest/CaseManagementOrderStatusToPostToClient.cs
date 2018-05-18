using System.Xml.Serialization;

namespace XmlRequestTest
{
    [XmlRoot(ElementName = "CaseManagementOrderStatusToPostToClient")]
    public class CaseManagementOrderStatusToPostToClient
    {
        [XmlElement(ElementName = "Notes")]
        public string Notes { get; set; }
        [XmlElement(ElementName = "AntiFraudTransactionId")]
        public string AntiFraudTransactionId { get; set; }
        [XmlElement(ElementName = "MerchantReferenceNumber")]
        public string MerchantReferenceNumber { get; set; }
        [XmlElement(ElementName = "OriginalDecision")]
        public string OriginalDecision { get; set; }
        [XmlElement(ElementName = "NewDecision")]
        public string NewDecision { get; set; }
        [XmlElement(ElementName = "Reviewer")]
        public string Reviewer { get; set; }
        [XmlElement(ElementName = "ReviewerComments")]
        public string ReviewerComments { get; set; }
        [XmlElement(ElementName = "Queue")]
        public string Queue { get; set; }
        [XmlElement(ElementName = "Profile")]
        public string Profile { get; set; }
        [XmlAttribute(AttributeName = "xsd", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsd { get; set; }
        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi { get; set; }
    }
}
