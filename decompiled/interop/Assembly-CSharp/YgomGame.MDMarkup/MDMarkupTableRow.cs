using Il2CppDummyDll;
using TMPro;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.PropertyOverrider;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000D0A")]
public class MDMarkupTableRow : ElementWidgetBase
{
	[Token(Token = "0x4009D5E")]
	[FieldOffset(Offset = "0x20")]
	private readonly string k_ELabelBG;

	[Token(Token = "0x17000B35")]
	private PlatformOverriderGroup overriderGroup
	{
		[Token(Token = "0x6004ED0")]
		[Address(RVA = "0x95CA90", Offset = "0x95BC90", VA = "0x18095CA90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B36")]
	public bool borderVisible
	{
		[Token(Token = "0x6004ED1")]
		[Address(RVA = "0x95C980", Offset = "0x95BB80", VA = "0x18095C980")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004ED2")]
		[Address(RVA = "0x95CB50", Offset = "0x95BD50", VA = "0x18095CB50")]
		set
		{
		}
	}

	[Token(Token = "0x17000B37")]
	public bool bgVisible
	{
		[Token(Token = "0x6004ED3")]
		[Address(RVA = "0x95C920", Offset = "0x95BB20", VA = "0x18095C920")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004ED4")]
		[Address(RVA = "0x95CAE0", Offset = "0x95BCE0", VA = "0x18095CAE0")]
		set
		{
		}
	}

	[Token(Token = "0x17000B38")]
	public string layout
	{
		[Token(Token = "0x6004ED5")]
		[Address(RVA = "0x95C9E0", Offset = "0x95BBE0", VA = "0x18095C9E0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004ED6")]
		[Address(RVA = "0x95CBC0", Offset = "0x95BDC0", VA = "0x18095CBC0")]
		set
		{
		}
	}

	[Token(Token = "0x6004ED7")]
	[Address(RVA = "0x95C8C0", Offset = "0x95BAC0", VA = "0x18095C8C0")]
	public MDMarkupTableRow(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6004ED8")]
	[Address(RVA = "0x95C770", Offset = "0x95B970", VA = "0x18095C770")]
	public void SetAlignment(TextAlignmentOptions alignment)
	{
	}

	[Token(Token = "0x6004ED9")]
	[Address(RVA = "0x95C840", Offset = "0x95BA40", VA = "0x18095C840")]
	public void SetIsLast(bool isLast)
	{
	}
}
