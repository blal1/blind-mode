using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000020")]
public readonly struct BindingResult
{
	[Token(Token = "0x17000021")]
	public BindingStatus status
	{
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x8C8B50", Offset = "0x8C7D50", VA = "0x1808C8B50")]
		[CompilerGenerated]
		get
		{
			return default(BindingStatus);
		}
	}

	[Token(Token = "0x17000022")]
	public string message
	{
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x5BF750", Offset = "0x5BE950", VA = "0x1805BF750")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xD59140", Offset = "0xD58340", VA = "0x180D59140")]
	public BindingResult(BindingStatus status, [Optional] string message)
	{
	}
}
