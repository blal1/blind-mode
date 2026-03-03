using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal;

public sealed class RawColorHistory : CameraHistoryItem
{
	private static readonly IntPtr NativeFieldInfoPtr_m_Ids;

	private static readonly IntPtr NativeFieldInfoPtr_m_Names;

	private static readonly IntPtr NativeFieldInfoPtr_m_Descriptor;

	private static readonly IntPtr NativeFieldInfoPtr_m_DescKey;

	private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Public_Virtual_Void_BufferedRTHandleSystem_UInt32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetCurrentTexture_Public_RTHandle_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetPreviousTexture_Public_RTHandle_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsAllocated_Private_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsDirty_Private_Boolean_byref_RenderTextureDescriptor_0;

	private static readonly IntPtr NativeMethodInfoPtr_Alloc_Private_Void_byref_RenderTextureDescriptor_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetHistoryDescriptor_Internal_RenderTextureDescriptor_byref_RenderTextureDescriptor_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Internal_Boolean_byref_RenderTextureDescriptor_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppStructArray<int> m_Ids
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ids);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ids)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStringArray m_Names
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_Names, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_Names, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RenderTextureDescriptor m_Descriptor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Descriptor);
			return *(RenderTextureDescriptor*)num;
		}
		set
		{
			*(RenderTextureDescriptor*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Descriptor)) = value;
		}
	}

	public unsafe Hash128 m_DescKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DescKey);
			return *(Hash128*)num;
		}
		set
		{
			*(Hash128*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DescKey)) = value;
		}
	}

	static RawColorHistory()
	{
		Il2CppClassPointerStore<RawColorHistory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "RawColorHistory");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RawColorHistory>.NativeClassPtr);
		NativeFieldInfoPtr_m_Ids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RawColorHistory>.NativeClassPtr, "m_Ids");
		NativeFieldInfoPtr_m_Names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RawColorHistory>.NativeClassPtr, "m_Names");
		NativeFieldInfoPtr_m_Descriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RawColorHistory>.NativeClassPtr, "m_Descriptor");
		NativeFieldInfoPtr_m_DescKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RawColorHistory>.NativeClassPtr, "m_DescKey");
		NativeMethodInfoPtr_OnCreate_Public_Virtual_Void_BufferedRTHandleSystem_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RawColorHistory>.NativeClassPtr, 100664631);
		NativeMethodInfoPtr_GetCurrentTexture_Public_RTHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RawColorHistory>.NativeClassPtr, 100664632);
		NativeMethodInfoPtr_GetPreviousTexture_Public_RTHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RawColorHistory>.NativeClassPtr, 100664633);
		NativeMethodInfoPtr_IsAllocated_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RawColorHistory>.NativeClassPtr, 100664634);
		NativeMethodInfoPtr_IsDirty_Private_Boolean_byref_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RawColorHistory>.NativeClassPtr, 100664635);
		NativeMethodInfoPtr_Alloc_Private_Void_byref_RenderTextureDescriptor_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RawColorHistory>.NativeClassPtr, 100664636);
		NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RawColorHistory>.NativeClassPtr, 100664637);
		NativeMethodInfoPtr_GetHistoryDescriptor_Internal_RenderTextureDescriptor_byref_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RawColorHistory>.NativeClassPtr, 100664638);
		NativeMethodInfoPtr_Update_Internal_Boolean_byref_RenderTextureDescriptor_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RawColorHistory>.NativeClassPtr, 100664639);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RawColorHistory>.NativeClassPtr, 100664640);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087543, XrefRangeEnd = 1087546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnCreate(BufferedRTHandleSystem owner, uint typeId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)owner);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &typeId;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnCreate_Public_Virtual_Void_BufferedRTHandleSystem_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 1087547, RefRangeEnd = 1087559, XrefRangeStart = 1087546, XrefRangeEnd = 1087547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RTHandle GetCurrentTexture(int eyeIndex = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&eyeIndex);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentTexture_Public_RTHandle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087559, XrefRangeEnd = 1087560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RTHandle GetPreviousTexture(int eyeIndex = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&eyeIndex);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPreviousTexture_Public_RTHandle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087560, XrefRangeEnd = 1087561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsAllocated()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAllocated_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087561, XrefRangeEnd = 1087565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsDirty(ref RenderTextureDescriptor desc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref desc);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsDirty_Private_Boolean_byref_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087565, XrefRangeEnd = 1087577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Alloc(ref RenderTextureDescriptor desc, bool xrMultipassEnabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref desc);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &xrMultipassEnabled;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Alloc_Private_Void_byref_RenderTextureDescriptor_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087577, XrefRangeEnd = 1087579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe RenderTextureDescriptor GetHistoryDescriptor(ref RenderTextureDescriptor cameraDesc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref cameraDesc);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHistoryDescriptor_Internal_RenderTextureDescriptor_byref_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RenderTextureDescriptor*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1087598, RefRangeEnd = 1087600, XrefRangeStart = 1087579, XrefRangeEnd = 1087598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Update(ref RenderTextureDescriptor cameraDesc, bool xrMultipassEnabled = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref cameraDesc);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &xrMultipassEnabled;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Internal_Boolean_byref_RenderTextureDescriptor_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087600, XrefRangeEnd = 1087605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RawColorHistory()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RawColorHistory>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RawColorHistory(IntPtr pointer)
		: base(pointer)
	{
	}
}
