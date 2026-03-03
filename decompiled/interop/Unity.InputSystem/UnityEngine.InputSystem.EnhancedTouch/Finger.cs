using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.InputSystem.LowLevel;

namespace UnityEngine.InputSystem.EnhancedTouch;

public class Finger : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__screen_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__index_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StateHistory;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_screen_Public_get_Touchscreen_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_index_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_screenPosition_Public_get_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lastTouch_Public_get_Touch_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_currentTouch_Public_get_Touch_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_touchHistory_Public_get_TouchHistory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Touchscreen_Int32_InputUpdateType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldRecordTouch_Private_Static_Boolean_InputControl_Double_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnTouchRecorded_Private_Void_Record_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindTouch_Private_Touch_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTouchHistory_Internal_TouchHistory_Touch_0;

	public unsafe Touchscreen _screen_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__screen_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Touchscreen>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__screen_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int _index_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__index_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__index_k__BackingField)) = value;
		}
	}

	public unsafe InputStateHistory<TouchState> m_StateHistory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StateHistory);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputStateHistory<TouchState>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StateHistory)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Touchscreen screen
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_screen_Public_get_Touchscreen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Touchscreen>(intPtr2) : null;
		}
	}

	public unsafe int index
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54510, RefRangeEnd = 54511, XrefRangeStart = 54510, XrefRangeEnd = 54511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_index_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isActive
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006395, XrefRangeEnd = 1006402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Vector2 screenPosition
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006402, XrefRangeEnd = 1006417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_screenPosition_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Touch lastTouch
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1006422, RefRangeEnd = 1006424, XrefRangeStart = 1006417, XrefRangeEnd = 1006422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lastTouch_Public_get_Touch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Touch(pointer);
		}
	}

	public unsafe Touch currentTouch
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1006452, RefRangeEnd = 1006454, XrefRangeStart = 1006424, XrefRangeEnd = 1006452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_currentTouch_Public_get_Touch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Touch(pointer);
		}
	}

	public unsafe TouchHistory touchHistory
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006454, XrefRangeEnd = 1006456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_touchHistory_Public_get_TouchHistory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new TouchHistory(pointer);
		}
	}

	static Finger()
	{
		Il2CppClassPointerStore<Finger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.EnhancedTouch", "Finger");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Finger>.NativeClassPtr);
		NativeFieldInfoPtr__screen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Finger>.NativeClassPtr, "<screen>k__BackingField");
		NativeFieldInfoPtr__index_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Finger>.NativeClassPtr, "<index>k__BackingField");
		NativeFieldInfoPtr_m_StateHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Finger>.NativeClassPtr, "m_StateHistory");
		NativeMethodInfoPtr_get_screen_Public_get_Touchscreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Finger>.NativeClassPtr, 100667081);
		NativeMethodInfoPtr_get_index_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Finger>.NativeClassPtr, 100667082);
		NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Finger>.NativeClassPtr, 100667083);
		NativeMethodInfoPtr_get_screenPosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Finger>.NativeClassPtr, 100667084);
		NativeMethodInfoPtr_get_lastTouch_Public_get_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Finger>.NativeClassPtr, 100667085);
		NativeMethodInfoPtr_get_currentTouch_Public_get_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Finger>.NativeClassPtr, 100667086);
		NativeMethodInfoPtr_get_touchHistory_Public_get_TouchHistory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Finger>.NativeClassPtr, 100667087);
		NativeMethodInfoPtr__ctor_Internal_Void_Touchscreen_Int32_InputUpdateType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Finger>.NativeClassPtr, 100667088);
		NativeMethodInfoPtr_ShouldRecordTouch_Private_Static_Boolean_InputControl_Double_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Finger>.NativeClassPtr, 100667089);
		NativeMethodInfoPtr_OnTouchRecorded_Private_Void_Record_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Finger>.NativeClassPtr, 100667090);
		NativeMethodInfoPtr_FindTouch_Private_Touch_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Finger>.NativeClassPtr, 100667091);
		NativeMethodInfoPtr_GetTouchHistory_Internal_TouchHistory_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Finger>.NativeClassPtr, 100667092);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1006507, RefRangeEnd = 1006508, XrefRangeStart = 1006456, XrefRangeEnd = 1006507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Finger(Touchscreen screen, int index, InputUpdateType updateMask)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Finger>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)screen);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(InputUpdateType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &updateMask;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Touchscreen_Int32_InputUpdateType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006508, XrefRangeEnd = 1006512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ShouldRecordTouch(InputControl control, double time, InputEventPtr eventPtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		*(InputEventPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &eventPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShouldRecordTouch_Private_Static_Boolean_InputControl_Double_InputEventPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006512, XrefRangeEnd = 1006538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnTouchRecorded(InputStateHistory.Record record)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)record));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnTouchRecorded_Private_Void_Record_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1006555, RefRangeEnd = 1006556, XrefRangeStart = 1006538, XrefRangeEnd = 1006555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Touch FindTouch(uint uniqueId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&uniqueId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindTouch_Private_Touch_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Touch(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1006588, RefRangeEnd = 1006589, XrefRangeStart = 1006556, XrefRangeEnd = 1006588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TouchHistory GetTouchHistory(Touch touch)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)touch));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTouchHistory_Internal_TouchHistory_Touch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new TouchHistory(pointer);
	}

	public Finger(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
