using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Core
{
    static class Utils
    {
        public static bool isValidInput(string input)
        {
            return (string.IsNullOrEmpty(input) ? false : true);
        }
    }
}
