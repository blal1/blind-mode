using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppYgomGame.Menu;

namespace Il2Cpp;

public class _SoloModeViewController : BaseMenuViewController
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static _SoloModeViewController()
	{
		Il2CppClassPointerStore<_SoloModeViewController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "_SoloModeViewController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_SoloModeViewController>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_SoloModeViewController>.NativeClassPtr, 100663437);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 25362, RefRangeEnd = 25379, XrefRangeStart = 25362, XrefRangeEnd = 25379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe _SoloModeViewController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_SoloModeViewController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public _SoloModeViewController(IntPtr pointer)
		: base(pointer)
	{
	}
}
