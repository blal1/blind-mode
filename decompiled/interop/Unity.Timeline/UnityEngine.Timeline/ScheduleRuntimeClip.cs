using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Playables;

namespace UnityEngine.Timeline;

public class ScheduleRuntimeClip : RuntimeClipBase
{
	private static readonly IntPtr NativeFieldInfoPtr_m_Clip;

	private static readonly IntPtr NativeFieldInfoPtr_m_Playable;

	private static readonly IntPtr NativeFieldInfoPtr_m_ParentMixer;

	private static readonly IntPtr NativeFieldInfoPtr_m_StartDelay;

	private static readonly IntPtr NativeFieldInfoPtr_m_FinishTail;

	private static readonly IntPtr NativeFieldInfoPtr_m_Started;

	private static readonly IntPtr NativeMethodInfoPtr_get_start_Public_Virtual_get_Double_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_duration_Public_Virtual_get_Double_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetTime_Public_Void_Double_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_clip_Public_get_TimelineClip_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_mixer_Public_get_Playable_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_playable_Public_get_Playable_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TimelineClip_Playable_Playable_Double_Double_0;

	private static readonly IntPtr NativeMethodInfoPtr_Create_Private_Void_TimelineClip_Playable_Playable_Double_Double_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_enable_Public_Virtual_set_Void_Boolean_0;

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

	public unsafe double m_StartDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StartDelay);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StartDelay)) = value;
		}
	}

	public unsafe double m_FinishTail
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FinishTail);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FinishTail)) = value;
		}
	}

	public unsafe bool m_Started
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Started);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Started)) = value;
		}
	}

	public unsafe override double start
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140100, XrefRangeEnd = 1140105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140117, XrefRangeEnd = 1140126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	static ScheduleRuntimeClip()
	{
		Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "ScheduleRuntimeClip");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr);
		NativeFieldInfoPtr_m_Clip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr, "m_Clip");
		NativeFieldInfoPtr_m_Playable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr, "m_Playable");
		NativeFieldInfoPtr_m_ParentMixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr, "m_ParentMixer");
		NativeFieldInfoPtr_m_StartDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr, "m_StartDelay");
		NativeFieldInfoPtr_m_FinishTail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr, "m_FinishTail");
		NativeFieldInfoPtr_m_Started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr, "m_Started");
		NativeMethodInfoPtr_get_start_Public_Virtual_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr, 100663915);
		NativeMethodInfoPtr_get_duration_Public_Virtual_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr, 100663916);
		NativeMethodInfoPtr_SetTime_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr, 100663917);
		NativeMethodInfoPtr_get_clip_Public_get_TimelineClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr, 100663918);
		NativeMethodInfoPtr_get_mixer_Public_get_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr, 100663919);
		NativeMethodInfoPtr_get_playable_Public_get_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr, 100663920);
		NativeMethodInfoPtr__ctor_Public_Void_TimelineClip_Playable_Playable_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr, 100663921);
		NativeMethodInfoPtr_Create_Private_Void_TimelineClip_Playable_Playable_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr, 100663922);
		NativeMethodInfoPtr_set_enable_Public_Virtual_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr, 100663923);
		NativeMethodInfoPtr_EvaluateAt_Public_Virtual_Void_Double_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr, 100663924);
		NativeMethodInfoPtr_DisableAt_Public_Virtual_Void_Double_Double_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr, 100663925);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140105, XrefRangeEnd = 1140108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140108, XrefRangeEnd = 1140113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ScheduleRuntimeClip(TimelineClip clip, Playable clipPlayable, Playable parentMixer, double startDelay = 0.2, double finishTail = 0.1)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clip);
		*(Playable**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &clipPlayable;
		*(Playable**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &parentMixer;
		*(double**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &startDelay;
		*(double**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &finishTail;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_TimelineClip_Playable_Playable_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140113, XrefRangeEnd = 1140117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Create(TimelineClip clip, Playable clipPlayable, Playable parentMixer, double startDelay, double finishTail)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clip);
		*(Playable**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &clipPlayable;
		*(Playable**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &parentMixer;
		*(double**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &startDelay;
		*(double**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &finishTail;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Private_Void_TimelineClip_Playable_Playable_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140126, XrefRangeEnd = 1140155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 572391, RefRangeEnd = 572394, XrefRangeStart = 572391, XrefRangeEnd = 572394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public ScheduleRuntimeClip(IntPtr pointer)
		: base(pointer)
	{
	}
}
