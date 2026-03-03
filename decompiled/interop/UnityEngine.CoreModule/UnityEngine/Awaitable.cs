using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.ExceptionServices;
using Il2CppSystem.Runtime.InteropServices;
using Il2CppSystem.Threading;
using UnityEngine.Pool;

namespace UnityEngine;

public class Awaitable : Il2CppSystem.Object
{
	[OriginalName("UnityEngine.CoreModule.dll", "", "AwaiterCompletionThreadAffinity")]
	public enum AwaiterCompletionThreadAffinity
	{
		None,
		MainThread,
		BackgroundThread
	}

	public sealed class AwaitableAsyncMethodBuilder : Il2CppSystem.ValueType
	{
		public class IStateMachineBox : Il2CppObjectBase
		{
			static IStateMachineBox()
			{
				Il2CppClassPointerStore<IStateMachineBox>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AwaitableAsyncMethodBuilder>.NativeClassPtr, "IStateMachineBox");
			}

			public IStateMachineBox(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr__stateMachineBox;

		private static readonly System.IntPtr NativeFieldInfoPtr__resultingCoroutine;

		public unsafe IStateMachineBox _stateMachineBox
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__stateMachineBox);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IStateMachineBox>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__stateMachineBox)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Awaitable _resultingCoroutine
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__resultingCoroutine);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Awaitable>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__resultingCoroutine)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static AwaitableAsyncMethodBuilder()
		{
			Il2CppClassPointerStore<AwaitableAsyncMethodBuilder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, "AwaitableAsyncMethodBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AwaitableAsyncMethodBuilder>.NativeClassPtr);
			NativeFieldInfoPtr__stateMachineBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwaitableAsyncMethodBuilder>.NativeClassPtr, "_stateMachineBox");
			NativeFieldInfoPtr__resultingCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwaitableAsyncMethodBuilder>.NativeClassPtr, "_resultingCoroutine");
		}

		public AwaitableAsyncMethodBuilder(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public AwaitableAsyncMethodBuilder()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AwaitableAsyncMethodBuilder>.NativeClassPtr))
		{
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct AwaitableHandle
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__handle;

		private static readonly System.IntPtr NativeFieldInfoPtr_ManagedHandle;

		private static readonly System.IntPtr NativeFieldInfoPtr_NullHandle;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsNull_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsManaged_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_IntPtr_AwaitableHandle_0;

		[System.Runtime.InteropServices.FieldOffset(0)]
		public readonly System.IntPtr _handle;

		public unsafe static AwaitableHandle ManagedHandle
		{
			get
			{
				Unsafe.SkipInit(out AwaitableHandle result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ManagedHandle, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ManagedHandle, (void*)(&value));
			}
		}

		public unsafe static AwaitableHandle NullHandle
		{
			get
			{
				Unsafe.SkipInit(out AwaitableHandle result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NullHandle, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NullHandle, (void*)(&value));
			}
		}

		public unsafe bool IsNull
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 762667, RefRangeEnd = 762672, XrefRangeStart = 762667, XrefRangeEnd = 762672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsNull_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe bool IsManaged
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186035, XrefRangeEnd = 1186039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsManaged_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		static AwaitableHandle()
		{
			Il2CppClassPointerStore<AwaitableHandle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, "AwaitableHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AwaitableHandle>.NativeClassPtr);
			NativeFieldInfoPtr__handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwaitableHandle>.NativeClassPtr, "_handle");
			NativeFieldInfoPtr_ManagedHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwaitableHandle>.NativeClassPtr, "ManagedHandle");
			NativeFieldInfoPtr_NullHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwaitableHandle>.NativeClassPtr, "NullHandle");
			NativeMethodInfoPtr_get_IsNull_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitableHandle>.NativeClassPtr, 100666211);
			NativeMethodInfoPtr_get_IsManaged_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitableHandle>.NativeClassPtr, 100666212);
			NativeMethodInfoPtr_op_Implicit_Public_Static_IntPtr_AwaitableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitableHandle>.NativeClassPtr, 100666214);
		}

		[CallerCount(1403)]
		[CachedScanResults(RefRangeStart = 106100, RefRangeEnd = 107503, XrefRangeStart = 106100, XrefRangeEnd = 107503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator System.IntPtr(AwaitableHandle handle)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&handle);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_IntPtr_AwaitableHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AwaitableHandle>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public sealed class AwaitableAndFrameIndex : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__Awaitable_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__FrameIndex_k__BackingField;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Awaitable_Public_get_Awaitable_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_FrameIndex_Public_get_Int32_0;

		public unsafe Awaitable _Awaitable_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Awaitable_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Awaitable>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Awaitable_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int _FrameIndex_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__FrameIndex_k__BackingField);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__FrameIndex_k__BackingField)) = value;
			}
		}

		public unsafe Awaitable Awaitable
		{
			[CallerCount(98)]
			[CachedScanResults(RefRangeStart = 110111, RefRangeEnd = 110209, XrefRangeStart = 110111, XrefRangeEnd = 110209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Awaitable_Public_get_Awaitable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Awaitable>(intPtr2) : null;
			}
		}

		public unsafe int FrameIndex
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 719678, RefRangeEnd = 719702, XrefRangeStart = 719678, XrefRangeEnd = 719702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FrameIndex_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		static AwaitableAndFrameIndex()
		{
			Il2CppClassPointerStore<AwaitableAndFrameIndex>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, "AwaitableAndFrameIndex");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AwaitableAndFrameIndex>.NativeClassPtr);
			NativeFieldInfoPtr__Awaitable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwaitableAndFrameIndex>.NativeClassPtr, "<Awaitable>k__BackingField");
			NativeFieldInfoPtr__FrameIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwaitableAndFrameIndex>.NativeClassPtr, "<FrameIndex>k__BackingField");
			NativeMethodInfoPtr_get_Awaitable_Public_get_Awaitable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitableAndFrameIndex>.NativeClassPtr, 100666216);
			NativeMethodInfoPtr_get_FrameIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitableAndFrameIndex>.NativeClassPtr, 100666217);
		}

		public AwaitableAndFrameIndex(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public AwaitableAndFrameIndex()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AwaitableAndFrameIndex>.NativeClassPtr))
		{
		}
	}

	public class DoubleBufferedAwaitableList : Il2CppSystem.Object
	{
		public sealed class _003C_003Ec__DisplayClass4_0
		{
		}

		private static readonly System.IntPtr NativeFieldInfoPtr__awaitables;

		private static readonly System.IntPtr NativeFieldInfoPtr__scratch;

		private static readonly System.IntPtr NativeMethodInfoPtr_SwapAndComplete_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe List<AwaitableAndFrameIndex> _awaitables
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__awaitables);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AwaitableAndFrameIndex>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__awaitables)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe List<AwaitableAndFrameIndex> _scratch
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__scratch);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AwaitableAndFrameIndex>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__scratch)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static DoubleBufferedAwaitableList()
		{
			Il2CppClassPointerStore<DoubleBufferedAwaitableList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, "DoubleBufferedAwaitableList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoubleBufferedAwaitableList>.NativeClassPtr);
			NativeFieldInfoPtr__awaitables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleBufferedAwaitableList>.NativeClassPtr, "_awaitables");
			NativeFieldInfoPtr__scratch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleBufferedAwaitableList>.NativeClassPtr, "_scratch");
			NativeMethodInfoPtr_SwapAndComplete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleBufferedAwaitableList>.NativeClassPtr, 100666218);
			NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleBufferedAwaitableList>.NativeClassPtr, 100666219);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleBufferedAwaitableList>.NativeClassPtr, 100666220);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1186067, RefRangeEnd = 1186069, XrefRangeStart = 1186039, XrefRangeEnd = 1186067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwapAndComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SwapAndComplete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186069, XrefRangeEnd = 1186071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186071, XrefRangeEnd = 1186084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoubleBufferedAwaitableList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoubleBufferedAwaitableList>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public DoubleBufferedAwaitableList(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("UnityEngine.Awaitable+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__76_1;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__76_0_Internal_ObjectPool_1_Awaitable_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__76_1_Internal_Awaitable_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<Awaitable> __9__76_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__76_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Awaitable>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__76_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__76_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__76_1");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666222);
			NativeMethodInfoPtr___cctor_b__76_0_Internal_ObjectPool_1_Awaitable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666223);
			NativeMethodInfoPtr___cctor_b__76_1_Internal_Awaitable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666224);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186084, XrefRangeEnd = 1186105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectPool<Awaitable> __cctor_b__76_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___cctor_b__76_0_Internal_ObjectPool_1_Awaitable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectPool<Awaitable>>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186105, XrefRangeEnd = 1186109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Awaitable __cctor_b__76_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___cctor_b__76_1_Internal_Awaitable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Awaitable>(intPtr2) : null;
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public sealed class _003C_003Ec
	{
	}

	private delegate System.IntPtr FromAsyncOperationInternalDelegate(System.IntPtr asyncOperation);

	private delegate void AttachManagedGCHandleToNativeAwaitableDelegate(System.IntPtr nativeAwaitable, System.UIntPtr gcHandle);

	private delegate void CancelNativeAwaitableDelegate(System.IntPtr nativeAwaitable);

	private delegate System.IntPtr NextFrameInternalDelegate();

	private delegate System.IntPtr WaitForScondsInternalDelegate(float seconds);

	private delegate System.IntPtr FixedUpdateInternalDelegate();

	private delegate System.IntPtr EndOfFrameInternalDelegate();

	private delegate void WireupNextFrameAndEndOfFrameCallbacksDelegate();

	private static readonly System.IntPtr NativeFieldInfoPtr__spinLock;

	private static readonly System.IntPtr NativeFieldInfoPtr__pool;

	private static readonly System.IntPtr NativeFieldInfoPtr__handle;

	private static readonly System.IntPtr NativeFieldInfoPtr__exceptionToRethrow;

	private static readonly System.IntPtr NativeFieldInfoPtr__managedAwaitableDone;

	private static readonly System.IntPtr NativeFieldInfoPtr__completionThreadAffinity;

	private static readonly System.IntPtr NativeFieldInfoPtr__continuation;

	private static readonly System.IntPtr NativeFieldInfoPtr__cancelTokenRegistration;

	private static readonly System.IntPtr NativeFieldInfoPtr__managedCompletionQueue;

	private static readonly System.IntPtr NativeFieldInfoPtr__nextFrameAndEndOfFrameWiredUp;

	private static readonly System.IntPtr NativeFieldInfoPtr__nextFrameAndEndOfFrameWiredUpCTRegistration;

	private static readonly System.IntPtr NativeFieldInfoPtr__nextFrameAwaitables;

	private static readonly System.IntPtr NativeFieldInfoPtr__endOfFrameAwaitables;

	private static readonly System.IntPtr NativeFieldInfoPtr__synchronizationContext;

	private static readonly System.IntPtr NativeFieldInfoPtr__mainThreadId;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetExceptionFromNative_Private_Void_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RunContinuation_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseNativeAwaitable_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsNativeAwaitableCompleted_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MatchCompletionThreadAffinity_Private_Static_Boolean_AwaiterCompletionThreadAffinity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RunOrScheduleContinuation_Private_Void_AwaiterCompletionThreadAffinity_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoRunContinuationOnSynchonizationContext_Private_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RaiseManagedCompletion_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PropagateExceptionAndRelease_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsCompletedNoLock_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsDettachedOrCompleted_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckPointerValidity_Private_AwaitableHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDelayedCallManagerCleared_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEndOfFrame_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSynchronizationContext_Internal_Static_Void_UnitySynchronizationContext_0;

	private static readonly FromAsyncOperationInternalDelegate FromAsyncOperationInternalDelegateField;

	private static readonly AttachManagedGCHandleToNativeAwaitableDelegate AttachManagedGCHandleToNativeAwaitableDelegateField;

	private static readonly CancelNativeAwaitableDelegate CancelNativeAwaitableDelegateField;

	private static readonly NextFrameInternalDelegate NextFrameInternalDelegateField;

	private static readonly WaitForScondsInternalDelegate WaitForScondsInternalDelegateField;

	private static readonly FixedUpdateInternalDelegate FixedUpdateInternalDelegateField;

	private static readonly EndOfFrameInternalDelegate EndOfFrameInternalDelegateField;

	private static readonly WireupNextFrameAndEndOfFrameCallbacksDelegate WireupNextFrameAndEndOfFrameCallbacksDelegateField;

	public unsafe SpinLock _spinLock
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__spinLock);
			return *(SpinLock*)num;
		}
		set
		{
			*(SpinLock*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__spinLock)) = value;
		}
	}

	public unsafe static ThreadLocal<ObjectPool<Awaitable>> _pool
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__pool, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ThreadLocal<ObjectPool<Awaitable>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__pool, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe AwaitableHandle _handle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__handle);
			return *(AwaitableHandle*)num;
		}
		set
		{
			*(AwaitableHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__handle)) = value;
		}
	}

	public unsafe ExceptionDispatchInfo _exceptionToRethrow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__exceptionToRethrow);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__exceptionToRethrow)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool _managedAwaitableDone
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__managedAwaitableDone);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__managedAwaitableDone)) = value;
		}
	}

	public unsafe AwaiterCompletionThreadAffinity _completionThreadAffinity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__completionThreadAffinity);
			return *(AwaiterCompletionThreadAffinity*)num;
		}
		set
		{
			*(AwaiterCompletionThreadAffinity*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__completionThreadAffinity)) = value;
		}
	}

	public unsafe Il2CppSystem.Action _continuation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__continuation);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__continuation)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppSystem.Nullable<CancellationTokenRegistration> _cancelTokenRegistration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cancelTokenRegistration);
			return new Il2CppSystem.Nullable<CancellationTokenRegistration>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<CancellationTokenRegistration>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cancelTokenRegistration), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<CancellationTokenRegistration>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe DoubleBufferedAwaitableList _managedCompletionQueue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__managedCompletionQueue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DoubleBufferedAwaitableList>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__managedCompletionQueue)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static bool _nextFrameAndEndOfFrameWiredUp
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__nextFrameAndEndOfFrameWiredUp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__nextFrameAndEndOfFrameWiredUp, (void*)(&value));
		}
	}

	public unsafe static CancellationTokenRegistration _nextFrameAndEndOfFrameWiredUpCTRegistration
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__nextFrameAndEndOfFrameWiredUpCTRegistration, (void*)intPtr);
			return new CancellationTokenRegistration(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__nextFrameAndEndOfFrameWiredUpCTRegistration, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static DoubleBufferedAwaitableList _nextFrameAwaitables
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__nextFrameAwaitables, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DoubleBufferedAwaitableList>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__nextFrameAwaitables, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DoubleBufferedAwaitableList _endOfFrameAwaitables
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__endOfFrameAwaitables, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DoubleBufferedAwaitableList>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__endOfFrameAwaitables, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static SynchronizationContext _synchronizationContext
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__synchronizationContext, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__synchronizationContext, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int _mainThreadId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__mainThreadId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__mainThreadId, (void*)(&value));
		}
	}

	public unsafe bool IsCompletedNoLock
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186208, XrefRangeEnd = 1186223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsCompletedNoLock_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool IsCompleted
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1186250, RefRangeEnd = 1186251, XrefRangeStart = 1186223, XrefRangeEnd = 1186250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool IsDettachedOrCompleted
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1186279, RefRangeEnd = 1186280, XrefRangeStart = 1186251, XrefRangeEnd = 1186279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsDettachedOrCompleted_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe virtual Il2CppSystem.Object System_002ECollections_002EIEnumerator_002ECurrent
	{
		[CallerCount(146)]
		[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
		}
	}

	public bool IsLogicallyCompletedNoLock
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public AwaiterCompletionThreadAffinity CompletionThreadAffinity
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	static Awaitable()
	{
		Il2CppClassPointerStore<Awaitable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Awaitable");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Awaitable>.NativeClassPtr);
		NativeFieldInfoPtr__spinLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, "_spinLock");
		NativeFieldInfoPtr__pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, "_pool");
		NativeFieldInfoPtr__handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, "_handle");
		NativeFieldInfoPtr__exceptionToRethrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, "_exceptionToRethrow");
		NativeFieldInfoPtr__managedAwaitableDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, "_managedAwaitableDone");
		NativeFieldInfoPtr__completionThreadAffinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, "_completionThreadAffinity");
		NativeFieldInfoPtr__continuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, "_continuation");
		NativeFieldInfoPtr__cancelTokenRegistration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, "_cancelTokenRegistration");
		NativeFieldInfoPtr__managedCompletionQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, "_managedCompletionQueue");
		NativeFieldInfoPtr__nextFrameAndEndOfFrameWiredUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, "_nextFrameAndEndOfFrameWiredUp");
		NativeFieldInfoPtr__nextFrameAndEndOfFrameWiredUpCTRegistration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, "_nextFrameAndEndOfFrameWiredUpCTRegistration");
		NativeFieldInfoPtr__nextFrameAwaitables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, "_nextFrameAwaitables");
		NativeFieldInfoPtr__endOfFrameAwaitables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, "_endOfFrameAwaitables");
		NativeFieldInfoPtr__synchronizationContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, "_synchronizationContext");
		NativeFieldInfoPtr__mainThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, "_mainThreadId");
		NativeMethodInfoPtr_SetExceptionFromNative_Private_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100666189);
		NativeMethodInfoPtr_RunContinuation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100666190);
		NativeMethodInfoPtr_ReleaseNativeAwaitable_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100666191);
		NativeMethodInfoPtr_IsNativeAwaitableCompleted_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100666192);
		NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100666193);
		NativeMethodInfoPtr_MatchCompletionThreadAffinity_Private_Static_Boolean_AwaiterCompletionThreadAffinity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100666194);
		NativeMethodInfoPtr_RunOrScheduleContinuation_Private_Void_AwaiterCompletionThreadAffinity_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100666195);
		NativeMethodInfoPtr_DoRunContinuationOnSynchonizationContext_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100666196);
		NativeMethodInfoPtr_RaiseManagedCompletion_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100666197);
		NativeMethodInfoPtr_PropagateExceptionAndRelease_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100666198);
		NativeMethodInfoPtr_get_IsCompletedNoLock_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100666199);
		NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100666200);
		NativeMethodInfoPtr_get_IsDettachedOrCompleted_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100666201);
		NativeMethodInfoPtr_CheckPointerValidity_Private_AwaitableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100666202);
		NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100666203);
		NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100666204);
		NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100666205);
		NativeMethodInfoPtr_OnDelayedCallManagerCleared_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100666206);
		NativeMethodInfoPtr_OnUpdate_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100666207);
		NativeMethodInfoPtr_OnEndOfFrame_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100666208);
		NativeMethodInfoPtr_SetSynchronizationContext_Internal_Static_Void_UnitySynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100666209);
		FromAsyncOperationInternalDelegateField = IL2CPP.ResolveICall<FromAsyncOperationInternalDelegate>("UnityEngine.Awaitable::FromAsyncOperationInternal");
		AttachManagedGCHandleToNativeAwaitableDelegateField = IL2CPP.ResolveICall<AttachManagedGCHandleToNativeAwaitableDelegate>("UnityEngine.Awaitable::AttachManagedGCHandleToNativeAwaitable");
		CancelNativeAwaitableDelegateField = IL2CPP.ResolveICall<CancelNativeAwaitableDelegate>("UnityEngine.Awaitable::CancelNativeAwaitable");
		NextFrameInternalDelegateField = IL2CPP.ResolveICall<NextFrameInternalDelegate>("UnityEngine.Awaitable::NextFrameInternal");
		WaitForScondsInternalDelegateField = IL2CPP.ResolveICall<WaitForScondsInternalDelegate>("UnityEngine.Awaitable::WaitForScondsInternal");
		FixedUpdateInternalDelegateField = IL2CPP.ResolveICall<FixedUpdateInternalDelegate>("UnityEngine.Awaitable::FixedUpdateInternal");
		EndOfFrameInternalDelegateField = IL2CPP.ResolveICall<EndOfFrameInternalDelegate>("UnityEngine.Awaitable::EndOfFrameInternal");
		WireupNextFrameAndEndOfFrameCallbacksDelegateField = IL2CPP.ResolveICall<WireupNextFrameAndEndOfFrameCallbacksDelegate>("UnityEngine.Awaitable::WireupNextFrameAndEndOfFrameCallbacks");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186109, XrefRangeEnd = 1186118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetExceptionFromNative(Il2CppSystem.Exception ex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetExceptionFromNative_Private_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186118, XrefRangeEnd = 1186126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RunContinuation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RunContinuation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186126, XrefRangeEnd = 1186128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReleaseNativeAwaitable(System.IntPtr nativeAwaitable)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&nativeAwaitable);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReleaseNativeAwaitable_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186128, XrefRangeEnd = 1186130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int IsNativeAwaitableCompleted(System.IntPtr nativeAwaitable)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&nativeAwaitable);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsNativeAwaitableCompleted_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186130, XrefRangeEnd = 1186131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Awaitable()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Awaitable>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186131, XrefRangeEnd = 1186137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool MatchCompletionThreadAffinity(AwaiterCompletionThreadAffinity awaiterCompletionThreadAffinity)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&awaiterCompletionThreadAffinity);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MatchCompletionThreadAffinity_Private_Static_Boolean_AwaiterCompletionThreadAffinity_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1186147, RefRangeEnd = 1186148, XrefRangeStart = 1186137, XrefRangeEnd = 1186147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RunOrScheduleContinuation(AwaiterCompletionThreadAffinity awaiterCompletionThreadAffinity, Il2CppSystem.Action continuation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&awaiterCompletionThreadAffinity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)continuation);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RunOrScheduleContinuation_Private_Void_AwaiterCompletionThreadAffinity_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186148, XrefRangeEnd = 1186150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DoRunContinuationOnSynchonizationContext(Il2CppSystem.Object continuation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)continuation);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoRunContinuationOnSynchonizationContext_Private_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186150, XrefRangeEnd = 1186160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RaiseManagedCompletion()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RaiseManagedCompletion_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186160, XrefRangeEnd = 1186208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PropagateExceptionAndRelease()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PropagateExceptionAndRelease_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186280, XrefRangeEnd = 1186283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AwaitableHandle CheckPointerValidity()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckPointerValidity_Private_AwaitableHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AwaitableHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186283, XrefRangeEnd = 1186284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool System_Collections_IEnumerator_MoveNext()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void System_Collections_IEnumerator_Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186284, XrefRangeEnd = 1186294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnDelayedCallManagerCleared()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDelayedCallManagerCleared_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186294, XrefRangeEnd = 1186300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnUpdate()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUpdate_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186300, XrefRangeEnd = 1186306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnEndOfFrame()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEndOfFrame_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1186313, RefRangeEnd = 1186314, XrefRangeStart = 1186306, XrefRangeEnd = 1186313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetSynchronizationContext(UnitySynchronizationContext synchronizationContext)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)synchronizationContext);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSynchronizationContext_Internal_Static_Void_UnitySynchronizationContext_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Awaitable(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public unsafe static Awaitable FromAsyncOperation(AsyncOperation op, [System.Runtime.InteropServices.Optional] CancellationToken cancellationToken)
	{
		//IL_0008: Expected O, but got Ref
		((CancellationToken)(&cancellationToken)).ThrowIfCancellationRequested();
		System.IntPtr nativeHandle = FromAsyncOperationInternal(op.m_Ptr);
		return FromNativeAwaitableHandle(nativeHandle, cancellationToken);
	}

	public static System.IntPtr FromAsyncOperationInternal(System.IntPtr asyncOperation)
	{
		return FromAsyncOperationInternalDelegateField(asyncOperation);
	}

	public static void AttachManagedGCHandleToNativeAwaitable(System.IntPtr nativeAwaitable, System.UIntPtr gcHandle)
	{
		AttachManagedGCHandleToNativeAwaitableDelegateField(nativeAwaitable, gcHandle);
	}

	public static void CancelNativeAwaitable(System.IntPtr nativeAwaitable)
	{
		CancelNativeAwaitableDelegateField(nativeAwaitable);
	}

	public static void ThrowIfNotMainThread()
	{
		if (Thread.CurrentThread.ManagedThreadId != _mainThreadId)
		{
			throw new Il2CppSystem.InvalidOperationException("This operation can only be performed on the main thread.");
		}
	}

	public unsafe static Awaitable NextFrameAsync([System.Runtime.InteropServices.Optional] CancellationToken cancellationToken)
	{
		//IL_000e: Expected O, but got Ref
		//IL_0040: Expected O, but got Ref
		ThrowIfNotMainThread();
		((CancellationToken)(&cancellationToken)).ThrowIfCancellationRequested();
		EnsureDelayedCallWiredUp();
		Awaitable awaitable = NewManagedAwaitable();
		_nextFrameAwaitables.Add(awaitable, Time.frameCount + 1);
		awaitable._managedCompletionQueue = _nextFrameAwaitables;
		if (((CancellationToken)(&cancellationToken)).CanBeCanceled)
		{
			WireupCancellation(awaitable, cancellationToken);
		}
		return awaitable;
	}

	public unsafe static Awaitable WaitForSecondsAsync(float seconds, [System.Runtime.InteropServices.Optional] CancellationToken cancellationToken)
	{
		//IL_000e: Expected O, but got Ref
		ThrowIfNotMainThread();
		((CancellationToken)(&cancellationToken)).ThrowIfCancellationRequested();
		System.IntPtr nativeHandle = WaitForScondsInternal(seconds);
		return FromNativeAwaitableHandle(nativeHandle, cancellationToken);
	}

	public unsafe static Awaitable FixedUpdateAsync([System.Runtime.InteropServices.Optional] CancellationToken cancellationToken)
	{
		//IL_000e: Expected O, but got Ref
		ThrowIfNotMainThread();
		((CancellationToken)(&cancellationToken)).ThrowIfCancellationRequested();
		System.IntPtr nativeHandle = FixedUpdateInternal();
		return FromNativeAwaitableHandle(nativeHandle, cancellationToken);
	}

	public unsafe static Awaitable EndOfFrameAsync([System.Runtime.InteropServices.Optional] CancellationToken cancellationToken)
	{
		//IL_000e: Expected O, but got Ref
		//IL_003a: Expected O, but got Ref
		ThrowIfNotMainThread();
		((CancellationToken)(&cancellationToken)).ThrowIfCancellationRequested();
		EnsureDelayedCallWiredUp();
		Awaitable awaitable = NewManagedAwaitable();
		_endOfFrameAwaitables.Add(awaitable, -1);
		awaitable._managedCompletionQueue = _endOfFrameAwaitables;
		if (((CancellationToken)(&cancellationToken)).CanBeCanceled)
		{
			WireupCancellation(awaitable, cancellationToken);
		}
		return awaitable;
	}

	public unsafe static void EnsureDelayedCallWiredUp()
	{
		//IL_0032: Expected O, but got Ref
		if (!_nextFrameAndEndOfFrameWiredUp)
		{
			_nextFrameAndEndOfFrameWiredUp = true;
			WireupNextFrameAndEndOfFrameCallbacks();
			CancellationToken exitCancellationToken = Application.exitCancellationToken;
			_nextFrameAndEndOfFrameWiredUpCTRegistration = ((CancellationToken)(&exitCancellationToken)).Register(new Il2CppSystem.Action(null, (nint)(delegate*<void>)(&OnDelayedCallManagerCleared)));
		}
	}

	public static System.IntPtr NextFrameInternal()
	{
		return NextFrameInternalDelegateField();
	}

	public static System.IntPtr WaitForScondsInternal(float seconds)
	{
		return WaitForScondsInternalDelegateField(seconds);
	}

	public static System.IntPtr FixedUpdateInternal()
	{
		return FixedUpdateInternalDelegateField();
	}

	public static System.IntPtr EndOfFrameInternal()
	{
		return EndOfFrameInternalDelegateField();
	}

	public static void WireupNextFrameAndEndOfFrameCallbacks()
	{
		WireupNextFrameAndEndOfFrameCallbacksDelegateField();
	}

	public static Awaitable NewManagedAwaitable()
	{
		Awaitable awaitable = _pool.Value.Get();
		awaitable._handle = AwaitableHandle.ManagedHandle;
		return awaitable;
	}

	public unsafe static Awaitable FromNativeAwaitableHandle(System.IntPtr nativeHandle, CancellationToken cancellationToken)
	{
		//IL_0042: Expected O, but got Ref
		Awaitable awaitable = _pool.Value.Get();
		awaitable._handle = AwaitableHandle.op_Implicit(nativeHandle);
		AttachManagedGCHandleToNativeAwaitable(nativeHandle, (System.UIntPtr)(void*)Il2CppSystem.Runtime.InteropServices.GCHandle.ToIntPtr(Il2CppSystem.Runtime.InteropServices.GCHandle.Alloc(awaitable)));
		if (((CancellationToken)(&cancellationToken)).CanBeCanceled)
		{
			WireupCancellation(awaitable, cancellationToken);
		}
		return awaitable;
	}

	public static void WireupCancellation(Awaitable awaitable, CancellationToken cancellationToken)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void RaiseManagedCompletion(Il2CppSystem.Exception exception)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void Cancel()
	{
		AwaitableHandle awaitableHandle = CheckPointerValidity();
		if (awaitableHandle.IsManaged)
		{
			_managedCompletionQueue?.Remove(this);
			RaiseManagedCompletion(new Il2CppSystem.OperationCanceledException());
		}
		else
		{
			CancelNativeAwaitable(awaitableHandle);
		}
	}

	public void SetContinuation(Il2CppSystem.Action continuation)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}
}
