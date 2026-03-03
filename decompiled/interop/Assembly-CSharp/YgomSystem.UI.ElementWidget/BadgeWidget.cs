using Il2CppDummyDll;
using YgomSystem.ElementSystem;

namespace YgomSystem.UI.ElementWidget;

[Token(Token = "0x2000603")]
public class BadgeWidget : ElementWidgetBase
{
	[Token(Token = "0x4001CE6")]
	private const string k_ELabelNewBadge = "NewBadge";

	[Token(Token = "0x4001CE7")]
	private const string k_ELabelNumBadge = "NumBadge";

	[Token(Token = "0x4001CE8")]
	private const string k_ELabelNumBadgeText = "NumBadgeText";

	[Token(Token = "0x6002763")]
	[Address(RVA = "0x6A1440", Offset = "0x6A0640", VA = "0x1806A1440")]
	public BadgeWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6002764")]
	[Address(RVA = "0x6A0FA0", Offset = "0x6A01A0", VA = "0x1806A0FA0")]
	public static void SetAsNewOrNum(ElementObjectManager eom, bool isNew, int num)
	{
	}

	[Token(Token = "0x6002765")]
	[Address(RVA = "0x6A11D0", Offset = "0x6A03D0", VA = "0x1806A11D0")]
	public static void SetAsNew(ElementObjectManager eom, bool isNew)
	{
	}

	[Token(Token = "0x6002766")]
	[Address(RVA = "0x6A12D0", Offset = "0x6A04D0", VA = "0x1806A12D0")]
	public static void SetAsNum(ElementObjectManager eom, int num)
	{
	}
}
