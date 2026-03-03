using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.Duel;

[Token(Token = "0x2001917")]
public class LogShowTurn : LogItemBase
{
	[Token(Token = "0x400EA88")]
	[FieldOffset(Offset = "0x0")]
	public static int SINGALCHARWIDTH;

	[Token(Token = "0x400EA89")]
	[FieldOffset(Offset = "0x8")]
	public static string TEXT_TURN;

	[Token(Token = "0x400EA8A")]
	[FieldOffset(Offset = "0x50")]
	protected string LABEL_EO_PLAERICON;

	[Token(Token = "0x400EA8B")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	protected string m_Label_FaceIconL;

	[Token(Token = "0x400EA8C")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	protected string m_Label_FaceIconR;

	[Token(Token = "0x400EA8D")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	protected string m_Label_FaceIcon;

	[Token(Token = "0x400EA8E")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	protected string m_Label_FaceIconCursor;

	[Token(Token = "0x400EA8F")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	protected string m_Label_LPValueL;

	[Token(Token = "0x400EA90")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	protected string m_Label_LPValueR;

	[Token(Token = "0x400EA91")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	protected string m_Label_TurnText;

	[Token(Token = "0x400EA92")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	protected string m_Label_TurnBg;

	[Token(Token = "0x400EA93")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	protected Color m_Color_Team0;

	[Token(Token = "0x400EA94")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	protected Color m_Color_Team1;

	[Token(Token = "0x400EA95")]
	[FieldOffset(Offset = "0xB8")]
	protected int m_IconIDL;

	[Token(Token = "0x400EA96")]
	[FieldOffset(Offset = "0xBC")]
	protected int m_IconIDR;

	[Token(Token = "0x400EA97")]
	[FieldOffset(Offset = "0xC0")]
	private ElementObjectManager m_EOManager_Origin;

	[Token(Token = "0x170018BD")]
	protected ElementObjectManager m_EOManager
	{
		[Token(Token = "0x600A1C0")]
		[Address(RVA = "0xEF44B0", Offset = "0xEF36B0", VA = "0x180EF44B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A1BF")]
	[Address(RVA = "0xEF3EE0", Offset = "0xEF30E0", VA = "0x180EF3EE0")]
	public void SetData(ShowTurnData data)
	{
	}

	[Token(Token = "0x600A1C1")]
	[Address(RVA = "0xEF4050", Offset = "0xEF3250", VA = "0x180EF4050")]
	protected void SetFaceIcon(int playerid, GameObject root)
	{
	}

	[Token(Token = "0x600A1C2")]
	[Address(RVA = "0xEF4100", Offset = "0xEF3300", VA = "0x180EF4100")]
	protected void SetLP(string lplabel, int value)
	{
	}

	[Token(Token = "0x600A1C3")]
	[Address(RVA = "0xEF4190", Offset = "0xEF3390", VA = "0x180EF4190")]
	protected void SetTurn(int value, int playerid)
	{
	}

	[Token(Token = "0x600A1C4")]
	[Address(RVA = "0xEF4440", Offset = "0xEF3640", VA = "0x180EF4440")]
	public LogShowTurn()
	{
	}
}
