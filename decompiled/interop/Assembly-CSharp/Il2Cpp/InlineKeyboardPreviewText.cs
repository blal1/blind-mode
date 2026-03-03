using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.EventSystems;

namespace Il2Cpp;

public class InlineKeyboardPreviewText : UIBehaviour
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static InlineKeyboardPreviewText()
	{
		Il2CppClassPointerStore<InlineKeyboardPreviewText>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "InlineKeyboardPreviewText");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InlineKeyboardPreviewText>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InlineKeyboardPreviewText>.NativeClassPtr, 100664088);
	}

	[CallerCount(39)]
	[CachedScanResults(RefRangeStart = 38937, RefRangeEnd = 38976, XrefRangeStart = 38936, XrefRangeEnd = 38937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InlineKeyboardPreviewText()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InlineKeyboardPreviewText>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public InlineKeyboardPreviewText(IntPtr pointer)
		: base(pointer)
	{
	}
}
