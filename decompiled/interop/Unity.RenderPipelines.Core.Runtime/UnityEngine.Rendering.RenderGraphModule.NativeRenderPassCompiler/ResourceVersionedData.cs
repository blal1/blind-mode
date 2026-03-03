using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[StructLayout(LayoutKind.Explicit)]
public struct ResourceVersionedData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_written;

	private static readonly System.IntPtr NativeFieldInfoPtr_writePassId;

	private static readonly System.IntPtr NativeFieldInfoPtr_numReaders;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWritingPass_Public_Void_CompilerContextData_ResourceHandle_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterReadingPass_Public_Void_CompilerContextData_ResourceHandle_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveReadingPass_Public_Void_CompilerContextData_ResourceHandle_Int32_0;

	[FieldOffset(0)]
	[MarshalAs(UnmanagedType.U1)]
	public bool written;

	[FieldOffset(4)]
	public int writePassId;

	[FieldOffset(8)]
	public int numReaders;

	static ResourceVersionedData()
	{
		Il2CppClassPointerStore<ResourceVersionedData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler", "ResourceVersionedData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceVersionedData>.NativeClassPtr);
		NativeFieldInfoPtr_written = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceVersionedData>.NativeClassPtr, "written");
		NativeFieldInfoPtr_writePassId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceVersionedData>.NativeClassPtr, "writePassId");
		NativeFieldInfoPtr_numReaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceVersionedData>.NativeClassPtr, "numReaders");
		NativeMethodInfoPtr_SetWritingPass_Public_Void_CompilerContextData_ResourceHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceVersionedData>.NativeClassPtr, 100667899);
		NativeMethodInfoPtr_RegisterReadingPass_Public_Void_CompilerContextData_ResourceHandle_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceVersionedData>.NativeClassPtr, 100667900);
		NativeMethodInfoPtr_RemoveReadingPass_Public_Void_CompilerContextData_ResourceHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceVersionedData>.NativeClassPtr, 100667901);
	}

	[CallerCount(0)]
	public unsafe void SetWritingPass(CompilerContextData ctx, ResourceHandle h, int passId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(ResourceHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &passId;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWritingPass_Public_Void_CompilerContextData_ResourceHandle_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063805, XrefRangeEnd = 1063815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterReadingPass(CompilerContextData ctx, ResourceHandle h, int passId, int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(ResourceHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &passId;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterReadingPass_Public_Void_CompilerContextData_ResourceHandle_Int32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063815, XrefRangeEnd = 1063841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveReadingPass(CompilerContextData ctx, ResourceHandle h, int passId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(ResourceHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &passId;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveReadingPass_Public_Void_CompilerContextData_ResourceHandle_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ResourceVersionedData>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
