using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.InputSystem.Controls;

namespace UnityEngine.InputSystem;

public class AmbientTemperatureSensor : Sensor
{
	private static readonly IntPtr NativeFieldInfoPtr__ambientTemperature_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__current_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_ambientTemperature_Public_get_AxisControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_ambientTemperature_Protected_set_Void_AxisControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_current_Public_Static_get_AmbientTemperatureSensor_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_current_Private_Static_set_Void_AmbientTemperatureSensor_0;

	private static readonly IntPtr NativeMethodInfoPtr_MakeCurrent_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnRemoved_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe AxisControl _ambientTemperature_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ambientTemperature_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AxisControl>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ambientTemperature_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static AmbientTemperatureSensor _current_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__current_k__BackingField, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<AmbientTemperatureSensor>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__current_k__BackingField, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe AxisControl ambientTemperature
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 392549, RefRangeEnd = 392550, XrefRangeStart = 392549, XrefRangeEnd = 392550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ambientTemperature_Public_get_AxisControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ambientTemperature_Protected_set_Void_AxisControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static AmbientTemperatureSensor current
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993220, XrefRangeEnd = 993222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_current_Public_Static_get_AmbientTemperatureSensor_0, (IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<AmbientTemperatureSensor>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993222, XrefRangeEnd = 993226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_current_Private_Static_set_Void_AmbientTemperatureSensor_0, (IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static AmbientTemperatureSensor()
	{
		Il2CppClassPointerStore<AmbientTemperatureSensor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem", "AmbientTemperatureSensor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmbientTemperatureSensor>.NativeClassPtr);
		NativeFieldInfoPtr__ambientTemperature_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTemperatureSensor>.NativeClassPtr, "<ambientTemperature>k__BackingField");
		NativeFieldInfoPtr__current_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTemperatureSensor>.NativeClassPtr, "<current>k__BackingField");
		NativeMethodInfoPtr_get_ambientTemperature_Public_get_AxisControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientTemperatureSensor>.NativeClassPtr, 100665877);
		NativeMethodInfoPtr_set_ambientTemperature_Protected_set_Void_AxisControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientTemperatureSensor>.NativeClassPtr, 100665878);
		NativeMethodInfoPtr_get_current_Public_Static_get_AmbientTemperatureSensor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientTemperatureSensor>.NativeClassPtr, 100665879);
		NativeMethodInfoPtr_set_current_Private_Static_set_Void_AmbientTemperatureSensor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientTemperatureSensor>.NativeClassPtr, 100665880);
		NativeMethodInfoPtr_MakeCurrent_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientTemperatureSensor>.NativeClassPtr, 100665881);
		NativeMethodInfoPtr_OnRemoved_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientTemperatureSensor>.NativeClassPtr, 100665882);
		NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientTemperatureSensor>.NativeClassPtr, 100665883);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientTemperatureSensor>.NativeClassPtr, 100665884);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993226, XrefRangeEnd = 993231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void MakeCurrent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_MakeCurrent_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993231, XrefRangeEnd = 993238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnRemoved()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnRemoved_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993238, XrefRangeEnd = 993245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	public unsafe AmbientTemperatureSensor()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbientTemperatureSensor>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AmbientTemperatureSensor(IntPtr pointer)
		: base(pointer)
	{
	}
}
