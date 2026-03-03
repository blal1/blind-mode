using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Util;

namespace Il2CppSystem;

public sealed class SharedStatics : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__sharedStatics;

	private static readonly System.IntPtr NativeFieldInfoPtr__maker;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSharedStringMaker_Public_Static_StringMaker_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseSharedStringMaker_Public_Static_Void_byref_StringMaker_0;

	public unsafe static SharedStatics _sharedStatics
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__sharedStatics, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SharedStatics>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__sharedStatics, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Tokenizer.StringMaker _maker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maker);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Tokenizer.StringMaker>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maker)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static SharedStatics()
	{
		Il2CppClassPointerStore<SharedStatics>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "SharedStatics");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedStatics>.NativeClassPtr);
		NativeFieldInfoPtr__sharedStatics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedStatics>.NativeClassPtr, "_sharedStatics");
		NativeFieldInfoPtr__maker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedStatics>.NativeClassPtr, "_maker");
		NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedStatics>.NativeClassPtr, 100666945);
		NativeMethodInfoPtr_GetSharedStringMaker_Public_Static_StringMaker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedStatics>.NativeClassPtr, 100666946);
		NativeMethodInfoPtr_ReleaseSharedStringMaker_Public_Static_Void_byref_StringMaker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedStatics>.NativeClassPtr, 100666947);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SharedStatics()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedStatics>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 758414, RefRangeEnd = 758419, XrefRangeStart = 758394, XrefRangeEnd = 758414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Tokenizer.StringMaker GetSharedStringMaker()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSharedStringMaker_Public_Static_StringMaker_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Tokenizer.StringMaker>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 758434, RefRangeEnd = 758438, XrefRangeStart = 758419, XrefRangeEnd = 758434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReleaseSharedStringMaker(ref Tokenizer.StringMaker maker)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)maker);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReleaseSharedStringMaker_Public_Static_Void_byref_StringMaker_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		maker = ((intPtr4 == (System.IntPtr)0) ? null : new Tokenizer.StringMaker(intPtr4));
	}

	public SharedStatics(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
