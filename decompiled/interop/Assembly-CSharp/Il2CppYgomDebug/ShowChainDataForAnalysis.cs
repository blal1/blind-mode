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
public struct ShowChainDataForAnalysis
{
	[OriginalName("Assembly-CSharp.dll", "", "ChainDataTypeForAnalysis")]
	public enum ChainDataTypeForAnalysis
	{
		SET,
		RUN,
		STEP,
		END
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_cardid;

	private static readonly System.IntPtr NativeFieldInfoPtr_chainnum;

	private static readonly System.IntPtr NativeFieldInfoPtr_team;

	private static readonly System.IntPtr NativeFieldInfoPtr_type;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ShowChainData_0;

	[FieldOffset(0)]
	public short cardid;

	[FieldOffset(2)]
	public short chainnum;

	[FieldOffset(4)]
	[MarshalAs(UnmanagedType.U1)]
	public bool team;

	[FieldOffset(8)]
	public ChainDataTypeForAnalysis type;

	static ShowChainDataForAnalysis()
	{
		Il2CppClassPointerStore<ShowChainDataForAnalysis>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "YgomDebug", "ShowChainDataForAnalysis");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowChainDataForAnalysis>.NativeClassPtr);
		NativeFieldInfoPtr_cardid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowChainDataForAnalysis>.NativeClassPtr, "cardid");
		NativeFieldInfoPtr_chainnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowChainDataForAnalysis>.NativeClassPtr, "chainnum");
		NativeFieldInfoPtr_team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowChainDataForAnalysis>.NativeClassPtr, "team");
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowChainDataForAnalysis>.NativeClassPtr, "type");
		NativeMethodInfoPtr__ctor_Public_Void_ShowChainData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowChainDataForAnalysis>.NativeClassPtr, 100665306);
	}

	[CallerCount(0)]
	public unsafe ShowChainDataForAnalysis(ShowChainData showChainData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&showChainData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ShowChainData_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowChainDataForAnalysis>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
