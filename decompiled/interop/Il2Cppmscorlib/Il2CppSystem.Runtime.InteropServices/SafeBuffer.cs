using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;

namespace Il2CppSystem.Runtime.InteropServices;

public class SafeBuffer : SafeHandleZeroOrMinusOneIsInvalid
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Uninitialized;

	private static readonly System.IntPtr NativeFieldInfoPtr__numBytes;

	private static readonly System.IntPtr NativeMethodInfoPtr_AcquirePointer_Public_Void_byref_ptr_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReleasePointer_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NotInitialized_Private_Static_InvalidOperationException_0;

	public unsafe static System.UIntPtr Uninitialized
	{
		get
		{
			Unsafe.SkipInit(out System.UIntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Uninitialized, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Uninitialized, (void*)(&value));
		}
	}

	public unsafe System.UIntPtr _numBytes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__numBytes);
			return *(System.UIntPtr*)num;
		}
		set
		{
			*(System.UIntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__numBytes)) = value;
		}
	}

	static SafeBuffer()
	{
		Il2CppClassPointerStore<SafeBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "SafeBuffer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeBuffer>.NativeClassPtr);
		NativeFieldInfoPtr_Uninitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeBuffer>.NativeClassPtr, "Uninitialized");
		NativeFieldInfoPtr__numBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeBuffer>.NativeClassPtr, "_numBytes");
		NativeMethodInfoPtr_AcquirePointer_Public_Void_byref_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeBuffer>.NativeClassPtr, 100671209);
		NativeMethodInfoPtr_ReleasePointer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeBuffer>.NativeClassPtr, 100671210);
		NativeMethodInfoPtr_NotInitialized_Private_Static_InvalidOperationException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeBuffer>.NativeClassPtr, 100671211);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 803981, RefRangeEnd = 803985, XrefRangeStart = 803974, XrefRangeEnd = 803981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AcquirePointer(ref byte* pointer)
	{
		//IL_0046->IL0048: Incompatible stack types: I vs O
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<byte*, object>(ref pointer));
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AcquirePointer_Public_Void_byref_ptr_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		Unsafe.As<byte*, object>(ref pointer) = ((intPtr4 == (System.IntPtr)0) ? null : ((object)new byte*(intPtr4)));
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 804002, RefRangeEnd = 804006, XrefRangeStart = 803985, XrefRangeEnd = 804002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReleasePointer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReleasePointer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 804012, RefRangeEnd = 804013, XrefRangeStart = 804006, XrefRangeEnd = 804012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InvalidOperationException NotInitialized()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NotInitialized_Private_Static_InvalidOperationException_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InvalidOperationException>(intPtr2) : null;
	}

	public SafeBuffer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
