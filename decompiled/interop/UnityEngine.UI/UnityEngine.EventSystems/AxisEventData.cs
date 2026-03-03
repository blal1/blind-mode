using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems;

public class AxisEventData : BaseEventData
{
	private static readonly IntPtr NativeFieldInfoPtr__moveVector_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__moveDir_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_moveVector_Public_get_Vector2_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_moveVector_Public_set_Void_Vector2_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_moveDir_Public_get_MoveDirection_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_moveDir_Public_set_Void_MoveDirection_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0;

	public unsafe Vector2 _moveVector_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__moveVector_k__BackingField);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__moveVector_k__BackingField)) = value;
		}
	}

	public unsafe MoveDirection _moveDir_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__moveDir_k__BackingField);
			return *(MoveDirection*)num;
		}
		set
		{
			*(MoveDirection*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__moveDir_k__BackingField)) = value;
		}
	}

	public unsafe Vector2 moveVector
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_moveVector_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_moveVector_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe MoveDirection moveDir
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80842, RefRangeEnd = 80843, XrefRangeStart = 80842, XrefRangeEnd = 80843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_moveDir_Public_get_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(MoveDirection*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 84616, RefRangeEnd = 84621, XrefRangeStart = 84616, XrefRangeEnd = 84621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_moveDir_Public_set_Void_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static AxisEventData()
	{
		Il2CppClassPointerStore<AxisEventData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "AxisEventData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AxisEventData>.NativeClassPtr);
		NativeFieldInfoPtr__moveVector_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisEventData>.NativeClassPtr, "<moveVector>k__BackingField");
		NativeFieldInfoPtr__moveDir_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisEventData>.NativeClassPtr, "<moveDir>k__BackingField");
		NativeMethodInfoPtr_get_moveVector_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisEventData>.NativeClassPtr, 100664812);
		NativeMethodInfoPtr_set_moveVector_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisEventData>.NativeClassPtr, 100664813);
		NativeMethodInfoPtr_get_moveDir_Public_get_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisEventData>.NativeClassPtr, 100664814);
		NativeMethodInfoPtr_set_moveDir_Public_set_Void_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisEventData>.NativeClassPtr, 100664815);
		NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisEventData>.NativeClassPtr, 100664816);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1299724, RefRangeEnd = 1299726, XrefRangeStart = 1299720, XrefRangeEnd = 1299724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AxisEventData(EventSystem eventSystem)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AxisEventData>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventSystem);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AxisEventData(IntPtr pointer)
		: base(pointer)
	{
	}
}
