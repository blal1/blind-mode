using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.XR;

namespace Unity.XR.Oculus.Input;

public class OculusHMD : XRHMD
{
	private static readonly IntPtr NativeFieldInfoPtr__userPresence_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__deviceAngularVelocity_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__deviceAcceleration_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__deviceAngularAcceleration_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__leftEyeAngularVelocity_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__leftEyeAcceleration_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__leftEyeAngularAcceleration_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__rightEyeAngularVelocity_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__rightEyeAcceleration_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__rightEyeAngularAcceleration_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__centerEyeAngularVelocity_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__centerEyeAcceleration_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__centerEyeAngularAcceleration_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_userPresence_Public_get_ButtonControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_userPresence_Protected_set_Void_ButtonControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_deviceAngularVelocity_Public_get_Vector3Control_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_deviceAngularVelocity_Protected_set_Void_Vector3Control_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_deviceAcceleration_Public_get_Vector3Control_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_deviceAcceleration_Protected_set_Void_Vector3Control_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_deviceAngularAcceleration_Public_get_Vector3Control_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_deviceAngularAcceleration_Protected_set_Void_Vector3Control_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_leftEyeAngularVelocity_Public_get_Vector3Control_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_leftEyeAngularVelocity_Protected_set_Void_Vector3Control_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_leftEyeAcceleration_Public_get_Vector3Control_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_leftEyeAcceleration_Protected_set_Void_Vector3Control_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_leftEyeAngularAcceleration_Public_get_Vector3Control_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_leftEyeAngularAcceleration_Protected_set_Void_Vector3Control_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_rightEyeAngularVelocity_Public_get_Vector3Control_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_rightEyeAngularVelocity_Protected_set_Void_Vector3Control_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_rightEyeAcceleration_Public_get_Vector3Control_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_rightEyeAcceleration_Protected_set_Void_Vector3Control_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_rightEyeAngularAcceleration_Public_get_Vector3Control_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_rightEyeAngularAcceleration_Protected_set_Void_Vector3Control_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_centerEyeAngularVelocity_Public_get_Vector3Control_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_centerEyeAngularVelocity_Protected_set_Void_Vector3Control_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_centerEyeAcceleration_Public_get_Vector3Control_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_centerEyeAcceleration_Protected_set_Void_Vector3Control_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_centerEyeAngularAcceleration_Public_get_Vector3Control_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_centerEyeAngularAcceleration_Protected_set_Void_Vector3Control_0;

	private static readonly IntPtr NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ButtonControl _userPresence_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__userPresence_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__userPresence_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
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

	public unsafe Vector3Control _leftEyeAngularVelocity_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__leftEyeAngularVelocity_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Vector3Control>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__leftEyeAngularVelocity_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Vector3Control _leftEyeAcceleration_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__leftEyeAcceleration_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Vector3Control>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__leftEyeAcceleration_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Vector3Control _leftEyeAngularAcceleration_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__leftEyeAngularAcceleration_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Vector3Control>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__leftEyeAngularAcceleration_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Vector3Control _rightEyeAngularVelocity_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rightEyeAngularVelocity_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Vector3Control>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rightEyeAngularVelocity_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Vector3Control _rightEyeAcceleration_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rightEyeAcceleration_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Vector3Control>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rightEyeAcceleration_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Vector3Control _rightEyeAngularAcceleration_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rightEyeAngularAcceleration_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Vector3Control>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rightEyeAngularAcceleration_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Vector3Control _centerEyeAngularVelocity_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__centerEyeAngularVelocity_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Vector3Control>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__centerEyeAngularVelocity_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Vector3Control _centerEyeAcceleration_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__centerEyeAcceleration_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Vector3Control>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__centerEyeAcceleration_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Vector3Control _centerEyeAngularAcceleration_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__centerEyeAngularAcceleration_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Vector3Control>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__centerEyeAngularAcceleration_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ButtonControl userPresence
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_userPresence_Public_get_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_userPresence_Protected_set_Void_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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

	public unsafe Vector3Control leftEyeAngularVelocity
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_leftEyeAngularVelocity_Public_get_Vector3Control_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_leftEyeAngularVelocity_Protected_set_Void_Vector3Control_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3Control leftEyeAcceleration
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_leftEyeAcceleration_Public_get_Vector3Control_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_leftEyeAcceleration_Protected_set_Void_Vector3Control_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3Control leftEyeAngularAcceleration
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_leftEyeAngularAcceleration_Public_get_Vector3Control_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_leftEyeAngularAcceleration_Protected_set_Void_Vector3Control_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3Control rightEyeAngularVelocity
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rightEyeAngularVelocity_Public_get_Vector3Control_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_rightEyeAngularVelocity_Protected_set_Void_Vector3Control_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3Control rightEyeAcceleration
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rightEyeAcceleration_Public_get_Vector3Control_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_rightEyeAcceleration_Protected_set_Void_Vector3Control_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3Control rightEyeAngularAcceleration
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rightEyeAngularAcceleration_Public_get_Vector3Control_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_rightEyeAngularAcceleration_Protected_set_Void_Vector3Control_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3Control centerEyeAngularVelocity
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_centerEyeAngularVelocity_Public_get_Vector3Control_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_centerEyeAngularVelocity_Protected_set_Void_Vector3Control_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3Control centerEyeAcceleration
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_centerEyeAcceleration_Public_get_Vector3Control_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_centerEyeAcceleration_Protected_set_Void_Vector3Control_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3Control centerEyeAngularAcceleration
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_centerEyeAngularAcceleration_Public_get_Vector3Control_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_centerEyeAngularAcceleration_Protected_set_Void_Vector3Control_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static OculusHMD()
	{
		Il2CppClassPointerStore<OculusHMD>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "Unity.XR.Oculus.Input", "OculusHMD");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr);
		NativeFieldInfoPtr__userPresence_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, "<userPresence>k__BackingField");
		NativeFieldInfoPtr__deviceAngularVelocity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, "<deviceAngularVelocity>k__BackingField");
		NativeFieldInfoPtr__deviceAcceleration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, "<deviceAcceleration>k__BackingField");
		NativeFieldInfoPtr__deviceAngularAcceleration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, "<deviceAngularAcceleration>k__BackingField");
		NativeFieldInfoPtr__leftEyeAngularVelocity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, "<leftEyeAngularVelocity>k__BackingField");
		NativeFieldInfoPtr__leftEyeAcceleration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, "<leftEyeAcceleration>k__BackingField");
		NativeFieldInfoPtr__leftEyeAngularAcceleration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, "<leftEyeAngularAcceleration>k__BackingField");
		NativeFieldInfoPtr__rightEyeAngularVelocity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, "<rightEyeAngularVelocity>k__BackingField");
		NativeFieldInfoPtr__rightEyeAcceleration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, "<rightEyeAcceleration>k__BackingField");
		NativeFieldInfoPtr__rightEyeAngularAcceleration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, "<rightEyeAngularAcceleration>k__BackingField");
		NativeFieldInfoPtr__centerEyeAngularVelocity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, "<centerEyeAngularVelocity>k__BackingField");
		NativeFieldInfoPtr__centerEyeAcceleration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, "<centerEyeAcceleration>k__BackingField");
		NativeFieldInfoPtr__centerEyeAngularAcceleration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, "<centerEyeAngularAcceleration>k__BackingField");
		NativeMethodInfoPtr_get_userPresence_Public_get_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, 100663407);
		NativeMethodInfoPtr_set_userPresence_Protected_set_Void_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, 100663408);
		NativeMethodInfoPtr_get_deviceAngularVelocity_Public_get_Vector3Control_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, 100663409);
		NativeMethodInfoPtr_set_deviceAngularVelocity_Protected_set_Void_Vector3Control_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, 100663410);
		NativeMethodInfoPtr_get_deviceAcceleration_Public_get_Vector3Control_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, 100663411);
		NativeMethodInfoPtr_set_deviceAcceleration_Protected_set_Void_Vector3Control_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, 100663412);
		NativeMethodInfoPtr_get_deviceAngularAcceleration_Public_get_Vector3Control_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, 100663413);
		NativeMethodInfoPtr_set_deviceAngularAcceleration_Protected_set_Void_Vector3Control_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, 100663414);
		NativeMethodInfoPtr_get_leftEyeAngularVelocity_Public_get_Vector3Control_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, 100663415);
		NativeMethodInfoPtr_set_leftEyeAngularVelocity_Protected_set_Void_Vector3Control_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, 100663416);
		NativeMethodInfoPtr_get_leftEyeAcceleration_Public_get_Vector3Control_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, 100663417);
		NativeMethodInfoPtr_set_leftEyeAcceleration_Protected_set_Void_Vector3Control_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, 100663418);
		NativeMethodInfoPtr_get_leftEyeAngularAcceleration_Public_get_Vector3Control_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, 100663419);
		NativeMethodInfoPtr_set_leftEyeAngularAcceleration_Protected_set_Void_Vector3Control_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, 100663420);
		NativeMethodInfoPtr_get_rightEyeAngularVelocity_Public_get_Vector3Control_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, 100663421);
		NativeMethodInfoPtr_set_rightEyeAngularVelocity_Protected_set_Void_Vector3Control_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, 100663422);
		NativeMethodInfoPtr_get_rightEyeAcceleration_Public_get_Vector3Control_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, 100663423);
		NativeMethodInfoPtr_set_rightEyeAcceleration_Protected_set_Void_Vector3Control_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, 100663424);
		NativeMethodInfoPtr_get_rightEyeAngularAcceleration_Public_get_Vector3Control_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, 100663425);
		NativeMethodInfoPtr_set_rightEyeAngularAcceleration_Protected_set_Void_Vector3Control_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, 100663426);
		NativeMethodInfoPtr_get_centerEyeAngularVelocity_Public_get_Vector3Control_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, 100663427);
		NativeMethodInfoPtr_set_centerEyeAngularVelocity_Protected_set_Void_Vector3Control_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, 100663428);
		NativeMethodInfoPtr_get_centerEyeAcceleration_Public_get_Vector3Control_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, 100663429);
		NativeMethodInfoPtr_set_centerEyeAcceleration_Protected_set_Void_Vector3Control_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, 100663430);
		NativeMethodInfoPtr_get_centerEyeAngularAcceleration_Public_get_Vector3Control_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, 100663431);
		NativeMethodInfoPtr_set_centerEyeAngularAcceleration_Protected_set_Void_Vector3Control_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, 100663432);
		NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, 100663433);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr, 100663434);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 963182, RefRangeEnd = 963183, XrefRangeStart = 963114, XrefRangeEnd = 963182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	public unsafe OculusHMD()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OculusHMD>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public OculusHMD(IntPtr pointer)
		: base(pointer)
	{
	}
}
