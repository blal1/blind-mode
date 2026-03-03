using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Card;

[Token(Token = "0x200161F")]
public class CardPictureFontHelper
{
	[Token(Token = "0x2001620")]
	public enum Mode
	{
		[Token(Token = "0x400D4DD")]
		Normal,
		[Token(Token = "0x400D4DE")]
		CardCheck
	}

	[Token(Token = "0x400D4D6")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<short, float> m_NormalFontSizeTable;

	[Token(Token = "0x400D4D7")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<short, float> m_PendulumFontSizeTable;

	[Token(Token = "0x400D4D8")]
	private const string DATAFILEPATHBASE = "Card/ScriptableObjects/#/CardPictureFontSetting";

	[Token(Token = "0x400D4D9")]
	public const byte AUTOSIZE = 0;

	[Token(Token = "0x400D4DA")]
	[FieldOffset(Offset = "0x0")]
	private static CardPictureFontHelper m_Instance;

	[Token(Token = "0x400D4DB")]
	[FieldOffset(Offset = "0x8")]
	public static Mode m_Mode;

	[Token(Token = "0x60089A3")]
	[Address(RVA = "0xD4D420", Offset = "0xD4C620", VA = "0x180D4D420")]
	public static void Create()
	{
	}

	[Token(Token = "0x60089A4")]
	[Address(RVA = "0xD4D5C0", Offset = "0xD4C7C0", VA = "0x180D4D5C0")]
	public static bool GetNormalTextFontSize(int cardid, out float fontsize)
	{
		return default(bool);
	}

	[Token(Token = "0x60089A5")]
	[Address(RVA = "0xD4D6F0", Offset = "0xD4C8F0", VA = "0x180D4D6F0")]
	public static bool GetPendulumTextFontSize(int cardid, out float fontsize)
	{
		return default(bool);
	}

	[Token(Token = "0x60089A6")]
	[Address(RVA = "0xD4D840", Offset = "0xD4CA40", VA = "0x180D4D840")]
	public static void LoadDataToTable()
	{
	}

	[Token(Token = "0x60089A7")]
	[Address(RVA = "0xD4D890", Offset = "0xD4CA90", VA = "0x180D4D890")]
	public static void ResetTable()
	{
	}

	[Token(Token = "0x60089A8")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void AddData(int cardid, float fontsize, bool ispendulum)
	{
	}

	[Token(Token = "0x60089A9")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void ClearData()
	{
	}

	[Token(Token = "0x60089AA")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void RewriteData()
	{
	}

	[Token(Token = "0x60089AB")]
	[Address(RVA = "0xD4D7A0", Offset = "0xD4C9A0", VA = "0x180D4D7A0")]
	protected void Initialize()
	{
	}

	[Token(Token = "0x60089AC")]
	[Address(RVA = "0xD4D3C0", Offset = "0xD4C5C0", VA = "0x180D4D3C0")]
	private void ClearTable()
	{
	}

	[Token(Token = "0x60089AD")]
	[Address(RVA = "0xD4D920", Offset = "0xD4CB20", VA = "0x180D4D920")]
	private void SetData()
	{
	}

	[Token(Token = "0x60089AE")]
	[Address(RVA = "0xD4D540", Offset = "0xD4C740", VA = "0x180D4D540")]
	private bool GetNormalTextFontSizeImpl(int cardid, out float fontsize)
	{
		return default(bool);
	}

	[Token(Token = "0x60089AF")]
	[Address(RVA = "0xD4D670", Offset = "0xD4C870", VA = "0x180D4D670")]
	private bool GetPendulumTextFontSizeImpl(int cardid, out float fontsize)
	{
		return default(bool);
	}

	[Token(Token = "0x60089B0")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CardPictureFontHelper()
	{
	}
}
