using System.Collections.Generic;
using Il2CppDummyDll;

namespace com.adjust.sdk;

[Token(Token = "0x2001DE5")]
public class AdjustThirdPartySharing
{
	[Token(Token = "0x4010612")]
	[FieldOffset(Offset = "0x10")]
	internal bool? isEnabled;

	[Token(Token = "0x4010613")]
	[FieldOffset(Offset = "0x18")]
	internal Dictionary<string, List<string>> granularOptions;

	[Token(Token = "0x4010614")]
	[FieldOffset(Offset = "0x20")]
	internal Dictionary<string, List<string>> partnerSharingSettings;

	[Token(Token = "0x600BFC7")]
	[Address(RVA = "0x598C60", Offset = "0x597E60", VA = "0x180598C60")]
	public AdjustThirdPartySharing(bool? isEnabled)
	{
	}

	[Token(Token = "0x600BFC8")]
	[Address(RVA = "0x598D10", Offset = "0x597F10", VA = "0x180598D10")]
	public void addGranularOption(string partnerName, string key, string value)
	{
	}

	[Token(Token = "0x600BFC9")]
	[Address(RVA = "0x598E70", Offset = "0x598070", VA = "0x180598E70")]
	public void addPartnerSharingSetting(string partnerName, string key, bool value)
	{
	}
}
