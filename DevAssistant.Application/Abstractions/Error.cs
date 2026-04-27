using System;
using System.Collections.Generic;
using System.Text;

namespace DevAssistant.Application.Abstractions
{
    public record Error(string code,string description)
    {
        public static readonly  Error None=new(string.Empty,string.Empty);
    }
}
