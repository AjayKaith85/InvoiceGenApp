namespace InvoiceGenApp.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DueDate { get; set; }
        public decimal TotalAmount { get; set; }
        public List<InvoiceItem> Items { get; set; }
    }

    public class InvoiceDetail
    {

        public int Id { get; set; }
        public string TransactionId { get; set; }
        public string ClientName { get; set; }
        public string ClientEmail { get; set; }
        public string BillingAddress { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal DueAmount { get; set; }
        public string PaymentStatus { get; set; }
        public string PaymentReferenceNo { get; set; } //not in use for now
        public DateTime InvoiceDate { get; set; }
        public DateTime DueDate { get; set; }

        public decimal DiscountPercent { get; set; } //Not in Use for now
        public decimal VatPercent { get; set; } //Not in use for now

        public string Country { get; set; }
        public string Currency { get; set; }
        public List<InvoiceItem> Items { get; set; }

    }

}
