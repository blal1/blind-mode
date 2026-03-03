using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading;

public sealed class CancellationCallbackCoreWorkArguments : ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr__currArrayFragment;

	private static readonly System.IntPtr NativeFieldInfoPtr__currArrayIndex;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_SparselyPopulatedArrayFragment_1_CancellationCallbackInfo_Int32_0;

	public unsafe SparselyPopulatedArrayFragment<CancellationCallbackInfo> _currArrayFragment
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currArrayFragment);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SparselyPopulatedArrayFragment<CancellationCallbackInfo>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currArrayFragment)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int _currArrayIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currArrayIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currArrayIndex)) = value;
		}
	}

	static CancellationCallbackCoreWorkArguments()
	{
		Il2CppClassPointerStore<CancellationCallbackCoreWorkArguments>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "CancellationCallbackCoreWorkArguments");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CancellationCallbackCoreWorkArguments>.NativeClassPtr);
		NativeFieldInfoPtr__currArrayFragment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationCallbackCoreWorkArguments>.NativeClassPtr, "_currArrayFragment");
		NativeFieldInfoPtr__currArrayIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationCallbackCoreWorkArguments>.NativeClassPtr, "_currArrayIndex");
		NativeMethodInfoPtr__ctor_Public_Void_SparselyPopulatedArrayFragment_1_CancellationCallbackInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationCallbackCoreWorkArguments>.NativeClassPtr, 100667677);
	}

	[CallerCount(23)]
	[CachedScanResults(RefRangeStart = 767829, RefRangeEnd = 767852, XrefRangeStart = 767828, XrefRangeEnd = 767829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CancellationCallbackCoreWorkArguments(SparselyPopulatedArrayFragment<CancellationCallbackInfo> currArrayFragment, int currArrayIndex)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancellationCallbackCoreWorkArguments>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)currArrayFragment);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &currArrayIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_SparselyPopulatedArrayFragment_1_CancellationCallbackInfo_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public CancellationCallbackCoreWorkArguments(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public CancellationCallbackCoreWorkArguments()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancellationCallbackCoreWorkArguments>.NativeClassPtr))
	{
	}
}
