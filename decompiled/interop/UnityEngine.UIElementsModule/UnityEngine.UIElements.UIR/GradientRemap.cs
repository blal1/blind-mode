using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200057A")]
internal class GradientRemap : LinkedPoolItem<GradientRemap>
{
	[Token(Token = "0x4001385")]
	[FieldOffset(Offset = "0x18")]
	public int origIndex;

	[Token(Token = "0x4001386")]
	[FieldOffset(Offset = "0x1C")]
	public int destIndex;

	[Token(Token = "0x4001387")]
	[FieldOffset(Offset = "0x20")]
	public RectInt location;

	[Token(Token = "0x4001388")]
	[FieldOffset(Offset = "0x30")]
	public GradientRemap next;

	[Token(Token = "0x4001389")]
	[FieldOffset(Offset = "0x38")]
	public TextureId atlas;

	[Token(Token = "0x60026AB")]
	[Address(RVA = "0x2A583F0", Offset = "0x2A575F0", VA = "0x182A583F0")]
	public void Reset()
	{
	}

	[Token(Token = "0x60026AC")]
	[Address(RVA = "0x2A58460", Offset = "0x2A57660", VA = "0x182A58460")]
	public GradientRemap()
	{
	}
}
