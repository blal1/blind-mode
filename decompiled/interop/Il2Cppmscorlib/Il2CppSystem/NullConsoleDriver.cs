using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem;

public class NullConsoleDriver : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_EmptyConsoleKeyInfo;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadKey_Public_Virtual_Final_New_ConsoleKeyInfo_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static ConsoleKeyInfo EmptyConsoleKeyInfo
	{
		get
		{
			Unsafe.SkipInit(out ConsoleKeyInfo result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EmptyConsoleKeyInfo, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EmptyConsoleKeyInfo, (void*)(&value));
		}
	}

	static NullConsoleDriver()
	{
		Il2CppClassPointerStore<NullConsoleDriver>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "NullConsoleDriver");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NullConsoleDriver>.NativeClassPtr);
		NativeFieldInfoPtr_EmptyConsoleKeyInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NullConsoleDriver>.NativeClassPtr, "EmptyConsoleKeyInfo");
		NativeMethodInfoPtr_ReadKey_Public_Virtual_Final_New_ConsoleKeyInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullConsoleDriver>.NativeClassPtr, 100667193);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullConsoleDriver>.NativeClassPtr, 100667194);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763318, XrefRangeEnd = 763322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual ConsoleKeyInfo ReadKey(bool intercept)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&intercept);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadKey_Public_Virtual_Final_New_ConsoleKeyInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ConsoleKeyInfo*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NullConsoleDriver()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NullConsoleDriver>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public NullConsoleDriver(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
