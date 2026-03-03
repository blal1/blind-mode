using System;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F61")]
public class ProductWCSInfoWidget : ElementWidgetBase
{
	[Token(Token = "0x400A7A8")]
	private const string k_ELabelButtonLive = "ButtonLive";

	[Token(Token = "0x400A7A9")]
	private const string k_ELabelImageLogo = "ImageLogo";

	[Token(Token = "0x400A7AA")]
	private const string k_ELabelTemplateRandomPlay = "templateDuelLive";

	[Token(Token = "0x400A7AB")]
	private const string k_ELabelTemplateWCSGroup = "templateWCSGroup";

	[Token(Token = "0x400A7AC")]
	[FieldOffset(Offset = "0x20")]
	private bool m_logoLoaded;

	[Token(Token = "0x400A7AD")]
	[FieldOffset(Offset = "0x28")]
	private SelectionButton m_liveButton;

	[Token(Token = "0x400A7AE")]
	[FieldOffset(Offset = "0x30")]
	private SelectionButton m_randomButton;

	[Token(Token = "0x400A7AF")]
	[FieldOffset(Offset = "0x38")]
	private DuelLiveWCSMenuData m_menuData;

	[Token(Token = "0x400A7B0")]
	[FieldOffset(Offset = "0x40")]
	public Action<int> onClickRandomPlayButtonCallback;

	[Token(Token = "0x400A7B1")]
	[FieldOffset(Offset = "0x48")]
	public Action<string> onClickLiveButtonCallback;

	[Token(Token = "0x17000EB1")]
	public SelectionButton liveButton
	{
		[Token(Token = "0x6005D55")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EB2")]
	public bool isLiveButtonEnable
	{
		[Token(Token = "0x6005D56")]
		[Address(RVA = "0xA2AF50", Offset = "0xA2A150", VA = "0x180A2AF50")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000EB3")]
	public SelectionButton randomButton
	{
		[Token(Token = "0x6005D57")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005D58")]
	[Address(RVA = "0xA2AD40", Offset = "0xA29F40", VA = "0x180A2AD40")]
	public ProductWCSInfoWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6005D59")]
	[Address(RVA = "0xA2AB10", Offset = "0xA29D10", VA = "0x180A2AB10")]
	public void SetView(DuelLiveWCSMenuData menuData)
	{
	}
}
