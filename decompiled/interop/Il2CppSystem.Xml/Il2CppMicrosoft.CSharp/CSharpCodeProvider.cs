using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppMicrosoft.CSharp;

public class CSharpCodeProvider : CodeDomProvider
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static CSharpCodeProvider()
	{
		Il2CppClassPointerStore<CSharpCodeProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "Microsoft.CSharp", "CSharpCodeProvider");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CSharpCodeProvider>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSharpCodeProvider>.NativeClassPtr, 100663300);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CSharpCodeProvider()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CSharpCodeProvider>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public CSharpCodeProvider(IntPtr pointer)
		: base(pointer)
	{
	}
}
