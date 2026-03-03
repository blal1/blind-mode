using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;

namespace Il2CppSpine;

public static class Json : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_Object_TextReader_0;

	static Json()
	{
		Il2CppClassPointerStore<Json>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-csharp.dll", "Spine", "Json");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Json>.NativeClassPtr);
		NativeMethodInfoPtr_Deserialize_Public_Static_Object_TextReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json>.NativeClassPtr, 100663884);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 843630, RefRangeEnd = 843631, XrefRangeStart = 843624, XrefRangeEnd = 843630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Object Deserialize(TextReader text)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)text);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deserialize_Public_Static_Object_TextReader_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	public Json(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
