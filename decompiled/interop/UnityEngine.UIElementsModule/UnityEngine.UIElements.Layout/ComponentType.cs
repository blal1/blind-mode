using Il2CppDummyDll;

namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x200059B")]
internal struct ComponentType
{
	[Token(Token = "0x400140D")]
	[FieldOffset(Offset = "0x0")]
	public int Size;

	[Token(Token = "0x600278D")]
	public static ComponentType Create<T>() where T : struct
	{
		return default(ComponentType);
	}
}
