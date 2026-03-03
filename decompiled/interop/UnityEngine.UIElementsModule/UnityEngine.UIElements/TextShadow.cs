using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000466")]
public struct TextShadow : IEquatable<TextShadow>
{
	[Token(Token = "0x2000467")]
	internal class PropertyBag : ContainerPropertyBag<TextShadow>
	{
		[Token(Token = "0x2000468")]
		private class OffsetProperty : Property<TextShadow, Vector2>
		{
			[Token(Token = "0x170008FE")]
			public override string Name
			{
				[Token(Token = "0x6002164")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170008FF")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x6002165")]
				[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6002166")]
			[Address(RVA = "0x2A0A330", Offset = "0x2A09530", VA = "0x182A0A330", Slot = "14")]
			public override Vector2 GetValue(ref TextShadow container)
			{
				return default(Vector2);
			}

			[Token(Token = "0x6002167")]
			[Address(RVA = "0x29D84E0", Offset = "0x29D76E0", VA = "0x1829D84E0", Slot = "15")]
			public override void SetValue(ref TextShadow container, Vector2 value)
			{
			}

			[Token(Token = "0x6002168")]
			[Address(RVA = "0x2A0A350", Offset = "0x2A09550", VA = "0x182A0A350")]
			public OffsetProperty()
			{
			}
		}

		[Token(Token = "0x2000469")]
		private class BlurRadiusProperty : Property<TextShadow, float>
		{
			[Token(Token = "0x17000900")]
			public override string Name
			{
				[Token(Token = "0x6002169")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000901")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x600216A")]
				[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600216B")]
			[Address(RVA = "0x28D7BC0", Offset = "0x28D6DC0", VA = "0x1828D7BC0", Slot = "14")]
			public override float GetValue(ref TextShadow container)
			{
				return default(float);
			}

			[Token(Token = "0x600216C")]
			[Address(RVA = "0x28D7BD0", Offset = "0x28D6DD0", VA = "0x1828D7BD0", Slot = "15")]
			public override void SetValue(ref TextShadow container, float value)
			{
			}

			[Token(Token = "0x600216D")]
			[Address(RVA = "0x2A099F0", Offset = "0x2A08BF0", VA = "0x182A099F0")]
			public BlurRadiusProperty()
			{
			}
		}

		[Token(Token = "0x200046A")]
		private class ColorProperty : Property<TextShadow, Color>
		{
			[Token(Token = "0x17000902")]
			public override string Name
			{
				[Token(Token = "0x600216E")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000903")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x600216F")]
				[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6002170")]
			[Address(RVA = "0x2A09A60", Offset = "0x2A08C60", VA = "0x182A09A60", Slot = "14")]
			public override Color GetValue(ref TextShadow container)
			{
				return default(Color);
			}

			[Token(Token = "0x6002171")]
			[Address(RVA = "0x2A09A70", Offset = "0x2A08C70", VA = "0x182A09A70", Slot = "15")]
			public override void SetValue(ref TextShadow container, Color value)
			{
			}

			[Token(Token = "0x6002172")]
			[Address(RVA = "0x2A09A80", Offset = "0x2A08C80", VA = "0x182A09A80")]
			public ColorProperty()
			{
			}
		}

		[Token(Token = "0x6002163")]
		[Address(RVA = "0x2A0A3C0", Offset = "0x2A095C0", VA = "0x182A0A3C0")]
		public PropertyBag()
		{
		}
	}

	[Token(Token = "0x4000EDC")]
	[FieldOffset(Offset = "0x0")]
	public Vector2 offset;

	[Token(Token = "0x4000EDD")]
	[FieldOffset(Offset = "0x8")]
	public float blurRadius;

	[Token(Token = "0x4000EDE")]
	[FieldOffset(Offset = "0xC")]
	public Color color;

	[Token(Token = "0x600215C")]
	[Address(RVA = "0x2A11D60", Offset = "0x2A10F60", VA = "0x182A11D60", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x600215D")]
	[Address(RVA = "0x2A11E10", Offset = "0x2A11010", VA = "0x182A11E10", Slot = "4")]
	public bool Equals(TextShadow other)
	{
		return default(bool);
	}

	[Token(Token = "0x600215E")]
	[Address(RVA = "0x2A11ED0", Offset = "0x2A110D0", VA = "0x182A11ED0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600215F")]
	[Address(RVA = "0x2A121D0", Offset = "0x2A113D0", VA = "0x182A121D0")]
	public static bool operator ==(TextShadow style1, TextShadow style2)
	{
		return default(bool);
	}

	[Token(Token = "0x6002160")]
	[Address(RVA = "0x2A12200", Offset = "0x2A11400", VA = "0x182A12200")]
	public static bool operator !=(TextShadow style1, TextShadow style2)
	{
		return default(bool);
	}

	[Token(Token = "0x6002161")]
	[Address(RVA = "0x2A12100", Offset = "0x2A11300", VA = "0x182A12100", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002162")]
	[Address(RVA = "0x2A11FC0", Offset = "0x2A111C0", VA = "0x182A11FC0")]
	internal static TextShadow LerpUnclamped(TextShadow a, TextShadow b, float t)
	{
		return default(TextShadow);
	}
}
