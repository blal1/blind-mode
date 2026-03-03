using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Buffers;

public class MemoryManager<T> : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetSpan_Public_Abstract_Virtual_New_Span_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pin_Public_Abstract_Virtual_New_MemoryHandle_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetArray_FamOrAssem_Virtual_New_Boolean_byref_ArraySegment_1_T_0;

	static MemoryManager()
	{
		Il2CppClassPointerStore<MemoryManager<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Buffers", "MemoryManager`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryManager<T>>.NativeClassPtr);
		NativeMethodInfoPtr_GetSpan_Public_Abstract_Virtual_New_Span_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryManager<T>>.NativeClassPtr, 100674347);
		NativeMethodInfoPtr_Pin_Public_Abstract_Virtual_New_MemoryHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryManager<T>>.NativeClassPtr, 100674348);
		NativeMethodInfoPtr_TryGetArray_FamOrAssem_Virtual_New_Boolean_byref_ArraySegment_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryManager<T>>.NativeClassPtr, 100674349);
	}

	[CallerCount(0)]
	public unsafe virtual Span<T> GetSpan()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetSpan_Public_Abstract_Virtual_New_Span_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Span<T>(pointer);
	}

	[CallerCount(0)]
	public unsafe virtual MemoryHandle Pin(int elementIndex = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&elementIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Pin_Public_Abstract_Virtual_New_MemoryHandle_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new MemoryHandle(pointer);
	}

	[CallerCount(0)]
	public unsafe virtual bool TryGetArray(out ArraySegment<T> segment)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		nint num = 0;
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_TryGetArray_FamOrAssem_Virtual_New_Boolean_byref_ArraySegment_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num2 = num;
		segment = ((num2 == 0) ? null : new ArraySegment<T>(num2));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public MemoryManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
