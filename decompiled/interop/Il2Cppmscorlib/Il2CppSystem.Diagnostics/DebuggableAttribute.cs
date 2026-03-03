using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Diagnostics;

public sealed class DebuggableAttribute : Attribute
{
	[OriginalName("mscorlib.dll", "", "DebuggingModes")]
	[System.Flags]
	public enum DebuggingModes
	{
		None = 0,
		Default = 1,
		DisableOptimizations = 0x100,
		IgnoreSymbolStoreSequencePoints = 2,
		EnableEditAndContinue = 4
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_debuggingModes;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_DebuggingModes_0;

	public unsafe DebuggingModes m_debuggingModes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_debuggingModes);
			return *(DebuggingModes*)num;
		}
		set
		{
			*(DebuggingModes*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_debuggingModes)) = value;
		}
	}

	static DebuggableAttribute()
	{
		Il2CppClassPointerStore<DebuggableAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics", "DebuggableAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebuggableAttribute>.NativeClassPtr);
		NativeFieldInfoPtr_m_debuggingModes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebuggableAttribute>.NativeClassPtr, "m_debuggingModes");
		NativeMethodInfoPtr__ctor_Public_Void_DebuggingModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggableAttribute>.NativeClassPtr, 100673321);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 166660, RefRangeEnd = 166661, XrefRangeStart = 166660, XrefRangeEnd = 166661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DebuggableAttribute(DebuggingModes modes)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebuggableAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&modes);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_DebuggingModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public DebuggableAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
