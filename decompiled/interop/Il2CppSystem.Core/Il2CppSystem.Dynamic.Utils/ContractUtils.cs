using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Dynamic.Utils;

public static class ContractUtils : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_get_Unreachable_Public_Static_get_Exception_0;

	public unsafe static Exception Unreachable
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 861694, RefRangeEnd = 861695, XrefRangeStart = 861688, XrefRangeEnd = 861694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Unreachable_Public_Static_get_Exception_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
		}
	}

	static ContractUtils()
	{
		Il2CppClassPointerStore<ContractUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Dynamic.Utils", "ContractUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContractUtils>.NativeClassPtr);
		NativeMethodInfoPtr_get_Unreachable_Public_Static_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContractUtils>.NativeClassPtr, 100663620);
	}

	public ContractUtils(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
