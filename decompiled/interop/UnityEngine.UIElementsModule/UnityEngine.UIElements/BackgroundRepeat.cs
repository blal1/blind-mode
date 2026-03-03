using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x200000F")]
public struct BackgroundRepeat : IEquatable<BackgroundRepeat>
{
	[Token(Token = "0x2000010")]
	internal class PropertyBag : ContainerPropertyBag<BackgroundRepeat>
	{
		[Token(Token = "0x2000011")]
		private class XProperty : Property<BackgroundRepeat, Repeat>
		{
			[Token(Token = "0x1700000C")]
			public override string Name
			{
				[Token(Token = "0x600004C")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000D")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x600004D")]
				[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600004E")]
			[Address(RVA = "0xD17EA0", Offset = "0xD170A0", VA = "0x180D17EA0", Slot = "14")]
			public override Repeat GetValue(ref BackgroundRepeat container)
			{
				return default(Repeat);
			}

			[Token(Token = "0x600004F")]
			[Address(RVA = "0x28FB700", Offset = "0x28FA900", VA = "0x1828FB700", Slot = "15")]
			public override void SetValue(ref BackgroundRepeat container, Repeat value)
			{
			}

			[Token(Token = "0x6000050")]
			[Address(RVA = "0x2999770", Offset = "0x2998970", VA = "0x182999770")]
			public XProperty()
			{
			}
		}

		[Token(Token = "0x2000012")]
		private class YProperty : Property<BackgroundRepeat, Repeat>
		{
			[Token(Token = "0x1700000E")]
			public override string Name
			{
				[Token(Token = "0x6000051")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000F")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x6000052")]
				[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000053")]
			[Address(RVA = "0x29997E0", Offset = "0x29989E0", VA = "0x1829997E0", Slot = "14")]
			public override Repeat GetValue(ref BackgroundRepeat container)
			{
				return default(Repeat);
			}

			[Token(Token = "0x6000054")]
			[Address(RVA = "0x28FBA40", Offset = "0x28FAC40", VA = "0x1828FBA40", Slot = "15")]
			public override void SetValue(ref BackgroundRepeat container, Repeat value)
			{
			}

			[Token(Token = "0x6000055")]
			[Address(RVA = "0x2999880", Offset = "0x2998A80", VA = "0x182999880")]
			public YProperty()
			{
			}
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x2997890", Offset = "0x2996A90", VA = "0x182997890")]
		public PropertyBag()
		{
		}
	}

	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x0")]
	public Repeat x;

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x4")]
	public Repeat y;

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xB684C0", Offset = "0xB676C0", VA = "0x180B684C0")]
	public BackgroundRepeat(Repeat repeatX, Repeat repeatY)
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x15BAEE0", Offset = "0x15BA0E0", VA = "0x1815BAEE0")]
	internal static BackgroundRepeat Initial()
	{
		return default(BackgroundRepeat);
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x2974FC0", Offset = "0x29741C0", VA = "0x182974FC0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x2797330", Offset = "0x2796530", VA = "0x182797330", Slot = "4")]
	public bool Equals(BackgroundRepeat other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x2975050", Offset = "0x2974250", VA = "0x182975050", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x2975120", Offset = "0x2974320", VA = "0x182975120")]
	public static bool operator ==(BackgroundRepeat style1, BackgroundRepeat style2)
	{
		return default(bool);
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x2975140", Offset = "0x2974340", VA = "0x182975140")]
	public static bool operator !=(BackgroundRepeat style1, BackgroundRepeat style2)
	{
		return default(bool);
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x2975090", Offset = "0x2974290", VA = "0x182975090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
