using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Xml;
using System.Xml.Schema;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;

namespace USnd;

[Token(Token = "0x20000E6")]
public class AudioManager : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000E7")]
	public class AudioCategorySettings
	{
		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string categoryName;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int maxPlaybacksNum;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float volume;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string masterName;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AudioMasterSettings attachMaster;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AudioParamUpdater volumeUpdater;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private AudioParamUpdater duckingUpdater;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float programVolume;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float duckingVolume;

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x8AB9F0", Offset = "0x8AABF0", VA = "0x1808AB9F0")]
		public AudioCategorySettings()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x8AB7F0", Offset = "0x8AA9F0", VA = "0x1808AB7F0")]
		public void CopySettings(AudioCategorySettings src)
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
		public void SetAttachMasterInstance(AudioMasterSettings master)
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x8AB850", Offset = "0x8AAA50", VA = "0x1808AB850")]
		public float GetVolumeFactor()
		{
			return default(float);
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x8A9B10", Offset = "0x8A8D10", VA = "0x1808A9B10")]
		public float GetCurrentVolume()
		{
			return default(float);
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x8AB900", Offset = "0x8AAB00", VA = "0x1808AB900")]
		public void SetVolumeUpdater(float start, float target, float time)
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x8AB890", Offset = "0x8AAA90", VA = "0x1808AB890")]
		public void SetDuckingVolumeUpdater(float target, float time, bool isLow)
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x8AB7C0", Offset = "0x8AA9C0", VA = "0x1808AB7C0")]
		public void ClearVolumeUpdater()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x8AB9B0", Offset = "0x8AABB0", VA = "0x1808AB9B0")]
		public bool UpdateVolume()
		{
			return default(bool);
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x8AB970", Offset = "0x8AAB70", VA = "0x1808AB970")]
		public bool UpdateDuckingVolume()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20000E8")]
	private class AudioDebugLog
	{
		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool isActive;

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x8ABAC0", Offset = "0x8AACC0", VA = "0x1808ABAC0")]
		public static void Break()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x8ABF70", Offset = "0x8AB170", VA = "0x1808ABF70")]
		public static void Log(object message)
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x8ABEB0", Offset = "0x8AB0B0", VA = "0x1808ABEB0")]
		public static void Log(object message, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x8ABC90", Offset = "0x8AAE90", VA = "0x1808ABC90")]
		public static void LogError(object message)
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x8ABBD0", Offset = "0x8AADD0", VA = "0x1808ABBD0")]
		public static void LogError(object message, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x8ABE00", Offset = "0x8AB000", VA = "0x1808ABE00")]
		public static void LogWarning(object message)
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x8ABD40", Offset = "0x8AAF40", VA = "0x1808ABD40")]
		public static void LogWarning(object message, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x8ABB60", Offset = "0x8AAD60", VA = "0x1808ABB60")]
		private static bool IsEnable()
		{
			return default(bool);
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public AudioDebugLog()
		{
		}
	}

	[Token(Token = "0x20000E9")]
	private class AudioInstance
	{
		[Token(Token = "0x20000EA")]
		private enum FADE_END_STATE
		{
			[Token(Token = "0x4000586")]
			UNSET,
			[Token(Token = "0x4000587")]
			PAUSE,
			[Token(Token = "0x4000588")]
			STOP
		}

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool isAudioDebug;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AudioLabelSettings setting;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AudioSource source;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform sourceTransform;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float defaultVolume;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float defaultPan;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int defaultPitch;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int currentPitch;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float currentVolume;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float volumeFactor;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float ctrlVolumeFactor;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private AudioParamUpdater volumeUpdater;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private AudioParamUpdater panUpdater;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioParamUpdater pitchUpdater;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private AudioParamUpdater controlUpdater;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int prevPlaySamples;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private bool onPause;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int randomIndex;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int instanceId;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool activeSelf;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private FADE_END_STATE fadeStatus;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AudioDefine.INSTANCE_STATUS status;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Transform targetTransform;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 defaultPos;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool isUpdateStart;

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x449850", Offset = "0x448A50", VA = "0x180449850")]
		public void SetActive(bool active)
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x55E610", Offset = "0x55D810", VA = "0x18055E610")]
		public void SetInstanceID(int id)
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x55E5F0", Offset = "0x55D7F0", VA = "0x18055E5F0")]
		public int GetInstanceID()
		{
			return default(int);
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x8AD880", Offset = "0x8ACA80", VA = "0x1808AD880")]
		public void Reset(AudioMainPool pool)
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x55E5E0", Offset = "0x55D7E0", VA = "0x18055E5E0")]
		public int GetRandomIndex()
		{
			return default(int);
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x8ACC60", Offset = "0x8ABE60", VA = "0x1808ACC60")]
		public void Init(AudioSource playSource, float factor, int index)
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x8ACB80", Offset = "0x8ABD80", VA = "0x1808ACB80")]
		public void Init(AudioSource playSource, AudioLabelSettings labelInfo, float factor, int index)
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x8AE3D0", Offset = "0x8AD5D0", VA = "0x1808AE3D0")]
		public void UpdateVolumeFactor(float factor)
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x8AE4A0", Offset = "0x8AD6A0", VA = "0x1808AE4A0")]
		public void Update()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x8AD850", Offset = "0x8ACA50", VA = "0x1808AD850")]
		public void ResetPlayPosition()
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x8AD290", Offset = "0x8AC490", VA = "0x1808AD290")]
		public void Prepare(float volume, float fadeTime, float pan, int pitch, int playStartSample)
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x8AD0F0", Offset = "0x8AC2F0", VA = "0x1808AD0F0")]
		public void Play(float delay)
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x8ADFA0", Offset = "0x8AD1A0", VA = "0x1808ADFA0")]
		public void Stop(float fadeTime)
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x8AC900", Offset = "0x8ABB00", VA = "0x1808AC900")]
		public void ForceStop()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x8ACFC0", Offset = "0x8AC1C0", VA = "0x1808ACFC0")]
		public void OnPause(float fadeTime)
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x8ACE00", Offset = "0x8AC000", VA = "0x1808ACE00")]
		public void OffPause(float fadeTime)
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x8ADEC0", Offset = "0x8AD0C0", VA = "0x1808ADEC0")]
		public void SetVolume(float newVolume, float moveTime)
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x8A9B10", Offset = "0x8A8D10", VA = "0x1808A9B10")]
		public float GetCurrentVolume()
		{
			return default(float);
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x8AC990", Offset = "0x8ABB90", VA = "0x1808AC990")]
		public float GetCalcVolume()
		{
			return default(float);
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x8ADAE0", Offset = "0x8ACCE0", VA = "0x1808ADAE0")]
		public void SetPitch(int newPitch, float moveTime)
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x8AD9F0", Offset = "0x8ACBF0", VA = "0x1808AD9F0")]
		public void SetPan(float newPan, float moveTime)
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x8ADD50", Offset = "0x8ACF50", VA = "0x1808ADD50")]
		public void SetTrackingObject(GameObject target)
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x8ADDD0", Offset = "0x8ACFD0", VA = "0x1808ADDD0")]
		public void SetTrackingObject(Transform target)
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x8ADBB0", Offset = "0x8ACDB0", VA = "0x1808ADBB0")]
		public void SetPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x8ACD80", Offset = "0x8ABF80", VA = "0x1808ACD80")]
		public bool IsPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x865350", Offset = "0x864550", VA = "0x180865350")]
		public AudioDefine.INSTANCE_STATUS GetStatus()
		{
			return default(AudioDefine.INSTANCE_STATUS);
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x803CC0", Offset = "0x802EC0", VA = "0x180803CC0")]
		public int GetPrevPlaySamples()
		{
			return default(int);
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x8ACA40", Offset = "0x8ABC40", VA = "0x1808ACA40")]
		public float GetPlayTime()
		{
			return default(float);
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x8AC9B0", Offset = "0x8ABBB0", VA = "0x1808AC9B0")]
		public int GetPlaySamples()
		{
			return default(int);
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x8ADCA0", Offset = "0x8ACEA0", VA = "0x1808ADCA0")]
		public void SetTime(float time)
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x8ADBF0", Offset = "0x8ACDF0", VA = "0x1808ADBF0")]
		public void SetTimeSamples(int samples)
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x8ACAD0", Offset = "0x8ABCD0", VA = "0x1808ACAD0")]
		public bool GetSpectrumData(int instanceId, float[] sample, int channel, FFTWindow window)
		{
			return default(bool);
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x8AEEF0", Offset = "0x8AE0F0", VA = "0x1808AEEF0")]
		private void setupVolume(float volume, float fadeTime, bool isPlayLastSamples)
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x8AEC60", Offset = "0x8ADE60", VA = "0x1808AEC60")]
		private void setupPitch(int pitch)
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x8AEDB0", Offset = "0x8ADFB0", VA = "0x1808AEDB0")]
		private void setupStereoPan(float pan)
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x8AEAB0", Offset = "0x8ADCB0", VA = "0x1808AEAB0")]
		private float getRandomValue(float min, float max, float unit, bool isconsecutive, float prevValue)
		{
			return default(float);
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x8AEA20", Offset = "0x8ADC20", VA = "0x1808AEA20")]
		private float calcPitchRatio(int cent)
		{
			return default(float);
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x8AE200", Offset = "0x8AD400", VA = "0x1808AE200")]
		public void UpdateAudio3DSettings(Audio3DSettings audio3d)
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x8AE8C0", Offset = "0x8ADAC0", VA = "0x1808AE8C0")]
		public AudioInstance()
		{
		}
	}

	[Token(Token = "0x20000EB")]
	private class AudioInstancePool
	{
		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static AudioInstancePool _instance;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int instanceIdNext;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<AudioInstance> pool;

		[Token(Token = "0x17000073")]
		public static AudioInstancePool instance
		{
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x8AC8B0", Offset = "0x8ABAB0", VA = "0x1808AC8B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x8AC650", Offset = "0x8AB850", VA = "0x1808AC650")]
		public static void Initialize()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x8AC440", Offset = "0x8AB640", VA = "0x1808AC440")]
		public void AddEmpty(int num)
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x8AC250", Offset = "0x8AB450", VA = "0x1808AC250")]
		public AudioInstance AddComponent()
		{
			return null;
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x8AC630", Offset = "0x8AB830", VA = "0x1808AC630")]
		public void Deactive(AudioInstance instance)
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x8AC550", Offset = "0x8AB750", VA = "0x1808AC550")]
		public void Clear()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x8AC7F0", Offset = "0x8AB9F0", VA = "0x1808AC7F0")]
		public AudioInstancePool()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20000EC")]
	public class AudioLabelSettings
	{
		[Token(Token = "0x20000ED")]
		public enum BEHAVIOR
		{
			[Token(Token = "0x40005C7")]
			STEAL_OLDEST,
			[Token(Token = "0x40005C8")]
			JUST_FAIL,
			[Token(Token = "0x40005C9")]
			QUEUE
		}

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float volume;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public BEHAVIOR maxPlaybacksBehavior;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int priority;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string categoryName;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string singleGroup;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int maxPlaybacksNum;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool isStealOldest;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string unityMixerName;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string spatialGroup;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float playStartDelay;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float playInterval;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float pan;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int pitchShiftCent;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool isPlayLastSamples;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float fadeInTime;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float fadeOutTime;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float fadeInTimeOldSamples;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float fadeOutTimeOnPause;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float fadeInTimeOffPause;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool isVolumeRandom;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		public bool inconsecutiveVolume;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float volumeRandomMin;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float volumeRandomMax;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float volumeRandomUnit;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool isPitchRandom;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		public bool inconsecutivePitch;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public int pitchRandomMin;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public int pitchRandomMax;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public int pitchRandomUnit;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool isPanRandom;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		public bool inconsecutivePan;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float panRandomMin;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float panRandomMax;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float panRandomUnit;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool isRandomPlay;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool inconsecutiveSource;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string[] randomSource;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool isMovePitch;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public int pitchStart;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public int pitchEnd;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float pitchMoveTime;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool isMovePan;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float panStart;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float panEnd;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float panMoveTime;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public string[] duckingCategories;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float duckingStartTime;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float duckingEndTime;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float duckingVolumeFactor;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public bool autoRestoreDucking;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public float restoreTime;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public bool isAndroidNative;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private int androidSoundId;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public int loadId;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public string name;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private AudioCategorySettings attachCategory;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public string clipName;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public bool isLoop;

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x8AF080", Offset = "0x8AE280", VA = "0x1808AF080")]
		public void SetAndroidSoundId(int soundId)
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x764490", Offset = "0x763690", VA = "0x180764490")]
		public int GetAndroidSoundId()
		{
			return default(int);
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x8AF090", Offset = "0x8AE290", VA = "0x1808AF090")]
		public void SetLoop(bool loop)
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x8AF070", Offset = "0x8AE270", VA = "0x1808AF070")]
		public bool GetLoop()
		{
			return default(bool);
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x5FC6A0", Offset = "0x5FB8A0", VA = "0x1805FC6A0")]
		public void SetClipName(string name)
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x5FC5F0", Offset = "0x5FB7F0", VA = "0x1805FC5F0")]
		public string GetClipName()
		{
			return null;
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x5968C0", Offset = "0x595AC0", VA = "0x1805968C0")]
		public void SetAttachCategoryInstance(AudioCategorySettings category)
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x5FC5E0", Offset = "0x5FB7E0", VA = "0x1805FC5E0")]
		public AudioCategorySettings GetAttachCategory()
		{
			return null;
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		public string GetCategoryName()
		{
			return null;
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x8AF0A0", Offset = "0x8AE2A0", VA = "0x1808AF0A0")]
		public AudioLabelSettings()
		{
		}
	}

	[Token(Token = "0x20000EE")]
	private class AudioMainPool : MonoBehaviour
	{
		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<AudioSource> pool;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static AudioMainPool _instance;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static GameObject owner;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Transform _cacheTransform;

		[Token(Token = "0x17000074")]
		private static Transform CacheTransform
		{
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x8AF870", Offset = "0x8AEA70", VA = "0x1808AF870")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000075")]
		public static AudioMainPool instance
		{
			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x8AF950", Offset = "0x8AEB50", VA = "0x1808AF950")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x8AF590", Offset = "0x8AE790", VA = "0x1808AF590")]
		public static void Initialize(GameObject obj)
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x8AF680", Offset = "0x8AE880", VA = "0x1808AF680")]
		public static void Terminate()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x8AF0D0", Offset = "0x8AE2D0", VA = "0x1808AF0D0")]
		public void AddEmpty(int num)
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x8AF3F0", Offset = "0x8AE5F0", VA = "0x1808AF3F0")]
		public AudioSource GetClone()
		{
			return null;
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x8AF3A0", Offset = "0x8AE5A0", VA = "0x1808AF3A0")]
		public void Deactive(AudioSource source)
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x8AF250", Offset = "0x8AE450", VA = "0x1808AF250")]
		public void Clear()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x8AF7B0", Offset = "0x8AE9B0", VA = "0x1808AF7B0")]
		public AudioMainPool()
		{
		}
	}

	[Token(Token = "0x20000EF")]
	private enum RESULT
	{
		[Token(Token = "0x40005CF")]
		CONTINUE,
		[Token(Token = "0x40005D0")]
		EXECUTE,
		[Token(Token = "0x40005D1")]
		FINISH
	}

	[Serializable]
	[Token(Token = "0x20000F0")]
	private class Wrapper<T>
	{
		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T[] master;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T[] category;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T[] label;

		[Token(Token = "0x60005BC")]
		public Wrapper()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20000F1")]
	private class AudioSourceWrapper
	{
		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string spatialName;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float spatialBlend;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1.1f)]
		public float reverbZoneMix;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 5f)]
		public float dopplerLevel;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 360f)]
		public int spread;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioRolloffMode rolloffMode;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float minDistance;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float maxDistance;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve customRolloffCurve;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve spatialBlendCurve;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve reverbZoneMixCurve;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve spreadCurve;

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x8B4250", Offset = "0x8B3450", VA = "0x1808B4250")]
		public AudioSourceWrapper()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20000F2")]
	public class AudioMasterSettings
	{
		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string masterName;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float volume;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AudioParamUpdater volumeUpdater;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float programVolume;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float mute;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float manner;

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x8AFB40", Offset = "0x8AED40", VA = "0x1808AFB40")]
		public AudioMasterSettings()
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x8AF9C0", Offset = "0x8AEBC0", VA = "0x1808AF9C0")]
		public void CopySettings(AudioMasterSettings src)
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x649DB0", Offset = "0x648FB0", VA = "0x180649DB0")]
		public float GetCurrentVolume()
		{
			return default(float);
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x8AFA10", Offset = "0x8AEC10", VA = "0x1808AFA10")]
		public float GetVolumeFactor()
		{
			return default(float);
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x8AFA90", Offset = "0x8AEC90", VA = "0x1808AFA90")]
		public void SetVolumeUpdater(float start, float target, float time)
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x8AF990", Offset = "0x8AEB90", VA = "0x1808AF990")]
		public void ClearVolumeUpdater()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x8AFB00", Offset = "0x8AED00", VA = "0x1808AFB00")]
		public bool UpdateVolume()
		{
			return default(bool);
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x8AFA60", Offset = "0x8AEC60", VA = "0x1808AFA60")]
		public void SetMute(bool onMute)
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x8AFA30", Offset = "0x8AEC30", VA = "0x1808AFA30")]
		public void SetMannerMode(bool onMute)
		{
		}
	}

	[Token(Token = "0x20000F3")]
	private class AudioMixerSettings
	{
		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioMixer mixer;

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
		public void SetAudioMixer(AudioMixer _mixer)
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x8AFBE0", Offset = "0x8AEDE0", VA = "0x1808AFBE0")]
		public AudioMixerGroup[] FindGroup(string groupName)
		{
			return null;
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x8AFD20", Offset = "0x8AEF20", VA = "0x1808AFD20")]
		public void SetSnapshot(string snapName, float time)
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x8AFC80", Offset = "0x8AEE80", VA = "0x1808AFC80")]
		public void SetFloat(string paramName, float value)
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public AudioMixerSettings()
		{
		}
	}

	[Token(Token = "0x20000F4")]
	private class AudioParamUpdater
	{
		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float target;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float current;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float unit;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float prevTime;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool move;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		private bool _active;

		[Token(Token = "0x17000076")]
		public bool active
		{
			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x5D7890", Offset = "0x5D6A90", VA = "0x1805D7890")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x671010", Offset = "0x670210", VA = "0x180671010")]
			set
			{
			}
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x8AFE00", Offset = "0x8AF000", VA = "0x1808AFE00")]
		public void SetParam(float _start, float _target, float moveTime, bool isLow)
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x8AFE70", Offset = "0x8AF070", VA = "0x1808AFE70")]
		public void UpdateStart()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x8AFEA0", Offset = "0x8AF0A0", VA = "0x1808AFEA0")]
		public float Update()
		{
			return default(float);
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x8AFDF0", Offset = "0x8AEFF0", VA = "0x1808AFDF0")]
		public void Clear()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x8AFF30", Offset = "0x8AF130", VA = "0x1808AFF30")]
		public AudioParamUpdater()
		{
		}
	}

	[Token(Token = "0x20000F5")]
	private class AudioPlayer
	{
		[Token(Token = "0x20000F6")]
		private class PlayData
		{
			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioClip clip;

			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AudioLabelSettings info;

			[Token(Token = "0x6000616")]
			[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
			public PlayData()
			{
			}
		}

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<AudioInstance> playInstance;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<PlayData> playSource;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AudioLabelSettings playSettings;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AudioClip playClip;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool isSetClip;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int prevPlayIndex;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float prevVolumeRandom;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float prevPitchRandom;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float prevPanRandom;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<int> prevPlaySamplesList;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string playerName;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private AudioMixerGroup mixer;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Audio3DSettings spatialSettings;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextInterval;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float prevPlayTime;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool force2D;

		[Token(Token = "0x17000077")]
		public string PlayerName
		{
			[Token(Token = "0x60005D4")]
			[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
			set
			{
			}
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x81BD60", Offset = "0x81AF60", VA = "0x18081BD60")]
		public void SetAudioMixerGroup(AudioMixerGroup _mixer)
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x8B2CA0", Offset = "0x8B1EA0", VA = "0x1808B2CA0")]
		public void UpdateRandomSourceInfo(Dictionary<string, AudioPlayer> dict)
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		public AudioClip GetPlayClip()
		{
			return null;
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x51FEA0", Offset = "0x51F0A0", VA = "0x18051FEA0")]
		public bool IsSetPlayClip()
		{
			return default(bool);
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x8B1E30", Offset = "0x8B1030", VA = "0x1808B1E30")]
		public void SetPlayClip(AudioClip clip)
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x8B0090", Offset = "0x8AF290", VA = "0x1808B0090")]
		public float GetClipLength()
		{
			return default(float);
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x8B0120", Offset = "0x8AF320", VA = "0x1808B0120")]
		public int GetClipSamples()
		{
			return default(int);
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x8B07A0", Offset = "0x8AF9A0", VA = "0x1808B07A0")]
		public bool Init(AudioClip clip, string name, AudioLabelSettings label, Dictionary<string, AudioPlayer> dict)
		{
			return default(bool);
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x8B3630", Offset = "0x8B2830", VA = "0x1808B3630")]
		private void initRandomSettins()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x8B14B0", Offset = "0x8B06B0", VA = "0x1808B14B0")]
		public void ResetPlayClip()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x8B1620", Offset = "0x8B0820", VA = "0x1808B1620")]
		public void Reset()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x8B0CA0", Offset = "0x8AFEA0", VA = "0x1808B0CA0")]
		public void LoadAudioData()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x8B2AE0", Offset = "0x8B1CE0", VA = "0x1808B2AE0")]
		public void UnloadAudioData()
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x8B3480", Offset = "0x8B2680", VA = "0x1808B3480")]
		private float getRandomValue(float min, float max, float unit, bool isconsecutive, float prevValue)
		{
			return default(float);
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x8B1590", Offset = "0x8B0790", VA = "0x1808B1590")]
		public void ResetPlayPosition()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x8B0580", Offset = "0x8AF780", VA = "0x1808B0580")]
		public int GetPlayingNum()
		{
			return default(int);
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x8B0640", Offset = "0x8AF840", VA = "0x1808B0640")]
		public int GetPlayingTrueNum()
		{
			return default(int);
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x8B0360", Offset = "0x8AF560", VA = "0x1808B0360")]
		public int GetMaxPlaybacksNum()
		{
			return default(int);
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x8B0C80", Offset = "0x8AFE80", VA = "0x1808B0C80")]
		public bool IsStealOldest()
		{
			return default(bool);
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x8B0040", Offset = "0x8AF240", VA = "0x1808B0040")]
		public string GetCategoryName()
		{
			return null;
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x8B0010", Offset = "0x8AF210", VA = "0x1808B0010")]
		public int GetCategoryMaxPlaybacksNum()
		{
			return default(int);
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x8B0680", Offset = "0x8AF880", VA = "0x1808B0680")]
		public int GetPriority()
		{
			return default(int);
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x8B0340", Offset = "0x8AF540", VA = "0x1808B0340")]
		public AudioLabelSettings.BEHAVIOR GetMaxPlaybacksBehavior()
		{
			return default(AudioLabelSettings.BEHAVIOR);
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x8B0260", Offset = "0x8AF460", VA = "0x1808B0260")]
		public float GetFadeOutTime()
		{
			return default(float);
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x8B0070", Offset = "0x8AF270", VA = "0x1808B0070")]
		public AudioCategorySettings GetCategorySettings()
		{
			return null;
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		public AudioLabelSettings GetLabelSettings()
		{
			return null;
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x8B0280", Offset = "0x8AF480", VA = "0x1808B0280")]
		public AudioDefine.INSTANCE_STATUS GetInstanceStatus(int instanceId)
		{
			return default(AudioDefine.INSTANCE_STATUS);
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x8B2930", Offset = "0x8B1B30", VA = "0x1808B2930")]
		public void StopOldInstance()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x8B3700", Offset = "0x8B2900", VA = "0x1808B3700")]
		private int prepareImpl(float volume, float fadeTime, float pan, int pitch, float delay, bool isStart, bool isForce2D)
		{
			return default(int);
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x8B1470", Offset = "0x8B0670", VA = "0x1808B1470")]
		public int Prepare(float volume, float fadeTime, float pan, int pitch, bool isForce2D)
		{
			return default(int);
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x8B1420", Offset = "0x8B0620", VA = "0x1808B1420")]
		public int Play(float volume, float fadeTime, float pan, int pitch, float delay, bool isForce2D)
		{
			return default(int);
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x8B1360", Offset = "0x8B0560", VA = "0x1808B1360")]
		public void PlayInstance(int instanceId, float delay = 0f)
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x8B22F0", Offset = "0x8B14F0", VA = "0x1808B22F0")]
		public void SetTrackingObject(int instanceId, GameObject target)
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x8B2240", Offset = "0x8B1440", VA = "0x1808B2240")]
		public void SetTrackingObject(int instanceId, Transform target)
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x8B2A30", Offset = "0x8B1C30", VA = "0x1808B2A30")]
		public void Stop(int instanceId, float fadeTime = -1f)
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x8B2610", Offset = "0x8B1810", VA = "0x1808B2610")]
		public void StopAll(float fadeTime = -1f)
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x8B12B0", Offset = "0x8B04B0", VA = "0x1808B12B0")]
		public void OnPause(int instanceId, float fadeTime = -1f)
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x8B10D0", Offset = "0x8B02D0", VA = "0x1808B10D0")]
		public void OnPauseAll(float fadeTime = -1f)
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x8B1020", Offset = "0x8B0220", VA = "0x1808B1020")]
		public void OffPause(int instanceId, float fadeTime = -1f)
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x8B0D90", Offset = "0x8AFF90", VA = "0x1808B0D90")]
		public void OffPauseAll(float fadeTime = -1f)
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x8B2540", Offset = "0x8B1740", VA = "0x1808B2540")]
		public void SetVolume(int instanceId, float newVolume, float moveTime)
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x8B01A0", Offset = "0x8AF3A0", VA = "0x1808B01A0")]
		public float GetCurrentVolume(int instanceId)
		{
			return default(float);
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x8AFF50", Offset = "0x8AF150", VA = "0x1808AFF50")]
		public float GetCalcVolume(int instanceId)
		{
			return default(float);
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x8B23A0", Offset = "0x8B15A0", VA = "0x1808B23A0")]
		public void SetVolumeAll(float newVolume, float moveTime)
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x8B1D60", Offset = "0x8B0F60", VA = "0x1808B1D60")]
		public void SetPitch(int instanceId, int newPitch, float moveTime)
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x8B1BD0", Offset = "0x8B0DD0", VA = "0x1808B1BD0")]
		public void SetPitchAll(int newPitch, float moveTime)
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x8B1B00", Offset = "0x8B0D00", VA = "0x1808B1B00")]
		public void SetPan(int instanceId, float newPan, float moveTime)
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x8B1930", Offset = "0x8B0B30", VA = "0x1808B1930")]
		public void SetPanAll(float newPan, float moveTime)
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x8B1FB0", Offset = "0x8B11B0", VA = "0x1808B1FB0")]
		public void SetPosition(int instanceId, Vector3 position)
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x8B1EF0", Offset = "0x8B10F0", VA = "0x1808B1EF0")]
		public void SetPositionAll(Vector3 position)
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x8B2F80", Offset = "0x8B2180", VA = "0x1808B2F80")]
		public void UpdateVolumeFactor(float volumeFactor)
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x8B0440", Offset = "0x8AF640", VA = "0x1808B0440")]
		public float GetPlayTime(int instanceId)
		{
			return default(float);
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x8B0500", Offset = "0x8AF700", VA = "0x1808B0500")]
		public float GetPlayTime()
		{
			return default(float);
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x8B0380", Offset = "0x8AF580", VA = "0x1808B0380")]
		public int GetPlaySamples(int instanceId)
		{
			return default(int);
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x8B2130", Offset = "0x8B1330", VA = "0x1808B2130")]
		public void SetTime(int instanceId, float time)
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x8B2080", Offset = "0x8B1280", VA = "0x1808B2080")]
		public void SetTimeSamples(int instanceId, int samples)
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x8B06C0", Offset = "0x8AF8C0", VA = "0x1808B06C0")]
		public bool GetSpectrumData(int instanceId, float[] sample, int channel, FFTWindow window)
		{
			return default(bool);
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x8B30E0", Offset = "0x8B22E0", VA = "0x1808B30E0")]
		public void Update()
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x8B06A0", Offset = "0x8AF8A0", VA = "0x1808B06A0")]
		public string GetSpatialGroup()
		{
			return null;
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x8B0C20", Offset = "0x8AFE20", VA = "0x1808B0C20")]
		public bool IsSetSpatialGroup()
		{
			return default(bool);
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
		public void SetAudio3DSettings(Audio3DSettings setting)
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x8B0BA0", Offset = "0x8AFDA0", VA = "0x1808B0BA0")]
		public bool IsPlayInterval()
		{
			return default(bool);
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x8B4200", Offset = "0x8B3400", VA = "0x1808B4200")]
		private void setInterval()
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x8B2BF0", Offset = "0x8B1DF0", VA = "0x1808B2BF0")]
		public void UpdateAudio3DSettings(Audio3DSettings settings)
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x8B3350", Offset = "0x8B2550", VA = "0x1808B3350")]
		public AudioPlayer()
		{
		}
	}

	[Token(Token = "0x20000F7")]
	private class AudioXmlLoad
	{
		[Token(Token = "0x6000617")]
		[Address(RVA = "0x8B46F0", Offset = "0x8B38F0", VA = "0x1808B46F0")]
		public static XmlDocument Load(Stream xml)
		{
			return null;
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x8B4490", Offset = "0x8B3690", VA = "0x1808B4490")]
		public static XmlDocument Load(Stream xsd, Stream xml)
		{
			return null;
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x8B42D0", Offset = "0x8B34D0", VA = "0x1808B42D0")]
		private static void DebugParse(XmlDocument xmlDoc)
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x8B4840", Offset = "0x8B3A40", VA = "0x1808B4840")]
		private static void OutputXml(XmlDocument xmlDoc)
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
		private static void ValidationCallback(object sender, ValidationEventArgs args)
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public AudioXmlLoad()
		{
		}
	}

	[Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class _003CloadCategoryXmlCoroutine_003Ed__221 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Stream xsd;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Stream xml;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioManager _003C_003E4__this;

		[Token(Token = "0x17000078")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000620")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000622")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CloadCategoryXmlCoroutine_003Ed__221(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x8C4D60", Offset = "0x8C3F60", VA = "0x1808C4D60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x8C5350", Offset = "0x8C4550", VA = "0x1808C5350", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class _003CloadJsonImpl_003Ed__172 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioManager _003C_003E4__this;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string tableData;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int loadId;

		[Token(Token = "0x1700007A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000626")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000628")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CloadJsonImpl_003Ed__172(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x8C5390", Offset = "0x8C4590", VA = "0x1808C5390", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x8C55D0", Offset = "0x8C47D0", VA = "0x1808C55D0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class _003CloadLabelXmlCoroutine_003Ed__223 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Stream xsd;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Stream xml;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioManager _003C_003E4__this;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int loadId;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private XmlNodeList _003CnodeList_003E5__2;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _003Ci_003E5__3;

		[Token(Token = "0x1700007C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600062C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600062E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CloadLabelXmlCoroutine_003Ed__223(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x8C5610", Offset = "0x8C4810", VA = "0x1808C5610", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x8C7BD0", Offset = "0x8C6DD0", VA = "0x1808C7BD0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class _003CloadMasterXmlCoroutine_003Ed__218 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Stream xsd;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Stream xml;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioManager _003C_003E4__this;

		[Token(Token = "0x1700007E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000632")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000634")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CloadMasterXmlCoroutine_003Ed__218(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x8C7C10", Offset = "0x8C6E10", VA = "0x1808C7C10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x8C80F0", Offset = "0x8C72F0", VA = "0x1808C80F0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400054B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static AudioManager manager;

	[Token(Token = "0x400054C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool IsOnMute;

	[Token(Token = "0x400054D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int AndroidSoundPoolNum;

	[Token(Token = "0x400054E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<string, AudioPlayer> sourceDict;

	[Token(Token = "0x400054F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<int, AudioPlayer> playAudioDict;

	[Token(Token = "0x4000550")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dictionary<string, List<int>> playCategoryDict;

	[Token(Token = "0x4000551")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Dictionary<string, AudioCategorySettings> categoryDict;

	[Token(Token = "0x4000552")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Dictionary<string, AudioMasterSettings> masterDict;

	[Token(Token = "0x4000553")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Dictionary<string, List<string>> playDuckingTrigger;

	[Token(Token = "0x4000554")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<int> playAudioRemoveKey;

	[Token(Token = "0x4000555")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private HashSet<AudioPlayer> playerHashSet;

	[Token(Token = "0x4000556")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Dictionary<string, AudioClip> audioClipDict;

	[Token(Token = "0x4000557")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Dictionary<string, Audio3DSettings> audio3DSettings;

	[Token(Token = "0x4000558")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private AudioMixerSettings mixerSettings;

	[Token(Token = "0x4000559")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Transform _cacheTransform;

	[Token(Token = "0x400055A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Thread jsonThread;

	[Token(Token = "0x400055B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private bool jsonThreadFlag;

	[Token(Token = "0x400055C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private string jsonStr;

	[Token(Token = "0x400055D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private AudioMasterSettings[] tmpMaster;

	[Token(Token = "0x400055E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private AudioCategorySettings[] tmpCategory;

	[Token(Token = "0x400055F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private AudioLabelSettings[] tmpLabel;

	[Token(Token = "0x4000560")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private AudioDefine.LOAD_XML_STATUS loadXmlStatus;

	[Token(Token = "0x4000561")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private AudioDefine.LOAD_JSON_STATUS loadJsonStatus;

	[Token(Token = "0x17000072")]
	private Transform CacheTransform
	{
		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x78C4C0", Offset = "0x78B6C0", VA = "0x18078C4C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000445")]
	[Address(RVA = "0x782D20", Offset = "0x781F20", VA = "0x180782D20")]
	public static bool IsInitialized()
	{
		return default(bool);
	}

	[Token(Token = "0x6000446")]
	[Address(RVA = "0x782AB0", Offset = "0x781CB0", VA = "0x180782AB0")]
	public static void Initialize(int defaultSampleRate = 0)
	{
	}

	[Token(Token = "0x6000447")]
	[Address(RVA = "0x787950", Offset = "0x786B50", VA = "0x180787950")]
	public static void Terminate()
	{
	}

	[Token(Token = "0x6000448")]
	[Address(RVA = "0x786130", Offset = "0x785330", VA = "0x180786130")]
	public static void SetAudioMixer(AudioMixer mixer)
	{
	}

	[Token(Token = "0x6000449")]
	[Address(RVA = "0x788010", Offset = "0x787210", VA = "0x180788010")]
	public static void UnsetAudioMixer()
	{
	}

	[Token(Token = "0x600044A")]
	[Address(RVA = "0x786F20", Offset = "0x786120", VA = "0x180786F20")]
	public static void SetSnapshot(string snapName, float time)
	{
	}

	[Token(Token = "0x600044B")]
	[Address(RVA = "0x786070", Offset = "0x785270", VA = "0x180786070")]
	public static void SetAudioMixerExposedParam(string paramName, float value)
	{
	}

	[Token(Token = "0x600044C")]
	[Address(RVA = "0x785960", Offset = "0x784B60", VA = "0x180785960")]
	public static void SetAudio3DSettingsFromJson(string jsonStr)
	{
	}

	[Token(Token = "0x600044D")]
	[Address(RVA = "0x785C90", Offset = "0x784E90", VA = "0x180785C90")]
	public static void SetAudio3DSettings(Audio3DSettings setting)
	{
	}

	[Token(Token = "0x600044E")]
	[Address(RVA = "0x785B40", Offset = "0x784D40", VA = "0x180785B40")]
	public static void SetAudio3DSettings(Audio3DSettings[] settings)
	{
	}

	[Token(Token = "0x600044F")]
	[Address(RVA = "0x783250", Offset = "0x782450", VA = "0x180783250")]
	public static bool LoadBinaryTable(byte[] tableData, int loadId = 0)
	{
		return default(bool);
	}

	[Token(Token = "0x6000450")]
	[Address(RVA = "0x783490", Offset = "0x782690", VA = "0x180783490")]
	public static bool LoadJson(string tableData, int loadId = 0)
	{
		return default(bool);
	}

	[Token(Token = "0x6000451")]
	[Address(RVA = "0x780310", Offset = "0x77F510", VA = "0x180780310")]
	public static void AddAudioClip(AudioClip[] clips)
	{
	}

	[Token(Token = "0x6000452")]
	[Address(RVA = "0x780400", Offset = "0x77F600", VA = "0x180780400")]
	public static void AddAudioClip(AudioClip clip)
	{
	}

	[Token(Token = "0x6000453")]
	[Address(RVA = "0x782C40", Offset = "0x781E40", VA = "0x180782C40")]
	public static bool IsExistAudioClip(string clipName)
	{
		return default(bool);
	}

	[Token(Token = "0x6000454")]
	[Address(RVA = "0x7851F0", Offset = "0x7843F0", VA = "0x1807851F0")]
	public static void RemoveAudioClip(string clipName)
	{
	}

	[Token(Token = "0x6000455")]
	[Address(RVA = "0x785130", Offset = "0x784330", VA = "0x180785130")]
	public static void RemoveAudioClipAll()
	{
	}

	[Token(Token = "0x6000456")]
	[Address(RVA = "0x7808F0", Offset = "0x77FAF0", VA = "0x1807808F0")]
	public static bool FindLabel(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x6000457")]
	[Address(RVA = "0x780810", Offset = "0x77FA10", VA = "0x180780810")]
	public static bool FindCategory(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x6000458")]
	[Address(RVA = "0x7809D0", Offset = "0x77FBD0", VA = "0x1807809D0")]
	public static bool FindMaster(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x6000459")]
	[Address(RVA = "0x780560", Offset = "0x77F760", VA = "0x180780560")]
	public static bool CanRemoveLabel(string labelName)
	{
		return default(bool);
	}

	[Token(Token = "0x600045A")]
	[Address(RVA = "0x787DF0", Offset = "0x786FF0", VA = "0x180787DF0")]
	public static bool UnsetAudioClipToLabel(string labelName)
	{
		return default(bool);
	}

	[Token(Token = "0x600045B")]
	[Address(RVA = "0x787D50", Offset = "0x786F50", VA = "0x180787D50")]
	public static void UnsetAudioClipToLabelLoadId(int loadId)
	{
	}

	[Token(Token = "0x600045C")]
	[Address(RVA = "0x787CB0", Offset = "0x786EB0", VA = "0x180787CB0")]
	public static void UnsetAudioClipToLabelAll()
	{
	}

	[Token(Token = "0x600045D")]
	[Address(RVA = "0x785420", Offset = "0x784620", VA = "0x180785420")]
	public static bool RemoveLabel(string labelName)
	{
		return default(bool);
	}

	[Token(Token = "0x600045E")]
	[Address(RVA = "0x785380", Offset = "0x784580", VA = "0x180785380")]
	public static void RemoveLabelLoadId(int loadId)
	{
	}

	[Token(Token = "0x600045F")]
	[Address(RVA = "0x7852E0", Offset = "0x7844E0", VA = "0x1807852E0")]
	public static void RemoveLabelAll()
	{
	}

	[Token(Token = "0x6000460")]
	[Address(RVA = "0x785090", Offset = "0x784290", VA = "0x180785090")]
	public static void RemoveAll()
	{
	}

	[Token(Token = "0x6000461")]
	[Address(RVA = "0x788160", Offset = "0x787360", VA = "0x180788160")]
	public static void UpdateRandomSourceInfo(string labelName)
	{
	}

	[Token(Token = "0x6000462")]
	[Address(RVA = "0x7880C0", Offset = "0x7872C0", VA = "0x1807880C0")]
	public static void UpdateRandomSourceInfoAll()
	{
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0x783160", Offset = "0x782360", VA = "0x180783160")]
	public static void LoadAudioData(string labelName)
	{
	}

	[Token(Token = "0x6000464")]
	[Address(RVA = "0x7830C0", Offset = "0x7822C0", VA = "0x1807830C0")]
	public static void LoadAudioDataLoadId(int loadId)
	{
	}

	[Token(Token = "0x6000465")]
	[Address(RVA = "0x787BC0", Offset = "0x786DC0", VA = "0x180787BC0")]
	public static void UnloadAudioData(string labelName)
	{
	}

	[Token(Token = "0x6000466")]
	[Address(RVA = "0x787A80", Offset = "0x786C80", VA = "0x180787A80")]
	public static void UnloadAudioDataAll()
	{
	}

	[Token(Token = "0x6000467")]
	[Address(RVA = "0x787B20", Offset = "0x786D20", VA = "0x180787B20")]
	public static void UnloadAudioDataLoadId(int loadId)
	{
	}

	[Token(Token = "0x6000468")]
	[Address(RVA = "0x782050", Offset = "0x781250", VA = "0x180782050")]
	public static AudioDefine.LOAD_XML_STATUS GetLoadXmlStatus()
	{
		return default(AudioDefine.LOAD_XML_STATUS);
	}

	[Token(Token = "0x6000469")]
	[Address(RVA = "0x781FB0", Offset = "0x7811B0", VA = "0x180781FB0")]
	public static AudioDefine.LOAD_JSON_STATUS GetLoadJsonStatus()
	{
		return default(AudioDefine.LOAD_JSON_STATUS);
	}

	[Token(Token = "0x600046A")]
	[Address(RVA = "0x7837C0", Offset = "0x7829C0", VA = "0x1807837C0")]
	public static bool LoadMasterXml(Stream xml, [Optional] Stream xsd)
	{
		return default(bool);
	}

	[Token(Token = "0x600046B")]
	[Address(RVA = "0x783310", Offset = "0x782510", VA = "0x180783310")]
	public static bool LoadCategoryXml(Stream xml, [Optional] Stream xsd)
	{
		return default(bool);
	}

	[Token(Token = "0x600046C")]
	[Address(RVA = "0x783640", Offset = "0x782840", VA = "0x180783640")]
	public static bool LoadLabelXml(int loadId, Stream xml, [Optional] Stream xsd)
	{
		return default(bool);
	}

	[Token(Token = "0x600046D")]
	[Address(RVA = "0x786360", Offset = "0x785560", VA = "0x180786360")]
	public static void SetDucking(string categoryName, float targetVolumeFactor, float fadeTime)
	{
	}

	[Token(Token = "0x600046E")]
	[Address(RVA = "0x785570", Offset = "0x784770", VA = "0x180785570")]
	public static void ResetDucking(string categoryName, float fadeTime)
	{
	}

	[Token(Token = "0x600046F")]
	[Address(RVA = "0x7854D0", Offset = "0x7846D0", VA = "0x1807854D0")]
	public static void ResetDuckingAll(float fadeTime)
	{
	}

	[Token(Token = "0x6000470")]
	[Address(RVA = "0x780B50", Offset = "0x77FD50", VA = "0x180780B50")]
	public static void ForceResetDucking(string categoryName, float fadeTime)
	{
	}

	[Token(Token = "0x6000471")]
	[Address(RVA = "0x780AB0", Offset = "0x77FCB0", VA = "0x180780AB0")]
	public static void ForceResetDuckingAll(float fadeTime)
	{
	}

	[Token(Token = "0x6000472")]
	[Address(RVA = "0x784D10", Offset = "0x783F10", VA = "0x180784D10")]
	public static int Play(string labelName, float delay = -1f)
	{
		return default(int);
	}

	[Token(Token = "0x6000473")]
	[Address(RVA = "0x784BE0", Offset = "0x783DE0", VA = "0x180784BE0")]
	public static int PlayOption(string labelName, float volume, float fadeTime, float pan, int pitch, float delay = -1f)
	{
		return default(int);
	}

	[Token(Token = "0x6000474")]
	[Address(RVA = "0x784FB0", Offset = "0x7841B0", VA = "0x180784FB0")]
	public static int Prepare(string labelName)
	{
		return default(int);
	}

	[Token(Token = "0x6000475")]
	[Address(RVA = "0x784E80", Offset = "0x784080", VA = "0x180784E80")]
	public static int PrepareOption(string labelName, float volume, float fadeTime, float pan, int pitch)
	{
		return default(int);
	}

	[Token(Token = "0x6000476")]
	[Address(RVA = "0x784B30", Offset = "0x783D30", VA = "0x180784B30")]
	public static void PlayInstance(int instanceId, float delay = -1f)
	{
	}

	[Token(Token = "0x6000477")]
	[Address(RVA = "0x784940", Offset = "0x783B40", VA = "0x180784940")]
	public static int Play3D(string labelName, GameObject target, float delay = -1f)
	{
		return default(int);
	}

	[Token(Token = "0x6000478")]
	[Address(RVA = "0x7846F0", Offset = "0x7838F0", VA = "0x1807846F0")]
	public static int Play3D(string labelName, Vector3 position, float delay = -1f)
	{
		return default(int);
	}

	[Token(Token = "0x6000479")]
	[Address(RVA = "0x784500", Offset = "0x783700", VA = "0x180784500")]
	public static int Play3D(string labelName, Transform target, float delay = -1f)
	{
		return default(int);
	}

	[Token(Token = "0x600047A")]
	[Address(RVA = "0x784330", Offset = "0x783530", VA = "0x180784330")]
	public static int Play2D(string labelName, float delay = -1f)
	{
		return default(int);
	}

	[Token(Token = "0x600047B")]
	[Address(RVA = "0x7871F0", Offset = "0x7863F0", VA = "0x1807871F0")]
	public static void SetTrackingObject(int instanceId, GameObject target)
	{
	}

	[Token(Token = "0x600047C")]
	[Address(RVA = "0x7872A0", Offset = "0x7864A0", VA = "0x1807872A0")]
	public static void SetTrackingObject(int instanceId, Transform target)
	{
	}

	[Token(Token = "0x600047D")]
	[Address(RVA = "0x7878A0", Offset = "0x786AA0", VA = "0x1807878A0")]
	public static void Stop(int instanceId, float fadeTime = -1f)
	{
	}

	[Token(Token = "0x600047E")]
	[Address(RVA = "0x7876E0", Offset = "0x7868E0", VA = "0x1807876E0")]
	public static void StopLabel(string labelName, float fadeTime = -1f)
	{
	}

	[Token(Token = "0x600047F")]
	[Address(RVA = "0x787590", Offset = "0x786790", VA = "0x180787590")]
	public static void StopAll(float fadeTime = -1f)
	{
	}

	[Token(Token = "0x6000480")]
	[Address(RVA = "0x784280", Offset = "0x783480", VA = "0x180784280")]
	public static void OnPause(int instanceId, float fadeTime = -1f)
	{
	}

	[Token(Token = "0x6000481")]
	[Address(RVA = "0x783F70", Offset = "0x783170", VA = "0x180783F70")]
	public static void OnPauseAll(float fadeTime = -1f)
	{
	}

	[Token(Token = "0x6000482")]
	[Address(RVA = "0x783E40", Offset = "0x783040", VA = "0x180783E40")]
	public static void OffPause(int instanceId, float fadeTime = -1f)
	{
	}

	[Token(Token = "0x6000483")]
	[Address(RVA = "0x783940", Offset = "0x782B40", VA = "0x180783940")]
	public static void OffPauseAll(float fadeTime = -1f)
	{
	}

	[Token(Token = "0x6000484")]
	[Address(RVA = "0x787350", Offset = "0x786550", VA = "0x180787350")]
	public static void SetVolume(int instanceId, float newVolume, float moveTime)
	{
	}

	[Token(Token = "0x6000485")]
	[Address(RVA = "0x787470", Offset = "0x786670", VA = "0x180787470")]
	public static void SetVolume(string labelName, float newVolume, float moveTime)
	{
	}

	[Token(Token = "0x6000486")]
	[Address(RVA = "0x786BC0", Offset = "0x785DC0", VA = "0x180786BC0")]
	public static void SetPitch(int instanceId, int newPitch, float moveTime)
	{
	}

	[Token(Token = "0x6000487")]
	[Address(RVA = "0x786AB0", Offset = "0x785CB0", VA = "0x180786AB0")]
	public static void SetPitch(string labelName, int newPitch, float moveTime)
	{
	}

	[Token(Token = "0x6000488")]
	[Address(RVA = "0x786870", Offset = "0x785A70", VA = "0x180786870")]
	public static void SetPan(int instanceId, float newPan, float moveTime)
	{
	}

	[Token(Token = "0x6000489")]
	[Address(RVA = "0x786990", Offset = "0x785B90", VA = "0x180786990")]
	public static void SetPan(string labelName, float newPan, float moveTime)
	{
	}

	[Token(Token = "0x600048A")]
	[Address(RVA = "0x786E00", Offset = "0x786000", VA = "0x180786E00")]
	public static void SetPosition(int instanceId, Vector3 position)
	{
	}

	[Token(Token = "0x600048B")]
	[Address(RVA = "0x786CE0", Offset = "0x785EE0", VA = "0x180786CE0")]
	public static void SetPosition(string labelName, Vector3 position)
	{
	}

	[Token(Token = "0x600048C")]
	[Address(RVA = "0x785730", Offset = "0x784930", VA = "0x180785730")]
	public static void ResetPlayPosition(string labelName)
	{
	}

	[Token(Token = "0x600048D")]
	[Address(RVA = "0x785690", Offset = "0x784890", VA = "0x180785690")]
	public static void ResetPlayPositionAll()
	{
	}

	[Token(Token = "0x600048E")]
	[Address(RVA = "0x781830", Offset = "0x780A30", VA = "0x180781830")]
	public static float GetInstanceVolume(int instanceId)
	{
		return default(float);
	}

	[Token(Token = "0x600048F")]
	[Address(RVA = "0x781620", Offset = "0x780820", VA = "0x180781620")]
	public static float GetInstanceCalcVolume(int instanceId)
	{
		return default(float);
	}

	[Token(Token = "0x6000490")]
	[Address(RVA = "0x786690", Offset = "0x785890", VA = "0x180786690")]
	public static void SetMasterVolume(string masterName, float volume, float moveTime = 0f)
	{
	}

	[Token(Token = "0x6000491")]
	[Address(RVA = "0x782360", Offset = "0x781560", VA = "0x180782360")]
	public static float GetMasterVolume(string masterName)
	{
		return default(float);
	}

	[Token(Token = "0x6000492")]
	[Address(RVA = "0x786220", Offset = "0x785420", VA = "0x180786220")]
	public static void SetCategoryVolume(string categoryName, float volume, float moveTime = 0f)
	{
	}

	[Token(Token = "0x6000493")]
	[Address(RVA = "0x781450", Offset = "0x780650", VA = "0x180781450")]
	public static float GetCategoryVolume(string categoryName)
	{
		return default(float);
	}

	[Token(Token = "0x6000494")]
	[Address(RVA = "0x781EA0", Offset = "0x7810A0", VA = "0x180781EA0")]
	public static float GetLabelVolume(string labelName)
	{
		return default(float);
	}

	[Token(Token = "0x6000495")]
	[Address(RVA = "0x7877F0", Offset = "0x7869F0", VA = "0x1807877F0")]
	public static void StopMaster(string masterName, float fadeTime = -1f)
	{
	}

	[Token(Token = "0x6000496")]
	[Address(RVA = "0x7841D0", Offset = "0x7833D0", VA = "0x1807841D0")]
	public static void OnPauseMaster(string masterName, float fadeTime = -1f)
	{
	}

	[Token(Token = "0x6000497")]
	[Address(RVA = "0x783D90", Offset = "0x782F90", VA = "0x180783D90")]
	public static void OffPauseMaster(string masterName, float fadeTime = -1f)
	{
	}

	[Token(Token = "0x6000498")]
	[Address(RVA = "0x787630", Offset = "0x786830", VA = "0x180787630")]
	public static void StopCategory(string categoryName, float fadeTime = -1f)
	{
	}

	[Token(Token = "0x6000499")]
	[Address(RVA = "0x7840C0", Offset = "0x7832C0", VA = "0x1807840C0")]
	public static void OnPauseLabel(string labelName, float fadeTime = -1f)
	{
	}

	[Token(Token = "0x600049A")]
	[Address(RVA = "0x783C80", Offset = "0x782E80", VA = "0x180783C80")]
	public static void OffPauseLabel(string labelName, float fadeTime = -1f)
	{
	}

	[Token(Token = "0x600049B")]
	[Address(RVA = "0x784010", Offset = "0x783210", VA = "0x180784010")]
	public static void OnPauseCategory(string categoryName, float fadeTime = -1f)
	{
	}

	[Token(Token = "0x600049C")]
	[Address(RVA = "0x7839E0", Offset = "0x782BE0", VA = "0x1807839E0")]
	public static void OffPauseCategory(string categoryName, float fadeTime = -1f)
	{
	}

	[Token(Token = "0x600049D")]
	[Address(RVA = "0x783A90", Offset = "0x782C90", VA = "0x180783A90")]
	public static void OffPauseCategory(string categoryName, List<int> instanceList, float fadeTime = -1f)
	{
	}

	[Token(Token = "0x600049E")]
	[Address(RVA = "0x781720", Offset = "0x780920", VA = "0x180781720")]
	public static AudioDefine.INSTANCE_STATUS GetInstanceStatus(int instanceId)
	{
		return default(AudioDefine.INSTANCE_STATUS);
	}

	[Token(Token = "0x600049F")]
	[Address(RVA = "0x782FB0", Offset = "0x7821B0", VA = "0x180782FB0")]
	public static bool IsPlayingLabel(string labelName)
	{
		return default(bool);
	}

	[Token(Token = "0x60004A0")]
	[Address(RVA = "0x781CD0", Offset = "0x780ED0", VA = "0x180781CD0")]
	public static int GetLabelNum()
	{
		return default(int);
	}

	[Token(Token = "0x60004A1")]
	[Address(RVA = "0x781C30", Offset = "0x780E30", VA = "0x180781C30")]
	public static string[] GetLabelNameList()
	{
		return null;
	}

	[Token(Token = "0x60004A2")]
	[Address(RVA = "0x781390", Offset = "0x780590", VA = "0x180781390")]
	public static int GetCategoryNum()
	{
		return default(int);
	}

	[Token(Token = "0x60004A3")]
	[Address(RVA = "0x7811E0", Offset = "0x7803E0", VA = "0x1807811E0")]
	public static string[] GetCategoryNameList()
	{
		return null;
	}

	[Token(Token = "0x60004A4")]
	[Address(RVA = "0x7822A0", Offset = "0x7814A0", VA = "0x1807822A0")]
	public static int GetMasterNum()
	{
		return default(int);
	}

	[Token(Token = "0x60004A5")]
	[Address(RVA = "0x7820F0", Offset = "0x7812F0", VA = "0x1807820F0")]
	public static string[] GetMasterNameList()
	{
		return null;
	}

	[Token(Token = "0x60004A6")]
	[Address(RVA = "0x781280", Offset = "0x780480", VA = "0x180781280")]
	public static string GetCategoryNameSettingOfLabel(string labelName)
	{
		return null;
	}

	[Token(Token = "0x60004A7")]
	[Address(RVA = "0x782190", Offset = "0x781390", VA = "0x180782190")]
	public static string GetMasterNameSettingOfCategory(string categoryName)
	{
		return null;
	}

	[Token(Token = "0x60004A8")]
	[Address(RVA = "0x782620", Offset = "0x781820", VA = "0x180782620")]
	public static float GetPlayTime(int instanceId)
	{
		return default(float);
	}

	[Token(Token = "0x60004A9")]
	[Address(RVA = "0x782510", Offset = "0x781710", VA = "0x180782510")]
	public static int GetPlaySamples(int instanceId)
	{
		return default(int);
	}

	[Token(Token = "0x60004AA")]
	[Address(RVA = "0x7870E0", Offset = "0x7862E0", VA = "0x1807870E0")]
	public static void SetTime(int instanceId, float time)
	{
	}

	[Token(Token = "0x60004AB")]
	[Address(RVA = "0x786FE0", Offset = "0x7861E0", VA = "0x180786FE0")]
	public static void SetTimeSamples(int instanceId, int samples)
	{
	}

	[Token(Token = "0x60004AC")]
	[Address(RVA = "0x7867D0", Offset = "0x7859D0", VA = "0x1807867D0")]
	public static void SetMute(bool onMute)
	{
	}

	[Token(Token = "0x60004AD")]
	[Address(RVA = "0x782470", Offset = "0x781670", VA = "0x180782470")]
	public static bool GetMuteStatus()
	{
		return default(bool);
	}

	[Token(Token = "0x60004AE")]
	[Address(RVA = "0x780D80", Offset = "0x77FF80", VA = "0x180780D80")]
	public static string[] GetAudioClipNameLoadId(int loadId)
	{
		return null;
	}

	[Token(Token = "0x60004AF")]
	[Address(RVA = "0x780CE0", Offset = "0x77FEE0", VA = "0x180780CE0")]
	public static string[] GetAudioClipNameAll()
	{
		return null;
	}

	[Token(Token = "0x60004B0")]
	[Address(RVA = "0x780E30", Offset = "0x780030", VA = "0x180780E30")]
	public static string GetAudioClipName(string labelName)
	{
		return null;
	}

	[Token(Token = "0x60004B1")]
	[Address(RVA = "0x780EE0", Offset = "0x7800E0", VA = "0x180780EE0")]
	public static string[] GetAudioClipNames(string labelName)
	{
		return null;
	}

	[Token(Token = "0x60004B2")]
	[Address(RVA = "0x782730", Offset = "0x781930", VA = "0x180782730")]
	public static string[] GetRandomSourceNames(string labelName)
	{
		return null;
	}

	[Token(Token = "0x60004B3")]
	[Address(RVA = "0x785E30", Offset = "0x785030", VA = "0x180785E30")]
	public static void SetAudioClipToLabelLoadId(int loadId)
	{
	}

	[Token(Token = "0x60004B4")]
	[Address(RVA = "0x785D90", Offset = "0x784F90", VA = "0x180785D90")]
	public static void SetAudioClipToLabelAll()
	{
	}

	[Token(Token = "0x60004B5")]
	[Address(RVA = "0x785ED0", Offset = "0x7850D0", VA = "0x180785ED0")]
	public static void SetAudioClipToLabel(string labelName)
	{
	}

	[Token(Token = "0x60004B6")]
	[Address(RVA = "0x785820", Offset = "0x784A20", VA = "0x180785820")]
	public static void SetAndroidNativeToLabel(string labelName, string filePath, string className, string funcName)
	{
	}

	[Token(Token = "0x60004B7")]
	[Address(RVA = "0x780670", Offset = "0x77F870", VA = "0x180780670")]
	public static void ClearObjectPool()
	{
	}

	[Token(Token = "0x60004B8")]
	[Address(RVA = "0x781A20", Offset = "0x780C20", VA = "0x180781A20")]
	public static float GetLabelLength(string labelName)
	{
		return default(float);
	}

	[Token(Token = "0x60004B9")]
	[Address(RVA = "0x781D90", Offset = "0x780F90", VA = "0x180781D90")]
	public static int GetLabelSamples(string labelName)
	{
		return default(int);
	}

	[Token(Token = "0x60004BA")]
	[Address(RVA = "0x782970", Offset = "0x781B70", VA = "0x180782970")]
	public static bool GetSpectrumData(int instanceId, float[] sample, int channel, FFTWindow window)
	{
		return default(bool);
	}

	[Token(Token = "0x60004BB")]
	[Address(RVA = "0x782EA0", Offset = "0x7820A0", VA = "0x180782EA0")]
	public static bool IsLoop(string labelName)
	{
		return default(bool);
	}

	[Token(Token = "0x60004BC")]
	[Address(RVA = "0x781B20", Offset = "0x780D20", VA = "0x180781B20")]
	public static int GetLabelMaxPlaybacksNum(string labelName)
	{
		return default(int);
	}

	[Token(Token = "0x60004BD")]
	[Address(RVA = "0x7810E0", Offset = "0x7802E0", VA = "0x1807810E0")]
	public static int GetCategoryMaxPlaybacksNum(string categoryName)
	{
		return default(int);
	}

	[Token(Token = "0x60004BE")]
	[Address(RVA = "0x780F90", Offset = "0x780190", VA = "0x180780F90")]
	public static int GetCategoryMaxPlaybacksNumFromLabel(string labelName)
	{
		return default(int);
	}

	[Token(Token = "0x60004BF")]
	[Address(RVA = "0x782D90", Offset = "0x781F90", VA = "0x180782D90")]
	public static bool IsInterval(string labelName)
	{
		return default(bool);
	}

	[Token(Token = "0x60004C0")]
	[Address(RVA = "0x781560", Offset = "0x780760", VA = "0x180781560")]
	public static int GetCurrentPlayNum()
	{
		return default(int);
	}

	[Token(Token = "0x60004C2")]
	[Address(RVA = "0x783F60", Offset = "0x783160", VA = "0x180783F60")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60004C3")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void OnApplicationPause(bool status)
	{
	}

	[Token(Token = "0x60004C4")]
	[Address(RVA = "0x783EF0", Offset = "0x7830F0", VA = "0x180783EF0")]
	private void OnApplicationFocus(bool status)
	{
	}

	[Token(Token = "0x60004C5")]
	[Address(RVA = "0x78EC10", Offset = "0x78DE10", VA = "0x18078EC10")]
	private void onHeadsetPlugCallback(string status)
	{
	}

	[Token(Token = "0x60004C6")]
	[Address(RVA = "0x786520", Offset = "0x785720", VA = "0x180786520")]
	private void SetMannerMode(bool onMute)
	{
	}

	[Token(Token = "0x60004C7")]
	[Address(RVA = "0x786480", Offset = "0x785680", VA = "0x180786480")]
	private void SetMannerMode()
	{
	}

	[Token(Token = "0x60004C8")]
	[Address(RVA = "0x7804A0", Offset = "0x77F6A0", VA = "0x1807804A0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004C9")]
	[Address(RVA = "0x792D50", Offset = "0x791F50", VA = "0x180792D50")]
	public void setAudioMixer(AudioMixer mixer)
	{
	}

	[Token(Token = "0x60004CA")]
	[Address(RVA = "0x794AB0", Offset = "0x793CB0", VA = "0x180794AB0")]
	public void unsetAudioMixer()
	{
	}

	[Token(Token = "0x60004CB")]
	[Address(RVA = "0x793500", Offset = "0x792700", VA = "0x180793500")]
	public void setSnapshot(string snapName, float time)
	{
	}

	[Token(Token = "0x60004CC")]
	[Address(RVA = "0x792D30", Offset = "0x791F30", VA = "0x180792D30")]
	public void setAudioMixerExposedParam(string paramName, float value)
	{
	}

	[Token(Token = "0x60004CD")]
	[Address(RVA = "0x7925D0", Offset = "0x7917D0", VA = "0x1807925D0")]
	public void setAudio3DSettingsFromJson(string jsonStr)
	{
	}

	[Token(Token = "0x60004CE")]
	[Address(RVA = "0x792730", Offset = "0x791930", VA = "0x180792730")]
	public void setAudio3DSettings(Audio3DSettings setting)
	{
	}

	[Token(Token = "0x60004CF")]
	[Address(RVA = "0x7927C0", Offset = "0x7919C0", VA = "0x1807927C0")]
	public void setAudio3DSettings(Audio3DSettings[] settings)
	{
	}

	[Token(Token = "0x60004D0")]
	[Address(RVA = "0x78B5A0", Offset = "0x78A7A0", VA = "0x18078B5A0")]
	private string getChunk(byte[] tableData, int startIndex)
	{
		return null;
	}

	[Token(Token = "0x60004D1")]
	[Address(RVA = "0x78CA90", Offset = "0x78BC90", VA = "0x18078CA90")]
	public bool loadBinaryTable(byte[] tableData, int loadId)
	{
		return default(bool);
	}

	[Token(Token = "0x60004D2")]
	[Address(RVA = "0x78C3F0", Offset = "0x78B5F0", VA = "0x18078C3F0")]
	private string getString(byte[] tableData, ref int startIndex)
	{
		return null;
	}

	[Token(Token = "0x60004D3")]
	[Address(RVA = "0x78D110", Offset = "0x78C310", VA = "0x18078D110")]
	public bool loadJson(string tableData, int loadId)
	{
		return default(bool);
	}

	[Token(Token = "0x60004D4")]
	[Address(RVA = "0x78D070", Offset = "0x78C270", VA = "0x18078D070")]
	[IteratorStateMachine(typeof(_003CloadJsonImpl_003Ed__172))]
	private IEnumerator loadJsonImpl(string tableData, int loadId)
	{
		return null;
	}

	[Token(Token = "0x60004D5")]
	[Address(RVA = "0x78C770", Offset = "0x78B970", VA = "0x18078C770")]
	private void jsonParse()
	{
	}

	[Token(Token = "0x60004D6")]
	private T[] MasterFromJson<T>(string json)
	{
		return null;
	}

	[Token(Token = "0x60004D7")]
	private T[] CategoryFromJson<T>(string json)
	{
		return null;
	}

	[Token(Token = "0x60004D8")]
	private T[] LabelFromJson<T>(string json)
	{
		return null;
	}

	[Token(Token = "0x60004D9")]
	[Address(RVA = "0x780710", Offset = "0x77F910", VA = "0x180780710")]
	private Audio3DSettings D3SettingsFromJson(string json)
	{
		return null;
	}

	[Token(Token = "0x60004DA")]
	[Address(RVA = "0x78DC60", Offset = "0x78CE60", VA = "0x18078DC60")]
	private bool loadLabelJson(int loadId)
	{
		return default(bool);
	}

	[Token(Token = "0x60004DB")]
	[Address(RVA = "0x78E110", Offset = "0x78D310", VA = "0x18078E110")]
	private bool loadMasterBinary(byte[] tableData, ref int startIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x60004DC")]
	[Address(RVA = "0x78CCA0", Offset = "0x78BEA0", VA = "0x18078CCA0")]
	private bool loadCategoryBinary(byte[] tableData, ref int startIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x60004DD")]
	[Address(RVA = "0x78D250", Offset = "0x78C450", VA = "0x18078D250")]
	private bool loadLabelBinary(byte[] tableData, ref int startIndex, int loadId, int tableVer)
	{
		return default(bool);
	}

	[Token(Token = "0x60004DE")]
	[Address(RVA = "0x7892A0", Offset = "0x7884A0", VA = "0x1807892A0")]
	public void addCategorySettings(AudioCategorySettings[] list)
	{
	}

	[Token(Token = "0x60004DF")]
	[Address(RVA = "0x789670", Offset = "0x788870", VA = "0x180789670")]
	public bool addCategorySettings(AudioCategorySettings category)
	{
		return default(bool);
	}

	[Token(Token = "0x60004E0")]
	[Address(RVA = "0x7899B0", Offset = "0x788BB0", VA = "0x1807899B0")]
	public void addMasterSettings(AudioMasterSettings[] list)
	{
	}

	[Token(Token = "0x60004E1")]
	[Address(RVA = "0x789AE0", Offset = "0x788CE0", VA = "0x180789AE0")]
	public bool addMasterSettings(AudioMasterSettings master)
	{
		return default(bool);
	}

	[Token(Token = "0x60004E2")]
	[Address(RVA = "0x789070", Offset = "0x788270", VA = "0x180789070")]
	public void addAudioClip(AudioClip[] clips)
	{
	}

	[Token(Token = "0x60004E3")]
	[Address(RVA = "0x7891B0", Offset = "0x7883B0", VA = "0x1807891B0")]
	public void addAudioClip(AudioClip clip)
	{
	}

	[Token(Token = "0x60004E4")]
	[Address(RVA = "0x78C560", Offset = "0x78B760", VA = "0x18078C560")]
	public bool isExistAudioClip(string clipName)
	{
		return default(bool);
	}

	[Token(Token = "0x60004E5")]
	[Address(RVA = "0x7914A0", Offset = "0x7906A0", VA = "0x1807914A0")]
	public void removeAudioClip(string clipName)
	{
	}

	[Token(Token = "0x60004E6")]
	[Address(RVA = "0x791450", Offset = "0x790650", VA = "0x180791450")]
	public void removeAudioClipAll()
	{
	}

	[Token(Token = "0x60004E7")]
	[Address(RVA = "0x78A3B0", Offset = "0x7895B0", VA = "0x18078A3B0")]
	public bool findLabel(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x60004E8")]
	[Address(RVA = "0x78A350", Offset = "0x789550", VA = "0x18078A350")]
	public bool findCategory(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x60004E9")]
	[Address(RVA = "0x78A410", Offset = "0x789610", VA = "0x18078A410")]
	public bool findMaster(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x60004EA")]
	[Address(RVA = "0x789DB0", Offset = "0x788FB0", VA = "0x180789DB0")]
	public bool canRemoveLabel(string labelName)
	{
		return default(bool);
	}

	[Token(Token = "0x60004EB")]
	[Address(RVA = "0x794930", Offset = "0x793B30", VA = "0x180794930")]
	public bool unsetAudioClipToLabel(string labelName)
	{
		return default(bool);
	}

	[Token(Token = "0x60004EC")]
	[Address(RVA = "0x7946B0", Offset = "0x7938B0", VA = "0x1807946B0")]
	public void unsetAudioClipToLabelLoadId(int loadId)
	{
	}

	[Token(Token = "0x60004ED")]
	[Address(RVA = "0x7944C0", Offset = "0x7936C0", VA = "0x1807944C0")]
	public void unsetAudioClipToLabelAll()
	{
	}

	[Token(Token = "0x60004EE")]
	[Address(RVA = "0x791BE0", Offset = "0x790DE0", VA = "0x180791BE0")]
	public bool removeLabel(string labelName)
	{
		return default(bool);
	}

	[Token(Token = "0x60004EF")]
	[Address(RVA = "0x791880", Offset = "0x790A80", VA = "0x180791880")]
	public void removeLabelLoadId(int loadId)
	{
	}

	[Token(Token = "0x60004F0")]
	[Address(RVA = "0x791520", Offset = "0x790720", VA = "0x180791520")]
	public void removeLabelAll()
	{
	}

	[Token(Token = "0x60004F1")]
	[Address(RVA = "0x791390", Offset = "0x790590", VA = "0x180791390")]
	public void removeAll()
	{
	}

	[Token(Token = "0x60004F2")]
	[Address(RVA = "0x78A330", Offset = "0x789530", VA = "0x18078A330")]
	private void deleteAudioSource(AudioPlayer player)
	{
	}

	[Token(Token = "0x60004F3")]
	[Address(RVA = "0x794C10", Offset = "0x793E10", VA = "0x180794C10")]
	public void updateRandomSourceInfo(string labelName)
	{
	}

	[Token(Token = "0x60004F4")]
	[Address(RVA = "0x794AE0", Offset = "0x793CE0", VA = "0x180794AE0")]
	public void updateRandomSourceInfoAll()
	{
	}

	[Token(Token = "0x60004F5")]
	[Address(RVA = "0x78CA10", Offset = "0x78BC10", VA = "0x18078CA10")]
	public void loadAudioData(string labelName)
	{
	}

	[Token(Token = "0x60004F6")]
	[Address(RVA = "0x78C8D0", Offset = "0x78BAD0", VA = "0x18078C8D0")]
	public void loadAudioDataLoadId(int loadId)
	{
	}

	[Token(Token = "0x60004F7")]
	[Address(RVA = "0x794440", Offset = "0x793640", VA = "0x180794440")]
	public void unloadAudioData(string labelName)
	{
	}

	[Token(Token = "0x60004F8")]
	[Address(RVA = "0x7941E0", Offset = "0x7933E0", VA = "0x1807941E0")]
	public void unloadAudioDataAll()
	{
	}

	[Token(Token = "0x60004F9")]
	[Address(RVA = "0x794300", Offset = "0x793500", VA = "0x180794300")]
	public void unloadAudioDataLoadId(int loadId)
	{
	}

	[Token(Token = "0x60004FA")]
	[Address(RVA = "0x793760", Offset = "0x792960", VA = "0x180793760")]
	private void setUnityAudioMixer(AudioPlayer player)
	{
	}

	[Token(Token = "0x60004FB")]
	[Address(RVA = "0x667EF0", Offset = "0x6670F0", VA = "0x180667EF0")]
	public AudioDefine.LOAD_XML_STATUS getLoadXmlStatus()
	{
		return default(AudioDefine.LOAD_XML_STATUS);
	}

	[Token(Token = "0x60004FC")]
	[Address(RVA = "0x667F00", Offset = "0x667100", VA = "0x180667F00")]
	public AudioDefine.LOAD_JSON_STATUS getLoadJsonStatus()
	{
		return default(AudioDefine.LOAD_JSON_STATUS);
	}

	[Token(Token = "0x60004FD")]
	[Address(RVA = "0x78E470", Offset = "0x78D670", VA = "0x18078E470")]
	public bool loadMasterXml(Stream xml, [Optional] Stream xsd)
	{
		return default(bool);
	}

	[Token(Token = "0x60004FE")]
	[Address(RVA = "0x78E3C0", Offset = "0x78D5C0", VA = "0x18078E3C0")]
	[IteratorStateMachine(typeof(_003CloadMasterXmlCoroutine_003Ed__218))]
	private IEnumerator loadMasterXmlCoroutine(Stream xml, Stream xsd)
	{
		return null;
	}

	[Token(Token = "0x60004FF")]
	[Address(RVA = "0x789D30", Offset = "0x788F30", VA = "0x180789D30")]
	private void attachMasterSettings(AudioCategorySettings category)
	{
	}

	[Token(Token = "0x6000500")]
	[Address(RVA = "0x78CF70", Offset = "0x78C170", VA = "0x18078CF70")]
	public bool loadCategoryXml(Stream xml, [Optional] Stream xsd)
	{
		return default(bool);
	}

	[Token(Token = "0x6000501")]
	[Address(RVA = "0x78CEC0", Offset = "0x78C0C0", VA = "0x18078CEC0")]
	[IteratorStateMachine(typeof(_003CloadCategoryXmlCoroutine_003Ed__221))]
	private IEnumerator loadCategoryXmlCoroutine(Stream xml, Stream xsd)
	{
		return null;
	}

	[Token(Token = "0x6000502")]
	[Address(RVA = "0x78E000", Offset = "0x78D200", VA = "0x18078E000")]
	public bool loadLabelXml(int loadId, Stream xml, [Optional] Stream xsd)
	{
		return default(bool);
	}

	[Token(Token = "0x6000503")]
	[Address(RVA = "0x78DF40", Offset = "0x78D140", VA = "0x18078DF40")]
	[IteratorStateMachine(typeof(_003CloadLabelXmlCoroutine_003Ed__223))]
	private IEnumerator loadLabelXmlCoroutine(int loadId, Stream xml, Stream xsd)
	{
		return null;
	}

	[Token(Token = "0x6000504")]
	[Address(RVA = "0x78F2B0", Offset = "0x78E4B0", VA = "0x18078F2B0")]
	private void orderCategoryInstanceList(List<int> playerList)
	{
	}

	[Token(Token = "0x6000505")]
	[Address(RVA = "0x789BE0", Offset = "0x788DE0", VA = "0x180789BE0")]
	private void addPlayInfo(AudioPlayer player, int instanceId)
	{
	}

	[Token(Token = "0x6000506")]
	[Address(RVA = "0x793F60", Offset = "0x793160", VA = "0x180793F60")]
	private void stopSameSingleGroup(string singleGroup, string playLabelName)
	{
	}

	[Token(Token = "0x6000507")]
	[Address(RVA = "0x78A1F0", Offset = "0x7893F0", VA = "0x18078A1F0")]
	private RESULT checkLabelPlaybacksNum(AudioPlayer player)
	{
		return default(RESULT);
	}

	[Token(Token = "0x6000508")]
	[Address(RVA = "0x789E40", Offset = "0x789040", VA = "0x180789E40")]
	private RESULT checkCategoryPlaybacksNum(AudioPlayer player, ref float time, ref bool queueOn)
	{
		return default(RESULT);
	}

	[Token(Token = "0x6000509")]
	[Address(RVA = "0x793910", Offset = "0x792B10", VA = "0x180793910")]
	private void startDucking(AudioPlayer player, int instanceId)
	{
	}

	[Token(Token = "0x600050A")]
	[Address(RVA = "0x792E90", Offset = "0x792090", VA = "0x180792E90")]
	public void setDucking(string categoryName, float targetVolumeFactor, float fadeTime)
	{
	}

	[Token(Token = "0x600050B")]
	[Address(RVA = "0x7922E0", Offset = "0x7914E0", VA = "0x1807922E0")]
	public void resetDucking(string categoryName, float fadeTime)
	{
	}

	[Token(Token = "0x600050C")]
	[Address(RVA = "0x791F50", Offset = "0x791150", VA = "0x180791F50")]
	public void resetDuckingAll(float fadeTime)
	{
	}

	[Token(Token = "0x600050D")]
	[Address(RVA = "0x78A690", Offset = "0x789890", VA = "0x18078A690")]
	public void forceResetDucking(string categoryName, float fadeTime)
	{
	}

	[Token(Token = "0x600050E")]
	[Address(RVA = "0x78A470", Offset = "0x789670", VA = "0x18078A470")]
	public void forceResetDuckingAll(float fadeTime)
	{
	}

	[Token(Token = "0x600050F")]
	[Address(RVA = "0x7905F0", Offset = "0x78F7F0", VA = "0x1807905F0")]
	public int play(string labelName, float delay = -1f)
	{
		return default(int);
	}

	[Token(Token = "0x6000510")]
	[Address(RVA = "0x7906A0", Offset = "0x78F8A0", VA = "0x1807906A0")]
	private int prepareInstance(string labelName, float volume, float fadeTime, float pan, int pitch, float delay, ref AudioPlayer player, ref float time, ref bool queueOn, bool isForce2D)
	{
		return default(int);
	}

	[Token(Token = "0x6000511")]
	[Address(RVA = "0x78FB60", Offset = "0x78ED60", VA = "0x18078FB60")]
	public int playOption(string labelName, float volume, float fadeTime, float pan, int pitch, float delay)
	{
		return default(int);
	}

	[Token(Token = "0x6000512")]
	[Address(RVA = "0x7912E0", Offset = "0x7904E0", VA = "0x1807912E0")]
	public int prepare(string labelName, bool isForce2D = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000513")]
	[Address(RVA = "0x790A50", Offset = "0x78FC50", VA = "0x180790A50")]
	public int prepareOption(string labelName, float volume, float fadeTime, float pan, int pitch, bool isForce2D)
	{
		return default(int);
	}

	[Token(Token = "0x6000514")]
	[Address(RVA = "0x78F8C0", Offset = "0x78EAC0", VA = "0x18078F8C0")]
	public void playInstance(int instanceId, float delay = -1f)
	{
	}

	[Token(Token = "0x6000515")]
	[Address(RVA = "0x78F790", Offset = "0x78E990", VA = "0x18078F790")]
	public int play3D(string labelName, GameObject target, float delay = -1f)
	{
		return default(int);
	}

	[Token(Token = "0x6000516")]
	[Address(RVA = "0x78F4D0", Offset = "0x78E6D0", VA = "0x18078F4D0")]
	public int play3D(string labelName, Vector3 position, float delay = -1f)
	{
		return default(int);
	}

	[Token(Token = "0x6000517")]
	[Address(RVA = "0x78F660", Offset = "0x78E860", VA = "0x18078F660")]
	public int play3D(string labelName, Transform target, float delay = -1f)
	{
		return default(int);
	}

	[Token(Token = "0x6000518")]
	[Address(RVA = "0x78F3C0", Offset = "0x78E5C0", VA = "0x18078F3C0")]
	public int play2D(string labelName, float delay = -1f)
	{
		return default(int);
	}

	[Token(Token = "0x6000519")]
	[Address(RVA = "0x793640", Offset = "0x792840", VA = "0x180793640")]
	public void setTrackingObject(int instanceId, GameObject target)
	{
	}

	[Token(Token = "0x600051A")]
	[Address(RVA = "0x7936D0", Offset = "0x7928D0", VA = "0x1807936D0")]
	public void setTrackingObject(int instanceId, Transform target)
	{
	}

	[Token(Token = "0x600051B")]
	[Address(RVA = "0x794150", Offset = "0x793350", VA = "0x180794150")]
	public void stop(int instanceId, float fadeTime = -1f)
	{
	}

	[Token(Token = "0x600051C")]
	[Address(RVA = "0x793D30", Offset = "0x792F30", VA = "0x180793D30")]
	public void stopLabel(string labelName, float fadeTime = -1f)
	{
	}

	[Token(Token = "0x600051D")]
	[Address(RVA = "0x793AC0", Offset = "0x792CC0", VA = "0x180793AC0")]
	public void stopAll(float fadeTime = -1f)
	{
	}

	[Token(Token = "0x600051E")]
	[Address(RVA = "0x78F220", Offset = "0x78E420", VA = "0x18078F220")]
	public void onPause(int instanceId, float fadeTime = -1f)
	{
	}

	[Token(Token = "0x600051F")]
	[Address(RVA = "0x78ED80", Offset = "0x78DF80", VA = "0x18078ED80")]
	public void onPauseAll(float fadeTime = -1f)
	{
	}

	[Token(Token = "0x6000520")]
	[Address(RVA = "0x78EB80", Offset = "0x78DD80", VA = "0x18078EB80")]
	public void offPause(int instanceId, float fadeTime = -1f)
	{
	}

	[Token(Token = "0x6000521")]
	[Address(RVA = "0x78E570", Offset = "0x78D770", VA = "0x18078E570")]
	public void offPauseAll(float fadeTime = -1f)
	{
	}

	[Token(Token = "0x6000522")]
	[Address(RVA = "0x793870", Offset = "0x792A70", VA = "0x180793870")]
	public void setVolume(int instanceId, float newVolume, float moveTime)
	{
	}

	[Token(Token = "0x6000523")]
	[Address(RVA = "0x7937D0", Offset = "0x7929D0", VA = "0x1807937D0")]
	public void setVolume(string labelName, float newVolume, float moveTime)
	{
	}

	[Token(Token = "0x6000524")]
	[Address(RVA = "0x793320", Offset = "0x792520", VA = "0x180793320")]
	public void setPitch(int instanceId, int newPitch, float moveTime)
	{
	}

	[Token(Token = "0x6000525")]
	[Address(RVA = "0x793280", Offset = "0x792480", VA = "0x180793280")]
	public void setPitch(string labelName, int newPitch, float moveTime)
	{
	}

	[Token(Token = "0x6000526")]
	[Address(RVA = "0x7931E0", Offset = "0x7923E0", VA = "0x1807931E0")]
	public void setPan(int instanceId, float newPan, float moveTime)
	{
	}

	[Token(Token = "0x6000527")]
	[Address(RVA = "0x793140", Offset = "0x792340", VA = "0x180793140")]
	public void setPan(string labelName, float newPan, float moveTime)
	{
	}

	[Token(Token = "0x6000528")]
	[Address(RVA = "0x7933C0", Offset = "0x7925C0", VA = "0x1807933C0")]
	public void setPosition(int instanceId, Vector3 position)
	{
	}

	[Token(Token = "0x6000529")]
	[Address(RVA = "0x793460", Offset = "0x792660", VA = "0x180793460")]
	public void setPosition(string labelName, Vector3 position)
	{
	}

	[Token(Token = "0x600052A")]
	[Address(RVA = "0x7924A0", Offset = "0x7916A0", VA = "0x1807924A0")]
	public void resetPlayPosition(string labelName)
	{
	}

	[Token(Token = "0x600052B")]
	[Address(RVA = "0x792380", Offset = "0x791580", VA = "0x180792380")]
	public void resetPlayPositionAll()
	{
	}

	[Token(Token = "0x600052C")]
	[Address(RVA = "0x78B7C0", Offset = "0x78A9C0", VA = "0x18078B7C0")]
	public float getInstanceVolume(int instanceId)
	{
		return default(float);
	}

	[Token(Token = "0x600052D")]
	[Address(RVA = "0x78B6A0", Offset = "0x78A8A0", VA = "0x18078B6A0")]
	public float getInstanceCalcVolume(int instanceId)
	{
		return default(float);
	}

	[Token(Token = "0x600052E")]
	[Address(RVA = "0x792F40", Offset = "0x792140", VA = "0x180792F40")]
	public void setMasterVolume(string masterName, float volume, float moveTime = 0f)
	{
	}

	[Token(Token = "0x600052F")]
	[Address(RVA = "0x78BFE0", Offset = "0x78B1E0", VA = "0x18078BFE0")]
	public float getMasterVolume(string masterName)
	{
		return default(float);
	}

	[Token(Token = "0x6000530")]
	[Address(RVA = "0x792DD0", Offset = "0x791FD0", VA = "0x180792DD0")]
	public void setCategoryVolume(string categoryName, float volume, float moveTime = 0f)
	{
	}

	[Token(Token = "0x6000531")]
	[Address(RVA = "0x78B510", Offset = "0x78A710", VA = "0x18078B510")]
	public float getCategoryVolume(string categoryName)
	{
		return default(float);
	}

	[Token(Token = "0x6000532")]
	[Address(RVA = "0x78BC60", Offset = "0x78AE60", VA = "0x18078BC60")]
	public float getLabelVolume(string labelName)
	{
		return default(float);
	}

	[Token(Token = "0x6000533")]
	[Address(RVA = "0x793DC0", Offset = "0x792FC0", VA = "0x180793DC0")]
	public void stopMaster(string masterName, float fadeTime = -1f)
	{
	}

	[Token(Token = "0x6000534")]
	[Address(RVA = "0x78F080", Offset = "0x78E280", VA = "0x18078F080")]
	public void onPauseMaster(string masterName, float fadeTime = -1f)
	{
	}

	[Token(Token = "0x6000535")]
	[Address(RVA = "0x78E9E0", Offset = "0x78DBE0", VA = "0x18078E9E0")]
	public void offPauseMaster(string masterName, float fadeTime = -1f)
	{
	}

	[Token(Token = "0x6000536")]
	[Address(RVA = "0x793C00", Offset = "0x792E00", VA = "0x180793C00")]
	public void stopCategory(string categoryName, float fadeTime = -1f)
	{
	}

	[Token(Token = "0x6000537")]
	[Address(RVA = "0x78EFF0", Offset = "0x78E1F0", VA = "0x18078EFF0")]
	public void onPauseLabel(string labelName, float fadeTime = -1f)
	{
	}

	[Token(Token = "0x6000538")]
	[Address(RVA = "0x78E950", Offset = "0x78DB50", VA = "0x18078E950")]
	public void offPauseLabel(string labelName, float fadeTime = -1f)
	{
	}

	[Token(Token = "0x6000539")]
	[Address(RVA = "0x78EEC0", Offset = "0x78E0C0", VA = "0x18078EEC0")]
	public void onPauseCategory(string categoryName, float fadeTime = -1f)
	{
	}

	[Token(Token = "0x600053A")]
	[Address(RVA = "0x78E6B0", Offset = "0x78D8B0", VA = "0x18078E6B0")]
	public void offPauseCategory(string categoryName, float fadeTime = -1f)
	{
	}

	[Token(Token = "0x600053B")]
	[Address(RVA = "0x78E7E0", Offset = "0x78D9E0", VA = "0x18078E7E0")]
	public void offPauseCategory(string categoryName, List<int> instanceList, float fadeTime = -1f)
	{
	}

	[Token(Token = "0x600053C")]
	[Address(RVA = "0x78B730", Offset = "0x78A930", VA = "0x18078B730")]
	public AudioDefine.INSTANCE_STATUS getInstanceStatus(int instanceId)
	{
		return default(AudioDefine.INSTANCE_STATUS);
	}

	[Token(Token = "0x600053D")]
	[Address(RVA = "0x78C6E0", Offset = "0x78B8E0", VA = "0x18078C6E0")]
	public bool isPlayingLabel(string labelName)
	{
		return default(bool);
	}

	[Token(Token = "0x600053E")]
	[Address(RVA = "0x78BB80", Offset = "0x78AD80", VA = "0x18078BB80")]
	public int getLabelNum()
	{
		return default(int);
	}

	[Token(Token = "0x600053F")]
	[Address(RVA = "0x78B970", Offset = "0x78AB70", VA = "0x18078B970")]
	public string[] getLabelNameList()
	{
		return null;
	}

	[Token(Token = "0x6000540")]
	[Address(RVA = "0x78B4C0", Offset = "0x78A6C0", VA = "0x18078B4C0")]
	public int getCategoryNum()
	{
		return default(int);
	}

	[Token(Token = "0x6000541")]
	[Address(RVA = "0x78B220", Offset = "0x78A420", VA = "0x18078B220")]
	public string[] getCategoryNameList()
	{
		return null;
	}

	[Token(Token = "0x6000542")]
	[Address(RVA = "0x78BF90", Offset = "0x78B190", VA = "0x18078BF90")]
	public int getMasterNum()
	{
		return default(int);
	}

	[Token(Token = "0x6000543")]
	[Address(RVA = "0x78BCF0", Offset = "0x78AEF0", VA = "0x18078BCF0")]
	public string[] getMasterNameList()
	{
		return null;
	}

	[Token(Token = "0x6000544")]
	[Address(RVA = "0x78A9B0", Offset = "0x789BB0", VA = "0x18078A9B0")]
	public int getAudio3DSettingsNum()
	{
		return default(int);
	}

	[Token(Token = "0x6000545")]
	[Address(RVA = "0x78A7A0", Offset = "0x7899A0", VA = "0x18078A7A0")]
	public string[] getAudio3DSettingsNameList()
	{
		return null;
	}

	[Token(Token = "0x6000546")]
	[Address(RVA = "0x794D60", Offset = "0x793F60", VA = "0x180794D60")]
	public void updateUnityMixerName(string labelName, string newMixerName)
	{
	}

	[Token(Token = "0x6000547")]
	[Address(RVA = "0x794C90", Offset = "0x793E90", VA = "0x180794C90")]
	public void updateSpatialGroupName(string labelName, string newGroupName)
	{
	}

	[Token(Token = "0x6000548")]
	[Address(RVA = "0x78B430", Offset = "0x78A630", VA = "0x18078B430")]
	public string getCategoryNameSettingOfLabel(string labelName)
	{
		return null;
	}

	[Token(Token = "0x6000549")]
	[Address(RVA = "0x78BF00", Offset = "0x78B100", VA = "0x18078BF00")]
	public string getMasterNameSettingOfCategory(string categoryName)
	{
		return null;
	}

	[Token(Token = "0x600054A")]
	[Address(RVA = "0x78C100", Offset = "0x78B300", VA = "0x18078C100")]
	public float getPlayTime(int instanceId)
	{
		return default(float);
	}

	[Token(Token = "0x600054B")]
	[Address(RVA = "0x78C070", Offset = "0x78B270", VA = "0x18078C070")]
	public int getPlaySamples(int instanceId)
	{
		return default(int);
	}

	[Token(Token = "0x600054C")]
	[Address(RVA = "0x7935B0", Offset = "0x7927B0", VA = "0x1807935B0")]
	public void setTime(int instanceId, float time)
	{
	}

	[Token(Token = "0x600054D")]
	[Address(RVA = "0x793520", Offset = "0x792720", VA = "0x180793520")]
	public void setTimeSamples(int instanceId, int samples)
	{
	}

	[Token(Token = "0x600054E")]
	[Address(RVA = "0x793000", Offset = "0x792200", VA = "0x180793000")]
	public void setMute(bool onMute)
	{
	}

	[Token(Token = "0x600054F")]
	[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680")]
	public bool getMuteStatus()
	{
		return default(bool);
	}

	[Token(Token = "0x6000550")]
	[Address(RVA = "0x78AC40", Offset = "0x789E40", VA = "0x18078AC40")]
	public string[] getAudioClipNameLoadId(int loadId)
	{
		return null;
	}

	[Token(Token = "0x6000551")]
	[Address(RVA = "0x78AA00", Offset = "0x789C00", VA = "0x18078AA00")]
	public string[] getAudioClipNameAll()
	{
		return null;
	}

	[Token(Token = "0x6000552")]
	[Address(RVA = "0x78AE20", Offset = "0x78A020", VA = "0x18078AE20")]
	public string getAudioClipName(string labelName)
	{
		return null;
	}

	[Token(Token = "0x6000553")]
	[Address(RVA = "0x78AEB0", Offset = "0x78A0B0", VA = "0x18078AEB0")]
	public string[] getAudioClipNames(string labelName)
	{
		return null;
	}

	[Token(Token = "0x6000554")]
	[Address(RVA = "0x78C190", Offset = "0x78B390", VA = "0x18078C190")]
	public string[] getRandomSourceNames(string labelName)
	{
		return null;
	}

	[Token(Token = "0x6000555")]
	[Address(RVA = "0x792A50", Offset = "0x791C50", VA = "0x180792A50")]
	public void setAudioClipToLabelLoadId(int loadId)
	{
	}

	[Token(Token = "0x6000556")]
	[Address(RVA = "0x792890", Offset = "0x791A90", VA = "0x180792890")]
	public void setAudioClipToLabelAll()
	{
	}

	[Token(Token = "0x6000557")]
	[Address(RVA = "0x792C10", Offset = "0x791E10", VA = "0x180792C10")]
	public void setAudioClipToLabel(string labelName)
	{
	}

	[Token(Token = "0x6000558")]
	[Address(RVA = "0x792520", Offset = "0x791720", VA = "0x180792520")]
	public void setAndroidNativeToLabel(string labelName, string filePath, string className, string funcName)
	{
	}

	[Token(Token = "0x6000559")]
	[Address(RVA = "0x78A270", Offset = "0x789470", VA = "0x18078A270")]
	public void clearObjectPool()
	{
	}

	[Token(Token = "0x600055A")]
	[Address(RVA = "0x78B850", Offset = "0x78AA50", VA = "0x18078B850")]
	public float getLabelLength(string labelName)
	{
		return default(float);
	}

	[Token(Token = "0x600055B")]
	[Address(RVA = "0x78BBD0", Offset = "0x78ADD0", VA = "0x18078BBD0")]
	public int getLabelSamples(string labelName)
	{
		return default(int);
	}

	[Token(Token = "0x600055C")]
	[Address(RVA = "0x78C340", Offset = "0x78B540", VA = "0x18078C340")]
	public bool getSpectrumData(int instanceId, float[] sample, int channel, FFTWindow window)
	{
		return default(bool);
	}

	[Token(Token = "0x600055D")]
	[Address(RVA = "0x78C650", Offset = "0x78B850", VA = "0x18078C650")]
	public bool isLoop(string labelName)
	{
		return default(bool);
	}

	[Token(Token = "0x600055E")]
	[Address(RVA = "0x78B8E0", Offset = "0x78AAE0", VA = "0x18078B8E0")]
	public int getLabelMaxPlaybacksNum(string labelName)
	{
		return default(int);
	}

	[Token(Token = "0x600055F")]
	[Address(RVA = "0x78B190", Offset = "0x78A390", VA = "0x18078B190")]
	public int getCategoryMaxPlaybacksNum(string categoryName)
	{
		return default(int);
	}

	[Token(Token = "0x6000560")]
	[Address(RVA = "0x78B0C0", Offset = "0x78A2C0", VA = "0x18078B0C0")]
	public int getCategoryMaxPlaybacksNumFromLabel(string labelName)
	{
		return default(int);
	}

	[Token(Token = "0x6000561")]
	[Address(RVA = "0x78C5C0", Offset = "0x78B7C0", VA = "0x18078C5C0")]
	public bool isInterval(string labelName)
	{
		return default(bool);
	}

	[Token(Token = "0x6000562")]
	[Address(RVA = "0x78B650", Offset = "0x78A850", VA = "0x18078B650")]
	public int getCurrentPlayNum()
	{
		return default(int);
	}

	[Token(Token = "0x6000563")]
	[Address(RVA = "0x788200", Offset = "0x787400", VA = "0x180788200")]
	private void Update()
	{
	}

	[Token(Token = "0x6000564")]
	[Address(RVA = "0x7920B0", Offset = "0x7912B0", VA = "0x1807920B0")]
	private void resetDuckingBeforeUpdate(AudioPlayer player)
	{
	}

	[Token(Token = "0x6000565")]
	[Address(RVA = "0x781930", Offset = "0x780B30", VA = "0x180781930")]
	public static AudioLabelSettings GetLabelInfo_Extention(string name)
	{
		return null;
	}

	[Token(Token = "0x6000566")]
	[Address(RVA = "0x788D40", Offset = "0x787F40", VA = "0x180788D40")]
	public AudioManager()
	{
	}
}
