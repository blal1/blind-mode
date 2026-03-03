using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000490")]
public abstract class UxmlAttributeDescription
{
	[Token(Token = "0x2000491")]
	public enum Use
	{
		[Token(Token = "0x4000F3C")]
		None,
		[Token(Token = "0x4000F3D")]
		Optional,
		[Token(Token = "0x4000F3E")]
		Prohibited,
		[Token(Token = "0x4000F3F")]
		Required
	}

	[Token(Token = "0x4000F36")]
	[FieldOffset(Offset = "0x18")]
	private string[] m_ObsoleteNames;

	[Token(Token = "0x1700091A")]
	public string name
	{
		[Token(Token = "0x600223E")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600223F")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700091B")]
	public IEnumerable<string> obsoleteNames
	{
		[Token(Token = "0x6002240")]
		[Address(RVA = "0x2A1C4A0", Offset = "0x2A1B6A0", VA = "0x182A1C4A0")]
		set
		{
		}
	}

	[Token(Token = "0x1700091C")]
	protected internal string type
	{
		[Token(Token = "0x6002241")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700091D")]
	protected string typeNamespace
	{
		[Token(Token = "0x6002242")]
		[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700091E")]
	public Use use
	{
		[Token(Token = "0x6002243")]
		[Address(RVA = "0x49C0C0", Offset = "0x49B2C0", VA = "0x18049C0C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700091F")]
	public UxmlTypeRestriction restriction
	{
		[Token(Token = "0x6002244")]
		[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x600223D")]
	[Address(RVA = "0x2A1C470", Offset = "0x2A1B670", VA = "0x182A1C470")]
	protected UxmlAttributeDescription()
	{
	}

	[Token(Token = "0x6002245")]
	[Address(RVA = "0x2A1BA40", Offset = "0x2A1AC40", VA = "0x182A1BA40")]
	internal bool TryFindValueInAttributeOverrides(string elementName, CreationContext cc, List<TemplateAsset.AttributeOverride> attributeOverrides, out string value)
	{
		return default(bool);
	}

	[Token(Token = "0x6002246")]
	[Address(RVA = "0x2A1C3A0", Offset = "0x2A1B5A0", VA = "0x182A1C3A0")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal bool TryGetValueFromBagAsString(IUxmlAttributes bag, CreationContext cc, out string value)
	{
		return default(bool);
	}

	[Token(Token = "0x6002247")]
	[Address(RVA = "0x2A1BD80", Offset = "0x2A1AF80", VA = "0x182A1BD80")]
	internal bool TryGetAttributeOverrideValueFromBagAsString(IUxmlAttributes bag, CreationContext cc, out string value, out VisualTreeAsset sourceAsset)
	{
		return default(bool);
	}

	[Token(Token = "0x6002248")]
	[Address(RVA = "0x2A1C3F0", Offset = "0x2A1B5F0", VA = "0x182A1C3F0")]
	internal bool ValidateName()
	{
		return default(bool);
	}

	[Token(Token = "0x6002249")]
	[Address(RVA = "0x2A1C070", Offset = "0x2A1B270", VA = "0x182A1C070")]
	internal bool TryGetValueFromBagAsString(IUxmlAttributes bag, CreationContext cc, out string value, out VisualTreeAsset sourceAsset)
	{
		return default(bool);
	}

	[Token(Token = "0x600224A")]
	protected bool TryGetValueFromBag<T>(IUxmlAttributes bag, CreationContext cc, Func<string, T, T> converterFunc, T defaultValue, ref T value)
	{
		return default(bool);
	}

	[Token(Token = "0x600224B")]
	protected T GetValueFromBag<T>(IUxmlAttributes bag, CreationContext cc, Func<string, T, T> converterFunc, T defaultValue)
	{
		return (T)null;
	}
}
