using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;

namespace Il2CppSystem;

public class IValueTupleInternal : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_IEqualityComparer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToStringEnd_Public_Abstract_Virtual_New_String_0;

	static IValueTupleInternal()
	{
		Il2CppClassPointerStore<IValueTupleInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "IValueTupleInternal");
		NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IValueTupleInternal>.NativeClassPtr, 100666153);
		NativeMethodInfoPtr_ToStringEnd_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IValueTupleInternal>.NativeClassPtr, 100666154);
	}

	[CallerCount(0)]
	public unsafe virtual int GetHashCode(IEqualityComparer comparer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_IEqualityComparer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual string ToStringEnd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ToStringEnd_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public IValueTupleInternal(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
