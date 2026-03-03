using Il2CppDummyDll;

namespace YgomSystem.UI;

[Token(Token = "0x2000563")]
public static class UIDefine
{
	[Token(Token = "0x4001A44")]
	public const int SelectorPriorityGameMin = 0;

	[Token(Token = "0x4001A45")]
	public const int SelectorPriorityHeader = 2000;

	[Token(Token = "0x4001A46")]
	public const int SelectorPriorityBlurOverlay = 3000;

	[Token(Token = "0x4001A47")]
	public const int SelectorPriorityDialog = 4000;

	[Token(Token = "0x4001A48")]
	public const int SelectorPriorityInform = 5000;

	[Token(Token = "0x4001A49")]
	public const int SelectorPriorityGameMax = 9900;

	[Token(Token = "0x4001A4A")]
	public const int SelectorPrioritySystemMin = 10000;

	[Token(Token = "0x4001A4B")]
	public const int SelectorPrioritySystemMax = 19900;

	[Token(Token = "0x4001A4C")]
	public const int SelectorPriorityDebugMin = 20000;

	[Token(Token = "0x4001A4D")]
	public const int SelectorPriorityDebugLogViewer = 20001;

	[Token(Token = "0x4001A4E")]
	public const int SelectorPriorityCheatMenu = 20002;

	[Token(Token = "0x4001A4F")]
	public const int SelectorPrioritySnapshotReport = 20003;

	[Token(Token = "0x4001A50")]
	public const int SelectorPriorityDebugMax = 29900;

	[Token(Token = "0x4001A51")]
	public const int SelectorPrioritySwitchKeyboard = 99999;

	[Token(Token = "0x4001A52")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string ViewControllerNameBoot;

	[Token(Token = "0x4001A53")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string ViewControllerNameTitle;

	[Token(Token = "0x4001A54")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string ViewControllerNameLanguageSelect;

	[Token(Token = "0x4001A55")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string ViewControllerNameFirstLanguageSelect;
}
