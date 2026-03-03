using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal;

public sealed class StpHistory : CameraHistoryItem
{
	private static readonly IntPtr NativeFieldInfoPtr_m_historyContexts;

	private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Public_Virtual_Void_BufferedRTHandleSystem_UInt32_0;

	private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetHistoryContext_Internal_HistoryContext_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Internal_Boolean_UniversalCameraData_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppReferenceArray<STP.HistoryContext> m_historyContexts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_historyContexts);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<STP.HistoryContext>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_historyContexts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static StpHistory()
	{
		Il2CppClassPointerStore<StpHistory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "StpHistory");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StpHistory>.NativeClassPtr);
		NativeFieldInfoPtr_m_historyContexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StpHistory>.NativeClassPtr, "m_historyContexts");
		NativeMethodInfoPtr_OnCreate_Public_Virtual_Void_BufferedRTHandleSystem_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StpHistory>.NativeClassPtr, 100664666);
		NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StpHistory>.NativeClassPtr, 100664667);
		NativeMethodInfoPtr_GetHistoryContext_Internal_HistoryContext_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StpHistory>.NativeClassPtr, 100664668);
		NativeMethodInfoPtr_Update_Internal_Boolean_UniversalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StpHistory>.NativeClassPtr, 100664669);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StpHistory>.NativeClassPtr, 100664670);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087721, XrefRangeEnd = 1087727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087727, XrefRangeEnd = 1087728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1087728, RefRangeEnd = 1087729, XrefRangeStart = 1087728, XrefRangeEnd = 1087728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe STP.HistoryContext GetHistoryContext(int eyeIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&eyeIndex);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHistoryContext_Internal_HistoryContext_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<STP.HistoryContext>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1087735, RefRangeEnd = 1087736, XrefRangeStart = 1087729, XrefRangeEnd = 1087735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Update(UniversalCameraData cameraData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Internal_Boolean_UniversalCameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087736, XrefRangeEnd = 1087741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StpHistory()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StpHistory>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public StpHistory(IntPtr pointer)
		: base(pointer)
	{
	}
}
