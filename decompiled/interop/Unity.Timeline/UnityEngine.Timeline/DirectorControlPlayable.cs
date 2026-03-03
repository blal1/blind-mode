using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Timeline;

public class DirectorControlPlayable : PlayableBehaviour
{
	[OriginalName("Unity.Timeline.dll", "", "PauseAction")]
	public enum PauseAction
	{
		StopDirector,
		PauseDirector
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_director;

	private static readonly System.IntPtr NativeFieldInfoPtr_pauseAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SyncTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AssetDuration;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_DirectorControlPlayable_PlayableGraph_PlayableDirector_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPlayableDestroy_Public_Virtual_Void_Playable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareFrame_Public_Virtual_Void_Playable_FrameData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBehaviourPlay_Public_Virtual_Void_Playable_FrameData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBehaviourPause_Public_Virtual_Void_Playable_FrameData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessFrame_Public_Virtual_Void_Playable_FrameData_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SyncSpeed_Private_Void_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SyncStart_Private_Void_PlayableGraph_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SyncStop_Private_Void_PlayableGraph_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DetectDiscontinuity_Private_Boolean_Playable_FrameData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DetectOutOfSync_Private_Boolean_Playable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTime_Private_Void_Playable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe PlayableDirector director
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_director);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayableDirector>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_director)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe PauseAction pauseAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pauseAction);
			return *(PauseAction*)num;
		}
		set
		{
			*(PauseAction*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pauseAction)) = value;
		}
	}

	public unsafe bool m_SyncTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SyncTime);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SyncTime)) = value;
		}
	}

	public unsafe double m_AssetDuration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AssetDuration);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AssetDuration)) = value;
		}
	}

	static DirectorControlPlayable()
	{
		Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "DirectorControlPlayable");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr);
		NativeFieldInfoPtr_director = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr, "director");
		NativeFieldInfoPtr_pauseAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr, "pauseAction");
		NativeFieldInfoPtr_m_SyncTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr, "m_SyncTime");
		NativeFieldInfoPtr_m_AssetDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr, "m_AssetDuration");
		NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_DirectorControlPlayable_PlayableGraph_PlayableDirector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr, 100664018);
		NativeMethodInfoPtr_OnPlayableDestroy_Public_Virtual_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr, 100664019);
		NativeMethodInfoPtr_PrepareFrame_Public_Virtual_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr, 100664020);
		NativeMethodInfoPtr_OnBehaviourPlay_Public_Virtual_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr, 100664021);
		NativeMethodInfoPtr_OnBehaviourPause_Public_Virtual_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr, 100664022);
		NativeMethodInfoPtr_ProcessFrame_Public_Virtual_Void_Playable_FrameData_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr, 100664023);
		NativeMethodInfoPtr_SyncSpeed_Private_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr, 100664024);
		NativeMethodInfoPtr_SyncStart_Private_Void_PlayableGraph_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr, 100664025);
		NativeMethodInfoPtr_SyncStop_Private_Void_PlayableGraph_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr, 100664026);
		NativeMethodInfoPtr_DetectDiscontinuity_Private_Boolean_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr, 100664027);
		NativeMethodInfoPtr_DetectOutOfSync_Private_Boolean_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr, 100664028);
		NativeMethodInfoPtr_UpdateTime_Private_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr, 100664029);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr, 100664030);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1140680, RefRangeEnd = 1140681, XrefRangeStart = 1140661, XrefRangeEnd = 1140680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ScriptPlayable<DirectorControlPlayable> Create(PlayableGraph graph, PlayableDirector director)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&graph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)director);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_DirectorControlPlayable_PlayableGraph_PlayableDirector_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ScriptPlayable<DirectorControlPlayable>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140681, XrefRangeEnd = 1140690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnPlayableDestroy(Playable playable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playable);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnPlayableDestroy_Public_Virtual_Void_Playable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140690, XrefRangeEnd = 1140737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void PrepareFrame(Playable playable, FrameData info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&playable);
		*(FrameData**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &info;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_PrepareFrame_Public_Virtual_Void_Playable_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140737, XrefRangeEnd = 1140746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnBehaviourPlay(Playable playable, FrameData info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&playable);
		*(FrameData**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &info;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnBehaviourPlay_Public_Virtual_Void_Playable_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140746, XrefRangeEnd = 1140757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnBehaviourPause(Playable playable, FrameData info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&playable);
		*(FrameData**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &info;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnBehaviourPause_Public_Virtual_Void_Playable_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140757, XrefRangeEnd = 1140801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void ProcessFrame(Playable playable, FrameData info, Il2CppSystem.Object playerData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&playable);
		*(FrameData**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &info;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ProcessFrame_Public_Virtual_Void_Playable_FrameData_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140801, XrefRangeEnd = 1140813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SyncSpeed(double speed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&speed);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SyncSpeed_Private_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140813, XrefRangeEnd = 1140818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SyncStart(PlayableGraph graph, double time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&graph);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SyncStart_Private_Void_PlayableGraph_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140818, XrefRangeEnd = 1140825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SyncStop(PlayableGraph graph, double time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&graph);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SyncStop_Private_Void_PlayableGraph_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140825, XrefRangeEnd = 1140837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool DetectDiscontinuity(Playable playable, FrameData info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&playable);
		*(FrameData**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &info;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DetectDiscontinuity_Private_Boolean_Playable_FrameData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140837, XrefRangeEnd = 1140846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool DetectOutOfSync(Playable playable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playable);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DetectOutOfSync_Private_Boolean_Playable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1140860, RefRangeEnd = 1140861, XrefRangeStart = 1140846, XrefRangeEnd = 1140860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateTime(Playable playable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playable);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateTime_Private_Void_Playable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140861, XrefRangeEnd = 1140862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DirectorControlPlayable()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public DirectorControlPlayable(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
