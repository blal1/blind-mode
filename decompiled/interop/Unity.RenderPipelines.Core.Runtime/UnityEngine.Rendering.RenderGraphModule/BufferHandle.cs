using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.RenderGraphModule;

[StructLayout(LayoutKind.Explicit)]
public struct BufferHandle
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_NullHandle;

	private static readonly System.IntPtr NativeFieldInfoPtr_handle;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_nullHandle_Public_Static_get_BufferHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_byref_ResourceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_GraphicsBuffer_BufferHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

	[FieldOffset(0)]
	public ResourceHandle handle;

	public unsafe static BufferHandle s_NullHandle
	{
		get
		{
			Unsafe.SkipInit(out BufferHandle result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_NullHandle, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_NullHandle, (void*)(&value));
		}
	}

	public unsafe static BufferHandle nullHandle
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059262, XrefRangeEnd = 1059266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_nullHandle_Public_Static_get_BufferHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(BufferHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static BufferHandle()
	{
		Il2CppClassPointerStore<BufferHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule", "BufferHandle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BufferHandle>.NativeClassPtr);
		NativeFieldInfoPtr_s_NullHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferHandle>.NativeClassPtr, "s_NullHandle");
		NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferHandle>.NativeClassPtr, "handle");
		NativeMethodInfoPtr_get_nullHandle_Public_Static_get_BufferHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferHandle>.NativeClassPtr, 100667520);
		NativeMethodInfoPtr__ctor_Internal_Void_byref_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferHandle>.NativeClassPtr, 100667521);
		NativeMethodInfoPtr__ctor_Internal_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferHandle>.NativeClassPtr, 100667522);
		NativeMethodInfoPtr_op_Implicit_Public_Static_GraphicsBuffer_BufferHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferHandle>.NativeClassPtr, 100667523);
		NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferHandle>.NativeClassPtr, 100667524);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1000096, RefRangeEnd = 1000102, XrefRangeStart = 1000096, XrefRangeEnd = 1000102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BufferHandle([In] ref ResourceHandle h)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref h);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_byref_ResourceHandle_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059266, XrefRangeEnd = 1059267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BufferHandle(int handle, bool shared = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&handle);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shared;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Int32_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 1059296, RefRangeEnd = 1059313, XrefRangeStart = 1059267, XrefRangeEnd = 1059296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator GraphicsBuffer(BufferHandle buffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&buffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_GraphicsBuffer_BufferHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1059317, RefRangeEnd = 1059321, XrefRangeStart = 1059313, XrefRangeEnd = 1059317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsValid()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValid_Public_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BufferHandle>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
