using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace YgomSystem.UI;

[Token(Token = "0x2000564")]
public class UiSwitchTweenAnimationController : MonoBehaviour
{
	[Token(Token = "0x4001A59")]
	[FieldOffset(Offset = "0x38")]
	public bool activeControl;

	[Token(Token = "0x4001A5A")]
	[FieldOffset(Offset = "0x40")]
	public string labelShow;

	[Token(Token = "0x4001A5B")]
	[FieldOffset(Offset = "0x48")]
	public string labelShow_Event;

	[Token(Token = "0x4001A5C")]
	[FieldOffset(Offset = "0x50")]
	public string labelHide;

	[Token(Token = "0x4001A5D")]
	[FieldOffset(Offset = "0x58")]
	public string labelHide_Event;

	[Token(Token = "0x4001A5E")]
	[FieldOffset(Offset = "0x60")]
	public string labelChain;

	[Token(Token = "0x4001A5F")]
	[FieldOffset(Offset = "0x68")]
	public string labelChain_Event;

	[Token(Token = "0x14000030")]
	public event UnityAction onShow
	{
		[Token(Token = "0x60022F8")]
		[Address(RVA = "0x659E60", Offset = "0x659060", VA = "0x180659E60")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60022F9")]
		[Address(RVA = "0x65A050", Offset = "0x659250", VA = "0x18065A050")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000031")]
	public event UnityAction onHide
	{
		[Token(Token = "0x60022FA")]
		[Address(RVA = "0x659DC0", Offset = "0x658FC0", VA = "0x180659DC0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60022FB")]
		[Address(RVA = "0x659FB0", Offset = "0x6591B0", VA = "0x180659FB0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000032")]
	public event UnityAction<int> onChain
	{
		[Token(Token = "0x60022FC")]
		[Address(RVA = "0x659D10", Offset = "0x658F10", VA = "0x180659D10")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60022FD")]
		[Address(RVA = "0x659F00", Offset = "0x659100", VA = "0x180659F00")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60022FE")]
	[Address(RVA = "0x659330", Offset = "0x658530", VA = "0x180659330")]
	private void Awake()
	{
	}

	[Token(Token = "0x60022FF")]
	[Address(RVA = "0x659900", Offset = "0x658B00", VA = "0x180659900")]
	public bool Show()
	{
		return default(bool);
	}

	[Token(Token = "0x6002300")]
	[Address(RVA = "0x659630", Offset = "0x658830", VA = "0x180659630")]
	public bool Hide()
	{
		return default(bool);
	}

	[Token(Token = "0x6002301")]
	[Address(RVA = "0x3F2960", Offset = "0x3F1B60", VA = "0x1803F2960")]
	private void OnShow()
	{
	}

	[Token(Token = "0x6002302")]
	[Address(RVA = "0x659880", Offset = "0x658A80", VA = "0x180659880")]
	private void OnHide()
	{
	}

	[Token(Token = "0x6002303")]
	[Address(RVA = "0x659810", Offset = "0x658A10", VA = "0x180659810")]
	private void OnChain(int index)
	{
	}

	[Token(Token = "0x6002304")]
	[Address(RVA = "0x659B70", Offset = "0x658D70", VA = "0x180659B70")]
	private void StopAllTween()
	{
	}

	[Token(Token = "0x6002305")]
	[Address(RVA = "0x659830", Offset = "0x658A30", VA = "0x180659830")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002306")]
	[Address(RVA = "0x659BF0", Offset = "0x658DF0", VA = "0x180659BF0")]
	public UiSwitchTweenAnimationController()
	{
	}
}
