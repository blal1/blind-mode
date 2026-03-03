using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering.RenderGraphModule;

public class TexturePool : RenderGraphResourcePool<RTHandle>
{
	private static readonly IntPtr NativeMethodInfoPtr_ReleaseInternalResource_Protected_Virtual_Void_RTHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetResourceName_Protected_Virtual_String_byref_RTHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetResourceSize_Protected_Virtual_Int64_byref_RTHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetResourceTypeName_Protected_Virtual_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSortIndex_Protected_Virtual_Int32_RTHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static TexturePool()
	{
		Il2CppClassPointerStore<TexturePool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule", "TexturePool");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TexturePool>.NativeClassPtr);
		NativeMethodInfoPtr_ReleaseInternalResource_Protected_Virtual_Void_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TexturePool>.NativeClassPtr, 100667750);
		NativeMethodInfoPtr_GetResourceName_Protected_Virtual_String_byref_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TexturePool>.NativeClassPtr, 100667751);
		NativeMethodInfoPtr_GetResourceSize_Protected_Virtual_Int64_byref_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TexturePool>.NativeClassPtr, 100667752);
		NativeMethodInfoPtr_GetResourceTypeName_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TexturePool>.NativeClassPtr, 100667753);
		NativeMethodInfoPtr_GetSortIndex_Protected_Virtual_Int32_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TexturePool>.NativeClassPtr, 100667754);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TexturePool>.NativeClassPtr, 100667755);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061113, XrefRangeEnd = 1061115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void ReleaseInternalResource(RTHandle res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)res);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ReleaseInternalResource_Protected_Virtual_Void_RTHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061115, XrefRangeEnd = 1061117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetResourceName([In] ref RTHandle res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)res);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetResourceName_Protected_Virtual_String_byref_RTHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr4 = intPtr;
		res = ((intPtr4 == (IntPtr)0) ? null : new RTHandle(intPtr4));
		return IL2CPP.Il2CppStringToManaged(intPtr3);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061117, XrefRangeEnd = 1061119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override long GetResourceSize([In] ref RTHandle res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)res);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetResourceSize_Protected_Virtual_Int64_byref_RTHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr4 = intPtr;
		res = ((intPtr4 == (IntPtr)0) ? null : new RTHandle(intPtr4));
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061119, XrefRangeEnd = 1061121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061121, XrefRangeEnd = 1061123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetSortIndex(RTHandle res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)res);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetSortIndex_Protected_Virtual_Int32_RTHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061123, XrefRangeEnd = 1061129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TexturePool()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TexturePool>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TexturePool(IntPtr pointer)
		: base(pointer)
	{
	}
}
