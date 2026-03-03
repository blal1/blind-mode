using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Serializable]
[Token(Token = "0x20004BE")]
public abstract class UxmlSerializedData
{
	[Token(Token = "0x20004BF")]
	[Flags]
	public enum UxmlAttributeFlags : byte
	{
		[Token(Token = "0x4000F76")]
		Ignore = 0,
		[Token(Token = "0x4000F77")]
		OverriddenInUxml = 1,
		[Token(Token = "0x4000F78")]
		DefaultValue = 2
	}

	[Token(Token = "0x4000F71")]
	internal const string AttributeFlagSuffix = "_UxmlAttributeFlags";

	[Token(Token = "0x4000F72")]
	private const UxmlAttributeFlags k_DefaultFlags = UxmlAttributeFlags.OverriddenInUxml;

	[Token(Token = "0x4000F73")]
	[FieldOffset(Offset = "0x10")]
	[UxmlIgnore]
	[HideInInspector]
	[SerializeField]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal int uxmlAssetId;

	[Token(Token = "0x4000F74")]
	[FieldOffset(Offset = "0x0")]
	private static UxmlAttributeFlags s_CurrentDeserializeFlags;

	[Token(Token = "0x60022D0")]
	public abstract object CreateInstance();

	[Token(Token = "0x60022D1")]
	public abstract void Deserialize(object obj);

	[Token(Token = "0x60022D2")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected UxmlSerializedData()
	{
	}
}
