using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.IntegerTime;

namespace UnityEngine.InputForUI;

public sealed class Event : Il2CppSystem.ValueType
{
	[OriginalName("UnityEngine.InputForUIModule.dll", "", "Type")]
	public enum Type
	{
		Invalid,
		KeyEvent,
		PointerEvent,
		TextInputEvent,
		IMECompositionEvent,
		CommandEvent,
		NavigationEvent
	}

	public class IMapFn<TOutputType> : Il2CppObjectBase
	{
		private sealed class MethodInfoStoreGeneric_Map_Public_Abstract_Virtual_New_TOutputType_byref_TEventType_0
		{
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(IMapFn<TOutputType>.NativeMethodInfoPtr_Map_Public_Abstract_Virtual_New_TOutputType_byref_TEventType_0, Il2CppClassPointerStore<IMapFn<TOutputType>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOutputType>.NativeClassPtr)) }))));
		}

		private static readonly System.IntPtr NativeMethodInfoPtr_Map_Public_Abstract_Virtual_New_TOutputType_byref_TEventType_0;

		static IMapFn()
		{
			Il2CppClassPointerStore<IMapFn<TOutputType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Event>.NativeClassPtr, "IMapFn`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOutputType>.NativeClassPtr)) })).TypeHandle.value);
			NativeMethodInfoPtr_Map_Public_Abstract_Virtual_New_TOutputType_byref_TEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMapFn<TOutputType>>.NativeClassPtr, 100663326);
		}

		[CallerCount(0)]
		public unsafe virtual TOutputType Map<TEventType>(ref TEventType ev)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<TEventType, object>(ref ev));
			*ptr = (nint)(&intPtr);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), IMapFn<TEventType>.MethodInfoStoreGeneric_Map_Public_Abstract_Virtual_New_TOutputType_byref_TEventType_0.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			System.IntPtr intPtr4 = intPtr;
			Unsafe.As<TEventType, object>(ref ev) = ((intPtr4 == (System.IntPtr)0) ? ((TEventType)null) : IL2CPP.PointerToValueGeneric<TEventType>(intPtr4, false, false));
			return IL2CPP.PointerToValueGeneric<TOutputType>(intPtr3, false, true);
		}

		public IMapFn(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct MapAsObject
	{
		private sealed class MethodInfoStoreGeneric_Map_Public_Virtual_Final_New_IEventProperties_byref_TEventType_0<TEventType>
		{
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Map_Public_Virtual_Final_New_IEventProperties_byref_TEventType_0, Il2CppClassPointerStore<MapAsObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEventType>.NativeClassPtr)) }))));
		}

		private static readonly System.IntPtr NativeMethodInfoPtr_Map_Public_Virtual_Final_New_IEventProperties_byref_TEventType_0;

		static MapAsObject()
		{
			Il2CppClassPointerStore<MapAsObject>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Event>.NativeClassPtr, "MapAsObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapAsObject>.NativeClassPtr);
			NativeMethodInfoPtr_Map_Public_Virtual_Final_New_IEventProperties_byref_TEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapAsObject>.NativeClassPtr, 100663327);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250886, XrefRangeEnd = 1250888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEventProperties Map<TEventType>(ref TEventType ev)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<TEventType, object>(ref ev));
			*ptr = (nint)(&intPtr);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Map_Public_Virtual_Final_New_IEventProperties_byref_TEventType_0<TEventType>.Pointer, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			System.IntPtr intPtr4 = intPtr;
			Unsafe.As<TEventType, object>(ref ev) = ((intPtr4 == (System.IntPtr)0) ? ((TEventType)null) : IL2CPP.PointerToValueGeneric<TEventType>(intPtr4, false, false));
			return (intPtr3 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEventProperties>(intPtr3) : null;
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapAsObject>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct MapAsEventSource
	{
		private sealed class MethodInfoStoreGeneric_Map_Public_Virtual_Final_New_EventSource_byref_TEventType_0<TEventType>
		{
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Map_Public_Virtual_Final_New_EventSource_byref_TEventType_0, Il2CppClassPointerStore<MapAsEventSource>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEventType>.NativeClassPtr)) }))));
		}

		private static readonly System.IntPtr NativeMethodInfoPtr_Map_Public_Virtual_Final_New_EventSource_byref_TEventType_0;

		static MapAsEventSource()
		{
			Il2CppClassPointerStore<MapAsEventSource>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Event>.NativeClassPtr, "MapAsEventSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapAsEventSource>.NativeClassPtr);
			NativeMethodInfoPtr_Map_Public_Virtual_Final_New_EventSource_byref_TEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapAsEventSource>.NativeClassPtr, 100663328);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250888, XrefRangeEnd = 1250889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual EventSource Map<TEventType>(ref TEventType ev)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<TEventType, object>(ref ev));
			*ptr = (nint)(&intPtr);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Map_Public_Virtual_Final_New_EventSource_byref_TEventType_0<TEventType>.Pointer, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			System.IntPtr intPtr4 = intPtr;
			Unsafe.As<TEventType, object>(ref ev) = ((intPtr4 == (System.IntPtr)0) ? ((TEventType)null) : IL2CPP.PointerToValueGeneric<TEventType>(intPtr4, false, false));
			return *(EventSource*)IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapAsEventSource>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct MapAsEventModifiers
	{
		private sealed class MethodInfoStoreGeneric_Map_Public_Virtual_Final_New_EventModifiers_byref_TEventType_0<TEventType>
		{
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Map_Public_Virtual_Final_New_EventModifiers_byref_TEventType_0, Il2CppClassPointerStore<MapAsEventModifiers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEventType>.NativeClassPtr)) }))));
		}

		private static readonly System.IntPtr NativeMethodInfoPtr_Map_Public_Virtual_Final_New_EventModifiers_byref_TEventType_0;

		static MapAsEventModifiers()
		{
			Il2CppClassPointerStore<MapAsEventModifiers>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Event>.NativeClassPtr, "MapAsEventModifiers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapAsEventModifiers>.NativeClassPtr);
			NativeMethodInfoPtr_Map_Public_Virtual_Final_New_EventModifiers_byref_TEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapAsEventModifiers>.NativeClassPtr, 100663329);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250889, XrefRangeEnd = 1250890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual EventModifiers Map<TEventType>(ref TEventType ev)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<TEventType, object>(ref ev));
			*ptr = (nint)(&intPtr);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Map_Public_Virtual_Final_New_EventModifiers_byref_TEventType_0<TEventType>.Pointer, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			System.IntPtr intPtr4 = intPtr;
			Unsafe.As<TEventType, object>(ref ev) = ((intPtr4 == (System.IntPtr)0) ? ((TEventType)null) : IL2CPP.PointerToValueGeneric<TEventType>(intPtr4, false, false));
			return *(EventModifiers*)IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapAsEventModifiers>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private sealed class MethodInfoStoreGeneric_Map_Private_TOutputType_TMapType_0<TOutputType, TMapType>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Map_Private_TOutputType_TMapType_0, Il2CppClassPointerStore<Event>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOutputType>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMapType>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_Map_Private_TOutputType_0<TOutputType, TMapType>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Map_Private_TOutputType_0, Il2CppClassPointerStore<Event>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOutputType>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMapType>.NativeClassPtr))
		}))));
	}

	public struct MapAsTimestamp
	{
	}

	public struct MapAsPlayerId
	{
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_TypesWithState;

	private static readonly System.IntPtr NativeFieldInfoPtr__type;

	private static readonly System.IntPtr NativeFieldInfoPtr__managedEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr__keyEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr__pointerEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr__textInputEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr__commandEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr__navigationEvent;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareType_Internal_Static_Int32_Event_Event_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_type_Public_get_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_asObject_Private_get_IEventProperties_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_eventSource_Public_Virtual_Final_New_get_EventSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_eventModifiers_Public_Virtual_Final_New_get_EventModifiers_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Ensure_Private_Void_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_From_Public_Static_Event_KeyEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_asKeyEvent_Public_get_KeyEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_From_Public_Static_Event_PointerEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_asPointerEvent_Public_get_PointerEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_From_Public_Static_Event_TextInputEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_asTextInputEvent_Public_get_TextInputEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_From_Public_Static_Event_IMECompositionEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_asIMECompositionEvent_Public_get_IMECompositionEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_From_Public_Static_Event_CommandEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_asCommandEvent_Public_get_CommandEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_From_Public_Static_Event_NavigationEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_asNavigationEvent_Public_get_NavigationEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Map_Private_TOutputType_TMapType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Map_Private_TOutputType_0;

	public const int kManagedOffset = 8;

	public const int kUnmanagedOffset = 16;

	public unsafe static Il2CppStructArray<Type> TypesWithState
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TypesWithState, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Type>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TypesWithState, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Type _type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__type);
			return *(Type*)num;
		}
		set
		{
			*(Type*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__type)) = value;
		}
	}

	public unsafe Il2CppSystem.Object _managedEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__managedEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__managedEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe KeyEvent _keyEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__keyEvent);
			return *(KeyEvent*)num;
		}
		set
		{
			*(KeyEvent*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__keyEvent)) = value;
		}
	}

	public unsafe PointerEvent _pointerEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__pointerEvent);
			return *(PointerEvent*)num;
		}
		set
		{
			*(PointerEvent*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__pointerEvent)) = value;
		}
	}

	public unsafe TextInputEvent _textInputEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__textInputEvent);
			return *(TextInputEvent*)num;
		}
		set
		{
			*(TextInputEvent*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__textInputEvent)) = value;
		}
	}

	public unsafe CommandEvent _commandEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__commandEvent);
			return *(CommandEvent*)num;
		}
		set
		{
			*(CommandEvent*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__commandEvent)) = value;
		}
	}

	public unsafe NavigationEvent _navigationEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__navigationEvent);
			return *(NavigationEvent*)num;
		}
		set
		{
			*(NavigationEvent*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__navigationEvent)) = value;
		}
	}

	public unsafe Type type
	{
		[CallerCount(175)]
		[CachedScanResults(RefRangeStart = 52464, RefRangeEnd = 52639, XrefRangeStart = 52464, XrefRangeEnd = 52639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_type_Public_get_Type_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Type*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe IEventProperties asObject
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250915, XrefRangeEnd = 1250921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_asObject_Private_get_IEventProperties_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEventProperties>(intPtr2) : null;
		}
	}

	public unsafe virtual EventSource eventSource
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1250927, RefRangeEnd = 1250930, XrefRangeStart = 1250921, XrefRangeEnd = 1250927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_eventSource_Public_Virtual_Final_New_get_EventSource_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(EventSource*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe virtual EventModifiers eventModifiers
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250930, XrefRangeEnd = 1250936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_eventModifiers_Public_Virtual_Final_New_get_EventModifiers_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(EventModifiers*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe KeyEvent asKeyEvent
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1250974, RefRangeEnd = 1250975, XrefRangeStart = 1250970, XrefRangeEnd = 1250974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_asKeyEvent_Public_get_KeyEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(KeyEvent*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe PointerEvent asPointerEvent
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1250981, RefRangeEnd = 1250982, XrefRangeStart = 1250977, XrefRangeEnd = 1250981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_asPointerEvent_Public_get_PointerEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(PointerEvent*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe TextInputEvent asTextInputEvent
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1250986, RefRangeEnd = 1250987, XrefRangeStart = 1250982, XrefRangeEnd = 1250986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_asTextInputEvent_Public_get_TextInputEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextInputEvent*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe IMECompositionEvent asIMECompositionEvent
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1250998, RefRangeEnd = 1250999, XrefRangeStart = 1250991, XrefRangeEnd = 1250998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_asIMECompositionEvent_Public_get_IMECompositionEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new IMECompositionEvent(pointer);
		}
	}

	public unsafe CommandEvent asCommandEvent
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1251003, RefRangeEnd = 1251004, XrefRangeStart = 1250999, XrefRangeEnd = 1251003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_asCommandEvent_Public_get_CommandEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(CommandEvent*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe NavigationEvent asNavigationEvent
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1251011, RefRangeEnd = 1251012, XrefRangeStart = 1251007, XrefRangeEnd = 1251011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_asNavigationEvent_Public_get_NavigationEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(NavigationEvent*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public DiscreteTime timestamp => Map<DiscreteTime, MapAsTimestamp>();

	public uint playerId => Map<uint, MapAsPlayerId>();

	static Event()
	{
		Il2CppClassPointerStore<Event>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputForUIModule.dll", "UnityEngine.InputForUI", "Event");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Event>.NativeClassPtr);
		NativeFieldInfoPtr_TypesWithState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Event>.NativeClassPtr, "TypesWithState");
		NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Event>.NativeClassPtr, "_type");
		NativeFieldInfoPtr__managedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Event>.NativeClassPtr, "_managedEvent");
		NativeFieldInfoPtr__keyEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Event>.NativeClassPtr, "_keyEvent");
		NativeFieldInfoPtr__pointerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Event>.NativeClassPtr, "_pointerEvent");
		NativeFieldInfoPtr__textInputEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Event>.NativeClassPtr, "_textInputEvent");
		NativeFieldInfoPtr__commandEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Event>.NativeClassPtr, "_commandEvent");
		NativeFieldInfoPtr__navigationEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Event>.NativeClassPtr, "_navigationEvent");
		NativeMethodInfoPtr_CompareType_Internal_Static_Int32_Event_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663304);
		NativeMethodInfoPtr_get_type_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663305);
		NativeMethodInfoPtr_get_asObject_Private_get_IEventProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663306);
		NativeMethodInfoPtr_get_eventSource_Public_Virtual_Final_New_get_EventSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663307);
		NativeMethodInfoPtr_get_eventModifiers_Public_Virtual_Final_New_get_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663308);
		NativeMethodInfoPtr_Ensure_Private_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663309);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663310);
		NativeMethodInfoPtr_From_Public_Static_Event_KeyEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663311);
		NativeMethodInfoPtr_get_asKeyEvent_Public_get_KeyEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663312);
		NativeMethodInfoPtr_From_Public_Static_Event_PointerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663313);
		NativeMethodInfoPtr_get_asPointerEvent_Public_get_PointerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663314);
		NativeMethodInfoPtr_From_Public_Static_Event_TextInputEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663315);
		NativeMethodInfoPtr_get_asTextInputEvent_Public_get_TextInputEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663316);
		NativeMethodInfoPtr_From_Public_Static_Event_IMECompositionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663317);
		NativeMethodInfoPtr_get_asIMECompositionEvent_Public_get_IMECompositionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663318);
		NativeMethodInfoPtr_From_Public_Static_Event_CommandEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663319);
		NativeMethodInfoPtr_get_asCommandEvent_Public_get_CommandEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663320);
		NativeMethodInfoPtr_From_Public_Static_Event_NavigationEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663321);
		NativeMethodInfoPtr_get_asNavigationEvent_Public_get_NavigationEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663322);
		NativeMethodInfoPtr_Map_Private_TOutputType_TMapType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663323);
		NativeMethodInfoPtr_Map_Private_TOutputType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663324);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1250913, RefRangeEnd = 1250915, XrefRangeStart = 1250890, XrefRangeEnd = 1250913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CompareType(Event a, Event b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)a));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)b));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareType_Internal_Static_Int32_Event_Event_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1250943, RefRangeEnd = 1250949, XrefRangeStart = 1250936, XrefRangeEnd = 1250943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Ensure(Type t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&t);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Ensure_Private_Void_Type_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1250969, RefRangeEnd = 1250970, XrefRangeStart = 1250949, XrefRangeEnd = 1250969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static Event From(KeyEvent keyEvent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&keyEvent);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_From_Public_Static_Event_KeyEvent_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Event(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1250975, RefRangeEnd = 1250977, XrefRangeStart = 1250975, XrefRangeEnd = 1250975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Event From(PointerEvent pointerEvent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pointerEvent);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_From_Public_Static_Event_PointerEvent_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Event(pointer);
	}

	[CallerCount(0)]
	public unsafe static Event From(TextInputEvent textInputEvent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&textInputEvent);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_From_Public_Static_Event_TextInputEvent_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Event(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250987, XrefRangeEnd = 1250991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Event From(IMECompositionEvent imeCompositionEvent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)imeCompositionEvent));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_From_Public_Static_Event_IMECompositionEvent_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Event(pointer);
	}

	[CallerCount(0)]
	public unsafe static Event From(CommandEvent commandEvent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&commandEvent);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_From_Public_Static_Event_CommandEvent_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Event(pointer);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1251004, RefRangeEnd = 1251007, XrefRangeStart = 1251004, XrefRangeEnd = 1251004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Event From(NavigationEvent navigationEvent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&navigationEvent);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_From_Public_Static_Event_NavigationEvent_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Event(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1251017, RefRangeEnd = 1251018, XrefRangeStart = 1251012, XrefRangeEnd = 1251017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TOutputType Map<TOutputType, TMapType>(TMapType fn)
	{
		//IL_004c->IL004f: Incompatible stack types: I vs Ref
		//IL_003f->IL004f: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref TMapType reference;
		if (!typeof(TMapType).IsValueType)
		{
			object obj = fn;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref fn;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Map_Private_TOutputType_TMapType_0<TOutputType, TMapType>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TOutputType>(intPtr2, false, true);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1251024, RefRangeEnd = 1251026, XrefRangeStart = 1251018, XrefRangeEnd = 1251024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TOutputType Map<TOutputType, TMapType>() where TMapType : new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Map_Private_TOutputType_0<TOutputType, TMapType>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TOutputType>(intPtr2, false, true);
	}

	public Event(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public Event()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Event>.NativeClassPtr))
	{
	}
}
