using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Diagnostics;

public sealed class DebuggerBrowsableAttribute : Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr_state;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_DebuggerBrowsableState_0;

	public unsafe DebuggerBrowsableState state
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_state);
			return *(DebuggerBrowsableState*)num;
		}
		set
		{
			*(DebuggerBrowsableState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_state)) = value;
		}
	}

	static DebuggerBrowsableAttribute()
	{
		Il2CppClassPointerStore<DebuggerBrowsableAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics", "DebuggerBrowsableAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebuggerBrowsableAttribute>.NativeClassPtr);
		NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebuggerBrowsableAttribute>.NativeClassPtr, "state");
		NativeMethodInfoPtr__ctor_Public_Void_DebuggerBrowsableState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerBrowsableAttribute>.NativeClassPtr, 100673322);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 821992, XrefRangeEnd = 821993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DebuggerBrowsableAttribute(DebuggerBrowsableState state)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebuggerBrowsableAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&state);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_DebuggerBrowsableState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public DebuggerBrowsableAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
