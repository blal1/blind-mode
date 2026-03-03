using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.TextCore;
using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000451")]
internal class UITKTextHandle : UnityEngine.TextCore.Text.TextHandle
{
	[Token(Token = "0x4000E36")]
	[FieldOffset(Offset = "0xB0")]
	internal ATGTextEventHandler m_ATGTextEventHandler;

	[Token(Token = "0x4000E37")]
	[FieldOffset(Offset = "0xB8")]
	private List<(int, UnityEngine.TextCore.RichTextTagParser.TagType, string)> m_Links;

	[Token(Token = "0x4000E38")]
	[FieldOffset(Offset = "0xC0")]
	internal Color atgHyperlinkColor;

	[Token(Token = "0x4000E39")]
	[FieldOffset(Offset = "0x0")]
	private static UnityEngine.TextCore.Text.TextLib s_TextLib;

	[Token(Token = "0x4000E3E")]
	[FieldOffset(Offset = "0xF0")]
	internal TextEventHandler m_TextEventHandler;

	[Token(Token = "0x4000E3F")]
	[FieldOffset(Offset = "0xF8")]
	protected TextElement m_TextElement;

	[Token(Token = "0x4000E40")]
	[FieldOffset(Offset = "0x8")]
	internal static readonly float k_MinPadding;

	[Token(Token = "0x4000E41")]
	[FieldOffset(Offset = "0x100")]
	private bool wasAdvancedTextEnabledForElement;

	[Token(Token = "0x17000894")]
	private List<(int, UnityEngine.TextCore.RichTextTagParser.TagType, string)> Links
	{
		[Token(Token = "0x6001FFB")]
		[Address(RVA = "0x2A04D00", Offset = "0x2A03F00", VA = "0x182A04D00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000895")]
	protected internal UnityEngine.TextCore.Text.TextLib textLib
	{
		[MethodImpl(256)]
		[Token(Token = "0x6002005")]
		[Address(RVA = "0x2A04D90", Offset = "0x2A03F90", VA = "0x182A04D90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000896")]
	public Vector2 MeasuredSizes
	{
		[Token(Token = "0x6002008")]
		[Address(RVA = "0x2046DC0", Offset = "0x2045FC0", VA = "0x182046DC0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6002009")]
		[Address(RVA = "0x2A04FD0", Offset = "0x2A041D0", VA = "0x182A04FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000897")]
	public Vector2 RoundedSizes
	{
		[Token(Token = "0x600200A")]
		[Address(RVA = "0x139F4E0", Offset = "0x139E6E0", VA = "0x18139F4E0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x600200B")]
		[Address(RVA = "0x139F850", Offset = "0x139EA50", VA = "0x18139F850")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000898")]
	public Vector2 ATGMeasuredSizes
	{
		[Token(Token = "0x600200C")]
		[Address(RVA = "0x139F4C0", Offset = "0x139E6C0", VA = "0x18139F4C0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x600200D")]
		[Address(RVA = "0x139F840", Offset = "0x139EA40", VA = "0x18139F840")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000899")]
	public Vector2 ATGRoundedSizes
	{
		[Token(Token = "0x600200E")]
		[Address(RVA = "0x2A04CA0", Offset = "0x2A03EA0", VA = "0x182A04CA0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x600200F")]
		[Address(RVA = "0x2A04FC0", Offset = "0x2A041C0", VA = "0x182A04FC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700089A")]
	public override bool IsPlaceholder
	{
		[Token(Token = "0x600201D")]
		[Address(RVA = "0x2A04CC0", Offset = "0x2A03EC0", VA = "0x182A04CC0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6001FFC")]
	[Address(RVA = "0x2A02470", Offset = "0x2A01670", VA = "0x182A02470")]
	public void ComputeNativeTextSize(in UnityEngine.TextCore.Text.RenderedText textToMeasure, float width, float height)
	{
	}

	[Token(Token = "0x6001FFD")]
	[Address(RVA = "0x2A04910", Offset = "0x2A03B10", VA = "0x182A04910")]
	public (UnityEngine.TextCore.Text.NativeTextInfo, bool) UpdateNative(bool generateNativeSettings = true)
	{
		return default((UnityEngine.TextCore.Text.NativeTextInfo, bool));
	}

	[Token(Token = "0x6001FFE")]
	[Address(RVA = "0x2A04320", Offset = "0x2A03520", VA = "0x182A04320")]
	public void ProcessMeshInfos(UnityEngine.TextCore.Text.NativeTextInfo textInfo)
	{
	}

	[Token(Token = "0x6001FFF")]
	[Address(RVA = "0x2A04DF0", Offset = "0x2A03FF0", VA = "0x182A04DF0")]
	private (bool, bool) hasLinkAndHyperlink()
	{
		return default((bool, bool));
	}

	[Token(Token = "0x6002000")]
	[Address(RVA = "0x2A02270", Offset = "0x2A01470", VA = "0x182A02270")]
	internal (UnityEngine.TextCore.RichTextTagParser.TagType, string) ATGFindIntersectingLink(Vector2 point)
	{
		return default((UnityEngine.TextCore.RichTextTagParser.TagType, string));
	}

	[Token(Token = "0x6002001")]
	[Address(RVA = "0x2A047C0", Offset = "0x2A039C0", VA = "0x182A047C0")]
	internal void UpdateATGTextEventHandler()
	{
	}

	[Token(Token = "0x6002002")]
	[Address(RVA = "0x2A02B20", Offset = "0x2A01D20", VA = "0x182A02B20")]
	internal bool ConvertUssToNativeTextGenerationSettings()
	{
		return default(bool);
	}

	[Token(Token = "0x6002003")]
	[Address(RVA = "0x2A038D0", Offset = "0x2A02AD0", VA = "0x182A038D0")]
	private TextAsset GetICUAsset()
	{
		return null;
	}

	[Token(Token = "0x6002004")]
	[Address(RVA = "0x2A03810", Offset = "0x2A02A10", VA = "0x182A03810")]
	internal static TextAsset GetICUAssetStaticFalback()
	{
		return null;
	}

	[Token(Token = "0x6002006")]
	[Address(RVA = "0x2A041C0", Offset = "0x2A033C0", VA = "0x182A041C0")]
	protected internal void InitTextLib()
	{
	}

	[Token(Token = "0x6002007")]
	[Address(RVA = "0x2A04BC0", Offset = "0x2A03DC0", VA = "0x182A04BC0")]
	public UITKTextHandle(TextElement te)
	{
	}

	[Token(Token = "0x6002010")]
	[Address(RVA = "0x2A029E0", Offset = "0x2A01BE0", VA = "0x182A029E0")]
	public Vector2 ComputeTextSize(in UnityEngine.TextCore.Text.RenderedText textToMeasure, float width, float height)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6002011")]
	[Address(RVA = "0x2A02690", Offset = "0x2A01890", VA = "0x182A02690")]
	public void ComputeSettingsAndUpdate()
	{
	}

	[Token(Token = "0x6002012")]
	[Address(RVA = "0x2A03F20", Offset = "0x2A03120", VA = "0x182A03F20")]
	public void HandleATag()
	{
	}

	[Token(Token = "0x6002013")]
	[Address(RVA = "0x2A04080", Offset = "0x2A03280", VA = "0x182A04080")]
	public void HandleLinkTag()
	{
	}

	[Token(Token = "0x6002014")]
	[Address(RVA = "0x2A04060", Offset = "0x2A03260", VA = "0x182A04060")]
	public void HandleLinkAndATagCallbacks()
	{
	}

	[Token(Token = "0x6002015")]
	[Address(RVA = "0x2A04840", Offset = "0x2A03A40", VA = "0x182A04840")]
	public void UpdateMesh()
	{
	}

	[Token(Token = "0x6002016")]
	[Address(RVA = "0x2A023F0", Offset = "0x2A015F0", VA = "0x182A023F0", Slot = "4")]
	public override void AddTextInfoToPermanentCache()
	{
	}

	[Token(Token = "0x6002017")]
	[Address(RVA = "0x2A03BC0", Offset = "0x2A02DC0", VA = "0x182A03BC0")]
	private UnityEngine.TextCore.Text.TextOverflowMode GetTextOverflowMode()
	{
		return default(UnityEngine.TextCore.Text.TextOverflowMode);
	}

	[Token(Token = "0x6002018")]
	[Address(RVA = "0x2A03090", Offset = "0x2A02290", VA = "0x182A03090", Slot = "8")]
	internal virtual bool ConvertUssToTextGenerationSettings()
	{
		return default(bool);
	}

	[Token(Token = "0x6002019")]
	[Address(RVA = "0x2A04780", Offset = "0x2A03980", VA = "0x182A04780")]
	internal bool TextLibraryCanElide()
	{
		return default(bool);
	}

	[Token(Token = "0x600201A")]
	[Address(RVA = "0x2A03CB0", Offset = "0x2A02EB0", VA = "0x182A03CB0")]
	internal float GetVertexPadding(FontAsset fontAsset)
	{
		return default(float);
	}

	[Token(Token = "0x600201B")]
	[Address(RVA = "0x2A042B0", Offset = "0x2A034B0", VA = "0x182A042B0", Slot = "7")]
	internal override bool IsAdvancedTextEnabledForElement()
	{
		return default(bool);
	}

	[Token(Token = "0x600201C")]
	[Address(RVA = "0x2A043F0", Offset = "0x2A035F0", VA = "0x182A043F0")]
	internal void ReleaseResourcesIfPossible()
	{
	}

	[Token(Token = "0x600201E")]
	[Address(RVA = "0x2A042C0", Offset = "0x2A034C0", VA = "0x182A042C0")]
	public bool IsElided()
	{
		return default(bool);
	}
}
