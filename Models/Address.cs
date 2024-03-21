using System.Text;

namespace InvoiceGenApp.Models
{
    public class Address
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }

        public string MergedAddress()
        {
            var sb = new StringBuilder(AddressLine1);

            AppendIfNotNull(sb, ", ", AddressLine2);
            AppendIfNotNull(sb, ", ", City);
            AppendIfNotNull(sb, ", ", State);
            AppendIfNotNull(sb, ", ", Country);

            if (!string.IsNullOrWhiteSpace(ZipCode))
            {
                sb.Append(" ").Append(ZipCode);
            }

            return sb.ToString();
        }
        private static void AppendIfNotNull(StringBuilder sb, string separator, string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                sb.Append(separator).Append(value);
            }
        }


    }
}
