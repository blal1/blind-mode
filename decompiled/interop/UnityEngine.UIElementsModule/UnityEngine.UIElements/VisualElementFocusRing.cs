using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20004F1")]
public class VisualElementFocusRing : IFocusRing
{
	[Token(Token = "0x20004F2")]
	public enum DefaultFocusOrder
	{
		[Token(Token = "0x400103C")]
		ChildOrder,
		[Token(Token = "0x400103D")]
		PositionXY,
		[Token(Token = "0x400103E")]
		PositionYX
	}

	[Token(Token = "0x20004F3")]
	private class FocusRingRecord
	{
		[Token(Token = "0x400103F")]
		[FieldOffset(Offset = "0x10")]
		public int m_AutoIndex;

		[Token(Token = "0x4001040")]
		[FieldOffset(Offset = "0x18")]
		public Focusable m_Focusable;

		[Token(Token = "0x4001041")]
		[FieldOffset(Offset = "0x20")]
		public bool m_IsSlot;

		[Token(Token = "0x4001042")]
		[FieldOffset(Offset = "0x28")]
		public List<FocusRingRecord> m_ScopeNavigationOrder;

		[Token(Token = "0x60023B2")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public FocusRingRecord()
		{
		}
	}

	[Token(Token = "0x4001038")]
	[FieldOffset(Offset = "0x10")]
	private readonly VisualElement root;

	[Token(Token = "0x400103A")]
	[FieldOffset(Offset = "0x20")]
	private List<FocusRingRecord> m_FocusRing;

	[Token(Token = "0x1700095D")]
	private FocusController focusController
	{
		[Token(Token = "0x60023A5")]
		[Address(RVA = "0x1E412F0", Offset = "0x1E404F0", VA = "0x181E412F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700095E")]
	public DefaultFocusOrder defaultFocusOrder
	{
		[Token(Token = "0x60023A6")]
		[Address(RVA = "0x5C7C60", Offset = "0x5C6E60", VA = "0x1805C7C60")]
		[CompilerGenerated]
		get
		{
			return default(DefaultFocusOrder);
		}
		[Token(Token = "0x60023A7")]
		[Address(RVA = "0x615AB0", Offset = "0x614CB0", VA = "0x180615AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x60023A4")]
	[Address(RVA = "0x2A3E840", Offset = "0x2A3DA40", VA = "0x182A3E840")]
	public VisualElementFocusRing(VisualElement root, DefaultFocusOrder dfo = DefaultFocusOrder.ChildOrder)
	{
	}

	[Token(Token = "0x60023A8")]
	[Address(RVA = "0x2A3D550", Offset = "0x2A3C750", VA = "0x182A3D550")]
	private int FocusRingAutoIndexSort(FocusRingRecord a, FocusRingRecord b)
	{
		return default(int);
	}

	[Token(Token = "0x60023A9")]
	[Address(RVA = "0x2A3D910", Offset = "0x2A3CB10", VA = "0x182A3D910")]
	private int FocusRingSort(FocusRingRecord a, FocusRingRecord b)
	{
		return default(int);
	}

	[Token(Token = "0x60023AA")]
	[Address(RVA = "0x2A3D470", Offset = "0x2A3C670", VA = "0x182A3D470")]
	private void DoUpdate()
	{
	}

	[Token(Token = "0x60023AB")]
	[Address(RVA = "0x2A3D1A0", Offset = "0x2A3C3A0", VA = "0x182A3D1A0")]
	private void BuildRingForScopeRecursive(VisualElement ve, ref int scopeIndex, List<FocusRingRecord> scopeList)
	{
	}

	[Token(Token = "0x60023AC")]
	[Address(RVA = "0x2A3E5F0", Offset = "0x2A3D7F0", VA = "0x182A3E5F0")]
	private void SortAndFlattenScopeLists(List<FocusRingRecord> rootScopeList)
	{
	}

	[Token(Token = "0x60023AD")]
	[Address(RVA = "0x2A3DD60", Offset = "0x2A3CF60", VA = "0x182A3DD60")]
	private int GetFocusableInternalIndex(Focusable f)
	{
		return default(int);
	}

	[Token(Token = "0x60023AE")]
	[Address(RVA = "0x2A3DA30", Offset = "0x2A3CC30", VA = "0x182A3DA30", Slot = "4")]
	public FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e)
	{
		return null;
	}

	[Token(Token = "0x60023AF")]
	[Address(RVA = "0x2A3DEC0", Offset = "0x2A3D0C0", VA = "0x182A3DEC0", Slot = "5")]
	public Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction)
	{
		return null;
	}

	[Token(Token = "0x60023B0")]
	[Address(RVA = "0x2A3DE10", Offset = "0x2A3D010", VA = "0x182A3DE10")]
	internal static Focusable GetNextFocusableInTree(VisualElement currentFocusable)
	{
		return null;
	}

	[Token(Token = "0x60023B1")]
	[Address(RVA = "0x2A3E500", Offset = "0x2A3D700", VA = "0x182A3E500")]
	internal static Focusable GetPreviousFocusableInTree(VisualElement currentFocusable)
	{
		return null;
	}
}
