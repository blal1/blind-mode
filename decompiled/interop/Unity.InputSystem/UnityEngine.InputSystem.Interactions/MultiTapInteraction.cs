using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.InputSystem.Interactions;

public class MultiTapInteraction : Il2CppSystem.Object
{
	[OriginalName("Unity.InputSystem.dll", "", "TapPhase")]
	public enum TapPhase
	{
		None,
		WaitingForNextRelease,
		WaitingForNextPress
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_tapTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_tapDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_tapCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_pressPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentTapPhase;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentTapCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentTapStartTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LastTapReleaseTime;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_tapTimeOrDefault_Private_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_tapDelayOrDefault_Internal_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pressPointOrDefault_Private_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_releasePointOrDefault_Private_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Process_Public_Virtual_Final_New_Void_byref_InputInteractionContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float tapTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tapTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tapTime)) = value;
		}
	}

	public unsafe float tapDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tapDelay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tapDelay)) = value;
		}
	}

	public unsafe int tapCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tapCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tapCount)) = value;
		}
	}

	public unsafe float pressPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pressPoint);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pressPoint)) = value;
		}
	}

	public unsafe TapPhase m_CurrentTapPhase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentTapPhase);
			return *(TapPhase*)num;
		}
		set
		{
			*(TapPhase*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentTapPhase)) = value;
		}
	}

	public unsafe int m_CurrentTapCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentTapCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentTapCount)) = value;
		}
	}

	public unsafe double m_CurrentTapStartTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentTapStartTime);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentTapStartTime)) = value;
		}
	}

	public unsafe double m_LastTapReleaseTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LastTapReleaseTime);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LastTapReleaseTime)) = value;
		}
	}

	public unsafe float tapTimeOrDefault
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1015253, RefRangeEnd = 1015254, XrefRangeStart = 1015252, XrefRangeEnd = 1015253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_tapTimeOrDefault_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe float tapDelayOrDefault
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1015255, RefRangeEnd = 1015256, XrefRangeStart = 1015254, XrefRangeEnd = 1015255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_tapDelayOrDefault_Internal_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe float pressPointOrDefault
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1015257, RefRangeEnd = 1015258, XrefRangeStart = 1015256, XrefRangeEnd = 1015257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pressPointOrDefault_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe float releasePointOrDefault
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015258, XrefRangeEnd = 1015261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_releasePointOrDefault_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static MultiTapInteraction()
	{
		Il2CppClassPointerStore<MultiTapInteraction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.Interactions", "MultiTapInteraction");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiTapInteraction>.NativeClassPtr);
		NativeFieldInfoPtr_tapTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiTapInteraction>.NativeClassPtr, "tapTime");
		NativeFieldInfoPtr_tapDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiTapInteraction>.NativeClassPtr, "tapDelay");
		NativeFieldInfoPtr_tapCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiTapInteraction>.NativeClassPtr, "tapCount");
		NativeFieldInfoPtr_pressPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiTapInteraction>.NativeClassPtr, "pressPoint");
		NativeFieldInfoPtr_m_CurrentTapPhase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiTapInteraction>.NativeClassPtr, "m_CurrentTapPhase");
		NativeFieldInfoPtr_m_CurrentTapCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiTapInteraction>.NativeClassPtr, "m_CurrentTapCount");
		NativeFieldInfoPtr_m_CurrentTapStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiTapInteraction>.NativeClassPtr, "m_CurrentTapStartTime");
		NativeFieldInfoPtr_m_LastTapReleaseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiTapInteraction>.NativeClassPtr, "m_LastTapReleaseTime");
		NativeMethodInfoPtr_get_tapTimeOrDefault_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiTapInteraction>.NativeClassPtr, 100668546);
		NativeMethodInfoPtr_get_tapDelayOrDefault_Internal_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiTapInteraction>.NativeClassPtr, 100668547);
		NativeMethodInfoPtr_get_pressPointOrDefault_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiTapInteraction>.NativeClassPtr, 100668548);
		NativeMethodInfoPtr_get_releasePointOrDefault_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiTapInteraction>.NativeClassPtr, 100668549);
		NativeMethodInfoPtr_Process_Public_Virtual_Final_New_Void_byref_InputInteractionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiTapInteraction>.NativeClassPtr, 100668550);
		NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiTapInteraction>.NativeClassPtr, 100668551);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiTapInteraction>.NativeClassPtr, 100668552);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015261, XrefRangeEnd = 1015269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Process(ref InputInteractionContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Process_Public_Virtual_Final_New_Void_byref_InputInteractionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015269, XrefRangeEnd = 1015270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MultiTapInteraction()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiTapInteraction>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public MultiTapInteraction(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
