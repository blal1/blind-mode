using Il2CppDummyDll;
using UnityEngine;

namespace Unity.Properties.Internal;

[Token(Token = "0x2000088")]
internal class RectPropertyBag : ContainerPropertyBag<Rect>
{
	[Token(Token = "0x2000089")]
	private class XProperty : Property<Rect, float>
	{
		[Token(Token = "0x17000075")]
		public override string Name
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x28FB960", Offset = "0x28FAB60", VA = "0x1828FB960", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x28FB6F0", Offset = "0x28FA8F0", VA = "0x1828FB6F0", Slot = "14")]
		public override float GetValue(ref Rect container)
		{
			return default(float);
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x28F60F0", Offset = "0x28F52F0", VA = "0x1828F60F0", Slot = "15")]
		public override void SetValue(ref Rect container, float value)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x28FB810", Offset = "0x28FAA10", VA = "0x1828FB810")]
		public XProperty()
		{
		}
	}

	[Token(Token = "0x200008A")]
	private class YProperty : Property<Rect, float>
	{
		[Token(Token = "0x17000077")]
		public override string Name
		{
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x28FBCD0", Offset = "0x28FAED0", VA = "0x1828FBCD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x28FBA30", Offset = "0x28FAC30", VA = "0x1828FBA30", Slot = "14")]
		public override float GetValue(ref Rect container)
		{
			return default(float);
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x28D88A0", Offset = "0x28D7AA0", VA = "0x1828D88A0", Slot = "15")]
		public override void SetValue(ref Rect container, float value)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x28FBA50", Offset = "0x28FAC50", VA = "0x1828FBA50")]
		public YProperty()
		{
		}
	}

	[Token(Token = "0x200008B")]
	private class WidthProperty : Property<Rect, float>
	{
		[Token(Token = "0x17000079")]
		public override string Name
		{
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x28FB680", Offset = "0x28FA880", VA = "0x1828FB680", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x28FB5D0", Offset = "0x28FA7D0", VA = "0x1828FB5D0", Slot = "14")]
		public override float GetValue(ref Rect container)
		{
			return default(float);
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x28D7BD0", Offset = "0x28D6DD0", VA = "0x1828D7BD0", Slot = "15")]
		public override void SetValue(ref Rect container, float value)
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x28FB640", Offset = "0x28FA840", VA = "0x1828FB640")]
		public WidthProperty()
		{
		}
	}

	[Token(Token = "0x200008C")]
	private class HeightProperty : Property<Rect, float>
	{
		[Token(Token = "0x1700007B")]
		public override string Name
		{
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x28D8D30", Offset = "0x28D7F30", VA = "0x1828D8D30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x28D8C60", Offset = "0x28D7E60", VA = "0x1828D8C60", Slot = "14")]
		public override float GetValue(ref Rect container)
		{
			return default(float);
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x28D7950", Offset = "0x28D6B50", VA = "0x1828D7950", Slot = "15")]
		public override void SetValue(ref Rect container, float value)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x28D8C80", Offset = "0x28D7E80", VA = "0x1828D8C80")]
		public HeightProperty()
		{
		}
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x28F6340", Offset = "0x28F5540", VA = "0x1828F6340")]
	public RectPropertyBag()
	{
	}
}
