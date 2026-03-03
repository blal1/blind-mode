using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics;

public sealed class Debugger : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_DefaultCategory;

	private static readonly System.IntPtr NativeMethodInfoPtr_NotifyOfCrossThreadDependency_Public_Static_Void_0;

	public unsafe static string DefaultCategory
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DefaultCategory, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DefaultCategory, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static Debugger()
	{
		Il2CppClassPointerStore<Debugger>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics", "Debugger");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Debugger>.NativeClassPtr);
		NativeFieldInfoPtr_DefaultCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Debugger>.NativeClassPtr, "DefaultCategory");
		NativeMethodInfoPtr_NotifyOfCrossThreadDependency_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debugger>.NativeClassPtr, 100673325);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NotifyOfCrossThreadDependency()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NotifyOfCrossThreadDependency_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Debugger(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
