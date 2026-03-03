using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppYgomGame.Duel;

namespace Il2CppYgomDebug;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct ShowTextDataForAnalysis
{
	private static readonly System.IntPtr NativeFieldInfoPtr_textid;

	private static readonly System.IntPtr NativeFieldInfoPtr_indent;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ShowTextData_0;

	[FieldOffset(0)]
	public short textid;

	[FieldOffset(2)]
	[MarshalAs(UnmanagedType.U1)]
	public bool indent;

	static ShowTextDataForAnalysis()
	{
		Il2CppClassPointerStore<ShowTextDataForAnalysis>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "YgomDebug", "ShowTextDataForAnalysis");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowTextDataForAnalysis>.NativeClassPtr);
		NativeFieldInfoPtr_textid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTextDataForAnalysis>.NativeClassPtr, "textid");
		NativeFieldInfoPtr_indent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTextDataForAnalysis>.NativeClassPtr, "indent");
		NativeMethodInfoPtr__ctor_Public_Void_ShowTextData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTextDataForAnalysis>.NativeClassPtr, 100665321);
	}

	[CallerCount(0)]
	public unsafe ShowTextDataForAnalysis(ShowTextData showTextData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&showTextData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ShowTextData_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowTextDataForAnalysis>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
