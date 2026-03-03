using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.Audio;

public class AudioMixer : Object
{
	private delegate System.IntPtr get_outputAudioMixerGroup_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_outputAudioMixerGroup_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate void TransitionToSnapshots_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr snapshots, System.IntPtr weights, float timeToReach);

	private delegate AudioMixerUpdateMode get_updateMode_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_updateMode_InjectedDelegate(System.IntPtr _unity_self, AudioMixerUpdateMode value);

	private delegate bool ClearFloat_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr name);

	private delegate bool GetFloat_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr name, [Out] System.IntPtr value);

	private delegate float GetAbsoluteAudibilityFromGroup_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr group);

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindSnapshot_Public_AudioMixerSnapshot_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindMatchingGroups_Public_Il2CppReferenceArray_1_AudioMixerGroup_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransitionToSnapshot_Internal_Void_AudioMixerSnapshot_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransitionToSnapshotInternal_Private_Void_AudioMixerSnapshot_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFloat_Public_Boolean_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindSnapshot_Injected_Private_Static_IntPtr_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindMatchingGroups_Injected_Private_Static_Il2CppReferenceArray_1_AudioMixerGroup_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransitionToSnapshotInternal_Injected_Private_Static_Void_IntPtr_IntPtr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFloat_Injected_Private_Static_Boolean_IntPtr_byref_ManagedSpanWrapper_Single_0;

	private static readonly get_outputAudioMixerGroup_InjectedDelegate get_outputAudioMixerGroup_InjectedDelegateField;

	private static readonly set_outputAudioMixerGroup_InjectedDelegate set_outputAudioMixerGroup_InjectedDelegateField;

	private static readonly TransitionToSnapshots_InjectedDelegate TransitionToSnapshots_InjectedDelegateField;

	private static readonly get_updateMode_InjectedDelegate get_updateMode_InjectedDelegateField;

	private static readonly set_updateMode_InjectedDelegate set_updateMode_InjectedDelegateField;

	private static readonly ClearFloat_InjectedDelegate ClearFloat_InjectedDelegateField;

	private static readonly GetFloat_InjectedDelegate GetFloat_InjectedDelegateField;

	private static readonly GetAbsoluteAudibilityFromGroup_InjectedDelegate GetAbsoluteAudibilityFromGroup_InjectedDelegateField;

	public AudioMixerGroup outputAudioMixerGroup
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<AudioMixerGroup>(get_outputAudioMixerGroup_Injected(intPtr));
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_outputAudioMixerGroup_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public AudioMixerUpdateMode updateMode
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_updateMode_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_updateMode_Injected(intPtr, value);
		}
	}

	static AudioMixer()
	{
		Il2CppClassPointerStore<AudioMixer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine.Audio", "AudioMixer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioMixer>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixer>.NativeClassPtr, 100663429);
		NativeMethodInfoPtr_FindSnapshot_Public_AudioMixerSnapshot_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixer>.NativeClassPtr, 100663430);
		NativeMethodInfoPtr_FindMatchingGroups_Public_Il2CppReferenceArray_1_AudioMixerGroup_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixer>.NativeClassPtr, 100663431);
		NativeMethodInfoPtr_TransitionToSnapshot_Internal_Void_AudioMixerSnapshot_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixer>.NativeClassPtr, 100663432);
		NativeMethodInfoPtr_TransitionToSnapshotInternal_Private_Void_AudioMixerSnapshot_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixer>.NativeClassPtr, 100663433);
		NativeMethodInfoPtr_SetFloat_Public_Boolean_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixer>.NativeClassPtr, 100663434);
		NativeMethodInfoPtr_FindSnapshot_Injected_Private_Static_IntPtr_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixer>.NativeClassPtr, 100663435);
		NativeMethodInfoPtr_FindMatchingGroups_Injected_Private_Static_Il2CppReferenceArray_1_AudioMixerGroup_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixer>.NativeClassPtr, 100663436);
		NativeMethodInfoPtr_TransitionToSnapshotInternal_Injected_Private_Static_Void_IntPtr_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixer>.NativeClassPtr, 100663437);
		NativeMethodInfoPtr_SetFloat_Injected_Private_Static_Boolean_IntPtr_byref_ManagedSpanWrapper_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixer>.NativeClassPtr, 100663438);
		get_outputAudioMixerGroup_InjectedDelegateField = IL2CPP.ResolveICall<get_outputAudioMixerGroup_InjectedDelegate>("UnityEngine.Audio.AudioMixer::get_outputAudioMixerGroup_Injected");
		set_outputAudioMixerGroup_InjectedDelegateField = IL2CPP.ResolveICall<set_outputAudioMixerGroup_InjectedDelegate>("UnityEngine.Audio.AudioMixer::set_outputAudioMixerGroup_Injected");
		TransitionToSnapshots_InjectedDelegateField = IL2CPP.ResolveICall<TransitionToSnapshots_InjectedDelegate>("UnityEngine.Audio.AudioMixer::TransitionToSnapshots_Injected");
		get_updateMode_InjectedDelegateField = IL2CPP.ResolveICall<get_updateMode_InjectedDelegate>("UnityEngine.Audio.AudioMixer::get_updateMode_Injected");
		set_updateMode_InjectedDelegateField = IL2CPP.ResolveICall<set_updateMode_InjectedDelegate>("UnityEngine.Audio.AudioMixer::set_updateMode_Injected");
		ClearFloat_InjectedDelegateField = IL2CPP.ResolveICall<ClearFloat_InjectedDelegate>("UnityEngine.Audio.AudioMixer::ClearFloat_Injected");
		GetFloat_InjectedDelegateField = IL2CPP.ResolveICall<GetFloat_InjectedDelegate>("UnityEngine.Audio.AudioMixer::GetFloat_Injected");
		GetAbsoluteAudibilityFromGroup_InjectedDelegateField = IL2CPP.ResolveICall<GetAbsoluteAudibilityFromGroup_InjectedDelegate>("UnityEngine.Audio.AudioMixer::GetAbsoluteAudibilityFromGroup_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163432, XrefRangeEnd = 1163436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioMixer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioMixer>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1163456, RefRangeEnd = 1163457, XrefRangeStart = 1163436, XrefRangeEnd = 1163456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioMixerSnapshot FindSnapshot(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindSnapshot_Public_AudioMixerSnapshot_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioMixerSnapshot>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1163473, RefRangeEnd = 1163474, XrefRangeStart = 1163457, XrefRangeEnd = 1163473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<AudioMixerGroup> FindMatchingGroups(string subPath)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(subPath);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindMatchingGroups_Public_Il2CppReferenceArray_1_AudioMixerGroup_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioMixerGroup>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1163529, RefRangeEnd = 1163530, XrefRangeStart = 1163474, XrefRangeEnd = 1163529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TransitionToSnapshot(AudioMixerSnapshot snapshot, float timeToReach)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)snapshot);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &timeToReach;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransitionToSnapshot_Internal_Void_AudioMixerSnapshot_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163530, XrefRangeEnd = 1163538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TransitionToSnapshotInternal(AudioMixerSnapshot snapshot, float timeToReach)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)snapshot);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &timeToReach;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransitionToSnapshotInternal_Private_Void_AudioMixerSnapshot_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1163554, RefRangeEnd = 1163555, XrefRangeStart = 1163538, XrefRangeEnd = 1163554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SetFloat(string name, float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFloat_Public_Boolean_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163555, XrefRangeEnd = 1163557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr FindSnapshot_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindSnapshot_Injected_Private_Static_IntPtr_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163557, XrefRangeEnd = 1163559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<AudioMixerGroup> FindMatchingGroups_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper subPath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref subPath);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindMatchingGroups_Injected_Private_Static_Il2CppReferenceArray_1_AudioMixerGroup_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioMixerGroup>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163559, XrefRangeEnd = 1163561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TransitionToSnapshotInternal_Injected(System.IntPtr _unity_self, System.IntPtr snapshot, float timeToReach)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &snapshot;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &timeToReach;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransitionToSnapshotInternal_Injected_Private_Static_Void_IntPtr_IntPtr_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163561, XrefRangeEnd = 1163563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetFloat_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper name, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref name);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFloat_Injected_Private_Static_Boolean_IntPtr_byref_ManagedSpanWrapper_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public AudioMixer(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public unsafe void TransitionToSnapshots(Il2CppReferenceArray<AudioMixerSnapshot> snapshots, Il2CppStructArray<float> weights, float timeToReach)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0020: Expected O, but got Ref
		//IL_002c: Expected O, but got Ref
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<float> span);
		((Il2CppSystem.Span<float>)(&span))._002Ector((Il2CppArrayBase<float>)(object)weights);
		fixed (float* begin = &((Il2CppSystem.Span<float>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper weights2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<float>)(&span)).Length);
			TransitionToSnapshots_Injected(intPtr, snapshots, ref weights2, timeToReach);
		}
	}

	public unsafe bool ClearFloat(string name)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(name);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return ClearFloat_Injected(intPtr, ref managedSpanWrapper);
				}
			}
			return ClearFloat_Injected(intPtr, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe bool GetFloat(string name, out float value)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(name);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return GetFloat_Injected(intPtr, ref managedSpanWrapper, out value);
				}
			}
			return GetFloat_Injected(intPtr, ref managedSpanWrapper, out value);
		}
		finally
		{
		}
	}

	public float GetAbsoluteAudibilityFromGroup(AudioMixerGroup group)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetAbsoluteAudibilityFromGroup_Injected(intPtr, MarshalledUnityObject.Marshal(group));
	}

	public static System.IntPtr get_outputAudioMixerGroup_Injected(System.IntPtr _unity_self)
	{
		return get_outputAudioMixerGroup_InjectedDelegateField(_unity_self);
	}

	public static void set_outputAudioMixerGroup_Injected(System.IntPtr _unity_self, System.IntPtr value)
	{
		set_outputAudioMixerGroup_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void TransitionToSnapshots_Injected(System.IntPtr _unity_self, Il2CppReferenceArray<AudioMixerSnapshot> snapshots, ref ManagedSpanWrapper weights, float timeToReach)
	{
		TransitionToSnapshots_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)snapshots), (nint)Unsafe.AsPointer(ref weights), timeToReach);
	}

	public static AudioMixerUpdateMode get_updateMode_Injected(System.IntPtr _unity_self)
	{
		return get_updateMode_InjectedDelegateField(_unity_self);
	}

	public static void set_updateMode_Injected(System.IntPtr _unity_self, AudioMixerUpdateMode value)
	{
		set_updateMode_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static bool ClearFloat_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper name)
	{
		return ClearFloat_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref name));
	}

	public unsafe static bool GetFloat_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper name, out float value)
	{
		return GetFloat_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref name), (nint)Unsafe.AsPointer(ref value));
	}

	public static float GetAbsoluteAudibilityFromGroup_Injected(System.IntPtr _unity_self, System.IntPtr group)
	{
		return GetAbsoluteAudibilityFromGroup_InjectedDelegateField(_unity_self, group);
	}
}
