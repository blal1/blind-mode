using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem;

public class IObservable<T> : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Subscribe_Public_Abstract_Virtual_New_IDisposable_IObserver_1_T_0;

	static IObservable()
	{
		Il2CppClassPointerStore<IObservable<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "IObservable`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		NativeMethodInfoPtr_Subscribe_Public_Abstract_Virtual_New_IDisposable_IObserver_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObservable<T>>.NativeClassPtr, 100665201);
	}

	[CallerCount(0)]
	public unsafe virtual IDisposable Subscribe(IObserver<T> observer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)observer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Subscribe_Public_Abstract_Virtual_New_IDisposable_IObserver_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IDisposable>(intPtr2) : null;
	}

	public IObservable(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
