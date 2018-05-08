namespace AuthenticationApplication.Framework
{
    using System;
    public class DuplicatePrimaryKeyException : Exception
    {
        public DuplicatePrimaryKeyException():base("Email id already exists")
        {
        }
    }
}
