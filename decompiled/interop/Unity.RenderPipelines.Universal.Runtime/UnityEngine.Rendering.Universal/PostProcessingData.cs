using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal;

public sealed class PostProcessingData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_frameData;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ContextContainer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_universalPostProcessingData_Internal_get_UniversalPostProcessingData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_gradingMode_Public_get_byref_ColorGradingMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lutSize_Public_get_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_useFastSRGBLinearConversion_Public_get_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportScreenSpaceLensFlare_Public_get_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportDataDrivenLensFlare_Public_get_byref_Boolean_0;

	public unsafe ContextContainer frameData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ContextContainer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe UniversalPostProcessingData universalPostProcessingData
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1107428, RefRangeEnd = 1107429, XrefRangeStart = 1107424, XrefRangeEnd = 1107428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_universalPostProcessingData_Internal_get_UniversalPostProcessingData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UniversalPostProcessingData>(intPtr2) : null;
		}
	}

	public unsafe ref ColorGradingMode gradingMode
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1107432, RefRangeEnd = 1107433, XrefRangeStart = 1107429, XrefRangeEnd = 1107432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_gradingMode_Public_get_byref_ColorGradingMode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(ColorGradingMode*)intPtr2;
		}
	}

	public unsafe ref int lutSize
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1107436, RefRangeEnd = 1107437, XrefRangeStart = 1107433, XrefRangeEnd = 1107436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lutSize_Public_get_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(int*)intPtr2;
		}
	}

	public unsafe ref bool useFastSRGBLinearConversion
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1107440, RefRangeEnd = 1107441, XrefRangeStart = 1107437, XrefRangeEnd = 1107440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_useFastSRGBLinearConversion_Public_get_byref_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(bool*)intPtr2;
		}
	}

	public unsafe ref bool supportScreenSpaceLensFlare
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1107444, RefRangeEnd = 1107445, XrefRangeStart = 1107441, XrefRangeEnd = 1107444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportScreenSpaceLensFlare_Public_get_byref_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(bool*)intPtr2;
		}
	}

	public unsafe ref bool supportDataDrivenLensFlare
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1107448, RefRangeEnd = 1107449, XrefRangeStart = 1107445, XrefRangeEnd = 1107448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportDataDrivenLensFlare_Public_get_byref_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(bool*)intPtr2;
		}
	}

	static PostProcessingData()
	{
		Il2CppClassPointerStore<PostProcessingData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "PostProcessingData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessingData>.NativeClassPtr);
		NativeFieldInfoPtr_frameData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingData>.NativeClassPtr, "frameData");
		NativeMethodInfoPtr__ctor_Internal_Void_ContextContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingData>.NativeClassPtr, 100666109);
		NativeMethodInfoPtr_get_universalPostProcessingData_Internal_get_UniversalPostProcessingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingData>.NativeClassPtr, 100666110);
		NativeMethodInfoPtr_get_gradingMode_Public_get_byref_ColorGradingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingData>.NativeClassPtr, 100666111);
		NativeMethodInfoPtr_get_lutSize_Public_get_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingData>.NativeClassPtr, 100666112);
		NativeMethodInfoPtr_get_useFastSRGBLinearConversion_Public_get_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingData>.NativeClassPtr, 100666113);
		NativeMethodInfoPtr_get_supportScreenSpaceLensFlare_Public_get_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingData>.NativeClassPtr, 100666114);
		NativeMethodInfoPtr_get_supportDataDrivenLensFlare_Public_get_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingData>.NativeClassPtr, 100666115);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 110106, RefRangeEnd = 110111, XrefRangeStart = 110106, XrefRangeEnd = 110111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PostProcessingData(ContextContainer frameData)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessingData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_ContextContainer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public PostProcessingData(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public PostProcessingData()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessingData>.NativeClassPtr))
	{
	}
}
