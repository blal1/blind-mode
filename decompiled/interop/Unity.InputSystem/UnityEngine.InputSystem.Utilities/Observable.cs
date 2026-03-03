using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.InputSystem.LowLevel;

namespace UnityEngine.InputSystem.Utilities;

public static class Observable : Il2CppSystem.Object
{
	[ObfuscatedName("UnityEngine.InputSystem.Utilities.Observable+<>c__DisplayClass6_0`1")]
	public sealed class __c__DisplayClass6_0<TValue> : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_subscription;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__CallOnce_b__0_Internal_Void_0;

		public unsafe Il2CppSystem.IDisposable subscription
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subscription);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IDisposable>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subscription)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c__DisplayClass6_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass6_0<TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Observable>.NativeClassPtr, "<>c__DisplayClass6_0`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass6_0<TValue>>.NativeClassPtr);
			NativeFieldInfoPtr_subscription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass6_0<TValue>>.NativeClassPtr, "subscription");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass6_0<TValue>>.NativeClassPtr, 100668888);
			NativeMethodInfoPtr__CallOnce_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass6_0<TValue>>.NativeClassPtr, 100668889);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass6_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass6_0<TValue>>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020371, XrefRangeEnd = 1020374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _CallOnce_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__CallOnce_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public __c__DisplayClass6_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_Where_Public_Static_IObservable_1_TValue_IObservable_1_TValue_Func_2_TValue_Boolean_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Where_Public_Static_IObservable_1_TValue_IObservable_1_TValue_Func_2_TValue_Boolean_0, Il2CppClassPointerStore<Observable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Select_Public_Static_IObservable_1_TResult_IObservable_1_TSource_Func_2_TSource_TResult_0<TSource, TResult>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Select_Public_Static_IObservable_1_TResult_IObservable_1_TSource_Func_2_TSource_TResult_0, Il2CppClassPointerStore<Observable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_SelectMany_Public_Static_IObservable_1_TResult_IObservable_1_TSource_Func_2_TSource_IEnumerable_1_TResult_0<TSource, TResult>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SelectMany_Public_Static_IObservable_1_TResult_IObservable_1_TSource_Func_2_TSource_IEnumerable_1_TResult_0, Il2CppClassPointerStore<Observable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_Take_Public_Static_IObservable_1_TValue_IObservable_1_TValue_Int32_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Take_Public_Static_IObservable_1_TValue_IObservable_1_TValue_Int32_0, Il2CppClassPointerStore<Observable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_ForDevice_Public_Static_IObservable_1_InputEventPtr_IObservable_1_InputEventPtr_0<TDevice>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ForDevice_Public_Static_IObservable_1_InputEventPtr_IObservable_1_InputEventPtr_0, Il2CppClassPointerStore<Observable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDevice>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_CallOnce_Public_Static_IDisposable_IObservable_1_TValue_Action_1_TValue_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_CallOnce_Public_Static_IDisposable_IObservable_1_TValue_Action_1_TValue_0, Il2CppClassPointerStore<Observable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Call_Public_Static_IDisposable_IObservable_1_TValue_Action_1_TValue_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Call_Public_Static_IDisposable_IObservable_1_TValue_Action_1_TValue_0, Il2CppClassPointerStore<Observable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_Where_Public_Static_IObservable_1_TValue_IObservable_1_TValue_Func_2_TValue_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Select_Public_Static_IObservable_1_TResult_IObservable_1_TSource_Func_2_TSource_TResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectMany_Public_Static_IObservable_1_TResult_IObservable_1_TSource_Func_2_TSource_IEnumerable_1_TResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Take_Public_Static_IObservable_1_TValue_IObservable_1_TValue_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForDevice_Public_Static_IObservable_1_InputEventPtr_IObservable_1_InputEventPtr_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForDevice_Public_Static_IObservable_1_InputEventPtr_IObservable_1_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallOnce_Public_Static_IDisposable_IObservable_1_TValue_Action_1_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Call_Public_Static_IDisposable_IObservable_1_TValue_Action_1_TValue_0;

	static Observable()
	{
		Il2CppClassPointerStore<Observable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.Utilities", "Observable");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Observable>.NativeClassPtr);
		NativeMethodInfoPtr_Where_Public_Static_IObservable_1_TValue_IObservable_1_TValue_Func_2_TValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Observable>.NativeClassPtr, 100668880);
		NativeMethodInfoPtr_Select_Public_Static_IObservable_1_TResult_IObservable_1_TSource_Func_2_TSource_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Observable>.NativeClassPtr, 100668881);
		NativeMethodInfoPtr_SelectMany_Public_Static_IObservable_1_TResult_IObservable_1_TSource_Func_2_TSource_IEnumerable_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Observable>.NativeClassPtr, 100668882);
		NativeMethodInfoPtr_Take_Public_Static_IObservable_1_TValue_IObservable_1_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Observable>.NativeClassPtr, 100668883);
		NativeMethodInfoPtr_ForDevice_Public_Static_IObservable_1_InputEventPtr_IObservable_1_InputEventPtr_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Observable>.NativeClassPtr, 100668884);
		NativeMethodInfoPtr_ForDevice_Public_Static_IObservable_1_InputEventPtr_IObservable_1_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Observable>.NativeClassPtr, 100668885);
		NativeMethodInfoPtr_CallOnce_Public_Static_IDisposable_IObservable_1_TValue_Action_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Observable>.NativeClassPtr, 100668886);
		NativeMethodInfoPtr_Call_Public_Static_IDisposable_IObservable_1_TValue_Action_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Observable>.NativeClassPtr, 100668887);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1020378, RefRangeEnd = 1020379, XrefRangeStart = 1020374, XrefRangeEnd = 1020378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.IObservable<TValue> Where<TValue>(this Il2CppSystem.IObservable<TValue> source, Il2CppSystem.Func<TValue, bool> predicate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Where_Public_Static_IObservable_1_TValue_IObservable_1_TValue_Func_2_TValue_Boolean_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IObservable<TValue>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1020383, RefRangeEnd = 1020384, XrefRangeStart = 1020379, XrefRangeEnd = 1020383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.IObservable<TResult> Select<TSource, TResult>(this Il2CppSystem.IObservable<TSource> source, Il2CppSystem.Func<TSource, TResult> filter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)filter);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Select_Public_Static_IObservable_1_TResult_IObservable_1_TSource_Func_2_TSource_TResult_0<TSource, TResult>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IObservable<TResult>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020384, XrefRangeEnd = 1020387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.IObservable<TResult> SelectMany<TSource, TResult>(this Il2CppSystem.IObservable<TSource> source, Il2CppSystem.Func<TSource, IEnumerable<TResult>> filter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)filter);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SelectMany_Public_Static_IObservable_1_TResult_IObservable_1_TSource_Func_2_TSource_IEnumerable_1_TResult_0<TSource, TResult>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IObservable<TResult>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020387, XrefRangeEnd = 1020390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.IObservable<TValue> Take<TValue>(this Il2CppSystem.IObservable<TValue> source, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Take_Public_Static_IObservable_1_TValue_IObservable_1_TValue_Int32_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IObservable<TValue>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020390, XrefRangeEnd = 1020397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.IObservable<InputEventPtr> ForDevice(this Il2CppSystem.IObservable<InputEventPtr> source, InputDevice device)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForDevice_Public_Static_IObservable_1_InputEventPtr_IObservable_1_InputEventPtr_InputDevice_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IObservable<InputEventPtr>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020397, XrefRangeEnd = 1020405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.IObservable<InputEventPtr> ForDevice<TDevice>(this Il2CppSystem.IObservable<InputEventPtr> source) where TDevice : InputDevice
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ForDevice_Public_Static_IObservable_1_InputEventPtr_IObservable_1_InputEventPtr_0<TDevice>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IObservable<InputEventPtr>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020405, XrefRangeEnd = 1020418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.IDisposable CallOnce<TValue>(this Il2CppSystem.IObservable<TValue> source, Il2CppSystem.Action<TValue> action)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_CallOnce_Public_Static_IDisposable_IObservable_1_TValue_Action_1_TValue_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IDisposable>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020418, XrefRangeEnd = 1020433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.IDisposable Call<TValue>(this Il2CppSystem.IObservable<TValue> source, Il2CppSystem.Action<TValue> action)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Call_Public_Static_IDisposable_IObservable_1_TValue_Action_1_TValue_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IDisposable>(intPtr2) : null;
	}

	public Observable(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
