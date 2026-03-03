using Il2CppDummyDll;
using TMPro;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Menu.Common;

[Token(Token = "0x20014AC")]
public class SearchCategoryWidget : ElementWidgetBase
{
	[Token(Token = "0x400C76C")]
	[FieldOffset(Offset = "0x20")]
	private int m_categoryId;

	[Token(Token = "0x400C76D")]
	[FieldOffset(Offset = "0x28")]
	private string m_categoryName;

	[Token(Token = "0x400C76E")]
	[FieldOffset(Offset = "0x30")]
	private TextMeshProUGUI m_TextOn;

	[Token(Token = "0x400C76F")]
	[FieldOffset(Offset = "0x38")]
	private TextMeshProUGUI m_TextOff;

	[Token(Token = "0x170013AC")]
	public int categoryId
	{
		[Token(Token = "0x6008031")]
		[Address(RVA = "0x4BDC30", Offset = "0x4BCE30", VA = "0x1804BDC30")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170013AD")]
	public string categoryName
	{
		[Token(Token = "0x6008032")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008033")]
	[Address(RVA = "0xC7DE60", Offset = "0xC7D060", VA = "0x180C7DE60")]
	public SearchCategoryWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6008034")]
	[Address(RVA = "0xC7DDE0", Offset = "0xC7CFE0", VA = "0x180C7DDE0")]
	public SearchCategoryWidget Binding(int id, string name)
	{
		return null;
	}
}
