using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.IntegerTime;

namespace UnityEngine.InputForUI;

public class NavigationEventRepeatHelper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_ConsecutiveMoveCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LastDirection;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PrevActionTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InitialRepeatDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ConsecutiveRepeatDelay;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldSendMoveEvent_Public_Boolean_DiscreteTime_Direction_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int m_ConsecutiveMoveCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ConsecutiveMoveCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ConsecutiveMoveCount)) = value;
		}
	}

	public unsafe NavigationEvent.Direction m_LastDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LastDirection);
			return *(NavigationEvent.Direction*)num;
		}
		set
		{
			*(NavigationEvent.Direction*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LastDirection)) = value;
		}
	}

	public unsafe DiscreteTime m_PrevActionTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PrevActionTime);
			return *(DiscreteTime*)num;
		}
		set
		{
			*(DiscreteTime*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PrevActionTime)) = value;
		}
	}

	public unsafe DiscreteTime m_InitialRepeatDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InitialRepeatDelay);
			return *(DiscreteTime*)num;
		}
		set
		{
			*(DiscreteTime*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InitialRepeatDelay)) = value;
		}
	}

	public unsafe DiscreteTime m_ConsecutiveRepeatDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ConsecutiveRepeatDelay);
			return *(DiscreteTime*)num;
		}
		set
		{
			*(DiscreteTime*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ConsecutiveRepeatDelay)) = value;
		}
	}

	static NavigationEventRepeatHelper()
	{
		Il2CppClassPointerStore<NavigationEventRepeatHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputForUIModule.dll", "UnityEngine.InputForUI", "NavigationEventRepeatHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationEventRepeatHelper>.NativeClassPtr);
		NativeFieldInfoPtr_m_ConsecutiveMoveCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationEventRepeatHelper>.NativeClassPtr, "m_ConsecutiveMoveCount");
		NativeFieldInfoPtr_m_LastDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationEventRepeatHelper>.NativeClassPtr, "m_LastDirection");
		NativeFieldInfoPtr_m_PrevActionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationEventRepeatHelper>.NativeClassPtr, "m_PrevActionTime");
		NativeFieldInfoPtr_m_InitialRepeatDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationEventRepeatHelper>.NativeClassPtr, "m_InitialRepeatDelay");
		NativeFieldInfoPtr_m_ConsecutiveRepeatDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationEventRepeatHelper>.NativeClassPtr, "m_ConsecutiveRepeatDelay");
		NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationEventRepeatHelper>.NativeClassPtr, 100663507);
		NativeMethodInfoPtr_ShouldSendMoveEvent_Public_Boolean_DiscreteTime_Direction_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationEventRepeatHelper>.NativeClassPtr, 100663508);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationEventRepeatHelper>.NativeClassPtr, 100663509);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252371, XrefRangeEnd = 1252375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1252383, RefRangeEnd = 1252384, XrefRangeStart = 1252375, XrefRangeEnd = 1252383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ShouldSendMoveEvent(DiscreteTime timestamp, NavigationEvent.Direction direction, bool axisButtonsWherePressedThisFrame)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&timestamp);
		*(NavigationEvent.Direction**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisButtonsWherePressedThisFrame;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShouldSendMoveEvent_Public_Boolean_DiscreteTime_Direction_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1252393, RefRangeEnd = 1252394, XrefRangeStart = 1252384, XrefRangeEnd = 1252393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NavigationEventRepeatHelper()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationEventRepeatHelper>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public NavigationEventRepeatHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
