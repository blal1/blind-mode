using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.InputSystem.Controls;

public class DeltaControl : Vector2Control
{
	private static readonly IntPtr NativeFieldInfoPtr__up_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__down_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__left_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__right_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_up_Public_get_AxisControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_up_Public_set_Void_AxisControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_down_Public_get_AxisControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_down_Public_set_Void_AxisControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_left_Public_get_AxisControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_left_Public_set_Void_AxisControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_right_Public_get_AxisControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_right_Public_set_Void_AxisControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe AxisControl _up_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__up_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AxisControl>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__up_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe AxisControl _down_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__down_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AxisControl>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__down_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe AxisControl _left_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__left_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AxisControl>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__left_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe AxisControl _right_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__right_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AxisControl>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__right_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe AxisControl up
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_up_Public_get_AxisControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_up_Public_set_Void_AxisControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe AxisControl down
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_down_Public_get_AxisControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_down_Public_set_Void_AxisControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe AxisControl left
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_left_Public_get_AxisControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_left_Public_set_Void_AxisControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe AxisControl right
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_right_Public_get_AxisControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_right_Public_set_Void_AxisControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static DeltaControl()
	{
		Il2CppClassPointerStore<DeltaControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.Controls", "DeltaControl");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeltaControl>.NativeClassPtr);
		NativeFieldInfoPtr__up_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeltaControl>.NativeClassPtr, "<up>k__BackingField");
		NativeFieldInfoPtr__down_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeltaControl>.NativeClassPtr, "<down>k__BackingField");
		NativeFieldInfoPtr__left_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeltaControl>.NativeClassPtr, "<left>k__BackingField");
		NativeFieldInfoPtr__right_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeltaControl>.NativeClassPtr, "<right>k__BackingField");
		NativeMethodInfoPtr_get_up_Public_get_AxisControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeltaControl>.NativeClassPtr, 100668413);
		NativeMethodInfoPtr_set_up_Public_set_Void_AxisControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeltaControl>.NativeClassPtr, 100668414);
		NativeMethodInfoPtr_get_down_Public_get_AxisControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeltaControl>.NativeClassPtr, 100668415);
		NativeMethodInfoPtr_set_down_Public_set_Void_AxisControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeltaControl>.NativeClassPtr, 100668416);
		NativeMethodInfoPtr_get_left_Public_get_AxisControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeltaControl>.NativeClassPtr, 100668417);
		NativeMethodInfoPtr_set_left_Public_set_Void_AxisControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeltaControl>.NativeClassPtr, 100668418);
		NativeMethodInfoPtr_get_right_Public_get_AxisControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeltaControl>.NativeClassPtr, 100668419);
		NativeMethodInfoPtr_set_right_Public_set_Void_AxisControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeltaControl>.NativeClassPtr, 100668420);
		NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeltaControl>.NativeClassPtr, 100668421);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeltaControl>.NativeClassPtr, 100668422);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014482, XrefRangeEnd = 1014504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void FinishSetup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 1014505, RefRangeEnd = 1014519, XrefRangeStart = 1014504, XrefRangeEnd = 1014505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DeltaControl()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeltaControl>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public DeltaControl(IntPtr pointer)
		: base(pointer)
	{
	}
}
