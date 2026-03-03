using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct RenderStateBlock
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_BlendState;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RasterState;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DepthState;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StencilState;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StencilReference;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Mask;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderStateMask_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_blendState_Public_set_Void_BlendState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_rasterState_Public_set_Void_RasterState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_depthState_Public_get_DepthState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_depthState_Public_set_Void_DepthState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_stencilState_Public_get_StencilState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_stencilState_Public_set_Void_StencilState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_stencilReference_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_stencilReference_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mask_Public_get_RenderStateMask_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_mask_Public_set_Void_RenderStateMask_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderStateBlock_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	[FieldOffset(0)]
	public BlendState m_BlendState;

	[FieldOffset(68)]
	public RasterState m_RasterState;

	[FieldOffset(84)]
	public DepthState m_DepthState;

	[FieldOffset(86)]
	public StencilState m_StencilState;

	[FieldOffset(100)]
	public int m_StencilReference;

	[FieldOffset(104)]
	public RenderStateMask m_Mask;

	public unsafe BlendState blendState
	{
		get
		{
			return m_BlendState;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1239121, RefRangeEnd = 1239122, XrefRangeStart = 1239121, XrefRangeEnd = 1239121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_blendState_Public_set_Void_BlendState_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe RasterState rasterState
	{
		get
		{
			return m_RasterState;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1239122, RefRangeEnd = 1239123, XrefRangeStart = 1239122, XrefRangeEnd = 1239122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_rasterState_Public_set_Void_RasterState_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe DepthState depthState
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1239123, RefRangeEnd = 1239124, XrefRangeStart = 1239123, XrefRangeEnd = 1239123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_depthState_Public_get_DepthState_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(DepthState*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1239124, RefRangeEnd = 1239126, XrefRangeStart = 1239124, XrefRangeEnd = 1239124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_depthState_Public_set_Void_DepthState_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe StencilState stencilState
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1239126, RefRangeEnd = 1239128, XrefRangeStart = 1239126, XrefRangeEnd = 1239126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_stencilState_Public_get_StencilState_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(StencilState*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1239128, RefRangeEnd = 1239134, XrefRangeStart = 1239128, XrefRangeEnd = 1239128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_stencilState_Public_set_Void_StencilState_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int stencilReference
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1239134, RefRangeEnd = 1239135, XrefRangeStart = 1239134, XrefRangeEnd = 1239134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_stencilReference_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 84633, RefRangeEnd = 84638, XrefRangeStart = 84633, XrefRangeEnd = 84638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_stencilReference_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe RenderStateMask mask
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1239135, RefRangeEnd = 1239141, XrefRangeStart = 1239135, XrefRangeEnd = 1239135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mask_Public_get_RenderStateMask_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RenderStateMask*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 398421, RefRangeEnd = 398429, XrefRangeStart = 398421, XrefRangeEnd = 398429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_mask_Public_set_Void_RenderStateMask_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static RenderStateBlock()
	{
		Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RenderStateBlock");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr);
		NativeFieldInfoPtr_m_BlendState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, "m_BlendState");
		NativeFieldInfoPtr_m_RasterState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, "m_RasterState");
		NativeFieldInfoPtr_m_DepthState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, "m_DepthState");
		NativeFieldInfoPtr_m_StencilState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, "m_StencilState");
		NativeFieldInfoPtr_m_StencilReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, "m_StencilReference");
		NativeFieldInfoPtr_m_Mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, "m_Mask");
		NativeMethodInfoPtr__ctor_Public_Void_RenderStateMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100668639);
		NativeMethodInfoPtr_set_blendState_Public_set_Void_BlendState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100668640);
		NativeMethodInfoPtr_set_rasterState_Public_set_Void_RasterState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100668641);
		NativeMethodInfoPtr_get_depthState_Public_get_DepthState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100668642);
		NativeMethodInfoPtr_set_depthState_Public_set_Void_DepthState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100668643);
		NativeMethodInfoPtr_get_stencilState_Public_get_StencilState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100668644);
		NativeMethodInfoPtr_set_stencilState_Public_set_Void_StencilState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100668645);
		NativeMethodInfoPtr_get_stencilReference_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100668646);
		NativeMethodInfoPtr_set_stencilReference_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100668647);
		NativeMethodInfoPtr_get_mask_Public_get_RenderStateMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100668648);
		NativeMethodInfoPtr_set_mask_Public_set_Void_RenderStateMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100668649);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderStateBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100668650);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100668651);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100668652);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1239115, RefRangeEnd = 1239121, XrefRangeStart = 1239102, XrefRangeEnd = 1239115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderStateBlock(RenderStateMask mask)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mask);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_RenderStateMask_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1239147, RefRangeEnd = 1239148, XrefRangeStart = 1239141, XrefRangeEnd = 1239147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(RenderStateBlock other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderStateBlock_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239148, XrefRangeEnd = 1239152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239152, XrefRangeEnd = 1239162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static bool operator ==(RenderStateBlock left, RenderStateBlock right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(RenderStateBlock left, RenderStateBlock right)
	{
		return !left.Equals(right);
	}
}
