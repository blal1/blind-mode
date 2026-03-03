using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering.RenderGraphModule;

public class IBaseRenderGraphBuilder : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_UseTexture_Public_Abstract_Virtual_New_Void_byref_TextureHandle_AccessFlags_0;

	private static readonly IntPtr NativeMethodInfoPtr_UseGlobalTexture_Public_Abstract_Virtual_New_Void_Int32_AccessFlags_0;

	private static readonly IntPtr NativeMethodInfoPtr_UseAllGlobalTextures_Public_Abstract_Virtual_New_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetGlobalTextureAfterPass_Public_Abstract_Virtual_New_Void_byref_TextureHandle_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_UseBuffer_Public_Abstract_Virtual_New_BufferHandle_byref_BufferHandle_AccessFlags_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateTransientTexture_Public_Abstract_Virtual_New_TextureHandle_byref_TextureDesc_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateTransientTexture_Public_Abstract_Virtual_New_TextureHandle_byref_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateTransientBuffer_Public_Abstract_Virtual_New_BufferHandle_byref_BufferDesc_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateTransientBuffer_Public_Abstract_Virtual_New_BufferHandle_byref_BufferHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_UseRendererList_Public_Abstract_Virtual_New_Void_byref_RendererListHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_EnableAsyncCompute_Public_Abstract_Virtual_New_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_AllowPassCulling_Public_Abstract_Virtual_New_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_AllowGlobalStateModification_Public_Abstract_Virtual_New_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_EnableFoveatedRasterization_Public_Abstract_Virtual_New_Void_Boolean_0;

	static IBaseRenderGraphBuilder()
	{
		Il2CppClassPointerStore<IBaseRenderGraphBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule", "IBaseRenderGraphBuilder");
		NativeMethodInfoPtr_UseTexture_Public_Abstract_Virtual_New_Void_byref_TextureHandle_AccessFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBaseRenderGraphBuilder>.NativeClassPtr, 100667095);
		NativeMethodInfoPtr_UseGlobalTexture_Public_Abstract_Virtual_New_Void_Int32_AccessFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBaseRenderGraphBuilder>.NativeClassPtr, 100667096);
		NativeMethodInfoPtr_UseAllGlobalTextures_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBaseRenderGraphBuilder>.NativeClassPtr, 100667097);
		NativeMethodInfoPtr_SetGlobalTextureAfterPass_Public_Abstract_Virtual_New_Void_byref_TextureHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBaseRenderGraphBuilder>.NativeClassPtr, 100667098);
		NativeMethodInfoPtr_UseBuffer_Public_Abstract_Virtual_New_BufferHandle_byref_BufferHandle_AccessFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBaseRenderGraphBuilder>.NativeClassPtr, 100667099);
		NativeMethodInfoPtr_CreateTransientTexture_Public_Abstract_Virtual_New_TextureHandle_byref_TextureDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBaseRenderGraphBuilder>.NativeClassPtr, 100667100);
		NativeMethodInfoPtr_CreateTransientTexture_Public_Abstract_Virtual_New_TextureHandle_byref_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBaseRenderGraphBuilder>.NativeClassPtr, 100667101);
		NativeMethodInfoPtr_CreateTransientBuffer_Public_Abstract_Virtual_New_BufferHandle_byref_BufferDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBaseRenderGraphBuilder>.NativeClassPtr, 100667102);
		NativeMethodInfoPtr_CreateTransientBuffer_Public_Abstract_Virtual_New_BufferHandle_byref_BufferHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBaseRenderGraphBuilder>.NativeClassPtr, 100667103);
		NativeMethodInfoPtr_UseRendererList_Public_Abstract_Virtual_New_Void_byref_RendererListHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBaseRenderGraphBuilder>.NativeClassPtr, 100667104);
		NativeMethodInfoPtr_EnableAsyncCompute_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBaseRenderGraphBuilder>.NativeClassPtr, 100667105);
		NativeMethodInfoPtr_AllowPassCulling_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBaseRenderGraphBuilder>.NativeClassPtr, 100667106);
		NativeMethodInfoPtr_AllowGlobalStateModification_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBaseRenderGraphBuilder>.NativeClassPtr, 100667107);
		NativeMethodInfoPtr_EnableFoveatedRasterization_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBaseRenderGraphBuilder>.NativeClassPtr, 100667108);
	}

	[CallerCount(0)]
	public unsafe virtual void UseTexture([In] ref TextureHandle input, AccessFlags flags = AccessFlags.Read)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref input);
		*(AccessFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &flags;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_UseTexture_Public_Abstract_Virtual_New_Void_byref_TextureHandle_AccessFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void UseGlobalTexture(int propertyId, AccessFlags flags = AccessFlags.Read)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&propertyId);
		*(AccessFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &flags;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_UseGlobalTexture_Public_Abstract_Virtual_New_Void_Int32_AccessFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void UseAllGlobalTextures(bool enable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&enable);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_UseAllGlobalTextures_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void SetGlobalTextureAfterPass([In] ref TextureHandle input, int propertyId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref input);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &propertyId;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetGlobalTextureAfterPass_Public_Abstract_Virtual_New_Void_byref_TextureHandle_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual BufferHandle UseBuffer([In] ref BufferHandle input, AccessFlags flags = AccessFlags.Read)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref input);
		*(AccessFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &flags;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_UseBuffer_Public_Abstract_Virtual_New_BufferHandle_byref_BufferHandle_AccessFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(BufferHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual TextureHandle CreateTransientTexture([In] ref TextureDesc desc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)desc);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateTransientTexture_Public_Abstract_Virtual_New_TextureHandle_byref_TextureDesc_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual TextureHandle CreateTransientTexture([In] ref TextureHandle texture)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref texture);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateTransientTexture_Public_Abstract_Virtual_New_TextureHandle_byref_TextureHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual BufferHandle CreateTransientBuffer([In] ref BufferDesc desc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)desc);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateTransientBuffer_Public_Abstract_Virtual_New_BufferHandle_byref_BufferDesc_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(BufferHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual BufferHandle CreateTransientBuffer([In] ref BufferHandle computebuffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref computebuffer);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateTransientBuffer_Public_Abstract_Virtual_New_BufferHandle_byref_BufferHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(BufferHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void UseRendererList([In] ref RendererListHandle input)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref input);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_UseRendererList_Public_Abstract_Virtual_New_Void_byref_RendererListHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void EnableAsyncCompute(bool value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_EnableAsyncCompute_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void AllowPassCulling(bool value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AllowPassCulling_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void AllowGlobalStateModification(bool value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AllowGlobalStateModification_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void EnableFoveatedRasterization(bool value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_EnableFoveatedRasterization_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IBaseRenderGraphBuilder(IntPtr pointer)
		: base(pointer)
	{
	}
}
