using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppInternal.Runtime.Augments;

public class ReflectionExecutionDomainCallbacks : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_CreateMissingMetadataException_Internal_Exception_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static ReflectionExecutionDomainCallbacks()
	{
		Il2CppClassPointerStore<ReflectionExecutionDomainCallbacks>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Internal.Runtime.Augments", "ReflectionExecutionDomainCallbacks");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionExecutionDomainCallbacks>.NativeClassPtr);
		NativeMethodInfoPtr_CreateMissingMetadataException_Internal_Exception_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionExecutionDomainCallbacks>.NativeClassPtr, 100663865);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionExecutionDomainCallbacks>.NativeClassPtr, 100663866);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701219, XrefRangeEnd = 701223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Exception CreateMissingMetadataException(Il2CppSystem.Type attributeType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attributeType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateMissingMetadataException_Internal_Exception_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Exception>(intPtr2) : null;
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReflectionExecutionDomainCallbacks()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionExecutionDomainCallbacks>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ReflectionExecutionDomainCallbacks(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
