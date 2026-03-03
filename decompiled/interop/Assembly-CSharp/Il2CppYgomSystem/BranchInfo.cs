using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppYgomSystem;

public static class BranchInfo : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_branchName;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_commitHash;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_isReleaseBranch;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_branchName_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_commitHash_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isReleaseBranch_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_BranchData_0;

	public unsafe static string s_branchName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_branchName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_branchName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string s_commitHash
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_commitHash, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_commitHash, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static bool s_isReleaseBranch
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_isReleaseBranch, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_isReleaseBranch, (void*)(&value));
		}
	}

	public unsafe static string branchName
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56489, XrefRangeEnd = 56493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_branchName_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe static string commitHash
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56493, XrefRangeEnd = 56497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_commitHash_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe static bool isReleaseBranch
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56497, XrefRangeEnd = 56501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isReleaseBranch_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static BranchInfo()
	{
		Il2CppClassPointerStore<BranchInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "YgomSystem", "BranchInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BranchInfo>.NativeClassPtr);
		NativeFieldInfoPtr_s_branchName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BranchInfo>.NativeClassPtr, "s_branchName");
		NativeFieldInfoPtr_s_commitHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BranchInfo>.NativeClassPtr, "s_commitHash");
		NativeFieldInfoPtr_s_isReleaseBranch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BranchInfo>.NativeClassPtr, "s_isReleaseBranch");
		NativeMethodInfoPtr_get_branchName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchInfo>.NativeClassPtr, 100665488);
		NativeMethodInfoPtr_get_commitHash_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchInfo>.NativeClassPtr, 100665489);
		NativeMethodInfoPtr_get_isReleaseBranch_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchInfo>.NativeClassPtr, 100665490);
		NativeMethodInfoPtr_Initialize_Public_Static_Void_BranchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchInfo>.NativeClassPtr, 100665491);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56501, XrefRangeEnd = 56511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize(BranchData data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Static_Void_BranchData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public BranchInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
