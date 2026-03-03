using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.EventSystems;

namespace UnityEngine.InputSystem.UI;

public class ExtendedSubmitCancelEventData : BaseEventData
{
	private static readonly IntPtr NativeFieldInfoPtr__device_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_device_Public_Virtual_Final_New_get_InputDevice_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_device_Public_set_Void_InputDevice_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0;

	public unsafe InputDevice _device_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__device_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InputDevice>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__device_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe virtual InputDevice device
	{
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 32112, RefRangeEnd = 32148, XrefRangeStart = 32112, XrefRangeEnd = 32148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_device_Public_Virtual_Final_New_get_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<InputDevice>(intPtr2) : null;
		}
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 32149, RefRangeEnd = 32159, XrefRangeStart = 32149, XrefRangeEnd = 32159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_device_Public_set_Void_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static ExtendedSubmitCancelEventData()
	{
		Il2CppClassPointerStore<ExtendedSubmitCancelEventData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.UI", "ExtendedSubmitCancelEventData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExtendedSubmitCancelEventData>.NativeClassPtr);
		NativeFieldInfoPtr__device_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedSubmitCancelEventData>.NativeClassPtr, "<device>k__BackingField");
		NativeMethodInfoPtr_get_device_Public_Virtual_Final_New_get_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedSubmitCancelEventData>.NativeClassPtr, 100666707);
		NativeMethodInfoPtr_set_device_Public_set_Void_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedSubmitCancelEventData>.NativeClassPtr, 100666708);
		NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedSubmitCancelEventData>.NativeClassPtr, 100666709);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 273889, RefRangeEnd = 273903, XrefRangeStart = 273889, XrefRangeEnd = 273903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ExtendedSubmitCancelEventData(EventSystem eventSystem)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExtendedSubmitCancelEventData>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventSystem);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ExtendedSubmitCancelEventData(IntPtr pointer)
		: base(pointer)
	{
	}
}
