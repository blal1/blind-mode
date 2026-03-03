using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct AttachmentDescriptor
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_LoadAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StoreAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Format;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LoadStoreTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ResolveTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ClearColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ClearDepth;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ClearStencil;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_loadAction_Public_set_Void_RenderBufferLoadAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_storeAction_Public_set_Void_RenderBufferStoreAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_loadStoreTarget_Public_get_RenderTargetIdentifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_loadStoreTarget_Public_set_Void_RenderTargetIdentifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_resolveTarget_Public_set_Void_RenderTargetIdentifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_clearColor_Public_set_Void_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_clearDepth_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_clearStencil_Public_set_Void_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureTarget_Public_Void_RenderTargetIdentifier_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureResolveTarget_Public_Void_RenderTargetIdentifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureClear_Public_Void_Color_Single_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AttachmentDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_AttachmentDescriptor_AttachmentDescriptor_0;

	[FieldOffset(0)]
	public RenderBufferLoadAction m_LoadAction;

	[FieldOffset(4)]
	public RenderBufferStoreAction m_StoreAction;

	[FieldOffset(8)]
	public GraphicsFormat m_Format;

	[FieldOffset(16)]
	public RenderTargetIdentifier m_LoadStoreTarget;

	[FieldOffset(56)]
	public RenderTargetIdentifier m_ResolveTarget;

	[FieldOffset(96)]
	public Color m_ClearColor;

	[FieldOffset(112)]
	public float m_ClearDepth;

	[FieldOffset(116)]
	public uint m_ClearStencil;

	public unsafe RenderBufferLoadAction loadAction
	{
		get
		{
			return m_LoadAction;
		}
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 53703, RefRangeEnd = 53715, XrefRangeStart = 53703, XrefRangeEnd = 53715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_loadAction_Public_set_Void_RenderBufferLoadAction_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe RenderBufferStoreAction storeAction
	{
		get
		{
			return m_StoreAction;
		}
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 376349, RefRangeEnd = 376359, XrefRangeStart = 376349, XrefRangeEnd = 376359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_storeAction_Public_set_Void_RenderBufferStoreAction_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe GraphicsFormat graphicsFormat
	{
		[CallerCount(46)]
		[CachedScanResults(RefRangeStart = 1153890, RefRangeEnd = 1153936, XrefRangeStart = 1153890, XrefRangeEnd = 1153936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_Format = value;
		}
	}

	public unsafe RenderTargetIdentifier loadStoreTarget
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1237829, RefRangeEnd = 1237833, XrefRangeStart = 1237829, XrefRangeEnd = 1237829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_loadStoreTarget_Public_get_RenderTargetIdentifier_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RenderTargetIdentifier*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1237833, RefRangeEnd = 1237836, XrefRangeStart = 1237833, XrefRangeEnd = 1237833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_loadStoreTarget_Public_set_Void_RenderTargetIdentifier_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe RenderTargetIdentifier resolveTarget
	{
		get
		{
			return m_ResolveTarget;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1237836, RefRangeEnd = 1237837, XrefRangeStart = 1237836, XrefRangeEnd = 1237836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_resolveTarget_Public_set_Void_RenderTargetIdentifier_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Color clearColor
	{
		get
		{
			return m_ClearColor;
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 591315, RefRangeEnd = 591317, XrefRangeStart = 591315, XrefRangeEnd = 591317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_clearColor_Public_set_Void_Color_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float clearDepth
	{
		get
		{
			return m_ClearDepth;
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 841985, RefRangeEnd = 841988, XrefRangeStart = 841985, XrefRangeEnd = 841988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_clearDepth_Public_set_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe uint clearStencil
	{
		get
		{
			return m_ClearStencil;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33833, RefRangeEnd = 33834, XrefRangeStart = 33833, XrefRangeEnd = 33834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_clearStencil_Public_set_Void_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public RenderTextureFormat format
	{
		get
		{
			if (GraphicsFormatUtility.IsDepthStencilFormat(m_Format))
			{
				return RenderTextureFormat.Depth;
			}
			return GraphicsFormatUtility.GetRenderTextureFormat(m_Format);
		}
		set
		{
			m_Format = GetAdjustedFormat(value, RenderTextureReadWrite.Default);
		}
	}

	static AttachmentDescriptor()
	{
		Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "AttachmentDescriptor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr);
		NativeFieldInfoPtr_m_LoadAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, "m_LoadAction");
		NativeFieldInfoPtr_m_StoreAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, "m_StoreAction");
		NativeFieldInfoPtr_m_Format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, "m_Format");
		NativeFieldInfoPtr_m_LoadStoreTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, "m_LoadStoreTarget");
		NativeFieldInfoPtr_m_ResolveTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, "m_ResolveTarget");
		NativeFieldInfoPtr_m_ClearColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, "m_ClearColor");
		NativeFieldInfoPtr_m_ClearDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, "m_ClearDepth");
		NativeFieldInfoPtr_m_ClearStencil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, "m_ClearStencil");
		NativeMethodInfoPtr_set_loadAction_Public_set_Void_RenderBufferLoadAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100668407);
		NativeMethodInfoPtr_set_storeAction_Public_set_Void_RenderBufferStoreAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100668408);
		NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100668409);
		NativeMethodInfoPtr_get_loadStoreTarget_Public_get_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100668410);
		NativeMethodInfoPtr_set_loadStoreTarget_Public_set_Void_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100668411);
		NativeMethodInfoPtr_set_resolveTarget_Public_set_Void_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100668412);
		NativeMethodInfoPtr_set_clearColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100668413);
		NativeMethodInfoPtr_set_clearDepth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100668414);
		NativeMethodInfoPtr_set_clearStencil_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100668415);
		NativeMethodInfoPtr_ConfigureTarget_Public_Void_RenderTargetIdentifier_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100668416);
		NativeMethodInfoPtr_ConfigureResolveTarget_Public_Void_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100668417);
		NativeMethodInfoPtr_ConfigureClear_Public_Void_Color_Single_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100668418);
		NativeMethodInfoPtr__ctor_Public_Void_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100668419);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AttachmentDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100668420);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100668421);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100668422);
		NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_AttachmentDescriptor_AttachmentDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100668423);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1237837, RefRangeEnd = 1237841, XrefRangeStart = 1237837, XrefRangeEnd = 1237837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfigureTarget(RenderTargetIdentifier target, bool loadExistingContents, bool storeResults)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&target);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &loadExistingContents;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &storeResults;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureTarget_Public_Void_RenderTargetIdentifier_Boolean_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1237841, RefRangeEnd = 1237843, XrefRangeStart = 1237841, XrefRangeEnd = 1237841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfigureResolveTarget(RenderTargetIdentifier target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&target);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureResolveTarget_Public_Void_RenderTargetIdentifier_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1237843, RefRangeEnd = 1237848, XrefRangeStart = 1237843, XrefRangeEnd = 1237843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfigureClear(Color clearColor, float clearDepth = 1f, uint clearStencil = 0u)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&clearColor);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &clearDepth;
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &clearStencil;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureClear_Public_Void_Color_Single_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1237850, RefRangeEnd = 1237856, XrefRangeStart = 1237848, XrefRangeEnd = 1237850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AttachmentDescriptor(GraphicsFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GraphicsFormat_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1237864, RefRangeEnd = 1237866, XrefRangeStart = 1237856, XrefRangeEnd = 1237864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(AttachmentDescriptor other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AttachmentDescriptor_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237866, XrefRangeEnd = 1237870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237870, XrefRangeEnd = 1237874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1237875, RefRangeEnd = 1237876, XrefRangeStart = 1237874, XrefRangeEnd = 1237875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator !=(AttachmentDescriptor left, AttachmentDescriptor right)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&left);
		*(AttachmentDescriptor**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &right;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_AttachmentDescriptor_AttachmentDescriptor_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static GraphicsFormat GetAdjustedFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite)
	{
		if (format == RenderTextureFormat.Depth || format == RenderTextureFormat.Shadowmap)
		{
			return SystemInfo.GetGraphicsFormat((format == RenderTextureFormat.Depth) ? DefaultFormat.DepthStencil : DefaultFormat.Shadow);
		}
		return GraphicsFormatUtility.GetGraphicsFormat(format, readWrite);
	}

	public static bool operator ==(AttachmentDescriptor left, AttachmentDescriptor right)
	{
		return left.Equals(right);
	}
}
