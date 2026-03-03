using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.InputSystem.Controls;

namespace UnityEngine.InputSystem;

public class TrackedDevice : InputDevice
{
	private static readonly IntPtr NativeFieldInfoPtr__trackingState_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__isTracked_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__devicePosition_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__deviceRotation_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_trackingState_Public_get_IntegerControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_trackingState_Protected_set_Void_IntegerControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_isTracked_Public_get_ButtonControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_isTracked_Protected_set_Void_ButtonControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_devicePosition_Public_get_Vector3Control_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_devicePosition_Protected_set_Void_Vector3Control_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_deviceRotation_Public_get_QuaternionControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_deviceRotation_Protected_set_Void_QuaternionControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe IntegerControl _trackingState_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__trackingState_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IntegerControl>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__trackingState_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ButtonControl _isTracked_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isTracked_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isTracked_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Vector3Control _devicePosition_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__devicePosition_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Vector3Control>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__devicePosition_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe QuaternionControl _deviceRotation_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__deviceRotation_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<QuaternionControl>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__deviceRotation_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe IntegerControl trackingState
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 392549, RefRangeEnd = 392550, XrefRangeStart = 392549, XrefRangeEnd = 392550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_trackingState_Public_get_IntegerControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<IntegerControl>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_trackingState_Protected_set_Void_IntegerControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ButtonControl isTracked
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 392551, RefRangeEnd = 392553, XrefRangeStart = 392551, XrefRangeEnd = 392553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isTracked_Public_get_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isTracked_Protected_set_Void_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3Control devicePosition
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_devicePosition_Public_get_Vector3Control_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Vector3Control>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_devicePosition_Protected_set_Void_Vector3Control_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe QuaternionControl deviceRotation
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_deviceRotation_Public_get_QuaternionControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<QuaternionControl>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_deviceRotation_Protected_set_Void_QuaternionControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static TrackedDevice()
	{
		Il2CppClassPointerStore<TrackedDevice>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem", "TrackedDevice");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackedDevice>.NativeClassPtr);
		NativeFieldInfoPtr__trackingState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedDevice>.NativeClassPtr, "<trackingState>k__BackingField");
		NativeFieldInfoPtr__isTracked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedDevice>.NativeClassPtr, "<isTracked>k__BackingField");
		NativeFieldInfoPtr__devicePosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedDevice>.NativeClassPtr, "<devicePosition>k__BackingField");
		NativeFieldInfoPtr__deviceRotation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedDevice>.NativeClassPtr, "<deviceRotation>k__BackingField");
		NativeMethodInfoPtr_get_trackingState_Public_get_IntegerControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedDevice>.NativeClassPtr, 100665923);
		NativeMethodInfoPtr_set_trackingState_Protected_set_Void_IntegerControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedDevice>.NativeClassPtr, 100665924);
		NativeMethodInfoPtr_get_isTracked_Public_get_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedDevice>.NativeClassPtr, 100665925);
		NativeMethodInfoPtr_set_isTracked_Protected_set_Void_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedDevice>.NativeClassPtr, 100665926);
		NativeMethodInfoPtr_get_devicePosition_Public_get_Vector3Control_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedDevice>.NativeClassPtr, 100665927);
		NativeMethodInfoPtr_set_devicePosition_Protected_set_Void_Vector3Control_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedDevice>.NativeClassPtr, 100665928);
		NativeMethodInfoPtr_get_deviceRotation_Public_get_QuaternionControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedDevice>.NativeClassPtr, 100665929);
		NativeMethodInfoPtr_set_deviceRotation_Protected_set_Void_QuaternionControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedDevice>.NativeClassPtr, 100665930);
		NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedDevice>.NativeClassPtr, 100665931);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedDevice>.NativeClassPtr, 100665932);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 993624, RefRangeEnd = 993629, XrefRangeStart = 993551, XrefRangeEnd = 993624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void FinishSetup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 963305, RefRangeEnd = 963314, XrefRangeStart = 963305, XrefRangeEnd = 963314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TrackedDevice()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackedDevice>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TrackedDevice(IntPtr pointer)
		: base(pointer)
	{
	}
}
