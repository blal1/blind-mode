using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic;

public sealed class TreeWalkPredicate<T> : MulticastDelegate
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Node_T_0;

	static TreeWalkPredicate()
	{
		Il2CppClassPointerStore<TreeWalkPredicate<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Generic", "TreeWalkPredicate`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeWalkPredicate<T>>.NativeClassPtr, 100665716);
		NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeWalkPredicate<T>>.NativeClassPtr, 100665717);
	}

	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 883878, RefRangeEnd = 883897, XrefRangeStart = 883874, XrefRangeEnd = 883878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TreeWalkPredicate(Object @object, System.IntPtr method)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TreeWalkPredicate<T>>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool Invoke(SortedSet<T>.Node node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public TreeWalkPredicate(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static implicit operator TreeWalkPredicate<T>(System.Func<SortedSet<T>.Node, bool> P_0)
	{
		return DelegateSupport.ConvertDelegate<TreeWalkPredicate<T>>((System.Delegate)P_0);
	}

	public static TreeWalkPredicate<T> operator +(TreeWalkPredicate<T> P_0, TreeWalkPredicate<T> P_1)
	{
		return ((Il2CppObjectBase)Delegate.Combine(P_0, P_1)).Cast<TreeWalkPredicate<T>>();
	}

	public static TreeWalkPredicate<T> operator -(TreeWalkPredicate<T> P_0, TreeWalkPredicate<T> P_1)
	{
		object obj = Delegate.Remove(P_0, P_1);
		if (obj != null)
		{
			obj = ((Il2CppObjectBase)obj).Cast<TreeWalkPredicate<T>>();
		}
		return (TreeWalkPredicate<T>)obj;
	}
}
