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

namespace UnityEngine.EventSystems;

public static class ExecuteEvents : Il2CppSystem.Object
{
	public sealed class EventFunction<T1> : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_BaseEventData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T1_BaseEventData_AsyncCallback_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

		static EventFunction()
		{
			Il2CppClassPointerStore<EventFunction<T1>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "EventFunction`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)) })).TypeHandle.value);
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventFunction<T1>>.NativeClassPtr, 100665025);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventFunction<T1>>.NativeClassPtr, 100665026);
			NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T1_BaseEventData_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventFunction<T1>>.NativeClassPtr, 100665027);
			NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventFunction<T1>>.NativeClassPtr, 100665028);
		}

		[CallerCount(110)]
		[CachedScanResults(RefRangeStart = 49659, RefRangeEnd = 49769, XrefRangeStart = 49659, XrefRangeEnd = 49769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventFunction(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventFunction<T1>>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(T1 handler, BaseEventData eventData)
		{
			//IL_004c->IL004f: Incompatible stack types: I vs Ref
			//IL_003f->IL004f: Incompatible stack types: I vs Ref
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			ref T1 reference;
			if (!typeof(T1).IsValueType)
			{
				object obj = handler;
				reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
			}
			else
			{
				reference = ref handler;
			}
			*ptr = (nint)Unsafe.AsPointer(ref reference);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppSystem.IAsyncResult BeginInvoke(T1 handler, BaseEventData eventData, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
		{
			//IL_004c->IL004f: Incompatible stack types: I vs Ref
			//IL_003f->IL004f: Incompatible stack types: I vs Ref
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			ref T1 reference;
			if (!typeof(T1).IsValueType)
			{
				object obj = handler;
				reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
			}
			else
			{
				reference = ref handler;
			}
			*ptr = (nint)Unsafe.AsPointer(ref reference);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T1_BaseEventData_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndInvoke(Il2CppSystem.IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public EventFunction(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator EventFunction<T1>(System.Action<T1, BaseEventData> P_0)
		{
			return DelegateSupport.ConvertDelegate<EventFunction<T1>>((System.Delegate)P_0);
		}

		public static EventFunction<T1> operator +(EventFunction<T1> P_0, EventFunction<T1> P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<EventFunction<T1>>();
		}

		public static EventFunction<T1> operator -(EventFunction<T1> P_0, EventFunction<T1> P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<EventFunction<T1>>();
			}
			return (EventFunction<T1>)obj;
		}
	}

	private sealed class MethodInfoStoreGeneric_ValidateEventData_Public_Static_T_BaseEventData_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ValidateEventData_Public_Static_T_BaseEventData_0, Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Execute_Public_Static_Boolean_GameObject_BaseEventData_EventFunction_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Execute_Public_Static_Boolean_GameObject_BaseEventData_EventFunction_1_T_0, Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_ExecuteHierarchy_Public_Static_GameObject_GameObject_BaseEventData_EventFunction_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ExecuteHierarchy_Public_Static_GameObject_GameObject_BaseEventData_EventFunction_1_T_0, Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_ShouldSendToComponent_Private_Static_Boolean_Component_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ShouldSendToComponent_Private_Static_Boolean_Component_0, Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetEventList_Private_Static_Void_GameObject_IList_1_IEventSystemHandler_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetEventList_Private_Static_Void_GameObject_IList_1_IEventSystemHandler_0, Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_CanHandleEvent_Public_Static_Boolean_GameObject_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_CanHandleEvent_Public_Static_Boolean_GameObject_0, Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetEventHandler_Public_Static_GameObject_GameObject_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetEventHandler_Public_Static_GameObject_GameObject_0, Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_s_PointerMoveHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_PointerEnterHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_PointerExitHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_PointerDownHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_PointerUpHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_PointerClickHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_InitializePotentialDragHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_BeginDragHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_DragHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_EndDragHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_DropHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_ScrollHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_UpdateSelectedHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_SelectHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_DeselectHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_MoveHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_SubmitHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_CancelHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_InternalTransformList;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateEventData_Public_Static_T_BaseEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerMoveHandler_BaseEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerEnterHandler_BaseEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerExitHandler_BaseEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerDownHandler_BaseEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerUpHandler_BaseEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerClickHandler_BaseEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IInitializePotentialDragHandler_BaseEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IBeginDragHandler_BaseEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IDragHandler_BaseEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IEndDragHandler_BaseEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IDropHandler_BaseEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IScrollHandler_BaseEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IUpdateSelectedHandler_BaseEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_ISelectHandler_BaseEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IDeselectHandler_BaseEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IMoveHandler_BaseEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_ISubmitHandler_BaseEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_ICancelHandler_BaseEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pointerMoveHandler_Public_Static_get_EventFunction_1_IPointerMoveHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pointerEnterHandler_Public_Static_get_EventFunction_1_IPointerEnterHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pointerExitHandler_Public_Static_get_EventFunction_1_IPointerExitHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pointerDownHandler_Public_Static_get_EventFunction_1_IPointerDownHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pointerUpHandler_Public_Static_get_EventFunction_1_IPointerUpHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pointerClickHandler_Public_Static_get_EventFunction_1_IPointerClickHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_initializePotentialDrag_Public_Static_get_EventFunction_1_IInitializePotentialDragHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_beginDragHandler_Public_Static_get_EventFunction_1_IBeginDragHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_dragHandler_Public_Static_get_EventFunction_1_IDragHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_endDragHandler_Public_Static_get_EventFunction_1_IEndDragHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_dropHandler_Public_Static_get_EventFunction_1_IDropHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_scrollHandler_Public_Static_get_EventFunction_1_IScrollHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_updateSelectedHandler_Public_Static_get_EventFunction_1_IUpdateSelectedHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_selectHandler_Public_Static_get_EventFunction_1_ISelectHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_deselectHandler_Public_Static_get_EventFunction_1_IDeselectHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_moveHandler_Public_Static_get_EventFunction_1_IMoveHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_submitHandler_Public_Static_get_EventFunction_1_ISubmitHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cancelHandler_Public_Static_get_EventFunction_1_ICancelHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEventChain_Private_Static_Void_GameObject_IList_1_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Static_Boolean_GameObject_BaseEventData_EventFunction_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteHierarchy_Public_Static_GameObject_GameObject_BaseEventData_EventFunction_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldSendToComponent_Private_Static_Boolean_Component_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEventList_Private_Static_Void_GameObject_IList_1_IEventSystemHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanHandleEvent_Public_Static_Boolean_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEventHandler_Public_Static_GameObject_GameObject_0;

	public unsafe static EventFunction<IPointerMoveHandler> s_PointerMoveHandler
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_PointerMoveHandler, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventFunction<IPointerMoveHandler>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_PointerMoveHandler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static EventFunction<IPointerEnterHandler> s_PointerEnterHandler
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_PointerEnterHandler, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventFunction<IPointerEnterHandler>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_PointerEnterHandler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static EventFunction<IPointerExitHandler> s_PointerExitHandler
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_PointerExitHandler, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventFunction<IPointerExitHandler>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_PointerExitHandler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static EventFunction<IPointerDownHandler> s_PointerDownHandler
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_PointerDownHandler, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventFunction<IPointerDownHandler>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_PointerDownHandler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static EventFunction<IPointerUpHandler> s_PointerUpHandler
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_PointerUpHandler, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventFunction<IPointerUpHandler>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_PointerUpHandler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static EventFunction<IPointerClickHandler> s_PointerClickHandler
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_PointerClickHandler, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventFunction<IPointerClickHandler>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_PointerClickHandler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static EventFunction<IInitializePotentialDragHandler> s_InitializePotentialDragHandler
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_InitializePotentialDragHandler, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventFunction<IInitializePotentialDragHandler>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_InitializePotentialDragHandler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static EventFunction<IBeginDragHandler> s_BeginDragHandler
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_BeginDragHandler, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventFunction<IBeginDragHandler>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_BeginDragHandler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static EventFunction<IDragHandler> s_DragHandler
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_DragHandler, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventFunction<IDragHandler>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_DragHandler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static EventFunction<IEndDragHandler> s_EndDragHandler
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_EndDragHandler, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventFunction<IEndDragHandler>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_EndDragHandler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static EventFunction<IDropHandler> s_DropHandler
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_DropHandler, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventFunction<IDropHandler>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_DropHandler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static EventFunction<IScrollHandler> s_ScrollHandler
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_ScrollHandler, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventFunction<IScrollHandler>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_ScrollHandler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static EventFunction<IUpdateSelectedHandler> s_UpdateSelectedHandler
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_UpdateSelectedHandler, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventFunction<IUpdateSelectedHandler>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_UpdateSelectedHandler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static EventFunction<ISelectHandler> s_SelectHandler
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_SelectHandler, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventFunction<ISelectHandler>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_SelectHandler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static EventFunction<IDeselectHandler> s_DeselectHandler
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_DeselectHandler, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventFunction<IDeselectHandler>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_DeselectHandler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static EventFunction<IMoveHandler> s_MoveHandler
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_MoveHandler, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventFunction<IMoveHandler>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_MoveHandler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static EventFunction<ISubmitHandler> s_SubmitHandler
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_SubmitHandler, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventFunction<ISubmitHandler>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_SubmitHandler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static EventFunction<ICancelHandler> s_CancelHandler
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_CancelHandler, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventFunction<ICancelHandler>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_CancelHandler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static List<Transform> s_InternalTransformList
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_InternalTransformList, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_InternalTransformList, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static EventFunction<IPointerMoveHandler> pointerMoveHandler
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300672, XrefRangeEnd = 1300676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pointerMoveHandler_Public_Static_get_EventFunction_1_IPointerMoveHandler_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventFunction<IPointerMoveHandler>>(intPtr2) : null;
		}
	}

	public unsafe static EventFunction<IPointerEnterHandler> pointerEnterHandler
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300676, XrefRangeEnd = 1300680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pointerEnterHandler_Public_Static_get_EventFunction_1_IPointerEnterHandler_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventFunction<IPointerEnterHandler>>(intPtr2) : null;
		}
	}

	public unsafe static EventFunction<IPointerExitHandler> pointerExitHandler
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300680, XrefRangeEnd = 1300684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pointerExitHandler_Public_Static_get_EventFunction_1_IPointerExitHandler_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventFunction<IPointerExitHandler>>(intPtr2) : null;
		}
	}

	public unsafe static EventFunction<IPointerDownHandler> pointerDownHandler
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300684, XrefRangeEnd = 1300688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pointerDownHandler_Public_Static_get_EventFunction_1_IPointerDownHandler_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventFunction<IPointerDownHandler>>(intPtr2) : null;
		}
	}

	public unsafe static EventFunction<IPointerUpHandler> pointerUpHandler
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300688, XrefRangeEnd = 1300692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pointerUpHandler_Public_Static_get_EventFunction_1_IPointerUpHandler_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventFunction<IPointerUpHandler>>(intPtr2) : null;
		}
	}

	public unsafe static EventFunction<IPointerClickHandler> pointerClickHandler
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300692, XrefRangeEnd = 1300696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pointerClickHandler_Public_Static_get_EventFunction_1_IPointerClickHandler_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventFunction<IPointerClickHandler>>(intPtr2) : null;
		}
	}

	public unsafe static EventFunction<IInitializePotentialDragHandler> initializePotentialDrag
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300696, XrefRangeEnd = 1300700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_initializePotentialDrag_Public_Static_get_EventFunction_1_IInitializePotentialDragHandler_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventFunction<IInitializePotentialDragHandler>>(intPtr2) : null;
		}
	}

	public unsafe static EventFunction<IBeginDragHandler> beginDragHandler
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300700, XrefRangeEnd = 1300704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_beginDragHandler_Public_Static_get_EventFunction_1_IBeginDragHandler_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventFunction<IBeginDragHandler>>(intPtr2) : null;
		}
	}

	public unsafe static EventFunction<IDragHandler> dragHandler
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300704, XrefRangeEnd = 1300708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_dragHandler_Public_Static_get_EventFunction_1_IDragHandler_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventFunction<IDragHandler>>(intPtr2) : null;
		}
	}

	public unsafe static EventFunction<IEndDragHandler> endDragHandler
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300708, XrefRangeEnd = 1300712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_endDragHandler_Public_Static_get_EventFunction_1_IEndDragHandler_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventFunction<IEndDragHandler>>(intPtr2) : null;
		}
	}

	public unsafe static EventFunction<IDropHandler> dropHandler
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300712, XrefRangeEnd = 1300716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_dropHandler_Public_Static_get_EventFunction_1_IDropHandler_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventFunction<IDropHandler>>(intPtr2) : null;
		}
	}

	public unsafe static EventFunction<IScrollHandler> scrollHandler
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300716, XrefRangeEnd = 1300720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scrollHandler_Public_Static_get_EventFunction_1_IScrollHandler_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventFunction<IScrollHandler>>(intPtr2) : null;
		}
	}

	public unsafe static EventFunction<IUpdateSelectedHandler> updateSelectedHandler
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300720, XrefRangeEnd = 1300724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_updateSelectedHandler_Public_Static_get_EventFunction_1_IUpdateSelectedHandler_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventFunction<IUpdateSelectedHandler>>(intPtr2) : null;
		}
	}

	public unsafe static EventFunction<ISelectHandler> selectHandler
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300724, XrefRangeEnd = 1300728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_selectHandler_Public_Static_get_EventFunction_1_ISelectHandler_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventFunction<ISelectHandler>>(intPtr2) : null;
		}
	}

	public unsafe static EventFunction<IDeselectHandler> deselectHandler
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300728, XrefRangeEnd = 1300732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_deselectHandler_Public_Static_get_EventFunction_1_IDeselectHandler_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventFunction<IDeselectHandler>>(intPtr2) : null;
		}
	}

	public unsafe static EventFunction<IMoveHandler> moveHandler
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300732, XrefRangeEnd = 1300736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_moveHandler_Public_Static_get_EventFunction_1_IMoveHandler_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventFunction<IMoveHandler>>(intPtr2) : null;
		}
	}

	public unsafe static EventFunction<ISubmitHandler> submitHandler
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300736, XrefRangeEnd = 1300740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_submitHandler_Public_Static_get_EventFunction_1_ISubmitHandler_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventFunction<ISubmitHandler>>(intPtr2) : null;
		}
	}

	public unsafe static EventFunction<ICancelHandler> cancelHandler
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300740, XrefRangeEnd = 1300744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cancelHandler_Public_Static_get_EventFunction_1_ICancelHandler_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventFunction<ICancelHandler>>(intPtr2) : null;
		}
	}

	static ExecuteEvents()
	{
		Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "ExecuteEvents");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr);
		NativeFieldInfoPtr_s_PointerMoveHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_PointerMoveHandler");
		NativeFieldInfoPtr_s_PointerEnterHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_PointerEnterHandler");
		NativeFieldInfoPtr_s_PointerExitHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_PointerExitHandler");
		NativeFieldInfoPtr_s_PointerDownHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_PointerDownHandler");
		NativeFieldInfoPtr_s_PointerUpHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_PointerUpHandler");
		NativeFieldInfoPtr_s_PointerClickHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_PointerClickHandler");
		NativeFieldInfoPtr_s_InitializePotentialDragHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_InitializePotentialDragHandler");
		NativeFieldInfoPtr_s_BeginDragHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_BeginDragHandler");
		NativeFieldInfoPtr_s_DragHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_DragHandler");
		NativeFieldInfoPtr_s_EndDragHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_EndDragHandler");
		NativeFieldInfoPtr_s_DropHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_DropHandler");
		NativeFieldInfoPtr_s_ScrollHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_ScrollHandler");
		NativeFieldInfoPtr_s_UpdateSelectedHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_UpdateSelectedHandler");
		NativeFieldInfoPtr_s_SelectHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_SelectHandler");
		NativeFieldInfoPtr_s_DeselectHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_DeselectHandler");
		NativeFieldInfoPtr_s_MoveHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_MoveHandler");
		NativeFieldInfoPtr_s_SubmitHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_SubmitHandler");
		NativeFieldInfoPtr_s_CancelHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_CancelHandler");
		NativeFieldInfoPtr_s_InternalTransformList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_InternalTransformList");
		NativeMethodInfoPtr_ValidateEventData_Public_Static_T_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664980);
		NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerMoveHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664981);
		NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerEnterHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664982);
		NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerExitHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664983);
		NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerDownHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664984);
		NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerUpHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664985);
		NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerClickHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664986);
		NativeMethodInfoPtr_Execute_Private_Static_Void_IInitializePotentialDragHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664987);
		NativeMethodInfoPtr_Execute_Private_Static_Void_IBeginDragHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664988);
		NativeMethodInfoPtr_Execute_Private_Static_Void_IDragHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664989);
		NativeMethodInfoPtr_Execute_Private_Static_Void_IEndDragHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664990);
		NativeMethodInfoPtr_Execute_Private_Static_Void_IDropHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664991);
		NativeMethodInfoPtr_Execute_Private_Static_Void_IScrollHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664992);
		NativeMethodInfoPtr_Execute_Private_Static_Void_IUpdateSelectedHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664993);
		NativeMethodInfoPtr_Execute_Private_Static_Void_ISelectHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664994);
		NativeMethodInfoPtr_Execute_Private_Static_Void_IDeselectHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664995);
		NativeMethodInfoPtr_Execute_Private_Static_Void_IMoveHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664996);
		NativeMethodInfoPtr_Execute_Private_Static_Void_ISubmitHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664997);
		NativeMethodInfoPtr_Execute_Private_Static_Void_ICancelHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664998);
		NativeMethodInfoPtr_get_pointerMoveHandler_Public_Static_get_EventFunction_1_IPointerMoveHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664999);
		NativeMethodInfoPtr_get_pointerEnterHandler_Public_Static_get_EventFunction_1_IPointerEnterHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665000);
		NativeMethodInfoPtr_get_pointerExitHandler_Public_Static_get_EventFunction_1_IPointerExitHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665001);
		NativeMethodInfoPtr_get_pointerDownHandler_Public_Static_get_EventFunction_1_IPointerDownHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665002);
		NativeMethodInfoPtr_get_pointerUpHandler_Public_Static_get_EventFunction_1_IPointerUpHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665003);
		NativeMethodInfoPtr_get_pointerClickHandler_Public_Static_get_EventFunction_1_IPointerClickHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665004);
		NativeMethodInfoPtr_get_initializePotentialDrag_Public_Static_get_EventFunction_1_IInitializePotentialDragHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665005);
		NativeMethodInfoPtr_get_beginDragHandler_Public_Static_get_EventFunction_1_IBeginDragHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665006);
		NativeMethodInfoPtr_get_dragHandler_Public_Static_get_EventFunction_1_IDragHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665007);
		NativeMethodInfoPtr_get_endDragHandler_Public_Static_get_EventFunction_1_IEndDragHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665008);
		NativeMethodInfoPtr_get_dropHandler_Public_Static_get_EventFunction_1_IDropHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665009);
		NativeMethodInfoPtr_get_scrollHandler_Public_Static_get_EventFunction_1_IScrollHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665010);
		NativeMethodInfoPtr_get_updateSelectedHandler_Public_Static_get_EventFunction_1_IUpdateSelectedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665011);
		NativeMethodInfoPtr_get_selectHandler_Public_Static_get_EventFunction_1_ISelectHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665012);
		NativeMethodInfoPtr_get_deselectHandler_Public_Static_get_EventFunction_1_IDeselectHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665013);
		NativeMethodInfoPtr_get_moveHandler_Public_Static_get_EventFunction_1_IMoveHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665014);
		NativeMethodInfoPtr_get_submitHandler_Public_Static_get_EventFunction_1_ISubmitHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665015);
		NativeMethodInfoPtr_get_cancelHandler_Public_Static_get_EventFunction_1_ICancelHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665016);
		NativeMethodInfoPtr_GetEventChain_Private_Static_Void_GameObject_IList_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665017);
		NativeMethodInfoPtr_Execute_Public_Static_Boolean_GameObject_BaseEventData_EventFunction_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665018);
		NativeMethodInfoPtr_ExecuteHierarchy_Public_Static_GameObject_GameObject_BaseEventData_EventFunction_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665019);
		NativeMethodInfoPtr_ShouldSendToComponent_Private_Static_Boolean_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665020);
		NativeMethodInfoPtr_GetEventList_Private_Static_Void_GameObject_IList_1_IEventSystemHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665021);
		NativeMethodInfoPtr_CanHandleEvent_Public_Static_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665022);
		NativeMethodInfoPtr_GetEventHandler_Public_Static_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665023);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 1300508, RefRangeEnd = 1300521, XrefRangeStart = 1300491, XrefRangeEnd = 1300508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T ValidateEventData<T>(BaseEventData data) where T : class
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ValidateEventData_Public_Static_T_BaseEventData_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300521, XrefRangeEnd = 1300531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Execute(IPointerMoveHandler handler, BaseEventData eventData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerMoveHandler_BaseEventData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300531, XrefRangeEnd = 1300541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Execute(IPointerEnterHandler handler, BaseEventData eventData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerEnterHandler_BaseEventData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300541, XrefRangeEnd = 1300551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Execute(IPointerExitHandler handler, BaseEventData eventData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerExitHandler_BaseEventData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300551, XrefRangeEnd = 1300561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Execute(IPointerDownHandler handler, BaseEventData eventData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerDownHandler_BaseEventData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300561, XrefRangeEnd = 1300571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Execute(IPointerUpHandler handler, BaseEventData eventData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerUpHandler_BaseEventData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300571, XrefRangeEnd = 1300581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Execute(IPointerClickHandler handler, BaseEventData eventData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerClickHandler_BaseEventData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300581, XrefRangeEnd = 1300591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Execute(IInitializePotentialDragHandler handler, BaseEventData eventData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Private_Static_Void_IInitializePotentialDragHandler_BaseEventData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300591, XrefRangeEnd = 1300601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Execute(IBeginDragHandler handler, BaseEventData eventData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Private_Static_Void_IBeginDragHandler_BaseEventData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300601, XrefRangeEnd = 1300611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Execute(IDragHandler handler, BaseEventData eventData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Private_Static_Void_IDragHandler_BaseEventData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300611, XrefRangeEnd = 1300621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Execute(IEndDragHandler handler, BaseEventData eventData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Private_Static_Void_IEndDragHandler_BaseEventData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300621, XrefRangeEnd = 1300631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Execute(IDropHandler handler, BaseEventData eventData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Private_Static_Void_IDropHandler_BaseEventData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300631, XrefRangeEnd = 1300641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Execute(IScrollHandler handler, BaseEventData eventData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Private_Static_Void_IScrollHandler_BaseEventData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300641, XrefRangeEnd = 1300645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Execute(IUpdateSelectedHandler handler, BaseEventData eventData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Private_Static_Void_IUpdateSelectedHandler_BaseEventData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300645, XrefRangeEnd = 1300649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Execute(ISelectHandler handler, BaseEventData eventData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Private_Static_Void_ISelectHandler_BaseEventData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300649, XrefRangeEnd = 1300653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Execute(IDeselectHandler handler, BaseEventData eventData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Private_Static_Void_IDeselectHandler_BaseEventData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300653, XrefRangeEnd = 1300664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Execute(IMoveHandler handler, BaseEventData eventData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Private_Static_Void_IMoveHandler_BaseEventData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300664, XrefRangeEnd = 1300668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Execute(ISubmitHandler handler, BaseEventData eventData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Private_Static_Void_ISubmitHandler_BaseEventData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300668, XrefRangeEnd = 1300672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Execute(ICancelHandler handler, BaseEventData eventData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Private_Static_Void_ICancelHandler_BaseEventData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1300760, RefRangeEnd = 1300761, XrefRangeStart = 1300744, XrefRangeEnd = 1300760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetEventChain(GameObject root, IList<Transform> eventChain)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)root);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventChain);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEventChain_Private_Static_Void_GameObject_IList_1_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 1300804, RefRangeEnd = 1300857, XrefRangeStart = 1300761, XrefRangeEnd = 1300804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Execute<T>(GameObject target, BaseEventData eventData, EventFunction<T> functor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)functor);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Execute_Public_Static_Boolean_GameObject_BaseEventData_EventFunction_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 1300875, RefRangeEnd = 1300895, XrefRangeStart = 1300857, XrefRangeEnd = 1300875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject ExecuteHierarchy<T>(GameObject root, BaseEventData eventData, EventFunction<T> callbackFunction)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)root);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callbackFunction);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ExecuteHierarchy_Public_Static_GameObject_GameObject_BaseEventData_EventFunction_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300895, XrefRangeEnd = 1300904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ShouldSendToComponent<T>(Component component)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)component);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ShouldSendToComponent_Private_Static_Boolean_Component_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1300951, RefRangeEnd = 1300954, XrefRangeStart = 1300904, XrefRangeEnd = 1300951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetEventList<T>(GameObject go, IList<IEventSystemHandler> results)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetEventList_Private_Static_Void_GameObject_IList_1_IEventSystemHandler_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300954, XrefRangeEnd = 1300969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CanHandleEvent<T>(GameObject go)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_CanHandleEvent_Public_Static_Boolean_GameObject_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(24)]
	[CachedScanResults(RefRangeStart = 1301001, RefRangeEnd = 1301025, XrefRangeStart = 1300969, XrefRangeEnd = 1301001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject GetEventHandler<T>(GameObject root)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)root);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetEventHandler_Public_Static_GameObject_GameObject_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
	}

	public ExecuteEvents(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
