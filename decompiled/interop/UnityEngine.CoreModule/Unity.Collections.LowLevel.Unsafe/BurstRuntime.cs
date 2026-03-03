using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Collections.LowLevel.Unsafe;

public static class BurstRuntime : Il2CppSystem.Object
{
	public sealed class HashCode64<T> : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Value;

		public unsafe static long Value
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out long result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Value, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Value, (void*)(&value));
			}
		}

		static HashCode64()
		{
			Il2CppClassPointerStore<HashCode64<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr, "HashCode64`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashCode64<T>>.NativeClassPtr);
			NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashCode64<T>>.NativeClassPtr, "Value");
		}

		public HashCode64(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public HashCode64()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HashCode64<T>>.NativeClassPtr))
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_GetHashCode64_Public_Static_Int64_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetHashCode64_Public_Static_Int64_0, Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode64_Public_Static_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HashStringWithFNV1A64_Internal_Static_Int64_String_0;

	static BurstRuntime()
	{
		Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "BurstRuntime");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr);
		NativeMethodInfoPtr_GetHashCode64_Public_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr, 100663610);
		NativeMethodInfoPtr_HashStringWithFNV1A64_Internal_Static_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr, 100663611);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 959152, RefRangeEnd = 959153, XrefRangeStart = 959152, XrefRangeEnd = 959153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long GetHashCode64<T>()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetHashCode64_Public_Static_Int64_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long HashStringWithFNV1A64(string text)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HashStringWithFNV1A64_Internal_Static_Int64_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public BurstRuntime(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
