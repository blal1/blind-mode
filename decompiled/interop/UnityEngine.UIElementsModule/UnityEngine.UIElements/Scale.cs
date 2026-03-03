using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x20003CD")]
public struct Scale : IEquatable<Scale>
{
	[Token(Token = "0x20003CE")]
	internal class PropertyBag : ContainerPropertyBag<Scale>
	{
		[Token(Token = "0x20003CF")]
		private class ValueProperty : Property<Scale, Vector3>
		{
			[Token(Token = "0x1700081D")]
			public override string Name
			{
				[Token(Token = "0x6001CE8")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700081E")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x6001CE9")]
				[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6001CEA")]
			[Address(RVA = "0x1B3C5E0", Offset = "0x1B3B7E0", VA = "0x181B3C5E0", Slot = "14")]
			public override Vector3 GetValue(ref Scale container)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6001CEB")]
			[Address(RVA = "0x28D7F90", Offset = "0x28D7190", VA = "0x1828D7F90", Slot = "15")]
			public override void SetValue(ref Scale container, Vector3 value)
			{
			}

			[Token(Token = "0x6001CEC")]
			[Address(RVA = "0x29F05E0", Offset = "0x29EF7E0", VA = "0x1829F05E0")]
			public ValueProperty()
			{
			}
		}

		[Token(Token = "0x6001CE7")]
		[Address(RVA = "0x29E28F0", Offset = "0x29E1AF0", VA = "0x1829E28F0")]
		public PropertyBag()
		{
		}
	}

	[Token(Token = "0x4000CAD")]
	[FieldOffset(Offset = "0x0")]
	private Vector3 m_Scale;

	[Token(Token = "0x4000CAE")]
	[FieldOffset(Offset = "0xC")]
	private bool m_IsNone;

	[Token(Token = "0x1700081C")]
	public Vector3 value
	{
		[Token(Token = "0x6001CDF")]
		[Address(RVA = "0x1C255A0", Offset = "0x1C247A0", VA = "0x181C255A0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6001CE0")]
		[Address(RVA = "0x23D9B70", Offset = "0x23D8D70", VA = "0x1823D9B70")]
		set
		{
		}
	}

	[Token(Token = "0x6001CDC")]
	[Address(RVA = "0x25209B0", Offset = "0x251FBB0", VA = "0x1825209B0")]
	public Scale(Vector3 scale)
	{
	}

	[Token(Token = "0x6001CDD")]
	[Address(RVA = "0x29E5D60", Offset = "0x29E4F60", VA = "0x1829E5D60")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal static Scale Initial()
	{
		return default(Scale);
	}

	[Token(Token = "0x6001CDE")]
	[Address(RVA = "0x29E5DD0", Offset = "0x29E4FD0", VA = "0x1829E5DD0")]
	public static Scale None()
	{
		return default(Scale);
	}

	[Token(Token = "0x6001CE1")]
	[Address(RVA = "0x29E5E50", Offset = "0x29E5050", VA = "0x1829E5E50")]
	public static bool operator ==(Scale lhs, Scale rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CE2")]
	[Address(RVA = "0x29E5EB0", Offset = "0x29E50B0", VA = "0x1829E5EB0")]
	public static bool operator !=(Scale lhs, Scale rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CE3")]
	[Address(RVA = "0x29E5BE0", Offset = "0x29E4DE0", VA = "0x1829E5BE0", Slot = "4")]
	public bool Equals(Scale other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CE4")]
	[Address(RVA = "0x29E5C30", Offset = "0x29E4E30", VA = "0x1829E5C30", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CE5")]
	[Address(RVA = "0x29E5D00", Offset = "0x29E4F00", VA = "0x1829E5D00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001CE6")]
	[Address(RVA = "0x28044B0", Offset = "0x28036B0", VA = "0x1828044B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
