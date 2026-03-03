using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.InputSystem.Controls;

public class AnyKeyControl : ButtonControl
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ReadUnprocessedValueFromState_Public_Virtual_Single_ptr_Void_0;

	static AnyKeyControl()
	{
		Il2CppClassPointerStore<AnyKeyControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.Controls", "AnyKeyControl");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnyKeyControl>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnyKeyControl>.NativeClassPtr, 100668391);
		NativeMethodInfoPtr_ReadUnprocessedValueFromState_Public_Virtual_Single_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnyKeyControl>.NativeClassPtr, 100668392);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1014153, RefRangeEnd = 1014154, XrefRangeStart = 1014148, XrefRangeEnd = 1014153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnyKeyControl()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnyKeyControl>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014154, XrefRangeEnd = 1014155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override float ReadUnprocessedValueFromState(void* statePtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)statePtr;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ReadUnprocessedValueFromState_Public_Virtual_Single_ptr_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public AnyKeyControl(IntPtr pointer)
		: base(pointer)
	{
	}
}
