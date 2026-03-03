using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x200000A")]
public struct BackgroundPosition : IEquatable<BackgroundPosition>
{
	[Token(Token = "0x200000B")]
	internal class PropertyBag : ContainerPropertyBag<BackgroundPosition>
	{
		[Token(Token = "0x200000C")]
		private class KeywordProperty : Property<BackgroundPosition, BackgroundPositionKeyword>
		{
			[Token(Token = "0x17000008")]
			public override string Name
			{
				[Token(Token = "0x6000035")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000009")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x6000036")]
				[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000037")]
			[Address(RVA = "0xD17EA0", Offset = "0xD170A0", VA = "0x180D17EA0", Slot = "14")]
			public override BackgroundPositionKeyword GetValue(ref BackgroundPosition container)
			{
				return default(BackgroundPositionKeyword);
			}

			[Token(Token = "0x6000038")]
			[Address(RVA = "0x28FB700", Offset = "0x28FA900", VA = "0x1828FB700", Slot = "15")]
			public override void SetValue(ref BackgroundPosition container, BackgroundPositionKeyword value)
			{
			}

			[Token(Token = "0x6000039")]
			[Address(RVA = "0x29975F0", Offset = "0x29967F0", VA = "0x1829975F0")]
			public KeywordProperty()
			{
			}
		}

		[Token(Token = "0x200000D")]
		private class OffsetProperty : Property<BackgroundPosition, Length>
		{
			[Token(Token = "0x1700000A")]
			public override string Name
			{
				[Token(Token = "0x600003A")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000B")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x600003B")]
				[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600003C")]
			[Address(RVA = "0x2997800", Offset = "0x2996A00", VA = "0x182997800", Slot = "14")]
			public override Length GetValue(ref BackgroundPosition container)
			{
				return default(Length);
			}

			[Token(Token = "0x600003D")]
			[Address(RVA = "0x2997810", Offset = "0x2996A10", VA = "0x182997810", Slot = "15")]
			public override void SetValue(ref BackgroundPosition container, Length value)
			{
			}

			[Token(Token = "0x600003E")]
			[Address(RVA = "0x2997820", Offset = "0x2996A20", VA = "0x182997820")]
			public OffsetProperty()
			{
			}
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2997A10", Offset = "0x2996C10", VA = "0x182997A10")]
		public PropertyBag()
		{
		}
	}

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x0")]
	public BackgroundPositionKeyword keyword;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x4")]
	public Length offset;

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x2974A20", Offset = "0x2973C20", VA = "0x182974A20")]
	public BackgroundPosition(BackgroundPositionKeyword keyword)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x1697E90", Offset = "0x1697090", VA = "0x181697E90")]
	public BackgroundPosition(BackgroundPositionKeyword keyword, Length offset)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x2974930", Offset = "0x2973B30", VA = "0x182974930")]
	internal static BackgroundPosition Initial()
	{
		return default(BackgroundPosition);
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x2974840", Offset = "0x2973A40", VA = "0x182974840", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x29747F0", Offset = "0x29739F0", VA = "0x1829747F0", Slot = "4")]
	public bool Equals(BackgroundPosition other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x29748F0", Offset = "0x2973AF0", VA = "0x1829748F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x2974A60", Offset = "0x2973C60", VA = "0x182974A60")]
	public static bool operator ==(BackgroundPosition style1, BackgroundPosition style2)
	{
		return default(bool);
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x2974AD0", Offset = "0x2973CD0", VA = "0x182974AD0")]
	public static bool operator !=(BackgroundPosition style1, BackgroundPosition style2)
	{
		return default(bool);
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x2974980", Offset = "0x2973B80", VA = "0x182974980", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
