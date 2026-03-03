using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000580")]
internal class UIRVEShaderInfoAllocator
{
	[Token(Token = "0x40013A4")]
	[FieldOffset(Offset = "0x10")]
	private BaseShaderInfoStorage m_Storage;

	[Token(Token = "0x40013A5")]
	[FieldOffset(Offset = "0x18")]
	private BitmapAllocator32 m_TransformAllocator;

	[Token(Token = "0x40013A6")]
	[FieldOffset(Offset = "0x38")]
	private BitmapAllocator32 m_ClipRectAllocator;

	[Token(Token = "0x40013A7")]
	[FieldOffset(Offset = "0x58")]
	private BitmapAllocator32 m_OpacityAllocator;

	[Token(Token = "0x40013A8")]
	[FieldOffset(Offset = "0x78")]
	private BitmapAllocator32 m_ColorAllocator;

	[Token(Token = "0x40013A9")]
	[FieldOffset(Offset = "0x98")]
	private BitmapAllocator32 m_TextSettingsAllocator;

	[Token(Token = "0x40013AA")]
	[FieldOffset(Offset = "0xB8")]
	private bool m_StorageReallyCreated;

	[Token(Token = "0x40013AB")]
	[FieldOffset(Offset = "0xBC")]
	private ColorSpace m_ColorSpace;

	[Token(Token = "0x40013AC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Vector2Int identityTransformTexel;

	[Token(Token = "0x40013AD")]
	[FieldOffset(Offset = "0x8")]
	private static readonly Vector2Int infiniteClipRectTexel;

	[Token(Token = "0x40013AE")]
	[FieldOffset(Offset = "0x10")]
	private static readonly Vector2Int fullOpacityTexel;

	[Token(Token = "0x40013AF")]
	[FieldOffset(Offset = "0x18")]
	private static readonly Vector2Int clearColorTexel;

	[Token(Token = "0x40013B0")]
	[FieldOffset(Offset = "0x20")]
	private static readonly Vector2Int defaultTextCoreSettingsTexel;

	[Token(Token = "0x40013B1")]
	[FieldOffset(Offset = "0x28")]
	private static readonly Matrix4x4 identityTransformValue;

	[Token(Token = "0x40013B2")]
	[FieldOffset(Offset = "0x68")]
	private static readonly Vector4 identityTransformRow0Value;

	[Token(Token = "0x40013B3")]
	[FieldOffset(Offset = "0x78")]
	private static readonly Vector4 identityTransformRow1Value;

	[Token(Token = "0x40013B4")]
	[FieldOffset(Offset = "0x88")]
	private static readonly Vector4 identityTransformRow2Value;

	[Token(Token = "0x40013B5")]
	[FieldOffset(Offset = "0x98")]
	private static readonly Vector4 infiniteClipRectValue;

	[Token(Token = "0x40013B6")]
	[FieldOffset(Offset = "0xA8")]
	private static readonly Vector4 fullOpacityValue;

	[Token(Token = "0x40013B7")]
	[FieldOffset(Offset = "0xB8")]
	private static readonly Vector4 clearColorValue;

	[Token(Token = "0x40013B8")]
	[FieldOffset(Offset = "0xC8")]
	private static readonly TextCoreSettings defaultTextCoreSettingsValue;

	[Token(Token = "0x40013B9")]
	[FieldOffset(Offset = "0x108")]
	public static readonly BMPAlloc identityTransform;

	[Token(Token = "0x40013BA")]
	[FieldOffset(Offset = "0x110")]
	public static readonly BMPAlloc infiniteClipRect;

	[Token(Token = "0x40013BB")]
	[FieldOffset(Offset = "0x118")]
	public static readonly BMPAlloc fullOpacity;

	[Token(Token = "0x40013BC")]
	[FieldOffset(Offset = "0x120")]
	public static readonly BMPAlloc clearColor;

	[Token(Token = "0x40013BD")]
	[FieldOffset(Offset = "0x128")]
	public static readonly BMPAlloc defaultTextCoreSettings;

	[Token(Token = "0x40013BE")]
	[FieldOffset(Offset = "0x130")]
	private static int s_DefaultShaderInfoTextureRefCount;

	[Token(Token = "0x40013BF")]
	[FieldOffset(Offset = "0x138")]
	private static Texture2D s_DefaultShaderInfoTexture;

	[Token(Token = "0x170009C8")]
	private static int pageWidth
	{
		[Token(Token = "0x60026C3")]
		[Address(RVA = "0x2A805E0", Offset = "0x2A7F7E0", VA = "0x182A805E0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170009C9")]
	private static int pageHeight
	{
		[Token(Token = "0x60026C4")]
		[Address(RVA = "0x2A805D0", Offset = "0x2A7F7D0", VA = "0x182A805D0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170009CA")]
	public Texture atlas
	{
		[Token(Token = "0x60026C9")]
		[Address(RVA = "0x2A80540", Offset = "0x2A7F740", VA = "0x182A80540")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60026C5")]
	[Address(RVA = "0x2A7D7F0", Offset = "0x2A7C9F0", VA = "0x182A7D7F0")]
	private static void AcquireDefaultShaderInfoTexture()
	{
	}

	[Token(Token = "0x60026C6")]
	[Address(RVA = "0x2A7F1F0", Offset = "0x2A7E3F0", VA = "0x182A7F1F0")]
	private static void ReleaseDefaultShaderInfoTexture()
	{
	}

	[Token(Token = "0x60026C7")]
	[Address(RVA = "0x2A7DDD0", Offset = "0x2A7CFD0", VA = "0x182A7DDD0")]
	private static Vector2Int AllocToTexelCoord(ref BitmapAllocator32 allocator, BMPAlloc alloc)
	{
		return default(Vector2Int);
	}

	[Token(Token = "0x60026C8")]
	[Address(RVA = "0x2A7DE80", Offset = "0x2A7D080", VA = "0x182A7DE80")]
	private static bool AtlasRectMatchesPage(ref BitmapAllocator32 allocator, BMPAlloc defAlloc, RectInt atlasRect)
	{
		return default(bool);
	}

	[Token(Token = "0x60026CA")]
	[Address(RVA = "0x2A80300", Offset = "0x2A7F500", VA = "0x182A80300")]
	public UIRVEShaderInfoAllocator(ColorSpace colorSpace)
	{
	}

	[Token(Token = "0x60026CB")]
	[Address(RVA = "0x2A7E7A0", Offset = "0x2A7D9A0", VA = "0x182A7E7A0")]
	private void ReallyCreateStorage()
	{
	}

	[Token(Token = "0x60026CC")]
	[Address(RVA = "0x2A7E200", Offset = "0x2A7D400", VA = "0x182A7E200")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60026CD")]
	[Address(RVA = "0x2A7E680", Offset = "0x2A7D880", VA = "0x182A7E680")]
	public void IssuePendingStorageChanges()
	{
	}

	[Token(Token = "0x60026CE")]
	[Address(RVA = "0x2A7DE50", Offset = "0x2A7D050", VA = "0x182A7DE50")]
	public BMPAlloc AllocTransform()
	{
		return default(BMPAlloc);
	}

	[Token(Token = "0x60026CF")]
	[Address(RVA = "0x2A7DD00", Offset = "0x2A7CF00", VA = "0x182A7DD00")]
	public BMPAlloc AllocClipRect()
	{
		return default(BMPAlloc);
	}

	[Token(Token = "0x60026D0")]
	[Address(RVA = "0x2A7DD60", Offset = "0x2A7CF60", VA = "0x182A7DD60")]
	public BMPAlloc AllocOpacity()
	{
		return default(BMPAlloc);
	}

	[Token(Token = "0x60026D1")]
	[Address(RVA = "0x2A7DD30", Offset = "0x2A7CF30", VA = "0x182A7DD30")]
	public BMPAlloc AllocColor()
	{
		return default(BMPAlloc);
	}

	[Token(Token = "0x60026D2")]
	[Address(RVA = "0x2A7DD90", Offset = "0x2A7CF90", VA = "0x182A7DD90")]
	public BMPAlloc AllocTextCoreSettings(TextCoreSettings settings)
	{
		return default(BMPAlloc);
	}

	[Token(Token = "0x60026D3")]
	[Address(RVA = "0x2A7FB70", Offset = "0x2A7ED70", VA = "0x182A7FB70")]
	public void SetTransformValue(BMPAlloc alloc, Matrix4x4 xform)
	{
	}

	[Token(Token = "0x60026D4")]
	[Address(RVA = "0x2A7F2F0", Offset = "0x2A7E4F0", VA = "0x182A7F2F0")]
	public void SetClipRectValue(BMPAlloc alloc, Vector4 clipRect)
	{
	}

	[Token(Token = "0x60026D5")]
	[Address(RVA = "0x2A7F600", Offset = "0x2A7E800", VA = "0x182A7F600")]
	public void SetOpacityValue(BMPAlloc alloc, float opacity)
	{
	}

	[Token(Token = "0x60026D6")]
	[Address(RVA = "0x2A7F430", Offset = "0x2A7E630", VA = "0x182A7F430")]
	public void SetColorValue(BMPAlloc alloc, Color color)
	{
	}

	[Token(Token = "0x60026D7")]
	[Address(RVA = "0x2A7F740", Offset = "0x2A7E940", VA = "0x182A7F740")]
	public void SetTextCoreSettingValue(BMPAlloc alloc, TextCoreSettings settings)
	{
	}

	[Token(Token = "0x60026D8")]
	[Address(RVA = "0x2A7E5E0", Offset = "0x2A7D7E0", VA = "0x182A7E5E0")]
	public void FreeTransform(BMPAlloc alloc)
	{
	}

	[Token(Token = "0x60026D9")]
	[Address(RVA = "0x2A7E360", Offset = "0x2A7D560", VA = "0x182A7E360")]
	public void FreeClipRect(BMPAlloc alloc)
	{
	}

	[Token(Token = "0x60026DA")]
	[Address(RVA = "0x2A7E4A0", Offset = "0x2A7D6A0", VA = "0x182A7E4A0")]
	public void FreeOpacity(BMPAlloc alloc)
	{
	}

	[Token(Token = "0x60026DB")]
	[Address(RVA = "0x2A7E400", Offset = "0x2A7D600", VA = "0x182A7E400")]
	public void FreeColor(BMPAlloc alloc)
	{
	}

	[Token(Token = "0x60026DC")]
	[Address(RVA = "0x2A7E540", Offset = "0x2A7D740", VA = "0x182A7E540")]
	public void FreeTextCoreSettings(BMPAlloc alloc)
	{
	}

	[Token(Token = "0x60026DD")]
	[Address(RVA = "0x2A7FEF0", Offset = "0x2A7F0F0", VA = "0x182A7FEF0")]
	public Color32 TransformAllocToVertexData(BMPAlloc alloc)
	{
		return default(Color32);
	}

	[Token(Token = "0x60026DE")]
	[Address(RVA = "0x2A7E000", Offset = "0x2A7D200", VA = "0x182A7E000")]
	public Color32 ClipRectAllocToVertexData(BMPAlloc alloc)
	{
		return default(Color32);
	}

	[Token(Token = "0x60026DF")]
	[Address(RVA = "0x2A7E6A0", Offset = "0x2A7D8A0", VA = "0x182A7E6A0")]
	public Color32 OpacityAllocToVertexData(BMPAlloc alloc)
	{
		return default(Color32);
	}

	[Token(Token = "0x60026E0")]
	[Address(RVA = "0x2A7E100", Offset = "0x2A7D300", VA = "0x182A7E100")]
	public Color32 ColorAllocToVertexData(BMPAlloc alloc)
	{
		return default(Color32);
	}

	[Token(Token = "0x60026E1")]
	[Address(RVA = "0x2A7FDF0", Offset = "0x2A7EFF0", VA = "0x182A7FDF0")]
	public Color32 TextCoreSettingsToVertexData(BMPAlloc alloc)
	{
		return default(Color32);
	}
}
