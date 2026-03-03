using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.Duel;

[Token(Token = "0x2001912")]
public class LogShowTag : LogItemBase
{
	[Token(Token = "0x400EA6F")]
	private const int FULLWIDTH = 320;

	[Token(Token = "0x400EA70")]
	private const int FULLWIDTH_MOBILE = 670;

	[Token(Token = "0x400EA71")]
	private const int INDENTWIDTH = 280;

	[Token(Token = "0x400EA72")]
	private const int INDENTWIDTH_MOBILE = 580;

	[Token(Token = "0x400EA73")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	protected string m_Label_TagName;

	[Token(Token = "0x400EA74")]
	[FieldOffset(Offset = "0x58")]
	private ElementObjectManager m_EOManager_Origin;

	[Token(Token = "0x170018B7")]
	protected ElementObjectManager m_EOManager
	{
		[Token(Token = "0x600A1A9")]
		[Address(RVA = "0xEF3AE0", Offset = "0xEF2CE0", VA = "0x180EF3AE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A1A8")]
	[Address(RVA = "0xEF3780", Offset = "0xEF2980", VA = "0x180EF3780")]
	public void SetData(ShowTagData data)
	{
	}

	[Token(Token = "0x600A1AA")]
	[Address(RVA = "0xEF3960", Offset = "0xEF2B60", VA = "0x180EF3960")]
	protected void SetTargetTag()
	{
	}

	[Token(Token = "0x600A1AB")]
	[Address(RVA = "0xEF36C0", Offset = "0xEF28C0", VA = "0x180EF36C0")]
	protected void SetCostTag()
	{
	}

	[Token(Token = "0x600A1AC")]
	[Address(RVA = "0xEF3A20", Offset = "0xEF2C20", VA = "0x180EF3A20")]
	protected void SetWidth(bool isIndent)
	{
	}

	[Token(Token = "0x600A1AD")]
	[Address(RVA = "0x422F60", Offset = "0x422160", VA = "0x180422F60")]
	public LogShowTag()
	{
	}
}
