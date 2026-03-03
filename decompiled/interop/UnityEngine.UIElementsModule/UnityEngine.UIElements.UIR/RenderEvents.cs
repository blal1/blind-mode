using System;
using Il2CppDummyDll;
using Unity.Profiling;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000567")]
internal static class RenderEvents
{
	[Token(Token = "0x4001335")]
	[FieldOffset(Offset = "0x0")]
	private static readonly ProfilerMarker k_NudgeVerticesMarker;

	[Token(Token = "0x4001336")]
	[FieldOffset(Offset = "0x8")]
	private static readonly float VisibilityTreshold;

	[Token(Token = "0x600263C")]
	[Address(RVA = "0x2A60D70", Offset = "0x2A5FF70", VA = "0x182A60D70")]
	internal static void ProcessOnClippingChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats)
	{
	}

	[Token(Token = "0x600263D")]
	[Address(RVA = "0x2A60F20", Offset = "0x2A60120", VA = "0x182A60F20")]
	internal static void ProcessOnOpacityChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats)
	{
	}

	[Token(Token = "0x600263E")]
	[Address(RVA = "0x2A60E90", Offset = "0x2A60090", VA = "0x182A60E90")]
	internal static void ProcessOnColorChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats)
	{
	}

	[Token(Token = "0x600263F")]
	[Address(RVA = "0x2A61030", Offset = "0x2A60230", VA = "0x182A61030")]
	internal static void ProcessOnTransformOrSizeChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats)
	{
	}

	[Token(Token = "0x6002640")]
	[Address(RVA = "0x2A5FC80", Offset = "0x2A5EE80", VA = "0x182A5FC80")]
	private static Matrix4x4 GetTransformIDTransformInfo(VisualElement ve)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x6002641")]
	[Address(RVA = "0x2A5F990", Offset = "0x2A5EB90", VA = "0x182A5F990")]
	private static Vector4 GetClipRectIDClipInfo(VisualElement ve)
	{
		return default(Vector4);
	}

	[Token(Token = "0x6002642")]
	[Address(RVA = "0x2A5D4E0", Offset = "0x2A5C6E0", VA = "0x182A5D4E0")]
	internal static uint DepthFirstOnChildAdded(RenderChain renderChain, VisualElement parent, VisualElement ve, int index, bool resetState)
	{
		return default(uint);
	}

	[Token(Token = "0x6002643")]
	[Address(RVA = "0x2A5DD10", Offset = "0x2A5CF10", VA = "0x182A5DD10")]
	internal static uint DepthFirstOnChildRemoving(RenderChain renderChain, VisualElement ve)
	{
		return default(uint);
	}

	[Token(Token = "0x6002644")]
	[Address(RVA = "0x2A5E840", Offset = "0x2A5DA40", VA = "0x182A5E840")]
	private static void DepthFirstOnClippingChanged(RenderChain renderChain, VisualElement parent, VisualElement ve, uint dirtyID, bool hierarchical, bool isRootOfChange, bool isPendingHierarchicalRepaint, bool inheritedClipRectIDChanged, bool inheritedMaskingChanged, UIRenderDevice device, ref ChainBuilderStats stats)
	{
	}

	[Token(Token = "0x6002645")]
	[Address(RVA = "0x2A5EEE0", Offset = "0x2A5E0E0", VA = "0x182A5EEE0")]
	private static void DepthFirstOnOpacityChanged(RenderChain renderChain, float parentCompositeOpacity, VisualElement ve, uint dirtyID, bool hierarchical, ref ChainBuilderStats stats, bool isDoingFullVertexRegeneration = false)
	{
	}

	[Token(Token = "0x6002646")]
	[Address(RVA = "0x2A60900", Offset = "0x2A5FB00", VA = "0x182A60900")]
	private static void OnColorChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats)
	{
	}

	[Token(Token = "0x6002647")]
	[Address(RVA = "0x2A5F380", Offset = "0x2A5E580", VA = "0x182A5F380")]
	private static void DepthFirstOnTransformOrSizeChanged(RenderChain renderChain, VisualElement parent, VisualElement ve, uint dirtyID, UIRenderDevice device, bool isAncestorOfChangeSkinned, bool transformChanged, ref ChainBuilderStats stats)
	{
	}

	[Token(Token = "0x6002648")]
	[Address(RVA = "0x2A618E0", Offset = "0x2A60AE0", VA = "0x182A618E0")]
	public static bool UpdateTextCoreSettings(RenderChain renderChain, VisualElement ve)
	{
		return default(bool);
	}

	[Token(Token = "0x6002649")]
	[Address(RVA = "0x2A602F0", Offset = "0x2A5F4F0", VA = "0x182A602F0")]
	private static bool NudgeVerticesToNewSpace(VisualElement ve, RenderChain renderChain, UIRenderDevice device)
	{
		return default(bool);
	}

	[Token(Token = "0x600264A")]
	[Address(RVA = "0x2A60C20", Offset = "0x2A5FE20", VA = "0x182A60C20")]
	private static void PrepareNudgeVertices(VisualElement ve, UIRenderDevice device, MeshHandle mesh, out IntPtr src, out IntPtr dst, out int count)
	{
	}

	[Token(Token = "0x600264B")]
	[Address(RVA = "0x2A5FC00", Offset = "0x2A5EE00", VA = "0x182A5FC00")]
	private static VisualElement GetLastDeepestChild(VisualElement ve)
	{
		return null;
	}

	[Token(Token = "0x600264C")]
	[Address(RVA = "0x2A5F8A0", Offset = "0x2A5EAA0", VA = "0x182A5F8A0")]
	private static ClipMethod DetermineSelfClipMethod(RenderChain renderChain, VisualElement ve)
	{
		return default(ClipMethod);
	}

	[Token(Token = "0x600264D")]
	[Address(RVA = "0x2A617D0", Offset = "0x2A609D0", VA = "0x182A617D0")]
	private static bool UpdateLocalFlipsWinding(VisualElement ve)
	{
		return default(bool);
	}

	[Token(Token = "0x600264E")]
	[Address(RVA = "0x2A61E10", Offset = "0x2A61010", VA = "0x182A61E10")]
	private static void UpdateZeroScaling(VisualElement ve)
	{
	}

	[Token(Token = "0x600264F")]
	[Address(RVA = "0x2A602C0", Offset = "0x2A5F4C0", VA = "0x182A602C0")]
	private static bool NeedsTransformID(VisualElement ve)
	{
		return default(bool);
	}

	[Token(Token = "0x6002650")]
	[Address(RVA = "0x2A601B0", Offset = "0x2A5F3B0", VA = "0x182A601B0")]
	internal static bool NeedsColorID(VisualElement ve)
	{
		return default(bool);
	}

	[Token(Token = "0x6002651")]
	[Address(RVA = "0x2A601D0", Offset = "0x2A5F3D0", VA = "0x182A601D0")]
	internal static bool NeedsTextCoreSettings(VisualElement ve)
	{
		return default(bool);
	}

	[Token(Token = "0x6002652")]
	[Address(RVA = "0x2A5FE50", Offset = "0x2A5F050", VA = "0x182A5FE50")]
	private static bool InitColorIDs(RenderChain renderChain, VisualElement ve)
	{
		return default(bool);
	}

	[Token(Token = "0x6002653")]
	[Address(RVA = "0x2A61110", Offset = "0x2A60310", VA = "0x182A61110")]
	public static void SetColorValues(RenderChain renderChain, VisualElement ve)
	{
	}
}
