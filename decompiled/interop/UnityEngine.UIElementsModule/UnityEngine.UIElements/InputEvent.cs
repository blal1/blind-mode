using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20001E7")]
public class InputEvent : EventBase<InputEvent>
{
	[Token(Token = "0x1700026A")]
	protected string previousData
	{
		[Token(Token = "0x6000DC7")]
		[Address(RVA = "0x49C1F0", Offset = "0x49B3F0", VA = "0x18049C1F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700026B")]
	protected string newData
	{
		[Token(Token = "0x6000DC8")]
		[Address(RVA = "0x3D77E0", Offset = "0x3D69E0", VA = "0x1803D77E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6000DC6")]
	[Address(RVA = "0x2B175D0", Offset = "0x2B167D0", VA = "0x182B175D0")]
	static InputEvent()
	{
	}

	[Token(Token = "0x6000DC9")]
	[Address(RVA = "0x2B17520", Offset = "0x2B16720", VA = "0x182B17520", Slot = "13")]
	protected override void Init()
	{
	}

	[Token(Token = "0x6000DCA")]
	[Address(RVA = "0x2B17590", Offset = "0x2B16790", VA = "0x182B17590")]
	private void LocalInit()
	{
	}

	[Token(Token = "0x6000DCB")]
	[Address(RVA = "0x2B17480", Offset = "0x2B16680", VA = "0x182B17480")]
	public static InputEvent GetPooled(string previousData, string newData)
	{
		return null;
	}

	[Token(Token = "0x6000DCC")]
	[Address(RVA = "0x2B176B0", Offset = "0x2B168B0", VA = "0x182B176B0")]
	public InputEvent()
	{
	}
}
