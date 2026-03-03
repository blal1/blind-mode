using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Playables;

namespace UnityEngine.Timeline;

public class TimeControlPlayable : PlayableBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_m_timeControl;

	private static readonly IntPtr NativeFieldInfoPtr_m_started;

	private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_TimeControlPlayable_PlayableGraph_ITimeControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_ITimeControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_PrepareFrame_Public_Virtual_Void_Playable_FrameData_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourPlay_Public_Virtual_Void_Playable_FrameData_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourPause_Public_Virtual_Void_Playable_FrameData_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ITimeControl m_timeControl
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_timeControl);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ITimeControl>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_timeControl)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_started
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_started);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_started)) = value;
		}
	}

	static TimeControlPlayable()
	{
		Il2CppClassPointerStore<TimeControlPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "TimeControlPlayable");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeControlPlayable>.NativeClassPtr);
		NativeFieldInfoPtr_m_timeControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeControlPlayable>.NativeClassPtr, "m_timeControl");
		NativeFieldInfoPtr_m_started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeControlPlayable>.NativeClassPtr, "m_started");
		NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_TimeControlPlayable_PlayableGraph_ITimeControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeControlPlayable>.NativeClassPtr, 100664052);
		NativeMethodInfoPtr_Initialize_Public_Void_ITimeControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeControlPlayable>.NativeClassPtr, 100664053);
		NativeMethodInfoPtr_PrepareFrame_Public_Virtual_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeControlPlayable>.NativeClassPtr, 100664054);
		NativeMethodInfoPtr_OnBehaviourPlay_Public_Virtual_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeControlPlayable>.NativeClassPtr, 100664055);
		NativeMethodInfoPtr_OnBehaviourPause_Public_Virtual_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeControlPlayable>.NativeClassPtr, 100664056);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeControlPlayable>.NativeClassPtr, 100664057);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1141065, RefRangeEnd = 1141066, XrefRangeStart = 1141050, XrefRangeEnd = 1141065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ScriptPlayable<TimeControlPlayable> Create(PlayableGraph graph, ITimeControl timeControl)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&graph);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)timeControl);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_TimeControlPlayable_PlayableGraph_ITimeControl_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ScriptPlayable<TimeControlPlayable>(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 42532, RefRangeEnd = 42533, XrefRangeStart = 42532, XrefRangeEnd = 42533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize(ITimeControl timeControl)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)timeControl);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_ITimeControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141066, XrefRangeEnd = 1141072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void PrepareFrame(Playable playable, FrameData info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&playable);
		*(FrameData**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &info;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_PrepareFrame_Public_Virtual_Void_Playable_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141072, XrefRangeEnd = 1141075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnBehaviourPlay(Playable playable, FrameData info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&playable);
		*(FrameData**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &info;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnBehaviourPlay_Public_Virtual_Void_Playable_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141075, XrefRangeEnd = 1141078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnBehaviourPause(Playable playable, FrameData info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&playable);
		*(FrameData**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &info;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnBehaviourPause_Public_Virtual_Void_Playable_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(134)]
	[CachedScanResults(RefRangeStart = 24861, RefRangeEnd = 24995, XrefRangeStart = 24861, XrefRangeEnd = 24995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TimeControlPlayable()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeControlPlayable>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TimeControlPlayable(IntPtr pointer)
		: base(pointer)
	{
	}
}
