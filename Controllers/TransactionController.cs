using DOT_NET_CORE_SECURE_DATA.Model;
using DOT_NET_CORE_SECURE_DATA.RSA;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DOT_NET_CORE_SECURE_DATA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly IRsaHelper _rsaHelper;
        public TransactionController(IRsaHelper rsaHelper)
        {
            _rsaHelper = rsaHelper;
        }

        [HttpPost]
        public UserTransactionResponseModel Post([FromBody] UserTransactionModel user)
        {
            var response = new UserTransactionResponseModel();
            try
            {
                var decryptCurrencyCode = _rsaHelper.Decrypt(user.CurrencyCode);
                var decryptSystemTraceNr = _rsaHelper.Decrypt(user.SystemTraceNr);
                var decryptFunctionCode = _rsaHelper.Decrypt(user.FunctionCode);
                var decryptCardNo = _rsaHelper.Decrypt(user.CardNo);
                var decryptCardHolder = _rsaHelper.Decrypt(user.CardHolder);
                var decryptAmountTrxn = _rsaHelper.Decrypt(user.AmountTrxn);

                var CurrencyCode = _rsaHelper.Decrypt(user.CurrencyCode);
                response.ResponseCode = "00";
                response.Message = "Success";
                response.ApprovalCode = "123123";
                response.DateTime = DateTime.Now.ToString();
                response.ServerRequestFromUI = user;
            }
            catch (Exception ex)
            {

            }
            return response;
        }
    }


}
