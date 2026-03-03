using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem;

public sealed class EventHandler : MulticastDelegate
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_EventArgs_0;

	static EventHandler()
	{
		Il2CppClassPointerStore<EventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "EventHandler");
		NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHandler>.NativeClassPtr, 100664936);
		NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHandler>.NativeClassPtr, 100664937);
	}

	[CallerCount(110)]
	[CachedScanResults(RefRangeStart = 49659, RefRangeEnd = 49769, XrefRangeStart = 49659, XrefRangeEnd = 49769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EventHandler(Object @object, System.IntPtr method)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventHandler>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void Invoke(Object sender, EventArgs e)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sender);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)e);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_EventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public EventHandler(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static implicit operator EventHandler(System.Action<Object, EventArgs> P_0)
	{
		return DelegateSupport.ConvertDelegate<EventHandler>((System.Delegate)P_0);
	}

	public static EventHandler operator +(EventHandler P_0, EventHandler P_1)
	{
		return ((Il2CppObjectBase)Delegate.Combine(P_0, P_1)).Cast<EventHandler>();
	}

	public static EventHandler operator -(EventHandler P_0, EventHandler P_1)
	{
		object obj = Delegate.Remove(P_0, P_1);
		if (obj != null)
		{
			obj = ((Il2CppObjectBase)obj).Cast<EventHandler>();
		}
		return (EventHandler)obj;
	}
}
public sealed class EventHandler<TEventArgs> : MulticastDelegate
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_TEventArgs_0;

	static EventHandler()
	{
		Il2CppClassPointerStore<EventHandler<TEventArgs>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "EventHandler`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEventArgs>.NativeClassPtr)) })).TypeHandle.value);
		NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHandler<TEventArgs>>.NativeClassPtr, 100664938);
		NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_TEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHandler<TEventArgs>>.NativeClassPtr, 100664939);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 725107, RefRangeEnd = 725113, XrefRangeStart = 725097, XrefRangeEnd = 725107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EventHandler(Object @object, System.IntPtr method)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventHandler<TEventArgs>>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void Invoke(Object sender, TEventArgs e)
	{
		//IL_005e->IL0061: Incompatible stack types: I vs Ref
		//IL_0051->IL0061: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sender);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TEventArgs reference;
		if (!typeof(TEventArgs).IsValueType)
		{
			object obj = e;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref e;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_TEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public EventHandler(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static implicit operator EventHandler<TEventArgs>(System.Action<Object, TEventArgs> P_0)
	{
		return DelegateSupport.ConvertDelegate<EventHandler<TEventArgs>>((System.Delegate)P_0);
	}

	public static EventHandler<TEventArgs> operator +(EventHandler<TEventArgs> P_0, EventHandler<TEventArgs> P_1)
	{
		return ((Il2CppObjectBase)Delegate.Combine(P_0, P_1)).Cast<EventHandler<TEventArgs>>();
	}

	public static EventHandler<TEventArgs> operator -(EventHandler<TEventArgs> P_0, EventHandler<TEventArgs> P_1)
	{
		object obj = Delegate.Remove(P_0, P_1);
		if (obj != null)
		{
			obj = ((Il2CppObjectBase)obj).Cast<EventHandler<TEventArgs>>();
		}
		return (EventHandler<TEventArgs>)obj;
	}
}
