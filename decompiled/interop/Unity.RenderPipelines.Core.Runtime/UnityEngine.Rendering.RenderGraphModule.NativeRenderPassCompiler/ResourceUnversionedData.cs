using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[StructLayout(LayoutKind.Explicit)]
public struct ResourceUnversionedData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_isImported;

	private static readonly System.IntPtr NativeFieldInfoPtr_isShared;

	private static readonly System.IntPtr NativeFieldInfoPtr_tag;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastUsePassID;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastWritePassID;

	private static readonly System.IntPtr NativeFieldInfoPtr_firstUsePassID;

	private static readonly System.IntPtr NativeFieldInfoPtr_memoryLess;

	private static readonly System.IntPtr NativeFieldInfoPtr_width;

	private static readonly System.IntPtr NativeFieldInfoPtr_height;

	private static readonly System.IntPtr NativeFieldInfoPtr_volumeDepth;

	private static readonly System.IntPtr NativeFieldInfoPtr_msaaSamples;

	private static readonly System.IntPtr NativeFieldInfoPtr_latestVersionNumber;

	private static readonly System.IntPtr NativeFieldInfoPtr_clear;

	private static readonly System.IntPtr NativeFieldInfoPtr_discard;

	private static readonly System.IntPtr NativeFieldInfoPtr_bindMS;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetName_Public_String_CompilerContextData_ResourceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_IRenderGraphResource_byref_RenderTargetInfo_byref_TextureDesc_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_IRenderGraphResource_byref_BufferDesc_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_IRenderGraphResource_byref_RayTracingAccelerationStructureDesc_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeNullResource_Public_Void_0;

	[FieldOffset(0)]
	[MarshalAs(UnmanagedType.U1)]
	public readonly bool isImported;

	[FieldOffset(1)]
	[MarshalAs(UnmanagedType.U1)]
	public bool isShared;

	[FieldOffset(4)]
	public int tag;

	[FieldOffset(8)]
	public int lastUsePassID;

	[FieldOffset(12)]
	public int lastWritePassID;

	[FieldOffset(16)]
	public int firstUsePassID;

	[FieldOffset(20)]
	[MarshalAs(UnmanagedType.U1)]
	public bool memoryLess;

	[FieldOffset(24)]
	public readonly int width;

	[FieldOffset(28)]
	public readonly int height;

	[FieldOffset(32)]
	public readonly int volumeDepth;

	[FieldOffset(36)]
	public readonly int msaaSamples;

	[FieldOffset(40)]
	public int latestVersionNumber;

	[FieldOffset(44)]
	[MarshalAs(UnmanagedType.U1)]
	public readonly bool clear;

	[FieldOffset(45)]
	[MarshalAs(UnmanagedType.U1)]
	public readonly bool discard;

	[FieldOffset(46)]
	[MarshalAs(UnmanagedType.U1)]
	public readonly bool bindMS;

	static ResourceUnversionedData()
	{
		Il2CppClassPointerStore<ResourceUnversionedData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler", "ResourceUnversionedData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceUnversionedData>.NativeClassPtr);
		NativeFieldInfoPtr_isImported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceUnversionedData>.NativeClassPtr, "isImported");
		NativeFieldInfoPtr_isShared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceUnversionedData>.NativeClassPtr, "isShared");
		NativeFieldInfoPtr_tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceUnversionedData>.NativeClassPtr, "tag");
		NativeFieldInfoPtr_lastUsePassID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceUnversionedData>.NativeClassPtr, "lastUsePassID");
		NativeFieldInfoPtr_lastWritePassID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceUnversionedData>.NativeClassPtr, "lastWritePassID");
		NativeFieldInfoPtr_firstUsePassID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceUnversionedData>.NativeClassPtr, "firstUsePassID");
		NativeFieldInfoPtr_memoryLess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceUnversionedData>.NativeClassPtr, "memoryLess");
		NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceUnversionedData>.NativeClassPtr, "width");
		NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceUnversionedData>.NativeClassPtr, "height");
		NativeFieldInfoPtr_volumeDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceUnversionedData>.NativeClassPtr, "volumeDepth");
		NativeFieldInfoPtr_msaaSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceUnversionedData>.NativeClassPtr, "msaaSamples");
		NativeFieldInfoPtr_latestVersionNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceUnversionedData>.NativeClassPtr, "latestVersionNumber");
		NativeFieldInfoPtr_clear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceUnversionedData>.NativeClassPtr, "clear");
		NativeFieldInfoPtr_discard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceUnversionedData>.NativeClassPtr, "discard");
		NativeFieldInfoPtr_bindMS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceUnversionedData>.NativeClassPtr, "bindMS");
		NativeMethodInfoPtr_GetName_Public_String_CompilerContextData_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceUnversionedData>.NativeClassPtr, 100667894);
		NativeMethodInfoPtr__ctor_Public_Void_IRenderGraphResource_byref_RenderTargetInfo_byref_TextureDesc_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceUnversionedData>.NativeClassPtr, 100667895);
		NativeMethodInfoPtr__ctor_Public_Void_IRenderGraphResource_byref_BufferDesc_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceUnversionedData>.NativeClassPtr, 100667896);
		NativeMethodInfoPtr__ctor_Public_Void_IRenderGraphResource_byref_RayTracingAccelerationStructureDesc_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceUnversionedData>.NativeClassPtr, 100667897);
		NativeMethodInfoPtr_InitializeNullResource_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceUnversionedData>.NativeClassPtr, 100667898);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063804, XrefRangeEnd = 1063805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetName(CompilerContextData ctx, ResourceHandle h)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(ResourceHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetName_Public_String_CompilerContextData_ResourceHandle_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	public unsafe ResourceUnversionedData(IRenderGraphResource rll, ref RenderTargetInfo info, ref TextureDesc desc, bool isResourceShared)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rll);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref info);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)desc);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isResourceShared;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IRenderGraphResource_byref_RenderTargetInfo_byref_TextureDesc_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe ResourceUnversionedData(IRenderGraphResource rll, ref BufferDesc _, bool isResourceShared)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rll);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)_);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isResourceShared;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IRenderGraphResource_byref_BufferDesc_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe ResourceUnversionedData(IRenderGraphResource rll, ref RayTracingAccelerationStructureDesc _, bool isResourceShared)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rll);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)_);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isResourceShared;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IRenderGraphResource_byref_RayTracingAccelerationStructureDesc_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void InitializeNullResource()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeNullResource_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ResourceUnversionedData>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
