using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppMicrosoft.CSharp;

public class CodeDomProvider : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static CodeDomProvider()
	{
		Il2CppClassPointerStore<CodeDomProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "Microsoft.CSharp", "CodeDomProvider");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodeDomProvider>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeDomProvider>.NativeClassPtr, 100663299);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CodeDomProvider()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CodeDomProvider>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public CodeDomProvider(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
