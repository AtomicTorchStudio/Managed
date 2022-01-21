namespace Noesis
{
    using System;

    public static class ExternalTypeHelper
    {
        public static CheckDelegate CheckTypeCanContainDependencyProperties { get; private set; }

        public static void Setup(CheckDelegate func)
        {
            CheckTypeCanContainDependencyProperties = func;
        }

        public delegate bool CheckDelegate(Type type);
    }
}