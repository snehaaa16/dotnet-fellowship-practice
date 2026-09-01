using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Reflection
{
    public class DIContainer
    {
        public T Create<T>()
        {
            Type type = typeof(T);

            ConstructorInfo constructor =
                type.GetConstructors()[0];

            ParameterInfo[] parameters =
                constructor.GetParameters();

            object[] dependencies = new object[parameters.Length];

            for (int i = 0; i < parameters.Length; i++)
            {
                Type dependencyType = parameters[i].ParameterType;

                if (dependencyType == typeof(ILogger))
                {
                    dependencies[i] = new Logger();
                }
            }

            return (T)constructor.Invoke(dependencies);
        }
    }
}
