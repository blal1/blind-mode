using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x200056D")]
[AddComponentMenu("Ygom/UI/View Controller/Tween View Controller")]
public class TweenViewController : ViewController
{
	[Token(Token = "0x4001A6E")]
	[FieldOffset(Offset = "0x48")]
	public string PushLabel;

	[Token(Token = "0x4001A6F")]
	[FieldOffset(Offset = "0x50")]
	public string PopLabel;

	[Token(Token = "0x4001A70")]
	[FieldOffset(Offset = "0x58")]
	public string CoverLabel;

	[Token(Token = "0x4001A71")]
	[FieldOffset(Offset = "0x60")]
	public string UncoverLabel;

	[Token(Token = "0x4001A72")]
	[FieldOffset(Offset = "0x68")]
	public string SwapInLabel;

	[Token(Token = "0x4001A73")]
	[FieldOffset(Offset = "0x70")]
	public string SwapOutLabel;

	[Token(Token = "0x4001A74")]
	[FieldOffset(Offset = "0x78")]
	private string m_LastTweenLabel;

	[Token(Token = "0x170003C9")]
	protected virtual GameObject m_TweenTarget
	{
		[Token(Token = "0x6002326")]
		[Address(RVA = "0x4A1C50", Offset = "0x4A0E50", VA = "0x1804A1C50", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003CA")]
	protected string k_SwapLabelAlphaFade
	{
		[Token(Token = "0x6002327")]
		[Address(RVA = "0x655530", Offset = "0x654730", VA = "0x180655530")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003CB")]
	protected string k_SwapLabelFlip
	{
		[Token(Token = "0x6002328")]
		[Address(RVA = "0x655560", Offset = "0x654760", VA = "0x180655560")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002329")]
	[Address(RVA = "0x654FF0", Offset = "0x6541F0", VA = "0x180654FF0")]
	protected void AddLabelSuffix(string suffix)
	{
	}

	[Token(Token = "0x600232A")]
	[Address(RVA = "0x6550D0", Offset = "0x6542D0", VA = "0x1806550D0")]
	public string GetTransitionType2Label(TransitionType type)
	{
		return null;
	}

	[Token(Token = "0x600232B")]
	[Address(RVA = "0x6551A0", Offset = "0x6543A0", VA = "0x1806551A0", Slot = "11")]
	public override void TransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x600232C")]
	[Address(RVA = "0x655320", Offset = "0x654520", VA = "0x180655320", Slot = "12")]
	public override bool TransitionUpdate(TransitionType type)
	{
		return default(bool);
	}

	[Token(Token = "0x600232D")]
	[Address(RVA = "0x655400", Offset = "0x654600", VA = "0x180655400")]
	public TweenViewController()
	{
	}
}
