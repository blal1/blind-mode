using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Xml.Schema;

public class Datatype_dateTimeTimeZone : Datatype_dateTimeBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

	static Datatype_dateTimeTimeZone()
	{
		Il2CppClassPointerStore<Datatype_dateTimeTimeZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_dateTimeTimeZone");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_dateTimeTimeZone>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_dateTimeTimeZone>.NativeClassPtr, 100666326);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923585, XrefRangeEnd = 923589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Datatype_dateTimeTimeZone()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_dateTimeTimeZone>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Datatype_dateTimeTimeZone(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
