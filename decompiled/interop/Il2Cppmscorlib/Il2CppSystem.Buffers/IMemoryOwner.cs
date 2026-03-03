using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Buffers;

public class IMemoryOwner<T> : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_get_Memory_Public_Abstract_Virtual_New_get_Memory_1_T_0;

	public unsafe virtual Memory<T> Memory
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Memory_Public_Abstract_Virtual_New_get_Memory_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Memory<T>(pointer);
		}
	}

	static IMemoryOwner()
	{
		Il2CppClassPointerStore<IMemoryOwner<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Buffers", "IMemoryOwner`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		NativeMethodInfoPtr_get_Memory_Public_Abstract_Virtual_New_get_Memory_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMemoryOwner<T>>.NativeClassPtr, 100674342);
	}

	public IMemoryOwner(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
