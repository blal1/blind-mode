using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Remoting;

public class FormatterData : ProviderData
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static FormatterData()
	{
		Il2CppClassPointerStore<FormatterData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "FormatterData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormatterData>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterData>.NativeClassPtr, 100669882);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 791229, RefRangeEnd = 791233, XrefRangeStart = 791229, XrefRangeEnd = 791233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FormatterData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormatterData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public FormatterData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
