using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering.RenderGraphModule;

public class BufferPool : RenderGraphResourcePool<GraphicsBuffer>
{
	private static readonly IntPtr NativeMethodInfoPtr_ReleaseInternalResource_Protected_Virtual_Void_GraphicsBuffer_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetResourceName_Protected_Virtual_String_byref_GraphicsBuffer_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetResourceSize_Protected_Virtual_Int64_byref_GraphicsBuffer_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetResourceTypeName_Protected_Virtual_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSortIndex_Protected_Virtual_Int32_GraphicsBuffer_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static BufferPool()
	{
		Il2CppClassPointerStore<BufferPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule", "BufferPool");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BufferPool>.NativeClassPtr);
		NativeMethodInfoPtr_ReleaseInternalResource_Protected_Virtual_Void_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferPool>.NativeClassPtr, 100667537);
		NativeMethodInfoPtr_GetResourceName_Protected_Virtual_String_byref_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferPool>.NativeClassPtr, 100667538);
		NativeMethodInfoPtr_GetResourceSize_Protected_Virtual_Int64_byref_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferPool>.NativeClassPtr, 100667539);
		NativeMethodInfoPtr_GetResourceTypeName_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferPool>.NativeClassPtr, 100667540);
		NativeMethodInfoPtr_GetSortIndex_Protected_Virtual_Int32_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferPool>.NativeClassPtr, 100667541);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferPool>.NativeClassPtr, 100667542);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059358, XrefRangeEnd = 1059360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void ReleaseInternalResource(GraphicsBuffer res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)res);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ReleaseInternalResource_Protected_Virtual_Void_GraphicsBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059360, XrefRangeEnd = 1059362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetResourceName([In] ref GraphicsBuffer res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)res);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetResourceName_Protected_Virtual_String_byref_GraphicsBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr4 = intPtr;
		res = ((intPtr4 == (IntPtr)0) ? null : new GraphicsBuffer(intPtr4));
		return IL2CPP.Il2CppStringToManaged(intPtr3);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059362, XrefRangeEnd = 1059364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override long GetResourceSize([In] ref GraphicsBuffer res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)res);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetResourceSize_Protected_Virtual_Int64_byref_GraphicsBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr4 = intPtr;
		res = ((intPtr4 == (IntPtr)0) ? null : new GraphicsBuffer(intPtr4));
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059364, XrefRangeEnd = 1059366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetResourceTypeName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetResourceTypeName_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059366, XrefRangeEnd = 1059367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetSortIndex(GraphicsBuffer res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)res);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetSortIndex_Protected_Virtual_Int32_GraphicsBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059367, XrefRangeEnd = 1059373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BufferPool()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BufferPool>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public BufferPool(IntPtr pointer)
		: base(pointer)
	{
	}
}
