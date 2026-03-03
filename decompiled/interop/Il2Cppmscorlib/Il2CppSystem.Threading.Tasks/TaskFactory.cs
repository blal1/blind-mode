using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Threading.Tasks;

public class TaskFactory<TResult> : Object
{
	public sealed class FromAsyncTrimPromise<TInstance> : Task<TResult> where TInstance : class
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_s_completeFromAsyncResult;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_thisRef;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_endMethod;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TInstance_Func_3_TInstance_IAsyncResult_TResult_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CompleteFromAsyncResult_Internal_Static_Void_IAsyncResult_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Complete_Internal_Void_TInstance_Func_3_TInstance_IAsyncResult_TResult_IAsyncResult_Boolean_0;

		public unsafe static AsyncCallback s_completeFromAsyncResult
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_completeFromAsyncResult, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_completeFromAsyncResult, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe TInstance m_thisRef
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_thisRef);
				return IL2CPP.PointerToValueGeneric<TInstance>((System.IntPtr)num, true, false);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				nint num2 = (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_thisRef);
				System.Type typeFromHandle = typeof(TInstance);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((value is Il2CppObjectBase) ? value : null));
						if (intPtr != (System.IntPtr)0 && IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr)))
						{
							System.IntPtr intPtr2 = intPtr;
							// IL cpblk instruction
							Unsafe.CopyBlock(num2, IL2CPP.il2cpp_object_unbox(intPtr), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr2), ref *(uint*)null));
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)num2, intPtr);
						}
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)num2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					Unsafe.Write((void*)num2, value);
				}
			}
		}

		public unsafe Func<TInstance, IAsyncResult, TResult> m_endMethod
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_endMethod);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Func<TInstance, IAsyncResult, TResult>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_endMethod)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static FromAsyncTrimPromise()
		{
			Il2CppClassPointerStore<FromAsyncTrimPromise<TInstance>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, "FromAsyncTrimPromise`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[2]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TInstance>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FromAsyncTrimPromise<TInstance>>.NativeClassPtr);
			NativeFieldInfoPtr_s_completeFromAsyncResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FromAsyncTrimPromise<TInstance>>.NativeClassPtr, "s_completeFromAsyncResult");
			NativeFieldInfoPtr_m_thisRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FromAsyncTrimPromise<TInstance>>.NativeClassPtr, "m_thisRef");
			NativeFieldInfoPtr_m_endMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FromAsyncTrimPromise<TInstance>>.NativeClassPtr, "m_endMethod");
			NativeMethodInfoPtr__ctor_Internal_Void_TInstance_Func_3_TInstance_IAsyncResult_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FromAsyncTrimPromise<TInstance>>.NativeClassPtr, 100668201);
			NativeMethodInfoPtr_CompleteFromAsyncResult_Internal_Static_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FromAsyncTrimPromise<TInstance>>.NativeClassPtr, 100668202);
			NativeMethodInfoPtr_Complete_Internal_Void_TInstance_Func_3_TInstance_IAsyncResult_TResult_IAsyncResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FromAsyncTrimPromise<TInstance>>.NativeClassPtr, 100668203);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 773288, RefRangeEnd = 773289, XrefRangeStart = 773279, XrefRangeEnd = 773288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FromAsyncTrimPromise(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FromAsyncTrimPromise<TInstance>>.NativeClassPtr))
		{
			//IL_0055->IL0058: Incompatible stack types: I vs Ref
			//IL_0048->IL0058: Incompatible stack types: I vs Ref
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			ref TInstance reference;
			if (!typeof(TInstance).IsValueType)
			{
				TInstance val = thisRef;
				reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
			}
			else
			{
				reference = ref thisRef;
			}
			*ptr = (nint)Unsafe.AsPointer(ref reference);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)endMethod);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_TInstance_Func_3_TInstance_IAsyncResult_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773289, XrefRangeEnd = 773299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CompleteFromAsyncResult(IAsyncResult asyncResult)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asyncResult);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompleteFromAsyncResult_Internal_Static_Void_IAsyncResult_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 773304, RefRangeEnd = 773306, XrefRangeStart = 773299, XrefRangeEnd = 773304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod, IAsyncResult asyncResult, bool requiresSynchronization)
		{
			//IL_004c->IL004f: Incompatible stack types: I vs Ref
			//IL_003f->IL004f: Incompatible stack types: I vs Ref
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			ref TInstance reference;
			if (!typeof(TInstance).IsValueType)
			{
				TInstance val = thisRef;
				reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
			}
			else
			{
				reference = ref thisRef;
			}
			*ptr = (nint)Unsafe.AsPointer(ref reference);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)endMethod);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asyncResult);
			*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &requiresSynchronization;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Complete_Internal_Void_TInstance_Func_3_TInstance_IAsyncResult_TResult_IAsyncResult_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public FromAsyncTrimPromise(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("System.Threading.Tasks.TaskFactory`1+<>c__DisplayClass35_0")]
	public sealed class __c__DisplayClass35_0 : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_endFunction;

		private static readonly System.IntPtr NativeFieldInfoPtr_endAction;

		private static readonly System.IntPtr NativeFieldInfoPtr_promise;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__FromAsyncImpl_b__0_Internal_Void_IAsyncResult_0;

		public unsafe Func<IAsyncResult, TResult> endFunction
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endFunction);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Func<IAsyncResult, TResult>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endFunction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Action<IAsyncResult> endAction
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endAction);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Action<IAsyncResult>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endAction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Task<TResult> promise
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_promise);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_promise)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c__DisplayClass35_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, "<>c__DisplayClass35_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass35_0>.NativeClassPtr);
			NativeFieldInfoPtr_endFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass35_0>.NativeClassPtr, "endFunction");
			NativeFieldInfoPtr_endAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass35_0>.NativeClassPtr, "endAction");
			NativeFieldInfoPtr_promise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass35_0>.NativeClassPtr, "promise");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass35_0>.NativeClassPtr, 100668205);
			NativeMethodInfoPtr__FromAsyncImpl_b__0_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass35_0>.NativeClassPtr, 100668206);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass35_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass35_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773306, XrefRangeEnd = 773310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _FromAsyncImpl_b__0(IAsyncResult iar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iar);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__FromAsyncImpl_b__0_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public __c__DisplayClass35_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("System.Threading.Tasks.TaskFactory`1+<>c__DisplayClass38_0`1")]
	public sealed class __c__DisplayClass38_0<TArg1> : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_endFunction;

		private static readonly System.IntPtr NativeFieldInfoPtr_endAction;

		private static readonly System.IntPtr NativeFieldInfoPtr_promise;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__FromAsyncImpl_b__0_Internal_Void_IAsyncResult_0;

		public unsafe Func<IAsyncResult, TResult> endFunction
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endFunction);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Func<IAsyncResult, TResult>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endFunction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Action<IAsyncResult> endAction
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endAction);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Action<IAsyncResult>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endAction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Task<TResult> promise
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_promise);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_promise)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c__DisplayClass38_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass38_0<TArg1>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, "<>c__DisplayClass38_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[2]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg1>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass38_0<TArg1>>.NativeClassPtr);
			NativeFieldInfoPtr_endFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass38_0<TArg1>>.NativeClassPtr, "endFunction");
			NativeFieldInfoPtr_endAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass38_0<TArg1>>.NativeClassPtr, "endAction");
			NativeFieldInfoPtr_promise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass38_0<TArg1>>.NativeClassPtr, "promise");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass38_0<TArg1>>.NativeClassPtr, 100668207);
			NativeMethodInfoPtr__FromAsyncImpl_b__0_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass38_0<TArg1>>.NativeClassPtr, 100668208);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass38_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass38_0<TArg1>>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773310, XrefRangeEnd = 773314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _FromAsyncImpl_b__0(IAsyncResult iar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iar);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__FromAsyncImpl_b__0_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public __c__DisplayClass38_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("System.Threading.Tasks.TaskFactory`1+<>c__DisplayClass41_0`2")]
	public sealed class __c__DisplayClass41_0<TArg1, TArg2> : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_endFunction;

		private static readonly System.IntPtr NativeFieldInfoPtr_endAction;

		private static readonly System.IntPtr NativeFieldInfoPtr_promise;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__FromAsyncImpl_b__0_Internal_Void_IAsyncResult_0;

		public unsafe Func<IAsyncResult, TResult> endFunction
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endFunction);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Func<IAsyncResult, TResult>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endFunction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Action<IAsyncResult> endAction
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endAction);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Action<IAsyncResult>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endAction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Task<TResult> promise
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_promise);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_promise)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c__DisplayClass41_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass41_0<TArg1, TArg2>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, "<>c__DisplayClass41_0`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[3]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg2>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass41_0<TArg1, TArg2>>.NativeClassPtr);
			NativeFieldInfoPtr_endFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass41_0<TArg1, TArg2>>.NativeClassPtr, "endFunction");
			NativeFieldInfoPtr_endAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass41_0<TArg1, TArg2>>.NativeClassPtr, "endAction");
			NativeFieldInfoPtr_promise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass41_0<TArg1, TArg2>>.NativeClassPtr, "promise");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass41_0<TArg1, TArg2>>.NativeClassPtr, 100668209);
			NativeMethodInfoPtr__FromAsyncImpl_b__0_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass41_0<TArg1, TArg2>>.NativeClassPtr, 100668210);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass41_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass41_0<TArg1, TArg2>>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773314, XrefRangeEnd = 773318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _FromAsyncImpl_b__0(IAsyncResult iar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iar);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__FromAsyncImpl_b__0_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public __c__DisplayClass41_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_FromAsync_Public_Task_1_TResult_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_TArg1_Object_0
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(TaskFactory<TResult>.NativeMethodInfoPtr_FromAsync_Public_Task_1_TResult_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_TArg1_Object_0, Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(TaskFactory<TResult>.NativeMethodInfoPtr_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0, Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_5_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_TArg1_TArg2_Object_TaskCreationOptions_0<TArg2>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(TaskFactory<TResult>.NativeMethodInfoPtr_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_5_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_TArg1_TArg2_Object_TaskCreationOptions_0, Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[2]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg2>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_FromAsyncTrim_Internal_Static_Task_1_TResult_TInstance_TArgs_Func_5_TInstance_TArgs_AsyncCallback_Object_IAsyncResult_Func_3_TInstance_IAsyncResult_TResult_0<TArgs>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(TaskFactory<TResult>.NativeMethodInfoPtr_FromAsyncTrim_Internal_Static_Task_1_TResult_TInstance_TArgs_Func_5_TInstance_TArgs_AsyncCallback_Object_IAsyncResult_Func_3_TInstance_IAsyncResult_TResult_0, Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[2]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArgs>.NativeClassPtr))
		}))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_defaultCancellationToken;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_defaultScheduler;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_defaultCreationOptions;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_defaultContinuationOptions;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CancellationToken_TaskCreationOptions_TaskContinuationOptions_TaskScheduler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromAsyncCoreLogic_Private_Static_Void_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_Task_1_TResult_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromAsync_Public_Task_1_TResult_Func_3_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_3_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_Object_TaskCreationOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromAsync_Public_Task_1_TResult_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_TArg1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_5_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_TArg1_TArg2_Object_TaskCreationOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromAsyncTrim_Internal_Static_Task_1_TResult_TInstance_TArgs_Func_5_TInstance_TArgs_AsyncCallback_Object_IAsyncResult_Func_3_TInstance_IAsyncResult_TResult_0;

	public unsafe CancellationToken m_defaultCancellationToken
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultCancellationToken);
			return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultCancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe TaskScheduler m_defaultScheduler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultScheduler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TaskScheduler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultScheduler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe TaskCreationOptions m_defaultCreationOptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultCreationOptions);
			return *(TaskCreationOptions*)num;
		}
		set
		{
			*(TaskCreationOptions*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultCreationOptions)) = value;
		}
	}

	public unsafe TaskContinuationOptions m_defaultContinuationOptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultContinuationOptions);
			return *(TaskContinuationOptions*)num;
		}
		set
		{
			*(TaskContinuationOptions*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultContinuationOptions)) = value;
		}
	}

	static TaskFactory()
	{
		Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "TaskFactory`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr);
		NativeFieldInfoPtr_m_defaultCancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, "m_defaultCancellationToken");
		NativeFieldInfoPtr_m_defaultScheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, "m_defaultScheduler");
		NativeFieldInfoPtr_m_defaultCreationOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, "m_defaultCreationOptions");
		NativeFieldInfoPtr_m_defaultContinuationOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, "m_defaultContinuationOptions");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, 100668192);
		NativeMethodInfoPtr__ctor_Public_Void_CancellationToken_TaskCreationOptions_TaskContinuationOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, 100668193);
		NativeMethodInfoPtr_FromAsyncCoreLogic_Private_Static_Void_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_Task_1_TResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, 100668194);
		NativeMethodInfoPtr_FromAsync_Public_Task_1_TResult_Func_3_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, 100668195);
		NativeMethodInfoPtr_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_3_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_Object_TaskCreationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, 100668196);
		NativeMethodInfoPtr_FromAsync_Public_Task_1_TResult_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_TArg1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, 100668197);
		NativeMethodInfoPtr_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, 100668198);
		NativeMethodInfoPtr_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_5_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_TArg1_TArg2_Object_TaskCreationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, 100668199);
		NativeMethodInfoPtr_FromAsyncTrim_Internal_Static_Task_1_TResult_TInstance_TArgs_Func_5_TInstance_TArgs_AsyncCallback_Object_IAsyncResult_Func_3_TInstance_IAsyncResult_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, 100668200);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 773323, RefRangeEnd = 773324, XrefRangeStart = 773318, XrefRangeEnd = 773323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TaskFactory()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773324, XrefRangeEnd = 773329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cancellationToken));
		*(TaskCreationOptions**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &creationOptions;
		*(TaskContinuationOptions**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &continuationOptions;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scheduler);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_CancellationToken_TaskCreationOptions_TaskContinuationOptions_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 773339, RefRangeEnd = 773341, XrefRangeStart = 773329, XrefRangeEnd = 773339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FromAsyncCoreLogic(IAsyncResult iar, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, Task<TResult> promise, bool requiresSynchronization)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iar);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)endFunction);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)endAction);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)promise);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &requiresSynchronization;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromAsyncCoreLogic_Private_Static_Void_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_Task_1_TResult_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773341, XrefRangeEnd = 773342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Task<TResult> FromAsync(Func<AsyncCallback, Object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, Object state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)beginMethod);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)endMethod);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromAsync_Public_Task_1_TResult_Func_3_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 773379, RefRangeEnd = 773380, XrefRangeStart = 773342, XrefRangeEnd = 773379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Task<TResult> FromAsyncImpl(Func<AsyncCallback, Object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, Object state, TaskCreationOptions creationOptions)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)beginMethod);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)endFunction);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)endAction);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		*(TaskCreationOptions**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &creationOptions;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_3_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_Object_TaskCreationOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 773382, RefRangeEnd = 773383, XrefRangeStart = 773380, XrefRangeEnd = 773382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Task<TResult> FromAsync<TArg1>(Func<TArg1, AsyncCallback, Object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, Object state)
	{
		//IL_0070->IL0073: Incompatible stack types: I vs Ref
		//IL_0063->IL0073: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)beginMethod);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)endMethod);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TArg1 reference;
		if (!typeof(TArg1).IsValueType)
		{
			object obj = arg1;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref arg1;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TArg1>.MethodInfoStoreGeneric_FromAsync_Public_Task_1_TResult_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_TArg1_Object_0.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 773418, RefRangeEnd = 773419, XrefRangeStart = 773383, XrefRangeEnd = 773418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Task<TResult> FromAsyncImpl<TArg1>(Func<TArg1, AsyncCallback, Object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, Object state, TaskCreationOptions creationOptions)
	{
		//IL_007b->IL007e: Incompatible stack types: I vs Ref
		//IL_006e->IL007e: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)beginMethod);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)endFunction);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)endAction);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TArg1 reference;
		if (!typeof(TArg1).IsValueType)
		{
			object obj = arg1;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref arg1;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		*(TaskCreationOptions**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &creationOptions;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TArg1>.MethodInfoStoreGeneric_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 773454, RefRangeEnd = 773456, XrefRangeStart = 773419, XrefRangeEnd = 773454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Task<TResult> FromAsyncImpl<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, Object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, TArg2 arg2, Object state, TaskCreationOptions creationOptions)
	{
		//IL_007b->IL007e: Incompatible stack types: I vs Ref
		//IL_006e->IL007e: Incompatible stack types: I vs Ref
		//IL_00c4->IL00c7: Incompatible stack types: I vs Ref
		//IL_00b7->IL00c7: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)beginMethod);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)endFunction);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)endAction);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TArg1 reference;
		if (!typeof(TArg1).IsValueType)
		{
			object obj = arg1;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref arg1;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		byte* num2 = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TArg2 reference2;
		if (!typeof(TArg2).IsValueType)
		{
			object obj2 = arg2;
			reference2 = ref *(_003F*)((!(obj2 is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj2 is Il2CppObjectBase) ? obj2 : null)) : IL2CPP.ManagedStringToIl2Cpp(obj2 as string));
		}
		else
		{
			reference2 = ref arg2;
		}
		*(void**)num2 = Unsafe.AsPointer(ref reference2);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		*(TaskCreationOptions**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &creationOptions;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TArg1>.MethodInfoStoreGeneric_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_5_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_TArg1_TArg2_Object_TaskCreationOptions_0<TArg2>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 773467, RefRangeEnd = 773468, XrefRangeStart = 773456, XrefRangeEnd = 773467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Task<TResult> FromAsyncTrim<TInstance, TArgs>(TInstance thisRef, TArgs args, Func<TInstance, TArgs, AsyncCallback, Object, IAsyncResult> beginMethod, Func<TInstance, IAsyncResult, TResult> endMethod) where TInstance : class
	{
		//IL_0045->IL0048: Incompatible stack types: I vs Ref
		//IL_0038->IL0048: Incompatible stack types: I vs Ref
		//IL_008d->IL0090: Incompatible stack types: I vs Ref
		//IL_0080->IL0090: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		ref TInstance reference;
		if (!typeof(TInstance).IsValueType)
		{
			TInstance val = thisRef;
			reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
		}
		else
		{
			reference = ref thisRef;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TArgs reference2;
		if (!typeof(TArgs).IsValueType)
		{
			object obj = args;
			reference2 = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference2 = ref args;
		}
		*(void**)num = Unsafe.AsPointer(ref reference2);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)beginMethod);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)endMethod);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TInstance>.MethodInfoStoreGeneric_FromAsyncTrim_Internal_Static_Task_1_TResult_TInstance_TArgs_Func_5_TInstance_TArgs_AsyncCallback_Object_IAsyncResult_Func_3_TInstance_IAsyncResult_TResult_0<TArgs>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr2) : null;
	}

	public TaskFactory(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
public class TaskFactory : Object
{
	public sealed class CompleteOnInvokePromise : Task<Task>
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__tasks;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_IList_1_Task_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Void_Task_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_InvokeMayRunArbitraryCode_Public_Virtual_Final_New_get_Boolean_0;

		public unsafe IList<Task> _tasks
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__tasks);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IList<Task>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__tasks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe virtual bool InvokeMayRunArbitraryCode
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 61071, RefRangeEnd = 61098, XrefRangeStart = 61071, XrefRangeEnd = 61098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_InvokeMayRunArbitraryCode_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		static CompleteOnInvokePromise()
		{
			Il2CppClassPointerStore<CompleteOnInvokePromise>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, "CompleteOnInvokePromise");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompleteOnInvokePromise>.NativeClassPtr);
			NativeFieldInfoPtr__tasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompleteOnInvokePromise>.NativeClassPtr, "_tasks");
			NativeMethodInfoPtr__ctor_Public_Void_IList_1_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompleteOnInvokePromise>.NativeClassPtr, 100668434);
			NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompleteOnInvokePromise>.NativeClassPtr, 100668435);
			NativeMethodInfoPtr_get_InvokeMayRunArbitraryCode_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompleteOnInvokePromise>.NativeClassPtr, 100668436);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 776025, XrefRangeEnd = 776036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompleteOnInvokePromise(IList<Task> tasks)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompleteOnInvokePromise>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tasks);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IList_1_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 776054, RefRangeEnd = 776055, XrefRangeStart = 776036, XrefRangeEnd = 776054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Invoke(Task completingTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)completingTask);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public CompleteOnInvokePromise(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_StartNew_Public_Task_1_TResult_Func_1_TResult_CancellationToken_TaskCreationOptions_TaskScheduler_0<TResult>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_StartNew_Public_Task_1_TResult_Func_1_TResult_CancellationToken_TaskCreationOptions_TaskScheduler_0, Il2CppClassPointerStore<TaskFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_StartNew_Public_Task_1_TResult_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_TaskScheduler_0<TResult>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_StartNew_Public_Task_1_TResult_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_TaskScheduler_0, Il2CppClassPointerStore<TaskFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_0<TArg1>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_0, Il2CppClassPointerStore<TaskFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg1>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0<TArg1>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0, Il2CppClassPointerStore<TaskFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg1>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_FromAsync_Public_Task_Func_5_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_TArg2_Object_0<TArg1, TArg2>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_FromAsync_Public_Task_Func_5_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_TArg2_Object_0, Il2CppClassPointerStore<TaskFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[2]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg1>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg2>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_FromAsync_Public_Task_Func_5_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_TArg2_Object_TaskCreationOptions_0<TArg1, TArg2>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_FromAsync_Public_Task_Func_5_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_TArg2_Object_TaskCreationOptions_0, Il2CppClassPointerStore<TaskFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[2]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg1>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg2>.NativeClassPtr))
		}))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_defaultCancellationToken;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_defaultScheduler;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_defaultCreationOptions;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_defaultContinuationOptions;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CancellationToken_TaskCreationOptions_TaskContinuationOptions_TaskScheduler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckCreationOptions_Internal_Static_Void_TaskCreationOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartNew_Public_Task_Action_1_Object_Object_CancellationToken_TaskCreationOptions_TaskScheduler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartNew_Public_Task_1_TResult_Func_1_TResult_CancellationToken_TaskCreationOptions_TaskScheduler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartNew_Public_Task_1_TResult_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_TaskScheduler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromAsync_Public_Task_Func_5_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_TArg2_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromAsync_Public_Task_Func_5_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_TArg2_Object_TaskCreationOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckFromAsyncOptions_Internal_Static_Void_TaskCreationOptions_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CommonCWAnyLogic_Internal_Static_Task_1_Task_IList_1_Task_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckMultiTaskContinuationOptions_Internal_Static_Void_TaskContinuationOptions_0;

	public unsafe CancellationToken m_defaultCancellationToken
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultCancellationToken);
			return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultCancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe TaskScheduler m_defaultScheduler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultScheduler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TaskScheduler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultScheduler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe TaskCreationOptions m_defaultCreationOptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultCreationOptions);
			return *(TaskCreationOptions*)num;
		}
		set
		{
			*(TaskCreationOptions*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultCreationOptions)) = value;
		}
	}

	public unsafe TaskContinuationOptions m_defaultContinuationOptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultContinuationOptions);
			return *(TaskContinuationOptions*)num;
		}
		set
		{
			*(TaskContinuationOptions*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultContinuationOptions)) = value;
		}
	}

	static TaskFactory()
	{
		Il2CppClassPointerStore<TaskFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "TaskFactory");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr);
		NativeFieldInfoPtr_m_defaultCancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, "m_defaultCancellationToken");
		NativeFieldInfoPtr_m_defaultScheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, "m_defaultScheduler");
		NativeFieldInfoPtr_m_defaultCreationOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, "m_defaultCreationOptions");
		NativeFieldInfoPtr_m_defaultContinuationOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, "m_defaultContinuationOptions");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100668421);
		NativeMethodInfoPtr__ctor_Public_Void_CancellationToken_TaskCreationOptions_TaskContinuationOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100668422);
		NativeMethodInfoPtr_CheckCreationOptions_Internal_Static_Void_TaskCreationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100668423);
		NativeMethodInfoPtr_StartNew_Public_Task_Action_1_Object_Object_CancellationToken_TaskCreationOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100668424);
		NativeMethodInfoPtr_StartNew_Public_Task_1_TResult_Func_1_TResult_CancellationToken_TaskCreationOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100668425);
		NativeMethodInfoPtr_StartNew_Public_Task_1_TResult_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100668426);
		NativeMethodInfoPtr_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100668427);
		NativeMethodInfoPtr_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100668428);
		NativeMethodInfoPtr_FromAsync_Public_Task_Func_5_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_TArg2_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100668429);
		NativeMethodInfoPtr_FromAsync_Public_Task_Func_5_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_TArg2_Object_TaskCreationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100668430);
		NativeMethodInfoPtr_CheckFromAsyncOptions_Internal_Static_Void_TaskCreationOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100668431);
		NativeMethodInfoPtr_CommonCWAnyLogic_Internal_Static_Task_1_Task_IList_1_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100668432);
		NativeMethodInfoPtr_CheckMultiTaskContinuationOptions_Internal_Static_Void_TaskContinuationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100668433);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 776055, XrefRangeEnd = 776058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TaskFactory()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 776058, XrefRangeEnd = 776061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cancellationToken));
		*(TaskCreationOptions**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &creationOptions;
		*(TaskContinuationOptions**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &continuationOptions;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scheduler);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_CancellationToken_TaskCreationOptions_TaskContinuationOptions_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 776061, RefRangeEnd = 776063, XrefRangeStart = 776061, XrefRangeEnd = 776061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CheckCreationOptions(TaskCreationOptions creationOptions)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&creationOptions);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckCreationOptions_Internal_Static_Void_TaskCreationOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 776074, RefRangeEnd = 776076, XrefRangeStart = 776063, XrefRangeEnd = 776074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Task StartNew(Action<Object> action, Object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cancellationToken));
		*(TaskCreationOptions**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &creationOptions;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scheduler);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartNew_Public_Task_Action_1_Object_Object_CancellationToken_TaskCreationOptions_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 776082, RefRangeEnd = 776083, XrefRangeStart = 776076, XrefRangeEnd = 776082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Task<TResult> StartNew<TResult>(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)function);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cancellationToken));
		*(TaskCreationOptions**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &creationOptions;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scheduler);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_StartNew_Public_Task_1_TResult_Func_1_TResult_CancellationToken_TaskCreationOptions_TaskScheduler_0<TResult>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 776089, RefRangeEnd = 776090, XrefRangeStart = 776083, XrefRangeEnd = 776089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Task<TResult> StartNew<TResult>(Func<Object, TResult> function, Object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)function);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cancellationToken));
		*(TaskCreationOptions**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &creationOptions;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scheduler);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_StartNew_Public_Task_1_TResult_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_TaskScheduler_0<TResult>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 776093, RefRangeEnd = 776094, XrefRangeStart = 776090, XrefRangeEnd = 776093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Task FromAsync<TArg1>(Func<TArg1, AsyncCallback, Object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, Object state)
	{
		//IL_0070->IL0073: Incompatible stack types: I vs Ref
		//IL_0063->IL0073: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)beginMethod);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)endMethod);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TArg1 reference;
		if (!typeof(TArg1).IsValueType)
		{
			object obj = arg1;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref arg1;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_0<TArg1>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 776094, XrefRangeEnd = 776096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Task FromAsync<TArg1>(Func<TArg1, AsyncCallback, Object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, Object state, TaskCreationOptions creationOptions)
	{
		//IL_0070->IL0073: Incompatible stack types: I vs Ref
		//IL_0063->IL0073: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)beginMethod);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)endMethod);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TArg1 reference;
		if (!typeof(TArg1).IsValueType)
		{
			object obj = arg1;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref arg1;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		*(TaskCreationOptions**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &creationOptions;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0<TArg1>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 776099, RefRangeEnd = 776100, XrefRangeStart = 776096, XrefRangeEnd = 776099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Task FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, Object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, Object state)
	{
		//IL_0070->IL0073: Incompatible stack types: I vs Ref
		//IL_0063->IL0073: Incompatible stack types: I vs Ref
		//IL_00b9->IL00bc: Incompatible stack types: I vs Ref
		//IL_00ac->IL00bc: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)beginMethod);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)endMethod);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TArg1 reference;
		if (!typeof(TArg1).IsValueType)
		{
			object obj = arg1;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref arg1;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		byte* num2 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TArg2 reference2;
		if (!typeof(TArg2).IsValueType)
		{
			object obj2 = arg2;
			reference2 = ref *(_003F*)((!(obj2 is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj2 is Il2CppObjectBase) ? obj2 : null)) : IL2CPP.ManagedStringToIl2Cpp(obj2 as string));
		}
		else
		{
			reference2 = ref arg2;
		}
		*(void**)num2 = Unsafe.AsPointer(ref reference2);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_FromAsync_Public_Task_Func_5_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_TArg2_Object_0<TArg1, TArg2>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 776100, XrefRangeEnd = 776102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Task FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, Object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, Object state, TaskCreationOptions creationOptions)
	{
		//IL_0070->IL0073: Incompatible stack types: I vs Ref
		//IL_0063->IL0073: Incompatible stack types: I vs Ref
		//IL_00b9->IL00bc: Incompatible stack types: I vs Ref
		//IL_00ac->IL00bc: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)beginMethod);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)endMethod);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TArg1 reference;
		if (!typeof(TArg1).IsValueType)
		{
			object obj = arg1;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref arg1;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		byte* num2 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TArg2 reference2;
		if (!typeof(TArg2).IsValueType)
		{
			object obj2 = arg2;
			reference2 = ref *(_003F*)((!(obj2 is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj2 is Il2CppObjectBase) ? obj2 : null)) : IL2CPP.ManagedStringToIl2Cpp(obj2 as string));
		}
		else
		{
			reference2 = ref arg2;
		}
		*(void**)num2 = Unsafe.AsPointer(ref reference2);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		*(TaskCreationOptions**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &creationOptions;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_FromAsync_Public_Task_Func_5_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_TArg2_Object_TaskCreationOptions_0<TArg1, TArg2>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 776102, RefRangeEnd = 776106, XrefRangeStart = 776102, XrefRangeEnd = 776102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CheckFromAsyncOptions(TaskCreationOptions creationOptions, bool hasBeginMethod)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&creationOptions);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasBeginMethod;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckFromAsyncOptions_Internal_Static_Void_TaskCreationOptions_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 776136, RefRangeEnd = 776138, XrefRangeStart = 776106, XrefRangeEnd = 776136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Task<Task> CommonCWAnyLogic(IList<Task> tasks)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tasks);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CommonCWAnyLogic_Internal_Static_Task_1_Task_IList_1_Task_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task<Task>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 776138, RefRangeEnd = 776140, XrefRangeStart = 776138, XrefRangeEnd = 776138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CheckMultiTaskContinuationOptions(TaskContinuationOptions continuationOptions)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&continuationOptions);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckMultiTaskContinuationOptions_Internal_Static_Void_TaskContinuationOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TaskFactory(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
