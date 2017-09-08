using System.Xml.Serialization;

namespace ChargifyNET
{
    public class DeviceData : ChargifyBase
    {
        [XmlElement("device_session_id")]
        public string DeviceSessionId { get; set; }

        [XmlElement("fraud_merchant_id")]
        public string FraudMerchantId { get; set; }
    }
}
