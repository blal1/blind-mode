using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomSystem.UI;

namespace YgomGame.Duel;

[Token(Token = "0x2001A86")]
public class SharedMisc
{
	[Token(Token = "0x2001A88")]
	[CompilerGenerated]
	private sealed class _003CDelayedFunctionImpl_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400F4A4")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400F4A5")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400F4A6")]
		[FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x400F4A7")]
		[FieldOffset(Offset = "0x28")]
		public Action func;

		[Token(Token = "0x17001AB6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600AC90")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001AB7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600AC92")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600AC8D")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CDelayedFunctionImpl_003Ed__19(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600AC8E")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600AC8F")]
		[Address(RVA = "0x436D70", Offset = "0x435F70", VA = "0x180436D70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600AC91")]
		[Address(RVA = "0x436E30", Offset = "0x436030", VA = "0x180436E30", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001A89")]
	[CompilerGenerated]
	private sealed class _003CWaitLimitedTime_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400F4A8")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400F4A9")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400F4AA")]
		[FieldOffset(Offset = "0x20")]
		public Func<bool> isFinishedFunc;

		[Token(Token = "0x400F4AB")]
		[FieldOffset(Offset = "0x28")]
		public float timeLimit;

		[Token(Token = "0x400F4AC")]
		[FieldOffset(Offset = "0x2C")]
		private float _003CstartTime_003E5__2;

		[Token(Token = "0x17001AB8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600AC96")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001AB9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600AC98")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600AC93")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CWaitLimitedTime_003Ed__23(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600AC94")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600AC95")]
		[Address(RVA = "0x438E40", Offset = "0x438040", VA = "0x180438E40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600AC97")]
		[Address(RVA = "0x438EF0", Offset = "0x4380F0", VA = "0x180438EF0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x600AC70")]
	[Address(RVA = "0x434950", Offset = "0x433B50", VA = "0x180434950")]
	public static CardRoot GetCardRoot(DuelGameObjectManager goManager, int team, int position, int index)
	{
		return null;
	}

	[Token(Token = "0x600AC71")]
	[Address(RVA = "0x4344E0", Offset = "0x4336E0", VA = "0x1804344E0")]
	public static Vector3 Bezier(Vector3 P0, Vector3 P1, Vector3 P2, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600AC72")]
	[Address(RVA = "0x4343E0", Offset = "0x4335E0", VA = "0x1804343E0")]
	public static Vector3 BezierVec(Vector3 P0, Vector3 P1, Vector3 P2, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600AC73")]
	[Address(RVA = "0x434130", Offset = "0x433330", VA = "0x180434130")]
	public static Vector3 BezierVec2(Vector3 P0, Vector3 P1, Vector3 P2, Vector3 P3, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600AC74")]
	[Address(RVA = "0x433E40", Offset = "0x433040", VA = "0x180433E40")]
	public static float Bezier2(float P1, float P2, float t)
	{
		return default(float);
	}

	[Token(Token = "0x600AC75")]
	[Address(RVA = "0x433F60", Offset = "0x433160", VA = "0x180433F60")]
	public static float Bezier3(float P1, float P2, float P3, float t)
	{
		return default(float);
	}

	[Token(Token = "0x600AC76")]
	[Address(RVA = "0x4353A0", Offset = "0x4345A0", VA = "0x1804353A0")]
	public static Quaternion QuatBezier(Quaternion P0, Quaternion P1, Quaternion P2, float t)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600AC77")]
	[Address(RVA = "0x434FC0", Offset = "0x4341C0", VA = "0x180434FC0")]
	public static Vector3 PerlinShake(float cycle, Vector3 pow)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600AC78")]
	[Address(RVA = "0x434DF0", Offset = "0x433FF0", VA = "0x180434DF0")]
	public static bool LinePlaneIntersection(out Vector3 intersection, Vector3 linePoint, Vector3 lineVec, Vector3 planeNormal, Vector3 planePoint)
	{
		return default(bool);
	}

	[Token(Token = "0x600AC79")]
	[Address(RVA = "0x434B50", Offset = "0x433D50", VA = "0x180434B50")]
	public static bool LineLineIntersection(out Vector3 intersection, Vector3 linePoint1, Vector3 lineVec1, Vector3 linePoint2, Vector3 lineVec2)
	{
		return default(bool);
	}

	[Token(Token = "0x600AC7A")]
	[Address(RVA = "0x435630", Offset = "0x434830", VA = "0x180435630")]
	public static Vector3 SetVectorLength(Vector3 vector, float size)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600AC7B")]
	[Address(RVA = "0x4349E0", Offset = "0x433BE0", VA = "0x1804349E0")]
	public static Vector3 GetIntersectionZXPlane(Ray ray)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600AC7C")]
	[Address(RVA = "0x4348D0", Offset = "0x433AD0", VA = "0x1804348D0")]
	public static string GetBillboardTexPath(int cardId)
	{
		return null;
	}

	[Token(Token = "0x600AC7D")]
	[Address(RVA = "0x435480", Offset = "0x434680", VA = "0x180435480")]
	public static void SetMeshColor(MeshFilter meshFilter, Color col)
	{
	}

	[Token(Token = "0x600AC7E")]
	[Address(RVA = "0x434A50", Offset = "0x433C50", VA = "0x180434A50")]
	public static Color GetMeshColor(MeshFilter meshFilter)
	{
		return default(Color);
	}

	[Token(Token = "0x600AC7F")]
	[Address(RVA = "0x434750", Offset = "0x433950", VA = "0x180434750")]
	public static Dictionary<CardPlace, Engine.AffectType> GetAffectCardPlaces(DuelFieldBase duelField, int team, int position)
	{
		return null;
	}

	[Token(Token = "0x600AC80")]
	[Address(RVA = "0x4345D0", Offset = "0x4337D0", VA = "0x1804345D0")]
	public static string DebugGetCallMethod(int numFrames = 1)
	{
		return null;
	}

	[Token(Token = "0x600AC81")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void DebugPrintCallStack(string message, uint numStacks = 3u)
	{
	}

	[Token(Token = "0x600AC82")]
	[Address(RVA = "0x434680", Offset = "0x433880", VA = "0x180434680")]
	public static void DelayedFunction(float delay, Action func)
	{
	}

	[Token(Token = "0x600AC83")]
	[Address(RVA = "0x434600", Offset = "0x433800", VA = "0x180434600")]
	[IteratorStateMachine(typeof(_003CDelayedFunctionImpl_003Ed__19))]
	private static IEnumerator DelayedFunctionImpl(float delay, Action func)
	{
		return null;
	}

	[Token(Token = "0x600AC84")]
	public static int BinarySearch<T>(List<T> list, Func<T, int> comparer)
	{
		return default(int);
	}

	[Token(Token = "0x600AC85")]
	[Address(RVA = "0x433CA0", Offset = "0x432EA0", VA = "0x180433CA0")]
	public static TweenSet ApplyTweenTR(GameObject go, Vector3 srcPos, Quaternion srcRot, Vector3 dstPos, Quaternion dstRot, float duration, Tween.Easing easing, UnityAction onFinished)
	{
		return null;
	}

	[Token(Token = "0x600AC86")]
	[Address(RVA = "0x4350B0", Offset = "0x4342B0", VA = "0x1804350B0")]
	public static void PlayTween(GameObject target, string label, Action onFinished)
	{
	}

	[Token(Token = "0x600AC87")]
	[Address(RVA = "0x4356A0", Offset = "0x4348A0", VA = "0x1804356A0")]
	[IteratorStateMachine(typeof(_003CWaitLimitedTime_003Ed__23))]
	public static IEnumerator WaitLimitedTime(float timeLimit, Func<bool> isFinishedFunc)
	{
		return null;
	}

	[Token(Token = "0x600AC88")]
	[Address(RVA = "0x434AD0", Offset = "0x433CD0", VA = "0x180434AD0")]
	public static bool IsDistanceLength(Vector2 screenPointA, Vector2 screenPointB, float screenRatio)
	{
		return default(bool);
	}

	[Token(Token = "0x600AC89")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public SharedMisc()
	{
	}
}
