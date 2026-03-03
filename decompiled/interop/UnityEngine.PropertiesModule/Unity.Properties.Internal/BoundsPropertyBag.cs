using Il2CppDummyDll;
using UnityEngine;

namespace Unity.Properties.Internal;

[Token(Token = "0x2000092")]
internal class BoundsPropertyBag : ContainerPropertyBag<Bounds>
{
	[Token(Token = "0x2000093")]
	private class CenterProperty : Property<Bounds, Vector3>
	{
		[Token(Token = "0x17000085")]
		public override string Name
		{
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x28D7FF0", Offset = "0x28D71F0", VA = "0x1828D7FF0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000086")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x28D7F70", Offset = "0x28D7170", VA = "0x1828D7F70", Slot = "14")]
		public override Vector3 GetValue(ref Bounds container)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x28D7F90", Offset = "0x28D7190", VA = "0x1828D7F90", Slot = "15")]
		public override void SetValue(ref Bounds container, Vector3 value)
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x28D7FB0", Offset = "0x28D71B0", VA = "0x1828D7FB0")]
		public CenterProperty()
		{
		}
	}

	[Token(Token = "0x2000094")]
	private class ExtentsProperty : Property<Bounds, Vector3>
	{
		[Token(Token = "0x17000087")]
		public override string Name
		{
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x28D8780", Offset = "0x28D7980", VA = "0x1828D8780", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000088")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x28D8700", Offset = "0x28D7900", VA = "0x1828D8700", Slot = "14")]
		public override Vector3 GetValue(ref Bounds container)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x28D8720", Offset = "0x28D7920", VA = "0x1828D8720", Slot = "15")]
		public override void SetValue(ref Bounds container, Vector3 value)
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x28D8740", Offset = "0x28D7940", VA = "0x1828D8740")]
		public ExtentsProperty()
		{
		}
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x28D7D70", Offset = "0x28D6F70", VA = "0x1828D7D70")]
	public BoundsPropertyBag()
	{
	}
}
