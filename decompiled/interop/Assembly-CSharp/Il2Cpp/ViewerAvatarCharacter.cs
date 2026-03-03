using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2Cpp;

public class ViewerAvatarCharacter : Character
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static ViewerAvatarCharacter()
	{
		Il2CppClassPointerStore<ViewerAvatarCharacter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ViewerAvatarCharacter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ViewerAvatarCharacter>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewerAvatarCharacter>.NativeClassPtr, 100663299);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24995, XrefRangeEnd = 25013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ViewerAvatarCharacter()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ViewerAvatarCharacter>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ViewerAvatarCharacter(IntPtr pointer)
		: base(pointer)
	{
	}
}
