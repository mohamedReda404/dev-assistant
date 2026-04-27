using DevAssistant.Application.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevAssistant.Application.Errors
{
    public static class UsersErrors
    {
        public static  Error InvlidEmailAndPassword=>
            new ("User.InvlidEmailAndPassword", "InvlidEmai/Password");
    }
}
