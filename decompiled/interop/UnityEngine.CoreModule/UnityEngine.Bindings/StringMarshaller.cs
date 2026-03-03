using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Bindings;

public static class StringMarshaller : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalEmptyOrNullString_Public_Static_Boolean_String_byref_ManagedSpanWrapper_0;

	static StringMarshaller()
	{
		Il2CppClassPointerStore<StringMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Bindings", "StringMarshaller");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringMarshaller>.NativeClassPtr);
		NativeMethodInfoPtr_TryMarshalEmptyOrNullString_Public_Static_Boolean_String_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringMarshaller>.NativeClassPtr, 100667245);
	}

	[CallerCount(0)]
	public unsafe static bool TryMarshalEmptyOrNullString(string s, ref ManagedSpanWrapper managedSpanWrapper)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref managedSpanWrapper);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryMarshalEmptyOrNullString_Public_Static_Boolean_String_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public StringMarshaller(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
