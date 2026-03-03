using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x20002DC")]
internal class InlineStyleAccessPropertyBag : PropertyBag<InlineStyleAccess>, INamedProperties<InlineStyleAccess>
{
	[Token(Token = "0x20002DD")]
	private class AlignContentProperty : InlineStyleEnumProperty<Align>
	{
		[Token(Token = "0x1700046C")]
		public override string Name
		{
			[Token(Token = "0x600152F")]
			[Address(RVA = "0x29B47E0", Offset = "0x29B39E0", VA = "0x1829B47E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700046D")]
		public override string ussName
		{
			[Token(Token = "0x6001530")]
			[Address(RVA = "0x29B4810", Offset = "0x29B3A10", VA = "0x1829B4810", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700046E")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6001531")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001532")]
		[Address(RVA = "0x29B46F0", Offset = "0x29B38F0", VA = "0x1829B46F0", Slot = "14")]
		public override StyleEnum<Align> GetValue(ref InlineStyleAccess container)
		{
			return default(StyleEnum<Align>);
		}

		[Token(Token = "0x6001533")]
		[Address(RVA = "0x29B4740", Offset = "0x29B3940", VA = "0x1829B4740", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleEnum<Align> value)
		{
		}

		[Token(Token = "0x6001534")]
		[Address(RVA = "0x29B47A0", Offset = "0x29B39A0", VA = "0x1829B47A0")]
		public AlignContentProperty()
		{
		}
	}

	[Token(Token = "0x20002DE")]
	private class AlignItemsProperty : InlineStyleEnumProperty<Align>
	{
		[Token(Token = "0x1700046F")]
		public override string Name
		{
			[Token(Token = "0x6001535")]
			[Address(RVA = "0x29B4930", Offset = "0x29B3B30", VA = "0x1829B4930", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000470")]
		public override string ussName
		{
			[Token(Token = "0x6001536")]
			[Address(RVA = "0x29B4960", Offset = "0x29B3B60", VA = "0x1829B4960", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000471")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6001537")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001538")]
		[Address(RVA = "0x29B4840", Offset = "0x29B3A40", VA = "0x1829B4840", Slot = "14")]
		public override StyleEnum<Align> GetValue(ref InlineStyleAccess container)
		{
			return default(StyleEnum<Align>);
		}

		[Token(Token = "0x6001539")]
		[Address(RVA = "0x29B4890", Offset = "0x29B3A90", VA = "0x1829B4890", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleEnum<Align> value)
		{
		}

		[Token(Token = "0x600153A")]
		[Address(RVA = "0x29B48F0", Offset = "0x29B3AF0", VA = "0x1829B48F0")]
		public AlignItemsProperty()
		{
		}
	}

	[Token(Token = "0x20002DF")]
	private class AlignSelfProperty : InlineStyleEnumProperty<Align>
	{
		[Token(Token = "0x17000472")]
		public override string Name
		{
			[Token(Token = "0x600153B")]
			[Address(RVA = "0x29B4A80", Offset = "0x29B3C80", VA = "0x1829B4A80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000473")]
		public override string ussName
		{
			[Token(Token = "0x600153C")]
			[Address(RVA = "0x29B4AB0", Offset = "0x29B3CB0", VA = "0x1829B4AB0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000474")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x600153D")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600153E")]
		[Address(RVA = "0x29B4990", Offset = "0x29B3B90", VA = "0x1829B4990", Slot = "14")]
		public override StyleEnum<Align> GetValue(ref InlineStyleAccess container)
		{
			return default(StyleEnum<Align>);
		}

		[Token(Token = "0x600153F")]
		[Address(RVA = "0x29B49E0", Offset = "0x29B3BE0", VA = "0x1829B49E0", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleEnum<Align> value)
		{
		}

		[Token(Token = "0x6001540")]
		[Address(RVA = "0x29B4A40", Offset = "0x29B3C40", VA = "0x1829B4A40")]
		public AlignSelfProperty()
		{
		}
	}

	[Token(Token = "0x20002E0")]
	private class BackgroundColorProperty : InlineStyleColorProperty
	{
		[Token(Token = "0x17000475")]
		public override string Name
		{
			[Token(Token = "0x6001541")]
			[Address(RVA = "0x29B4CB0", Offset = "0x29B3EB0", VA = "0x1829B4CB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000476")]
		public override string ussName
		{
			[Token(Token = "0x6001542")]
			[Address(RVA = "0x29B4CE0", Offset = "0x29B3EE0", VA = "0x1829B4CE0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000477")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6001543")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001544")]
		[Address(RVA = "0x29B4AE0", Offset = "0x29B3CE0", VA = "0x1829B4AE0", Slot = "14")]
		public override StyleColor GetValue(ref InlineStyleAccess container)
		{
			return default(StyleColor);
		}

		[Token(Token = "0x6001545")]
		[Address(RVA = "0x29B4BC0", Offset = "0x29B3DC0", VA = "0x1829B4BC0", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleColor value)
		{
		}

		[Token(Token = "0x6001546")]
		[Address(RVA = "0x29B4CA0", Offset = "0x29B3EA0", VA = "0x1829B4CA0")]
		public BackgroundColorProperty()
		{
		}
	}

	[Token(Token = "0x20002E1")]
	private class BackgroundImageProperty : InlineStyleBackgroundProperty
	{
		[Token(Token = "0x17000478")]
		public override string Name
		{
			[Token(Token = "0x6001547")]
			[Address(RVA = "0x29B4F00", Offset = "0x29B4100", VA = "0x1829B4F00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000479")]
		public override string ussName
		{
			[Token(Token = "0x6001548")]
			[Address(RVA = "0x29B4F30", Offset = "0x29B4130", VA = "0x1829B4F30", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700047A")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6001549")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600154A")]
		[Address(RVA = "0x29B4D10", Offset = "0x29B3F10", VA = "0x1829B4D10", Slot = "14")]
		public override StyleBackground GetValue(ref InlineStyleAccess container)
		{
			return default(StyleBackground);
		}

		[Token(Token = "0x600154B")]
		[Address(RVA = "0x29B4E00", Offset = "0x29B4000", VA = "0x1829B4E00", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleBackground value)
		{
		}

		[Token(Token = "0x600154C")]
		[Address(RVA = "0x29B4EF0", Offset = "0x29B40F0", VA = "0x1829B4EF0")]
		public BackgroundImageProperty()
		{
		}
	}

	[Token(Token = "0x20002E2")]
	private class BackgroundPositionXProperty : InlineStyleBackgroundPositionProperty
	{
		[Token(Token = "0x1700047B")]
		public override string Name
		{
			[Token(Token = "0x600154D")]
			[Address(RVA = "0x29B5140", Offset = "0x29B4340", VA = "0x1829B5140", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700047C")]
		public override string ussName
		{
			[Token(Token = "0x600154E")]
			[Address(RVA = "0x29B5170", Offset = "0x29B4370", VA = "0x1829B5170", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700047D")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x600154F")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001550")]
		[Address(RVA = "0x29B4F60", Offset = "0x29B4160", VA = "0x1829B4F60", Slot = "14")]
		public override StyleBackgroundPosition GetValue(ref InlineStyleAccess container)
		{
			return default(StyleBackgroundPosition);
		}

		[Token(Token = "0x6001551")]
		[Address(RVA = "0x29B5030", Offset = "0x29B4230", VA = "0x1829B5030", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleBackgroundPosition value)
		{
		}

		[Token(Token = "0x6001552")]
		[Address(RVA = "0x29B5100", Offset = "0x29B4300", VA = "0x1829B5100")]
		public BackgroundPositionXProperty()
		{
		}
	}

	[Token(Token = "0x20002E3")]
	private class BackgroundPositionYProperty : InlineStyleBackgroundPositionProperty
	{
		[Token(Token = "0x1700047E")]
		public override string Name
		{
			[Token(Token = "0x6001553")]
			[Address(RVA = "0x29B5340", Offset = "0x29B4540", VA = "0x1829B5340", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700047F")]
		public override string ussName
		{
			[Token(Token = "0x6001554")]
			[Address(RVA = "0x29B5370", Offset = "0x29B4570", VA = "0x1829B5370", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000480")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6001555")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001556")]
		[Address(RVA = "0x29B51A0", Offset = "0x29B43A0", VA = "0x1829B51A0", Slot = "14")]
		public override StyleBackgroundPosition GetValue(ref InlineStyleAccess container)
		{
			return default(StyleBackgroundPosition);
		}

		[Token(Token = "0x6001557")]
		[Address(RVA = "0x29B5270", Offset = "0x29B4470", VA = "0x1829B5270", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleBackgroundPosition value)
		{
		}

		[Token(Token = "0x6001558")]
		[Address(RVA = "0x29B5100", Offset = "0x29B4300", VA = "0x1829B5100")]
		public BackgroundPositionYProperty()
		{
		}
	}

	[Token(Token = "0x20002E4")]
	private class BackgroundRepeatProperty : InlineStyleBackgroundRepeatProperty
	{
		[Token(Token = "0x17000481")]
		public override string Name
		{
			[Token(Token = "0x6001559")]
			[Address(RVA = "0x29B55A0", Offset = "0x29B47A0", VA = "0x1829B55A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000482")]
		public override string ussName
		{
			[Token(Token = "0x600155A")]
			[Address(RVA = "0x29B55D0", Offset = "0x29B47D0", VA = "0x1829B55D0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000483")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x600155B")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600155C")]
		[Address(RVA = "0x29B53A0", Offset = "0x29B45A0", VA = "0x1829B53A0", Slot = "14")]
		public override StyleBackgroundRepeat GetValue(ref InlineStyleAccess container)
		{
			return default(StyleBackgroundRepeat);
		}

		[Token(Token = "0x600155D")]
		[Address(RVA = "0x29B5480", Offset = "0x29B4680", VA = "0x1829B5480", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleBackgroundRepeat value)
		{
		}

		[Token(Token = "0x600155E")]
		[Address(RVA = "0x29B5560", Offset = "0x29B4760", VA = "0x1829B5560")]
		public BackgroundRepeatProperty()
		{
		}
	}

	[Token(Token = "0x20002E5")]
	private class BackgroundSizeProperty : InlineStyleBackgroundSizeProperty
	{
		[Token(Token = "0x17000484")]
		public override string Name
		{
			[Token(Token = "0x600155F")]
			[Address(RVA = "0x29B5800", Offset = "0x29B4A00", VA = "0x1829B5800", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000485")]
		public override string ussName
		{
			[Token(Token = "0x6001560")]
			[Address(RVA = "0x29B5830", Offset = "0x29B4A30", VA = "0x1829B5830", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000486")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6001561")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001562")]
		[Address(RVA = "0x29B5600", Offset = "0x29B4800", VA = "0x1829B5600", Slot = "14")]
		public override StyleBackgroundSize GetValue(ref InlineStyleAccess container)
		{
			return default(StyleBackgroundSize);
		}

		[Token(Token = "0x6001563")]
		[Address(RVA = "0x29B56E0", Offset = "0x29B48E0", VA = "0x1829B56E0", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleBackgroundSize value)
		{
		}

		[Token(Token = "0x6001564")]
		[Address(RVA = "0x29B57C0", Offset = "0x29B49C0", VA = "0x1829B57C0")]
		public BackgroundSizeProperty()
		{
		}
	}

	[Token(Token = "0x20002E6")]
	private class BorderBottomColorProperty : InlineStyleColorProperty
	{
		[Token(Token = "0x17000487")]
		public override string Name
		{
			[Token(Token = "0x6001565")]
			[Address(RVA = "0x29B5A20", Offset = "0x29B4C20", VA = "0x1829B5A20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000488")]
		public override string ussName
		{
			[Token(Token = "0x6001566")]
			[Address(RVA = "0x29B5A50", Offset = "0x29B4C50", VA = "0x1829B5A50", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000489")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6001567")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001568")]
		[Address(RVA = "0x29B5860", Offset = "0x29B4A60", VA = "0x1829B5860", Slot = "14")]
		public override StyleColor GetValue(ref InlineStyleAccess container)
		{
			return default(StyleColor);
		}

		[Token(Token = "0x6001569")]
		[Address(RVA = "0x29B5940", Offset = "0x29B4B40", VA = "0x1829B5940", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleColor value)
		{
		}

		[Token(Token = "0x600156A")]
		[Address(RVA = "0x29B4CA0", Offset = "0x29B3EA0", VA = "0x1829B4CA0")]
		public BorderBottomColorProperty()
		{
		}
	}

	[Token(Token = "0x20002E7")]
	private class BorderBottomLeftRadiusProperty : InlineStyleLengthProperty
	{
		[Token(Token = "0x1700048A")]
		public override string Name
		{
			[Token(Token = "0x600156B")]
			[Address(RVA = "0x29B5C50", Offset = "0x29B4E50", VA = "0x1829B5C50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700048B")]
		public override string ussName
		{
			[Token(Token = "0x600156C")]
			[Address(RVA = "0x29B5C80", Offset = "0x29B4E80", VA = "0x1829B5C80", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700048C")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x600156D")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600156E")]
		[Address(RVA = "0x29B5A80", Offset = "0x29B4C80", VA = "0x1829B5A80", Slot = "14")]
		public override StyleLength GetValue(ref InlineStyleAccess container)
		{
			return default(StyleLength);
		}

		[Token(Token = "0x600156F")]
		[Address(RVA = "0x29B5B60", Offset = "0x29B4D60", VA = "0x1829B5B60", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleLength value)
		{
		}

		[Token(Token = "0x6001570")]
		[Address(RVA = "0x29B5C40", Offset = "0x29B4E40", VA = "0x1829B5C40")]
		public BorderBottomLeftRadiusProperty()
		{
		}
	}

	[Token(Token = "0x20002E8")]
	private class BorderBottomRightRadiusProperty : InlineStyleLengthProperty
	{
		[Token(Token = "0x1700048D")]
		public override string Name
		{
			[Token(Token = "0x6001571")]
			[Address(RVA = "0x29B5E70", Offset = "0x29B5070", VA = "0x1829B5E70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700048E")]
		public override string ussName
		{
			[Token(Token = "0x6001572")]
			[Address(RVA = "0x29B5EA0", Offset = "0x29B50A0", VA = "0x1829B5EA0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700048F")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6001573")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001574")]
		[Address(RVA = "0x29B5CB0", Offset = "0x29B4EB0", VA = "0x1829B5CB0", Slot = "14")]
		public override StyleLength GetValue(ref InlineStyleAccess container)
		{
			return default(StyleLength);
		}

		[Token(Token = "0x6001575")]
		[Address(RVA = "0x29B5D90", Offset = "0x29B4F90", VA = "0x1829B5D90", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleLength value)
		{
		}

		[Token(Token = "0x6001576")]
		[Address(RVA = "0x29B5C40", Offset = "0x29B4E40", VA = "0x1829B5C40")]
		public BorderBottomRightRadiusProperty()
		{
		}
	}

	[Token(Token = "0x20002E9")]
	private class BorderBottomWidthProperty : InlineStyleFloatProperty
	{
		[Token(Token = "0x17000490")]
		public override string Name
		{
			[Token(Token = "0x6001577")]
			[Address(RVA = "0x29B5F90", Offset = "0x29B5190", VA = "0x1829B5F90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000491")]
		public override string ussName
		{
			[Token(Token = "0x6001578")]
			[Address(RVA = "0x29B5FC0", Offset = "0x29B51C0", VA = "0x1829B5FC0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000492")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6001579")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600157A")]
		[Address(RVA = "0x29B5ED0", Offset = "0x29B50D0", VA = "0x1829B5ED0", Slot = "14")]
		public override StyleFloat GetValue(ref InlineStyleAccess container)
		{
			return default(StyleFloat);
		}

		[Token(Token = "0x600157B")]
		[Address(RVA = "0x29B5F20", Offset = "0x29B5120", VA = "0x1829B5F20", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleFloat value)
		{
		}

		[Token(Token = "0x600157C")]
		[Address(RVA = "0x29B5F80", Offset = "0x29B5180", VA = "0x1829B5F80")]
		public BorderBottomWidthProperty()
		{
		}
	}

	[Token(Token = "0x20002EA")]
	private class BorderLeftColorProperty : InlineStyleColorProperty
	{
		[Token(Token = "0x17000493")]
		public override string Name
		{
			[Token(Token = "0x600157D")]
			[Address(RVA = "0x29B61B0", Offset = "0x29B53B0", VA = "0x1829B61B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000494")]
		public override string ussName
		{
			[Token(Token = "0x600157E")]
			[Address(RVA = "0x29B61E0", Offset = "0x29B53E0", VA = "0x1829B61E0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000495")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x600157F")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001580")]
		[Address(RVA = "0x29B5FF0", Offset = "0x29B51F0", VA = "0x1829B5FF0", Slot = "14")]
		public override StyleColor GetValue(ref InlineStyleAccess container)
		{
			return default(StyleColor);
		}

		[Token(Token = "0x6001581")]
		[Address(RVA = "0x29B60D0", Offset = "0x29B52D0", VA = "0x1829B60D0", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleColor value)
		{
		}

		[Token(Token = "0x6001582")]
		[Address(RVA = "0x29B4CA0", Offset = "0x29B3EA0", VA = "0x1829B4CA0")]
		public BorderLeftColorProperty()
		{
		}
	}

	[Token(Token = "0x20002EB")]
	private class BorderLeftWidthProperty : InlineStyleFloatProperty
	{
		[Token(Token = "0x17000496")]
		public override string Name
		{
			[Token(Token = "0x6001583")]
			[Address(RVA = "0x29B62C0", Offset = "0x29B54C0", VA = "0x1829B62C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000497")]
		public override string ussName
		{
			[Token(Token = "0x6001584")]
			[Address(RVA = "0x29B62F0", Offset = "0x29B54F0", VA = "0x1829B62F0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000498")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6001585")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001586")]
		[Address(RVA = "0x29B6210", Offset = "0x29B5410", VA = "0x1829B6210", Slot = "14")]
		public override StyleFloat GetValue(ref InlineStyleAccess container)
		{
			return default(StyleFloat);
		}

		[Token(Token = "0x6001587")]
		[Address(RVA = "0x29B6260", Offset = "0x29B5460", VA = "0x1829B6260", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleFloat value)
		{
		}

		[Token(Token = "0x6001588")]
		[Address(RVA = "0x29B5F80", Offset = "0x29B5180", VA = "0x1829B5F80")]
		public BorderLeftWidthProperty()
		{
		}
	}

	[Token(Token = "0x20002EC")]
	private class BorderRightColorProperty : InlineStyleColorProperty
	{
		[Token(Token = "0x17000499")]
		public override string Name
		{
			[Token(Token = "0x6001589")]
			[Address(RVA = "0x29B64E0", Offset = "0x29B56E0", VA = "0x1829B64E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700049A")]
		public override string ussName
		{
			[Token(Token = "0x600158A")]
			[Address(RVA = "0x29B6510", Offset = "0x29B5710", VA = "0x1829B6510", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700049B")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x600158B")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600158C")]
		[Address(RVA = "0x29B6320", Offset = "0x29B5520", VA = "0x1829B6320", Slot = "14")]
		public override StyleColor GetValue(ref InlineStyleAccess container)
		{
			return default(StyleColor);
		}

		[Token(Token = "0x600158D")]
		[Address(RVA = "0x29B6400", Offset = "0x29B5600", VA = "0x1829B6400", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleColor value)
		{
		}

		[Token(Token = "0x600158E")]
		[Address(RVA = "0x29B4CA0", Offset = "0x29B3EA0", VA = "0x1829B4CA0")]
		public BorderRightColorProperty()
		{
		}
	}

	[Token(Token = "0x20002ED")]
	private class BorderRightWidthProperty : InlineStyleFloatProperty
	{
		[Token(Token = "0x1700049C")]
		public override string Name
		{
			[Token(Token = "0x600158F")]
			[Address(RVA = "0x29B65F0", Offset = "0x29B57F0", VA = "0x1829B65F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700049D")]
		public override string ussName
		{
			[Token(Token = "0x6001590")]
			[Address(RVA = "0x29B6620", Offset = "0x29B5820", VA = "0x1829B6620", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700049E")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6001591")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001592")]
		[Address(RVA = "0x29B6540", Offset = "0x29B5740", VA = "0x1829B6540", Slot = "14")]
		public override StyleFloat GetValue(ref InlineStyleAccess container)
		{
			return default(StyleFloat);
		}

		[Token(Token = "0x6001593")]
		[Address(RVA = "0x29B6590", Offset = "0x29B5790", VA = "0x1829B6590", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleFloat value)
		{
		}

		[Token(Token = "0x6001594")]
		[Address(RVA = "0x29B5F80", Offset = "0x29B5180", VA = "0x1829B5F80")]
		public BorderRightWidthProperty()
		{
		}
	}

	[Token(Token = "0x20002EE")]
	private class BorderTopColorProperty : InlineStyleColorProperty
	{
		[Token(Token = "0x1700049F")]
		public override string Name
		{
			[Token(Token = "0x6001595")]
			[Address(RVA = "0x29B6810", Offset = "0x29B5A10", VA = "0x1829B6810", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004A0")]
		public override string ussName
		{
			[Token(Token = "0x6001596")]
			[Address(RVA = "0x29B6840", Offset = "0x29B5A40", VA = "0x1829B6840", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004A1")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6001597")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001598")]
		[Address(RVA = "0x29B6650", Offset = "0x29B5850", VA = "0x1829B6650", Slot = "14")]
		public override StyleColor GetValue(ref InlineStyleAccess container)
		{
			return default(StyleColor);
		}

		[Token(Token = "0x6001599")]
		[Address(RVA = "0x29B6730", Offset = "0x29B5930", VA = "0x1829B6730", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleColor value)
		{
		}

		[Token(Token = "0x600159A")]
		[Address(RVA = "0x29B4CA0", Offset = "0x29B3EA0", VA = "0x1829B4CA0")]
		public BorderTopColorProperty()
		{
		}
	}

	[Token(Token = "0x20002EF")]
	private class BorderTopLeftRadiusProperty : InlineStyleLengthProperty
	{
		[Token(Token = "0x170004A2")]
		public override string Name
		{
			[Token(Token = "0x600159B")]
			[Address(RVA = "0x29B6A30", Offset = "0x29B5C30", VA = "0x1829B6A30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004A3")]
		public override string ussName
		{
			[Token(Token = "0x600159C")]
			[Address(RVA = "0x29B6A60", Offset = "0x29B5C60", VA = "0x1829B6A60", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004A4")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x600159D")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600159E")]
		[Address(RVA = "0x29B6870", Offset = "0x29B5A70", VA = "0x1829B6870", Slot = "14")]
		public override StyleLength GetValue(ref InlineStyleAccess container)
		{
			return default(StyleLength);
		}

		[Token(Token = "0x600159F")]
		[Address(RVA = "0x29B6950", Offset = "0x29B5B50", VA = "0x1829B6950", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleLength value)
		{
		}

		[Token(Token = "0x60015A0")]
		[Address(RVA = "0x29B5C40", Offset = "0x29B4E40", VA = "0x1829B5C40")]
		public BorderTopLeftRadiusProperty()
		{
		}
	}

	[Token(Token = "0x20002F0")]
	private class BorderTopRightRadiusProperty : InlineStyleLengthProperty
	{
		[Token(Token = "0x170004A5")]
		public override string Name
		{
			[Token(Token = "0x60015A1")]
			[Address(RVA = "0x29B6C50", Offset = "0x29B5E50", VA = "0x1829B6C50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004A6")]
		public override string ussName
		{
			[Token(Token = "0x60015A2")]
			[Address(RVA = "0x29B6C80", Offset = "0x29B5E80", VA = "0x1829B6C80", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004A7")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60015A3")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60015A4")]
		[Address(RVA = "0x29B6A90", Offset = "0x29B5C90", VA = "0x1829B6A90", Slot = "14")]
		public override StyleLength GetValue(ref InlineStyleAccess container)
		{
			return default(StyleLength);
		}

		[Token(Token = "0x60015A5")]
		[Address(RVA = "0x29B6B70", Offset = "0x29B5D70", VA = "0x1829B6B70", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleLength value)
		{
		}

		[Token(Token = "0x60015A6")]
		[Address(RVA = "0x29B5C40", Offset = "0x29B4E40", VA = "0x1829B5C40")]
		public BorderTopRightRadiusProperty()
		{
		}
	}

	[Token(Token = "0x20002F1")]
	private class BorderTopWidthProperty : InlineStyleFloatProperty
	{
		[Token(Token = "0x170004A8")]
		public override string Name
		{
			[Token(Token = "0x60015A7")]
			[Address(RVA = "0x29B6D60", Offset = "0x29B5F60", VA = "0x1829B6D60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004A9")]
		public override string ussName
		{
			[Token(Token = "0x60015A8")]
			[Address(RVA = "0x29B6D90", Offset = "0x29B5F90", VA = "0x1829B6D90", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004AA")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60015A9")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60015AA")]
		[Address(RVA = "0x29B6CB0", Offset = "0x29B5EB0", VA = "0x1829B6CB0", Slot = "14")]
		public override StyleFloat GetValue(ref InlineStyleAccess container)
		{
			return default(StyleFloat);
		}

		[Token(Token = "0x60015AB")]
		[Address(RVA = "0x29B6D00", Offset = "0x29B5F00", VA = "0x1829B6D00", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleFloat value)
		{
		}

		[Token(Token = "0x60015AC")]
		[Address(RVA = "0x29B5F80", Offset = "0x29B5180", VA = "0x1829B5F80")]
		public BorderTopWidthProperty()
		{
		}
	}

	[Token(Token = "0x20002F2")]
	private class BottomProperty : InlineStyleLengthProperty
	{
		[Token(Token = "0x170004AB")]
		public override string Name
		{
			[Token(Token = "0x60015AD")]
			[Address(RVA = "0x29B6F80", Offset = "0x29B6180", VA = "0x1829B6F80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004AC")]
		public override string ussName
		{
			[Token(Token = "0x60015AE")]
			[Address(RVA = "0x29B6FB0", Offset = "0x29B61B0", VA = "0x1829B6FB0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004AD")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60015AF")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60015B0")]
		[Address(RVA = "0x29B6DC0", Offset = "0x29B5FC0", VA = "0x1829B6DC0", Slot = "14")]
		public override StyleLength GetValue(ref InlineStyleAccess container)
		{
			return default(StyleLength);
		}

		[Token(Token = "0x60015B1")]
		[Address(RVA = "0x29B6EA0", Offset = "0x29B60A0", VA = "0x1829B6EA0", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleLength value)
		{
		}

		[Token(Token = "0x60015B2")]
		[Address(RVA = "0x29B5C40", Offset = "0x29B4E40", VA = "0x1829B5C40")]
		public BottomProperty()
		{
		}
	}

	[Token(Token = "0x20002F3")]
	private class ColorProperty : InlineStyleColorProperty
	{
		[Token(Token = "0x170004AE")]
		public override string Name
		{
			[Token(Token = "0x60015B3")]
			[Address(RVA = "0x29B71A0", Offset = "0x29B63A0", VA = "0x1829B71A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004AF")]
		public override string ussName
		{
			[Token(Token = "0x60015B4")]
			[Address(RVA = "0x29B71D0", Offset = "0x29B63D0", VA = "0x1829B71D0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004B0")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60015B5")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60015B6")]
		[Address(RVA = "0x29B6FE0", Offset = "0x29B61E0", VA = "0x1829B6FE0", Slot = "14")]
		public override StyleColor GetValue(ref InlineStyleAccess container)
		{
			return default(StyleColor);
		}

		[Token(Token = "0x60015B7")]
		[Address(RVA = "0x29B70C0", Offset = "0x29B62C0", VA = "0x1829B70C0", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleColor value)
		{
		}

		[Token(Token = "0x60015B8")]
		[Address(RVA = "0x29B4CA0", Offset = "0x29B3EA0", VA = "0x1829B4CA0")]
		public ColorProperty()
		{
		}
	}

	[Token(Token = "0x20002F4")]
	private class CursorProperty : InlineStyleCursorProperty
	{
		[Token(Token = "0x170004B1")]
		public override string Name
		{
			[Token(Token = "0x60015B9")]
			[Address(RVA = "0x29B7400", Offset = "0x29B6600", VA = "0x1829B7400", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004B2")]
		public override string ussName
		{
			[Token(Token = "0x60015BA")]
			[Address(RVA = "0x29B7430", Offset = "0x29B6630", VA = "0x1829B7430", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004B3")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60015BB")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60015BC")]
		[Address(RVA = "0x29B7200", Offset = "0x29B6400", VA = "0x1829B7200", Slot = "14")]
		public override StyleCursor GetValue(ref InlineStyleAccess container)
		{
			return default(StyleCursor);
		}

		[Token(Token = "0x60015BD")]
		[Address(RVA = "0x29B72E0", Offset = "0x29B64E0", VA = "0x1829B72E0", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleCursor value)
		{
		}

		[Token(Token = "0x60015BE")]
		[Address(RVA = "0x29B73C0", Offset = "0x29B65C0", VA = "0x1829B73C0")]
		public CursorProperty()
		{
		}
	}

	[Token(Token = "0x20002F5")]
	private class DisplayProperty : InlineStyleEnumProperty<DisplayStyle>
	{
		[Token(Token = "0x170004B4")]
		public override string Name
		{
			[Token(Token = "0x60015BF")]
			[Address(RVA = "0x29B7620", Offset = "0x29B6820", VA = "0x1829B7620", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004B5")]
		public override string ussName
		{
			[Token(Token = "0x60015C0")]
			[Address(RVA = "0x29B7650", Offset = "0x29B6850", VA = "0x1829B7650", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004B6")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60015C1")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60015C2")]
		[Address(RVA = "0x29B7460", Offset = "0x29B6660", VA = "0x1829B7460", Slot = "14")]
		public override StyleEnum<DisplayStyle> GetValue(ref InlineStyleAccess container)
		{
			return default(StyleEnum<DisplayStyle>);
		}

		[Token(Token = "0x60015C3")]
		[Address(RVA = "0x29B7520", Offset = "0x29B6720", VA = "0x1829B7520", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleEnum<DisplayStyle> value)
		{
		}

		[Token(Token = "0x60015C4")]
		[Address(RVA = "0x29B75E0", Offset = "0x29B67E0", VA = "0x1829B75E0")]
		public DisplayProperty()
		{
		}
	}

	[Token(Token = "0x20002F6")]
	private class FlexBasisProperty : InlineStyleLengthProperty
	{
		[Token(Token = "0x170004B7")]
		public override string Name
		{
			[Token(Token = "0x60015C5")]
			[Address(RVA = "0x29B7840", Offset = "0x29B6A40", VA = "0x1829B7840", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004B8")]
		public override string ussName
		{
			[Token(Token = "0x60015C6")]
			[Address(RVA = "0x29B7870", Offset = "0x29B6A70", VA = "0x1829B7870", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004B9")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60015C7")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60015C8")]
		[Address(RVA = "0x29B7680", Offset = "0x29B6880", VA = "0x1829B7680", Slot = "14")]
		public override StyleLength GetValue(ref InlineStyleAccess container)
		{
			return default(StyleLength);
		}

		[Token(Token = "0x60015C9")]
		[Address(RVA = "0x29B7760", Offset = "0x29B6960", VA = "0x1829B7760", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleLength value)
		{
		}

		[Token(Token = "0x60015CA")]
		[Address(RVA = "0x29B5C40", Offset = "0x29B4E40", VA = "0x1829B5C40")]
		public FlexBasisProperty()
		{
		}
	}

	[Token(Token = "0x20002F7")]
	private class FlexDirectionProperty : InlineStyleEnumProperty<FlexDirection>
	{
		[Token(Token = "0x170004BA")]
		public override string Name
		{
			[Token(Token = "0x60015CB")]
			[Address(RVA = "0x29B7A60", Offset = "0x29B6C60", VA = "0x1829B7A60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004BB")]
		public override string ussName
		{
			[Token(Token = "0x60015CC")]
			[Address(RVA = "0x29B7A90", Offset = "0x29B6C90", VA = "0x1829B7A90", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004BC")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60015CD")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60015CE")]
		[Address(RVA = "0x29B78A0", Offset = "0x29B6AA0", VA = "0x1829B78A0", Slot = "14")]
		public override StyleEnum<FlexDirection> GetValue(ref InlineStyleAccess container)
		{
			return default(StyleEnum<FlexDirection>);
		}

		[Token(Token = "0x60015CF")]
		[Address(RVA = "0x29B7960", Offset = "0x29B6B60", VA = "0x1829B7960", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleEnum<FlexDirection> value)
		{
		}

		[Token(Token = "0x60015D0")]
		[Address(RVA = "0x29B7A20", Offset = "0x29B6C20", VA = "0x1829B7A20")]
		public FlexDirectionProperty()
		{
		}
	}

	[Token(Token = "0x20002F8")]
	private class FlexGrowProperty : InlineStyleFloatProperty
	{
		[Token(Token = "0x170004BD")]
		public override string Name
		{
			[Token(Token = "0x60015D1")]
			[Address(RVA = "0x29B7B70", Offset = "0x29B6D70", VA = "0x1829B7B70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004BE")]
		public override string ussName
		{
			[Token(Token = "0x60015D2")]
			[Address(RVA = "0x29B7BA0", Offset = "0x29B6DA0", VA = "0x1829B7BA0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004BF")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60015D3")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60015D4")]
		[Address(RVA = "0x29B7AC0", Offset = "0x29B6CC0", VA = "0x1829B7AC0", Slot = "14")]
		public override StyleFloat GetValue(ref InlineStyleAccess container)
		{
			return default(StyleFloat);
		}

		[Token(Token = "0x60015D5")]
		[Address(RVA = "0x29B7B10", Offset = "0x29B6D10", VA = "0x1829B7B10", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleFloat value)
		{
		}

		[Token(Token = "0x60015D6")]
		[Address(RVA = "0x29B5F80", Offset = "0x29B5180", VA = "0x1829B5F80")]
		public FlexGrowProperty()
		{
		}
	}

	[Token(Token = "0x20002F9")]
	private class FlexShrinkProperty : InlineStyleFloatProperty
	{
		[Token(Token = "0x170004C0")]
		public override string Name
		{
			[Token(Token = "0x60015D7")]
			[Address(RVA = "0x29B7C80", Offset = "0x29B6E80", VA = "0x1829B7C80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004C1")]
		public override string ussName
		{
			[Token(Token = "0x60015D8")]
			[Address(RVA = "0x29B7CB0", Offset = "0x29B6EB0", VA = "0x1829B7CB0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004C2")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60015D9")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60015DA")]
		[Address(RVA = "0x29B7BD0", Offset = "0x29B6DD0", VA = "0x1829B7BD0", Slot = "14")]
		public override StyleFloat GetValue(ref InlineStyleAccess container)
		{
			return default(StyleFloat);
		}

		[Token(Token = "0x60015DB")]
		[Address(RVA = "0x29B7C20", Offset = "0x29B6E20", VA = "0x1829B7C20", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleFloat value)
		{
		}

		[Token(Token = "0x60015DC")]
		[Address(RVA = "0x29B5F80", Offset = "0x29B5180", VA = "0x1829B5F80")]
		public FlexShrinkProperty()
		{
		}
	}

	[Token(Token = "0x20002FA")]
	private class FlexWrapProperty : InlineStyleEnumProperty<Wrap>
	{
		[Token(Token = "0x170004C3")]
		public override string Name
		{
			[Token(Token = "0x60015DD")]
			[Address(RVA = "0x29B7EA0", Offset = "0x29B70A0", VA = "0x1829B7EA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004C4")]
		public override string ussName
		{
			[Token(Token = "0x60015DE")]
			[Address(RVA = "0x29B7ED0", Offset = "0x29B70D0", VA = "0x1829B7ED0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004C5")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60015DF")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60015E0")]
		[Address(RVA = "0x29B7CE0", Offset = "0x29B6EE0", VA = "0x1829B7CE0", Slot = "14")]
		public override StyleEnum<Wrap> GetValue(ref InlineStyleAccess container)
		{
			return default(StyleEnum<Wrap>);
		}

		[Token(Token = "0x60015E1")]
		[Address(RVA = "0x29B7DA0", Offset = "0x29B6FA0", VA = "0x1829B7DA0", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleEnum<Wrap> value)
		{
		}

		[Token(Token = "0x60015E2")]
		[Address(RVA = "0x29B7E60", Offset = "0x29B7060", VA = "0x1829B7E60")]
		public FlexWrapProperty()
		{
		}
	}

	[Token(Token = "0x20002FB")]
	private class FontSizeProperty : InlineStyleLengthProperty
	{
		[Token(Token = "0x170004C6")]
		public override string Name
		{
			[Token(Token = "0x60015E3")]
			[Address(RVA = "0x29B80C0", Offset = "0x29B72C0", VA = "0x1829B80C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004C7")]
		public override string ussName
		{
			[Token(Token = "0x60015E4")]
			[Address(RVA = "0x29B80F0", Offset = "0x29B72F0", VA = "0x1829B80F0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004C8")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60015E5")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60015E6")]
		[Address(RVA = "0x29B7F00", Offset = "0x29B7100", VA = "0x1829B7F00", Slot = "14")]
		public override StyleLength GetValue(ref InlineStyleAccess container)
		{
			return default(StyleLength);
		}

		[Token(Token = "0x60015E7")]
		[Address(RVA = "0x29B7FE0", Offset = "0x29B71E0", VA = "0x1829B7FE0", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleLength value)
		{
		}

		[Token(Token = "0x60015E8")]
		[Address(RVA = "0x29B5C40", Offset = "0x29B4E40", VA = "0x1829B5C40")]
		public FontSizeProperty()
		{
		}
	}

	[Token(Token = "0x20002FC")]
	private class HeightProperty : InlineStyleLengthProperty
	{
		[Token(Token = "0x170004C9")]
		public override string Name
		{
			[Token(Token = "0x60015E9")]
			[Address(RVA = "0x29B82E0", Offset = "0x29B74E0", VA = "0x1829B82E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004CA")]
		public override string ussName
		{
			[Token(Token = "0x60015EA")]
			[Address(RVA = "0x29B8310", Offset = "0x29B7510", VA = "0x1829B8310", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004CB")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60015EB")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60015EC")]
		[Address(RVA = "0x29B8120", Offset = "0x29B7320", VA = "0x1829B8120", Slot = "14")]
		public override StyleLength GetValue(ref InlineStyleAccess container)
		{
			return default(StyleLength);
		}

		[Token(Token = "0x60015ED")]
		[Address(RVA = "0x29B8200", Offset = "0x29B7400", VA = "0x1829B8200", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleLength value)
		{
		}

		[Token(Token = "0x60015EE")]
		[Address(RVA = "0x29B5C40", Offset = "0x29B4E40", VA = "0x1829B5C40")]
		public HeightProperty()
		{
		}
	}

	[Token(Token = "0x20002FD")]
	private class JustifyContentProperty : InlineStyleEnumProperty<Justify>
	{
		[Token(Token = "0x170004CC")]
		public override string Name
		{
			[Token(Token = "0x60015EF")]
			[Address(RVA = "0x29BB520", Offset = "0x29BA720", VA = "0x1829BB520", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004CD")]
		public override string ussName
		{
			[Token(Token = "0x60015F0")]
			[Address(RVA = "0x29BB550", Offset = "0x29BA750", VA = "0x1829BB550", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004CE")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60015F1")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60015F2")]
		[Address(RVA = "0x29BB360", Offset = "0x29BA560", VA = "0x1829BB360", Slot = "14")]
		public override StyleEnum<Justify> GetValue(ref InlineStyleAccess container)
		{
			return default(StyleEnum<Justify>);
		}

		[Token(Token = "0x60015F3")]
		[Address(RVA = "0x29BB420", Offset = "0x29BA620", VA = "0x1829BB420", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleEnum<Justify> value)
		{
		}

		[Token(Token = "0x60015F4")]
		[Address(RVA = "0x29BB4E0", Offset = "0x29BA6E0", VA = "0x1829BB4E0")]
		public JustifyContentProperty()
		{
		}
	}

	[Token(Token = "0x20002FE")]
	private class LeftProperty : InlineStyleLengthProperty
	{
		[Token(Token = "0x170004CF")]
		public override string Name
		{
			[Token(Token = "0x60015F5")]
			[Address(RVA = "0x29BB740", Offset = "0x29BA940", VA = "0x1829BB740", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004D0")]
		public override string ussName
		{
			[Token(Token = "0x60015F6")]
			[Address(RVA = "0x29BB770", Offset = "0x29BA970", VA = "0x1829BB770", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004D1")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60015F7")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60015F8")]
		[Address(RVA = "0x29BB580", Offset = "0x29BA780", VA = "0x1829BB580", Slot = "14")]
		public override StyleLength GetValue(ref InlineStyleAccess container)
		{
			return default(StyleLength);
		}

		[Token(Token = "0x60015F9")]
		[Address(RVA = "0x29BB660", Offset = "0x29BA860", VA = "0x1829BB660", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleLength value)
		{
		}

		[Token(Token = "0x60015FA")]
		[Address(RVA = "0x29B5C40", Offset = "0x29B4E40", VA = "0x1829B5C40")]
		public LeftProperty()
		{
		}
	}

	[Token(Token = "0x20002FF")]
	private class LetterSpacingProperty : InlineStyleLengthProperty
	{
		[Token(Token = "0x170004D2")]
		public override string Name
		{
			[Token(Token = "0x60015FB")]
			[Address(RVA = "0x29BB960", Offset = "0x29BAB60", VA = "0x1829BB960", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004D3")]
		public override string ussName
		{
			[Token(Token = "0x60015FC")]
			[Address(RVA = "0x29BB990", Offset = "0x29BAB90", VA = "0x1829BB990", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004D4")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60015FD")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60015FE")]
		[Address(RVA = "0x29BB7A0", Offset = "0x29BA9A0", VA = "0x1829BB7A0", Slot = "14")]
		public override StyleLength GetValue(ref InlineStyleAccess container)
		{
			return default(StyleLength);
		}

		[Token(Token = "0x60015FF")]
		[Address(RVA = "0x29BB880", Offset = "0x29BAA80", VA = "0x1829BB880", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleLength value)
		{
		}

		[Token(Token = "0x6001600")]
		[Address(RVA = "0x29B5C40", Offset = "0x29B4E40", VA = "0x1829B5C40")]
		public LetterSpacingProperty()
		{
		}
	}

	[Token(Token = "0x2000300")]
	private class MarginBottomProperty : InlineStyleLengthProperty
	{
		[Token(Token = "0x170004D5")]
		public override string Name
		{
			[Token(Token = "0x6001601")]
			[Address(RVA = "0x29BBB80", Offset = "0x29BAD80", VA = "0x1829BBB80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004D6")]
		public override string ussName
		{
			[Token(Token = "0x6001602")]
			[Address(RVA = "0x29BBBB0", Offset = "0x29BADB0", VA = "0x1829BBBB0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004D7")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6001603")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001604")]
		[Address(RVA = "0x29BB9C0", Offset = "0x29BABC0", VA = "0x1829BB9C0", Slot = "14")]
		public override StyleLength GetValue(ref InlineStyleAccess container)
		{
			return default(StyleLength);
		}

		[Token(Token = "0x6001605")]
		[Address(RVA = "0x29BBAA0", Offset = "0x29BACA0", VA = "0x1829BBAA0", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleLength value)
		{
		}

		[Token(Token = "0x6001606")]
		[Address(RVA = "0x29B5C40", Offset = "0x29B4E40", VA = "0x1829B5C40")]
		public MarginBottomProperty()
		{
		}
	}

	[Token(Token = "0x2000301")]
	private class MarginLeftProperty : InlineStyleLengthProperty
	{
		[Token(Token = "0x170004D8")]
		public override string Name
		{
			[Token(Token = "0x6001607")]
			[Address(RVA = "0x29BBDA0", Offset = "0x29BAFA0", VA = "0x1829BBDA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004D9")]
		public override string ussName
		{
			[Token(Token = "0x6001608")]
			[Address(RVA = "0x29BBDD0", Offset = "0x29BAFD0", VA = "0x1829BBDD0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004DA")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6001609")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600160A")]
		[Address(RVA = "0x29BBBE0", Offset = "0x29BADE0", VA = "0x1829BBBE0", Slot = "14")]
		public override StyleLength GetValue(ref InlineStyleAccess container)
		{
			return default(StyleLength);
		}

		[Token(Token = "0x600160B")]
		[Address(RVA = "0x29BBCC0", Offset = "0x29BAEC0", VA = "0x1829BBCC0", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleLength value)
		{
		}

		[Token(Token = "0x600160C")]
		[Address(RVA = "0x29B5C40", Offset = "0x29B4E40", VA = "0x1829B5C40")]
		public MarginLeftProperty()
		{
		}
	}

	[Token(Token = "0x2000302")]
	private class MarginRightProperty : InlineStyleLengthProperty
	{
		[Token(Token = "0x170004DB")]
		public override string Name
		{
			[Token(Token = "0x600160D")]
			[Address(RVA = "0x29BBFC0", Offset = "0x29BB1C0", VA = "0x1829BBFC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004DC")]
		public override string ussName
		{
			[Token(Token = "0x600160E")]
			[Address(RVA = "0x29BBFF0", Offset = "0x29BB1F0", VA = "0x1829BBFF0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004DD")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x600160F")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001610")]
		[Address(RVA = "0x29BBE00", Offset = "0x29BB000", VA = "0x1829BBE00", Slot = "14")]
		public override StyleLength GetValue(ref InlineStyleAccess container)
		{
			return default(StyleLength);
		}

		[Token(Token = "0x6001611")]
		[Address(RVA = "0x29BBEE0", Offset = "0x29BB0E0", VA = "0x1829BBEE0", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleLength value)
		{
		}

		[Token(Token = "0x6001612")]
		[Address(RVA = "0x29B5C40", Offset = "0x29B4E40", VA = "0x1829B5C40")]
		public MarginRightProperty()
		{
		}
	}

	[Token(Token = "0x2000303")]
	private class MarginTopProperty : InlineStyleLengthProperty
	{
		[Token(Token = "0x170004DE")]
		public override string Name
		{
			[Token(Token = "0x6001613")]
			[Address(RVA = "0x29BC1E0", Offset = "0x29BB3E0", VA = "0x1829BC1E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004DF")]
		public override string ussName
		{
			[Token(Token = "0x6001614")]
			[Address(RVA = "0x29BC210", Offset = "0x29BB410", VA = "0x1829BC210", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004E0")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6001615")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001616")]
		[Address(RVA = "0x29BC020", Offset = "0x29BB220", VA = "0x1829BC020", Slot = "14")]
		public override StyleLength GetValue(ref InlineStyleAccess container)
		{
			return default(StyleLength);
		}

		[Token(Token = "0x6001617")]
		[Address(RVA = "0x29BC100", Offset = "0x29BB300", VA = "0x1829BC100", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleLength value)
		{
		}

		[Token(Token = "0x6001618")]
		[Address(RVA = "0x29B5C40", Offset = "0x29B4E40", VA = "0x1829B5C40")]
		public MarginTopProperty()
		{
		}
	}

	[Token(Token = "0x2000304")]
	private class MaxHeightProperty : InlineStyleLengthProperty
	{
		[Token(Token = "0x170004E1")]
		public override string Name
		{
			[Token(Token = "0x6001619")]
			[Address(RVA = "0x29BC400", Offset = "0x29BB600", VA = "0x1829BC400", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004E2")]
		public override string ussName
		{
			[Token(Token = "0x600161A")]
			[Address(RVA = "0x29BC430", Offset = "0x29BB630", VA = "0x1829BC430", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004E3")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x600161B")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600161C")]
		[Address(RVA = "0x29BC240", Offset = "0x29BB440", VA = "0x1829BC240", Slot = "14")]
		public override StyleLength GetValue(ref InlineStyleAccess container)
		{
			return default(StyleLength);
		}

		[Token(Token = "0x600161D")]
		[Address(RVA = "0x29BC320", Offset = "0x29BB520", VA = "0x1829BC320", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleLength value)
		{
		}

		[Token(Token = "0x600161E")]
		[Address(RVA = "0x29B5C40", Offset = "0x29B4E40", VA = "0x1829B5C40")]
		public MaxHeightProperty()
		{
		}
	}

	[Token(Token = "0x2000305")]
	private class MaxWidthProperty : InlineStyleLengthProperty
	{
		[Token(Token = "0x170004E4")]
		public override string Name
		{
			[Token(Token = "0x600161F")]
			[Address(RVA = "0x29BC620", Offset = "0x29BB820", VA = "0x1829BC620", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004E5")]
		public override string ussName
		{
			[Token(Token = "0x6001620")]
			[Address(RVA = "0x29BC650", Offset = "0x29BB850", VA = "0x1829BC650", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004E6")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6001621")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001622")]
		[Address(RVA = "0x29BC460", Offset = "0x29BB660", VA = "0x1829BC460", Slot = "14")]
		public override StyleLength GetValue(ref InlineStyleAccess container)
		{
			return default(StyleLength);
		}

		[Token(Token = "0x6001623")]
		[Address(RVA = "0x29BC540", Offset = "0x29BB740", VA = "0x1829BC540", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleLength value)
		{
		}

		[Token(Token = "0x6001624")]
		[Address(RVA = "0x29B5C40", Offset = "0x29B4E40", VA = "0x1829B5C40")]
		public MaxWidthProperty()
		{
		}
	}

	[Token(Token = "0x2000306")]
	private class MinHeightProperty : InlineStyleLengthProperty
	{
		[Token(Token = "0x170004E7")]
		public override string Name
		{
			[Token(Token = "0x6001625")]
			[Address(RVA = "0x29BC840", Offset = "0x29BBA40", VA = "0x1829BC840", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004E8")]
		public override string ussName
		{
			[Token(Token = "0x6001626")]
			[Address(RVA = "0x29BC870", Offset = "0x29BBA70", VA = "0x1829BC870", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004E9")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6001627")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001628")]
		[Address(RVA = "0x29BC680", Offset = "0x29BB880", VA = "0x1829BC680", Slot = "14")]
		public override StyleLength GetValue(ref InlineStyleAccess container)
		{
			return default(StyleLength);
		}

		[Token(Token = "0x6001629")]
		[Address(RVA = "0x29BC760", Offset = "0x29BB960", VA = "0x1829BC760", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleLength value)
		{
		}

		[Token(Token = "0x600162A")]
		[Address(RVA = "0x29B5C40", Offset = "0x29B4E40", VA = "0x1829B5C40")]
		public MinHeightProperty()
		{
		}
	}

	[Token(Token = "0x2000307")]
	private class MinWidthProperty : InlineStyleLengthProperty
	{
		[Token(Token = "0x170004EA")]
		public override string Name
		{
			[Token(Token = "0x600162B")]
			[Address(RVA = "0x29BCA60", Offset = "0x29BBC60", VA = "0x1829BCA60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004EB")]
		public override string ussName
		{
			[Token(Token = "0x600162C")]
			[Address(RVA = "0x29BCA90", Offset = "0x29BBC90", VA = "0x1829BCA90", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004EC")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x600162D")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600162E")]
		[Address(RVA = "0x29BC8A0", Offset = "0x29BBAA0", VA = "0x1829BC8A0", Slot = "14")]
		public override StyleLength GetValue(ref InlineStyleAccess container)
		{
			return default(StyleLength);
		}

		[Token(Token = "0x600162F")]
		[Address(RVA = "0x29BC980", Offset = "0x29BBB80", VA = "0x1829BC980", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleLength value)
		{
		}

		[Token(Token = "0x6001630")]
		[Address(RVA = "0x29B5C40", Offset = "0x29B4E40", VA = "0x1829B5C40")]
		public MinWidthProperty()
		{
		}
	}

	[Token(Token = "0x2000308")]
	private class OpacityProperty : InlineStyleFloatProperty
	{
		[Token(Token = "0x170004ED")]
		public override string Name
		{
			[Token(Token = "0x6001631")]
			[Address(RVA = "0x29BCB70", Offset = "0x29BBD70", VA = "0x1829BCB70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004EE")]
		public override string ussName
		{
			[Token(Token = "0x6001632")]
			[Address(RVA = "0x29BCBA0", Offset = "0x29BBDA0", VA = "0x1829BCBA0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004EF")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6001633")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001634")]
		[Address(RVA = "0x29BCAC0", Offset = "0x29BBCC0", VA = "0x1829BCAC0", Slot = "14")]
		public override StyleFloat GetValue(ref InlineStyleAccess container)
		{
			return default(StyleFloat);
		}

		[Token(Token = "0x6001635")]
		[Address(RVA = "0x29BCB10", Offset = "0x29BBD10", VA = "0x1829BCB10", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleFloat value)
		{
		}

		[Token(Token = "0x6001636")]
		[Address(RVA = "0x29B5F80", Offset = "0x29B5180", VA = "0x1829B5F80")]
		public OpacityProperty()
		{
		}
	}

	[Token(Token = "0x2000309")]
	private class OverflowProperty : InlineStyleEnumProperty<Overflow>
	{
		[Token(Token = "0x170004F0")]
		public override string Name
		{
			[Token(Token = "0x6001637")]
			[Address(RVA = "0x29BCD90", Offset = "0x29BBF90", VA = "0x1829BCD90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004F1")]
		public override string ussName
		{
			[Token(Token = "0x6001638")]
			[Address(RVA = "0x29BCDC0", Offset = "0x29BBFC0", VA = "0x1829BCDC0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004F2")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6001639")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600163A")]
		[Address(RVA = "0x29BCBD0", Offset = "0x29BBDD0", VA = "0x1829BCBD0", Slot = "14")]
		public override StyleEnum<Overflow> GetValue(ref InlineStyleAccess container)
		{
			return default(StyleEnum<Overflow>);
		}

		[Token(Token = "0x600163B")]
		[Address(RVA = "0x29BCC90", Offset = "0x29BBE90", VA = "0x1829BCC90", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleEnum<Overflow> value)
		{
		}

		[Token(Token = "0x600163C")]
		[Address(RVA = "0x29BCD50", Offset = "0x29BBF50", VA = "0x1829BCD50")]
		public OverflowProperty()
		{
		}
	}

	[Token(Token = "0x200030A")]
	private class PaddingBottomProperty : InlineStyleLengthProperty
	{
		[Token(Token = "0x170004F3")]
		public override string Name
		{
			[Token(Token = "0x600163D")]
			[Address(RVA = "0x29BCFB0", Offset = "0x29BC1B0", VA = "0x1829BCFB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004F4")]
		public override string ussName
		{
			[Token(Token = "0x600163E")]
			[Address(RVA = "0x29BCFE0", Offset = "0x29BC1E0", VA = "0x1829BCFE0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004F5")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x600163F")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001640")]
		[Address(RVA = "0x29BCDF0", Offset = "0x29BBFF0", VA = "0x1829BCDF0", Slot = "14")]
		public override StyleLength GetValue(ref InlineStyleAccess container)
		{
			return default(StyleLength);
		}

		[Token(Token = "0x6001641")]
		[Address(RVA = "0x29BCED0", Offset = "0x29BC0D0", VA = "0x1829BCED0", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleLength value)
		{
		}

		[Token(Token = "0x6001642")]
		[Address(RVA = "0x29B5C40", Offset = "0x29B4E40", VA = "0x1829B5C40")]
		public PaddingBottomProperty()
		{
		}
	}

	[Token(Token = "0x200030B")]
	private class PaddingLeftProperty : InlineStyleLengthProperty
	{
		[Token(Token = "0x170004F6")]
		public override string Name
		{
			[Token(Token = "0x6001643")]
			[Address(RVA = "0x29BD1D0", Offset = "0x29BC3D0", VA = "0x1829BD1D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004F7")]
		public override string ussName
		{
			[Token(Token = "0x6001644")]
			[Address(RVA = "0x29BD200", Offset = "0x29BC400", VA = "0x1829BD200", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004F8")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6001645")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001646")]
		[Address(RVA = "0x29BD010", Offset = "0x29BC210", VA = "0x1829BD010", Slot = "14")]
		public override StyleLength GetValue(ref InlineStyleAccess container)
		{
			return default(StyleLength);
		}

		[Token(Token = "0x6001647")]
		[Address(RVA = "0x29BD0F0", Offset = "0x29BC2F0", VA = "0x1829BD0F0", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleLength value)
		{
		}

		[Token(Token = "0x6001648")]
		[Address(RVA = "0x29B5C40", Offset = "0x29B4E40", VA = "0x1829B5C40")]
		public PaddingLeftProperty()
		{
		}
	}

	[Token(Token = "0x200030C")]
	private class PaddingRightProperty : InlineStyleLengthProperty
	{
		[Token(Token = "0x170004F9")]
		public override string Name
		{
			[Token(Token = "0x6001649")]
			[Address(RVA = "0x29BD3F0", Offset = "0x29BC5F0", VA = "0x1829BD3F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004FA")]
		public override string ussName
		{
			[Token(Token = "0x600164A")]
			[Address(RVA = "0x29BD420", Offset = "0x29BC620", VA = "0x1829BD420", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004FB")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x600164B")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600164C")]
		[Address(RVA = "0x29BD230", Offset = "0x29BC430", VA = "0x1829BD230", Slot = "14")]
		public override StyleLength GetValue(ref InlineStyleAccess container)
		{
			return default(StyleLength);
		}

		[Token(Token = "0x600164D")]
		[Address(RVA = "0x29BD310", Offset = "0x29BC510", VA = "0x1829BD310", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleLength value)
		{
		}

		[Token(Token = "0x600164E")]
		[Address(RVA = "0x29B5C40", Offset = "0x29B4E40", VA = "0x1829B5C40")]
		public PaddingRightProperty()
		{
		}
	}

	[Token(Token = "0x200030D")]
	private class PaddingTopProperty : InlineStyleLengthProperty
	{
		[Token(Token = "0x170004FC")]
		public override string Name
		{
			[Token(Token = "0x600164F")]
			[Address(RVA = "0x29BD610", Offset = "0x29BC810", VA = "0x1829BD610", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004FD")]
		public override string ussName
		{
			[Token(Token = "0x6001650")]
			[Address(RVA = "0x29BD640", Offset = "0x29BC840", VA = "0x1829BD640", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004FE")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6001651")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001652")]
		[Address(RVA = "0x29BD450", Offset = "0x29BC650", VA = "0x1829BD450", Slot = "14")]
		public override StyleLength GetValue(ref InlineStyleAccess container)
		{
			return default(StyleLength);
		}

		[Token(Token = "0x6001653")]
		[Address(RVA = "0x29BD530", Offset = "0x29BC730", VA = "0x1829BD530", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleLength value)
		{
		}

		[Token(Token = "0x6001654")]
		[Address(RVA = "0x29B5C40", Offset = "0x29B4E40", VA = "0x1829B5C40")]
		public PaddingTopProperty()
		{
		}
	}

	[Token(Token = "0x200030E")]
	private class PositionProperty : InlineStyleEnumProperty<Position>
	{
		[Token(Token = "0x170004FF")]
		public override string Name
		{
			[Token(Token = "0x6001655")]
			[Address(RVA = "0x29BD7D0", Offset = "0x29BC9D0", VA = "0x1829BD7D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000500")]
		public override string ussName
		{
			[Token(Token = "0x6001656")]
			[Address(RVA = "0x29BD800", Offset = "0x29BCA00", VA = "0x1829BD800", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000501")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6001657")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001658")]
		[Address(RVA = "0x29BD670", Offset = "0x29BC870", VA = "0x1829BD670", Slot = "14")]
		public override StyleEnum<Position> GetValue(ref InlineStyleAccess container)
		{
			return default(StyleEnum<Position>);
		}

		[Token(Token = "0x6001659")]
		[Address(RVA = "0x29BD730", Offset = "0x29BC930", VA = "0x1829BD730", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleEnum<Position> value)
		{
		}

		[Token(Token = "0x600165A")]
		[Address(RVA = "0x29BD790", Offset = "0x29BC990", VA = "0x1829BD790")]
		public PositionProperty()
		{
		}
	}

	[Token(Token = "0x200030F")]
	private class RightProperty : InlineStyleLengthProperty
	{
		[Token(Token = "0x17000502")]
		public override string Name
		{
			[Token(Token = "0x600165B")]
			[Address(RVA = "0x29BEB30", Offset = "0x29BDD30", VA = "0x1829BEB30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000503")]
		public override string ussName
		{
			[Token(Token = "0x600165C")]
			[Address(RVA = "0x29BEB60", Offset = "0x29BDD60", VA = "0x1829BEB60", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000504")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x600165D")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600165E")]
		[Address(RVA = "0x29BE970", Offset = "0x29BDB70", VA = "0x1829BE970", Slot = "14")]
		public override StyleLength GetValue(ref InlineStyleAccess container)
		{
			return default(StyleLength);
		}

		[Token(Token = "0x600165F")]
		[Address(RVA = "0x29BEA50", Offset = "0x29BDC50", VA = "0x1829BEA50", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleLength value)
		{
		}

		[Token(Token = "0x6001660")]
		[Address(RVA = "0x29B5C40", Offset = "0x29B4E40", VA = "0x1829B5C40")]
		public RightProperty()
		{
		}
	}

	[Token(Token = "0x2000310")]
	private class RotateProperty : InlineStyleRotateProperty
	{
		[Token(Token = "0x17000505")]
		public override string Name
		{
			[Token(Token = "0x6001661")]
			[Address(RVA = "0x29BED60", Offset = "0x29BDF60", VA = "0x1829BED60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000506")]
		public override string ussName
		{
			[Token(Token = "0x6001662")]
			[Address(RVA = "0x29BED90", Offset = "0x29BDF90", VA = "0x1829BED90", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000507")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6001663")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001664")]
		[Address(RVA = "0x29BEB90", Offset = "0x29BDD90", VA = "0x1829BEB90", Slot = "14")]
		public override StyleRotate GetValue(ref InlineStyleAccess container)
		{
			return default(StyleRotate);
		}

		[Token(Token = "0x6001665")]
		[Address(RVA = "0x29BEC70", Offset = "0x29BDE70", VA = "0x1829BEC70", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleRotate value)
		{
		}

		[Token(Token = "0x6001666")]
		[Address(RVA = "0x29BB220", Offset = "0x29BA420", VA = "0x1829BB220")]
		public RotateProperty()
		{
		}
	}

	[Token(Token = "0x2000311")]
	private class ScaleProperty : InlineStyleScaleProperty
	{
		[Token(Token = "0x17000508")]
		public override string Name
		{
			[Token(Token = "0x6001667")]
			[Address(RVA = "0x29BEF80", Offset = "0x29BE180", VA = "0x1829BEF80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000509")]
		public override string ussName
		{
			[Token(Token = "0x6001668")]
			[Address(RVA = "0x29BEFB0", Offset = "0x29BE1B0", VA = "0x1829BEFB0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700050A")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6001669")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600166A")]
		[Address(RVA = "0x29BEDC0", Offset = "0x29BDFC0", VA = "0x1829BEDC0", Slot = "14")]
		public override StyleScale GetValue(ref InlineStyleAccess container)
		{
			return default(StyleScale);
		}

		[Token(Token = "0x600166B")]
		[Address(RVA = "0x29BEEA0", Offset = "0x29BE0A0", VA = "0x1829BEEA0", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleScale value)
		{
		}

		[Token(Token = "0x600166C")]
		[Address(RVA = "0x29BB260", Offset = "0x29BA460", VA = "0x1829BB260")]
		public ScaleProperty()
		{
		}
	}

	[Token(Token = "0x2000312")]
	private class TextOverflowProperty : InlineStyleEnumProperty<TextOverflow>
	{
		[Token(Token = "0x1700050B")]
		public override string Name
		{
			[Token(Token = "0x600166D")]
			[Address(RVA = "0x29BF1A0", Offset = "0x29BE3A0", VA = "0x1829BF1A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700050C")]
		public override string ussName
		{
			[Token(Token = "0x600166E")]
			[Address(RVA = "0x29BF1D0", Offset = "0x29BE3D0", VA = "0x1829BF1D0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700050D")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x600166F")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001670")]
		[Address(RVA = "0x29BEFE0", Offset = "0x29BE1E0", VA = "0x1829BEFE0", Slot = "14")]
		public override StyleEnum<TextOverflow> GetValue(ref InlineStyleAccess container)
		{
			return default(StyleEnum<TextOverflow>);
		}

		[Token(Token = "0x6001671")]
		[Address(RVA = "0x29BF0A0", Offset = "0x29BE2A0", VA = "0x1829BF0A0", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleEnum<TextOverflow> value)
		{
		}

		[Token(Token = "0x6001672")]
		[Address(RVA = "0x29BF160", Offset = "0x29BE360", VA = "0x1829BF160")]
		public TextOverflowProperty()
		{
		}
	}

	[Token(Token = "0x2000313")]
	private class TextShadowProperty : InlineStyleTextShadowProperty
	{
		[Token(Token = "0x1700050E")]
		public override string Name
		{
			[Token(Token = "0x6001673")]
			[Address(RVA = "0x29BF3C0", Offset = "0x29BE5C0", VA = "0x1829BF3C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700050F")]
		public override string ussName
		{
			[Token(Token = "0x6001674")]
			[Address(RVA = "0x29BF3F0", Offset = "0x29BE5F0", VA = "0x1829BF3F0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000510")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6001675")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001676")]
		[Address(RVA = "0x29BF200", Offset = "0x29BE400", VA = "0x1829BF200", Slot = "14")]
		public override StyleTextShadow GetValue(ref InlineStyleAccess container)
		{
			return default(StyleTextShadow);
		}

		[Token(Token = "0x6001677")]
		[Address(RVA = "0x29BF2E0", Offset = "0x29BE4E0", VA = "0x1829BF2E0", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleTextShadow value)
		{
		}

		[Token(Token = "0x6001678")]
		[Address(RVA = "0x29BB2A0", Offset = "0x29BA4A0", VA = "0x1829BB2A0")]
		public TextShadowProperty()
		{
		}
	}

	[Token(Token = "0x2000314")]
	private class TopProperty : InlineStyleLengthProperty
	{
		[Token(Token = "0x17000511")]
		public override string Name
		{
			[Token(Token = "0x6001679")]
			[Address(RVA = "0x29BF5E0", Offset = "0x29BE7E0", VA = "0x1829BF5E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000512")]
		public override string ussName
		{
			[Token(Token = "0x600167A")]
			[Address(RVA = "0x29BF610", Offset = "0x29BE810", VA = "0x1829BF610", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000513")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x600167B")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600167C")]
		[Address(RVA = "0x29BF420", Offset = "0x29BE620", VA = "0x1829BF420", Slot = "14")]
		public override StyleLength GetValue(ref InlineStyleAccess container)
		{
			return default(StyleLength);
		}

		[Token(Token = "0x600167D")]
		[Address(RVA = "0x29BF500", Offset = "0x29BE700", VA = "0x1829BF500", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleLength value)
		{
		}

		[Token(Token = "0x600167E")]
		[Address(RVA = "0x29B5C40", Offset = "0x29B4E40", VA = "0x1829B5C40")]
		public TopProperty()
		{
		}
	}

	[Token(Token = "0x2000315")]
	private class TransformOriginProperty : InlineStyleTransformOriginProperty
	{
		[Token(Token = "0x17000514")]
		public override string Name
		{
			[Token(Token = "0x600167F")]
			[Address(RVA = "0x29BF800", Offset = "0x29BEA00", VA = "0x1829BF800", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000515")]
		public override string ussName
		{
			[Token(Token = "0x6001680")]
			[Address(RVA = "0x29BF830", Offset = "0x29BEA30", VA = "0x1829BF830", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000516")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6001681")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001682")]
		[Address(RVA = "0x29BF640", Offset = "0x29BE840", VA = "0x1829BF640", Slot = "14")]
		public override StyleTransformOrigin GetValue(ref InlineStyleAccess container)
		{
			return default(StyleTransformOrigin);
		}

		[Token(Token = "0x6001683")]
		[Address(RVA = "0x29BF720", Offset = "0x29BE920", VA = "0x1829BF720", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleTransformOrigin value)
		{
		}

		[Token(Token = "0x6001684")]
		[Address(RVA = "0x29BB2E0", Offset = "0x29BA4E0", VA = "0x1829BB2E0")]
		public TransformOriginProperty()
		{
		}
	}

	[Token(Token = "0x2000316")]
	private class TransitionDelayProperty : InlineStyleListProperty<TimeValue>
	{
		[Token(Token = "0x17000517")]
		public override string Name
		{
			[Token(Token = "0x6001685")]
			[Address(RVA = "0x29BFA40", Offset = "0x29BEC40", VA = "0x1829BFA40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000518")]
		public override string ussName
		{
			[Token(Token = "0x6001686")]
			[Address(RVA = "0x29BFA70", Offset = "0x29BEC70", VA = "0x1829BFA70", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000519")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6001687")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001688")]
		[Address(RVA = "0x29BF860", Offset = "0x29BEA60", VA = "0x1829BF860", Slot = "14")]
		public override StyleList<TimeValue> GetValue(ref InlineStyleAccess container)
		{
			return default(StyleList<TimeValue>);
		}

		[Token(Token = "0x6001689")]
		[Address(RVA = "0x29BF930", Offset = "0x29BEB30", VA = "0x1829BF930", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleList<TimeValue> value)
		{
		}

		[Token(Token = "0x600168A")]
		[Address(RVA = "0x29BFA00", Offset = "0x29BEC00", VA = "0x1829BFA00")]
		public TransitionDelayProperty()
		{
		}
	}

	[Token(Token = "0x2000317")]
	private class TransitionDurationProperty : InlineStyleListProperty<TimeValue>
	{
		[Token(Token = "0x1700051A")]
		public override string Name
		{
			[Token(Token = "0x600168B")]
			[Address(RVA = "0x29BFC80", Offset = "0x29BEE80", VA = "0x1829BFC80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700051B")]
		public override string ussName
		{
			[Token(Token = "0x600168C")]
			[Address(RVA = "0x29BFCB0", Offset = "0x29BEEB0", VA = "0x1829BFCB0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700051C")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x600168D")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600168E")]
		[Address(RVA = "0x29BFAA0", Offset = "0x29BECA0", VA = "0x1829BFAA0", Slot = "14")]
		public override StyleList<TimeValue> GetValue(ref InlineStyleAccess container)
		{
			return default(StyleList<TimeValue>);
		}

		[Token(Token = "0x600168F")]
		[Address(RVA = "0x29BFB70", Offset = "0x29BED70", VA = "0x1829BFB70", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleList<TimeValue> value)
		{
		}

		[Token(Token = "0x6001690")]
		[Address(RVA = "0x29BFC40", Offset = "0x29BEE40", VA = "0x1829BFC40")]
		public TransitionDurationProperty()
		{
		}
	}

	[Token(Token = "0x2000318")]
	private class TransitionPropertyProperty : InlineStyleListProperty<StylePropertyName>
	{
		[Token(Token = "0x1700051D")]
		public override string Name
		{
			[Token(Token = "0x6001691")]
			[Address(RVA = "0x29BFEC0", Offset = "0x29BF0C0", VA = "0x1829BFEC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700051E")]
		public override string ussName
		{
			[Token(Token = "0x6001692")]
			[Address(RVA = "0x29BFEF0", Offset = "0x29BF0F0", VA = "0x1829BFEF0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700051F")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6001693")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001694")]
		[Address(RVA = "0x29BFCE0", Offset = "0x29BEEE0", VA = "0x1829BFCE0", Slot = "14")]
		public override StyleList<StylePropertyName> GetValue(ref InlineStyleAccess container)
		{
			return default(StyleList<StylePropertyName>);
		}

		[Token(Token = "0x6001695")]
		[Address(RVA = "0x29BFDB0", Offset = "0x29BEFB0", VA = "0x1829BFDB0", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleList<StylePropertyName> value)
		{
		}

		[Token(Token = "0x6001696")]
		[Address(RVA = "0x29BFE80", Offset = "0x29BF080", VA = "0x1829BFE80")]
		public TransitionPropertyProperty()
		{
		}
	}

	[Token(Token = "0x2000319")]
	private class TransitionTimingFunctionProperty : InlineStyleListProperty<EasingFunction>
	{
		[Token(Token = "0x17000520")]
		public override string Name
		{
			[Token(Token = "0x6001697")]
			[Address(RVA = "0x29C0100", Offset = "0x29BF300", VA = "0x1829C0100", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000521")]
		public override string ussName
		{
			[Token(Token = "0x6001698")]
			[Address(RVA = "0x29C0130", Offset = "0x29BF330", VA = "0x1829C0130", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000522")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6001699")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600169A")]
		[Address(RVA = "0x29BFF20", Offset = "0x29BF120", VA = "0x1829BFF20", Slot = "14")]
		public override StyleList<EasingFunction> GetValue(ref InlineStyleAccess container)
		{
			return default(StyleList<EasingFunction>);
		}

		[Token(Token = "0x600169B")]
		[Address(RVA = "0x29BFFF0", Offset = "0x29BF1F0", VA = "0x1829BFFF0", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleList<EasingFunction> value)
		{
		}

		[Token(Token = "0x600169C")]
		[Address(RVA = "0x29C00C0", Offset = "0x29BF2C0", VA = "0x1829C00C0")]
		public TransitionTimingFunctionProperty()
		{
		}
	}

	[Token(Token = "0x200031A")]
	private class TranslateProperty : InlineStyleTranslateProperty
	{
		[Token(Token = "0x17000523")]
		public override string Name
		{
			[Token(Token = "0x600169D")]
			[Address(RVA = "0x29C0330", Offset = "0x29BF530", VA = "0x1829C0330", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000524")]
		public override string ussName
		{
			[Token(Token = "0x600169E")]
			[Address(RVA = "0x29C0360", Offset = "0x29BF560", VA = "0x1829C0360", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000525")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x600169F")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60016A0")]
		[Address(RVA = "0x29C0160", Offset = "0x29BF360", VA = "0x1829C0160", Slot = "14")]
		public override StyleTranslate GetValue(ref InlineStyleAccess container)
		{
			return default(StyleTranslate);
		}

		[Token(Token = "0x60016A1")]
		[Address(RVA = "0x29C0240", Offset = "0x29BF440", VA = "0x1829C0240", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleTranslate value)
		{
		}

		[Token(Token = "0x60016A2")]
		[Address(RVA = "0x29BB320", Offset = "0x29BA520", VA = "0x1829BB320")]
		public TranslateProperty()
		{
		}
	}

	[Token(Token = "0x200031B")]
	private class UnityBackgroundImageTintColorProperty : InlineStyleColorProperty
	{
		[Token(Token = "0x17000526")]
		public override string Name
		{
			[Token(Token = "0x60016A3")]
			[Address(RVA = "0x29C0C20", Offset = "0x29BFE20", VA = "0x1829C0C20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000527")]
		public override string ussName
		{
			[Token(Token = "0x60016A4")]
			[Address(RVA = "0x29C0C50", Offset = "0x29BFE50", VA = "0x1829C0C50", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000528")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60016A5")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60016A6")]
		[Address(RVA = "0x29C0A60", Offset = "0x29BFC60", VA = "0x1829C0A60", Slot = "14")]
		public override StyleColor GetValue(ref InlineStyleAccess container)
		{
			return default(StyleColor);
		}

		[Token(Token = "0x60016A7")]
		[Address(RVA = "0x29C0B40", Offset = "0x29BFD40", VA = "0x1829C0B40", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleColor value)
		{
		}

		[Token(Token = "0x60016A8")]
		[Address(RVA = "0x29B4CA0", Offset = "0x29B3EA0", VA = "0x1829B4CA0")]
		public UnityBackgroundImageTintColorProperty()
		{
		}
	}

	[Token(Token = "0x200031C")]
	private class UnityEditorTextRenderingModeProperty : InlineStyleEnumProperty<EditorTextRenderingMode>
	{
		[Token(Token = "0x17000529")]
		public override string Name
		{
			[Token(Token = "0x60016A9")]
			[Address(RVA = "0x29C0E40", Offset = "0x29C0040", VA = "0x1829C0E40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700052A")]
		public override string ussName
		{
			[Token(Token = "0x60016AA")]
			[Address(RVA = "0x29C0E70", Offset = "0x29C0070", VA = "0x1829C0E70", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700052B")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60016AB")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60016AC")]
		[Address(RVA = "0x29C0C80", Offset = "0x29BFE80", VA = "0x1829C0C80", Slot = "14")]
		public override StyleEnum<EditorTextRenderingMode> GetValue(ref InlineStyleAccess container)
		{
			return default(StyleEnum<EditorTextRenderingMode>);
		}

		[Token(Token = "0x60016AD")]
		[Address(RVA = "0x29C0D40", Offset = "0x29BFF40", VA = "0x1829C0D40", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleEnum<EditorTextRenderingMode> value)
		{
		}

		[Token(Token = "0x60016AE")]
		[Address(RVA = "0x29C0E00", Offset = "0x29C0000", VA = "0x1829C0E00")]
		public UnityEditorTextRenderingModeProperty()
		{
		}
	}

	[Token(Token = "0x200031D")]
	private class UnityFontProperty : InlineStyleFontProperty
	{
		[Token(Token = "0x1700052C")]
		public override string Name
		{
			[Token(Token = "0x60016AF")]
			[Address(RVA = "0x29C1280", Offset = "0x29C0480", VA = "0x1829C1280", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700052D")]
		public override string ussName
		{
			[Token(Token = "0x60016B0")]
			[Address(RVA = "0x29C12B0", Offset = "0x29C04B0", VA = "0x1829C12B0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700052E")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60016B1")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60016B2")]
		[Address(RVA = "0x29C10D0", Offset = "0x29C02D0", VA = "0x1829C10D0", Slot = "14")]
		public override StyleFont GetValue(ref InlineStyleAccess container)
		{
			return default(StyleFont);
		}

		[Token(Token = "0x60016B3")]
		[Address(RVA = "0x29C11A0", Offset = "0x29C03A0", VA = "0x1829C11A0", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleFont value)
		{
		}

		[Token(Token = "0x60016B4")]
		[Address(RVA = "0x29BADB0", Offset = "0x29B9FB0", VA = "0x1829BADB0")]
		public UnityFontProperty()
		{
		}
	}

	[Token(Token = "0x200031E")]
	private class UnityFontDefinitionProperty : InlineStyleFontDefinitionProperty
	{
		[Token(Token = "0x1700052F")]
		public override string Name
		{
			[Token(Token = "0x60016B5")]
			[Address(RVA = "0x29C1070", Offset = "0x29C0270", VA = "0x1829C1070", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000530")]
		public override string ussName
		{
			[Token(Token = "0x60016B6")]
			[Address(RVA = "0x29C10A0", Offset = "0x29C02A0", VA = "0x1829C10A0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000531")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60016B7")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60016B8")]
		[Address(RVA = "0x29C0EA0", Offset = "0x29C00A0", VA = "0x1829C0EA0", Slot = "14")]
		public override StyleFontDefinition GetValue(ref InlineStyleAccess container)
		{
			return default(StyleFontDefinition);
		}

		[Token(Token = "0x60016B9")]
		[Address(RVA = "0x29C0F80", Offset = "0x29C0180", VA = "0x1829C0F80", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleFontDefinition value)
		{
		}

		[Token(Token = "0x60016BA")]
		[Address(RVA = "0x29C1060", Offset = "0x29C0260", VA = "0x1829C1060")]
		public UnityFontDefinitionProperty()
		{
		}
	}

	[Token(Token = "0x200031F")]
	private class UnityFontStyleAndWeightProperty : InlineStyleEnumProperty<FontStyle>
	{
		[Token(Token = "0x17000532")]
		public override string Name
		{
			[Token(Token = "0x60016BB")]
			[Address(RVA = "0x29C14B0", Offset = "0x29C06B0", VA = "0x1829C14B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000533")]
		public override string ussName
		{
			[Token(Token = "0x60016BC")]
			[Address(RVA = "0x29C14E0", Offset = "0x29C06E0", VA = "0x1829C14E0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000534")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60016BD")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60016BE")]
		[Address(RVA = "0x29C12E0", Offset = "0x29C04E0", VA = "0x1829C12E0", Slot = "14")]
		public override StyleEnum<FontStyle> GetValue(ref InlineStyleAccess container)
		{
			return default(StyleEnum<FontStyle>);
		}

		[Token(Token = "0x60016BF")]
		[Address(RVA = "0x29C13A0", Offset = "0x29C05A0", VA = "0x1829C13A0", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleEnum<FontStyle> value)
		{
		}

		[Token(Token = "0x60016C0")]
		[Address(RVA = "0x29C1470", Offset = "0x29C0670", VA = "0x1829C1470")]
		public UnityFontStyleAndWeightProperty()
		{
		}
	}

	[Token(Token = "0x2000320")]
	private class UnityOverflowClipBoxProperty : InlineStyleEnumProperty<OverflowClipBox>
	{
		[Token(Token = "0x17000535")]
		public override string Name
		{
			[Token(Token = "0x60016C1")]
			[Address(RVA = "0x29C16E0", Offset = "0x29C08E0", VA = "0x1829C16E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000536")]
		public override string ussName
		{
			[Token(Token = "0x60016C2")]
			[Address(RVA = "0x29C1710", Offset = "0x29C0910", VA = "0x1829C1710", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000537")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60016C3")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60016C4")]
		[Address(RVA = "0x29C1510", Offset = "0x29C0710", VA = "0x1829C1510", Slot = "14")]
		public override StyleEnum<OverflowClipBox> GetValue(ref InlineStyleAccess container)
		{
			return default(StyleEnum<OverflowClipBox>);
		}

		[Token(Token = "0x60016C5")]
		[Address(RVA = "0x29C15D0", Offset = "0x29C07D0", VA = "0x1829C15D0", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleEnum<OverflowClipBox> value)
		{
		}

		[Token(Token = "0x60016C6")]
		[Address(RVA = "0x29C16A0", Offset = "0x29C08A0", VA = "0x1829C16A0")]
		public UnityOverflowClipBoxProperty()
		{
		}
	}

	[Token(Token = "0x2000321")]
	private class UnityParagraphSpacingProperty : InlineStyleLengthProperty
	{
		[Token(Token = "0x17000538")]
		public override string Name
		{
			[Token(Token = "0x60016C7")]
			[Address(RVA = "0x29C1900", Offset = "0x29C0B00", VA = "0x1829C1900", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000539")]
		public override string ussName
		{
			[Token(Token = "0x60016C8")]
			[Address(RVA = "0x29C1930", Offset = "0x29C0B30", VA = "0x1829C1930", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700053A")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60016C9")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60016CA")]
		[Address(RVA = "0x29C1740", Offset = "0x29C0940", VA = "0x1829C1740", Slot = "14")]
		public override StyleLength GetValue(ref InlineStyleAccess container)
		{
			return default(StyleLength);
		}

		[Token(Token = "0x60016CB")]
		[Address(RVA = "0x29C1820", Offset = "0x29C0A20", VA = "0x1829C1820", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleLength value)
		{
		}

		[Token(Token = "0x60016CC")]
		[Address(RVA = "0x29B5C40", Offset = "0x29B4E40", VA = "0x1829B5C40")]
		public UnityParagraphSpacingProperty()
		{
		}
	}

	[Token(Token = "0x2000322")]
	private class UnitySliceBottomProperty : InlineStyleIntProperty
	{
		[Token(Token = "0x1700053B")]
		public override string Name
		{
			[Token(Token = "0x60016CD")]
			[Address(RVA = "0x29C1A10", Offset = "0x29C0C10", VA = "0x1829C1A10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700053C")]
		public override string ussName
		{
			[Token(Token = "0x60016CE")]
			[Address(RVA = "0x29C1A40", Offset = "0x29C0C40", VA = "0x1829C1A40", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700053D")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60016CF")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60016D0")]
		[Address(RVA = "0x29C1960", Offset = "0x29C0B60", VA = "0x1829C1960", Slot = "14")]
		public override StyleInt GetValue(ref InlineStyleAccess container)
		{
			return default(StyleInt);
		}

		[Token(Token = "0x60016D1")]
		[Address(RVA = "0x29C19B0", Offset = "0x29C0BB0", VA = "0x1829C19B0", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleInt value)
		{
		}

		[Token(Token = "0x60016D2")]
		[Address(RVA = "0x29BADF0", Offset = "0x29B9FF0", VA = "0x1829BADF0")]
		public UnitySliceBottomProperty()
		{
		}
	}

	[Token(Token = "0x2000323")]
	private class UnitySliceLeftProperty : InlineStyleIntProperty
	{
		[Token(Token = "0x1700053E")]
		public override string Name
		{
			[Token(Token = "0x60016D3")]
			[Address(RVA = "0x29C1B20", Offset = "0x29C0D20", VA = "0x1829C1B20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700053F")]
		public override string ussName
		{
			[Token(Token = "0x60016D4")]
			[Address(RVA = "0x29C1B50", Offset = "0x29C0D50", VA = "0x1829C1B50", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000540")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60016D5")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60016D6")]
		[Address(RVA = "0x29C1A70", Offset = "0x29C0C70", VA = "0x1829C1A70", Slot = "14")]
		public override StyleInt GetValue(ref InlineStyleAccess container)
		{
			return default(StyleInt);
		}

		[Token(Token = "0x60016D7")]
		[Address(RVA = "0x29C1AC0", Offset = "0x29C0CC0", VA = "0x1829C1AC0", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleInt value)
		{
		}

		[Token(Token = "0x60016D8")]
		[Address(RVA = "0x29BADF0", Offset = "0x29B9FF0", VA = "0x1829BADF0")]
		public UnitySliceLeftProperty()
		{
		}
	}

	[Token(Token = "0x2000324")]
	private class UnitySliceRightProperty : InlineStyleIntProperty
	{
		[Token(Token = "0x17000541")]
		public override string Name
		{
			[Token(Token = "0x60016D9")]
			[Address(RVA = "0x29C1C30", Offset = "0x29C0E30", VA = "0x1829C1C30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000542")]
		public override string ussName
		{
			[Token(Token = "0x60016DA")]
			[Address(RVA = "0x29C1C60", Offset = "0x29C0E60", VA = "0x1829C1C60", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000543")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60016DB")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60016DC")]
		[Address(RVA = "0x29C1B80", Offset = "0x29C0D80", VA = "0x1829C1B80", Slot = "14")]
		public override StyleInt GetValue(ref InlineStyleAccess container)
		{
			return default(StyleInt);
		}

		[Token(Token = "0x60016DD")]
		[Address(RVA = "0x29C1BD0", Offset = "0x29C0DD0", VA = "0x1829C1BD0", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleInt value)
		{
		}

		[Token(Token = "0x60016DE")]
		[Address(RVA = "0x29BADF0", Offset = "0x29B9FF0", VA = "0x1829BADF0")]
		public UnitySliceRightProperty()
		{
		}
	}

	[Token(Token = "0x2000325")]
	private class UnitySliceScaleProperty : InlineStyleFloatProperty
	{
		[Token(Token = "0x17000544")]
		public override string Name
		{
			[Token(Token = "0x60016DF")]
			[Address(RVA = "0x29C1D40", Offset = "0x29C0F40", VA = "0x1829C1D40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000545")]
		public override string ussName
		{
			[Token(Token = "0x60016E0")]
			[Address(RVA = "0x29C1D70", Offset = "0x29C0F70", VA = "0x1829C1D70", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000546")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60016E1")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60016E2")]
		[Address(RVA = "0x29C1C90", Offset = "0x29C0E90", VA = "0x1829C1C90", Slot = "14")]
		public override StyleFloat GetValue(ref InlineStyleAccess container)
		{
			return default(StyleFloat);
		}

		[Token(Token = "0x60016E3")]
		[Address(RVA = "0x29C1CE0", Offset = "0x29C0EE0", VA = "0x1829C1CE0", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleFloat value)
		{
		}

		[Token(Token = "0x60016E4")]
		[Address(RVA = "0x29B5F80", Offset = "0x29B5180", VA = "0x1829B5F80")]
		public UnitySliceScaleProperty()
		{
		}
	}

	[Token(Token = "0x2000326")]
	private class UnitySliceTopProperty : InlineStyleIntProperty
	{
		[Token(Token = "0x17000547")]
		public override string Name
		{
			[Token(Token = "0x60016E5")]
			[Address(RVA = "0x29C1E50", Offset = "0x29C1050", VA = "0x1829C1E50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000548")]
		public override string ussName
		{
			[Token(Token = "0x60016E6")]
			[Address(RVA = "0x29C1E80", Offset = "0x29C1080", VA = "0x1829C1E80", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000549")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60016E7")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60016E8")]
		[Address(RVA = "0x29C1DA0", Offset = "0x29C0FA0", VA = "0x1829C1DA0", Slot = "14")]
		public override StyleInt GetValue(ref InlineStyleAccess container)
		{
			return default(StyleInt);
		}

		[Token(Token = "0x60016E9")]
		[Address(RVA = "0x29C1DF0", Offset = "0x29C0FF0", VA = "0x1829C1DF0", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleInt value)
		{
		}

		[Token(Token = "0x60016EA")]
		[Address(RVA = "0x29BADF0", Offset = "0x29B9FF0", VA = "0x1829BADF0")]
		public UnitySliceTopProperty()
		{
		}
	}

	[Token(Token = "0x2000327")]
	private class UnitySliceTypeProperty : InlineStyleEnumProperty<SliceType>
	{
		[Token(Token = "0x1700054A")]
		public override string Name
		{
			[Token(Token = "0x60016EB")]
			[Address(RVA = "0x29C2080", Offset = "0x29C1280", VA = "0x1829C2080", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700054B")]
		public override string ussName
		{
			[Token(Token = "0x60016EC")]
			[Address(RVA = "0x29C20B0", Offset = "0x29C12B0", VA = "0x1829C20B0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700054C")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60016ED")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60016EE")]
		[Address(RVA = "0x29C1EB0", Offset = "0x29C10B0", VA = "0x1829C1EB0", Slot = "14")]
		public override StyleEnum<SliceType> GetValue(ref InlineStyleAccess container)
		{
			return default(StyleEnum<SliceType>);
		}

		[Token(Token = "0x60016EF")]
		[Address(RVA = "0x29C1F70", Offset = "0x29C1170", VA = "0x1829C1F70", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleEnum<SliceType> value)
		{
		}

		[Token(Token = "0x60016F0")]
		[Address(RVA = "0x29C2040", Offset = "0x29C1240", VA = "0x1829C2040")]
		public UnitySliceTypeProperty()
		{
		}
	}

	[Token(Token = "0x2000328")]
	private class UnityTextAlignProperty : InlineStyleEnumProperty<TextAnchor>
	{
		[Token(Token = "0x1700054D")]
		public override string Name
		{
			[Token(Token = "0x60016F1")]
			[Address(RVA = "0x29C22B0", Offset = "0x29C14B0", VA = "0x1829C22B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700054E")]
		public override string ussName
		{
			[Token(Token = "0x60016F2")]
			[Address(RVA = "0x29C22E0", Offset = "0x29C14E0", VA = "0x1829C22E0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700054F")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60016F3")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60016F4")]
		[Address(RVA = "0x29C20E0", Offset = "0x29C12E0", VA = "0x1829C20E0", Slot = "14")]
		public override StyleEnum<TextAnchor> GetValue(ref InlineStyleAccess container)
		{
			return default(StyleEnum<TextAnchor>);
		}

		[Token(Token = "0x60016F5")]
		[Address(RVA = "0x29C21A0", Offset = "0x29C13A0", VA = "0x1829C21A0", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleEnum<TextAnchor> value)
		{
		}

		[Token(Token = "0x60016F6")]
		[Address(RVA = "0x29C2270", Offset = "0x29C1470", VA = "0x1829C2270")]
		public UnityTextAlignProperty()
		{
		}
	}

	[Token(Token = "0x2000329")]
	private class UnityTextGeneratorProperty : InlineStyleEnumProperty<TextGeneratorType>
	{
		[Token(Token = "0x17000550")]
		public override string Name
		{
			[Token(Token = "0x60016F7")]
			[Address(RVA = "0x29C24E0", Offset = "0x29C16E0", VA = "0x1829C24E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000551")]
		public override string ussName
		{
			[Token(Token = "0x60016F8")]
			[Address(RVA = "0x29C2510", Offset = "0x29C1710", VA = "0x1829C2510", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000552")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60016F9")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60016FA")]
		[Address(RVA = "0x29C2310", Offset = "0x29C1510", VA = "0x1829C2310", Slot = "14")]
		public override StyleEnum<TextGeneratorType> GetValue(ref InlineStyleAccess container)
		{
			return default(StyleEnum<TextGeneratorType>);
		}

		[Token(Token = "0x60016FB")]
		[Address(RVA = "0x29C23D0", Offset = "0x29C15D0", VA = "0x1829C23D0", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleEnum<TextGeneratorType> value)
		{
		}

		[Token(Token = "0x60016FC")]
		[Address(RVA = "0x29C24A0", Offset = "0x29C16A0", VA = "0x1829C24A0")]
		public UnityTextGeneratorProperty()
		{
		}
	}

	[Token(Token = "0x200032A")]
	private class UnityTextOutlineColorProperty : InlineStyleColorProperty
	{
		[Token(Token = "0x17000553")]
		public override string Name
		{
			[Token(Token = "0x60016FD")]
			[Address(RVA = "0x29C2700", Offset = "0x29C1900", VA = "0x1829C2700", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000554")]
		public override string ussName
		{
			[Token(Token = "0x60016FE")]
			[Address(RVA = "0x29C2730", Offset = "0x29C1930", VA = "0x1829C2730", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000555")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60016FF")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001700")]
		[Address(RVA = "0x29C2540", Offset = "0x29C1740", VA = "0x1829C2540", Slot = "14")]
		public override StyleColor GetValue(ref InlineStyleAccess container)
		{
			return default(StyleColor);
		}

		[Token(Token = "0x6001701")]
		[Address(RVA = "0x29C2620", Offset = "0x29C1820", VA = "0x1829C2620", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleColor value)
		{
		}

		[Token(Token = "0x6001702")]
		[Address(RVA = "0x29B4CA0", Offset = "0x29B3EA0", VA = "0x1829B4CA0")]
		public UnityTextOutlineColorProperty()
		{
		}
	}

	[Token(Token = "0x200032B")]
	private class UnityTextOutlineWidthProperty : InlineStyleFloatProperty
	{
		[Token(Token = "0x17000556")]
		public override string Name
		{
			[Token(Token = "0x6001703")]
			[Address(RVA = "0x29C2810", Offset = "0x29C1A10", VA = "0x1829C2810", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000557")]
		public override string ussName
		{
			[Token(Token = "0x6001704")]
			[Address(RVA = "0x29C2840", Offset = "0x29C1A40", VA = "0x1829C2840", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000558")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6001705")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001706")]
		[Address(RVA = "0x29C2760", Offset = "0x29C1960", VA = "0x1829C2760", Slot = "14")]
		public override StyleFloat GetValue(ref InlineStyleAccess container)
		{
			return default(StyleFloat);
		}

		[Token(Token = "0x6001707")]
		[Address(RVA = "0x29C27B0", Offset = "0x29C19B0", VA = "0x1829C27B0", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleFloat value)
		{
		}

		[Token(Token = "0x6001708")]
		[Address(RVA = "0x29B5F80", Offset = "0x29B5180", VA = "0x1829B5F80")]
		public UnityTextOutlineWidthProperty()
		{
		}
	}

	[Token(Token = "0x200032C")]
	private class UnityTextOverflowPositionProperty : InlineStyleEnumProperty<TextOverflowPosition>
	{
		[Token(Token = "0x17000559")]
		public override string Name
		{
			[Token(Token = "0x6001709")]
			[Address(RVA = "0x29C2A40", Offset = "0x29C1C40", VA = "0x1829C2A40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700055A")]
		public override string ussName
		{
			[Token(Token = "0x600170A")]
			[Address(RVA = "0x29C2A70", Offset = "0x29C1C70", VA = "0x1829C2A70", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700055B")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x600170B")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600170C")]
		[Address(RVA = "0x29C2870", Offset = "0x29C1A70", VA = "0x1829C2870", Slot = "14")]
		public override StyleEnum<TextOverflowPosition> GetValue(ref InlineStyleAccess container)
		{
			return default(StyleEnum<TextOverflowPosition>);
		}

		[Token(Token = "0x600170D")]
		[Address(RVA = "0x29C2930", Offset = "0x29C1B30", VA = "0x1829C2930", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleEnum<TextOverflowPosition> value)
		{
		}

		[Token(Token = "0x600170E")]
		[Address(RVA = "0x29C2A00", Offset = "0x29C1C00", VA = "0x1829C2A00")]
		public UnityTextOverflowPositionProperty()
		{
		}
	}

	[Token(Token = "0x200032D")]
	private class VisibilityProperty : InlineStyleEnumProperty<Visibility>
	{
		[Token(Token = "0x1700055C")]
		public override string Name
		{
			[Token(Token = "0x600170F")]
			[Address(RVA = "0x29C2C00", Offset = "0x29C1E00", VA = "0x1829C2C00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700055D")]
		public override string ussName
		{
			[Token(Token = "0x6001710")]
			[Address(RVA = "0x29C2C30", Offset = "0x29C1E30", VA = "0x1829C2C30", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700055E")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6001711")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001712")]
		[Address(RVA = "0x29C2AA0", Offset = "0x29C1CA0", VA = "0x1829C2AA0", Slot = "14")]
		public override StyleEnum<Visibility> GetValue(ref InlineStyleAccess container)
		{
			return default(StyleEnum<Visibility>);
		}

		[Token(Token = "0x6001713")]
		[Address(RVA = "0x29C2B60", Offset = "0x29C1D60", VA = "0x1829C2B60", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleEnum<Visibility> value)
		{
		}

		[Token(Token = "0x6001714")]
		[Address(RVA = "0x29C2BC0", Offset = "0x29C1DC0", VA = "0x1829C2BC0")]
		public VisibilityProperty()
		{
		}
	}

	[Token(Token = "0x200032E")]
	private class WhiteSpaceProperty : InlineStyleEnumProperty<WhiteSpace>
	{
		[Token(Token = "0x1700055F")]
		public override string Name
		{
			[Token(Token = "0x6001715")]
			[Address(RVA = "0x29D7CB0", Offset = "0x29D6EB0", VA = "0x1829D7CB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000560")]
		public override string ussName
		{
			[Token(Token = "0x6001716")]
			[Address(RVA = "0x29D7CE0", Offset = "0x29D6EE0", VA = "0x1829D7CE0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000561")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6001717")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001718")]
		[Address(RVA = "0x29D7AE0", Offset = "0x29D6CE0", VA = "0x1829D7AE0", Slot = "14")]
		public override StyleEnum<WhiteSpace> GetValue(ref InlineStyleAccess container)
		{
			return default(StyleEnum<WhiteSpace>);
		}

		[Token(Token = "0x6001719")]
		[Address(RVA = "0x29D7BA0", Offset = "0x29D6DA0", VA = "0x1829D7BA0", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleEnum<WhiteSpace> value)
		{
		}

		[Token(Token = "0x600171A")]
		[Address(RVA = "0x29D7C70", Offset = "0x29D6E70", VA = "0x1829D7C70")]
		public WhiteSpaceProperty()
		{
		}
	}

	[Token(Token = "0x200032F")]
	private class WidthProperty : InlineStyleLengthProperty
	{
		[Token(Token = "0x17000562")]
		public override string Name
		{
			[Token(Token = "0x600171B")]
			[Address(RVA = "0x29D7ED0", Offset = "0x29D70D0", VA = "0x1829D7ED0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000563")]
		public override string ussName
		{
			[Token(Token = "0x600171C")]
			[Address(RVA = "0x29D7F00", Offset = "0x29D7100", VA = "0x1829D7F00", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000564")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x600171D")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600171E")]
		[Address(RVA = "0x29D7D10", Offset = "0x29D6F10", VA = "0x1829D7D10", Slot = "14")]
		public override StyleLength GetValue(ref InlineStyleAccess container)
		{
			return default(StyleLength);
		}

		[Token(Token = "0x600171F")]
		[Address(RVA = "0x29D7DF0", Offset = "0x29D6FF0", VA = "0x1829D7DF0", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleLength value)
		{
		}

		[Token(Token = "0x6001720")]
		[Address(RVA = "0x29B5C40", Offset = "0x29B4E40", VA = "0x1829B5C40")]
		public WidthProperty()
		{
		}
	}

	[Token(Token = "0x2000330")]
	private class WordSpacingProperty : InlineStyleLengthProperty
	{
		[Token(Token = "0x17000565")]
		public override string Name
		{
			[Token(Token = "0x6001721")]
			[Address(RVA = "0x29D80F0", Offset = "0x29D72F0", VA = "0x1829D80F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000566")]
		public override string ussName
		{
			[Token(Token = "0x6001722")]
			[Address(RVA = "0x29D8120", Offset = "0x29D7320", VA = "0x1829D8120", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000567")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6001723")]
			[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001724")]
		[Address(RVA = "0x29D7F30", Offset = "0x29D7130", VA = "0x1829D7F30", Slot = "14")]
		public override StyleLength GetValue(ref InlineStyleAccess container)
		{
			return default(StyleLength);
		}

		[Token(Token = "0x6001725")]
		[Address(RVA = "0x29D8010", Offset = "0x29D7210", VA = "0x1829D8010", Slot = "15")]
		public override void SetValue(ref InlineStyleAccess container, StyleLength value)
		{
		}

		[Token(Token = "0x6001726")]
		[Address(RVA = "0x29B5C40", Offset = "0x29B4E40", VA = "0x1829B5C40")]
		public WordSpacingProperty()
		{
		}
	}

	[Token(Token = "0x2000331")]
	private abstract class InlineStyleProperty<TStyleValue, TValue> : Property<InlineStyleAccess, TStyleValue> where TStyleValue : IStyleValue<TValue>, new()
	{
		[Token(Token = "0x17000568")]
		public abstract string ussName
		{
			[Token(Token = "0x6001728")]
			get;
		}

		[Token(Token = "0x6001727")]
		protected InlineStyleProperty()
		{
		}
	}

	[Token(Token = "0x2000333")]
	private abstract class InlineStyleEnumProperty<TValue> : InlineStyleProperty<StyleEnum<TValue>, TValue> where TValue : struct, IConvertible
	{
		[Token(Token = "0x600172F")]
		protected InlineStyleEnumProperty()
		{
		}
	}

	[Token(Token = "0x2000334")]
	private abstract class InlineStyleColorProperty : InlineStyleProperty<StyleColor, Color>
	{
		[Token(Token = "0x6001730")]
		[Address(RVA = "0x29BA580", Offset = "0x29B9780", VA = "0x1829BA580")]
		protected InlineStyleColorProperty()
		{
		}
	}

	[Token(Token = "0x2000336")]
	private abstract class InlineStyleBackgroundProperty : InlineStyleProperty<StyleBackground, Background>
	{
		[Token(Token = "0x6001735")]
		[Address(RVA = "0x29B9E10", Offset = "0x29B9010", VA = "0x1829B9E10")]
		protected InlineStyleBackgroundProperty()
		{
		}
	}

	[Token(Token = "0x2000338")]
	private abstract class InlineStyleLengthProperty : InlineStyleProperty<StyleLength, Length>
	{
		[Token(Token = "0x6001740")]
		[Address(RVA = "0x29BAE30", Offset = "0x29BA030", VA = "0x1829BAE30")]
		protected InlineStyleLengthProperty()
		{
		}
	}

	[Token(Token = "0x200033A")]
	private abstract class InlineStyleFloatProperty : InlineStyleProperty<StyleFloat, float>
	{
		[Token(Token = "0x6001747")]
		[Address(RVA = "0x29BA7A0", Offset = "0x29B99A0", VA = "0x1829BA7A0")]
		protected InlineStyleFloatProperty()
		{
		}
	}

	[Token(Token = "0x200033C")]
	private abstract class InlineStyleListProperty<T> : InlineStyleProperty<StyleList<T>, List<T>>
	{
		[Token(Token = "0x600174C")]
		protected InlineStyleListProperty()
		{
		}
	}

	[Token(Token = "0x200033D")]
	private abstract class InlineStyleFontProperty : InlineStyleProperty<StyleFont, Font>
	{
		[Token(Token = "0x600174D")]
		[Address(RVA = "0x29BADB0", Offset = "0x29B9FB0", VA = "0x1829BADB0")]
		protected InlineStyleFontProperty()
		{
		}
	}

	[Token(Token = "0x200033E")]
	private abstract class InlineStyleFontDefinitionProperty : InlineStyleProperty<StyleFontDefinition, FontDefinition>
	{
		[Token(Token = "0x600174E")]
		[Address(RVA = "0x29BA9C0", Offset = "0x29B9BC0", VA = "0x1829BA9C0")]
		protected InlineStyleFontDefinitionProperty()
		{
		}
	}

	[Token(Token = "0x2000340")]
	private abstract class InlineStyleIntProperty : InlineStyleProperty<StyleInt, int>
	{
		[Token(Token = "0x6001755")]
		[Address(RVA = "0x29BADF0", Offset = "0x29B9FF0", VA = "0x1829BADF0")]
		protected InlineStyleIntProperty()
		{
		}
	}

	[Token(Token = "0x2000341")]
	private abstract class InlineStyleRotateProperty : InlineStyleProperty<StyleRotate, Rotate>
	{
		[Token(Token = "0x6001756")]
		[Address(RVA = "0x29BB220", Offset = "0x29BA420", VA = "0x1829BB220")]
		protected InlineStyleRotateProperty()
		{
		}
	}

	[Token(Token = "0x2000342")]
	private abstract class InlineStyleScaleProperty : InlineStyleProperty<StyleScale, Scale>
	{
		[Token(Token = "0x6001757")]
		[Address(RVA = "0x29BB260", Offset = "0x29BA460", VA = "0x1829BB260")]
		protected InlineStyleScaleProperty()
		{
		}
	}

	[Token(Token = "0x2000343")]
	private abstract class InlineStyleCursorProperty : InlineStyleProperty<StyleCursor, Cursor>
	{
		[Token(Token = "0x6001758")]
		[Address(RVA = "0x29B73C0", Offset = "0x29B65C0", VA = "0x1829B73C0")]
		protected InlineStyleCursorProperty()
		{
		}
	}

	[Token(Token = "0x2000344")]
	private abstract class InlineStyleTextShadowProperty : InlineStyleProperty<StyleTextShadow, TextShadow>
	{
		[Token(Token = "0x6001759")]
		[Address(RVA = "0x29BB2A0", Offset = "0x29BA4A0", VA = "0x1829BB2A0")]
		protected InlineStyleTextShadowProperty()
		{
		}
	}

	[Token(Token = "0x2000345")]
	private abstract class InlineStyleTransformOriginProperty : InlineStyleProperty<StyleTransformOrigin, TransformOrigin>
	{
		[Token(Token = "0x600175A")]
		[Address(RVA = "0x29BB2E0", Offset = "0x29BA4E0", VA = "0x1829BB2E0")]
		protected InlineStyleTransformOriginProperty()
		{
		}
	}

	[Token(Token = "0x2000346")]
	private abstract class InlineStyleTranslateProperty : InlineStyleProperty<StyleTranslate, Translate>
	{
		[Token(Token = "0x600175B")]
		[Address(RVA = "0x29BB320", Offset = "0x29BA520", VA = "0x1829BB320")]
		protected InlineStyleTranslateProperty()
		{
		}
	}

	[Token(Token = "0x2000347")]
	private abstract class InlineStyleBackgroundPositionProperty : InlineStyleProperty<StyleBackgroundPosition, BackgroundPosition>
	{
		[Token(Token = "0x600175C")]
		[Address(RVA = "0x29B5100", Offset = "0x29B4300", VA = "0x1829B5100")]
		protected InlineStyleBackgroundPositionProperty()
		{
		}
	}

	[Token(Token = "0x2000348")]
	private abstract class InlineStyleBackgroundRepeatProperty : InlineStyleProperty<StyleBackgroundRepeat, BackgroundRepeat>
	{
		[Token(Token = "0x600175D")]
		[Address(RVA = "0x29B5560", Offset = "0x29B4760", VA = "0x1829B5560")]
		protected InlineStyleBackgroundRepeatProperty()
		{
		}
	}

	[Token(Token = "0x2000349")]
	private abstract class InlineStyleBackgroundSizeProperty : InlineStyleProperty<StyleBackgroundSize, BackgroundSize>
	{
		[Token(Token = "0x600175E")]
		[Address(RVA = "0x29B57C0", Offset = "0x29B49C0", VA = "0x1829B57C0")]
		protected InlineStyleBackgroundSizeProperty()
		{
		}
	}

	[Token(Token = "0x4000B90")]
	[FieldOffset(Offset = "0x18")]
	private readonly List<IProperty<InlineStyleAccess>> m_PropertiesList;

	[Token(Token = "0x4000B91")]
	[FieldOffset(Offset = "0x20")]
	private readonly Dictionary<string, IProperty<InlineStyleAccess>> m_PropertiesHash;

	[Token(Token = "0x600152A")]
	[Address(RVA = "0x29B8470", Offset = "0x29B7670", VA = "0x1829B8470")]
	public InlineStyleAccessPropertyBag()
	{
	}

	[Token(Token = "0x600152B")]
	private void AddProperty<TStyleValue, TValue>(InlineStyleProperty<TStyleValue, TValue> property) where TStyleValue : IStyleValue<TValue>, new()
	{
	}

	[Token(Token = "0x600152C")]
	[Address(RVA = "0x29B8340", Offset = "0x29B7540", VA = "0x1829B8340", Slot = "12")]
	public override PropertyCollection<InlineStyleAccess> GetProperties()
	{
		return default(PropertyCollection<InlineStyleAccess>);
	}

	[Token(Token = "0x600152D")]
	[Address(RVA = "0x29B83A0", Offset = "0x29B75A0", VA = "0x1829B83A0", Slot = "13")]
	public override PropertyCollection<InlineStyleAccess> GetProperties(ref InlineStyleAccess container)
	{
		return default(PropertyCollection<InlineStyleAccess>);
	}

	[Token(Token = "0x600152E")]
	[Address(RVA = "0x29B8400", Offset = "0x29B7600", VA = "0x1829B8400", Slot = "16")]
	public bool TryGetProperty(ref InlineStyleAccess container, string name, out IProperty<InlineStyleAccess> property)
	{
		return default(bool);
	}
}
