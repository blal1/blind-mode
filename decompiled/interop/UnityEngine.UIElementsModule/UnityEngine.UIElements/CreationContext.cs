using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x20004D0")]
public struct CreationContext : IEquatable<CreationContext>
{
	[Token(Token = "0x20004D1")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal struct AttributeOverrideRange
	{
		[Token(Token = "0x4000FC3")]
		[FieldOffset(Offset = "0x0")]
		internal readonly VisualTreeAsset sourceAsset;

		[Token(Token = "0x4000FC4")]
		[FieldOffset(Offset = "0x8")]
		internal readonly List<TemplateAsset.AttributeOverride> attributeOverrides;

		[Token(Token = "0x600235E")]
		[Address(RVA = "0x5BF700", Offset = "0x5BE900", VA = "0x1805BF700")]
		public AttributeOverrideRange(VisualTreeAsset sourceAsset, List<TemplateAsset.AttributeOverride> attributeOverrides)
		{
		}
	}

	[Token(Token = "0x20004D2")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal struct SerializedDataOverrideRange
	{
		[Token(Token = "0x4000FC5")]
		[FieldOffset(Offset = "0x0")]
		internal readonly VisualTreeAsset sourceAsset;

		[Token(Token = "0x4000FC6")]
		[FieldOffset(Offset = "0x8")]
		internal readonly int templateId;

		[Token(Token = "0x4000FC7")]
		[FieldOffset(Offset = "0x10")]
		internal readonly List<TemplateAsset.UxmlSerializedDataOverride> attributeOverrides;

		[Token(Token = "0x600235F")]
		[Address(RVA = "0x2A32410", Offset = "0x2A31610", VA = "0x182A32410")]
		public SerializedDataOverrideRange(VisualTreeAsset sourceAsset, List<TemplateAsset.UxmlSerializedDataOverride> attributeOverrides, int templateId)
		{
		}
	}

	[Token(Token = "0x4000FBB")]
	[FieldOffset(Offset = "0x0")]
	public static readonly CreationContext Default;

	[Token(Token = "0x1700094E")]
	public VisualElement target
	{
		[Token(Token = "0x6002346")]
		[Address(RVA = "0x5BF740", Offset = "0x5BE940", VA = "0x1805BF740")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Token(Token = "0x6002347")]
		[Address(RVA = "0x5BF760", Offset = "0x5BE960", VA = "0x1805BF760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700094F")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal List<int> veaIdsPath
	{
		[Token(Token = "0x6002348")]
		[Address(RVA = "0x5BF750", Offset = "0x5BE950", VA = "0x1805BF750")]
		[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Token(Token = "0x6002349")]
		[Address(RVA = "0x5BF770", Offset = "0x5BE970", VA = "0x1805BF770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000950")]
	public VisualTreeAsset visualTreeAsset
	{
		[Token(Token = "0x600234A")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Token(Token = "0x600234B")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000951")]
	public Dictionary<string, VisualElement> slotInsertionPoints
	{
		[Token(Token = "0x600234C")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Token(Token = "0x600234D")]
		[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000952")]
	internal List<AttributeOverrideRange> attributeOverrides
	{
		[Token(Token = "0x600234E")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Token(Token = "0x600234F")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000953")]
	internal List<SerializedDataOverrideRange> serializedDataOverrides
	{
		[Token(Token = "0x6002350")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Token(Token = "0x6002351")]
		[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000954")]
	internal List<string> namesPath
	{
		[Token(Token = "0x6002352")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Token(Token = "0x6002353")]
		[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000955")]
	internal bool hasOverrides
	{
		[Token(Token = "0x6002354")]
		[Address(RVA = "0x2A2E530", Offset = "0x2A2D730", VA = "0x182A2E530")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6002355")]
	[Address(RVA = "0x2A2E280", Offset = "0x2A2D480", VA = "0x182A2E280")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal CreationContext(VisualTreeAsset vta)
	{
	}

	[Token(Token = "0x6002356")]
	[Address(RVA = "0x2A2E200", Offset = "0x2A2D400", VA = "0x182A2E200")]
	internal CreationContext(Dictionary<string, VisualElement> slotInsertionPoints, List<AttributeOverrideRange> attributeOverrides)
	{
	}

	[Token(Token = "0x6002357")]
	[Address(RVA = "0x2A2E3C0", Offset = "0x2A2D5C0", VA = "0x182A2E3C0")]
	internal CreationContext(Dictionary<string, VisualElement> slotInsertionPoints, VisualTreeAsset vta, VisualElement target)
	{
	}

	[Token(Token = "0x6002358")]
	[Address(RVA = "0x2A2E320", Offset = "0x2A2D520", VA = "0x182A2E320")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal CreationContext(Dictionary<string, VisualElement> slotInsertionPoints, List<AttributeOverrideRange> attributeOverrides, VisualTreeAsset vta, VisualElement target)
	{
	}

	[Token(Token = "0x6002359")]
	[Address(RVA = "0x2A2E450", Offset = "0x2A2D650", VA = "0x182A2E450")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal CreationContext(Dictionary<string, VisualElement> slotInsertionPoints, List<AttributeOverrideRange> attributeOverrides, List<SerializedDataOverrideRange> serializedDataOverrides, VisualTreeAsset vta, VisualElement target, List<int> veaIdsPath, List<string> namesPath)
	{
	}

	[Token(Token = "0x600235A")]
	[Address(RVA = "0x2A2DFC0", Offset = "0x2A2D1C0", VA = "0x182A2DFC0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x600235B")]
	[Address(RVA = "0x2A2DE60", Offset = "0x2A2D060", VA = "0x182A2DE60", Slot = "4")]
	public bool Equals(CreationContext other)
	{
		return default(bool);
	}

	[Token(Token = "0x600235C")]
	[Address(RVA = "0x2A2E090", Offset = "0x2A2D290", VA = "0x182A2E090", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
