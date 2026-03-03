using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering;

public class CoreRPHelpURLAttribute : HelpURLAttribute
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0;

	static CoreRPHelpURLAttribute()
	{
		Il2CppClassPointerStore<CoreRPHelpURLAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "CoreRPHelpURLAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoreRPHelpURLAttribute>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreRPHelpURLAttribute>.NativeClassPtr, 100665249);
		NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreRPHelpURLAttribute>.NativeClassPtr, 100665250);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037456, XrefRangeEnd = 1037460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CoreRPHelpURLAttribute(string pageName, string packageName = "com.unity.render-pipelines.core")
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoreRPHelpURLAttribute>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(pageName);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(packageName);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1037462, RefRangeEnd = 1037463, XrefRangeStart = 1037460, XrefRangeEnd = 1037462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CoreRPHelpURLAttribute(string pageName, string pageHash, string packageName = "com.unity.render-pipelines.core")
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoreRPHelpURLAttribute>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(pageName);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pageHash);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(packageName);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public CoreRPHelpURLAttribute(IntPtr pointer)
		: base(pointer)
	{
	}
}
