using System;
using System.Collections.Generic;
using System.Text;

namespace Factorial.Core.Services
{
    public interface IFactorialService
    {
        double GetFactorial(int n);
    }
}
