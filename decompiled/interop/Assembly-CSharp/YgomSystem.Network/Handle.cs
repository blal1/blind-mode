using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x2000278")]
public class Handle
{
	[Token(Token = "0x4000E0D")]
	[FieldOffset(Offset = "0x10")]
	private NetworkMain.RequestStructure m_Request;

	[Token(Token = "0x6000ED2")]
	[Address(RVA = "0x438FD0", Offset = "0x4381D0", VA = "0x180438FD0")]
	public Handle(NetworkMain.RequestStructure request)
	{
	}

	[Token(Token = "0x6000ED3")]
	[Address(RVA = "0xE6F000", Offset = "0xE6E200", VA = "0x180E6F000")]
	public Handle AddCompleteEvent(EventHandler e)
	{
		return null;
	}

	[Token(Token = "0x6000ED4")]
	[Address(RVA = "0xE6F0C0", Offset = "0xE6E2C0", VA = "0x180E6F0C0")]
	public Handle AddErrorEvent(EventHandler e)
	{
		return null;
	}

	[Token(Token = "0x6000ED5")]
	[Address(RVA = "0xE6F1E0", Offset = "0xE6E3E0", VA = "0x180E6F1E0")]
	public void ClearAllEvent()
	{
	}

	[Token(Token = "0x6000ED6")]
	[Address(RVA = "0xE6F180", Offset = "0xE6E380", VA = "0x180E6F180")]
	public Handle Chain(Handle hdl)
	{
		return null;
	}

	[Token(Token = "0x6000ED7")]
	[Address(RVA = "0xE6F370", Offset = "0xE6E570", VA = "0x180E6F370")]
	public bool Retry()
	{
		return default(bool);
	}

	[Token(Token = "0x6000ED8")]
	[Address(RVA = "0xE6F2C0", Offset = "0xE6E4C0", VA = "0x180E6F2C0")]
	public bool IsCompleted()
	{
		return default(bool);
	}

	[Token(Token = "0x6000ED9")]
	[Address(RVA = "0xE6F2F0", Offset = "0xE6E4F0", VA = "0x180E6F2F0")]
	public bool IsError()
	{
		return default(bool);
	}

	[Token(Token = "0x6000EDA")]
	[Address(RVA = "0xE6F320", Offset = "0xE6E520", VA = "0x180E6F320")]
	public bool IsFatal()
	{
		return default(bool);
	}

	[Token(Token = "0x6000EDB")]
	[Address(RVA = "0xE6F340", Offset = "0xE6E540", VA = "0x180E6F340")]
	public bool IsLongPolling()
	{
		return default(bool);
	}

	[Token(Token = "0x6000EDC")]
	[Address(RVA = "0xE6F280", Offset = "0xE6E480", VA = "0x180E6F280")]
	public int GetCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000EDD")]
	[Address(RVA = "0xE6F240", Offset = "0xE6E440", VA = "0x180E6F240")]
	public void Finish()
	{
	}

	[Token(Token = "0x6000EDE")]
	[Address(RVA = "0x534450", Offset = "0x533650", VA = "0x180534450")]
	public string GetCommand()
	{
		return null;
	}

	[Token(Token = "0x6000EDF")]
	[Address(RVA = "0x534350", Offset = "0x533550", VA = "0x180534350")]
	public Dictionary<string, object> GetParam()
	{
		return null;
	}

	[Token(Token = "0x6000EE0")]
	[Address(RVA = "0xE6F2A0", Offset = "0xE6E4A0", VA = "0x180E6F2A0")]
	public int GetId()
	{
		return default(int);
	}

	[Token(Token = "0x6000EE1")]
	[Address(RVA = "0xE6EFE0", Offset = "0xE6E1E0", VA = "0x180E6EFE0")]
	public void Abort()
	{
	}
}
