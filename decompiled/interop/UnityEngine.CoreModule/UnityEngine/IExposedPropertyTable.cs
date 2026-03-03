using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine;

public class IExposedPropertyTable : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_GetReferenceValue_Public_Abstract_Virtual_New_Object_PropertyName_byref_Boolean_0;

	static IExposedPropertyTable()
	{
		Il2CppClassPointerStore<IExposedPropertyTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "IExposedPropertyTable");
		NativeMethodInfoPtr_GetReferenceValue_Public_Abstract_Virtual_New_Object_PropertyName_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExposedPropertyTable>.NativeClassPtr, 100664094);
	}

	[CallerCount(0)]
	public unsafe virtual Object GetReferenceValue(PropertyName id, out bool idValid)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&id);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref idValid);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetReferenceValue_Public_Abstract_Virtual_New_Object_PropertyName_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	public IExposedPropertyTable(IntPtr pointer)
		: base(pointer)
	{
	}
}
