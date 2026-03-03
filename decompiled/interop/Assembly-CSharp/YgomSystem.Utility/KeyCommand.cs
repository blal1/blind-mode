using System;
using Il2CppDummyDll;
using YgomSystem.UI;

namespace YgomSystem.Utility;

[Token(Token = "0x20003E3")]
public class KeyCommand
{
	[Token(Token = "0x20003E4")]
	public enum OnKeyResult
	{
		[Token(Token = "0x4001383")]
		Success,
		[Token(Token = "0x4001384")]
		Complete,
		[Token(Token = "0x4001385")]
		AlreadyCompleted,
		[Token(Token = "0x4001386")]
		Failed
	}

	[Token(Token = "0x400137F")]
	[FieldOffset(Offset = "0x10")]
	private KeyCommandSetting.KeyCommandInfo info;

	[Token(Token = "0x4001380")]
	[FieldOffset(Offset = "0x18")]
	private int index;

	[Token(Token = "0x4001381")]
	[FieldOffset(Offset = "0x20")]
	private Action<OnKeyResult> onSetKeyCallback;

	[Token(Token = "0x6001901")]
	[Address(RVA = "0x5CE880", Offset = "0x5CDA80", VA = "0x1805CE880")]
	public KeyCommand(KeyCommandSetting.KeyCommandInfo info, Action<OnKeyResult> onSetKeyCallback)
	{
	}

	[Token(Token = "0x6001902")]
	[Address(RVA = "0x5CE720", Offset = "0x5CD920", VA = "0x1805CE720")]
	public void SetKey(SelectorManager.KeyType keyType)
	{
	}

	[Token(Token = "0x6001903")]
	[Address(RVA = "0x5CE710", Offset = "0x5CD910", VA = "0x1805CE710")]
	public void Reset()
	{
	}

	[Token(Token = "0x6001904")]
	[Address(RVA = "0x5CE6F0", Offset = "0x5CD8F0", VA = "0x1805CE6F0")]
	private void InvokeOnSetKeyResult(OnKeyResult result)
	{
	}
}
