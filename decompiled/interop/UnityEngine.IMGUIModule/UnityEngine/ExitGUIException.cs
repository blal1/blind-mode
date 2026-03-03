using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine;

public sealed class ExitGUIException : Il2CppSystem.Exception
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

	static ExitGUIException()
	{
		Il2CppClassPointerStore<ExitGUIException>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "ExitGUIException");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExitGUIException>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitGUIException>.NativeClassPtr, 100663748);
		NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitGUIException>.NativeClassPtr, 100663749);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1248292, RefRangeEnd = 1248293, XrefRangeStart = 1248280, XrefRangeEnd = 1248292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ExitGUIException()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExitGUIException>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248293, XrefRangeEnd = 1248305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ExitGUIException(string message)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExitGUIException>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ExitGUIException(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
