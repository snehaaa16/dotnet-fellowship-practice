using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Scenrio_Based_Review
{
    public class ErrorNode
    {
        public string Errors;
        public ErrorNode Next;

        public ErrorNode(string errors)
        {
            this.Errors = errors;
        }
    }
}
