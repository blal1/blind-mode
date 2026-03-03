using System.Collections.Generic;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;

namespace YgomGame.Duel;

[Token(Token = "0x20017A7")]
public class DuelRuleSetInfo
{
	[Token(Token = "0x20017A8")]
	public enum RuleType
	{
		[Token(Token = "0x400DD96")]
		None,
		[Token(Token = "0x400DD97")]
		LifeChange,
		[Token(Token = "0x400DD98")]
		TimeChange,
		[Token(Token = "0x400DD99")]
		HandNumChange
	}

	[Token(Token = "0x20017A9")]
	public class RuleInfo
	{
		[Token(Token = "0x400DD9A")]
		[FieldOffset(Offset = "0x10")]
		public RuleType type;

		[Token(Token = "0x400DD9B")]
		[FieldOffset(Offset = "0x14")]
		public float value;

		[Token(Token = "0x400DD9C")]
		[FieldOffset(Offset = "0x18")]
		public bool used;

		[Token(Token = "0x60094E2")]
		[Address(RVA = "0xDECA30", Offset = "0xDEBC30", VA = "0x180DECA30")]
		public RuleInfo(string strType, object val)
		{
		}
	}

	[Token(Token = "0x400DD93")]
	[FieldOffset(Offset = "0x10")]
	public List<RuleInfo> myRuleInfos;

	[Token(Token = "0x400DD94")]
	[FieldOffset(Offset = "0x18")]
	public List<RuleInfo> rivalRuleInfos;

	[Token(Token = "0x60094DD")]
	[Address(RVA = "0xDE50F0", Offset = "0xDE42F0", VA = "0x180DE50F0")]
	public static DuelRuleSetInfo Create()
	{
		return null;
	}

	[Token(Token = "0x60094DE")]
	[Address(RVA = "0xDE5680", Offset = "0xDE4880", VA = "0x180DE5680")]
	public List<RuleInfo> GetRuleInfos()
	{
		return null;
	}

	[Token(Token = "0x60094DF")]
	[Address(RVA = "0xDE4BD0", Offset = "0xDE3DD0", VA = "0x180DE4BD0")]
	public void BindIcon(ElementObjectManager tlEom)
	{
	}

	[Token(Token = "0x60094E0")]
	[Address(RVA = "0xDE4EF0", Offset = "0xDE40F0", VA = "0x180DE4EF0")]
	private void Bind(ElementObjectManager iconEom, RuleInfo info)
	{
	}

	[Token(Token = "0x60094E1")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public DuelRuleSetInfo()
	{
	}
}
