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
public struct CornerRadius {

  [MarshalAs(UnmanagedType.R4)]
  private float _tl;

  [MarshalAs(UnmanagedType.R4)]
  private float _tr;

  [MarshalAs(UnmanagedType.R4)]
  private float _br;

  [MarshalAs(UnmanagedType.R4)]
  private float _bl;

  public double TopLeft {
    get { return this._tl; }
    set { this._tl = (float)value; }
  }

  public double TopRight {
    get { return this._tr; }
    set { this._tr = (float)value; }
  }

  public double BottomRight {
    get { return this._br; }
    set { this._br = (float)value; }
  }

  public double BottomLeft {
    get { return this._bl; }
    set { this._bl = (float)value; }
  }

  public CornerRadius(float radius) : this(radius, radius, radius, radius) {
  }

  public CornerRadius(float topLeft, float topRight, float bottomRight, float bottomLeft) {
    this._tl = topLeft;
    this._tr = topRight;
    this._br = bottomRight;
    this._bl = bottomLeft;
  }

  public static bool operator==(CornerRadius c0, CornerRadius c1) {
    return
      c0.TopLeft == c1.TopLeft &&
      c0.TopRight == c1.TopRight &&
      c0.BottomRight == c1.BottomRight &&
      c0.BottomLeft == c1.BottomLeft;
  }

  public static bool operator!=(CornerRadius c0, CornerRadius c1) {
    return !(c0 == c1);
  }

  public override bool Equals(Object obj) {
    return obj is CornerRadius && this == (CornerRadius)obj;
  }

  public bool Equals(CornerRadius t) {
    return this == t;
  }

  public override int GetHashCode() {
    return ((TopLeft.GetHashCode() ^ TopRight.GetHashCode()) ^ BottomRight.GetHashCode()) ^ BottomLeft.GetHashCode();
  }

  public override string ToString() {
    if (TopLeft == TopRight && TopLeft == BottomRight && TopLeft == BottomLeft) {
      return String.Format("{0}", TopLeft);
    }
    else {
      return String.Format("{0},{1},{2},{3}", TopLeft, TopRight, BottomRight, BottomLeft);
    }
  }

  public static CornerRadius Parse(string str) {
    CornerRadius cornerRadius;
    if (CornerRadius.TryParse(str, out cornerRadius)) {
      return cornerRadius;
    }
    throw new ArgumentException("Cannot create CornerRadius from '" + str + "'");
  }

  public static bool TryParse(string str, out CornerRadius result) {
    bool ret = NoesisGUI_PINVOKE.CornerRadius_TryParse(str != null ? str : string.Empty, out result);
    return ret;
  }

}

}

