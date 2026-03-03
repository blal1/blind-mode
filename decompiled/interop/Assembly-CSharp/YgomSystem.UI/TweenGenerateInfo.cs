using Il2CppDummyDll;

namespace YgomSystem.UI;

[Token(Token = "0x200050A")]
public abstract class TweenGenerateInfo : TweenInfo
{
	[Token(Token = "0x40018CD")]
	[FieldOffset(Offset = "0x18")]
	public string label;

	[Token(Token = "0x40018CE")]
	[FieldOffset(Offset = "0x20")]
	public Tween.Easing easing;

	[Token(Token = "0x40018CF")]
	[FieldOffset(Offset = "0x24")]
	public Tween.Style style;

	[Token(Token = "0x40018D0")]
	[FieldOffset(Offset = "0x28")]
	[SecField]
	public float duration;

	[Token(Token = "0x40018D1")]
	[FieldOffset(Offset = "0x2C")]
	[SecField]
	public float startDelay;

	[Token(Token = "0x40018D2")]
	[FieldOffset(Offset = "0x30")]
	public bool ignoreTimeScale;

	[Token(Token = "0x60020E3")]
	[Address(RVA = "0x63B820", Offset = "0x63AA20", VA = "0x18063B820")]
	protected TweenGenerateInfo()
	{
	}
}
