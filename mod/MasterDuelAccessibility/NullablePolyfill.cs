// Polyfill requis pour les annotations nullable (?) quand on référence
// les DLLs interop IL2CPP (Il2Cppmscorlib ne contient pas NullableAttribute).
// Ce fichier ne génère aucune logique — il est uniquement là pour que le
// compilateur C# accepte <Nullable>enable</Nullable>.

namespace System.Runtime.CompilerServices
{
    internal sealed class NullableAttribute : Attribute
    {
        public NullableAttribute(byte _) { }
        public NullableAttribute(byte[] _) { }
    }

    internal sealed class NullableContextAttribute : Attribute
    {
        public NullableContextAttribute(byte _) { }
    }
}
