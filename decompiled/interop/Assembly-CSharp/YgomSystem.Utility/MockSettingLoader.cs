using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace YgomSystem.Utility;

[Token(Token = "0x20003EF")]
public class MockSettingLoader
{
	[Token(Token = "0x40013AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private MockSetting setting;

	[Token(Token = "0x40013AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<string, Mock> mocks;

	[Token(Token = "0x6001937")]
	[Address(RVA = "0x5D1080", Offset = "0x5D0280", VA = "0x1805D1080")]
	public static MockSettingLoader load([Optional] SelectEnvSetting envSetting)
	{
		return null;
	}

	[Token(Token = "0x6001938")]
	[Address(RVA = "0x5D0D80", Offset = "0x5CFF80", VA = "0x1805D0D80")]
	private MockSettingLoader(MockSetting setting)
	{
	}

	[Token(Token = "0x6001939")]
	[Address(RVA = "0x5D0ED0", Offset = "0x5D00D0", VA = "0x1805D0ED0")]
	public (bool, string) getBtnAttr(RuntimeEnvironment.ServerType serverType)
	{
		return default((bool, string));
	}

	[Token(Token = "0x600193A")]
	[Address(RVA = "0x5D0FB0", Offset = "0x5D01B0", VA = "0x1805D0FB0")]
	public (string, string) getUrl(RuntimeEnvironment.ServerType serverType)
	{
		return default((string, string));
	}
}
