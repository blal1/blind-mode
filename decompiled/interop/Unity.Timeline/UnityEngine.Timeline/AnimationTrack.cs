using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace UnityEngine.Timeline;

[System.Serializable]
public class AnimationTrack : TrackAsset
{
	public static class AnimationTrackUpgrade : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_ConvertRotationsToEuler_Public_Static_Void_AnimationTrack_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ConvertRootMotion_Public_Static_Void_AnimationTrack_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ConvertInfiniteTrack_Public_Static_Void_AnimationTrack_0;

		static AnimationTrackUpgrade()
		{
			Il2CppClassPointerStore<AnimationTrackUpgrade>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "AnimationTrackUpgrade");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationTrackUpgrade>.NativeClassPtr);
			NativeMethodInfoPtr_ConvertRotationsToEuler_Public_Static_Void_AnimationTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrackUpgrade>.NativeClassPtr, 100663453);
			NativeMethodInfoPtr_ConvertRootMotion_Public_Static_Void_AnimationTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrackUpgrade>.NativeClassPtr, 100663454);
			NativeMethodInfoPtr_ConvertInfiniteTrack_Public_Static_Void_AnimationTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrackUpgrade>.NativeClassPtr, 100663455);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135547, XrefRangeEnd = 1135551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConvertRotationsToEuler(AnimationTrack track)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)track);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertRotationsToEuler_Public_Static_Void_AnimationTrack_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135551, XrefRangeEnd = 1135555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConvertRootMotion(AnimationTrack track)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)track);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertRootMotion_Public_Static_Void_AnimationTrack_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135555, XrefRangeEnd = 1135558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConvertInfiniteTrack(AnimationTrack track)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)track);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertInfiniteTrack_Public_Static_Void_AnimationTrack_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public AnimationTrackUpgrade(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("UnityEngine.Timeline.AnimationTrack+<get_outputs>d__49")]
	public sealed class _get_outputs_d__49 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr___l__initialThreadId;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_Playables_PlayableBinding__get_Current_Private_Virtual_Final_New_get_PlayableBinding_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_Playables_PlayableBinding__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayableBinding_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		public unsafe int __1__state
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = value;
			}
		}

		public unsafe PlayableBinding __2__current
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current);
				return new PlayableBinding(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe int __l__initialThreadId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___l__initialThreadId);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___l__initialThreadId)) = value;
			}
		}

		public unsafe AnimationTrack __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationTrack>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe virtual PlayableBinding System_002ECollections_002EGeneric_002EIEnumerator_003CUnityEngine_002EPlayables_002EPlayableBinding_003E_002ECurrent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_Playables_PlayableBinding__get_Current_Private_Virtual_Final_New_get_PlayableBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new PlayableBinding(pointer);
			}
		}

		public unsafe virtual Il2CppSystem.Object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135563, XrefRangeEnd = 1135566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
		}

		static _get_outputs_d__49()
		{
			Il2CppClassPointerStore<_get_outputs_d__49>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "<get_outputs>d__49");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_get_outputs_d__49>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_get_outputs_d__49>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_get_outputs_d__49>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_get_outputs_d__49>.NativeClassPtr, "<>l__initialThreadId");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_get_outputs_d__49>.NativeClassPtr, "<>4__this");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_get_outputs_d__49>.NativeClassPtr, 100663456);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_get_outputs_d__49>.NativeClassPtr, 100663457);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_get_outputs_d__49>.NativeClassPtr, 100663458);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_Playables_PlayableBinding__get_Current_Private_Virtual_Final_New_get_PlayableBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_get_outputs_d__49>.NativeClassPtr, 100663459);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_get_outputs_d__49>.NativeClassPtr, 100663460);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_get_outputs_d__49>.NativeClassPtr, 100663461);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_Playables_PlayableBinding__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayableBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_get_outputs_d__49>.NativeClassPtr, 100663462);
			NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_get_outputs_d__49>.NativeClassPtr, 100663463);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _get_outputs_d__49(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_get_outputs_d__49>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&_003C_003E1__state);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(19883)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135558, XrefRangeEnd = 1135563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135566, XrefRangeEnd = 1135568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<PlayableBinding> System_Collections_Generic_IEnumerable_UnityEngine_Playables_PlayableBinding__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_Playables_PlayableBinding__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayableBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator<PlayableBinding>>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		public _get_outputs_d__49(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DefaultInfiniteClipName;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DefaultRecordableClipName;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InfiniteClipPreExtrapolation;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InfiniteClipPostExtrapolation;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InfiniteClipOffsetPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InfiniteClipOffsetEulerAngles;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InfiniteClipTimeOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InfiniteClipRemoveOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InfiniteClipApplyFootIK;

	private static readonly System.IntPtr NativeFieldInfoPtr_mInfiniteClipLoop;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MatchTargetFields;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Position;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_EulerAngles;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AvatarMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ApplyAvatarMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TrackOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InfiniteClip;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_CachedQueue;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OpenClipOffsetRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Rotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ApplyOffsets;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_rotation_Public_set_Void_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_eulerAngles_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_applyOffsets_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_applyOffsets_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_trackOffset_Public_get_TrackOffset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_trackOffset_Public_set_Void_TrackOffset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_matchTargetFields_Public_get_MatchTargetFields_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_matchTargetFields_Public_set_Void_MatchTargetFields_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_infiniteClip_Public_get_AnimationClip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_infiniteClip_Internal_set_Void_AnimationClip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_infiniteClipRemoveOffset_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_infiniteClipRemoveOffset_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_avatarMask_Public_get_AvatarMask_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_avatarMask_Public_set_Void_AvatarMask_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_applyAvatarMask_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_applyAvatarMask_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanCompileClips_Internal_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_outputs_Public_Virtual_get_IEnumerable_1_PlayableBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_inClipMode_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_infiniteClipOffsetPosition_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_infiniteClipOffsetPosition_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_infiniteClipOffsetRotation_Public_get_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_infiniteClipOffsetRotation_Public_set_Void_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_infiniteClipOffsetEulerAngles_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_infiniteClipOffsetEulerAngles_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_infiniteClipApplyFootIK_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_infiniteClipApplyFootIK_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_infiniteClipTimeOffset_Internal_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_infiniteClipTimeOffset_Internal_set_Void_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_infiniteClipPreExtrapolation_Public_get_ClipExtrapolation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_infiniteClipPreExtrapolation_Public_set_Void_ClipExtrapolation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_infiniteClipPostExtrapolation_Public_get_ClipExtrapolation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_infiniteClipPostExtrapolation_Public_set_Void_ClipExtrapolation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_infiniteClipLoop_Internal_get_LoopMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_infiniteClipLoop_Internal_set_Void_LoopMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetOffsets_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateClip_Public_TimelineClip_AnimationClip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInfiniteClip_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRecordableClip_Public_TimelineClip_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateClip_Protected_Virtual_Void_TimelineClip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateItemsHash_FamOrAssem_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateClipOffsets_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompileTrackPlayable_Private_Playable_PlayableGraph_AnimationTrack_GameObject_IntervalTree_1_RuntimeElement_AppliedOffsetMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnityEngine_Timeline_ILayerable_CreateLayerMixer_Private_Virtual_Final_New_Playable_PlayableGraph_GameObject_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateMixerPlayableGraph_Internal_Virtual_Playable_PlayableGraph_GameObject_IntervalTree_1_RuntimeElement_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultBlendCount_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AttachDefaultBlend_Private_Void_PlayableGraph_AnimationLayerMixerPlayable_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AttachOffsetPlayable_Private_Playable_PlayableGraph_Playable_Vector3_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RequiresMotionXPlayable_Private_Boolean_AppliedOffsetMode_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UsesAbsoluteMotion_Private_Static_Boolean_AppliedOffsetMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasController_Private_Boolean_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBinding_Internal_Animator_PlayableDirector_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateGroupMixer_Private_Static_AnimationLayerMixerPlayable_PlayableGraph_GameObject_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInfiniteTrackPlayable_Private_Playable_PlayableGraph_GameObject_IntervalTree_1_RuntimeElement_AppliedOffsetMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyTrackOffset_Private_Playable_PlayableGraph_Playable_GameObject_AppliedOffsetMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEvaluationTime_Internal_Virtual_Void_byref_Double_byref_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSequenceTime_Internal_Virtual_Void_byref_Double_byref_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AssignAnimationClip_Private_Void_TimelineClip_AnimationClip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GatherProperties_Public_Virtual_Void_PlayableDirector_IPropertyCollector_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAnimationClips_Private_Void_List_1_AnimationClip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOffsetMode_Private_AppliedOffsetMode_GameObject_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsRootTransformDisabledByMask_Private_Boolean_GameObject_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGenericRootNode_Private_Transform_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AnimatesRootTransform_Internal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindInHierarchyBreadthFirst_Private_Static_Transform_Transform_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_openClipOffsetPosition_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_openClipOffsetPosition_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_openClipOffsetRotation_Public_get_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_openClipOffsetRotation_Public_set_Void_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_openClipOffsetEulerAngles_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_openClipOffsetEulerAngles_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_openClipPreExtrapolation_Public_get_ClipExtrapolation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_openClipPreExtrapolation_Public_set_Void_ClipExtrapolation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_openClipPostExtrapolation_Public_get_ClipExtrapolation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_openClipPostExtrapolation_Public_set_Void_ClipExtrapolation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUpgradeFromVersion_Internal_Virtual_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static string k_DefaultInfiniteClipName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DefaultInfiniteClipName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DefaultInfiniteClipName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string k_DefaultRecordableClipName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DefaultRecordableClipName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DefaultRecordableClipName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe TimelineClip.ClipExtrapolation m_InfiniteClipPreExtrapolation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InfiniteClipPreExtrapolation);
			return *(TimelineClip.ClipExtrapolation*)num;
		}
		set
		{
			*(TimelineClip.ClipExtrapolation*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InfiniteClipPreExtrapolation)) = value;
		}
	}

	public unsafe TimelineClip.ClipExtrapolation m_InfiniteClipPostExtrapolation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InfiniteClipPostExtrapolation);
			return *(TimelineClip.ClipExtrapolation*)num;
		}
		set
		{
			*(TimelineClip.ClipExtrapolation*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InfiniteClipPostExtrapolation)) = value;
		}
	}

	public unsafe Vector3 m_InfiniteClipOffsetPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InfiniteClipOffsetPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InfiniteClipOffsetPosition)) = value;
		}
	}

	public unsafe Vector3 m_InfiniteClipOffsetEulerAngles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InfiniteClipOffsetEulerAngles);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InfiniteClipOffsetEulerAngles)) = value;
		}
	}

	public unsafe double m_InfiniteClipTimeOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InfiniteClipTimeOffset);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InfiniteClipTimeOffset)) = value;
		}
	}

	public unsafe bool m_InfiniteClipRemoveOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InfiniteClipRemoveOffset);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InfiniteClipRemoveOffset)) = value;
		}
	}

	public unsafe bool m_InfiniteClipApplyFootIK
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InfiniteClipApplyFootIK);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InfiniteClipApplyFootIK)) = value;
		}
	}

	public unsafe AnimationPlayableAsset.LoopMode mInfiniteClipLoop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mInfiniteClipLoop);
			return *(AnimationPlayableAsset.LoopMode*)num;
		}
		set
		{
			*(AnimationPlayableAsset.LoopMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mInfiniteClipLoop)) = value;
		}
	}

	public unsafe MatchTargetFields m_MatchTargetFields
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MatchTargetFields);
			return *(MatchTargetFields*)num;
		}
		set
		{
			*(MatchTargetFields*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MatchTargetFields)) = value;
		}
	}

	public unsafe Vector3 m_Position
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Position);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Position)) = value;
		}
	}

	public unsafe Vector3 m_EulerAngles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EulerAngles);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EulerAngles)) = value;
		}
	}

	public unsafe AvatarMask m_AvatarMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AvatarMask);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AvatarMask>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AvatarMask)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_ApplyAvatarMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ApplyAvatarMask);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ApplyAvatarMask)) = value;
		}
	}

	public unsafe TrackOffset m_TrackOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TrackOffset);
			return *(TrackOffset*)num;
		}
		set
		{
			*(TrackOffset*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TrackOffset)) = value;
		}
	}

	public unsafe AnimationClip m_InfiniteClip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InfiniteClip);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InfiniteClip)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Queue<Transform> s_CachedQueue
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_CachedQueue, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Queue<Transform>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_CachedQueue, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Quaternion m_OpenClipOffsetRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OpenClipOffsetRotation);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OpenClipOffsetRotation)) = value;
		}
	}

	public unsafe Quaternion m_Rotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Rotation);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Rotation)) = value;
		}
	}

	public unsafe bool m_ApplyOffsets
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ApplyOffsets);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ApplyOffsets)) = value;
		}
	}

	public unsafe Vector3 position
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_position_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Quaternion rotation
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135568, XrefRangeEnd = 1135569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135569, XrefRangeEnd = 1135571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_rotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3 eulerAngles
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_eulerAngles_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool applyOffsets
	{
		[CallerCount(143)]
		[CachedScanResults(RefRangeStart = 9, RefRangeEnd = 152, XrefRangeStart = 9, XrefRangeEnd = 152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_applyOffsets_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(19883)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_applyOffsets_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TrackOffset trackOffset
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_trackOffset_Public_get_TrackOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TrackOffset*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_trackOffset_Public_set_Void_TrackOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe MatchTargetFields matchTargetFields
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_matchTargetFields_Public_get_MatchTargetFields_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(MatchTargetFields*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135571, XrefRangeEnd = 1135575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_matchTargetFields_Public_set_Void_MatchTargetFields_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe AnimationClip infiniteClip
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_infiniteClip_Public_get_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_infiniteClip_Internal_set_Void_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool infiniteClipRemoveOffset
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_infiniteClipRemoveOffset_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_infiniteClipRemoveOffset_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe AvatarMask avatarMask
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_avatarMask_Public_get_AvatarMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AvatarMask>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_avatarMask_Public_set_Void_AvatarMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool applyAvatarMask
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_applyAvatarMask_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_applyAvatarMask_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe override IEnumerable<PlayableBinding> outputs
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135577, XrefRangeEnd = 1135583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_outputs_Public_Virtual_get_IEnumerable_1_PlayableBinding_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerable<PlayableBinding>>(intPtr2) : null;
		}
	}

	public unsafe bool inClipMode
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1135584, RefRangeEnd = 1135587, XrefRangeStart = 1135583, XrefRangeEnd = 1135584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inClipMode_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Vector3 infiniteClipOffsetPosition
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_infiniteClipOffsetPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_infiniteClipOffsetPosition_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Quaternion infiniteClipOffsetRotation
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135587, XrefRangeEnd = 1135588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_infiniteClipOffsetRotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135588, XrefRangeEnd = 1135590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_infiniteClipOffsetRotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3 infiniteClipOffsetEulerAngles
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_infiniteClipOffsetEulerAngles_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_infiniteClipOffsetEulerAngles_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool infiniteClipApplyFootIK
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_infiniteClipApplyFootIK_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_infiniteClipApplyFootIK_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe double infiniteClipTimeOffset
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_infiniteClipTimeOffset_Internal_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_infiniteClipTimeOffset_Internal_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TimelineClip.ClipExtrapolation infiniteClipPreExtrapolation
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 167261, RefRangeEnd = 167262, XrefRangeStart = 167261, XrefRangeEnd = 167262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_infiniteClipPreExtrapolation_Public_get_ClipExtrapolation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TimelineClip.ClipExtrapolation*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 483144, RefRangeEnd = 483151, XrefRangeStart = 483144, XrefRangeEnd = 483151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_infiniteClipPreExtrapolation_Public_set_Void_ClipExtrapolation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TimelineClip.ClipExtrapolation infiniteClipPostExtrapolation
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 51672, RefRangeEnd = 51673, XrefRangeStart = 51672, XrefRangeEnd = 51673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_infiniteClipPostExtrapolation_Public_get_ClipExtrapolation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TimelineClip.ClipExtrapolation*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_infiniteClipPostExtrapolation_Public_set_Void_ClipExtrapolation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe AnimationPlayableAsset.LoopMode infiniteClipLoop
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_infiniteClipLoop_Internal_get_LoopMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(AnimationPlayableAsset.LoopMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_infiniteClipLoop_Internal_set_Void_LoopMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3 openClipOffsetPosition
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_openClipOffsetPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_openClipOffsetPosition_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Quaternion openClipOffsetRotation
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_openClipOffsetRotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_openClipOffsetRotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3 openClipOffsetEulerAngles
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_openClipOffsetEulerAngles_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_openClipOffsetEulerAngles_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TimelineClip.ClipExtrapolation openClipPreExtrapolation
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 167261, RefRangeEnd = 167262, XrefRangeStart = 167261, XrefRangeEnd = 167262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_openClipPreExtrapolation_Public_get_ClipExtrapolation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TimelineClip.ClipExtrapolation*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 483144, RefRangeEnd = 483151, XrefRangeStart = 483144, XrefRangeEnd = 483151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_openClipPreExtrapolation_Public_set_Void_ClipExtrapolation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TimelineClip.ClipExtrapolation openClipPostExtrapolation
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 51672, RefRangeEnd = 51673, XrefRangeStart = 51672, XrefRangeEnd = 51673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_openClipPostExtrapolation_Public_get_ClipExtrapolation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TimelineClip.ClipExtrapolation*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_openClipPostExtrapolation_Public_set_Void_ClipExtrapolation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static AnimationTrack()
	{
		Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "AnimationTrack");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr);
		NativeFieldInfoPtr_k_DefaultInfiniteClipName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "k_DefaultInfiniteClipName");
		NativeFieldInfoPtr_k_DefaultRecordableClipName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "k_DefaultRecordableClipName");
		NativeFieldInfoPtr_m_InfiniteClipPreExtrapolation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "m_InfiniteClipPreExtrapolation");
		NativeFieldInfoPtr_m_InfiniteClipPostExtrapolation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "m_InfiniteClipPostExtrapolation");
		NativeFieldInfoPtr_m_InfiniteClipOffsetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "m_InfiniteClipOffsetPosition");
		NativeFieldInfoPtr_m_InfiniteClipOffsetEulerAngles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "m_InfiniteClipOffsetEulerAngles");
		NativeFieldInfoPtr_m_InfiniteClipTimeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "m_InfiniteClipTimeOffset");
		NativeFieldInfoPtr_m_InfiniteClipRemoveOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "m_InfiniteClipRemoveOffset");
		NativeFieldInfoPtr_m_InfiniteClipApplyFootIK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "m_InfiniteClipApplyFootIK");
		NativeFieldInfoPtr_mInfiniteClipLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "mInfiniteClipLoop");
		NativeFieldInfoPtr_m_MatchTargetFields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "m_MatchTargetFields");
		NativeFieldInfoPtr_m_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "m_Position");
		NativeFieldInfoPtr_m_EulerAngles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "m_EulerAngles");
		NativeFieldInfoPtr_m_AvatarMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "m_AvatarMask");
		NativeFieldInfoPtr_m_ApplyAvatarMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "m_ApplyAvatarMask");
		NativeFieldInfoPtr_m_TrackOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "m_TrackOffset");
		NativeFieldInfoPtr_m_InfiniteClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "m_InfiniteClip");
		NativeFieldInfoPtr_s_CachedQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "s_CachedQueue");
		NativeFieldInfoPtr_m_OpenClipOffsetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "m_OpenClipOffsetRotation");
		NativeFieldInfoPtr_m_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "m_Rotation");
		NativeFieldInfoPtr_m_ApplyOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, "m_ApplyOffsets");
		NativeMethodInfoPtr_get_position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663371);
		NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663372);
		NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663373);
		NativeMethodInfoPtr_set_rotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663374);
		NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663375);
		NativeMethodInfoPtr_set_eulerAngles_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663376);
		NativeMethodInfoPtr_get_applyOffsets_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663377);
		NativeMethodInfoPtr_set_applyOffsets_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663378);
		NativeMethodInfoPtr_get_trackOffset_Public_get_TrackOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663379);
		NativeMethodInfoPtr_set_trackOffset_Public_set_Void_TrackOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663380);
		NativeMethodInfoPtr_get_matchTargetFields_Public_get_MatchTargetFields_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663381);
		NativeMethodInfoPtr_set_matchTargetFields_Public_set_Void_MatchTargetFields_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663382);
		NativeMethodInfoPtr_get_infiniteClip_Public_get_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663383);
		NativeMethodInfoPtr_set_infiniteClip_Internal_set_Void_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663384);
		NativeMethodInfoPtr_get_infiniteClipRemoveOffset_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663385);
		NativeMethodInfoPtr_set_infiniteClipRemoveOffset_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663386);
		NativeMethodInfoPtr_get_avatarMask_Public_get_AvatarMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663387);
		NativeMethodInfoPtr_set_avatarMask_Public_set_Void_AvatarMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663388);
		NativeMethodInfoPtr_get_applyAvatarMask_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663389);
		NativeMethodInfoPtr_set_applyAvatarMask_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663390);
		NativeMethodInfoPtr_CanCompileClips_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663391);
		NativeMethodInfoPtr_get_outputs_Public_Virtual_get_IEnumerable_1_PlayableBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663392);
		NativeMethodInfoPtr_get_inClipMode_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663393);
		NativeMethodInfoPtr_get_infiniteClipOffsetPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663394);
		NativeMethodInfoPtr_set_infiniteClipOffsetPosition_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663395);
		NativeMethodInfoPtr_get_infiniteClipOffsetRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663396);
		NativeMethodInfoPtr_set_infiniteClipOffsetRotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663397);
		NativeMethodInfoPtr_get_infiniteClipOffsetEulerAngles_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663398);
		NativeMethodInfoPtr_set_infiniteClipOffsetEulerAngles_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663399);
		NativeMethodInfoPtr_get_infiniteClipApplyFootIK_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663400);
		NativeMethodInfoPtr_set_infiniteClipApplyFootIK_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663401);
		NativeMethodInfoPtr_get_infiniteClipTimeOffset_Internal_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663402);
		NativeMethodInfoPtr_set_infiniteClipTimeOffset_Internal_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663403);
		NativeMethodInfoPtr_get_infiniteClipPreExtrapolation_Public_get_ClipExtrapolation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663404);
		NativeMethodInfoPtr_set_infiniteClipPreExtrapolation_Public_set_Void_ClipExtrapolation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663405);
		NativeMethodInfoPtr_get_infiniteClipPostExtrapolation_Public_get_ClipExtrapolation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663406);
		NativeMethodInfoPtr_set_infiniteClipPostExtrapolation_Public_set_Void_ClipExtrapolation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663407);
		NativeMethodInfoPtr_get_infiniteClipLoop_Internal_get_LoopMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663408);
		NativeMethodInfoPtr_set_infiniteClipLoop_Internal_set_Void_LoopMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663409);
		NativeMethodInfoPtr_ResetOffsets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663410);
		NativeMethodInfoPtr_CreateClip_Public_TimelineClip_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663411);
		NativeMethodInfoPtr_CreateInfiniteClip_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663412);
		NativeMethodInfoPtr_CreateRecordableClip_Public_TimelineClip_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663413);
		NativeMethodInfoPtr_OnCreateClip_Protected_Virtual_Void_TimelineClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663414);
		NativeMethodInfoPtr_CalculateItemsHash_FamOrAssem_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663415);
		NativeMethodInfoPtr_UpdateClipOffsets_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663416);
		NativeMethodInfoPtr_CompileTrackPlayable_Private_Playable_PlayableGraph_AnimationTrack_GameObject_IntervalTree_1_RuntimeElement_AppliedOffsetMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663417);
		NativeMethodInfoPtr_UnityEngine_Timeline_ILayerable_CreateLayerMixer_Private_Virtual_Final_New_Playable_PlayableGraph_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663418);
		NativeMethodInfoPtr_CreateMixerPlayableGraph_Internal_Virtual_Playable_PlayableGraph_GameObject_IntervalTree_1_RuntimeElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663419);
		NativeMethodInfoPtr_GetDefaultBlendCount_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663420);
		NativeMethodInfoPtr_AttachDefaultBlend_Private_Void_PlayableGraph_AnimationLayerMixerPlayable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663421);
		NativeMethodInfoPtr_AttachOffsetPlayable_Private_Playable_PlayableGraph_Playable_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663422);
		NativeMethodInfoPtr_RequiresMotionXPlayable_Private_Boolean_AppliedOffsetMode_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663423);
		NativeMethodInfoPtr_UsesAbsoluteMotion_Private_Static_Boolean_AppliedOffsetMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663424);
		NativeMethodInfoPtr_HasController_Private_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663425);
		NativeMethodInfoPtr_GetBinding_Internal_Animator_PlayableDirector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663426);
		NativeMethodInfoPtr_CreateGroupMixer_Private_Static_AnimationLayerMixerPlayable_PlayableGraph_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663427);
		NativeMethodInfoPtr_CreateInfiniteTrackPlayable_Private_Playable_PlayableGraph_GameObject_IntervalTree_1_RuntimeElement_AppliedOffsetMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663428);
		NativeMethodInfoPtr_ApplyTrackOffset_Private_Playable_PlayableGraph_Playable_GameObject_AppliedOffsetMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663429);
		NativeMethodInfoPtr_GetEvaluationTime_Internal_Virtual_Void_byref_Double_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663430);
		NativeMethodInfoPtr_GetSequenceTime_Internal_Virtual_Void_byref_Double_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663431);
		NativeMethodInfoPtr_AssignAnimationClip_Private_Void_TimelineClip_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663432);
		NativeMethodInfoPtr_GatherProperties_Public_Virtual_Void_PlayableDirector_IPropertyCollector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663433);
		NativeMethodInfoPtr_GetAnimationClips_Private_Void_List_1_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663434);
		NativeMethodInfoPtr_GetOffsetMode_Private_AppliedOffsetMode_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663435);
		NativeMethodInfoPtr_IsRootTransformDisabledByMask_Private_Boolean_GameObject_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663436);
		NativeMethodInfoPtr_GetGenericRootNode_Private_Transform_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663437);
		NativeMethodInfoPtr_AnimatesRootTransform_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663438);
		NativeMethodInfoPtr_FindInHierarchyBreadthFirst_Private_Static_Transform_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663439);
		NativeMethodInfoPtr_get_openClipOffsetPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663440);
		NativeMethodInfoPtr_set_openClipOffsetPosition_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663441);
		NativeMethodInfoPtr_get_openClipOffsetRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663442);
		NativeMethodInfoPtr_set_openClipOffsetRotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663443);
		NativeMethodInfoPtr_get_openClipOffsetEulerAngles_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663444);
		NativeMethodInfoPtr_set_openClipOffsetEulerAngles_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663445);
		NativeMethodInfoPtr_get_openClipPreExtrapolation_Public_get_ClipExtrapolation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663446);
		NativeMethodInfoPtr_set_openClipPreExtrapolation_Public_set_Void_ClipExtrapolation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663447);
		NativeMethodInfoPtr_get_openClipPostExtrapolation_Public_get_ClipExtrapolation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663448);
		NativeMethodInfoPtr_set_openClipPostExtrapolation_Public_set_Void_ClipExtrapolation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663449);
		NativeMethodInfoPtr_OnUpgradeFromVersion_Internal_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663450);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr, 100663451);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135575, XrefRangeEnd = 1135577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool CanCompileClips()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CanCompileClips_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135590, XrefRangeEnd = 1135594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetOffsets()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetOffsets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135594, XrefRangeEnd = 1135602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TimelineClip CreateClip(AnimationClip clip)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clip);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateClip_Public_TimelineClip_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TimelineClip>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135602, XrefRangeEnd = 1135619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateInfiniteClip(string infiniteClipName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(infiniteClipName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInfiniteClip_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135619, XrefRangeEnd = 1135640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TimelineClip CreateRecordableClip(string animClipName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(animClipName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRecordableClip_Public_TimelineClip_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TimelineClip>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135640, XrefRangeEnd = 1135643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnCreateClip(TimelineClip clip)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clip);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnCreateClip_Protected_Virtual_Void_TimelineClip_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135643, XrefRangeEnd = 1135655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int CalculateItemsHash()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CalculateItemsHash_FamOrAssem_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateClipOffsets()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateClipOffsets_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1135706, RefRangeEnd = 1135707, XrefRangeStart = 1135655, XrefRangeEnd = 1135706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Playable CompileTrackPlayable(PlayableGraph graph, AnimationTrack track, GameObject go, IntervalTree<RuntimeElement> tree, AppliedOffsetMode mode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&graph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)track);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tree);
		*(AppliedOffsetMode**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileTrackPlayable_Private_Playable_PlayableGraph_AnimationTrack_GameObject_IntervalTree_1_RuntimeElement_AppliedOffsetMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Playable*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135707, XrefRangeEnd = 1135711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Playable UnityEngine_Timeline_ILayerable_CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&graph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnityEngine_Timeline_ILayerable_CreateLayerMixer_Private_Virtual_Final_New_Playable_PlayableGraph_GameObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Playable*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135711, XrefRangeEnd = 1135819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Playable CreateMixerPlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&graph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tree);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateMixerPlayableGraph_Internal_Virtual_Playable_PlayableGraph_GameObject_IntervalTree_1_RuntimeElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Playable*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(146)]
	[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetDefaultBlendCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefaultBlendCount_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AttachDefaultBlend(PlayableGraph graph, AnimationLayerMixerPlayable mixer, bool requireOffset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&graph);
		*(AnimationLayerMixerPlayable**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mixer;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &requireOffset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AttachDefaultBlend_Private_Void_PlayableGraph_AnimationLayerMixerPlayable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135819, XrefRangeEnd = 1135830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Playable AttachOffsetPlayable(PlayableGraph graph, Playable playable, Vector3 pos, Quaternion rot)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&graph);
		*(Playable**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &playable;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		*(Quaternion**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &rot;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AttachOffsetPlayable_Private_Playable_PlayableGraph_Playable_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Playable*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1135832, RefRangeEnd = 1135833, XrefRangeStart = 1135830, XrefRangeEnd = 1135832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool RequiresMotionXPlayable(AppliedOffsetMode mode, GameObject gameObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&mode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RequiresMotionXPlayable_Private_Boolean_AppliedOffsetMode_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool UsesAbsoluteMotion(AppliedOffsetMode mode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mode);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UsesAbsoluteMotion_Private_Static_Boolean_AppliedOffsetMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135833, XrefRangeEnd = 1135845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasController(GameObject gameObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasController_Private_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1135870, RefRangeEnd = 1135874, XrefRangeStart = 1135845, XrefRangeEnd = 1135870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Animator GetBinding(PlayableDirector director)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)director);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBinding_Internal_Animator_PlayableDirector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135874, XrefRangeEnd = 1135878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AnimationLayerMixerPlayable CreateGroupMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&graph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateGroupMixer_Private_Static_AnimationLayerMixerPlayable_PlayableGraph_GameObject_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AnimationLayerMixerPlayable*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1135915, RefRangeEnd = 1135916, XrefRangeStart = 1135878, XrefRangeEnd = 1135915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Playable CreateInfiniteTrackPlayable(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree, AppliedOffsetMode mode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&graph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tree);
		*(AppliedOffsetMode**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInfiniteTrackPlayable_Private_Playable_PlayableGraph_GameObject_IntervalTree_1_RuntimeElement_AppliedOffsetMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Playable*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1135929, RefRangeEnd = 1135931, XrefRangeStart = 1135916, XrefRangeEnd = 1135929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Playable ApplyTrackOffset(PlayableGraph graph, Playable root, GameObject go, AppliedOffsetMode mode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&graph);
		*(Playable**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &root;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		*(AppliedOffsetMode**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyTrackOffset_Private_Playable_PlayableGraph_Playable_GameObject_AppliedOffsetMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Playable*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135931, XrefRangeEnd = 1135938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void GetEvaluationTime(out double outStart, out double outDuration)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref outStart);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref outDuration);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetEvaluationTime_Internal_Virtual_Void_byref_Double_byref_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135938, XrefRangeEnd = 1135949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void GetSequenceTime(out double outStart, out double outDuration)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref outStart);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref outDuration);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetSequenceTime_Internal_Virtual_Void_byref_Double_byref_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1135980, RefRangeEnd = 1135982, XrefRangeStart = 1135949, XrefRangeEnd = 1135980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AssignAnimationClip(TimelineClip clip, AnimationClip animClip)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clip);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animClip);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AssignAnimationClip_Private_Void_TimelineClip_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)director);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)driver);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GatherProperties_Public_Virtual_Void_PlayableDirector_IPropertyCollector_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1136030, RefRangeEnd = 1136031, XrefRangeStart = 1135982, XrefRangeEnd = 1136030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetAnimationClips(List<AnimationClip> animClips)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animClips);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAnimationClips_Private_Void_List_1_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1136051, RefRangeEnd = 1136052, XrefRangeStart = 1136031, XrefRangeEnd = 1136051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AppliedOffsetMode GetOffsetMode(GameObject go, bool animatesRootTransform)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &animatesRootTransform;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOffsetMode_Private_AppliedOffsetMode_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AppliedOffsetMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1136088, RefRangeEnd = 1136091, XrefRangeStart = 1136052, XrefRangeEnd = 1136088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsRootTransformDisabledByMask(GameObject gameObject, Transform genericRootNode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)genericRootNode);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsRootTransformDisabledByMask_Private_Boolean_GameObject_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1136118, RefRangeEnd = 1136119, XrefRangeStart = 1136091, XrefRangeEnd = 1136118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Transform GetGenericRootNode(GameObject gameObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGenericRootNode_Private_Transform_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1136150, RefRangeEnd = 1136155, XrefRangeStart = 1136119, XrefRangeEnd = 1136150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AnimatesRootTransform()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AnimatesRootTransform_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1136185, RefRangeEnd = 1136186, XrefRangeStart = 1136155, XrefRangeEnd = 1136185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Transform FindInHierarchyBreadthFirst(Transform t, string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindInHierarchyBreadthFirst_Private_Static_Transform_Transform_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136186, XrefRangeEnd = 1136198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnUpgradeFromVersion(int oldVersion)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&oldVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnUpgradeFromVersion_Internal_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136198, XrefRangeEnd = 1136218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnimationTrack()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationTrack>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AnimationTrack(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
