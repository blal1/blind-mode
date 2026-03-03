using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Diagnostics.CodeAnalysis;

public sealed class ExcludeFromCodeCoverageAttribute : Attribute
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static ExcludeFromCodeCoverageAttribute()
	{
		Il2CppClassPointerStore<ExcludeFromCodeCoverageAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Diagnostics.CodeAnalysis", "ExcludeFromCodeCoverageAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExcludeFromCodeCoverageAttribute>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExcludeFromCodeCoverageAttribute>.NativeClassPtr, 100664848);
	}

	[CallerCount(134)]
	[CachedScanResults(RefRangeStart = 24861, RefRangeEnd = 24995, XrefRangeStart = 24861, XrefRangeEnd = 24995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ExcludeFromCodeCoverageAttribute()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExcludeFromCodeCoverageAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ExcludeFromCodeCoverageAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
