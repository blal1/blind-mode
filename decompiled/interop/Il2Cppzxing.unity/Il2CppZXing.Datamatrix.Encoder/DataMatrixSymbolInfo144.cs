using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppZXing.Datamatrix.Encoder;

public sealed class DataMatrixSymbolInfo144 : SymbolInfo
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_getInterleavedBlockCount_Public_Virtual_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_getDataLengthForInterleavedBlock_Public_Virtual_Int32_Int32_0;

	static DataMatrixSymbolInfo144()
	{
		Il2CppClassPointerStore<DataMatrixSymbolInfo144>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.Datamatrix.Encoder", "DataMatrixSymbolInfo144");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataMatrixSymbolInfo144>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataMatrixSymbolInfo144>.NativeClassPtr, 100664487);
		NativeMethodInfoPtr_getInterleavedBlockCount_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataMatrixSymbolInfo144>.NativeClassPtr, 100664488);
		NativeMethodInfoPtr_getDataLengthForInterleavedBlock_Public_Virtual_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataMatrixSymbolInfo144>.NativeClassPtr, 100664489);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426410, XrefRangeEnd = 1426414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DataMatrixSymbolInfo144()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataMatrixSymbolInfo144>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe override int getInterleavedBlockCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getInterleavedBlockCount_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe override int getDataLengthForInterleavedBlock(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getDataLengthForInterleavedBlock_Public_Virtual_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public DataMatrixSymbolInfo144(IntPtr pointer)
		: base(pointer)
	{
	}
}
