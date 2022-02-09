namespace DOT_NET_CORE_SECURE_DATA.Model
{
    public class UserTransactionResponseModel
    {
        public UserTransactionModel ServerRequestFromUI { get; set; }
        public string ResponseCode { get; set; }
        public string Message { get; set; }
        public string ApprovalCode { get; set; }
        public string DateTime { get; set; }
    }
}
