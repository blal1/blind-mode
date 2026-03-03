using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace Il2CppSpine.Unity.Playables;

[Serializable]
public class SpineAnimationStateBehaviour : PlayableBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_timelineClip;

	private static readonly IntPtr NativeFieldInfoPtr_animationReference;

	private static readonly IntPtr NativeFieldInfoPtr_loop;

	private static readonly IntPtr NativeFieldInfoPtr_customDuration;

	private static readonly IntPtr NativeFieldInfoPtr_useBlendDuration;

	private static readonly IntPtr NativeFieldInfoPtr_isInitialized;

	private static readonly IntPtr NativeFieldInfoPtr_mixDuration;

	private static readonly IntPtr NativeFieldInfoPtr_holdPrevious;

	private static readonly IntPtr NativeFieldInfoPtr_dontPauseWithDirector;

	private static readonly IntPtr NativeFieldInfoPtr_dontEndWithClip;

	private static readonly IntPtr NativeFieldInfoPtr_endMixOutDuration;

	private static readonly IntPtr NativeFieldInfoPtr_attachmentThreshold;

	private static readonly IntPtr NativeFieldInfoPtr_eventThreshold;

	private static readonly IntPtr NativeFieldInfoPtr_drawOrderThreshold;

	private static readonly IntPtr NativeFieldInfoPtr_alpha;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe TimelineClip timelineClip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timelineClip);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TimelineClip>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timelineClip)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe AnimationReferenceAsset animationReference
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animationReference);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AnimationReferenceAsset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animationReference)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool loop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loop);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loop)) = value;
		}
	}

	public unsafe bool customDuration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customDuration);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customDuration)) = value;
		}
	}

	public unsafe bool useBlendDuration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useBlendDuration);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useBlendDuration)) = value;
		}
	}

	public unsafe bool isInitialized
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInitialized);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInitialized)) = value;
		}
	}

	public unsafe float mixDuration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mixDuration);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mixDuration)) = value;
		}
	}

	public unsafe bool holdPrevious
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_holdPrevious);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_holdPrevious)) = value;
		}
	}

	public unsafe bool dontPauseWithDirector
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontPauseWithDirector);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontPauseWithDirector)) = value;
		}
	}

	public unsafe bool dontEndWithClip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontEndWithClip);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontEndWithClip)) = value;
		}
	}

	public unsafe float endMixOutDuration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endMixOutDuration);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endMixOutDuration)) = value;
		}
	}

	public unsafe float attachmentThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attachmentThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attachmentThreshold)) = value;
		}
	}

	public unsafe float eventThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventThreshold)) = value;
		}
	}

	public unsafe float drawOrderThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawOrderThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawOrderThreshold)) = value;
		}
	}

	public unsafe float alpha
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alpha);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alpha)) = value;
		}
	}

	static SpineAnimationStateBehaviour()
	{
		Il2CppClassPointerStore<SpineAnimationStateBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-timeline.dll", "Spine.Unity.Playables", "SpineAnimationStateBehaviour");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpineAnimationStateBehaviour>.NativeClassPtr);
		NativeFieldInfoPtr_timelineClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpineAnimationStateBehaviour>.NativeClassPtr, "timelineClip");
		NativeFieldInfoPtr_animationReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpineAnimationStateBehaviour>.NativeClassPtr, "animationReference");
		NativeFieldInfoPtr_loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpineAnimationStateBehaviour>.NativeClassPtr, "loop");
		NativeFieldInfoPtr_customDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpineAnimationStateBehaviour>.NativeClassPtr, "customDuration");
		NativeFieldInfoPtr_useBlendDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpineAnimationStateBehaviour>.NativeClassPtr, "useBlendDuration");
		NativeFieldInfoPtr_isInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpineAnimationStateBehaviour>.NativeClassPtr, "isInitialized");
		NativeFieldInfoPtr_mixDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpineAnimationStateBehaviour>.NativeClassPtr, "mixDuration");
		NativeFieldInfoPtr_holdPrevious = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpineAnimationStateBehaviour>.NativeClassPtr, "holdPrevious");
		NativeFieldInfoPtr_dontPauseWithDirector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpineAnimationStateBehaviour>.NativeClassPtr, "dontPauseWithDirector");
		NativeFieldInfoPtr_dontEndWithClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpineAnimationStateBehaviour>.NativeClassPtr, "dontEndWithClip");
		NativeFieldInfoPtr_endMixOutDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpineAnimationStateBehaviour>.NativeClassPtr, "endMixOutDuration");
		NativeFieldInfoPtr_attachmentThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpineAnimationStateBehaviour>.NativeClassPtr, "attachmentThreshold");
		NativeFieldInfoPtr_eventThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpineAnimationStateBehaviour>.NativeClassPtr, "eventThreshold");
		NativeFieldInfoPtr_drawOrderThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpineAnimationStateBehaviour>.NativeClassPtr, "drawOrderThreshold");
		NativeFieldInfoPtr_alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpineAnimationStateBehaviour>.NativeClassPtr, "alpha");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpineAnimationStateBehaviour>.NativeClassPtr, 100663323);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 849657, XrefRangeEnd = 849658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SpineAnimationStateBehaviour()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpineAnimationStateBehaviour>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SpineAnimationStateBehaviour(IntPtr pointer)
		: base(pointer)
	{
	}
}
