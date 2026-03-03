using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Collections.LowLevel.Unsafe;

public static class BurstLike : Il2CppSystem.Object
{
	public sealed class SharedStatic<T> : Il2CppSystem.ValueType where T : new()
	{
		private sealed class MethodInfoStoreGeneric_GetOrCreate_Public_Static_SharedStatic_1_T_UInt32_0
		{
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(SharedStatic<T>.NativeMethodInfoPtr_GetOrCreate_Public_Static_SharedStatic_1_T_UInt32_0, Il2CppClassPointerStore<SharedStatic<T>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		private static readonly System.IntPtr NativeFieldInfoPtr__buffer;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_ptr_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Data_Public_get_byref_T_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetOrCreate_Public_Static_SharedStatic_1_T_UInt32_0;

		public unsafe void* _buffer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__buffer);
				return *(void**)num;
			}
			set
			{
				*(void**)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__buffer)) = value;
			}
		}

		public unsafe ref T Data
		{
			[CallerCount(46)]
			[CachedScanResults(RefRangeStart = 959640, RefRangeEnd = 959686, XrefRangeStart = 959640, XrefRangeEnd = 959686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Data_Public_get_byref_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return ref *(T*)intPtr2;
			}
		}

		static SharedStatic()
		{
			Il2CppClassPointerStore<SharedStatic<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstLike>.NativeClassPtr, "SharedStatic`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedStatic<T>>.NativeClassPtr);
			NativeFieldInfoPtr__buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedStatic<T>>.NativeClassPtr, "_buffer");
			NativeMethodInfoPtr__ctor_Private_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedStatic<T>>.NativeClassPtr, 100663606);
			NativeMethodInfoPtr_get_Data_Public_get_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedStatic<T>>.NativeClassPtr, 100663607);
			NativeMethodInfoPtr_GetOrCreate_Public_Static_SharedStatic_1_T_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedStatic<T>>.NativeClassPtr, 100663608);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 687877, RefRangeEnd = 687880, XrefRangeStart = 687877, XrefRangeEnd = 687880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SharedStatic(void* buffer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedStatic<T>>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)buffer;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_ptr_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165965, XrefRangeEnd = 1165970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SharedStatic<T> GetOrCreate<TContext>(uint alignment = 0u)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&alignment);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SharedStatic<TContext>.MethodInfoStoreGeneric_GetOrCreate_Public_Static_SharedStatic_1_T_UInt32_0.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new SharedStatic<T>(pointer);
		}

		public SharedStatic(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public SharedStatic()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedStatic<T>>.NativeClassPtr))
		{
		}
	}

	public static class SharedStatic : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_GetOrCreateSharedStaticInternal_Public_Static_ptr_Void_Int64_Int64_UInt32_UInt32_0;

		static SharedStatic()
		{
			Il2CppClassPointerStore<SharedStatic>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstLike>.NativeClassPtr, "SharedStatic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedStatic>.NativeClassPtr);
			NativeMethodInfoPtr_GetOrCreateSharedStaticInternal_Public_Static_ptr_Void_Int64_Int64_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedStatic>.NativeClassPtr, 100663609);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1165973, RefRangeEnd = 1165974, XrefRangeStart = 1165970, XrefRangeEnd = 1165973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* GetOrCreateSharedStaticInternal(long getHashCode64, long getSubHashCode64, uint sizeOf, uint alignment)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)(&getHashCode64);
			*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &getSubHashCode64;
			*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sizeOf;
			*(uint**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &alignment;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOrCreateSharedStaticInternal_Public_Static_ptr_Void_Int64_Int64_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (void*)result;
		}

		public SharedStatic(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private delegate int NativeFunctionCall_Int_IntPtr_IntPtrDelegate(System.IntPtr function, System.IntPtr p0, System.IntPtr p1, [Out] System.IntPtr error);

	private static readonly NativeFunctionCall_Int_IntPtr_IntPtrDelegate NativeFunctionCall_Int_IntPtr_IntPtrDelegateField;

	static BurstLike()
	{
		Il2CppClassPointerStore<BurstLike>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "BurstLike");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstLike>.NativeClassPtr);
		NativeFunctionCall_Int_IntPtr_IntPtrDelegateField = IL2CPP.ResolveICall<NativeFunctionCall_Int_IntPtr_IntPtrDelegate>("Unity.Collections.LowLevel.Unsafe.BurstLike::NativeFunctionCall_Int_IntPtr_IntPtr");
	}

	public BurstLike(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public unsafe static int NativeFunctionCall_Int_IntPtr_IntPtr(System.IntPtr function, System.IntPtr p0, System.IntPtr p1, out int error)
	{
		return NativeFunctionCall_Int_IntPtr_IntPtrDelegateField(function, p0, p1, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref error));
	}
}
