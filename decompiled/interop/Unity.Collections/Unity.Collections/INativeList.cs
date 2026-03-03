using System.Reflection;
using Il2CppDummyDll;

namespace Unity.Collections;

[Token(Token = "0x200003F")]
[DefaultMember("Item")]
public interface INativeList<T> : IIndexable<T> where T : struct
{
}
