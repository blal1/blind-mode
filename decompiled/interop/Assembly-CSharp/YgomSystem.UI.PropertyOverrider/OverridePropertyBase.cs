using System;
using Il2CppDummyDll;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider;

[Serializable]
[Token(Token = "0x20005A2")]
public class OverridePropertyBase<T>
{
	[Token(Token = "0x4001B98")]
	[FieldOffset(Offset = "0x0")]
	public T m_DefaultValue;

	[Token(Token = "0x4001B99")]
	[FieldOffset(Offset = "0x0")]
	public T m_MobileValue;

	[Token(Token = "0x6002569")]
	public T GetPlatformValue()
	{
		return (T)null;
	}

	[Token(Token = "0x600256A")]
	public T GetPlatformValue(DeviceInfo.PlatformType platformType)
	{
		return (T)null;
	}

	[Token(Token = "0x600256B")]
	public void SetPlatformValue(T value)
	{
	}

	[Token(Token = "0x600256C")]
	public void SetPlatformValue(DeviceInfo.PlatformType platformType, T value)
	{
	}

	[Token(Token = "0x600256D")]
	public OverridePropertyBase()
	{
	}
}
