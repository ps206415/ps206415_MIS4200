using System;

namespace ps206415_MIS4200.Models
{
    internal class ReqularExpressionsAttribute : Attribute
    {
        private string v;
        private string errorMessage;

        public ReqularExpressionsAttribute(string v, string ErrorMessage)
        {
            this.v = v;
            errorMessage = ErrorMessage;
        }
    }
}