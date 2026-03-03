using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine;

public class AndroidJavaClass : AndroidJavaObject
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr__AndroidJavaClass_Private_Void_String_0;

	static AndroidJavaClass()
	{
		Il2CppClassPointerStore<AndroidJavaClass>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AndroidJNIModule.dll", "UnityEngine", "AndroidJavaClass");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidJavaClass>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaClass>.NativeClassPtr, 100663344);
		NativeMethodInfoPtr__AndroidJavaClass_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaClass>.NativeClassPtr, 100663345);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1149371, RefRangeEnd = 1149376, XrefRangeStart = 1149348, XrefRangeEnd = 1149371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AndroidJavaClass(string className)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidJavaClass>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(className);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149376, XrefRangeEnd = 1149398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _AndroidJavaClass(string className)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(className);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AndroidJavaClass_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AndroidJavaClass(IntPtr pointer)
		: base(pointer)
	{
	}
}
