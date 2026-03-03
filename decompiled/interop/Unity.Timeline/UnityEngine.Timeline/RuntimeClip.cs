using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Playables;

namespace UnityEngine.Timeline;

public class RuntimeClip : RuntimeClipBase
{
	private static readonly IntPtr NativeFieldInfoPtr_m_Clip;

	private static readonly IntPtr NativeFieldInfoPtr_m_Playable;

	private static readonly IntPtr NativeFieldInfoPtr_m_ParentMixer;

	private static readonly IntPtr NativeMethodInfoPtr_get_start_Public_Virtual_get_Double_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_duration_Public_Virtual_get_Double_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TimelineClip_Playable_Playable_0;

	private static readonly IntPtr NativeMethodInfoPtr_Create_Private_Void_TimelineClip_Playable_Playable_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_clip_Public_get_TimelineClip_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_mixer_Public_get_Playable_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_playable_Public_get_Playable_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_enable_Public_Virtual_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetTime_Public_Void_Double_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetDuration_Public_Void_Double_0;

	private static readonly IntPtr NativeMethodInfoPtr_EvaluateAt_Public_Virtual_Void_Double_FrameData_0;

	private static readonly IntPtr NativeMethodInfoPtr_DisableAt_Public_Virtual_Void_Double_Double_FrameData_0;

	public unsafe TimelineClip m_Clip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Clip);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TimelineClip>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Clip)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

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

	public unsafe Playable m_ParentMixer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ParentMixer);
			return *(Playable*)num;
		}
		set
		{
			*(Playable*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ParentMixer)) = value;
		}
	}

	public unsafe override double start
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_start_Public_Virtual_get_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe override double duration
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140000, XrefRangeEnd = 1140002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_duration_Public_Virtual_get_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe TimelineClip clip
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_clip_Public_get_TimelineClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<TimelineClip>(intPtr2) : null;
		}
	}

	public unsafe Playable mixer
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mixer_Public_get_Playable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Playable*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Playable playable
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_playable_Public_get_Playable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Playable*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe override bool enable
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140011, XrefRangeEnd = 1140025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	static RuntimeClip()
	{
		Il2CppClassPointerStore<RuntimeClip>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "RuntimeClip");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeClip>.NativeClassPtr);
		NativeFieldInfoPtr_m_Clip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeClip>.NativeClassPtr, "m_Clip");
		NativeFieldInfoPtr_m_Playable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeClip>.NativeClassPtr, "m_Playable");
		NativeFieldInfoPtr_m_ParentMixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeClip>.NativeClassPtr, "m_ParentMixer");
		NativeMethodInfoPtr_get_start_Public_Virtual_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClip>.NativeClassPtr, 100663890);
		NativeMethodInfoPtr_get_duration_Public_Virtual_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClip>.NativeClassPtr, 100663891);
		NativeMethodInfoPtr__ctor_Public_Void_TimelineClip_Playable_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClip>.NativeClassPtr, 100663892);
		NativeMethodInfoPtr_Create_Private_Void_TimelineClip_Playable_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClip>.NativeClassPtr, 100663893);
		NativeMethodInfoPtr_get_clip_Public_get_TimelineClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClip>.NativeClassPtr, 100663894);
		NativeMethodInfoPtr_get_mixer_Public_get_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClip>.NativeClassPtr, 100663895);
		NativeMethodInfoPtr_get_playable_Public_get_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClip>.NativeClassPtr, 100663896);
		NativeMethodInfoPtr_set_enable_Public_Virtual_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClip>.NativeClassPtr, 100663897);
		NativeMethodInfoPtr_SetTime_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClip>.NativeClassPtr, 100663898);
		NativeMethodInfoPtr_SetDuration_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClip>.NativeClassPtr, 100663899);
		NativeMethodInfoPtr_EvaluateAt_Public_Virtual_Void_Double_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClip>.NativeClassPtr, 100663900);
		NativeMethodInfoPtr_DisableAt_Public_Virtual_Void_Double_Double_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClip>.NativeClassPtr, 100663901);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140002, XrefRangeEnd = 1140007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RuntimeClip(TimelineClip clip, Playable clipPlayable, Playable parentMixer)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeClip>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clip);
		*(Playable**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &clipPlayable;
		*(Playable**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &parentMixer;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_TimelineClip_Playable_Playable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140007, XrefRangeEnd = 1140011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Create(TimelineClip clip, Playable clipPlayable, Playable parentMixer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clip);
		*(Playable**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &clipPlayable;
		*(Playable**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &parentMixer;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Private_Void_TimelineClip_Playable_Playable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140025, XrefRangeEnd = 1140028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTime(double time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&time);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTime_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140028, XrefRangeEnd = 1140031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDuration(double duration)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&duration);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDuration_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140031, XrefRangeEnd = 1140066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140066, XrefRangeEnd = 1140086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public RuntimeClip(IntPtr pointer)
		: base(pointer)
	{
	}
}
