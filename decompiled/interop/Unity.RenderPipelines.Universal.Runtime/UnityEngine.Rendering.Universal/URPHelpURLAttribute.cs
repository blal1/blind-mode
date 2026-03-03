using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering.Universal;

public class URPHelpURLAttribute : CoreRPHelpURLAttribute
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

	static URPHelpURLAttribute()
	{
		Il2CppClassPointerStore<URPHelpURLAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "URPHelpURLAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<URPHelpURLAttribute>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<URPHelpURLAttribute>.NativeClassPtr, 100664481);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086402, XrefRangeEnd = 1086405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe URPHelpURLAttribute(string pageName, string pageHash = "")
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<URPHelpURLAttribute>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(pageName);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pageHash);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public URPHelpURLAttribute(IntPtr pointer)
		: base(pointer)
	{
	}
}
