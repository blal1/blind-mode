using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Serializable]
[Token(Token = "0x2000163")]
public struct ToggleButtonGroupState : IEquatable<ToggleButtonGroupState>, IComparable<ToggleButtonGroupState>
{
	[Token(Token = "0x40006FF")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	private ulong m_Data;

	[Token(Token = "0x4000700")]
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	private int m_Length;

	[Token(Token = "0x170001D1")]
	public int length
	{
		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0x130E8C0", Offset = "0x130DAC0", VA = "0x18130E8C0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0x1EDF6D0", Offset = "0x1EDE8D0", VA = "0x181EDF6D0")]
		[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal set
		{
		}
	}

	[Token(Token = "0x170001D2")]
	internal ulong data
	{
		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0x5BF740", Offset = "0x5BE940", VA = "0x1805BF740")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x170001D3")]
	public bool this[int index]
	{
		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0x2B00DB0", Offset = "0x2AFFFB0", VA = "0x182B00DB0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0x2B00EE0", Offset = "0x2B000E0", VA = "0x182B00EE0")]
		set
		{
		}
	}

	[Token(Token = "0x6000AB5")]
	[Address(RVA = "0x2B00CA0", Offset = "0x2AFFEA0", VA = "0x182B00CA0")]
	public ToggleButtonGroupState(ulong optionsBitMask, int length)
	{
	}

	[Token(Token = "0x6000ABB")]
	[Address(RVA = "0x2B009A0", Offset = "0x2AFFBA0", VA = "0x182B009A0")]
	public Span<int> GetActiveOptions(Span<int> activeOptionsIndices)
	{
		return default(Span<int>);
	}

	[Token(Token = "0x6000ABC")]
	[Address(RVA = "0x1DB7D60", Offset = "0x1DB6F60", VA = "0x181DB7D60")]
	public void ResetAllOptions()
	{
	}

	[Token(Token = "0x6000ABD")]
	[Address(RVA = "0x2B008D0", Offset = "0x2AFFAD0", VA = "0x182B008D0", Slot = "5")]
	public int CompareTo(ToggleButtonGroupState other)
	{
		return default(int);
	}

	[Token(Token = "0x6000ABE")]
	[Address(RVA = "0x2B00BD0", Offset = "0x2AFFDD0", VA = "0x182B00BD0")]
	private void ResetOptions(int startingIndex)
	{
	}

	[Token(Token = "0x6000ABF")]
	[Address(RVA = "0x12CB400", Offset = "0x12CA600", VA = "0x1812CB400")]
	public static bool operator ==(ToggleButtonGroupState lhs, ToggleButtonGroupState rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6000AC0")]
	[Address(RVA = "0x2B00EA0", Offset = "0x2B000A0", VA = "0x182B00EA0")]
	public static bool operator !=(ToggleButtonGroupState lhs, ToggleButtonGroupState rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6000AC1")]
	[Address(RVA = "0x12CB400", Offset = "0x12CA600", VA = "0x1812CB400", Slot = "4")]
	public bool Equals(ToggleButtonGroupState other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000AC2")]
	[Address(RVA = "0x2B00910", Offset = "0x2AFFB10", VA = "0x182B00910", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000AC3")]
	[Address(RVA = "0x2B00B60", Offset = "0x2AFFD60", VA = "0x182B00B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000AC4")]
	[Address(RVA = "0x2B00C20", Offset = "0x2AFFE20", VA = "0x182B00C20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
