using Il2CppDummyDll;
using UnityEngine;

namespace Unity.Properties.Internal;

[Token(Token = "0x2000081")]
internal class Vector2IntPropertyBag : ContainerPropertyBag<Vector2Int>
{
	[Token(Token = "0x2000082")]
	private class XProperty : Property<Vector2Int, int>
	{
		[Token(Token = "0x1700006B")]
		public override string Name
		{
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x28FB9C0", Offset = "0x28FABC0", VA = "0x1828FB9C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006C")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x28FB6E0", Offset = "0x28FA8E0", VA = "0x1828FB6E0", Slot = "14")]
		public override int GetValue(ref Vector2Int container)
		{
			return default(int);
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x28FB700", Offset = "0x28FA900", VA = "0x1828FB700", Slot = "15")]
		public override void SetValue(ref Vector2Int container, int value)
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x28FB790", Offset = "0x28FA990", VA = "0x1828FB790")]
		public XProperty()
		{
		}
	}

	[Token(Token = "0x2000083")]
	private class YProperty : Property<Vector2Int, int>
	{
		[Token(Token = "0x1700006D")]
		public override string Name
		{
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x28FBC40", Offset = "0x28FAE40", VA = "0x1828FBC40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006E")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x28FBA20", Offset = "0x28FAC20", VA = "0x1828FBA20", Slot = "14")]
		public override int GetValue(ref Vector2Int container)
		{
			return default(int);
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x28FBA40", Offset = "0x28FAC40", VA = "0x1828FBA40", Slot = "15")]
		public override void SetValue(ref Vector2Int container, int value)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x28FBBD0", Offset = "0x28FADD0", VA = "0x1828FBBD0")]
		public YProperty()
		{
		}
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x28FAE50", Offset = "0x28FA050", VA = "0x1828FAE50")]
	public Vector2IntPropertyBag()
	{
	}
}
