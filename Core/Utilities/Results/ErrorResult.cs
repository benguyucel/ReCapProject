using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorResult:Result
    {
        public ErrorResult(string msg):base(false,msg)
        {

        }
        public ErrorResult():base(true)
        {

        }
    }
}
