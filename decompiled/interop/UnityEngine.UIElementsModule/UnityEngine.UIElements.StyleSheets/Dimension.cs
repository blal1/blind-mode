using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements.StyleSheets;

[Serializable]
[Token(Token = "0x20005C2")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal struct Dimension : IEquatable<Dimension>
{
	[Token(Token = "0x20005C3")]
	public enum Unit
	{
		[Token(Token = "0x4001547")]
		Unitless,
		[Token(Token = "0x4001548")]
		Pixel,
		[Token(Token = "0x4001549")]
		Percent,
		[Token(Token = "0x400154A")]
		Second,
		[Token(Token = "0x400154B")]
		Millisecond,
		[Token(Token = "0x400154C")]
		Degree,
		[Token(Token = "0x400154D")]
		Gradian,
		[Token(Token = "0x400154E")]
		Radian,
		[Token(Token = "0x400154F")]
		Turn
	}

	[Token(Token = "0x4001544")]
	[FieldOffset(Offset = "0x0")]
	public Unit unit;

	[Token(Token = "0x4001545")]
	[FieldOffset(Offset = "0x4")]
	public float value;

	[Token(Token = "0x600283C")]
	[Address(RVA = "0x2A82220", Offset = "0x2A81420", VA = "0x182A82220")]
	public Dimension(float value, Unit unit)
	{
	}

	[Token(Token = "0x600283D")]
	[Address(RVA = "0x2A82020", Offset = "0x2A81220", VA = "0x182A82020")]
	public Length ToLength()
	{
		return default(Length);
	}

	[Token(Token = "0x600283E")]
	[Address(RVA = "0x2A821F0", Offset = "0x2A813F0", VA = "0x182A821F0")]
	public TimeValue ToTime()
	{
		return default(TimeValue);
	}

	[Token(Token = "0x600283F")]
	[Address(RVA = "0x2A81F90", Offset = "0x2A81190", VA = "0x182A81F90")]
	public Angle ToAngle()
	{
		return default(Angle);
	}

	[Token(Token = "0x6002840")]
	[Address(RVA = "0x2A82230", Offset = "0x2A81430", VA = "0x182A82230")]
	public static bool operator ==(Dimension lhs, Dimension rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6002841")]
	[Address(RVA = "0x2A81F20", Offset = "0x2A81120", VA = "0x182A81F20", Slot = "4")]
	public bool Equals(Dimension other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002842")]
	[Address(RVA = "0x2A81E60", Offset = "0x2A81060", VA = "0x182A81E60", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6002843")]
	[Address(RVA = "0x2A81F50", Offset = "0x2A81150", VA = "0x182A81F50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002844")]
	[Address(RVA = "0x2A82050", Offset = "0x2A81250", VA = "0x182A82050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
