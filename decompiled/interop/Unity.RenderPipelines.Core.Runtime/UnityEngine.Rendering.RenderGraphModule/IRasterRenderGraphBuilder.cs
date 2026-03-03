using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering.RenderGraphModule;

public class IRasterRenderGraphBuilder : Il2CppObjectBase
{
	private sealed class MethodInfoStoreGeneric_SetRenderFunc_Public_Abstract_Virtual_New_Void_BaseRenderFunc_2_PassData_RasterGraphContext_0<PassData>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SetRenderFunc_Public_Abstract_Virtual_New_Void_BaseRenderFunc_2_PassData_RasterGraphContext_0, Il2CppClassPointerStore<IRasterRenderGraphBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PassData>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRenderAttachment_Public_Virtual_New_Void_TextureHandle_Int32_AccessFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRenderAttachment_Public_Abstract_Virtual_New_Void_TextureHandle_Int32_AccessFlags_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInputAttachment_Public_Virtual_New_Void_TextureHandle_Int32_AccessFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInputAttachment_Public_Abstract_Virtual_New_Void_TextureHandle_Int32_AccessFlags_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRenderAttachmentDepth_Public_Virtual_New_Void_TextureHandle_AccessFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRenderAttachmentDepth_Public_Abstract_Virtual_New_Void_TextureHandle_AccessFlags_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRandomAccessAttachment_Public_Abstract_Virtual_New_TextureHandle_TextureHandle_Int32_AccessFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseBufferRandomAccess_Public_Abstract_Virtual_New_BufferHandle_BufferHandle_Int32_AccessFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseBufferRandomAccess_Public_Abstract_Virtual_New_BufferHandle_BufferHandle_Int32_Boolean_AccessFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRenderFunc_Public_Abstract_Virtual_New_Void_BaseRenderFunc_2_PassData_RasterGraphContext_0;

	static IRasterRenderGraphBuilder()
	{
		Il2CppClassPointerStore<IRasterRenderGraphBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule", "IRasterRenderGraphBuilder");
		NativeMethodInfoPtr_SetRenderAttachment_Public_Virtual_New_Void_TextureHandle_Int32_AccessFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRasterRenderGraphBuilder>.NativeClassPtr, 100667111);
		NativeMethodInfoPtr_SetRenderAttachment_Public_Abstract_Virtual_New_Void_TextureHandle_Int32_AccessFlags_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRasterRenderGraphBuilder>.NativeClassPtr, 100667112);
		NativeMethodInfoPtr_SetInputAttachment_Public_Virtual_New_Void_TextureHandle_Int32_AccessFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRasterRenderGraphBuilder>.NativeClassPtr, 100667113);
		NativeMethodInfoPtr_SetInputAttachment_Public_Abstract_Virtual_New_Void_TextureHandle_Int32_AccessFlags_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRasterRenderGraphBuilder>.NativeClassPtr, 100667114);
		NativeMethodInfoPtr_SetRenderAttachmentDepth_Public_Virtual_New_Void_TextureHandle_AccessFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRasterRenderGraphBuilder>.NativeClassPtr, 100667115);
		NativeMethodInfoPtr_SetRenderAttachmentDepth_Public_Abstract_Virtual_New_Void_TextureHandle_AccessFlags_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRasterRenderGraphBuilder>.NativeClassPtr, 100667116);
		NativeMethodInfoPtr_SetRandomAccessAttachment_Public_Abstract_Virtual_New_TextureHandle_TextureHandle_Int32_AccessFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRasterRenderGraphBuilder>.NativeClassPtr, 100667117);
		NativeMethodInfoPtr_UseBufferRandomAccess_Public_Abstract_Virtual_New_BufferHandle_BufferHandle_Int32_AccessFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRasterRenderGraphBuilder>.NativeClassPtr, 100667118);
		NativeMethodInfoPtr_UseBufferRandomAccess_Public_Abstract_Virtual_New_BufferHandle_BufferHandle_Int32_Boolean_AccessFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRasterRenderGraphBuilder>.NativeClassPtr, 100667119);
		NativeMethodInfoPtr_SetRenderFunc_Public_Abstract_Virtual_New_Void_BaseRenderFunc_2_PassData_RasterGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRasterRenderGraphBuilder>.NativeClassPtr, 100667120);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1055631, XrefRangeEnd = 1055634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetRenderAttachment(TextureHandle tex, int index, AccessFlags flags = AccessFlags.Write)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&tex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(AccessFlags**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetRenderAttachment_Public_Virtual_New_Void_TextureHandle_Int32_AccessFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void SetRenderAttachment(TextureHandle tex, int index, AccessFlags flags, int mipLevel, int depthSlice)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&tex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(AccessFlags**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipLevel;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthSlice;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetRenderAttachment_Public_Abstract_Virtual_New_Void_TextureHandle_Int32_AccessFlags_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1055634, XrefRangeEnd = 1055637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetInputAttachment(TextureHandle tex, int index, AccessFlags flags = AccessFlags.Read)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&tex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(AccessFlags**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetInputAttachment_Public_Virtual_New_Void_TextureHandle_Int32_AccessFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void SetInputAttachment(TextureHandle tex, int index, AccessFlags flags, int mipLevel, int depthSlice)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&tex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(AccessFlags**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipLevel;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthSlice;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetInputAttachment_Public_Abstract_Virtual_New_Void_TextureHandle_Int32_AccessFlags_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1055637, XrefRangeEnd = 1055640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetRenderAttachmentDepth(TextureHandle tex, AccessFlags flags = AccessFlags.Write)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&tex);
		*(AccessFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetRenderAttachmentDepth_Public_Virtual_New_Void_TextureHandle_AccessFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void SetRenderAttachmentDepth(TextureHandle tex, AccessFlags flags, int mipLevel, int depthSlice)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&tex);
		*(AccessFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipLevel;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthSlice;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetRenderAttachmentDepth_Public_Abstract_Virtual_New_Void_TextureHandle_AccessFlags_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual TextureHandle SetRandomAccessAttachment(TextureHandle tex, int index, AccessFlags flags = AccessFlags.ReadWrite)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&tex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(AccessFlags**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetRandomAccessAttachment_Public_Abstract_Virtual_New_TextureHandle_TextureHandle_Int32_AccessFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual BufferHandle UseBufferRandomAccess(BufferHandle tex, int index, AccessFlags flags = AccessFlags.Read)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&tex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(AccessFlags**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_UseBufferRandomAccess_Public_Abstract_Virtual_New_BufferHandle_BufferHandle_Int32_AccessFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(BufferHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual BufferHandle UseBufferRandomAccess(BufferHandle tex, int index, bool preserveCounterValue, AccessFlags flags = AccessFlags.Read)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&tex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &preserveCounterValue;
		*(AccessFlags**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_UseBufferRandomAccess_Public_Abstract_Virtual_New_BufferHandle_BufferHandle_Int32_Boolean_AccessFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(BufferHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void SetRenderFunc<PassData>(BaseRenderFunc<PassData, RasterGraphContext> renderFunc) where PassData : class, new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderFunc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), MethodInfoStoreGeneric_SetRenderFunc_Public_Abstract_Virtual_New_Void_BaseRenderFunc_2_PassData_RasterGraphContext_0<PassData>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IRasterRenderGraphBuilder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
