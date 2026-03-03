using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.CardPack;

[Token(Token = "0x200152E")]
public class CardWidget : ElementWidgetBase
{
	[Token(Token = "0x400CB89")]
	[FieldOffset(Offset = "0x20")]
	private readonly string k_ECardLabelButton;

	[Token(Token = "0x400CB8A")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ECardLabelHighlight;

	[Token(Token = "0x400CB8B")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ECardLabelIconRarity;

	[Token(Token = "0x400CB8C")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ECardLabelLimitIcon;

	[Token(Token = "0x400CB8D")]
	[FieldOffset(Offset = "0x40")]
	private readonly string k_ECardLabelNumTextArea;

	[Token(Token = "0x400CB8E")]
	[FieldOffset(Offset = "0x48")]
	private readonly string k_ECardLabelNumText;

	[Token(Token = "0x400CB8F")]
	[FieldOffset(Offset = "0x50")]
	private readonly string k_ECardLabelNewIcon;

	[Token(Token = "0x400CB90")]
	[FieldOffset(Offset = "0x58")]
	private int m_Mrk;

	[Token(Token = "0x400CB91")]
	[FieldOffset(Offset = "0x5C")]
	private int m_StyleId;

	[Token(Token = "0x400CB92")]
	[FieldOffset(Offset = "0x60")]
	private readonly RawImage m_CardRawImage;

	[Token(Token = "0x400CB93")]
	[FieldOffset(Offset = "0x68")]
	private BindingCardMaterial m_BindingCardMaterial;

	[Token(Token = "0x400CB94")]
	[FieldOffset(Offset = "0x70")]
	public int regurationId;

	[Token(Token = "0x170013F7")]
	public bool highlightVisible
	{
		[Token(Token = "0x60082F9")]
		[Address(RVA = "0x8E5240", Offset = "0x8E4440", VA = "0x1808E5240")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60082FA")]
		[Address(RVA = "0x8E54A0", Offset = "0x8E46A0", VA = "0x1808E54A0")]
		set
		{
		}
	}

	[Token(Token = "0x170013F8")]
	public bool newIconVisible
	{
		[Token(Token = "0x60082FB")]
		[Address(RVA = "0x8E53A0", Offset = "0x8E45A0", VA = "0x1808E53A0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60082FC")]
		[Address(RVA = "0x8E5560", Offset = "0x8E4760", VA = "0x1808E5560")]
		set
		{
		}
	}

	[Token(Token = "0x170013F9")]
	public bool limitIconVisible
	{
		[Token(Token = "0x60082FD")]
		[Address(RVA = "0x8E5360", Offset = "0x8E4560", VA = "0x1808E5360")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60082FE")]
		[Address(RVA = "0x8E5520", Offset = "0x8E4720", VA = "0x1808E5520")]
		set
		{
		}
	}

	[Token(Token = "0x170013FA")]
	public Image limitIconImage
	{
		[Token(Token = "0x60082FF")]
		[Address(RVA = "0xCBCF90", Offset = "0xCBC190", VA = "0x180CBCF90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013FB")]
	public GameObject innerTextArea
	{
		[Token(Token = "0x6008300")]
		[Address(RVA = "0x941110", Offset = "0x940310", VA = "0x180941110")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013FC")]
	public TMP_Text innerText
	{
		[Token(Token = "0x6008301")]
		[Address(RVA = "0xCBCF40", Offset = "0xCBC140", VA = "0x180CBCF40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013FD")]
	public SelectionButton button
	{
		[Token(Token = "0x6008302")]
		[Address(RVA = "0xCBCEF0", Offset = "0xCBC0F0", VA = "0x180CBCEF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013FE")]
	public BindingCardMaterial bindingCardMaterial
	{
		[Token(Token = "0x6008303")]
		[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008304")]
	[Address(RVA = "0xCBC860", Offset = "0xCBBA60", VA = "0x180CBC860")]
	public static CardWidget Create(ElementObjectManager eom)
	{
		return null;
	}

	[Token(Token = "0x6008305")]
	[Address(RVA = "0xCBCBE0", Offset = "0xCBBDE0", VA = "0x180CBCBE0")]
	public CardWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6008306")]
	[Address(RVA = "0xCBC590", Offset = "0xCBB790", VA = "0x180CBC590", Slot = "10")]
	public virtual void Binding(int mrk, int styleId = 1)
	{
	}

	[Token(Token = "0x6008307")]
	[Address(RVA = "0xCBC8C0", Offset = "0xCBBAC0", VA = "0x180CBC8C0", Slot = "11")]
	protected virtual void OnClick()
	{
	}

	[Token(Token = "0x6008308")]
	[Address(RVA = "0xCBC8C0", Offset = "0xCBBAC0", VA = "0x180CBC8C0")]
	public void OpenDetail()
	{
	}
}
