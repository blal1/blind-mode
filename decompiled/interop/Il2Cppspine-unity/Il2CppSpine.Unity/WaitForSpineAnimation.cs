using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSpine.Unity;

public class WaitForSpineAnimation : Il2CppSystem.Object
{
	[OriginalName("spine-unity.dll", "", "AnimationEventTypes")]
	[System.Flags]
	public enum AnimationEventTypes
	{
		Start = 1,
		Interrupt = 2,
		End = 4,
		Dispose = 8,
		Complete = 0x10
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_WasFired;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_TrackEntry_AnimationEventTypes_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NowWaitFor_Public_WaitForSpineAnimation_TrackEntry_AnimationEventTypes_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SafeSubscribe_Protected_Void_TrackEntry_AnimationEventTypes_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleComplete_Private_Void_TrackEntry_0;

	public unsafe bool m_WasFired
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WasFired);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WasFired)) = value;
		}
	}

	public unsafe virtual Il2CppSystem.Object System_002ECollections_002EIEnumerator_002ECurrent
	{
		[CallerCount(146)]
		[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	static WaitForSpineAnimation()
	{
		Il2CppClassPointerStore<WaitForSpineAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-unity.dll", "Spine.Unity", "WaitForSpineAnimation");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForSpineAnimation>.NativeClassPtr);
		NativeFieldInfoPtr_m_WasFired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForSpineAnimation>.NativeClassPtr, "m_WasFired");
		NativeMethodInfoPtr__ctor_Public_Void_TrackEntry_AnimationEventTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSpineAnimation>.NativeClassPtr, 100664172);
		NativeMethodInfoPtr_NowWaitFor_Public_WaitForSpineAnimation_TrackEntry_AnimationEventTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSpineAnimation>.NativeClassPtr, 100664173);
		NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSpineAnimation>.NativeClassPtr, 100664174);
		NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSpineAnimation>.NativeClassPtr, 100664175);
		NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSpineAnimation>.NativeClassPtr, 100664176);
		NativeMethodInfoPtr_SafeSubscribe_Protected_Void_TrackEntry_AnimationEventTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSpineAnimation>.NativeClassPtr, 100664177);
		NativeMethodInfoPtr_HandleComplete_Private_Void_TrackEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSpineAnimation>.NativeClassPtr, 100664178);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857934, XrefRangeEnd = 857936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WaitForSpineAnimation(TrackEntry trackEntry, AnimationEventTypes eventsToWaitFor)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForSpineAnimation>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)trackEntry);
		*(AnimationEventTypes**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &eventsToWaitFor;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_TrackEntry_AnimationEventTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857936, XrefRangeEnd = 857937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WaitForSpineAnimation NowWaitFor(TrackEntry trackEntry, AnimationEventTypes eventsToWaitFor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)trackEntry);
		*(AnimationEventTypes**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &eventsToWaitFor;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NowWaitFor_Public_WaitForSpineAnimation_TrackEntry_AnimationEventTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<WaitForSpineAnimation>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857937, XrefRangeEnd = 857938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool System_Collections_IEnumerator_MoveNext()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 216196, RefRangeEnd = 216200, XrefRangeStart = 216196, XrefRangeEnd = 216200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void System_Collections_IEnumerator_Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 857967, RefRangeEnd = 857973, XrefRangeStart = 857938, XrefRangeEnd = 857967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SafeSubscribe(TrackEntry trackEntry, AnimationEventTypes eventsToWaitFor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)trackEntry);
		*(AnimationEventTypes**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &eventsToWaitFor;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SafeSubscribe_Protected_Void_TrackEntry_AnimationEventTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 82714, RefRangeEnd = 82717, XrefRangeStart = 82714, XrefRangeEnd = 82717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleComplete(TrackEntry trackEntry)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)trackEntry);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleComplete_Private_Void_TrackEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public WaitForSpineAnimation(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
