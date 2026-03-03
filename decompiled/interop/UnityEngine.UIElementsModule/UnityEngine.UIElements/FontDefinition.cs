using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;
using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements;

[Token(Token = "0x20002D6")]
public struct FontDefinition : IEquatable<FontDefinition>
{
	[Token(Token = "0x20002D7")]
	internal class PropertyBag : ContainerPropertyBag<FontDefinition>
	{
		[Token(Token = "0x20002D8")]
		private class FontProperty : Property<FontDefinition, Font>
		{
			[Token(Token = "0x17000413")]
			public override string Name
			{
				[Token(Token = "0x6001449")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000414")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x600144A")]
				[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600144B")]
			[Address(RVA = "0x2B5EAA0", Offset = "0x2B5DCA0", VA = "0x182B5EAA0", Slot = "14")]
			public override Font GetValue(ref FontDefinition container)
			{
				return null;
			}

			[Token(Token = "0x600144C")]
			[Address(RVA = "0x2B5EAB0", Offset = "0x2B5DCB0", VA = "0x182B5EAB0", Slot = "15")]
			public override void SetValue(ref FontDefinition container, Font value)
			{
			}

			[Token(Token = "0x600144D")]
			[Address(RVA = "0x2B5EAD0", Offset = "0x2B5DCD0", VA = "0x182B5EAD0")]
			public FontProperty()
			{
			}
		}

		[Token(Token = "0x20002D9")]
		private class FontAssetProperty : Property<FontDefinition, FontAsset>
		{
			[Token(Token = "0x17000415")]
			public override string Name
			{
				[Token(Token = "0x600144E")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000416")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x600144F")]
				[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6001450")]
			[Address(RVA = "0x2B5E2F0", Offset = "0x2B5D4F0", VA = "0x182B5E2F0", Slot = "14")]
			public override FontAsset GetValue(ref FontDefinition container)
			{
				return null;
			}

			[Token(Token = "0x6001451")]
			[Address(RVA = "0x2B5E300", Offset = "0x2B5D500", VA = "0x182B5E300", Slot = "15")]
			public override void SetValue(ref FontDefinition container, FontAsset value)
			{
			}

			[Token(Token = "0x6001452")]
			[Address(RVA = "0x2B5E320", Offset = "0x2B5D520", VA = "0x182B5E320")]
			public FontAssetProperty()
			{
			}
		}

		[Token(Token = "0x6001448")]
		[Address(RVA = "0x2B6C250", Offset = "0x2B6B450", VA = "0x182B6C250")]
		public PropertyBag()
		{
		}
	}

	[Token(Token = "0x4000B75")]
	[FieldOffset(Offset = "0x0")]
	private Font m_Font;

	[Token(Token = "0x4000B76")]
	[FieldOffset(Offset = "0x8")]
	private FontAsset m_FontAsset;

	[Token(Token = "0x17000411")]
	public Font font
	{
		[Token(Token = "0x600143A")]
		[Address(RVA = "0x10E5520", Offset = "0x10E4720", VA = "0x1810E5520")]
		get
		{
			return null;
		}
		[Token(Token = "0x600143B")]
		[Address(RVA = "0x2B5E9B0", Offset = "0x2B5DBB0", VA = "0x182B5E9B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000412")]
	public FontAsset fontAsset
	{
		[Token(Token = "0x600143C")]
		[Address(RVA = "0x1FA2BC0", Offset = "0x1FA1DC0", VA = "0x181FA2BC0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600143D")]
		[Address(RVA = "0x2B5E8C0", Offset = "0x2B5DAC0", VA = "0x182B5E8C0")]
		set
		{
		}
	}

	[Token(Token = "0x600143E")]
	[Address(RVA = "0x2B5E490", Offset = "0x2B5D690", VA = "0x182B5E490")]
	public static FontDefinition FromFont(Font f)
	{
		return default(FontDefinition);
	}

	[Token(Token = "0x600143F")]
	[Address(RVA = "0x2B5E620", Offset = "0x2B5D820", VA = "0x182B5E620")]
	public static FontDefinition FromSDFFont(FontAsset f)
	{
		return default(FontDefinition);
	}

	[Token(Token = "0x6001440")]
	[Address(RVA = "0x2B5E4D0", Offset = "0x2B5D6D0", VA = "0x182B5E4D0")]
	internal static FontDefinition FromObject(object obj)
	{
		return default(FontDefinition);
	}

	[Token(Token = "0x6001441")]
	[Address(RVA = "0x2B5E750", Offset = "0x2B5D950", VA = "0x182B5E750")]
	internal bool IsEmpty()
	{
		return default(bool);
	}

	[Token(Token = "0x6001442")]
	[Address(RVA = "0x2B5E7E0", Offset = "0x2B5D9E0", VA = "0x182B5E7E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001443")]
	[Address(RVA = "0x2B5E440", Offset = "0x2B5D640", VA = "0x182B5E440", Slot = "4")]
	public bool Equals(FontDefinition other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001444")]
	[Address(RVA = "0x2B5E390", Offset = "0x2B5D590", VA = "0x182B5E390", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6001445")]
	[Address(RVA = "0x2B5E660", Offset = "0x2B5D860", VA = "0x182B5E660", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001446")]
	[Address(RVA = "0x2B5E440", Offset = "0x2B5D640", VA = "0x182B5E440")]
	public static bool operator ==(FontDefinition left, FontDefinition right)
	{
		return default(bool);
	}

	[Token(Token = "0x6001447")]
	[Address(RVA = "0x2B5E870", Offset = "0x2B5DA70", VA = "0x182B5E870")]
	public static bool operator !=(FontDefinition left, FontDefinition right)
	{
		return default(bool);
	}
}
