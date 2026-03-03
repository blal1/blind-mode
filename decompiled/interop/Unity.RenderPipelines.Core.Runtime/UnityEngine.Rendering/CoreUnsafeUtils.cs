using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Unity.Collections;

namespace UnityEngine.Rendering;

public static class CoreUnsafeUtils : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct FixedBufferStringQueue
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_ReadCursor;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_WriteCursor;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_BufferEnd;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_BufferStart;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_BufferLength;

		private static readonly System.IntPtr NativeFieldInfoPtr__Count_k__BackingField;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_Count_Private_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_Byte_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_TryPush_Public_Boolean_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_TryPop_Public_Boolean_byref_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		[FieldOffset(0)]
		public System.IntPtr m_ReadCursor;

		[FieldOffset(8)]
		public System.IntPtr m_WriteCursor;

		[FieldOffset(16)]
		public readonly System.IntPtr m_BufferEnd;

		[FieldOffset(24)]
		public readonly System.IntPtr m_BufferStart;

		[FieldOffset(32)]
		public readonly int m_BufferLength;

		[FieldOffset(36)]
		public int _Count_k__BackingField;

		public unsafe int Count
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Count_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Count_Private_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		static FixedBufferStringQueue()
		{
			Il2CppClassPointerStore<FixedBufferStringQueue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, "FixedBufferStringQueue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FixedBufferStringQueue>.NativeClassPtr);
			NativeFieldInfoPtr_m_ReadCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedBufferStringQueue>.NativeClassPtr, "m_ReadCursor");
			NativeFieldInfoPtr_m_WriteCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedBufferStringQueue>.NativeClassPtr, "m_WriteCursor");
			NativeFieldInfoPtr_m_BufferEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedBufferStringQueue>.NativeClassPtr, "m_BufferEnd");
			NativeFieldInfoPtr_m_BufferStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedBufferStringQueue>.NativeClassPtr, "m_BufferStart");
			NativeFieldInfoPtr_m_BufferLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedBufferStringQueue>.NativeClassPtr, "m_BufferLength");
			NativeFieldInfoPtr__Count_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedBufferStringQueue>.NativeClassPtr, "<Count>k__BackingField");
			NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedBufferStringQueue>.NativeClassPtr, 100664349);
			NativeMethodInfoPtr_set_Count_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedBufferStringQueue>.NativeClassPtr, 100664350);
			NativeMethodInfoPtr__ctor_Public_Void_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedBufferStringQueue>.NativeClassPtr, 100664351);
			NativeMethodInfoPtr_TryPush_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedBufferStringQueue>.NativeClassPtr, 100664352);
			NativeMethodInfoPtr_TryPop_Public_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedBufferStringQueue>.NativeClassPtr, 100664353);
			NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedBufferStringQueue>.NativeClassPtr, 100664354);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028738, XrefRangeEnd = 1028739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FixedBufferStringQueue(byte* ptr, int length)
		{
			System.IntPtr* ptr2 = stackalloc System.IntPtr[2];
			*ptr2 = (nint)ptr;
			*(int**)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ptr_Byte_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr2, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028739, XrefRangeEnd = 1028741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryPush(string v)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(v);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryPush_Public_Boolean_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028741, XrefRangeEnd = 1028742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryPop(out string v)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			nint num = 0;
			*ptr = (nint)(&num);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryPop_Public_Boolean_byref_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			v = IL2CPP.Il2CppStringToManaged((System.IntPtr)num);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028742, XrefRangeEnd = 1028743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FixedBufferStringQueue>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public class IKeyGetter<TValue, TKey> : Il2CppObjectBase
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_TKey_byref_TValue_0;

		static IKeyGetter()
		{
			Il2CppClassPointerStore<IKeyGetter<TValue, TKey>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, "IKeyGetter`2"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)),
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr))
			})).TypeHandle.value);
			NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_TKey_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IKeyGetter<TValue, TKey>>.NativeClassPtr, 100664355);
		}

		[CallerCount(0)]
		public unsafe virtual TKey Get(ref TValue v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<TValue, object>(ref v));
			*ptr = (nint)(&intPtr);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_TKey_byref_TValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			System.IntPtr intPtr4 = intPtr;
			Unsafe.As<TValue, object>(ref v) = ((intPtr4 == (System.IntPtr)0) ? ((TValue)null) : IL2CPP.PointerToValueGeneric<TValue>(intPtr4, false, false));
			return IL2CPP.PointerToValueGeneric<TKey>(intPtr3, false, true);
		}

		public IKeyGetter(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class DefaultKeyGetter<T> : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_T_byref_T_0;

		static DefaultKeyGetter()
		{
			Il2CppClassPointerStore<DefaultKeyGetter<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, "DefaultKeyGetter`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultKeyGetter<T>>.NativeClassPtr);
			NativeMethodInfoPtr_Get_Public_Virtual_Final_New_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultKeyGetter<T>>.NativeClassPtr, 100664356);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1028743, RefRangeEnd = 1028747, XrefRangeStart = 1028743, XrefRangeEnd = 1028743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual T Get(ref T v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<T, object>(ref v));
			*ptr = (nint)(&intPtr);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Virtual_Final_New_T_byref_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			System.IntPtr intPtr4 = intPtr;
			Unsafe.As<T, object>(ref v) = ((intPtr4 == (System.IntPtr)0) ? ((T)null) : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			return IL2CPP.PointerToValueGeneric<T>(intPtr3, false, true);
		}

		public DefaultKeyGetter(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public DefaultKeyGetter()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultKeyGetter<T>>.NativeClassPtr))
		{
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct UintKeyGetter
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_UInt32_byref_UInt32_0;

		static UintKeyGetter()
		{
			Il2CppClassPointerStore<UintKeyGetter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, "UintKeyGetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UintKeyGetter>.NativeClassPtr);
			NativeMethodInfoPtr_Get_Public_Virtual_Final_New_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UintKeyGetter>.NativeClassPtr, 100664357);
		}

		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 498700, RefRangeEnd = 498709, XrefRangeStart = 498700, XrefRangeEnd = 498709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual uint Get(ref uint v)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)Unsafe.AsPointer(ref v);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Virtual_Final_New_UInt32_byref_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UintKeyGetter>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct UlongKeyGetter
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_UInt64_byref_UInt64_0;

		static UlongKeyGetter()
		{
			Il2CppClassPointerStore<UlongKeyGetter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, "UlongKeyGetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UlongKeyGetter>.NativeClassPtr);
			NativeMethodInfoPtr_Get_Public_Virtual_Final_New_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UlongKeyGetter>.NativeClassPtr, 100664358);
		}

		[CallerCount(0)]
		public unsafe virtual ulong Get(ref ulong v)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)Unsafe.AsPointer(ref v);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Virtual_Final_New_UInt64_byref_UInt64_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UlongKeyGetter>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private sealed class MethodInfoStoreGeneric_CopyTo_Public_Static_Void_List_1_T_ptr_Void_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_CopyTo_Public_Static_Void_List_1_T_ptr_Void_Int32_0, Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_CopyTo_Public_Static_Void_Il2CppArrayBase_1_T_ptr_Void_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_CopyTo_Public_Static_Void_Il2CppArrayBase_1_T_ptr_Void_Int32_0, Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_QuickSort_Public_Static_Void_Int32_ptr_Void_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(CoreUnsafeUtils.NativeMethodInfoPtr_QuickSort_Public_Static_Void_Int32_ptr_Void_0, Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_QuickSort_Public_Static_Void_Int32_ptr_Void_0<TValue, TKey, TGetter>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(CoreUnsafeUtils.NativeMethodInfoPtr_QuickSort_Public_Static_Void_Int32_ptr_Void_0, Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TGetter>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_QuickSort_Public_Static_Void_ptr_Void_Int32_Int32_0<TValue, TKey, TGetter>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_QuickSort_Public_Static_Void_ptr_Void_Int32_Int32_0, Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TGetter>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_IndexOf_Public_Static_Int32_ptr_Void_Int32_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_IndexOf_Public_Static_Int32_ptr_Void_Int32_T_0, Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_CompareHashes_Public_Static_Int32_Int32_ptr_Void_Int32_ptr_Void_ptr_Int32_ptr_Int32_byref_Int32_byref_Int32_0<TOldValue, TOldGetter, TNewValue, TNewGetter>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_CompareHashes_Public_Static_Int32_Int32_ptr_Void_Int32_ptr_Void_ptr_Int32_ptr_Int32_byref_Int32_byref_Int32_0, Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[4]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOldValue>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOldGetter>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TNewValue>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TNewGetter>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_CombineHashes_Public_Static_Void_Int32_ptr_Void_ptr_Hash128_0<TValue, TGetter>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_CombineHashes_Public_Static_Void_Int32_ptr_Void_ptr_Hash128_0, Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TGetter>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_Partition_Private_Static_Int32_ptr_Void_Int32_Int32_0<TValue, TKey, TGetter>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Partition_Private_Static_Int32_ptr_Void_Int32_Int32_0, Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TGetter>.NativeClassPtr))
		}))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyTo_Public_Static_Void_List_1_T_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyTo_Public_Static_Void_Il2CppArrayBase_1_T_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateRadixParams_Private_Static_Void_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateRadixSupportSize_Private_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateRadixSortSupportArrays_Private_Static_Void_Int32_Int32_ptr_UInt32_byref_ptr_UInt32_byref_ptr_UInt32_byref_ptr_UInt32_byref_ptr_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MergeSort_Private_Static_Void_ptr_UInt32_ptr_UInt32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MergeSort_Public_Static_Void_Il2CppStructArray_1_UInt32_Int32_byref_Il2CppStructArray_1_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MergeSort_Public_Static_Void_NativeArray_1_UInt32_Int32_byref_NativeArray_1_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InsertionSort_Private_Static_Void_ptr_UInt32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InsertionSort_Public_Static_Void_Il2CppStructArray_1_UInt32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InsertionSort_Public_Static_Void_NativeArray_1_UInt32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RadixSort_Private_Static_Void_ptr_UInt32_ptr_UInt32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RadixSort_Public_Static_Void_Il2CppStructArray_1_UInt32_Int32_byref_Il2CppStructArray_1_UInt32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RadixSort_Public_Static_Void_NativeArray_1_UInt32_Int32_byref_NativeArray_1_UInt32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QuickSort_Public_Static_Void_Il2CppStructArray_1_UInt32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QuickSort_Public_Static_Void_Il2CppStructArray_1_UInt64_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QuickSort_Public_Static_Void_Int32_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QuickSort_Public_Static_Void_Int32_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QuickSort_Public_Static_Void_ptr_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOf_Public_Static_Int32_ptr_Void_Int32_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareHashes_Public_Static_Int32_Int32_ptr_Void_Int32_ptr_Void_ptr_Int32_ptr_Int32_byref_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareHashes_Public_Static_Int32_Int32_ptr_Hash128_Int32_ptr_Hash128_ptr_Int32_ptr_Int32_byref_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CombineHashes_Public_Static_Void_Int32_ptr_Void_ptr_Hash128_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CombineHashes_Public_Static_Void_Int32_ptr_Hash128_ptr_Hash128_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Partition_Private_Static_Int32_ptr_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveDuplicates_Public_Static_Boolean_Il2CppStructArray_1_Int32_0;

	static CoreUnsafeUtils()
	{
		Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "CoreUnsafeUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr);
		NativeMethodInfoPtr_CopyTo_Public_Static_Void_List_1_T_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100664323);
		NativeMethodInfoPtr_CopyTo_Public_Static_Void_Il2CppArrayBase_1_T_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100664324);
		NativeMethodInfoPtr_CalculateRadixParams_Private_Static_Void_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100664325);
		NativeMethodInfoPtr_CalculateRadixSupportSize_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100664326);
		NativeMethodInfoPtr_CalculateRadixSortSupportArrays_Private_Static_Void_Int32_Int32_ptr_UInt32_byref_ptr_UInt32_byref_ptr_UInt32_byref_ptr_UInt32_byref_ptr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100664327);
		NativeMethodInfoPtr_MergeSort_Private_Static_Void_ptr_UInt32_ptr_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100664328);
		NativeMethodInfoPtr_MergeSort_Public_Static_Void_Il2CppStructArray_1_UInt32_Int32_byref_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100664329);
		NativeMethodInfoPtr_MergeSort_Public_Static_Void_NativeArray_1_UInt32_Int32_byref_NativeArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100664330);
		NativeMethodInfoPtr_InsertionSort_Private_Static_Void_ptr_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100664331);
		NativeMethodInfoPtr_InsertionSort_Public_Static_Void_Il2CppStructArray_1_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100664332);
		NativeMethodInfoPtr_InsertionSort_Public_Static_Void_NativeArray_1_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100664333);
		NativeMethodInfoPtr_RadixSort_Private_Static_Void_ptr_UInt32_ptr_UInt32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100664334);
		NativeMethodInfoPtr_RadixSort_Public_Static_Void_Il2CppStructArray_1_UInt32_Int32_byref_Il2CppStructArray_1_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100664335);
		NativeMethodInfoPtr_RadixSort_Public_Static_Void_NativeArray_1_UInt32_Int32_byref_NativeArray_1_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100664336);
		NativeMethodInfoPtr_QuickSort_Public_Static_Void_Il2CppStructArray_1_UInt32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100664337);
		NativeMethodInfoPtr_QuickSort_Public_Static_Void_Il2CppStructArray_1_UInt64_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100664338);
		CoreUnsafeUtils.NativeMethodInfoPtr_QuickSort_Public_Static_Void_Int32_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100664339);
		CoreUnsafeUtils.NativeMethodInfoPtr_QuickSort_Public_Static_Void_Int32_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100664340);
		NativeMethodInfoPtr_QuickSort_Public_Static_Void_ptr_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100664341);
		NativeMethodInfoPtr_IndexOf_Public_Static_Int32_ptr_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100664342);
		NativeMethodInfoPtr_CompareHashes_Public_Static_Int32_Int32_ptr_Void_Int32_ptr_Void_ptr_Int32_ptr_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100664343);
		NativeMethodInfoPtr_CompareHashes_Public_Static_Int32_Int32_ptr_Hash128_Int32_ptr_Hash128_ptr_Int32_ptr_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100664344);
		NativeMethodInfoPtr_CombineHashes_Public_Static_Void_Int32_ptr_Void_ptr_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100664345);
		NativeMethodInfoPtr_CombineHashes_Public_Static_Void_Int32_ptr_Hash128_ptr_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100664346);
		NativeMethodInfoPtr_Partition_Private_Static_Int32_ptr_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100664347);
		NativeMethodInfoPtr_HaveDuplicates_Public_Static_Boolean_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUnsafeUtils>.NativeClassPtr, 100664348);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028747, XrefRangeEnd = 1028749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyTo<T>(this List<T> list, void* dest, int count) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = dest;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_CopyTo_Public_Static_Void_List_1_T_ptr_Void_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1028750, RefRangeEnd = 1028751, XrefRangeStart = 1028749, XrefRangeEnd = 1028750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyTo<T>(this Il2CppArrayBase<T> list, void* dest, int count) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = dest;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_CopyTo_Public_Static_Void_Il2CppArrayBase_1_T_ptr_Void_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void CalculateRadixParams(int radixBits, out int bitStates)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&radixBits);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref bitStates);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateRadixParams_Private_Static_Void_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static int CalculateRadixSupportSize(int bitStates, int arrayLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&bitStates);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &arrayLength;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateRadixSupportSize_Private_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static void CalculateRadixSortSupportArrays(int bitStates, int arrayLength, uint* supportArray, out uint* bucketIndices, out uint* bucketSizes, out uint* bucketPrefix, out uint* arrayOutput)
	{
		//IL_0093->IL0095: Incompatible stack types: I vs O
		//IL_00a5->IL00a7: Incompatible stack types: I vs O
		//IL_00b7->IL00b9: Incompatible stack types: I vs O
		//IL_00c9->IL00cb: Incompatible stack types: I vs O
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&bitStates);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &arrayLength;
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = supportArray;
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		byte* num3 = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		byte* num5 = (byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num6 = 0;
		*(nint**)num5 = &num6;
		byte* num7 = (byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num8 = 0;
		*(nint**)num7 = &num8;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateRadixSortSupportArrays_Private_Static_Void_Int32_Int32_ptr_UInt32_byref_ptr_UInt32_byref_ptr_UInt32_byref_ptr_UInt32_byref_ptr_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num9 = num2;
		Unsafe.As<uint*, object>(ref bucketIndices) = ((num9 == 0) ? null : ((object)new uint*((System.IntPtr)num9)));
		nint num10 = num4;
		Unsafe.As<uint*, object>(ref bucketSizes) = ((num10 == 0) ? null : ((object)new uint*((System.IntPtr)num10)));
		nint num11 = num6;
		Unsafe.As<uint*, object>(ref bucketPrefix) = ((num11 == 0) ? null : ((object)new uint*((System.IntPtr)num11)));
		nint num12 = num8;
		Unsafe.As<uint*, object>(ref arrayOutput) = ((num12 == 0) ? null : ((object)new uint*((System.IntPtr)num12)));
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1028753, RefRangeEnd = 1028755, XrefRangeStart = 1028751, XrefRangeEnd = 1028753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MergeSort(uint* array, uint* support, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)array;
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = support;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MergeSort_Private_Static_Void_ptr_UInt32_ptr_UInt32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028755, XrefRangeEnd = 1028765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MergeSort(Il2CppStructArray<uint> arr, int sortSize, ref Il2CppStructArray<uint> supportArray)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sortSize;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)supportArray);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MergeSort_Public_Static_Void_Il2CppStructArray_1_UInt32_Int32_byref_Il2CppStructArray_1_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		supportArray = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<uint>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028765, XrefRangeEnd = 1028779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MergeSort(NativeArray<uint> arr, int sortSize, ref NativeArray<uint> supportArray)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)arr));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sortSize;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)supportArray);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MergeSort_Public_Static_Void_NativeArray_1_UInt32_Int32_byref_NativeArray_1_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void InsertionSort(uint* arr, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)arr;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsertionSort_Private_Static_Void_ptr_UInt32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028779, XrefRangeEnd = 1028784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InsertionSort(Il2CppStructArray<uint> arr, int sortSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sortSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsertionSort_Public_Static_Void_Il2CppStructArray_1_UInt32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028784, XrefRangeEnd = 1028792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InsertionSort(NativeArray<uint> arr, int sortSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)arr));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sortSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsertionSort_Public_Static_Void_NativeArray_1_UInt32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1028793, RefRangeEnd = 1028795, XrefRangeStart = 1028792, XrefRangeEnd = 1028793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RadixSort(uint* array, uint* support, int radixBits, int bitStates, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)array;
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = support;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &radixBits;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitStates;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RadixSort_Private_Static_Void_ptr_UInt32_ptr_UInt32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028795, XrefRangeEnd = 1028806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RadixSort(Il2CppStructArray<uint> arr, int sortSize, ref Il2CppStructArray<uint> supportArray, int radixBits = 8)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sortSize;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)supportArray);
		*(System.IntPtr**)num = &intPtr;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &radixBits;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RadixSort_Public_Static_Void_Il2CppStructArray_1_UInt32_Int32_byref_Il2CppStructArray_1_UInt32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		supportArray = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<uint>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028806, XrefRangeEnd = 1028820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RadixSort(NativeArray<uint> array, int sortSize, ref NativeArray<uint> supportArray, int radixBits = 8)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)array));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sortSize;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)supportArray);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &radixBits;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RadixSort_Public_Static_Void_NativeArray_1_UInt32_Int32_byref_NativeArray_1_UInt32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028820, XrefRangeEnd = 1028825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void QuickSort(Il2CppStructArray<uint> arr, int left, int right)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &left;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &right;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QuickSort_Public_Static_Void_Il2CppStructArray_1_UInt32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028825, XrefRangeEnd = 1028830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void QuickSort(Il2CppStructArray<ulong> arr, int left, int right)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &left;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &right;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QuickSort_Public_Static_Void_Il2CppStructArray_1_UInt64_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1028842, RefRangeEnd = 1028844, XrefRangeStart = 1028830, XrefRangeEnd = 1028842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void QuickSort<T>(int count, void* data) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&count);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = data;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_QuickSort_Public_Static_Void_Int32_ptr_Void_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028844, XrefRangeEnd = 1028846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void QuickSort<TValue, TKey, TGetter>(int count, void* data) where TValue : new() where TKey : new() where TGetter : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&count);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = data;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_QuickSort_Public_Static_Void_Int32_ptr_Void_0<TValue, TKey, TGetter>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1028856, RefRangeEnd = 1028857, XrefRangeStart = 1028846, XrefRangeEnd = 1028856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void QuickSort<TValue, TKey, TGetter>(void* data, int left, int right) where TValue : new() where TKey : new() where TGetter : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)data;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &left;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &right;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_QuickSort_Public_Static_Void_ptr_Void_Int32_Int32_0<TValue, TKey, TGetter>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028857, XrefRangeEnd = 1028868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int IndexOf<T>(void* data, int count, T v) where T : new()
	{
		//IL_0060->IL0063: Incompatible stack types: I vs Ref
		//IL_0053->IL0063: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)data;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = v;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref v;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_IndexOf_Public_Static_Int32_ptr_Void_Int32_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1028888, RefRangeEnd = 1028889, XrefRangeStart = 1028868, XrefRangeEnd = 1028888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CompareHashes<TOldValue, TOldGetter, TNewValue, TNewGetter>(int oldHashCount, void* oldHashes, int newHashCount, void* newHashes, int* addIndices, int* removeIndices, out int addCount, out int remCount) where TOldValue : new() where TOldGetter : new() where TNewValue : new() where TNewGetter : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&oldHashCount);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = oldHashes;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &newHashCount;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = newHashes;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = addIndices;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = removeIndices;
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref addCount);
		*(void**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref remCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_CompareHashes_Public_Static_Int32_Int32_ptr_Void_Int32_ptr_Void_ptr_Int32_ptr_Int32_byref_Int32_byref_Int32_0<TOldValue, TOldGetter, TNewValue, TNewGetter>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028889, XrefRangeEnd = 1028892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CompareHashes(int oldHashCount, Hash128* oldHashes, int newHashCount, Hash128* newHashes, int* addIndices, int* removeIndices, out int addCount, out int remCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&oldHashCount);
		*(Hash128**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = oldHashes;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &newHashCount;
		*(Hash128**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = newHashes;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = addIndices;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = removeIndices;
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref addCount);
		*(void**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref remCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareHashes_Public_Static_Int32_Int32_ptr_Hash128_Int32_ptr_Hash128_ptr_Int32_ptr_Int32_byref_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1028896, RefRangeEnd = 1028897, XrefRangeStart = 1028892, XrefRangeEnd = 1028896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CombineHashes<TValue, TGetter>(int count, void* hashes, Hash128* outHash) where TValue : new() where TGetter : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&count);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = hashes;
		*(Hash128**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = outHash;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_CombineHashes_Public_Static_Void_Int32_ptr_Void_ptr_Hash128_0<TValue, TGetter>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028897, XrefRangeEnd = 1028900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CombineHashes(int count, Hash128* hashes, Hash128* outHash)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&count);
		*(Hash128**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = hashes;
		*(Hash128**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = outHash;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CombineHashes_Public_Static_Void_Int32_ptr_Hash128_ptr_Hash128_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028900, XrefRangeEnd = 1028907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Partition<TValue, TKey, TGetter>(void* data, int left, int right) where TValue : new() where TKey : new() where TGetter : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)data;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &left;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &right;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Partition_Private_Static_Int32_ptr_Void_Int32_Int32_0<TValue, TKey, TGetter>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028907, XrefRangeEnd = 1028919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HaveDuplicates(Il2CppStructArray<int> arr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HaveDuplicates_Public_Static_Boolean_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public CoreUnsafeUtils(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
