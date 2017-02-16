using System.Xml.Serialization;

namespace ChargifyNET
{
    public class PayPalAttributes : PaymentProfileBase
    {
        [XmlElement("paypal_email")]
        public string PayPalEmail { get; set; }
        public bool ShouldSerializePayPalEmail()
        {
            return !string.IsNullOrEmpty(PayPalEmail);
        }

        [XmlElement("payment_method_nonce")]
        public string PaymentMethodNonce { get; set; }
        public bool ShouldSerializePaymentMethodNonce()
        {
            return !string.IsNullOrEmpty(PaymentMethodNonce);
        }
    }
}
