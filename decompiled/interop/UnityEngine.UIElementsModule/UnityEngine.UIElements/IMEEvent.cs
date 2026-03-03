using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20001E5")]
[EventCategory(EventCategory.Keyboard)]
internal class IMEEvent : EventBase<IMEEvent>
{
	[Token(Token = "0x17000269")]
	protected string compositionString
	{
		[Token(Token = "0x6000DBD")]
		[Address(RVA = "0x49C1F0", Offset = "0x49B3F0", VA = "0x18049C1F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6000DBE")]
	[Address(RVA = "0x2B17320", Offset = "0x2B16520", VA = "0x182B17320")]
	static IMEEvent()
	{
	}

	[Token(Token = "0x6000DBF")]
	[Address(RVA = "0x2B17210", Offset = "0x2B16410", VA = "0x182B17210")]
	public static IMEEvent GetPooled(string compositionString)
	{
		return null;
	}

	[Token(Token = "0x6000DC0")]
	[Address(RVA = "0x2B172A0", Offset = "0x2B164A0", VA = "0x182B172A0", Slot = "13")]
	protected override void Init()
	{
	}

	[Token(Token = "0x6000DC1")]
	[Address(RVA = "0x2B17300", Offset = "0x2B16500", VA = "0x182B17300")]
	private void LocalInit()
	{
	}

	[Token(Token = "0x6000DC2")]
	[Address(RVA = "0x2B17400", Offset = "0x2B16600", VA = "0x182B17400")]
	public IMEEvent()
	{
	}
}
