using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Bindings;

namespace Unity.Hierarchy;

public class HierarchyNodeTypeHandlerBase : Il2CppSystem.Object
{
	public static class BindingsMarshaller : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_HierarchyNodeTypeHandlerBase_0;

		static BindingsMarshaller()
		{
			Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBase>.NativeClassPtr, "BindingsMarshaller");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr);
			NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_HierarchyNodeTypeHandlerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr, 100663340);
		}

		[CallerCount(0)]
		public unsafe static System.IntPtr ConvertToNative(HierarchyNodeTypeHandlerBase handler)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_HierarchyNodeTypeHandlerBase_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public BindingsMarshaller(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ConstructorScope
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Hierarchy;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_CommandList;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_Ptr_Private_Static_set_Void_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_Hierarchy_Private_Static_set_Void_Hierarchy_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_CommandList_Private_Static_set_Void_HierarchyCommandList_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Hierarchy_HierarchyCommandList_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		public unsafe static System.IntPtr m_Ptr
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_Ptr, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_Ptr, (void*)(&value));
			}
		}

		public unsafe static Hierarchy m_Hierarchy
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_Hierarchy, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hierarchy>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_Hierarchy, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static HierarchyCommandList m_CommandList
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_CommandList, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HierarchyCommandList>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_CommandList, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static System.IntPtr Ptr
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242659, XrefRangeEnd = 1242662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Ptr_Private_Static_set_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe static Hierarchy Hierarchy
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242662, XrefRangeEnd = 1242668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Hierarchy_Private_Static_set_Void_Hierarchy_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe static HierarchyCommandList CommandList
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242668, XrefRangeEnd = 1242674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CommandList_Private_Static_set_Void_HierarchyCommandList_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		static ConstructorScope()
		{
			Il2CppClassPointerStore<ConstructorScope>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBase>.NativeClassPtr, "ConstructorScope");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructorScope>.NativeClassPtr);
			NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructorScope>.NativeClassPtr, "m_Ptr");
			NativeFieldInfoPtr_m_Hierarchy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructorScope>.NativeClassPtr, "m_Hierarchy");
			NativeFieldInfoPtr_m_CommandList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructorScope>.NativeClassPtr, "m_CommandList");
			NativeMethodInfoPtr_set_Ptr_Private_Static_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructorScope>.NativeClassPtr, 100663341);
			NativeMethodInfoPtr_set_Hierarchy_Private_Static_set_Void_Hierarchy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructorScope>.NativeClassPtr, 100663342);
			NativeMethodInfoPtr_set_CommandList_Private_Static_set_Void_HierarchyCommandList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructorScope>.NativeClassPtr, 100663343);
			NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Hierarchy_HierarchyCommandList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructorScope>.NativeClassPtr, 100663344);
			NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructorScope>.NativeClassPtr, 100663345);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1242689, RefRangeEnd = 1242690, XrefRangeStart = 1242674, XrefRangeEnd = 1242689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructorScope(System.IntPtr nativePtr, Hierarchy hierarchy, HierarchyCommandList cmdList)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&nativePtr);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hierarchy);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmdList);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Hierarchy_HierarchyCommandList_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1242705, RefRangeEnd = 1242708, XrefRangeStart = 1242690, XrefRangeEnd = 1242705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConstructorScope>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private delegate int GetNodeTypeFromTypeDelegate(System.IntPtr type);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Hierarchy;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CommandList;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_NodeTypes;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Protected_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNodeTypeName_Public_Virtual_New_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultNodeFlags_Public_Virtual_New_HierarchyNodeFlags_byref_HierarchyNode_HierarchyNodeFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SearchBegin_Protected_Virtual_New_Void_HierarchySearchQueryDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SearchMatch_Protected_Virtual_New_Boolean_byref_HierarchyNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SearchEnd_Protected_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromIntPtr_Internal_Static_HierarchyNodeTypeHandlerBase_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_SearchBegin_Internal_Void_HierarchySearchQueryDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateNodeTypeHandlerFromType_Private_Static_IntPtr_IntPtr_Type_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetStaticNodeType_Private_Static_Boolean_Type_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeInitialize_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeDispose_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeGetNodeTypeName_Private_Static_String_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeGetDefaultNodeFlags_Private_Static_HierarchyNodeFlags_IntPtr_byref_HierarchyNode_HierarchyNodeFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeChangesPending_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeIntegrateChanges_Private_Static_Boolean_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeSearchMatch_Private_Static_Boolean_IntPtr_byref_HierarchyNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeSearchEnd_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangesPending_Protected_Virtual_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IntegrateChanges_Protected_Virtual_New_Boolean_HierarchyCommandList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNodeTypeName_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultNodeFlags_Injected_Private_Static_HierarchyNodeFlags_IntPtr_byref_HierarchyNode_HierarchyNodeFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SearchBegin_Injected_Private_Static_Void_IntPtr_HierarchySearchQueryDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SearchMatch_Injected_Private_Static_Boolean_IntPtr_byref_HierarchyNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SearchEnd_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangesPending_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IntegrateChanges_Injected_Private_Static_Boolean_IntPtr_IntPtr_0;

	private static readonly GetNodeTypeFromTypeDelegate GetNodeTypeFromTypeDelegateField;

	public unsafe System.IntPtr m_Ptr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ptr);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ptr)) = value;
		}
	}

	public unsafe Hierarchy m_Hierarchy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Hierarchy);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hierarchy>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Hierarchy)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe HierarchyCommandList m_CommandList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CommandList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HierarchyCommandList>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CommandList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Dictionary<Il2CppSystem.Type, int> s_NodeTypes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_NodeTypes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Type, int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_NodeTypes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public Hierarchy Hierarchy => m_Hierarchy;

	public HierarchyCommandList CommandList => m_CommandList;

	static HierarchyNodeTypeHandlerBase()
	{
		Il2CppClassPointerStore<HierarchyNodeTypeHandlerBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.HierarchyCoreModule.dll", "Unity.Hierarchy", "HierarchyNodeTypeHandlerBase");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBase>.NativeClassPtr);
		NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBase>.NativeClassPtr, "m_Ptr");
		NativeFieldInfoPtr_m_Hierarchy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBase>.NativeClassPtr, "m_Hierarchy");
		NativeFieldInfoPtr_m_CommandList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBase>.NativeClassPtr, "m_CommandList");
		NativeFieldInfoPtr_s_NodeTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBase>.NativeClassPtr, "s_NodeTypes");
		NativeMethodInfoPtr_Initialize_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBase>.NativeClassPtr, 100663311);
		NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBase>.NativeClassPtr, 100663312);
		NativeMethodInfoPtr_GetNodeTypeName_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBase>.NativeClassPtr, 100663313);
		NativeMethodInfoPtr_GetDefaultNodeFlags_Public_Virtual_New_HierarchyNodeFlags_byref_HierarchyNode_HierarchyNodeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBase>.NativeClassPtr, 100663314);
		NativeMethodInfoPtr_SearchBegin_Protected_Virtual_New_Void_HierarchySearchQueryDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBase>.NativeClassPtr, 100663315);
		NativeMethodInfoPtr_SearchMatch_Protected_Virtual_New_Boolean_byref_HierarchyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBase>.NativeClassPtr, 100663316);
		NativeMethodInfoPtr_SearchEnd_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBase>.NativeClassPtr, 100663317);
		NativeMethodInfoPtr_FromIntPtr_Internal_Static_HierarchyNodeTypeHandlerBase_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBase>.NativeClassPtr, 100663318);
		NativeMethodInfoPtr_Internal_SearchBegin_Internal_Void_HierarchySearchQueryDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBase>.NativeClassPtr, 100663319);
		NativeMethodInfoPtr_CreateNodeTypeHandlerFromType_Private_Static_IntPtr_IntPtr_Type_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBase>.NativeClassPtr, 100663320);
		NativeMethodInfoPtr_TryGetStaticNodeType_Private_Static_Boolean_Type_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBase>.NativeClassPtr, 100663321);
		NativeMethodInfoPtr_InvokeInitialize_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBase>.NativeClassPtr, 100663322);
		NativeMethodInfoPtr_InvokeDispose_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBase>.NativeClassPtr, 100663323);
		NativeMethodInfoPtr_InvokeGetNodeTypeName_Private_Static_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBase>.NativeClassPtr, 100663324);
		NativeMethodInfoPtr_InvokeGetDefaultNodeFlags_Private_Static_HierarchyNodeFlags_IntPtr_byref_HierarchyNode_HierarchyNodeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBase>.NativeClassPtr, 100663325);
		NativeMethodInfoPtr_InvokeChangesPending_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBase>.NativeClassPtr, 100663326);
		NativeMethodInfoPtr_InvokeIntegrateChanges_Private_Static_Boolean_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBase>.NativeClassPtr, 100663327);
		NativeMethodInfoPtr_InvokeSearchMatch_Private_Static_Boolean_IntPtr_byref_HierarchyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBase>.NativeClassPtr, 100663328);
		NativeMethodInfoPtr_InvokeSearchEnd_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBase>.NativeClassPtr, 100663329);
		NativeMethodInfoPtr_ChangesPending_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBase>.NativeClassPtr, 100663330);
		NativeMethodInfoPtr_IntegrateChanges_Protected_Virtual_New_Boolean_HierarchyCommandList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBase>.NativeClassPtr, 100663331);
		NativeMethodInfoPtr_GetNodeTypeName_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBase>.NativeClassPtr, 100663333);
		NativeMethodInfoPtr_GetDefaultNodeFlags_Injected_Private_Static_HierarchyNodeFlags_IntPtr_byref_HierarchyNode_HierarchyNodeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBase>.NativeClassPtr, 100663334);
		NativeMethodInfoPtr_SearchBegin_Injected_Private_Static_Void_IntPtr_HierarchySearchQueryDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBase>.NativeClassPtr, 100663335);
		NativeMethodInfoPtr_SearchMatch_Injected_Private_Static_Boolean_IntPtr_byref_HierarchyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBase>.NativeClassPtr, 100663336);
		NativeMethodInfoPtr_SearchEnd_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBase>.NativeClassPtr, 100663337);
		NativeMethodInfoPtr_ChangesPending_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBase>.NativeClassPtr, 100663338);
		NativeMethodInfoPtr_IntegrateChanges_Injected_Private_Static_Boolean_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBase>.NativeClassPtr, 100663339);
		GetNodeTypeFromTypeDelegateField = IL2CPP.ResolveICall<GetNodeTypeFromTypeDelegate>("Unity.Hierarchy.HierarchyNodeTypeHandlerBase::GetNodeTypeFromType");
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Initialize_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose(bool disposing)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&disposing);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242708, XrefRangeEnd = 1242717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual string GetNodeTypeName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetNodeTypeName_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242717, XrefRangeEnd = 1242724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual HierarchyNodeFlags GetDefaultNodeFlags([In] ref HierarchyNode node, HierarchyNodeFlags defaultFlags = HierarchyNodeFlags.None)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref node);
		*(HierarchyNodeFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultFlags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetDefaultNodeFlags_Public_Virtual_New_HierarchyNodeFlags_byref_HierarchyNode_HierarchyNodeFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(HierarchyNodeFlags*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242724, XrefRangeEnd = 1242731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SearchBegin(HierarchySearchQueryDescriptor query)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)query);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SearchBegin_Protected_Virtual_New_Void_HierarchySearchQueryDescriptor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242731, XrefRangeEnd = 1242738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool SearchMatch([In] ref HierarchyNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref node);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SearchMatch_Protected_Virtual_New_Boolean_byref_HierarchyNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242738, XrefRangeEnd = 1242745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SearchEnd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SearchEnd_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242745, XrefRangeEnd = 1242752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HierarchyNodeTypeHandlerBase FromIntPtr(System.IntPtr handlePtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handlePtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromIntPtr_Internal_Static_HierarchyNodeTypeHandlerBase_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HierarchyNodeTypeHandlerBase>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 906993, RefRangeEnd = 906994, XrefRangeStart = 906993, XrefRangeEnd = 906994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Internal_SearchBegin(HierarchySearchQueryDescriptor query)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)query);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_SearchBegin_Internal_Void_HierarchySearchQueryDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242752, XrefRangeEnd = 1242765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr CreateNodeTypeHandlerFromType(System.IntPtr nativePtr, Il2CppSystem.Type handlerType, System.IntPtr hierarchyPtr, System.IntPtr cmdListPtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&nativePtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handlerType);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hierarchyPtr;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &cmdListPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateNodeTypeHandlerFromType_Private_Static_IntPtr_IntPtr_Type_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242765, XrefRangeEnd = 1242777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryGetStaticNodeType(Il2CppSystem.Type handlerType, out int nodeType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handlerType);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref nodeType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetStaticNodeType_Private_Static_Boolean_Type_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242777, XrefRangeEnd = 1242782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeInitialize(System.IntPtr handlePtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handlePtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeInitialize_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242782, XrefRangeEnd = 1242791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeDispose(System.IntPtr handlePtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handlePtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeDispose_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242791, XrefRangeEnd = 1242796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string InvokeGetNodeTypeName(System.IntPtr handlePtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handlePtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeGetNodeTypeName_Private_Static_String_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242796, XrefRangeEnd = 1242801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HierarchyNodeFlags InvokeGetDefaultNodeFlags(System.IntPtr handlePtr, [In] ref HierarchyNode node, HierarchyNodeFlags defaultFlags)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&handlePtr);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref node);
		*(HierarchyNodeFlags**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultFlags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeGetDefaultNodeFlags_Private_Static_HierarchyNodeFlags_IntPtr_byref_HierarchyNode_HierarchyNodeFlags_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(HierarchyNodeFlags*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242801, XrefRangeEnd = 1242806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool InvokeChangesPending(System.IntPtr handlePtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handlePtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeChangesPending_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242806, XrefRangeEnd = 1242812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool InvokeIntegrateChanges(System.IntPtr handlePtr, System.IntPtr cmdListPtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&handlePtr);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cmdListPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeIntegrateChanges_Private_Static_Boolean_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242812, XrefRangeEnd = 1242817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool InvokeSearchMatch(System.IntPtr handlePtr, [In] ref HierarchyNode node)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&handlePtr);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref node);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeSearchMatch_Private_Static_Boolean_IntPtr_byref_HierarchyNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242817, XrefRangeEnd = 1242822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeSearchEnd(System.IntPtr handlePtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handlePtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeSearchEnd_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242822, XrefRangeEnd = 1242829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool ChangesPending()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ChangesPending_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242829, XrefRangeEnd = 1242836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool IntegrateChanges(HierarchyCommandList cmdList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmdList);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IntegrateChanges_Protected_Virtual_New_Boolean_HierarchyCommandList_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242836, XrefRangeEnd = 1242838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetNodeTypeName_Injected(System.IntPtr _unity_self, out ManagedSpanWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNodeTypeName_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242838, XrefRangeEnd = 1242840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HierarchyNodeFlags GetDefaultNodeFlags_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node, HierarchyNodeFlags defaultFlags)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref node);
		*(HierarchyNodeFlags**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultFlags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefaultNodeFlags_Injected_Private_Static_HierarchyNodeFlags_IntPtr_byref_HierarchyNode_HierarchyNodeFlags_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(HierarchyNodeFlags*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242840, XrefRangeEnd = 1242842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SearchBegin_Injected(System.IntPtr _unity_self, HierarchySearchQueryDescriptor query)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)query);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SearchBegin_Injected_Private_Static_Void_IntPtr_HierarchySearchQueryDescriptor_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242842, XrefRangeEnd = 1242844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SearchMatch_Injected(System.IntPtr _unity_self, [In] ref HierarchyNode node)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref node);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SearchMatch_Injected_Private_Static_Boolean_IntPtr_byref_HierarchyNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242844, XrefRangeEnd = 1242846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SearchEnd_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SearchEnd_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242846, XrefRangeEnd = 1242848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ChangesPending_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangesPending_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242848, XrefRangeEnd = 1242850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IntegrateChanges_Injected(System.IntPtr _unity_self, System.IntPtr cmdList)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cmdList;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IntegrateChanges_Injected_Private_Static_Boolean_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public HierarchyNodeTypeHandlerBase(System.IntPtr pointer)
		: base(pointer)
	{
	}

	~HierarchyNodeTypeHandlerBase()
	{
		Dispose(disposing: false);
	}

	public HierarchyNodeType GetNodeType()
	{
		return new HierarchyNodeType(GetNodeTypeFromType(base.GetType()));
	}

	public virtual HierarchyNodeFlags GetDefaultNodeFlags([In] ref HierarchyNode node, [Optional] HierarchyNodeFlags defaultFlags)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetDefaultNodeFlags_Injected(intPtr, ref node, defaultFlags);
	}

	public virtual bool SearchMatch([In] ref HierarchyNode node)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return SearchMatch_Injected(intPtr, ref node);
	}

	public bool Internal_SearchMatch([In] ref HierarchyNode node)
	{
		return this.SearchMatch(ref node);
	}

	public static int GetNodeTypeFromType(Il2CppSystem.Type type)
	{
		return GetNodeTypeFromTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type));
	}

	public void Dispose()
	{
	}
}
