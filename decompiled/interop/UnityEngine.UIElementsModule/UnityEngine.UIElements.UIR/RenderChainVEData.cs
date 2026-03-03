using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000563")]
internal struct RenderChainVEData
{
	[Token(Token = "0x4001303")]
	[FieldOffset(Offset = "0x0")]
	public VisualElement prev;

	[Token(Token = "0x4001304")]
	[FieldOffset(Offset = "0x8")]
	public VisualElement next;

	[Token(Token = "0x4001305")]
	[FieldOffset(Offset = "0x10")]
	public VisualElement groupTransformAncestor;

	[Token(Token = "0x4001306")]
	[FieldOffset(Offset = "0x18")]
	public VisualElement boneTransformAncestor;

	[Token(Token = "0x4001307")]
	[FieldOffset(Offset = "0x20")]
	public VisualElement prevDirty;

	[Token(Token = "0x4001308")]
	[FieldOffset(Offset = "0x28")]
	public VisualElement nextDirty;

	[Token(Token = "0x4001309")]
	[FieldOffset(Offset = "0x30")]
	public RenderDataFlags flags;

	[Token(Token = "0x400130A")]
	[FieldOffset(Offset = "0x34")]
	public int hierarchyDepth;

	[Token(Token = "0x400130B")]
	[FieldOffset(Offset = "0x38")]
	public RenderDataDirtyTypes dirtiedValues;

	[Token(Token = "0x400130C")]
	[FieldOffset(Offset = "0x3C")]
	public uint dirtyID;

	[Token(Token = "0x400130D")]
	[FieldOffset(Offset = "0x40")]
	public RenderChainCommand firstHeadCommand;

	[Token(Token = "0x400130E")]
	[FieldOffset(Offset = "0x48")]
	public RenderChainCommand lastHeadCommand;

	[Token(Token = "0x400130F")]
	[FieldOffset(Offset = "0x50")]
	public RenderChainCommand firstTailCommand;

	[Token(Token = "0x4001310")]
	[FieldOffset(Offset = "0x58")]
	public RenderChainCommand lastTailCommand;

	[Token(Token = "0x4001311")]
	[FieldOffset(Offset = "0x60")]
	public bool localFlipsWinding;

	[Token(Token = "0x4001312")]
	[FieldOffset(Offset = "0x61")]
	public bool localTransformScaleZero;

	[Token(Token = "0x4001313")]
	[FieldOffset(Offset = "0x62")]
	public bool worldFlipsWinding;

	[Token(Token = "0x4001314")]
	[FieldOffset(Offset = "0x63")]
	public bool worldTransformScaleZero;

	[Token(Token = "0x4001315")]
	[FieldOffset(Offset = "0x64")]
	public ClipMethod clipMethod;

	[Token(Token = "0x4001316")]
	[FieldOffset(Offset = "0x68")]
	public int childrenStencilRef;

	[Token(Token = "0x4001317")]
	[FieldOffset(Offset = "0x6C")]
	public int childrenMaskDepth;

	[Token(Token = "0x4001318")]
	[FieldOffset(Offset = "0x70")]
	public MeshHandle headMesh;

	[Token(Token = "0x4001319")]
	[FieldOffset(Offset = "0x78")]
	public MeshHandle tailMesh;

	[Token(Token = "0x400131A")]
	[FieldOffset(Offset = "0x80")]
	public Matrix4x4 verticesSpace;

	[Token(Token = "0x400131B")]
	[FieldOffset(Offset = "0xC0")]
	public BMPAlloc transformID;

	[Token(Token = "0x400131C")]
	[FieldOffset(Offset = "0xC8")]
	public BMPAlloc clipRectID;

	[Token(Token = "0x400131D")]
	[FieldOffset(Offset = "0xD0")]
	public BMPAlloc opacityID;

	[Token(Token = "0x400131E")]
	[FieldOffset(Offset = "0xD8")]
	public BMPAlloc textCoreSettingsID;

	[Token(Token = "0x400131F")]
	[FieldOffset(Offset = "0xE0")]
	public BMPAlloc colorID;

	[Token(Token = "0x4001320")]
	[FieldOffset(Offset = "0xE8")]
	public BMPAlloc backgroundColorID;

	[Token(Token = "0x4001321")]
	[FieldOffset(Offset = "0xF0")]
	public BMPAlloc borderLeftColorID;

	[Token(Token = "0x4001322")]
	[FieldOffset(Offset = "0xF8")]
	public BMPAlloc borderTopColorID;

	[Token(Token = "0x4001323")]
	[FieldOffset(Offset = "0x100")]
	public BMPAlloc borderRightColorID;

	[Token(Token = "0x4001324")]
	[FieldOffset(Offset = "0x108")]
	public BMPAlloc borderBottomColorID;

	[Token(Token = "0x4001325")]
	[FieldOffset(Offset = "0x110")]
	public BMPAlloc tintColorID;

	[Token(Token = "0x4001326")]
	[FieldOffset(Offset = "0x118")]
	public float compositeOpacity;

	[Token(Token = "0x4001327")]
	[FieldOffset(Offset = "0x11C")]
	public float backgroundAlpha;

	[Token(Token = "0x4001328")]
	[FieldOffset(Offset = "0x120")]
	public BasicNode<TextureEntry> textures;

	[Token(Token = "0x4001329")]
	[FieldOffset(Offset = "0x128")]
	public bool pendingRepaint;

	[Token(Token = "0x400132A")]
	[FieldOffset(Offset = "0x129")]
	public bool pendingHierarchicalRepaint;

	[Token(Token = "0x170009B4")]
	public RenderChainCommand lastTailOrHeadCommand
	{
		[Token(Token = "0x6002632")]
		[Address(RVA = "0x2A58B00", Offset = "0x2A57D00", VA = "0x182A58B00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009B5")]
	public bool isInChain
	{
		[MethodImpl(256)]
		[Token(Token = "0x6002635")]
		[Address(RVA = "0x2A58AF0", Offset = "0x2A57CF0", VA = "0x182A58AF0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170009B6")]
	public bool isGroupTransform
	{
		[MethodImpl(256)]
		[Token(Token = "0x6002636")]
		[Address(RVA = "0x2A58AE0", Offset = "0x2A57CE0", VA = "0x182A58AE0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170009B7")]
	public bool isIgnoringDynamicColorHint
	{
		[MethodImpl(256)]
		[Token(Token = "0x6002637")]
		[Address(RVA = "0x1FA7920", Offset = "0x1FA6B20", VA = "0x181FA7920")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170009B8")]
	public bool hasExtraData
	{
		[MethodImpl(256)]
		[Token(Token = "0x6002638")]
		[Address(RVA = "0x2A58AC0", Offset = "0x2A57CC0", VA = "0x182A58AC0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170009B9")]
	public bool hasExtraMeshes
	{
		[MethodImpl(256)]
		[Token(Token = "0x6002639")]
		[Address(RVA = "0x2A58AD0", Offset = "0x2A57CD0", VA = "0x182A58AD0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6002633")]
	[Address(RVA = "0x2A58A00", Offset = "0x2A57C00", VA = "0x182A58A00")]
	public static bool AllocatesID(BMPAlloc alloc)
	{
		return default(bool);
	}

	[Token(Token = "0x6002634")]
	[Address(RVA = "0x2A58A60", Offset = "0x2A57C60", VA = "0x182A58A60")]
	public static bool InheritsID(BMPAlloc alloc)
	{
		return default(bool);
	}
}
