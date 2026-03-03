using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2Cpp;

public class ColosseumInfoDialog : ColosseumDialog
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static ColosseumInfoDialog()
	{
		Il2CppClassPointerStore<ColosseumInfoDialog>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ColosseumInfoDialog");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColosseumInfoDialog>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColosseumInfoDialog>.NativeClassPtr, 100663558);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32480, XrefRangeEnd = 32481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ColosseumInfoDialog()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColosseumInfoDialog>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ColosseumInfoDialog(IntPtr pointer)
		: base(pointer)
	{
	}
}
