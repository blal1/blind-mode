using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq.Expressions;

public class MemberExpression : Expression
{
	private static readonly System.IntPtr NativeMethodInfoPtr_get_Member_Public_get_MemberInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMember_Internal_Virtual_New_MemberInfo_0;

	public unsafe MemberInfo Member
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50621, RefRangeEnd = 50622, XrefRangeStart = 50621, XrefRangeEnd = 50622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Member_Public_get_MemberInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr2) : null;
		}
	}

	static MemberExpression()
	{
		Il2CppClassPointerStore<MemberExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "MemberExpression");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemberExpression>.NativeClassPtr);
		NativeMethodInfoPtr_get_Member_Public_get_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberExpression>.NativeClassPtr, 100663614);
		NativeMethodInfoPtr_GetMember_Internal_Virtual_New_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberExpression>.NativeClassPtr, 100663615);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861670, XrefRangeEnd = 861673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual MemberInfo GetMember()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetMember_Internal_Virtual_New_MemberInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr2) : null;
	}

	public MemberExpression(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
