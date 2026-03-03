using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.LowLevel;

[StructLayout(LayoutKind.Explicit)]
public struct FontEngineUtilities
{
	private static readonly System.IntPtr NativeMethodInfoPtr_MaxValue_Internal_Static_Int32_Int32_Int32_Int32_0;

	static FontEngineUtilities()
	{
		Il2CppClassPointerStore<FontEngineUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreFontEngineModule.dll", "UnityEngine.TextCore.LowLevel", "FontEngineUtilities");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontEngineUtilities>.NativeClassPtr);
		NativeMethodInfoPtr_MaxValue_Internal_Static_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngineUtilities>.NativeClassPtr, 100663429);
	}

	[CallerCount(0)]
	public unsafe static int MaxValue(int a, int b, int c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&a);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MaxValue_Internal_Static_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FontEngineUtilities>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static bool Approximately(float a, float b)
	{
		return Mathf.Abs(a - b) < 0.001f;
	}
}
