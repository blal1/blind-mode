using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq;

public class IOrderedEnumerable<TElement> : Il2CppObjectBase
{
	private sealed class MethodInfoStoreGeneric_CreateOrderedEnumerable_Public_Abstract_Virtual_New_IOrderedEnumerable_1_TElement_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_0
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(IOrderedEnumerable<TElement>.NativeMethodInfoPtr_CreateOrderedEnumerable_Public_Abstract_Virtual_New_IOrderedEnumerable_1_TElement_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_0, Il2CppClassPointerStore<IOrderedEnumerable<TElement>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateOrderedEnumerable_Public_Abstract_Virtual_New_IOrderedEnumerable_1_TElement_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_0;

	static IOrderedEnumerable()
	{
		Il2CppClassPointerStore<IOrderedEnumerable<TElement>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq", "IOrderedEnumerable`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr)) })).TypeHandle.value);
		NativeMethodInfoPtr_CreateOrderedEnumerable_Public_Abstract_Virtual_New_IOrderedEnumerable_1_TElement_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOrderedEnumerable<TElement>>.NativeClassPtr, 100663531);
	}

	[CallerCount(0)]
	public unsafe virtual IOrderedEnumerable<TElement> CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keySelector);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparer);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &descending;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), IOrderedEnumerable<TKey>.MethodInfoStoreGeneric_CreateOrderedEnumerable_Public_Abstract_Virtual_New_IOrderedEnumerable_1_TElement_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_0.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IOrderedEnumerable<TElement>>(intPtr2) : null;
	}

	public IOrderedEnumerable(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
