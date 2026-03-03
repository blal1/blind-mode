using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Net.NetworkInformation;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;
using Il2CppSystem.Threading.Tasks.Sources;

namespace Il2CppSystem.Net.Sockets;

public class Socket : Object
{
	public sealed class CachedEventArgs : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_TaskAccept;

		private static readonly System.IntPtr NativeFieldInfoPtr_TaskReceive;

		private static readonly System.IntPtr NativeFieldInfoPtr_TaskSend;

		private static readonly System.IntPtr NativeFieldInfoPtr_ValueTaskReceive;

		private static readonly System.IntPtr NativeFieldInfoPtr_ValueTaskSend;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe TaskSocketAsyncEventArgs<Socket> TaskAccept
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TaskAccept);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TaskSocketAsyncEventArgs<Socket>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TaskAccept)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Int32TaskSocketAsyncEventArgs TaskReceive
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TaskReceive);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Int32TaskSocketAsyncEventArgs>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TaskReceive)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Int32TaskSocketAsyncEventArgs TaskSend
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TaskSend);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Int32TaskSocketAsyncEventArgs>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TaskSend)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe AwaitableSocketAsyncEventArgs ValueTaskReceive
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ValueTaskReceive);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AwaitableSocketAsyncEventArgs>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ValueTaskReceive)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe AwaitableSocketAsyncEventArgs ValueTaskSend
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ValueTaskSend);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AwaitableSocketAsyncEventArgs>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ValueTaskSend)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static CachedEventArgs()
		{
			Il2CppClassPointerStore<CachedEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Socket>.NativeClassPtr, "CachedEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CachedEventArgs>.NativeClassPtr);
			NativeFieldInfoPtr_TaskAccept = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedEventArgs>.NativeClassPtr, "TaskAccept");
			NativeFieldInfoPtr_TaskReceive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedEventArgs>.NativeClassPtr, "TaskReceive");
			NativeFieldInfoPtr_TaskSend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedEventArgs>.NativeClassPtr, "TaskSend");
			NativeFieldInfoPtr_ValueTaskReceive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedEventArgs>.NativeClassPtr, "ValueTaskReceive");
			NativeFieldInfoPtr_ValueTaskSend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedEventArgs>.NativeClassPtr, "ValueTaskSend");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedEventArgs>.NativeClassPtr, 100667340);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CachedEventArgs()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CachedEventArgs>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public CachedEventArgs(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class TaskSocketAsyncEventArgs<TResult> : SocketAsyncEventArgs
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__builder;

		private static readonly System.IntPtr NativeFieldInfoPtr__accessed;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetCompletionResponsibility_Internal_AsyncTaskMethodBuilder_1_TResult_byref_Boolean_0;

		public unsafe Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult> _builder
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__builder);
				return new Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe bool _accessed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__accessed);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__accessed)) = value;
			}
		}

		static TaskSocketAsyncEventArgs()
		{
			Il2CppClassPointerStore<TaskSocketAsyncEventArgs<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Socket>.NativeClassPtr, "TaskSocketAsyncEventArgs`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskSocketAsyncEventArgs<TResult>>.NativeClassPtr);
			NativeFieldInfoPtr__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskSocketAsyncEventArgs<TResult>>.NativeClassPtr, "_builder");
			NativeFieldInfoPtr__accessed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskSocketAsyncEventArgs<TResult>>.NativeClassPtr, "_accessed");
			NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskSocketAsyncEventArgs<TResult>>.NativeClassPtr, 100667341);
			NativeMethodInfoPtr_GetCompletionResponsibility_Internal_AsyncTaskMethodBuilder_1_TResult_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskSocketAsyncEventArgs<TResult>>.NativeClassPtr, 100667342);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 897652, RefRangeEnd = 897653, XrefRangeStart = 897603, XrefRangeEnd = 897652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskSocketAsyncEventArgs()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskSocketAsyncEventArgs<TResult>>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 897660, RefRangeEnd = 897661, XrefRangeStart = 897653, XrefRangeEnd = 897660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult> GetCompletionResponsibility(out bool responsibleForReturningToPool)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref responsibleForReturningToPool);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCompletionResponsibility_Internal_AsyncTaskMethodBuilder_1_TResult_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult>(pointer);
		}

		public TaskSocketAsyncEventArgs(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class Int32TaskSocketAsyncEventArgs : TaskSocketAsyncEventArgs<int>
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__wrapExceptionsInIOExceptions;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe bool _wrapExceptionsInIOExceptions
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__wrapExceptionsInIOExceptions);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__wrapExceptionsInIOExceptions)) = value;
			}
		}

		static Int32TaskSocketAsyncEventArgs()
		{
			Il2CppClassPointerStore<Int32TaskSocketAsyncEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Socket>.NativeClassPtr, "Int32TaskSocketAsyncEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Int32TaskSocketAsyncEventArgs>.NativeClassPtr);
			NativeFieldInfoPtr__wrapExceptionsInIOExceptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Int32TaskSocketAsyncEventArgs>.NativeClassPtr, "_wrapExceptionsInIOExceptions");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int32TaskSocketAsyncEventArgs>.NativeClassPtr, 100667343);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897661, XrefRangeEnd = 897664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Int32TaskSocketAsyncEventArgs()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Int32TaskSocketAsyncEventArgs>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public Int32TaskSocketAsyncEventArgs(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class AwaitableSocketAsyncEventArgs : SocketAsyncEventArgs
	{
		[System.Serializable]
		[ObfuscatedName("System.Net.Sockets.Socket+AwaitableSocketAsyncEventArgs+<>c")]
		public sealed class __c : Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__14_0;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__20_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__OnCompleted_b__14_0_Internal_Void_Object_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__InvokeContinuation_b__20_0_Internal_Void_Object_0;

			private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__27_0_Internal_Void_Object_0;

			private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__27_1_Internal_Void_Object_0;

			public unsafe static __c __9
			{
				get
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			public unsafe static ContextCallback __9__14_0
			{
				get
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__14_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			public unsafe static SendOrPostCallback __9__20_0
			{
				get
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SendOrPostCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__20_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			static __c()
			{
				Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AwaitableSocketAsyncEventArgs>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
				NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
				NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__14_0");
				NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__20_0");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667363);
				NativeMethodInfoPtr__OnCompleted_b__14_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667364);
				NativeMethodInfoPtr__InvokeContinuation_b__20_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667365);
				NativeMethodInfoPtr___cctor_b__27_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667366);
				NativeMethodInfoPtr___cctor_b__27_1_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667367);
			}

			[CallerCount(1950)]
			[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897664, XrefRangeEnd = 897670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnCompleted_b__14_0(Object runState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)runState);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__OnCompleted_b__14_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897670, XrefRangeEnd = 897676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InvokeContinuation_b__20_0(Object s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__InvokeContinuation_b__20_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897676, XrefRangeEnd = 897682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__27_0(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___cctor_b__27_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897682, XrefRangeEnd = 897688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__27_1(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___cctor_b__27_1_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			public __c(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_Reserved;

		private static readonly System.IntPtr NativeFieldInfoPtr_s_completedSentinel;

		private static readonly System.IntPtr NativeFieldInfoPtr_s_availableSentinel;

		private static readonly System.IntPtr NativeFieldInfoPtr__continuation;

		private static readonly System.IntPtr NativeFieldInfoPtr__executionContext;

		private static readonly System.IntPtr NativeFieldInfoPtr__scheduler;

		private static readonly System.IntPtr NativeFieldInfoPtr__token;

		private static readonly System.IntPtr NativeFieldInfoPtr__WrapExceptionsInIOExceptions_k__BackingField;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_WrapExceptionsInIOExceptions_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_WrapExceptionsInIOExceptions_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Reserve_Public_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Release_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_OnCompleted_Protected_Virtual_Void_SocketAsyncEventArgs_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveAsync_Public_ValueTask_1_Int32_Socket_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SendAsyncForNetworkStream_Public_ValueTask_Socket_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetStatus_Public_Virtual_Final_New_ValueTaskSourceStatus_Int16_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_1_Object_Object_Int16_ValueTaskSourceOnCompletedFlags_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_InvokeContinuation_Private_Void_Action_1_Object_Object_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetResult_Public_Virtual_Final_New_Int32_Int16_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Threading_Tasks_Sources_IValueTaskSource_GetResult_Private_Virtual_Final_New_Void_Int16_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ThrowIncorrectTokenException_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ThrowMultipleContinuationsException_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ThrowException_Private_Void_SocketError_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CreateException_Private_Exception_SocketError_0;

		public unsafe static AwaitableSocketAsyncEventArgs Reserved
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Reserved, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AwaitableSocketAsyncEventArgs>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Reserved, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Action<Object> s_completedSentinel
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_completedSentinel, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_completedSentinel, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Action<Object> s_availableSentinel
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_availableSentinel, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_availableSentinel, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Action<Object> _continuation
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__continuation);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__continuation)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe ExecutionContext _executionContext
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__executionContext);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__executionContext)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Object _scheduler
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__scheduler);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__scheduler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe short _token
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__token);
				return *(short*)num;
			}
			set
			{
				*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__token)) = value;
			}
		}

		public unsafe bool _WrapExceptionsInIOExceptions_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__WrapExceptionsInIOExceptions_k__BackingField);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__WrapExceptionsInIOExceptions_k__BackingField)) = value;
			}
		}

		public unsafe bool WrapExceptionsInIOExceptions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_WrapExceptionsInIOExceptions_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_WrapExceptionsInIOExceptions_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		static AwaitableSocketAsyncEventArgs()
		{
			Il2CppClassPointerStore<AwaitableSocketAsyncEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Socket>.NativeClassPtr, "AwaitableSocketAsyncEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AwaitableSocketAsyncEventArgs>.NativeClassPtr);
			NativeFieldInfoPtr_Reserved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwaitableSocketAsyncEventArgs>.NativeClassPtr, "Reserved");
			NativeFieldInfoPtr_s_completedSentinel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwaitableSocketAsyncEventArgs>.NativeClassPtr, "s_completedSentinel");
			NativeFieldInfoPtr_s_availableSentinel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwaitableSocketAsyncEventArgs>.NativeClassPtr, "s_availableSentinel");
			NativeFieldInfoPtr__continuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwaitableSocketAsyncEventArgs>.NativeClassPtr, "_continuation");
			NativeFieldInfoPtr__executionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwaitableSocketAsyncEventArgs>.NativeClassPtr, "_executionContext");
			NativeFieldInfoPtr__scheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwaitableSocketAsyncEventArgs>.NativeClassPtr, "_scheduler");
			NativeFieldInfoPtr__token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwaitableSocketAsyncEventArgs>.NativeClassPtr, "_token");
			NativeFieldInfoPtr__WrapExceptionsInIOExceptions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwaitableSocketAsyncEventArgs>.NativeClassPtr, "<WrapExceptionsInIOExceptions>k__BackingField");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitableSocketAsyncEventArgs>.NativeClassPtr, 100667344);
			NativeMethodInfoPtr_get_WrapExceptionsInIOExceptions_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitableSocketAsyncEventArgs>.NativeClassPtr, 100667345);
			NativeMethodInfoPtr_set_WrapExceptionsInIOExceptions_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitableSocketAsyncEventArgs>.NativeClassPtr, 100667346);
			NativeMethodInfoPtr_Reserve_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitableSocketAsyncEventArgs>.NativeClassPtr, 100667347);
			NativeMethodInfoPtr_Release_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitableSocketAsyncEventArgs>.NativeClassPtr, 100667348);
			NativeMethodInfoPtr_OnCompleted_Protected_Virtual_Void_SocketAsyncEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitableSocketAsyncEventArgs>.NativeClassPtr, 100667349);
			NativeMethodInfoPtr_ReceiveAsync_Public_ValueTask_1_Int32_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitableSocketAsyncEventArgs>.NativeClassPtr, 100667350);
			NativeMethodInfoPtr_SendAsyncForNetworkStream_Public_ValueTask_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitableSocketAsyncEventArgs>.NativeClassPtr, 100667351);
			NativeMethodInfoPtr_GetStatus_Public_Virtual_Final_New_ValueTaskSourceStatus_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitableSocketAsyncEventArgs>.NativeClassPtr, 100667352);
			NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_1_Object_Object_Int16_ValueTaskSourceOnCompletedFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitableSocketAsyncEventArgs>.NativeClassPtr, 100667353);
			NativeMethodInfoPtr_InvokeContinuation_Private_Void_Action_1_Object_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitableSocketAsyncEventArgs>.NativeClassPtr, 100667354);
			NativeMethodInfoPtr_GetResult_Public_Virtual_Final_New_Int32_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitableSocketAsyncEventArgs>.NativeClassPtr, 100667355);
			NativeMethodInfoPtr_System_Threading_Tasks_Sources_IValueTaskSource_GetResult_Private_Virtual_Final_New_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitableSocketAsyncEventArgs>.NativeClassPtr, 100667356);
			NativeMethodInfoPtr_ThrowIncorrectTokenException_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitableSocketAsyncEventArgs>.NativeClassPtr, 100667357);
			NativeMethodInfoPtr_ThrowMultipleContinuationsException_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitableSocketAsyncEventArgs>.NativeClassPtr, 100667358);
			NativeMethodInfoPtr_ThrowException_Private_Void_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitableSocketAsyncEventArgs>.NativeClassPtr, 100667359);
			NativeMethodInfoPtr_CreateException_Private_Exception_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitableSocketAsyncEventArgs>.NativeClassPtr, 100667360);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 897702, RefRangeEnd = 897705, XrefRangeStart = 897688, XrefRangeEnd = 897702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AwaitableSocketAsyncEventArgs()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AwaitableSocketAsyncEventArgs>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 897711, RefRangeEnd = 897713, XrefRangeStart = 897705, XrefRangeEnd = 897711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Reserve()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reserve_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 897719, RefRangeEnd = 897723, XrefRangeStart = 897713, XrefRangeEnd = 897719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Release_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897723, XrefRangeEnd = 897758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCompleted(SocketAsyncEventArgs _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnCompleted_Protected_Virtual_Void_SocketAsyncEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897758, XrefRangeEnd = 897766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTask<int> ReceiveAsync(Socket socket)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)socket);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReceiveAsync_Public_ValueTask_1_Int32_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ValueTask<int>(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897766, XrefRangeEnd = 897776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTask SendAsyncForNetworkStream(Socket socket)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)socket);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendAsyncForNetworkStream_Public_ValueTask_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ValueTask(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897776, XrefRangeEnd = 897780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ValueTaskSourceStatus GetStatus(short token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&token);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStatus_Public_Virtual_Final_New_ValueTaskSourceStatus_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ValueTaskSourceStatus*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897780, XrefRangeEnd = 897810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnCompleted(Action<Object> continuation, Object state, short token, ValueTaskSourceOnCompletedFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)continuation);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
			*(short**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &token;
			*(ValueTaskSourceOnCompletedFlags**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_1_Object_Object_Int16_ValueTaskSourceOnCompletedFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 897820, RefRangeEnd = 897823, XrefRangeStart = 897810, XrefRangeEnd = 897820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeContinuation(Action<Object> continuation, Object state, bool forceAsync)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)continuation);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
			*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceAsync;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeContinuation_Private_Void_Action_1_Object_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897823, XrefRangeEnd = 897824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetResult(short token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&token);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetResult_Public_Virtual_Final_New_Int32_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897824, XrefRangeEnd = 897825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Threading_Tasks_Sources_IValueTaskSource_GetResult(short token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&token);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Threading_Tasks_Sources_IValueTaskSource_GetResult_Private_Virtual_Final_New_Void_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897825, XrefRangeEnd = 897831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIncorrectTokenException()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowIncorrectTokenException_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897831, XrefRangeEnd = 897868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowMultipleContinuationsException()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowMultipleContinuationsException_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897868, XrefRangeEnd = 897871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowException(SocketError error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&error);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowException_Private_Void_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 897882, RefRangeEnd = 897884, XrefRangeStart = 897871, XrefRangeEnd = 897882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception CreateException(SocketError error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&error);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateException_Private_Exception_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
		}

		public AwaitableSocketAsyncEventArgs(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct WSABUF
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_len;

		private static readonly System.IntPtr NativeFieldInfoPtr_buf;

		[FieldOffset(0)]
		public int len;

		[FieldOffset(8)]
		public System.IntPtr buf;

		static WSABUF()
		{
			Il2CppClassPointerStore<WSABUF>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Socket>.NativeClassPtr, "WSABUF");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WSABUF>.NativeClassPtr);
			NativeFieldInfoPtr_len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WSABUF>.NativeClassPtr, "len");
			NativeFieldInfoPtr_buf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WSABUF>.NativeClassPtr, "buf");
		}

		public unsafe Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WSABUF>.NativeClassPtr, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
		}
	}

	[System.Serializable]
	[ObfuscatedName("System.Net.Sockets.Socket+<>c")]
	public sealed class __c : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__14_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__14_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__15_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__15_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__22_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__22_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__23_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__23_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__295_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__297_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ReceiveAsync_b__14_0_Internal_CachedEventArgs_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ReceiveAsync_b__14_1_Internal_AwaitableSocketAsyncEventArgs_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ReceiveAsyncApm_b__15_0_Internal_Void_IAsyncResult_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ReceiveAsyncApm_b__15_1_Internal_Void_IAsyncResult_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SendAsyncForNetworkStream_b__22_0_Internal_CachedEventArgs_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SendAsyncForNetworkStream_b__22_1_Internal_AwaitableSocketAsyncEventArgs_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SendAsyncApm_b__23_0_Internal_Void_IAsyncResult_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SendAsyncApm_b__23_1_Internal_Void_IAsyncResult_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SendAsync_b__295_0_Internal_Void_IOAsyncResult_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__BeginSend_b__297_0_Internal_Void_IOAsyncResult_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__367_0_Internal_Void_Object_SocketAsyncEventArgs_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__367_1_Internal_Void_Object_SocketAsyncEventArgs_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__367_2_Internal_Void_Object_SocketAsyncEventArgs_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__367_3_Internal_Void_IAsyncResult_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__367_4_Internal_Void_IOAsyncResult_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__367_5_Internal_Void_IOAsyncResult_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__367_6_Internal_Void_IAsyncResult_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__367_7_Internal_Void_IOAsyncResult_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__367_8_Internal_Void_IAsyncResult_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__367_9_Internal_Void_IOAsyncResult_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__367_10_Internal_Void_IAsyncResult_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__367_11_Internal_Void_IOAsyncResult_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__367_12_Internal_Void_IOAsyncResult_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__367_13_Internal_Void_IAsyncResult_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__367_14_Internal_Void_IOAsyncResult_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__367_15_Internal_Void_IAsyncResult_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__367_16_Internal_Void_IOAsyncResult_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__367_17_Internal_Void_IAsyncResult_0;

		public unsafe static __c __9
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Func<CachedEventArgs> __9__14_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Func<CachedEventArgs>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__14_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Func<AwaitableSocketAsyncEventArgs> __9__14_1
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__14_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Func<AwaitableSocketAsyncEventArgs>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__14_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static AsyncCallback __9__15_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__15_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static AsyncCallback __9__15_1
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__15_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__15_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Func<CachedEventArgs> __9__22_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__22_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Func<CachedEventArgs>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__22_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Func<AwaitableSocketAsyncEventArgs> __9__22_1
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__22_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Func<AwaitableSocketAsyncEventArgs>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__22_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static AsyncCallback __9__23_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__23_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__23_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static AsyncCallback __9__23_1
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__23_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__23_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static IOAsyncCallback __9__295_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__295_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__295_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static IOAsyncCallback __9__297_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__297_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__297_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Socket>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__14_0");
			NativeFieldInfoPtr___9__14_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__14_1");
			NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__15_0");
			NativeFieldInfoPtr___9__15_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__15_1");
			NativeFieldInfoPtr___9__22_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__22_0");
			NativeFieldInfoPtr___9__22_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__22_1");
			NativeFieldInfoPtr___9__23_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__23_0");
			NativeFieldInfoPtr___9__23_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__23_1");
			NativeFieldInfoPtr___9__295_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__295_0");
			NativeFieldInfoPtr___9__297_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__297_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667369);
			NativeMethodInfoPtr__ReceiveAsync_b__14_0_Internal_CachedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667370);
			NativeMethodInfoPtr__ReceiveAsync_b__14_1_Internal_AwaitableSocketAsyncEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667371);
			NativeMethodInfoPtr__ReceiveAsyncApm_b__15_0_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667372);
			NativeMethodInfoPtr__ReceiveAsyncApm_b__15_1_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667373);
			NativeMethodInfoPtr__SendAsyncForNetworkStream_b__22_0_Internal_CachedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667374);
			NativeMethodInfoPtr__SendAsyncForNetworkStream_b__22_1_Internal_AwaitableSocketAsyncEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667375);
			NativeMethodInfoPtr__SendAsyncApm_b__23_0_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667376);
			NativeMethodInfoPtr__SendAsyncApm_b__23_1_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667377);
			NativeMethodInfoPtr__SendAsync_b__295_0_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667378);
			NativeMethodInfoPtr__BeginSend_b__297_0_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667379);
			NativeMethodInfoPtr___cctor_b__367_0_Internal_Void_Object_SocketAsyncEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667380);
			NativeMethodInfoPtr___cctor_b__367_1_Internal_Void_Object_SocketAsyncEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667381);
			NativeMethodInfoPtr___cctor_b__367_2_Internal_Void_Object_SocketAsyncEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667382);
			NativeMethodInfoPtr___cctor_b__367_3_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667383);
			NativeMethodInfoPtr___cctor_b__367_4_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667384);
			NativeMethodInfoPtr___cctor_b__367_5_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667385);
			NativeMethodInfoPtr___cctor_b__367_6_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667386);
			NativeMethodInfoPtr___cctor_b__367_7_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667387);
			NativeMethodInfoPtr___cctor_b__367_8_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667388);
			NativeMethodInfoPtr___cctor_b__367_9_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667389);
			NativeMethodInfoPtr___cctor_b__367_10_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667390);
			NativeMethodInfoPtr___cctor_b__367_11_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667391);
			NativeMethodInfoPtr___cctor_b__367_12_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667392);
			NativeMethodInfoPtr___cctor_b__367_13_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667393);
			NativeMethodInfoPtr___cctor_b__367_14_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667394);
			NativeMethodInfoPtr___cctor_b__367_15_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667395);
			NativeMethodInfoPtr___cctor_b__367_16_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667396);
			NativeMethodInfoPtr___cctor_b__367_17_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667397);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897884, XrefRangeEnd = 897888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CachedEventArgs _ReceiveAsync_b__14_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ReceiveAsync_b__14_0_Internal_CachedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CachedEventArgs>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897888, XrefRangeEnd = 897892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AwaitableSocketAsyncEventArgs _ReceiveAsync_b__14_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ReceiveAsync_b__14_1_Internal_AwaitableSocketAsyncEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AwaitableSocketAsyncEventArgs>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897892, XrefRangeEnd = 897907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ReceiveAsyncApm_b__15_0(IAsyncResult iar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iar);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ReceiveAsyncApm_b__15_0_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897907, XrefRangeEnd = 897947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ReceiveAsyncApm_b__15_1(IAsyncResult iar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iar);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ReceiveAsyncApm_b__15_1_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897947, XrefRangeEnd = 897951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CachedEventArgs _SendAsyncForNetworkStream_b__22_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SendAsyncForNetworkStream_b__22_0_Internal_CachedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CachedEventArgs>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897951, XrefRangeEnd = 897955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AwaitableSocketAsyncEventArgs _SendAsyncForNetworkStream_b__22_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SendAsyncForNetworkStream_b__22_1_Internal_AwaitableSocketAsyncEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AwaitableSocketAsyncEventArgs>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897955, XrefRangeEnd = 897970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SendAsyncApm_b__23_0(IAsyncResult iar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iar);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SendAsyncApm_b__23_0_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897970, XrefRangeEnd = 897994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SendAsyncApm_b__23_1(IAsyncResult iar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iar);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SendAsyncApm_b__23_1_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897994, XrefRangeEnd = 898001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SendAsync_b__295_0(IOAsyncResult s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SendAsync_b__295_0_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898001, XrefRangeEnd = 898008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _BeginSend_b__297_0(IOAsyncResult s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__BeginSend_b__297_0_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898008, XrefRangeEnd = 898036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__367_0(Object s, SocketAsyncEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)e);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___cctor_b__367_0_Internal_Void_Object_SocketAsyncEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898036, XrefRangeEnd = 898045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__367_1(Object s, SocketAsyncEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)e);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___cctor_b__367_1_Internal_Void_Object_SocketAsyncEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898045, XrefRangeEnd = 898054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__367_2(Object s, SocketAsyncEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)e);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___cctor_b__367_2_Internal_Void_Object_SocketAsyncEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898054, XrefRangeEnd = 898081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__367_3(IAsyncResult ares)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ares);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___cctor_b__367_3_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898081, XrefRangeEnd = 898089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__367_4(IOAsyncResult ares)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ares);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___cctor_b__367_4_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898089, XrefRangeEnd = 898108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__367_5(IOAsyncResult ares)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ares);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___cctor_b__367_5_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898108, XrefRangeEnd = 898122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__367_6(IAsyncResult ares)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ares);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___cctor_b__367_6_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898122, XrefRangeEnd = 898150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__367_7(IOAsyncResult ares)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ares);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___cctor_b__367_7_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898150, XrefRangeEnd = 898171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__367_8(IAsyncResult ares)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ares);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___cctor_b__367_8_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898171, XrefRangeEnd = 898182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__367_9(IOAsyncResult ares)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ares);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___cctor_b__367_9_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898182, XrefRangeEnd = 898196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__367_10(IAsyncResult ares)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ares);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___cctor_b__367_10_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898196, XrefRangeEnd = 898214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__367_11(IOAsyncResult ares)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ares);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___cctor_b__367_11_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898214, XrefRangeEnd = 898218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__367_12(IOAsyncResult ares)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ares);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___cctor_b__367_12_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898218, XrefRangeEnd = 898237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__367_13(IAsyncResult ares)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ares);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___cctor_b__367_13_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898237, XrefRangeEnd = 898242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__367_14(IOAsyncResult ares)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ares);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___cctor_b__367_14_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898242, XrefRangeEnd = 898256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__367_15(IAsyncResult ares)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ares);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___cctor_b__367_15_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898256, XrefRangeEnd = 898260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__367_16(IOAsyncResult ares)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ares);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___cctor_b__367_16_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898260, XrefRangeEnd = 898281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__367_17(IAsyncResult ares)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ares);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___cctor_b__367_17_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("System.Net.Sockets.Socket+<>c__DisplayClass240_0")]
	public sealed class __c__DisplayClass240_0 : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_sockares;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__BeginConnect_b__0_Internal_Void_Task_1_Il2CppReferenceArray_1_IPAddress_0;

		public unsafe SocketAsyncResult sockares
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sockares);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SocketAsyncResult>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sockares)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c__DisplayClass240_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass240_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Socket>.NativeClassPtr, "<>c__DisplayClass240_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass240_0>.NativeClassPtr);
			NativeFieldInfoPtr_sockares = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass240_0>.NativeClassPtr, "sockares");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass240_0>.NativeClassPtr, 100667398);
			NativeMethodInfoPtr__BeginConnect_b__0_Internal_Void_Task_1_Il2CppReferenceArray_1_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass240_0>.NativeClassPtr, 100667399);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass240_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass240_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898281, XrefRangeEnd = 898300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _BeginConnect_b__0(Task<Il2CppReferenceArray<IPAddress>> t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__BeginConnect_b__0_Internal_Void_Task_1_Il2CppReferenceArray_1_IPAddress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public __c__DisplayClass240_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("System.Net.Sockets.Socket+<>c__DisplayClass298_0")]
	public sealed class __c__DisplayClass298_0 : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_sent_so_far;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__BeginSendCallback_b__0_Internal_Void_IOAsyncResult_0;

		public unsafe int sent_so_far
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sent_so_far);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sent_so_far)) = value;
			}
		}

		static __c__DisplayClass298_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass298_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Socket>.NativeClassPtr, "<>c__DisplayClass298_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass298_0>.NativeClassPtr);
			NativeFieldInfoPtr_sent_so_far = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass298_0>.NativeClassPtr, "sent_so_far");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass298_0>.NativeClassPtr, 100667400);
			NativeMethodInfoPtr__BeginSendCallback_b__0_Internal_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass298_0>.NativeClassPtr, 100667401);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass298_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass298_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898300, XrefRangeEnd = 898307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _BeginSendCallback_b__0(IOAsyncResult s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__BeginSendCallback_b__0_Internal_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public __c__DisplayClass298_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("System.Net.Sockets.Socket+<>c__DisplayClass355_0")]
	public sealed class __c__DisplayClass355_0 : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr_job;

		private static readonly System.IntPtr NativeFieldInfoPtr_handle;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__QueueIOSelectorJob_b__0_Internal_Void_Task_0;

		public unsafe Socket __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Socket>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe IOSelectorJob job
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_job);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IOSelectorJob>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_job)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe System.IntPtr handle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handle);
				return *(System.IntPtr*)num;
			}
			set
			{
				*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handle)) = value;
			}
		}

		static __c__DisplayClass355_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass355_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Socket>.NativeClassPtr, "<>c__DisplayClass355_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass355_0>.NativeClassPtr);
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass355_0>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr_job = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass355_0>.NativeClassPtr, "job");
			NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass355_0>.NativeClassPtr, "handle");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass355_0>.NativeClassPtr, 100667402);
			NativeMethodInfoPtr__QueueIOSelectorJob_b__0_Internal_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass355_0>.NativeClassPtr, 100667403);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass355_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass355_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898307, XrefRangeEnd = 898310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _QueueIOSelectorJob_b__0(Task t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__QueueIOSelectorJob_b__0_Internal_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public __c__DisplayClass355_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_AcceptCompletedHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_ReceiveCompletedHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_SendCompletedHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_rentedSocketSentinel;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_rentedInt32Sentinel;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_zeroTask;

	private static readonly System.IntPtr NativeFieldInfoPtr__cachedTaskEventArgs;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_InternalSyncObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_SupportsIPv4;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_SupportsIPv6;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_OSSupportsIPv6;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_Initialized;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_LoggingEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_is_closed;

	private static readonly System.IntPtr NativeFieldInfoPtr_is_listening;

	private static readonly System.IntPtr NativeFieldInfoPtr_linger_timeout;

	private static readonly System.IntPtr NativeFieldInfoPtr_addressFamily;

	private static readonly System.IntPtr NativeFieldInfoPtr_socketType;

	private static readonly System.IntPtr NativeFieldInfoPtr_protocolType;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Handle;

	private static readonly System.IntPtr NativeFieldInfoPtr_seed_endpoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_ReadSem;

	private static readonly System.IntPtr NativeFieldInfoPtr_WriteSem;

	private static readonly System.IntPtr NativeFieldInfoPtr_is_blocking;

	private static readonly System.IntPtr NativeFieldInfoPtr_is_bound;

	private static readonly System.IntPtr NativeFieldInfoPtr_is_connected;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IntCleanedUp;

	private static readonly System.IntPtr NativeFieldInfoPtr_connect_in_progress;

	private static readonly System.IntPtr NativeFieldInfoPtr_AcceptAsyncCallback;

	private static readonly System.IntPtr NativeFieldInfoPtr_BeginAcceptCallback;

	private static readonly System.IntPtr NativeFieldInfoPtr_BeginAcceptReceiveCallback;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConnectAsyncCallback;

	private static readonly System.IntPtr NativeFieldInfoPtr_BeginConnectCallback;

	private static readonly System.IntPtr NativeFieldInfoPtr_DisconnectAsyncCallback;

	private static readonly System.IntPtr NativeFieldInfoPtr_BeginDisconnectCallback;

	private static readonly System.IntPtr NativeFieldInfoPtr_ReceiveAsyncCallback;

	private static readonly System.IntPtr NativeFieldInfoPtr_BeginReceiveCallback;

	private static readonly System.IntPtr NativeFieldInfoPtr_BeginReceiveGenericCallback;

	private static readonly System.IntPtr NativeFieldInfoPtr_ReceiveFromAsyncCallback;

	private static readonly System.IntPtr NativeFieldInfoPtr_BeginReceiveFromCallback;

	private static readonly System.IntPtr NativeFieldInfoPtr_SendAsyncCallback;

	private static readonly System.IntPtr NativeFieldInfoPtr_BeginSendGenericCallback;

	private static readonly System.IntPtr NativeFieldInfoPtr_SendToAsyncCallback;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveAsync_Internal_ValueTask_1_Int32_Memory_1_Byte_SocketFlags_Boolean_CancellationToken_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveAsyncApm_Private_Task_1_Int32_Memory_1_Byte_SocketFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendAsyncForNetworkStream_Internal_ValueTask_ReadOnlyMemory_1_Byte_SocketFlags_CancellationToken_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendAsyncApm_Private_Task_1_Int32_ReadOnlyMemory_1_Byte_SocketFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompleteAccept_Private_Static_Void_Socket_TaskSocketAsyncEventArgs_1_Socket_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompleteSendReceive_Private_Static_Void_Socket_Int32TaskSocketAsyncEventArgs_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetException_Private_Static_Exception_SocketError_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReturnSocketAsyncEventArgs_Private_Void_Int32TaskSocketAsyncEventArgs_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReturnSocketAsyncEventArgs_Private_Void_TaskSocketAsyncEventArgs_1_Socket_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_AddressFamily_SocketType_ProtocolType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_OSSupportsIPv4_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_OSSupportsIPv6_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Handle_Public_get_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AddressFamily_Public_get_AddressFamily_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SocketType_Public_get_SocketType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ProtocolType_Public_get_ProtocolType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_DontFragment_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DualMode_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_DualMode_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsDualMode_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanTryAddressFamily_Internal_Boolean_AddressFamily_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Send_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Send_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Receive_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Receive_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IOControl_Public_Int32_IOControlCode_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetIPProtectionLevel_Public_Void_IPProtectionLevel_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginSend_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_AsyncCallback_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndSend_Public_Int32_IAsyncResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginReceive_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_AsyncCallback_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndReceive_Public_Int32_IAsyncResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CleanedUp_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeSockets_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalShutdown_Internal_Void_SocketShutdown_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSocketOption_Internal_Void_SocketOptionLevel_SocketOptionName_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_AddressFamily_SocketType_ProtocolType_SafeSocketHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SocketDefaults_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Socket_icall_Private_Static_IntPtr_AddressFamily_SocketType_ProtocolType_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalEndPoint_Public_get_EndPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LocalEndPoint_internal_Private_Static_SocketAddress_SafeSocketHandle_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LocalEndPoint_icall_Private_Static_SocketAddress_IntPtr_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Blocking_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Blocking_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Blocking_internal_Private_Static_Void_SafeSocketHandle_Boolean_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Blocking_icall_Internal_Static_Void_IntPtr_Boolean_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Connected_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_NoDelay_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RemoteEndPoint_Public_get_EndPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoteEndPoint_internal_Private_Static_SocketAddress_SafeSocketHandle_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoteEndPoint_icall_Private_Static_SocketAddress_IntPtr_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Poll_Public_Boolean_Int32_SelectMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Poll_internal_Private_Static_Boolean_SafeSocketHandle_SelectMode_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Poll_icall_Private_Static_Boolean_IntPtr_SelectMode_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Accept_Public_Socket_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Accept_Internal_Void_Socket_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginAccept_Public_IAsyncResult_AsyncCallback_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndAccept_Public_Socket_IAsyncResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndAccept_Public_Socket_byref_Il2CppStructArray_1_Byte_byref_Int32_IAsyncResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Accept_internal_Private_Static_SafeSocketHandle_SafeSocketHandle_byref_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Accept_icall_Private_Static_IntPtr_IntPtr_byref_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Bind_Public_Void_EndPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Bind_internal_Private_Static_Void_SafeSocketHandle_SocketAddress_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Bind_icall_Private_Static_Void_IntPtr_SocketAddress_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Listen_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Listen_internal_Private_Static_Void_SafeSocketHandle_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Listen_icall_Private_Static_Void_IntPtr_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Connect_Public_Void_IPAddress_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Connect_Public_Void_EndPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginConnect_Public_IAsyncResult_String_Int32_AsyncCallback_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginConnect_Public_IAsyncResult_EndPoint_AsyncCallback_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginMConnect_Private_Static_Boolean_SocketAsyncResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginSConnect_Private_Static_Boolean_SocketAsyncResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndConnect_Public_Void_IAsyncResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Connect_internal_Private_Static_Void_SafeSocketHandle_SocketAddress_byref_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Connect_icall_Private_Static_Void_IntPtr_SocketAddress_byref_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Disconnect_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndDisconnect_Public_Void_IAsyncResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Disconnect_internal_Private_Static_Void_SafeSocketHandle_Boolean_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Disconnect_icall_Private_Static_Void_IntPtr_Boolean_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Receive_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Receive_Private_Int32_Memory_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Receive_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_byref_SocketError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Receive_Public_Int32_Span_1_Byte_SocketFlags_byref_SocketError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Send_Public_Int32_ReadOnlySpan_1_Byte_SocketFlags_byref_SocketError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveAsync_Public_Boolean_SocketAsyncEventArgs_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginReceive_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_AsyncCallback_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndReceive_Public_Int32_IAsyncResult_byref_SocketError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Receive_internal_Private_Static_Int32_SafeSocketHandle_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Receive_array_icall_Private_Static_Int32_IntPtr_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Receive_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Receive_icall_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveFrom_Private_Int32_Memory_1_Byte_Int32_Int32_SocketFlags_byref_EndPoint_byref_SocketError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndReceiveFrom_internal_Private_Int32_SocketAsyncResult_SocketAsyncEventArgs_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveFrom_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_byref_SocketAddress_byref_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveFrom_icall_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_byref_SocketAddress_byref_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Send_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Send_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_byref_SocketError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendAsync_Public_Boolean_SocketAsyncEventArgs_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginSend_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_AsyncCallback_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginSendCallback_Private_Static_Void_SocketAsyncResult_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndSend_Public_Int32_IAsyncResult_byref_SocketError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Send_internal_Private_Static_Int32_SafeSocketHandle_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Send_array_icall_Private_Static_Int32_IntPtr_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Send_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Send_icall_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndSendTo_Public_Int32_IAsyncResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSocketOption_Public_Object_SocketOptionLevel_SocketOptionName_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSocketOption_obj_internal_Private_Static_Void_SafeSocketHandle_SocketOptionLevel_SocketOptionName_byref_Object_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSocketOption_obj_icall_Private_Static_Void_IntPtr_SocketOptionLevel_SocketOptionName_byref_Object_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSocketOption_Public_Void_SocketOptionLevel_SocketOptionName_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSocketOption_internal_Private_Static_Void_SafeSocketHandle_SocketOptionLevel_SocketOptionName_Object_Il2CppStructArray_1_Byte_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSocketOption_icall_Private_Static_Void_IntPtr_SocketOptionLevel_SocketOptionName_Object_Il2CppStructArray_1_Byte_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IOControl_Public_Int32_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IOControl_internal_Private_Static_Int32_SafeSocketHandle_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IOControl_icall_Private_Static_Int32_IntPtr_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Close_icall_Internal_Static_Void_IntPtr_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Shutdown_internal_Private_Static_Void_SafeSocketHandle_SocketShutdown_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Shutdown_icall_Internal_Static_Void_IntPtr_SocketShutdown_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Linger_Private_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowIfDisposedAndClosed_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowIfBufferNull_Private_Void_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowIfBufferOutOfRange_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowIfUdp_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateEndIAsyncResult_Private_SocketAsyncResult_IAsyncResult_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueueIOSelectorJob_Private_Void_SemaphoreSlim_IntPtr_IOSelectorJob_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitSocketAsyncEventArgs_Private_Void_SocketAsyncEventArgs_AsyncCallback_Object_SocketOperation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SocketOperationToSocketAsyncOperation_Private_SocketAsyncOperation_SocketOperation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemapIPEndPoint_Private_IPEndPoint_IPEndPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_cancel_blocking_socket_operation_Internal_Static_Void_Thread_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_FamilyHint_Internal_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsProtocolSupported_internal_Private_Static_Boolean_NetworkInterfaceComponent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsProtocolSupported_Private_Static_Boolean_NetworkInterfaceComponent_0;

	public unsafe static EventHandler<SocketAsyncEventArgs> AcceptCompletedHandler
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AcceptCompletedHandler, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventHandler<SocketAsyncEventArgs>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AcceptCompletedHandler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static EventHandler<SocketAsyncEventArgs> ReceiveCompletedHandler
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ReceiveCompletedHandler, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventHandler<SocketAsyncEventArgs>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ReceiveCompletedHandler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static EventHandler<SocketAsyncEventArgs> SendCompletedHandler
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SendCompletedHandler, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventHandler<SocketAsyncEventArgs>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SendCompletedHandler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static TaskSocketAsyncEventArgs<Socket> s_rentedSocketSentinel
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_rentedSocketSentinel, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TaskSocketAsyncEventArgs<Socket>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_rentedSocketSentinel, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Int32TaskSocketAsyncEventArgs s_rentedInt32Sentinel
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_rentedInt32Sentinel, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Int32TaskSocketAsyncEventArgs>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_rentedInt32Sentinel, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Task<int> s_zeroTask
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_zeroTask, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_zeroTask, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe CachedEventArgs _cachedTaskEventArgs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cachedTaskEventArgs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CachedEventArgs>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cachedTaskEventArgs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Object s_InternalSyncObject
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_InternalSyncObject, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_InternalSyncObject, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static bool s_SupportsIPv4
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_SupportsIPv4, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_SupportsIPv4, (void*)(&value));
		}
	}

	public unsafe static bool s_SupportsIPv6
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_SupportsIPv6, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_SupportsIPv6, (void*)(&value));
		}
	}

	public unsafe static bool s_OSSupportsIPv6
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_OSSupportsIPv6, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_OSSupportsIPv6, (void*)(&value));
		}
	}

	public unsafe static bool s_Initialized
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Initialized, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Initialized, (void*)(&value));
		}
	}

	public unsafe static bool s_LoggingEnabled
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_LoggingEnabled, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_LoggingEnabled, (void*)(&value));
		}
	}

	public unsafe bool is_closed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_is_closed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_is_closed)) = value;
		}
	}

	public unsafe bool is_listening
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_is_listening);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_is_listening)) = value;
		}
	}

	public unsafe int linger_timeout
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linger_timeout);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linger_timeout)) = value;
		}
	}

	public unsafe AddressFamily addressFamily
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addressFamily);
			return *(AddressFamily*)num;
		}
		set
		{
			*(AddressFamily*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addressFamily)) = value;
		}
	}

	public unsafe SocketType socketType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_socketType);
			return *(SocketType*)num;
		}
		set
		{
			*(SocketType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_socketType)) = value;
		}
	}

	public unsafe ProtocolType protocolType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_protocolType);
			return *(ProtocolType*)num;
		}
		set
		{
			*(ProtocolType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_protocolType)) = value;
		}
	}

	public unsafe SafeSocketHandle m_Handle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Handle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SafeSocketHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Handle)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe EndPoint seed_endpoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seed_endpoint);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EndPoint>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seed_endpoint)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe SemaphoreSlim ReadSem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReadSem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SemaphoreSlim>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReadSem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe SemaphoreSlim WriteSem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WriteSem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SemaphoreSlim>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WriteSem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool is_blocking
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_is_blocking);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_is_blocking)) = value;
		}
	}

	public unsafe bool is_bound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_is_bound);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_is_bound)) = value;
		}
	}

	public unsafe bool is_connected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_is_connected);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_is_connected)) = value;
		}
	}

	public unsafe int m_IntCleanedUp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IntCleanedUp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IntCleanedUp)) = value;
		}
	}

	public unsafe bool connect_in_progress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_connect_in_progress);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_connect_in_progress)) = value;
		}
	}

	public unsafe static AsyncCallback AcceptAsyncCallback
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AcceptAsyncCallback, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AcceptAsyncCallback, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static IOAsyncCallback BeginAcceptCallback
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BeginAcceptCallback, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BeginAcceptCallback, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static IOAsyncCallback BeginAcceptReceiveCallback
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BeginAcceptReceiveCallback, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BeginAcceptReceiveCallback, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static AsyncCallback ConnectAsyncCallback
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ConnectAsyncCallback, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ConnectAsyncCallback, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static IOAsyncCallback BeginConnectCallback
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BeginConnectCallback, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BeginConnectCallback, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static AsyncCallback DisconnectAsyncCallback
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DisconnectAsyncCallback, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DisconnectAsyncCallback, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static IOAsyncCallback BeginDisconnectCallback
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BeginDisconnectCallback, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BeginDisconnectCallback, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static AsyncCallback ReceiveAsyncCallback
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ReceiveAsyncCallback, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ReceiveAsyncCallback, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static IOAsyncCallback BeginReceiveCallback
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BeginReceiveCallback, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BeginReceiveCallback, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static IOAsyncCallback BeginReceiveGenericCallback
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BeginReceiveGenericCallback, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BeginReceiveGenericCallback, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static AsyncCallback ReceiveFromAsyncCallback
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ReceiveFromAsyncCallback, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ReceiveFromAsyncCallback, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static IOAsyncCallback BeginReceiveFromCallback
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BeginReceiveFromCallback, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BeginReceiveFromCallback, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static AsyncCallback SendAsyncCallback
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SendAsyncCallback, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SendAsyncCallback, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static IOAsyncCallback BeginSendGenericCallback
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BeginSendGenericCallback, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BeginSendGenericCallback, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static AsyncCallback SendToAsyncCallback
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SendToAsyncCallback, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SendToAsyncCallback, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static bool OSSupportsIPv4
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 898641, RefRangeEnd = 898643, XrefRangeStart = 898635, XrefRangeEnd = 898641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_OSSupportsIPv4_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool OSSupportsIPv6
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 898649, RefRangeEnd = 898651, XrefRangeStart = 898643, XrefRangeEnd = 898649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_OSSupportsIPv6_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe System.IntPtr Handle
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Handle_Public_get_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe AddressFamily AddressFamily
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63233, RefRangeEnd = 63234, XrefRangeStart = 63233, XrefRangeEnd = 63234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AddressFamily_Public_get_AddressFamily_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(AddressFamily*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe SocketType SocketType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SocketType_Public_get_SocketType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(SocketType*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe ProtocolType ProtocolType
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80842, RefRangeEnd = 80843, XrefRangeStart = 80842, XrefRangeEnd = 80843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ProtocolType_Public_get_ProtocolType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ProtocolType*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool DontFragment
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898651, XrefRangeEnd = 898652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_DontFragment_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool DualMode
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898652, XrefRangeEnd = 898655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DualMode_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898655, XrefRangeEnd = 898656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_DualMode_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool IsDualMode
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 898656, RefRangeEnd = 898658, XrefRangeStart = 898656, XrefRangeEnd = 898656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsDualMode_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static Object InternalSyncObject
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898700, XrefRangeEnd = 898715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}
	}

	public unsafe bool CleanedUp
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CleanedUp_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe EndPoint LocalEndPoint
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 898820, RefRangeEnd = 898823, XrefRangeStart = 898815, XrefRangeEnd = 898820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LocalEndPoint_Public_get_EndPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EndPoint>(intPtr2) : null;
		}
	}

	public unsafe bool Blocking
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Blocking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 898838, RefRangeEnd = 898840, XrefRangeStart = 898833, XrefRangeEnd = 898838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Blocking_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool Connected
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Connected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool NoDelay
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898850, XrefRangeEnd = 898852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_NoDelay_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe EndPoint RemoteEndPoint
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 898857, RefRangeEnd = 898860, XrefRangeStart = 898852, XrefRangeEnd = 898857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RemoteEndPoint_Public_get_EndPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EndPoint>(intPtr2) : null;
		}
	}

	public unsafe static int FamilyHint
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 899853, RefRangeEnd = 899857, XrefRangeStart = 899835, XrefRangeEnd = 899853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FamilyHint_Internal_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static Socket()
	{
		Il2CppClassPointerStore<Socket>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Sockets", "Socket");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Socket>.NativeClassPtr);
		NativeFieldInfoPtr_AcceptCompletedHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "AcceptCompletedHandler");
		NativeFieldInfoPtr_ReceiveCompletedHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "ReceiveCompletedHandler");
		NativeFieldInfoPtr_SendCompletedHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "SendCompletedHandler");
		NativeFieldInfoPtr_s_rentedSocketSentinel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "s_rentedSocketSentinel");
		NativeFieldInfoPtr_s_rentedInt32Sentinel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "s_rentedInt32Sentinel");
		NativeFieldInfoPtr_s_zeroTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "s_zeroTask");
		NativeFieldInfoPtr__cachedTaskEventArgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "_cachedTaskEventArgs");
		NativeFieldInfoPtr_s_InternalSyncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "s_InternalSyncObject");
		NativeFieldInfoPtr_s_SupportsIPv4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "s_SupportsIPv4");
		NativeFieldInfoPtr_s_SupportsIPv6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "s_SupportsIPv6");
		NativeFieldInfoPtr_s_OSSupportsIPv6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "s_OSSupportsIPv6");
		NativeFieldInfoPtr_s_Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "s_Initialized");
		NativeFieldInfoPtr_s_LoggingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "s_LoggingEnabled");
		NativeFieldInfoPtr_is_closed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "is_closed");
		NativeFieldInfoPtr_is_listening = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "is_listening");
		NativeFieldInfoPtr_linger_timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "linger_timeout");
		NativeFieldInfoPtr_addressFamily = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "addressFamily");
		NativeFieldInfoPtr_socketType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "socketType");
		NativeFieldInfoPtr_protocolType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "protocolType");
		NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "m_Handle");
		NativeFieldInfoPtr_seed_endpoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "seed_endpoint");
		NativeFieldInfoPtr_ReadSem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "ReadSem");
		NativeFieldInfoPtr_WriteSem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "WriteSem");
		NativeFieldInfoPtr_is_blocking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "is_blocking");
		NativeFieldInfoPtr_is_bound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "is_bound");
		NativeFieldInfoPtr_is_connected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "is_connected");
		NativeFieldInfoPtr_m_IntCleanedUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "m_IntCleanedUp");
		NativeFieldInfoPtr_connect_in_progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "connect_in_progress");
		NativeFieldInfoPtr_AcceptAsyncCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "AcceptAsyncCallback");
		NativeFieldInfoPtr_BeginAcceptCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "BeginAcceptCallback");
		NativeFieldInfoPtr_BeginAcceptReceiveCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "BeginAcceptReceiveCallback");
		NativeFieldInfoPtr_ConnectAsyncCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "ConnectAsyncCallback");
		NativeFieldInfoPtr_BeginConnectCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "BeginConnectCallback");
		NativeFieldInfoPtr_DisconnectAsyncCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "DisconnectAsyncCallback");
		NativeFieldInfoPtr_BeginDisconnectCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "BeginDisconnectCallback");
		NativeFieldInfoPtr_ReceiveAsyncCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "ReceiveAsyncCallback");
		NativeFieldInfoPtr_BeginReceiveCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "BeginReceiveCallback");
		NativeFieldInfoPtr_BeginReceiveGenericCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "BeginReceiveGenericCallback");
		NativeFieldInfoPtr_ReceiveFromAsyncCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "ReceiveFromAsyncCallback");
		NativeFieldInfoPtr_BeginReceiveFromCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "BeginReceiveFromCallback");
		NativeFieldInfoPtr_SendAsyncCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "SendAsyncCallback");
		NativeFieldInfoPtr_BeginSendGenericCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "BeginSendGenericCallback");
		NativeFieldInfoPtr_SendToAsyncCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "SendToAsyncCallback");
		NativeMethodInfoPtr_ReceiveAsync_Internal_ValueTask_1_Int32_Memory_1_Byte_SocketFlags_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667201);
		NativeMethodInfoPtr_ReceiveAsyncApm_Private_Task_1_Int32_Memory_1_Byte_SocketFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667202);
		NativeMethodInfoPtr_SendAsyncForNetworkStream_Internal_ValueTask_ReadOnlyMemory_1_Byte_SocketFlags_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667203);
		NativeMethodInfoPtr_SendAsyncApm_Private_Task_1_Int32_ReadOnlyMemory_1_Byte_SocketFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667204);
		NativeMethodInfoPtr_CompleteAccept_Private_Static_Void_Socket_TaskSocketAsyncEventArgs_1_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667205);
		NativeMethodInfoPtr_CompleteSendReceive_Private_Static_Void_Socket_Int32TaskSocketAsyncEventArgs_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667206);
		NativeMethodInfoPtr_GetException_Private_Static_Exception_SocketError_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667207);
		NativeMethodInfoPtr_ReturnSocketAsyncEventArgs_Private_Void_Int32TaskSocketAsyncEventArgs_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667208);
		NativeMethodInfoPtr_ReturnSocketAsyncEventArgs_Private_Void_TaskSocketAsyncEventArgs_1_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667209);
		NativeMethodInfoPtr__ctor_Public_Void_AddressFamily_SocketType_ProtocolType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667210);
		NativeMethodInfoPtr_get_OSSupportsIPv4_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667211);
		NativeMethodInfoPtr_get_OSSupportsIPv6_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667212);
		NativeMethodInfoPtr_get_Handle_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667213);
		NativeMethodInfoPtr_get_AddressFamily_Public_get_AddressFamily_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667214);
		NativeMethodInfoPtr_get_SocketType_Public_get_SocketType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667215);
		NativeMethodInfoPtr_get_ProtocolType_Public_get_ProtocolType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667216);
		NativeMethodInfoPtr_set_DontFragment_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667217);
		NativeMethodInfoPtr_get_DualMode_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667218);
		NativeMethodInfoPtr_set_DualMode_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667219);
		NativeMethodInfoPtr_get_IsDualMode_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667220);
		NativeMethodInfoPtr_CanTryAddressFamily_Internal_Boolean_AddressFamily_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667221);
		NativeMethodInfoPtr_Send_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667222);
		NativeMethodInfoPtr_Send_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667223);
		NativeMethodInfoPtr_Receive_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667224);
		NativeMethodInfoPtr_Receive_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667225);
		NativeMethodInfoPtr_IOControl_Public_Int32_IOControlCode_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667226);
		NativeMethodInfoPtr_SetIPProtectionLevel_Public_Void_IPProtectionLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667227);
		NativeMethodInfoPtr_BeginSend_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667228);
		NativeMethodInfoPtr_EndSend_Public_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667229);
		NativeMethodInfoPtr_BeginReceive_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667230);
		NativeMethodInfoPtr_EndReceive_Public_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667231);
		NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667232);
		NativeMethodInfoPtr_get_CleanedUp_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667233);
		NativeMethodInfoPtr_InitializeSockets_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667234);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667235);
		NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667236);
		NativeMethodInfoPtr_InternalShutdown_Internal_Void_SocketShutdown_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667237);
		NativeMethodInfoPtr_SetSocketOption_Internal_Void_SocketOptionLevel_SocketOptionName_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667238);
		NativeMethodInfoPtr__ctor_Internal_Void_AddressFamily_SocketType_ProtocolType_SafeSocketHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667239);
		NativeMethodInfoPtr_SocketDefaults_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667240);
		NativeMethodInfoPtr_Socket_icall_Private_Static_IntPtr_AddressFamily_SocketType_ProtocolType_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667241);
		NativeMethodInfoPtr_get_LocalEndPoint_Public_get_EndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667242);
		NativeMethodInfoPtr_LocalEndPoint_internal_Private_Static_SocketAddress_SafeSocketHandle_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667243);
		NativeMethodInfoPtr_LocalEndPoint_icall_Private_Static_SocketAddress_IntPtr_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667244);
		NativeMethodInfoPtr_get_Blocking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667245);
		NativeMethodInfoPtr_set_Blocking_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667246);
		NativeMethodInfoPtr_Blocking_internal_Private_Static_Void_SafeSocketHandle_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667247);
		NativeMethodInfoPtr_Blocking_icall_Internal_Static_Void_IntPtr_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667248);
		NativeMethodInfoPtr_get_Connected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667249);
		NativeMethodInfoPtr_set_NoDelay_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667250);
		NativeMethodInfoPtr_get_RemoteEndPoint_Public_get_EndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667251);
		NativeMethodInfoPtr_RemoteEndPoint_internal_Private_Static_SocketAddress_SafeSocketHandle_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667252);
		NativeMethodInfoPtr_RemoteEndPoint_icall_Private_Static_SocketAddress_IntPtr_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667253);
		NativeMethodInfoPtr_Poll_Public_Boolean_Int32_SelectMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667254);
		NativeMethodInfoPtr_Poll_internal_Private_Static_Boolean_SafeSocketHandle_SelectMode_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667255);
		NativeMethodInfoPtr_Poll_icall_Private_Static_Boolean_IntPtr_SelectMode_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667256);
		NativeMethodInfoPtr_Accept_Public_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667257);
		NativeMethodInfoPtr_Accept_Internal_Void_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667258);
		NativeMethodInfoPtr_BeginAccept_Public_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667259);
		NativeMethodInfoPtr_EndAccept_Public_Socket_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667260);
		NativeMethodInfoPtr_EndAccept_Public_Socket_byref_Il2CppStructArray_1_Byte_byref_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667261);
		NativeMethodInfoPtr_Accept_internal_Private_Static_SafeSocketHandle_SafeSocketHandle_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667262);
		NativeMethodInfoPtr_Accept_icall_Private_Static_IntPtr_IntPtr_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667263);
		NativeMethodInfoPtr_Bind_Public_Void_EndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667264);
		NativeMethodInfoPtr_Bind_internal_Private_Static_Void_SafeSocketHandle_SocketAddress_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667265);
		NativeMethodInfoPtr_Bind_icall_Private_Static_Void_IntPtr_SocketAddress_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667266);
		NativeMethodInfoPtr_Listen_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667267);
		NativeMethodInfoPtr_Listen_internal_Private_Static_Void_SafeSocketHandle_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667268);
		NativeMethodInfoPtr_Listen_icall_Private_Static_Void_IntPtr_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667269);
		NativeMethodInfoPtr_Connect_Public_Void_IPAddress_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667270);
		NativeMethodInfoPtr_Connect_Public_Void_EndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667271);
		NativeMethodInfoPtr_BeginConnect_Public_IAsyncResult_String_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667272);
		NativeMethodInfoPtr_BeginConnect_Public_IAsyncResult_EndPoint_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667273);
		NativeMethodInfoPtr_BeginMConnect_Private_Static_Boolean_SocketAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667274);
		NativeMethodInfoPtr_BeginSConnect_Private_Static_Boolean_SocketAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667275);
		NativeMethodInfoPtr_EndConnect_Public_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667276);
		NativeMethodInfoPtr_Connect_internal_Private_Static_Void_SafeSocketHandle_SocketAddress_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667277);
		NativeMethodInfoPtr_Connect_icall_Private_Static_Void_IntPtr_SocketAddress_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667278);
		NativeMethodInfoPtr_Disconnect_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667279);
		NativeMethodInfoPtr_EndDisconnect_Public_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667280);
		NativeMethodInfoPtr_Disconnect_internal_Private_Static_Void_SafeSocketHandle_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667281);
		NativeMethodInfoPtr_Disconnect_icall_Private_Static_Void_IntPtr_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667282);
		NativeMethodInfoPtr_Receive_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667283);
		NativeMethodInfoPtr_Receive_Private_Int32_Memory_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667284);
		NativeMethodInfoPtr_Receive_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_byref_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667285);
		NativeMethodInfoPtr_Receive_Public_Int32_Span_1_Byte_SocketFlags_byref_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667286);
		NativeMethodInfoPtr_Send_Public_Int32_ReadOnlySpan_1_Byte_SocketFlags_byref_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667287);
		NativeMethodInfoPtr_ReceiveAsync_Public_Boolean_SocketAsyncEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667288);
		NativeMethodInfoPtr_BeginReceive_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667289);
		NativeMethodInfoPtr_EndReceive_Public_Int32_IAsyncResult_byref_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667290);
		NativeMethodInfoPtr_Receive_internal_Private_Static_Int32_SafeSocketHandle_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667291);
		NativeMethodInfoPtr_Receive_array_icall_Private_Static_Int32_IntPtr_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667292);
		NativeMethodInfoPtr_Receive_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667293);
		NativeMethodInfoPtr_Receive_icall_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667294);
		NativeMethodInfoPtr_ReceiveFrom_Private_Int32_Memory_1_Byte_Int32_Int32_SocketFlags_byref_EndPoint_byref_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667295);
		NativeMethodInfoPtr_EndReceiveFrom_internal_Private_Int32_SocketAsyncResult_SocketAsyncEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667296);
		NativeMethodInfoPtr_ReceiveFrom_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_byref_SocketAddress_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667297);
		NativeMethodInfoPtr_ReceiveFrom_icall_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_byref_SocketAddress_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667298);
		NativeMethodInfoPtr_Send_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667299);
		NativeMethodInfoPtr_Send_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_byref_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667300);
		NativeMethodInfoPtr_SendAsync_Public_Boolean_SocketAsyncEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667301);
		NativeMethodInfoPtr_BeginSend_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667302);
		NativeMethodInfoPtr_BeginSendCallback_Private_Static_Void_SocketAsyncResult_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667303);
		NativeMethodInfoPtr_EndSend_Public_Int32_IAsyncResult_byref_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667304);
		NativeMethodInfoPtr_Send_internal_Private_Static_Int32_SafeSocketHandle_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667305);
		NativeMethodInfoPtr_Send_array_icall_Private_Static_Int32_IntPtr_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667306);
		NativeMethodInfoPtr_Send_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667307);
		NativeMethodInfoPtr_Send_icall_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667308);
		NativeMethodInfoPtr_EndSendTo_Public_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667309);
		NativeMethodInfoPtr_GetSocketOption_Public_Object_SocketOptionLevel_SocketOptionName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667310);
		NativeMethodInfoPtr_GetSocketOption_obj_internal_Private_Static_Void_SafeSocketHandle_SocketOptionLevel_SocketOptionName_byref_Object_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667311);
		NativeMethodInfoPtr_GetSocketOption_obj_icall_Private_Static_Void_IntPtr_SocketOptionLevel_SocketOptionName_byref_Object_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667312);
		NativeMethodInfoPtr_SetSocketOption_Public_Void_SocketOptionLevel_SocketOptionName_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667313);
		NativeMethodInfoPtr_SetSocketOption_internal_Private_Static_Void_SafeSocketHandle_SocketOptionLevel_SocketOptionName_Object_Il2CppStructArray_1_Byte_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667314);
		NativeMethodInfoPtr_SetSocketOption_icall_Private_Static_Void_IntPtr_SocketOptionLevel_SocketOptionName_Object_Il2CppStructArray_1_Byte_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667315);
		NativeMethodInfoPtr_IOControl_Public_Int32_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667316);
		NativeMethodInfoPtr_IOControl_internal_Private_Static_Int32_SafeSocketHandle_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667317);
		NativeMethodInfoPtr_IOControl_icall_Private_Static_Int32_IntPtr_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667318);
		NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667319);
		NativeMethodInfoPtr_Close_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667320);
		NativeMethodInfoPtr_Close_icall_Internal_Static_Void_IntPtr_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667321);
		NativeMethodInfoPtr_Shutdown_internal_Private_Static_Void_SafeSocketHandle_SocketShutdown_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667322);
		NativeMethodInfoPtr_Shutdown_icall_Internal_Static_Void_IntPtr_SocketShutdown_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667323);
		NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667324);
		NativeMethodInfoPtr_Linger_Private_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667325);
		NativeMethodInfoPtr_ThrowIfDisposedAndClosed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667326);
		NativeMethodInfoPtr_ThrowIfBufferNull_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667327);
		NativeMethodInfoPtr_ThrowIfBufferOutOfRange_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667328);
		NativeMethodInfoPtr_ThrowIfUdp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667329);
		NativeMethodInfoPtr_ValidateEndIAsyncResult_Private_SocketAsyncResult_IAsyncResult_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667330);
		NativeMethodInfoPtr_QueueIOSelectorJob_Private_Void_SemaphoreSlim_IntPtr_IOSelectorJob_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667331);
		NativeMethodInfoPtr_InitSocketAsyncEventArgs_Private_Void_SocketAsyncEventArgs_AsyncCallback_Object_SocketOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667332);
		NativeMethodInfoPtr_SocketOperationToSocketAsyncOperation_Private_SocketAsyncOperation_SocketOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667333);
		NativeMethodInfoPtr_RemapIPEndPoint_Private_IPEndPoint_IPEndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667334);
		NativeMethodInfoPtr_cancel_blocking_socket_operation_Internal_Static_Void_Thread_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667335);
		NativeMethodInfoPtr_get_FamilyHint_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667336);
		NativeMethodInfoPtr_IsProtocolSupported_internal_Private_Static_Boolean_NetworkInterfaceComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667337);
		NativeMethodInfoPtr_IsProtocolSupported_Private_Static_Boolean_NetworkInterfaceComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667338);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 898356, RefRangeEnd = 898358, XrefRangeStart = 898310, XrefRangeEnd = 898356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ValueTask<int> ReceiveAsync(Memory<byte> buffer, SocketFlags socketFlags, bool fromNetworkStream, CancellationToken cancellationToken)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)buffer));
		*(SocketFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &socketFlags;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fromNetworkStream;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cancellationToken));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReceiveAsync_Internal_ValueTask_1_Int32_Memory_1_Byte_SocketFlags_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ValueTask<int>(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 898406, RefRangeEnd = 898407, XrefRangeStart = 898358, XrefRangeEnd = 898406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Task<int> ReceiveAsyncApm(Memory<byte> buffer, SocketFlags socketFlags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)buffer));
		*(SocketFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &socketFlags;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReceiveAsyncApm_Private_Task_1_Int32_Memory_1_Byte_SocketFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task<int>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 898452, RefRangeEnd = 898454, XrefRangeStart = 898407, XrefRangeEnd = 898452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ValueTask SendAsyncForNetworkStream(ReadOnlyMemory<byte> buffer, SocketFlags socketFlags, CancellationToken cancellationToken)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)buffer));
		*(SocketFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &socketFlags;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cancellationToken));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendAsyncForNetworkStream_Internal_ValueTask_ReadOnlyMemory_1_Byte_SocketFlags_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ValueTask(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 898527, RefRangeEnd = 898528, XrefRangeStart = 898454, XrefRangeEnd = 898527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Task<int> SendAsyncApm(ReadOnlyMemory<byte> buffer, SocketFlags socketFlags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)buffer));
		*(SocketFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &socketFlags;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendAsyncApm_Private_Task_1_Int32_ReadOnlyMemory_1_Byte_SocketFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task<int>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898528, XrefRangeEnd = 898550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CompleteAccept(Socket s, TaskSocketAsyncEventArgs<Socket> saea)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)saea);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompleteAccept_Private_Static_Void_Socket_TaskSocketAsyncEventArgs_1_Socket_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 898567, RefRangeEnd = 898569, XrefRangeStart = 898550, XrefRangeEnd = 898567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CompleteSendReceive(Socket s, Int32TaskSocketAsyncEventArgs saea, bool isReceive)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)saea);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isReceive;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompleteSendReceive_Private_Static_Void_Socket_Int32TaskSocketAsyncEventArgs_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 898580, RefRangeEnd = 898581, XrefRangeStart = 898569, XrefRangeEnd = 898580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception GetException(SocketError error, bool wrapExceptionsInIOExceptions = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&error);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &wrapExceptionsInIOExceptions;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetException_Private_Static_Exception_SocketError_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898581, XrefRangeEnd = 898586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReturnSocketAsyncEventArgs(Int32TaskSocketAsyncEventArgs saea, bool isReceive)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)saea);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isReceive;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReturnSocketAsyncEventArgs_Private_Void_Int32TaskSocketAsyncEventArgs_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898586, XrefRangeEnd = 898590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReturnSocketAsyncEventArgs(TaskSocketAsyncEventArgs<Socket> saea)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)saea);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReturnSocketAsyncEventArgs_Private_Void_TaskSocketAsyncEventArgs_1_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 898627, RefRangeEnd = 898635, XrefRangeStart = 898590, XrefRangeEnd = 898627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Socket(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Socket>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&addressFamily);
		*(SocketType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &socketType;
		*(ProtocolType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &protocolType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_AddressFamily_SocketType_ProtocolType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool CanTryAddressFamily(AddressFamily family)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&family);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanTryAddressFamily_Internal_Boolean_AddressFamily_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898658, XrefRangeEnd = 898659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffers);
		*(SocketFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &socketFlags;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Send_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898659, XrefRangeEnd = 898660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Send(Il2CppStructArray<byte> buffer, int offset, int size, SocketFlags socketFlags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		*(SocketFlags**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &socketFlags;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Send_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898660, XrefRangeEnd = 898661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Receive(Il2CppStructArray<byte> buffer, int offset, int size, SocketFlags socketFlags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		*(SocketFlags**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &socketFlags;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Receive_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898661, XrefRangeEnd = 898662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffers);
		*(SocketFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &socketFlags;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Receive_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 898666, RefRangeEnd = 898667, XrefRangeStart = 898662, XrefRangeEnd = 898666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int IOControl(IOControlCode ioControlCode, Il2CppStructArray<byte> optionInValue, Il2CppStructArray<byte> optionOutValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&ioControlCode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)optionInValue);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)optionOutValue);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IOControl_Public_Int32_IOControlCode_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898667, XrefRangeEnd = 898668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetIPProtectionLevel(IPProtectionLevel level)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&level);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetIPProtectionLevel_Public_Void_IPProtectionLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 898669, RefRangeEnd = 898671, XrefRangeStart = 898668, XrefRangeEnd = 898669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IAsyncResult BeginSend(Il2CppStructArray<byte> buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, Object state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		*(SocketFlags**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &socketFlags;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginSend_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 898680, RefRangeEnd = 898684, XrefRangeStart = 898671, XrefRangeEnd = 898680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int EndSend(IAsyncResult asyncResult)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asyncResult);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndSend_Public_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 898685, RefRangeEnd = 898687, XrefRangeStart = 898684, XrefRangeEnd = 898685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IAsyncResult BeginReceive(Il2CppStructArray<byte> buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, Object state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		*(SocketFlags**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &socketFlags;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginReceive_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 898696, RefRangeEnd = 898700, XrefRangeStart = 898687, XrefRangeEnd = 898696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int EndReceive(IAsyncResult asyncResult)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asyncResult);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndReceive_Public_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 898771, RefRangeEnd = 898777, XrefRangeStart = 898715, XrefRangeEnd = 898771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitializeSockets()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeSockets_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 898781, RefRangeEnd = 898782, XrefRangeStart = 898777, XrefRangeEnd = 898781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Finalize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 898786, RefRangeEnd = 898788, XrefRangeStart = 898782, XrefRangeEnd = 898786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalShutdown(SocketShutdown how)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&how);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalShutdown_Internal_Void_SocketShutdown_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 898793, RefRangeEnd = 898795, XrefRangeStart = 898788, XrefRangeEnd = 898793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue, bool silent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&optionLevel);
		*(SocketOptionName**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &optionName;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &optionValue;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &silent;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSocketOption_Internal_Void_SocketOptionLevel_SocketOptionName_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 898810, RefRangeEnd = 898811, XrefRangeStart = 898795, XrefRangeEnd = 898810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Socket(AddressFamily family, SocketType type, ProtocolType proto, SafeSocketHandle safe_handle)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Socket>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&family);
		*(SocketType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(ProtocolType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &proto;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)safe_handle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_AddressFamily_SocketType_ProtocolType_SafeSocketHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 898813, RefRangeEnd = 898814, XrefRangeStart = 898811, XrefRangeEnd = 898813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SocketDefaults()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SocketDefaults_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898814, XrefRangeEnd = 898815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr Socket_icall(AddressFamily family, SocketType type, ProtocolType proto, out int error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&family);
		*(SocketType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(ProtocolType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &proto;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Socket_icall_Private_Static_IntPtr_AddressFamily_SocketType_ProtocolType_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 898831, RefRangeEnd = 898832, XrefRangeStart = 898823, XrefRangeEnd = 898831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SocketAddress LocalEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)safeHandle);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &family;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LocalEndPoint_internal_Private_Static_SocketAddress_SafeSocketHandle_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SocketAddress>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898832, XrefRangeEnd = 898833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SocketAddress LocalEndPoint_icall(System.IntPtr socket, int family, out int error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&socket);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &family;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LocalEndPoint_icall_Private_Static_SocketAddress_IntPtr_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SocketAddress>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 898848, RefRangeEnd = 898849, XrefRangeStart = 898840, XrefRangeEnd = 898848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Blocking_internal(SafeSocketHandle safeHandle, bool block, out int error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)safeHandle);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &block;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Blocking_internal_Private_Static_Void_SafeSocketHandle_Boolean_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898849, XrefRangeEnd = 898850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Blocking_icall(System.IntPtr socket, bool block, out int error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&socket);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &block;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Blocking_icall_Internal_Static_Void_IntPtr_Boolean_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 898868, RefRangeEnd = 898869, XrefRangeStart = 898860, XrefRangeEnd = 898868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SocketAddress RemoteEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)safeHandle);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &family;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoteEndPoint_internal_Private_Static_SocketAddress_SafeSocketHandle_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SocketAddress>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898869, XrefRangeEnd = 898870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SocketAddress RemoteEndPoint_icall(System.IntPtr socket, int family, out int error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&socket);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &family;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoteEndPoint_icall_Private_Static_SocketAddress_IntPtr_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SocketAddress>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 898878, RefRangeEnd = 898880, XrefRangeStart = 898870, XrefRangeEnd = 898878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Poll(int microSeconds, SelectMode mode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&microSeconds);
		*(SelectMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Poll_Public_Boolean_Int32_SelectMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 898888, RefRangeEnd = 898889, XrefRangeStart = 898880, XrefRangeEnd = 898888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Poll_internal(SafeSocketHandle safeHandle, SelectMode mode, int timeout, out int error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)safeHandle);
		*(SelectMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &timeout;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Poll_internal_Private_Static_Boolean_SafeSocketHandle_SelectMode_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898889, XrefRangeEnd = 898890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Poll_icall(System.IntPtr socket, SelectMode mode, int timeout, out int error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&socket);
		*(SelectMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &timeout;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Poll_icall_Private_Static_Boolean_IntPtr_SelectMode_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 898900, RefRangeEnd = 898903, XrefRangeStart = 898890, XrefRangeEnd = 898900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Socket Accept()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Accept_Public_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Socket>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 898911, RefRangeEnd = 898913, XrefRangeStart = 898903, XrefRangeEnd = 898911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Accept(Socket acceptSocket)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)acceptSocket);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Accept_Internal_Void_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 898929, RefRangeEnd = 898930, XrefRangeStart = 898913, XrefRangeEnd = 898929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IAsyncResult BeginAccept(AsyncCallback callback, Object state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginAccept_Public_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 898942, RefRangeEnd = 898943, XrefRangeStart = 898930, XrefRangeEnd = 898942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Socket EndAccept(IAsyncResult asyncResult)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asyncResult);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndAccept_Public_Socket_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Socket>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898943, XrefRangeEnd = 898955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Socket EndAccept(out Il2CppStructArray<byte> buffer, out int bytesTransferred, IAsyncResult asyncResult)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		nint num = 0;
		*ptr = (nint)(&num);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref bytesTransferred);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asyncResult);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndAccept_Public_Socket_byref_Il2CppStructArray_1_Byte_byref_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num2 = num;
		buffer = ((num2 == 0) ? null : new Il2CppStructArray<byte>((System.IntPtr)num2));
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Socket>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 898967, RefRangeEnd = 898969, XrefRangeStart = 898955, XrefRangeEnd = 898967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SafeSocketHandle Accept_internal(SafeSocketHandle safeHandle, out int error, bool blocking)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)safeHandle);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &blocking;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Accept_internal_Private_Static_SafeSocketHandle_SafeSocketHandle_byref_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SafeSocketHandle>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898969, XrefRangeEnd = 898970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr Accept_icall(System.IntPtr sock, out int error, bool blocking)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&sock);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &blocking;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Accept_icall_Private_Static_IntPtr_IntPtr_byref_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 898980, RefRangeEnd = 898983, XrefRangeStart = 898970, XrefRangeEnd = 898980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Bind(EndPoint localEP)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)localEP);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Bind_Public_Void_EndPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 898991, RefRangeEnd = 898992, XrefRangeStart = 898983, XrefRangeEnd = 898991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Bind_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)safeHandle);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sa);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Bind_internal_Private_Static_Void_SafeSocketHandle_SocketAddress_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898992, XrefRangeEnd = 898993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Bind_icall(System.IntPtr sock, SocketAddress sa, out int error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&sock);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sa);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Bind_icall_Private_Static_Void_IntPtr_SocketAddress_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 898998, RefRangeEnd = 898999, XrefRangeStart = 898993, XrefRangeEnd = 898998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Listen(int backlog)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&backlog);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Listen_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 899007, RefRangeEnd = 899008, XrefRangeStart = 898999, XrefRangeEnd = 899007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Listen_internal(SafeSocketHandle safeHandle, int backlog, out int error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)safeHandle);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &backlog;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Listen_internal_Private_Static_Void_SafeSocketHandle_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899008, XrefRangeEnd = 899009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Listen_icall(System.IntPtr sock, int backlog, out int error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&sock);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &backlog;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Listen_icall_Private_Static_Void_IntPtr_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 899014, RefRangeEnd = 899016, XrefRangeStart = 899009, XrefRangeEnd = 899014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Connect(IPAddress address, int port)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)address);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &port;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Connect_Public_Void_IPAddress_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 899040, RefRangeEnd = 899043, XrefRangeStart = 899016, XrefRangeEnd = 899040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Connect(EndPoint remoteEP)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)remoteEP);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Connect_Public_Void_EndPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 899068, RefRangeEnd = 899069, XrefRangeStart = 899043, XrefRangeEnd = 899068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IAsyncResult BeginConnect(string host, int port, AsyncCallback callback, Object state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(host);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &port;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginConnect_Public_IAsyncResult_String_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 899080, RefRangeEnd = 899082, XrefRangeStart = 899069, XrefRangeEnd = 899080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IAsyncResult BeginConnect(EndPoint remoteEP, AsyncCallback callback, Object state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)remoteEP);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginConnect_Public_IAsyncResult_EndPoint_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 899093, RefRangeEnd = 899095, XrefRangeStart = 899082, XrefRangeEnd = 899093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool BeginMConnect(SocketAsyncResult sockares)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sockares);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginMConnect_Private_Static_Boolean_SocketAsyncResult_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 899119, RefRangeEnd = 899121, XrefRangeStart = 899095, XrefRangeEnd = 899119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool BeginSConnect(SocketAsyncResult sockares)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sockares);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginSConnect_Private_Static_Boolean_SocketAsyncResult_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 899130, RefRangeEnd = 899134, XrefRangeStart = 899121, XrefRangeEnd = 899130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EndConnect(IAsyncResult asyncResult)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asyncResult);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndConnect_Public_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 899142, RefRangeEnd = 899143, XrefRangeStart = 899134, XrefRangeEnd = 899142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Connect_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error, bool blocking)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)safeHandle);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sa);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &blocking;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Connect_internal_Private_Static_Void_SafeSocketHandle_SocketAddress_byref_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899143, XrefRangeEnd = 899144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Connect_icall(System.IntPtr sock, SocketAddress sa, out int error, bool blocking)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&sock);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sa);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &blocking;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Connect_icall_Private_Static_Void_IntPtr_SocketAddress_byref_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899144, XrefRangeEnd = 899149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Disconnect(bool reuseSocket)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&reuseSocket);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Disconnect_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899149, XrefRangeEnd = 899158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EndDisconnect(IAsyncResult asyncResult)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asyncResult);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndDisconnect_Public_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 899166, RefRangeEnd = 899168, XrefRangeStart = 899158, XrefRangeEnd = 899166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Disconnect_internal(SafeSocketHandle safeHandle, bool reuse, out int error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)safeHandle);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &reuse;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Disconnect_internal_Private_Static_Void_SafeSocketHandle_Boolean_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899168, XrefRangeEnd = 899169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Disconnect_icall(System.IntPtr sock, bool reuse, out int error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&sock);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &reuse;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Disconnect_icall_Private_Static_Void_IntPtr_Boolean_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 899176, RefRangeEnd = 899180, XrefRangeStart = 899169, XrefRangeEnd = 899176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Receive(Il2CppStructArray<byte> buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		*(SocketFlags**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &socketFlags;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref errorCode);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Receive_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 899197, RefRangeEnd = 899198, XrefRangeStart = 899180, XrefRangeEnd = 899197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Receive(Memory<byte> buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)buffer));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		*(SocketFlags**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &socketFlags;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref errorCode);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Receive_Private_Int32_Memory_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 899244, RefRangeEnd = 899246, XrefRangeStart = 899198, XrefRangeEnd = 899244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffers);
		*(SocketFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &socketFlags;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref errorCode);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Receive_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_byref_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899246, XrefRangeEnd = 899255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Receive(Span<byte> buffer, SocketFlags socketFlags, out SocketError errorCode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)buffer));
		*(SocketFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &socketFlags;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref errorCode);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Receive_Public_Int32_Span_1_Byte_SocketFlags_byref_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899255, XrefRangeEnd = 899259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Send(ReadOnlySpan<byte> buffer, SocketFlags socketFlags, out SocketError errorCode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)buffer));
		*(SocketFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &socketFlags;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref errorCode);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Send_Public_Int32_ReadOnlySpan_1_Byte_SocketFlags_byref_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 899300, RefRangeEnd = 899301, XrefRangeStart = 899259, XrefRangeEnd = 899300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ReceiveAsync(SocketAsyncEventArgs e)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)e);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReceiveAsync_Public_Boolean_SocketAsyncEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 899322, RefRangeEnd = 899323, XrefRangeStart = 899301, XrefRangeEnd = 899322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IAsyncResult BeginReceive(Il2CppStructArray<byte> buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, Object state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		*(SocketFlags**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &socketFlags;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref errorCode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginReceive_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899323, XrefRangeEnd = 899332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int EndReceive(IAsyncResult asyncResult, out SocketError errorCode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asyncResult);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref errorCode);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndReceive_Public_Int32_IAsyncResult_byref_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 899340, RefRangeEnd = 899341, XrefRangeStart = 899332, XrefRangeEnd = 899340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Receive_internal(SafeSocketHandle safeHandle, WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)safeHandle);
		*(WSABUF**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = bufarray;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(SocketFlags**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &blocking;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Receive_internal_Private_Static_Int32_SafeSocketHandle_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899341, XrefRangeEnd = 899342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Receive_array_icall(System.IntPtr sock, WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&sock);
		*(WSABUF**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = bufarray;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(SocketFlags**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &blocking;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Receive_array_icall_Private_Static_Int32_IntPtr_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 899350, RefRangeEnd = 899353, XrefRangeStart = 899342, XrefRangeEnd = 899350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Receive_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)safeHandle);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = buffer;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(SocketFlags**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &blocking;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Receive_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899353, XrefRangeEnd = 899354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Receive_icall(System.IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&sock);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = buffer;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(SocketFlags**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &blocking;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Receive_icall_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 899371, RefRangeEnd = 899372, XrefRangeStart = 899354, XrefRangeEnd = 899371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int ReceiveFrom(Memory<byte> buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, out SocketError errorCode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)buffer));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		*(SocketFlags**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &socketFlags;
		byte* num = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)remoteEP);
		*(System.IntPtr**)num = &intPtr;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref errorCode);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReceiveFrom_Private_Int32_Memory_1_Byte_Int32_Int32_SocketFlags_byref_EndPoint_byref_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		remoteEP = ((intPtr4 == (System.IntPtr)0) ? null : new EndPoint(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899372, XrefRangeEnd = 899377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int EndReceiveFrom_internal(SocketAsyncResult sockares, SocketAsyncEventArgs ares)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sockares);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ares);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndReceiveFrom_internal_Private_Int32_SocketAsyncResult_SocketAsyncEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 899385, RefRangeEnd = 899386, XrefRangeStart = 899377, XrefRangeEnd = 899385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ReceiveFrom_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)safeHandle);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = buffer;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(SocketFlags**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		byte* num = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sockaddr);
		*(System.IntPtr**)num = &intPtr;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &blocking;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReceiveFrom_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_byref_SocketAddress_byref_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		sockaddr = ((intPtr4 == (System.IntPtr)0) ? null : new SocketAddress(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899386, XrefRangeEnd = 899387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ReceiveFrom_icall(System.IntPtr sock, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&sock);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = buffer;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(SocketFlags**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		byte* num = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sockaddr);
		*(System.IntPtr**)num = &intPtr;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &blocking;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReceiveFrom_icall_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_byref_SocketAddress_byref_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		sockaddr = ((intPtr4 == (System.IntPtr)0) ? null : new SocketAddress(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 899394, RefRangeEnd = 899398, XrefRangeStart = 899387, XrefRangeEnd = 899394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Send(Il2CppStructArray<byte> buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		*(SocketFlags**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &socketFlags;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref errorCode);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Send_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 899444, RefRangeEnd = 899446, XrefRangeStart = 899398, XrefRangeEnd = 899444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffers);
		*(SocketFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &socketFlags;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref errorCode);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Send_Public_Int32_IList_1_ArraySegment_1_Byte_SocketFlags_byref_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 899501, RefRangeEnd = 899502, XrefRangeStart = 899446, XrefRangeEnd = 899501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SendAsync(SocketAsyncEventArgs e)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)e);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendAsync_Public_Boolean_SocketAsyncEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 899534, RefRangeEnd = 899535, XrefRangeStart = 899502, XrefRangeEnd = 899534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IAsyncResult BeginSend(Il2CppStructArray<byte> buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, Object state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		*(SocketFlags**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &socketFlags;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref errorCode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginSend_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_SocketFlags_byref_SocketError_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 899558, RefRangeEnd = 899561, XrefRangeStart = 899535, XrefRangeEnd = 899558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BeginSendCallback(SocketAsyncResult sockares, int sent_so_far)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sockares);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sent_so_far;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginSendCallback_Private_Static_Void_SocketAsyncResult_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899561, XrefRangeEnd = 899570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int EndSend(IAsyncResult asyncResult, out SocketError errorCode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asyncResult);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref errorCode);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndSend_Public_Int32_IAsyncResult_byref_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 899578, RefRangeEnd = 899579, XrefRangeStart = 899570, XrefRangeEnd = 899578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Send_internal(SafeSocketHandle safeHandle, WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)safeHandle);
		*(WSABUF**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = bufarray;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(SocketFlags**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &blocking;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Send_internal_Private_Static_Int32_SafeSocketHandle_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899579, XrefRangeEnd = 899580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Send_array_icall(System.IntPtr sock, WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&sock);
		*(WSABUF**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = bufarray;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(SocketFlags**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &blocking;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Send_array_icall_Private_Static_Int32_IntPtr_ptr_WSABUF_Int32_SocketFlags_byref_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 899588, RefRangeEnd = 899590, XrefRangeStart = 899580, XrefRangeEnd = 899588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Send_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)safeHandle);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = buffer;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(SocketFlags**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &blocking;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Send_internal_Private_Static_Int32_SafeSocketHandle_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899590, XrefRangeEnd = 899591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Send_icall(System.IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&sock);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = buffer;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(SocketFlags**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &blocking;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Send_icall_Private_Static_Int32_IntPtr_ptr_Byte_Int32_SocketFlags_byref_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899591, XrefRangeEnd = 899599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int EndSendTo(IAsyncResult asyncResult)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asyncResult);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndSendTo_Public_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 899610, RefRangeEnd = 899616, XrefRangeStart = 899599, XrefRangeEnd = 899610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&optionLevel);
		*(SocketOptionName**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &optionName;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSocketOption_Public_Object_SocketOptionLevel_SocketOptionName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 899624, RefRangeEnd = 899625, XrefRangeStart = 899616, XrefRangeEnd = 899624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetSocketOption_obj_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, out Object obj_val, out int error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)safeHandle);
		*(SocketOptionLevel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(SocketOptionName**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &name;
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSocketOption_obj_internal_Private_Static_Void_SafeSocketHandle_SocketOptionLevel_SocketOptionName_byref_Object_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		obj_val = ((num3 == 0) ? null : new Object(num3));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899625, XrefRangeEnd = 899626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetSocketOption_obj_icall(System.IntPtr socket, SocketOptionLevel level, SocketOptionName name, out Object obj_val, out int error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&socket);
		*(SocketOptionLevel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(SocketOptionName**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &name;
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSocketOption_obj_icall_Private_Static_Void_IntPtr_SocketOptionLevel_SocketOptionName_byref_Object_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		obj_val = ((num3 == 0) ? null : new Object(num3));
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 899632, RefRangeEnd = 899638, XrefRangeStart = 899626, XrefRangeEnd = 899632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&optionLevel);
		*(SocketOptionName**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &optionName;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &optionValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSocketOption_Public_Void_SocketOptionLevel_SocketOptionName_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 899646, RefRangeEnd = 899648, XrefRangeStart = 899638, XrefRangeEnd = 899646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetSocketOption_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, Object obj_val, Il2CppStructArray<byte> byte_val, int int_val, out int error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)safeHandle);
		*(SocketOptionLevel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(SocketOptionName**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &name;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj_val);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)byte_val);
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &int_val;
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSocketOption_internal_Private_Static_Void_SafeSocketHandle_SocketOptionLevel_SocketOptionName_Object_Il2CppStructArray_1_Byte_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899648, XrefRangeEnd = 899649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetSocketOption_icall(System.IntPtr socket, SocketOptionLevel level, SocketOptionName name, Object obj_val, Il2CppStructArray<byte> byte_val, int int_val, out int error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&socket);
		*(SocketOptionLevel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(SocketOptionName**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &name;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj_val);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)byte_val);
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &int_val;
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSocketOption_icall_Private_Static_Void_IntPtr_SocketOptionLevel_SocketOptionName_Object_Il2CppStructArray_1_Byte_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899649, XrefRangeEnd = 899653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int IOControl(int ioControlCode, Il2CppStructArray<byte> optionInValue, Il2CppStructArray<byte> optionOutValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&ioControlCode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)optionInValue);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)optionOutValue);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IOControl_Public_Int32_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 899661, RefRangeEnd = 899663, XrefRangeStart = 899653, XrefRangeEnd = 899661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int IOControl_internal(SafeSocketHandle safeHandle, int ioctl_code, Il2CppStructArray<byte> input, Il2CppStructArray<byte> output, out int error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)safeHandle);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ioctl_code;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)input);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)output);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IOControl_internal_Private_Static_Int32_SafeSocketHandle_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899663, XrefRangeEnd = 899664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int IOControl_icall(System.IntPtr sock, int ioctl_code, Il2CppStructArray<byte> input, Il2CppStructArray<byte> output, out int error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&sock);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ioctl_code;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)input);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)output);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IOControl_icall_Private_Static_Int32_IntPtr_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 899668, RefRangeEnd = 899676, XrefRangeStart = 899664, XrefRangeEnd = 899668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Close()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899676, XrefRangeEnd = 899680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Close(int timeout)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&timeout);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Close_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899680, XrefRangeEnd = 899681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Close_icall(System.IntPtr socket, out int error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&socket);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Close_icall_Internal_Static_Void_IntPtr_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 899689, RefRangeEnd = 899690, XrefRangeStart = 899681, XrefRangeEnd = 899689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Shutdown_internal(SafeSocketHandle safeHandle, SocketShutdown how, out int error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)safeHandle);
		*(SocketShutdown**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &how;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Shutdown_internal_Private_Static_Void_SafeSocketHandle_SocketShutdown_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899690, XrefRangeEnd = 899691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Shutdown_icall(System.IntPtr socket, SocketShutdown how, out int error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&socket);
		*(SocketShutdown**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &how;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref error);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Shutdown_icall_Internal_Static_Void_IntPtr_SocketShutdown_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899691, XrefRangeEnd = 899706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose(bool disposing)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&disposing);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899706, XrefRangeEnd = 899720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Linger(System.IntPtr handle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Linger_Private_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(40)]
	[CachedScanResults(RefRangeStart = 899720, RefRangeEnd = 899760, XrefRangeStart = 899720, XrefRangeEnd = 899720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ThrowIfDisposedAndClosed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowIfDisposedAndClosed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void ThrowIfBufferNull(Il2CppStructArray<byte> buffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowIfBufferNull_Private_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 899760, RefRangeEnd = 899764, XrefRangeStart = 899760, XrefRangeEnd = 899760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ThrowIfBufferOutOfRange(Il2CppStructArray<byte> buffer, int offset, int size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowIfBufferOutOfRange_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void ThrowIfUdp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowIfUdp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 899767, RefRangeEnd = 899779, XrefRangeStart = 899764, XrefRangeEnd = 899767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SocketAsyncResult ValidateEndIAsyncResult(IAsyncResult ares, string methodName, string argName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ares);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(methodName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(argName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateEndIAsyncResult_Private_SocketAsyncResult_IAsyncResult_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SocketAsyncResult>(intPtr2) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 899794, RefRangeEnd = 899799, XrefRangeStart = 899779, XrefRangeEnd = 899794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void QueueIOSelectorJob(SemaphoreSlim sem, System.IntPtr handle, IOSelectorJob job)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sem);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &handle;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)job);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueueIOSelectorJob_Private_Void_SemaphoreSlim_IntPtr_IOSelectorJob_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 899821, RefRangeEnd = 899823, XrefRangeStart = 899799, XrefRangeEnd = 899821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitSocketAsyncEventArgs(SocketAsyncEventArgs e, AsyncCallback callback, Object state, SocketOperation operation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)e);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		*(SocketOperation**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &operation;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitSocketAsyncEventArgs_Private_Void_SocketAsyncEventArgs_AsyncCallback_Object_SocketOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe SocketAsyncOperation SocketOperationToSocketAsyncOperation(SocketOperation op)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&op);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SocketOperationToSocketAsyncOperation_Private_SocketAsyncOperation_SocketOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(SocketAsyncOperation*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 899831, RefRangeEnd = 899834, XrefRangeStart = 899823, XrefRangeEnd = 899831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IPEndPoint RemapIPEndPoint(IPEndPoint input)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)input);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemapIPEndPoint_Private_IPEndPoint_IPEndPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IPEndPoint>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899834, XrefRangeEnd = 899835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void cancel_blocking_socket_operation(Thread thread)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thread);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_cancel_blocking_socket_operation_Internal_Static_Void_Thread_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 804554, RefRangeEnd = 804555, XrefRangeStart = 804554, XrefRangeEnd = 804555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsProtocolSupported_internal(NetworkInterfaceComponent networkInterface)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&networkInterface);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsProtocolSupported_internal_Private_Static_Boolean_NetworkInterfaceComponent_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899857, XrefRangeEnd = 899861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsProtocolSupported(NetworkInterfaceComponent networkInterface)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&networkInterface);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsProtocolSupported_Private_Static_Boolean_NetworkInterfaceComponent_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public Socket(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
