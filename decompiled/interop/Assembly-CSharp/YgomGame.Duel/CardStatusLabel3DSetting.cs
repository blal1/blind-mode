using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x20019EC")]
[CreateAssetMenu(menuName = "Scriptable Object/CardStatusLabel3DSetting")]
public class CardStatusLabel3DSetting : ScriptableObject
{
	[Token(Token = "0x400EF80")]
	[FieldOffset(Offset = "0x0")]
	private static CardStatusLabel3DSetting m_Instance;

	[Token(Token = "0x400EF81")]
	private const string PATH = "Duel/ScriptableObject/CardStatusLabel3DSetting";

	[Token(Token = "0x400EF82")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private int m_FontSize_Active;

	[Token(Token = "0x400EF83")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private int m_FontSize_Inactive;

	[Token(Token = "0x400EF84")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int m_FontSize_Slash;

	[Token(Token = "0x400EF85")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private int m_FontSizeForMobile_Active;

	[Token(Token = "0x400EF86")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private int m_FontSizeForMobile_Inactive;

	[Token(Token = "0x400EF87")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private int m_FontSizeForMobile_Slash;

	[Token(Token = "0x400EF88")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Color m_FontColor_Normal;

	[Token(Token = "0x400EF89")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Color m_FontColor_Changed;

	[Token(Token = "0x400EF8A")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Color m_FontColor_Slash;

	[Token(Token = "0x400EF8B")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Color m_FontColor_Up;

	[Token(Token = "0x400EF8C")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Color m_FontColor_UpLight;

	[Token(Token = "0x400EF8D")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Color m_FontColor_Down;

	[Token(Token = "0x400EF8E")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Color m_FontColor_DownLight;

	[Token(Token = "0x400EF8F")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private float m_FadeSpeed;

	[Token(Token = "0x400EF90")]
	[FieldOffset(Offset = "0xA4")]
	[SerializeField]
	private float m_BrightInactive;

	[Token(Token = "0x170019B6")]
	protected static CardStatusLabel3DSetting Instance
	{
		[Token(Token = "0x600A743")]
		[Address(RVA = "0xF2F5F0", Offset = "0xF2E7F0", VA = "0x180F2F5F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170019B7")]
	public static int FontSize_Active
	{
		[Token(Token = "0x600A744")]
		[Address(RVA = "0xF2F590", Offset = "0xF2E790", VA = "0x180F2F590")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170019B8")]
	public static int FontSize_Inactive
	{
		[Token(Token = "0x600A745")]
		[Address(RVA = "0xF2F5B0", Offset = "0xF2E7B0", VA = "0x180F2F5B0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170019B9")]
	public static int FontSize_Slash
	{
		[Token(Token = "0x600A746")]
		[Address(RVA = "0xF2F5D0", Offset = "0xF2E7D0", VA = "0x180F2F5D0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170019BA")]
	public static int FontSizeForMobile_Active
	{
		[Token(Token = "0x600A747")]
		[Address(RVA = "0xF2F530", Offset = "0xF2E730", VA = "0x180F2F530")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170019BB")]
	public static int FontSizeForMobile_Inactive
	{
		[Token(Token = "0x600A748")]
		[Address(RVA = "0xF2F550", Offset = "0xF2E750", VA = "0x180F2F550")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170019BC")]
	public static int FontSizeForMobile_Slash
	{
		[Token(Token = "0x600A749")]
		[Address(RVA = "0xF2F570", Offset = "0xF2E770", VA = "0x180F2F570")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170019BD")]
	public static Color FontColor_Normal
	{
		[Token(Token = "0x600A74A")]
		[Address(RVA = "0xF2F470", Offset = "0xF2E670", VA = "0x180F2F470")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x170019BE")]
	public static Color FontColor_Changed
	{
		[Token(Token = "0x600A74B")]
		[Address(RVA = "0xF2F3E0", Offset = "0xF2E5E0", VA = "0x180F2F3E0")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x170019BF")]
	public static Color FontColor_Up
	{
		[Token(Token = "0x600A74C")]
		[Address(RVA = "0xF2F500", Offset = "0xF2E700", VA = "0x180F2F500")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x170019C0")]
	public static Color FontColor_UpLight
	{
		[Token(Token = "0x600A74D")]
		[Address(RVA = "0xF2F4D0", Offset = "0xF2E6D0", VA = "0x180F2F4D0")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x170019C1")]
	public static Color FontColor_Down
	{
		[Token(Token = "0x600A74E")]
		[Address(RVA = "0xF2F440", Offset = "0xF2E640", VA = "0x180F2F440")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x170019C2")]
	public static Color FontColor_DownLight
	{
		[Token(Token = "0x600A74F")]
		[Address(RVA = "0xF2F410", Offset = "0xF2E610", VA = "0x180F2F410")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x170019C3")]
	public static Color FontColor_Slash
	{
		[Token(Token = "0x600A750")]
		[Address(RVA = "0xF2F4A0", Offset = "0xF2E6A0", VA = "0x180F2F4A0")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x170019C4")]
	public static float FadeSpeed
	{
		[Token(Token = "0x600A751")]
		[Address(RVA = "0xF2F3B0", Offset = "0xF2E5B0", VA = "0x180F2F3B0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170019C5")]
	public static float BrightInactive
	{
		[Token(Token = "0x600A752")]
		[Address(RVA = "0xF2F380", Offset = "0xF2E580", VA = "0x180F2F380")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x600A753")]
	[Address(RVA = "0x3D4F30", Offset = "0x3D4130", VA = "0x1803D4F30")]
	public CardStatusLabel3DSetting()
	{
	}
}
