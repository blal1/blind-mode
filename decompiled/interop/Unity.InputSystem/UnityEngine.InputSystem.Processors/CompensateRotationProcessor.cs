using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.InputSystem.Processors;

public class CompensateRotationProcessor : InputProcessor<Quaternion>
{
	private static readonly IntPtr NativeMethodInfoPtr_Process_Public_Virtual_Quaternion_Quaternion_InputControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_cachingPolicy_Public_Virtual_get_CachingPolicy_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe override CachingPolicy cachingPolicy
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 63528, RefRangeEnd = 63535, XrefRangeStart = 63528, XrefRangeEnd = 63535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_cachingPolicy_Public_Virtual_get_CachingPolicy_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(CachingPolicy*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static CompensateRotationProcessor()
	{
		Il2CppClassPointerStore<CompensateRotationProcessor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.Processors", "CompensateRotationProcessor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompensateRotationProcessor>.NativeClassPtr);
		NativeMethodInfoPtr_Process_Public_Virtual_Quaternion_Quaternion_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompensateRotationProcessor>.NativeClassPtr, 100667988);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompensateRotationProcessor>.NativeClassPtr, 100667989);
		NativeMethodInfoPtr_get_cachingPolicy_Public_Virtual_get_CachingPolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompensateRotationProcessor>.NativeClassPtr, 100667990);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompensateRotationProcessor>.NativeClassPtr, 100667991);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1010825, XrefRangeEnd = 1010838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Quaternion Process(Quaternion value, InputControl control)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&value);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Process_Public_Virtual_Quaternion_Quaternion_InputControl_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1010838, XrefRangeEnd = 1010840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1010840, XrefRangeEnd = 1010843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CompensateRotationProcessor()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompensateRotationProcessor>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public CompensateRotationProcessor(IntPtr pointer)
		: base(pointer)
	{
	}
}
