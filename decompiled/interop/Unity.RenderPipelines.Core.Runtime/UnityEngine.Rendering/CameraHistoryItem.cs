using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering;

public class CameraHistoryItem : ContextItem
{
	private static readonly IntPtr NativeFieldInfoPtr_m_owner;

	private static readonly IntPtr NativeFieldInfoPtr_m_TypeId;

	private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Public_Virtual_New_Void_BufferedRTHandleSystem_UInt32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_storage_Protected_get_BufferedRTHandleSystem_0;

	private static readonly IntPtr NativeMethodInfoPtr_MakeId_Protected_Int32_UInt32_0;

	private static readonly IntPtr NativeMethodInfoPtr_AllocHistoryFrameRT_Protected_RTHandle_Int32_Int32_byref_RenderTextureDescriptor_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_ReleaseHistoryFrameRT_Protected_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetPreviousFrameRT_Protected_RTHandle_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetCurrentFrameRT_Protected_RTHandle_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	public unsafe BufferedRTHandleSystem m_owner
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_owner);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BufferedRTHandleSystem>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_owner)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe uint m_TypeId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TypeId);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TypeId)) = value;
		}
	}

	public unsafe BufferedRTHandleSystem storage
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_storage_Protected_get_BufferedRTHandleSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<BufferedRTHandleSystem>(intPtr2) : null;
		}
	}

	static CameraHistoryItem()
	{
		Il2CppClassPointerStore<CameraHistoryItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "CameraHistoryItem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraHistoryItem>.NativeClassPtr);
		NativeFieldInfoPtr_m_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraHistoryItem>.NativeClassPtr, "m_owner");
		NativeFieldInfoPtr_m_TypeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraHistoryItem>.NativeClassPtr, "m_TypeId");
		NativeMethodInfoPtr_OnCreate_Public_Virtual_New_Void_BufferedRTHandleSystem_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraHistoryItem>.NativeClassPtr, 100663466);
		NativeMethodInfoPtr_get_storage_Protected_get_BufferedRTHandleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraHistoryItem>.NativeClassPtr, 100663467);
		NativeMethodInfoPtr_MakeId_Protected_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraHistoryItem>.NativeClassPtr, 100663468);
		NativeMethodInfoPtr_AllocHistoryFrameRT_Protected_RTHandle_Int32_Int32_byref_RenderTextureDescriptor_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraHistoryItem>.NativeClassPtr, 100663469);
		NativeMethodInfoPtr_ReleaseHistoryFrameRT_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraHistoryItem>.NativeClassPtr, 100663470);
		NativeMethodInfoPtr_GetPreviousFrameRT_Protected_RTHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraHistoryItem>.NativeClassPtr, 100663471);
		NativeMethodInfoPtr_GetCurrentFrameRT_Protected_RTHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraHistoryItem>.NativeClassPtr, 100663472);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraHistoryItem>.NativeClassPtr, 100663473);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 762714, RefRangeEnd = 762719, XrefRangeStart = 762714, XrefRangeEnd = 762719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnCreate(BufferedRTHandleSystem owner, uint typeId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)owner);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &typeId;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnCreate_Public_Virtual_New_Void_BufferedRTHandleSystem_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1026287, RefRangeEnd = 1026294, XrefRangeStart = 1026287, XrefRangeEnd = 1026287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int MakeId(uint index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeId_Protected_Int32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 1026297, RefRangeEnd = 1026310, XrefRangeStart = 1026294, XrefRangeEnd = 1026297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RTHandle AllocHistoryFrameRT(int id, int count, ref RenderTextureDescriptor desc, string name = "")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = (nint)(&id);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &count;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref desc);
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AllocHistoryFrameRT_Protected_RTHandle_Int32_Int32_byref_RenderTextureDescriptor_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1026312, RefRangeEnd = 1026316, XrefRangeStart = 1026310, XrefRangeEnd = 1026312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReleaseHistoryFrameRT(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReleaseHistoryFrameRT_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1026318, RefRangeEnd = 1026320, XrefRangeStart = 1026316, XrefRangeEnd = 1026318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RTHandle GetPreviousFrameRT(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPreviousFrameRT_Protected_RTHandle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 1026322, RefRangeEnd = 1026332, XrefRangeStart = 1026320, XrefRangeEnd = 1026322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RTHandle GetCurrentFrameRT(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentFrameRT_Protected_RTHandle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1026333, RefRangeEnd = 1026338, XrefRangeStart = 1026332, XrefRangeEnd = 1026333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CameraHistoryItem()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraHistoryItem>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public CameraHistoryItem(IntPtr pointer)
		: base(pointer)
	{
	}
}
