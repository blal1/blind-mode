using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Playables;

namespace UnityEngine.Timeline;

public class InfiniteRuntimeClip : RuntimeElement
{
	private static readonly IntPtr NativeFieldInfoPtr_m_Playable;

	private static readonly IntPtr NativeFieldInfoPtr_kIntervalEnd;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Playable_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_intervalStart_Public_Virtual_get_Int64_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_intervalEnd_Public_Virtual_get_Int64_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_enable_Public_Virtual_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_EvaluateAt_Public_Virtual_Void_Double_FrameData_0;

	private static readonly IntPtr NativeMethodInfoPtr_DisableAt_Public_Virtual_Void_Double_Double_FrameData_0;

	public unsafe Playable m_Playable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Playable);
			return *(Playable*)num;
		}
		set
		{
			*(Playable*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Playable)) = value;
		}
	}

	public unsafe static long kIntervalEnd
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kIntervalEnd, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kIntervalEnd, (void*)(&value));
		}
	}

	public unsafe override long intervalStart
	{
		[CallerCount(146)]
		[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_intervalStart_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe override long intervalEnd
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139867, XrefRangeEnd = 1139871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_intervalEnd_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe override bool enable
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139871, XrefRangeEnd = 1139875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_set_enable_Public_Virtual_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static InfiniteRuntimeClip()
	{
		Il2CppClassPointerStore<InfiniteRuntimeClip>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "InfiniteRuntimeClip");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InfiniteRuntimeClip>.NativeClassPtr);
		NativeFieldInfoPtr_m_Playable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfiniteRuntimeClip>.NativeClassPtr, "m_Playable");
		NativeFieldInfoPtr_kIntervalEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfiniteRuntimeClip>.NativeClassPtr, "kIntervalEnd");
		NativeMethodInfoPtr__ctor_Public_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiniteRuntimeClip>.NativeClassPtr, 100663869);
		NativeMethodInfoPtr_get_intervalStart_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiniteRuntimeClip>.NativeClassPtr, 100663870);
		NativeMethodInfoPtr_get_intervalEnd_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiniteRuntimeClip>.NativeClassPtr, 100663871);
		NativeMethodInfoPtr_set_enable_Public_Virtual_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiniteRuntimeClip>.NativeClassPtr, 100663872);
		NativeMethodInfoPtr_EvaluateAt_Public_Virtual_Void_Double_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiniteRuntimeClip>.NativeClassPtr, 100663873);
		NativeMethodInfoPtr_DisableAt_Public_Virtual_Void_Double_Double_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiniteRuntimeClip>.NativeClassPtr, 100663874);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139866, XrefRangeEnd = 1139867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InfiniteRuntimeClip(Playable playable)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InfiniteRuntimeClip>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&playable);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Playable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139875, XrefRangeEnd = 1139878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void EvaluateAt(double localTime, FrameData frameData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&localTime);
		*(FrameData**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &frameData;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_EvaluateAt_Public_Virtual_Void_Double_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139878, XrefRangeEnd = 1139881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void DisableAt(double localTime, double rootDuration, FrameData frameData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&localTime);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &rootDuration;
		*(FrameData**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &frameData;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_DisableAt_Public_Virtual_Void_Double_Double_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public InfiniteRuntimeClip(IntPtr pointer)
		: base(pointer)
	{
	}
}
