using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000250")]
public class FocusChangeDirection : IDisposable
{
	[Token(Token = "0x4000909")]
	[FieldOffset(Offset = "0x10")]
	private readonly int m_Value;

	[Token(Token = "0x170002EE")]
	public static FocusChangeDirection unspecified
	{
		[Token(Token = "0x600100D")]
		[Address(RVA = "0x2B2A6A0", Offset = "0x2B298A0", VA = "0x182B2A6A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002EF")]
	public static FocusChangeDirection none
	{
		[Token(Token = "0x600100E")]
		[Address(RVA = "0x2B2A650", Offset = "0x2B29850", VA = "0x182B2A650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002F0")]
	protected static FocusChangeDirection lastValue
	{
		[Token(Token = "0x600100F")]
		[Address(RVA = "0x2B2A600", Offset = "0x2B29800", VA = "0x182B2A600")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001010")]
	[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
	protected FocusChangeDirection(int value)
	{
	}

	[Token(Token = "0x6001011")]
	[Address(RVA = "0x2B2A6F0", Offset = "0x2B298F0", VA = "0x182B2A6F0")]
	public static implicit operator int(FocusChangeDirection fcd)
	{
		return default(int);
	}

	[Token(Token = "0x6001012")]
	[Address(RVA = "0x417C60", Offset = "0x416E60", VA = "0x180417C60", Slot = "4")]
	private void System_002EIDisposable_002EDispose()
	{
	}

	[Token(Token = "0x6001013")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
	protected virtual void Dispose()
	{
	}

	[Token(Token = "0x6001014")]
	[Address(RVA = "0x2B2A4A0", Offset = "0x2B296A0", VA = "0x182B2A4A0", Slot = "6")]
	internal virtual void ApplyTo(FocusController focusController, Focusable f)
	{
	}
}
