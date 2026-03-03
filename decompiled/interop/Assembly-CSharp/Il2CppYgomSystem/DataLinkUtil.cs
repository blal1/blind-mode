using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppYgomSystem;

public static class DataLinkUtil : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_getInheritLimitTextFromCW_Private_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLimitNoticeText_Public_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInheritSuccessText_Public_Static_String_Func_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInheritLimitErrorText_Public_Static_String_0;

	static DataLinkUtil()
	{
		Il2CppClassPointerStore<DataLinkUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "YgomSystem", "DataLinkUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataLinkUtil>.NativeClassPtr);
		NativeMethodInfoPtr_getInheritLimitTextFromCW_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataLinkUtil>.NativeClassPtr, 100665493);
		NativeMethodInfoPtr_GetLimitNoticeText_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataLinkUtil>.NativeClassPtr, 100665494);
		NativeMethodInfoPtr_GetInheritSuccessText_Public_Static_String_Func_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataLinkUtil>.NativeClassPtr, 100665495);
		NativeMethodInfoPtr_GetInheritLimitErrorText_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataLinkUtil>.NativeClassPtr, 100665496);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 56535, RefRangeEnd = 56540, XrefRangeStart = 56511, XrefRangeEnd = 56535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string getInheritLimitTextFromCW(string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getInheritLimitTextFromCW_Private_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 56543, RefRangeEnd = 56545, XrefRangeStart = 56540, XrefRangeEnd = 56543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetLimitNoticeText()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLimitNoticeText_Public_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 56563, RefRangeEnd = 56564, XrefRangeStart = 56545, XrefRangeEnd = 56563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetInheritSuccessText(Il2CppSystem.Func<string> getDefaultText = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)getDefaultText);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInheritSuccessText_Public_Static_String_Func_1_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 56574, RefRangeEnd = 56575, XrefRangeStart = 56564, XrefRangeEnd = 56574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetInheritLimitErrorText()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInheritLimitErrorText_Public_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public DataLinkUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
