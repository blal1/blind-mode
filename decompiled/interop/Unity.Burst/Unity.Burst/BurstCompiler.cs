using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Burst;

public static class BurstCompiler : Il2CppSystem.Object
{
	public static class BurstCompilerHelper : Il2CppSystem.Object
	{
		public sealed class IsBurstEnabledDelegate : Il2CppSystem.MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_0;

			static IsBurstEnabledDelegate()
			{
				Il2CppClassPointerStore<IsBurstEnabledDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstCompilerHelper>.NativeClassPtr, "IsBurstEnabledDelegate");
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsBurstEnabledDelegate>.NativeClassPtr, 100663316);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsBurstEnabledDelegate>.NativeClassPtr, 100663317);
			}

			[CallerCount(236)]
			[CachedScanResults(RefRangeStart = 958584, RefRangeEnd = 958820, XrefRangeStart = 958581, XrefRangeEnd = 958584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IsBurstEnabledDelegate(Il2CppSystem.Object @object, System.IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IsBurstEnabledDelegate>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual bool Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			public IsBurstEnabledDelegate(System.IntPtr pointer)
				: base(pointer)
			{
			}

			public static implicit operator IsBurstEnabledDelegate(System.Func<bool> P_0)
			{
				return DelegateSupport.ConvertDelegate<IsBurstEnabledDelegate>((System.Delegate)P_0);
			}

			public static IsBurstEnabledDelegate operator +(IsBurstEnabledDelegate P_0, IsBurstEnabledDelegate P_1)
			{
				return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<IsBurstEnabledDelegate>();
			}

			public static IsBurstEnabledDelegate operator -(IsBurstEnabledDelegate P_0, IsBurstEnabledDelegate P_1)
			{
				object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
				if (obj != null)
				{
					obj = ((Il2CppObjectBase)obj).Cast<IsBurstEnabledDelegate>();
				}
				return (IsBurstEnabledDelegate)obj;
			}
		}

		[ObfuscatedName("Unity.Burst.BurstCompiler+BurstCompilerHelper+IsBurstEnabled_00000145$PostfixBurstDelegate")]
		public sealed class MulticastDelegateNInternalSealedBoUnique : Il2CppSystem.MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_0;

			static MulticastDelegateNInternalSealedBoUnique()
			{
				Il2CppClassPointerStore<MulticastDelegateNInternalSealedBoUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstCompilerHelper>.NativeClassPtr, "IsBurstEnabled_00000145$PostfixBurstDelegate");
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegateNInternalSealedBoUnique>.NativeClassPtr, 100663318);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegateNInternalSealedBoUnique>.NativeClassPtr, 100663319);
			}

			[CallerCount(236)]
			[CachedScanResults(RefRangeStart = 958584, RefRangeEnd = 958820, XrefRangeStart = 958584, XrefRangeEnd = 958820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MulticastDelegateNInternalSealedBoUnique(Il2CppSystem.Object A_1, System.IntPtr A_2)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MulticastDelegateNInternalSealedBoUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)A_1);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &A_2;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual bool Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			public MulticastDelegateNInternalSealedBoUnique(System.IntPtr pointer)
				: base(pointer)
			{
			}

			public static implicit operator MulticastDelegateNInternalSealedBoUnique(System.Func<bool> P_0)
			{
				return DelegateSupport.ConvertDelegate<MulticastDelegateNInternalSealedBoUnique>((System.Delegate)P_0);
			}

			public static MulticastDelegateNInternalSealedBoUnique operator +(MulticastDelegateNInternalSealedBoUnique P_0, MulticastDelegateNInternalSealedBoUnique P_1)
			{
				return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<MulticastDelegateNInternalSealedBoUnique>();
			}

			public static MulticastDelegateNInternalSealedBoUnique operator -(MulticastDelegateNInternalSealedBoUnique P_0, MulticastDelegateNInternalSealedBoUnique P_1)
			{
				object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
				if (obj != null)
				{
					obj = ((Il2CppObjectBase)obj).Cast<MulticastDelegateNInternalSealedBoUnique>();
				}
				return (MulticastDelegateNInternalSealedBoUnique)obj;
			}
		}

		[ObfuscatedName("Unity.Burst.BurstCompiler+BurstCompilerHelper+IsBurstEnabled_00000145$BurstDirectCall")]
		public static class ObjectNInternalAbstractSealedInPoUnique : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;

			private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Boolean_0;

			public unsafe static System.IntPtr Pointer
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr result);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Pointer, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Pointer, (void*)(&value));
				}
			}

			static ObjectNInternalAbstractSealedInPoUnique()
			{
				Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstCompilerHelper>.NativeClassPtr, "IsBurstEnabled_00000145$BurstDirectCall");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoUnique>.NativeClassPtr);
				NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoUnique>.NativeClassPtr, "Pointer");
				NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoUnique>.NativeClassPtr, 100663320);
				NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoUnique>.NativeClassPtr, 100663321);
				NativeMethodInfoPtr_Invoke_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoUnique>.NativeClassPtr, 100663322);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958820, XrefRangeEnd = 958839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void GetFunctionPointerDiscard(ref System.IntPtr A_0)
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)Unsafe.AsPointer(ref A_0);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958839, XrefRangeEnd = 958858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static System.IntPtr GetFunctionPointer()
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 958894, RefRangeEnd = 958895, XrefRangeStart = 958858, XrefRangeEnd = 958894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool Invoke()
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			public ObjectNInternalAbstractSealedInPoUnique(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_IsBurstEnabledImpl;

		private static readonly System.IntPtr NativeFieldInfoPtr_IsBurstGenerated;

		private static readonly System.IntPtr NativeMethodInfoPtr_IsBurstEnabled_Private_Static_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_DiscardedMethod_Private_Static_Void_byref_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_IsCompiledByBurst_Private_Static_Boolean_Delegate_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_PDM_0;

		public unsafe static IsBurstEnabledDelegate IsBurstEnabledImpl
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsBurstEnabledImpl, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IsBurstEnabledDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsBurstEnabledImpl, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static bool IsBurstGenerated
		{
			get
			{
				Unsafe.SkipInit(out bool result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsBurstGenerated, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsBurstGenerated, (void*)(&value));
			}
		}

		static BurstCompilerHelper()
		{
			Il2CppClassPointerStore<BurstCompilerHelper>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, "BurstCompilerHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstCompilerHelper>.NativeClassPtr);
			NativeFieldInfoPtr_IsBurstEnabledImpl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerHelper>.NativeClassPtr, "IsBurstEnabledImpl");
			NativeFieldInfoPtr_IsBurstGenerated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompilerHelper>.NativeClassPtr, "IsBurstGenerated");
			NativeMethodInfoPtr_IsBurstEnabled_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerHelper>.NativeClassPtr, 100663311);
			NativeMethodInfoPtr_DiscardedMethod_Private_Static_Void_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerHelper>.NativeClassPtr, 100663312);
			NativeMethodInfoPtr_IsCompiledByBurst_Private_Static_Boolean_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerHelper>.NativeClassPtr, 100663313);
			NativeMethodInfoPtr_Method_Internal_Static_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerHelper>.NativeClassPtr, 100663315);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958895, XrefRangeEnd = 958896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsBurstEnabled()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsBurstEnabled_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe static void DiscardedMethod(ref bool value)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)Unsafe.AsPointer(ref value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DiscardedMethod_Private_Static_Void_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958896, XrefRangeEnd = 958899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsCompiledByBurst(Il2CppSystem.Delegate del)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)del);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsCompiledByBurst_Private_Static_Boolean_Delegate_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958899, XrefRangeEnd = 958902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Method_Internal_Static_Boolean_PDM_0()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_Boolean_PDM_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public BurstCompilerHelper(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class FakeDelegate : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__Method_k__BackingField;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Method_Public_get_MethodInfo_0;

		public unsafe MethodInfo _Method_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Method_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Method_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe MethodInfo Method
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Method_Public_get_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
		}

		static FakeDelegate()
		{
			Il2CppClassPointerStore<FakeDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, "FakeDelegate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FakeDelegate>.NativeClassPtr);
			NativeFieldInfoPtr__Method_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeDelegate>.NativeClassPtr, "<Method>k__BackingField");
			NativeMethodInfoPtr_get_Method_Public_get_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeDelegate>.NativeClassPtr, 100663323);
		}

		public FakeDelegate(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("Unity.Burst.BurstCompiler+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__22_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Compile_b__22_0_Internal_Boolean_Attribute_0;

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

		public unsafe static Il2CppSystem.Func<Il2CppSystem.Attribute, bool> __9__22_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__22_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Il2CppSystem.Attribute, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__22_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__22_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__22_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100663325);
			NativeMethodInfoPtr__Compile_b__22_0_Internal_Boolean_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100663326);
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958902, XrefRangeEnd = 958914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Compile_b__22_0(Il2CppSystem.Attribute s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Compile_b__22_0_Internal_Boolean_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_CompileFunctionPointer_Public_Static_FunctionPointer_1_T_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_CompileFunctionPointer_Public_Static_FunctionPointer_1_T_T_0, Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__IsEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_Options;

	private static readonly System.IntPtr NativeFieldInfoPtr_DummyMethodInfo;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsEnabled_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompileFunctionPointer_Public_Static_FunctionPointer_1_T_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Compile_Private_Static_ptr_Void_Object_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Compile_Private_Static_ptr_Void_Object_MethodInfo_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DummyMethod_Private_Static_Void_0;

	public unsafe static bool _IsEnabled
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__IsEnabled, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__IsEnabled, (void*)(&value));
		}
	}

	public unsafe static BurstCompilerOptions Options
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Options, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BurstCompilerOptions>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Options, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static MethodInfo DummyMethodInfo
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DummyMethodInfo, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DummyMethodInfo, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static bool IsEnabled
	{
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 958919, RefRangeEnd = 958935, XrefRangeStart = 958914, XrefRangeEnd = 958919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsEnabled_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static BurstCompiler()
	{
		Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst", "BurstCompiler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr);
		NativeFieldInfoPtr__IsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, "_IsEnabled");
		NativeFieldInfoPtr_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, "Options");
		NativeFieldInfoPtr_DummyMethodInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, "DummyMethodInfo");
		NativeMethodInfoPtr_get_IsEnabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663305);
		NativeMethodInfoPtr_CompileFunctionPointer_Public_Static_FunctionPointer_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663306);
		NativeMethodInfoPtr_Compile_Private_Static_ptr_Void_Object_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663307);
		NativeMethodInfoPtr_Compile_Private_Static_ptr_Void_Object_MethodInfo_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663308);
		NativeMethodInfoPtr_DummyMethod_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663309);
	}

	[CallerCount(49)]
	[CachedScanResults(RefRangeStart = 958940, RefRangeEnd = 958989, XrefRangeStart = 958935, XrefRangeEnd = 958940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FunctionPointer<T> CompileFunctionPointer<T>(T delegateMethod) where T : class
	{
		//IL_0045->IL0048: Incompatible stack types: I vs Ref
		//IL_0038->IL0048: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			T val = delegateMethod;
			reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
		}
		else
		{
			reference = ref delegateMethod;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_CompileFunctionPointer_Public_Static_FunctionPointer_1_T_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new FunctionPointer<T>(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 958996, RefRangeEnd = 958997, XrefRangeStart = 958989, XrefRangeEnd = 958996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void* Compile(Il2CppSystem.Object delegateObj, bool isFunctionPointer, bool deterministicCompilation = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)delegateObj);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isFunctionPointer;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &deterministicCompilation;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compile_Private_Static_ptr_Void_Object_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (void*)result;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 959072, RefRangeEnd = 959073, XrefRangeStart = 958997, XrefRangeEnd = 959072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void* Compile(Il2CppSystem.Object delegateObj, MethodInfo methodInfo, bool isFunctionPointer, bool isILPostProcessing, bool deterministicCompilation = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)delegateObj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)methodInfo);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isFunctionPointer;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isILPostProcessing;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &deterministicCompilation;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compile_Private_Static_ptr_Void_Object_MethodInfo_Boolean_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (void*)result;
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DummyMethod()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DummyMethod_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public BurstCompiler(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
