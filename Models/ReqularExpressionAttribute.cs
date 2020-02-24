using System;

namespace ps206415_MIS4200.Models
{
    internal class ReqularExpressionAttribute : Attribute
    {
        private string v;

        public ReqularExpressionAttribute(string v, string ErrorMessage)
        {
            this.v = v;
            this.ErrorMessage = ErrorMessage;
        }

        public string ErrorMessage { get; set; }
    }
}