using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.IO;

[StructLayout(LayoutKind.Explicit)]
public struct DisableMediaInsertionPrompt
{
	private static readonly System.IntPtr NativeFieldInfoPtr__disableSuccess;

	private static readonly System.IntPtr NativeFieldInfoPtr__oldMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_useUWPFallback;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_DisableMediaInsertionPrompt_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	[FieldOffset(0)]
	[MarshalAs(UnmanagedType.U1)]
	public bool _disableSuccess;

	[FieldOffset(4)]
	public uint _oldMode;

	public unsafe static bool useUWPFallback
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_useUWPFallback, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_useUWPFallback, (void*)(&value));
		}
	}

	static DisableMediaInsertionPrompt()
	{
		Il2CppClassPointerStore<DisableMediaInsertionPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "DisableMediaInsertionPrompt");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisableMediaInsertionPrompt>.NativeClassPtr);
		NativeFieldInfoPtr__disableSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableMediaInsertionPrompt>.NativeClassPtr, "_disableSuccess");
		NativeFieldInfoPtr__oldMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableMediaInsertionPrompt>.NativeClassPtr, "_oldMode");
		NativeFieldInfoPtr_useUWPFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableMediaInsertionPrompt>.NativeClassPtr, "useUWPFallback");
		NativeMethodInfoPtr_Create_Public_Static_DisableMediaInsertionPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableMediaInsertionPrompt>.NativeClassPtr, 100674389);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableMediaInsertionPrompt>.NativeClassPtr, 100674390);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 833635, RefRangeEnd = 833636, XrefRangeStart = 833630, XrefRangeEnd = 833635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DisableMediaInsertionPrompt Create()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_DisableMediaInsertionPrompt_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DisableMediaInsertionPrompt*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 833637, RefRangeEnd = 833639, XrefRangeStart = 833636, XrefRangeEnd = 833637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DisableMediaInsertionPrompt>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
