using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;
using UnityEngine.Bindings;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements;

[Token(Token = "0x200042C")]
public struct StylePropertyName : IEquatable<StylePropertyName>
{
	[Token(Token = "0x200042D")]
	internal class PropertyBag : ContainerPropertyBag<StylePropertyName>
	{
		[Token(Token = "0x200042E")]
		private class IdProperty : Property<StylePropertyName, StylePropertyId>
		{
			[Token(Token = "0x17000874")]
			public override string Name
			{
				[Token(Token = "0x6001F5B")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000875")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x6001F5C")]
				[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6001F5D")]
			[Address(RVA = "0xD17EA0", Offset = "0xD170A0", VA = "0x180D17EA0", Slot = "14")]
			public override StylePropertyId GetValue(ref StylePropertyName container)
			{
				return default(StylePropertyId);
			}

			[Token(Token = "0x6001F5E")]
			[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "15")]
			public override void SetValue(ref StylePropertyName container, StylePropertyId value)
			{
			}

			[Token(Token = "0x6001F5F")]
			[Address(RVA = "0x29F7630", Offset = "0x29F6830", VA = "0x1829F7630")]
			public IdProperty()
			{
			}
		}

		[Token(Token = "0x200042F")]
		private class NameProperty : Property<StylePropertyName, string>
		{
			[Token(Token = "0x17000876")]
			public override string Name
			{
				[Token(Token = "0x6001F60")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000877")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x6001F61")]
				[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6001F62")]
			[Address(RVA = "0x4CAAA0", Offset = "0x4C9CA0", VA = "0x1804CAAA0", Slot = "14")]
			public override string GetValue(ref StylePropertyName container)
			{
				return null;
			}

			[Token(Token = "0x6001F63")]
			[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "15")]
			public override void SetValue(ref StylePropertyName container, string value)
			{
			}

			[Token(Token = "0x6001F64")]
			[Address(RVA = "0x29F78A0", Offset = "0x29F6AA0", VA = "0x1829F78A0")]
			public NameProperty()
			{
			}
		}

		[Token(Token = "0x6001F5A")]
		[Address(RVA = "0x29F7AF0", Offset = "0x29F6CF0", VA = "0x1829F7AF0")]
		public PropertyBag()
		{
		}
	}

	[Token(Token = "0x17000872")]
	internal readonly StylePropertyId id
	{
		[Token(Token = "0x6001F4E")]
		[Address(RVA = "0x8C8B50", Offset = "0x8C7D50", VA = "0x1808C8B50")]
		[CompilerGenerated]
		get
		{
			return default(StylePropertyId);
		}
	}

	[Token(Token = "0x17000873")]
	private readonly string name
	{
		[Token(Token = "0x6001F4F")]
		[Address(RVA = "0x5BF750", Offset = "0x5BE950", VA = "0x1805BF750")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001F50")]
	[Address(RVA = "0x29F8C90", Offset = "0x29F7E90", VA = "0x1829F8C90")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal static StylePropertyId StylePropertyIdFromString(string name)
	{
		return default(StylePropertyId);
	}

	[Token(Token = "0x6001F51")]
	[Address(RVA = "0x29F8E00", Offset = "0x29F8000", VA = "0x1829F8E00")]
	internal StylePropertyName(StylePropertyId stylePropertyId)
	{
	}

	[Token(Token = "0x6001F52")]
	[Address(RVA = "0x29F8D30", Offset = "0x29F7F30", VA = "0x1829F8D30")]
	public StylePropertyName(string name)
	{
	}

	[Token(Token = "0x6001F53")]
	[Address(RVA = "0x278E010", Offset = "0x278D210", VA = "0x18278E010")]
	public static bool operator ==(StylePropertyName lhs, StylePropertyName rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F54")]
	[Address(RVA = "0x29F8F00", Offset = "0x29F8100", VA = "0x1829F8F00")]
	public static bool operator !=(StylePropertyName lhs, StylePropertyName rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F55")]
	[Address(RVA = "0x29F8EC0", Offset = "0x29F80C0", VA = "0x1829F8EC0")]
	public static implicit operator StylePropertyName(string name)
	{
		return default(StylePropertyName);
	}

	[Token(Token = "0x6001F56")]
	[Address(RVA = "0x1500B10", Offset = "0x14FFD10", VA = "0x181500B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001F57")]
	[Address(RVA = "0x29F8C00", Offset = "0x29F7E00", VA = "0x1829F8C00", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F58")]
	[Address(RVA = "0x278E010", Offset = "0x278D210", VA = "0x18278E010", Slot = "4")]
	public bool Equals(StylePropertyName other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F59")]
	[Address(RVA = "0x1FA2BC0", Offset = "0x1FA1DC0", VA = "0x181FA2BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
