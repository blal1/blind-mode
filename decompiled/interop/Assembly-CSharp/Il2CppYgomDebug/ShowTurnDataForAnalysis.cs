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
public struct ShowTurnDataForAnalysis
{
	private static readonly System.IntPtr NativeFieldInfoPtr_bitdata0;

	private static readonly System.IntPtr NativeFieldInfoPtr_bitdata1;

	private static readonly System.IntPtr NativeFieldInfoPtr_restlpl;

	private static readonly System.IntPtr NativeFieldInfoPtr_restlpr;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_playeridc_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_turn_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_playeridl_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_playeridr_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ShowTurnData_0;

	[FieldOffset(0)]
	public ulong bitdata0;

	[FieldOffset(8)]
	public uint bitdata1;

	[FieldOffset(12)]
	public int restlpl;

	[FieldOffset(16)]
	public int restlpr;

	public unsafe int playeridc
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53855, XrefRangeEnd = 53856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_playeridc_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int turn
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53856, XrefRangeEnd = 53857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_turn_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int playeridl
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53857, XrefRangeEnd = 53858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_playeridl_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int playeridr
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53858, XrefRangeEnd = 53859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_playeridr_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static ShowTurnDataForAnalysis()
	{
		Il2CppClassPointerStore<ShowTurnDataForAnalysis>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "YgomDebug", "ShowTurnDataForAnalysis");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowTurnDataForAnalysis>.NativeClassPtr);
		NativeFieldInfoPtr_bitdata0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTurnDataForAnalysis>.NativeClassPtr, "bitdata0");
		NativeFieldInfoPtr_bitdata1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTurnDataForAnalysis>.NativeClassPtr, "bitdata1");
		NativeFieldInfoPtr_restlpl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTurnDataForAnalysis>.NativeClassPtr, "restlpl");
		NativeFieldInfoPtr_restlpr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTurnDataForAnalysis>.NativeClassPtr, "restlpr");
		NativeMethodInfoPtr_get_playeridc_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTurnDataForAnalysis>.NativeClassPtr, 100665326);
		NativeMethodInfoPtr_get_turn_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTurnDataForAnalysis>.NativeClassPtr, 100665327);
		NativeMethodInfoPtr_get_playeridl_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTurnDataForAnalysis>.NativeClassPtr, 100665328);
		NativeMethodInfoPtr_get_playeridr_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTurnDataForAnalysis>.NativeClassPtr, 100665329);
		NativeMethodInfoPtr__ctor_Public_Void_ShowTurnData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTurnDataForAnalysis>.NativeClassPtr, 100665330);
	}

	[CallerCount(0)]
	public unsafe ShowTurnDataForAnalysis(ShowTurnData showTurnData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&showTurnData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ShowTurnData_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowTurnDataForAnalysis>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
