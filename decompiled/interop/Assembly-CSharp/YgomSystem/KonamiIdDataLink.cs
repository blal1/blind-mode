using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace YgomSystem;

public class KonamiIdDataLink : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static KonamiIdDataLink()
	{
		Il2CppClassPointerStore<KonamiIdDataLink>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "YgomSystem", "KonamiIdDataLink");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KonamiIdDataLink>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KonamiIdDataLink>.NativeClassPtr, 100665427);
	}

	[CallerCount(1830)]
	[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 21395, XrefRangeStart = 19565, XrefRangeEnd = 21395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe KonamiIdDataLink()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KonamiIdDataLink>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public KonamiIdDataLink(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
