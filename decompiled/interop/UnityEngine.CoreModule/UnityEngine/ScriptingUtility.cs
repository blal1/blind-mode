using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

public class ScriptingUtility : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct TestClass
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_value;

		[FieldOffset(0)]
		public int value;

		static TestClass()
		{
			Il2CppClassPointerStore<TestClass>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptingUtility>.NativeClassPtr, "TestClass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TestClass>.NativeClassPtr);
			NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestClass>.NativeClassPtr, "value");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TestClass>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_IsManagedCodeWorking_Private_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupCallbacks_Private_Static_Void_IntPtr_0;

	static ScriptingUtility()
	{
		Il2CppClassPointerStore<ScriptingUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ScriptingUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptingUtility>.NativeClassPtr);
		NativeMethodInfoPtr_IsManagedCodeWorking_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptingUtility>.NativeClassPtr, 100666467);
		NativeMethodInfoPtr_SetupCallbacks_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptingUtility>.NativeClassPtr, 100666468);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1204066, RefRangeEnd = 1204067, XrefRangeStart = 1204066, XrefRangeEnd = 1204066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsManagedCodeWorking()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsManagedCodeWorking_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetupCallbacks(System.IntPtr p)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&p);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupCallbacks_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ScriptingUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
