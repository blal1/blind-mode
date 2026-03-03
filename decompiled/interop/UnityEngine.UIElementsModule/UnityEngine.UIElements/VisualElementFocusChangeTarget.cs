using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20004EF")]
internal class VisualElementFocusChangeTarget : FocusChangeDirection
{
	[Token(Token = "0x4001035")]
	[FieldOffset(Offset = "0x0")]
	private static readonly ObjectPool<VisualElementFocusChangeTarget> Pool;

	[Token(Token = "0x1700095C")]
	public Focusable target
	{
		[Token(Token = "0x600239E")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600239F")]
		[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600239A")]
	[Address(RVA = "0x2A3CF50", Offset = "0x2A3C150", VA = "0x182A3CF50")]
	public static VisualElementFocusChangeTarget GetPooled(Focusable target)
	{
		return null;
	}

	[Token(Token = "0x600239B")]
	[Address(RVA = "0x2A3CEC0", Offset = "0x2A3C0C0", VA = "0x182A3CEC0", Slot = "5")]
	protected override void Dispose()
	{
	}

	[Token(Token = "0x600239C")]
	[Address(RVA = "0x2A3CE70", Offset = "0x2A3C070", VA = "0x182A3CE70", Slot = "6")]
	internal override void ApplyTo(FocusController focusController, Focusable f)
	{
	}

	[Token(Token = "0x600239D")]
	[Address(RVA = "0x2A3D100", Offset = "0x2A3C300", VA = "0x182A3D100")]
	public VisualElementFocusChangeTarget()
	{
	}
}
