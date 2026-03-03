using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Menu;

[Token(Token = "0x2000013")]
public class IconViewerViewController : BaseMenuViewController
{
	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x0")]
	public static bool isChanged;

	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x8")]
	public static Action onOcgFlagChanged;

	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x10")]
	private static bool m_HasOcg;

	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x18")]
	public static string KEY_ICONID;

	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x20")]
	public static string KEY_ICONSIZE;

	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x28")]
	public static string KEY_FRAMEID;

	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x30")]
	public static string KEY_FRAMESIZE;

	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x38")]
	public static string KEY_BACKGROUND;

	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x40")]
	public static string KEY_BACKSELECT;

	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x48")]
	public static string KEY_DISCONNECT;

	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x50")]
	public static string KEY_DXFRAME;

	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x58")]
	public static string KEY_USE_MATERIALTEXTURE;

	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x60")]
	public static string KEY_USE_OCG;

	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string k_ShopBackNormalPath;

	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string k_ShopBackDXPath;

	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string k_CenterIconHolder;

	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string k_HeaderIconHolder;

	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string k_BackImage;

	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string k_RootPC;

	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x100")]
	private readonly string k_RootMobile;

	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0x108")]
	private readonly string k_FarIcon;

	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0x110")]
	private readonly string k_NearIcon;

	[Token(Token = "0x4000051")]
	[FieldOffset(Offset = "0x118")]
	private readonly string k_DuelIconHolder;

	[Token(Token = "0x4000052")]
	[FieldOffset(Offset = "0x120")]
	private readonly string k_DisconnectIcon;

	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x128")]
	private readonly string k_ProfileEditIcon;

	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0x130")]
	private readonly string k_ProfileEditFrame;

	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x138")]
	private readonly string k_DXIconLocater;

	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x140")]
	private Image m_CenterIconHolder;

	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x148")]
	private GameObject m_HeaderIconHolder;

	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0x150")]
	private GameObject m_DuelFarIconHolder;

	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x158")]
	private GameObject m_DuelNearIconHolder;

	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x160")]
	private GameObject m_DuelFarDisconnect;

	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x168")]
	private GameObject m_DuelNearDisconnect;

	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x170")]
	private GameObject m_ProfileEditIconImage;

	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x178")]
	private GameObject m_ProfileEditFrameImage;

	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x180")]
	private GameObject m_DXIconLocater;

	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x188")]
	private Image m_BackGround;

	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0x190")]
	private Material m_FrameMat;

	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0x198")]
	private Sprite m_ShopBackNormal;

	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0x1A0")]
	private Sprite m_ShopBackDX;

	[Token(Token = "0x17000007")]
	public static bool hasOcg
	{
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x3E0EA0", Offset = "0x3E00A0", VA = "0x1803E0EA0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x3E0EF0", Offset = "0x3E00F0", VA = "0x1803E0EF0")]
		set
		{
		}
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x3DF130", Offset = "0x3DE330", VA = "0x1803DF130", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x3E0510", Offset = "0x3DF710", VA = "0x1803E0510")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x3E00E0", Offset = "0x3DF2E0", VA = "0x1803E00E0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x3E0860", Offset = "0x3DFA60", VA = "0x1803E0860")]
	private void Update()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x3DF2B0", Offset = "0x3DE4B0", VA = "0x1803DF2B0")]
	private void OnChanged()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x3DEED0", Offset = "0x3DE0D0", VA = "0x1803DEED0")]
	private (string, string) MakeIconPath(int id, int size)
	{
		return default((string, string));
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x3DED90", Offset = "0x3DDF90", VA = "0x1803DED90")]
	private (string, string) MakeFramePath(int id, int size)
	{
		return default((string, string));
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x3E05A0", Offset = "0x3DF7A0", VA = "0x1803E05A0")]
	public static void SaveColor(string key, Color color)
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x3DEC30", Offset = "0x3DDE30", VA = "0x1803DEC30")]
	public static Color LoadColor(string key, Color defaultColor)
	{
		return default(Color);
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x3E0BF0", Offset = "0x3DFDF0", VA = "0x1803E0BF0")]
	public IconViewerViewController()
	{
	}
}
