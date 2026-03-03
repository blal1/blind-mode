using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Buffers;

public sealed class SpanAction<T, TArg> : MulticastDelegate
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Span_1_T_TArg_0;

	static SpanAction()
	{
		Il2CppClassPointerStore<SpanAction<T, TArg>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Buffers", "SpanAction`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[2]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg>.NativeClassPtr))
		})).TypeHandle.value);
		NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpanAction<T, TArg>>.NativeClassPtr, 100674328);
		NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Span_1_T_TArg_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpanAction<T, TArg>>.NativeClassPtr, 100674329);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 833202, RefRangeEnd = 833203, XrefRangeStart = 833199, XrefRangeEnd = 833202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SpanAction(Object @object, System.IntPtr method)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpanAction<T, TArg>>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void Invoke(Span<T> span, TArg arg)
	{
		//IL_0063->IL0066: Incompatible stack types: I vs Ref
		//IL_0056->IL0066: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)span));
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TArg reference;
		if (!typeof(TArg).IsValueType)
		{
			object obj = arg;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref arg;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Span_1_T_TArg_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SpanAction(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static implicit operator SpanAction<T, TArg>(System.Action<Span<T>, TArg> P_0)
	{
		return DelegateSupport.ConvertDelegate<SpanAction<T, TArg>>((System.Delegate)P_0);
	}

	public static SpanAction<T, TArg> operator +(SpanAction<T, TArg> P_0, SpanAction<T, TArg> P_1)
	{
		return ((Il2CppObjectBase)Delegate.Combine(P_0, P_1)).Cast<SpanAction<T, TArg>>();
	}

	public static SpanAction<T, TArg> operator -(SpanAction<T, TArg> P_0, SpanAction<T, TArg> P_1)
	{
		object obj = Delegate.Remove(P_0, P_1);
		if (obj != null)
		{
			obj = ((Il2CppObjectBase)obj).Cast<SpanAction<T, TArg>>();
		}
		return (SpanAction<T, TArg>)obj;
	}
}
