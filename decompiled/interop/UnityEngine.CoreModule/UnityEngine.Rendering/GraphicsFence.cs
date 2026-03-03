using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct GraphicsFence
{
	private delegate bool HasFencePassed_InternalDelegate(System.IntPtr fencePtr);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Version;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FenceType;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitPostAllocation_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsFencePending_Internal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Validate_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPlatformNotSupportedVersion_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVersionNumber_Private_Static_Int32_IntPtr_0;

	[FieldOffset(0)]
	public System.IntPtr m_Ptr;

	[FieldOffset(8)]
	public int m_Version;

	[FieldOffset(12)]
	public GraphicsFenceType m_FenceType;

	private static readonly HasFencePassed_InternalDelegate HasFencePassed_InternalDelegateField;

	public bool passed
	{
		get
		{
			Validate();
			if (!SystemInfo.supportsGraphicsFence)
			{
				throw new Il2CppSystem.NotSupportedException("Cannot determine if this GraphicsFence has passed as this platform has not implemented GraphicsFences.");
			}
			if (m_FenceType == GraphicsFenceType.AsyncQueueSynchronisation && !SystemInfo.supportsAsyncCompute)
			{
				throw new Il2CppSystem.NotSupportedException("Cannot determine if this AsyncQueueSynchronisation GraphicsFence has passed as this platform does not support async compute.");
			}
			if (!IsFencePending())
			{
				return true;
			}
			return HasFencePassed_Internal(m_Ptr);
		}
	}

	static GraphicsFence()
	{
		Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "GraphicsFence");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr);
		NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, "m_Ptr");
		NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, "m_Version");
		NativeFieldInfoPtr_m_FenceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, "m_FenceType");
		NativeMethodInfoPtr_InitPostAllocation_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, 100667707);
		NativeMethodInfoPtr_IsFencePending_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, 100667708);
		NativeMethodInfoPtr_Validate_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, 100667709);
		NativeMethodInfoPtr_GetPlatformNotSupportedVersion_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, 100667710);
		NativeMethodInfoPtr_GetVersionNumber_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, 100667711);
		HasFencePassed_InternalDelegateField = IL2CPP.ResolveICall<HasFencePassed_InternalDelegate>("UnityEngine.Rendering.GraphicsFence::HasFencePassed_Internal");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232230, XrefRangeEnd = 1232232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitPostAllocation()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitPostAllocation_Internal_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232232, XrefRangeEnd = 1232234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsFencePending()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsFencePending_Internal_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1232235, RefRangeEnd = 1232236, XrefRangeStart = 1232234, XrefRangeEnd = 1232235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Validate()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Validate_Internal_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe int GetPlatformNotSupportedVersion()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPlatformNotSupportedVersion_Private_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232236, XrefRangeEnd = 1232238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetVersionNumber(System.IntPtr fencePtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&fencePtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVersionNumber_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static SynchronisationStageFlags TranslateSynchronizationStageToFlags(SynchronisationStage s)
	{
		return (s == SynchronisationStage.VertexProcessing) ? SynchronisationStageFlags.VertexProcessing : SynchronisationStageFlags.PixelProcessing;
	}

	public static bool HasFencePassed_Internal(System.IntPtr fencePtr)
	{
		return HasFencePassed_InternalDelegateField(fencePtr);
	}
}
