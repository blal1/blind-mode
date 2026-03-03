using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Events;
using YgomSystem.UI;

namespace YgomGame.Menu;

[Token(Token = "0x2001238")]
public class LoginBonusButton
{
	[Token(Token = "0x400BA9C")]
	[FieldOffset(Offset = "0x10")]
	private readonly SelectionButton _btn;

	[Token(Token = "0x170011DD")]
	internal bool enable
	{
		[Token(Token = "0x6007172")]
		[Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007171")]
		[Address(RVA = "0x662770", Offset = "0x661970", VA = "0x180662770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170011DE")]
	internal string text
	{
		[Token(Token = "0x6007174")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6007173")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170011DF")]
	internal string schemeURL
	{
		[Token(Token = "0x6007176")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6007175")]
		[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170011E0")]
	internal UnityAction onSelected
	{
		[Token(Token = "0x6007177")]
		[Address(RVA = "0xB77A50", Offset = "0xB76C50", VA = "0x180B77A50")]
		set
		{
		}
	}

	[Token(Token = "0x6007178")]
	[Address(RVA = "0xB77990", Offset = "0xB76B90", VA = "0x180B77990")]
	internal LoginBonusButton(SelectionButton btn, bool enable = false)
	{
	}

	[Token(Token = "0x6007179")]
	[Address(RVA = "0xB77640", Offset = "0xB76840", VA = "0x180B77640")]
	internal void SetData(object src)
	{
	}

	[Token(Token = "0x600717A")]
	[Address(RVA = "0xB775B0", Offset = "0xB767B0", VA = "0x180B775B0")]
	internal void Activate()
	{
	}
}
