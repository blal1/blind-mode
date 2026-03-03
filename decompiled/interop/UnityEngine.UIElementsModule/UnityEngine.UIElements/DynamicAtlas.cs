using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000008")]
internal class DynamicAtlas : AtlasBase
{
	[Token(Token = "0x2000009")]
	internal class TextureInfo : LinkedPoolItem<TextureInfo>
	{
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x18")]
		public DynamicAtlasPage page;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x20")]
		public int counter;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x28")]
		public Allocator2D.Alloc2D alloc;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x58")]
		public RectInt rect;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x0")]
		public static readonly LinkedPool<TextureInfo> pool;

		[MethodImpl(256)]
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2997FB0", Offset = "0x29971B0", VA = "0x182997FB0")]
		private static TextureInfo Create()
		{
			return null;
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2998020", Offset = "0x2997220", VA = "0x182998020")]
		private static void Reset(TextureInfo info)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2998190", Offset = "0x2997390", VA = "0x182998190")]
		public TextureInfo()
		{
		}
	}

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<Texture, TextureInfo> m_Database;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x20")]
	private DynamicAtlasPage m_PointPage;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x28")]
	private DynamicAtlasPage m_BilinearPage;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x30")]
	private ColorSpace m_ColorSpace;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x38")]
	private List<IPanel> m_Panels;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x40")]
	private int m_MinAtlasSize;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x44")]
	private int m_MaxAtlasSize;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x48")]
	private int m_MaxSubTextureSize;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x4C")]
	private DynamicAtlasFilters m_ActiveFilters;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x50")]
	private DynamicAtlasCustomFilter m_CustomFilter;

	[Token(Token = "0x17000001")]
	internal bool isInitialized
	{
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2993270", Offset = "0x2992470", VA = "0x182993270")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000002")]
	public int minAtlasSize
	{
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2993350", Offset = "0x2992550", VA = "0x182993350")]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public int maxAtlasSize
	{
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2993310", Offset = "0x2992510", VA = "0x182993310")]
		set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public static DynamicAtlasFilters defaultFilters
	{
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x218CDB0", Offset = "0x218BFB0", VA = "0x18218CDB0")]
		get
		{
			return default(DynamicAtlasFilters);
		}
	}

	[Token(Token = "0x17000005")]
	public DynamicAtlasFilters activeFilters
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2993290", Offset = "0x2992490", VA = "0x182993290")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public int maxSubTextureSize
	{
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2844C50", Offset = "0x2843E50", VA = "0x182844C50")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2993330", Offset = "0x2992530", VA = "0x182993330")]
		set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public DynamicAtlasCustomFilter customFilter
	{
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x29932B0", Offset = "0x29924B0", VA = "0x1829932B0")]
		set
		{
		}
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x29926D0", Offset = "0x29918D0", VA = "0x1829926D0", Slot = "7")]
	protected override void OnAssignedToPanel(IPanel panel)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x29927A0", Offset = "0x29919A0", VA = "0x1829927A0", Slot = "8")]
	protected override void OnRemovedFromPanel(IPanel panel)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x29928B0", Offset = "0x2991AB0", VA = "0x1829928B0", Slot = "6")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x2992320", Offset = "0x2991520", VA = "0x182992320")]
	private void InitPages()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x2992290", Offset = "0x2991490", VA = "0x182992290")]
	private void DestroyPages()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x2992B80", Offset = "0x2991D80", VA = "0x182992B80", Slot = "4")]
	public override bool TryGetAtlas(VisualElement ve, Texture2D src, out TextureId atlas, out RectInt atlasRect)
	{
		return default(bool);
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x2992A30", Offset = "0x2991C30", VA = "0x182992A30", Slot = "5")]
	public override void ReturnAtlas(VisualElement ve, Texture2D src, TextureId atlas)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x2992830", Offset = "0x2991A30", VA = "0x182992830", Slot = "9")]
	protected override void OnUpdateDynamicTextures(IPanel panel)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x2992470", Offset = "0x2991670", VA = "0x182992470")]
	internal static bool IsTextureFormatSupported(TextureFormat format)
	{
		return default(bool);
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x2992500", Offset = "0x2991700", VA = "0x182992500", Slot = "10")]
	public virtual bool IsTextureValid(Texture2D texture, FilterMode atlasFilterMode)
	{
		return default(bool);
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x2993110", Offset = "0x2992310", VA = "0x182993110")]
	public DynamicAtlas()
	{
	}
}
