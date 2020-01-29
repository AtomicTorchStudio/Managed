//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


using System;
using System.Runtime.InteropServices;

namespace Noesis
{

[StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
public struct KeyTime {

  [MarshalAs(UnmanagedType.I4)]
  private KeyTimeType _type;
  [MarshalAs(UnmanagedType.R4)]
  private float _percent;
  private TimeSpan _timeSpan;

  public KeyTimeType Type {
    get {
      return this._type;
    }
  }

  public double Percent {
    get {
      if (this._type != KeyTimeType.Percent) {
        throw new InvalidOperationException("KeyTime does not have a percent value");
      }
      return this._percent;
    }
  }

  public TimeSpan TimeSpan {
    get {
      if (this._type != KeyTimeType.TimeSpan) {
        throw new InvalidOperationException("KeyTime does not have a TimeSpan value");
      }
      return this._timeSpan;
    }
  }

  public static KeyTime Uniform {
    get {
      return new KeyTime { _type = KeyTimeType.Uniform };
    }
  }

  public static KeyTime Paced {
    get {
      return new KeyTime { _type = KeyTimeType.Paced };
    }
  }

  public static KeyTime FromPercent(float percent) {
    if (percent < 0.0f || percent > 1.0f) {
      throw new ArgumentException("Invalid percent value for KeyTime");
    }
    return new KeyTime { _type = KeyTimeType.Percent, _percent = percent };
  }

  public static KeyTime FromTimeSpan(TimeSpan timeSpan) {
    if (timeSpan < TimeSpan.Zero) {
      throw new ArgumentException("KeyTime cannot be negative");
    }
    return new KeyTime { _type = KeyTimeType.TimeSpan, _timeSpan = timeSpan };
  }

  public static implicit operator KeyTime(TimeSpan timeSpan) {
    return KeyTime.FromTimeSpan(timeSpan);
  }

  public static bool operator==(KeyTime t0, KeyTime t1) {
    if (t0._type == t1._type) {
      if (t0._type == KeyTimeType.Percent) {
        return t0._percent == t1._percent;
      }
      else if (t0._type == KeyTimeType.TimeSpan) {
        return t0._timeSpan == t1._timeSpan;
      }
      else {
        return true;
      }
    }
    return false;
  }

  public static bool operator!=(KeyTime t0, KeyTime t1) {
    return !(t0 == t1);
  }

  public override bool Equals(System.Object obj) {
    return obj is KeyTime && this == (KeyTime)obj;
  }

  public bool Equals(KeyTime v) {
    return this == v;
  }

  public override int GetHashCode() {
    if (this._type == KeyTimeType.Percent) {
      return this._percent.GetHashCode();
    }
    else if (this._type == KeyTimeType.TimeSpan) {
      return this._timeSpan.GetHashCode();
    }
    else {
      return this._type.GetHashCode();
    }
  }

  public override string ToString() {
    switch (this._type) {
      case KeyTimeType.Percent: return System.String.Format("{0}%", this._percent * 100.0f);
      case KeyTimeType.TimeSpan: return ((System.TimeSpan)this._timeSpan).ToString();
      case KeyTimeType.Paced: return "Paced";
      case KeyTimeType.Uniform: return "Uniform";
      default: return "Uniform";
    }
  }

  public static KeyTime Parse(string str) {
    KeyTime keyTime;
    if (KeyTime.TryParse(str, out keyTime)) {
      return keyTime;
    }
    throw new ArgumentException("Cannot create KeyTime from '" + str + "'");
  }

  public static bool TryParse(string str, out KeyTime result) {
    bool ret = NoesisGUI_PINVOKE.KeyTime_TryParse(str != null ? str : string.Empty, out result);
    return ret;
  }

}

}

