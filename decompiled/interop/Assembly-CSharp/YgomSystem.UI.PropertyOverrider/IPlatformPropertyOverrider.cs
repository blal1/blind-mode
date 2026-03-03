using Il2CppDummyDll;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider;

[Token(Token = "0x20005BB")]
public interface IPlatformPropertyOverrider
{
	[Token(Token = "0x1700046A")]
	OverrideMode overrideMode
	{
		[Token(Token = "0x60025C2")]
		get;
		[Token(Token = "0x60025C3")]
		set;
	}

	[Token(Token = "0x1700046B")]
	string switchLabel
	{
		[Token(Token = "0x60025CA")]
		get;
	}

	[Token(Token = "0x1700046C")]
	bool switchLabelAsReg
	{
		[Token(Token = "0x60025CB")]
		get;
	}

	[Token(Token = "0x60025C4")]
	void ApplyImmediate();

	[Token(Token = "0x60025C5")]
	void ApplyImmediate(DeviceInfo.PlatformType platformType);

	[Token(Token = "0x60025C6")]
	void Import();

	[Token(Token = "0x60025C7")]
	void Import(DeviceInfo.PlatformType platformType);

	[Token(Token = "0x60025C8")]
	void Export();

	[Token(Token = "0x60025C9")]
	void Export(DeviceInfo.PlatformType platformType);
}
