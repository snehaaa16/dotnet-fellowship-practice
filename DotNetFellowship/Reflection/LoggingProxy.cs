using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Reflection
{
    public class LoggingProxy<T> : DispatchProxy
    {
        private T target;

        public void SetTarget(T target)
        {
            this.target = target;
        }

        protected override object Invoke(
            MethodInfo targetMethod,
            object[] args)
        {
            Console.WriteLine("Calling: " + targetMethod.Name);

            return targetMethod.Invoke(target, args);
        }
    }
}
