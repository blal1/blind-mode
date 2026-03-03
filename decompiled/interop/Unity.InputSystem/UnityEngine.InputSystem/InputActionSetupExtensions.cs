using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.InputSystem;

public static class InputActionSetupExtensions : Il2CppSystem.Object
{
	public sealed class BindingSyntax : Il2CppSystem.ValueType
	{
		private sealed class MethodInfoStoreGeneric_WithInteraction_Public_BindingSyntax_0<TInteraction>
		{
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_WithInteraction_Public_BindingSyntax_0, Il2CppClassPointerStore<BindingSyntax>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TInteraction>.NativeClassPtr)) }))));
		}

		private sealed class MethodInfoStoreGeneric_WithProcessor_Public_BindingSyntax_0<TProcessor>
		{
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_WithProcessor_Public_BindingSyntax_0, Il2CppClassPointerStore<BindingSyntax>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TProcessor>.NativeClassPtr)) }))));
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_m_ActionMap;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Action;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_BindingIndexInMap;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_valid_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_bindingIndex_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_binding_Public_get_InputBinding_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_InputActionMap_Int32_InputAction_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithName_Public_BindingSyntax_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithPath_Public_BindingSyntax_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithGroup_Public_BindingSyntax_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithGroups_Public_BindingSyntax_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithInteraction_Public_BindingSyntax_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithInteractions_Public_BindingSyntax_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithInteraction_Public_BindingSyntax_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithProcessor_Public_BindingSyntax_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithProcessors_Public_BindingSyntax_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithProcessor_Public_BindingSyntax_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Triggering_Public_BindingSyntax_InputAction_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_To_Public_BindingSyntax_InputBinding_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_NextBinding_Public_BindingSyntax_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_PreviousBinding_Public_BindingSyntax_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_NextPartBinding_Public_BindingSyntax_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_PreviousPartBinding_Public_BindingSyntax_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_NextCompositeBinding_Public_BindingSyntax_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_PreviousCompositeBinding_Public_BindingSyntax_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Iterate_Private_BindingSyntax_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_IterateCompositeBinding_Private_BindingSyntax_Boolean_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_IteratePartBinding_Private_BindingSyntax_Boolean_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Erase_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_InsertPartBinding_Public_BindingSyntax_String_String_0;

		public unsafe InputActionMap m_ActionMap
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActionMap);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputActionMap>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActionMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe InputAction m_Action
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Action);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputAction>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Action)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int m_BindingIndexInMap
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BindingIndexInMap);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BindingIndexInMap)) = value;
			}
		}

		public unsafe bool valid
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 967714, RefRangeEnd = 967716, XrefRangeStart = 967711, XrefRangeEnd = 967714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_valid_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe int bindingIndex
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967716, XrefRangeEnd = 967719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bindingIndex_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe InputBinding binding
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 967722, RefRangeEnd = 967731, XrefRangeStart = 967719, XrefRangeEnd = 967722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_binding_Public_get_InputBinding_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new InputBinding(pointer);
			}
		}

		static BindingSyntax()
		{
			Il2CppClassPointerStore<BindingSyntax>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, "BindingSyntax");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingSyntax>.NativeClassPtr);
			NativeFieldInfoPtr_m_ActionMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingSyntax>.NativeClassPtr, "m_ActionMap");
			NativeFieldInfoPtr_m_Action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingSyntax>.NativeClassPtr, "m_Action");
			NativeFieldInfoPtr_m_BindingIndexInMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingSyntax>.NativeClassPtr, "m_BindingIndexInMap");
			NativeMethodInfoPtr_get_valid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingSyntax>.NativeClassPtr, 100664008);
			NativeMethodInfoPtr_get_bindingIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingSyntax>.NativeClassPtr, 100664009);
			NativeMethodInfoPtr_get_binding_Public_get_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingSyntax>.NativeClassPtr, 100664010);
			NativeMethodInfoPtr__ctor_Internal_Void_InputActionMap_Int32_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingSyntax>.NativeClassPtr, 100664011);
			NativeMethodInfoPtr_WithName_Public_BindingSyntax_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingSyntax>.NativeClassPtr, 100664012);
			NativeMethodInfoPtr_WithPath_Public_BindingSyntax_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingSyntax>.NativeClassPtr, 100664013);
			NativeMethodInfoPtr_WithGroup_Public_BindingSyntax_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingSyntax>.NativeClassPtr, 100664014);
			NativeMethodInfoPtr_WithGroups_Public_BindingSyntax_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingSyntax>.NativeClassPtr, 100664015);
			NativeMethodInfoPtr_WithInteraction_Public_BindingSyntax_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingSyntax>.NativeClassPtr, 100664016);
			NativeMethodInfoPtr_WithInteractions_Public_BindingSyntax_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingSyntax>.NativeClassPtr, 100664017);
			NativeMethodInfoPtr_WithInteraction_Public_BindingSyntax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingSyntax>.NativeClassPtr, 100664018);
			NativeMethodInfoPtr_WithProcessor_Public_BindingSyntax_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingSyntax>.NativeClassPtr, 100664019);
			NativeMethodInfoPtr_WithProcessors_Public_BindingSyntax_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingSyntax>.NativeClassPtr, 100664020);
			NativeMethodInfoPtr_WithProcessor_Public_BindingSyntax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingSyntax>.NativeClassPtr, 100664021);
			NativeMethodInfoPtr_Triggering_Public_BindingSyntax_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingSyntax>.NativeClassPtr, 100664022);
			NativeMethodInfoPtr_To_Public_BindingSyntax_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingSyntax>.NativeClassPtr, 100664023);
			NativeMethodInfoPtr_NextBinding_Public_BindingSyntax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingSyntax>.NativeClassPtr, 100664024);
			NativeMethodInfoPtr_PreviousBinding_Public_BindingSyntax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingSyntax>.NativeClassPtr, 100664025);
			NativeMethodInfoPtr_NextPartBinding_Public_BindingSyntax_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingSyntax>.NativeClassPtr, 100664026);
			NativeMethodInfoPtr_PreviousPartBinding_Public_BindingSyntax_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingSyntax>.NativeClassPtr, 100664027);
			NativeMethodInfoPtr_NextCompositeBinding_Public_BindingSyntax_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingSyntax>.NativeClassPtr, 100664028);
			NativeMethodInfoPtr_PreviousCompositeBinding_Public_BindingSyntax_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingSyntax>.NativeClassPtr, 100664029);
			NativeMethodInfoPtr_Iterate_Private_BindingSyntax_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingSyntax>.NativeClassPtr, 100664030);
			NativeMethodInfoPtr_IterateCompositeBinding_Private_BindingSyntax_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingSyntax>.NativeClassPtr, 100664031);
			NativeMethodInfoPtr_IteratePartBinding_Private_BindingSyntax_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingSyntax>.NativeClassPtr, 100664032);
			NativeMethodInfoPtr_Erase_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingSyntax>.NativeClassPtr, 100664033);
			NativeMethodInfoPtr_InsertPartBinding_Public_BindingSyntax_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingSyntax>.NativeClassPtr, 100664034);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967731, XrefRangeEnd = 967733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BindingSyntax(InputActionMap map, int bindingIndexInMap, InputAction action = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BindingSyntax>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)map);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bindingIndexInMap;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_InputActionMap_Int32_InputAction_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967733, XrefRangeEnd = 967738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BindingSyntax WithName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithName_Public_BindingSyntax_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new BindingSyntax(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967738, XrefRangeEnd = 967743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BindingSyntax WithPath(string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithPath_Public_BindingSyntax_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new BindingSyntax(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967743, XrefRangeEnd = 967749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BindingSyntax WithGroup(string group)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(group);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithGroup_Public_BindingSyntax_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new BindingSyntax(pointer);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 967764, RefRangeEnd = 967765, XrefRangeStart = 967749, XrefRangeEnd = 967764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BindingSyntax WithGroups(string groups)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(groups);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithGroups_Public_BindingSyntax_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new BindingSyntax(pointer);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 967771, RefRangeEnd = 967772, XrefRangeStart = 967765, XrefRangeEnd = 967771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BindingSyntax WithInteraction(string interaction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(interaction);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithInteraction_Public_BindingSyntax_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new BindingSyntax(pointer);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 967787, RefRangeEnd = 967788, XrefRangeStart = 967772, XrefRangeEnd = 967787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BindingSyntax WithInteractions(string interactions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(interactions);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithInteractions_Public_BindingSyntax_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new BindingSyntax(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967788, XrefRangeEnd = 967799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BindingSyntax WithInteraction<TInteraction>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_WithInteraction_Public_BindingSyntax_0<TInteraction>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new BindingSyntax(pointer);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 967805, RefRangeEnd = 967807, XrefRangeStart = 967799, XrefRangeEnd = 967805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BindingSyntax WithProcessor(string processor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(processor);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithProcessor_Public_BindingSyntax_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new BindingSyntax(pointer);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 967822, RefRangeEnd = 967823, XrefRangeStart = 967807, XrefRangeEnd = 967822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BindingSyntax WithProcessors(string processors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(processors);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithProcessors_Public_BindingSyntax_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new BindingSyntax(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967823, XrefRangeEnd = 967834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BindingSyntax WithProcessor<TProcessor>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_WithProcessor_Public_BindingSyntax_0<TProcessor>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new BindingSyntax(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967834, XrefRangeEnd = 967840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BindingSyntax Triggering(InputAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Triggering_Public_BindingSyntax_InputAction_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new BindingSyntax(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967840, XrefRangeEnd = 967846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BindingSyntax To(InputBinding binding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)binding));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_To_Public_BindingSyntax_InputBinding_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new BindingSyntax(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967846, XrefRangeEnd = 967847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BindingSyntax NextBinding()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NextBinding_Public_BindingSyntax_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new BindingSyntax(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967847, XrefRangeEnd = 967848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BindingSyntax PreviousBinding()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreviousBinding_Public_BindingSyntax_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new BindingSyntax(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967848, XrefRangeEnd = 967850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BindingSyntax NextPartBinding(string partName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(partName);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NextPartBinding_Public_BindingSyntax_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new BindingSyntax(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967850, XrefRangeEnd = 967852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BindingSyntax PreviousPartBinding(string partName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(partName);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreviousPartBinding_Public_BindingSyntax_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new BindingSyntax(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967852, XrefRangeEnd = 967853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BindingSyntax NextCompositeBinding(string compositeName = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(compositeName);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NextCompositeBinding_Public_BindingSyntax_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new BindingSyntax(pointer);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 967854, RefRangeEnd = 967855, XrefRangeStart = 967853, XrefRangeEnd = 967854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BindingSyntax PreviousCompositeBinding(string compositeName = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(compositeName);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreviousCompositeBinding_Public_BindingSyntax_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new BindingSyntax(pointer);
		}

		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 967860, RefRangeEnd = 967865, XrefRangeStart = 967855, XrefRangeEnd = 967860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BindingSyntax Iterate(bool next)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&next);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Iterate_Private_BindingSyntax_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new BindingSyntax(pointer);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 967878, RefRangeEnd = 967880, XrefRangeStart = 967865, XrefRangeEnd = 967878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BindingSyntax IterateCompositeBinding(bool next, string compositeName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&next);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(compositeName);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IterateCompositeBinding_Private_BindingSyntax_Boolean_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new BindingSyntax(pointer);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 967895, RefRangeEnd = 967897, XrefRangeStart = 967880, XrefRangeEnd = 967895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BindingSyntax IteratePartBinding(bool next, string partName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&next);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(partName);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IteratePartBinding_Private_BindingSyntax_Boolean_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new BindingSyntax(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967897, XrefRangeEnd = 967913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Erase()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Erase_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967913, XrefRangeEnd = 967925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BindingSyntax InsertPartBinding(string partName, string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(partName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(path);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsertPartBinding_Public_BindingSyntax_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new BindingSyntax(pointer);
		}

		public BindingSyntax(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public BindingSyntax()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BindingSyntax>.NativeClassPtr))
		{
		}
	}

	public sealed class CompositeSyntax : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_Action;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_ActionMap;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_BindingIndexInMap;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_bindingIndex_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_InputActionMap_InputAction_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_With_Public_CompositeSyntax_String_String_String_String_0;

		public unsafe InputAction m_Action
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Action);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputAction>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Action)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe InputActionMap m_ActionMap
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActionMap);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputActionMap>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActionMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int m_BindingIndexInMap
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BindingIndexInMap);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BindingIndexInMap)) = value;
			}
		}

		public unsafe int bindingIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bindingIndex_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		static CompositeSyntax()
		{
			Il2CppClassPointerStore<CompositeSyntax>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, "CompositeSyntax");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompositeSyntax>.NativeClassPtr);
			NativeFieldInfoPtr_m_Action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeSyntax>.NativeClassPtr, "m_Action");
			NativeFieldInfoPtr_m_ActionMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeSyntax>.NativeClassPtr, "m_ActionMap");
			NativeFieldInfoPtr_m_BindingIndexInMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeSyntax>.NativeClassPtr, "m_BindingIndexInMap");
			NativeMethodInfoPtr_get_bindingIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeSyntax>.NativeClassPtr, 100664035);
			NativeMethodInfoPtr__ctor_Internal_Void_InputActionMap_InputAction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeSyntax>.NativeClassPtr, 100664036);
			NativeMethodInfoPtr_With_Public_CompositeSyntax_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeSyntax>.NativeClassPtr, 100664037);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967925, XrefRangeEnd = 967927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompositeSyntax(InputActionMap map, InputAction action, int compositeIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompositeSyntax>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)map);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &compositeIndex;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_InputActionMap_InputAction_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 967938, RefRangeEnd = 967970, XrefRangeStart = 967927, XrefRangeEnd = 967938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompositeSyntax With(string name, string binding, string groups = null, string processors = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(binding);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(groups);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(processors);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_With_Public_CompositeSyntax_String_String_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new CompositeSyntax(pointer);
		}

		public CompositeSyntax(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public CompositeSyntax()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompositeSyntax>.NativeClassPtr))
		{
		}
	}

	public sealed class ControlSchemeSyntax : Il2CppSystem.ValueType
	{
		private sealed class MethodInfoStoreGeneric_WithRequiredDevice_Public_ControlSchemeSyntax_0<TDevice>
		{
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_WithRequiredDevice_Public_ControlSchemeSyntax_0, Il2CppClassPointerStore<ControlSchemeSyntax>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDevice>.NativeClassPtr)) }))));
		}

		private sealed class MethodInfoStoreGeneric_WithOptionalDevice_Public_ControlSchemeSyntax_0<TDevice>
		{
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_WithOptionalDevice_Public_ControlSchemeSyntax_0, Il2CppClassPointerStore<ControlSchemeSyntax>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDevice>.NativeClassPtr)) }))));
		}

		private sealed class MethodInfoStoreGeneric_OrWithRequiredDevice_Public_ControlSchemeSyntax_0<TDevice>
		{
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_OrWithRequiredDevice_Public_ControlSchemeSyntax_0, Il2CppClassPointerStore<ControlSchemeSyntax>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDevice>.NativeClassPtr)) }))));
		}

		private sealed class MethodInfoStoreGeneric_OrWithOptionalDevice_Public_ControlSchemeSyntax_0<TDevice>
		{
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_OrWithOptionalDevice_Public_ControlSchemeSyntax_0, Il2CppClassPointerStore<ControlSchemeSyntax>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDevice>.NativeClassPtr)) }))));
		}

		private sealed class MethodInfoStoreGeneric_DeviceTypeToControlPath_Private_String_0<TDevice>
		{
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_DeviceTypeToControlPath_Private_String_0, Il2CppClassPointerStore<ControlSchemeSyntax>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDevice>.NativeClassPtr)) }))));
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Asset;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_ControlSchemeIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_ControlScheme;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_InputActionAsset_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_InputControlScheme_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithBindingGroup_Public_ControlSchemeSyntax_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithRequiredDevice_Public_ControlSchemeSyntax_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithOptionalDevice_Public_ControlSchemeSyntax_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_OrWithRequiredDevice_Public_ControlSchemeSyntax_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_OrWithOptionalDevice_Public_ControlSchemeSyntax_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithRequiredDevice_Public_ControlSchemeSyntax_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithOptionalDevice_Public_ControlSchemeSyntax_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_OrWithRequiredDevice_Public_ControlSchemeSyntax_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_OrWithOptionalDevice_Public_ControlSchemeSyntax_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_DeviceTypeToControlPath_Private_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Done_Public_InputControlScheme_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddDeviceEntry_Private_Void_String_Flags_0;

		public unsafe InputActionAsset m_Asset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Asset);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputActionAsset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Asset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int m_ControlSchemeIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ControlSchemeIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ControlSchemeIndex)) = value;
			}
		}

		public unsafe InputControlScheme m_ControlScheme
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ControlScheme);
				return new InputControlScheme(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputControlScheme>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ControlScheme), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InputControlScheme>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static ControlSchemeSyntax()
		{
			Il2CppClassPointerStore<ControlSchemeSyntax>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, "ControlSchemeSyntax");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlSchemeSyntax>.NativeClassPtr);
			NativeFieldInfoPtr_m_Asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlSchemeSyntax>.NativeClassPtr, "m_Asset");
			NativeFieldInfoPtr_m_ControlSchemeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlSchemeSyntax>.NativeClassPtr, "m_ControlSchemeIndex");
			NativeFieldInfoPtr_m_ControlScheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlSchemeSyntax>.NativeClassPtr, "m_ControlScheme");
			NativeMethodInfoPtr__ctor_Internal_Void_InputActionAsset_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlSchemeSyntax>.NativeClassPtr, 100664038);
			NativeMethodInfoPtr__ctor_Internal_Void_InputControlScheme_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlSchemeSyntax>.NativeClassPtr, 100664039);
			NativeMethodInfoPtr_WithBindingGroup_Public_ControlSchemeSyntax_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlSchemeSyntax>.NativeClassPtr, 100664040);
			NativeMethodInfoPtr_WithRequiredDevice_Public_ControlSchemeSyntax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlSchemeSyntax>.NativeClassPtr, 100664041);
			NativeMethodInfoPtr_WithOptionalDevice_Public_ControlSchemeSyntax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlSchemeSyntax>.NativeClassPtr, 100664042);
			NativeMethodInfoPtr_OrWithRequiredDevice_Public_ControlSchemeSyntax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlSchemeSyntax>.NativeClassPtr, 100664043);
			NativeMethodInfoPtr_OrWithOptionalDevice_Public_ControlSchemeSyntax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlSchemeSyntax>.NativeClassPtr, 100664044);
			NativeMethodInfoPtr_WithRequiredDevice_Public_ControlSchemeSyntax_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlSchemeSyntax>.NativeClassPtr, 100664045);
			NativeMethodInfoPtr_WithOptionalDevice_Public_ControlSchemeSyntax_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlSchemeSyntax>.NativeClassPtr, 100664046);
			NativeMethodInfoPtr_OrWithRequiredDevice_Public_ControlSchemeSyntax_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlSchemeSyntax>.NativeClassPtr, 100664047);
			NativeMethodInfoPtr_OrWithOptionalDevice_Public_ControlSchemeSyntax_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlSchemeSyntax>.NativeClassPtr, 100664048);
			NativeMethodInfoPtr_DeviceTypeToControlPath_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlSchemeSyntax>.NativeClassPtr, 100664049);
			NativeMethodInfoPtr_Done_Public_InputControlScheme_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlSchemeSyntax>.NativeClassPtr, 100664050);
			NativeMethodInfoPtr_AddDeviceEntry_Private_Void_String_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlSchemeSyntax>.NativeClassPtr, 100664051);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967970, XrefRangeEnd = 967971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControlSchemeSyntax(InputActionAsset asset, int index)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlSchemeSyntax>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asset);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_InputActionAsset_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967971, XrefRangeEnd = 967973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControlSchemeSyntax(InputControlScheme controlScheme)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlSchemeSyntax>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)controlScheme));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_InputControlScheme_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 967980, RefRangeEnd = 967981, XrefRangeStart = 967973, XrefRangeEnd = 967980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControlSchemeSyntax WithBindingGroup(string bindingGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(bindingGroup);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithBindingGroup_Public_ControlSchemeSyntax_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ControlSchemeSyntax(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967981, XrefRangeEnd = 967984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControlSchemeSyntax WithRequiredDevice<TDevice>() where TDevice : InputDevice
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_WithRequiredDevice_Public_ControlSchemeSyntax_0<TDevice>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ControlSchemeSyntax(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967984, XrefRangeEnd = 967987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControlSchemeSyntax WithOptionalDevice<TDevice>() where TDevice : InputDevice
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_WithOptionalDevice_Public_ControlSchemeSyntax_0<TDevice>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ControlSchemeSyntax(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967987, XrefRangeEnd = 967990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControlSchemeSyntax OrWithRequiredDevice<TDevice>() where TDevice : InputDevice
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_OrWithRequiredDevice_Public_ControlSchemeSyntax_0<TDevice>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ControlSchemeSyntax(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967990, XrefRangeEnd = 967993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControlSchemeSyntax OrWithOptionalDevice<TDevice>() where TDevice : InputDevice
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_OrWithOptionalDevice_Public_ControlSchemeSyntax_0<TDevice>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ControlSchemeSyntax(pointer);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 967994, RefRangeEnd = 967995, XrefRangeStart = 967993, XrefRangeEnd = 967994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControlSchemeSyntax WithRequiredDevice(string controlPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(controlPath);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithRequiredDevice_Public_ControlSchemeSyntax_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ControlSchemeSyntax(pointer);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 967996, RefRangeEnd = 967997, XrefRangeStart = 967995, XrefRangeEnd = 967996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControlSchemeSyntax WithOptionalDevice(string controlPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(controlPath);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithOptionalDevice_Public_ControlSchemeSyntax_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ControlSchemeSyntax(pointer);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 967998, RefRangeEnd = 967999, XrefRangeStart = 967997, XrefRangeEnd = 967998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControlSchemeSyntax OrWithRequiredDevice(string controlPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(controlPath);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OrWithRequiredDevice_Public_ControlSchemeSyntax_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ControlSchemeSyntax(pointer);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 968000, RefRangeEnd = 968001, XrefRangeStart = 967999, XrefRangeEnd = 968000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControlSchemeSyntax OrWithOptionalDevice(string controlPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(controlPath);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OrWithOptionalDevice_Public_ControlSchemeSyntax_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ControlSchemeSyntax(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968001, XrefRangeEnd = 968020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string DeviceTypeToControlPath<TDevice>() where TDevice : InputDevice
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_DeviceTypeToControlPath_Private_String_0<TDevice>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968020, XrefRangeEnd = 968024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputControlScheme Done()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Done_Public_InputControlScheme_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new InputControlScheme(pointer);
		}

		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 968038, RefRangeEnd = 968048, XrefRangeStart = 968024, XrefRangeEnd = 968038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDeviceEntry(string controlPath, InputControlScheme.DeviceRequirement.Flags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(controlPath);
			*(InputControlScheme.DeviceRequirement.Flags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddDeviceEntry_Private_Void_String_Flags_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public ControlSchemeSyntax(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public ControlSchemeSyntax()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlSchemeSyntax>.NativeClassPtr))
		{
		}
	}

	[ObfuscatedName("UnityEngine.InputSystem.InputActionSetupExtensions+<>c__DisplayClass5_0")]
	public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_binding;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RemoveAction_b__0_Internal_Boolean_InputBinding_0;

		public unsafe InputBinding binding
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_binding);
				return new InputBinding(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputBinding>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_binding), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InputBinding>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static __c__DisplayClass5_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, "<>c__DisplayClass5_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr);
			NativeFieldInfoPtr_binding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr, "binding");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr, 100664052);
			NativeMethodInfoPtr__RemoveAction_b__0_Internal_Boolean_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr, 100664053);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass5_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968048, XrefRangeEnd = 968053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _RemoveAction_b__0(InputBinding b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)b));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RemoveAction_b__0_Internal_Boolean_InputBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public __c__DisplayClass5_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_AddActionMap_Public_Static_InputActionMap_InputActionAsset_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddActionMap_Public_Static_Void_InputActionAsset_InputActionMap_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveActionMap_Public_Static_Void_InputActionAsset_InputActionMap_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveActionMap_Public_Static_Void_InputActionAsset_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddAction_Public_Static_InputAction_InputActionMap_String_InputActionType_String_String_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAction_Public_Static_Void_InputAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAction_Public_Static_Void_InputActionAsset_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBinding_Public_Static_BindingSyntax_InputAction_String_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBinding_Public_Static_BindingSyntax_InputAction_InputControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBinding_Public_Static_BindingSyntax_InputAction_InputBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBinding_Public_Static_BindingSyntax_InputActionMap_String_String_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBinding_Public_Static_BindingSyntax_InputActionMap_String_InputAction_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBinding_Public_Static_BindingSyntax_InputActionMap_String_Guid_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBinding_Public_Static_BindingSyntax_InputActionMap_InputBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddCompositeBinding_Public_Static_CompositeSyntax_InputAction_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBindingInternal_Private_Static_Int32_InputActionMap_InputBinding_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeBinding_Public_Static_BindingSyntax_InputAction_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeBinding_Public_Static_BindingSyntax_InputAction_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeBinding_Public_Static_BindingSyntax_InputActionMap_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeBindingWithId_Public_Static_BindingSyntax_InputAction_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeBindingWithId_Public_Static_BindingSyntax_InputAction_Guid_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeBindingWithGroup_Public_Static_BindingSyntax_InputAction_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeBindingWithPath_Public_Static_BindingSyntax_InputAction_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeBinding_Public_Static_BindingSyntax_InputAction_InputBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeCompositeBinding_Public_Static_BindingSyntax_InputAction_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rename_Public_Static_Void_InputAction_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddControlScheme_Public_Static_Void_InputActionAsset_InputControlScheme_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddControlScheme_Public_Static_ControlSchemeSyntax_InputActionAsset_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveControlScheme_Public_Static_Void_InputActionAsset_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WithBindingGroup_Public_Static_InputControlScheme_InputControlScheme_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WithDevice_Public_Static_InputControlScheme_InputControlScheme_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WithRequiredDevice_Public_Static_InputControlScheme_InputControlScheme_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WithOptionalDevice_Public_Static_InputControlScheme_InputControlScheme_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OrWithRequiredDevice_Public_Static_InputControlScheme_InputControlScheme_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OrWithOptionalDevice_Public_Static_InputControlScheme_InputControlScheme_String_0;

	static InputActionSetupExtensions()
	{
		Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem", "InputActionSetupExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_AddActionMap_Public_Static_InputActionMap_InputActionAsset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, 100663973);
		NativeMethodInfoPtr_AddActionMap_Public_Static_Void_InputActionAsset_InputActionMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, 100663974);
		NativeMethodInfoPtr_RemoveActionMap_Public_Static_Void_InputActionAsset_InputActionMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, 100663975);
		NativeMethodInfoPtr_RemoveActionMap_Public_Static_Void_InputActionAsset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, 100663976);
		NativeMethodInfoPtr_AddAction_Public_Static_InputAction_InputActionMap_String_InputActionType_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, 100663977);
		NativeMethodInfoPtr_RemoveAction_Public_Static_Void_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, 100663978);
		NativeMethodInfoPtr_RemoveAction_Public_Static_Void_InputActionAsset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, 100663979);
		NativeMethodInfoPtr_AddBinding_Public_Static_BindingSyntax_InputAction_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, 100663980);
		NativeMethodInfoPtr_AddBinding_Public_Static_BindingSyntax_InputAction_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, 100663981);
		NativeMethodInfoPtr_AddBinding_Public_Static_BindingSyntax_InputAction_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, 100663982);
		NativeMethodInfoPtr_AddBinding_Public_Static_BindingSyntax_InputActionMap_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, 100663983);
		NativeMethodInfoPtr_AddBinding_Public_Static_BindingSyntax_InputActionMap_String_InputAction_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, 100663984);
		NativeMethodInfoPtr_AddBinding_Public_Static_BindingSyntax_InputActionMap_String_Guid_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, 100663985);
		NativeMethodInfoPtr_AddBinding_Public_Static_BindingSyntax_InputActionMap_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, 100663986);
		NativeMethodInfoPtr_AddCompositeBinding_Public_Static_CompositeSyntax_InputAction_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, 100663987);
		NativeMethodInfoPtr_AddBindingInternal_Private_Static_Int32_InputActionMap_InputBinding_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, 100663988);
		NativeMethodInfoPtr_ChangeBinding_Public_Static_BindingSyntax_InputAction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, 100663989);
		NativeMethodInfoPtr_ChangeBinding_Public_Static_BindingSyntax_InputAction_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, 100663990);
		NativeMethodInfoPtr_ChangeBinding_Public_Static_BindingSyntax_InputActionMap_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, 100663991);
		NativeMethodInfoPtr_ChangeBindingWithId_Public_Static_BindingSyntax_InputAction_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, 100663992);
		NativeMethodInfoPtr_ChangeBindingWithId_Public_Static_BindingSyntax_InputAction_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, 100663993);
		NativeMethodInfoPtr_ChangeBindingWithGroup_Public_Static_BindingSyntax_InputAction_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, 100663994);
		NativeMethodInfoPtr_ChangeBindingWithPath_Public_Static_BindingSyntax_InputAction_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, 100663995);
		NativeMethodInfoPtr_ChangeBinding_Public_Static_BindingSyntax_InputAction_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, 100663996);
		NativeMethodInfoPtr_ChangeCompositeBinding_Public_Static_BindingSyntax_InputAction_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, 100663997);
		NativeMethodInfoPtr_Rename_Public_Static_Void_InputAction_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, 100663998);
		NativeMethodInfoPtr_AddControlScheme_Public_Static_Void_InputActionAsset_InputControlScheme_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, 100663999);
		NativeMethodInfoPtr_AddControlScheme_Public_Static_ControlSchemeSyntax_InputActionAsset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, 100664000);
		NativeMethodInfoPtr_RemoveControlScheme_Public_Static_Void_InputActionAsset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, 100664001);
		NativeMethodInfoPtr_WithBindingGroup_Public_Static_InputControlScheme_InputControlScheme_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, 100664002);
		NativeMethodInfoPtr_WithDevice_Public_Static_InputControlScheme_InputControlScheme_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, 100664003);
		NativeMethodInfoPtr_WithRequiredDevice_Public_Static_InputControlScheme_InputControlScheme_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, 100664004);
		NativeMethodInfoPtr_WithOptionalDevice_Public_Static_InputControlScheme_InputControlScheme_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, 100664005);
		NativeMethodInfoPtr_OrWithRequiredDevice_Public_Static_InputControlScheme_InputControlScheme_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, 100664006);
		NativeMethodInfoPtr_OrWithOptionalDevice_Public_Static_InputControlScheme_InputControlScheme_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetupExtensions>.NativeClassPtr, 100664007);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968053, XrefRangeEnd = 968065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InputActionMap AddActionMap(this InputActionAsset asset, string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddActionMap_Public_Static_InputActionMap_InputActionAsset_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputActionMap>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 968119, RefRangeEnd = 968120, XrefRangeStart = 968065, XrefRangeEnd = 968119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddActionMap(this InputActionAsset asset, InputActionMap map)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)map);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddActionMap_Public_Static_Void_InputActionAsset_InputActionMap_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968120, XrefRangeEnd = 968134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveActionMap(this InputActionAsset asset, InputActionMap map)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)map);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveActionMap_Public_Static_Void_InputActionAsset_InputActionMap_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968134, XrefRangeEnd = 968153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveActionMap(this InputActionAsset asset, string nameOrId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(nameOrId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveActionMap_Public_Static_Void_InputActionAsset_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 968173, RefRangeEnd = 968190, XrefRangeStart = 968153, XrefRangeEnd = 968173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InputAction AddAction(this InputActionMap map, string name, InputActionType type = InputActionType.Value, string binding = null, string interactions = null, string processors = null, string groups = null, string expectedControlLayout = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)map);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(InputActionType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(binding);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(interactions);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(processors);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(groups);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(expectedControlLayout);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddAction_Public_Static_InputAction_InputActionMap_String_InputActionType_String_String_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputAction>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 968226, RefRangeEnd = 968227, XrefRangeStart = 968190, XrefRangeEnd = 968226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveAction(this InputAction action)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveAction_Public_Static_Void_InputAction_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968227, XrefRangeEnd = 968233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveAction(this InputActionAsset asset, string nameOrId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(nameOrId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveAction_Public_Static_Void_InputActionAsset_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(23)]
	[CachedScanResults(RefRangeStart = 968242, RefRangeEnd = 968265, XrefRangeStart = 968233, XrefRangeEnd = 968242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BindingSyntax AddBinding(this InputAction action, string path, string interactions = null, string processors = null, string groups = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(path);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(interactions);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(processors);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(groups);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddBinding_Public_Static_BindingSyntax_InputAction_String_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BindingSyntax(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968265, XrefRangeEnd = 968267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BindingSyntax AddBinding(this InputAction action, InputControl control)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddBinding_Public_Static_BindingSyntax_InputAction_InputControl_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BindingSyntax(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968267, XrefRangeEnd = 968272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BindingSyntax AddBinding(this InputAction action, InputBinding binding = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)binding));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddBinding_Public_Static_BindingSyntax_InputAction_InputBinding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BindingSyntax(pointer);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 968280, RefRangeEnd = 968283, XrefRangeStart = 968272, XrefRangeEnd = 968280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BindingSyntax AddBinding(this InputActionMap actionMap, string path, string interactions = null, string groups = null, string action = null, string processors = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionMap);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(path);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(interactions);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(groups);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(processors);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddBinding_Public_Static_BindingSyntax_InputActionMap_String_String_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BindingSyntax(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968283, XrefRangeEnd = 968292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BindingSyntax AddBinding(this InputActionMap actionMap, string path, InputAction action, string interactions = null, string groups = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionMap);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(path);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(interactions);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(groups);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddBinding_Public_Static_BindingSyntax_InputActionMap_String_InputAction_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BindingSyntax(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968292, XrefRangeEnd = 968298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BindingSyntax AddBinding(this InputActionMap actionMap, string path, Il2CppSystem.Guid action, string interactions = null, string groups = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionMap);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(path);
		*(Il2CppSystem.Guid**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &action;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(interactions);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(groups);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddBinding_Public_Static_BindingSyntax_InputActionMap_String_Guid_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BindingSyntax(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968298, XrefRangeEnd = 968301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BindingSyntax AddBinding(this InputActionMap actionMap, InputBinding binding)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionMap);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)binding));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddBinding_Public_Static_BindingSyntax_InputActionMap_InputBinding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BindingSyntax(pointer);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 968312, RefRangeEnd = 968319, XrefRangeStart = 968301, XrefRangeEnd = 968312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CompositeSyntax AddCompositeBinding(this InputAction action, string composite, string interactions = null, string processors = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(composite);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(interactions);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(processors);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCompositeBinding_Public_Static_CompositeSyntax_InputAction_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new CompositeSyntax(pointer);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 968337, RefRangeEnd = 968343, XrefRangeStart = 968319, XrefRangeEnd = 968337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int AddBindingInternal(InputActionMap map, InputBinding binding, int bindingIndex = -1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)map);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)binding));
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bindingIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddBindingInternal_Private_Static_Int32_InputActionMap_InputBinding_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 968347, RefRangeEnd = 968348, XrefRangeStart = 968343, XrefRangeEnd = 968347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BindingSyntax ChangeBinding(this InputAction action, int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeBinding_Public_Static_BindingSyntax_InputAction_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BindingSyntax(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968348, XrefRangeEnd = 968350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BindingSyntax ChangeBinding(this InputAction action, string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeBinding_Public_Static_BindingSyntax_InputAction_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BindingSyntax(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968350, XrefRangeEnd = 968355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BindingSyntax ChangeBinding(this InputActionMap actionMap, int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionMap);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeBinding_Public_Static_BindingSyntax_InputActionMap_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BindingSyntax(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968355, XrefRangeEnd = 968357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BindingSyntax ChangeBindingWithId(this InputAction action, string id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(id);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeBindingWithId_Public_Static_BindingSyntax_InputAction_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BindingSyntax(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968357, XrefRangeEnd = 968360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BindingSyntax ChangeBindingWithId(this InputAction action, Il2CppSystem.Guid id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(Il2CppSystem.Guid**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &id;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeBindingWithId_Public_Static_BindingSyntax_InputAction_Guid_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BindingSyntax(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968360, XrefRangeEnd = 968362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BindingSyntax ChangeBindingWithGroup(this InputAction action, string group)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(group);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeBindingWithGroup_Public_Static_BindingSyntax_InputAction_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BindingSyntax(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968362, XrefRangeEnd = 968364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BindingSyntax ChangeBindingWithPath(this InputAction action, string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeBindingWithPath_Public_Static_BindingSyntax_InputAction_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BindingSyntax(pointer);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 968372, RefRangeEnd = 968377, XrefRangeStart = 968364, XrefRangeEnd = 968372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BindingSyntax ChangeBinding(this InputAction action, InputBinding match)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)match));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeBinding_Public_Static_BindingSyntax_InputAction_InputBinding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BindingSyntax(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968377, XrefRangeEnd = 968387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BindingSyntax ChangeCompositeBinding(this InputAction action, string compositeName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(compositeName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeCompositeBinding_Public_Static_BindingSyntax_InputAction_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BindingSyntax(pointer);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 968406, RefRangeEnd = 968410, XrefRangeStart = 968387, XrefRangeEnd = 968406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Rename(this InputAction action, string newName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(newName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rename_Public_Static_Void_InputAction_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 968462, RefRangeEnd = 968463, XrefRangeStart = 968410, XrefRangeEnd = 968462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddControlScheme(this InputActionAsset asset, InputControlScheme controlScheme)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)controlScheme));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddControlScheme_Public_Static_Void_InputActionAsset_InputControlScheme_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968463, XrefRangeEnd = 968473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ControlSchemeSyntax AddControlScheme(this InputActionAsset asset, string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddControlScheme_Public_Static_ControlSchemeSyntax_InputActionAsset_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ControlSchemeSyntax(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968473, XrefRangeEnd = 968496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveControlScheme(this InputActionAsset asset, string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveControlScheme_Public_Static_Void_InputActionAsset_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968496, XrefRangeEnd = 968504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InputControlScheme WithBindingGroup(this InputControlScheme scheme, string bindingGroup)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)scheme));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(bindingGroup);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithBindingGroup_Public_Static_InputControlScheme_InputControlScheme_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new InputControlScheme(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968504, XrefRangeEnd = 968520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InputControlScheme WithDevice(this InputControlScheme scheme, string controlPath, bool required)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)scheme));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(controlPath);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &required;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithDevice_Public_Static_InputControlScheme_InputControlScheme_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new InputControlScheme(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968520, XrefRangeEnd = 968528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InputControlScheme WithRequiredDevice(this InputControlScheme scheme, string controlPath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)scheme));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(controlPath);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithRequiredDevice_Public_Static_InputControlScheme_InputControlScheme_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new InputControlScheme(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968528, XrefRangeEnd = 968536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InputControlScheme WithOptionalDevice(this InputControlScheme scheme, string controlPath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)scheme));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(controlPath);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithOptionalDevice_Public_Static_InputControlScheme_InputControlScheme_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new InputControlScheme(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968536, XrefRangeEnd = 968544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InputControlScheme OrWithRequiredDevice(this InputControlScheme scheme, string controlPath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)scheme));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(controlPath);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OrWithRequiredDevice_Public_Static_InputControlScheme_InputControlScheme_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new InputControlScheme(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968544, XrefRangeEnd = 968552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InputControlScheme OrWithOptionalDevice(this InputControlScheme scheme, string controlPath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)scheme));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(controlPath);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OrWithOptionalDevice_Public_Static_InputControlScheme_InputControlScheme_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new InputControlScheme(pointer);
	}

	public InputActionSetupExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
