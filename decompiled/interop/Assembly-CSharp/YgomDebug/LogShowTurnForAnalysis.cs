using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomDebug;

[Token(Token = "0x200013A")]
public class LogShowTurnForAnalysis : LogItemBaseForAnalysis
{
	[Token(Token = "0x4000785")]
	[FieldOffset(Offset = "0x0")]
	public static int SINGALCHARWIDTH;

	[Token(Token = "0x4000786")]
	[FieldOffset(Offset = "0x8")]
	public static string TEXT_TURN;

	[Token(Token = "0x4000787")]
	[FieldOffset(Offset = "0x20")]
	protected string LABEL_EO_PLAERICON;

	[Token(Token = "0x4000788")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	protected string m_Label_FaceIconL;

	[Token(Token = "0x4000789")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	protected string m_Label_FaceIconR;

	[Token(Token = "0x400078A")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	protected string m_Label_FaceIcon;

	[Token(Token = "0x400078B")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	protected string m_Label_FaceIconCursor;

	[Token(Token = "0x400078C")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	protected string m_Label_LPValueL;

	[Token(Token = "0x400078D")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	protected string m_Label_LPValueR;

	[Token(Token = "0x400078E")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	protected string m_Label_TurnText;

	[Token(Token = "0x400078F")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	protected string m_Label_TurnBg;

	[Token(Token = "0x4000790")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	protected Color m_Color_Team0;

	[Token(Token = "0x4000791")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	protected Color m_Color_Team1;

	[Token(Token = "0x4000792")]
	[FieldOffset(Offset = "0x88")]
	protected int m_IconIDL;

	[Token(Token = "0x4000793")]
	[FieldOffset(Offset = "0x8C")]
	protected int m_IconIDR;

	[Token(Token = "0x4000794")]
	[FieldOffset(Offset = "0x90")]
	private ElementObjectManager m_EOManager_Origin;

	[Token(Token = "0x170000DF")]
	protected ElementObjectManager m_EOManager
	{
		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x9DA980", Offset = "0x9D9B80", VA = "0x1809DA980")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60007F3")]
	[Address(RVA = "0x9DA3F0", Offset = "0x9D95F0", VA = "0x1809DA3F0")]
	public void SetData(ShowTurnDataForAnalysis data)
	{
	}

	[Token(Token = "0x60007F5")]
	[Address(RVA = "0x9DA520", Offset = "0x9D9720", VA = "0x1809DA520")]
	protected void SetFaceIcon(int playerid, GameObject root)
	{
	}

	[Token(Token = "0x60007F6")]
	[Address(RVA = "0x9DA5E0", Offset = "0x9D97E0", VA = "0x1809DA5E0")]
	protected void SetLP(string lplabel, int value)
	{
	}

	[Token(Token = "0x60007F7")]
	[Address(RVA = "0x9DA670", Offset = "0x9D9870", VA = "0x1809DA670")]
	protected void SetTurn(int value, int playerid)
	{
	}

	[Token(Token = "0x60007F8")]
	[Address(RVA = "0x9DA910", Offset = "0x9D9B10", VA = "0x1809DA910")]
	public LogShowTurnForAnalysis()
	{
	}
}
