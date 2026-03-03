using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem;

[StructLayout(LayoutKind.Explicit)]
public struct Variant
{
	private static readonly System.IntPtr NativeFieldInfoPtr_vt;

	private static readonly System.IntPtr NativeFieldInfoPtr_wReserved1;

	private static readonly System.IntPtr NativeFieldInfoPtr_wReserved2;

	private static readonly System.IntPtr NativeFieldInfoPtr_wReserved3;

	private static readonly System.IntPtr NativeFieldInfoPtr_llVal;

	private static readonly System.IntPtr NativeFieldInfoPtr_lVal;

	private static readonly System.IntPtr NativeFieldInfoPtr_bVal;

	private static readonly System.IntPtr NativeFieldInfoPtr_iVal;

	private static readonly System.IntPtr NativeFieldInfoPtr_fltVal;

	private static readonly System.IntPtr NativeFieldInfoPtr_dblVal;

	private static readonly System.IntPtr NativeFieldInfoPtr_boolVal;

	private static readonly System.IntPtr NativeFieldInfoPtr_bstrVal;

	private static readonly System.IntPtr NativeFieldInfoPtr_cVal;

	private static readonly System.IntPtr NativeFieldInfoPtr_uiVal;

	private static readonly System.IntPtr NativeFieldInfoPtr_ulVal;

	private static readonly System.IntPtr NativeFieldInfoPtr_ullVal;

	private static readonly System.IntPtr NativeFieldInfoPtr_intVal;

	private static readonly System.IntPtr NativeFieldInfoPtr_uintVal;

	private static readonly System.IntPtr NativeFieldInfoPtr_pdispVal;

	private static readonly System.IntPtr NativeFieldInfoPtr_bRecord;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

	[FieldOffset(0)]
	public short vt;

	[FieldOffset(2)]
	public ushort wReserved1;

	[FieldOffset(4)]
	public ushort wReserved2;

	[FieldOffset(6)]
	public ushort wReserved3;

	[FieldOffset(8)]
	public long llVal;

	[FieldOffset(8)]
	public int lVal;

	[FieldOffset(8)]
	public byte bVal;

	[FieldOffset(8)]
	public short iVal;

	[FieldOffset(8)]
	public float fltVal;

	[FieldOffset(8)]
	public double dblVal;

	[FieldOffset(8)]
	public short boolVal;

	[FieldOffset(8)]
	public System.IntPtr bstrVal;

	[FieldOffset(8)]
	public sbyte cVal;

	[FieldOffset(8)]
	public ushort uiVal;

	[FieldOffset(8)]
	public uint ulVal;

	[FieldOffset(8)]
	public ulong ullVal;

	[FieldOffset(8)]
	public int intVal;

	[FieldOffset(8)]
	public uint uintVal;

	[FieldOffset(8)]
	public System.IntPtr pdispVal;

	[FieldOffset(8)]
	public BRECORD bRecord;

	static Variant()
	{
		Il2CppClassPointerStore<Variant>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Variant");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Variant>.NativeClassPtr);
		NativeFieldInfoPtr_vt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "vt");
		NativeFieldInfoPtr_wReserved1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "wReserved1");
		NativeFieldInfoPtr_wReserved2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "wReserved2");
		NativeFieldInfoPtr_wReserved3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "wReserved3");
		NativeFieldInfoPtr_llVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "llVal");
		NativeFieldInfoPtr_lVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "lVal");
		NativeFieldInfoPtr_bVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "bVal");
		NativeFieldInfoPtr_iVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "iVal");
		NativeFieldInfoPtr_fltVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "fltVal");
		NativeFieldInfoPtr_dblVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "dblVal");
		NativeFieldInfoPtr_boolVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "boolVal");
		NativeFieldInfoPtr_bstrVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "bstrVal");
		NativeFieldInfoPtr_cVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "cVal");
		NativeFieldInfoPtr_uiVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "uiVal");
		NativeFieldInfoPtr_ulVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "ulVal");
		NativeFieldInfoPtr_ullVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "ullVal");
		NativeFieldInfoPtr_intVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "intVal");
		NativeFieldInfoPtr_uintVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "uintVal");
		NativeFieldInfoPtr_pdispVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "pdispVal");
		NativeFieldInfoPtr_bRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "bRecord");
		NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Variant>.NativeClassPtr, 100667394);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765668, XrefRangeEnd = 765675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Variant>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
