using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.Playables;

public class PlayableDirector : Behaviour
{
	private delegate void ResetFrameTimingDelegate();

	private delegate DirectorUpdateMode get_timeUpdateMode_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_initialTime_InjectedDelegate(System.IntPtr _unity_self, double value);

	private delegate void ClearReferenceValue_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr id);

	private delegate void SetReferenceValue_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr id, System.IntPtr value);

	private delegate void RebindPlayableGraphOutputs_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void ProcessPendingGraphChanges_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool HasGenericBinding_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr key);

	private delegate void EvaluateNextFrame_InjectedDelegate(System.IntPtr _unity_self);

	private static readonly System.IntPtr NativeFieldInfoPtr_played;

	private static readonly System.IntPtr NativeFieldInfoPtr_paused;

	private static readonly System.IntPtr NativeFieldInfoPtr_stopped;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_state_Public_get_PlayState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_extrapolationMode_Public_set_Void_DirectorWrapMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_extrapolationMode_Public_get_DirectorWrapMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_playableAsset_Public_get_PlayableAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_playableAsset_Public_set_Void_PlayableAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_playableGraph_Public_get_PlayableGraph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_playOnAwake_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_playOnAwake_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Play_Internal_Void_FrameRate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Void_PlayableAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Void_PlayableAsset_DirectorWrapMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGenericBinding_Public_Void_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_timeUpdateMode_Public_set_Void_DirectorUpdateMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_time_Public_set_Void_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_time_Public_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_initialTime_Public_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_duration_Public_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayOnFrame_Private_Void_FrameRate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pause_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Resume_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RebuildGraph_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetReferenceValue_Public_Virtual_Final_New_Object_PropertyName_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGenericBinding_Public_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearGenericBinding_Public_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayState_Private_PlayState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWrapMode_Private_Void_DirectorWrapMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWrapMode_Private_DirectorWrapMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGraphHandle_Private_PlayableGraph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPlayOnAwake_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayOnAwake_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_SetGenericBinding_Private_Void_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPlayableAsset_Private_Void_ScriptableObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_GetPlayableAsset_Private_ScriptableObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_played_Public_add_Void_Action_1_PlayableDirector_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_played_Public_rem_Void_Action_1_PlayableDirector_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_paused_Public_add_Void_Action_1_PlayableDirector_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_paused_Public_rem_Void_Action_1_PlayableDirector_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_stopped_Public_add_Void_Action_1_PlayableDirector_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_stopped_Public_rem_Void_Action_1_PlayableDirector_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendOnPlayableDirectorPlay_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendOnPlayableDirectorPause_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendOnPlayableDirectorStop_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_timeUpdateMode_Injected_Private_Static_Void_IntPtr_DirectorUpdateMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_time_Injected_Private_Static_Void_IntPtr_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_time_Injected_Private_Static_Double_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_initialTime_Injected_Private_Static_Double_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_duration_Injected_Private_Static_Double_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayOnFrame_Injected_Private_Static_Void_IntPtr_byref_FrameRate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Play_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pause_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Resume_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RebuildGraph_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetReferenceValue_Injected_Private_Static_IntPtr_IntPtr_byref_PropertyName_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGenericBinding_Injected_Private_Static_IntPtr_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearGenericBinding_Injected_Private_Static_Void_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayState_Injected_Private_Static_PlayState_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWrapMode_Injected_Private_Static_Void_IntPtr_DirectorWrapMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWrapMode_Injected_Private_Static_DirectorWrapMode_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGraphHandle_Injected_Private_Static_Void_IntPtr_byref_PlayableGraph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPlayOnAwake_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayOnAwake_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_SetGenericBinding_Injected_Private_Static_Void_IntPtr_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPlayableAsset_Injected_Private_Static_Void_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_GetPlayableAsset_Injected_Private_Static_IntPtr_IntPtr_0;

	private static readonly ResetFrameTimingDelegate ResetFrameTimingDelegateField;

	private static readonly get_timeUpdateMode_InjectedDelegate get_timeUpdateMode_InjectedDelegateField;

	private static readonly set_initialTime_InjectedDelegate set_initialTime_InjectedDelegateField;

	private static readonly ClearReferenceValue_InjectedDelegate ClearReferenceValue_InjectedDelegateField;

	private static readonly SetReferenceValue_InjectedDelegate SetReferenceValue_InjectedDelegateField;

	private static readonly RebindPlayableGraphOutputs_InjectedDelegate RebindPlayableGraphOutputs_InjectedDelegateField;

	private static readonly ProcessPendingGraphChanges_InjectedDelegate ProcessPendingGraphChanges_InjectedDelegateField;

	private static readonly HasGenericBinding_InjectedDelegate HasGenericBinding_InjectedDelegateField;

	private static readonly EvaluateNextFrame_InjectedDelegate EvaluateNextFrame_InjectedDelegateField;

	public unsafe Il2CppSystem.Action<PlayableDirector> played
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_played);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<PlayableDirector>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_played)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppSystem.Action<PlayableDirector> paused
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paused);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<PlayableDirector>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paused)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppSystem.Action<PlayableDirector> stopped
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stopped);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<PlayableDirector>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stopped)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe PlayState state
	{
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 1241891, RefRangeEnd = 1241923, XrefRangeStart = 1241886, XrefRangeEnd = 1241891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_state_Public_get_PlayState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(PlayState*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe DirectorWrapMode extrapolationMode
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1241936, RefRangeEnd = 1241948, XrefRangeStart = 1241931, XrefRangeEnd = 1241936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_extrapolationMode_Public_get_DirectorWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(DirectorWrapMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1241928, RefRangeEnd = 1241931, XrefRangeStart = 1241923, XrefRangeEnd = 1241928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_extrapolationMode_Public_set_Void_DirectorWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe PlayableAsset playableAsset
	{
		[CallerCount(62)]
		[CachedScanResults(RefRangeStart = 1241957, RefRangeEnd = 1242019, XrefRangeStart = 1241948, XrefRangeEnd = 1241957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_playableAsset_Public_get_PlayableAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayableAsset>(intPtr2) : null;
		}
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 1242027, RefRangeEnd = 1242044, XrefRangeStart = 1242019, XrefRangeEnd = 1242027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_playableAsset_Public_set_Void_PlayableAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe PlayableGraph playableGraph
	{
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 1242048, RefRangeEnd = 1242072, XrefRangeStart = 1242044, XrefRangeEnd = 1242048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_playableGraph_Public_get_PlayableGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(PlayableGraph*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool playOnAwake
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1242077, RefRangeEnd = 1242078, XrefRangeStart = 1242072, XrefRangeEnd = 1242077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_playOnAwake_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1242083, RefRangeEnd = 1242084, XrefRangeStart = 1242078, XrefRangeEnd = 1242083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_playOnAwake_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe DirectorUpdateMode timeUpdateMode
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_timeUpdateMode_Injected(intPtr);
		}
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1242160, RefRangeEnd = 1242164, XrefRangeStart = 1242155, XrefRangeEnd = 1242160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_timeUpdateMode_Public_set_Void_DirectorUpdateMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe double time
	{
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 1242237, RefRangeEnd = 1242273, XrefRangeStart = 1242232, XrefRangeEnd = 1242237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_time_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(63)]
		[CachedScanResults(RefRangeStart = 1242169, RefRangeEnd = 1242232, XrefRangeStart = 1242164, XrefRangeEnd = 1242169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_time_Public_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe double initialTime
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1242278, RefRangeEnd = 1242279, XrefRangeStart = 1242273, XrefRangeEnd = 1242278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_initialTime_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_initialTime_Injected(intPtr, value);
		}
	}

	public unsafe double duration
	{
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 1242284, RefRangeEnd = 1242304, XrefRangeStart = 1242279, XrefRangeEnd = 1242284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_duration_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static PlayableDirector()
	{
		Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.DirectorModule.dll", "UnityEngine.Playables", "PlayableDirector");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr);
		NativeFieldInfoPtr_played = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, "played");
		NativeFieldInfoPtr_paused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, "paused");
		NativeFieldInfoPtr_stopped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, "stopped");
		NativeMethodInfoPtr_get_state_Public_get_PlayState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663302);
		NativeMethodInfoPtr_set_extrapolationMode_Public_set_Void_DirectorWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663303);
		NativeMethodInfoPtr_get_extrapolationMode_Public_get_DirectorWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663304);
		NativeMethodInfoPtr_get_playableAsset_Public_get_PlayableAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663305);
		NativeMethodInfoPtr_set_playableAsset_Public_set_Void_PlayableAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663306);
		NativeMethodInfoPtr_get_playableGraph_Public_get_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663307);
		NativeMethodInfoPtr_get_playOnAwake_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663308);
		NativeMethodInfoPtr_set_playOnAwake_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663309);
		NativeMethodInfoPtr_Play_Internal_Void_FrameRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663310);
		NativeMethodInfoPtr_Play_Public_Void_PlayableAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663311);
		NativeMethodInfoPtr_Play_Public_Void_PlayableAsset_DirectorWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663312);
		NativeMethodInfoPtr_SetGenericBinding_Public_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663313);
		NativeMethodInfoPtr_set_timeUpdateMode_Public_set_Void_DirectorUpdateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663314);
		NativeMethodInfoPtr_set_time_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663315);
		NativeMethodInfoPtr_get_time_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663316);
		NativeMethodInfoPtr_get_initialTime_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663317);
		NativeMethodInfoPtr_get_duration_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663318);
		NativeMethodInfoPtr_Evaluate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663319);
		NativeMethodInfoPtr_PlayOnFrame_Private_Void_FrameRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663320);
		NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663321);
		NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663322);
		NativeMethodInfoPtr_Pause_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663323);
		NativeMethodInfoPtr_Resume_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663324);
		NativeMethodInfoPtr_RebuildGraph_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663325);
		NativeMethodInfoPtr_GetReferenceValue_Public_Virtual_Final_New_Object_PropertyName_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663326);
		NativeMethodInfoPtr_GetGenericBinding_Public_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663327);
		NativeMethodInfoPtr_ClearGenericBinding_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663328);
		NativeMethodInfoPtr_GetPlayState_Private_PlayState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663329);
		NativeMethodInfoPtr_SetWrapMode_Private_Void_DirectorWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663330);
		NativeMethodInfoPtr_GetWrapMode_Private_DirectorWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663331);
		NativeMethodInfoPtr_GetGraphHandle_Private_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663332);
		NativeMethodInfoPtr_SetPlayOnAwake_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663333);
		NativeMethodInfoPtr_GetPlayOnAwake_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663334);
		NativeMethodInfoPtr_Internal_SetGenericBinding_Private_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663335);
		NativeMethodInfoPtr_SetPlayableAsset_Private_Void_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663336);
		NativeMethodInfoPtr_Internal_GetPlayableAsset_Private_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663337);
		NativeMethodInfoPtr_add_played_Public_add_Void_Action_1_PlayableDirector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663338);
		NativeMethodInfoPtr_remove_played_Public_rem_Void_Action_1_PlayableDirector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663339);
		NativeMethodInfoPtr_add_paused_Public_add_Void_Action_1_PlayableDirector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663340);
		NativeMethodInfoPtr_remove_paused_Public_rem_Void_Action_1_PlayableDirector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663341);
		NativeMethodInfoPtr_add_stopped_Public_add_Void_Action_1_PlayableDirector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663342);
		NativeMethodInfoPtr_remove_stopped_Public_rem_Void_Action_1_PlayableDirector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663343);
		NativeMethodInfoPtr_SendOnPlayableDirectorPlay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663344);
		NativeMethodInfoPtr_SendOnPlayableDirectorPause_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663345);
		NativeMethodInfoPtr_SendOnPlayableDirectorStop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663346);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663347);
		NativeMethodInfoPtr_set_timeUpdateMode_Injected_Private_Static_Void_IntPtr_DirectorUpdateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663348);
		NativeMethodInfoPtr_set_time_Injected_Private_Static_Void_IntPtr_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663349);
		NativeMethodInfoPtr_get_time_Injected_Private_Static_Double_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663350);
		NativeMethodInfoPtr_get_initialTime_Injected_Private_Static_Double_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663351);
		NativeMethodInfoPtr_get_duration_Injected_Private_Static_Double_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663352);
		NativeMethodInfoPtr_Evaluate_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663353);
		NativeMethodInfoPtr_PlayOnFrame_Injected_Private_Static_Void_IntPtr_byref_FrameRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663354);
		NativeMethodInfoPtr_Play_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663355);
		NativeMethodInfoPtr_Stop_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663356);
		NativeMethodInfoPtr_Pause_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663357);
		NativeMethodInfoPtr_Resume_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663358);
		NativeMethodInfoPtr_RebuildGraph_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663359);
		NativeMethodInfoPtr_GetReferenceValue_Injected_Private_Static_IntPtr_IntPtr_byref_PropertyName_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663360);
		NativeMethodInfoPtr_GetGenericBinding_Injected_Private_Static_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663361);
		NativeMethodInfoPtr_ClearGenericBinding_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663362);
		NativeMethodInfoPtr_GetPlayState_Injected_Private_Static_PlayState_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663363);
		NativeMethodInfoPtr_SetWrapMode_Injected_Private_Static_Void_IntPtr_DirectorWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663364);
		NativeMethodInfoPtr_GetWrapMode_Injected_Private_Static_DirectorWrapMode_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663365);
		NativeMethodInfoPtr_GetGraphHandle_Injected_Private_Static_Void_IntPtr_byref_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663366);
		NativeMethodInfoPtr_SetPlayOnAwake_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663367);
		NativeMethodInfoPtr_GetPlayOnAwake_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663368);
		NativeMethodInfoPtr_Internal_SetGenericBinding_Injected_Private_Static_Void_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663369);
		NativeMethodInfoPtr_SetPlayableAsset_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663370);
		NativeMethodInfoPtr_Internal_GetPlayableAsset_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663371);
		ResetFrameTimingDelegateField = IL2CPP.ResolveICall<ResetFrameTimingDelegate>("UnityEngine.Playables.PlayableDirector::ResetFrameTiming");
		get_timeUpdateMode_InjectedDelegateField = IL2CPP.ResolveICall<get_timeUpdateMode_InjectedDelegate>("UnityEngine.Playables.PlayableDirector::get_timeUpdateMode_Injected");
		set_initialTime_InjectedDelegateField = IL2CPP.ResolveICall<set_initialTime_InjectedDelegate>("UnityEngine.Playables.PlayableDirector::set_initialTime_Injected");
		ClearReferenceValue_InjectedDelegateField = IL2CPP.ResolveICall<ClearReferenceValue_InjectedDelegate>("UnityEngine.Playables.PlayableDirector::ClearReferenceValue_Injected");
		SetReferenceValue_InjectedDelegateField = IL2CPP.ResolveICall<SetReferenceValue_InjectedDelegate>("UnityEngine.Playables.PlayableDirector::SetReferenceValue_Injected");
		RebindPlayableGraphOutputs_InjectedDelegateField = IL2CPP.ResolveICall<RebindPlayableGraphOutputs_InjectedDelegate>("UnityEngine.Playables.PlayableDirector::RebindPlayableGraphOutputs_Injected");
		ProcessPendingGraphChanges_InjectedDelegateField = IL2CPP.ResolveICall<ProcessPendingGraphChanges_InjectedDelegate>("UnityEngine.Playables.PlayableDirector::ProcessPendingGraphChanges_Injected");
		HasGenericBinding_InjectedDelegateField = IL2CPP.ResolveICall<HasGenericBinding_InjectedDelegate>("UnityEngine.Playables.PlayableDirector::HasGenericBinding_Injected");
		EvaluateNextFrame_InjectedDelegateField = IL2CPP.ResolveICall<EvaluateNextFrame_InjectedDelegate>("UnityEngine.Playables.PlayableDirector::EvaluateNextFrame_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242084, XrefRangeEnd = 1242088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Play(FrameRate frameRate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&frameRate);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play_Internal_Void_FrameRate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 1242104, RefRangeEnd = 1242115, XrefRangeStart = 1242088, XrefRangeEnd = 1242104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Play(PlayableAsset asset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play_Public_Void_PlayableAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1242141, RefRangeEnd = 1242142, XrefRangeStart = 1242115, XrefRangeEnd = 1242141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Play(PlayableAsset asset, DirectorWrapMode mode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asset);
		*(DirectorWrapMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play_Public_Void_PlayableAsset_DirectorWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1242153, RefRangeEnd = 1242155, XrefRangeStart = 1242142, XrefRangeEnd = 1242153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetGenericBinding(Object key, Object value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGenericBinding_Public_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(22)]
	[CachedScanResults(RefRangeStart = 1242309, RefRangeEnd = 1242331, XrefRangeStart = 1242304, XrefRangeEnd = 1242309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Evaluate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Evaluate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242331, XrefRangeEnd = 1242335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayOnFrame(FrameRate frameRate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&frameRate);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayOnFrame_Private_Void_FrameRate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(26)]
	[CachedScanResults(RefRangeStart = 1242340, RefRangeEnd = 1242366, XrefRangeStart = 1242335, XrefRangeEnd = 1242340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Play()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(26)]
	[CachedScanResults(RefRangeStart = 1242371, RefRangeEnd = 1242397, XrefRangeStart = 1242366, XrefRangeEnd = 1242371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Stop()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 1242402, RefRangeEnd = 1242418, XrefRangeStart = 1242397, XrefRangeEnd = 1242402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Pause()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pause_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1242423, RefRangeEnd = 1242429, XrefRangeStart = 1242418, XrefRangeEnd = 1242423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Resume()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Resume_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1242434, RefRangeEnd = 1242440, XrefRangeStart = 1242429, XrefRangeEnd = 1242434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildGraph()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RebuildGraph_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242440, XrefRangeEnd = 1242447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Object GetReferenceValue(PropertyName id, out bool idValid)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&id);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref idValid);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetReferenceValue_Public_Virtual_Final_New_Object_PropertyName_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1242458, RefRangeEnd = 1242464, XrefRangeStart = 1242447, XrefRangeEnd = 1242458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Object GetGenericBinding(Object key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)key);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGenericBinding_Public_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1242472, RefRangeEnd = 1242473, XrefRangeStart = 1242464, XrefRangeEnd = 1242472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearGenericBinding(Object key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)key);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearGenericBinding_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(32)]
	[CachedScanResults(RefRangeStart = 1241891, RefRangeEnd = 1241923, XrefRangeStart = 1241891, XrefRangeEnd = 1241923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayState GetPlayState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPlayState_Private_PlayState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PlayState*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1241928, RefRangeEnd = 1241931, XrefRangeStart = 1241928, XrefRangeEnd = 1241931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetWrapMode(DirectorWrapMode mode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mode);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWrapMode_Private_Void_DirectorWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 1241936, RefRangeEnd = 1241948, XrefRangeStart = 1241936, XrefRangeEnd = 1241948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DirectorWrapMode GetWrapMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWrapMode_Private_DirectorWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DirectorWrapMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242473, XrefRangeEnd = 1242477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayableGraph GetGraphHandle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGraphHandle_Private_PlayableGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PlayableGraph*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1242083, RefRangeEnd = 1242084, XrefRangeStart = 1242083, XrefRangeEnd = 1242084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPlayOnAwake(bool on)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&on);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPlayOnAwake_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1242077, RefRangeEnd = 1242078, XrefRangeStart = 1242077, XrefRangeEnd = 1242078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetPlayOnAwake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPlayOnAwake_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1242153, RefRangeEnd = 1242155, XrefRangeStart = 1242153, XrefRangeEnd = 1242155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Internal_SetGenericBinding(Object key, Object value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_SetGenericBinding_Private_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 1242027, RefRangeEnd = 1242044, XrefRangeStart = 1242027, XrefRangeEnd = 1242044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPlayableAsset(ScriptableObject asset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPlayableAsset_Private_Void_ScriptableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242477, XrefRangeEnd = 1242485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ScriptableObject Internal_GetPlayableAsset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_GetPlayableAsset_Private_ScriptableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr2) : null;
	}

	[SpecialName]
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1242490, RefRangeEnd = 1242495, XrefRangeStart = 1242485, XrefRangeEnd = 1242490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_played(Il2CppSystem.Action<PlayableDirector> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_played_Public_add_Void_Action_1_PlayableDirector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242495, XrefRangeEnd = 1242500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_played(Il2CppSystem.Action<PlayableDirector> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_played_Public_rem_Void_Action_1_PlayableDirector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1242505, RefRangeEnd = 1242507, XrefRangeStart = 1242500, XrefRangeEnd = 1242505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_paused(Il2CppSystem.Action<PlayableDirector> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_paused_Public_add_Void_Action_1_PlayableDirector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242507, XrefRangeEnd = 1242512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_paused(Il2CppSystem.Action<PlayableDirector> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_paused_Public_rem_Void_Action_1_PlayableDirector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 1242517, RefRangeEnd = 1242527, XrefRangeStart = 1242512, XrefRangeEnd = 1242517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_stopped(Il2CppSystem.Action<PlayableDirector> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_stopped_Public_add_Void_Action_1_PlayableDirector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1242532, RefRangeEnd = 1242534, XrefRangeStart = 1242527, XrefRangeEnd = 1242532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_stopped(Il2CppSystem.Action<PlayableDirector> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_stopped_Public_rem_Void_Action_1_PlayableDirector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void SendOnPlayableDirectorPlay()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendOnPlayableDirectorPlay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void SendOnPlayableDirectorPause()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendOnPlayableDirectorPause_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void SendOnPlayableDirectorStop()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendOnPlayableDirectorStop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(646)]
	[CachedScanResults(RefRangeStart = 1152221, RefRangeEnd = 1152867, XrefRangeStart = 1152221, XrefRangeEnd = 1152867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayableDirector()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242534, XrefRangeEnd = 1242536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_timeUpdateMode_Injected(System.IntPtr _unity_self, DirectorUpdateMode value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(DirectorUpdateMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_timeUpdateMode_Injected_Private_Static_Void_IntPtr_DirectorUpdateMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242536, XrefRangeEnd = 1242538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_time_Injected(System.IntPtr _unity_self, double value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_time_Injected_Private_Static_Void_IntPtr_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242538, XrefRangeEnd = 1242540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double get_time_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_time_Injected_Private_Static_Double_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242540, XrefRangeEnd = 1242542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double get_initialTime_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_initialTime_Injected_Private_Static_Double_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242542, XrefRangeEnd = 1242544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double get_duration_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_duration_Injected_Private_Static_Double_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242544, XrefRangeEnd = 1242546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Evaluate_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Evaluate_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242546, XrefRangeEnd = 1242548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PlayOnFrame_Injected(System.IntPtr _unity_self, [In] ref FrameRate frameRate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref frameRate);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayOnFrame_Injected_Private_Static_Void_IntPtr_byref_FrameRate_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242548, XrefRangeEnd = 1242550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Play_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242550, XrefRangeEnd = 1242552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Stop_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Stop_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242552, XrefRangeEnd = 1242554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Pause_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pause_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242554, XrefRangeEnd = 1242556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Resume_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Resume_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242556, XrefRangeEnd = 1242558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RebuildGraph_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RebuildGraph_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242558, XrefRangeEnd = 1242560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetReferenceValue_Injected(System.IntPtr _unity_self, [In] ref PropertyName id, out bool idValid)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref id);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref idValid);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetReferenceValue_Injected_Private_Static_IntPtr_IntPtr_byref_PropertyName_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242560, XrefRangeEnd = 1242562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetGenericBinding_Injected(System.IntPtr _unity_self, System.IntPtr key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &key;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGenericBinding_Injected_Private_Static_IntPtr_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242562, XrefRangeEnd = 1242564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearGenericBinding_Injected(System.IntPtr _unity_self, System.IntPtr key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &key;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearGenericBinding_Injected_Private_Static_Void_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242564, XrefRangeEnd = 1242566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PlayState GetPlayState_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPlayState_Injected_Private_Static_PlayState_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PlayState*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242566, XrefRangeEnd = 1242568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetWrapMode_Injected(System.IntPtr _unity_self, DirectorWrapMode mode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(DirectorWrapMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWrapMode_Injected_Private_Static_Void_IntPtr_DirectorWrapMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242568, XrefRangeEnd = 1242570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DirectorWrapMode GetWrapMode_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWrapMode_Injected_Private_Static_DirectorWrapMode_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DirectorWrapMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242570, XrefRangeEnd = 1242572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetGraphHandle_Injected(System.IntPtr _unity_self, out PlayableGraph ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGraphHandle_Injected_Private_Static_Void_IntPtr_byref_PlayableGraph_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242572, XrefRangeEnd = 1242574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetPlayOnAwake_Injected(System.IntPtr _unity_self, bool on)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &on;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPlayOnAwake_Injected_Private_Static_Void_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242574, XrefRangeEnd = 1242576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetPlayOnAwake_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPlayOnAwake_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242576, XrefRangeEnd = 1242578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_SetGenericBinding_Injected(System.IntPtr _unity_self, System.IntPtr key, System.IntPtr value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &key;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_SetGenericBinding_Injected_Private_Static_Void_IntPtr_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242578, XrefRangeEnd = 1242580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetPlayableAsset_Injected(System.IntPtr _unity_self, System.IntPtr asset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &asset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPlayableAsset_Injected_Private_Static_Void_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242580, XrefRangeEnd = 1242582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr Internal_GetPlayableAsset_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_GetPlayableAsset_Injected_Private_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public PlayableDirector(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void DeferredEvaluate()
	{
		EvaluateNextFrame();
	}

	public void ClearReferenceValue(PropertyName id)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		ClearReferenceValue_Injected(intPtr, ref id);
	}

	public void SetReferenceValue(PropertyName id, Object value)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetReferenceValue_Injected(intPtr, ref id, MarshalledUnityObject.Marshal(value));
	}

	public void RebindPlayableGraphOutputs()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		RebindPlayableGraphOutputs_Injected(intPtr);
	}

	public void ProcessPendingGraphChanges()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		ProcessPendingGraphChanges_Injected(intPtr);
	}

	public bool HasGenericBinding(Object key)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return HasGenericBinding_Injected(intPtr, MarshalledUnityObject.Marshal(key));
	}

	public void EvaluateNextFrame()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		EvaluateNextFrame_Injected(intPtr);
	}

	public static void ResetFrameTiming()
	{
		ResetFrameTimingDelegateField();
	}

	public static DirectorUpdateMode get_timeUpdateMode_Injected(System.IntPtr _unity_self)
	{
		return get_timeUpdateMode_InjectedDelegateField(_unity_self);
	}

	public static void set_initialTime_Injected(System.IntPtr _unity_self, double value)
	{
		set_initialTime_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void ClearReferenceValue_Injected(System.IntPtr _unity_self, [In] ref PropertyName id)
	{
		ClearReferenceValue_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref id));
	}

	public unsafe static void SetReferenceValue_Injected(System.IntPtr _unity_self, [In] ref PropertyName id, System.IntPtr value)
	{
		SetReferenceValue_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref id), value);
	}

	public static void RebindPlayableGraphOutputs_Injected(System.IntPtr _unity_self)
	{
		RebindPlayableGraphOutputs_InjectedDelegateField(_unity_self);
	}

	public static void ProcessPendingGraphChanges_Injected(System.IntPtr _unity_self)
	{
		ProcessPendingGraphChanges_InjectedDelegateField(_unity_self);
	}

	public static bool HasGenericBinding_Injected(System.IntPtr _unity_self, System.IntPtr key)
	{
		return HasGenericBinding_InjectedDelegateField(_unity_self, key);
	}

	public static void EvaluateNextFrame_Injected(System.IntPtr _unity_self)
	{
		EvaluateNextFrame_InjectedDelegateField(_unity_self);
	}
}
