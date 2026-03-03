using Il2CppDummyDll;
using UnityEngine.UI;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001465")]
public class CraftIconBinder : ResourceBinderBase
{
	[Token(Token = "0x400C697")]
	[FieldOffset(Offset = "0x10")]
	public readonly string[] m_CraftIconPath;

	[Token(Token = "0x6007F08")]
	[Address(RVA = "0x438FD0", Offset = "0x4381D0", VA = "0x180438FD0")]
	public CraftIconBinder(string[] craftIconPath)
	{
	}

	[Token(Token = "0x6007F09")]
	[Address(RVA = "0xC73A30", Offset = "0xC72C30", VA = "0x180C73A30")]
	public string GetCraftIconPath(int id)
	{
		return null;
	}

	[Token(Token = "0x6007F0A")]
	[Address(RVA = "0xC739E0", Offset = "0xC72BE0", VA = "0x180C739E0")]
	public BindingImageEx BindCraftIcon(Image target, int id, bool async = true)
	{
		return null;
	}
}
