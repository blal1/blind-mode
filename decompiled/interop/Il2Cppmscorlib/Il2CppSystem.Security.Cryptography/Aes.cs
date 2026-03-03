using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography;

public class Aes : SymmetricAlgorithm
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_legalBlockSizes;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_legalKeySizes;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_Aes_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_Aes_String_0;

	public unsafe static Il2CppReferenceArray<KeySizes> s_legalBlockSizes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_legalBlockSizes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_legalBlockSizes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<KeySizes> s_legalKeySizes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_legalKeySizes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_legalKeySizes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static Aes()
	{
		Il2CppClassPointerStore<Aes>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "Aes");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Aes>.NativeClassPtr);
		NativeFieldInfoPtr_s_legalBlockSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Aes>.NativeClassPtr, "s_legalBlockSizes");
		NativeFieldInfoPtr_s_legalKeySizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Aes>.NativeClassPtr, "s_legalKeySizes");
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Aes>.NativeClassPtr, 100669218);
		NativeMethodInfoPtr_Create_Public_Static_Aes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Aes>.NativeClassPtr, 100669219);
		NativeMethodInfoPtr_Create_Public_Static_Aes_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Aes>.NativeClassPtr, 100669220);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 784911, RefRangeEnd = 784913, XrefRangeStart = 784903, XrefRangeEnd = 784911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Aes()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Aes>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 784924, RefRangeEnd = 784926, XrefRangeStart = 784913, XrefRangeEnd = 784924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Aes Create()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_Aes_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Aes>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784926, XrefRangeEnd = 784932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe static Aes Create(string algorithmName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(algorithmName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_Aes_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Aes>(intPtr2) : null;
	}

	public Aes(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
