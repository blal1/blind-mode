using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000255")]
internal class NavigateFocusRing : IFocusRing
{
	[Token(Token = "0x2000256")]
	public class ChangeDirection : FocusChangeDirection
	{
		[Token(Token = "0x600104A")]
		[Address(RVA = "0x2B29B20", Offset = "0x2B28D20", VA = "0x182B29B20")]
		public ChangeDirection(int i)
		{
		}
	}

	[Token(Token = "0x2000257")]
	private struct FocusableHierarchyTraversal
	{
		[Token(Token = "0x4000920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VisualElement currentFocusable;

		[Token(Token = "0x4000921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Rect validRect;

		[Token(Token = "0x4000922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool firstPass;

		[Token(Token = "0x4000923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ChangeDirection direction;

		[Token(Token = "0x600104B")]
		[Address(RVA = "0x2B2D0A0", Offset = "0x2B2C2A0", VA = "0x182B2D0A0")]
		private bool ValidateHierarchyTraversal(VisualElement v)
		{
			return default(bool);
		}

		[Token(Token = "0x600104C")]
		[Address(RVA = "0x2B2CFA0", Offset = "0x2B2C1A0", VA = "0x182B2CFA0")]
		private bool ValidateElement(VisualElement v)
		{
			return default(bool);
		}

		[Token(Token = "0x600104D")]
		[Address(RVA = "0x2B2CB80", Offset = "0x2B2BD80", VA = "0x182B2CB80")]
		private int Order(VisualElement a, VisualElement b)
		{
			return default(int);
		}

		[Token(Token = "0x600104E")]
		[Address(RVA = "0x2B2CC30", Offset = "0x2B2BE30", VA = "0x182B2CC30")]
		private int StrictOrder(VisualElement a, VisualElement b)
		{
			return default(int);
		}

		[Token(Token = "0x600104F")]
		[Address(RVA = "0x2B2CCB0", Offset = "0x2B2BEB0", VA = "0x182B2CCB0")]
		private int StrictOrder(Rect ra, Rect rb)
		{
			return default(int);
		}

		[Token(Token = "0x6001050")]
		[Address(RVA = "0x2B2CE80", Offset = "0x2B2C080", VA = "0x182B2CE80")]
		private int TieBreaker(Rect ra, Rect rb)
		{
			return default(int);
		}

		[Token(Token = "0x6001051")]
		[Address(RVA = "0x2B2C980", Offset = "0x2B2BB80", VA = "0x182B2C980")]
		public VisualElement GetBestOverall(VisualElement candidate, [Optional] VisualElement bestSoFar)
		{
			return null;
		}
	}

	[Token(Token = "0x4000918")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly ChangeDirection Left;

	[Token(Token = "0x4000919")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static readonly ChangeDirection Right;

	[Token(Token = "0x400091A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static readonly ChangeDirection Up;

	[Token(Token = "0x400091B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static readonly ChangeDirection Down;

	[Token(Token = "0x400091C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static readonly FocusChangeDirection Next;

	[Token(Token = "0x400091D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static readonly FocusChangeDirection Previous;

	[Token(Token = "0x400091E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly VisualElement m_Root;

	[Token(Token = "0x400091F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly VisualElementFocusRing m_Ring;

	[Token(Token = "0x170002FC")]
	private FocusController focusController
	{
		[Token(Token = "0x6001042")]
		[Address(RVA = "0x1E412F0", Offset = "0x1E404F0", VA = "0x181E412F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001043")]
	[Address(RVA = "0x2B35670", Offset = "0x2B34870", VA = "0x182B35670")]
	public NavigateFocusRing(VisualElement root)
	{
	}

	[Token(Token = "0x6001044")]
	[Address(RVA = "0x2B34670", Offset = "0x2B33870", VA = "0x182B34670", Slot = "4")]
	public FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e)
	{
		return null;
	}

	[Token(Token = "0x6001045")]
	[Address(RVA = "0x2B35130", Offset = "0x2B34330", VA = "0x182B35130", Slot = "6")]
	public virtual Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction)
	{
		return null;
	}

	[Token(Token = "0x6001046")]
	[Address(RVA = "0x2B34B30", Offset = "0x2B33D30", VA = "0x182B34B30")]
	private Focusable GetNextFocusable2D(Focusable currentFocusable, ChangeDirection direction)
	{
		return null;
	}

	[Token(Token = "0x6001047")]
	[Address(RVA = "0x2B35290", Offset = "0x2B34490", VA = "0x182B35290")]
	private static bool IsActive(VisualElement v)
	{
		return default(bool);
	}

	[Token(Token = "0x6001048")]
	[Address(RVA = "0x2B35300", Offset = "0x2B34500", VA = "0x182B35300")]
	private static bool IsNavigable(Focusable focusable)
	{
		return default(bool);
	}
}
