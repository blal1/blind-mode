using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Controls;

public class IntegerControl : InputControl<int>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ReadUnprocessedValueFromState_Public_Virtual_Int32_ptr_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_WriteValueIntoState_Public_Virtual_Void_Int32_ptr_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CalculateOptimizedControlDataType_Protected_Virtual_FourCC_0;

	static IntegerControl()
	{
		Il2CppClassPointerStore<IntegerControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.Controls", "IntegerControl");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntegerControl>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerControl>.NativeClassPtr, 100668449);
		NativeMethodInfoPtr_ReadUnprocessedValueFromState_Public_Virtual_Int32_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerControl>.NativeClassPtr, 100668450);
		NativeMethodInfoPtr_WriteValueIntoState_Public_Virtual_Void_Int32_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerControl>.NativeClassPtr, 100668451);
		NativeMethodInfoPtr_CalculateOptimizedControlDataType_Protected_Virtual_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerControl>.NativeClassPtr, 100668452);
	}

	[CallerCount(37)]
	[CachedScanResults(RefRangeStart = 1014779, RefRangeEnd = 1014816, XrefRangeStart = 1014772, XrefRangeEnd = 1014779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IntegerControl()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntegerControl>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014816, XrefRangeEnd = 1014821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int ReadUnprocessedValueFromState(void* statePtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)statePtr;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ReadUnprocessedValueFromState_Public_Virtual_Int32_ptr_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014821, XrefRangeEnd = 1014827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void WriteValueIntoState(int value, void* statePtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&value);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = statePtr;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_WriteValueIntoState_Public_Virtual_Void_Int32_ptr_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014827, XrefRangeEnd = 1014837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override FourCC CalculateOptimizedControlDataType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CalculateOptimizedControlDataType_Protected_Virtual_FourCC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public IntegerControl(IntPtr pointer)
		: base(pointer)
	{
	}
}
