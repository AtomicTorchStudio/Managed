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
public struct GridLength {

  [MarshalAs(UnmanagedType.I4)]
  private GridUnitType _type;

  [MarshalAs(UnmanagedType.R4)]
  private float _value;

  public GridUnitType GridUnitType {
    get { return this._type; }
  }

  public bool IsAbsolute {
    get { return this._type == GridUnitType.Pixel; }
  }

  public bool IsAuto {
    get { return this._type == GridUnitType.Auto; }
  }

  public bool IsStar {
    get { return this._type == GridUnitType.Star; }
  }

  public double Value {
    get { return this._value; }
  }

  public static GridLength Auto {
    get { return new GridLength(0.0f, GridUnitType.Auto); }
  }

  public GridLength(float pixels) : this(pixels, GridUnitType.Pixel) {
  }

  public GridLength(float value, GridUnitType type) {
    if (float.IsNaN(value)) {
      throw new ArgumentException("Invalid GridLength NaN value");
    }
    if (float.IsInfinity(value)) {
      throw new ArgumentException("Invalid GridLength Infinity value");
    }
    if (type != GridUnitType.Auto && type != GridUnitType.Pixel && type != GridUnitType.Star) {
      throw new ArgumentException("Invalid GridLength unit type");
    }
    this._type = type;
    this._value = type == GridUnitType.Auto ? 0.0f : value;
  }

  public static bool operator==(GridLength l0, GridLength l1) {
    return l0.GridUnitType == l1.GridUnitType && l0.Value == l1.Value;
  }

  public static bool operator!=(GridLength l0, GridLength l1) {
    return !(l0 == l1);
  }

  public override bool Equals(System.Object obj) {
    return obj is GridLength && this == (GridLength)obj;
  }

  public bool Equals(GridLength t) {
    return this == t;
  }

  public override int GetHashCode() {
    return GridUnitType.GetHashCode() ^ Value.GetHashCode();
  }

  public override string ToString() {
    switch (GridUnitType) {
      default:
      case GridUnitType.Auto: {
        return "Auto";
      }
      case GridUnitType.Pixel: {
        return Value.ToString();
      }
      case GridUnitType.Star: {
        if (Math.Abs(Value - 1.0f) < 0.00001f) {
          return "*";
        }
        else {
          return String.Format("{0}*", Value);
        }
      }
    }
  }

  public static GridLength Parse(string str) {
    GridLength len;
    if (GridLength.TryParse(str, out len)) {
      return len;
    }
    throw new ArgumentException("Cannot create GridLength from '" + str + "'");
  }

  public static bool TryParse(string str, out GridLength result) {
    bool ret = NoesisGUI_PINVOKE.GridLength_TryParse(str != null ? str : string.Empty, out result);
    return ret;
  }

}

}

