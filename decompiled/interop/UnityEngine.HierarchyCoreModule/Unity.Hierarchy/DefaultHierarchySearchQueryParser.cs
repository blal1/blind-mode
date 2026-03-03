using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text.RegularExpressions;

namespace Unity.Hierarchy;

public class DefaultHierarchySearchQueryParser : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_Filter;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static Regex s_Filter
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Filter, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Filter, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static DefaultHierarchySearchQueryParser()
	{
		Il2CppClassPointerStore<DefaultHierarchySearchQueryParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.HierarchyCoreModule.dll", "Unity.Hierarchy", "DefaultHierarchySearchQueryParser");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultHierarchySearchQueryParser>.NativeClassPtr);
		NativeFieldInfoPtr_s_Filter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultHierarchySearchQueryParser>.NativeClassPtr, "s_Filter");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultHierarchySearchQueryParser>.NativeClassPtr, 100663361);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DefaultHierarchySearchQueryParser()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultHierarchySearchQueryParser>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public DefaultHierarchySearchQueryParser(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static List<string> Tokenize(string s)
	{
		s = s.Trim();
		List<string> list = new List<string>();
		int num = 0;
		int i = 0;
		while (i < s.Length)
		{
			if (Il2CppSystem.Char.IsWhiteSpace(s[i]))
			{
				string item = s.Substring(num, i - num);
				list.Add(item);
				for (i++; i < s.Length && Il2CppSystem.Char.IsWhiteSpace(s[i]); i++)
				{
				}
				if (i < s.Length)
				{
					num = i;
				}
			}
			else if (s[i] == '"')
			{
				for (i++; i < s.Length && s[i] != '"'; i++)
				{
				}
				if (i >= s.Length)
				{
					return null;
				}
				i++;
			}
			else
			{
				i++;
			}
		}
		if (i != num)
		{
			string item2 = s.Substring(num, i - num);
			list.Add(item2);
		}
		return list;
	}

	public HierarchySearchQueryDescriptor ParseQuery(string query)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}
}
