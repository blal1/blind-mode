using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.XR;

namespace Unity.XR.Oculus.Input;

public class OculusTouchController : XRControllerWithRumble
{
	private static readonly IntPtr NativeFieldInfoPtr__thumbstick_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__trigger_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__grip_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__primaryButton_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__secondaryButton_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__gripPressed_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__start_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__thumbstickClicked_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__primaryTouched_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__secondaryTouched_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__triggerTouched_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__triggerPressed_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__thumbstickTouched_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__deviceVelocity_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__deviceAngularVelocity_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__deviceAcceleration_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__deviceAngularAcceleration_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_thumbstick_Public_get_Vector2Control_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_thumbstick_Protected_set_Void_Vector2Control_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_trigger_Public_get_AxisControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_trigger_Protected_set_Void_AxisControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_grip_Public_get_AxisControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_grip_Protected_set_Void_AxisControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_primaryButton_Public_get_ButtonControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_primaryButton_Protected_set_Void_ButtonControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_secondaryButton_Public_get_ButtonControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_secondaryButton_Protected_set_Void_ButtonControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_gripPressed_Public_get_ButtonControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_gripPressed_Protected_set_Void_ButtonControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_start_Public_get_ButtonControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_start_Protected_set_Void_ButtonControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_thumbstickClicked_Public_get_ButtonControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_thumbstickClicked_Protected_set_Void_ButtonControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_primaryTouched_Public_get_ButtonControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_primaryTouched_Protected_set_Void_ButtonControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_secondaryTouched_Public_get_ButtonControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_secondaryTouched_Protected_set_Void_ButtonControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_triggerTouched_Public_get_AxisControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_triggerTouched_Protected_set_Void_AxisControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_triggerPressed_Public_get_ButtonControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_triggerPressed_Protected_set_Void_ButtonControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_thumbstickTouched_Public_get_ButtonControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_thumbstickTouched_Protected_set_Void_ButtonControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_deviceVelocity_Public_get_Vector3Control_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_deviceVelocity_Protected_set_Void_Vector3Control_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_deviceAngularVelocity_Public_get_Vector3Control_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_deviceAngularVelocity_Protected_set_Void_Vector3Control_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_deviceAcceleration_Public_get_Vector3Control_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_deviceAcceleration_Protected_set_Void_Vector3Control_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_deviceAngularAcceleration_Public_get_Vector3Control_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_deviceAngularAcceleration_Protected_set_Void_Vector3Control_0;

	private static readonly IntPtr NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Vector2Control _thumbstick_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__thumbstick_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Vector2Control>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__thumbstick_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe AxisControl _trigger_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__trigger_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AxisControl>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__trigger_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe AxisControl _grip_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__grip_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AxisControl>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__grip_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ButtonControl _primaryButton_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__primaryButton_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__primaryButton_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ButtonControl _secondaryButton_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__secondaryButton_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__secondaryButton_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ButtonControl _gripPressed_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__gripPressed_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__gripPressed_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ButtonControl _start_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__start_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__start_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ButtonControl _thumbstickClicked_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__thumbstickClicked_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__thumbstickClicked_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ButtonControl _primaryTouched_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__primaryTouched_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__primaryTouched_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ButtonControl _secondaryTouched_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__secondaryTouched_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__secondaryTouched_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe AxisControl _triggerTouched_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__triggerTouched_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AxisControl>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__triggerTouched_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ButtonControl _triggerPressed_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__triggerPressed_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__triggerPressed_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ButtonControl _thumbstickTouched_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__thumbstickTouched_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__thumbstickTouched_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Vector3Control _deviceVelocity_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__deviceVelocity_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Vector3Control>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__deviceVelocity_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Vector3Control _deviceAngularVelocity_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__deviceAngularVelocity_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Vector3Control>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__deviceAngularVelocity_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Vector3Control _deviceAcceleration_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__deviceAcceleration_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Vector3Control>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__deviceAcceleration_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Vector3Control _deviceAngularAcceleration_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__deviceAngularAcceleration_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Vector3Control>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__deviceAngularAcceleration_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Vector2Control thumbstick
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_thumbstick_Public_get_Vector2Control_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Vector2Control>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_thumbstick_Protected_set_Void_Vector2Control_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe AxisControl trigger
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_trigger_Public_get_AxisControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<AxisControl>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_trigger_Protected_set_Void_AxisControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe AxisControl grip
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_grip_Public_get_AxisControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<AxisControl>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_grip_Protected_set_Void_AxisControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ButtonControl primaryButton
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 392554, RefRangeEnd = 392564, XrefRangeStart = 392554, XrefRangeEnd = 392564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_primaryButton_Public_get_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_primaryButton_Protected_set_Void_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ButtonControl secondaryButton
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_secondaryButton_Public_get_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_secondaryButton_Protected_set_Void_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ButtonControl gripPressed
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_gripPressed_Public_get_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_gripPressed_Protected_set_Void_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ButtonControl start
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_start_Public_get_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_start_Protected_set_Void_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ButtonControl thumbstickClicked
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_thumbstickClicked_Public_get_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_thumbstickClicked_Protected_set_Void_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ButtonControl primaryTouched
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_primaryTouched_Public_get_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_primaryTouched_Protected_set_Void_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ButtonControl secondaryTouched
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_secondaryTouched_Public_get_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_secondaryTouched_Protected_set_Void_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe AxisControl triggerTouched
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_triggerTouched_Public_get_AxisControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<AxisControl>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_triggerTouched_Protected_set_Void_AxisControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ButtonControl triggerPressed
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_triggerPressed_Public_get_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_triggerPressed_Protected_set_Void_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ButtonControl thumbstickTouched
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_thumbstickTouched_Public_get_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_thumbstickTouched_Protected_set_Void_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3Control deviceVelocity
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_deviceVelocity_Public_get_Vector3Control_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_deviceVelocity_Protected_set_Void_Vector3Control_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3Control deviceAngularVelocity
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_deviceAngularVelocity_Public_get_Vector3Control_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_deviceAngularVelocity_Protected_set_Void_Vector3Control_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3Control deviceAcceleration
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_deviceAcceleration_Public_get_Vector3Control_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_deviceAcceleration_Protected_set_Void_Vector3Control_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3Control deviceAngularAcceleration
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_deviceAngularAcceleration_Public_get_Vector3Control_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_deviceAngularAcceleration_Protected_set_Void_Vector3Control_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static OculusTouchController()
	{
		Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "Unity.XR.Oculus.Input", "OculusTouchController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr);
		NativeFieldInfoPtr__thumbstick_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, "<thumbstick>k__BackingField");
		NativeFieldInfoPtr__trigger_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, "<trigger>k__BackingField");
		NativeFieldInfoPtr__grip_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, "<grip>k__BackingField");
		NativeFieldInfoPtr__primaryButton_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, "<primaryButton>k__BackingField");
		NativeFieldInfoPtr__secondaryButton_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, "<secondaryButton>k__BackingField");
		NativeFieldInfoPtr__gripPressed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, "<gripPressed>k__BackingField");
		NativeFieldInfoPtr__start_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, "<start>k__BackingField");
		NativeFieldInfoPtr__thumbstickClicked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, "<thumbstickClicked>k__BackingField");
		NativeFieldInfoPtr__primaryTouched_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, "<primaryTouched>k__BackingField");
		NativeFieldInfoPtr__secondaryTouched_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, "<secondaryTouched>k__BackingField");
		NativeFieldInfoPtr__triggerTouched_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, "<triggerTouched>k__BackingField");
		NativeFieldInfoPtr__triggerPressed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, "<triggerPressed>k__BackingField");
		NativeFieldInfoPtr__thumbstickTouched_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, "<thumbstickTouched>k__BackingField");
		NativeFieldInfoPtr__deviceVelocity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, "<deviceVelocity>k__BackingField");
		NativeFieldInfoPtr__deviceAngularVelocity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, "<deviceAngularVelocity>k__BackingField");
		NativeFieldInfoPtr__deviceAcceleration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, "<deviceAcceleration>k__BackingField");
		NativeFieldInfoPtr__deviceAngularAcceleration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, "<deviceAngularAcceleration>k__BackingField");
		NativeMethodInfoPtr_get_thumbstick_Public_get_Vector2Control_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, 100663435);
		NativeMethodInfoPtr_set_thumbstick_Protected_set_Void_Vector2Control_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, 100663436);
		NativeMethodInfoPtr_get_trigger_Public_get_AxisControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, 100663437);
		NativeMethodInfoPtr_set_trigger_Protected_set_Void_AxisControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, 100663438);
		NativeMethodInfoPtr_get_grip_Public_get_AxisControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, 100663439);
		NativeMethodInfoPtr_set_grip_Protected_set_Void_AxisControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, 100663440);
		NativeMethodInfoPtr_get_primaryButton_Public_get_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, 100663441);
		NativeMethodInfoPtr_set_primaryButton_Protected_set_Void_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, 100663442);
		NativeMethodInfoPtr_get_secondaryButton_Public_get_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, 100663443);
		NativeMethodInfoPtr_set_secondaryButton_Protected_set_Void_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, 100663444);
		NativeMethodInfoPtr_get_gripPressed_Public_get_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, 100663445);
		NativeMethodInfoPtr_set_gripPressed_Protected_set_Void_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, 100663446);
		NativeMethodInfoPtr_get_start_Public_get_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, 100663447);
		NativeMethodInfoPtr_set_start_Protected_set_Void_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, 100663448);
		NativeMethodInfoPtr_get_thumbstickClicked_Public_get_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, 100663449);
		NativeMethodInfoPtr_set_thumbstickClicked_Protected_set_Void_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, 100663450);
		NativeMethodInfoPtr_get_primaryTouched_Public_get_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, 100663451);
		NativeMethodInfoPtr_set_primaryTouched_Protected_set_Void_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, 100663452);
		NativeMethodInfoPtr_get_secondaryTouched_Public_get_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, 100663453);
		NativeMethodInfoPtr_set_secondaryTouched_Protected_set_Void_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, 100663454);
		NativeMethodInfoPtr_get_triggerTouched_Public_get_AxisControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, 100663455);
		NativeMethodInfoPtr_set_triggerTouched_Protected_set_Void_AxisControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, 100663456);
		NativeMethodInfoPtr_get_triggerPressed_Public_get_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, 100663457);
		NativeMethodInfoPtr_set_triggerPressed_Protected_set_Void_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, 100663458);
		NativeMethodInfoPtr_get_thumbstickTouched_Public_get_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, 100663459);
		NativeMethodInfoPtr_set_thumbstickTouched_Protected_set_Void_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, 100663460);
		NativeMethodInfoPtr_get_deviceVelocity_Public_get_Vector3Control_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, 100663461);
		NativeMethodInfoPtr_set_deviceVelocity_Protected_set_Void_Vector3Control_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, 100663462);
		NativeMethodInfoPtr_get_deviceAngularVelocity_Public_get_Vector3Control_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, 100663463);
		NativeMethodInfoPtr_set_deviceAngularVelocity_Protected_set_Void_Vector3Control_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, 100663464);
		NativeMethodInfoPtr_get_deviceAcceleration_Public_get_Vector3Control_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, 100663465);
		NativeMethodInfoPtr_set_deviceAcceleration_Protected_set_Void_Vector3Control_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, 100663466);
		NativeMethodInfoPtr_get_deviceAngularAcceleration_Public_get_Vector3Control_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, 100663467);
		NativeMethodInfoPtr_set_deviceAngularAcceleration_Protected_set_Void_Vector3Control_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, 100663468);
		NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, 100663469);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr, 100663470);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963183, XrefRangeEnd = 963273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void FinishSetup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OculusTouchController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OculusTouchController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public OculusTouchController(IntPtr pointer)
		: base(pointer)
	{
	}
}
