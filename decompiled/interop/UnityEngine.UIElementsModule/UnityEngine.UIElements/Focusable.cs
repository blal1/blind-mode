using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x200024F")]
public abstract class Focusable : CallbackEventHandler
{
	[Token(Token = "0x40008FD")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly BindingId focusableProperty;

	[Token(Token = "0x40008FE")]
	[FieldOffset(Offset = "0x98")]
	internal static readonly BindingId tabIndexProperty;

	[Token(Token = "0x40008FF")]
	[FieldOffset(Offset = "0x130")]
	internal static readonly BindingId delegatesFocusProperty;

	[Token(Token = "0x4000900")]
	[FieldOffset(Offset = "0x1C8")]
	internal static readonly BindingId canGrabFocusProperty;

	[Token(Token = "0x4000901")]
	[FieldOffset(Offset = "0x20")]
	private bool m_Focusable;

	[Token(Token = "0x4000902")]
	[FieldOffset(Offset = "0x24")]
	private int m_TabIndex;

	[Token(Token = "0x4000903")]
	[FieldOffset(Offset = "0x28")]
	private bool m_DelegatesFocus;

	[Token(Token = "0x4000904")]
	[FieldOffset(Offset = "0x29")]
	private bool m_ExcludeFromFocusRing;

	[Token(Token = "0x170002E7")]
	public abstract FocusController focusController
	{
		[Token(Token = "0x6000FFB")]
		get;
	}

	[Token(Token = "0x170002E8")]
	[CreateProperty]
	public virtual bool focusable
	{
		[Token(Token = "0x6000FFC")]
		[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "16")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000FFD")]
		[Address(RVA = "0x2B2DBB0", Offset = "0x2B2CDB0", VA = "0x182B2DBB0", Slot = "17")]
		set
		{
		}
	}

	[Token(Token = "0x170002E9")]
	[CreateProperty]
	public int tabIndex
	{
		[Token(Token = "0x6000FFE")]
		[Address(RVA = "0x416290", Offset = "0x415490", VA = "0x180416290")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000FFF")]
		[Address(RVA = "0x2B2DC30", Offset = "0x2B2CE30", VA = "0x182B2DC30")]
		set
		{
		}
	}

	[Token(Token = "0x170002EA")]
	[CreateProperty]
	public bool delegatesFocus
	{
		[Token(Token = "0x6001000")]
		[Address(RVA = "0x2B2DA30", Offset = "0x2B2CC30", VA = "0x182B2DA30")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001001")]
		[Address(RVA = "0x2B2DA50", Offset = "0x2B2CC50", VA = "0x182B2DA50")]
		set
		{
		}
	}

	[Token(Token = "0x170002EB")]
	internal bool excludeFromFocusRing
	{
		[Token(Token = "0x6001002")]
		[Address(RVA = "0x2B2DA40", Offset = "0x2B2CC40", VA = "0x182B2DA40")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001003")]
		[Address(RVA = "0x2B2DAD0", Offset = "0x2B2CCD0", VA = "0x182B2DAD0")]
		set
		{
		}
	}

	[Token(Token = "0x170002EC")]
	internal bool isEligibleToReceiveFocusFromDisabledChild
	{
		[Token(Token = "0x6001004")]
		[Address(RVA = "0x25152E0", Offset = "0x25144E0", VA = "0x1825152E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001005")]
		[Address(RVA = "0x25129D0", Offset = "0x2511BD0", VA = "0x1825129D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170002ED")]
	[CreateProperty(ReadOnly = true)]
	public virtual bool canGrabFocus
	{
		[Token(Token = "0x6001006")]
		[Address(RVA = "0x1E6AF80", Offset = "0x1E6A180", VA = "0x181E6AF80", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000FFA")]
	[Address(RVA = "0x2B2D970", Offset = "0x2B2CB70", VA = "0x182B2D970")]
	protected Focusable()
	{
	}

	[Token(Token = "0x6001007")]
	[Address(RVA = "0x2B2D270", Offset = "0x2B2C470", VA = "0x182B2D270", Slot = "19")]
	public virtual void Focus()
	{
	}

	[Token(Token = "0x6001008")]
	[Address(RVA = "0x2B2D220", Offset = "0x2B2C420", VA = "0x182B2D220", Slot = "20")]
	public virtual void Blur()
	{
	}

	[Token(Token = "0x6001009")]
	[Address(RVA = "0x2B2D1D0", Offset = "0x2B2C3D0", VA = "0x182B2D1D0")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal void BlurImmediately()
	{
	}

	[Token(Token = "0x600100A")]
	[Address(RVA = "0x2B2D550", Offset = "0x2B2C750", VA = "0x182B2D550")]
	internal Focusable GetFocusDelegate()
	{
		return null;
	}

	[Token(Token = "0x600100B")]
	[Address(RVA = "0x2B2D3C0", Offset = "0x2B2C5C0", VA = "0x182B2D3C0")]
	private static Focusable GetFirstFocusableChild(VisualElement ve)
	{
		return null;
	}
}
